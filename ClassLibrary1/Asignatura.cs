using System;


namespace EDexamenT6a8
{




    /*Clase que representa la gestíon de las notas para una asignatura.
     * Se puede(métodos): Introducir la asignatura
     *                    Registrar las notas de prácticas y examen para cada evaluación.
     *                    Calcular las notas por cada trimestre.
     *                    Calcular la nota final de curso.
     * Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
     */


    class Asignatura
    {
        /// (REFACTORIZACION: Renombramiento, Encapsular campos)
        /// <summary>
        /// Variables de la clase
        /// </summary>
        private string cod_Asignatura;
        private string nombre_Asignatura;
        private double nota_trimestre1;
        private double notaTrimestre2;
        private double nota_Trimestre3;
        private double notaFinal;
        /// (REFACTORIZACION: Extraer Metodo)
        /// <summary>
        /// Getters tras cambiar la proteccion de las variables
        /// </summary>
        public string Cod_Asignatura { get => cod_Asignatura; set => cod_Asignatura = value; }
        public string Nombre_Asignatura { get => nombre_Asignatura; set => nombre_Asignatura = value; }
        public double Nota_trimestre1 { get => nota_trimestre1; set => nota_trimestre1 = value; }
        public double NotaTrimestre2 { get => notaTrimestre2; set => notaTrimestre2 = value; }
        public double Nota_Trimestre3 { get => nota_Trimestre3; set => nota_Trimestre3 = value; }
        public double NotaFinal { get => notaFinal; set => notaFinal = value; }
        /// <summary>
        /// Contructor de la clase
        /// </summary>
        /// <param name="CodigodelaAsignatura"> Hace referencia al codigo de la asignatura </param>
        /// <param name="NombredelaAsignatura"> Hace referencia al nombre de la asignatura </param>
        /// <param name="NotadelPrimertrimestre"> Hace referencia a la nota del primer trimestre de la asignatura </param>
        /// <param name="NotadelSegungoTrimestre"> Hace referencia a la nota del segundi trimestre de la asignatura </param>
        /// <param name="NotadelTercerTrimestre"> Hace referencia a la nota del tercero trimestre de la asignatura </param>
        /// <param name="NotaFinaldelCurso"> Hace referencia a la nota final de la asignatura </param>
        public Asignatura(string CodigodelaAsignatura, string NombredelaAsignatura, double NotadelPrimertrimestre, double NotadelSegungoTrimestre, double NotadelTercerTrimestre, double NotaFinaldelCurso)
        {
            this.Cod_Asignatura = CodigodelaAsignatura; //Codigo de la asignatura.
            this.Nombre_Asignatura = NombredelaAsignatura; //Nombre de la asignatura.
                                                           // Nota de los trimestres (1, 2   y 3) y nota final.
            this.Nota_trimestre1 = NotadelPrimertrimestre;
            this.NotaTrimestre2 = NotadelSegungoTrimestre;
            this.Nota_Trimestre3 = NotadelTercerTrimestre;
            this.NotaFinal = NotaFinaldelCurso;
        }

