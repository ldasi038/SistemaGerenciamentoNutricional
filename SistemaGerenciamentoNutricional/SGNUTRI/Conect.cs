using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGNUTRI
{
    static class Conect
    {
        static private string servidor = "localhost";
        static private string bancoDados = "sgnutri";
        static private string usuario = "root";
        static private string senha = "Le@123456789";

        static public string strConect = $"server={servidor}; User Id={usuario}; database={bancoDados}; password={senha}";
    }
}
