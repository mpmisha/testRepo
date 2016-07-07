using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoGit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGit.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void RunAutoGitTest()
        {
            AutoGit.Program.RunAutoGit();
        }
    }
}