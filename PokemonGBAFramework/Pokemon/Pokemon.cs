using Gabriel.Cat.S.Binaris;
using PokemonGBAFramework.Pokemon.Ataque;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon
{
    public class Pokemon : BaseElemento
    {
        public new const long ID = Ataque.Ataque.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Pokemon>();

        public OrdenNacional OrdenNacional { get; set; }
        public OrdenLocal OrdenLocal { get; set; }

        public int OrdenGameFreak { get; set; }

        public NombrePokemon Nombre { get; set; }

        public DescripcionPokedex Descripcion { get; set; }

        public Sprites.Sprite Sprites { get; set; }

        public StatsPokemon Stats { get; set; }



        public HuellaPokemon Huella { get; set; }

        public AtaquesAprendidos AtaquesAprendidos { get; set; }

        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
