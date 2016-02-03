using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	public GameObject objektDemWirFolgen;

	Vector3 abstandZumObjekt;

	// Use this for initialization
	void Start () {
//		abstandZumObjekt = transform.position - objektDemWirFolgen.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (objektDemWirFolgen != null) {
//			transform.LookAt(objektDemWirFolgen.transform);
		
			Vector3 zwischenWert = transform.position;
			zwischenWert.x = objektDemWirFolgen.transform.position.x + abstandZumObjekt.x;
			transform.position = zwischenWert; 
		}
	
	}
}