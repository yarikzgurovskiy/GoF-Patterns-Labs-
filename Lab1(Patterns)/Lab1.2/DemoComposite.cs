using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2 {
    class DemoComposite {
        static void Main(string[] args) {
            //create director
            SchoolWorker director = new SchoolWorker("Ivanchenko", SchoolWorkerType.Director);

            //create head teachers
            SchoolWorker ht1 = new SchoolWorker("Stepanenko", SchoolWorkerType.HeadTeacher);
            SchoolWorker ht2 = new SchoolWorker("Petrenko", SchoolWorkerType.HeadTeacher);
            SchoolWorker ht3 = new SchoolWorker("Omelchenko", SchoolWorkerType.HeadTeacher);

            director.Add(ht1);
            director.Add(ht2);
            director.Add(ht3);

            //create teachers
            SchoolWorker t1 = new SchoolWorker("Ivanova", SchoolWorkerType.Teacher, 2, 'B');
            SchoolWorker t2 = new SchoolWorker("Petrova", SchoolWorkerType.Teacher, 4, 'A');
            SchoolWorker t3 = new SchoolWorker("Sydorova", SchoolWorkerType.Teacher, 6, 'C');
            SchoolWorker t4 = new SchoolWorker("Sayko", SchoolWorkerType.Teacher, 8, 'D');
            SchoolWorker t5 = new SchoolWorker("Lysytsa", SchoolWorkerType.Teacher, 11, 'A');
            SchoolWorker t6 = new SchoolWorker("Orlova", SchoolWorkerType.Teacher, 10, 'B');

            ht1.Add(t1);
            ht2.Add(t2);
            ht2.Add(t3);
            ht3.Add(t4);
            ht3.Add(t5);
            ht3.Add(t6);

            //fill classes by parents
            for(int i = 0; i < 8; i++) {
                t1.Add(new Parents("Nemchaninov"));
                t2.Add(new Parents("Bilenkyi"));
                t3.Add(new Parents("Smyrnyi"));
                t4.Add(new Parents("Mykolaenko"));
                t5.Add(new Parents("Stepanenko"));
                t6.Add(new Parents("Kryvonis"));
            }
            string input = "";
            do {
                Console.WriteLine("Please, input sum to collect...");
                try {
                    input = Console.ReadLine();
                    director.RaiseMoney(Int32.Parse(input));
                    director.GetMoneyInfo();
                    director.Display(3);

                } catch(FormatException ex) {
                    Console.WriteLine(ex.Message);
                }
            } while (input != "exit"); 
        }
    }
}
