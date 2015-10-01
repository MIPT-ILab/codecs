/*
 * as_filter.h
 *
 * Universal AviSynth filter header.
 *
 * For MIPT-Intel lab, Multimedia section.
 * Kryukov Pavel, (C) 2011.
*/
#ifndef AS_FILTER
#define AS_FILTER

#include <windows.h>
#include <cstring>

#include <avisynth.h>

class ASFilter: public GenericVideoFilter
{
protected:

    // bites per pixel
    const unsigned short bpp;

    // Frame sizes
    unsigned pitch;
    unsigned width;
    unsigned height;

    unsigned pitchUV;    
    unsigned widthUV;    
    unsigned heightUV;    

    inline void planarUVCopy( unsigned char* dstpU, unsigned char* dstpV, const unsigned char* srcpU, const unsigned char* srcpV)
    {
        if (!vi.IsYV12()) return;
        for ( unsigned h = 0; h < heightUV; h++)
        {
            std::memcpy( dstpU, srcpU, widthUV);
            std::memcpy( dstpV, srcpV, widthUV);

            dstpU += pitchUV;
            dstpV += pitchUV;

            srcpU += pitchUV;
            srcpV += pitchUV;
        }
    }
public:
    inline ASFilter( PClip _child, IScriptEnvironment* env)
        : GenericVideoFilter( _child)
        , bpp( (vi.IsYUY2() || vi.IsRGB32()) 
            ? 4 
            : (vi.IsRGB24() 
                ? 3 
                : 1))
    {
        PVideoFrame src = child->GetFrame( 1, env);

        pitch = src->GetPitch();
        width = src->GetRowSize();
        height = src->GetHeight();

        if (vi.IsYV12())
        {
            pitchUV = src->GetPitch( PLANAR_U);    
            widthUV = src->GetRowSize( PLANAR_U);    
            heightUV = src->GetHeight( PLANAR_U);    
        }
    }

    virtual __stdcall ~ASFilter() { };
};
#endif
