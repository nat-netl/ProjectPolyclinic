using PdfSharp.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories.Implementations;

public class CustomFontResolver : IFontResolver
{
    public string DefaultFontName => "Arial";

    public byte[] GetFont(string faceName)
    {
        string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Шрифт", $"{faceName}.ttf");

        if (!File.Exists(fontPath))
        {
            throw new FileNotFoundException($"Файл не найден: {fontPath}");
        }

        using (var ms = new MemoryStream())
        {
            using (var fs = File.Open(fontPath, FileMode.Open))
            {
                fs.CopyTo(ms);
                ms.Position = 0;
                return ms.ToArray();
            }
        }
    }

    public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
    {
        if (familyName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
        {
            return new FontResolverInfo("Arial");
        }
        else if (isBold)
        {
            return new FontResolverInfo("Arial");
        }
        else if (isItalic)
        {
            return new FontResolverInfo("Arial");
        }
        else
        {
            return new FontResolverInfo("Arial");
        }
    }
}