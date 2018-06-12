using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoBianca
{
    public class Aluno
    {
        public int Cod { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        public int idade()
        {
            int idade = DateTime.Today.Year - this.DataNascimento.Year;

            return idade;
        }

        public string nomeCompleto()
        {
            return string.Concat(Nome + Sobrenome);
        }

        public int validaNome()
        {
            int i = 0;
            string no = Nome;
            string so = Sobrenome;

            if (no.Contains("Ç") || no.Contains("ç") || so.Contains("Ç") || so.Contains("ç"))
            {
                i = +1;
            }
            if (no.Contains("@") || so.Contains("@"))
            {
                
                i = +2;
            }
            return i;
        }

        public string erroValidacao(int i)
        {
            string erro;
            if (validaNome() == 1)
            {
                erro = "Este nome não pode ser usado contém caracter 'Ç' que é inválido no inicio do nome";
                return erro;
            }
            else if (validaNome() == 2)
            {
                erro = "Este nome não pode ser usado contém caracter '@' que é inválido";
                return erro;
            }

            return "";
        }

    }
}
