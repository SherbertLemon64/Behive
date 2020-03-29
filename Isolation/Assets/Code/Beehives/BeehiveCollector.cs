using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class BeehiveCollector : Beehive
{
    float timer = 0;
    float cooldown = 5f;
    [SerializeField]
    ParticleSystem particles;

    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
            if(!particles.isPlaying)
                particles.Play();
    }

    private void OnMouseDown()
    {
        Debug.Log($"Interracting with collecting");
        if(timer <= 0)
        {
            timer = cooldown;
        }
    }

    void ReleaseCollectorBees()
    {
        int CollectedPollen = 0;
        List<BeehiveConverter> converters = new List<BeehiveConverter> { };

        foreach (IEntity Entity in Entities)
            if (Entity.GetType() == typeof(Plant))
                if ((Entity as Plant).HasPollen)
                    CollectedPollen++;

        foreach (IEntity Entity in Entities)
            if (Entity.GetType() == typeof(BeehiveConverter))
                converters.Add(Entity as BeehiveConverter);

        int AmountToSend = (CollectedPollen / converters.Count);

        foreach (BeehiveConverter converter in converters)
            converter.UploadPollen(AmountToSend);

        particles.Stop();
    }
}
