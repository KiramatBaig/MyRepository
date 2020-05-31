using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	Vector3 initialPos;
    // Start is called before the first frame update
    private void Start()
    {
        initialPos = transform.position;
    }
	private void onCollisionEnter(Collision collision)
	{
		if(collision.transform.CompareTag("Wall"))
		{
			GetComponent<Rigidbody>().velocity = Vector3.zero;
			transform.position = initialPos;
		}
	}
    
}
