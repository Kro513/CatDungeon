using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System.Threading;
using System;
using Unity.VisualScripting;

public class gameManager : MonoBehaviour
{
    public Text InterfaceText;
	public static gameManager I;

	void Awake()
	{
		I = this;
	}
	

	bool Clickable = false;
    // Start is called before the first frame update
    void Start()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ListOn()
    {
        if(Clickable == false)
        {
            Clickable = true;
        }
    }

    public void OutputInterfaceText(string text)
    {
        InterfaceText.text = "���� �ε�����...";
	}

	public void NPCInterfaceText(string text)
	{
		InterfaceText.text = "�Ϳ��� ȸ�� ����̴�.";
	}

	public void BoxInterfaceText(string text)
	{
		InterfaceText.text = "���ڰ� ���� �����ִ�.";
	}

	public void DeleteInterfaceText(string text)
	{
		InterfaceText.text = " ";
	}






}

