using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    #region Enumerations

    #endregion

    #region Static Variables

    #endregion

    #region Public Variables
    public OVRInput.Button shootButton;
    #endregion

    #region Private Variables
    [SerializeField]
    OVRGrabbable grabbable;
    [SerializeField]
    AudioSource audioSource;
    #endregion

    #region MonoBehaviour Callbacks
    //Awake is called when the script instance is being loaded
    private void Awake()
    {

    }

    //This function is called when the object becomes enabled and active
    private void OnEnable()
    {

    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called every frame, if the MonoBehaviour is enabled
    private void Update()
    {

    }

    //This function is called when the behaviour becomes disabled
    private void OnDisable()
    {

    }
    #endregion

    #region DevkitName Callbacks

    #endregion

    #region Script Methods

    #endregion


}
