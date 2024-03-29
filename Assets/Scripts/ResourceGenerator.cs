using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour
{
    private float timer;
    private float timerMax;
    private BuildingTypeSO buildingType;

    private void Awake() {
        buildingType = GetComponent<BuildingTypeHolder>().buildingType;
        timerMax = buildingType.resourceGeneratorData.timerMax;
    }

    private void Update() {
        timer -= Time.deltaTime;
        if(timer <= 0) {
            timer += timerMax;
            ResourcesManager.Instance.AddResource(buildingType.resourceGeneratorData.resourceType, 1);
        }
    }
}
