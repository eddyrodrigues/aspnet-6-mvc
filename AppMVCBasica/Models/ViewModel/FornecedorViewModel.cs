﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMVCBasica.Models;

public class FornecedorViewModel
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
    public string Documento { get; set; }
    public TipoFornecedor TipoFornecedor { get; set; }
    public EnderecoViewModel Endereco { get; set; }

    [DisplayName("Ativo?")]
    public bool Ativo { get; set; }

    /* EF Relations */
    public IEnumerable<ProdutoViewModel> Produtos { get; set; }

}