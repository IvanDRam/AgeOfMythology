using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crud.Logica
{
    class lunidades
    {
        private int unidad;
        private string nombre;
        private string costo;
        private int puntos_resis;
        private float velocidad;
        private int coste_poblacion;
        private int alcance_max;
        private int arm_anticontundente;
        private int arm_anticortante;
        private int arm_antiproyectiles;
        private int dam_cortante;
        private int dam_perforante;
        private int dam_demoledor;
        private string civilizacion;
        private string edad;
        private string tipo;

        public int Unidad 
        {
            get { return unidad; }
            set { unidad = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public int Puntos_resis
        {
            get { return puntos_resis; }
            set { puntos_resis = value; }
        }
        public float Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }
        public int Coste_poblacion
        {
            get { return coste_poblacion; }
            set { coste_poblacion = value; }
        }
        public int Alcance_max
        {
            get { return alcance_max; }
            set { alcance_max = value; }
        }
        public int Arm_anticontundente
        {
            get { return arm_anticontundente; }
            set { arm_anticontundente = value; }
        }
        public int Arm_anticortante
        {
            get { return arm_anticortante; }
            set { arm_anticortante = value; }
        }
        public int Arm_antiproyectiles
        {
            get { return arm_antiproyectiles; }
            set { arm_antiproyectiles = value; }
        }
        public int Dam_cortante
        {
            get { return dam_cortante; }
            set { dam_cortante = value; }
        }
        public int Dam_perforante
        {
            get { return dam_perforante; }
            set { dam_perforante = value; }
        }
        public int Dam_demoledor
        {
            get { return dam_demoledor; }
            set { dam_demoledor = value; }
        }
        public string Civilizacion
        {
            get { return civilizacion; }
            set { civilizacion = value; }
        }
        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public lunidades()
        { 
        }

        public lunidades(int unidad,string nombre,string costo, int puntos_resis, float velocidad, int coste_poblacion, int alcance_max, int arm_anticontundente, int arm_anticortante, int arm_antiproyactiles, int dam_cortante, int dam_perforante, int dam_demoledor, string civilizacion, string edad, string tipo)
        {
            Unidad= unidad;
            Nombre= nombre;
            Costo = costo;
            Puntos_resis= puntos_resis;
            Velocidad= velocidad;
            Coste_poblacion= coste_poblacion;
            Alcance_max= alcance_max;
            Arm_anticontundente= arm_anticontundente;
            Arm_anticortante= arm_anticortante;
            Arm_antiproyectiles= arm_antiproyectiles;
            Dam_cortante= dam_cortante;
            Dam_perforante= dam_perforante;
            Dam_demoledor= dam_demoledor;
            Civilizacion= civilizacion;
            Edad= edad;
            Tipo= tipo;
    }
    }
}
