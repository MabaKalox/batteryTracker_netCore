using System.Diagnostics;

namespace BatteryTracker
{
    public static class ShellHelper
    {
        public static (string, string) Bash(this string cmd)
        {
            var escapedArgs = cmd.Replace("\"", "\\\"");

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            process.Start();
            string error = process.StandardError.ReadToEnd();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return (error, result);
        }
    }
}