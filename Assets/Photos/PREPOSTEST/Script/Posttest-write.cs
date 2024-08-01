using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
public class Posttestwrite : MonoBehaviour
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

    string URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLSfDpB4zA7-t0FaCWvFRe9dmSYKv-mJkZSrVBpWI7PdbWt0qdA/formResponse";

    public void Send()
    {
        StartCoroutine(Post(Question1.text));
    }

    IEnumerator Post(string s1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1901409625", s1);
        form.AddField("entry.1717454850", s1);
        form.AddField("entry.609439635", s1);
        form.AddField("entry.128278824", s1);
        form.AddField("entry.1489417635", s1);
        form.AddField("entry.1047118588",s1);
        form.AddField("entry.940491434", s1);
        form.AddField("entry.1140703820", s1);
        form.AddField("entry.1726922945", s1);
        form.AddField("entry.1135728665", s1);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();
    }
}
