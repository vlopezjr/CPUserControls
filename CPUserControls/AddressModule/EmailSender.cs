using CPUserControls.CPMail;
using CreateCustomer.API.Entities;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CPUserControls.AddressModule
{
    internal static class EmailSender
    {
        internal static void EmailSalesTaxServiceFailure(string serviceName, BLAddress address, Customer customer)
        {
            var custId = customer == null ? address.CustId : customer.Id;

            string subject = $"Error calculating Sales Tax: {custId} - Address: {address.Data.Name}";
            string body = $"Unable to retrieve Sales Tax Schedule information from the {serviceName} Tax Service. Default Sales Tax has been applied. Please check tcpZipTax and tsmPostalCode.{Environment.NewLine}Customer: {address.Data.Name} - {custId} {Environment.NewLine}{Environment.NewLine}Current address: {Environment.NewLine}{address.Data.Line1}{address.Data.Line2}{Environment.NewLine}{address.Data.City}{Environment.NewLine}{address.Data.Zip} {address.Data.State}{Environment.NewLine}{address.Data.Country}";

            if (Debugger.IsAttached)
            {
                MessageBox.Show(subject + Environment.NewLine + body);
                return;
            }

            ServiceSoapClient client = new ServiceSoapClient();
            client.Email("operations@caseparts.com", "dev@caseparts.com", subject, body, false, "", "");
        }
    }
}
