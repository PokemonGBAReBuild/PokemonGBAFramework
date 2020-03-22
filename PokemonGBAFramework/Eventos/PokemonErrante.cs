using Gabriel.Cat.S.Binaris;
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

        //public static Script GetScript(Edicion edicion, PokemonErrante pokemonErrante)
        //{
        //    Hex nivelYEstado;
        //    string estado, nivel;
        //    ushort auxNivelYEstado;
        //    Script scriptPokemonErrante = new Script();
        //    scriptPokemonErrante.ComandosScript.Add(new ComandosScript.Special(new Word((ushort)Variable.GetVariable(VariableSpecialPokemonErrante, edicion))));
        //    scriptPokemonErrante.ComandosScript.Add(new ComandosScript.SetVar(new Word((ushort)Variable.GetVariable(VariablePokemonErranteVar, edicion)), pokemonErrante.OrdenNacional));
        //    scriptPokemonErrante.ComandosScript.Add(new ComandosScript.SetVar(new Word((ushort)Variable.GetVariable(VariableVitalidadVar, edicion)), pokemonErrante.Vida));
        //    estado = ((Hex)pokemonErrante.Stats).ToString().PadLeft(2, '0');
        //    nivel = ((Hex)((byte)pokemonErrante.Nivel)).ToString();
        //    nivelYEstado = (Hex)(estado + nivel);
        //    auxNivelYEstado = (ushort)(uint)nivelYEstado;
        //    scriptPokemonErrante.ComandosScript.Add(new ComandosScript.SetVar(new Word((ushort)Variable.GetVariable(VariableNivelYEstadoVar, edicion)), new Word(auxNivelYEstado)));//por mirar
        //    return scriptPokemonErrante;


        //}
    }
}
