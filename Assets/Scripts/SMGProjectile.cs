using UnityEngine;
using System.Collections;

public class SMGProjectile : Projectile {
    
    public override void Spawn(Transform trans, Vector3 offset, float speed, GameObject src) {
        Vector3 shift1 = trans.rotation * offset;
        Vector3 shift2 = trans.rotation * new Vector3(-offset.x, offset.y, offset.z);

        Projectile clone1 = Instantiate(this, trans.position + shift1, trans.rotation);
		clone1.GetComponent<Rigidbody2D>().AddForce(trans.rotation * Vector3.up * speed);
		clone1.source = src;
		clone1.transform.parent = clone1.source.transform;
        
        Projectile clone2 = Instantiate(this, trans.position + shift2, trans.rotation);
		clone2.GetComponent<Rigidbody2D>().AddForce(trans.rotation * Vector3.up * speed);
		clone2.source = src;
		clone2.transform.parent = clone2.source.transform;
    }
}
