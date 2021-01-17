using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject currentSpell;
    public GameObject fireballfab;
    public GameObject lightningsparkfab;

    //public Button m_YourThirdButton;
    // Start is called before the first frame update
    void Start()
    {
        //fireballButton.onClick.AddListener(TaskOnClick);
        //lightningSparkButton.onClick.AddListener(TaskOnClick);
        //m_YourThirdButton.onClick.AddListener(() => ButtonClicked(42));
        //m_YourThirdButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireballActivate()
    {
        currentSpell = fireballfab;
    }

    public void LightningSparkActivate()
    {
        currentSpell = lightningsparkfab;
    }
}
