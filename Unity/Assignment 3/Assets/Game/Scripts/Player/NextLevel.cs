using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nextSceneName;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by: " + other.name);

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
