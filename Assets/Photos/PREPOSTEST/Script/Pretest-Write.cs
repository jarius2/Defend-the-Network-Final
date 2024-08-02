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
        StartCoroutine(Post(Question1.text,Question2.text,Question3.text,Question4.text,Question5.text,Question6.text,Question7.text,Question8.text,Question9.text,Question10.text));
    }

    IEnumerator Post(string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1958166543", s1);
        form.AddField("entry.2144430512", s2);
        form.AddField("entry.2002522859", s3);
        form.AddField("entry.985707723", s4);
        form.AddField("entry.815792001", s5);
        form.AddField("entry.2115540110",s6);
        form.AddField("entry.1474042793", s7);
        form.AddField("entry.896265687", s8);
        form.AddField("entry.85727533", s9);
        form.AddField("entry.425767890", s10);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();
    }
    

}
