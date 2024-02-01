import cv2
import os

img_path = r"imgs/fruits.png"
directory = r"/Users/anhkhoakz/TDT_Semester_4/Introduction_to_Digital_Image_Processing/Labs/Lab01/imgs"

img = cv2.imread(img_path)

os.chdir(directory)

print("Before saving image:")
print(os.listdir(directory))

filename = "savedImage.jpg"

cv2.imwrite(filename, img)

print("After saving image:")
print(os.listdir(directory))

print("Successfully saved")

cv2.impo
