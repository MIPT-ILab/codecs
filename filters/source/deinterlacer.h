/*
 * DeInterlacer.h
 *
 * Deinterlacing plugin for AviSynth
 *
 * For MIPT-Intel lab, Multimedia section.
 * Copyright 2011 Kryukov Pavel.
*/

#ifndef __DEINTERLACER_H_
#define __DEINTERLACER_H_

#include "as_filter.h"

class DeInterlacer : public ASFilter
{
public:
    DeInterlacer(PClip _child, IScriptEnvironment* env);
    PVideoFrame __stdcall GetFrame(int n, IScriptEnvironment* env);
    virtual __stdcall ~DeInterlacer() { }
};

#endif  // __DEINTERLACER_H_
