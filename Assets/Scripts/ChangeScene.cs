using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public GameObject checkBtn;
    private string currentSceneName;

    public void ShowHideBtn(string scene)
    {
        checkBtn.SetActive(!checkBtn.activeSelf);
        currentSceneName = scene;
    }

    public void ChangeToScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneName);
    }
}
