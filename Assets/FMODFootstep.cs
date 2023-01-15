using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FMODFootstep : MonoBehaviour
{
    public EventReference eventReference;


    public void Step(AnimationEvent evt) {

        if(evt.animatorClipInfo.weight > 0.5f) {        

            RuntimeManager.PlayOneShot(eventReference, transform.position);
        }
    }
}
