using Gabriel.Cat.S.Binaris;
using PokemonGBAFramework.Pokemon.Ataque;
using System;
using System.Collections.Generic;
using System.Text;


namespace PokemonGBAFramework.Batalla
{
    public class NombreClaseEntrenador:BaseElemento
    {
        public new const long ID = Ataque.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<NombreClaseEntrenador>();
        public string Nombre { get; set; }

        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer => Serializador;
    }
}
