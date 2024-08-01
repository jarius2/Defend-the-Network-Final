using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;

public class PretestWrite : MonoBehaviour
{
    
    [SerializeField] TMP_InputField Question1;
    [SerializeField] TMP_InputField Question2;
    [SerializeField] TMP_InputField Question3;
    [SerializeField] TMP_InputField Question4;
    [SerializeField] TMP_InputField Question5;
    [SerializeField] TMP_InputField Question6;
    [SerializeField] TMP_InputField Question7;
    [SerializeField] TMP_InputField Question8;
    [SerializeField] TMP_InputField Question9;
    [SerializeField] TMP_InputField Question10;

    string URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLSd6HAnGQS7gxd7nwGa7wHaf-P4QMFtkD7kMq9FkSd9qG9CBUw/formResponse";

    public void Send()
    {
        StartCoroutine(Post(Question1.text));
    }

    IEnumerator Post(string s1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1958166543", s1);
        form.AddField("entry.2144430512", s1);
        form.AddField("entry.2002522859", s1);
        form.AddField("entry.985707723", s1);
        form.AddField("entry.815792001", s1);
        form.AddField("entry.2115540110",s1);
        form.AddField("entry.1474042793", s1);
        form.AddField("entry.896265687", s1);
        form.AddField("entry.85727533", s1);
        form.AddField("entry.425767890", s1);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();
    }
    

}
