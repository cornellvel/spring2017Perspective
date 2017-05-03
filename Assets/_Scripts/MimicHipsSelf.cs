using UnityEngine;
using System.Collections;

public class MimicHipsSelf : MonoBehaviour {

	public GameObject followedObject;
    public GameObject holdHeight;
    public float theHeight;

    // Use this for initialization
    void Start () {
		transform.parent = followedObject.transform;
        theHeight = holdHeight.transform.position.y;
        Debug.Log(theHeight);
    }

	void followPosition() {  
        //Debug.Log("In Mimic Hips Follow Position");
        Vector3 _tmp = followedObject.transform.position;
        _tmp.z = followedObject.transform.position.z;
        //	_tmp.y = (followedObject.transform.position.y - (theHeight * .35f) + .0142f);
        _tmp.y = (followedObject.transform.position.y-theHeight - .13f);
        _tmp.x = (followedObject.transform.position.x -.18f);
        this.transform.position = _tmp;
        //Debug.Log(this.transform.position.y);
    }
    void followRotation()
    {
        Debug.Log("Totally no rotation");
        Vector3 _tmp2 = followedObject.transform.eulerAngles;
        _tmp2.x = 0;
        _tmp2.y = 90;
        _tmp2.z = 0;
        this.transform.eulerAngles = _tmp2;
    }
    // Update is called once per frame

    void Update()
    {
        followPosition();
        followRotation();
    }
}
