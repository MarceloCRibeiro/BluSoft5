using System;
using System.Web.Services;
using System.Collections.Generic;

using BluSoftService.Service;
using BluSoftService.Repository;

public partial class ConsultaCliente : System.Web.UI.Page
{

    #region Properties

    
    #endregion

    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #endregion

    #region Methods

    private static bool VerificarSessao() // Verifica se sessão está ativa
    {
        // implementamos a rotina para validar a sessão do usuário
        return true;
    }

    #endregion

    #region WebMethods

    [WebMethod]
    public static List<BluSoftService.Repository.Cliente> BuscarCliente(string tipoPesquisa, string valorPesquisa)
    {

        try
        {
            BluSoftService.Service.BluSoftService service = new BluSoftService.Service.BluSoftService();

            return service.BuscarCliente(tipoPesquisa, valorPesquisa);


        }
        catch (Exception ex)
        {
            throw ex;
        }
        
    }

    #endregion

}

