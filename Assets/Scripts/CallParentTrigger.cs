using UnityEngine;
using System.Collections;

public class CallParentTrigger : MonoBehaviour
{
    [SerializeField]
    private Habit Parent;

    [SerializeField]
    private GameObject UI;

    [SerializeField] private KeyCode UseKey = KeyCode.E;

    private bool InRange;

    public void OnTriggerEnter(Collider other)
    {
        this.UI.SetActive(true);
        this.InRange = true;
    }

    public void OnTriggerExit(Collider other)
    {
        this.UI.SetActive(false);
        this.InRange = false;
    }

    public void Update()
    {
        if (!Input.GetKeyUp(this.UseKey) || !this.InRange)
            return;
        this.Parent.ExecuteHabit();
    }
}
