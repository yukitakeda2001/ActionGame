using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEvent : MonoBehaviour
{

    //TODO:AnimationEventを使わないで実装する
    public void FinDeathAnimation()
    {
        gameObject.SetActive(false);
    }
}
