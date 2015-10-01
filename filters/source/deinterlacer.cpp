/*
 * DeInterlacer.cpp
 *
 * Deinterlacing plugin for AviSynth.
 * Uses different algorithms.
 *
 * For MIPT-Intel lab, Multimedia section.
 * Copyright 2011 Kryukov Pavel.
*/

#include "./deinterlacer.h"

/*
 * Constructor
 */
DeInterlacer::DeInterlacer(PClip _child, IScriptEnvironment* env)
    : ASFilter(_child, env)
{
    // Doubling FPS and number of frames
    vi.num_frames = vi.num_frames << 1;
    vi.SetFPS(vi.fps_numerator << 1, vi.fps_denominator);
}

/*
 * Frame generator
 */
PVideoFrame __stdcall DeInterlacer::GetFrame(int n, IScriptEnvironment* env)
{
    // Two frames are linked to one base, so we use division by two.
    PVideoFrame src = child->GetFrame((n >> 1), env);
    env->MakeWritable(&src);

    // Directed offsets (if from to bottom, +, otherwise -)
    signed pitchT = pitch;

    unsigned char* srcp = (unsigned char*)src->GetReadPtr();

    // Inverting if odd.
    if (n & 1)
    {
        srcp += height * pitch - pitch;
        pitchT = -pitchT;
    }

    unsigned doublePitch = pitchT * 2;

    unsigned char* srcp1 = srcp;
    unsigned char* srcp2 = srcp + doublePitch;
    srcp += pitchT;

    unsigned line = doublePitch - width;

    // Copying rows (without last pair).
    unsigned lines = (height >> 1) - 1;
    for (unsigned h = 0; h < lines; h++)
    {
        // Row based on two similar
        for (unsigned w = 0; w < width; w++)
            *(srcp++) = (*(srcp1++) >> 1) + (*(srcp2++) >> 1);

        srcp  += line;
        srcp1 += line;
        srcp2 += line;
    }

    std::memcpy(srcp, srcp1, width);

    return src;
}
