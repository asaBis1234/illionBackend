using Illion0.Context;
using Illion0.Entities;
using Illion0.Interface;

namespace Illion0.Services
{
    public class SDataBaseUpdate : IDataBaseUpdate
    {

        private readonly IllionDBContext _illionDBContext;

        private IIllion _illion;

        public SDataBaseUpdate(IllionDBContext illionDBContext, IIllion illion)
        {
                _illionDBContext=illionDBContext;
             _illion=illion;
        }
        public async Task updateCustomerList(string taxpayerId, string institution)
        {
            try
            {
                var getAccList=await _illion.ListCustomerAccount(taxpayerId, institution);

                if (getAccList.Item1.accounts != null) {
                    Accounts Check_cuAcc = _illionDBContext.accounts.FirstOrDefault(x => x.TaxPayerId == taxpayerId && x.institution == institution);

                    if (Check_cuAcc == null)
                    {
                        _illionDBContext.accounts.Add(getAccList.Item1);
                        _illionDBContext.SaveChanges();
                    }
                    else
                    {
                        _illionDBContext.Entry<Accounts>(Check_cuAcc).CurrentValues.SetValues(getAccList.Item1);
                        _illionDBContext.SaveChanges();
                    }


                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
