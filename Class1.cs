using System;
using System.Management.Automation;

// http://www.powershellmagazine.com/2014/03/18/writing-a-powershell-module-in-c-part-1-the-basics/
// dotnet add package PowerShellStandard.Library
// Import-Module -Path .\bin\Debug\netstandard2.0\MyCmdlet.dll
// Get-Salutation -Name world,foo
// Remove-Module -Name MyCmdlet

namespace MyCmdlet
{
    [Cmdlet(VerbsCommon.Get, "Salutation")]
    public class Class1 : PSCmdlet
    {
        private string[] nameCollection;

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true,
            Position = 0,
            HelpMessage = "Name to get salutation for."
        )]
        public string[] Name {
            get { return nameCollection; }
            set { nameCollection = value; }
        }

        [Parameter()]
        public string Greeting {
            get => _Greeting;
            set => _Greeting = value;
        }
        private string _Greeting = "Hello";

        protected override void ProcessRecord() {
            foreach(string name in nameCollection) {
                WriteVerbose($"Creating salutation for {name}");
                string salutation = $"{Greeting} {name}";
                WriteObject(salutation);
            }
        }
    }
}
