using UnityEngine;
using System.Collections;

public class CallParentTrigger : MonoBehaviour
{
    [SerializeField]
    private Action Parent;

    [SerializeField]
    private GameObject UI;

    [SerializeField] private KeyCode UseKey = KeyCode.E;

    private bool InRange;
    private bool IsRunning;

    public void OnTriggerEnter(Collider other)
    {
        this.UI.SetActive(true);
        this.InRange = true;
    }

    public void OnTriggerExit(Collider other)
    {
        this.UI.SetActive(false);
        this.InRange = false;
        if (this.IsRunning)
            this.Parent.Abort();
    }

    public void Update()
    {
        if (!Input.GetKeyUp(this.UseKey) || !this.InRange)
            return;
        this.Parent.Execute();
        this.IsRunning = true;
    }
}
