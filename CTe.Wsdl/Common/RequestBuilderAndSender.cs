using System.Threading.Tasks;
using System.Xml;
using CTe.Utils.Enums;
using CTe.Utils.Soap;
using CTe.Wsdl.Configuracao;
namespace CTe.Wsdl.Common
{
    public static class RequestBuilderAndSender{
        
        public static async Task<XmlNode> Execute<TCommonSoapEnvelope>(TCommonSoapEnvelope soapEnvelope, 
            WsdlConfiguracao configuration, Enums.TipoEvento requestType, string responseElementName) where TCommonSoapEnvelope: CommonSoapEnvelope
        {
            {
                var soapUtils = new SoapUtils();
                var xmlResult = new XmlDocument();                
                
                var xmlEnvelop = soapUtils.SerealizeDocument(soapEnvelope);

                var tes = await soapUtils.SendRequest(xmlEnvelop, configuration.CertificadoDigital, configuration.Url,  configuration.TimeOut, requestType);
                xmlResult.LoadXml(tes);

                return xmlResult.GetElementsByTagName(responseElementName)[0];

            }
        }
    }

}