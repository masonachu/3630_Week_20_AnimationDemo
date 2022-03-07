using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class ThirdPersonFMOD : MonoBehaviour
{
    public EventReference stepSfx;

    public void Step() {

        RuntimeManager.PlayOneShot(stepSfx, transform.position);
    }

}
