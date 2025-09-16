using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;

public class Dictionary_1 : MonoBehaviour {


    private enum ResourceType {

        Wood,
        Metal,
        Gold,
        Stone
    }

    void Start()
    {
        
        Dictionary<ResourceType, int> resourceTypeAmountDictionary = new Dictionary<ResourceType, int>();

        resourceTypeAmountDictionary.Add(ResourceType.Wood, 5);
        resourceTypeAmountDictionary.Add(ResourceType.Metal, 15);
        resourceTypeAmountDictionary[ResourceType.Metal] = 120; // you can change 
        resourceTypeAmountDictionary.Remove(ResourceType.Wood); // you can remove


        // you can  initialized like Lists and Arrays
        Dictionary<ResourceType, int> resourceAmount2 = new Dictionary<ResourceType, int>() {

            {ResourceType.Wood, 5},
            {ResourceType.Metal, 15},
            {ResourceType.Gold, 15},
        };
                

        Debug.Log(resourceTypeAmountDictionary.ContainsKey(ResourceType.Metal)); // checking for key bool returns 

        Debug.Log(resourceTypeAmountDictionary.TryGetValue(ResourceType.Metal, out int amount)); // other one aproach for checking key

        if(resourceTypeAmountDictionary.TryGetValue(ResourceType.Metal, out amount)) {
            Debug.Log(amount); // printed with out parameter  
        }




        // foreach key value check

        Debug.Log("///////////////////////////////////////////// ");
        foreach(KeyValuePair<ResourceType, int> keyValuePair in resourceAmount2) {


            Debug.Log(keyValuePair.Key + ":" + keyValuePair.Value);
        }

        Debug.Log("///////////////////////////////////////////// ");
        foreach (ResourceType resourceType in resourceAmount2.Keys) {


            Debug.Log(resourceType + ":" + resourceAmount2[resourceType]);
        }

        Debug.Log("///////////////////////////////////////////// ");
        foreach (int values in resourceAmount2.Values) {


            Debug.Log(values);
        }
    }

   
}
