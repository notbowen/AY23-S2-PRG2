namespace S10255800_HospitalApp;

public class Doctor : Person
{
    public string Department { get; }
    public Dictionary<string, Patient> PatientDict { get; }

    public Doctor()
    {
    }
    
    public Doctor(string nric, string name, string department) : base(nric, name)
    {
        Department = department;
        PatientDict = new Dictionary<string, Patient>();
    }

    public void AddPatient(Patient patient)
    {
        PatientDict.Add(patient.Nric, patient);
    }

    public void RemovePatient(Patient patient)
    {
        PatientDict.Remove(patient.Nric);
    }
    
    public override string ToString()
    {
        return $"{base.ToString()} {Department,-15}";
    }
}