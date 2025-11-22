using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu()]
public class RecipeSO : ScriptableObject
{
    public List<List<KitchenObjectSO>> kitchenObjectSOList;
    public string recipeName;
    
}