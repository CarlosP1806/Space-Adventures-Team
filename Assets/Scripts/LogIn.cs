using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class LogIn : MonoBehaviour
{
    // Inputs register
    public TMP_InputField lista;
    public TMP_Dropdown grupo;
    public Toggle m_toggle;
    public Toggle f_toggle;

    // Inputs login
    public TMP_InputField lista_login;
    public TMP_Dropdown grupo_login;


    IEnumerator Upload(User u)
    {
        WWWForm form = new WWWForm();
        form.AddField("user", JsonUtility.ToJson(u));
        using (UnityWebRequest www =
            UnityWebRequest.Post("http://127.0.0.1:5000/api/estudiantes", form)) // Change to ip of host
        {
            yield return www.SendWebRequest();
            if (www.result != UnityWebRequest.Result.Success)
                Debug.Log(www.error);
            else
            {
                Debug.Log("Success");
            }
        }
    }

    IEnumerator Login(User u)
    {
        WWWForm form = new WWWForm();
        form.AddField("user", JsonUtility.ToJson(u));
        using (UnityWebRequest www =
            UnityWebRequest.Post("http://127.0.0.1:5000/api/estudiantes/login", form)) // Change to ip of host
        {
            yield return www.SendWebRequest();
            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log("Login failed");
            }
            else
            {
                Debug.Log("Login successful");
            }
        }
    }

    public void ClickRegister()
    {
        User u = new User();
        u.numero_lista = int.Parse(lista.text);
        u.grupo = grupo.options[grupo.value].text;
        if (m_toggle.isOn)
        {
            u.genero = "M";
        }
        else if (f_toggle.isOn)
        {
            u.genero = "F";
        }
        
        StartCoroutine(Upload(u));
    }

    public void ClickLogin()
    {
        User u = new User();
        u.numero_lista = int.Parse(lista_login.text);
        u.grupo = grupo_login.options[grupo_login.value].text;
        StartCoroutine(Login(u));
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
