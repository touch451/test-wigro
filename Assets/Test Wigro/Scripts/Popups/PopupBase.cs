using System;
using UnityEngine;

public class PopupBase : MonoBehaviour
{
    [SerializeField] private float timeToShow = 0.5f;
    [SerializeField] private float timeToHide = 0.5f;
    [SerializeField] private RectTransform body;

    private bool isShown;

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    protected virtual void PreparingToShow()
    {
        body.localScale = Vector3.zero;
    }

    public virtual void Show()
    {
        if (isShown) return;

        isShown = true;
        PreparingToShow();
        gameObject.SetActive(true);

        DoScale(Vector3.one, timeToShow);
    }

    public virtual void Hide()
    {
        if (!isShown) return;

        isShown = false;

        DoScale(Vector3.zero, timeToHide, onComplete:
            () => gameObject.SetActive(false));
    }

    private void DoScale(Vector3 endValue, float duration, Action onComplete = null)
    {
        StartCoroutine(ScriptUtils.DoScale_Co(
            body, endValue, duration, onComplete));
    }
}
