//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;

//public class ROTATE : MonoBehaviour
//{
    //public Transform coin;
    //public GameObject sprenging;
    //private Text countText;
    //public GameObject bullet;
    //private int count;

    //void Start(){
        //countText = GameObject.Find("Text").GetComponent<Text>();
        //count = gameObject.GetComponent<Bullet>().count;
        //SetCountText();
    //}
    
    // Update is called once per frame
    //void Update()
    //{
        //transform.Rotate(new Vector3(0, 5, 0)*Time.deltaTime);
    //}
    //private void OnCollisionEnter(Collision collision){
        //if (collision.collider.tag == "player")
        //{
            //Instantiate(sprenging, transform.position, transform.rotation);
            //Destroy(gameObject);
            //gameObject.SetActive(false);
            //count = count + 2;//færð stig
            //SetCountText();//kallar í aðferðina
        //}
    //}
    //void SetCountText()//hér er aðferðin
    //{
        //countText.text = "Stig: " + count.ToString();
    //}
//}
