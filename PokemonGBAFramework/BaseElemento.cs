using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework
{
    public abstract class BaseElemento:IElementoBinarioComplejo
    {
        public const long ID = 0;
        public abstract long IdTipo { get; }
        public abstract ElementoBinario Serialitzer { get; }
    }
}
