using Gabriel.Cat.S.Binaris;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PokemonGBAFramework.Batalla
{
    public class Objeto : BaseElemento
    {
        public enum BolsilloObjetos
        {

            Desconocido,
            Items,
            Pokeballs,
            MTMO,
            Bayas,
            ObjetosClave
        }
        public new const long ID = Pokeball.ID + 1;
        public static readonly ElementoBinario Serializador = ElementoBinario.GetSerializador<Objeto>();
        
        public string Nombre { get; set; }
        public int Index { get; set; }
        public int Price { get; set; }
        public int HoldEffect { get; set; }
        public int Parameter { get; set; }
        public string Descripcion { get; set; }
        public int PointerFieldUsage { get; set; }
        public int KeyItemValue { get; set; }
        public int BagKeyItem { get; set; }
        public BolsilloObjetos Bolsillo { get; set; }
        public int Tipo { get; set; }
        public int BattleUsage { get; set; }
        public int PointerBattleUsage { get; set; }
        public int ExtraParameter { get; set; }
        public Bitmap Imagen { get; set; }
        public override long IdTipo => ID;

        public override ElementoBinario Serialitzer => Serializador;


    }
}
