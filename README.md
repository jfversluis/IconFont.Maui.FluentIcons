[![NuGet](https://img.shields.io/nuget/v/IconFont.Maui.FluentIcons.svg?label=NuGet)](https://www.nuget.org/packages/IconFont.Maui.FluentIcons)

# IconFont.Maui.FluentIcons

`IconFont.Maui.FluentIcons` ships the `FluentSystemIcons-Regular.ttf` icon font for .NET MAUI. It registers the font across supported targets when you call `UseFluentIcons()` and exposes strongly-typed glyph constants via `FluentIcons` to simplify XAML and C# usage.

## ✨ Features
- ⚙️ **One-line setup**: call `builder.UseFluentIcons()` (generated) in `MauiProgram`
- ➕ **Multiple fonts**: use `builder.UseIconFonts()` to register all, or per-font helpers like `UseFluentIconsFilled()`
- 🔤 **Strongly-typed glyphs** via `FluentIcons.Regular.*` (and other styles if present)
- 🧰 **Helper APIs**: `FluentIcons.Create()` for `FontImageSource`
- 📱 **Supported targets**: Android, iOS, Mac Catalyst, Windows

## 📦 Install
```bash
dotnet add package IconFont.Maui.FluentIcons
```

Add the registration in `MauiProgram`:

```csharp
var builder = MauiApp.CreateBuilder()
    .UseMauiApp<App>()
    .UseFluentIcons(); // generated helper
```

## 🚀 Getting Started

### Register
```csharp
var builder = MauiApp.CreateBuilder()
    .UseMauiApp<App>()
    .UseFluentIcons();
```

### XAML usage
```xaml
xmlns:icons="clr-namespace:IconFont.Maui.FluentIcons;assembly=IconFont.Maui.FluentIcons"

<FontImageSource Glyph="{x:Static icons:FluentIcons.Regular.Add24}"
                 FontFamily="{x:Static icons:FluentIcons.FontFamily}"
                 Color="#2563EB"
                 Size="32" />
```

### C# usage
```csharp
using IconFont.Maui.FluentIcons;

// Create a FontImageSource for any glyph
var source = FluentIcons.Create(FluentIcons.Regular.Add24, Colors.Orange, 32);
```

> **Tip:** Glyph names follow the upstream font. If the font adds/changes glyphs, updating the TTF and rebuilding regenerates this API.

## 📋 Styles & glyphs
The default generator emits one class per style (e.g., `Regular`, `Filled`). Example members:

- `FluentIcons.Regular.Add24`
- `FluentIcons.Filled.Home24`

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
