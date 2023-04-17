﻿using ClubeDeLeituraConsoleApp.Compartilhado;
using ClubeDeLeituraConsoleApp.Modelos;

namespace ClubeDeLeituraConsoleApp.Repositorio
{
    public class RepositorioAmigos
    {
        public void CadastrarAmigos(List<Amigos> ListaAmigos)
        {
            Amigos amigos = new Amigos();

            Console.Write("Digite o nome do seu amigo: ");
            amigos.nome = Console.ReadLine();

            Console.Write("Digita o nome do responsável: ");
            amigos.nomeresponsavel = Console.ReadLine();

            Console.Write("Digita o número de telefone: ");
            amigos.numerotelefone = Console.ReadLine();

            Console.Write("Digita o endereço: ");
            amigos.endereco = Console.ReadLine();

            amigos.ID = ListaAmigos.Count;

            ListaAmigos.Add(amigos);

            Console.WriteLine("Cadastrado com sucesso");
        }
        public void EditarAmigos(List<Amigos> ListaAmigos)
        {
            Amigos amigos = new Amigos();
            
            Console.Write("Qual ID gostaria de Editar: ");
            amigos.remove = Convert.ToInt32(Console.ReadLine());

            int index = ListaAmigos.FindIndex(item => amigos.remove == item.ID);

            ListaAmigos.RemoveAt(index);

            Console.Write("Digite o nome: ");
            amigos.nome = Console.ReadLine();

            Console.Write("Digita o nome do responsável: ");
            amigos.nomeresponsavel = Console.ReadLine();

            Console.Write("Digita o número de telefone: ");
            amigos.numerotelefone = Console.ReadLine();

            Console.Write("Digita o endereço: ");
            amigos.endereco = Console.ReadLine();

            amigos.ID = ListaAmigos.Count;

            amigos.ID--;

            ListaAmigos.Add(amigos);

            Console.WriteLine("Editado com sucesso.");
        }
        public void ExcluirAmigos(List<Amigos> ListaAmigos)
        {
            Amigos amigos = new Amigos();

            Console.Write("Qual ID gostaria de Excluir: ");
            amigos.remove = Convert.ToInt32(Console.ReadLine());

            int index = ListaAmigos.FindIndex(item => amigos.remove == item.ID);

            Console.WriteLine("Excluido com sucesso.");
        }
        public void VerificarAmigos(List<Amigos> ListaAmigos)
        {
          
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" |{0,-10} | {1,-30} | {2,-30} | {3,-30} | {4,-30}|", "Id", "Nome", "Responsavel", "Numero Telefone", "Endereco");
            
            Console.WriteLine(" |----------------------------------------------------------------------------------------------------------------------------------------------|");

            foreach (var item in ListaAmigos)
            {
               
              Console.WriteLine(" |{0,-10} | {1,-30} | {2,-30} | {3,-30} | {4,-30}|", item.ID, item.nome, item.nomeresponsavel, item.numerotelefone, item.endereco );

            }

            Console.ResetColor();
            Console.WriteLine();

        }
    }
}
