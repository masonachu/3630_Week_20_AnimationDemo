using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class ThirdPersonFMOD : MonoBehaviour
{
    public EventReference stepSfx;

    public void Step(AnimationEvent evt) {

        if (evt.animatorClipInfo.weight > 0.5f) {

            RuntimeManager.PlayOneShot(stepSfx, transform.position);
        }
    }
}
