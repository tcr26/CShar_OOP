using NUnit.Framework;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("StarCraft.Tests")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("StarCraft.Tests")]
[assembly: AssemblyCopyright("Copyright ©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("b4287ec4-3514-4316-b975-e125df6376ed")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

//nunit parallel tests settings
[assembly: Timeout(1000000)]
[assembly: Parallelizable(ParallelScope.All)]
[assembly: LevelOfParallelism(2)]