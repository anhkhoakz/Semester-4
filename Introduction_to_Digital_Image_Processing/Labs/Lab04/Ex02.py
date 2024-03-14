import cv2 as cv

"""
Given an input image as follows (numbers are pixel intensities). Using morphological operations and contour to draw rectangles surrounding each number (bounding boxes).

# Hint:
(1) Convert to binary image (mask of numbers) using thresholding techniques 
(2) Using dilation/closing to connect digits of each numbers (choose a suitable kernel in size) 
(3) Find contours and bounding boxes (using methods in Contour features: bounding Rect)
"""


img = cv.imread("./img3.png", 0)
