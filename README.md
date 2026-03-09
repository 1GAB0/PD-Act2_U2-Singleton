# PD-Act2_U2-Singleton
Actividad de evidencia 2_U2 Singleton. Analizar el código proporcionado.

Gabriel San Roman Castillo - 19211731

## [Portada](./Portada%20PD.pdf)

## Introducción

Singleton es un patrón de diseño creacional que nos permite asegurarnos de que una clase tenga una única instancia, 
a la vez que proporciona un punto de acceso global a dicha instancia.

## [Codigo](Program.cs)

1.-el atributo estático de la instancia
  - Es una variable estática, entonces es propia de la clase, pero
  - no de los objetos que se generen. Se usa para guardar en la memoria
  - la única copia de la instancia del objeto "Central_911" que no va a cambiar durante toda la ejecución del programa
    
2.-el constructor
 - Al ser un constructor privado no puede ser usado fuera de la clase,
 - otras clases no pueden hacer su instancia al no poder usar la palabra new,

¿Por qué no se pueden crear múltiples objetos?
 - El patron asegura que al intentar crear otra instancia devuelve un valor de la instancia
 - ya existente, por eso el doble metodo para asegurarse de si ya hay una instancia creada.


## Conclusion
Singletonnos ayuda cuando necesitamos que exista un control centralizado de un recurso compartido. 
Asi evitamos que se creen copias innecesarias del objeto, esto optimiza el uso de la memoria, 
ademas de asegurarnos un único punto de acceso global y seguro.
