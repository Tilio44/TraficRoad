using System;

namespace TrafficSimulation
{
    public class Traffic
    {
        public enum TypeIntersection
        {
            CedezLePassage,
            RondPoint,
            FeuxTricolores
        }

        public class Vehicule
        {
            public string Type { get; set; }

            public void EffectuerAction(string action)
            {
                Console.WriteLine($"{Type} {action}");
            }
        }

        public class Intersection
        {
            public TypeIntersection Type { get; set; }

            public void GérerTrafic(Vehicule véhicule)
            {
                switch (Type)
                {
                    case TypeIntersection.CedezLePassage:
                        GérerIntersectionCedezLePassage(véhicule);
                        break;
                    case TypeIntersection.RondPoint:
                        GérerIntersectionRondPoint(véhicule);
                        break;
                    case TypeIntersection.FeuxTricolores:
                        GérerIntersectionFeuxTricolores(véhicule);
                        break;
                }
            }

            private void GérerIntersectionCedezLePassage(Vehicule véhicule)
            {
                // Logique de gestion pour une intersection céder le passage
                véhicule.EffectuerAction("Arrivée à l'intersection céder le passage / arrivée au passage piéton");
                véhicule.EffectuerAction("Céder le passage aux autres véhicules / passage piéton vert");
                véhicule.EffectuerAction("Entrée dans l'intersection / traverse le passage piéton");
                véhicule.EffectuerAction("Sortie de l'intersection / sortie du passage piéton");
            }

            private void GérerIntersectionRondPoint(Vehicule véhicule)
            {
                // Logique de gestion pour un rond-point / passage piéton
                véhicule.EffectuerAction("Arrivée au rond-point / arrivée au passage piéton");
                véhicule.EffectuerAction("Navigation dans le rond-point / traverse le passage piéton");
                véhicule.EffectuerAction("Sortie du rond-point / sortie du passage piéton");
            }

            private void GérerIntersectionFeuxTricolores(Vehicule véhicule)
            {
                // Logique de gestion pour une intersection avec feux tricolores
                véhicule.EffectuerAction("Arrivée à l'intersection avec feux tricolores / arrivée au passage piéton");
                véhicule.EffectuerAction("Attente du feu vert / passage piéton vert");
                véhicule.EffectuerAction("Passer l'intersection / traverser le passage piéton");
                véhicule.EffectuerAction("Sortie de l'intersection avec feux tricolores / sortie passage piéton");
            }
        }
    }
}