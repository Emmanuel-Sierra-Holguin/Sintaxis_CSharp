// 1. Declaración de variables iniciales
double precioProducto = 150.0;
int cantidad = 4;
double porcentajeDescuento = 20.0; // 20% de descuento

// 2. Cálculos iniciales
double subtotal = precioProducto * cantidad;
double descuento = subtotal * (porcentajeDescuento / 100);
double total = subtotal - descuento;

Console.WriteLine($"Subtotal: ${subtotal}");
Console.WriteLine($"Descuento ({porcentajeDescuento}%): -${descuento}");
Console.WriteLine($"Total a pagar: ${total}");

// 3. Modificación de valores con operadores de asignación compuesta
cantidad += 2;          // Se agregan 2 productos más (cantidad pasa a 6)
porcentajeDescuento += 5.0; // El descuento sube 5% más (pasa a 25%)

// 4. Recálculo actualizando los valores (sin volver a escribir 'double')
subtotal = precioProducto * cantidad;
descuento = subtotal * (porcentajeDescuento / 100);
total = subtotal - descuento;

Console.WriteLine("\n--- Después de actualizar el pedido ---");
Console.WriteLine($"Nuevo Subtotal: ${subtotal}");
Console.WriteLine($"Nuevo Descuento ({porcentajeDescuento}%): -${descuento}");
Console.WriteLine($"Nuevo Total a pagar: ${total}");