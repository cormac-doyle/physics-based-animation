
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
  - curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.0042746644
        inSlope: 0.065476656
        outSlope: 0.065476656
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.050000004
        value: 0.0065194797
        inSlope: -0.0011103675
        outSlope: -0.0011103675
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.083333336
        value: 0.0056663873
        inSlope: -0.026666224
        outSlope: -0.026666224
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.10000001
        value: 0.0052818903
        inSlope: -0.032723784
        outSlope: -0.032723784
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.116666675
        value: 0.0045755943
        inSlope: -0.037561253
        outSlope: -0.037561253
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.15
        value: 0.0035285898
        inSlope: -0.032469846
        outSlope: -0.032469846
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.16666667
        value: 0.0029475205
        inSlope: -0.013821717
        outSlope: -0.013821717
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.18333334
        value: 0.003067866
        inSlope: 0.027942326
        outSlope: 0.027942326
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.20000002
        value: 0.003878932
        inSlope: 0.0062871054
        outSlope: 0.0062871054
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.21666668
        value: 0.0032774368
        inSlope: -0.035612796
        outSlope: -0.035612796
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.23333335
        value: 0.002691839
        inSlope: -0.0015586298
        outSlope: -0.0015586298
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.25
        value: 0.003225482
        inSlope: 0.031760458
        outSlope: 0.031760458
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.28333336
        value: 0.0041270633
        inSlope: 0.016784715
        outSlope: 0.016784715
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.3
        value: 0.0043100114
        inSlope: 0.016264645
        outSlope: 0.016264645
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.3166667
        value: 0.0046692183
        inSlope: 0.022573933
        outSlope: 0.022573933
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.33333334
        value: 0.005062476
        inSlope: 0.040836073
        outSlope: 0.040836073
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.35000002
        value: 0.0060304212
        inSlope: 0.049536318
        outSlope: 0.049536318
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.36666667
        value: 0.0067136865
        inSlope: 0.047403418
        outSlope: 0.047403418
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.38333336
        value: 0.0076105352
        inSlope: 0.104464665
        outSlope: 0.104464665
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.40000004
        value: 0.010195845
        inSlope: 0.12235515
        outSlope: 0.12235515
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.4166667
        value: 0.011689041
        inSlope: 0.089590006
        outSlope: 0.089590006
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.43333337
        value: 0.013182178
        inSlope: 0.15581596
        outSlope: 0.15581596
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.45000002
        value: 0.016882904
        inSlope: 0.36212707
        outSlope: 0.36212707
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.4666667
        value: 0.025253084
        inSlope: 0.4929781
        outSlope: 0.4929781
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.48333335
        value: 0.033315506
        inSlope: 0.5753704
        outSlope: 0.5753704
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.5
        value: 0.044432078
        inSlope: 0.71316755
        outSlope: 0.71316755
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.5166667
        value: 0.05708778
        inSlope: 0.86663294
        outSlope: 0.86663294
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.6666667
        value: 0.22076207
        inSlope: 1.1922861
        outSlope: 1.1922861
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.8833333
        value: 0.4178115
        inSlope: 0.35549498
        outSlope: 0.35549498
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.95
        value: 0.43062735
        inSlope: 0.29815856
        outSlope: 0.29815856
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.0166667
        value: 0.44252998
        inSlope: 0.25450343
        outSlope: 0.25450343
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.1166667
        value: 0.43783104
        inSlope: -0.306633
        outSlope: -0.306633
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.2333333
        value: 0.42959064
        inSlope: 0.43003544
        outSlope: 0.43003544
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.2666667
        value: 0.4431246
        inSlope: -0.9141791
        outSlope: -0.9141791
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.2833333
        value: 0.40941662
        inSlope: -1.4889815
        outSlope: -1.4889815
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.3
        value: 0.39349192
        inSlope: -0.990412
        outSlope: -0.990412
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.3166667
        value: 0.3764029
        inSlope: -0.49785244
        outSlope: -0.49785244
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.35
        value: 0.39093584
        inSlope: 0.7839198
        outSlope: 0.7839198
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.4
        value: 0.43328375
        inSlope: 1.3463199
        outSlope: 1.3463199
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.4333333
        value: 0.50879204
        inSlope: 2.112996
        outSlope: 2.112996
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.5
        value: 0.5488869
        inSlope: 0.38452542
        outSlope: 0.38452542
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.5333333
        value: 0.5582433
        inSlope: 0.021209141
        outSlope: 0.021209141
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.5833334
        value: 0.5687578
        inSlope: 0.370816
        outSlope: 0.370816
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.65
        value: 0.5801226
        inSlope: 0.23215792
        outSlope: 0.23215792
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.7833333
        value: 0.6187718
        inSlope: 0.39477503
        outSlope: 0.39477503
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1.9166666
        value: 0.6339277
        inSlope: -0.276148
        outSlope: -0.276148
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2
        value: 0.63064706
        inSlope: -0.020695135
        outSlope: -0.020695135
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.1
        value: 0.5631858
        inSlope: -1.2490684
        outSlope: -1.2490684
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.1666667
        value: 0.46693066
        inSlope: -1.9389377
        outSlope: -1.9389377
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.3500001
        value: 0.18821228
        inSlope: -1.444787
        outSlope: -1.444787
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.3833334
        value: 0.14497007
        inSlope: -1.1837547
        outSlope: -1.1837547
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.4
        value: 0.12645514
        inSlope: -0.9212874
        outSlope: -0.9212874
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.4333334
        value: 0.10692036
        inSlope: -0.29277188
        outSlope: -0.29277188
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.4666667
        value: 0.10343189
        inSlope: -0.18666159
        outSlope: -0.18666159
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.5333335
        value: 0.07122841
        inSlope: -0.64852846
        outSlope: -0.64852846
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.5500002
        value: 0.06035732
        inSlope: -0.48885372
        outSlope: -0.48885372
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.5833335
        value: 0.053601827
        inSlope: 0.014792956
        outSlope: 0.014792956
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.6000001
        value: 0.055426396
        inSlope: 0.04608252
        outSlope: 0.04608252
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.65
        value: 0.051946774
        inSlope: -0.1345109
        outSlope: -0.1345109
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.6666667
        value: 0.049692772
        inSlope: -0.16365369
        outSlope: -0.16365369
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.6833334
        value: 0.046491656
        inSlope: -0.3562489
        outSlope: -0.3562489
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.7
        value: 0.03781782
        inSlope: -0.47951627
        outSlope: -0.47951627
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.7166667
        value: 0.030507796
        inSlope: -0.45079535
        outSlope: -0.45079535
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.7333336
        value: 0.022791212
        inSlope: -0.5716674
        outSlope: -0.5716674
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.7500002
        value: 0.011452124
        inSlope: -0.5941634
        outSlope: -0.5941634
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.766667
        value: 0.0029857846
        inSlope: -0.47426814
        outSlope: -0.47426814
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.7833335
        value: -0.004356799
        inSlope: -0.32270664
        outSlope: -0.32270664
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.8000002
        value: -0.007771093
        inSlope: -0.1297154
        outSlope: -0.1297154
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.8166668
        value: -0.008680642
        inSlope: -0.015712436
        outSlope: -0.015712436
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.8333335
        value: -0.00829484
        inSlope: 0.073390715
        outSlope: 0.073390715
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.8500001
        value: -0.006234287
        inSlope: 0.092849255
        outSlope: 0.092849255
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.8666668
        value: -0.005199868
        inSlope: 0.07877748
        outSlope: 0.07877748
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.9
        value: -0.0015294674
        inSlope: 0.134388
        outSlope: 0.134388
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.9166667
        value: 0.00087122177
        inSlope: 0.15569815
        outSlope: 0.15569815
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.9333334
        value: 0.003660466
        inSlope: 0.12690216
        outSlope: 0.12690216
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.95
        value: 0.0051012896
        inSlope: 0.26945144
        outSlope: 0.26945144
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.966667
        value: 0.01264228
        inSlope: 0.37115216
        outSlope: 0.37115216
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2.9833336
        value: 0.017473124
        inSlope: 0.30086458
        outSlope: 0.30086458
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.016667
        value: 0.027240718
        inSlope: 0.23470262
        outSlope: 0.23470262
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.0500002
        value: 0.03299752
        inSlope: 0.11105764
        outSlope: 0.11105764
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.0833335
        value: 0.033501852
        inSlope: -0.083601184
        outSlope: -0.083601184
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.1000001
        value: 0.031409718
        inSlope: -0.07914284
        outSlope: -0.07914284
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.1166668
        value: 0.03086376
        inSlope: -0.083964124
        outSlope: -0.083964124
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.1333334
        value: 0.028610917
        inSlope: -0.11943726
        outSlope: -0.11943726
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.1666667
        value: 0.025201304
        inSlope: -0.09646803
        outSlope: -0.09646803
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.1833334
        value: 0.023666924
        inSlope: -0.07367392
        outSlope: -0.07367392
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.216667
        value: 0.021613706
        inSlope: -0.091364846
        outSlope: -0.091364846
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.2333336
        value: 0.019700004
        inSlope: -0.1378304
        outSlope: -0.1378304
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.2500002
        value: 0.017019363
        inSlope: -0.15400426
        outSlope: -0.15400426
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.2833335
        value: 0.012145976
        inSlope: -0.15459186
        outSlope: -0.15459186
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.3166668
        value: 0.0067225453
        inSlope: -0.15409397
        outSlope: -0.15409397
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.3333335
        value: 0.0042770156
        inSlope: -0.1408863
        outSlope: -0.1408863
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.3500001
        value: 0.0020263393
        inSlope: -0.11494368
        outSlope: -0.11494368
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.3666668
        value: 0.00044556288
        inSlope: -0.09333047
        outSlope: -0.09333047
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.3833334
        value: -0.0010846737
        inSlope: -0.09135963
        outSlope: -0.09135963
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 3.4
        value: -0.002599755
        inSlope: -0.09090497
        outSlope: -0.09090497
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
""")

