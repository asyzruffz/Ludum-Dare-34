using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    public float attackDelay = 1f;
    public Projectile projectile;
    public float bulletSpeed = 400f;
    public Vector3 nozzleOffset;
    public Controller holder;

    private Animator animator;

	void Start () {
        animator = GetComponent<Animator>();
	}

    public void Fire() {
        animator.SetInteger("animState", 1);
    }

	public void StopFiring() {
		animator.SetInteger("animState", 0);
	}

    void OnShoot() {
        if (projectile) {
            projectile.initiate(transform, nozzleOffset, bulletSpeed, gameObject);
        }

        holder.reload();
    }
}
