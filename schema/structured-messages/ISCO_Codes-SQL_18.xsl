<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="text" indent="yes" encoding="utf-8"/>
    <xsl:template match="/">
        <xsl:for-each select="ISCO_codes/ISCO_code">
            <xsl:variable name="beginYear">
                <xsl:value-of select="begin-validity/year"/>
            </xsl:variable>

            <xsl:variable name="beginQuarter">
                <xsl:value-of select="begin-validity/quarter"/>
            </xsl:variable>

            <xsl:variable name="endYear">
                <xsl:value-of select="end-validity/year"/>
            </xsl:variable>

            <xsl:variable name="endQuarter">
                <xsl:value-of select="end-validity/quarter"/>
            </xsl:variable>

            <xsl:variable name="beginValidity">
                <xsl:value-of select="concat($beginYear,'/',$beginQuarter)" />
            </xsl:variable>

            <xsl:variable name="endValidity">
                <xsl:value-of select="concat($endYear,'/',$endQuarter)" />
            </xsl:variable>

INSERT INTO ISCO_codes (Code, NomeclatureNL, NomeclatureFR
        , DescriptionNL, DescriptionFR
        , Level1NL, Level1FR
        , Level2NL, Level2FR,
        , Level3NL, Level3FR,
        , BeginValidity, EndValidity)
VALUES("<xsl:value-of select="code"/>"
        , "<xsl:value-of select="nomeclature/nl"/>"
        , "<xsl:value-of select="nomeclature/fr"/>"
        , "<xsl:value-of select="description/nl"/>"
        , "<xsl:value-of select="description/fr"/>"
        , "<xsl:value-of select="level1/nl"/>"
        , "<xsl:value-of select="level1/fr"/>"
        , "<xsl:value-of select="level2/nl"/>"
        , "<xsl:value-of select="level2/fr"/>"
        , "<xsl:value-of select="level3/nl"/>"
        , "<xsl:value-of select="level3/fr"/>"
        , "<xsl:value-of select="$beginValidity"/>"
        , "<xsl:value-of select="$endValidity"/>");
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
