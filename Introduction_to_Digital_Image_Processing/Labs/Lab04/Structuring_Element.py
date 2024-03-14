import cv2

print(cv2.getStructuringElement(cv2.MORPH_RECT, (5, 5)))
print(cv2.getStructuringElement(cv2.MORPH_ELLIPSE, (5, 5)))
print(cv2.getStructuringElement(cv2.MORPH_CROSS, (5, 5)))
