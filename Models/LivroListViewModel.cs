using System.Collections.Generic;

namespace SiteBibliotecaMVC.Models.ViewModels
{
    public class LivroListViewModel
    {
        public IEnumerable<LivroViewModel> Livros { get;  set;  }
    }
}