
using UnityEngine;
using UnityEngine.Animations.Rigging;


public class ActivateIK : MonoBehaviour
{
    private Rig rig;
    private float rigWeight;
    public GameObject SoccerBall;
    public GameObject hand;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rig>();
    }

    // Update is called once per frame
    void Update()
    {
        float zDistanceToBall = SoccerBall.transform.position.z - hand.transform.position.z;



        if (zDistanceToBall > 2.5 && zDistanceToBall < 4 )
        {
            rigWeight = 0.7f;
            rig.weight = Mathf.Lerp(rig.weight, rigWeight, Time.deltaTime * 2f);

        }
        
        if(zDistanceToBall > 0 && zDistanceToBall <= 2.5)
        {
            rigWeight = 1f;
            rig.weight = Mathf.Lerp(rig.weight, rigWeight, Time.deltaTime * 5f);
        }

        if (zDistanceToBall < 0)
        {
            rigWeight = 0.0f;
            rig.weight = Mathf.Lerp(rig.weight, rigWeight, Time.deltaTime * 3f);
        }

    }
}
