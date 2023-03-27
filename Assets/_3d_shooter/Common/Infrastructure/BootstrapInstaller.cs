using UnityEngine.SceneManagement;
using Zenject;

public class BootstrapInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
