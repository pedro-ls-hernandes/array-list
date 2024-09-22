using System;
using array_list;
using System.Collections;
//Criando um ArrayList vazio
ArrayList pessoas = new ArrayList();

//Adicionando a quantidade desejada de pessoas na lista:
Console.WriteLine("Quantas pessoas serão adicionadas à lista?\n");
int numPessoas = int.Parse(Console.ReadLine());
for (int i = 0; i < numPessoas; i++)
{
    Console.WriteLine($"Digite o nome da pessoa {i + 1}: ");
    string nome = Console.ReadLine();
    Console.WriteLine($"Idade da pessoa {i + 1}:");
    int idade = int.Parse(Console.ReadLine());
    pessoas.Add(new Pessoa(nome, idade));
}

//Exibindo a lista após adicionar as pessoas
foreach (Pessoa pessoa in pessoas)
{
    pessoa.Exibir();
}
Console.WriteLine("");

//Adicionando mais pessoas caso o usuário queira
int addPessoas = 0;
do
{
    Console.WriteLine("Gostaria de adicionar mais pessoas na lista?\n1 - SIM\n2 - NÃO");
    addPessoas = int.Parse(Console.ReadLine());
    if (addPessoas == 1)
    {
        Console.WriteLine("Quantas?");
        int addNumPessoas = int.Parse(Console.ReadLine());
        for (int i = 0; i < addNumPessoas; i++)
        {
            Console.WriteLine($"Digite o nome da pessoa {i + 1}: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Idade da pessoa {i + 1}:");
            int idade = int.Parse(Console.ReadLine());
            pessoas.Add(new Pessoa(nome, idade));
        }
    }
    else
    {
        Console.WriteLine("Mostrando a lista atual: ");
        foreach (Pessoa pessoa in pessoas)
        {
            pessoa.Exibir();
        }
        Console.WriteLine("");
    }

} while (addPessoas == 1);



//Retirando a ultima pessoa do ArrayList
pessoas.RemoveAt(pessoas.Count - 1);
Console.WriteLine("A última pessoa da lista tirou seu nome dela.\nPressione qualquer botão para continuar:\n");
Console.ReadKey();
Console.WriteLine("Nova lista:\n");
foreach (Pessoa pessoa in pessoas)
{
    pessoa.Exibir();
}