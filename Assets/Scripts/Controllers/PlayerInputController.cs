using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerInputController : CatCharacterController
{
    private Camera _camera;
	private string text;
	public GameObject panel;


	public void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Wall_Collision")
		{
			StartCoroutine("UICoroutine");
		}

		if (coll.gameObject.tag == "NPC_Collision")
		{
			StartCoroutine("NPCCoroutine");
		}

		if (coll.gameObject.tag == "Box_Collision")
		{
			StartCoroutine("BoxCoroutine");
		}
	}
	IEnumerator UICoroutine()
	{
		
		ViewPanel();
		gameManager.I.OutputInterfaceText(text);
		

		yield return new WaitForSeconds(2.0f);

		ClosePanel();
		gameManager.I.DeleteInterfaceText(text);
	}

	IEnumerator NPCCoroutine()
	{

		ViewPanel();
		gameManager.I.NPCInterfaceText(text);


		yield return new WaitForSeconds(2.0f);

		ClosePanel();
		gameManager.I.DeleteInterfaceText(text);
	}

	IEnumerator BoxCoroutine()
	{

		ViewPanel();
		gameManager.I.BoxInterfaceText(text);


		yield return new WaitForSeconds(2.0f);

		ClosePanel();
		gameManager.I.DeleteInterfaceText(text);
	}






	public void ViewPanel()
	{
		panel.SetActive(true);
	}

	public void ClosePanel()
	{
		panel.SetActive(false);
	}




	private void Awake()
	{
		_camera = Camera.main;
	}

	public void OnMove(InputValue value)
	{
		Vector2 moveInput = value.Get<Vector2>().normalized;
		CallMoveEvent(moveInput);
	}

	public void OnLook(InputValue value)
	{
		Vector2 newAim = value.Get<Vector2>();
		Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
		newAim = (worldPos - (Vector2)transform.position).normalized;

		if (newAim.magnitude >= .9f)
		{
			CallLookEvent(newAim);
		}
	}

	public void OnFire(InputValue value)
	{
		Debug.Log("OnFire" + value.ToString());
	}
}
