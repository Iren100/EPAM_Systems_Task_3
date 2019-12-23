using System;
using FlexCel.XlsAdapter;
using System.Reflection;
using System.IO;
using FlexCel.Report;
using BillingSystem.Data;
using System.Collections.Generic;
using System.ComponentModel;

namespace Reports
{
    public static class Report_Excel
    {
        // создаем путь к файлу шаблона

        public static void ReportForExcel(ICollection<CallHistory> collection)
        {
            FlexCelReport flexCelReport = new FlexCelReport();

            string fileName = AssemblyDirectory + "\\Report.xlsx";

            XlsFile result = new XlsFile(true);

            result.Open(fileName);

            IList<CallHistory> list = (IList<CallHistory>)collection;

            flexCelReport.AddTable("table", ToDataTable(list));

            flexCelReport.Run(result);

            String docPath2 = AssemblyDirectory + "\\NewReport.xlsx";
            result.Save(docPath2);

            Console.WriteLine("Файл выгружен в " + docPath2);
        }

       private static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        /// <summary>
        /// Преобразует списочный тип данных в DataTable
        /// </summary>
        /// <param name="data">список(коллекция) элементов</param>
        /// <returns>Данные в виде DataTable</returns>
        private static System.Data.DataTable ToDataTable<T>(IList<T> data)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            PropertyDescriptorCollection propertyDescriptorCollection =
                TypeDescriptor.GetProperties(typeof(T));
            for (int i = 0; i < propertyDescriptorCollection.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = propertyDescriptorCollection[i];
                Type type = propertyDescriptor.PropertyType;

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    type = Nullable.GetUnderlyingType(type);

                dataTable.Columns.Add(propertyDescriptor.Name, type);
            }
            object[] values = new object[propertyDescriptorCollection.Count];
            foreach (T iListItem in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = propertyDescriptorCollection[i].GetValue(iListItem);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
