using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TextPreprocessor.Views
{
    public interface ITextView
    {
        string Id { get; set; }
        List<string> Words { get; set; }
        string SearchValue { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        
        //Ивенты
        event EventHandler SearchWordEvent;
        event EventHandler CreateNewDictionaryEvent;
        event EventHandler UpdateDictionaryEvent;
        event EventHandler DeleteAllWordsEvent;

        //Методы
        void SetDictionaryListBindingSource(BindingSource wordsList);
        void Show();
    }
}