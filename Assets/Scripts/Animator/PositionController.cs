using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : StateMachineBehaviour {

    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		if(stateInfo.IsName ("Pos1")){
			animator.SetBool ("Pos1", true);
//			animator.SetBool ("Pos2", false);
//			animator.SetBool ("Pos3", false);
//			animator.SetBool ("Pos4", false);
//			animator.SetBool ("Pos5", false);
//			animator.SetBool ("Pos6", false);
			return;
		}
		if(stateInfo.IsName ("Pos2")){
//			animator.SetBool ("Pos1", false);
			animator.SetBool ("Pos2", true);
//			animator.SetBool ("Pos3", false);
//			animator.SetBool ("Pos4", false);
//			animator.SetBool ("Pos5", false);
//			animator.SetBool ("Pos6", false);
			return;
		}
		if(stateInfo.IsName ("Pos3")){
//			animator.SetBool ("Pos1", false);
//			animator.SetBool ("Pos2", false);
			animator.SetBool ("Pos3", true);
//			animator.SetBool ("Pos4", false);
//			animator.SetBool ("Pos5", false);
//			animator.SetBool ("Pos6", false);
			return;
		}
		if(stateInfo.IsName ("Pos4")){
//			animator.SetBool ("Pos1", false);
//			animator.SetBool ("Pos2", false);
//			animator.SetBool ("Pos3", false);
			animator.SetBool ("Pos4", true);
//			animator.SetBool ("Pos5", false);
//			animator.SetBool ("Pos6", false);
			return;
		}
		if(stateInfo.IsName ("Pos5")){
//			animator.SetBool ("Pos1", false);
//			animator.SetBool ("Pos2", false);
//			animator.SetBool ("Pos3", false);
//			animator.SetBool ("Pos4", false);
			animator.SetBool ("Pos5", true);
//			animator.SetBool ("Pos6", false);
			return;
		}
		if(stateInfo.IsName ("Pos6")){
//			animator.SetBool ("Pos1", false);
//			animator.SetBool ("Pos2", false);
//			animator.SetBool ("Pos3", false);
//			animator.SetBool ("Pos4", false);
//			animator.SetBool ("Pos5", false);
			animator.SetBool ("Pos6", true);
			return;
		}

		if(stateInfo.IsName ("Done")){
			animator.SetBool ("Done", true);
		}
	}

	// OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateExit is called before OnStateExit is called on any state inside this state machine
//	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
//	
//	}

	// OnStateMove is called before OnStateMove is called on any state inside this state machine
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called before OnStateIK is called on any state inside this state machine
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMachineEnter is called when entering a statemachine via its Entry Node
	//override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash){
	//
	//}

	// OnStateMachineExit is called when exiting a statemachine via its Exit Node
	//override public void OnStateMachineExit(Animator animator, int stateMachinePathHash) {
	//
	//}
}
