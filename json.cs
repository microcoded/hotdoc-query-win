using System.Collections.Generic;

public class Rootobject
{
    public List<Clinic> clinics { get; set; }
    public List<Match> matches { get; set; }
}

public class Clinic
{
    public int id { get; set; }
    public string image { get; set; }
    public string name { get; set; }
    public string street_address { get; set; }
    public Open_State open_state { get; set; }
}

public class Open_State
{
    public bool is_open { get; set; }
    public Label label { get; set; }
}

public class Label
{
    public string _long { get; set; }
    public string _short { get; set; }
}

public class Match
{
    public int entity_id { get; set; }
    public string distance { get; set; }
    public object doctor_id { get; set; }
}