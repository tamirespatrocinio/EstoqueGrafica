using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueGrafica.Model
{
    class Grafica
    {
        private static int id;
        private static string nome_produto;
        private static string descricao_produto;
        private static string quantidade_produto;
        private static string valor_produto;
        private static string retorno;

        public static int Id { get => id; set => id = value; }
        public static string Nome_produto { get => nome_produto; set => nome_produto = value; }
        public static string Descricao_produto { get => descricao_produto; set => descricao_produto = value; }
        public static string Quantidade_produto { get => quantidade_produto; set => quantidade_produto = value; }
        public static string Valor_produto { get => valor_produto; set => valor_produto = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}