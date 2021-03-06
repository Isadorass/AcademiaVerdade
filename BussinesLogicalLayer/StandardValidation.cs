using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinesLogicalLayer
{
    public class StandardValidation
    {
        public bool ValidationNumero(string value)
        {
            List<string> listaValue = new List<string>();
            Regex regex = new Regex("[0-9]");

            for (int i = 0; i < value.Length; i++)
            {
                listaValue.Add(value.Substring(i, 1));
            }

            foreach (string valor in listaValue)
            {
                if (!regex.IsMatch(valor))
                {
                    return false;
                }            
            }
            return true;
        }

        public bool ValidationsDescricao(string descricao)
        {
            if ((!string.IsNullOrWhiteSpace(descricao)) &&
                (ValidationsComprimento(descricao, 3, 70)) &&
                (ValidationsCaracteres(descricao)))
            {
                return true;
            }
            return false;
        }

        public string ValidationsNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return "";
            }

            if (ValidationsComprimento(nome, 3, 70) && ValidationsCaracteres(nome))
            {
                nome = nome.Trim();
                nome = Regex.Replace(nome, @"\s+", " ");

                TextInfo textInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
                nome = textInfo.ToTitleCase(nome);

                return nome;
            }

            return "";
        }

        public bool ValidationsCpf(string cpf)
        {
            cpf = cpf.Replace("-", "").Replace(".", "").Replace(",", "").Replace(" ", "");

            if ((string.IsNullOrWhiteSpace(cpf)) || 
                (!ValidationsComprimento(cpf, 11, 11)) ||
                (!ValidationNumero(cpf)))
            {
                return false;
            }

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            bool valido = cpf.EndsWith(digito);
            if (!valido)
            {
                return false;
            }
            return true;
        }

        public bool ValidationsRg(string rg)
        {
            rg = rg.Replace("-", "").Replace(".", "").Replace(",", "");

            if ((!string.IsNullOrWhiteSpace(rg)) && 
                (ValidationsComprimento(rg, 7, 7)) && 
                (ValidationNumero(rg)))
            {
                return true;
            }

            return false;
        }    
        public bool ValidationsEmail(string email)
        {
            List<String> listaEmail = new List<String>();

            if ((string.IsNullOrWhiteSpace(email)) || (!ValidationsComprimento(email, 8, 100)))
            {
                return false;
            }

            for (int i = 0; i < email.Length; i++)
            {
                listaEmail.Add(email.Substring(i, 1));
            }

            foreach (String letra in listaEmail)
            {
                if (letra.Equals("@"))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidationsTelefone(string telefone)
        {
    telefone = telefone.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "");
            if ((string.IsNullOrWhiteSpace(telefone)) || (!ValidationsComprimento(telefone, 11, 11)
                || (!ValidationNumero(telefone))))
            {
                return false;
            }

            return true;
        }

        public bool ValidationsComprimento(string value, int min, int max)
        {
            if (value.Length < min || value.Length > max)
            {
                return false;
            }

            return true;
        }

        public bool ValidationsCaracteres(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                char letra = value[i];
                if (!char.IsLetter(letra) && letra != ' ' && letra != '\'')
                {
                    return false;
                }
            }
            return true;
        }

        public bool ValidationsData(String data)
        {
            string dataAtualString = DateTime.Now.ToString();
            
            int anoRecebido = Convert.ToInt32(data.Substring(6, 4));
            int mesRecebido = Convert.ToInt32(data.Substring(3, 2));
            int diaRecebido = Convert.ToInt32(data.Substring(0, 2));

            int anoAtual = Convert.ToInt32(dataAtualString.Substring(6, 4));
            int mesAtual = Convert.ToInt32(dataAtualString.Substring(3, 2));
            int diaAtual = Convert.ToInt32(dataAtualString.Substring(0, 2));

            DateTime dataRecebida = new DateTime(anoRecebido, mesRecebido, diaRecebido);

            int diferenca = (int) dataRecebida.Subtract(DateTime.Today).TotalDays;

            if (diferenca > 4380)
            {
                return true;
            }
            return false;
        }

        public bool ValidationsBairro(string bairro)
        {
            if (string.IsNullOrWhiteSpace(bairro))
            {
                return false;
            }

            return ValidationsComprimento(bairro, 3, 100);
        }

        public bool ValidationsRua(string rua)
        {
            if (string.IsNullOrWhiteSpace(rua))
            {
                return false;
            }

            return ValidationsComprimento(rua, 3, 100);
        }

        public string ValidationsComplementoNumero(string complemento, string numeroCasa)
        {
            if (string.IsNullOrWhiteSpace(numeroCasa) && string.IsNullOrWhiteSpace(complemento))
            {
                return "Complemento obrigatório caso não tenha numero da casa.\r\n";
            }
            if (complemento?.Length > 30)
            {
                return "Complemento não pode conter mais de 30 caracteres.\r\n";
            }
            if (numeroCasa?.Length > 10)
            {
                return "Número da casa não pode conter mais de 6 caracteres.\r\n";
            }

            return "";
        }

        public bool ValidationsGenero(string genero)
        {
            if (string.IsNullOrWhiteSpace(genero))
            {
                return false;
            }

            string[] generos = { "Feminino", "Masculino", "Outros" };
            if (!generos.Contains(genero))
            {
                return false;
            }

            return true;
        }

        public bool ValidationsModalidades(string modalidade)
        {
            if (string.IsNullOrWhiteSpace(modalidade))
            {
                return false;
            }
            bool tamanhoEhValido = ValidationsComprimento(modalidade, 3, 70);
            if (tamanhoEhValido)
            {
                return true;
            }

            return ValidationsModalidades(modalidade);
        }
    }
}
