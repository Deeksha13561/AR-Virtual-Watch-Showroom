using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColourSelect : MonoBehaviour
{

	public Material band1;
	public Material band2;
	public Material band3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void w1ColourSelect(){

	string buttonName=EventSystem.current.currentSelectedGameObject.name;
	if(buttonName == "Black button"){
  		//set colour
  		Color myColour= new Color();
  		ColorUtility.TryParseHtmlString("#000000", out myColour);
  		band1.color= myColour;
  	}
	else if(buttonName == "Blue button"){
		//set colour
		Color myColour= new Color();
  		ColorUtility.TryParseHtmlString("#103B90", out myColour);
  		band1.color= myColour;
  	}

    }

public void w2ColourSelect(){
string buttonName=EventSystem.current.currentSelectedGameObject.name;
	if(buttonName == "Black button"){
  		//set colour
  		Color myColour= new Color();
  		ColorUtility.TryParseHtmlString("#000000", out myColour);
  		band2.color= myColour;
  	}
	else if(buttonName == "Red button"){
		//set colour
		Color myColour= new Color();
  		ColorUtility.TryParseHtmlString("#740202", out myColour);
  		band2.color= myColour;
  	}
    } 

    public void w3ColourSelect(){
string buttonName=EventSystem.current.currentSelectedGameObject.name;
	if(buttonName == "Black button"){
  		//set colour
  		Color myColour= new Color();
  		ColorUtility.TryParseHtmlString("#000000", out myColour);
  		band3.color= myColour;
  	}
	else if(buttonName == "Silver button"){
		//set colour
		Color myColour= new Color();
  		ColorUtility.TryParseHtmlString("#A1A1A1", out myColour);
  		band3.color= myColour;
  	}
    }
}
