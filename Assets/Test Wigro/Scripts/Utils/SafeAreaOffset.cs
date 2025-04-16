using UnityEngine;

public class SafeAreaOffset : MonoBehaviour
{
    [SerializeField] private Canvas canvas;

    [Space]
    [SerializeField] bool topOffset;
    [SerializeField] bool bottomOffset;

    private void Start()
    {
        if (canvas == null)
        {
            Debug.LogError(name + " Canvas reference is null.");
            return;
        }
        else
        {
            SetOffset();
        }  
    }

    private void SetOffset()
    {
        if (!TryGetComponent(out RectTransform rect))
            return;

        if (topOffset)
        {
            var curPos = rect.anchoredPosition;
            float offset = (Screen.height - Screen.safeArea.yMax) / canvas.scaleFactor;
            rect.anchoredPosition = new Vector2(curPos.x, curPos.y - offset);
        }

        if (bottomOffset)
        {
            var curPos = rect.anchoredPosition;
            float offset = Screen.safeArea.yMin / canvas.scaleFactor;
            rect.anchoredPosition = new Vector2(curPos.x, curPos.y + offset);
        }
    }
}
