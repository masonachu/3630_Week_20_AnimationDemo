using FMODUnity;
using JetBrains.Annotations;
using UnityEngine;

public class FMODTEST : MonoBehaviour
{
    public EventReference eventReference;

    public void Step(AnimationEvent evt)
    {
        if (evt.animatorClipInfo.weight > 0.5f)
        {
            RuntimeManager.PlayOneShot(eventReference, transform.position);
        }
    }
}
