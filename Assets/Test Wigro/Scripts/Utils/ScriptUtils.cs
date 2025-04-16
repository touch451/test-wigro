using System;
using System.Collections;
using UnityEngine;

public static class ScriptUtils
{
    public static IEnumerator DoFadeCanvasGroup_Co(
        CanvasGroup canvasGroup, float endValue, float duration, Action onComplete = null)
    {
        float startAlpha = canvasGroup.alpha;
        float time = 0f;

        while (time < duration)
        {
            time += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, endValue, time / duration);
            yield return null;
        }

        canvasGroup.alpha = endValue;
        onComplete?.Invoke();
    }

    public static IEnumerator DoMoveAnchorX_Co(
        RectTransform rect, float endValue, float duration, Action onComplete = null)
    {
        Vector2 startPos = rect.anchoredPosition;
        float time = 0f;

        while (time < duration)
        {
            time += Time.deltaTime;
            float xPos = Mathf.Lerp(startPos.x, endValue, time / duration);
            rect.anchoredPosition = new Vector2(xPos, startPos.y);
            yield return null;
        }

        rect.anchoredPosition = new Vector2(endValue, startPos.y);
        onComplete?.Invoke();
    }

    public static IEnumerator DoScale_Co(
        RectTransform rect, Vector3 endValue, float duration, Action onComplete = null)
    {
        Vector3 startScale = rect.localScale;
        float time = 0f;

        while (time < duration)
        {
            time += Time.deltaTime;
            
            Vector3 scale = Vector3.Lerp(startScale, endValue, time / duration);
            rect.localScale = scale;
            yield return null;
        }

        rect.localScale = endValue;
        onComplete?.Invoke();
    }
}
