using System;

public class IndexerExample
{

    public string this[string key]
    {
        get
        {
            string result = null;
            switch (key)
            {
                case "do":
                    result= "a deer";
                    break;
                case "re":
                    result= "a drop of golden sun";
                    break;
                default:
                    return null;

            }
            return result;

        }


    }
}