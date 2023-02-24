using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Conta
    {
        private int? _id;
        private string _descricao;
        private char _tipo;
        private double _valor;
        private DateTime _data_vencimento;
        private Categoria _categoria;

        public int? id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public char Tipo
        {
            get => _tipo;
            set => _tipo = value;
                //value.Equals('P') && !value.Equals('R') ? throw new Exception("Use P para Pagar e R para Receber") : value;
        }
        //public char Tipo { get; set; }
        public DateTime DataVencimento { get; set; }
        public Categoria Categoria { get; set; }



    }
}
