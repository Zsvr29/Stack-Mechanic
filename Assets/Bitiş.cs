using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bitiş : MonoBehaviour
{
    public GameObject player;
    public Text text;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="bitis")
        {

            text.text = "Oyun Bitti!";
           // Destroy(other.gameObject,0.5f);

            
        }
    }


}
