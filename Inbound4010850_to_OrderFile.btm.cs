namespace EDISamplePOC.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EDISamplePOC.X12_00401_850", typeof(global::EDISamplePOC.X12_00401_850))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EDISamplePOC.OrderFile", typeof(global::EDISamplePOC.OrderFile))]
    public sealed class Inbound4010850_to_OrderFile : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://Inbound_EDI.OrderFile"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:X12_00401_850"" />
  </xsl:template>
  <xsl:template match=""/s0:X12_00401_850"">
    <ns0:OrderFile>
      <CustOrder>
        <xsl:for-each select=""s0:PER"">
          <Details>
            <OderDate>
              <xsl:value-of select=""../s0:BEG/BEG01/text()"" />
            </OderDate>
            <xsl:if test=""../s0:BEG/BEG08"">
              <OrderNumber>
                <xsl:value-of select=""../s0:BEG/BEG08/text()"" />
              </OrderNumber>
            </xsl:if>
            <xsl:if test=""PER06"">
              <CustID>
                <xsl:value-of select=""PER06/text()"" />
              </CustID>
            </xsl:if>
            <xsl:if test=""PER03"">
              <CustName>
                <xsl:value-of select=""PER03/text()"" />
              </CustName>
            </xsl:if>
            <CustMobNum>
              <xsl:value-of select=""PER01/text()"" />
            </CustMobNum>
          </Details>
        </xsl:for-each>
        <xsl:for-each select=""s0:PO1Loop1"">
          <ItemsDetails>
            <OrderNumber>
              <xsl:value-of select=""../s0:BEG/BEG03/text()"" />
            </OrderNumber>
            <xsl:if test=""s0:PO1/PO107"">
              <Item>
                <xsl:value-of select=""s0:PO1/PO107/text()"" />
              </Item>
            </xsl:if>
            <xsl:if test=""s0:PO1/PO106"">
              <Quantity>
                <xsl:value-of select=""s0:PO1/PO106/text()"" />
              </Quantity>
            </xsl:if>
            <xsl:if test=""s0:PO1/PO103"">
              <Units>
                <xsl:value-of select=""s0:PO1/PO103/text()"" />
              </Units>
            </xsl:if>
            <xsl:if test=""s0:PO1/PO105"">
              <Units>
                <xsl:value-of select=""s0:PO1/PO105/text()"" />
              </Units>
            </xsl:if>
            <xsl:if test=""s0:PO1/PO104"">
              <Cost>
                <xsl:value-of select=""s0:PO1/PO104/text()"" />
              </Cost>
            </xsl:if>
            <xsl:if test=""s0:PO1/PO102"">
              <Finalcost>
                <xsl:value-of select=""s0:PO1/PO102/text()"" />
              </Finalcost>
            </xsl:if>
            <xsl:if test=""../s0:PID/PID05"">
              <Descofitem>
                <xsl:value-of select=""../s0:PID/PID05/text()"" />
              </Descofitem>
            </xsl:if>
          </ItemsDetails>
        </xsl:for-each>
      </CustOrder>
    </ns0:OrderFile>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"EDISamplePOC.X12_00401_850";
        
        private const global::EDISamplePOC.X12_00401_850 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"EDISamplePOC.OrderFile";
        
        private const global::EDISamplePOC.OrderFile _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"EDISamplePOC.X12_00401_850";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"EDISamplePOC.OrderFile";
                return _TrgSchemas;
            }
        }
    }
}
