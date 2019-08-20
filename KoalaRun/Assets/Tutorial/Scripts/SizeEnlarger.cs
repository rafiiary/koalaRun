using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeEnlarger : MonoBehaviour
{
    public GameObject image;
    public int initialScale;
    public int targetScale;

    Vector3 imageScale;
    // Start is called before the first frame update
    void Start()
    {
        imageScale = image.GetComponent<Transform>().localScale;
        imageScale = new Vector3(1, 1) * initialScale;
        StartCoroutine(Enlarge());
    }
    private IEnumerator Enlarge()
    {
        while(imageScale.x < targetScale)
        {
            imageScale += new Vector3(0.1f, 0.1f);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
