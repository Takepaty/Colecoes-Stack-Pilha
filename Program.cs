// Stack => Empilhar 
//LIFO => last in first out - Ultimo que entrou vai ser o primeiro a sair

Stack<int> pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(3);
pilha.Push(5);
pilha.Push(7);
pilha.Push(9);

Console.WriteLine("Adicionando item na pilha:");

foreach (int item in pilha)
{
  Console.WriteLine($"Item {item}");
}

Console.WriteLine();
Console.WriteLine("Removendo item da pilha:");
Console.WriteLine($"Item {pilha.Pop()}");

foreach (int item in pilha)
{
  Console.WriteLine($"Item {item}");
}