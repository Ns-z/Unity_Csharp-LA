using System;
using UnityEngine;
using System.Collections.Generic;

public class Dictionary_2 : MonoBehaviour {
    [SerializeField]
    public enum ResourceType {

        Gold,
        Metal,
        Wood,
        Silver

    }

    [Serializable]
    public class ResourceTypeAmount {

        public ResourceType resourceType;
        public int amount;

    }

    [SerializeField]
    private List<ResourceTypeAmount> resourceTypeList;

    private Dictionary<ResourceType, int> resourceDictionary = new Dictionary<ResourceType, int>();

    void Start() {
        foreach (ResourceTypeAmount resource in resourceTypeList) {

            resourceDictionary[resource.resourceType] = resource.amount;
            //resourceDictionary.Add(resource.resourceType, resource.amount);

        }

        Debug.Log(ResourceType.Gold + ":" + resourceDictionary[ResourceType.Gold]);

    }
}