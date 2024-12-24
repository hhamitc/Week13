﻿using _01_DependencyInjectionConsolePractice;

public class Program
{
    public static void Main()
    {
        // Teacher instance'ı oluştur
        ITeacher teacher = new Teacher("Hamit", "Canpolat");

        // Teacher'ı ClassRoom'a inject et
        ClassRoom classroom = new ClassRoom(teacher);


        Console.Write("Öğretmen: ");

        // Bilgileri yazdır
        Console.WriteLine(classroom.GetTeacherInfo());

        Console.ReadKey();
    }
}