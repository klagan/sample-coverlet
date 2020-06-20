using System;

namespace Sample.Runner
{
    using Library;

    class Program
    {
        static void Main(
            string[] args
        )
        {
            var lib = new MyLib();

            var a = lib.Test();
            var b = lib.Test2();
            
            Console.WriteLine($"Test call 1 => {a}");
            Console.WriteLine($"Test call 2 => {b}");
            
        }
    }
}

// dotnet new tool-manifest
// dotnet tool install dotnet-reportgenerator-globaltool
// add coverlet.msbuild package
// add Microsoft.Net.Test.Sdk
// MSYS2_ARG_CONV_EXCL="*" dotnet test --no-build --configuration Release /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=./TestResults/Coverage/
// dotnet test --no-build --configuration Release /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=./TestResults/Coverage/

// dotnet test --no-build --configuration Debug /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=./TestResults/Coverage/ /p:Threshold=50 /p:ThresholdType=line /p:ThresholdStat=Total
