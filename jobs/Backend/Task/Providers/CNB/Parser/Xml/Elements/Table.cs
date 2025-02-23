﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace ExchangeRateUpdater.Providers.CNB.Parser.Xml.Elements;

[XmlRoot(ElementName = "tabulka")]
public class Table
{
    [XmlElement(ElementName = "radek")]
    public List<Row> Rows { get; set; }

    [XmlAttribute(AttributeName = "typ")]
    public string Type { get; set; }
}