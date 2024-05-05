using System;

class Journal
{
    public void Run()
    {
        DisplayIntro();
    }
    private void DisplayIntro()
    {
        Console.WriteLine("Welcome to the Journal program");
    }
    public void Writing()
    {
        List<string> preguntas = new List<string>()
        {
            "If you had one thing I could do over today ,what would it be?",
            "¿What was the best part of my day'?",
            "¿What I could learn of this day?",
        };


        Random random = new Random();

        int indicePreguntaAleatoria = random.Next(preguntas.Count);
        string preguntaAleatoria = preguntas[indicePreguntaAleatoria];

        Console.WriteLine("Pregunta: " + preguntaAleatoria);
        string respuesta = Console.ReadLine();
    }
}








