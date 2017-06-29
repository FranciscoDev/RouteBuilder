﻿using System;

namespace RouteBuilder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Definitions (in seconds)
            double newTravelTime = 30 * 60;
            double timePeriod = 20 * 60;
            int k = 2;

            Console.WriteLine("Welcome to Route Builder by Tygger Inc.");

            NetworkReader nr = new NetworkReader("nodes.txt","links.txt");
            Console.WriteLine("Network loaded");

            DataBaseReader dbr = new DataBaseReader("db.txt");
            DetectionsDB DB = new DetectionsDB(dbr.BTData);
            Console.WriteLine("Data base loaded");

            RealNetwork rn = new RealNetwork(nr.nodesInfo,nr.linksInfo);
            Console.WriteLine("Real network created");

            RealNetwork mn = rn.real_to_model();
            mn.set_DijkstraData(rn);
            Network modelNet = new Network(mn);
            Console.WriteLine("Model network created");

            Scenario sc = new Scenario(DB,modelNet, newTravelTime,timePeriod,k);
            Console.WriteLine("Dwell times, travel times and vehicle travels with options loaded");



            //Asignar tiempos de permanencia a los nodos

            //Asignar tiempos de viaje a los arcos

            //Para cada par de nodos calcular el set de rutas posibles quizás antes

            //Para cdada dato determinar P

            //generar ruta

            //convertir a red real

            //mostrar


        }
    }
}
