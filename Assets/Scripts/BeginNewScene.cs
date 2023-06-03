using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class BeginNewScene : MonoBehaviour
{
    public GameObject Panel;

    void update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
        }
    }
    // Credits
    // How can I use inheritance to simplify this?

    public void OpenUnity()
    {
        Application.OpenURL("https://unity.com");
    }

    public void OpenSkybox()
    {
        Application.OpenURL("https://assetstore.unity.com/packages/2d/textures-materials/sky/8k-skybox-pack-free-150926");
    }

    public void OpenDesertBuildings()
    {
        Application.OpenURL("https://assetstore.unity.com/packages/3d/environments/urban/desert-buildings-71445");
    }

    public void OpenFantasyWoodenGUIFree()
    {
        Application.OpenURL("https://assetstore.unity.com/packages/2d/gui/fantasy-wooden-gui-free-103811");
    }

    public void OpenVISPBRGrassTextures()
    {
        Application.OpenURL("https://assetstore.unity.com/packages/2d/textures-materials/floors/vis-pbr-grass-textures-198071");
    }

    public void OpenGlobalRoadsAndTrafficLite()
    {
        Application.OpenURL("https://assetstore.unity.com/packages/3d/environments/roadways/global-roads-traffic-lite-218045");
    }

    public void OpenUnityLearn()
    {
        Application.OpenURL("https://unity.com/learn");
    }

    public void OpenStandardUnityAssetStoreEULA()
    {
        Application.OpenURL("https://unity.com/legal/as-terms");
    }

    public void OpenGoogleTranslate()
    {
        Application.OpenURL("https://translate.google.com");
    }
}
