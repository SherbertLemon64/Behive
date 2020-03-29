using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beehive : MonoBehaviour, IEntity
{
    public void Awake() => Init();
    public void OnEnable() => GameManager.beehiveInit.AddListener(BeehiveInitialized);
    public void OnDisable() => GameManager.beehiveInit.AddListener(BeehiveInitialized);

    protected List<IEntity> Entities;

    void Init()
    {
        GameManager.beehiveInit.Invoke(this);
    }

    public void DestroyHive()
    {
        Destroy(this.gameObject);
    }

    public void BeehiveInitialized(Beehive hive)
    {
        if(hive != this && !Entities.Contains(hive))
            Entities.Add(hive);
            hive.Entities.Add(this);
    }
}
