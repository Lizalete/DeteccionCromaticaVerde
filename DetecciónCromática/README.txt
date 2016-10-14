El objetivo de este programa es detectar el color verde en varias
imágenes con diferentes métodos. Los que se utilizaron fueron
RGB, YUV y HSV.

El programa está hecho en C# y consta de una clase:

1.- Form1.cs: Contiene los métodos relacionados con 
los eventos y métodos que se presentan en la interfaz 
de usuario, los cuales son:
a) getRGB: Asigna el rango en RGB del color verde 
y llama al método getImagesRGB.
b)getHSV: Asigna el rango en HSV del color verde 
y llama al método getImagesHSV.

En los siguientes tres métodos se crea una carpeta donde 
se guardarán las imágenes modificadas. Además, cuando se 
termine de modificar cada imagen, se sumará el parámetro 
number, el cual es utilizado en la interfaz para indicar 
al usuario cuánto falta para que termine el programa.

c)getImagesRGB: Se obtendrá de cada imagen su RGB. 
Si éste está dentro del rango obtenido en el métodogetRGB, 
se pintará de blanco el pixel. Si no está dentro del rango, 
se quedará con su color original.
d)getImagesYUV: Se obtendrá de cada imagen su YUV. 
Si la Y es mayor a .6 (rango de verde), se pintará de blanco 
el pixel. Si no está dentro del rango, se quedará con su color
original.
e)getImagesHSV: Se obtendrá de cada imagen su HSV. 
Si éste está dentro del rango obtenido en el método getHSV, 
se pintará de blanco el pixel. Si no está dentro del rango, 
se quedará con su color original.

NOTA: En el proyecto se encuentra una carpeta con las imágenes
utilizadas (...bin\BSR\BSDS500\data\images\train)