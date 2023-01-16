using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Bombpf;

    [SerializeField]
    private GameObject Fruit_00pf;
    [SerializeField]
    private GameObject Fruit_01pf;
    [SerializeField]
    private GameObject Fruit_02pf;
    [SerializeField]
    private GameObject Fruit_03pf;

    [SerializeField]
    private GameObject bomb_side;
    private bool stopSpawning=false;
    private int selector;

    void Start(){
        StartCoroutine(BombSpawnRoutine());
        StartCoroutine(FuitSpawnRoutine());
    }

    public void stopSpawner(){
        stopSpawning=true;
    }

    public void stop(){
        stopSpawning=true;
    }

    IEnumerator BombSpawnRoutine(){
        while(stopSpawning==false){
            Vector3  position= new Vector3(Random.Range(140f,780f),420,0);
            GameObject bomb= Instantiate(Bombpf, position, Quaternion.identity);
            bomb.transform.parent= bomb_side.transform;
            yield return new WaitForSeconds(7.0f);
        }
    }

    IEnumerator FuitSpawnRoutine(){
        while(stopSpawning==false){
            Vector3  position= new Vector3(Random.Range(140f,780f),420,0);
            selector=Random.Range(0,4);
            if(selector==0){
                GameObject fruit= Instantiate(Fruit_00pf, position, Quaternion.identity);
                fruit.transform.parent= bomb_side.transform;    
            }
            else if(selector==1){
                GameObject fruit= Instantiate(Fruit_01pf, position, Quaternion.identity);
                fruit.transform.parent= bomb_side.transform;    
            }
            else if(selector==2){
                GameObject fruit= Instantiate(Fruit_02pf, position, Quaternion.identity);
                fruit.transform.parent= bomb_side.transform;    
            }
            else if(selector==3){
                GameObject fruit= Instantiate(Fruit_03pf, position, Quaternion.identity);
                fruit.transform.parent= bomb_side.transform;    
            }
            yield return new WaitForSeconds(3.0f);
        }
    }

}
