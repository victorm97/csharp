using System;
using System.Globalization;

namespace Empresa
{
    class Funcionario
    {
        public string cpf {get; private set;}
        public string nome {get; private set;}
        public double salario {get; private set;}

        public Funcionario (string cpf, string nome, double salario)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }

        public void aumentarSalario(double porcentagem)
        {
            salario = porcentagem * salario / 100 + salario;
        }

        public override string ToString()
        {
            return "CPF: "
                + cpf
                + " \n"
                + "Nome: "
                + nome
                + "\n"
                + "Salario: R$ "
                + salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
