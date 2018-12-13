using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FairyGUI;
using FairyGUI.Utils;

public class TabCtr
{
    /*------------------------------- 我是漂亮的分割线 ----------------------------------------- */

    // Tab字典
    private Dictionary<object, List<GObject>> tabDict = new Dictionary<object, List<GObject>>();

    // 当前打开的Tab
    private object tabIndex;

    // Tab历史记录
    private List<object> tabHistorys = new List<object>();

    // 获取Tab的显示对象列表
    public List<GObject> GetTabDispyaObjects(object tabIndex)
    {
        if(tabDict.ContainsKey(tabIndex))
        {
            return tabDict[tabIndex];
        }

        List<GObject> list = new List<GObject>();
        tabDict.Add(tabIndex, list);
        return list;
    }


    // 注册Tab内容
    public void RegisterTab(object tabIndex, GObject displayObject)
    {
        List<GObject> list = GetTabDispyaObjects(tabIndex);
        list.Add(displayObject);
    }

    // 设置Tab，显示或者隐藏
    private void SetTabVisiable(object tabIndex, bool visiable)
    {
        List<GObject> list = GetTabDispyaObjects(tabIndex);

        for(int i = 0; i < list.Count; i ++)
        {
            list[i].visible = visiable;
        }
    }

    
    private void SetOpenTab(object tabIndex)
    {
        this.tabIndex = tabIndex;
        foreach (var kvp in tabDict)
        {
            if(kvp.Key != tabIndex)
            {
                SetTabVisiable(kvp.Key, false);
            }
        }

        SetTabVisiable(tabIndex, true);
        OnOpenTab(tabIndex);
    }

    virtual protected void OnOpenTab(object tabIndex)
    {

    }


    // 打开Tab
    public void OpenTab(object tabIndex)
    {
        tabHistorys.Add(tabIndex);
        SetOpenTab(tabIndex);
    }


    // 返回上一次Tab
    public void BackTab()
    {
        if(tabHistorys.Count > 0)
        {
            object lastIndex = null;
            for(int i = tabHistorys.Count - 1; i >= 0; i --)
            {
                if(tabHistorys[i] == this.tabIndex)
                {
                    if(i > 0)
                    {
                        if (tabHistorys[i - 1] != this.tabIndex)
                        {
                            lastIndex = this.tabHistorys[i - 1];
                        }
                    }
                }
            }

            if(lastIndex != null)
            {
                OpenTab(lastIndex);
            }
        }
    }


    // 清除Tab历史记录
    public void ClearTabHistorys()
    {
        this.tabHistorys = new List<object>() ;
    }

    /*------------------------------- 我是漂亮的分割线 ----------------------------------------- */
}
