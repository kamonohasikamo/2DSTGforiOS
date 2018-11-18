using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

    public GameObject bulletPrefab;
    private AudioSource laser2;

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

        if (pos.x > -2.22 && pos.x < 2.22)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.gameObject.transform.position = new Vector3(pos.x - 0.1f, pos.y, pos.z);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.gameObject.transform.position = new Vector3(pos.x + 0.1f, pos.y, pos.z);
            }
        }

        else if (pos.x >= 2.22)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.gameObject.transform.position = new Vector3(pos.x - 0.1f, pos.y, pos.z);
            }
        }

        else if (pos.x <= -2.22)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.gameObject.transform.position = new Vector3(pos.x + 0.1f, pos.y, pos.z);
            }
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

