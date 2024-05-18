using UnityEngine;

public class SC_KeyColManager : SC_ConcreteCollectableManager<SC_ColKey>
{
    private string ui_key_go_name;
    private static bool is_colected = false;

    private void Awake()
    {
        ui_key_go_name = "UI_Key";
        //_textMeshPro_name = "UI_Key";

    }

    private void Start()
    {
        UiManager.Instance().UnActiveColUI(ui_key_go_name);
    }

    public static bool IsCollected()
    {
        return is_colected;
    }
    protected override void ColCollected(string _textMeshPro_name)
    {
        if (ui_key_go_name == _textMeshPro_name)
        {
            is_colected = true;
            UiManager.Instance().ActiveColUI(ui_key_go_name);
            GameObject.Find("Sprite_Door").GetComponent<BoxCollider2D>().isTrigger = true;
        }

    }
}
