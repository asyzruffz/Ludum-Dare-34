using UnityEngine;
using System.Collections;

public class NpcBehaviour : MonoBehaviour {

    public bool noticed;
    public Vector2 targetPostion;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //
    }

    void OnCollisionEnter2D(Collision2D target) {
        //if (target.gameObject.tag == "Player") {
            noticed = true;
        Debug.Log("Detected");
            //targetPostion = new Vector2(target.gameObject.transform.position.x, target.gameObject.transform.position.y);
        //} else {
        //    noticed = false;
        //}
    }

}
