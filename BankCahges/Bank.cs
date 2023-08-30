using System;
using System.IO;
using System.Linq.Expressions;
using System.Threading;

class Bank
{
    private int money;
    private string name;
    private int percent;
    private string dataToAppend;


    public int Money
    {
        get { return money; }
        set
        {
            if (money != value)
            {
                money = value;
                Thread thread = new Thread( new ParameterizedThreadStart(AppendData));
                thread.IsBackground = true;
                thread.Start($"Изменено количество денег на: {value}");
            }
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (name != value)
            {
                name = value;
                Thread thread = new Thread(new ParameterizedThreadStart(AppendData));
                thread.IsBackground = true;
                thread.Start($"Изменено название на: {value}");
            }
        }
    }

    public int Percent
    {
        get { return percent; }
        set
        {
            if (percent != value)
            {
                percent = value;
                Thread thread = new Thread(new ParameterizedThreadStart(AppendData));
                thread.IsBackground = true;
                thread.Start($"Изменена процентная ставка на: {value}");
            }
        }
    }

    public void SaveData()
    {
        using (StreamWriter writer = new StreamWriter("Data.txt"))
            writer.WriteLine(dataToAppend);  
    }

    private void AppendData(object dataforAppend) =>
        dataToAppend += dataforAppend + "\n****************************************\n";
} 