// dllmain.cpp : Defines the entry point for the DLL application.
#include "dllmain.h"

//c++'da uygulama yazarken entrypoint olarak "WinMain" �a��r�rd�k
//bunun dll versiyonu ise DllMain:

BOOL APIENTRY DllMain( HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
	break;
	}
	return TRUE;
}

extern "C" __declspec(dllexport) int __stdcall calcHexNot(int opOne) {
	int retVal;			//fonsiyondan d�necek de�eri buna ataca��m

	__asm {				//bu etiket aras�na assembly g�mebiliyorum
		mov eax, opOne
		not eax			//NOT
		mov retVal, eax
	}

	return (retVal);		//de�eri d�nd�r�yorum
}

extern "C" __declspec(dllexport) int __cdecl calcHexAnd(int opOne, int opTwo) {
	int retVal;
	__asm {
		mov eax, opOne
			mov edx, opTwo
			and eax, edx	//AND
			mov retVal, eax
	}
	return(retVal);
}

extern "C" __declspec(dllexport) int __cdecl calcHexOr(int opOne, int opTwo) {
	int retVal;
	__asm {
		mov eax, opOne
			mov edx, opTwo
			or eax, edx	//OR
			mov retVal,eax
	}
	return(retVal);
}

extern "C" __declspec(dllexport) int __cdecl calcHexXor(int opOne, int opTwo) {
	int retVal;

	__asm {
		mov eax, opOne
		mov edx, opTwo
		xor eax, edx		//XOR
		mov retVal,eax
	}
	return(retVal);
}