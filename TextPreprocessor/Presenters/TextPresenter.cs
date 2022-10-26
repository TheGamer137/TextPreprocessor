using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TextPreprocessor._Repositories;
using TextPreprocessor.Models;
using TextPreprocessor.Views;

namespace TextPreprocessor.Presenters
{
    public class TextPresenter
    {
        private readonly ITextView _view;
        private readonly ITextRepository _repository;
        private BindingSource _bindingSource;
        private IEnumerable<Text> _textsList;

        public TextPresenter(ITextView view, ITextRepository repository)
        {
            _bindingSource = new BindingSource();
            _view = view;
            _repository = repository;
            _view.CreateNewDictionaryEvent += CreateDictionary;
            _view.UpdateDictionaryEvent += UpdateDictionary;
            _view.DeleteAllWordsEvent += DeleteAllWords;
            _view.SearchWordEvent += SearchWord;
        }

        private void SearchWord(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteAllWords(object sender, EventArgs e)
        {
            _repository.DeleteAllWords();
        }

        private void UpdateDictionary(object sender, EventArgs e)
        {
            var newList = new List<string>();
            foreach (var word in _view.Words)
            {
                string[] strings = word.Split(null);
                newList.AddRange(strings);
            }
            var duplicates = newList.GroupBy(x => x).Where(g => g.Count() > 2)
                .Select(r => new { r.Key});
            var model = new Text();
            foreach (var word in duplicates)
            {
                model.Word = word.Key;
            }
            _repository.AddWordsToDictionary(model);
        }

        private void CreateDictionary(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Title = "Выберите файл словаря",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Multiselect = false,
                Filter = "Текстовые файлы | *.txt",
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (_repository.CheckEncoding(dialog.FileName))
                    {
                        List<string> words = File.ReadAllLines(dialog.FileName).ToList();
                        var newList = new List<string>();
                        foreach (var word in words)
                        {
                            string[] strings = word.Split(null);
                            newList.AddRange(strings);
                        }
                        var duplicates = newList.GroupBy(x => x).Where(g => g.Count() > 2)
                            .Select(r => new { r.Key});
                        var model = new Text();
                        foreach (var word in duplicates)
                        {
                            model.Word = word.Key;
                        }
                        if (_repository.CheckIfDatabaseExists())
                         {
                             _repository.AddWordsToDictionary(model);
                         }
                         else
                         {
                             _repository.CreateDatabase();
                             _repository.AddWordsToDictionary(model);
                         }
                    }
                }
                catch (Exception exception)
                {
                    _view.IsSuccessful = false;
                    // _view.Message(exception.Message);
                }
            }
        }
    }
}