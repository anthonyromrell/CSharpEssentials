using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public IntData cash;
    public CollectablePanelBehaviour layoutObject;
    public List<Collectable> collectablesList;

    public void ReorderList()
    {
        collectablesList.Sort();
    }

    public void Collect(Collectable obj)
    {
        collectablesList.Add(obj);
    }
}
