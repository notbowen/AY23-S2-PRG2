// Hospital App
// Written by: Hu Bowen
// Date: 2 Jan 2024

using S10255800_HospitalApp;

// Q2a)
Dictionary<string, Room> roomDict = new Dictionary<string, Room>();
Dictionary<string, Patient> patientDict = new Dictionary<string, Patient>();
Dictionary<string, Doctor> doctorDict = new Dictionary<string, Doctor>();

// Q2b)
void InitData(Dictionary<string, Room> roomDict, Dictionary<string, Doctor> doctorDict)
{
    roomDict.Add("#01-01", new Room("#01-01", "C"));
    roomDict.Add("#02-02", new Room("#02-02", "B"));
    roomDict.Add("#03-03", new Room("#03-03", "A"));
    roomDict.Add("#04-04", new Room("#04-04", "A"));

    doctorDict.Add("S1234567A", new Doctor("S1234567A", "Tom", "Pediatrics"));
    doctorDict.Add("S2345678A", new Doctor("S2345678A", "Champ", "Oncology"));
    doctorDict.Add("S3456789B", new Doctor("S3456789B", "Terry", "Cardiology"));
}

InitData(roomDict, doctorDict);

Console.WriteLine("{0,-10} {1,-10}", "Location", "Ward Class");
foreach (Room room in roomDict.Values)
{
    Console.WriteLine(room);
}

Console.WriteLine();

Console.WriteLine("{0,-13} {1,-15} {2,-15}", "Nric", "Name", "Department");
foreach (Doctor doctor in doctorDict.Values)
{
    Console.WriteLine(doctor);
}

Console.WriteLine();

// Q2c)
void CreatePatients(Dictionary<string, Patient> patientDict, Dictionary<string, Room> roomDict)
{
    using (StreamReader sr = File.OpenText("Patients.csv"))
    {
        string? line = sr.ReadLine();
        while ((line = sr.ReadLine()) != null)
        {
            string[] data = line.Split(',');
            Patient patient = new Patient(data[0], data[1], roomDict[data[2]]);
            patientDict.Add(patient.Nric, patient);
        }
    }
}

CreatePatients(patientDict, roomDict);

Console.WriteLine("{0,-13} {1,-15} {2,-10}", "Nric", "Name", "Warded At");
foreach (Patient patient in patientDict.Values)
{
    Console.WriteLine(patient);
}

Console.WriteLine();

// Q2d)
void AssignPatientsToDoctors(Dictionary<string, Patient> patientDict, Dictionary<string, Doctor> doctorDict)
{
    using (StreamReader sr = File.OpenText("PatientsToDoctor.csv"))
    {
        string? line = sr.ReadLine();
        while ((line = sr.ReadLine()) != null)
        {
            string[] data = line.Split(',');
            Doctor doctor = doctorDict[data[2]];
            Patient patient = patientDict[data[0]];
            doctor.AddPatient(patient);
        }
    }
}

AssignPatientsToDoctors(patientDict, doctorDict);

Console.WriteLine("{0,-13} {1,-15} {2,-15} {3}", "Nric", "Name", "Department", "Patients");
foreach (Doctor doctor in doctorDict.Values)
{
    Console.WriteLine(
        $"{doctor} {string.Join(", ", doctor.PatientDict.Any() ? doctor.PatientDict.Values.Select(p => p.Name) : new[] { "-" })}");
}

Console.WriteLine();

// Q2e)
void RemovePatientFromDoctor(Dictionary<string, Doctor> doctorDict)
{
    Console.Write("Enter the NRIC of the patient to be removed: ");
    string nric = Console.ReadLine()!;
    foreach (var doctor in doctorDict.Values.Where(doctor => doctor.PatientDict.ContainsKey(nric)))
    {
        doctor.RemovePatient(doctor.PatientDict[nric]);
        Console.WriteLine("Patient removed successfully.\n");
        return;
    }
    Console.WriteLine("Patient not found.\n");
}

RemovePatientFromDoctor(doctorDict);

Console.WriteLine("{0,-13} {1,-15} {2,-15} {3}", "Nric", "Name", "Department", "Patients");
foreach (Doctor doctor in doctorDict.Values)
{
    Console.WriteLine(
        $"{doctor} {string.Join(", ", doctor.PatientDict.Any() ? doctor.PatientDict.Values.Select(p => p.Name) : new[] { "-" })}");
}

Console.WriteLine();

// Q2f)
void AddNewPatient(Dictionary<string, Patient> patientDict, Dictionary<string, Room> roomDict)
{
    Console.Write("Enter NRIC: ");
    string nric = Console.ReadLine()!;

    Console.Write("Enter Name: ");
    string name = Console.ReadLine()!;

    Console.Write("Enter Location: ");
    string location = Console.ReadLine()!;

    Patient newPatient = new Patient(nric, name, roomDict[location]);
    patientDict.Add(newPatient.Nric, newPatient);
    
    using (StreamWriter sw = File.AppendText("Patients.csv"))
    {
        sw.WriteLine($"\n{newPatient.Nric},{newPatient.Name},{newPatient.WardedAt.Location}");
    }
}

AddNewPatient(patientDict, roomDict);