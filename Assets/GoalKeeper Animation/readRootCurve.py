
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
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.11807516
        inSlope: 0.0770536
        outSlope: 0.0770536
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.18333334
        value: 0.13442928
        inSlope: 0.14796132
        outSlope: 0.14796132
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.26666668
        value: 0.14513221
        inSlope: 0.087034926
        outSlope: 0.087034926
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.36666667
        value: 0.16031761
        inSlope: 0.1827264
        outSlope: 0.1827264
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.45000002
        value: 0.16990283
        inSlope: 0.09360327
        outSlope: 0.09360327
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.5166667
        value: 0.18317771
        inSlope: 0.17854819
        outSlope: 0.17854819
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.55
        value: 0.19078708
        inSlope: 0.3786546
        outSlope: 0.3786546
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.5833334
        value: 0.2050083
        inSlope: 0.3006826
        outSlope: 0.3006826
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.65000004
        value: 0.21856733
        inSlope: 0.32251495
        outSlope: 0.32251495
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.73333335
        value: 0.25646174
        inSlope: 0.4362949
        outSlope: 0.4362949
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.85
        value: 0.30377585
        inSlope: 0.35611928
        outSlope: 0.35611928
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1
        value: 0.36164904
        inSlope: 0.37282047
        outSlope: 0.37282047
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.1333334
        value: 0.40885037
        inSlope: 0.3569377
        outSlope: 0.3569377
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.1833334
        value: 0.43032834
        inSlope: 0.25853032
        outSlope: 0.25853032
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.3166667
        value: 0.45255485
        inSlope: 0.1421429
        outSlope: 0.1421429
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.5166668
        value: 0.463206
        inSlope: 0.050060797
        outSlope: 0.050060797
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.7333335
        value: 0.46450484
        inSlope: 0.0019267788
        outSlope: 0.0019267788
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.9833335
        value: 0.4970742
        inSlope: 0.36209366
        outSlope: 0.36209366
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.3500001
        value: 0.56950784
        inSlope: 0.12965453
        outSlope: 0.12965453
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.5833335
        value: 0.59901303
        inSlope: 0.032744437
        outSlope: 0.032744437
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.7333336
        value: 0.6043406
        inSlope: 0.04915887
        outSlope: 0.04915887
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
""")

