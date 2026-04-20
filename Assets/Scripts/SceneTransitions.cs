using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public string sceneName;
    public Animator transitionAnim;
    public BeginningScene scene1;

    public void Update()
    {
        if (scene1.gameObject == false)
        {
            StartCoroutine(LoadScene());
        }
    }


    public IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}
