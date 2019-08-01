Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.

' Review the values of the assembly attributes

#If Device = "FM220"
#If InternalFull = "1"
<Assembly: AssemblyTitle("Interop.fm220api InternalFull 20190801")>
#Else
<Assembly: AssemblyTitle("Interop.fm220api Normal 20190801")>
#End If
#ElseIf Device = "FM300"
#If InternalFull = "1"
<Assembly: AssemblyTitle("Interop.fm300api InternalFull 20190801")>
#Else
<Assembly: AssemblyTitle("Interop.fm300api Normal 20190801")>
#End If
#ElseIf Device = "SFC360"
#If InternalFull = "1"
<Assembly: AssemblyTitle("Interop.sfc360api InternalFull 20190801")>
#Else
<Assembly: AssemblyTitle("Interop.sfc360api Normal 20190801")>
#End If
#End If
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("Startek")>
<Assembly: AssemblyProduct("Dll_PC")>
<Assembly: AssemblyCopyright("Copyright 2019")>
<Assembly: AssemblyTrademark("")> 

<Assembly: ComVisible(False)>

'The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("eed785a6-2e77-49a3-a87c-e94b90a56e7d")> 

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' <Assembly: AssemblyVersion("1.0.*")> 

<Assembly: AssemblyVersion("1.0.0.0")> 
<Assembly: AssemblyFileVersion("1.1.0.2")> 
