using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Intrrigger : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector Maintimeline;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("nigga");
            Maintimeline.Play();
        }
    }
}
