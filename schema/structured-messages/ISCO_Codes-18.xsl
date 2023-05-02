<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml" indent="yes" encoding="utf-8"/>
    <xsl:template match="/">
    <!-- ISCO code -->
    <!-- Code CITP -->
    <ISCO_codes>
        <xsl:for-each select="List/ann18">
        <ISCO_code>
            <code><xsl:value-of select="Code"/></code>
            <nomeclature>
                <nl><xsl:value-of select="Validite"/></nl>
                <fr></fr>
            </nomeclature>
            <description>
                <nl><xsl:value-of select="Omschrijving"/></nl>
                <fr></fr>
            </description>
            <level1>
                <nl><xsl:value-of select="Niveau1"/></nl>
                <fr></fr>
            </level1>
            <level2>
                <nl><xsl:value-of select="Niveau2"/></nl>
                <fr></fr>
            </level2>
            <level3>
                <nl><xsl:value-of select="Niveau3"/></nl>
                <fr></fr>
            </level3>
            <begin-validity>
                <xsl:value-of select="begin_geldigheid"/>
            </begin-validity>
            <end-validity><xsl:value-of select="einde_geldigheid"/></end-validity>
        </ISCO_code>
        </xsl:for-each>
    </ISCO_codes>
    </xsl:template>
</xsl:stylesheet>