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
        tip.text = "����� ����������";
    
    }

    public void circuit()
    {
        tip.text = "������� �����.";
    }

    public void barrel()
    {
        tip.text = "������� - ������������ ��� �������� ������ �� ������.";
    }

    public void cup()
    {
        tip.text = "������� ��� ����� ������������ ������.";
    }

    public void scaner()
    {
        tip.text = "������ - ������������ ��� ������������ ������.";
    }

    public void cartridge()
    {
        tip.text = "�������� - ��� �������� ������ � ���";
    }

    public void transition()
    {
        tip.text = "���������� ��� �������� �����������";
    }

    public void print()
    {
        tip.text = "���������� �������";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
