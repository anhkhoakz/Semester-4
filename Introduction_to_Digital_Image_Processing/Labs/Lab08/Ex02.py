import cv2
from pyzbar import pyzbar

# Load the image
image = cv2.imread("barcode_image.jpg")

# Convert the image to grayscale
gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)

# Find barcodes in the image
barcodes = pyzbar.decode(gray)

# Iterate over the detected barcodes
for barcode in barcodes:
    # Extract the barcode data and type
    barcode_data = barcode.data.decode("utf-8")
    barcode_type = barcode.type

    # Extract the position and thickness of each line in the barcode
    barcode_lines = barcode.polygon

    # Print the barcode information
    print("Barcode Type:", barcode_type)
    print("Barcode Data:", barcode_data)
    print("Barcode Lines:", barcode_lines)

    # Draw a rectangle around the barcode
    (x, y, w, h) = barcode.rect
    cv2.rectangle(image, (x, y), (x + w, y + h), (0, 255, 0), 2)

# Display the image with barcodes and their information
cv2.imshow("Barcode Detection", image)
cv2.waitKey(0)
cv2.destroyAllWindows()
