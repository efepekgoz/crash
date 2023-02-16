using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadScene : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("Scene0");
        }
    }
}
