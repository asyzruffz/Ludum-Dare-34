using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject target;
    public float PixelsPerUnit = 64f;

	private Transform _t;

	void Awake(){
		GetComponent<Camera>().orthographicSize = ((Screen.height / 2.0f) / PixelsPerUnit);
	}

	void Start () {
        if(target)
            _t = target.transform;
	}

	void Update () {
		if(_t)
			transform.position = new Vector3 (_t.position.x, _t.position.y, transform.position.z);
	}
}
