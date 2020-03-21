using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon
{
   public class Habilidad:BaseElemento
    {
        public new const long ID = NombreHabilidad.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Habilidad>();

        public NombreHabilidad Nombre { get; set; }
        public DescripcionHabilidad Descripcion { get; set; }

        public override long IdTipo => ID;
        public override ElementoBinario Serialitzer => Serializador;
    }
}
