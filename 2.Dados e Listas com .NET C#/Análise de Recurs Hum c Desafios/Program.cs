using System;

class Programa
{
    static void Main(string[] args)
    {
        // Entrada das notas
        string entrada = "10,9,8";
        
        // Separar os valores e convertê-los para inteiros
        string[] notasString = entrada.Split(',');
        int produtividade = int.Parse(notasString[0]);
        int qualidade = int.Parse(notasString[1]);
        int pontualidade = int.Parse(notasString[2]);
        
        // TODO: Calcule a média
        double media;
        media = (produtividade+qualidade+pontualidade)/3;
        Console.WriteLine($"produtividade: {produtividade},qualidade: {qualidade}, pontualidade: {pontualidade} ");
        
        // TODO: Verifique a elegibilidade para bônus
        string elegivelParaBonus;
        elegivelParaBonus = "Felipe";
        
        // Exibir os resultados
        Console.WriteLine($"Media: {media}");
        Console.WriteLine($"Elegivel para bonus: {elegivelParaBonus}");
    }
}