using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatCharacterController : MonoBehaviour
{
	public event Action<Vector2> OnMoveEvent;
	public event Action<Vector2> OnLookEvent;
	public Text playerName;

	private void Awake()
	{
		if(PlayerPrefs.HasKey("name"))
		{
			playerName.text = PlayerPrefs.GetString("name");
			Debug.Log("PlayerPrefs.GetString(\"name\"): " + PlayerPrefs.GetString("name"));
			Debug.Log("playerName.text: " + playerName.text);
		}
	}

	public void CallMoveEvent(Vector2 direction)
	{
		OnMoveEvent?.Invoke(direction);
	}

	public void CallLookEvent(Vector2 direction)
	{
		OnLookEvent?.Invoke(direction);
	}
}
