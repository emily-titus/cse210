using System;
using System.Text.Json.Serialization;

public class Entry
{
    [JsonInclude]
    public string _prompt { get; set; }
    [JsonInclude]
    public string _dateOfEntry { get; set; }
    [JsonInclude]
    public string _response { get; set; }
    public Entry() { }
    public Entry(string prompt, string dateofentry, string response)
    {
        this._prompt = prompt;
        this._dateOfEntry = dateofentry;
        this._response = response;
    }

    public string GetDisplay()
    {
        string display = $"Date: {_dateOfEntry} - Prompt: {_prompt} \n{_response}\n";
        return display;
    }
}

