/*
 * denoiser.cpp
 *
 * DeNoising plugin for AviSynth.
 * Uses 3D median filter algorithm.
 *
 * For MIPT-Intel lab, Multimedia section.
 * Kryukov Pavel, (C) 2011.
*/

#include <boost\thread.hpp>

#include "denoiser.h"

inline unsigned char median(const unsigned char* range, unsigned size, unsigned pos)
{
    unsigned char S[11];
    unsigned sS = 0;

    unsigned char B[11];
    unsigned sB = 0;

    unsigned char base = range[0];

    for (unsigned n = 1; n < size; n++)
        *(range[n] <= base ? (S + sS++) : (B + sB++)) = range[n];

    if (sS == pos)
        return base;

    return (sS < pos) 
        ? median(B, sB, pos - sS - 1)
        : median(S, sS, pos);
}

/*
 * Median filter
 *
 * Collects data from neighbour points in space and neighbour points in previous/next frames.
 */
void DeNoiser::medianFilter( unsigned char* dstp,         // Destination frame pointer
                             const unsigned char* srcp,     // Main frame pointer
                             const unsigned char* srcp1, // Previous frame
                             const unsigned char* srcp2     // Next frame
                            )
{
    // Median buffer
    unsigned char range[11];
    size_t index = 0;

    for ( size_t h = 0; h < height_thread; h++) 
    {
        // Counting vertical size of window (to prevent error readings on edges).
        // If first or last line, 2
        // If not, 3
        const size_t hdim = (!h || (h == height_thread - 1)) ? 2 : 3;

        for ( size_t w = 0; w < width; w++)
        {                  
            // Zeroying of array
            index = 0;
            
            // Setting offset to beginning of window
            size_t rwStart = w < bpp ? w : w - bpp;
            size_t rwFinish = rwStart + (bpp << 1) + (!w || (w >= width - bpp) ? 0 : bpp);

            // Getting window data
            for ( size_t wh = 0; wh < hdim; wh++)
            {
                for ( size_t ww = rwStart; ww < rwFinish; ww += bpp)
                    range[index++] = *( srcp + ww);

                rwStart  += pitch;
                rwFinish += pitch;
            }

            // Getting depth data
            if ( srcp1) range[index++] = *( srcp1 + w);
            if ( srcp2) range[index++] = *( srcp2 + w);
                    
            // Setting value to destination
            *( dstp + w) = median(range, index, index >> 1);
        }
        
        // Set pointers to next line
        dstp += pitch;
        if ( srcp1) srcp1 += pitch;
        if ( srcp2) srcp2 += pitch;
        if ( h > 0) srcp  += pitch;
    }
}

/*
 * Frame generator
 */
PVideoFrame __stdcall DeNoiser::GetFrame( int n, IScriptEnvironment* env)
{    
    // Getting main source frame
    const PVideoFrame src = child->GetFrame( n, env);

    // Getting destination pointer
    PVideoFrame dst = env->NewVideoFrame( vi);

    const unsigned threader = height_thread * pitch;

    boost::thread* threads[cores];
        
    for ( size_t j = 0, offset = 0; j < cores; j++)
    {
        threads[j] = new boost::thread( 
            &DeNoiser::medianFilter, this, 
            dst->GetWritePtr() + offset, 
            src->GetReadPtr()  + offset, 
            n == 0                 ? 0 : child->GetFrame( n - 1, env)->GetReadPtr() + offset, 
            n == vi.num_frames - 1 ? 0 : child->GetFrame( n + 1, env)->GetReadPtr() + offset);
        offset += threader;
    }

    for ( size_t j = 0; j < cores; j++)
    {
        threads[j]->join();
        delete threads[j];
    }

    // Planar YV12 copy
    planarUVCopy(
        dst->GetWritePtr( PLANAR_U), dst->GetWritePtr( PLANAR_V),
        src->GetReadPtr( PLANAR_U),  src->GetReadPtr( PLANAR_V));

    return dst;
}
