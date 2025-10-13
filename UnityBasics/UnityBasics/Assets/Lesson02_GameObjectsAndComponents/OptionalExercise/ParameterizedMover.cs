using UnityEngine;

namespace GameObjectsAndComponents
{
    public class ParameterizedMover : MonoBehaviour
    {

        //public enum EnumOscillatorType
        //{
        //    SIN,
        //    TRIANGLE
        //}
        //public EnumOscillatorType oscType;


        public bool UsePingPong = false;

        public float Period = 1.0f;
        public float Range = 10.0f;

        private Vector3 startPos;

        void Start()
        {
            startPos = transform.position;
        }


        void Update()
        {

            //float cycle = (Time.time % Period) / Period;
            //Debug.Log(cycle);


            if (UsePingPong)
            {
                // increases from 0.0 to 10.0 in 10.0 seconds, then decreases back to 0.0 in 10 seconds
                float fuckingThing = Mathf.PingPong(Time.time, 10.0f);
                //Debug.Log(fuckingThing);

                // ...so this increases from 0.0 to Period in Period seconds, then back to 0.0 in Period seconds
                float nextFuckingThing00 = Mathf.PingPong(Time.time, Period);
                //Debug.Log(nextFuckingThing00);

                // ... so this increases to Period/2.0 in Period/2.0 seconds, then back to 0.0 in Period/2.0 seconds
                float nextFuckingThing01 = Mathf.PingPong(Time.time, (Period / 2.0f));
                //Debug.Log(nextFuckingThing01);

                // ... so both of these lines increase from 0.0 to 1.0 over Period/2.0 seconds, then back down.
                // now we have a number that ocsillates between 0.0 and 1.0 over Period seconds
                //float nextFuckingThing02 = nextFuckingThing01 / (Period / 2.0f); // with an intermmediate substitution
                float nextFuckingThing02 = (Mathf.PingPong(Time.time, (Period / 2.0f)  ))  / (Period/2.0f); // all in one line
                //Debug.Log(nextFuckingThing02);

                // ...so this should oscillate between 0.0 and Range over Period seconds
                //float distanceFromOrigin = Range * nextFuckingThing02; // with an intermmediate subtitution
                float distanceFromOrigin = ((Mathf.PingPong(Time.time, (Period / 2.0f))) / (Period / 2.0f)) * Range; // all in one line
                //Debug.Log(distanceFromOrigin);

                Vector3 newPosition = new Vector3(0.0f, transform.position.y, distanceFromOrigin);
                transform.position = newPosition;
            }
            else
            {
                // how many seconds have elapsed since the game started
                float theTime = Time.time;
                //Debug.Log(theTime);

                // counts to 10 then restarts at zero, at a rate of one number per second
                float whereInTen = Time.time % 10.0f;
                //Debug.Log(whereInTen);

                // like above, but with the Period variable
                float whereInPeriod = Time.time % Period;
                //Debug.Log(whereInPeriod);

                // this number is the ratio of the current elapsed time within the period, and the period length
                // i.e. how much of the period has elapsed, as a fraction. It is always between 0.0 and 1.0
                float fractionOfPeriod = (Time.time % Period) / Period;
                //Debug.Log(fractionOfPeriod);

                // converts the above to an angle in radians
                float angleRadians = fractionOfPeriod * Mathf.PI * 2.0f;
                angleRadians -= Mathf.PI / 2.0f; // rotate it 180 degrees
                //Debug.Log(angleRadians);

                // now get the sine of that angle. this number will oscillate between -1.0 and 1.0 in a sine-ish manner 
                float rawSine = Mathf.Sin(angleRadians);
                //Debug.Log(rawSine);

                // scale it to the Range... 
                float offset = rawSine * Range;
                // ...and scoot it forward by the range, then divide that in half
                float distaceFromOrigin = (offset + (Range)) / 2.0f;
                
                transform.position = new Vector3(0.0f, transform.position.y, distaceFromOrigin);

            }

        }
    }
}
