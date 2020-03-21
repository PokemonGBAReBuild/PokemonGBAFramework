using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon.Ataque
{
    public class NombreAtaque : BaseElemento
    {
        public new const long ID = DescripcionPokedex.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<NombreAtaque>();
        public string Nombre { get; set; }

        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
