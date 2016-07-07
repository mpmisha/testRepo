using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AutoGit
{
    public class Program
    {
        public static void Main()
        {
            RunAutoGit();
        }

        public static void RunAutoGit()
        {
            Process cmd = new Process();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();
            cmd.StandardInput.WriteLine("dir");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            var x = cmd.StandardOutput.ReadToEnd();
            Console.WriteLine(x);
        }
    }
}
