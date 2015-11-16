using UnityEngine;
using System.Collections;

public static class InputC {
	public static float getHorz(short player) {
		if (player == 1) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				return -1;
			} else if (Input.GetKey (KeyCode.RightArrow)) {
				return 1;
			} else {
				return 0;
			}
		} 
		else {
			return 0.0f;
		}
	}

	public static bool jump(short player) {
		if (player == 1) {
			if(Input.GetKeyDown(KeyCode.Space)) {
				return true;
			}
			else {
				return false;
			}
		}
		else {
			return false;
		}
	}

	public static bool melee(short player) {
		if (player == 1) {
			if(Input.GetKeyDown(KeyCode.Z)) {
			return true;
			}
			else {
				return false;
			}
		} 
		else {
			return false;
		}
	}

	public static bool ranged(short player) {
		if (player == 1) {
			if(Input.GetKeyDown(KeyCode.X)) {
				return true;
			}
			else {
				return false;
			}
		}
		else {
			return false;
		}
	}
}
