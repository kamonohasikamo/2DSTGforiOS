using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

    public GameObject bulletPrefab;
    private AudioSource laser2;
    public bool moveL = false;
    public bool moveR = false;

    // Use this for initialization
    void Start()
    {
        laser2 = GetComponent<AudioSource>();
        transform.position = new Vector3(0, -4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.gameObject.transform.position;

        if (pos.x > -2.2 && pos.x < 2.2)
        {
            if (Input.GetKey(KeyCode.LeftArrow) && moveR == false)
            {
                moveL = true;
                this.gameObject.transform.position = new Vector3(pos.x - 0.1f, pos.y, pos.z);
            }
            if (Input.GetKey(KeyCode.RightArrow) && moveL == false)
            {
                moveR = true;
                this.gameObject.transform.position = new Vector3(pos.x + 0.1f, pos.y, pos.z);
            }

            if (Input.GetKeyUp(KeyCode.LeftArrow)) { moveL = false; }
            if (Input.GetKeyUp(KeyCode.RightArrow)) { moveR = false; }
        }

        else if (pos.x >= 2.2)
        {
            if (Input.GetKey(KeyCode.LeftArrow) && moveR == false)
            {
                this.gameObject.transform.position = new Vector3(pos.x - 0.1f, pos.y, pos.z);
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow)) { moveL = false; }
            if (Input.GetKeyUp(KeyCode.RightArrow)) { moveR = false; }
        }

        else if (pos.x <= -2.2)
        {
            if (Input.GetKey(KeyCode.RightArrow) && moveL == false)
            {
                this.gameObject.transform.position = new Vector3(pos.x + 0.1f, pos.y, pos.z);
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow)) { moveL = false; }
            if (Input.GetKeyUp(KeyCode.RightArrow)) { moveR = false; }
        }

        /*if (Input.GetKey (KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey (KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            laser2.PlayOneShot(laser2.clip);
        }
    }
}

