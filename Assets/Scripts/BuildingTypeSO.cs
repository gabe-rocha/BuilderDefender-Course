using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Building Type")]
public class BuildingTypeSO : ScriptableObject
{
    public string nameString;
    public GameObject prefab;
    public ResourceGeneratorData resourceGeneratorData;
}
