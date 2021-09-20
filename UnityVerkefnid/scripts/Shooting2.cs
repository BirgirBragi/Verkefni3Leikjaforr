using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting2 : MonoBehaviour
{
    //birgir bragi
    //breytur skilgreindar
    public GameObject bullet;
    public float speed = 100f;
    public float timeToWait = 0.5f;
    public float done = 0.0f;    
    void Update()
    {
        if (Input.GetKey("z") && Time.time > done)//ef ýtt er á z takkann og það hefur ekki verið ýtt á hann í smá tíma
        {
            done = Time.time + timeToWait;//stilli breytur sem reikna hvenær næsta kúla má komu, s.s. hvenær næsta input er registerað
            //Debug.Log("skjOtttttttta");

            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;//spawna bullet/kúlu
            //GameObject instBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();//breyta með rigidbody kúlunnar
            instBulletRigidbody.AddForce(transform.forward * speed);//læt kúluna fljúga áfram
            Destroy(instBullet, 0.5f);//kúlu eytt eftir 0.5sek
        }
        
    }
}
