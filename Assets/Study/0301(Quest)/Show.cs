using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Show : MonoBehaviour
{
    public Image uiImag;
    public List<Sprite> image;
    public int index = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiImag.sprite = image[index];
    }

    public void RightButton()
    {
        index++;
        if (index == image.Count)
        {
            index = 0;
        }
        uiImag.sprite = image[index];
    }

    public void LeftButton()
    {
        index--;
        // 3 -> 2 -> 1 -> 0 -> -1
        if (index == -1)
        {
            index = image.Count-1;
        }
        uiImag.sprite = image[index];
    }
}
