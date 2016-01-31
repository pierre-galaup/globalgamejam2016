using UnityEngine;
using System.Collections;

public class Action : MonoBehaviour
{
    [SerializeField]
    protected AudioClip Speech;

    public virtual void Execute()
    {
        
    }

    public virtual void Abort()
    {
        
    }
}
