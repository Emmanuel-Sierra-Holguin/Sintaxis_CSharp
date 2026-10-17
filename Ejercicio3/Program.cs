using System.Text;

// 1.  variables y datos
string producto = "Laptop Lenovo";
int cantidad = 2;
double precioUnitario = 1250.50;
bool envioGratis = true;
double total = cantidad * precioUnitario;

// --- OPCIÓN A: Interpolación de Strings ($"") ---
Console.WriteLine($"Producto: {producto} | Cantidad: {cantidad} | Total: ${total} | Envío gratis: {envioGratis}");

// --- OPCIÓN B: Concatenación Tradicional (+) ---
Console.WriteLine("Producto: " + producto + " | Cantidad: " + cantidad + " | Total: $" + total + " | Envío gratis: " + envioGratis);

// --- OPCIÓN C: StringBuilder ---
StringBuilder sb = new StringBuilder();
sb.Append("Producto: ");
sb.Append(producto);
sb.Append(" | Cantidad: ");
sb.Append(cantidad);
sb.Append(" | Total: $");
sb.Append(total);
sb.Append(" | Envío: gratis");
sb.Append(envioGratis);

Console.WriteLine(sb.ToString());