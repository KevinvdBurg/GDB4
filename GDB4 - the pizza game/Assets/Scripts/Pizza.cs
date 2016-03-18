using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pizza {

	public Texture Texture;
	private Dictionary<string, int> _neededIngredients = new Dictionary<string, int>();
	public string Name;
	// Use this for initialization
//	void Start () {
//		createIngredientList ();
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}

	public Pizza(){
		Name = GenPizzaName ();
		createIngredientList ();
	}

	public void createIngredientList(){
		for (int i = 0; i < Random.Range(3, 5); i++) {
			bool foundIngredient = false;
			string ingredientName = "";
			while (!foundIngredient) {
				switch (Random.Range(1,8)) {
				case 1:
					ingredientName = "Dough";
					break;
				case 2:
					ingredientName = "Tomato";
					break;
				case 3:
					ingredientName = "Cheese";
					break;
				case 4:
					ingredientName = "Salami";
					break;
				case 5:
					ingredientName = "Ham";
					break;
				case 6:
					ingredientName = "Mushroom";
					break;
				case 7:
					ingredientName = "Olive";
					break;
				case 8:
					ingredientName = "Chicken";
					break;
				}

				if (!_neededIngredients.ContainsKey(ingredientName))  {
					_neededIngredients.Add(ingredientName, Random.Range(1, 6));
					foundIngredient = true;
				}
			}
		}


	}

	public string GenPizzaName (){
		string pizzaName = "";
		switch (Random.Range(1,8)) {
		case 1:
			pizzaName = "Pizza le Kees";
			break;
		case 2:
			pizzaName = "Pizza Train";
			break;
		case 3:
			pizzaName = "Pizza Pikanto";
			break;
		case 4:
			pizzaName = "Pizza with Stuff";
			break;
		case 5:
			pizzaName = "The Pizza";
			break;
		case 6:
			pizzaName = "Pizza Azzip";
			break;
		case 7:
			pizzaName = "Pizza du Menno";
			break;
		case 8:
			pizzaName = "Kevin's Special Pizza";
			break;
		}
	}
}
