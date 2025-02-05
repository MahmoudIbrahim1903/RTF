/*
 * 
 * 
Console.WriteLine("====================================================");
Console.WriteLine("\n");

var alphaInput = @"世界 世界 안녕하세요 شسيش Asda m’appelle c'est bientôt Grüß estás giornata Привет Γειά się नमस्तe tested in almost all languages and numbers 世界 世界 안녕하세요 شسيش m’appelle Asda bientôt Grüß estás giornata Привет Γειά się नमस्ते V V VI VII VI四 五 삼 사 오 육  六 七 八 二 三 四 五 test samples À Á Â Ã Ä Å Æ Ç È É Ê Ë Ì Í Î Ï Ð Ñ Ò Ó Ô Õ Ö Ø Ù Ú Û Ü Ý Þ ß à á â ã ä å æ ç è é ê ë ì í î ï ð ñ ò ó ô õ ö ø ù ú û ü ý þ ÿ Ā ā Ă ă Ą ą Ć ć Ĉ ĉ Ċ ċ Č č Ď ď Đ đ Ē ē Ĕ ĕ Ė ė Ę ę Ě ě Ĝ ĝ Ğ ğ Ġ ġ Ģ ģ Ĥ ĥ Ħ ħ Ĩ ĩ Ī ī Ĭ ĭ Į į İ ı Ĳ ĳ Ĵ ĵ Ķ ķ Ĺ ĺ Ļ ļ Ľ ľ Ŀ ŀ Ł ł Ń ń Ņ ņ Ň ň ŉ Ō ō Ŏ ŏ Ő ő Œ œ Ŕ ŕ Ŗ ŗ Ř ř Ś ś Ŝ ŝ Ş ş Š š Ţ ţ Ť ť Ŧ ŧ Ũ ũ Ū ū Ŭ ŭ Ů ů Ű ű Ų ų Ŵ ŵ Ŷ ŷ Ÿ Ź ź Ż ż Ž ž Α Β Γ Δ Ε Ζ Η Θ Ι Κ Λ Μ Ν Ξ Ο Π Ρ Σ Τ Υ Φ Χ Ψ Ω α β γ δ ε ζ η θ ι κ λ μ ν ξ ο π ρ σ τ υ φ χ ψ ω А Б В Г Д Е Ё Ж З И Й К Л М Н О П Р С Т У Ф Х Ц Ч Ш Щ Ъ Ы Ь Э Ю Я а б в г д е ё ж з и й к л м н о п р с т у ф х ц ч ш щ ъ ы ь э ю я あ い う え お か き く け こ さ し す せ そ た ち つ て と な に ぬ ね の は ひ ふ へ ほ ま み む め も や ゆ よ ら り る れ ろ わ を ん ㄱ ㄲ ㄴ ㄷ ㄸ ㄹ ㅁ ㅂ ㅃ ㅅ ㅆ ㅇ ㅈ ㅉ ㅊ ㅋ ㅌ ㅍ ㅎ α β γ δ ε ζ η θ ι κ λ μ ν ξ ο π ρ σ τ υ φ χ ψ ω ע ב ג ד ה ו ז ח ט י כ ל מ נ ס ע פ צ ק ר ש תअ आ इ ई उ ऊ ऋ ए ऐ ओ औ अं अः क ख ग घ ङ च छ ज झ ञ ट ठ ड ढ ण त थ द ध न प फ ब भ म य र ल व श ष स ह  پ چ ژ گ ک ی";

var alphabeticRegex = @"^[\p{L}\p{M}\s'\u2019\u0027]+$";

var alphabeticResult = System.Text.RegularExpressions.Regex.IsMatch(alphaInput, alphabeticRegex);

Console.WriteLine($"result is: {alphabeticResult}");


Console.WriteLine("\n");
Console.WriteLine("====================================================");
Console.WriteLine("\n");

var alphaNumericInput = @"世界 世界 안녕하세요 شسيش Asda m’appelle c'est bientôt = Grüß estás giornata Привет Γειά się नमस्ते 4V V VI VII VI四 五 삼 사 오 육  六 七 八 ໒ ໓  二 三 四 五 ၃ ၄ ၅ ၆ ၇ ໔  ៤ ៥ ៦ ៧ ໕ ໖ ๓ ๔ ๕ ๖ ๗   ೨൨ ൩ ൪ ൫ ൬ ೩ ೪ ೫ ೬ ೭ ௨ ౨ ౩ ౪ ౫ ౬ ౭௩ ௪ ௫  ੧ ੨ ੩ ੪ ੫ ੬   ১ ২ ৩   ૬ ૭৪ ৫ ٠ ١ ٢ ٣ ٤ ٥ ٦ ٧ ٨ ٩  १ २ ३ ४ ५ test samples";

var alphaNumericRegex = @"^[\p{L}\p{M}\p{N}\s'\u2019\u0027]+$";

var alphaNumericResult = System.Text.RegularExpressions.Regex.IsMatch(alphaNumericInput, alphaNumericRegex);

Console.WriteLine($"Numeric result is: {alphaNumericResult}");


Console.WriteLine("\n");
Console.WriteLine("====================================================");

 numbers are '೩', '໔', '๕', '4', '၄', '३', '౩', '౫', '໒', '৪', '௫', '๓', '೨', '౨', '५', '๖', '๗', '১', '२', '೭', '၃', '७', '੬', '൨', '੩', '੪', '៦', '៧', '౬', '၆', '౭', '൪', '৩', '੧', '೫', '੨', '೬', '๔', '௨', '६', '൬', '২', '၅', '૭', '८', '௩', '៥', '൩', '१', '०', '४', '೪', '९', '၇', '൫', '௪', '౪', '໖', '৫', '໕', '੫', '៤', '૬', '໓'
*
*
*/



/*
 * 
 * 
var password = "P@ssw0rd2025";

// Create an instance of PasswordHasher
var passwordHasher = new PasswordHasher<object>();

// Hash the password
var hashedPassword = passwordHasher.HashPassword(null, password);

Console.WriteLine($"Original Password: {password}");
Console.WriteLine($"Hashed Password: {hashedPassword}");
*
*
*/


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RFT;
using RFT.Data;
using System;
using System.Text.Json;

var services = new ServiceCollection();

// Register DbContext and Repository
services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=.;Database=RTF_Db;User ID=sa;Password=M@hmoud1903;"));

services.AddScoped<LocationsRepository>();

// Build the service provider
var serviceProvider = services.BuildServiceProvider();

// Use the DbContext and Repository
using (var scope = serviceProvider.CreateScope())
{
    var repo = scope.ServiceProvider.GetRequiredService<LocationsRepository>();

    var locations = repo.GetLocations();
    var groupedLocations = Helper.GroupLocations(locations);
    var x = Helper.GetHeatPoints(groupedLocations);

    Console.WriteLine(JsonSerializer.Serialize(x));
}