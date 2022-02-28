using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class GoalTest
{
    float loadingTime = 0.3f;
    int shotCount = 5;
    GoalKeeper goalkeeper;
    GoalDetection soccerBall;

    Vector2[] targetZones = 
        {
        new Vector2(1, 1),
        new Vector2(1, 2),
        new Vector2(2, 1),
        new Vector2(2, 2),
        new Vector2(3, 1),
        new Vector2(3, 2)
        };

    [SetUp]
    public void SetUpTest()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void beforeEach()
    {
        soccerBall = GameObject.FindGameObjectWithTag("SoccerBall").GetComponent<GoalDetection>();
        goalkeeper = GameObject.FindGameObjectWithTag("Goalkeeper").GetComponent<GoalKeeper>();
        Assert.IsNotNull(soccerBall);
        Assert.IsNotNull(goalkeeper);
        goalkeeper.resetScene();
        Assert.IsFalse(soccerBall.getGoalStatus());



    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator LowCatchCenter()
    {
        int saveCount = 0;


        for(int i = 0; i < shotCount; i++)
        {
            yield return new WaitForSeconds(loadingTime);
            beforeEach();
            
            goalkeeper.shootBall(normaliseTargetPos(targetZones[0]));
            yield return new WaitForSeconds(3);

            if (!soccerBall.getGoalStatus())
            {
                saveCount++;
            }
        }

       Assert.AreEqual(saveCount, shotCount);

    }

    [UnityTest]
    public IEnumerator HighCatchCenter()
    {
        int saveCount = 0;

        for (int i = 0; i < shotCount; i++)
        {
            yield return new WaitForSeconds(loadingTime);
            beforeEach();

            goalkeeper.shootBall(normaliseTargetPos(targetZones[1]));
            yield return new WaitForSeconds(3);

            if (!soccerBall.getGoalStatus())
            {
                saveCount++;
            }
        }

        Assert.AreEqual(saveCount, shotCount);

    }

    [UnityTest]
    public IEnumerator ShortDiveLow()
    {
        int saveCount = 0;


        for (int i = 0; i < shotCount; i++)
        {
            yield return new WaitForSeconds(loadingTime);
            beforeEach();

            goalkeeper.shootBall(normaliseTargetPos(targetZones[2]));
            yield return new WaitForSeconds(3);

            if (!soccerBall.getGoalStatus())
            {
                saveCount++;
            }
        }

        Assert.AreEqual(saveCount, shotCount);

    }

    [UnityTest]
    public IEnumerator ShortDiveHigh()
    {
        int saveCount = 0;


        for (int i = 0; i < shotCount; i++)
        {
            yield return new WaitForSeconds(loadingTime);
            beforeEach();
            Debug.Log(targetZones[3]);
            goalkeeper.shootBall(normaliseTargetPos(targetZones[3]));
            yield return new WaitForSeconds(3);

            if (!soccerBall.getGoalStatus())
            {
                saveCount++;
            }
        }

        Assert.AreEqual(saveCount, shotCount);

    }

    [UnityTest]
    public IEnumerator LongDiveLow()
    {
        int saveCount = 0;


        for (int i = 0; i < shotCount; i++)
        {
            yield return new WaitForSeconds(loadingTime);
            beforeEach();
            Debug.Log(targetZones[4]);
            goalkeeper.shootBall(normaliseTargetPos(targetZones[4]));
            yield return new WaitForSeconds(3);

            if (!soccerBall.getGoalStatus())
            {
                saveCount++;
            }
        }

        Assert.AreEqual(saveCount, shotCount);


    }

    [UnityTest]
    public IEnumerator LongDiveHigh()
    {
        int saveCount = 0;


        for (int i = 0; i < shotCount; i++)
        {
            yield return new WaitForSeconds(loadingTime);
            beforeEach();
            Debug.Log(targetZones[5]);
            goalkeeper.shootBall(normaliseTargetPos(targetZones[5]));
            yield return new WaitForSeconds(3);

            if (!soccerBall.getGoalStatus())
            {
                saveCount++;
            }
        }

        Assert.AreEqual(saveCount, shotCount);


    }

    private Vector2 normaliseTargetPos(Vector2 targetPos)
    {
        return new Vector2((targetPos.x / 3.5f) * 2.6f, (targetPos.y * 1.7f / 2.5f)+6.4f);
    }
}
