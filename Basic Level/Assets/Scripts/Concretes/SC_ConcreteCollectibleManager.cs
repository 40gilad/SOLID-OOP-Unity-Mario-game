using System;
using System.Reflection;
using UnityEngine;

public class SC_ConcreteCollectableManager<T> : MonoBehaviour where T : MonoBehaviour
{
    public int initial_count;
    protected int count;
    protected string _textMeshPro_name;
    protected void Start()
    {
        count = initial_count;
        UiManager.Instance().UpdateUI(_textMeshPro_name, count);
    }
    protected virtual void OnEnable()
    {

        EventInfo collectedEvent = typeof(SC_ConcreteCollectible).GetEvent("ColCollected");
        EventInfo deCollectedEvent = typeof(SC_ConcreteCollectible).GetEvent("DeCollected");

        if (collectedEvent != null)
        {
            Delegate handler = Delegate.CreateDelegate(collectedEvent.EventHandlerType, this, "ColCollected");
            collectedEvent.AddEventHandler(this, handler);
        }

        if (deCollectedEvent != null)
        {
            Delegate handler = Delegate.CreateDelegate(deCollectedEvent.EventHandlerType, this, "DeCollected");
            deCollectedEvent.AddEventHandler(this, handler);
        }
    }

    protected virtual void OnDisable()
    {

        EventInfo collectedEvent = typeof(SC_ConcreteCollectible).GetEvent("ColCollected");
        EventInfo deCollectedEvent = typeof(SC_ConcreteCollectible).GetEvent("DeCollected");

        if (collectedEvent != null)
        {
            MethodInfo removeHandler = collectedEvent.GetRemoveMethod();
            Delegate handler = Delegate.CreateDelegate(collectedEvent.EventHandlerType, this, "ColCollected");
            removeHandler.Invoke(null, new object[] { handler });
        }

        if (deCollectedEvent != null)
        {
            MethodInfo removeHandler = deCollectedEvent.GetRemoveMethod();
            Delegate handler = Delegate.CreateDelegate(deCollectedEvent.EventHandlerType, this, "DeCollected");
            removeHandler.Invoke(null, new object[] { handler });
        }
    }


    protected virtual void ColCollected(string _textMeshPro_name)
    {
        if (_textMeshPro_name == this._textMeshPro_name)
        {
            count++;
            UpdateUI();
        }
    }

    protected virtual void DeCollected(string _textMeshPro_name)
    {
        if (_textMeshPro_name == this._textMeshPro_name)
        {
            count--;
            UpdateUI();
        }
    }

    public int GetCount()
    {
        return count;
    }

    protected virtual void UpdateUI()
    {
        UiManager.Instance().UpdateUI(_textMeshPro_name, count);

    }

}