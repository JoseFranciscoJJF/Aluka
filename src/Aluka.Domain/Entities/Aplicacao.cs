using Aluka.Domain.Enums;

namespace Aluka.Domain.Entities;

public class Aplicacao : BaseEntity
{
    public string Nome { get; private set; }
    public string CaminhoExecutavel { get; private set; }
    public string? IconeBase64 { get; private set; }
    public DateTime DataUltimaAtualizacao { get; private set; }
    public bool EstaAtivo { get; private set; }

    /// <summary>
    /// Indica se a aplicação está disponível para configuração de regras.
    /// </summary>
    public bool IsConfigurable { get; private set; }

    public virtual ICollection<RegraAgendamento> Regras { get; private set; }

    public Aplicacao(string nome, string caminhoExecutavel)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome da aplicação é obrigatório.", nameof(nome));

        if (string.IsNullOrWhiteSpace(caminhoExecutavel))
            throw new ArgumentException("O caminho do executável é obrigatório.", nameof(caminhoExecutavel));

        Nome = nome;
        CaminhoExecutavel = caminhoExecutavel;
        EstaAtivo = true;
        IsConfigurable = false;
        DataUltimaAtualizacao = DateTime.UtcNow;
        Regras = new List<RegraAgendamento>();
    }

    public void AtualizarIcone(string iconeBase64)
    {
        IconeBase64 = iconeBase64;
        DataUltimaAtualizacao = DateTime.UtcNow;
        UpdateModificationDate();
    }

    public void MarcarInativo()
    {
        EstaAtivo = false;
        UpdateModificationDate();
    }

    public void Reativar()
    {
        EstaAtivo = true;
        UpdateModificationDate();
    }

    public void AtualizarCaminho(string novoCaminho)
    {
        if (string.IsNullOrWhiteSpace(novoCaminho))
            throw new ArgumentException("O caminho do executável é obrigatório.", nameof(novoCaminho));

        CaminhoExecutavel = novoCaminho;
        DataUltimaAtualizacao = DateTime.UtcNow;
        UpdateModificationDate();
    }

    /// <summary>
    /// Atualiza o estado de configurabilidade da aplicação.
    /// </summary>
    public void AtualizarConfigurabilidade(bool isConfigurable)
    {
        IsConfigurable = isConfigurable;
        UpdateModificationDate();
    }
}