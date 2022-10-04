using SENAI___BACK_END.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAI___BACK_END.Classes
{
    internal class PessoaFisica : IPessoa
    {
        string? IPessoa.nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool? IPessoa.pagaImposto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string? IPessoa.endereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IPessoa.isEnderecoResidencial { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        string cpf;

        string dataNascimento;

        public bool ehMaiorDeIdade(string dataNascimento)
        {
            DateTime objDate;

            if (DateTime.TryParse(dataNascimento, out objDate))
            {
                DateTime hoje = DateTime.Today;
                double idade = (hoje - objDate).TotalDays / 365;

                if(idade >= 18)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
