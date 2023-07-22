<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="text" indent="yes" encoding="utf-8"/>
    <xsl:template match="/">
        <xsl:for-each select="admitted-characters/admitted-character">

INSERT INTO admitted_characters(Char, HexValue, DecValue, Translated)
VALUES("<xsl:value-of select="char"/>"
        , "<xsl:value-of select="hex-value"/>"
        , "<xsl:value-of select="dec-value"/>"
        , "<xsl:value-of select="translated"/>");
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
