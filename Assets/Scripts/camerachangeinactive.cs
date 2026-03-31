using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerachangeinactive : MonoBehaviour
{
    // Start is called before the first frame update
    private float inactivityTime = 15f;
    private float timer = 0f;
    [SerializeField] GameObject _blendListCamera;
    [SerializeField] GameObject _cockpitCamera;
    [SerializeField] GameObject _personCamera;
    [SerializeField] GameObject _shipCamController;
    private Vector3 lastMousePosition ;
    void Start()
    {
        _blendListCamera.SetActive(false);
        _cockpitCamera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        CameraSwap _camControl = _shipCamController.GetComponent<CameraSwap>();
        if (Input.anyKey || Input.mousePosition != lastMousePosition)
        {
            timer = 0f;
            lastMousePosition = Input.mousePosition;
            _blendListCamera.SetActive(false);
            _cockpitCamera.SetActive(true);
        }
        else
        {
            timer += Time.deltaTime;
        }
        if (timer >= inactivityTime)
        {
            _blendListCamera.SetActive(true);
            _cockpitCamera.SetActive(false);
            _camControl.EnableShipRenderer();
        }
    }
}
