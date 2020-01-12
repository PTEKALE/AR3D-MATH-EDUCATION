using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Vuforia;

public class Restart1 : VuforiaMonoBehaviour
{

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
