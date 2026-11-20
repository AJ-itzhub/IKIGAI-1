
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // START button: Open Home scene
    public void GoToHome()
    {
        SceneManager.LoadScene("home");
    }

    // CLASS button: Open Class scene
    public void GoToClass()
    {
        SceneManager.LoadScene("class");
    }

    // LESSONS button: Open Lessons scene
    public void GoToLessons()
    {
        SceneManager.LoadScene("lessons");
    }

    // BACK button: Return from Class to Home
    public void GoBackHome()
    {
        SceneManager.LoadScene("home");
    }
}
