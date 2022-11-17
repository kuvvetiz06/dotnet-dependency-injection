using System;

internal class Program
{
    enum Color
    {
        Siyah = 1,
        Mavi = 2,
        Kırmızı = 3,
        Beyaz = 4

    }
    interface IAraba
    {
        byte TekerSayisi { get; set; }
        Color Renk { get; set; }
        string Model { get; set; }
        string Marka { get; set; }
    }
    class Renault : IAraba
    {
        public Renault(string marka, string model, Color renk, byte tekersayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            TekerSayisi = tekersayisi;
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public Color Renk { get; set; }
        public byte TekerSayisi { get; set; }
    }
    class Fiat : IAraba
    {
        public Fiat(string marka, string model, Color renk, byte tekerSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            TekerSayisi = tekerSayisi;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public Color Renk { get; set; }
        public byte TekerSayisi { get; set; }
    }

    class AracYonetimi
    {
        readonly IAraba _araba;

        public AracYonetimi(IAraba araba)
        {
            _araba = araba;
        }
        public void RenkDegistir(Color renk) => _araba.Renk = renk;

        public void ModelDegistir(string model) => _araba.Model = model;

        public void TekerSayisiDegistir(byte tekerSayisi) => _araba.TekerSayisi = tekerSayisi;

        public string TumOzellikler()
        {
            var arry = new string[4];
            arry[0] = $"{nameof(_araba.TekerSayisi)}:{_araba.TekerSayisi}";
            arry[1] = $"{nameof(_araba.Renk)}:{_araba.Renk}";
            arry[3] = $"{nameof(_araba.Marka)}:{_araba.Marka}";
            arry[2] = $"{nameof(_araba.Model)}:{_araba.Model}";
            return string.Join(Environment.NewLine, arry);
        }
    }

    private static void Main(string[] args)
    {
        var aracYonetimi = new AracYonetimi(new Fiat("Fiat", "500L", Color.Kırmızı, 4));

        Console.WriteLine(aracYonetimi.TumOzellikler());


    }


}