using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class VRLoginManager : MonoBehaviour
{
    public TMP_InputField passwordField;
    public TextMeshProUGUI errorMessage;
    public string correctPassword = "123456";
    public string sceneToLoad = "SampleScene";

    void Start()
    {
        if (errorMessage != null)
        {
            errorMessage.gameObject.SetActive(false);
        }
    }

    public void TryLogin()
    {
        string enteredPassword = passwordField.text;

        if (enteredPassword == correctPassword)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            if (errorMessage != null)
            {
                errorMessage.text = "Incorrect password.";
                errorMessage.gameObject.SetActive(true);
            }
        }
    }
}
