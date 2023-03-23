using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ПР2
{

    public class DataBase //Вспомогательный класс
    {
        public static List<string> Data = new();

        public static List<string> Initialization()
        {
            Data.Add("Dima");
            Data.Add("Lesha");
            Data.Add("Rost");
            return Data;
        }
    }

    public class ExistenceCheck
    {
        public bool Check(string value)
        {
            foreach (var item in DataBase.Initialization())
            {
                if (value == item)
                {
                    Console.WriteLine($"Элемент {value} есть в базе данных");
                    return true;
                }
            }

            Console.WriteLine($"Элемент {value} не найден в базе данных");
            return false;
        }
    }

    public class DataValidation
    {
        public bool CheckValidation(string value)
        {
            Console.WriteLine($"Элемент {value} введён корректно");
            return true;
        }
    }



    public class DataBaseFacade
    {
        public ExistenceCheck existenceCheck;
        public DataValidation data;

        public DataBaseFacade(ExistenceCheck existenceCheck, DataValidation data)
        {
            this.existenceCheck = existenceCheck;
            this.data = data;
        }

        public void AddData(string data)
        {
            if (!existenceCheck.Check(data))
            {
                if (this.data.CheckValidation(data))
                {
                    Console.WriteLine("Элемент успешно добавлен");
                    DataBase.Data.Add(data);
                }
            }

        }

    }


    public class Client
    {
        static void Main(string[] args)
        {
            DataBaseFacade facade = new DataBaseFacade(new ExistenceCheck(), new DataValidation());
            facade.AddData("Dima");
        }

    }
}
