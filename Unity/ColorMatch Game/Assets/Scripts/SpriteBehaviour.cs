using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    private void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }

    public void ChangeRendererColor(ColorIDDataList obj)
    {
        rendererObj.color = obj.currentColor.value;
    }
}
