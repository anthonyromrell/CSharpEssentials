using System;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(menuName = "System/Vector3DataSystem")]
public class Vector3DataSystem : ScriptableObject
{
    //public GameAction ReturnAction;
    public Vector3DataCollection currentList;
    public Vector3DataCollection holdList;
    public int index;

    // private void OnEnable()
    // {
    //     if (ReturnAction != null) ReturnAction.raise += AddBack;
    // }

    public void RandomizeNum()
    {
        index = Random.Range(0, currentList.vector3DataObjs.Count - 1);
    }

    public void MoveListItem(Vector3DataCollection listA, Vector3DataCollection listB)
    {
        var currentObj = listA.vector3DataObjs[index];
        listB.vector3DataObjs.Add(currentObj);
        listA.vector3DataObjs.RemoveAt(index);
    }

    public void AddBack(object obj)
    {
        var vector3Obj = (Vector3Data) obj;
        currentList.vector3DataObjs.Add(vector3Obj);
    }
    
    public void MoveToCurrentList()
    {
        var currentObj = currentList.vector3DataObjs[index];
        currentList.vector3DataObjs.Add(currentObj);
        holdList.vector3DataObjs.RemoveAt(index);
    }
    
    public void MoveToCurrentList(Vector3Data currentObj)
    {
        currentList.vector3DataObjs.Add(currentObj);
    }

    public void MoveToHoldList()
    {
        var currentObj = currentList.vector3DataObjs[index];
        holdList.vector3DataObjs.Add(currentObj);
        currentList.vector3DataObjs.RemoveAt(index);
    }
    
    public Vector3Data MoveFromCurrentList()
    {
        var currentObj = currentList.vector3DataObjs[index];
        currentList.vector3DataObjs.RemoveAt(index);
        return currentObj;
    }

    public Vector3 ReturnCurrentVector3()
    {
        return currentList.vector3DataObjs[index].value;
    }

    public Vector3 ReturnRandomVector3()
    {
        RandomizeNum();
        var obj = ReturnCurrentVector3();
        return obj;
    }

    private void OnEnable()
    {
        ClearAll();
    }

    public void ClearAll()
    {
        currentList.vector3DataObjs.Clear();
        holdList.vector3DataObjs.Clear();
    }
}