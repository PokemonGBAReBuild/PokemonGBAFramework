using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework
{
    public class ElementoTienda<T> : IElementoConIdSerializable where T : IElementoConIdSerializable
    {
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<ElementoTienda<T>>();
        public long Id { get; set; }
        public long IdBase { get; set; }
        public string UrlTienda { get; set; }
        public long IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public long Version { get; set; }
        public string Licencia { get; set; }
        public SortedList<long, T> ElementosNuevos { get; set; }
        public SortedList<long, long> ElementosQuitados { get; set; }
        public SortedList<long,T> ElementosEditados { get; set; }
        public SortedList<long,int> Orden { get; set; }
        public virtual ElementoBinario Serialitzer => Serializador;
    }
}
