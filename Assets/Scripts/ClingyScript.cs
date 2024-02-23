using UnityEngine;

public class ClingyScript : MonoBehaviour {

    [SerializeField] GameObject trg;
    [SerializeField] float speed;

    void Start() {}

    void Update() {
        Vector2 dir = (trg.GetComponent<Rigidbody2D>().position - gameObject.GetComponent<Rigidbody2D>().position).normalized;
        GetComponent<Rigidbody2D>().velocity += speed * Time.deltaTime * dir;
    }

}
