using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public float tiempo;

    private void Update()
    {
        Time.timeScale = tiempo;
    }

}
