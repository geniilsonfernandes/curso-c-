using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores.models
{
    public class LeituraArquivo
    {
        public (bool sucesso, string[] linhas, int quant) LerArquivo(string caminho)
        {
            try
            {

                return (true, new string[1], 0);
            }
            catch (Exception)
            {
                return (false, new string[1], 0);
            }
        }
    }
}