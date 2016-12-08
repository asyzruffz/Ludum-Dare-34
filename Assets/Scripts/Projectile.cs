using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public float lifetime;

	[HideInInspector]
	public GameObject source;

    protected virtual void Start () {
	
	}

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

    public virtual void Spawn(Transform trans, Vector3 offset, float speed, GameObject src) {
        Vector3 shift = trans.rotation * offset;

        Projectile clone = Instantiate(this, trans.position + shift, trans.rotation);
		clone.GetComponent<Rigidbody2D>().AddForce(trans.rotation * Vector3.up * speed);
		source = src;
		clone.transform.parent = source.transform;
    }
}
