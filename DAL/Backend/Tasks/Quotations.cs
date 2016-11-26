﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frapid.Configuration;
using Frapid.Configuration.Db;
using Frapid.DataAccess;
using Frapid.Framework.Extensions;
using MixERP.Purchases.DTO;
using MixERP.Purchases.QueryModels;

namespace MixERP.Purchases.DAL.Backend.Tasks
{
    public static class Quotations
    {
        public static async Task<long> PostAsync(string tenant, Quotation model)
        {
            using (var db = DbProvider.Get(FrapidDbServer.GetConnectionString(tenant), tenant).GetDatabase())
            {
                var awaiter = await db.InsertAsync("purchase.quotations", "quotation_id", true, model).ConfigureAwait(false);
                long quotationId = awaiter.To<long>();

                foreach (var detail in model.Details)
                {
                    detail.QuotationId = quotationId;
                    await db.InsertAsync("purchase.quotation_details", "quotation_detail_id", true, detail).ConfigureAwait(false);
                }

                return quotationId;
            }
        }

        public static async Task<List<QuotationResultview>> GetQuotationResultViewAsync(string tenant, QuotationQueryModel query)
        {
            //Todo: The following query is incompatible with sql server
            const string sql = "SELECT * FROM purchase.get_quotation_view(@0::integer,@1::integer,@2, @3::date,@4::date,@5::date,@6::date,@7::bigint,@8,@9,@10,@11,@12);";

            var awaiter = await
                Factory.GetAsync<QuotationResultview>(tenant, sql, query.UserId, query.OfficeId, query.Supplier.Or(""), query.From, query.To,
                    query.ExpectedFrom, query.ExpectedTo, query.Id, query.ReferenceNumber.Or(""),
                    query.InternalMemo.Or(""), query.Terms.Or(""), query.PostedBy.Or(""), query.Office.Or("")).ConfigureAwait(false);

            return awaiter.OrderBy(x => x.ValueDate).ThenBy(x => x.Supplier).ToList();
        }
    }
}