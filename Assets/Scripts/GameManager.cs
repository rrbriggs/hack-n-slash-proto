using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    public void LoadGameBeginning()
    {
        StartCoroutine(StartGame());
    }

    private IEnumerator StartGame()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        while (operation.isDone == false)
        {
            yield return null;
        }

        Debug.Log("Game Starting");
    }
}