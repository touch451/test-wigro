using UnityEngine;
using UnityEngine.UI;

public class TabletCanvasMatcher : MonoBehaviour
{
    [SerializeField] private float tabletMatch = 0;

    private void Start()
    {
        if (DeviceUtils.IsTablet())
        {
            if (TryGetComponent(out CanvasScaler canvasScaler))
                canvasScaler.matchWidthOrHeight = tabletMatch;
        }
    }
}
