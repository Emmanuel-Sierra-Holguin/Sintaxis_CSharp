using System.Text;

int width = 7;
int height = 5;

int area = width * height;
int perimeter = 2 * width + 2 * height;

width *= 3;
height -= 2;

area = width * height;
perimeter = 2 * width + 2 * height;

StringBuilder sb = new StringBuilder();
sb.Append($"calcularemos el area de un rectangulo mediante el ancho {width} y altura {height}");
sb.Append(", el area del rectangulo es ");
sb.Append(area);
sb.Append(" y su perimetro es ");
sb.Append(perimeter);
sb.Append(".");

string resultado = sb.ToString();
Console.WriteLine(resultado);