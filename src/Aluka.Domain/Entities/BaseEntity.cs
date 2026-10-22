namespace Aluka.Domain.Entities;

/// <summary>
/// Classe base para todas as entidades do domínio.
/// Fornece propriedades comuns como Id, DataCriacao e DataModificacao.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>Identificador único da entidade.</summary>
    public int Id { get; protected set; }

    /// <summary>Data de criação da entidade (UTC).</summary>
    public DateTime DataCriacao { get; protected set; }

    /// <summary>Data da última modificação da entidade (UTC).</summary>
    public DateTime DataModificacao { get; protected set; }

    /// <summary>
    /// Construtor protegido que inicializa as datas de criação e modificação.
    /// </summary>
    protected BaseEntity()
    {
        DataCriacao = DateTime.UtcNow;
        DataModificacao = DateTime.UtcNow;
    }

    /// <summary>
    /// Atualiza a data de modificação para o momento atual (UTC).
    /// Deve ser chamado sempre que a entidade for alterada.
    /// </summary>
    public void UpdateModificationDate()
    {
        DataModificacao = DateTime.UtcNow;
    }
}