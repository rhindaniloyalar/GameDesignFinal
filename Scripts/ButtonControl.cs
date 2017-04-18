using UnityEngine;
using System.Collections;

public class ButtonControl : MonoBehaviour {

    public void OnClick()
    {
        if (Application.loadedLevelName == "IntroScreen")
        {
            Application.LoadLevel("CreateCharacter");
        }
    }
}
