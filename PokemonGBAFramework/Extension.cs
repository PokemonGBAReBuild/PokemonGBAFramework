using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework
{
    public static class Extension
    {
        public static byte[] GetBytes(this IElementoBinarioComplejo elemento)
        {
            return elemento.Serialitzer.GetBytes(elemento);
        }
    }
}
