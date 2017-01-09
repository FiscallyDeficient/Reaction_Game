using UnityEngine;
using System.Collections;

public class DeathController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Contains("enemy")) 
        {
            Application.LoadLevel(1);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
