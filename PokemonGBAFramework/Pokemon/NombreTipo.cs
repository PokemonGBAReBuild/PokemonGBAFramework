using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon
{
    class NombreTipo : BaseElemento
    {
        public new const long ID = HuellaPokemon.ID+1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<NombreTipo>();
        public string Nombre { get; set; }

        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
