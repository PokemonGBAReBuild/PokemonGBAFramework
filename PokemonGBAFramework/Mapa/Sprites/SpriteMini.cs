using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PokemonGBAFramework.Mapa.Sprites
{
    public class SpriteMini : BaseElemento
    {
        public new const long ID = PaletaMini.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<SpriteMini>();

        public Bitmap[] Minis { get; set; }
        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer => Serializador;
    }
}
