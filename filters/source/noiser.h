/*
 * noiser.h
 *
 * Noising plugin for AviSynth
 *
 * For MIPT-Intel lab, Multimedia section.
 * Kryukov Pavel, (C) 2011.
*/

#ifndef __NOISER_H_
#define __NOISER_H_

#include <cstdlib>

#include "as_filter.h"

template<bool SALT>
class Noiser : public ASFilter {
    // Level of noising.
    // If random number is greater than level, sets noise
    static const int _level = RAND_MAX >> 2;
    static const unsigned __int32 _noise32;
    static const unsigned __int8  _noise8;

    void Noise8 (unsigned __int8* srcp) const;
    void Noise24(unsigned __int8* srcp) const;
    void Noise32(unsigned __int8* srcp) const;

    void (Noiser::*_noiseFunc)(unsigned __int8* srcp) const;

public:
    // Constructor
    Noiser(PClip _child, IScriptEnvironment* env);

    //Frame getting
    PVideoFrame __stdcall GetFrame(int n, IScriptEnvironment* env);
    
    virtual __stdcall ~Noiser() { }
};

typedef Noiser<true> SaltNoiser;
typedef Noiser<false> PepperNoiser;

template<>
const unsigned __int32 SaltNoiser::_noise32 = 0xFFFFFFF;

template<>
const unsigned __int8 SaltNoiser::_noise8 = 0xFF;

template<>
const unsigned __int32 PepperNoiser::_noise32 = 0;

template<>
const unsigned __int8 PepperNoiser::_noise8 = 0;

template<bool SALT>
Noiser<SALT>::Noiser(PClip _child, IScriptEnvironment* env)
    : ASFilter( _child, env)
    , _noiseFunc(vi.IsYV12() 
        ? &Noiser::Noise8
        : vi.IsRGB24() 
            ? &Noiser::Noise24
            : &Noiser::Noise32)
{ }

template<bool SALT>
void Noiser<SALT>::Noise8(unsigned __int8* srcp) const
{
    for (unsigned h = 0; h < height; h++)
    {
        for (unsigned w = 0; w < width; w++)
            if (rand() < _level)
                *( srcp + w) = _noise8;
        srcp += pitch;
    }
}

template<bool SALT>
void Noiser<SALT>::Noise24(unsigned __int8* srcp) const
{
    const unsigned width_w = width / 3;
    for (unsigned h = 0; h < height; h++)
    {
        for (unsigned w = 0; w < width_w; w++)
            if (rand() > _level) {
                *(srcp + w)     = _noise8;
                 *(srcp + w + 1) = _noise8;
                *(srcp + w + 2) = _noise8;
            }
        srcp += pitch;
    }
}

template<bool SALT>
void Noiser<SALT>::Noise32(unsigned __int8* srcp) const
{
    const unsigned width_w = width >> 2;
    for (unsigned h = 0; h < height; h++)
    {
        for (unsigned w = 0; w < width_w; w++)
            if ( rand() < _level)
                 *((unsigned __int32*)srcp + w) = _noise32;
        srcp += pitch;
    }
}

/*
 * Getting noised frame.
 */
 template<bool SALT>
PVideoFrame __stdcall Noiser<SALT>::GetFrame( int n, IScriptEnvironment* env)
{
    PVideoFrame src = child->GetFrame( n, env);
    env->MakeWritable(&src);
    
    unsigned __int8* srcp = (unsigned __int8*)src->GetReadPtr();

    // Generating random numbers.
    std::srand( (int)srcp);

    (this->*_noiseFunc)(srcp);
    
    return src;
}

#endif //__NOISER_H_
