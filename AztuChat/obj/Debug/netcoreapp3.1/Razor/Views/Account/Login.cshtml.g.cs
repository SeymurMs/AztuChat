#pragma checksum "C:\Users\devel0per\source\repos\AztuChat\AztuChat\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8345570be4b84d6864a854256b0fed14c755cb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\devel0per\source\repos\AztuChat\AztuChat\Views\_ViewImports.cshtml"
using AztuChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\devel0per\source\repos\AztuChat\AztuChat\Views\_ViewImports.cshtml"
using AztuChat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\devel0per\source\repos\AztuChat\AztuChat\Views\_ViewImports.cshtml"
using AztuChat.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8345570be4b84d6864a854256b0fed14c755cb3", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37ae7614143a2c68c70abe01c77ae33ea0a92321", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter your name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter your UserName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter your password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("registor-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("reg-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\devel0per\source\repos\AztuChat\AztuChat\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Account";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
        body{
      margin:0;
      padding:0;

    }
    .back{
      background-image:url(""data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMSEhUTEhIVFRUWGBcXGBgXGBoXFxcXFxcXGBUXGBgYHSggGBolGxgYITEhJSkrLi4uFx8zODMtNygtLisBCgoKDg0OGxAQGy0lHyUtLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLf/AABEIALcBEwMBEQACEQEDEQH/xAAbAAACAgMBAAAAAAAAAAAAAAABAgAFAwQGB//EADYQAAEDAgUCBAQGAgIDAQAAAAEAAhEDIQQFEjFBUWEGInGRE4GhsTJCwdHh8CNSYvEUgpJD/8QAGgEAAgMBAQAAAAAAAAAAAAAAAAECAwQFBv/EADERAAICAQQBAwIFBAIDAQAAAAABAhEDBBIhMUEFIlETYRQycYGhI5Gx8BXBQlLRM//aAAwDAQACEQMRAD8A60OcTBM29l4HNlb+f3O9tQ1R+lZG9ztjXI2WY4tcS5sjrt/QutovU3pY042v15M+p0iy1TosnZ1azQPWVs/53LJe2K/yUL02N8tlfiM6eRZ0enP7LFk9X1U+E6R0MPp2KL5VlJUzcfusCwN2zorCaLM1axjnfmc4/sFe9O5SS+Cx49zRrYalUxEkeWmN3f7HmOqsm4YfuybcYfqb4x4DhTcZcQBrO7oECe8DdNueZ/Uff/zgxSwbVcejawdVtz8/kpSg5cLsoye1cm1iKbhZzYO453VebDPT5Nkvgqw5Y5FcSvx1Nzg0h+jvvYqCcV4s24HTqiozLAhpH+So9xjkD+QtMMn2SNkJN+DCyjDgBYyIm6nCdST+AyR3Ra+Su8QYU16r6hY5ryRpbbTAjdxM/M9V146nD3ZxPwedLbXHy");
            WriteLiteral(@"bmVZcWMAm49pXK1GZzk7R18UFjgooObY4hul4jv/dksWPc7RZSXJTZHVArF21o9yCT9F39Eqts896w90VFeWVVfHGtVdUJsTIHYfhHtCsk9zstwY1jxqKNrDs8odxcH3Kg0X2WIpNA+VlEa5FwuCrPu1sTyf2CnHE2ZsurjHhHY4Yvp0IeYiBbYXGyh6g3HTSS/Qx6FKerTf3Zo5nmOtmhjXOI6AlebxY6rdwenjDa7ZUZL4fOJFRxfpc0/hIvG+p0n8PFgdl2ccFJcMwavUywy/L38lJVrVaTjDBYxJbqaCPUEH9ldDFHzyYZ6vLNpflLPJswc4gGJie15++/z2WPVYYpbjpaTK5Jxfg6B7KpaYLQOdyVy04J+Tb7UcjinltbzHa0jvsupBJ4+DBrX4ZZUMfOlpdud+w4PzhZ5YauSRhTLijVa/cj3WKUZQ5Jlrh8YKYkkEdu3ZURT3WiuX3KrF+Im06Zb5w8jycQJs49F6+OZPFx3Rhw6Ryn17fN+TWo5/Ue0se4OBETABv3CyZdRka2t/wAHTh6fhi98VTX3NSphg4kxusyk6Lth6MyYgFs9II/dec2xbt2UMV4O5v8AO3tCjKv0JJGuysDNjYxxG02gqTht6LNrFeATz3/hOMnFEoRZV5jhXAeR0jod/dXYpL/yRvhJPspnYR7yb3vN7AAEkk8QAuhii5PbFEsmaGOO5j0MrGoa3agDs0hwmCYJGxiTCuy4smODkUY9bDI9sey/dW0s0tY4gCIaPouRFe5uXke23bZx+Zl5ddjx1sbLqadRqk0XZHUa7LfwlRqVXNdPkDoubugSQDzFjfv0XS0ujcsiy/DOB6hqoQg8S7aO+xuFNRoggOG0/ZbddoFqYfEkcbSat4Jc8pnOYnCOd/ijz3N7RAmR1vb5rhYNDkc5Y5Kml/c7q12OG3InwUGOzVrW6QIPM7k9T0WeOnk3tkduKT918GbLsvcwa6hmo+AB/qHbD1Khmlu9sOhOafC6M9VgNVzP+AI9Q6D91BQey");
            WriteLiteral(@"/uCftTNXE1vgm92n6FWRjKf6kqUkc7nOO1EwZ+q3afE12RySSVGhhMM92oMN3DSOgnc/JdzDFqFHmNVlj9a/CMmK8PPo0TVLhaJA6Egb+ylLHtjZPBrFky7KMNCsQxoiXHjqqlzwbpyUPczfLKrGgvYdJ6T5T1PZRnjaDDqoTdLg6TwvX3GouFoBi3XiVPA3ymYvUIx4lFK/J1WNw4dSdLZGkmPS6s1MbwyVeGYtLNxzxadclC7GsbTOowIsNl4yMJbqSPXuLb4Katlb3tNUksYdm/mc3q7oFsjqI43sXL8jk1J0yrLHzDZB0yYt5WkG/UbWWuGXZymRy4YZFUkZckwUuJH4tzPT9lDVZnXIsWGGLhF5icb8Fulw3FiFhhDf0W7U+Tgc/qyepJ+y72jhXJzdfO+DDlldwgTPrvfhW5YRb6MeOKZ0mFqkiQ6D1mCqHji1TXBoUS/wGNNRsPi1vU9VxdRhjin7SEkiszDJS7zU/WCevdacOsS4mWY51wys0vpnS4AHoenVa04zVo0xlaNgMcbwEXEbieiGttG3B6dl5t4ub8mZRAMaQJcJG0jZNQtc9D+n8DsouIENJLrwBJE8GOVe9NKb/pqyLyxi/czQzClU2a1znXOkgi3PFohWQ0c+bTL8ObGnd8Mwsy0kaqjwOzR+p/ZZ/qpL2L+5qeRdRQmJpAU3aJAiJP5uoWvSal48icijPieaO2+fBS1G66jHN8u4e3nW0Fo9Nz7BdbUyrC66OboL+tU/Fl2MZVpt84t/sBI+YGy4H04SftO1sjJ8FBm+ZyZB9v2W3T4KJ8RR1Pht2qkwHoNrR0I78r1uBf01Z4fWV9aVfJ1GEqzY7jfv0I7H9CrTG18D1KIJDouJg9juP70ScVaflBFtLb4Zxninw03WcQxxB/F8PhzxEafvHKwanSppyj2dzQeoyjthk/L8/ByozZ+sEzLTzY2suN+EaXB6NajG/0NZ+av+MH7SCPeSprTJQoX147kvAHPq1dtpiSYA/X2UoYFEhk1c");
            WriteLiteral(@"I8AOWS8NDpaAJMRe8hv0/tloTUVb7Odk1Mp8ItsFgW07jrz9lpwaiU5bTl58UVFyLnEYJlamabhIN94uNj8lvcdyoxYszxTUkc/gMie2sC4bWHfuq4Y9pu1Gq+quDtKmEbol0Af33Ty5ceKO6bpGXDCeSW2Ctmhh6TGvHe4kbnt3WBep6V20+vt/g6EtBqaXH8/5LennFIeVxcP/WbfKU4eq6eS8/2B+lajtU/3OZzXLqbHjEB4fSP4Rxq4E7EbrFq9OoQ3Ynwzr6LVTm3hyKpIwvzjVJdsP7K5X4Zro37EjVwFZpbVqn80MaOw3/vZW5YtOMPjkFbdmGliBR+HU7eYf8STP6H5KzZ9S4/7Y5dGvn2ODp6G/oFPTYuSGSShGjiK+ILnSYn7LuwgoqkcHJNzds3sEIAHzVcy7H0WtIif09r9lU0XplvlNW5uuZq42yqXLZaPrO0dLG+6xxgt/I4L5ObqSTJMmeb+5XXaUVSNfCRn/wDJjhV7PuNs7rK2OqucPydePQLmZIqKsjlagk/JduwQ+GWXM+5PX7eyrgk+DI8j3bjNh6Rb0+Scltl7WVyal2bAxZdqpF0y2CPzAOBErr6HLmypwk7jX7mTLGONqaXk4TFmsyuKFSQDJ1cGmOR6rn6jR/h7b/b7nodPnx5ob4f6zZzDEh2lgsJaI9p+lvmsWONXJlkINcsbGsAOoRPKI5HLhkYJWzRr5y2I52Vq08myax0zksVDn2tJ2C7ekx7nTMWtz/TjuR3mU4ynRpg1HtaO5v8AIbldtNRVHlnjyZZe1WZafjegHyWPGkmHAAh7ebWINgY7RyofXXk0/wDG5KtNFPmniyvWcdDzSYNg0wT3Lhc/QKEsjZtwaHFjXKtmDIs6pUazn4hznEt0td+MiTLrTPA2TxySfJDWaeWRJY6OmxODp4hgeG2cJGoQY+4VzSkjj75Y5Un0UVbJW05OmZgXuLTwsGqhspo6GDUznxJmmMMBYCAOAsLmarsy0qIG5VLbYD0aDnPvAbwt+");
            WriteLiteral(@"kljVfJj1G9/odLg8PAC6q6OdI2zhgPNFt0pNRVvwWQTlJRXk0jW1HzGBB0jp/Oy8VrdbPVSV9Lo9XptLHBH29+TUxdVuqnHDm/Ux+qohFc/obIJ0zSx5A+IelvTmP71VkE7SLIdKyl/8o0qYFSXMedTqZ20nkdHcyutp8z37e4+SnU4FkTmuJ+H5MGY5PA1U6ksdcA7ie66MtLD8yfByI+o5Etk1yVxe4AMiwssUsNS5OhHWwcVToD2veIK0YtJLvoz5vUoL2rklbA/EGl09+pWvFpow67Obn188nHg1qmSsYNLWGTyZMdpUdRlWNULTqWR22auBZwRcdVBuzoRVF/k+Xiq0zvwfT/tcvU6iWOdolZv0Mv+EAsks31GKqLLDUt5229J5VEp000CdGtUyDU4tDnCbg2vz0XT0OX8TPbLshqdXLFDcjcHh5dr8LD4OI9dkbts6DIMtYGtq7vcN+g6D23Xmc75o9FqM0m9vhF0CsylyZWR1QAgSJMwOTG8D5qVgkVWcYptCpSq/mJLI/2bEmfTj1WvRZXjnuRYsX1oSh/qN/GU6eLo+V2+zou13p9CF6PLihqcVPr/AAcnFmyaXNfx2edZphMVhz5qRdBs5vmB72uPnC48/T5R4rg9Jj9SwTVp/szVzDOHAAOBE9bLOtA4PkuhqcUl7WUtfElx8syeOq6Gn0rfZh1WvUOuy4yLKXucHOG2wXUxYVBcHB1OqlkfJbeLMNSZSDnNPxCIYQI/+nREdt/qjMopcktBLJKXtfBzmFaSATEkLOdpG6aYAgpobdci4jJazXAvY4DcHTv8xZTakjPHU4peT0HwtWc6iG1GuaW28wiRwr4S49xw9TCP1G4dG1i8E135fnylPFGfaKYZHDplFjMsIcYb8wLLk6jTyjJyiuDoYs6aSb5MeHyRzzYgR1VWmw/XvmqLM2f6aXFm0zJKodEtAjfefTotmLQU/ezPPVprgt8LgtIgmV0oxUVSMTbk+SZmdNOBu636rm+r5/padr/24Oj6V");
            WriteLiteral(@"hWTOpPxyc7invAggge4nqCvKQS8HrYqL6KKtjDrE9QfYrZHEtvBbVKhmVg8+Yy2ZLep4B7I2uPQqvor84ra3dT0HC0aeO1EZcKkWOV1w6gNUS0aSOumwPrELqSzx+ltbPN58Mo6hv8AcAwGo2FlzFlaLHTVD0sug9Ztcro6bNklJGPNGKiWDMsA4XWSMDkPi8F/jMDa6x+oRvA/sadHKsqOfGUte7VteDHIXBWqlCNHdouaTGUQ4gQAAPUn9Vkip55KPlsqnLbGzcpZa5w+K499PQLp6r076WDdDtdmHFrN2TbIwXaTbiYXG7N5Y4R0Fh4JB9P4Vuhy/S1MZP5r+/Bm1UHPFJHQfCC9yebqyjwGZPqtFDDtgMaGuqni0S1vfgn2XmsejeSTbPWar+k98u34LnBUBRpNYbBjQJJ4AuSfqsms008WS30yiGZZm35OC8aZ2yrWouw9WTS1+Zsi7i2IdzsdrXWjT4nGLUl2dfS4nCL+ouHRoYjM62Ia0Vnl+gkh0AOEiCLASDbfonxB8IuWnhG9nB6H4Yrt+A0xDY3GwPOofljrcW4XfwTU4Jo8hq8bhllGRZ4jD6grzHycD40cKRFNobqcCTIktHBHff2VGfJXB0NDp3JOT6KHI6lKkxwqNLnzLRG4O/m2F1DHmUY8luo0k8k048I6fw9mNMyKpDHT5RBiIAAnrKsxZk+zNqtFJfk5SLfxTk7q9ANpgF2tpuYAAmT9fqrMsXKNIo0OeOHJukVdTwt8HC1KtSDUa0aQNm+Ye5OyreLbFvybseueXPGK4ichW1vcQ20bz9o9/ZUpnVfyer+FPiHDsbWaQ5oiT+YRY+32WuF1yeZ1Lg8rcOiwq4RpIOm4tPZTpdmdyfQ4pDokxoR9JHDCXdiCgAZAA/ZVLFGMtyVMsc5NUxixWkQFiBldntP/AByN2mfXg/dcz1bB9XT/AKcnT9Ky7M9fPByOMxzouIHcj915fHjTfZ66MVdnP4h4c6YldHFUH7hZVKUWoPkzUsPE2gEnn");
            WriteLiteral(@"jgE24UMmROVoeOMlFKT5MGLcGjS2B6C6eNOTthJpIbJzaD1JVuRHF1Ek5to6fCMkBZmn4MzZvAaBaIJG+wk3Mrp6HNKMlDwZNRBNbvJhwuNY+pUpAw+mQC3kgtDg4dRDo7FdpS8GF4pKKl4ZkxtNxZpZpBNiXEwBybb/RVajC8uNwvslgyrHNMp24ZzXjUHlnLpDeLaWNBMT/sQsD0OnxrdJcLts6MdRkye1P3PpIz18IHuEa9DTN4uetv1XHy6zFjk3p1Xizq49E3H+u7+y/7JisU5hbFR2kuaHCd2kx8lXHV58kZRlJ8muGjwJ7lBWvsPmuDc0gs9Y4jp2WXFNflmGyGRfcuMkrMdSaWxt5pAnV+YH5r2Okw4ViW1Llfuzx2teaGaSm+n+xZMfAAGwstvCMW5lT4eoupU9J8riSTH0EjsvEZvUMkpbMEqXz8ntcuCE5b5KzZeZeWkkgtmCZBv0KyuWdrZuf8AcsWOCSkkV+YZXSq+QU2TyYA095F1HHly4ne5lqfFyMGEyPCUqjTUa8tiCNRc3V/sYvG9rrsaX1DT5Jr6ka/fgzaj8VLG1jkv8Ovg7DA5VRpnVSbonhrjpPfTMfNekhihHmKo81lzZJ8Td/r2DMarMO3WXtYP9SbO9ALg9wPWVKc4x7YsWKeTiKPMM4xgxNV9TbUbTYwPwiOwhYXLdJs9BjxfTgoo1WsHNlFpslwjJQBc6GAu9AT9tlOOOTKMuoxx7Z6hkOHqii34ztTo6bdp5XQgmlyeayyjOTcVSLU0gRBUmQSXZR4nwtQdU+Jpg6gXRs6NpChsjdmharKofTT4L0MAsFMzMLggkwQkNCuYgGrFLEA/kXSgLFKAsx4mmHNIIkEQotJqmWKTi012edeIPD7mEuYZb6XaP1XIz6L6dyjyvg9Ho/VVk9k+H8lBT8pAPJXPlFuztRnGlyPWxcmyjDE2OeWMTTewnddLBpW+WcrVeoRXEeS3ybBHe6vloouDvs4stW932LivVrUwDSpCod41QfYi6");
            WriteLiteral(@"w6fBJZUn2XylCUHb4OVzTxJidZmkymf9XNcT8i4j6BdJJQf5aslDTY5r8zZT0MzeKxrPdLiQZFtoFo4gQnbcrNH0YxxuC6PS8LmDKjQ4OEWtIJk7SPtPT2uzZ4YsbnLpfycfDppzy7Irl/wbAw7qkybdJXj9V6hk1En8fB6jBp8Wniklz8mpUxopEtJlruTu0+vRZ443NWuzbt3KznMxxZLy0dRHuF0MOOo2y3wdTXxDntDGjzOG/DR1XOikvdLpFKgovcypx+AFBv+MlrgZL/zErZp9VkeS/4ISxQyp7l2PQ8XtDQKgdrFjER6r1GPWw2rd2eVz+kZVkag+PBvPzxj22Ol42PXsV45aaUX0esWGnwa2D8RMqag2m/4rBEyC0iYMjcbbrfm0sYY0138mLT5J5Mri6UUXOV4gBsAFzzd0de54C5zdeDRlhb+wmZ0azgYLGD1VcFCEraHilBGTw1mrqdJ7az9ZZLgGeY6IEj5Gfdet9O1Klja+Pk4vqmlvKpRVJ/5OXx2KdWe5xAY0mQ2S53aSbofulZuxQ+nFIwfCAF1JIk2GmwEbTHHoo2waR1nhDEi7TFtgWgOjrP8Lbgm3xZxPUMMYNOK7+52lMhaTk0ZAgRHBMGRAJhKRIBCBiQgXkQhBEUtQKqAAgcSObKCb56NHEYeUEU6KHGZExxJ0CTzF1W8cX4NMM+ReWUuJ8PgbBKOKK6RLJq5vtsTD5GOVPaUrLZb4XAaYspUQcjefTAE8jpulsTdvsi5tJr5PNvGWeCufhU6ZAa7zPcNLiRPlAIkAd7298+Walwjs6DSPEt8nyznHUyxhcd+FUjpvg6fwbhJe6oHHTABnk78due65Pq2VKKh57NWmXcjscfT0sBDyCei4kYVTZphK3TRx2Y4p7iQ75Ryupixxjyi58dEy/DOj4rh5RAEmNV7x1AgyeFoeJzVIxZNZHE6fLLrBZqwAwb7OcbD0E9LKnV6XGsSil7jPpZ5s+Vyf5f9o1sVmjHm0vPRt/ssmPTyiueDq");
            WriteLiteral(@"qNFLWw1UuJ+GRPoPut0Z40qspkpN9HdVsB8VsvpsH/J0Of9P3XLjkcVw7Iqai+DlMRgn0MT8SkJabxG45B6CZ9gupg1EMkOX0Zsunk5XFd/wdJgRUawOLS5h30Hb1G65ORRbdfybJbfyvsbF4mk4eV5b1uf1S2ST4QoRkuzn30SagDKhl0j9fay7Hp9ynTVGf1CW3Du+DYqYMM3Lnun8X5Z6AbWXUmtrpHP0+RzVyf7C0qZe4U9pMDeYHP6JYk5MlqcixwtdlnmOUGnHlLhEgj7eqlLBLdSKoa6DhcuGbOQA6pDSB3V+DE4dnP12pjkSrwd1hSYC0nK5ZstQMcIDsBQJshQN0KSgLBCA7AQgGuAID7CkICrIUEmYnp0Qc0a72ShIjbfRrvoSgLcjF/4wQFEFAJirklSlZCFJHkmb0ScTWJv/lfxwHED7LA1cmep08ksMX9l/gy4LKTWcGuaQzn+hThDnkp1GpW2ost/DeBfh2OpRLmVHieu2k//ACQvPerwrKm3xR1tDljPCi5r4eq9svqNaOBElc2M41aVm1SinwjlcxpBro1E36Qujik5LosMmY1fiMYA7RoYGuB/MWwPL2i/crpY8kK7ODmwZFkftMeU0qjfxtGncTeAdrFYdXOLftfJ1NLCUYbWXxrQLAeoXOavsvUXfJS4jEO1G5WqMFRZZ0eXZkHAlx8ot6n9lilBwdUUTh8GZtZtSrECNJ/hSvbygpxia7q78O/S27Tdvp0+Sbgpcoe1ZFyaWPxNGtJe2HdRYqWOOTH0+CSi48GnlVHTWEGRwV3vTo7ve/BxfVstLZ8nW18J8Rq621M4H1GnaMeXZLFTWZJRCCjwgyZ5T5Z1DMNIghSop3MalgGt2CYmblNkIEZGoChwgZECoDggTQpQIiBoCB1YIQFICAsUoFZjLUyFCEIELpSH4E0oBUKWJhSQjmWP0QxpryUuF8N0mkkjUSZJduSbknuSoRxpGiWqnN/Y3xgGjYKVIipMqM3p6HgiwcPqP4hec9awt");
            WriteLiteral(@"yjPxR6L0fLGWNxXdlPj8bAPmj7rjYsTb6O7GJV4bKn1na3ghu4B3I6xwFsnnjjW2PLG5I3HYX8enZgF+53H0VCm6TfkkpdWWuWhtSnETA2PThQk3GXJRkuLKTM2aSSyx6FXYXuVMuT45NJmDc8BxP4r+67WP0+copo4mX1jHjm4O+Bs2wT8GQAS6n/tHMmx6GFHVaLa7J6D1JZI1Lsw0c50vB62XPlpbjR0nmg+DJjcz+KNOxF2noo4tO4OxvJFLgrTiJMPNx0XQx6RvldGDLrox4b5Oi8O4ZxIcQuvhxLHGked1WolllbO7wdKyvMNlhRooGbdNqBmaEASEESAIGNKB2RAuyFAPhAIQFKhYQIQoIPgEoCyFAxHFAqACgGLCYkEpE2xEEVQhCkRZNKRKNCuYixuIpakNcGnmOCFRhafUHoeqqzYY5Y7ZGjS6iWGe6BwdfA/BqTUBdH4ZFj37rzuq0+SD2RVL5PXaXVQywTT5FfnRuSsX4VmxOBkwOMii6d3kk/p9B9UssG5pLpDpNpmE4w0w1zT2PoU1j3tpkm0+zDVcajpOw3/AGW7Q6XfKvHk5/qGrWnxNrvwbTSYs0xxt+pXpUqXCPEzdybk1fkz+LcUyqWtY5rmgajBtNwAT1HTuuZq8yk1tfB39BppY03JcnHV8FyT7LKsh0XE1cRQeAPM6P7tCnCcb6RBxk/Jc+FcGxztLydZNp2Pb1W3TZYt7X2c3X4ZwW+PS7PRcuwOnZb6o4jm2y9w7EAnwbjUBuMgKQ7HDkw3chQKyakhoQOv/eyAHDkDRNSBsDnoEBzkEX2Y3OQDIHQgjHgBegkK8/3/AKQJ8AKYmgSgKI5yB1wABFkdpIRY6QpaiwpgKKE2xUUG4h2RRNS44KjNMO1wIIBChPbXJZhlNSuPZ5/meBAcdOwO24XncuSH1Hs6PVabJPYt/Zpv1cqpUa/rGWm2RF/kFF8Fc87rgy4XVqEiWi4HBPU9dlsw6tYo0kczU4PrPc3yXLalvwE/Mfuty9ShX");
            WriteLiteral(@"Rx5emTvtfyYMVh2yY7XHouO5tnqIXXJo1KQO424hFtFu0NLJXVpFNurSB0kdJVuGGTI3tVlWXPjw/8A6OiwyfwtUNSXzSDYII3J408Dbf0XQw6OcncuDm6r1TFGNY/dZ3mFw8AAkuI5MSfYALqxVKjz8mm7qv0NtjUyHJlaEBRkCQ1RJTFyPKSG2gOCGC4BukSvgLdkBYsoBskwnRFsQTb5IoVsJm/94QSskJBQXhAxNKAFLf78kCohbZBLxYsIIp2gEnogVjFAmQoJ+AJifCFJTK2wFAJ+SszVr4OloI9bx6LBrY5pQccaOho54dyc2cnjqJdciPlC868coPa07/Q9DHLFq01X6lNWaA6IU0nVl69ytGejTnbbk/oq5SISRt/BHTgfqqkyG0b4Z7JrImKkYnNMmdzH/SvXJq4rgwtY6DIIvMkR29lKXZOMovpj4as6m7U0ua4cjb+R2Usc5QdxYsuOE47ZK0egZY9z6bXPABI4P17L02CUpQTl39jxWqjCGVqHRvtCtKUzIAkSYYTItEQRIgdJBBTI+RpSJX4CCgE6CSlRJsWUyIC5AE1JDTQJRQXwM0pEkEoADkxsxuKERYpTIvqgykST8ClCEAlIfIQgFwAhA2IQpFbRIRYtoNM8IZJRZX5lQZpJcLBUZ8kYRcpGrBjlKW1HGYgNeS4NAk+Uegj+V5fPlc8jdHqNPj+nFRNem7T/AHdV7dxc42bbBz2WeXHBWK7VwpJqhGF9iZIG30WqKZduVHZMywVcMxp/FpEHubwvQvSxyYVF90eaWslizua6sqaHh2o68tEGLzwsMPTJSjy6ZuyesRi6irOny6iWU2tIgi1jI7GV2MEJQgoy8HCzzWSbkvJtKwqsZAWghyA3cgLkEGyByYXbGlAySgLGBSGmQIJLkRBDlElAN0LKYl2GUiYzXJUSTGLkDsGpArAUhiJkSIGAoEGEiVCoFQYQS5oUlANglArBqTDc2YMVSLmuaOQRfuFVlVwa+xowyqa/U4g4Z3QnfYf3l");
            WriteLiteral(@"eWhjlJ0keneaKXZY5FlwcCXtBkbH6ei7ei0ijjbkuzi67WN5EoPhGrisPpcW7QfouHnwPHJpnXxZVOCkBlC25WrBoozgpSuzLl1MozaS/kum+HWDEB//wCcE6eA+RHyuTC7X4OCy764/wCzlf8AITeD6bfP/R0IWsw8ETEwFMg+ASmQbZAUCVsMpA+BS5Mg34A16KBSYzaiKHGRkaUiyIQ5A030MHKLLE6BKYrbAgW0CCNAcUDkwtKRKPQyCVWJKZHpkLkhthQxpASFTAgAoJAQBEByKgVgTEKUEWyFsiENJ8MmnJcoxYjCh3p02CiopdFjk35FpUQ1Oipv5MGZYBlZkOseHDcfwoZcEciqRbg1UsLuIjcsYApKC8FTyW7ZvalYZx2uRRJS5HDkUT3BlAWK4oIyaC0oBEcgJIUoI0I5s7J2Vyjb4I0QnYlGuR2O5SaLE0uTMDZRLlyrCDZBJdAlArrgUuQQbASgbGhFkkrQjjCEQlwQPRRJSCDKOhx93YPmgikEJMmuBkiXBDAQN0gEoBsCYq4AEhEcgbFG6ZBdjFIm6EJUkVtiAJlZD6oBt0AFAk0LCBbmMglQzUDigtcgFyMgOgEIE1YWoGuEMglQqBcC6kURuuBjsgk0mjGBClZQo0ZWPUWXRkO1IsS+AoBgKA4ASgTdImtAbhHJkZciwgVDEJDaCAgdJB+aCXJEh0M4JE2mgIGAhBBqgFSIt0AFAJ2TSgSQ0KJOqAUxNIWFIhQHBBFxRjcmVtmMlMhYQUiV8mRrikWJsJCAcWgphQ8qJZyiByAtBJQS4EcE7K5JoUFMgiOQhSEcSmVtvodhSZZFsyAlItV3wPqSJfqBxQJiSmLkUuhFEN1csIfKBqQSUDI1yAUuA6kDsgKQw6kqJKXwM1yRNNMhKYnSYHulFClK+gFMTZCIQRraAIBMZIs4FJTINikpkLFKCDMZ9VIrpgQFIExwokr2sdo5QTS8mQFBPl8EIRYOLCDCBrgAKCK+SAoGnyMSlRNsCLIV5AmKk");
            WriteLiteral(@"+SFAmgoG1QzSkySDKCV0BxQRboVMj2uTGSmiuTYofCdEVLaQ1ClQObGY+yGiUJOgzJSH2xgUErDyglXIwKRKwjugf6gLkhNoBKZFtEJTAgKATISkDaA4pkZMxgplaCgkIUEGrYUWTEnsgXgbWiiW5UNKRLihi8FKiblGRA3lAbfJJTFaCgOEQvQG8UFBDkKCXfQCUERt0D7IUDoXUnRGyFyQW6E1JkLEc5MhJshKAv5IYQRdPgDTCGC9pkY9JlkZJj6gkWOSXIrqiKISmMXIJ7g7oDsAQCthhAiIBWQlA2SUEWxXOTE2hdSBWgEygXYAEAotELkEuRgUiyvkhKAELuyCDlXgLHBFMlGUXwOXQkScq6ICmJElAhSUEeRQVIjY7ahSaHGbGe9JInKdoSUyvyEuQNyACgF8i6igOQGyEQlwAFAIVxUiEmYnPupJFMpNMZtWyi0WxnwO16Q1LkJPsgbtjBA10MSkTYdSQ7aJKYDB6RJSsOpA7CXIG2Yy5MrbA9yCMjEXJlfFj6+yiW2QvQG4HxEBvMgKRoBKCDEcUyttk1JivkY1Eie4mtAbrBrQKwa0CchQ9MimHWgLobUgZC5AMBTINCpD6BKATCUdA1bIgFyI4J2QaXQulFkVBWI4piboamUMIjakid10O1x9kmSjbMgKVlu3yRxQJg1oEmEPQOwlyBvgUuhMi3XLFNVOiDmrIXWSH2jHKZEQ1EyDfI2pInQpqJEj//Z"");
      background-repeat:no-repeat;
      background-size:cover;
      background-position:center;
      width:100%;
      height:665px;
      -webkit-filter: blur(50px);
      position:fixed;
    }
    .register-form{
      background-color:#fff;
      background-opacit");
            WriteLiteral(@"y:0.4;
      position: fixed;
      top: 50%;
      left: 50%;
      transform: translate(-50%, -50%);
      width:30%;
      height:400px;
      border-radius:10px;
      box-shadow:0px 0px 100px #000;
      z-index:2;
    }
    .reg-text{
      position:absolute;
      font-family:sans-serif;
      font-size:15px;
      text-transform: capitalize;
      top:20px;
      left: 50%;
      transform: translate(-50%, -50%);
      color: #383838;

    }
    .reg-form{
      position:relative;
      top:70px;
      margin:40px;
      height:200px;
    }


    .text input{
      width:100%;
      heiht:0px;
      margin:10px auto;
      border:none;
      outline:none;
    }
    hr{
      position:relative;
      top:-10px;
      opacity:0.5;
    }
.terms label{
  display: block;
  padding-left: 25px;
  font-family:sans-serif;
  font-size:12px;
  color:grey;
  text-indent: -18px;
}
button{
  border:none;
  text-transform:uppercase;
  margin:40px 0px 0px 0px;
  p");
            WriteLiteral(@"adding:8px;
  color:#fff;
  background:#5b98f5;
  border-radius:5px;
  outline:none;
  float:right;
  cursor:pointer;
}
button:hover{
  transform: scale(1.1);
}
.largen:active{
  transform: scale(2);
}
</style>

  <div class=""back""></div>

  <div class=""register-form"">
        <h1 class=""reg-text"">register</h1>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8345570be4b84d6864a854256b0fed14c755cb323324", async() => {
                WriteLiteral("\r\n\r\n      <div class=\"text\">\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8345570be4b84d6864a854256b0fed14c755cb323623", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 100 "C:\Users\devel0per\source\repos\AztuChat\AztuChat\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FullName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n      <hr>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8345570be4b84d6864a854256b0fed14c755cb325435", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 102 "C:\Users\devel0per\source\repos\AztuChat\AztuChat\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n      <hr>\r\n       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8345570be4b84d6864a854256b0fed14c755cb327246", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 104 "C:\Users\devel0per\source\repos\AztuChat\AztuChat\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PassWord);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n      <hr>\r\n       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8345570be4b84d6864a854256b0fed14c755cb329057", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 106 "C:\Users\devel0per\source\repos\AztuChat\AztuChat\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Image);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n      <hr>\r\n      </div>\r\n      <div class=\"terms\">\r\n      <label for=\"terms\"><input class=\"largen\" type=\"checkbox\" name=\"terms-one\">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Recusandae, velit.</label>\r\n      </div>\r\n\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8345570be4b84d6864a854256b0fed14c755cb331020", async() => {
                    WriteLiteral("register");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
