using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework
{
    public class Paquete : ElementoTienda<Elemento>
    {
        public static new readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Paquete>();

        public override ElementoBinario Serialitzer => Serializador;
    }
}
