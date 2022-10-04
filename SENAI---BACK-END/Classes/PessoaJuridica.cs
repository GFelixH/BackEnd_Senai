using SENAI___BACK_END.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAI___BACK_END.Classes
{
    internal class PessoaJuridica : IPessoa
    {
        string? IPessoa.nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool? IPessoa.pagaImposto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string? IPessoa.endereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IPessoa.isEnderecoResidencial { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        string cnpj;

        string razaoSocial;

    }
}
