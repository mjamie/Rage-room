using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{
    [SerializeField] private Transform cubeTransform;
    [SerializeField] private ParticleSystem particleSystem;
    public void OnObjectBroke()
    {
        cubeTransform.gameObject.SetActive(false);
        particleSystem.gameObject.SetActive(true);

        particleSystem.transform.position = cubeTransform.position;
        transform.parent.GetComponent<BreakableCounter>().OnCheckBreakablesCount();

        Destroy(gameObject, 3);
    }

    private void OnDestroy()
    {
        
    }
}
