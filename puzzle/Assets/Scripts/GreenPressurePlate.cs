using UnityEngine;

public class GreenPressurePlate : MonoBehaviour
{
    public GameObject slider;
    public GameObject box;

    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.gameObject == box){
            Debug.Log("Green Pressed");

            slider.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision){

        if(collision.gameObject == box){
            Debug.Log("Green Released");

            slider.gameObject.SetActive(false);
        }
    }
}

/*
References:

https://www.youtube.com/watch?v=kDRjWher3zk

*/