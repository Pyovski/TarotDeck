using System;

class Program
{
    static void Main(string[] args)
    {
        // Exibindo uma carta de tarô aleatória
        string carta = ObterCartaTarotAleatoria();
        Console.WriteLine("Carta de Tarô Aleatória: " + carta);
    }

    // Método para obter uma carta de tarô aleatória
    static string ObterCartaTarotAleatoria()
    {
        string[] tarotDeck = {
            "O Louco", "O Mago", "A Sacerdotisa", "A Imperatriz", "O Imperador", 
            "O Hierofante", "Os Amantes", "O Carro", "A Justiça", "O Eremita", 
            "A Roda da Fortuna", "A Força", "O Enforcado", "A Morte", "A Temperança", 
            "O Diabo", "A Torre", "A Estrela", "A Lua", "O Sol", 
            "O Julgamento", "O Mundo"
        };

        // Gerando um índice aleatório para selecionar uma carta
        int indiceAleatorio = RandomDeck(0, tarotDeck.Length - 1);

        // Retornando a carta de tarô aleatória
        return tarotDeck[indiceAleatorio];
    }

    // Método para gerar números aleatórios em um intervalo específico
    static int RandomDeck(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
}