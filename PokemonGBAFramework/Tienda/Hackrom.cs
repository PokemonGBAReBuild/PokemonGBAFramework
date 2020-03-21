using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework
{
   public class Hackrom:ElementoTienda<Paquete>
    {
        public static new readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Hackrom>();
        public string IdTrailerYoutube { get; set; }
        public string UrlPoster { get; set; }
      
        public override ElementoBinario Serialitzer => Serializador;
    }
}
