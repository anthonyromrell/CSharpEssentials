using UnityEngine;
using TMPro;  
using UnityEngine.Events;

public class SimpleTextBehaviour : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public UnityEvent startEvent;
    
    private void Awake()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }
    
    public void UpdateText(SimpleIntData obj)
    {
        textObj.text = obj.value.ToString();
    }
}