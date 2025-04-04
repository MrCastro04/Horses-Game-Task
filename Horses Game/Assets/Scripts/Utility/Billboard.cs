using UnityEngine;
using Utility;

public class Billboard : MonoBehaviour
{
    private GameObject _camera;

    private void Awake()
    {
        _camera = GameObject.FindGameObjectWithTag(Constants.MAIN_CAMERA_TAG);
    }

    private void LateUpdate()
    {
        Vector3 cameraDirection = transform.position + _camera.transform.forward;

        transform.LookAt(cameraDirection);
    }

}
