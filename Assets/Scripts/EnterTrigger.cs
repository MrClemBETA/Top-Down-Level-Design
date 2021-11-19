using Cainos.PixelArtTopDown_Basic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTrigger : MonoBehaviour
{
    public string triggerName;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerData.instance.EnterTriggerLocation == triggerName)
        {
            PlayerData.instance.gameObject.transform.position = transform.position;
            CameraFollow.instance.QuickAdjust();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
