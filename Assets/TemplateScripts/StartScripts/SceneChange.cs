using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    public string sceneName;

    public void LoadScene() {
        if(sceneName != null) {
            SceneManager.LoadScene(sceneName);
        }
    }

}
