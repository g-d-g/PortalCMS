﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.CMS.Entities.Entities.Themes
{
    public class Theme
    {
        [Key]
        public int ThemeId { get; set; }

        [Required]
        public string ThemeName { get; set; }

        [Required]
        public bool IsDefault { get; set; }

        public int? TitleFontId { get; set; }

        [ForeignKey(nameof(TitleFontId))]
        public virtual Font TitleFont { get; set; }

        public int? TextFontId { get; set; }

        [ForeignKey(nameof(TextFontId))]
        public virtual Font TextFont { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public DateTime DateUpdated { get; set; }
    }
}