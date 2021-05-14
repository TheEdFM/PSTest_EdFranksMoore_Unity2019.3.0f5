
using UnityEngine;

public class CameraFollow : MonoBehaviour{

    public Transform thePlayer;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - thePlayer.position;
    }

    void LateUpdate()
    {
        Vector3 cameraNewPosition = new Vector3(0, thePlayer.position.y + offset.y, thePlayer.position.z + offset.z);

        transform.position = cameraNewPosition;
    }

}
