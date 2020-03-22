using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PokemonGBAFramework.Batalla
{
    public class SpriteClaseEntrenador : BaseElemento
    {
        public new const long ID = RateMoneyClaseEntrenador.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<SpriteClaseEntrenador>();
        public Bitmap Imagen { get; set; }

        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer => Serializador;
    }
}
