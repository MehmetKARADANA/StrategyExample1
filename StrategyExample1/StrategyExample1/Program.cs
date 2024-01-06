using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Eleman e1 = new Eleman("Beren");

        Eleman e2 = new Eleman("Ceren");

        Eleman e3 = new Eleman("Eren");

        e1.MaasHesapla(new YoneticiMhesap());
        e2.MaasHesapla(new MuhendisMhesap());
        e3.MaasHesapla(new TeknisyenMhesap());

        e1.IzinHesapla(new DepartmanAizinHesap());
        e2.IzinHesapla(new DepartmanBizinHesap());
        e3.IzinHesapla(new DepartmanBizinHesap());

    }
}

class Eleman
{

    public string Name { get; set; }

    public Eleman(string name)
    {
        Name = name;
    }

    public void MaasHesapla(MaasHesap maasHesap)
    {
        Console.WriteLine("{0}'in maası : {1}",this.Name,maasHesap.MaasHesapla());
    }

    public void IzinHesapla(IzinHesap izinHesap)
    {
        Console.WriteLine("{0}'in izini : {1}", this.Name,izinHesap.IzinHesapla());
    }

}
abstract class MaasHesap
{
    public abstract int MaasHesapla();
}

class MuhendisMhesap : MaasHesap
{
    public override int MaasHesapla()
    {//şu an tasarım deseni ile ilgileniyorum direkt bir değer dönderceğim
        return 5000;
       
    }
}

class YoneticiMhesap : MaasHesap
{
    public override int MaasHesapla()
    {
        return 5500;
    }
}

class TeknisyenMhesap : MaasHesap
{
    public override int MaasHesapla()
    {
        return 3500;
    }
}


abstract class IzinHesap
{
    public abstract int IzinHesapla();

}

class DepartmanAizinHesap : IzinHesap
{
    public override int IzinHesapla()
    {
        return 7;
    }
}


class DepartmanBizinHesap : IzinHesap
{
    public override int IzinHesapla()
    {
        return 5;
    }
}
