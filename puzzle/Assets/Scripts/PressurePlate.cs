using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject slider;
    public GameObject box;

    private void OnTriggerEnter2D(Collider2D collision){

        //door.gameObject.SetActive(false);

        if(collision.gameObject == box){
            Debug.Log("Pressed");

            //door.GetComponent<BoxCollider2D>().enabled = false;
            slider.gameObject.SetActive(false);
        }
    }

}

/*
References:

https://www.youtube.com/watch?v=kDRjWher3zk

*/