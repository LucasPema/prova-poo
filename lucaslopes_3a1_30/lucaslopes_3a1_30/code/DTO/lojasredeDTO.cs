using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lucaslopes_3a1_30.code.DTO
{
    class lojasredeDTO
    {
        private int _codigo;
        private string _produto;
        private double _valor;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Produto { get => _produto; set => _produto = value; }
        public double Valor { get => _valor; set => _valor = value; }
    }
}
