using System;

using Aplicacao.Usuario;

namespace Aplicacao
{
    class Program
    {
        // array armazenando os usuarios criados
        static private User[] usuarios = new User[10];

        static void Main(string[] args)
        {
            
            Console.WriteLine("Olá, mundo!!!");

            criarUsuario("Jason", 35);
            criarUsuario("Robson", 54);
            criarUsuario("Jackson", 23);
            criarUsuario("Jordana", 76);
            criarUsuario("Cabeça", 45);
            criarUsuario("Joao", 65);
            criarUsuario("Maria", 98);

            Console.WriteLine("\nListando Usuarios:\n" + listarUsuarios());

            int mediaIdade = pegarMediaIdade();
            Console.WriteLine($"A media total de idade é: {mediaIdade} Anos ({pegarClassificacao(mediaIdade)})");
        }

        static public int criarUsuario (string name, int age)
        {
            User usuario;
            int usuarioPosicao = -1;

            for (int i = 0; i < usuarios.Length; i++)
            {
                if (string.IsNullOrEmpty(usuarios[i].Name))
                {
                    usuario = new User(name, age);
                    
                    usuarios[i] = usuario;

                    usuarioPosicao = i;

                    break;
                }
            }

            if (usuarioPosicao == -1)
            {
                Console.WriteLine($"AVISO: O usuario({name}) não foi criado porque não há mais espaço no array!");
            }

            return usuarioPosicao;
        }
    
        static public int pegarMediaIdade ()
        {
            int idadeTotal = 0;
            int quantUsuarios = 0;

            foreach (User usuario in usuarios)
            {
                if (!string.IsNullOrEmpty(usuario.Name))
                {
                    idadeTotal += usuario.Age;
                    quantUsuarios++;
                }
            }

            return (int) idadeTotal / quantUsuarios;
        }
    
        static public string listarUsuarios ()
        {
            string listaUsuarios = "";

            for (int i = 0; i < usuarios.Length; i++)
            {
                if (!string.IsNullOrEmpty(usuarios[i].Name))
                {
                    listaUsuarios += $"Usuario {i+1}:\n{usuarios[i].ToString()}\n";
                }
            }

            return listaUsuarios;
        }

        static public Classificacao pegarClassificacao (int idade)
        {
            Classificacao classificacao = Classificacao.Bebê;

            if (idade <= 2)
            {
                classificacao = Classificacao.Bebê;
            }
            else if (idade < 11)
            {
                classificacao = Classificacao.Criança;
            }
            else if (idade < 20)
            {
                classificacao = Classificacao.Adolescente;
            }
            else if (idade < 25)
            {
                classificacao = Classificacao.Jovem;
            }
            else if (idade < 45)
            {
                classificacao = Classificacao.Adulto_Jovem;
            }
            else if (idade < 60)
            {
                classificacao = Classificacao.Adulto;
            }
            else if (idade < 90)
            {
                classificacao = Classificacao.Idoso;
            }
            else if (idade >= 90)
            {
                classificacao = Classificacao.Muito_Idoso;
            }

            return classificacao;
        }

    }
}
