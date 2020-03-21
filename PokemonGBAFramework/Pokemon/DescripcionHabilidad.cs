using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon
{
    public class DescripcionHabilidad : BaseElemento
    {
        public new const long ID = Sprites.Sprite.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<DescripcionHabilidad>();
        public string Descripcion { get; set; }

        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
