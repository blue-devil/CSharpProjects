//DllMain Header
//

#ifndef _SYSINFO_H
#define _SYSINFO_H

#include <Windows.h>

extern "C" __declspec(dllexport) int __stdcall getCPUModel();
extern "C" __declspec(dllexport) int __stdcall calcHexNot(int opOne);			//__stdcall argüman almýyor ya da sadece 1 tane alabiliyor
extern "C" __declspec(dllexport) int __cdecl calcHexAnd(int opOne, int opTwo);
extern "C" __declspec(dllexport) int __cdecl calcHexOr(int opOne, int opTwo);
extern "C" __declspec(dllexport) int __cdecl calcHexXor(int opOne, int opTwo);	//__cdecl 2 arguman alabiliyor

#endif

//yapýlacaklar :calling conventions ile ilgili yazý hazýrla