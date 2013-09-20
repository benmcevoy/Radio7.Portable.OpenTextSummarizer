using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Radio7.Portable.OpenTextSummarizer.Test
{
    [TestClass]
    public class SummarizerTests
    {
        [TestMethod]
        public void Summarize_When_Assumption_Does_Expectation()
        {
            // Arrange
            var arguments = new SummarizerArguments()
                {
                    InputString = ""
                };

            // Act
            var result = Summarizer.Summarize(arguments);

            // Assert
            Assert.Inconclusive();
        }
    }
}
