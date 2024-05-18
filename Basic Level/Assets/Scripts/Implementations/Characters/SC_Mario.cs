public class SC_Mario :SC_ConcreteCharacter
{
    public delegate void SC_MarioHitHandler(int effect =-1);
    public static event SC_MarioHitHandler MarioHit;
    public delegate void SC_MarioDeadHandler();
    public static event SC_MarioDeadHandler MarioDead;
    public SC_LivesColManager _livesColManager;
    private string _textMeshPro_name = "Txt_Lives";


    private void Start()
    {
        Init();
        init_lives_count = _livesColManager.GetCount();
        lives_manager.Init(init_lives_count);
    }
    public override void Hit(int effect = -1)
    {
        base.Hit(effect);
        MarioHit(effect);
    }
    public override void Die()
    {
        MarioDead();
    }

}
