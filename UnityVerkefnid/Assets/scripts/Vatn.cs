using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vatn : MonoBehaviour
{
    public static bool vatn = false; //boolean breyta
    private void OnTriggerEnter(Collider other) //function sem sér um collision
    {
        if (other.tag == "player") //ef player rekst í vatn
        {
            Debug.Log("Drukknaði");
            Ovinur.health = 30; //endurstillir lífin
            SceneManager.LoadScene(0); //fer yfir á byrjunarsenuna
            vatn = true;//stillir boolean breytuna
        }
    }
}
