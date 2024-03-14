using UnityEngine;

public class BladeScript : MonoBehaviour {

    [SerializeField] float stageAngle;
    [SerializeField] float tanThresh;
    [SerializeField] float tanAdd;

    public float health {
        get;
        private set;
    }

    // Start is called before the first frame update
    void Start() {
        health = 1;
    }

    // Update is called once per frame
    void Update() {}

    private void FixedUpdate() {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (health <= 0) {
            rb.velocity = Vector3.zero;
        }
        // radial component of gravity
        rb.AddForce(10 * Mathf.Cos((90 - stageAngle) * Mathf.Deg2Rad) * -1 * transform.localPosition, ForceMode2D.Force);
        // add fake tangential component
        float tanVel = Vector3.Dot(rb.velocity, Quaternion.Euler(0, 0, 90) * transform.localPosition.normalized);
        if (tanVel < tanThresh) {
            rb.AddForce(tanAdd * (Quaternion.Euler(0, 0, 90) * transform.localPosition.normalized), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        GameObject go = collision.collider.gameObject;
        if (health > 0 && go.tag == tag) {
            float vs = collision.rigidbody.velocity.magnitude;
            float vo = collision.otherRigidbody.velocity.magnitude;
            float vm = Mathf.Max(vs, vo);
            health -= Mathf.Floor(10f * (vs / vm)) / 100;
        }
    }

}
