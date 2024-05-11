using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Class : MonoBehaviour
{
    [SerializeField] private  TMP_Text text;
    [SerializeField] private GameObject t;
    [SerializeField] private GameObject n;
    [SerializeField] private GameObject s;

    public void ChooseClass(int ind)
    {
        if (ind == 0)
        {
            t.SetActive(true);
            n.SetActive(false);
            s.SetActive(false);
            text.text = '10ò';
        }
        if (ind == 1)
        {
            t.SetActive(false);
            n.SetActive(true);
            s.SetActive(false);
        }
        if (ind == 2)
        {
            t.SetActive(false);
            n.SetActive(false);
            s.SetActive(true);
        }










        //text = gameObject.AddComponent<TextMeshProUGUI>();

        //switch (index)
        //{

        //    case 0: text.text = "10ò";
        //        t.SetActive(true);
        //        n.SetActive(false);
        //        s.SetActive(false); break;
        //    case 1: text.text = "10åí";
        //        t.SetActive(false);
        //        n.SetActive(true);
        //        s.SetActive(false); break;
        //    case 2: text.text = "10ñý";
        //        t.SetActive(false);
        //        n.SetActive(false);
        //        s.SetActive(true); break;
        //}
    }
}
