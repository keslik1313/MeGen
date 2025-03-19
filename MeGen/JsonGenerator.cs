using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MeGen
{
    public static class JsonGenerator
    {
        public static void GenerateJson(int version, string license, string copyright, int sizeX, int sizeY, List<object> states)
        {
            var jsonTemplate = new
            {
                version = version,
                license = license,
                copyright = copyright,
                size = new
                {
                    x = sizeX,
                    y = sizeY
                },
                states = states
            };

            // serialize in json
            string json = JsonSerializer.Serialize(jsonTemplate, new JsonSerializerOptions { WriteIndented = true });

            // save file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.FileName = "meta";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, json);
            }
        }
    }
}
