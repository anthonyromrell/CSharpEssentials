using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "AiBrain", menuName = "Ai/Brain")]
public class AiBrain : ScriptableObject
{
    [SerializeField] public AiBase aiBaseObj;

    public void ChangeBase(AiBase newObj)
    {
        aiBaseObj = newObj;
    }

    public void Navigate(NavMeshAgent agent)
    {
        aiBaseObj.RunAgent(agent);
    }
}