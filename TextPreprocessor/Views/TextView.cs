using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TextPreprocessor.Views;

namespace TextPreprocessor
{
    public partial class TextView : Form, ITextView
    {
        public TextView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Создание словаря
            createDictionaryButton.Click+=delegate{CreateNewDictionaryEvent?.Invoke(this, EventArgs.Empty);  };

            //Обновление словаря
            updateDictionaryButton.Click+=delegate{UpdateDictionaryEvent?.Invoke(this, EventArgs.Empty);  };
            
            //Очистить словарь
            deleteDictionaryButton.Click += delegate
            {               
                var result = MessageBox.Show("Вы уверены что хотите удалить все слова??", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteAllWordsEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

        }

        public string Id { get; set; }

        public List<string> Words
        {
            get { return new List<string> { richTextBoxDictionary.Text };}
            set { richTextBoxDictionary.Text = value.ToString(); }
        }
        public string SearchValue { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public event EventHandler SearchWordEvent;
        public event EventHandler CreateNewDictionaryEvent;
        public event EventHandler UpdateDictionaryEvent;
        public event EventHandler DeleteAllWordsEvent;

        public void SetDictionaryListBindingSource(BindingSource petList)
        {
            throw new NotImplementedException();
        }
    }
}