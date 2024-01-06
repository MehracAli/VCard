namespace VCard.Extenseions
{
    public static class SaveText
    {
        public static void SaveAsText(this string text, string VCardName)
        {
            string folderPath = "D:\\TechNest\\HomeWorks\\VCard\\VCard\\Contacts";
            string fileName = $"contact-{VCardName}.vcf";
            string filePath = Path.Combine(folderPath, fileName);
            File.WriteAllText(filePath, text);
        }
    }
}
