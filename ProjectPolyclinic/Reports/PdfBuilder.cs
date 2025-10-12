using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Reports;

internal class PdfBuilder
{
    private readonly string _filePath;
    private readonly Document _document;
    public PdfBuilder(string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
        {
            throw new ArgumentNullException(nameof(filePath));
        }
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
        _filePath = filePath;
        _document = new Document();
        DefineStyles();
    }

    public PdfBuilder AddHeader(string header)
    {
        _document.AddSection().AddParagraph(header, "NormalBold");
        return this;
    }

    public PdfBuilder AddPieChart(string title, List<(string Caption, double Value)> data)
    {
        if (data == null || data.Count == 0)
        {
            return this;
        }
        var chart = new Chart(ChartType.Pie2D);
        var series = chart.SeriesCollection.AddSeries();
        series.Add(data.Select(x => x.Value).ToArray());
        var xseries = chart.XValues.AddXSeries();
        xseries.Add(data.Select(x => x.Caption).ToArray());
        chart.DataLabel.Type = DataLabelType.Percent;
        chart.DataLabel.Position = DataLabelPosition.OutsideEnd;
        chart.Width = Unit.FromCentimeter(16);
        chart.Height = Unit.FromCentimeter(12);
        chart.TopArea.AddParagraph(title);
        chart.XAxis.MajorTickMark = TickMarkType.Outside;
        chart.YAxis.MajorTickMark = TickMarkType.Outside;
        chart.YAxis.HasMajorGridlines = true;
        chart.PlotArea.LineFormat.Width = 1;
        chart.PlotArea.LineFormat.Visible = true;
        chart.TopArea.AddLegend();
        _document.LastSection.Add(chart);
        return this;
    }

    public void Build()
    {
        var renderer = new PdfDocumentRenderer()
        {
            Document = _document
        };
        renderer.RenderDocument();
        renderer.PdfDocument.Save(_filePath);
    }

    private void DefineStyles()
    {
        Style normalStyle = _document.Styles["Normal"];

        Style heading1Style = _document.Styles.AddStyle("Heading1", "Normal");
        heading1Style.Font.Name = "Arial"; 
        heading1Style.Font.Size = 16;
        heading1Style.Font.Bold = true;
        heading1Style.Font.Color = Colors.Black;
        heading1Style.ParagraphFormat.SpaceAfter = Unit.FromCentimeter(0.2);

        Style regularTextStyle = _document.Styles.AddStyle("RegularText", "Normal");
        regularTextStyle.Font.Name = "Arial"; 
        regularTextStyle.Font.Size = 11;
        regularTextStyle.Font.Color = Colors.Black;
        regularTextStyle.ParagraphFormat.Alignment = ParagraphAlignment.Justify;
        regularTextStyle.ParagraphFormat.SpaceAfter = Unit.FromCentimeter(0.1);

    }
}
