using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Json;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Net.Cache;

public class TestDB: MonoBehaviour
{
    ////private string url_insert = "http://dymy2002.dothome.co.kr/insert.php";
    ////private string url_select = "http://dymy2002.dothome.co.kr/index.php";
    ////private string url = "http://quine.dothome.co.kr/plan_insert.php";
    //private string url = "http://quine.dothome.co.kr/plan_view.php";
    //public static TestDB instance = null;// 싱글톤 인스턴스 선언
    //public Text text1;
    //public Text text2;
    //public Text text3;

        // test

    private void Awake()
    {
        //instance = this;//싱그톤 인스턴스 할당
    }

   void Start()
    {
        //  StartCoroutine(GetDate());
        // StartCoroutine(GetUsers());
        //StartCoroutine(Login("testuser","12345"));
        StartCoroutine(RegisterUser("testuser3", "123456"));
    }
    public IEnumerator GetDate()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://dymy2002.dothome.co.kr/TestConnect.php/"))
        {
            yield return www.Send();

            if(www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                //show results as text
                Debug.Log(www.downloadHandler.text);

                //Or retriece results as binary data
                byte[] results = www.downloadHandler.data;
            }






        }
    }

    public IEnumerator GetUsers()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://dymy2002.dothome.co.kr/TestDBConnect.php/"))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                //show results as text
                Debug.Log(www.downloadHandler.text);

                //Or retriece results as binary data
                byte[] results = www.downloadHandler.data;
            }
         }
    }

    IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        using (UnityWebRequest www= UnityWebRequest.Post("http://dymy2002.dothome.co.kr/Login.php/",form))
        {
            yield return www.SendWebRequest();

            if(www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }

         }
    }

    IEnumerator RegisterUser(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        using (UnityWebRequest www = UnityWebRequest.Post("http://dymy2002.dothome.co.kr/ReigisterUser.php/", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }

        }
    }

    public IEnumerator GetUserItems()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://dymy2002.dothome.co.kr/TestDBConnect.php/"))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                //show results as text
                Debug.Log(www.downloadHandler.text);

                //Or retriece results as binary data
                byte[] results = www.downloadHandler.data;
            }
        }
    }
}
