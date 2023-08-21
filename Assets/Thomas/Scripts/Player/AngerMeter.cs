using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerMeter : MonoBehaviour
{
    public float angerSpeedPercentage = 200, angerSpeedMax = 400, angerSpeedMin = 200;

    public bool isIncreasing = true, isDecreasing = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (angerSpeedPercentage >= angerSpeedMax)
        isIncreasing = false;

        if (isIncreasing)
        angerSpeedPercentage += Time.deltaTime * 5;

        if (angerSpeedPercentage <= angerSpeedMin)
        isDecreasing = false;

        if (isDecreasing)
        angerSpeedPercentage -= Time.deltaTime * 5;
    }
}
