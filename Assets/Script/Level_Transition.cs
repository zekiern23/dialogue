using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Transition : MonoBehaviour
{
    public void Levelac(string sahneadi)
    {
        SceneManager.LoadScene(sahneadi);
    }

    public void QuitGame ()
    {
        Application.Quit ();
    }
}
