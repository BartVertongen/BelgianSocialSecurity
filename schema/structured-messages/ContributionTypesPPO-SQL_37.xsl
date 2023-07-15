<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="text" indent="yes" encoding="utf-8"/>
    <xsl:template match="/">
        <xsl:for-each select="contribution-types/contribution-type">
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
INSERT INTO contribution_types_PPO(CodeNL, CodeFR, EmployerCategory, Type
    , OrdinaryContributionNL, OrdinaryContributionNL, BeginValidity, EndValidity)
VALUES("<xsl:value-of select="code/nl"/>"
        , "<xsl:value-of select="code/fr"/>"
        , "<xsl:value-of select="employer-category"/>"
        , "<xsl:value-of select="type"/>"
        , "<xsl:value-of select="ordinary-contribution/nl"/>"
        , "<xsl:value-of select="ordinary-contribution/fr"/>"
        , "<xsl:value-of select="$beginValidity"/>"
        , "<xsl:value-of select="$endValidity"/>");
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
