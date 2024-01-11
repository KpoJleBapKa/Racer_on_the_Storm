using System.Collections;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;

    private int m = 0;
    private int s = 0;

    private Coroutine _coroutine;

    public void StartTimer()
    {
        _coroutine = StartCoroutine(Timer_Coroutine());
    }

    private IEnumerator Timer_Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            s++;
            if (s == 60)
            {
                s = 0;
                m++;
            }
            UpdateText();
        }
    }

    public void ResetTimer()
    {
        PauseTimer();
        m = s = 0;
        UpdateText();
    }

    public void PauseTimer()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);
    }

    private void UpdateText()
    {
        TimerText.SetText(m.ToString("D2") + ":" + s.ToString("D2"));
    }
}
