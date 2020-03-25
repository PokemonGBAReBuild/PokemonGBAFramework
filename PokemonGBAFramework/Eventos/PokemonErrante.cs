using Gabriel.Cat.S.Binaris;
using Gabriel.Cat.S.Extension;
using PokemonGBAFramework.Mapa.Sprites;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Eventos
{
    public class PokemonErrante:BaseElemento
    {
        public class Ruta : BaseElemento
        {
            public new const long ID = PokemonErrante.ID + 1;
            public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Ruta>();

            public int[] Rutas { get; set; }
            public override long IdTipo => ID;

            public override ElementoBinario Serialitzer => Serializador;
        }

        public new const long ID = SpriteMini.ID+1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<PokemonErrante>();
        public int Pokemon { get; set; }
        public int Vida { get; set; }
        public int Nivel { get; set; }
        #region Stats por separado
        public bool EnvenenadoGrave
        {
            get;
            set;
        }
        public bool Envenenado
        {
            get;
            set;
        }
        public bool Paralizado
        {
            get;
            set;
        }
        public bool Congelado
        {
            get;
            set;
        }
        public bool Quemado
        {
            get;
            set;
        }


        public int TurnosDormido
        {
   
            get;
            set;
        }

        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer =>Serializador;


        #endregion

        public byte GetStats()
        {
            const int BITSBYTE = 8;

            bool[] bitsStat = new bool[BITSBYTE];
            bool[] noDor = { Envenenado, Quemado, Congelado, Paralizado, EnvenenadoGrave };
            bool[] bitsAPoner = ((byte)TurnosDormido).ToBits();

            for (int i = 0, f = 3; i < f; i++)
                bitsStat[i] = bitsAPoner[5 + i];

            for (int i=0;i<noDor.Length;i++)
              bitsStat[3 + i] = noDor[i];


            return bitsStat.ToByte();
        }

    
    }
}
