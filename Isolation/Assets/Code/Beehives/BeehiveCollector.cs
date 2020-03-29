using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class BeehiveCollector : Beehive
{  
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
    }
}
