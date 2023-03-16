using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomScript : MonoBehaviour
{
    public GameObject[] shirts;
    public GameObject[] pants;

    // Start is called before the first frame update

    public void Shirt(int shirtNumber)
    {
        for (int i = 0; i < shirts.Length; i++)
        {
            shirts[i].SetActive(false);
        }

        shirts[shirtNumber].SetActive(true);
    }

    public void Pants(int pantsNumber)
    {
        for (int i = 0; i < pants.Length; i++)
        {
            pants[i].SetActive(false);
        }

        pants[pantsNumber].SetActive(true);
    }
}