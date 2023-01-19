using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumManager : MonoBehaviour
{
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //print(gameObject.name);
        //print(_audioSource.pitch);
        _audioSource.pitch = (Random.Range(0.7f, 1.3f));
        _audioSource.volume = collision.relativeVelocity.magnitude;
        _audioSource.Play();
    }
}
