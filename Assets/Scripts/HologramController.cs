using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HologramController : MonoBehaviour
{
    [SerializeField] private Button _BL, _RL, _GL, _BluL, _YL, _Extra, _Altea, _Daibazaal, _Balmera, _Ship;
    
    void Start()
    {

    }

    public void Main_Non_Interactable()
    {
        _BL.interactable = false;
        _RL.interactable = false;
        _GL.interactable = false;
        _BluL.interactable = false;
        _YL.interactable = false;
        _Extra.interactable = false;
        _Altea.interactable = false;
        _Daibazaal.interactable = false;
        _Balmera.interactable = false;
        _Ship.interactable = false;
    }
    public void Main_Interactable()
    {
        _BL.interactable = true;
        _RL.interactable = true;
        _GL.interactable = true;
        _BluL.interactable = true;
        _YL.interactable = true;
        _Extra.interactable = true;
        _Altea.interactable = true;
        _Daibazaal.interactable = true;
        _Balmera.interactable = true;
        _Ship.interactable = true;
    }
}
