using UnityEngine;

public class TestingGameManager : MonoBehaviour
{
    [SerializeField] private SettingsManager settingsManager;

    private void Start()
    {
        settingsManager.Initialize();
    }

    private void OnDisable()
    {
        settingsManager.Conclude();
    }
}
