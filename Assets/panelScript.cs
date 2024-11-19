using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class panelScript : MonoBehaviour
{

    public Text tip;
    public bool PracticeStarted = false;
    public bool WaterServed = false;
    public bool BeansServed = false;
    public bool CupsSet = false;
    public bool CoffeeMaking = false;
    public bool CoffeeMade = false;
    public bool Cleaned = false;

    public UnityEngine.UI.Button btn1;
    public UnityEngine.UI.Button btn2;
    public UnityEngine.UI.Button btn3;
    public UnityEngine.UI.Button btn4;

    // Start is called before the first frame update
    void Start()
    {
        tip.text = "����� ���������� � ��������� ���������� Melitta Caffeo T";
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false); 
        btn3.gameObject.SetActive(false); 
        btn4.gameObject.SetActive(false);
    }

    public void StartPractice()
    {
        Machine.GetComponent<MachineLogic>().CupSet = false;
        Machine.GetComponent<MachineLogic>().BeansServed = false;
        Machine.GetComponent<MachineLogic>().WaterFilled = false;
        Machine.GetComponent<MachineLogic>().CoffeeSelected = false;
        Machine.GetComponent<MachineLogic>().CoffeeDone = false;
        Machine.GetComponent<MachineLogic>().Blocked = false;
        try
        {
            Destroy(Cup1.transform.GetChild(0).gameObject);
            Destroy(Cup2.transform.GetChild(0).gameObject);
        }
        catch
        {

        }
       WaterServed = false;
       BeansServed = false;
       CupsSet = false;
       CoffeeMaking = false;
       CoffeeMade = false;
       Cleaned = false;

    PracticeStarted =true;
        tip.text = "������� �� ��������� ����� ����������, ����� ������� ����.";


    }

    public void ServeBeans()
    {
        Machine.GetComponent<MachineLogic>().CupSet = false;
        Machine.GetComponent<MachineLogic>().BeansServed = false;
        Machine.GetComponent<MachineLogic>().WaterFilled = true;
        Machine.GetComponent<MachineLogic>().CoffeeSelected = false;
        Machine.GetComponent<MachineLogic>().CoffeeDone = false;
        Machine.GetComponent<MachineLogic>().Blocked = false;
        try
        {
            Destroy(Cup1.transform.GetChild(0).gameObject);
            Destroy(Cup2.transform.GetChild(0).gameObject);
        }
        catch
        {

        }
        PracticeStarted = true;
        BeansServed = false;
        CupsSet = false;
        CoffeeMaking = false;
        CoffeeMade = false;
        Cleaned = false;

        WaterServed = true;
        tip.text = "������� �� ������ ������ ����������, � ����� �� ����� � �������� �������, ����� ������� ����� � ����������";

        btn1.gameObject.SetActive(true);
    }

    public void SetCups()
    {
        Machine.GetComponent<MachineLogic>().CupSet = false;
        Machine.GetComponent<MachineLogic>().BeansServed = true;
        Machine.GetComponent<MachineLogic>().WaterFilled = true;
        Machine.GetComponent<MachineLogic>().CoffeeSelected = false;
        Machine.GetComponent<MachineLogic>().CoffeeDone = false;
        Machine.GetComponent<MachineLogic>().Blocked = false;
        try
        {
            Destroy(Cup1.transform.GetChild(0).gameObject);
            Destroy(Cup2.transform.GetChild(0).gameObject);
        }
        catch
        {

        }
        PracticeStarted = true;
        BeansServed = true;
        CupsSet = false;
        CoffeeMaking = false;
        CoffeeMade = false;
        Cleaned = false;
        WaterServed = true;

        tip.text = "������� �� ������ ������, ����� ���������� �� � ����������. �����, ������ ������ �� ������, ����� ���������� ��� ������";

        btn2.gameObject.SetActive(true);
    }

    public void MakeCoffee()
    {
        Machine.GetComponent<MachineLogic>().CupSet = true;
        Machine.GetComponent<MachineLogic>().BeansServed = true;
        Machine.GetComponent<MachineLogic>().WaterFilled = true;
        Machine.GetComponent<MachineLogic>().CoffeeSelected = false;
        Machine.GetComponent<MachineLogic>().CoffeeDone = false;
        Machine.GetComponent<MachineLogic>().Blocked = false;
        try
        {
            Destroy(Cup1.transform.GetChild(0).gameObject);
            Destroy(Cup2.transform.GetChild(0).gameObject);
        }
        catch
        {

        }
        PracticeStarted = true;
        BeansServed = true;
        CupsSet = true;
        CoffeeMaking = false;
        CoffeeMade = false;
        Cleaned = false;
        WaterServed = true;

        tip.text = "�������� ���������� � ������� ������ ����� �����. �������� ����� ������������� ����. ���� �� ������ ����������� ���� � �������, ������� �� ��������� ��� ������, ����� ������������ ��� � ����������.";
        btn3.gameObject.SetActive(true);
    }

    public void TuneCoffee()
    {
        Machine.GetComponent<MachineLogic>().CupSet = true;
        Machine.GetComponent<MachineLogic>().BeansServed = true;
        Machine.GetComponent<MachineLogic>().WaterFilled = true;
        Machine.GetComponent<MachineLogic>().CoffeeSelected = true;
        Machine.GetComponent<MachineLogic>().CoffeeDone = false;
        Machine.GetComponent<MachineLogic>().Blocked = false;
        
        PracticeStarted = true;
        BeansServed = true;
        if (!CupsSet)
        {
            Cup1.GetComponent<Animator>().SetBool("first", true);
            CupsSet = true;
        }
        CoffeeMade = false;
        Cleaned = false;
        WaterServed = true;
        CoffeeMaking =true;


        tip.text = "������������� ����� � �������� ���� ���� ���� ����� ����";
    }

    public void CleanCoffee()
    {
        Machine.GetComponent<MachineLogic>().BeansServed = true;
        Machine.GetComponent<MachineLogic>().WaterFilled = true;
        Machine.GetComponent<MachineLogic>().CoffeeSelected = false;
        Machine.GetComponent<MachineLogic>().CoffeeDone = true;
        Machine.GetComponent<MachineLogic>().Blocked = false;
       
        PracticeStarted = true;
        BeansServed = true;
        CoffeeMaking = false;
        CoffeeMade = true;
        Cleaned = false;
        WaterServed = true;

        CoffeeMade = true;
        tip.text = "������� ������ �� ��� ���������� � ������� �� ������, ����� ��������� ������������ ���� � ����.";
        btn4.gameObject.SetActive(true);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
