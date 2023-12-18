using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_InputField loginUsername;
    public TMP_InputField loginPassword;
    public TMP_InputField registerUsername;
    public TMP_InputField registerPassword;
    public TMP_InputField registerEmail;

    public string jwtToken;

    public GameObject authScreen;
    public GameObject selectScreen;
    public GameObject battleScreen;


    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
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
        
    }

    public void OpenAuthScreen()
    {
        authScreen.SetActive(true);
        selectScreen.SetActive(false);
        battleScreen.SetActive(false);
    }

    public void OpenSelectScreen()
    {
        authScreen.SetActive(false);
        selectScreen.SetActive(true);
        battleScreen.SetActive(false);
    }

    public void OpenBattleScreen()
    {
        authScreen.SetActive(false);
        selectScreen.SetActive(false);
        battleScreen.SetActive(true);
    }

    public void Login()
    {


    }

    public void Register()
    {

    }
}
