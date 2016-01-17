using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	//UI Text using library using UnityEngine.UI
	public Text text;

	//instance variable scope
	private enum States{cage,men1,platformClock,hambird,train,freedom};
	//enum name and variable
	private States myState;



	void Start () {
	
		myState = States.cage;
	
	}
	
	void Update () {
		print (myState);
       //state 1
		if (myState == States.cage) {
			//method formed
			state_cage();

		}

		//state2
		else if (myState == States.men1){
			//method formed
			men_1();

		}
		//state 3
		else if (myState == States.platformClock){
			//method formed
			platclock();
			
		}
		//state 3
		else if (myState == States.hambird){
			//method formed
			hambird();
			
		}
		//state 4
		else if (myState == States.train){
			//method formed
			train();
			
		}
		else if (myState == States.freedom){
			//method formed
			free();
			
		}
	
	
	}//update method END
	//state 1 method change to state men1
		void state_cage(){

		text.text = "A Bird is in the cage, and wants to escape. There are " +
			"two men standing on the front of their cage watching him and waiting a train. " +
			"One man has a wrist watch, Train come on the platform at 11 'O Clock, But the current time on the platform clock is 10 'O Clock.\n" +
			"Bird want a opportunity to escape from the cage.\n\n" +
			"Press M to view Men 1, C to view platform Clock";

		if (Input.GetKeyDown (KeyCode.M)) {
			
			myState = States.men1;

		} 

		else if (Input.GetKeyDown (KeyCode.C)) {
			
			myState = States.platformClock;

		}



	}
	
	//state 2 method change to default state cage
	void men_1(){

		text.text = "Now first man watching time on his clock. And then he start talking " +
			" to second man, But second man look at that cage.\n\n " +
			"Press R to Return view";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cage;
		
		
		}

	}

	//state 3 method change to default state cage
	void platclock(){
		text.text = "It's 10:50 on clock. In the front of Clock there is Big Tower, At the roof of tower " +
			"there are two guards standing and laid his gun on the cage.\n" +
			"Hamming Bird is sitting on the roof, Hamming bird is friend of that bird in the cage, Press H to take help " +
			"of Hamming Bird who will draw attention of guards towards him. " +
			"Press R to Return view";

		
		if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.hambird;
			
			
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cage;
		
		
		}
	}

	void hambird(){

	text.text=	"Hamming Bird Doing his job !\n\n"+

			"Press T to view Train";
		

	

		if (Input.GetKeyDown(KeyCode.T)){

			myState = States.train;
		
		}

		}


	//state 5 method change to default state cage
		void train(){
		text.text = "Train is coming and Stir will occur in the environment.\n\n" +
			"Press F to Fly";
		
		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.freedom;


		}
	
	
	}
	void free(){
		text.text = "Hurrah! You are now Free !\n\n" +
			"Press P to Play Again";
		if (Input.GetKeyDown (KeyCode.P)) {

			myState = States.cage;
		}
	}


}
