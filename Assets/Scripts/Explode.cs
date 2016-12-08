using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Explode : MonoBehaviour {

	public Blood blood;
	public int totalSpray = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Deadly") {
			OnExplode();
		}

	}

	void OnCollisionEnter2D(Collision2D target){
        if (target.gameObject.tag == "Deadly") {
            /*if(gameObject.tag == "Player") {
                Reincarnate(target.gameObject.GetComponent<Projectile>().Source);
            }*/

            //StartCoroutine(BackToMenu());
            OnExplode();
        }
	}

	public void OnExplode() {
        Destroy(gameObject);

        var t = transform;

        for (int i = 0; i < totalSpray; i++) {
            Blood clone = Instantiate(blood, t.position, Quaternion.identity) as Blood;
			clone.GetComponent<Rigidbody2D>().AddForce(Vector3.right * (Random.Range (-10, 10)));
			clone.GetComponent<Rigidbody2D>().AddForce(Vector3.up * Random.Range(-10, 10));
		}
    }

    void Reincarnate(GameObject newBody) {
        PlayerController pc = newBody.AddComponent<PlayerController>();
        Destroy(newBody.GetComponent("NpcController"));
        newBody.GetComponent<Character>().Controller = pc;
    }

    IEnumerator BackToMenu() {
        //OnExplode();
        yield return new WaitForSeconds(3);
		SceneManager.LoadScene ("Menu");
    }
}
