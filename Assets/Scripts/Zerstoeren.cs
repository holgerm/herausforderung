using UnityEngine;
using System.Collections;

public class Zerstoeren : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D getroffenesObjekt) {
		getroffenesObjekt.SendMessage ("zerstoeren", SendMessageOptions.DontRequireReceiver);
		Destroy (gameObject);
	}
}
