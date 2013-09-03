using System;

namespace Backend.Objects
{
    /// <summary>
    /// Tarkoitettu Documenteille mitä listänään DtcCodeObjekteihin
    /// </summary>
    public class Document
    {
        string Name { get; set; }
        string Description { get; set; }
        string Filename { get; set; }
    }
}
