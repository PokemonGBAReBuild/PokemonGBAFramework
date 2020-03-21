using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon.Ataque
{
    public class AtaquesAprendidos : BaseElemento
    {
        public new const long ID = AtaqueAprendido.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<AtaquesAprendidos>();
        public List<AtaqueAprendido> Ataques { get; set; }

        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
        public bool EstaElAtaque(AtaqueAprendido ataque)
        {
            bool esta = false;
            for (int i = 0; i < Ataques.Count && !esta; i++)
                esta = Ataques[i].Ataque == ataque.Ataque;
            return esta;
        }
    }
    public class AtaqueAprendido : BaseElemento
    {
        public new const long ID = AtaqueConcurso.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<AtaqueAprendido>();
		public int Ataque
		{
            get;

            set;
		}

		public int Nivel
		{
			get;

			set;
		}

		public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
