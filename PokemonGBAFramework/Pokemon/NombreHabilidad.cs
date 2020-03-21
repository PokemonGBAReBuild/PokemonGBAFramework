using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon
{
    public class NombreHabilidad : BaseElemento
    {
        public new const long ID = DescripcionHabilidad.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<NombreHabilidad>();
        public string Nombre { get; set; }

        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
