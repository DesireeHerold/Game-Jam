using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToLobby : MonoBehaviour
{
    public void backToSceneSelection()
    {
        SceneManager.LoadScene("Lobby");
    }
}
