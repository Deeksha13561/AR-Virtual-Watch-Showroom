using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class watchselect : MonoBehaviour
{
public GameObject watchModel1;
public GameObject watchModel2;
public GameObject watchModel3;

public GameObject w1Window;
public GameObject w2Window;
public GameObject w3Window;


    void Start()
    {
       

    }
public void WatchOneButtonClicked(){

	//show watch model 1 on users wrist

	watchModel1.SetActive(true);
	watchModel2.SetActive(false);
	watchModel3.SetActive(false);
//animate w1 window
	w1Window.SetActive(true);
	w2Window.SetActive(false);
	w3Window.SetActive(false);
}

public void WatchTwoButtonClicked(){
	//show watch model 2 on users wrist

	watchModel1.SetActive(false);
	watchModel2.SetActive(true);
	watchModel3.SetActive(false);

	//animate w2 window
	w1Window.SetActive(false);
	w2Window.SetActive(true);
	w3Window.SetActive(false);
	
}

public void WatchThreeButtonClicked(){
	//show watch model 3 on users wrist
	watchModel1.SetActive(false);
	watchModel2.SetActive(false);
	watchModel3.SetActive(true);
	

	//animate w3 window
w1Window.SetActive(false);
	w2Window.SetActive(false);
	w3Window.SetActive(true);
}
  
  public void CloseButtonClicked(){
  	string buttonName=EventSystem.current.currentSelectedGameObject.name;
  	if(buttonName == "w1close"){
  		//
  		w1Window.SetActive(false);
  	}
  	else if(buttonName == "w2close"){
		w2Window.SetActive(false);
  	}
  	else if(buttonName == "w3close"){
  		w3Window.SetActive(false);
  	}
  }
}
