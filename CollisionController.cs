using UnityEngine;
using System.Collections;

public class CollisionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Contains("enemy"))
        {
            Destroy(col.gameObject);
        }
    }
	// Update is called once per frame
	void Update () {
	    
	}
}
