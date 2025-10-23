 using UnityEngine;

    public class BackgroundFollowCamera : MonoBehaviour
    {
        public Camera mainCamera; // Assign your main camera in the Inspector

        void LateUpdate()
        {
            
            transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, transform.position.z);
        }
    }
    
