using TMPro;
using UnityEngine;

public class SC_LivesManager : MonoBehaviour
{
    protected int count;
    public void Init(int lives_count)
    {
        count = lives_count;
    }

    public int GetLives()
    {
        return count;
    }

    private void SetLives(int lives_count)
    {
        count = lives_count;
    }

    public void IncLives(int lives_count = 1)
    {
        count += lives_count;
    }

    public void DecLives(int lives_count = 1)
    {
        if (lives_count < 0)
            lives_count = lives_count * -1;
        count -= lives_count;
    }
}