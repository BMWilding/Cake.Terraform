using System.Collections.Generic;

namespace Cake.Terraform.Destroy
{
    /// <summary>
    /// The terraform destroy command is used to destroy the Terraform-managed infrastructure.
    /// </summary>
    public class TerraformDestroySettings : TerraformSettings
    {
        /// <summary>
        ///     Gets or sets the input variables. https://www.terraform.io/intro/getting-started/variables.html
        /// </summary>
        public Dictionary<string, string> InputVariables { get; set; }

        /// <summary>
        /// Variables file
        /// https://www.terraform.io/docs/configuration/variables.html#variable-files
        /// </summary>
        public string InputVariablesFile { get; set; }

        /// <summary>
        /// If set to true, then the destroy confirmation will not be shown.
        /// </summary>
        public bool Force { get; set; }
    }
}