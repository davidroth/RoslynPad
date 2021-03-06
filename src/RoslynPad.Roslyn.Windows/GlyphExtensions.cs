using System.Windows;
using System.Windows.Media;
using RoslynPad.Roslyn.Completion;

namespace RoslynPad.Roslyn
{
    public static class GlyphExtensions
    {
        public static ImageSource ToImageSource(this Glyph glyph)
        {
            return Application.Current.TryFindResource(glyph) as ImageSource;
        }
    }
}