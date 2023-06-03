using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update

    private void OpenMouseDown()
    {
        Panel.SetActive(true);
    }
}
