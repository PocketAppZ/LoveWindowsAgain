using System;
using System.Diagnostics;
using System.IO;

namespace HelperTool
{
    internal class Utils
    {
        public static readonly string TweetIntent = "https://twitter.com/intent/tweet?text=Try%20the%20new%20%23LoveWindowsAgain%20app%20%0a%0ahttps://github.com/builtbybel/LoveWindowsAgain";

        public static class Uri
        {
            public const string URL_ASSEMBLY = "https://raw.githubusercontent.com/builtbybel/LoveWindowsAgain/main/src/TUIX/Properties/AssemblyInfo.cs";
            public const string URL_TWITTER = "https://twitter.com/builtbybel";
            public const string URL_DONATE = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=donate@builtbybel.com&lc=US&item_name=%20Builtbybel&no_note=0&cn=&currency_code=USD&bn=PP-DonationsBF:btn_donateCC_LG.gif:NonHosted";
            public const string URL_GITREPO = "https://github.com/builtbybel/LoveWindowsAgain";
            public const string URL_GITLATEST = URL_GITREPO + "/releases/latest";
        }

        public static class Paths
        {
            public static string SysDir = Path.GetPathRoot(Environment.SystemDirectory);
            public static string LocalAppDataDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            public static string ShellWT = LocalAppDataDir +
                                            @"\Microsoft\WindowsApps\wt.exe";

            public static string ShellCommandPrompt = SysDir +
                                            @"Windows\System32\cmd.exe";

            public static string ShellPS = SysDir +
                                            @"Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
        }

        public static class Data
        {
            public static string BasePath()
            {
                return _FixPath(Environment.CurrentDirectory + "\\" + "app");
            }

            public static string _FixPath(string src)
            {
                if (src.EndsWith("\\"))
                {
                    return src;
                }
                return src + "\\";
            }
        }

        // Create data directory if non present
        public static void CreateDataDir()
        {
            bool dirExists = Directory.Exists(@"app");
            if (!dirExists)
                Directory.CreateDirectory(@"app");
        }

        // Launch Urls in richText control
        public static void LaunchUri(string url)
        {
            if (IsHttpURL(url)) Process.Start(url);
        }

        // Check Urls in in richText control
        public static bool IsHttpURL(string url)
        {
            return
                ((!string.IsNullOrWhiteSpace(url)) &&
                (url.ToLower().StartsWith("http")));
        }
    }
}