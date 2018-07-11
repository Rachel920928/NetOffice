#pragma once

#define WIN32_LEAN_AND_MEAN

#include "targetver.h"
#include <windows.h>
#include <tchar.h>
#include <mscoree.h>

//
// detect 64 bit windows
//
typedef BOOL(WINAPI *LPFN_ISWOW64PROCESS) (HANDLE, PBOOL);
LPFN_ISWOW64PROCESS fnIsWow64Process;


//
// Import Type Libraries
//
#import <mscorlib.tlb>  raw_interfaces_only high_property_prefixes("_get","_put","_putref")  rename("ReportEvent", "MsCorLib_ReportEvent")
#import <msxml6.dll> rename_namespace(_T("MSXML"))

//
// Macros
//
#define IfFalseGo(x) { b=(x); if (FALSE == b) {hr = E_FAIL; goto Error;} }
#define IfFailGo(x) { hr=(x); if (FAILED(hr)) goto Error; }
#define IfNullGo(p) { if(!p) {hr = E_FAIL; goto Error; } }
#define ValidateExtensibilityFail(x) { if(EXTENSIBILITY_FAIL_RESULT != E_NOTIMPL) x = EXTENSIBILITY_FAIL_RESULT; }
#define ShimDebugMessageBox(text, title){if(ENABLE_DEBUG_MESSAGE_BOX){MessageBox(GetDesktopWindow(), text, title, MB_OK);}}
#define DebugOutput(text){OutputDebugString(text);}