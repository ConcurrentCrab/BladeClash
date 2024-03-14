using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField] float initVel;
    [SerializeField] GameObject[] blades;

    // Start is called before the first frame update
    void Start() {
        foreach (GameObject blade in blades) {
            Rigidbody2D rb = blade.GetComponent<Rigidbody2D>();
            rb.AddForce(initVel * (Quaternion.Euler(0, 0, 90) * blade.transform.localPosition.normalized), ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update() {
        foreach (GameObject blade in blades) {
            if (blade.GetComponent<BladeScript>().health == 0) {
            }
        }
    }

}
