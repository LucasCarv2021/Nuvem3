// See https://aka.ms/new-console-template for more information


int contador = 0;

List<int> listNumbers = new List<int>();    
List<int> primeiroGrupo = new List<int>();
List<int> segundoGrupo = new List<int>();

Console.WriteLine("Digite 12 Numeros, Entre 1 e 20");

while (contador != 12)
{
    int numero = Convert.ToInt32(Console.ReadLine());
    while (numero > 20)
    {
        Console.WriteLine("Digite Novamente, Somente numeros entre 1 e 20");
        numero = Convert.ToInt32(Console.ReadLine());
    }
    listNumbers.Add(numero);
    contador++;

}

for( int i = 0; i < listNumbers.Count; i++)
{   
    if(listNumbers[i] <= 10 & listNumbers[i] % 2 == 0)
    {
        primeiroGrupo.Add(listNumbers[i]);
    }

    else if(listNumbers[i] > 10)
    {
        segundoGrupo.Add(listNumbers[i]);
    }

}


Console.Clear();
Console.WriteLine("Lista de numeros\n");

for (int i = 0; i < primeiroGrupo.Count; i++)
{
    Console.WriteLine("Primeiro grupo:" + primeiroGrupo[i]);

}

for (int i = 0; i < segundoGrupo.Count; i++)
{
    Console.WriteLine("Segundo grupo:" + segundoGrupo[i]);

}



