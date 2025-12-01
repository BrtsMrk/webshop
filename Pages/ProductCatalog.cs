using System;
using System.Collections.Generic;
using System.Linq;

namespace WebShop.Pages;

public static class ProductCatalog
{
    public static IReadOnlyList<ProductCategory> GetCategories() => new List<ProductCategory>
    {
        new(
            Key: "polok",
            Name: "Pólók",
            Badge: "Street kollekció",
            Description: "Minimalista grafikák, organikus pamut alapanyag és könnyen variálható színállások.",
            Items: new List<ProductItem>
            {
                new(
                    "neon-nova",
                    "Neon Nova",
                    "Vibráló logóprint, lézer vágott label.",
                    "14 900 Ft",
                    "Limitált grafika",
                    new[] { "100% organikus pamut", "Szellőző varrás", "Unisex szabás" },
                    "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?auto=format&fit=crop&w=900&q=80"
                ),
                new(
                    "urban-flow",
                    "Urban Flow",
                    "Sötét alapon finom neon díszítés, puha fogású alapanyag.",
                    "16 500 Ft",
                    "Városi minimal",
                    new[] { "Előmosott kényelem", "Rejtett zseb", "Gépben mosható" },
                    "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?auto=format&fit=crop&w=900&q=80"
                ),
                new(
                    "solar-fade",
                    "Solar Fade",
                    "Naplemente gradient print, könnyű súly.",
                    "15 200 Ft",
                    "Pasztell limit",
                    new[] { "OEKO-TEX tanúsítvány", "Lapos nyakpánt", "Maradékmentes csomagolás" },
                    "https://images.unsplash.com/photo-1524504388940-b1c1722653e1?auto=format&fit=crop&w=900&q=80"
                )
            }
        ),
        new(
            Key: "sapkas",
            Name: "Baseball sapkák",
            Badge: "Hat széria",
            Description: "Ívelt és flat visor modellek, mágneses zárral és mikroszálas izzadságsávval.",
            Items: new List<ProductItem>
            {
                new(
                    "night-runner",
                    "Night Runner",
                    "Fényvisszaverő logó, mély korona, strapback zár.",
                    "12 400 Ft",
                    "Futóbarát",
                    new[] { "UV szűrő anyag", "Hálós betét", "Állítható pánt" },
                    "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?auto=format&fit=crop&w=900&q=80&sat=-30"
                ),
                new(
                    "crestline",
                    "Crestline",
                    "Hímzett crest, tónusos színek, flat visor.",
                    "11 900 Ft",
                    "Signature",
                    new[] { "Prémium twill", "Rejtett címke", "Formázott panel" },
                    "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?auto=format&fit=crop&w=900&q=80&sat=-30"
                ),
                new(
                    "arcade",
                    "Arcade",
                    "Retro gaming inspiráció, neon varrás.",
                    "13 200 Ft",
                    "Retro drop",
                    new[] { "Flex fit", "Antibakteriális szalag", "Gyors száradás" },
                    "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?auto=format&fit=crop&w=900&q=80&sat=20"
                )
            }
        ),
        new(
            Key: "napszemuvegek",
            Name: "Napszemüvegek",
            Badge: "Optics",
            Description: "Polarizált lencsék, rozsdamentes zsanérok és karcálló bevonat.",
            Items: new List<ProductItem>
            {
                new(
                    "prism-air",
                    "Prism Air",
                    "Ultra könnyű keret, soft touch bevonat.",
                    "21 900 Ft",
                    "Polarizált",
                    new[] { "UV400 védelem", "Csúszásmentes orrtámasz", "Törlőkendővel" },
                    "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?auto=format&fit=crop&w=900&q=80&sat=-30"
                ),
                new(
                    "azure-tide",
                    "Azure Tide",
                    "Kék tükrös lencse, ívelt karok.",
                    "24 500 Ft",
                    "Parti kedvenc",
                    new[] { "Scratch guard", "Rugós zsanér", "Utazó tok" },
                    "https://images.unsplash.com/photo-1491553895911-0055eca6402d?auto=format&fit=crop&w=900&q=80"
                ),
                new(
                    "monochrome",
                    "Monochrome",
                    "Matte fekete, minimalista szár logó.",
                    "19 800 Ft",
                    "Essential",
                    new[] { "Könnyű acél", "Polarizált lencse", "All-day comfort" },
                    "https://images.unsplash.com/photo-1503341455253-b2e723bb3dbb?auto=format&fit=crop&w=900&q=80"
                )
            }
        ),
        new(
            Key: "kiegeszitok",
            Name: "Kiegészítők",
            Badge: "Accessory line",
            Description: "Táskák, kulacsok és technikai kiegészítők, amelyek illenek a kollekcióhoz.",
            Items: new List<ProductItem>
            {
                new(
                    "transit-tote",
                    "Transit Tote",
                    "Erősített vászon, mágneses zárás.",
                    "17 400 Ft",
                    "Városi",
                    new[] { "Belső laptop zseb", "Vízlepergető", "Párnázott pánt" },
                    "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?auto=format&fit=crop&w=900&q=80"
                ),
                new(
                    "pulse-kulacs",
                    "Pulse Kulacs",
                    "Duplafalú acél, 750 ml.",
                    "8 900 Ft",
                    "Hőtartó",
                    new[] { "Szivárgásmentes kupak", "Sport betét", "Matt felület" },
                    "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?auto=format&fit=crop&w=900&q=80"
                ),
                new(
                    "signal-tech",
                    "Signal Tech",
                    "Kábelrendező és mini powerbank egyben.",
                    "12 700 Ft",
                    "Tech pack",
                    new[] { "USB-C gyorstöltés", "Csúszásmentes tok", "Moduláris belső" },
                    "https://images.unsplash.com/photo-1523381294911-8d3cead13475?auto=format&fit=crop&w=900&q=80"
                )
            }
        )
    };

    public static (ProductCategory category, ProductItem item)? FindProduct(string categoryKey, string productSlug)
    {
        var category = GetCategories().FirstOrDefault(c => string.Equals(c.Key, categoryKey, StringComparison.OrdinalIgnoreCase));
        if (category is null)
        {
            return null;
        }

        var product = category.Items.FirstOrDefault(i => string.Equals(i.Slug, productSlug, StringComparison.OrdinalIgnoreCase));
        return product is null ? null : (category, product);
    }
}

public record ProductCategory(string Key, string Name, string Badge, string Description, IReadOnlyList<ProductItem> Items);
public record ProductItem(string Slug, string Name, string Description, string Price, string Tagline, IReadOnlyList<string> Features, string ImageUrl);
