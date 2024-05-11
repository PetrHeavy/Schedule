using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseDay : MonoBehaviour
{
    [SerializeField] private GameObject PanelSunday;
    [SerializeField] private GameObject PanelTuesday;
    [SerializeField] private GameObject PanelWednezday;
    [SerializeField] private GameObject PanelThursday;
    [SerializeField] private GameObject PanelFriday;

    public void ChooseMonday(int index)
    {
        PanelSunday.SetActive(false);
        PanelTuesday.SetActive(false);
        PanelWednezday.SetActive(false);
        PanelThursday.SetActive(false);
        PanelFriday.SetActive(false);
        
        
        
        
        
        
        
        
        
        
        
        
        //if (index == 0)
        //{
        //    PanelSunday.SetActive(true);
        //    PanelTuesday.SetActive(false);
        //    PanelWednezday.SetActive(false);
        //    PanelThursday.SetActive(false);
        //    PanelFriday.SetActive(false);
        //}
        //if (index == 1)
        //{
        //    PanelSunday.SetActive(false);
        //    PanelTuesday.SetActive(true);
        //    PanelWednezday.SetActive(false);
        //    PanelThursday.SetActive(false);
        //    PanelFriday.SetActive(false);
        //}
        //if (index == 2)
        //{
        //    PanelSunday.SetActive(false);
        //    PanelTuesday.SetActive(false);
        //    PanelWednezday.SetActive(true);
        //    PanelThursday.SetActive(false);
        //    PanelFriday.SetActive(false);
        //}
        //if (index == 3)
        //{
        //    PanelSunday.SetActive(false);
        //    PanelTuesday.SetActive(false);
        //    PanelWednezday.SetActive(false);
        //    PanelThursday.SetActive(true);
        //    PanelFriday.SetActive(false);
        //}
        //if (index == 4)
        //{
        //    PanelSunday.SetActive(false);
        //    PanelTuesday.SetActive(false);
        //    PanelWednezday.SetActive(false);
        //    PanelThursday.SetActive(false);
        //    PanelFriday.SetActive(true);
        //}
    }
}
