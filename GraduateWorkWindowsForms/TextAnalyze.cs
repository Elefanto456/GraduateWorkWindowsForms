﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Language.V1;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;
using Google.Protobuf.Collections;

namespace GraduateWorkWindowsForms
{
    public class TextAnalyze
    {
         static Dictionary<string, string> wordAndType = new Dictionary<string, string>();
         static string textForAnalyze;

        public Dictionary<string, string> AnalyzeEntitiesFromText(string text)
        {
            var client = LanguageServiceClient.Create();
            var response = client.AnalyzeEntities(new Document()
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            });
            wordAndType = WriteEntities(response.Entities);
            return wordAndType;

        }

        // [START analyze_entities_from_file]
        private static Dictionary<string, string> WriteEntities(IEnumerable<Entity> entities)
        {
            foreach (var entity in entities)
            {
                try
                {
                    wordAndType.Add(entity.Name, entity.Type.ToString());
                }
                catch (ArgumentException)
                {
                    break;
                }
            }
            return wordAndType;
        }
    }
}
