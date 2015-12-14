using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    public bool moving;
    public bool firing;
    public Vector2 direction = new Vector2();
    public Vector3 cursor = new Vector3();

    private float angle = 0f;

    protected void moveTowards(Vector2 target) {
        direction.x = target.x - transform.position.x;
        direction.y = target.y - transform.position.y;
        direction.Normalize();
    }

    protected void moveTowards(Vector3 target) {
        direction.x = target.x - transform.position.x;
        direction.y = target.y - transform.position.y;
        direction.Normalize();
    }

    public void faceTowards(Vector2 target) {
        Vector2 facing = target - new Vector2(transform.position.x, transform.position.y);
        angle = Mathf.Atan2(facing.y, facing.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    protected void faceTowards(Vector3 target) {
        Vector3 facing = target - transform.position;
        angle = Mathf.Atan2(facing.y, facing.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public void reload() {
        firing = false;
    }
}
