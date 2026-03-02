using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireworks : MonoBehaviour
{
    [SerializeField] private ParticleSystem _fireWork1;
    [SerializeField] private ParticleSystem _fireWork2;
    [SerializeField] private ParticleSystem _fireWork3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            changeFireworks(_fireWork1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            changeFireworks(_fireWork2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            changeFireworks(_fireWork3);
        }
    }

    public void changeFireworks(ParticleSystem p)
    {
        if (p.isPlaying)
        {
            p.Stop();
        }
        else
        {
            p.Play();
        }
    }
}
