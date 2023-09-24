using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PachinkoEndCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private ParticleSystem _particles;
    void Start()
    {
        _particles = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        Pachinko.Instance.BallEnteredCollider(gameObject.name);
        _particles.Play();
    }
}
