using System.Numerics;

namespace CodeMonkey_CSharpCourse
{
    public class Program
    {
        private const int DEFAULT_HEALTH_AMOUNT = 100;
        private enum UnitType
        {
            Melee,
            Ranged,
            Wizard
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SpawnUnit(new Vector3(0, 0, 0), UnitType.Melee, Quaternion.Identity, 56);
            SpawnUnit(new Vector3(10, 5, 0), UnitType.Ranged, Quaternion.Identity);
            SpawnUnit(healthAmount: 56);
        }
        private static void SpawnUnit(
            Vector3 spawnPosition = default,
            UnitType unitType = UnitType.Melee,
            Quaternion spawnRotation = default,
            int healthAmount = DEFAULT_HEALTH_AMOUNT
            )
        {
            Console.WriteLine("Spawning unit of type " + unitType + " with health: " + healthAmount + " at " + spawnPosition + ", ");
        }
    }
}
