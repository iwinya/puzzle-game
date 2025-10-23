using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject door;
    public GameObject DoorClosed;

    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.CompareTag("Player")){

            door.gameObject.SetActive(true);
            DoorClosed.gameObject.SetActive(false);
            this.gameObject.SetActive(false);

        }
    }

}

/*
References:

https://www.youtube.com/watch?v=kDRjWher3zk

*/