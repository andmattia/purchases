﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.Mapper.Decorators;
    using Frapid.WebsiteBuilder;
    using MixERP.Purchases;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Quotation/Index.cshtml")]
    public partial class _Views_Tasks_Quotation_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_Quotation_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Tasks\Quotation\Index.cshtml"
  
    ViewBag.Title = "Purchase Quotations";
    Layout = ViewBag.PurchaseLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n<style>\r\n    .modal iframe {\r\n        width: 100%;\r\n        border: none;\r\n    " +
"    height: 700px;\r\n    }\r\n</style>\r\n\r\n<div");

WriteLiteral(" class=\"ui attached page segment\"");

WriteLiteral(" style=\"min-height: 100%; padding: 3em;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui huge title header\"");

WriteLiteral(">Purchase Quotations</div>\r\n    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"ui basic buttons\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" id=\"AddNewButton\"");

WriteLiteral(" href=\"/dashboard/purchase/tasks/quotation/new\"");

WriteLiteral(" class=\"ui basic add new button\"");

WriteLiteral(">Add a New Purchase Quotation</a>\r\n        <div");

WriteLiteral(" class=\"ui icon top left pointing dropdown basic button\"");

WriteLiteral(" id=\"ExportDropDown\"");

WriteLiteral(" tabindex=\"0\"");

WriteLiteral(">\r\n            <span>\r\n                Export\r\n            </span>\r\n            <" +
"div");

WriteLiteral(" class=\"menu\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"header\"");

WriteLiteral(">\r\n                    Export This Document\r\n                </div>\r\n            " +
"    <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createDoc();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file word outline blue icon\"");

WriteLiteral("></i> Export to Doc\r\n                </a>\r\n                <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createXls();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file excel outline green icon\"");

WriteLiteral("></i> Export to Excel\r\n                </a>\r\n                <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createPDF();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file pdf outline red icon\"");

WriteLiteral("></i> Export to PDF\r\n                </a>\r\n            </div>\r\n        </div>\r\n  " +
"      <a");

WriteLiteral(" id=\"PrintButton\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"print()\"");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(">\r\n            Print\r\n        </a>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"ui stackable form segment\"");

WriteLiteral(" id=\"Annotation\"");

WriteLiteral(" style=\"\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"six fields\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" class=\"date\"");

WriteLiteral(" data-persist");

WriteLiteral(" placeholder=\"From\"");

WriteLiteral(" id=\"FromInputDate\"");

WriteLiteral(" title=\"From\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" class=\"date\"");

WriteLiteral(" data-persist");

WriteLiteral(" placeholder=\"To\"");

WriteLiteral(" id=\"ToInputDate\"");

WriteLiteral(" title=\"To\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" class=\"date\"");

WriteLiteral(" data-persist");

WriteLiteral(" placeholder=\"Expected From\"");

WriteLiteral(" id=\"ExpectedFromInputDate\"");

WriteLiteral(" title=\"Expected From\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" class=\"date\"");

WriteLiteral(" data-persist");

WriteLiteral(" placeholder=\"Expected To\"");

WriteLiteral(" id=\"ExpectedToInputDate\"");

WriteLiteral(" title=\"Expected To\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Id\"");

WriteLiteral(" id=\"IdInputText\"");

WriteLiteral(" title=\"Id\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"ReferenceNumber\"");

WriteLiteral(" id=\"ReferenceNumberInputText\"");

WriteLiteral(" title=\"ReferenceNumber\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"six fields\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Supplier\"");

WriteLiteral(" id=\"SupplierInputText\"");

WriteLiteral(" title=\"Supplier\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Terms & Conditions\"");

WriteLiteral(" id=\"TermsInputText\"");

WriteLiteral(" title=\"Internal Memo\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"InternalMemo\"");

WriteLiteral(" id=\"InternalMemoInputText\"");

WriteLiteral(" title=\"Internal Memo\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"PostedBy\"");

WriteLiteral(" id=\"PostedByInputText\"");

WriteLiteral(" title=\"PostedBy\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Office\"");

WriteLiteral(" id=\"OfficeInputText\"");

WriteLiteral(" title=\"Office\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field hidden\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"UserId\"");

WriteLiteral(" id=\"UserIdInputText\"");

WriteLiteral(" title=\"UserId\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field hidden\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"OfficeId\"");

WriteLiteral(" id=\"OfficeIdInputText\"");

WriteLiteral(" title=\"OfficeId\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui green button\"");

WriteLiteral(" id=\"ShowButton\"");

WriteLiteral(">Show</div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n    <table");

WriteLiteral(" id=\"JournalView\"");

WriteLiteral(" class=\"ui table segment\"");

