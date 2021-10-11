using System;
namespace maior_idade_POO {
    class MaiorIdade {

        private string nome;

        public string Nome {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private int idade;
        public int Idade {
            get { return idade; }
            set {
                if (value > 0) {
                    idade = value;
                }
                else {
                    this.idade = 0;
                }
            }
        }

        public MaiorIdade() {
            this.Nome = "";
            this.Idade = 0;
        }

        public MaiorIdade(string nome, int idade) {
            this.nome = nome;
            this.idade = idade;
        }
        public void ExibirDados() {
            Console.WriteLine("Nome: "+ this.Nome);
            Console.WriteLine("Idade: "+ this.Idade);
        }






    }
}
