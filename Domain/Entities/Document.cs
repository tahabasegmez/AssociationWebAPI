using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Domain.Entities
{
    public abstract class Document
    {
        public int Id { get; set; }

        public string RegistrationNumber { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public string FolderPath { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string FileNumber { get; set; } = string.Empty;

        public DocumentType FileType { get; set; } = DocumentType.NoInformation;

        public string ExtraInformation { get; set; } = string.Empty;
    }
}
