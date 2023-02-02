using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBackEndUc12.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNasc(DateTime dataNasc);
    }
}