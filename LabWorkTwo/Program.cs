namespace LabTwo
{
    class Vehicle
    {
        double coordinates;
        double price;
        double speed;
        int year;
        public Vehicle(double coordinates, double price, double speed, int year)
        {
            this.coordinates = coordinates;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public double Coordinates { get { return coordinates; } }
        public double Price { get { return price; } }
        public double Speed { get { return speed; } }
        public int Year { get { return year; } }
        public void GetGeneralInfo()
        {
            Console.WriteLine("Coordinates " + Coordinates);
            Console.WriteLine("Price " + Price);
            Console.WriteLine("Speed " + Speed);
            Console.WriteLine("Year " + Year);
        }
    }

    class Plane : Vehicle
    {
        double height;
        int passengers;
        public Plane(double coordinates, double price, double speed, int year, double height, int passengers) : base(coordinates, price, speed, year)
        {
            this.height = height;
            this.passengers = passengers;
        }

        public double Height { get { return height; } }
        public int Passengers { get { return passengers; } }

        public void GetPersonalInfo()
        {
            Console.WriteLine("Height " + Height);
            Console.WriteLine("Passengers " + Passengers);
        }
    }
    class Car : Vehicle
    {
        public Car(double coordinates, double price, double speed, int year) : base(coordinates, price, speed, year) { }
    }
    class Ship : Vehicle
    {
        int passengers;
        string port;
        public Ship(double coordinates, double price, double speed, int year, string port, int passengers) : base(coordinates, price, speed, year)
        {
            this.port = port;
            this.passengers = passengers;
        }
        public string Port { get { return port; } }
        public int Passengers { get { return passengers; } }

        public void GetPersonalInfo()
        {
            Console.WriteLine("Port " + Port);
            Console.WriteLine("Passengers " + Passengers);
        }

    }
    class ClassRoom
    {
        Pupil[] _pupil;
        public Pupil[] pupl
        {
            get { return _pupil; }
        }
        public ClassRoom(params Pupil[] pupil)
        {
            _pupil = new Pupil[pupil.Length];
            for (int i = 0; i < pupil.Length; i++)
            {
                _pupil[i] = pupil[i];
            }
        }
    }

    abstract class Pupil
    {
        virtual public void GetName() { }
        virtual public void GetInfo() { }

        virtual public void Study() { }

        virtual public void Read() { }

        virtual public void Write() { }

        virtual public void Relax() { }

    }

    class ExcelentPupil : Pupil
    {
        public override void GetName()
        {
            Console.WriteLine("ExcelentPupil");
        }
        override public void GetInfo()
        {
            Study();
            Read();
            Write();
            Relax();
        }
        override public void Study()
        {
            Console.WriteLine("I am studying hard!");
        }

        override public void Read()
        {
            Console.WriteLine("I am reading whole nights!");
        }

        override public void Write()
        {
            Console.WriteLine("I am writing beatifully and correctly!");
        }

        override public void Relax()
        {
            Console.WriteLine("I am not relaxing!");
        }
    }


    class GoodPupil : Pupil
    {
        public override void GetName()
        {
            Console.WriteLine("GoodPupil");
        }
        override public void GetInfo()
        {
            Study();
            Read();
            Write();
            Relax();
        }
        override public void Study()
        {
            Console.WriteLine("I am studying normally!");
        }

        override public void Read()
        {
            Console.WriteLine("I am reading 20 pages per day!");
        }

        override public void Write()
        {
            Console.WriteLine("I am writing correctly!");
        }

        override public void Relax()
        {
            Console.WriteLine("I am relaxing 8 hours!");
        }
    }


    class BadPupil : Pupil
    {
        public override void GetName()
        {
            Console.WriteLine("BadPupil");
        }
        override public void GetInfo()
        {
            Study();
            Read();
            Write();
            Relax();
        }
        override public void Study()
        {
            Console.WriteLine("I am not studying at all!");
        }

        override public void Read()
        {
            Console.WriteLine("I can't read!");
        }

        override public void Write()
        {
            Console.WriteLine("I am writing graffity on the walls!");
        }

        override public void Relax()
        {
            Console.WriteLine("Chill out!");
        }
    }



class DocumentWorker
    {
       public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
       public void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
      public  void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
      public  void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
      public  void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
    public    void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }

    static class Program
    {
        static void Main()
        { //task 1
            //some pupils
            ExcelentPupil epupil1 = new ExcelentPupil();
            ExcelentPupil epupil2 = new ExcelentPupil();
            GoodPupil gpupil = new GoodPupil();
            BadPupil bpupil = new BadPupil();
            //classroom1
            ClassRoom class1 = new ClassRoom(epupil1, epupil2, gpupil);
            //classroom2
            ClassRoom class2 = new ClassRoom(epupil1, epupil2, gpupil, bpupil);
            //outputs
            Console.WriteLine("\t\t\t\t\t\tClassRoom number 1");
            for (int i = 0; i < class1.pupl.Length; i++)
            {
                class1.pupl[i].GetName();
                class1.pupl[i].GetInfo();
                Console.WriteLine();
            }
            Console.WriteLine("\t\t\t\t\t\tClassRoom number 2");
            for (int i = 0; i < class2.pupl.Length; i++)
            {
                class2.pupl[i].GetInfo();
                Console.WriteLine();
            }

            //task 2
            Plane air = new Plane(123, 15000, 810, 2010, 10000, 150);
            Car earth = new Car(123, 2000, 120, 2020);
            Ship water = new Ship(123, 7000, 40, 1990, "Mali", 200);
            Console.WriteLine("Plane");
            air.GetGeneralInfo();
            air.GetPersonalInfo();
            Console.WriteLine("Car");
            earth.GetGeneralInfo();
            Console.WriteLine("Ship");
            water.GetGeneralInfo();
            water.GetPersonalInfo();



            //task3
            Console.WriteLine("Hello, please, choose mode of editor:\n1.Standart\n2.Pro\n3.Expert");
            string name = Console.ReadLine();
            const string PASS = "123";
            if (name == "Standart")
            {
                DocumentWorker dw = new DocumentWorker();
                dw.OpenDocument();
                dw.SaveDocument();
                dw.EditDocument();
            } else {
                Console.WriteLine("Please, input the key");
                string key = Console.ReadLine();
                if (key == PASS)
                {
                    if (name == "Pro")
                    {
                        Console.WriteLine("U are on pro version");
                        ProDocumentWorker pr = new ProDocumentWorker();
                        pr.OpenDocument();
                        pr.SaveDocument();
                        pr.EditDocument();
                    } else
                    {
                        Console.WriteLine("U are on expert version");
                        ExpertDocumentWorker ex = new ExpertDocumentWorker();
                        ex.OpenDocument();
                        ex.SaveDocument();
                        ex.EditDocument();
                    }
                } else {
                    Console.WriteLine("Wrong password, u are on base version");
                    DocumentWorker dw = new DocumentWorker();
                    dw.OpenDocument();
                    dw.SaveDocument();
                    dw.EditDocument();
                }
            }
        }
    }
}
