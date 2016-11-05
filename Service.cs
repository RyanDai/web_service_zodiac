using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{

    private Dictionary<string, string> findTime = new Dictionary<string, string>();
    

    public string getDate(string zodiac)
    {
        findTime.Add("Aries", "03/21 - 04/20");
        findTime.Add("Taurus", "04/21 - 05/20");
        findTime.Add("Gemini", "05/22 - 06/21");
        findTime.Add("Cancer", "06/22 - 07/22");
        findTime.Add("Leo", "07/23 - 08/22");
        findTime.Add("Virgo", "08/23 - 09/23");
        findTime.Add("Libra", "09/24 - 10/23");
        findTime.Add("Scorpio", "10/24 - 11/22");
        findTime.Add("Sagittarius", "11/23 - 12/21");
        findTime.Add("Capricorn", "12/22 - 01/20");
        findTime.Add("Aquarius", "01/21 - 02/19");
        findTime.Add("Pisces", "02/20 - 03/20");

        string result = "Not found";
        foreach (KeyValuePair<string, string> pair in findTime)
        {
            if (zodiac.Equals(pair.Key))
            {
                result = pair.Value;
            }
        }

        return result;
    }


    public string getName(string mon, string day)
    {
        string result = "Wrong Input Date";
        int dayNum = Convert.ToInt16(day);
        if(dayNum < 1 || dayNum > 31)
        {
            return result;
        }
        int days = 0;

        if (mon.Equals("01"))
        {
            days = 0 + Convert.ToInt16(day);
        }
        else if (mon.Equals("02"))
        {
            days = 31 + Convert.ToInt16(day);
        }
        else if (mon.Equals("03"))
        {
            days = 59 + Convert.ToInt16(day);
        }
        else if (mon.Equals("04"))
        {
            days = 90 + Convert.ToInt16(day);
        }
        else if (mon.Equals("05"))
        {
            days = 120 + Convert.ToInt16(day);
        }
        else if (mon.Equals("06"))
        {
            days = 151 + Convert.ToInt16(day);
        }
        else if (mon.Equals("07"))
        {
            days = 181 + Convert.ToInt16(day);
        }
        else if (mon.Equals("08"))
        {
            days = 212 + Convert.ToInt16(day);
        }
        else if (mon.Equals("09"))
        {
            days = 243 + Convert.ToInt16(day);
        }
        else if (mon.Equals("10"))
        {
            days = 273 + Convert.ToInt16(day);
        }
        else if (mon.Equals("11"))
        {
            days = 304 + Convert.ToInt16(day);
        }
        else if (mon.Equals("12"))
        {
            days = 0334 + Convert.ToInt16(day);
        } else
        {
            return result;
        }

        if (days >= 80 && days <= 110)
        { result = "Aries"; }
        else if (days >= 111 && days <= 141)
        { result = "Taurus"; }
        if (days >= 142 && days <= 172)
        { result = "Gemini"; }
        if (days >= 173 && days <= 203)
        { result = "Cancer"; }
        if (days >= 204 && days <= 234)
        { result = "Leo"; }
        if (days >= 235 && days <= 265)
        { result = "Virgo"; }
        if (days >= 266 && days <= 295)
        { result = "Libra"; }
        if (days >= 296 && days <= 325)
        { result = "Scorpio"; }
        if (days >= 326 && days <= 355)
        { result = "Sagittarius"; }
        if (days >= 356 || days <= 19)
        { result = "Capricorn"; }
        if (days >= 20 && days <= 49)
        { result = "Aquarius"; }
        if (days >= 50 && days <= 79)
        { result = "Pisces"; }

        return result;
    }

    public string getTime()
    {
        string time = DateTime.Now.ToString("hh:mm:ss");
        return time;
    }

    public string getPostCode(string area)
    {
        string text = System.IO.File.ReadAllText(@"H:\INFS3204\PostCodes.txt");
        string[] textArray = text.Split('\n');
        for (int i = 0; i < textArray.Length; i++)
        {
            string[] code = textArray[i].Split(',');
            if (area.Equals(code[0]))
            {
                return code[1];
            }
        }
        return "";

    }



    public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
