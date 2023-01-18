using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labdakullanilanlar : MonoBehaviour
{
    IEnumerator coroutine;
    int i = 0;
    void Start()
    {
        print("Şu anki zaman: " + Time.time);
        coroutine = AlarmKur(3.0f);
        StartCoroutine(coroutine);
    }
    IEnumerator AlarmKur(float sure)
    {
        while (true)
        {
            yield return new WaitForSeconds(sure);
            i += 1;
            print("Alarm çalıyor: #"+i+" " + Time.time);
        }
    }
    void Update()
    {
        if (i==3)
        {
            StopCoroutine(coroutine);
        }
    }
}
