using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QtpTests1
{
    public class TestBase
    {
        [TestInitialize]

        public static void Initialize()
        {
            Browser.Initialize();
        }

        [TestCleanup]

        public static void Cleanup()
        {
            Browser.Close();
        }
    }
}
