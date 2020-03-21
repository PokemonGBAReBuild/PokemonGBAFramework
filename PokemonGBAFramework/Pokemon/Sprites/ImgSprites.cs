using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PokemonGBAFramework.Pokemon.Sprites
{
    public abstract class ImgSprites:BaseElemento
    {
        public List<Bitmap> Imagenes { get; set; }
    }
}
