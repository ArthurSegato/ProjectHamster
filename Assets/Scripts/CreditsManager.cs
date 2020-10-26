using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour
{
    public void AbreArthur()
    {
        Application.OpenURL("https://arthursegato.com/");
    }
    public void AbreJoao()
    {
        Application.OpenURL("https://github.com/JoaoPretti");
    }
    public void AbreGustavo()
    {
        Application.OpenURL("https://github.com/gustavospelta");
    }
    public void AbreMatheus()
    {
        Application.OpenURL("https://www.artstation.com/matheusleonor");
    }
    public void VoltarMenu()
    {
        SceneManager.LoadScene("MenuInicial");
    }
}
