using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

    public void ButtonClick() {
        SceneManager.LoadScene("Scene");
    }

}