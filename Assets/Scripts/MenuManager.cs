using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("CapituloUm");
    }
    public void AbrirCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void ExitGame()
    {
        //Fecha a aplicação (Funciona apenas no editor)
        //UnityEditor.EditorApplication.isPlaying = false;
        //Fecha a aplicação (funciona apenas para o compilado)
        Application.Quit();
    }
}
