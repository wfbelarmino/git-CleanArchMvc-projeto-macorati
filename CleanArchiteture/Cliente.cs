using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchiteture
{
    public sealed class Cliente
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Endereco { get; private set; }

        public Cliente(int id, string nome, string endereco)
        {
            Validar(id, nome, endereco);
            Id = id;
            Name = nome;
            Endereco = endereco;
        }
        public void update(int id, string nome, string endereco) 
        {
            Validar(id, nome, endereco);
            Id = id;
            Name = nome;
            Endereco = endereco;
        }

        private void Validar(int id, string nome, string endereco)
        {
            if (id < 0)
            throw new InvalidOperationException("O Id tem que ser maior que 0");

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
                throw new InvalidOperationException("O nome é requerido");

            if (nome.Length < 2)
                throw new InvalidOperationException("O Nome contém poucos caracteres");

            if (nome.Length > 100)
                throw new InvalidOperationException("O Nome ultrapassou o limite permitido");

        }
    }
}
