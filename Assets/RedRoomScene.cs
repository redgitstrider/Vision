using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedRoomScene : MonoBehaviour
{

    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene(sceneName: "Scenes/RedRoom");
    }
}
