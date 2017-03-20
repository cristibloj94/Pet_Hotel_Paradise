using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mandatory_Assignment.Infrastructure
{
    public class Utilities
    {
        public static void SortSelectList(List<SelectListItem> selectList)
        {
            ArrayList textList = new ArrayList();
            ArrayList valuesList = new ArrayList();

            foreach (SelectListItem li in selectList)
            {
                textList.Add(li.Text);
            }
            textList.Sort();

            foreach (object item in textList)
            {
                SelectListItem li = selectList.Find(x => x.Text.Contains(item.ToString()));
                valuesList.Add(li.Value);
            }
            selectList.Clear();

            for (int i = 0; i < textList.Count; i++)
            {
                if (valuesList[i].ToString() == "NOT!") // selectedCode.ToString()
                {
                    selectList.Add(new SelectListItem
                    {
                        Text = textList[i].ToString(),
                        Value = valuesList[i].ToString(),
                        Selected = true
                    });
                }
                else
                {
                    selectList.Add(new SelectListItem
                    {
                        Text = textList[i].ToString(),
                        Value = valuesList[i].ToString()
                    });
                }
            }
        }
    }
}