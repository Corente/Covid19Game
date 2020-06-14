using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    
    int infected;
    bool Scored = true;

    // Start is called before the first frame update
    void Start()
    {
        Score.BuildingNumber += 1;
        Score.BuildingInfected += 1;
        meshRenderer.material.color = Color.green;
        infected = 100;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        infected -= 1;
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        infected -= 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (infected > 0 && infected <= 50)
        {
            meshRenderer.material.color = new Color(0.5f, 1f, 0.5f, 1f);
        }
        if (infected <= 0)
        {
            if (Scored)
            {
                Score.BuildingInfected -= 1;
                Scored = false;
                PlayParticule.play = true;
            }
            meshRenderer.material.color = Color.white;
        }
    }
}
