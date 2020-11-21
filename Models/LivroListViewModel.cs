using System.Collections.Generic;

namespace SiteBibliotecaMVC.Application.ViewModels
{
    public class LivroListViewModel
    {
        public IEnumerable<LivroViewModel> Livros { get;  set;  }
    }
}