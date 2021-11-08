using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueGrafica.Model
{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamires.patrocinio\source\repos\EstoqueGrafica\EstoqueGrafica\dbGrafica.mdf;Integrated Security=True";
        }
    }
}