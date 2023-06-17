
using UnityEngine;
using System.Collections;

public class TimerDestroy : MonoBehaviour
{
    public float timerDuration = 3f; // ������������ ������� � ��������

    private void Start()
    {
        // ��������� ��������
        StartCoroutine(DestroyWithDelay());
    }

    private IEnumerator DestroyWithDelay()
    {
        // ���� �������� �����
        yield return new WaitForSeconds(timerDuration);

        // ���������� ������
        Destroy(gameObject);
    }
}