@echo off

if "%1"=="gcc" (
    echo Building as_kryukov.dll with gcc
    g++ ./source/*.cpp -Wall -Werror -O3 -std=c++98 -pedantic -DBOOST_THREAD_USE_LIB -lboost_thread-mgw46-mt-1_47 --shared -Wl,--subsystem,windows -o ./bin/as_kryukov.dll
) else (
    echo Building as_kryukov.dll with MSVC
    cl /nologo /D_USRDLL /D_WINDLL /O2 /Ox /W4 /MD .\source\*.cpp /link /DLL /out:"bin\as_kryukov.dll"
    del *.obj
)
