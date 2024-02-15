using System.Collections.Generic;

namespace Zelda
{
    public interface IJRiverAPI
    {
        bool Connected { get; set; }
        string MCVersion { get; set; }
        string Library { get; set; }
        string LibraryPath { get; set; }
        int APIlevel { get; set; }
        bool ReadOnly { get; set; }

        bool Connect();

        void Disconnect();

        List<JRField> GetFields();

        bool CreateField(JRField field);

        IEnumerable<JRPlaylist> GetPlaylists(bool countFiles = true);

        IEnumerable<JRFile> GetPlaylistFiles(JRPlaylist playlist, List<string> fields = null, string filter = null);

        JRFile GetFile(int fileKey, List<string> fields = null, bool formatted = true);

        //List<JRField> GetFieldValues(int fileKey, List<string> fields, bool formatted = true);

        string ResolveExpression(int fileKey, string expression);
    }
}
