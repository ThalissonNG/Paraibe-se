using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public string LinkMuseuArtePopular;
    public string LinkMonumentoFarraDaBudega;
    public string LinkMuseuDoAlgodao;
    public string LinkParqueDoPovo;
    public string LinkCadetral;
    public string LinkBarDoCuscuz;
    public string LinkMuseuDigital;
    public string LinkParqueDaCrianca;
    public string LinkPioneiros;

    public void MapsMuseuArtePopular()
    {
        Application.OpenURL(LinkMuseuArtePopular);
    }
    public void MapsMonumentoFarraDaBudega()
    {
        Application.OpenURL(LinkMonumentoFarraDaBudega);
    }
    public void MapsMuseuDoAlgodao()
    {
        Application.OpenURL(LinkMuseuDoAlgodao);
    }
    public void MapsParqueDoPovo()
    {
        Application.OpenURL(LinkParqueDoPovo);
    }
    public void MapsCatedral()
    {
        Application.OpenURL(LinkCadetral);
    }
    public void MapsBarDoCuscuz()
    {
        Application.OpenURL(LinkBarDoCuscuz);
    }
    public void MapsMuseuDigital()
    {
        Application.OpenURL(LinkMuseuDigital);
    }
    public void MapsParqueDaCrianca()
    {
        Application.OpenURL(LinkParqueDaCrianca);
    }
    public void MapsPioneiros()
    {
        Application.OpenURL(LinkPioneiros);
    }

}
