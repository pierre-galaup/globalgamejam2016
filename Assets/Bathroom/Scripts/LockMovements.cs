using UnityEngine;
using System.Collections;

public class LockMovements : MonoBehaviour
{
    [SerializeField]
    private float LockTime = 3f;
    [SerializeField]
    private MonoBehaviour FpsControllerScript;

    private float startTime = 0f;

    void Start()
    {
        this.FpsControllerScript.enabled = false;
    }

    
    // Update is called once per frame
    void Update ()
	{
	    this.startTime += Time.deltaTime;
	    if (this.startTime >= this.LockTime)
        {
            this.FpsControllerScript.enabled = true;
            this.enabled = false;
        }
	        
	}
}
