using UnityEngine;
using System.Collections;

public static class InputC {
	public static float getHorz() {
	#if UNITY_STANDALONE
		if(Input.GetKey(KeyCode.LeftArrow)) {
			return -1;
		}
		else if(Input.GetKey(KeyCode.RightArrow)) {
			return 1;
		}
		else {
			return 0;
		}
	#endif
	}

	public static bool jump() {
	#if UNITY_STANDALONE
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			return true;
		}
		else {
			return false;
		}
	#endif
	}

	public static bool melee() {
	#if UNITY_STANDALONE
		if(Input.GetKeyDown(KeyCode.Z)) {
			return true;
		}
		else {
			return false;
		}
	}   
	#endif

	public static bool ranged() {
	#if UNITY_STANDALONE
		if(Input.GetKeyDown(KeyCode.X)) {
			return true;
		}
		else {
			return false;
		}
	#endif
	}
}
