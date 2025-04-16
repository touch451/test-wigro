using System;
using UnityEngine;

public class ScreenBase : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;

    private bool isShown;

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    protected virtual void PreparingToShow()
    {
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
    }

    public virtual void ShowScreen(float duration = 0.5f)
    {
        if (isShown) return;

        isShown = true;
        PreparingToShow();
        gameObject.SetActive(true);

        DoFade(1f, duration, onComplete:
            () => canvasGroup.blocksRaycasts = true);
    }

    public virtual void HideScreen(float duration = 0.5f)
    {
        if (!isShown) return;

        isShown = false;
        canvasGroup.blocksRaycasts = false;

        DoFade(0f, duration, onComplete:
            () => gameObject.SetActive(false));
    }

    private void DoFade(float endValue, float duration, Action onComplete = null)
    {
        StartCoroutine(ScriptUtils.DoFadeCanvasGroup_Co(
            canvasGroup, endValue, duration, onComplete));
    }
}
