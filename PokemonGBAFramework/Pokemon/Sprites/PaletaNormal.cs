﻿using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework.Pokemon.Sprites
{
    public class PaletaNormal:Paleta
    {
        public new const long ID = Frontales.ID+1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<PaletaNormal>();


        public override ElementoBinario Serialitzer => Serializador;

        public override long IdTipo => ID;
    }
}
