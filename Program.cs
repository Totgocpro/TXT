using System;
using System.IO;
using System.Threading;
namespace TXT
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Clear();
                int Nline = 0;
                int NlineE = 0;
                int NlineEe = 0;
                bool FOK;
                string txt = "";
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Title = "Chargement...";
                Console.WriteLine("Chargement...");
                String lines;
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader("conf.conf");
                    //Read the first line of text
                    lines = sr.ReadLine();
                    //Continue to read until you reach end of file
                 
                        //write the line to console window
                        if (lines == "pass='true'")
                        {

                        }
                        else if (lines == "pass='false'")
                        {
                            erre("");
                            //Application.Exit();
                           // public static void Exit(int exitCode);
                        }
                    else if (lines == "")
                    {
                        erre("");
                        //Application.Exit();
                        // public static void Exit(int exitCode);
                    }
                    else { erre(""); }
                        //Read the next line
                        lines = sr.ReadLine();
                    
                    //close the file
                    sr.Close();
                    //Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                //finally
                //{
                //  Console.WriteLine("Executing finally block.");
                //}
                Thread.Sleep(3000);

                //debut du code
                Console.Title = "TXT";
                Console.WriteLine("Hello!");



                while (true)
                {
                    NlineEe = 0;
                    Nline = 0;
                    NlineE = 0;
                    txt = "";
                    Console.WriteLine("entrer le chemin du fichier ( [a] pour voir dans le dossier les fichier) :");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    string fichier = Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    if (fichier == "a"){
                        Console.WriteLine("entrer le chemin du dossier :");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        string cfiles = Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        //Verifier l'existance du dossier
                        if (Directory.Exists("c:/Dossier")){
                            string[] files = Directory.GetFiles(@cfiles);
                            foreach (string file in files)
                                Console.WriteLine(file);
                            Console.WriteLine("entrer le chemin du fichier dans se dossier :");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            string cfiles2 = Console.ReadLine();
                            cfiles = cfiles + "/" + cfiles2;
                            fichier = cfiles;
                        }
                        else
                        {
                            //Console.WriteLine("Directory Not Found");
                            erre("Directory Not Found");
                        }
                            
                        
                    }
                    // Verifier l'existance du fichier
                    bool FileExist = File.Exists(fichier);
                    if (FileExist == false)
                    {
                        //Console.WriteLine("File Not Found");
                        erre("file not found");
                    }
        
                    //Console.WriteLine(fichier);
                    FOK = true;
                    while (FOK==true)
                    {
                        
                        Console.WriteLine("Que voulez-vous faire :   (a = lecture b= écriture rien=quitter le fichier)");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        string EL = Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        if (EL == "a" || EL == "A")
                        {
                            String line;
                            try
                            {
                                //Pass the file path and file name to the StreamReader constructor
                                StreamReader sr = new StreamReader(fichier);
                                //Read the first line of text
                                line = sr.ReadLine();
                                //Continue to read until you reach end of file
                                while (line != null)
                                {
                                    Nline = Nline + 1;
                                    //write the lie to console window
                                    Console.WriteLine(Nline + ":    " + line);
                                    //Read the next line
                                    line = sr.ReadLine();
                                }
                                //close the file
                                sr.Close();
                                Console.ReadLine();
                            }
                            catch (Exception e)
                            {
                                
                                erre(e.Message);
                                
                            }
                            finally
                            {
                            }
                        }
                        else if (EL == "b" || EL == "B")
                        {
                            String line;

                            try
                            {
                                Console.WriteLine("Contenu du fichier :");
                                //Pass the file path and file name to the StreamReader constructor
                                StreamReader sr = new StreamReader(fichier);
                                //Read the first line of text
                                line = sr.ReadLine();
                                //Continue to read until you reach end of file
                                while (line != null)
                                {
                                    Nline = Nline + 1;
                                    //write the lie to console window
                                    Console.WriteLine(Nline + ":    " + line);
                                    //Read the next line
                                    line = sr.ReadLine();
                                }
                                //close the file
                                sr.Close();
                                Console.ReadLine();
                            }
                            catch (Exception e)
                            {
                                
                                //Console.WriteLine("Erreur: " + e.Message);
                                erre(e.Message);
                                
                            }
                            finally
                            {
                            }



                            //on ecrit dans le fichier
                            try
                            {
                                Console.WriteLine("entrer le nombre de ligne d'écriture: ");
                                Console.BackgroundColor = ConsoleColor.Blue;

                                NlineE = (int.Parse(Console.ReadLine()));

                                Console.BackgroundColor = ConsoleColor.Yellow;
                            }
                            catch (Exception a)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Erreur" + a.Message);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                            }
                            try
                            {
                                //Pass the filepath and filename to the StreamWriter Constructor
                                StreamWriter sw = new StreamWriter(fichier);
                                while (NlineEe <= NlineE - 1)
                                {
                                    NlineEe = NlineEe + 1;



                                    //Write a line of text
                                    Console.WriteLine("entrer le texte de la ligne n°" + NlineEe);
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    txt = Console.ReadLine();
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    sw.WriteLine(txt);
                                    //Write a second line of text
                                    //  sw.WriteLine(txt);
                                    //Close the file

                                }
                                sw.Close();
                            }
                            catch (Exception e)
                            {
                                
                                erre(e.Message);
                                
                            }
                            finally
                            {

                            }


                        }
                        else
                        {
                            FOK = false;
                        }
                    }
                }
            }
            catch (InvalidCastException e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("erreur");
                Console.BackgroundColor = ConsoleColor.Yellow;
            }

        }

        private static void erre(string info)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("erreur");

            
            String infoataper;
            infoataper = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "  :    " + info;
            //Console.WriteLine(infoataper);
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("logs.log");
                StreamWriter sw = new StreamWriter("logs2.log");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to file
                    sw.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                sw.Close();
               // Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader("logs2.log");
                    StreamWriter sw = new StreamWriter("logs.log");
                    //Read the first line of text
                    line = sr.ReadLine();
                    //Continue to read until you reach end of file
                    while (line != null)
                    {
                        //write the line to file
                        sw.WriteLine(line);
                        //Read the next line
                        line = sr.ReadLine();
                    }
                    sw.WriteLine(infoataper);
                    //close the file
                    sr.Close();
                    sw.Close();
                    //Console.ReadLine();
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
               Console.BackgroundColor = ConsoleColor.Yellow;
                
            }


        }
    }
}