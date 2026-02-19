[![NuGet](https://img.shields.io/nuget/v/IconFont.Maui.FluentIcons.svg?label=NuGet)](https://www.nuget.org/packages/IconFont.Maui.FluentIcons)

# IconFont.Maui.FluentIcons

`IconFont.Maui.FluentIcons` ships all four [Fluent UI System Icons](https://github.com/microsoft/fluentui-system-icons) TTF icon fonts for .NET MAUI:

| Font | File | Class |
|------|------|-------|
| Regular | `FluentSystemIcons-Regular.ttf` | `FluentIconsRegular` |
| Filled | `FluentSystemIcons-Filled.ttf` | `FluentIconsFilled` |
| Light | `FluentSystemIcons-Light.ttf` | `FluentIconsLight` |
| Resizable | `FluentSystemIcons-Resizable.ttf` | `FluentIconsResizable` |

It registers the fonts across supported targets when you call `UseIconFonts()` (or individual helpers) and exposes strongly-typed glyph constants to simplify XAML and C# usage.

## ✨ Features
- ⚙️ **One-line setup**: call `builder.UseIconFonts()` to register all fonts, or per-font helpers like `UseFluentIcons()`, `UseFluentIconsFilled()`, etc.
- 🔤 **Strongly-typed glyphs** via flat classes: `FluentIconsRegular.Add24`, `FluentIconsFilled.Home24`, etc.
- 🧰 **Helper APIs**: `FluentIcons.Create()` for `FontImageSource`
- 📱 **Supported targets**: Android, iOS, Mac Catalyst, Windows

## 📦 Install
```bash
dotnet add package IconFont.Maui.FluentIcons
```

## 🚀 Getting Started

### Register
```csharp
var builder = MauiApp.CreateBuilder()
    .UseMauiApp<App>()
    .UseIconFonts(); // registers all four font styles
```

Or register individual fonts:
```csharp
builder.UseFluentIconsRegular();   // Regular only
builder.UseFluentIconsFilled();    // Filled only
builder.UseFluentIconsLight();     // Light only
builder.UseFluentIconsResizable(); // Resizable only
```

### XAML usage
```xaml
xmlns:icons="clr-namespace:IconFont.Maui.FluentIcons;assembly=IconFont.Maui.FluentIcons"

<FontImageSource Glyph="{x:Static icons:FluentIconsRegular.Add24}"
                 FontFamily="{x:Static icons:FluentIconsRegular.FontFamily}"
                 Color="#2563EB"
                 Size="32" />
```

### C# usage
```csharp
using IconFont.Maui.FluentIcons;

// Create a FontImageSource for any glyph
var source = FluentIcons.Create(FluentIconsRegular.Add24, Colors.Orange, 32);
```

> **Tip:** Glyph names follow the upstream font. If the font adds/changes glyphs, updating the font file and rebuilding regenerates this API.

## 📋 Styles & Glyphs
The source generator emits flat top-level classes for XAML `{x:Static}` compatibility:

| Class | Example |
|-------|---------|
| `FluentIconsRegular` | `FluentIconsRegular.Add24` |
| `FluentIconsFilled` | `FluentIconsFilled.Home24` |
| `FluentIconsLight` | `FluentIconsLight.Star24` |
| `FluentIconsResizable` | `FluentIconsResizable.Add20` |

## 🧩 Platforms
| Platform | Minimum |
|----------|---------|
| Android  | 21+     |
| iOS      | 15+     |
| macOS    | 12+     |
| Windows  | 10 1809 |

## 📄 License
- **Library:** MIT
- **Font:** MIT (see [license](https://github.com/microsoft/fluentui-system-icons/blob/main/LICENSE))

## 🙏 Attribution
- Upstream font: MIT © Microsoft Corporation
- This project is not affiliated with or endorsed by Microsoft.
