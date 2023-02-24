using System;
namespace TORO.Shared.Records;

public class produccionRecord
{
    public produccionRecord ()
    {

    }

    public produccionRecord(int iD,  DateTime fechaProd, int vacasProd, int litrosLeche)
    {
      ID = iD;
      VacasProd=vacasProd;
      LitrosLeche=LitrosLeche;
      FechaProd = fechaProd;
    }

    public int ID {get;set;}

    public  DateTime FechaProd {get; set;} = DateTime.Now;
    public int VacasProd { get; set;} 
    public int LitrosLeche {get; set;} 
}