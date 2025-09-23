var todosDias = new Disponibilidade
{
    Dias = new List<int>
    {
    (int)DayOfWeek.Sunday,
    (int)DayOfWeek.Monday,
    (int)DayOfWeek.Tuesday,
    (int)DayOfWeek.Wednesday,
    (int)DayOfWeek.Thursday,
    (int)DayOfWeek.Friday,
    (int)DayOfWeek.Saturday
},
    HoraInicio = new TimeSpan(0, 0, 0),
    HoraFim = new TimeSpan(23, 59, 59),
};
Console.WriteLine("Todos Os Dias: {0}", todosDias.EstaDisponivel());

var feijoada = new Disponibilidade
{
    Dias = new List<int>
    {
        (int)DayOfWeek.Wednesday,
        (int)DayOfWeek.Saturday
    },
    HoraInicio = new TimeSpan(11, 0, 0),
    HoraFim = new TimeSpan(15, 30, 59),
};
Console.WriteLine("Feijoada: {0}", feijoada.EstaDisponivel());