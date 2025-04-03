using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class FireTargetAT : ActionTask {

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        public Transform[] patrolPoints;
        public BBParameter<Transform> currentTarget;
        public GameObject shell;
        private int currentPatrolPointIndex = 0;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit()
        {
            return null;
        }

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute()
        {
            currentPatrolPointIndex++;
            if (currentPatrolPointIndex >= patrolPoints.Length)
            {
                GameObject.Instantiate(shell, currentTarget.value);
                currentPatrolPointIndex = 0;
                
            }
            currentTarget.value = patrolPoints[currentPatrolPointIndex];
            EndAction(true);
        }


        //Called once per frame while the action is active.
        protected override void OnUpdate() {
			if(currentPatrolPointIndex == 1)
            {
                GameObject.Instantiate (shell, currentTarget.value);
            }
            if (currentPatrolPointIndex == 2)
            {
                GameObject.Instantiate(shell,currentTarget.value);
            }
                
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}