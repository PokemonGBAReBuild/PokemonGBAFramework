using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon.Ataque
{
    public class DatosAtaque : BaseElemento
    {

        public enum Categoria
        {
            Fisico, Especial, Estatus
        }
        public new const long ID = DescripcionAtaque.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<DatosAtaque>();
        #region Propiedades
        public bool MakesContact
        {
            get;
            set;
        }
        public bool IsAffectedByProtect
        {
            get;
            set;
        }
        public bool IsAffectedByMagicCoat
        {
            get;
            set;
        }
        public bool IsAffectedBySnatch
        {
            get;
            set;
        }
        public bool IsAffectedByMirrorMove
        {
            get;
            set;
        }
        public bool IsAffectedByKingsRock
        {
            get;
            set;
        }

        public byte Effect
        {
            get;

            set;
        }

        public byte BasePower
        {
            get;

            set;
        }

        public byte Type
        {
            get;

            set;
        }

        public byte Accuracy
        {
            get;

            set;
        }

        public byte PP
        {
            get;

            set;
        }

        public byte EffectAccuracy
        {
            get;

            set;
        }

        public byte Target
        {
            get;

            set;
        }

        public byte Priority
        {
            get;

            set;
        }



        public byte PadByte1
        {
            get;

            set;
        }

        public Categoria Category
        {
            get;

            set;
        }

        public byte PadByte3
        {
            get;

            set;
        }
        #endregion
        public override long IdTipo => ID; 
        public override ElementoBinario Serialitzer => Serializador;
       



    }
}
