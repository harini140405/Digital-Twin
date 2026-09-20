import cv2
import cv2.aruco as aruco

dictionary = aruco.getPredefinedDictionary(aruco.DICT_6X6_250)

for i in range(4):
    marker = aruco.generateImageMarker(dictionary, i, 400)
    cv2.imwrite(f"marker_{i}.png", marker)
  
