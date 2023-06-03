using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private Renderer openPanel;
    [SerializeField] // Encapsulation
    private GameObject Panel;
    private bool panelIsActive = false;

    private void Start()
    {
        openPanel = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        PanelIsActive(); // Abstraction
    }

    void PanelIsActive()
    {
        if (!panelIsActive)
        {
            Debug.Log("Click!");
            Panel.SetActive(true);
            panelIsActive = true;
        }

        else if (panelIsActive)
        {
            Debug.Log("Unclicked!");
            Panel.SetActive(false);
            panelIsActive = false;
        }
    }
}
