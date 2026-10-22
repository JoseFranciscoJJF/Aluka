using Microsoft.Data.Sqlite;
using System.Diagnostics;

namespace Aluka.WinForms;

public static class DatabaseMigrator
{
    public static void EnsureColumnsExists()
    {
        try
        {
            var dbPath = Path.Combine(AppContext.BaseDirectory, "aluka.db");
            
            // Verificar se a base de dados existe
            if (!File.Exists(dbPath))
            {
                Debug.WriteLine("Base de dados não encontrada. Será criada pelo EF.");
                return;
            }

            var connectionString = $"Data Source={dbPath}";

            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            // Verificar quais colunas já existem
            var existingColumns = new List<string>();
            using (var cmd = new SqliteCommand("PRAGMA table_info(RegraAgendamento);", connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    existingColumns.Add(reader.GetString(1)); // Column name
                }
            }

            // Se a tabela não existir, sair
            if (!existingColumns.Any())
            {
                Debug.WriteLine("Tabela RegraAgendamento não encontrada.");
                connection.Close();
                return;
            }

            // Definir as colunas que precisam ser adicionadas
            var columnsToAdd = new Dictionary<string, string>
            {
                { "NotificarExecucao", "INTEGER NOT NULL DEFAULT 0" },
                { "TipoNotificacao", "TEXT NOT NULL DEFAULT 'Information'" },
                { "AtrasoNotificacaoSegundos", "INTEGER NOT NULL DEFAULT 0" },
                { "DuracaoNotificacao", "TEXT NOT NULL DEFAULT 'Short'" },
                { "UltimaNotificacao", "TEXT" }
            };

            var addedCount = 0;
            foreach (var (colName, colType) in columnsToAdd)
            {
                if (!existingColumns.Contains(colName))
                {
                    var sql = $"ALTER TABLE RegraAgendamento ADD COLUMN {colName} {colType};";
                    using var cmd = new SqliteCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    Debug.WriteLine($"✅ Coluna adicionada: {colName}");
                    addedCount++;
                }
            }

            connection.Close();

            // =========================================================
            // REMOVIDO: MessageBox - apenas log
            // =========================================================
            if (addedCount > 0)
            {
                Debug.WriteLine($"✅ Migração concluída: {addedCount} colunas adicionadas.");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"❌ Erro na migração: {ex.Message}");
            // Não mostrar MessageBox - silêncio total
        }
    }
}