using UnityEngine;

public class BallParticleScript : MonoBehaviour {

    [SerializeField] GameObject particle;
    [SerializeField] string collTag;
    [SerializeField] string holderTag;
    GameObject holderObj;

    void Start() {
        holderObj = GameObject.FindWithTag(holderTag);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == collTag) {
            GameObject effect = Instantiate(particle, collision.GetContact(0).point, Quaternion.identity, holderObj.transform);
        }
    }

}
