using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    private Dictionary<string, GameObject> canvas_objects;

    #region Singleton
    private UiManager()
    {
        Init();
    }

    static UiManager instance;
    public static UiManager Instance() {
            if (instance == null)
                instance = new UiManager();
            return instance;
    }

    #endregion

    private void Init()
    {
        canvas_objects = new Dictionary<string, GameObject>();
        GameObject canvas = GameObject.Find("Canvas");
        if (canvas != null)
        {
            foreach (Transform child in canvas.transform)
            {
                canvas_objects.Add(child.name, child.gameObject);
                GameObject childObject = child.gameObject;
            }
        }
    }
    public void UpdateUI(string _textMeshPro_name, int count)
    {
        TextMeshPro tm = GameObject.Find(_textMeshPro_name).GetComponent<TextMeshPro>();
        if (tm != null)
        {
            tm.text = string.Empty;
            tm.text = "X " + count.ToString();
        }
    }

    public void ActiveColUI(string _gameObject_name=null)
    {
        if (_gameObject_name != null)
        {
            if (canvas_objects.ContainsKey(_gameObject_name))
                canvas_objects[_gameObject_name].SetActive(true);
        }
        else
        {
            foreach (var kvp in canvas_objects)
                kvp.Value.SetActive(true);
        }
    }

    public void UnActiveColUI(string _gameObject_name=null)
    {
        if (_gameObject_name != null)
        {
            if (canvas_objects.ContainsKey(_gameObject_name))
                canvas_objects[_gameObject_name].SetActive(false);
        }
        else
        {
            foreach (var kvp in canvas_objects)
                kvp.Value.SetActive(false);
        }
    }
}