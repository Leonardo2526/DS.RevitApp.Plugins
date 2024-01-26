﻿using Autodesk.Revit.DB;
using MoreLinq;
using OLMP.RevitAPI.Core.Extensions;
using Rhino.UI;
using System.Collections.Generic;
using System.Linq;

namespace DS.MEPCurveTraversability.Interactors.Settings
{
    public abstract class DocSettingsBase
    {
        public abstract IEnumerable<string> AutoDocsDetectionFields { get; set; }


        public bool CanDetectAutoDocs { get; set; } = true;

        public (Document, IEnumerable<RevitLinkInstance>) ToDocLinks(
            IEnumerable<Document> docs, 
            (Document, IEnumerable<RevitLinkInstance>) allDocLinks)
        {
            if (docs == null) { return (null, null); }

            Document doc = docs.FirstOrDefault(d => !d.IsLinked);
            var fLinks = new List<RevitLinkInstance>();
            foreach (var d in docs)
            {
                var flink = d.TryGetLink(allDocLinks.Item2);
                if (flink != null)
                { fLinks.Add(flink); }
            }

            return (doc, fLinks);
        }

        public List<Document> Docs { get; set; }

        public DocSettingsBase TryUpdateDocs((Document, IEnumerable<RevitLinkInstance>) allDocLinks)
        {
            Docs = Docs?.Where(d => d.IsValidObject).ToList();
            if (Docs == null || Docs.Count() == 0)
            {
                if (CanDetectAutoDocs)
                { Docs = DocsFilter.FilterByLastFolderName(allDocLinks, AutoDocsDetectionFields).ToList(); }
            }          
            return this;
        }
    }
}