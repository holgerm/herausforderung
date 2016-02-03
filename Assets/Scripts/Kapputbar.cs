using UnityEngine;
using System.Collections;

public class Kapputbar : MonoBehaviour
{

	public int maxLeben = 3 ;
	public int leben;

	void Start ()
	{
		leben = maxLeben;
	}

	void zerstoeren ()
	{
		leben--;
		float health = (float)leben / maxLeben;
		gameObject.GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, health);

		if (leben <= 0)

			Destroy (gameObject);
	
	}
}
 


