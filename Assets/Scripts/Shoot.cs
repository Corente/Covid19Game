using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject balle;
    public Transform startpos;
    public float bullet_speed = 50f;
    public float lifetime = 5f;
    public AudioSource sound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = Instantiate(balle, startpos.position, startpos.rotation);
            b.GetComponent<Rigidbody>().AddForce(startpos.forward * bullet_speed, ForceMode.Impulse);
            StartCoroutine(DestroyBullet(b, lifetime));
            //sound.Play();
        }
    }

    private IEnumerator DestroyBullet(GameObject obj, float lifetime)
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(obj);
    }
}
