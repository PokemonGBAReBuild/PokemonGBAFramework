using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Batalla
{
    public class Entrenador : BaseElemento
    {
        public new const long ID = SpriteClaseEntrenador.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<SpriteClaseEntrenador>();

        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer => Serializador;

        public int TrainerClass { get; set; }
        public bool EsUnaEntrenadora { get; set; }
        public int MusicaBatalla { get; set; }
        public int SpriteIndex { get; set; }
        public string Nombre { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Inteligencia { get; set; }
        public EquipoPokemonEntrenador Equipo { get; set; }
    }
}
