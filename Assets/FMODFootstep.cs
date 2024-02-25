using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FMODFootstep : MonoBehaviour
{
    public AK.Wwise.Event eventReference;


    public void Step(AnimationEvent evt) {

        if(evt.animatorClipInfo.weight > 0.5f) {

            eventReference.Post(gameObject);
        }
    }
}
