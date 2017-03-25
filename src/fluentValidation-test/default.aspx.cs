using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace fluentValidation_test
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btn1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Name = txtName.Text;
            employee.Age = Int32.Parse(txtAge.Text);
            employee.Email = txtEmail.Text;
            EmployeeValidator employeeValidator = new EmployeeValidator();
            ValidationResult validationResult = employeeValidator.Validate(employee);
            if (!validationResult.IsValid)
            {
                lblError.Text = string.Empty;
                foreach (var error in validationResult.Errors)
                {
                    lblError.Text += error.ErrorMessage + "<br />";
                }
            }
            else
            {
                lblError.Text = "You are ready to go!";
            }
        }
    }
}