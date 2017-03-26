using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
[System.Serializable]
public class Cube {
    public int id;
    public int xPos;
    public int yPos;
    public string name;
    public Color cubeColor;
    public GameObject obj;
    public GameObject parent;
}
//
public class Grid : MonoBehaviour {
    //
    public static Grid instance;
    public GameObject gridParent;
    [Header("Grid")]
    #region
    public GameObject prefab;
    Vector2 dimensions = new Vector2(110, 60);//320x240//160x120//128x96//80x60
    public Color grey;
    #endregion
    [Header("stuff")]
    #region
    List<GameObject> cubes = new List<GameObject>();
    public List<Material> materials = new List<Material>();
    public List<Color> colors = new List<Color>();
    #endregion
    #region
    public Texture2D sourceTex;
    public Rect sourceRect;
    #endregion
    // 
    void Awake () {
        instance = this;
        //Color[] pix = sourceTex.GetPixels();
        //for (int p = 0; p < pix.Length; p++) {
        //}
        int i = 0;
        for (int x = 0; x < dimensions.x; x++) {
            for (int y = 0; y < dimensions.y; y++) {
                //sourceTex.GetPixel(x, y).grayscale;
                colors.Add(sourceTex.GetPixel(x, y));
                GameObject obj = Instantiate(prefab, new Vector3(x,y, sourceTex.GetPixel(x, y).grayscale), Quaternion.identity) as GameObject;//UnityEngine.Random.Range(0, 2)//sourceTex.GetPixel(x, y).grayscale)
                obj.GetComponent<Cube_Properties>().thisCube.name = "Cube( " + x + ", " + y + ")";
                obj.GetComponent<Cube_Properties>().thisCube.id = i;
                obj.GetComponent<Cube_Properties>().thisCube.xPos = x;
                obj.GetComponent<Cube_Properties>().thisCube.yPos = y;
                obj.GetComponent<Cube_Properties>().thisCube.cubeColor = sourceTex.GetPixel(x, y);
                obj.GetComponent<Cube_Properties>().thisCube.parent = gridParent;
                i++;
                cubes.Add(obj);
            }
        }
        //Color[] pix = sourceTex.GetPixels(0, 0, sourceTex.width, sourceTex.height);
    }
	//
	void Update () {

    }
}
