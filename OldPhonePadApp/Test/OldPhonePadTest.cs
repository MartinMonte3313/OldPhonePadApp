using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OldPhonePadApp.Model;

namespace OldPhonePadApp.Test
{
    internal class OldPhonePadTest
    {
        [Theory]
        [InlineData("222 666 6660", "COO ")]
        [InlineData("4433555 555666096667775553", "HELLO WORLD")]
        [InlineData("8*88", "U")]
        [InlineData("#123", "")]
        [InlineData("0000", "   ")]
        public void Decode_ShouldReturnExpectedText(string input, string expected)
        {
            var pad = new OldPhonePad();
            var result = pad.OldPhonePadFunction(input);
            Assert.Equal(expected, result);
        }
    }
}
