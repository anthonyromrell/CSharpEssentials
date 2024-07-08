using UnityEngine;

[CreateAssetMenu (menuName = "Single Variables/Simple Int Data")]
public class SimpleIntData : ScriptableObject
{
    public int value;
    
    public void UpdateValue(int valueObj)
    {
        value += valueObj;
    }
}
