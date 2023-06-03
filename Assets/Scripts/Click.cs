using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private Renderer openPanel;
    public GameObject Panel;
    private bool panelIsActive = false;

    private void Start()
    {
        openPanel = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        if (!panelIsActive)
        {
            Debug.Log("Click!");
            Panel.SetActive(true);
            panelIsActive = true;
        }

        else if(panelIsActive)
        {
            Debug.Log("Unclicked!");
            Panel.SetActive(false);
            panelIsActive = false;
        }
    }
}
