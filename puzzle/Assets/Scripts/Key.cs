using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D collision){

        //door.gameObject.SetActive(false);

        if(collision.CompareTag("Player")){
            //Debug.Log("Key picked up");

            //door.GetComponent<BoxCollider2D>().enabled = false;
            door.gameObject.SetActive(true);

            this.gameObject.SetActive(false);
        }
    }

}

/*
References:

https://www.youtube.com/watch?v=kDRjWher3zk

*/