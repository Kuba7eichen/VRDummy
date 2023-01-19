using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColliderManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableColliders()
    {
        Collider[] colliders = GetComponentsInChildren<Collider>();
        foreach(Collider col in colliders)
        {
            //print(col.name + " disabled");
            col.enabled = false;
        }
    }

    public void ReableCollidersAfterXSec(float waitTime)
    {
        StartCoroutine(WaitAndReable(waitTime));
    }
    private IEnumerator WaitAndReable(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        Collider[] colliders = GetComponentsInChildren<Collider>();
        foreach (Collider col in colliders)
        {
            //print(col.name + " enabled");
            col.enabled = true;
        }
    }
}
