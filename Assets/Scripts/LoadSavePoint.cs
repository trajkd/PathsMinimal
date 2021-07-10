using UnityEngine;
using System.Collections;
using Fungus;
 
[CommandInfo("Flow",
    "Load Savepoint",
    "Loads a savepoint")]
public class LoadSavePoint : Command
{
    [SerializeField]
    protected string saveDataKey = FungusConstants.DefaultSaveDataKey;
 
    public override void OnEnter()
    {
        var saveManager = FungusManager.Instance.SaveManager;
 
        if (saveManager.SaveDataExists(saveDataKey))
        {
            saveManager.Load(saveDataKey);
        }
        else
        {
            Continue();
        }
 
    }
 
}