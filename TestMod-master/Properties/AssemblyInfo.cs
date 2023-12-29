using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(ExtendFOV.BuildInfo.Description)]
[assembly: AssemblyDescription(ExtendFOV.BuildInfo.Description)]
[assembly: AssemblyCompany(ExtendFOV.BuildInfo.Company)]
[assembly: AssemblyProduct(ExtendFOV.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + ExtendFOV.BuildInfo.Author)]
[assembly: AssemblyTrademark(ExtendFOV.BuildInfo.Company)]
[assembly: AssemblyVersion(ExtendFOV.BuildInfo.Version)]
[assembly: AssemblyFileVersion(ExtendFOV.BuildInfo.Version)]
[assembly: MelonInfo(typeof(ExtendFOV.ExtendFOV), ExtendFOV.BuildInfo.Name, ExtendFOV.BuildInfo.Version, ExtendFOV.BuildInfo.Author, ExtendFOV.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]