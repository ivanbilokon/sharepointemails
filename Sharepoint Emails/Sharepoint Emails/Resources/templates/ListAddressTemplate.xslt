﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl" xmlns:d="urn:sharepointemail-context">
    <xsl:output method="text" indent="yes"/>
    <xsl:template match="@* | node()">
      <xsl:value-of select="d:EventData[1]/@ListEmail"/>
    </xsl:template>
</xsl:stylesheet>
