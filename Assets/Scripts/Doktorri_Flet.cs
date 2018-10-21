using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doktorri_Flet : MonoBehaviour 
{
	public string dialogue;
	private Shfaq_Msg dMan;
	
	public string[] dialogueLine;

	// Use this for initialization
	void Start () 
	{
		dMan = FindObjectOfType<Shfaq_Msg>();
		//dialogueLine.size = 2;
		//dialogLines[1] = 'You must be careful, Explorer. Keep away from the water';
		//dialogLines[2] = 'Rising sea levels and melting ice have claimed lives before.';
	}
	
	// Update is called once per frame
	void Update () 
	{		
	}
	
	void OnTriggerStay2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")	
		{
			if(Input.GetKeyUp(KeyCode.Q))
			{
				//dMan.ShowBox(dialogue);
				if(!dMan.dialogActive)
				{
					dMan.dialogLines = dialogueLine;
					dMan.currentLine = 0;
					dMan.ShowDialog();
				}
			}
		}
	}
}
