using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class GoalTest
{
    float loadingTime = 0.3f;
    float shotIncrement = 0.25f;
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
            Vector2 targetPos = getTargetPos(i, targetZones[0]);

            goalkeeper.shootBall(normaliseTargetPos(targetPos));
            yield return new WaitForSeconds(3);
            saveCount += wasSaved(targetPos);
        }

        Assert.AreEqual(shotCount, saveCount);


    }

    [UnityTest]
    public IEnumerator HighCatchCenter()
    {
        int saveCount = 0;

        for (int i = 0; i < shotCount; i++)
        {
            yield return new WaitForSeconds(loadingTime);
            beforeEach();

            Vector2 targetPos = getTargetPos(i, targetZones[1]);

            goalkeeper.shootBall(normaliseTargetPos(targetPos));
            yield return new WaitForSeconds(3);
            saveCount += wasSaved(targetPos);
        }

        Assert.AreEqual(shotCount, saveCount);


    }

    [UnityTest]
    public IEnumerator ShortDiveLow()
    {
        int saveCount = 0;


        for (int i = 0; i < shotCount; i++)
        {
            yield return new WaitForSeconds(loadingTime);
            beforeEach();
            Vector2 targetPos = getTargetPos(i, targetZones[2]);

            goalkeeper.shootBall(normaliseTargetPos(targetPos));
            yield return new WaitForSeconds(3);
            saveCount += wasSaved(targetPos);
        }

        Assert.AreEqual(shotCount, saveCount);


    }

    [UnityTest]
    public IEnumerator ShortDiveHigh()
    {
        int saveCount = 0;


        for (int i = 0; i < shotCount; i++)
        {
            yield return new WaitForSeconds(loadingTime);
            beforeEach();
            Vector2 targetPos = getTargetPos(i, targetZones[3]);

            goalkeeper.shootBall(normaliseTargetPos(targetPos));
            yield return new WaitForSeconds(3);
            saveCount += wasSaved(targetPos);
        }

        Assert.AreEqual(shotCount, saveCount);


    }

    [UnityTest]
    public IEnumerator LongDiveLow()
    {
        int saveCount = 0;


        for (int i = 0; i < shotCount; i++)
        {
            yield return new WaitForSeconds(loadingTime);
            beforeEach();
            Vector2 targetPos = getTargetPos(i, targetZones[4]);

            goalkeeper.shootBall(normaliseTargetPos(targetPos));
            yield return new WaitForSeconds(3);
            saveCount += wasSaved(targetPos);
        }

        Assert.AreEqual(shotCount, saveCount);



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
            Vector2 targetPos = getTargetPos(i, targetZones[4]);

            goalkeeper.shootBall(normaliseTargetPos(targetPos));
            yield return new WaitForSeconds(3);
            saveCount += wasSaved(targetPos);
        }

        Assert.AreEqual(shotCount, saveCount);


    }

    private int wasSaved(Vector2 targetPos)
    {
        Debug.Log(targetPos);
        if (!soccerBall.getGoalStatus())
        {
            Debug.Log("Saved");
            return 1;
        }
        else
        {
            Debug.Log("Scored");
            return 0;
        }


    }

    private Vector2 normaliseTargetPos(Vector2 targetPos)
    {
        return new Vector2((targetPos.x / 3.5f) * 2.6f, (targetPos.y * 1.7f / 2.5f)+6.4f);
    }

    private Vector2 getTargetPos(int index ,Vector2 targetPos)
    {
        switch (index)
        {
            case 1:
                return new Vector2(targetPos.x + shotIncrement, targetPos.y + shotIncrement);
            case 2:
                return new Vector2(targetPos.x + shotIncrement, targetPos.y - shotIncrement);
            case 3:
                return new Vector2(targetPos.x - shotIncrement, targetPos.y - shotIncrement);
            case 4:
                return new Vector2(targetPos.x - shotIncrement, targetPos.y + shotIncrement);
        }

        return targetPos;
    }
}
