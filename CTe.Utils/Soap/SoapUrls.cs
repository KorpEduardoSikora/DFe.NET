using System;

namespace CTe.Utils.Soap
{
    public class SoapUrls
    {
        public string GetSoapUrl(Enums.Enums.TipoEvento tipoEvento)
        {
            switch (tipoEvento)
            {
                case Enums.Enums.TipoEvento.CTeConsulta:
                    return "http://www.portalfiscal.inf.br/cte/wsdl/CteConsulta";
                case Enums.Enums.TipoEvento.CTeDistribuicaoDFe:
                    return "http://www.portalfiscal.inf.br/cte/wsdl/CTeDistribuicaoDFe";
                case Enums.Enums.TipoEvento.CTeRecepcaoEvento:
                    return "http://www.portalfiscal.inf.br/cte/wsdl/CteRecepcaoEvento";
                case Enums.Enums.TipoEvento.CTeInutilizacao:
                    return "http://www.portalfiscal.inf.br/cte/wsdl/CteInutilizacao";
                case Enums.Enums.TipoEvento.CTeRecepcao:
                    return "http://www.portalfiscal.inf.br/cte/wsdl/CteRecepcao";
                case Enums.Enums.TipoEvento.CTeRetRecepcao:
                    return "http://www.portalfiscal.inf.br/cte/wsdl/CteRetRecepcao";
                case Enums.Enums.TipoEvento.CTeStatusServico:
                    return "http://www.portalfiscal.inf.br/cte/wsdl/CteStatusServico";
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoEvento), tipoEvento, null);
            }
        } 
    }
}