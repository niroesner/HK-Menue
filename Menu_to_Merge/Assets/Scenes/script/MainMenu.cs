using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    private Transform cameraTransform;
    private Transform cameraDesiredLookAt;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    public void LookAtMenu(Transform menuTransform)
    {
        //Camera.main.transform.LookAt(menuTransform.position);
        cameraDesiredLookAt = menuTransform;
    }

    private void Update()
    {
        if (cameraDesiredLookAt != null)
        {
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, cameraDesiredLookAt.rotation, 4 * Time.deltaTime);
        }
    }
}
