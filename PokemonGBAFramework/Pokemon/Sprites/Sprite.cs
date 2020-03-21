using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon.Sprites
{
   public class Sprite:BaseElemento
    {
        public new const long ID = PaletaShiny.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Sprite>();
        public Frontales SpritesFrontales
        {
            get;
            set;
        }
        public Traseros SpritesTraseros
        {
            get;
            set;
        }

        public PaletaNormal PaletaNormal
        {
            get;
            set;
        }

        public PaletaShiny PaletaShiny
        {
            get;
            set;
        }

        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer => Serializador;
    }
}
