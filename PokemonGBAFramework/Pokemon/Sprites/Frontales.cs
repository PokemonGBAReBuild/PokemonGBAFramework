using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon.Sprites
{
    public class Frontales:ImgSprites
    {
        public new const long ID = Traseros.ID+1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Frontales>();

        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
