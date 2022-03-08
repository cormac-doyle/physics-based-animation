
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
            - serializedVersion: 3
        time: 0
        value: 0.11815512
        inSlope: 0.32694918
        outSlope: 0.32694918
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.116666675
        value: 0.1559398
        inSlope: 0.35333726
        outSlope: 0.35333726
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.26666668
        value: 0.22501776
        inSlope: 0.5277823
        outSlope: 0.5277823
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.38333336
        value: 0.2918865
        inSlope: 0.6465084
        outSlope: 0.6465084
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.4666667
        value: 0.35818994
        inSlope: 0.87346864
        outSlope: 0.87346864
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.4166666
        value: 1.0992892
        inSlope: 0.9969855
        outSlope: 0.9969855
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.5166667
        value: 1.1128795
        inSlope: 0.01071454
        outSlope: 0.01071454
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.0666666
        value: 1.0828496
        inSlope: -0.18357414
        outSlope: -0.18357414
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.4166667
        value: 1.1019281
        inSlope: 0.032840997
        outSlope: 0.032840997
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.9166667
        value: 1.1487993
        inSlope: 0.07104968
        outSlope: 0.07104968
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.35
        value: 1.188141
        inSlope: 0.0230098
        outSlope: 0.0230098
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
""")

