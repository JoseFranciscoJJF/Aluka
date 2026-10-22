namespace Aluka.Domain.Enums;

/// <summary>
/// Representa os dias da semana como flags para permitir combinações.
/// </summary>
[Flags]
public enum DiasSemana
{
    /// <summary>Domingo.</summary>
    Domingo = 1,
    
    /// <summary>Segunda-feira.</summary>
    Segunda = 2,
    
    /// <summary>Terça-feira.</summary>
    Terca = 4,
    
    /// <summary>Quarta-feira.</summary>
    Quarta = 8,
    
    /// <summary>Quinta-feira.</summary>
    Quinta = 16,
    
    /// <summary>Sexta-feira.</summary>
    Sexta = 32,
    
    /// <summary>Sábado.</summary>
    Sabado = 64,

    /// <summary>Dias úteis (Segunda a Sexta).</summary>
    DiasUteis = Segunda | Terca | Quarta | Quinta | Sexta,

    /// <summary>Fim de semana (Sábado e Domingo).</summary>
    FimDeSemana = Domingo | Sabado,

    /// <summary>Todos os dias da semana.</summary>
    TodosOsDias = DiasUteis | FimDeSemana
}