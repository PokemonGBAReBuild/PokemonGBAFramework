using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Batalla
{
   public class RateMoneyClaseEntrenador : BaseElemento
    {
        public new const long ID = NombreClaseEntrenador.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<RateMoneyClaseEntrenador>();
        public int Rate { get; set; }

        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer => Serializador;
    }
}
