//Dado n numeros, encontre os valores mínimo e máximo que podem ser calculados somando a quantidade elementos do array - 1.
//Depois escreva os valores mínimo e máximo e mostre todos os números primos entre esses dois números


using System.Security.Cryptography.X509Certificates;

Console.WriteLine("quantidade de numeros que ira digitar");

int n = int.Parse(Console.ReadLine());
int aux = 0;
int[] vet = new int[n];
int[] crescente = new int[n];


for (int i = 0; i < n; i++)

{
    vet[i] = int.Parse(Console.ReadLine());

}
//ordenando em forma crescente
for (int i = 0; i < vet.Length; i++)
{

    for (int j = 0; j < vet.Length; j++)
    {
        if (vet[i] < vet[j])
        {
            aux = vet[i];
            vet[i] = vet[j];
            vet[j] = aux;
        }
    }
}
for (int i = 0; i < n; i++)
{
    crescente[i] = vet[i];
}

//valor minimo array-1
int soma1 = 0;
for (int i = 0; i < n-1 ; i++)
{
    soma1 += crescente[i];
}
Console.WriteLine("\n\n" + soma1);

//valor maximo array-1
int soma2 = 0;  
for (int i = 1; i < n; i++)
{
    soma2 += crescente[i];
}

Console.WriteLine("\n\n" + soma2);


Console.WriteLine("\n\n os numeros primos entre a soma 1 e a soma 2 sao:");
for (int i = soma1; i < soma2; i++)
{
    if (i%1 == 0 && i%i==0)
    {
        Console.WriteLine(i);
    }
}
int[] vett = new int[soma2 - soma1];
for (int i = soma1; i < soma2; i++)
{
    int a = 0;
    vett[a++] = i;
}