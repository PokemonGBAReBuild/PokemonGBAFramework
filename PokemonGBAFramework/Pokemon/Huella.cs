using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PokemonGBAFramework.Pokemon
{
    public class HuellaPokemon : BaseElemento
    {
        public new const long ID = StatsPokemon.ID+1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<HuellaPokemon>();
        public Bitmap Huella { get; set; }
        public override ElementoBinario Serialitzer => Serializador;
        public override long IdTipo => ID;


    }
}
