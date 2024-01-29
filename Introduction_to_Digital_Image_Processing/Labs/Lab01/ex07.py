import cv2

path='imgs/fruits.png'

image = cv2.imread(path)

window_name='Image'

text='522H0046_Nguyen Huynh Anh Khoa'

font=cv2.FONT_HERSHEY_COMPLEX

org = (10, 50)

fontScale=1

color=(255,255,255)

thickness=2

image = cv2.putText(image,text,org,font,fontScale, color, thickness, cv2.LINE_AA, False)

image = cv2.putText(image, text, org, font, fontScale, color, thickness, cv2.LINE_AA, True)  

cv2.imshow(window_name, image)
cv2.waitKey(0)
cv2.destroyAllWindows()
print(image.shape)