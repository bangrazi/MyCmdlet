# MyCmdlet
Custom PowerShell cmdlet implemented in C#.

http://www.powershellmagazine.com/2014/03/18/writing-a-powershell-module-in-c-part-1-the-basics/

1. `dotnet add package PowerShellStandard.Library`
1. `Import-Module .\bin\Debug\netstandard2.0\MyCmdlet.dll`
1. `Get-Salutation -Name world,foo`
1. `Remove-Module -Name MyCmdlet`
1. May need to (close and) restart shell to fully drop reference to assembly.
