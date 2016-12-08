using UnityEngine;
using System.Collections;

public class NpcController : Controller {

    public float cooldown = 5f;
    public NpcBehaviour behaviour;

    private float timer = 0f;

    void Start() {

    }

    void Update() {
        if (timer <= 0f) {
            timer = cooldown;
            shoot();
        }

        if (behaviour) {
            if (behaviour.noticed) {
                faceTowards(behaviour.targetPostion);
            }
        }

        timer -= Time.deltaTime;
    }

    void shoot() {
        firing = true;
    }
}
