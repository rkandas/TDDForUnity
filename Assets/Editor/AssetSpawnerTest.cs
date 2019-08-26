using System;
using System.Collections;
using NUnit.Framework;
using TDDForUnity;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;



namespace Tests
{
    public class AssetSpawnerTest 
    {
        [UnityTest]
        public IEnumerator Should_InstantiateObject_When_GivenStringHasNameAndPosition()
        {
            //given 
            // mock the CSV reader
            var reader = Substitute.For<ICsvReader>();
            reader.ReadNextLine().Returns("CubeX,2,3,3");
            String expectedName = "CubeX";
            
            String csvString =  reader.ReadNextLine();
            Vector3 expectedCoordinate = new Vector3(2f,3f,3f);
            
            //when
            AssetSpawner assetSpawner = new AssetSpawner();
            assetSpawner.createAGameObjectFromString(csvString);
            
            //then
            GameObject obj = GameObject.Find(expectedName);
            Assert.IsNotNull(obj);
            Assert.AreEqual(expectedCoordinate, obj.transform.position);
            yield return null;
        }
    }
    
}
