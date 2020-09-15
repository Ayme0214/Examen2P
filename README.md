# Examen2P
Examen aplicando el patrón de diseño Decorator
El codigo se basa en decorar un Vehiculo con diferentes objetos o sistemas
los objetos con los que se decoró fueron: Nitrogeno, SistemadeSonido, Suspension,
y SistemadeAire las cuales se crean como clases y deben implementar a la interfaz
IDecoracion la cual tiene 2 métodos que son Costo() y Funciona(). Estos métodos
serán sobreescritos en cada clase de acuerdo a lo que vayan hacer.
Cada que se le agrega un decorador al vehículo, se irá sumando al valor inicial y eso
dará el costo final, y además se mostrará un mensaje del decorador que se está usando
