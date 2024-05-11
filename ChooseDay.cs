using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose_Monday : MonoBehaviour
{
    [SerializeField] private GameObject PanelOn;
    [SerializeField] private GameObject PanelOFF1;
    [SerializeField] private GameObject PanelOFF2;
    [SerializeField] private GameObject PanelOFF3;
    [SerializeField] private GameObject PanelOFF4;
    public void OnDay()
    {
        PanelOn.SetActive(true);
        PanelOFF1.SetActive(false);
        PanelOFF2.SetActive(false);
        PanelOFF3.SetActive(false);
        PanelOFF4.SetActive(false);
    }
}
