﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebDisk.Database.DatabaseModel
{
    public class Blob
    {
        public Blob()
        {
            BlobId = Guid.NewGuid();
        }
        [Key]
        public Guid BlobId { get; set; }
        [Required]
        public string Localisation { get; set; }

        public DateTime? LastBackupDate { get; set; }

    }
}