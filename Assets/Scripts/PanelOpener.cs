using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    [SerializeField] // Encapsulation
    private GameObject Panel;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        Panel.SetActive(true);
    }
}
