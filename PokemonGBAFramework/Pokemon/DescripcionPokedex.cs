using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon
{
    public class DescripcionPokedex : BaseElemento
    {
        public new const long ID = Habilidad.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<DescripcionPokedex>();

        /// <summary>
        /// Medida en Kg
        /// </summary>
        public float Peso { get; set; }
        /// <summary>
        /// Medida en metros
        /// </summary>
        public float Altura { get; set; }

        public int EscalaPokemon { get; set; }

        public int EscalaEntrenador { get; set; }

        public int Numero { get; set; }

        public int DireccionPokemon { get; set; }

        public int DireccionEntrenador { get; set; }

        public int Numero2 { get; set; }



        public string Especie { get; set; }
        public string Texto { get; set; }


        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
