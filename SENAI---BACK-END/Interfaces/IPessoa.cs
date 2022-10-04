using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAI___BACK_END.Interfaces
{
    internal interface IPessoa
    {
        public string ? nome { get; set; }

        public bool ? pagaImposto { get; set; }

        public string ? endereco { get; set; }

        public bool  isEnderecoResidencial { get; set; }
    }
}
