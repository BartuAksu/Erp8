using System.Text.RegularExpressions;

namespace OopGiris;
public class Kisi
{
    //ad, soyad, dogumTarihi, tckn, telefon, email, yas
    //Ad ve Soyad da özel karakter ve sayı olmamalı. Okunurken ilk harf büyük sonraki harfler küçük şekilde gösterilmeli
    //TCKN 11 haneli olmalı ve sadece rakamlardan oluşmalı
    //Telefon 10 haneli olmalı ve sadece rakamlardan oluşmalı
    //Email adresi @ işaretinden sonra en az 2 karakter olmalı ve email kurallarına uygun olmalı asd@asd
    //yas özelliği sadece okunur olmalı

    private string _ad, _soyad, _tckn, _telefon, _email;

    public string Ad
    {
        set
        {
            foreach (char harf in value)
            {
                if (char.IsDigit(harf) || char.IsSymbol(harf) || char.IsPunctuation(harf))
                    throw new Exception("Ad alanına özel karakter veya sayı girişi yapılamaz");
            }
            _ad = value;
        }
        get
        {
            return _ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower();
        }
    }
    public string Soyad
    {
        set
        {
            foreach (char harf in value)
            {
                if (char.IsDigit(harf) || char.IsSymbol(harf) || char.IsPunctuation(harf))
                    throw new Exception("Soyad alanına özel karakter veya sayı girişi yapılamaz");
            }
            _soyad = value;
        }
        get
        {
            return _soyad.ToUpper();
        }
    }
    public DateTime DogumTarihi { get; set; }

    public string Tckn
    {
        get => _tckn;
        set
        {
            if (value.Length != 11)
                throw new Exception("TCKN 11 haneli olmalıdır");
            foreach (char harf in value)
            {
                if (!char.IsDigit(harf))
                    throw new Exception("TCKN sadece rakamlardan oluşmalıdır");
            }
            _tckn = value;
        }
    }
    public string Telefon
    {
        get => _telefon;
        set
        {
            if (value.Length != 10)
                throw new Exception("Telefon Numarası 10 haneli olmalıdır");
            foreach (char harf in value)
            {
                if (!char.IsDigit(harf))
                    throw new Exception("Telefon Numarası sadece rakamlardan oluşmalıdır");
            }
            _telefon = value;
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (!Regex.IsMatch(value, emailRegex, RegexOptions.IgnoreCase))
                throw new Exception("Doğru bir email adresi giremediniz");
            _email = value;
        }
    }

    public int Yas => DateTime.Now.Year - this.DogumTarihi.Year;
}



