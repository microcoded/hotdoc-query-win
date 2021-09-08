using System;

public class Rootobject
{
    public Clinic[] clinics { get; set; }
    public object[] doctors { get; set; }
    public Suburb[] suburbs { get; set; }
    public Match[] matches { get; set; }
    public Meta meta { get; set; }
}

public class Meta
{
    public Paging paging { get; set; }
}

public class Paging
{
    public object next_cursor { get; set; }
}

public class Clinic
{
    public int id { get; set; }
    public string image { get; set; }
    public string name { get; set; }
    public string slug { get; set; }
    public string street_address { get; set; }
    public Open_State open_state { get; set; }
    public int suburb_id { get; set; }
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

public class Suburb
{
    public int id { get; set; }
    public string name { get; set; }
    public string state { get; set; }
    public string postcode { get; set; }
    public string slug { get; set; }
}

public class Match
{
    public int entity_id { get; set; }
    public string entity_type { get; set; }
    public string distance { get; set; }
    public Featured_Infos[] featured_infos { get; set; }
    public int clinic_id { get; set; }
    public object doctor_id { get; set; }
    public int suburb_id { get; set; }
}

public class Featured_Infos
{
    public string title { get; set; }
    public string description { get; set; }
    public string tone { get; set; }
    public string icon { get; set; }
}
