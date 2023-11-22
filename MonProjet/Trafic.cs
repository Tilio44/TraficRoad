using System;

class RandomNumber
{
    private static Random random = new Random(); // Déplacer l'objet Random en dehors de la méthode pour éviter les répétitions

    public static int GenerateRandomNumber()
    {
        return random.Next(1, 3); // Génère un nombre entre 1 (inclus) et 3 (exclus)
    }
}
