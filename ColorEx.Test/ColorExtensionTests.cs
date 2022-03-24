using NUnit.Framework;
using System.Drawing;
using ColorEx;

namespace ColorEx.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {         
        }

        [Test]
        public void ColorExtensionGetComplimentaryColor()
        {
            Color color = Color.FromArgb(128, 128, 50);
            Color complementary = color.GetComplementaryColor();

            Assert.AreEqual(complementary.A, 255);
            Assert.AreEqual(complementary.R, 50);
            Assert.AreEqual(complementary.G, 50);
            Assert.AreEqual(complementary.B, 128);


            Color secondColor = Color.FromArgb(63, 192, 162);
            Color secondComplementary = secondColor.GetComplementaryColor();

            Assert.AreEqual(secondComplementary.A, 255);
            Assert.AreEqual(secondComplementary.R, 192);
            Assert.AreEqual(secondComplementary.G, 63);
            Assert.AreEqual(secondComplementary.B, 93);
        }

        [Test]
        public void ColorExtensionRemoveRed()
        {
            Color color = Color.FromArgb(255, 255, 255);
            Color noRed = color.RemoveRedChannel();

            Assert.AreEqual(noRed.A, 255);
            Assert.AreEqual(noRed.R, 0);
            Assert.AreEqual(noRed.G, 255);
            Assert.AreEqual(noRed.B, 255);          
        }

        [Test]
        public void ColorExtensionRemoveGreen()
        {
            Color color = Color.FromArgb(255, 255, 255);
            Color noGreen = color.RemoveGreenChannel();

            Assert.AreEqual(noGreen.A, 255);
            Assert.AreEqual(noGreen.R, 255);
            Assert.AreEqual(noGreen.G, 0);
            Assert.AreEqual(noGreen.B, 255);
        }

        [Test]
        public void ColorExtensionRemoveBlue()
        {
            Color color = Color.FromArgb(255, 255, 255);
            Color noBlue = color.RemoveBlueChannel();

            Assert.AreEqual(noBlue.A, 255);
            Assert.AreEqual(noBlue.R, 255);
            Assert.AreEqual(noBlue.G, 255);
            Assert.AreEqual(noBlue.B, 0);
        }
    }
}