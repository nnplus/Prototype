using UnityEngine;
using System.Collections;



public class CombatGUI : MonoBehaviour {
	public Texture[] slot = new Texture[4];
	public int w,h;

	
	void OnGUI(){
		
		//Hotbar
		if (GUI.Button(new Rect((Screen.width - w) * 0.01f,
            (Screen.height - h) * 0.95f,
            w,
            h),slot[0])){
			Debug.Log("Clicked 1");
		
		}
		
		if (GUI.Button(new Rect((Screen.width - w) * 0.06f,
            (Screen.height - h) * 0.95f,
            w,
            h),slot[1])){
			Debug.Log("Clicked 2");
		}
		
		if (GUI.Button(new Rect((Screen.width - w) * 0.11f,
            (Screen.height - h) * 0.95f,
            w,
            h),slot[2])){
			Debug.Log("Clicked 3");
		}
		
		if (GUI.Button(new Rect((Screen.width - w) * 0.16f,
            (Screen.height - h) * 0.95f,
            w,
            h),slot[3])){
			Debug.Log("Clicked 4");
		}
		
		//Health Bar
		
		
	}
}
