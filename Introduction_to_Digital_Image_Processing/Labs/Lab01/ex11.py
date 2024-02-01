import cv2

path = r"imgs/fruits.png"
image = cv2.imread(path)

windowName = "Image"
centerCoordinates = (120, 100)
axesLength = (100, 50)
angle = 0
startAngle = 0
endAngle = 360
color = (0, 0, 255)
# thickness = 5
thickness = -1
image = cv2.ellipse(
    image, centerCoordinates, axesLength, angle, startAngle, endAngle, color, thickness
)

cv2.imshow(windowName, image)
cv2.waitKey(0)
cv2.destroyAllWindows()
