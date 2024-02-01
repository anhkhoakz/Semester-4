import cv2

path = "imgs/fruits.png"

image = cv2.imread(path)

windowsName = "Image"

startPoint = (5, 5)

endPoint = (110, 100)

color = (255, 0, 0)

# thickness = 2
thickness = -1

image = cv2.rectangle(image, startPoint, endPoint, color, thickness)

cv2.imshow(windowsName, image)
cv2.waitKey(0)
cv2.destroyAllWindows()
