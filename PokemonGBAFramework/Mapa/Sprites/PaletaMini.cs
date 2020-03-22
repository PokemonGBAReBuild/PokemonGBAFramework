using Gabriel.Cat.S.Binaris;
using PokemonGBAFramework.Batalla;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PokemonGBAFramework.Mapa.Sprites
{
    public class PaletaMini : BaseElemento
    {
        public new const long ID = ClaseEntrenador.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<PaletaMini>();

        public Color[] Paleta { get; set; }
        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer => Serializador;
    }
}
