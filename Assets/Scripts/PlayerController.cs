using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : Controller {
    
    void Start () {
	
	}
	
	void Update () {
        cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(1)) {
            moving = true;
        } else {
            moving = false;
        }

        if (Input.GetMouseButton(0)) {
            firing = true;
        } else {
            firing = false;
        }

        faceTowards(cursor);
        moveTowards(cursor);
    }
}
