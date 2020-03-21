using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon.Ataque
{
    public class DescripcionAtaque : BaseElemento
    {
        public new const long ID = NombreAtaque.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<DescripcionPokedex>();
        public string Descripcion { get; set; }

        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
