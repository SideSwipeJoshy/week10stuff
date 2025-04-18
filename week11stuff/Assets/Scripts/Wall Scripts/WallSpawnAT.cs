using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class WallSpawnAT : ActionTask {

       public BBParameter<Transform> currentTarget;
       

        public Transform[] patrolPoints;
        private int currentPatrolPointIndex = 0;
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
          
                currentPatrolPointIndex = 0;

            }
            currentTarget.value = patrolPoints[currentPatrolPointIndex];
            EndAction(true);
        }

           
        protected override void OnUpdate() {
       
        }

        //Called when the task is disabled.
        protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}