using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGraphics : MonoBehaviour {

	// Use this for initialization
    public ParticleSystem muzzleFlash;

    public GameObject hitEffectPrefab;

    public void playEffect()
    {
        muzzleFlash.Play();
    }

}
