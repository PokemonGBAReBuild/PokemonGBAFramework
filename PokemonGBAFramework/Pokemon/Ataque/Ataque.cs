using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon.Ataque
{
    public class Ataque : BaseElemento
    {
        public new const long ID = AtaquesAprendidos.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Ataque>();

        #region Propiedades
        public NombreAtaque Nombre
        {
            get;
            set;
        }

        public DescripcionAtaque Descripcion
        {
            get;
            set;
        }

        public DatosAtaque Datos
        {
            get;
            set;
        }

        public AtaqueConcurso Concursos
        {
            get;
            set;
        }
       

        #endregion
        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
