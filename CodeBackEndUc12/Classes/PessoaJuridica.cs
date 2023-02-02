using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeBackEndUc12.Interfaces;

namespace CodeBackEndUc12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? cnpj {get; set;}

        public string? razaSocial {get; set;}

        public override float CalcularImposto(float rendimentos)
        {
             if (rendimento <= 3000)
            {
                float resultado = (float) rendimento * .03f;
                return resultado;
            } 
            else if (rendimento > 3000 && rendimento <= 6000)
            {
                float resultado = (float) rendimento * .02f;
                return resultado;
            }
            else if (rendimento > 6000 && rendimento <= 10000)
            {
                float resultado = (float) rendimento * 0.07f;
                return resultado;
            }
            else
            {
                float resultado = (float) rendimento * 0.09f;
                return resultado; 
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}