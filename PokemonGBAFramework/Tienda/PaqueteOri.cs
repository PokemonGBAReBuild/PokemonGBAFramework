using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework
{
   public class PaqueteOri:ElementoTienda<ElementoOri>
    {
        public static new readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<PaqueteOri>();
        public override ElementoBinario Serialitzer =>Serializador;
    }
}
