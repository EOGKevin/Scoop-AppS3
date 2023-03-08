using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProfileManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI a_TextMeshProUGUI;
    [SerializeField] TextMeshProUGUI b_TextMeshProUGUI;

    // Start is called before the first frame update
    void Start()
    {
        FirebaseAuthManager.instance.LoadUserData(user =>
        {
            a_TextMeshProUGUI.text = user.Name;
            b_TextMeshProUGUI.text = user.Email;

        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
