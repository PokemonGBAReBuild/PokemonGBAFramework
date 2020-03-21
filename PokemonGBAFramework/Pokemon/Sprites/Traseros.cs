using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon.Sprites
{
    public class Traseros:ImgSprites
    {
        public new const long ID = NombreTipo.ID+1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Traseros>();

        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
