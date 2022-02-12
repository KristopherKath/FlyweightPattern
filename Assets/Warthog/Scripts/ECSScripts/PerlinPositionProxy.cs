using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[RequiresEntityConversion]
public class PerlinPositionProxy : MonoBehaviour, IConvertGameObjectToEntity
{
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        //creating a new component
        var data = new PerlinPosition { };

        //adding component to an entity (the cube)
        dstManager.AddComponentData(entity, data);
    }
}
