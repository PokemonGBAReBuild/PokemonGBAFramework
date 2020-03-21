using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGBAFramework
{
    public class Elemento : IElementoConIdSerializable
    {
        public const long BASEORIGINAL = 0;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Elemento>();
        public long IdBase { get; set; }
        public long IdTipo { get; set; }
        public long Id { get; set; }
        public byte[] Data { get; set; }
        public ElementoBinario Serialitzer => Serializador;
        public bool Original => IdBase == BASEORIGINAL;
        public Elemento() { }
        public Elemento(BaseElemento elemento,long id=-1,Elemento baseElemento=null)
        {
            IdTipo = elemento.IdTipo;
            Data = elemento.GetBytes();
            Id = id < 0 ? DateTime.UtcNow.Ticks : id;
            if (baseElemento != null)
            {
                IdBase = baseElemento.Id;
                Data = QuitarBase(baseElemento.Data, Data);
            }
            else IdBase = BASEORIGINAL;
        }

        private static byte[] QuitarBase(byte[] dataBase, byte[] data)
        {
            byte[] dataSinBase = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
                dataSinBase[i] = dataBase[i] != data[i] ? data[i] :byte.MinValue;
            return dataSinBase;
        }
        private static byte[] PonerBase(byte[] dataBase,byte[] dataSinBase)
        {
            byte[] dataConBase = new byte[dataBase.Length];
            for (int i = 0; i < dataBase.Length; i++)
                dataConBase[i] = dataSinBase[i]==byte.MinValue?dataBase[i]:dataSinBase[i];
            return dataConBase;
        }
        public static byte[] GetData(SortedList<long,Elemento> dic,Elemento elemento)
        {
            byte[] data;
            Stack<Elemento> parents= GetParents(dic, elemento);
            
            if (!elemento.Original)
            {
                data = parents.Pop().Data;
                while (parents.Count > 0)
                {
                    data = PonerBase(data, parents.Pop().Data);
                }
                data = PonerBase(data, elemento.Data);
            }
            else
            {
                data = elemento.Data;
            }
            return data;

        }

        private static Stack<Elemento> GetParents(SortedList<long, Elemento> dic, Elemento elemento)
        {
            Elemento actual;
            Stack<Elemento> parents = new Stack<Elemento>();
            
            if (!elemento.Original)
                actual = dic[elemento.IdBase];
            else actual = null;
            while (actual != null)
            {
                parents.Push(actual);
                if (!actual.Original)
                {
                    actual = dic[actual.IdBase];
                }
                else actual = null;
            }

            return parents;
        }

        public static byte[] GetData(SortedList<long,ElementoOri> dicOri, SortedList<long, Elemento> dicElementos, Elemento elemento)
        {
            Stack<Elemento> parents = GetParents(dicElementos, elemento);
            ElementoOri ori = parents.Count>0?dicOri.ContainsKey(parents.Peek().IdBase)?dicOri[parents.Pop().IdBase]:null:null;

            return ElementoOri.GetData(ori,GetData(dicElementos, elemento));
        }
    }
}
