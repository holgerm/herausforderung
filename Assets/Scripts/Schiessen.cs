using UnityEngine;
using System.Collections;

public class Schiessen : MonoBehaviour {

	public void schiess() {

		gameObject.GetComponentInParent<greg> ().schiess ();
	}
}
