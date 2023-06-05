# ISTEA-POO-SegundoParcial-JS
Parcial 5
Diseñar y programar una aplicación que gestione una empresa ferroviaria.
• Maquinistas: nombre, apellido y DNI.
En la parte de maquinaria podemos encontrar trenes, locomotoras, furgón y vagones. De cada uno de ellos hay que considerar: 
Maquinaria: tienen un número que los identifica, el año de fabricación y la marca. Además debe contener un método ImprimirReporte() que muester por pantalla los datos de la maquinaria. Este último método debe permitir a las clases derivadas darle una nueva implementación.
 • Vagones: Además de número de identificación, año de fabricación y marca y el tipo de mercancía (enum, valores Granos o Encomiendas)  con la que están cargados. 
• Locomotoras: Además de número de identificación, año de fabricación y marca y el tipo de motor (enum Diesel o eléctrico). 
• Trenes: esta clase no necesita ser instanciada para ser utilizada, están formados por una locomotora y vagones (encapsular los vagones en una lista, si el motor de la locomotora es Diesel permite máximo 4 y si es eléctrico 5) y un furgón. Cada tren tiene asignado un maquinista que es responsable de él. El método Agregar que recibe un parámetro del tipo maquinaria que asigna según el tipo pasado. Si se agrega una nueva Locomotora al tren debe lanzar una excepción que indique “No puede agregar dos locomotoras”.
Imprimir un reporte de las características de cada tren (instanciar al menos 2), informando su maquinista, cantidad de vagones, si tiene furgón o no, etc.
