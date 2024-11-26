using Kiss_Levente_Varosok;

List<Varos> varosok = [];

StreamReader sr = new StreamReader(@"..\..\..\SRC\varosok.csv");
sr.ReadLine();
while (!sr.EndOfStream)
{
    varosok.Add(new Varos(sr.ReadLine()));
}
sr.Close();
Console.WriteLine($"Kollekció hossza: {varosok.Count}");

var osszFoKina = varosok.Where(v => v.OrszagNeve == "Kína").Sum(v => v.Nepesseg);
Console.WriteLine($"\n{osszFoKina} millió fő él összesen a kínai nagyvárosokban.");

var indiaAtlag = varosok.Where(v => v.OrszagNeve == "India").Average(v => v.Nepesseg);
Console.WriteLine($"\n{indiaAtlag} fő az Indiai városok átlag lélekszáma. ");

var legnepesebbVaros = varosok.OrderByDescending(v => v.Nepesseg).First();
Console.WriteLine($"\nLegnepesebb város: {legnepesebbVaros}");

var nepessegSzerintCsokkeno = varosok.OrderByDescending(v => v.Nepesseg).Where(v => v.Nepesseg > 20);
Console.WriteLine($"\n20 millió lakos feletti városok csökkenő sorrendben:");
foreach (var varos in nepessegSzerintCsokkeno)
{
    Console.WriteLine(varos);
}

var tobbVaros = varosok.GroupBy(v=>v.OrszagNeve).Where(group =>group.Count()>1).Count();
Console.WriteLine($"\nTöbb nagyvárossal szerepel a listában: {tobbVaros} ország");

var kezdoBetu = varosok.GroupBy(v => v.VarosNeve[0]).OrderByDescending(v=>v.Count()).First();
Console.WriteLine($"\nA legtöbb nagyváros neve {kezdoBetu.Key} betűvel kezdődik.");

