/*
 * denoiser.h
 *
 * DeNoising plugin for AviSynth
 *
 * For MIPT-Intel lab, Multimedia section.
 * Kryukov Pavel, (C) 2011.
*/

#ifndef __DENOISER_H_
#define __DENOISER_H_

#include "as_filter.h"

#define THREAD_POWER 2

class DeNoiser : public ASFilter
{
#if THREAD_POWER
    // Power of cores.
    static const unsigned power = THREAD_POWER;
    static const unsigned cores = 1 << power;
#endif

    const unsigned height_thread;

    // Median filter.
    void medianFilter(unsigned char* dstp,                    // Destination frame pointer
                      const unsigned char* srcp,            // Main frame pointer
                      const unsigned char* srcp1,            // Previous frame
                      const unsigned char* srcp2);           // Next frame
public:
    // Constructor
    DeNoiser( PClip _child, IScriptEnvironment* env)
        : ASFilter( _child, env)
        , height_thread(height >> power)
    { }

    //Frame getting
    PVideoFrame __stdcall GetFrame( int n, IScriptEnvironment* env);
    
    virtual __stdcall ~DeNoiser() { }
};

#endif //__DENOISER_H_
