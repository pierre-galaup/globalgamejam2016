using UnityEngine;
using System.Collections;

public class Action : MonoBehaviour
{
    [SerializeField]
    protected AudioClip Speech;

    [SerializeField]
    protected MonoBehaviour OnTrigger;

    public virtual void Execute()
    {
        
    }

    public virtual void Abort()
    {
        
    }
}
