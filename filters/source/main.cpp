/*
 * main.cpp
 *
 * AviSynth plugin DLL exports
 *
 * For MIPT-Intel lab, Multimedia section.
 * Kryukov Pavel, (C) 2011.
*/

#include "./deinterlacer.h"
#include "./denoiser.h"
#include "./noiser.h"

template<typename ASFilterType>
AVSValue __cdecl Create(AVSValue args, void*, IScriptEnvironment* env) 
{
    return new ASFilterType(args[0].AsClip(), env);  
}

extern "C" __declspec(dllexport)
const char* __stdcall AvisynthPluginInit2(IScriptEnvironment* env) 
{
    env->AddFunction("DeInterlacer", "c", Create<DeInterlacer>, 0);
    env->AddFunction("DeNoiser"    , "c", Create<DeNoiser>    , 0);
    env->AddFunction("SaltNoiser"  , "c", Create<SaltNoiser>  , 0);
    env->AddFunction("PepperNoiser", "c", Create<PepperNoiser>, 0);
    return "`Kryukov' Kryukov plugin";
}
