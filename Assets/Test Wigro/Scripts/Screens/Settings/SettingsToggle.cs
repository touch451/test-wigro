using UnityEngine;

public class SettingsToggle : MonoBehaviour
{
    [SerializeField] private RectTransform handle;

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    public void SwitchToggle(bool isOn)
    {
        float posX = isOn ? 50f : -50f;
        StartCoroutine(ScriptUtils.DoMoveAnchorX_Co(handle, posX, 0.25f));
    }

    public void SetToggle(bool isOn)
    {
        float posX = isOn ? 50f : -50f;
        handle.anchoredPosition = new Vector2(posX, handle.anchoredPosition.y);
    }
}
