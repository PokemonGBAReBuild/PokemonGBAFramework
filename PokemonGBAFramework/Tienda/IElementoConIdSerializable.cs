using Gabriel.Cat.S.Binaris;
using System;

namespace PokemonGBAFramework
{
    public interface IElementoConIdSerializable:IElementoBinarioComplejo
    {
         long Id { get; set; }

    }
}
