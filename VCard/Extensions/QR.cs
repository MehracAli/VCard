using IronBarCode;

namespace VCard.Extensions
{
    public static class QR
    {
        public static void GenerateQR(this string contact, string VCardName)
        {
            IronBarCode.License.LicenseKey = "IRONSUITE.MEHRAJVM.CODE.EDU.AZ.441-4BD63EBD6F-CMMTW63GJHZ5FO-2Z3X2HYLIH5S-IIAWC657T42W-QTXHMXUOJCBZ-RDVJHA7ZQWHJ-7TEP7JZUWUOK-JLR5YG-TVE6IJVTBMOLUA-DEPLOYMENT.TRIAL-XHLAKB.TRIAL.EXPIRES.05.FEB.2024";
            var qrCode = QRCodeWriter.CreateQrCode(contact);
            qrCode.SaveAsPng(@$"D:\TechNest\HomeWorks\VCard\VCard\QRs\QR-{VCardName}.png");

        }
    }
}
