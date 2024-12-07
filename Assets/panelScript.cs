using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class panelScript : MonoBehaviour
{
    public Text tip;
 
    // Start is called before the first frame update
    void Start()
    {
        tip.text = "Добро пожаловать";
    
    }

    public void circuit()
    {
        tip.text = "Главная плата.";
    }

    public void barrel()
    {
        tip.text = "Барабан - используется для переноса тонера на бумагу.";
    }

    public void cup()
    {
        tip.text = "Емкость для сбора отработавших чернил.";
    }

    public void scaner()
    {
        tip.text = "Сканер - используется для сканирования бумаги.";
    }

    public void cartridge()
    {
        tip.text = "Картридж - для загрузки тонера в МФУ";
    }

    public void transition()
    {
        tip.text = "Устройство для переноса изображения";
    }

    public void print()
    {
        tip.text = "Печатающая головка";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
