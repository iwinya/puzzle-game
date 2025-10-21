using UnityEngine;

public class RedPressurePlate : MonoBehaviour
{
    public GameObject platform;
    public GameObject box;

    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.gameObject == box){
            Debug.Log("Red Pressed");

            platform.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision){

        if(collision.gameObject == box){
            Debug.Log("Red Released");

            if (platform != null)
                platform.SetActive(false);
        }
    }
}

/*
References:

https://www.youtube.com/watch?v=kDRjWher3zk

*/