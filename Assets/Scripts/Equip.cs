using UnityEngine;
using System.Collections;

public class Equip : MonoBehaviour {
    //public float fireRate = 0;
    //public float damage = 10;
    //public LayerMask notToHit;

    //float timeToFire = 0;
    //Transform firePoint;

    // Use this for initialization
    void Start ()
    {
        /*firePoint = transform.FindChild("FirePoint") ;
        if (firePoint == null)
        {
            Debug.LogError("No Firepoint ?");

        }*/
 
    }
    //  Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButton(0)) {
            //firing = true;
        }
        else {
            //firing = false;
        }
        /*if (fireRate == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();

            }
        }
        else
        {
            if (Input.GetButton ("Fire1") && Time.time > timeToFire) {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }*/
    }
    void OnShoot()
    {
        //Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y));
        //Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        //RaycastHit2D hit = Physics2D.Raycast(firePointPosition, mousePosition - firePointPosition, 1000, notToHit);
        //Debug.DrawLine(firePointPosition, (mousePosition-firePointPosition)*100);
         
    }
}
