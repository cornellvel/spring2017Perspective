using UnityEngine;
using System.Collections;

public class RotateAvatar_back : MonoBehaviour {

    // Use this for initialization
    void Start () {

    }
    void Update()
    {

    }

    public void changeRotation_back()
    {
        Vector3 _tmp2 = this.transform.eulerAngles;
        _tmp2.x = this.transform.eulerAngles.x;
        _tmp2.y = (this.transform.eulerAngles.y + 30);
        _tmp2.z = this.transform.eulerAngles.z;
        this.transform.eulerAngles = _tmp2;
    }

}
