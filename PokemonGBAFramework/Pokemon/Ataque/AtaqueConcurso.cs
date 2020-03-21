using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon.Ataque
{
    public class AtaqueConcurso : BaseElemento
    {
        public new const long ID = DatosAtaque.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<AtaqueConcurso>();

        public byte[] Datos { get; set; }
        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
