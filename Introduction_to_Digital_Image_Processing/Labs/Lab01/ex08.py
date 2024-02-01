import cv2

path = "imgs/fruits.png"

# image = cv2.imread(path) # Color
image = cv2.imread(path, 0)  # Grayscale

start_point = (0, 0)

end_point = (250, 250)

color = (172, 173, 174)

thickness = 9

windows_name = "Image"

image = cv2.line(image, start_point, end_point, color, thickness)

cv2.imshow(windows_name, image)
cv2.waitKey(0)
cv2.destroyAllWindows()
