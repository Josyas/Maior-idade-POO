using System;

namespace maior_idade_POO {
    class Program {
        static void Main(string[] args) {

            MaiorIdade pessoa1, pessoa2, pessoa3;
            pessoa1 = new MaiorIdade();
            pessoa2 = new MaiorIdade();
            

            Console.WriteLine("Dados da pimeira pessoa!");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados da segunda pessoa!");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados da terceira pessoa!");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            pessoa3 = new MaiorIdade(nome, idade);

            if (pessoa1.Idade > pessoa2.Idade || pessoa1.Idade > pessoa3.Idade) {
                Console.WriteLine("Pessoa com maior idade é: ");
                pessoa1.ExibirDados();
                
            }
            else {
                if (pessoa2.Idade > pessoa1.Idade || pessoa2.Idade > pessoa3.Idade) {
                    Console.WriteLine("Pessoa com maior idade é: ");
                    pessoa2.ExibirDados();
                }
                else {
                    if (pessoa3.Idade > pessoa1.Idade || pessoa3.Idade > pessoa2.Idade) {
                        Console.WriteLine("Pessoa com maior idade é: ");
                        pessoa3.ExibirDados();
                    }
                    else {
                        Console.WriteLine("Pessoa com a mesma idade!");
                    }
                }
            }


            
        }
    }
}
