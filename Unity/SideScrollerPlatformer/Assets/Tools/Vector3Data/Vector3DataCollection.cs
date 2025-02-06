using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

[CreateAssetMenu(menuName = "Collections/Vector3DataList")]
public class Vector3DataCollection : ScriptableObject
{
    [FormerlySerializedAs("vector3Datas")] public List<Vector3Data> vector3DataObjs;
    
    public int index;
    
    public void RandomizeIndex()
    {
        index = Random.Range(0, vector3DataObjs.Count);
    }
    
    public void RandomizeList()
    {
        System.Random rnd = new System.Random();
        vector3DataObjs = vector3DataObjs.OrderBy(x => rnd.Next()).ToList();
    } 
    
    public void ClearList()
    {
        vector3DataObjs.Clear();
    }
    
    public void AddPositionToList(Transform obj)
    {
        var newObj = CreateInstance<Vector3Data>();
        newObj.value = obj.position;
        vector3DataObjs.Add(newObj);
    }
    
    public void AddRectTransform (RectTransform obj)
    {
        var newObj = CreateInstance<Vector3Data>();
        newObj.value = obj.position;
        vector3DataObjs.Add(newObj);
    }
    
    public void TransformToVector3Data (IEnumerable<Transform> transforms)
    {
        foreach (var obj in transforms)
        {
            var temp = CreateInstance<Vector3Data>();
            temp.value = obj.position;
            vector3DataObjs.Add(temp);
        }
    }
}