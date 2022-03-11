
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
        value: 0.11485689
        inSlope: -0.013008266
        outSlope: -0.013008266
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.13333334
        value: 0.11544823
        inSlope: 0.008902029
        outSlope: 0.008902029
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.23333335
        value: 0.118029505
        inSlope: 0.0047162203
        outSlope: 0.0047162203
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.6833334
        value: 0.114580534
        inSlope: -0.026794355
        outSlope: -0.026794355
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.0500001
        value: 0.10713103
        inSlope: -0.0039591677
        outSlope: -0.0039591677
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.3166667
        value: 0.10751417
        inSlope: 0.0066141104
        outSlope: 0.0066141104
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.5500001
        value: 0.10388803
        inSlope: -0.034832764
        outSlope: -0.034832764
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.7666668
        value: 0.10008052
        inSlope: -0.000036880374
        outSlope: -0.000036880374
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2
        value: 0.101044424
        inSlope: -0.012619097
        outSlope: -0.012619097
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.1833334
        value: 0.09956774
        inSlope: 0.0010650615
        outSlope: 0.0010650615
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.4
        value: 0.10151858
        inSlope: 0.025143497
        outSlope: 0.025143497
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.7166667
        value: 0.10980991
        inSlope: 0.02762456
        outSlope: 0.02762456
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.9166667
        value: 0.114655375
        inSlope: 0.005721604
        outSlope: 0.005721604
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.2500002
        value: 0.119475745
        inSlope: -0.004134182
        outSlope: -0.004134182
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.4333334
        value: 0.116889745
        inSlope: -0.0047503263
        outSlope: -0.0047503263
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.6666667
        value: 0.11370585
        inSlope: -0.020723261
        outSlope: -0.020723261
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.8333335
        value: 0.10892541
        inSlope: 0.00047475152
        outSlope: 0.00047475152
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 4.166667
        value: 0.10522311
        inSlope: -0.011281338
        outSlope: -0.011281338
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 4.3833337
        value: 0.1067625
        inSlope: 0.00112984
        outSlope: 0.00112984
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 4.533334
        value: 0.109660916
        inSlope: 0.058325358
        outSlope: 0.058325358
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 4.616667
        value: 0.11479491
        inSlope: 0.062130295
        outSlope: 0.062130295
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
""")