        /// (REFACTORIZACION/CORRECCIONES: Renombrar)
        /// <summary>
        /// Clase para introducir las materias
        /// </summary>
        /// <param name="Cod_Asignatura"> Hace referencia al codigo de la asignatura </param>
        /// <param name="Nombre_Asignatura"> Hace referencia al nombre de la asignatura </param>
        public void IntroducirMateria(string Cod_Asignatura, string Nombre_Asignatura)
        {
            this.Cod_Asignatura = Cod_Asignatura; this.Nombre_Asignatura = Nombre_Asignatura;

        }
        /// (REFACTORIZACION/CORRECCIONES: Renombrar)
        /// (REFACTORIZACION: Extraer metodo)
        /// <summary>
        /// Clase para introducir las notas
        /// </summary>
        /// <param name="nota_Examen1"> Hace referencia a la nota del primer trimestre de la asignatura</param>
        /// <param name="nota_Examen2"> Hace referencia a la nota del segundi trimestre de la asignatura </param>
        /// <param name="nota_Examen3"> Hace referencia a la nota del tercero trimestre de la asignatura </param>
        /// <param name="nota_Practicas1"></param>
        /// <param name="nota_Practicas2"></param>
        /// <param name="nota_Practicas3"></param>
        public void Introducir_Notas(double nota_Examen1, double nota_Examen2, double nota_Examen3, double nota_Practicas1, double nota_Practicas2, double nota_Practicas3)
        {
            {
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine("Trimestre evaluado 1, 2 ó 3: ");
                    var Trimestre = Console.ReadLine();
                    Imprimirnotas(ref nota_Examen1, ref nota_Examen2, ref nota_Examen3, ref nota_Practicas1, ref nota_Practicas2, ref nota_Practicas3, Trimestre);

                }

            }
        }
        /// (REFACTORIZACION: Extraer metodo)
        /// <summary>
        /// Clase extraida con el switch de la funcion de arriba
        /// </summary>
        /// <param name="nota_Examen1"> Hace referencia a la nota del primer trimestre de la asignatura</param>
        /// <param name="nota_Examen2"> Hace referencia a la nota del segundi trimestre de la asignatura </param>
        /// <param name="nota_Examen3"> Hace referencia a la nota del tercero trimestre de la asignatura </param>
        /// <param name="nota_Practicas1"> Hace referencia a la nota de las practicas del primer trimestre </param>
        /// <param name="nota_Practicas2"> Hace referencia a la nota de las practicas del segundo trimestre </param>
        /// <param name="nota_Practicas3"> Hace referencia a la nota de las practicas del terecr trimestre </param>
        /// <param name="Trimestre"> Hace referencia al trimestre en concreto </param>
        private static void Imprimirnotas(ref double nota_Examen1,
                                          ref double nota_Examen2,
                                          ref double nota_Examen3,
                                          ref double nota_Practicas1,
                                          ref double nota_Practicas2,
                                          ref double nota_Practicas3,
                                          string Trimestre)
        {
            switch (Trimestre)
            {
                case "1":
                    Console.WriteLine("Nota de las prácticas: ");
                    nota_Practicas1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nota del examen: ");
                    nota_Examen1 = Convert.ToDouble(Console.ReadLine());
                    break;

                case "2":
                    Console.WriteLine("Nota de las prácticas: ");
                    nota_Practicas2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nota del examen: ");
                    nota_Examen2 = Convert.ToDouble(Console.ReadLine());
                    break;

                case "3":
                    Console.WriteLine("Nota de las prácticas: ");
                    nota_Practicas3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nota del examen: ");
                    nota_Examen3 = Convert.ToDouble(Console.ReadLine());
                    break;
            }
        }
        /// (REFACTORIZACION: Renombrar)
        /// <summary>
        /// Funcion para calcular la primera nota
        /// </summary>
        /// <param name="nota_Examen1"> Hace referencia a la nota del primer trimestre de la asignatura</param>
        /// <param name="nota_Practicas1"> Hace referencia a la nota d elas practicas del primer trimestre de la asignatura </param>
        /// <returns>Devuelve la nota final del trimestre</returns>
        public double calculo_Nota1(double nota_Examen1, double nota_Practicas1)
        {
            return Calculo_NotaGeneral(nota_Examen1, nota_Practicas1);
        }
        /// (REFACTORIZACION/CORRECCIONES: Renombrar)
        /// <summary>
        /// Funcion para calcular la segunda nota
        /// </summary>
        /// <param name="nota_Examen2"> Hace referencia a la nota del segundi trimestre de la asignatura </param>
        /// <param name="nota_Practicas2"> Hace referencia a la nota d elas practicas del segundo trimestre de la asignatura </param>
        /// <returns>Devuelve la nota final del trimestre</returns>
        public double calculodelaNota2(double nota_Examen2, double nota_Practicas2)
        {
            return Calculo_NotaGeneral(nota_Examen2, nota_Practicas2);
        }
        /// (REFACTORIZACION/CORRECCIONES: Renombrar)
        /// <summary>
        /// Funcion para calcular la tercera nota
        /// </summary>
        /// <param name="nota_Examen3"> Hace referencia a la nota del tercero trimestre de la asignatura </param>
        /// <param name="nota_Practicas3"> Hace referencia a la nota d elas practicas del tercer trimestre de la asignatura </param>
        /// <returns>Devuelve la nota final del trimestre</returns>
        public double calculodelaNota3(double nota_Examen3, double nota_Practicas3)
        {
            return Calculo_NotaGeneral(nota_Examen3, nota_Practicas3);
        }
        /// (REFACTORIZACION/CORRECCIONES: Renombrar)
        /// (REFACTORIZACION: Extraer metodo)
        /// <summary>
        /// Funcioon extrida para que las calculo nota la llamen y calcular sus notas
        /// </summary>
        /// <param name="nota_Examen"> Hace referencia a la nota del trimestre de la asignatura </param>
        /// <param name="nota_Practicas"> Hace referencia a la nota d elas practicas de la asignatura </param>
        /// <returns>Devuelve la nota final del trimestre</returns>
        private double Calculo_NotaGeneral(double nota_Examen, double nota_Practicas)
        {
            Nota_Trimestre3 = (nota_Examen * 0.8) + (nota_Practicas) * 0.2;
            return Nota_Trimestre3;
        }
        /// (REFACTORIZACION/CORRECCIONES: Renombrar)
        /// <summary>
        /// Funcion de calculo de la media
        /// </summary>
        /// <returns>Devuelve la nota final</returns>
        public double Calculo_media()
        {
            NotaFinal = (this.Nota_trimestre1 + this.NotaTrimestre2 + this.Nota_Trimestre3) / 3; //Nota final del curso
            return NotaFinal;
        }

    }
    class ejemplodeunaAsignatura
    {

        //TODO
        /*
         *   
        static void main()
        {
            * 
            * 
            * 
            asignatura mi_asignatura_ejemplo = new asignatura("0521385", "Entornos  de Desarrollo");

            /
        */
    }
}