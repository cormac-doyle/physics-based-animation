
def readPoints(myString):
    pointList = myString.split("\n")
    timesArr=[]
    valuesArr=[]
    
    for item in pointList:
        
        if "time: " in item:
            timeVal = [float(s) for s in item.split() if is_float(s)]
            timesArr.append(timeVal)

        if "value: " in item:
            valueVal = [float(s) for s in item.split() if is_float(s)]
            valuesArr.append(valueVal)
    
    for i in range(0,len(timesArr)):
        print("new Keyframe("+str(timesArr[i][0])+"f,"+str(valuesArr[i][0])+"f),")
        

    
def is_float(element) -> bool:
    try:
        float(element)
        return True
    except ValueError:
        return False

readPoints("""
              m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.95264846
        inSlope: -0.06817818
        outSlope: -0.06817818
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.35000002
        value: 0.93411773
        inSlope: -0.14111817
        outSlope: -0.14111817
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.6
        value: 0.8932062
        inSlope: -0.046216294
        outSlope: -0.046216294
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.75000006
        value: 0.8610709
        inSlope: -0.2304874
        outSlope: -0.2304874
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.9333334
        value: 0.7922888
        inSlope: -0.55380404
        outSlope: -0.55380404
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.0666667
        value: 0.7277568
        inSlope: -0.5850583
        outSlope: -0.5850583
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.2
        value: 0.6411242
        inSlope: -0.66969633
        outSlope: -0.66969633
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.2500001
        value: 0.626633
        inSlope: 0.19067252
        outSlope: 0.19067252
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.2833334
        value: 0.6368801
        inSlope: 0.8166315
        outSlope: 0.8166315
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.3166667
        value: 0.6722105
        inSlope: 0.53870255
        outSlope: 0.53870255
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.3333334
        value: 0.67564714
        inSlope: 0.7012553
        outSlope: 0.7012553
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.3666668
        value: 0.7106943
        inSlope: 0.80637145
        outSlope: 0.80637145
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.4166667
        value: 0.7406732
        inSlope: -0.18304844
        outSlope: -0.18304844
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.4333334
        value: 0.7286635
        inSlope: -1.4320257
        outSlope: -1.4320257
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.45
        value: 0.69293904
        inSlope: -1.8062478
        outSlope: -1.8062478
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.4833335
        value: 0.65738666
        inSlope: -0.28844088
        outSlope: -0.28844088
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.5166668
        value: 0.6561076
        inSlope: -0.31695694
        outSlope: -0.31695694
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.5500001
        value: 0.6483646
        inSlope: -0.05840605
        outSlope: -0.05840605
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.6000001
        value: 0.63135284
        inSlope: -0.52112836
        outSlope: -0.52112836
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.6333334
        value: 0.62793744
        inSlope: 0.17155962
        outSlope: 0.17155962
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.7
        value: 0.6270537
        inSlope: 0.12842429
        outSlope: 0.12842429
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.8000001
        value: 0.6358123
        inSlope: -0.22592446
        outSlope: -0.22592446
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.9333334
        value: 0.6280744
        inSlope: 0.34239143
        outSlope: 0.34239143
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.016667
        value: 0.62984085
        inSlope: -0.16886108
        outSlope: -0.16886108
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.0666668
        value: 0.6298775
        inSlope: -0.04036192
        outSlope: -0.04036192
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.2
        value: 0.6941936
        inSlope: 1.0668533
        outSlope: 1.0668533
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.4166667
        value: 0.8479545
        inSlope: 0.2121701
        outSlope: 0.2121701
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.6333334
        value: 0.9012592
        inSlope: 0.65550923
        outSlope: 0.65550923
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.8166668
        value: 0.9734305
        inSlope: -0.047773764
        outSlope: -0.047773764
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.3166668
        value: 0.9757512
        inSlope: 0.013216151
        outSlope: 0.013216151
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.4
        value: 0.9785227
        inSlope: 0.036202703
        outSlope: 0.036202703
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
""")

