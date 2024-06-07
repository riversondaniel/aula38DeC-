using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_aula_38
{
    class produtos2
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Produtos2()
        {
        }
           
        public produtos2( int id, string nome,double preco, int quantidade,  )
        {
            Id = id;
            Nome = nome;
            Preco = preco =
                Quantidade = quantidade;
        }


    }
}
