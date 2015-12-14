using UnityEngine;
using System.Collections;

public class NpcController : Controller {

    public float cooldown = 5f;
    public float sightDistance = 5f;

    private bool noticed;
    private float timer = 0f;
    private float angle2 = 0f;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (timer <= 0f) {
            timer = cooldown;
            shoot();
        }

        /*cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle2 += 5 * Time.fixedDeltaTime;
        direction.x = Mathf.Cos(angle2 % 360f);// cursor.x - transform.position.x;
        direction.y = Mathf.Sin(angle2 % 360f);//cursor.y - transform.position.y;
        direction.Normalize();
        faceTowards(transform.position + new Vector3(direction.x, direction.y, 0) * 5);

        if(noticePlayer())
            Debug.DrawRay(transform.position, direction, Color.green);*/                // useless code

        timer -= Time.deltaTime;

        noticed = false;
    }

    void OnCollisionEnter2D(Collision2D target) {
        if (target.gameObject.tag == "Player") {
            noticed = true;
        }
    }

    bool noticePlayer() {
        bool seePlayer = Physics2D.CircleCast(new Vector2(transform.position.x, transform.position.y),
                                                sightDistance, direction, 0f, 1 << LayerMask.NameToLayer("Entity"));

        return seePlayer;
    }

    void shoot() {
        firing = true;
    }
}
