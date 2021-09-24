using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class YellowBird : Bird
{
    [SerializeField] 
    public float _boostForce = 100;
    public bool _hasBoost = false;

    public void Boost()
    {
        if(State == BirdState.Thrown && !_hasBoost)
        {
            RigidBody.AddForce(RigidBody.velocity * _boostForce);
            _hasBoost = true;
        }
    }

    public override void OnTap()
    {
        Boost();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
