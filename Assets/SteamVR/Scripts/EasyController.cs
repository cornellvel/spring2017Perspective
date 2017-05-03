using UnityEngine;
using System.Collections;

public class EasyController : MonoBehaviour {

    private SteamVR_TrackedController device;

    // Use this for initialization
    void Start () {
        device = GetComponent<SteamVR_TrackedController>();
        device.TriggerClicked += Trigger; 
    }
	void Trigger (object sender, ClickedEventArgs e)
    {
        Debug.Log("Hi");
    }
}
