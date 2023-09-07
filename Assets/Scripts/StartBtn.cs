using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
	public InputField playerNameInput;
	private string playerName;



	
	// Start is called before the first frame update
	void Start()
    {
    
	}

    // Update is called once per frame
    void Update()
    {
        
    }
	public void gameStart()
	{
		playerName = playerNameInput.text;

		if (playerName.Length >= 2 && playerName.Length <= 10)
		{
			PlayerPrefs.SetString("name", playerName);
			SceneManager.LoadScene("SampleScene");
		}
		

	}
	public void Awake()
	{
		
	}

}
