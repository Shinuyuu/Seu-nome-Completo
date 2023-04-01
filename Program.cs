void Shin(string frase, int fun)
{
    if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
for (int i = 00; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(40);
}
}
Console.Clear();
Shin("Porfavor, escreva seu nome: ",01);
string nome = Console.ReadLine()!;
Console.Clear();
Shin("Agora insira seu sobrenome: ",01);
string sobrenome = Console.ReadLine()!;
Console.Clear();
string nomecompleto = nome + " " + sobrenome;
Shin($"Bom dia ",02);
Shin(nomecompleto,00);
Shin($", suas informações foram juntadas^^ \n",02);
Shin(sobrenome.ToUpper(),00);
Shin(" é seu sobrenome enquanto seu nome é ",02);
Shin(nome,00);
Shin(" :D ",02);
Console.ResetColor();
