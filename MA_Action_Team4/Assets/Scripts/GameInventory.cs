using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameInventory : MonoBehaviour{

    //5 Inventory Items:
    public GameObject InventoryMenu;
	public GameObject CookMenu;
	private bool InvIsOpen = false;

    public static bool item1bool = true;
    public static bool item2bool = false;
    public static bool item3bool = false;
    public static bool item4bool = false;
    public static bool item5bool = false;
    public static bool item6bool = false;
    public static bool item7bool = false;
    public static bool item8bool = false;
    public static bool item9bool = false;
    public static bool item10bool = false;
    public static bool item11bool = true;
	
	public static bool cooked1bool = false;
    public static bool cooked2bool = false;
    public static bool cooked3bool = false;
    public static bool cooked4bool = false;
    public static bool cooked5bool = false;
	
    public GameObject item1image;
    public GameObject item2image;
    public GameObject item3image;
    public GameObject item4image;
    public GameObject item5image;
    public GameObject item6image;
    public GameObject item7image;
    public GameObject item8image;
    public GameObject item9image;
    public GameObject item10image;
    public GameObject item11image;

    public GameObject cooked1image;
    public GameObject cooked2image;
    public GameObject cooked3image;
    public GameObject cooked4image;
    public GameObject cooked5image;

    public GameObject item1text;
    public GameObject item2text;
    public GameObject item3text;
    public GameObject item4text;
    public GameObject item5text;
    public GameObject item6text;
    public GameObject item7text;
    public GameObject item8text;
    public GameObject item9text;
    public GameObject item10text;
    public GameObject item11text;

    public GameObject cooked1text;
    public GameObject cooked2text;
    public GameObject cooked3text;
    public GameObject cooked4text;
    public GameObject cooked5text;

	public static int item1num;
	public static int item2num;	
	public static int item3num;	
	public static int item4num;	
	public static int item5num;	
	public static int item6num;	
	public static int item7num;
	public static int item8num;	
	public static int item9num;	
	public static int item10num;	
	public static int item11num = 5;	
	
	public static int cooked1num = 0;
	public static int cooked2num = 0;	
	public static int cooked3num = 0;	
	public static int cooked4num = 0;	
	public static int cooked5num = 0;	
	
	//Cookbook variables:
	public GameObject cookButton1;
    //public GameObject cookButton2;
    //public GameObject cookButton3;
    //public GameObject cookButton4;
    //public GameObject cookButton5;
    //public GameObject cookButton6;
	
	public GameObject ingredient1aText;
    public GameObject ingredient1bText;
	// public GameObject ingredient2aText;
    // public GameObject ingredient2bText;
	// public GameObject ingredient3aText;
    // public GameObject ingredient3bText;
	// public GameObject ingredient4aText;
    // public GameObject ingredient4bText;
	// public GameObject ingredient5aText;
    // public GameObject ingredient5bText;	
	// public GameObject ingredient6aText;
    // public GameObject ingredient6bText;	

    void Start(){
        InventoryMenu.SetActive(false);
		CookMenu.SetActive(false);
        InventoryDisplay();
    }

    void InventoryDisplay(){
        if (item1bool == true) { item1image.SetActive(true); } else { item1image.SetActive(false); }
        if (item2bool == true) { item2image.SetActive(true); } else { item2image.SetActive(false); }
        if (item3bool == true) { item3image.SetActive(true); } else { item3image.SetActive(false); }
        if (item4bool == true) { item4image.SetActive(true); } else { item4image.SetActive(false); }
        if (item5bool == true) { item5image.SetActive(true); } else { item5image.SetActive(false); }
        if (item6bool == true) { item6image.SetActive(true); } else { item6image.SetActive(false); }
        if (item7bool == true) { item7image.SetActive(true); } else { item7image.SetActive(false); }
        if (item8bool == true) { item8image.SetActive(true); } else { item8image.SetActive(false); }
        if (item9bool == true) { item9image.SetActive(true); } else { item9image.SetActive(false); }
        if (item10bool == true) { item10image.SetActive(true); } else { item10image.SetActive(false); }
        if (item11bool == true) { item11image.SetActive(true); } else { item11image.SetActive(false); }
        
		if (cooked1bool == true) { cooked1image.SetActive(true); } else { cooked1image.SetActive(false); }
        if (cooked2bool == true) { cooked2image.SetActive(true); } else { cooked2image.SetActive(false); }
        if (cooked3bool == true) { cooked3image.SetActive(true); } else { cooked3image.SetActive(false); }
        if (cooked4bool == true) { cooked4image.SetActive(true); } else { cooked4image.SetActive(false); }
        if (cooked5bool == true) { cooked5image.SetActive(true); } else { cooked5image.SetActive(false); }
		
        Text itemText1B = item1text.GetComponent<Text>(); itemText1B.text = ("" + item1num);
		Text itemText2B = item2text.GetComponent<Text>(); itemText2B.text = ("" + item2num);
		Text itemText3B = item3text.GetComponent<Text>(); itemText3B.text = ("" + item3num);
		Text itemText4B = item4text.GetComponent<Text>(); itemText4B.text = ("" + item4num);
		Text itemText5B = item5text.GetComponent<Text>(); itemText5B.text = ("" + item5num);
		Text itemText6B = item6text.GetComponent<Text>(); itemText6B.text = ("" + item6num);
		Text itemText7B = item7text.GetComponent<Text>(); itemText7B.text = ("" + item7num);
		Text itemText8B = item8text.GetComponent<Text>(); itemText8B.text = ("" + item8num);
		Text itemText9B = item9text.GetComponent<Text>(); itemText9B.text = ("" + item9num);
		Text itemText10B = item10text.GetComponent<Text>(); itemText10B.text = ("" + item10num);
		Text itemText11B = item11text.GetComponent<Text>(); itemText11B.text = ("" + item11num);
		
		Text cookedText1B = cooked1text.GetComponent<Text>(); cookedText1B.text = ("" + cooked1num);
		Text cookedText2B = cooked2text.GetComponent<Text>(); cookedText2B.text = ("" + cooked2num);
		Text cookedText3B = cooked3text.GetComponent<Text>(); cookedText3B.text = ("" + cooked3num);
		Text cookedText4B = cooked4text.GetComponent<Text>(); cookedText4B.text = ("" + cooked4num);
		Text cookedText5B = cooked5text.GetComponent<Text>(); cookedText5B.text = ("" + cooked5num);
		
		//Cookbook:
		if ((item1num >= 2) && (item11num >=1)){cookButton1.SetActive(true);} else {cookButton1.SetActive(false);} // applepie
		//if ((item1num >= 2) && (item11num >=1)){cookButton2.SetActive(true);} else {cookButton2.SetActive(false);}
		//if ((item1num >= 2) && (item11num >=1)){cookButton3.SetActive(true);} else {cookButton3.SetActive(false);}
		//if ((item1num >= 2) && (item11num >=1)){cookButton4.SetActive(true);} else {cookButton4.SetActive(false);}
		//if ((item1num >= 2) && (item11num >=1)){cookButton5.SetActive(true);} else {cookButton5.SetActive(false);}
		//if ((item1num >= 2) && (item11num >=1)){cookButton6.SetActive(true);} else {cookButton6.SetActive(false);}
    
		Text ingredient1aTextB = ingredient1aText.GetComponent<Text>(); ingredient1aTextB.text = ("" + item1num); //apples
		Text ingredient1bTextB = ingredient1bText.GetComponent<Text>(); ingredient1bTextB.text = ("" + item11num); //sugar
		//Text ingredient2aTextB = ingredient2aText.GetComponent<Text>(); ingredient2aTextB.text = ("" + item?num);
		//Text ingredient2bTextB = ingredient2bText.GetComponent<Text>(); ingredient2bTextB.text = ("" + item?num);
		//Text ingredient3aTextB = ingredient2aText.GetComponent<Text>(); ingredient2aTextB.text = ("" + item?num);
		//Text ingredient3bTextB = ingredient2bText.GetComponent<Text>(); ingredient2bTextB.text = ("" + item?num);
		//Text ingredient4aTextB = ingredient2aText.GetComponent<Text>(); ingredient2aTextB.text = ("" + item?num);
		//Text ingredient4bTextB = ingredient2bText.GetComponent<Text>(); ingredient2bTextB.text = ("" + item?num);
		//Text ingredient5aTextB = ingredient2aText.GetComponent<Text>(); ingredient2aTextB.text = ("" + item?num);
		//Text ingredient5bTextB = ingredient2bText.GetComponent<Text>(); ingredient2bTextB.text = ("" + item?num);
		//Text ingredient6aTextB = ingredient2aText.GetComponent<Text>(); ingredient2aTextB.text = ("" + item?num);
		//Text ingredient6bTextB = ingredient2bText.GetComponent<Text>(); ingredient2bTextB.text = ("" + item?num);
		
	}

    public void InventoryAdd(string item){
        string foundItemName = item;
        if (foundItemName == "item1") { item1bool = true; item1num++;}
        else if (foundItemName == "item2") { item2bool = true; item2num++; }
        else if (foundItemName == "item3") { item3bool = true; item3num++; }
        else if (foundItemName == "item4") { item4bool = true; item4num++; }
        else if (foundItemName == "item5") { item5bool = true; item5num++; }
	    else if (foundItemName == "item6") { item6bool = true; item6num++; }
        else if (foundItemName == "item7") { item7bool = true; item7num++; }
        else if (foundItemName == "item8") { item8bool = true; item8num++; }
        else if (foundItemName == "item9") { item9bool = true; item9num++; }
	    else if (foundItemName == "item10") { item10bool = true; item10num++; }
	    else if (foundItemName == "item11") { item11bool = true; item11num++; }

	    else if (foundItemName == "cooked1") { cooked1bool = true; cooked1num++; }		
		else if (foundItemName == "cooked2") { cooked2bool = true; cooked2num++; }
        else if (foundItemName == "cooked3") { cooked3bool = true; cooked3num++; }
        else if (foundItemName == "cooked4") { cooked4bool = true; cooked4num++; }
        else if (foundItemName == "cooked5") { cooked5bool = true; cooked5num++; }

        InventoryDisplay();
		
		if (!InvIsOpen){
			OpenCloseInventory();
		}
    }

    public void InventoryRemove(string item){
        string itemRemove = item;
        if (itemRemove == "item1") { item1num--;if (item1num<=0){item1bool = false;} }
        else if (itemRemove == "item2") { item2num--;if (item2num<=0){item2bool = false;} }
        else if (itemRemove == "item3") { item3num--;if (item3num<=0){item3bool = false;} }
        else if (itemRemove == "item4") { item4num--;if (item4num<=0){item4bool = false;} }
        else if (itemRemove == "item5") { item5num--;if (item5num<=0){item5bool = false;} }
        else if (itemRemove == "item6") { item6num--;if (item6num<=0){item6bool = false;} }
        else if (itemRemove == "item7") { item7num--;if (item7num<=0){item7bool = false;} }
        else if (itemRemove == "item8") { item8num--;if (item8num<=0){item8bool = false;} }
        else if (itemRemove == "item9") { item9num--;if (item9num<=0){item9bool = false;} }
        else if (itemRemove == "item10") { item10num--;if (item10num<=0){item10bool = false;} }
        else if (itemRemove == "item11") { item11num--;if (item11num<=0){item11bool = false;} }

        else if (itemRemove == "cooked1") { cooked1num--;if (cooked1num<=0){cooked1bool = false;} }        
		else if (itemRemove == "cooked2") { cooked2num--;if (cooked2num<=0){cooked2bool = false;} }
        else if (itemRemove == "cooked3") { cooked3num--;if (cooked3num<=0){cooked3bool = false;} }
        else if (itemRemove == "cooked4") { cooked4num--;if (cooked4num<=0){cooked4bool = false;} }
        else if (itemRemove == "cooked5") { cooked5num--;if (cooked5num<=0){cooked5bool = false;} }

		InventoryDisplay();
    }


	//Open and Close the Inventory
	public void OpenCloseInventory(){
		if (InvIsOpen){InventoryMenu.SetActive(false);} 
		else {InventoryMenu.SetActive(true);}
		InvIsOpen = !InvIsOpen;
	}

	//Open and Close the Cookbook
	public void OpenCookBook(){CookMenu.SetActive(true);}
	public void CloseCookBook(){CookMenu.SetActive(false);}


	//Cooked food add button functions
	public void AddCooked1(){
		InventoryAdd("cooked1");
		InventoryRemove("item1"); InventoryRemove("item1"); InventoryRemove("item11");
		}
	public void AddCooked2(){
		InventoryAdd("cooked2");
		//InventoryRemove("item?"); InventoryRemove("item?");
		}
	public void AddCooked3(){
		InventoryAdd("cooked3");
		//InventoryRemove("item?"); InventoryRemove("item?");
		}
	public void AddCooked4(){
		InventoryAdd("cooked4");
		//InventoryRemove("item?"); InventoryRemove("item?");
		}
	public void AddCooked5(){
		InventoryAdd("cooked5");
		//InventoryRemove("item?"); InventoryRemove("item?");
		}
	public void AddCooked6(){
		//GameHandler win state
	}


	//Cooked food eating button functions
	public void EatCooked1(){
		InventoryRemove("cooked1");
		GetComponent<GameHandler>().eatFood(20);
	}

	public void EatCooked2(){
		InventoryRemove("cooked2");
		GetComponent<GameHandler>().eatFood(20);
	}

	public void EatCooked3(){
		InventoryRemove("cooked3");
		GetComponent<GameHandler>().eatFood(35);
	}


	public void EatCooked4(){
		InventoryRemove("cooked4");
		GetComponent<GameHandler>().eatFood(40);
	}


	public void EatCooked5(){
		InventoryRemove("cooked5");
		GetComponent<GameHandler>().eatFood(55);
	}


}
