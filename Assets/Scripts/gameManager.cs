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
        InterfaceText.text = "º®¿¡ ºÎµúÇû´Ù...";
		Invoke("ResetInterfaceText", 2.0f);
	}

	public void ResetInterfaceText(string text)
	{
		InterfaceText.text = " ";
	}
    


}

