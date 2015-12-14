using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public float force = 10f;
    public float maxSpeed = 3f;
    public float skidMultiplier = 0.5f;
    public bool isNpc;
    public Weapon weapon;
    
    //private Animator animator;
    private Controller controller;

    void Start() {
        if(isNpc)
            controller = GetComponent<NpcController>();
        else
            controller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update() {
        if (controller.moving) {
            GetComponent<Rigidbody2D>().AddForce(controller.direction * force);

            float currentSpeed = GetComponent<Rigidbody2D>().velocity.magnitude;
            if (currentSpeed >= maxSpeed) {
                Vector2 currentVelocity = GetComponent<Rigidbody2D>().velocity;
                currentVelocity.Normalize();
                GetComponent<Rigidbody2D>().velocity = currentVelocity * maxSpeed;
            }
        } else {
            GetComponent<Rigidbody2D>().velocity *= skidMultiplier;
            GetComponent<Rigidbody2D>().angularVelocity *= skidMultiplier;
        }

        if (controller.firing) {
            if(weapon) {
                weapon.Fire();
            }
        }
    }
}
