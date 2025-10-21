using UnityEngine;

public class PurplePressurePlate : MonoBehaviour
{
    public GameObject slider;
    public GameObject box;

    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.gameObject == box){
            Debug.Log("Purple Pressed");

                slider.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision){

        if(collision.gameObject == box){
            Debug.Log("Purple Released");

            slider.gameObject.SetActive(true);
        }
    }
}

/*
References:

https://www.youtube.com/watch?v=kDRjWher3zk

*/