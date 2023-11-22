using System;

class Program
{

    static void EffectuerActionAléatoire(
        TrafficSimulation.Traffic.Vehicule véhicule,
        TrafficSimulation.Traffic.Intersection intersectionCeder,
        TrafficSimulation.Traffic.Intersection rondPointIntersection,
        TrafficSimulation.Traffic.Intersection feuxTricoloresIntersection,
        Random aléatoire
    )
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
