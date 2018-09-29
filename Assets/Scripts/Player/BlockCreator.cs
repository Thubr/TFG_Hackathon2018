using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreator : MonoBehaviour {

    public GameObject StdBlock;     //1
    public GameObject ShootBlock;   //2
    public GameObject ShieldBlock;  //3
    public GameObject CoreBlock;    //4

    Vector3 scale;


    
        public int[,] BMatrix ={{ 1, 1, 1, 1, 1, 1, 1, 1, 1},
                                { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                                { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                                { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                                { 2, 1, 1, 1, 1, 1, 1, 1, 1},
                                { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                                { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                                { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                                { 1, 1, 1, 1, 1, 1, 1, 1, 1}};
                        
                      /*
    public int[,] BMatrix ={{ 0, 0, 0, 0, 0, 0, 0, 1, 1},
                            { 0, 0, 0, 0, 0, 1, 1, 1, 1},
                            { 0, 0, 0, 1, 1, 1, 1, 1, 1},
                            { 0, 1, 1, 1, 1, 1, 1, 1, 1},
                            { 2, 1, 1, 1, 1, 1, 1, 1, 1},
                            { 0, 1, 1, 1, 1, 1, 1, 1, 1},
                            { 0, 0, 0, 1, 1, 1, 1, 1, 1},
                            { 0, 0, 0, 0, 0, 1, 1, 1, 1},
                            { 0, 0, 0, 0, 0, 0, 0, 1, 1}};
                            */

    // Use this for initialization
    void Start () {
        int xLenght = BMatrix.GetLength(0);
        int yLenght = BMatrix.GetLength(1);
        scale = StdBlock.transform.localScale;
        GameObject clone = null;

        for (int y = 0; y < yLenght; y++)
        {
            for (int x = 0; x < xLenght; x++)
            {
                if (BMatrix[y, x] == 0) continue;
                else if (BMatrix[y, x] == 1) clone = StdBlock;
                else if (BMatrix[y, x] == 2) clone = ShootBlock;
                else if (BMatrix[y, x] == 3) clone = ShieldBlock;
                else if (BMatrix[y, x] == 4) clone = CoreBlock;

                Instantiate(clone, transform.position + new Vector3((x - xLenght / 2) * scale.x, (y - yLenght / 2) * scale.y, 0), transform.rotation, transform);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
