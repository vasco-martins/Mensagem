using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(int scene)
    {
        Debug.Log("[UIManager] Scene Loaded -> " + scene);
        SceneManager.LoadScene(scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
