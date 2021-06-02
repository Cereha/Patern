using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patern;
using System;

namespace UnitTestPatern
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Tedy = new SoftGirder("Black", "small", "TedyBear", 400);
            var result = Tedy.ShallowCopy();
            Assert.AreEqual(result.Color, Tedy.Color);
            Assert.AreEqual(result.Size, Tedy.Size);
            Assert.AreEqual(result.Name, Tedy.Name);
            Assert.AreEqual(result.Price, Tedy.Price);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var Fox = new SoftGirder("White", "XXL", "Julik", 5000);
            var result = Fox.Clone();
            Assert.AreEqual(result.Color, Fox.Color);
            Assert.AreEqual(result.Size, Fox.Size);
            Assert.AreEqual(result.Name, Fox.Name);
            Assert.AreEqual(result.Price, Fox.Price);
        }
    }
}
