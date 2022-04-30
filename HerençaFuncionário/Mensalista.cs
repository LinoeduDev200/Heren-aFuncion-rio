using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerençaFuncionário
{
    internal class Mensalista : Funcionário
    {
        public override void Mostrar()
        {
            base.Mostrar();
                
        }
        public Mensalista(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {

        }
    }


}   
