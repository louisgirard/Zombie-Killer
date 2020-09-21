using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();   
    }

    public void show()
    {
        canvasGroup.alpha = 1;
        StartCoroutine(BloodFade());
    }

    IEnumerator BloodFade()
    {
        while(canvasGroup.alpha >= 0)
        {
            canvasGroup.alpha -= .05f;
            yield return new WaitForSeconds(.1f);
        }
    }
}
