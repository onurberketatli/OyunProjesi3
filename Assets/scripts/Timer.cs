using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class Timer : MonoBehaviour
{
    public float timer = 0;
    [SerializeField] TextMeshProUGUI timerYazi;
    [SerializeField] GameObject buffPanel;
    [SerializeField] TextMeshProUGUI canText;
    int can = 200;
    [SerializeField] Image moliSprite;
    [SerializeField] Image cansprite;
    bool buffOpen = false;
    float timer2 = 0;


    void Start()
    {
        buffPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        RefreshTimer();

        if(timer2 > 10f)
        {
            OyunuDurdur();
        }

        timer2 += Time.deltaTime;
    }


    public void RefreshTimer()
    {
        timer += Time.deltaTime;
        timerYazi.text = timer.ToString("f0");
    }

    void OyunuDurdur()
    {
        timer2 = 0;
        Time.timeScale = 0f; // Oyun zamanýný durdur
        buffPanel.SetActive(true);

    }

    public void Birinci()
    {
        Time.timeScale = 1f; // Oyun zamanýný durdur
        buffPanel.SetActive(false);
        moliSprite.color = Color.grey;


    }

    public void Ikinci()
    {
        Time.timeScale = 1f; // Oyun zamanýný durdur
        buffPanel.SetActive(false);


    }

    public void Ucuncu()
    {
        Time.timeScale = 1f;
        buffPanel.SetActive(false);
        canText.text = can.ToString();
        cansprite.color = Color.grey;
    }
}
