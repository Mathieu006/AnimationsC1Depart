using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendreTorche : MonoBehaviour
{
    // Start is called before the first frame update
   
[SerializeField] GameObject _monJoueur;

[SerializeField] GameObject _torcheMur;

   
[SerializeField] GameObject _torcheJoueur;


private void OnTriggerEnter(Collider other){

if(other.tag == "Player"){

        _torcheMur.SetActive(false);
        _torcheJoueur.SetActive(true);
    }


}






}

