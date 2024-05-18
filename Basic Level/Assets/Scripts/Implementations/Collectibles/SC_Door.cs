using UnityEngine;

public class SC_Door : SC_ConcreteCollectible
{
    public delegate void DoorCollisionHandler();
    public static event DoorCollisionHandler OnDoorCollision;

    protected override void OnCollect()
    {
        if(SC_KeyColManager.IsCollected()){
            if (OnDoorCollision != null)
                OnDoorCollision();
        }

    }
}

