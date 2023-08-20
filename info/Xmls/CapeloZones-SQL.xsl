<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="text" indent="yes" encoding="utf-8"/>
CREATE TABLE zones(
   Code                 TEXT NOT NULL
   , Version            TEXT NOT NULL
   , PublicationDay     TEXT NOT NULL
   , Title              TEXT NOT NULL
   , XmlLabel           TEXT NOT NULL
   , FunctionalBlock    TEXT NOT NULL
   , DescriptionNL      TEXT NOT NULL
   , DomainNL           TEXT NOT NULL
   , Reference          TEXT
   , Type               TEXT NOT NULL
   , Length             INTEGER
   , Presence           TEXT NOT NULL
   , Format             TEXT NOT NULL
   , PRIMARY KEY (Code, Version)
);
    <xsl:template match="/">
        <xsl:for-each select="List/glossary">

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "<xsl:value-of select="Code"/>"
        , "<xsl:value-of select="Versie"/>"
        , "<xsl:value-of select="Publicatiedatum"/>"
        , "<xsl:value-of select="Titel"/>"
        , "<xsl:value-of select="XmlLabel"/>"
        , "<xsl:value-of select="FunctioneelBlok"/>"
        , "<xsl:value-of select="Omschrijving"/>"
        , "<xsl:value-of select="ToegelatenDomein"/>"
        , "<xsl:value-of select="Referentie"/>"
        , "<xsl:value-of select="Type"/>"
        , "<xsl:value-of select="Lengte"/>"
        , "<xsl:value-of select="Aanwezigheid"/>"
        , "<xsl:value-of select="Formaat"/>"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '<xsl:value-of select="Code"/>'
                          AND Version = '<xsl:value-of select="Versie"/>'
);
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
