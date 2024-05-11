using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose_Class : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    public void Open()
    {
        panel.SetActive(true);
    }

    public void Clouse()
    {
        panel.SetActive(false);
    }
        
}
