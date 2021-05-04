using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager : MonoBehaviour {

    public static ResourcesManager Instance { get; private set; }      

    private Dictionary<ResourceTypeSO, int> resourceAmountDictionary = new Dictionary<ResourceTypeSO, int>();
    private ResourceTypeListSO resourceTypeList;

    private void Awake() {

        Instance = this;

        resourceTypeList = Resources.Load<ResourceTypeListSO>(typeof(ResourceTypeListSO).Name);

        foreach (var resourceType in resourceTypeList.list) {
            resourceAmountDictionary.Add(resourceType, 0);
        }
    }


    private void Update() {

        if(Input.GetKeyDown(KeyCode.T)){
            AddResource(resourceTypeList.list[0], 2);
            TestLogResourceAmountDictionary();
        }
    }

    private void TestLogResourceAmountDictionary() {
        foreach (var resource in resourceAmountDictionary) {
            Debug.Log(resource.Key.nameString + ": " + resource.Value);

        }
    }

    public  void AddResource(ResourceTypeSO resourceType, int amount){
        resourceAmountDictionary[resourceType] += amount;
        TestLogResourceAmountDictionary();
    }




}
