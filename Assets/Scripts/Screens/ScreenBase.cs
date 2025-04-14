using System;
using System.Collections;
using UnityEngine;

public class ScreenBase : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;

    private void Awake()
    {
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    public void ShowScreen()
    {
        gameObject.SetActive(true);

        DoFade(1f, 0.5f, onComplete:
            () => canvasGroup.blocksRaycasts = true);
    }

    public void HideScreen()
    {
        canvasGroup.blocksRaycasts = false;

        DoFade(1f, 0.5f, onComplete:
            () => gameObject.SetActive(false));
    }

    private void DoFade(float endValue, float duration, Action onComplete = null)
    {
        StartCoroutine(DoFade_Co());

        IEnumerator DoFade_Co()
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
    }
}
