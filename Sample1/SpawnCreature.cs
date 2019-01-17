namespace InterfacesExample.Sample1
{
    public class SpawnCreature
    {
        public static void Spawn(string creatureType)
        {
            ICreature creature;

            switch (creatureType)
            {
                case "Orc":
                    creature = new Orc();
                    break;
                case "Troll":
                    creature = new Troll();
                    break;
                default:
                    creature = new Troll();
                    break;
            }

            creature.Shout();
            creature.Walk();
        }
    }
}