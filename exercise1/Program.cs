//Exercísio 1 do desafio 21 dias de C#.

//Software que leia 3 nomes, 3 sobrenomes e mostre os nomes completos após isso.

//Apresentação do software.
Console.WriteLine("-- LEITOR E COMPOSITOR DE NOMES --");
Console.WriteLine();

//Receber 3 nomes do usuário.
Console.WriteLine("Escreva 3 nomes [Pressione Enter após cada um]: ");
string? name1 = Console.ReadLine();
string? name2 = Console.ReadLine();
string? name3 = Console.ReadLine();

//Receber 3 sobrenomes do usuário.
Console.WriteLine();
Console.WriteLine("Escreva 3 sobrenomes [Pressione Enter após cada um]: ");
string? nsur1 = Console.ReadLine();
string? nsur2 = Console.ReadLine();
string? nsur3 = Console.ReadLine();

//Processamento dos nomes completos.
string ncmp1 = name1 + " " + nsur1;
string ncmp2 = name2 + " " + nsur2;
string ncmp3 = name3 + " " + nsur3;

//Saída dos nomes completos.
Console.WriteLine();
Console.WriteLine("Os nomes completos escritos são: ");
Console.WriteLine(ncmp1);
Console.WriteLine(ncmp2);
Console.WriteLine(ncmp3);

//Fim do programa.
Console.WriteLine();
Console.WriteLine("-- FIM DO PROGRAMA --");