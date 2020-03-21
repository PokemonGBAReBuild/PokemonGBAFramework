using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon
{
    public class StatsPokemon : BaseElemento
    {
        public enum NivelEvs
        {
            Cero,
            Uno,
            Dos,
            Tres
        }
        public enum GrupoHuevo
        { Ninguno, Monstruo, Agua1, Bicho, Volador, Campo, Hada, Hierba, FormaHumana, Agua3, Mineral, Amorfo, Agua2, Ditto, Dragón, Desconocido }
        public enum StatEvs
        {
            Hp,
            Ataque,
            Velocidad,
            Defensa,
            AtaqueEspecial,
            DefensaEspecial
        }

        public enum RatioCrecimiento
        {
            Exp1000000,
            Exp600000,
            Exp1640000,
            Exp1059860,
            Exp800000,
            Exp1250000
        }

        public enum RatioGenero
        {
            Macho100 = 0,
            //no se puede poner el caracter %
            Macho87 = 31,
            Macho75 = 63,
            Macho65 = 89,
            Macho50Hembra = 127,
            Hembra65 = 165,
            Hembra75 = 191,
            Hembra87 = 223,
            Hembra100 = 254,
            SinGenero = 255
        }
        public enum Felicidad
        {
            Minima = 0,
            Baja = 35,
            Normal = 70,
            MediAlta = 90,
            Alta = 100,
            MuyAlta = 140,
            Maxima = 255

        }
        public enum Color
        {
            Rojo,
            Azul,
            Amarillo,
            Verde,
            Negro,
            Marron,
            Púrpura,
            Gris,
            Blanco,
            Rosa

        }


        public new const long ID = OrdenNacional.ID+1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<StatsPokemon>();
        #region Stats
        public int Hp
        {
            get;
            set;
        }
        public int Ataque
        {
            get;
            set;
        }


        public int Defensa
        {
            get;
            set;
        }
        public int Velocidad
        {
            get;
            set;
        }
        public int AtaqueEspecial
        {
            get;
            set;
        }
        public int DefensaEspecial
        {
            get;
            set;
        }
        public int Tipo1
        {
            get;

            set;
        }
        public int Tipo2
        {
            get;
            set;
        }
        public int RatioCaptura
        {
            get;
            set;
        }
        public int ExperienciaBase
        {
            get;
            set;
        }
        #region EVs
        public NivelEvs HpEvs
        {
            get;
            set;
        }
        public NivelEvs AtaqueEvs
        {
            get;
            set;

        }
        public NivelEvs DefensaEvs
        {
            get;
            set;

        }
        public NivelEvs VelocidadEvs
        {
            get;
            set;

        }
        public NivelEvs AtaqueEspecialEvs
        {
            get;
            set;
        }
        public NivelEvs DefensaEspecialEvs
        {
            get;
            set;
        }
        #endregion

        public int Objeto1
        {
            get;
            set;
        }

        public int Objeto2
        {
            get;
            set;
        }

        public RatioGenero RatioSexo
        {
            get;
            set;
        }
        /// <summary>
        /// Se usan multiplos de 256 ya que se guarda en un byte
        /// </summary>
        public int PasosParaEclosionarHuevo
        {
            get;
            set;
        }


        /// <summary>
        /// Se puede poner valores de 0 a FF
        /// </summary>
        public Felicidad BaseAmistad
        {
            get;
            set;
        }
        public RatioCrecimiento Crecimiento
        {
            get;//solo se usa la posicion de la enumeracion para determinar su crecimiento
            set;
        }
        public GrupoHuevo GrupoHuevo1
        {
            get;
            set;
        }
        public GrupoHuevo GrupoHuevo2
        {
            get;
            set;
        }
        public int Habilidad1
        {
            get;
            set;
        }



        public int Habilidad2
        {
            get;
            set;
        }
        public int RatioDeEscaparZonaSafari
        {
            get;
            set;
        }



        public Color ColorBaseStat
        {
            get;
            set;
        }
        /// <summary>
        /// Dirección de la imagen en la pantalla de estado
        /// </summary>
        public bool IsFaceRight
        {
            get;
            set;
        }
        public int PadBase
        {
            get;
            set;
        }

        #endregion

        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;


    }
}
