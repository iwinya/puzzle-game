using UnityEngine;

public class playerpush : MonoBehaviour {

		public float distance=1f;
		public LayerMask boxMask;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			Physics2D.queriesStartInColliders = false;
			RaycastHit2D hit= Physics2D.Raycast (transform.position, Vector2.right * transform.localScale.x, distance, boxMask);
		}

		void OnDrawGizmos()
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawLine (transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);
		}
}


/*
References:

https://www.youtube.com/watch?v=Qz2qMxmtxpQ&t=22s


*/