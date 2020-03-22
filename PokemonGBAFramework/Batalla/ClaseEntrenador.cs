using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Batalla
{
    public class ClaseEntrenador : BaseElemento
    {
        public new const long ID = Objeto.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Objeto>();

        public RateMoneyClaseEntrenador RateMoney { get; set; }

        public SpriteClaseEntrenador Sprite { get; set; }

        public NombreClaseEntrenador Nombre { get; set; }

        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer => Serializador;
    }
}
