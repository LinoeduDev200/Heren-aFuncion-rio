using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerençaFuncionário
{
    internal class Funcionário
    {

        protected int codigo;
        protected string nome;
        protected double salario;

        
        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo +
                    "\tNome: " + Nome + "\tSalário: " + Salario);
        }
        public Funcionário(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public int Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }
        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome; }
        }
        public double Salario
        {
            set { this.salario = value; }
            get { return this.salario; }
        }
    }
}
