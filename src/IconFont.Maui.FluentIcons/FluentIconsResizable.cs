using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Controls.Internals;

namespace IconFont.Maui.FluentIcons;

[Preserve(AllMembers = true)]
public static partial class FluentIconsResizable
{
    static FluentIconsResizable() { }
    // Font alias for resizable font (from IconFontConfigs)
    public static readonly string FontFamily = IconFontConfigs.All.First(x => x.ClassName == "FluentIconsResizable").FontAlias;

    public static FontImageSource Create(string glyph, Color? color = null, double size = 24d)
    {
        return new FontImageSource
        {
            FontFamily = FontFamily,
            Glyph = glyph,
            Color = color ?? Colors.Black,
            Size = size
        };
    }
}
