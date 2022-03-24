using System;
using System.Drawing;
using System.Linq;

namespace ColorEx
{
    /// <summary>
    /// A Color extension class expanding the capabilities of System.Drawing.Color.
    /// </summary>
    public static class ColorExtension
    {
        /// <summary>
        /// Returns the complementary color.
        /// </summary>
        /// <param name="color">The color to get complementary color from.</param>
        /// <returns>The complementary color.</returns>
        public static Color GetComplementaryColor(this Color color)
        {
            byte[] bytes = new byte[3] { color.R, color.G, color.B };
            int calc = bytes.Max() + bytes.Min();
            return Color.FromArgb(color.A, calc - color.R, calc - color.G, calc - color.B);
        }

        /// <summary>
        /// Removes the red channel from the color.
        /// </summary>
        /// <param name="color">The color to remove the red channel from.</param>
        /// <returns>The color with the red channel removed.</returns>
        public static Color RemoveRedChannel(this Color color)
        {
            return Color.FromArgb(color.A, 0, color.G, color.B);
        }

        /// <summary>
        /// Removes the green channel from the color.
        /// </summary>
        /// <param name="color">The color to remove the green channel from.</param>
        /// <returns>The color with the green channel removed.</returns>
        public static Color RemoveGreenChannel(this Color color)
        {
            return Color.FromArgb(color.A, color.R, 0, color.B);
        }

        /// <summary>
        /// Removes the blue channel from the color.
        /// </summary>
        /// <param name="color">The color to remove the blue channel from.</param>
        /// <returns>The color with the blue channel removed.</returns>
        public static Color RemoveBlueChannel(this Color color)
        {
            return Color.FromArgb(color.A, color.R, color.G, 0);
        }

        /// <summary>
        /// Removes the alpha channel from the color.
        /// </summary>
        /// <param name="color">The color to remove the alpha channel from.</param>
        /// <returns>The color with the alpha channel removed.</returns>
        public static Color RemoveAlphaChannel(this Color color)
        {
            return Color.FromArgb(0, color.R, color.G, color.B);
        }
    }
}