WriteLiteral(@">
        <thead>
        <tr>
            <th>Actions</th>
            <th>Id</th>
            <th>Supplier</th>
            <th>Value Date</th>
            <th>Expected Date</th>
            <th>Ref#</th>
            <th>Terms</th>
            <th>Internal Memo</th>
            <th>Posted By</th>
            <th>Office</th>
            <th>Posted On</th>
        </tr>
        </thead>
        <tbody></tbody>
    </table>
</div>

<div");

WriteLiteral(" class=\"ui large advice modal\"");

WriteLiteral(">\r\n    <i");

WriteLiteral(" class=\"close icon\"");

WriteLiteral("></i>\r\n    <iframe></iframe>\r\n</div>\r\n<script>\r\n    function displayTable(target," +
" data) {\r\n        target.find(\"tbody\").html(\"\");\r\n\r\n        function getCell(tex" +
"t) {\r\n            const cell = $(\"<td />\");\r\n\r\n            cell.text(text || \"\")" +
";\r\n\r\n            return cell;\r\n        };\r\n\r\n        function getActionCell(id) " +
"{\r\n            const cell = $(\"<td />\");\r\n\r\n            const checklistAnchor = " +
"$(\"<a title=\'Checklist Window\'><i class=\'list icon\'></i></a>\");\r\n            con" +
"st checklistUrl = \"/dashboard/purchase/tasks/quotation/checklist/{id}\";\r\n       " +
"     checklistAnchor.attr(\"href\", checklistUrl.replace(\"{id}\", id));\r\n\r\n\r\n      " +
"      const journalAdviceAnchor = $(\"<a title=\'View Quotation\'><i class=\'print i" +
"con\'></i></a>\");\r\n            journalAdviceAnchor.attr(\"href\", \"javascript:void(" +
"0);\");\r\n            journalAdviceAnchor.attr(\"onclick\", \"showQuotation(\" + id + " +
"\");\");\r\n\r\n            cell.append(checklistAnchor);\r\n            cell.append(jou" +
"rnalAdviceAnchor);\r\n\r\n            return cell;\r\n        };\r\n\r\n\r\n        $.each(d" +
"ata, function() {\r\n            const item = this;\r\n\r\n            const row = $(\"" +
"<tr />\");\r\n\r\n            row.append(getActionCell(item.Id));\r\n            row.ap" +
"pend(getCell(item.Id));\r\n            row.append(getCell(item.Supplier));\r\n      " +
"      row.append(getCell(item.ValueDate));\r\n            row.append(getCell(item." +
"ExpectedDate));\r\n            row.append(getCell(item.ReferenceNumber));\r\n       " +
"     row.append(getCell(item.Terms));\r\n            row.append(getCell(item.Inter" +
"nalMemo));\r\n            row.append(getCell(item.PostedBy));\r\n            row.app" +
"end(getCell(item.Office));\r\n            row.append(getCell(item.TransactionTs));" +
"\r\n\r\n            target.find(\"tbody\").append(row);\r\n        });\r\n    };\r\n\r\n    fu" +
"nction processQuery() {\r\n        function getModel() {\r\n            const form =" +
" window.serializeForm($(\"#Annotation\"));\r\n            return form;\r\n        };\r\n" +
"\r\n        function displayGrid(target) {\r\n            function request(query) {\r" +
"\n                const url = \"/dashboard/purchase/tasks/quotation/view\";\r\n      " +
"          const data = JSON.stringify(query);\r\n                return window.get" +
"AjaxRequest(url, \"POST\", data);\r\n            };\r\n\r\n            const query = get" +
"Model();\r\n\r\n            const ajax = request(query);\r\n\r\n            ajax.success" +
"(function(response) {\r\n                displayTable(target, response);\r\n        " +
"        target.removeClass(\"loading\");\r\n            });\r\n\r\n            ajax.fail" +
"(function(xhr) {\r\n                alert(JSON.stringify(xhr));\r\n            });\r\n" +
"        };\r\n\r\n        const view = $(\"#JournalView\").addClass(\"loading\");\r\n\r\n   " +
"     displayGrid(view);\r\n    };\r\n\r\n    $(\"#ShowButton\").unbind(\"click\").bind(\"cl" +
"ick\", function() {\r\n        processQuery();\r\n    });\r\n\r\n    function showQuotati" +
"on(id) {\r\n        $(\".modal iframe\").attr(\"src\", \"/dashboard/reports/source/Area" +
"s/MixERP.Purchases/Reports/Quotation.xml?quotation_id=\" + id);\r\n\r\n        setTim" +
"eout(function () {\r\n            $(\".advice.modal\")\r\n                .modal(\'sett" +
"ing\', \'transition\', \'horizontal flip\')\r\n                .modal(\"show\");\r\n\r\n     " +
"   }, 300);\r\n    };\r\n\r\n    window.loadDatepicker();\r\n\r\n    setTimeout(function()" +
" {\r\n        processQuery();\r\n    }, 1000);\r\n</script>");

        }
    }
}
#pragma warning restore 1591
