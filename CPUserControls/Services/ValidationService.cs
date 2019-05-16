using CPUserControls.AddressModule;

namespace CPUserControls.Services
{
    public class ValidationService
    {
        UPSOnline.UPSOnlineSoapClient upsProxy;
        public ValidationService()
        {
            upsProxy = new UPSOnline.UPSOnlineSoapClient();
        }

        internal BLAddress ValidateAndClassify(BLAddress address)
        {
            string addr1 = address.Data.Line1 ?? "";
            string addr2 = address.Data.Line2 ?? "";
            string city = address.Data.City ?? "";
            string state = address.Data.State ?? "";
            string zip5 = address.Zip5 ?? "";
            string zip4 = address.Zip4 ?? "";

            int status;
            int classification;
            int count;

            int result = upsProxy.ValidateClassifyAddress(ref addr1, ref addr2, ref city, ref state, ref zip5, ref zip4, out status, out classification, out count);

            if (result != -1)
            {
                address.Data.Line1 = addr1;
                address.Data.Line2 = addr2;
                address.Data.City = city;
                address.Data.State = state;
                address.Zip5 = zip5;
                address.Zip4 = zip4;

                address.Data.Residential = (short)classification == 2 ? (short)1 : (short)0;
                address.IsValidated = true;
                return address;
            }
            address.IsValidated = false;
            return address;
        }

    }
}
