using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerençaFuncionário
{
    class  Program
    {
       static void Main(string[] args)
        {
            Funcionário f = new Funcionário(1, "Jorge", 1800);
            f.Mostrar();

            Horista h = new Horista(2, "Laura", 2000);
            h.Mostrar();

            Mensalista m = new Mensalista(3, "Beatriz", 2500);
            m.Mostrar();

            Console.ReadKey();

        }
    }
}
