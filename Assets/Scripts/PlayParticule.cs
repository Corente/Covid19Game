using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticule : MonoBehaviour
{
    public ParticleSystem p;
    static public bool play;

    void Start()
    {
        play = false;
    }

    void Update()
    {
        if (play)
        {
            play = false;
            p.Play();
        }
    }
}
