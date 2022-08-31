using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    internal class Produto
    {
        private int _id;
        private string _alimento;
        private int _quantidade;
        private DateTime _dataFabricacao;
        private DateTime _dataValidade;
        private double _preco;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Alimento
        {
            get { return _alimento; }
            set { _alimento = value; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        public DateTime DataFabricacao
        {
            get { return _dataFabricacao; }
            set { _dataFabricacao = value; }
        }
        public DateTime DataValidade
        {
            get { return _dataValidade; }
            set { _dataValidade = value; }
        }
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
    }
}

