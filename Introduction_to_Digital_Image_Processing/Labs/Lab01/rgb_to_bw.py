import cv2


def rgb_to_bw_opencv(input_path, output_path):
    # Read the RGB image
    img = cv2.imread(input_path)

    # Convert to grayscale
    bw_img = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

    # Save the black and white image
    cv2.imwrite(output_path, bw_img)


# Example usage:
input_image_path = (
    "/Users/anhkhoakz/Library/Mobile Documents/com~apple~CloudDocs/avatar.png"
)
output_image_path = (
    "/Users/anhkhoakz/Library/Mobile Documents/com~apple~CloudDocs/avatar_bw.png"
)

rgb_to_bw_opencv(input_image_path, output_image_path)
