using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kassi : MonoBehaviour
{
    //public Text countText;
    //private static int count;
    public GameObject sprenging;
    void Start()
    {
       //countText = FindObjectOfType<Text>();
       //sprenging= GetComponent<Explosion>
        //count = 0;
        //SetCountText();
    }
    private void Update()
    {
        if (transform.position.y < -10) //ef kassinn er mjög langt niðri
        {
            Destroy(gameObject);//eyðir kassanum
            gameObject.SetActive(false);//eyðir kassanum
        }
    }
    private void OnCollisionEnter(Collision collision)//function sem sér um collision
    {
        if (collision.collider.tag == "kula2")//ef kúla rekst í kassann
        {
            Debug.Log("varð fyrir kúlu2");
            //count = count + 1;//færð stig
            //SetCountText();//kallar í aðferðina
            Sprengin();//kallar í functionið
        }
    }
    //void SetCountText()//hér er aðferðin
    //{
        //countText.text = "Stig: " + count.ToString();
    //}
    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);//spawnar sprengingunni inn í senuna í þeirri stöðu sem kassinn var
        Destroy(gameObject);//eyðir kassanum
        gameObject.SetActive(false);//eyðir kassanum
    }
}
