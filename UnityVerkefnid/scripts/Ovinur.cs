using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ovinur : MonoBehaviour
{
    //birgir bragi

    //breytur skilgreindar

    //public Text countText;
    //private static int count;
    public static int health = 30;
    private Text texti;
    public Transform player;
    private Rigidbody rb;
    private Vector3 movement;
    public float hradi = 5f;
    public GameObject sprenging;
    public GameObject smoke;
    public GameObject smoke2;
    public Rigidbody rb2;
    // Start is called before the first frame update
    void Start()
    {
        texti=GameObject.Find("Text2").GetComponent<Text>(); //finn textann með lífunum 
        rb = this.GetComponent<Rigidbody>();//næ í rigidbodyið á óvininum
        texti.text = "Líf: " + health.ToString(); //stilli lífatextann
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 stefna = player.position - transform.position;//stefnan að playernum
        stefna.Normalize(); //nota normalize()
        movement = stefna; //set í breytu
    }
    private void FixedUpdate()
    {
        Hreyfing(movement);//kalla á functionið hreyfing með færibreytunni movement
    }
    void Hreyfing(Vector3 stefna)
    {
        rb.MovePosition(transform.position + (stefna * hradi * Time.deltaTime));//færi óvininn í átt að player
    }
    private void OnCollisionEnter(Collision collision) //function sem sér um collision
    {
        if (collision.collider.tag=="player") //ef óvinur rekst í player
        {
            Debug.Log("Leikmaður fær í sig óvin");
            TakeDamage(10);//kalla á function
            Instantiate(smoke, transform.position, transform.rotation);//spawna reyk á þeim stað sem óvinurinn var
            Destroy(gameObject);//óvinur dauður
            gameObject.SetActive(false);//óvinur dauður
        }
        if (collision.collider.tag == "kula2") //ef óvinur rekst í kúlu 
        {
            Debug.Log("varð fyrir kúlu2");
            Sprengin();//kalla á function
        }
    }
    public void TakeDamage(int damage)
    {
        Debug.Log("health er núna" + (health).ToString());
        health -= damage;//mínusa damage færibreytuna frá lífunum sem hann hefur
        texti.text = "Líf " + health.ToString();//uppfæri lífatextann
        if (health <= 0)//ef engin líf eru eftir
        {
            Instantiate(smoke2, transform.position, transform.rotation);//spawna reyk
            rb.constraints = RigidbodyConstraints.FreezeAll;//stöðva alla hreyfingu playersins
            StartCoroutine(bida());//kalla á function
            SceneManager.LoadScene(0);//fer á upphafsenu
            health = 30;//endurstilli lífin
            Bullet.count = 0;//endurstilli stigin
            texti.text = "Líf: " + health.ToString();//uppfæri lífatextann
        }
    }
    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation); //spawna sprengingu
        Destroy(gameObject); //eyði óvin
        gameObject.SetActive(false);//eyði óvin
    }
    IEnumerator bida(){
        yield return new WaitForSeconds(5);//time.sleep(5) í python, bíður í 5 sek
    }
        
}
