using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.CompareTag("Player"))
        {
            SceneController.instance.NextLevel();        
        }

    }
}
/*
References:

https://www.youtube.com/watch?v=E25JWfeCFPA
*/