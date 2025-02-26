//Creacion de carpetas para inicio de programa
void CarpetasDeInicio()
{ //Función para crear una carpeta
    string LabAvenger, Backup, Archivos, ArchivosClasificados;
    LabAvenger = "C:\\LaboratorioAvengers";
    Backup = "C:\\LaboratorioAvengers\\Backup";
    Archivos = "C:\\LaboratorioAvengers\\Archivos";
    ArchivosClasificados = "C:\\LaboratorioAvengers\\ArchivosClasificados";
    Directory.CreateDirectory(LabAvenger); //Creo la carpeta de LaboratorioAvengers
    Directory.CreateDirectory(Backup); //Creo la carpeta de Backup
    Directory.CreateDirectory(Archivos); //Creo la carpeta de Archivos
    Directory.CreateDirectory(ArchivosClasificados); //Creo la carpeta de ArchivosClasificados
}
CarpetasDeInicio();



//Variables
string path1 = "C:\\LaboratorioAvengers\\Archivos"; //Archivos
string path2 = "C:\\LaboratorioAvengers\\Backup"; //Carpeta Backup
string path3 = "C:\\LaboratorioAvengers";
int opcion;

//Funciones
void CrearArchivo()
{ //Función para crear un archivo
    Console.Write("Ingrese el contenido del archivo: ");
    string contenido = Console.ReadLine() + "\n"; //Aca hago que el archivo se le pueda agregar contenido
    File.WriteAllText(Path.Combine(path1, "archivo.txt"), contenido); //Creo el archivo ya con el contenido agreagado
    Console.WriteLine("JARVIS- Archivo creado con éxito en " + path1);
}//CrearArchivo();

void AgregarLineas(string invento)
{ //Función para agregar líneas a un archivo
    string filePath = Path.Combine(path1, "archivo.txt");
    if (File.Exists(filePath))
    { //Verifico si el archivo existe
        File.AppendAllText(filePath, invento + Environment.NewLine); //Agrego el contenido al archivo y salto de línea
        Console.WriteLine("Invento agregado con éxito");
    }
    else
    {
        Console.WriteLine("JARVIS- Ultron ha borrado el archivo. Primero cree el archivo Sr.Stark .");
    }
} //AgregarLineas();

void LeerLineaPorLinea()
{ //Función para leer el archivo línea por línea
    string filePath = Path.Combine(path1, "archivo.txt");
    if (File.Exists(filePath))
    {
        int cont = 0;
        string[] lineas = File.ReadAllLines(filePath); //Leo todas las líneas del archivo
        foreach (string linea in lineas)
        {
            cont++;
            Console.WriteLine("Linea Núm: " + cont + " " + linea); //Imprimo cada línea del archivo con su número
        }
    }
    else
    {
        Console.WriteLine("JARVIS- No se ha encontrado nada en el sistema, probablemente Ultron lo borró.");
    }
}

void LeerTodoElArchivo()
{ //Función para leer todo el archivo
    string filePath = Path.Combine(path1, "archivo.txt");
    if (File.Exists(filePath))
    {
        string contenido = File.ReadAllText(filePath); //Leo todo el contenido del archivo
        Console.WriteLine("Contenido del archivo: ");
        Console.WriteLine(contenido);
    }
    else
    {
        Console.WriteLine("JARVIS- No se ha encontrado nada en el sistema, probablemente Ultron lo borró.");
    }
} //LeerTodoElArchivo();

void CopiarArchivo(string origen, string destino)
{ //Función para copiar un archivo
    origen = Path.Combine(path1, "archivo.txt");
    destino = "C:\\LaboratorioAvengers\\Backup\\Archivo(Copia).txt";
    if (File.Exists(origen))
    {
        File.Copy(origen, destino, true); //Copio el archivo a la carpeta de Backup
        Console.WriteLine("JARVIS- Su información ahora está a salvo de Ultron");
        Console.WriteLine("Archivo copiado con éxito");
        File.Delete(origen);
    }
    else
    {
        Console.WriteLine("JARVIS- No se encontró el archivo en la ruta especificada.");
    }
} //CopiarArchivo();

void MoverArchivo(string origen, string destino)
{ //Función para mover un archivo
    origen = Path.Combine(path1, "archivo.txt");
    destino = "C:\\LaboratorioAvengers\\ArchivosClasificados\\Archivo(Movido).txt";
    if (File.Exists(origen))
    { //Verifico si el archivo existe
        File.Move(origen, destino); //Muevo el archivo a la carpeta de ArchivosClasificados
        Console.WriteLine("JARVIS- Su información ahora está a salvo de Ultron");
        Console.WriteLine("Archivo movido con éxito");
    }
    else
    {
        Console.WriteLine("JARVIS- No se encontró el archivo en la ruta especificada.");
    }
} //MoverArchivo();

void CrearCarpeta(string PSecreto)
{ //Función para crear una carpeta
    PSecreto = "C:\\LaboratorioAvengers\\ProyectoSecreto";
    Directory.CreateDirectory(PSecreto); //Creo la carpeta de ProyectoSecreto
    Console.WriteLine("JARVIS- Ruta de acceso secreta creada\n");
} //CrearCarpeta();

void ListarArchivos(string ruta)
{ //Función para listar los archivos de una carpeta
    string[] archivos = Directory.GetFiles(ruta); //Obtengo los archivos de la carpeta
    Console.WriteLine("JARVIS- Archivos encontrados en la carpeta: ");
    foreach (string archivo in archivos) //Imprimo los archivos encontrados
    {
        Console.WriteLine(archivo);
    }
    Console.WriteLine();
} //ListarArchivos();




//Programa Principal
Console.WriteLine("\tBienvenido a StarLabs Sr.Stark!");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("¿Qué es lo que desea hacer hoy señor Stark?");
Console.WriteLine("1)  Crear Archivo");
Console.WriteLine("2)  Agregar lineas al Archivo");
Console.WriteLine("3)  Leer linea por linea del Archivo");
Console.WriteLine("4)  Leer todo el Archivo");
Console.WriteLine("5)  Copiar Archivo");
Console.WriteLine("6)  Mover Archivo");
Console.WriteLine("7)  Crear Carpeta");
Console.WriteLine("8)  Listar Archivos");
Console.WriteLine("9) Salir");
Console.WriteLine("----------------------------------------------------");
Console.Write("Opción: ");
opcion = int.Parse(Console.ReadLine());
do
{
    switch (opcion)
    {
        case 1: //Opcción para crear un archivo
            CrearArchivo();
            break;
        case 2: //Opción para agregar líneas a un archivo
            Console.Write("Invento: ");
            string invento = Console.ReadLine();
            AgregarLineas(invento);
            break;
        case 3: //Opción para leer el archivo línea por línea
            LeerLineaPorLinea();
            break;
        case 4: //Opción para leer todo el archivo
            LeerTodoElArchivo();
            break;
        case 5: //Opción para copiar un archivo
            CopiarArchivo(path1, path2);
            break;
        case 6: //Opción para mover un archivo
            MoverArchivo(path1, path2);
            break;
        case 7: //Opción para crear una carpeta
            CrearCarpeta(path3);
            break;
        case 8: //Opción para listar los archivos de una carpeta
            ListarArchivos(path1);
            break;
        case 9:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
    Console.WriteLine();
    Console.Write("Opción: ");
    opcion = int.Parse(Console.ReadLine());
} while (true);
