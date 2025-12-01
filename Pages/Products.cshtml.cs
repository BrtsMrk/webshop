using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebShop.Pages;

public class ProductsModel : PageModel
{
    public IReadOnlyList<ProductCategory> Categories { get; private set; } = Array.Empty<ProductCategory>();

    public void OnGet()
    {
        Categories = new List<ProductCategory>
        {
            new(
                Key: "polok",
                Name: "Pólók",
                Badge: "Street kollekció",
                Description: "Minimalista grafikák, organikus pamut alapanyag és könnyen variálható színállások.",
                Items: new List<ProductItem>
                {
                    new("Neon Nova", "Vibráló logóprint, lézer vágott label.", "14 900 Ft", "Limitált grafika", new [] {"100% organikus pamut", "Szellőző varrás", "Unisex szabás"}),
                    new("Urban Flow", "Sötét alapon finom neon díszítés, puha fogású alapanyag.", "16 500 Ft", "Városi minimal", new [] {"Előmosott kényelem", "Rejtett zseb", "Gépben mosható"}),
                    new("Solar Fade", "Naplemente gradient print, könnyű súly.", "15 200 Ft", "Pasztell limit", new [] {"OEKO-TEX tanúsítvány", "Lapos nyakpánt", "Maradékmentes csomagolás"})
                }
            ),
            new(
                Key: "sapkas",
                Name: "Baseball sapkák",
                Badge: "Hat széria",
                Description: "Ívelt és flat visor modellek, mágneses zárral és mikroszálas izzadságsávval.",
                Items: new List<ProductItem>
                {
                    new("Night Runner", "Fényvisszaverő logó, mély korona, strapback zár.", "12 400 Ft", "Futóbarát", new [] {"UV szűrő anyag", "Hálós betét", "Állítható pánt"}),
                    new("Crestline", "Hímzett crest, tónusos színek, flat visor.", "11 900 Ft", "Signature", new [] {"Prémium twill", "Rejtett címke", "Formázott panel"}),
                    new("Arcade", "Retro gaming inspiráció, neon varrás.", "13 200 Ft", "Retro drop", new [] {"Flex fit", "Antibakteriális szalag", "Gyors száradás"})
                }
            ),
            new(
                Key: "napszemuvegek",
                Name: "Napszemüvegek",
                Badge: "Optics",
                Description: "Polarizált lencsék, rozsdamentes zsanérok és karcálló bevonat.",
                Items: new List<ProductItem>
                {
                    new("Prism Air", "Ultra könnyű keret, soft touch bevonat.", "21 900 Ft", "Polarizált", new [] {"UV400 védelem", "Csúszásmentes orrtámasz", "Törlőkendővel"}),
                    new("Azure Tide", "Kék tükrös lencse, ívelt karok.", "24 500 Ft", "Parti kedvenc", new [] {"Scratch guard", "Rugós zsanér", "Utazó tok"}),
                    new("Monochrome", "Matte fekete, minimalista szár logó.", "19 800 Ft", "Essential", new [] {"Könnyű acél", "Polarizált lencse", "All-day comfort"})
                }
            ),
            new(
                Key: "kiegeszitok",
                Name: "Kiegészítők",
                Badge: "Accessory line",
                Description: "Táskák, kulacsok és technikai kiegészítők, amelyek illenek a kollekcióhoz.",
                Items: new List<ProductItem>
                {
                    new("Transit Tote", "Erősített vászon, mágneses zárás.", "17 400 Ft", "Városi", new [] {"Belső laptop zseb", "Vízlepergető", "Párnázott pánt"}),
                    new("Pulse Kulacs", "Duplafalú acél, 750 ml.", "8 900 Ft", "Hőtartó", new [] {"Szivárgásmentes kupak", "Sport betét", "Matt felület"}),
                    new("Signal Tech", "Kábelrendező és mini powerbank egyben.", "12 700 Ft", "Tech pack", new [] {"USB-C gyors töltés", "Csúszásmentes tok", "Moduláris belső"})
                }
            )
        };
    }

    public record ProductCategory(string Key, string Name, string Badge, string Description, IReadOnlyList<ProductItem> Items);
    public record ProductItem(string Name, string Description, string Price, string Tagline, IReadOnlyList<string> Features);
}
