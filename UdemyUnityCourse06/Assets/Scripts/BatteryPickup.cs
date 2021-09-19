using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 70;
    [SerializeField] float intensityAmount = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            other.GetComponentInChildren<FlashlightSystem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashlightSystem>().RestoreLightIntensity(intensityAmount);

            Destroy(gameObject);
        }
    }
}
