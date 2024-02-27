using System;
//Multilevel inheritance

class CyberSecurityStudent: CSStudent
{
    public CyberSecurityStudent(string name, byte rn, string pTitle, string certification)
    : base(name, rn, pTitle)
    {
        SecurityCertification= certification;
    }
    public string EthicalHackingCourseTitle { get; set; }
    public string SecurityCertification { get; set; }
    public DateTime CertifiedDate { get; set; }= DateTime.Now;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Certification: {SecurityCertification}");
        Console.WriteLine($"Certified Date: {CertifiedDate}");

    }
}