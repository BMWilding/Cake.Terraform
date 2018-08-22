﻿using Cake.Core.IO;

namespace Cake.Terraform.Show
{
    public class TerraformShowSettings : TerraformSettings
    {
        public FilePath OutFile { get; set; }
        public FilePath PlanFile { get; set; }
        public OutputFormat OutputFormat { get; set; } = OutputFormat.PlainText;
    }
}