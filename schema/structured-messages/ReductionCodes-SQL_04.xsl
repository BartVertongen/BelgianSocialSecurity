<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="text" indent="yes" encoding="utf-8"/>
    <xsl:template match="/">
        <xsl:for-each select="reduction-codes/reduction-code">
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

INSERT INTO reduction_codes (CodeDMFA, DescriptionNL, DescriptionFR, RegionNL, RegionFR
    , FlemishRegion, BrusselsRegion, WalloonRegion, WalloonAndGermanRegion
    , CalculationBase, Amount, BeginDateRight, MonthlyCosts
    , InssNbrReplaced, InssNbrAuthorized, OriginsCertificate
    , LinkBlockNL, LinkBlockFR
    , PresenceBlockDetail, BeginValidity, EndValidity)
VALUES("<xsl:value-of select="code-DMFA"/>"
        , "<xsl:value-of select="description/nl"/>"
        , "<xsl:value-of select="description/fr"/>"
        , "<xsl:value-of select="region/nl"/>"
        , "<xsl:value-of select="region/fr"/>"
        , "<xsl:value-of select="flemish-region"/>"
        , "<xsl:value-of select="brussels-region"/>"
        , "<xsl:value-of select="walloon-region"/>"
        , "<xsl:value-of select="walloon-and-german-region"/>"
        , "<xsl:value-of select="calculation-base"/>"
        , "<xsl:value-of select="amount"/>"
        , "<xsl:value-of select="begin-date-right"/>"
        , "<xsl:value-of select="monthly-costs"/>"
        , "<xsl:value-of select="inss-nbr-replaced"/>"
        , "<xsl:value-of select="inss-nbr-authorized"/>"
        , "<xsl:value-of select="origins-certificate"/>"
        , "<xsl:value-of select="link-block/nl"/>"
        , "<xsl:value-of select="link-block/fr"/>"
        , "<xsl:value-of select="presence-block-detail"/>"
        , "<xsl:value-of select="$beginValidity"/>"
        , "<xsl:value-of select="$endValidity"/>");
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
