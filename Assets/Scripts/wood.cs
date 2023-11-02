using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSway : MonoBehaviour
{
    public float swaySpeedX = 0.5f;
    public float swaySpeedY = 0.75f;
    public float swayAmountX = 0.25f;
    public float swayAmountY = 0.15f;

    private Vector3 initialPosition;
    private float timeOffsetX;
    private float timeOffsetY;

    void Start()
    {
        initialPosition = transform.position;
        timeOffsetX = Random.Range(0, 2 * Mathf.PI);
        timeOffsetY = Random.Range(0, 2 * Mathf.PI);
    }

    void Update()
    {
        // Используем синусоидальные функции для создания колебаний
        float swayX = Mathf.Sin(Time.time * swaySpeedX + timeOffsetX) * swayAmountX;
        float swayY = Mathf.Sin(Time.time * swaySpeedY + timeOffsetY) * swayAmountY;

        // Обновляем позицию объекта
        Vector3 newPosition = initialPosition + new Vector3(swayX, swayY, 0);
        transform.position = newPosition;
    }
}

