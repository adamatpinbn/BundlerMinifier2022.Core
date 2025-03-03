// ------------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by Extensibility Tools v1.8.175
// </auto-generated>
// ------------------------------------------------------------------------------
namespace BundlerMinifierVsix
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidBundlerPackageString = "f80c4895-89aa-4958-a5bc-fd4dbc5fd3ec";
        public const string guidBundlerCmdSetString = "98902516-9aed-44fb-93fe-8d17e10fa5e8";
        public static Guid guidBundlerPackage = new Guid(guidBundlerPackageString);
        public static Guid guidBundlerCmdSet = new Guid(guidBundlerCmdSetString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int MyMenu = 0x1000;
        public const int ContextMenuGroup = 0x1020;
        public const int SolExpMenuGroup = 0x1030;
        public const int CommandsMenuGruop = 0x1040;
        public const int SettingsMenuGruop = 0x1041;
        public const int CreateBundleId = 0x0100;
        public const int UpdateBundle = 0x0200;
        public const int BundleOnBuild = 0x0400;
        public const int RemoveBundle = 0x0500;
        public const int UpdateSolution = 0x0600;
        public const int ClearOutputFiles = 0x0700;
        public const int SuppressOutput = 0x0800;
        public const int ConvertToGulp = 0x0900;
        public const int OpenSettings = 0x0950;
    }
}
