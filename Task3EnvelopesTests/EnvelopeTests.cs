using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2Envelopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Envelopes.Tests
{
    [TestClass()]
    public class EnvelopeTests
    {
        [TestMethod()]
        public void CompareToTest()
        {    
            Envelope first = new Envelope(1, 2);
            Envelope second = new Envelope(3, 4);

            Assert.AreEqual(-1, first.CompareTo(second));
            Assert.AreEqual(1, second.CompareTo(first));
            Assert.AreEqual(0, first.CompareTo(first));
        }
    }
}