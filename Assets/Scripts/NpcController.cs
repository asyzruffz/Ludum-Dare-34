using UnityEngine;
using System.Collections;

public class NpcController : Controller {

    public float cooldown = 5f;
    public NpcBehaviour behaviour;

    private float timer = 0f;

    void Start() {

    }

    void Update() {
		//By default, cursor is just in front of self
		cursor = transform.position + transform.up;

        if (behaviour) {
            if (behaviour.noticed) {
                cursor = behaviour.targetPostion;
            }
		}

		faceTowards(cursor);
		moveTowards(cursor);

		// Let them shoot repeatedly with cooldown
		if (timer <= 0f) {
			timer = cooldown;
			shoot();
		}

        timer -= Time.deltaTime;
    }

    void shoot() {
        firing = true;
    }
}
