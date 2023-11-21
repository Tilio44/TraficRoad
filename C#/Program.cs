using System;

class Program
{

    static void EffectuerActionAléatoire()
    {
        véhicule.EffectuerAction("Approche de l'intersection");

        int intersectionAléatoire = aléatoire.Next(3); // 0 pour céder le passage, 1 pour rond-point, 2 pour feux tricolores

        switch (intersectionAléatoire)
        {
            case 0:
                intersectionCeder.GérerTrafic(véhicule);
                break;
            case 1:
                rondPointIntersection.GérerTrafic(véhicule);
                break;
            case 2:
                feuxTricoloresIntersection.GérerTrafic(véhicule);
                break;
        }
    }
}
