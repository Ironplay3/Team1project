
using UnityEngine;
using System.Collections;

public class TimerDestroy : MonoBehaviour
{
    public float timerDuration = 3f; // Длительность таймера в секундах

    private void Start()
    {
        // Запускаем корутину
        StartCoroutine(DestroyWithDelay());
    }

    private IEnumerator DestroyWithDelay()
    {
        // Ждем заданное время
        yield return new WaitForSeconds(timerDuration);

        // Уничтожаем объект
        Destroy(gameObject);
    }
}