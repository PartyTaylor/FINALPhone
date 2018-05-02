using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class loading : MonoBehaviour
{

    private bool loadScene = false;
    [SerializeField]
    private int scene;
    [SerializeField]
    private Text loadingText;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && loadScene == false)
        {
            loadScene = true;
            loadingText.text = "Loading...";
            StartCoroutine(LoadNewScene());
        }
        if (loadScene == true)
        {

            // ...then pulse the transparency of the loading text to let the player know that the computer is still working.
            loadingText.color = new Color(loadingText.color.r, loadingText.color.g, loadingText.color.b, Mathf.PingPong(Time.time, 1));

        }
    }
    IEnumerator LoadNewScene()
    {
        yield return new WaitForSeconds(3);
        AsyncOperation async = SceneManager.LoadSceneAsync(scene);
        while(!async.isDone)
        {
            yield return null;
        }
    }
}
