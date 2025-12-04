using System.Text;

namespace CodeMonkey_CSharpCourse
{
    public class Program
    {
        private enum ResourceType
        {
            Stone,
            Wood,
            Gold,
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Creates a new dictionary
            // Dictionary<ResourceType, int> resourceTypeAmountDictionary = new Dictionary<ResourceType, int>();

            // Another way to create key-value pairs and add them to the dictionary
            Dictionary<ResourceType, int> resourceTypeAmountDictionary = new Dictionary<ResourceType, int>()
            {
                {ResourceType.Wood, 10},
                {ResourceType.Gold, 27},

            };

            // Creates key-value pair and adds it to the dictionary
            resourceTypeAmountDictionary.Add(ResourceType.Stone, 56);

            Console.WriteLine(resourceTypeAmountDictionary[ResourceType.Stone]);

            // Update value property in key-value pair
            resourceTypeAmountDictionary[ResourceType.Stone] = 45;

            // Check if a value exists
            resourceTypeAmountDictionary.ContainsKey(ResourceType.Wood);

            resourceTypeAmountDictionary[ResourceType.Wood] = 30;
            // Another way to check if a value exists
            if (resourceTypeAmountDictionary.TryGetValue(ResourceType.Wood, out int woodAmount))
            {
                Console.WriteLine(woodAmount);
            };

            // remove a poperty from a dictionary
            resourceTypeAmountDictionary.Remove(ResourceType.Wood);

            foreach (ResourceType resourceType in resourceTypeAmountDictionary.Keys)
            {
                Console.WriteLine(resourceType + ": " + resourceTypeAmountDictionary[resourceType]);
            }
        }
    }
}
