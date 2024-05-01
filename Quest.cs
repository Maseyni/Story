using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public List<GameObject> Polochki = new List<GameObject>();

    private void Start()
    {
        Polochki[0].SetActive(false);
    }

    public void Btn0()
    {
        Polochki[0].SetActive(true);
    }

    public void Btn1()
    {
        Polochki[0].SetActive(false);
    }
}