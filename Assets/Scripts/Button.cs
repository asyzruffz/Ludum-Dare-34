using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    public string scene;

    private bool loadLock;
    private Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!Input.GetMouseButton(0))
            animator.SetInteger("animState", 0);
    }

    void OnMouseOver() {
        if (Input.GetMouseButton(0)) {
            animator.SetInteger("animState", 1);
            if (!loadLock)
                LoadScene();
        }
        else {
            animator.SetInteger("animState", 0);
        }
    }

    void LoadScene() {
        loadLock = true;
        if (scene.Length > 0) {
            Application.LoadLevel(scene);
        } else {
            Application.Quit();
        }
    }
}
