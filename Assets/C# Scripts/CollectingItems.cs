using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectingItems : MonoBehaviour
{
    public GameObject GameOver;

    public int items;

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Item")
        {
            Debug.Log("Item Collected");
            items = items + 1;
            Col.gameObject.SetActive(false);
        }

        if (items >= 3) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Cursor.visible = true;
        }



    }
        
}
