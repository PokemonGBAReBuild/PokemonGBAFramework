using Gabriel.Cat.S.Binaris;
using Gabriel.Cat.S.Extension;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PokemonGBAFramework
{
    public class ElementoOri : IElementoConIdSerializable
    {
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<ElementoOri>();

        [IgnoreSerialitzer]
        public long Id { 
            get {

                ElementoBinario intSerialitzer = ElementoBinario.GetSerializador<int>();
                return (long)ElementoBinario.GetSerializador<long>().GetObject(intSerialitzer.GetBytes(IdTipo).AddArray(intSerialitzer.GetBytes(PosicionRom)));
            
            } 
            set {
                MemoryStream ms =new MemoryStream(ElementoBinario.GetSerializador<long>().GetBytes(value));
                ElementoBinario intSerialitzer = ElementoBinario.GetSerializador<int>();
                IdTipo =(int) intSerialitzer.GetObject(ms);
                PosicionRom = (int)intSerialitzer.GetObject(ms);


            } 
        }
        public int IdTipo { get; set; }
        public int PosicionRom { get; set; }
        [IgnoreSerialitzer]
        public byte[] Data { get; set; }//se saca de la rom
        public ElementoBinario Serialitzer => Serializador;


        public static byte[] GetData(ElementoOri elementoOri,byte[] dataCustom)
        {
            byte[] data = new byte[dataCustom.Length];
            if (elementoOri != null)
            {
                for (int i = 0; i < data.Length; i++)
                    data[i] = dataCustom[i] == byte.MinValue ? elementoOri.Data[i] : dataCustom[i];
            }
            else dataCustom.CopyTo(data, 0);
            return data;
        }
  
    
    }
}
