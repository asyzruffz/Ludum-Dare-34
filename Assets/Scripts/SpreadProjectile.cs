using UnityEngine;
using System.Collections;

public class SpreadProjectile : Projectile {

    public int intensity;
    public float spread;
    public float fadeSpeed;

    private SpriteRenderer spriteRenderer;
    private Color start;
    private Color end;
    private float t = 0.0f;

    // Overwrite function from parent projectile class
	protected override void Start() {
        base.Start();

        spriteRenderer = GetComponent<SpriteRenderer>();
        start = spriteRenderer.color;
        end = new Color(start.r, start.g, start.b, 0.0f);
    }

	protected override void Update() {
        base.Update();

        t += Time.deltaTime * fadeSpeed;
        GetComponent<Renderer>().material.color = Color.Lerp(start, end, t / 2);
    }


    public override void initiate(Transform trans, Vector3 offset, float speed, GameObject src) {
        Vector3 shift = trans.rotation * offset;

        for (int i = 0; i < intensity; i++) {
            Projectile clone = Instantiate(this, trans.position + shift, trans.rotation) as Projectile;
            clone.Source = src;
            clone.GetComponent<Rigidbody2D>().AddForce(trans.rotation * Vector3.up * speed);
            clone.GetComponent<Rigidbody2D>().AddForce(trans.rotation * Vector3.right * (Random.Range(-spread, spread)));
        }
    }
}
