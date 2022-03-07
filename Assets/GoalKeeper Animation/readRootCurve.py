
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
  classID: 95
    script: {fileID: 0}
  - curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.8713843
        inSlope: -0.33413884
        outSlope: -0.33413884
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.18333334
        value: 0.87865144
        inSlope: 0.4901449
        outSlope: 0.4901449
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.36666667
        value: 0.882017
        inSlope: -0.76240003
        outSlope: -0.76240003
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.46666667
        value: 0.7688567
        inSlope: -0.2800759
        outSlope: -0.2800759
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.5833333
        value: 0.75661373
        inSlope: -0.14771476
        outSlope: -0.14771476
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.6666667
        value: 0.8082674
        inSlope: 0.82540053
        outSlope: 0.82540053
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.93333334
        value: 1.0428275
        inSlope: 0.6087655
        outSlope: 0.6087655
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.1333333
        value: 1.0467006
        inSlope: -0.2661022
        outSlope: -0.2661022
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.6000001
        value: 0.22811729
        inSlope: -0.17183039
        outSlope: -0.17183039
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.7
        value: 0.22108105
        inSlope: -0.0355697
        outSlope: -0.0355697
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.8500001
        value: 0.21924546
        inSlope: -0.06561382
        outSlope: -0.06561382
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.9833335
        value: 0.19571613
        inSlope: -0.3169979
        outSlope: -0.3169979
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.1166668
        value: 0.16602096
        inSlope: 0.020416101
        outSlope: 0.020416101
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.1833334
        value: 0.17671578
        inSlope: 0.29673308
        outSlope: 0.29673308
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.3833334
        value: 0.24862887
        inSlope: 0.51166224
        outSlope: 0.51166224
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.4333334
        value: 0.27423528
        inSlope: 0.47787
        outSlope: 0.47787
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.4833333
        value: 0.30703562
        inSlope: 0.87750113
        outSlope: 0.87750113
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.15
        value: 0.8718355
        inSlope: -0.05089049
        outSlope: -0.05089049
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.3000002
        value: 0.8411015
        inSlope: -0.045497462
        outSlope: -0.045497462
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.4
        value: 0.8508375
        inSlope: 0.17460482
        outSlope: 0.17460482
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
""")

