using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    [SerializeField] private GameObject _povCamera;
    [SerializeField] private GameObject _cockpit;
    [SerializeField] private GameObject _cockpit2;
    [SerializeField] private GameObject _personCamera;
    [SerializeField] private GameObject _mainship;
    private bool _canSwitch = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_canSwitch) return;
        if(Input.GetKeyDown(KeyCode.R))
        {
            if(_povCamera.activeSelf)
            {
                _mainship.GetComponent<Renderer>().enabled = true;
                _cockpit.GetComponent<Renderer>().enabled = false;
                Renderer[] renderers = _cockpit2.GetComponentsInChildren<Renderer>();

                foreach (Renderer r in renderers)
                {
                    r.enabled = false;
                }
                _personCamera.SetActive(true);
                _povCamera.SetActive(false);
            }
              
            else if(_personCamera.activeSelf)
            {
                _mainship.GetComponent<Renderer>().enabled = false;
                _cockpit.GetComponent<Renderer>().enabled = true;
                Renderer[] renderers = _cockpit2.GetComponentsInChildren<Renderer>();

                foreach (Renderer r in renderers)
                {
                    r.enabled = true    ;
                }
                _personCamera.SetActive(false); 
                _povCamera.SetActive(true);
                
            }
        }
    }
    public void EnableCanSwitch()
    {
        _canSwitch = true;
        _mainship.GetComponent<Renderer>().enabled = false;
        _cockpit.GetComponent<Renderer>().enabled = true;
        Renderer[] renderers = _cockpit2.GetComponentsInChildren<Renderer>();

        foreach (Renderer r in renderers)
        {
            r.enabled = true;
        }
        _personCamera.SetActive(false);
        _povCamera.SetActive(true);
    }
    public void EnableShipRenderer()
    {
        _mainship.GetComponent<Renderer>().enabled = true;
        _cockpit.GetComponent<Renderer>().enabled = false;
        Renderer[] renderers = _cockpit2.GetComponentsInChildren<Renderer>();

        foreach (Renderer r in renderers)
        {
            r.enabled = false;
        }
        _personCamera.SetActive(true);
        _povCamera.SetActive(false);
    }
}
