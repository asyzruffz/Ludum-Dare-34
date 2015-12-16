using UnityEngine;
using System.Collections;

public class SMGProjectile : Projectile {
    
    public override void initiate(Transform trans, Vector3 offset, float speed, GameObject src) {
        Vector3 shift1 = trans.rotation * offset;
        Vector3 shift2 = trans.rotation * new Vector3(-offset.x, offset.y, offset.z);

        Projectile clone1 = Instantiate(this, trans.position + shift1, trans.rotation) as Projectile;
        clone1.Source = src;
        clone1.GetComponent<Rigidbody2D>().AddForce(trans.rotation * Vector3.up * speed);
        
        Projectile clone2 = Instantiate(this, trans.position + shift2, trans.rotation) as Projectile;
        clone2.Source = src;
        clone2.GetComponent<Rigidbody2D>().AddForce(trans.rotation * Vector3.up * speed);
    }
}
