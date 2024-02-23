using UnityEngine;

public class MoveScript : MonoBehaviour {

    [SerializeField] float speed;

    void Start() {}

    void Update() {
        Vector2 dir = Input.GetAxis("Horizontal") * Vector2.right + Input.GetAxis("Vertical") * Vector2.up;
        GetComponent<Rigidbody2D>().velocity += speed * Time.deltaTime * dir;
    }

}
