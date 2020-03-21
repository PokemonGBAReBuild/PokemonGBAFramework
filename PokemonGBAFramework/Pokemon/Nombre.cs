using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon
{
    public class NombrePokemon:BaseElemento
    {
        public new const long ID = BaseElemento.ID+1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<NombrePokemon>();
        public string Nombre { get; set; }

        public override ElementoBinario Serialitzer =>Serializador;

        public override long IdTipo => ID;
    }
}
