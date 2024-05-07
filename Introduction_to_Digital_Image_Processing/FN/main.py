import cv2

# Detect hour in a clock image
# Load the clock image
clock_image = cv2.imread("./2.png")

# Convert the image to grayscale
gray_image = cv2.cvtColor(clock_image, cv2.COLOR_BGR2GRAY)

# Apply thresholding to create a binary image
_, binary_image = cv2.threshold(gray_image, 127, 255, cv2.THRESH_BINARY)

# Find contours in the binary image
contours, _ = cv2.findContours(binary_image, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

# Iterate through the contours
for contour in contours:
    # Calculate the area of each contour
    area = cv2.contourArea(contour)

    # Filter out small contours
    if area > 100:
        # Get the bounding rectangle of the contour
        x, y, w, h = cv2.boundingRect(contour)

        # Draw the bounding rectangle on the original image
        cv2.rectangle(clock_image, (x, y), (x + w, y + h), (0, 255, 0), 2)

        # Print the coordinates and size of the bounding rectangle
        print(f"Hour: x={x}, y={y}, width={w}, height={h}")

# Display the image with bounding rectangles
cv2.imshow("Clock Image", clock_image)
cv2.waitKey(0)
cv2.destroyAllWindows()
