using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        TrafficSimulation.Traffic.Intersection intersectionCeder = new TrafficSimulation.Traffic.Intersection { Type = TrafficSimulation.Traffic.TypeIntersection.CedezLePassage };
        TrafficSimulation.Traffic.Intersection rondPointIntersection = new TrafficSimulation.Traffic.Intersection { Type = TrafficSimulation.Traffic.TypeIntersection.RondPoint };
        TrafficSimulation.Traffic.Intersection feuxTricoloresIntersection = new TrafficSimulation.Traffic.Intersection { Type = TrafficSimulation.Traffic.TypeIntersection.FeuxTricolores };

        Random aléatoire = new Random();

        while (true)
        {
            int nombreVoitures = aléatoire.Next(5) + 1; // Nombre aléatoire de voitures entre 1 et 5
            int nombrePiétons = aléatoire.Next(3) + 1; // Nombre aléatoire de piétons entre 1 et 3

            Console.WriteLine($"----- Nouvelle itération - {nombreVoitures} voitures, {nombrePiétons} piétons -----");

            for (int i = 0; i < nombreVoitures; i++)
            {
                TrafficSimulation.Traffic.Vehicule voiture = new TrafficSimulation.Traffic.Vehicule { Type = "Voiture" };
                EffectuerActionAléatoire(voiture, intersectionCeder, rondPointIntersection, feuxTricoloresIntersection, aléatoire);
            }

            for (int i = 0; i < nombrePiétons; i++)
            {
                TrafficSimulation.Traffic.Vehicule piéton = new TrafficSimulation.Traffic.Vehicule { Type = "Piéton" };
                EffectuerActionAléatoire(piéton, intersectionCeder, rondPointIntersection, feuxTricoloresIntersection, aléatoire);
            }

            Thread.Sleep(10000); // Attente de 10 secondes entre chaque itération
        }
    }

    static void EffectuerActionAléatoire(
        TrafficSimulation.Traffic.Vehicule véhicule,
        TrafficSimulation.Traffic.Intersection intersectionCeder,
        TrafficSimulation.Traffic.Intersection rondPointIntersection,
        TrafficSimulation.Traffic.Intersection feuxTricoloresIntersection,
        Random aléatoire)
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