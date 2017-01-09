using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        movement();
	}
    void movement()
    {
       
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(this.transform.position.x == 0)
            {
                if(this.transform.position.y == 2)
                {
                    this.transform.position = new Vector3(-2, 0, 0);
                }
                else
                {
                    this.transform.position = new Vector3(2, 0, 0);
                }
                
            }
            else if (this.transform.position.x == 2)
            {
                this.transform.position = new Vector3(0, 2, 0);
            }
            else //this.transform.position.x == -2
            {
                this.transform.position = new Vector3(0, -2, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (this.transform.position.x == 0)
            {
                if (this.transform.position.y == 2)
                {
                    this.transform.position = new Vector3(2, 0, 0);
                }
                else
                {
                    this.transform.position = new Vector3(-2, 0, 0);
                }

            }
            else if (this.transform.position.x == 2)
            {
                this.transform.position = new Vector3(0, -2, 0);
            }
            else //this.transform.position.x == -2
            {
                this.transform.position = new Vector3(0, 2, 0);
            }
        }
    }
}
