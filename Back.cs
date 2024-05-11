using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public GameObject sceneNumber0;
    public GameObject main0;
    // Start is called before the first frame update
    public void CloseSettings()
    {
        sceneNumber0.SetActive(false);
        main0.SetActive(true);
    }
}
