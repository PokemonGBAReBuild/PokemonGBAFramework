using Gabriel.Cat.S.Binaris;
using System.Collections.Generic;

namespace PokemonGBAFramework.Batalla
{
    public class EquipoPokemonEntrenador : BaseElemento
    {
        public new const long ID = Entrenador.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<EquipoPokemonEntrenador>();

        public List<PokemonEntrenador> Equipo
        {
            get;set;

        }
        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer => Serializador;
    }
}