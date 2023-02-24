using Random = System.Random;

namespace AdamAsmaca.Helpers;
public class GameHelper
{
    public GameHelper()
    {
        SeciliSoru = RastgeleSoruSec();
        _ekran = new char[SeciliSoru.Length];
        for (int i = 0; i < SeciliSoru.Length; i++)
        {
            _ekran[i] = '_';
        }
        _puan = SeciliSoru.Length * 100;
        _oyunDevamEdiyorMu = true;
    }

    public readonly string SeciliSoru;
    public string[] Sorular = { "zeytinburnu", "kahramanmaraş", "çanakkale", "hayrabolu" };
    private int _hak = 6;
    private int _puan = 0;
    private char[] _ekran;
    private bool _oyunDevamEdiyorMu;

    private string RastgeleSoruSec() => Sorular[new Random().Next(Sorular.Length)];
    public int HakKontrol() => _hak;
    public int PuanKontrol() => _puan;

    public string EkraniYaz()
    {
        string skorBoard = $"Puan: {_puan}\tKalan Hak: {_hak}";
        string ekran = string.Join(' ', _ekran);
        return $"{skorBoard}\n{ekran}";
    }

    public bool TahminYap(string tahmin)
    {
        bool dogruMu = false;
        if (!string.IsNullOrEmpty(tahmin) && tahmin.Length == 1)
        {
            //harf tahmini
            char harf = tahmin.ToLower()[0];
            for (int i = 0; i < SeciliSoru.Length; i++)
            {
                if (SeciliSoru[i] == harf)
                {
                    dogruMu = true;
                    _ekran[i] = harf;
                }
            }
        }
        else if (!string.IsNullOrEmpty(tahmin))
        {
            //kelime tahmini
            if (SeciliSoru == tahmin.ToLower())
            {
                dogruMu = true;
                _oyunDevamEdiyorMu = false;
            }
        }

        if (!dogruMu)
        {
            _hak--;
            if (_hak == 0)
            {
                _oyunDevamEdiyorMu = false;
                _puan = 0;
            }
            else
                _puan = (int)(_puan * 0.9);
        }

        if (!_ekran.Contains('_'))
            _oyunDevamEdiyorMu = false;

        return dogruMu;
    }

    public bool OyunAktifMi() => _oyunDevamEdiyorMu;
}