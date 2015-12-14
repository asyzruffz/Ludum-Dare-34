using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public float lifetime;

    // Use this for initialization
    protected virtual void Start () {
	
	}

    // Update is called once per frame
    protected virtual void Update () {
        if (lifetime < -1f)
            return;

        if (lifetime <= 0f) {
            Destroy(gameObject);
        }

        lifetime -= Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D target) {
        Destroy(gameObject);
    }

    public virtual void initiate(Transform trans, Vector3 offset, float speed) {
        Vector3 shift = trans.rotation * offset;

        Projectile clone = Instantiate(this, trans.position + shift, trans.rotation) as Projectile;
        clone.GetComponent<Rigidbody2D>().AddForce(trans.rotation * Vector3.up * speed);
    }
}
