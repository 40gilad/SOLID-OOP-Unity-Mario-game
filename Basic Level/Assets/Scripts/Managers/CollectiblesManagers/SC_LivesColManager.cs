public class SC_LivesColManager : SC_ConcreteCollectableManager<SC_ColLives>
{
    private void Awake()
    {
        _textMeshPro_name = "Txt_Lives";
    }

    private void OnEnable()
    {
        SC_Mario.MarioHit += MarioHit;
    }

    private void OnDisable()
    {
        SC_Mario.MarioHit -= MarioHit;
    }
    private void MarioHit(int effect = -1)
    {
        count += effect;
        UiManager.Instance().UpdateUI(_textMeshPro_name, count);
    }
}
