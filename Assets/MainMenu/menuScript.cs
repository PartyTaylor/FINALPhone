using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public Canvas quitMenu;
    public Button startText;
    public Button startTextTeacher;
    public Button exitText;
	
	void Start ()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        startTextTeacher = startTextTeacher.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
	}
	
	public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        startTextTeacher.enabled = false;
    }
	
    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        startTextTeacher.enabled = true;
        exitText.enabled = true;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("loading1");
    }

    public void StartLevelTeacher()
    {
        SceneManager.LoadScene("loading2");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
