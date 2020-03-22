using Gabriel.Cat.S.Binaris;

namespace PokemonGBAFramework.Batalla
{
    public class PokemonEntrenador : BaseElemento
    {
        public new const long ID = EquipoPokemonEntrenador.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<PokemonEntrenador>();
        public int Especie { get; set; }
        public int Ivs { get; set; }
        public int Level { get; set; }
        public int Item { get; set; }
        public int Move1 { get; set; }
        public int Move2 { get; set; }
        public int Move3 { get; set; }
        public int Move4 { get; set; }
        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer => Serializador;


    }
}