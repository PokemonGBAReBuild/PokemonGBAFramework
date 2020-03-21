using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon
{
   public class OrdenNacional : BaseElemento
    {
        public new const long ID = OrdenLocal.ID+1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<OrdenNacional>();
        public int Orden { get; set; }
        public override ElementoBinario Serialitzer => Serializador;
        public override long IdTipo => ID;


    }
}
