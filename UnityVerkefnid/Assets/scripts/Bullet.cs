using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    //birgir bragi
    private Text countText; //breyta fyrir textann
    public static int count = 0; //teljari, breyta sem telur stig notanda

    void Start()
    {
       countText = GameObject.Find("Text").GetComponent<Text>(); //finnur stigatextann
       //sprenging= GetComponent<Explosion>
        SetCountText();//kallar á function sem uppfærir textann
    }
    private void Update()
    {
        if (transform.position.y < -10) //ef kúlan er mjög langt niðri
        {
            Destroy(gameObject); //eyðir kúlunni
            gameObject.SetActive(false); //eyðir kúlunni
        }
        if (Vatn.vatn == true){ //tjékkar ef að playerinn hefur snert vatn
            count = 0; //endurstillir stigin ef svo er
            Vatn.vatn = false; //endurstillir boolean breytuna
        }
    }
    private void OnCollisionEnter(Collision collision) //function sem sér um collision
    {
        if (collision.collider.tag == "enemy") //ef kúlan rekst í óvin
        {
            count = count + 5;//færð stig
            SetCountText();//kallar í aðferðina
        }
        if (collision.collider.tag == "kassi") //ef kúlan rekst í kassa
        {
            count = count + 1;//færð stig
            SetCountText();//kallar í aðferðina
        }
        if (count >= 50) //ef stigin eru 50 eða fleiri, þ.e.a.s. notandi hefur unnið
        {
            Ovinur.health = 30; //endurstillir lífin
            count = 0; //endurstillir stigin
            SceneManager.LoadScene(2); //fer yfir á lokasenuna
        }
        
    }
    void SetCountText()//hér er aðferðin
    {
        countText.text = "Stig: " + count.ToString();//uppfærir textaobjectið með breytunni sem inniheldur stigin
    }
}
