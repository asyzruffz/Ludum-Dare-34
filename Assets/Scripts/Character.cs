using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public float force = 10f;
    public float maxSpeed = 3f;
    public float skidMultiplier = 0.5f;
    public bool isNpc;
    public Weapon weapon;
    
	[HideInInspector]
	public Controller controller;

    void Start() {
		if (isNpc) {
			controller = GetComponent<NpcController> ();
		} else {
			controller = GetComponent<PlayerController> ();
		}
    }

    void Update() {
        if (controller.moving) {
            GetComponent<Rigidbody2D>().AddForce(controller.direction * force);

			Vector2 currentVelocity = GetComponent<Rigidbody2D>().velocity;
			float currentSpeed = currentVelocity.magnitude;
            if (currentSpeed >= maxSpeed) {
                currentVelocity.Normalize();
                GetComponent<Rigidbody2D>().velocity = currentVelocity * maxSpeed;
            }
        } else {
            GetComponent<Rigidbody2D>().velocity *= skidMultiplier;
            GetComponent<Rigidbody2D>().angularVelocity *= skidMultiplier;
        }

		if (weapon) {
			if (controller.firing) {
				weapon.Fire ();
			} else {
				weapon.StopFiring ();
			}
        }
    }
}
