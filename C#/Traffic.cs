using System;

namespace TrafficSimulation
{

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
        }
    }
