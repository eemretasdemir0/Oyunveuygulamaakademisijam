using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ogretmenscript : MonoBehaviour
{
    public GameObject ses1;

    private void Start()
    {
        ses1.SetActive(true);
        StartCoroutine(spawndelay());

    }
    IEnumerator spawndelay()
    {
        yield return new WaitForSecondsRealtime(39f);
        SceneManager.LoadScene("4");
    }
}
