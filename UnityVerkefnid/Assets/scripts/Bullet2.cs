﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{

    //er ekki að nota þessa skriftu, þetta er skriftan þín sem ég notaði til þess að vinna með

    public Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        Debug.Log("konni hér");

        if (collision.collider.tag == "kassi")
        {
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
            Debug.Log("hitti óvin");
            
        }

        else if (collision.collider.name != "byssa")
        {
            gameObject.SetActive(false);
            // Debug.Log("kúlu líka eytt eytt");
        }
    }
}
