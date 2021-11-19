using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadePanel : MonoBehaviour
{
    public static FadePanel instance;

    public float transitionTime = 4f;

    public bool Fading { get { return fadingOut || fadingIn; } }

    private bool fadingOut = false;
    private bool fadingIn = false;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(transform.parent);
        } else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fadingOut)
        {
            Color c = GetComponent<Image>().color;
            c.a += Time.deltaTime / transitionTime;
            GetComponent<Image>().color = c;
            if(c.a >= 1f)
            {
                fadingOut = false;
                fadingIn = true;
            }
        }
        if(fadingIn)
        {
            Color c = GetComponent<Image>().color;
            c.a -= Time.deltaTime / transitionTime;
            GetComponent<Image>().color = c;
            if(c.a <= 0f)
            {
                fadingIn = false;
            }
        }
    }

    public float FadeOut()
    {
        fadingOut = true;
        return transitionTime;
    }
}
