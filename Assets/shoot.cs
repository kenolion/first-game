using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	// Use this for initialization
    public float damage = 10.0f;

    public float range = 100.0f;
    public Camera fpscam;
    private WeaponGraphics wpnGraphics;
    

	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("Fire1"))
	    {
	        wpnGraphics = GetComponent<WeaponGraphics>();
	        wpnGraphics.playEffect();
	        Shoot();
	    }

	}

    void Shoot()
    {
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        RaycastHit hit;
        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range,layerMask))
        {
            Debug.Log(hit.transform.name);
            
            Debug.DrawRay(fpscam.transform.position,fpscam.transform.forward * hit.distance,Color.yellow,2);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.takeDamage(damage);
            }
        }

    }
}
