using System;
using UnityEngine;

namespace TDDForUnity
{
    public class AssetSpawner
    {
        public void createAGameObjectFromString(String csvString)
        {
            String[] tokens = csvString.Split(",".ToCharArray());
            if (tokens.Length >= 4)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Vector3 position = new Vector3(float.Parse(tokens[1]),float.Parse(tokens[2]),float.Parse(tokens[3]));
                cube.name = tokens[0];
                cube.transform.position = position;
            }
        }
    }
}