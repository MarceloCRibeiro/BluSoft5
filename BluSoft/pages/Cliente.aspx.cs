using System;
using System.Web.Services;

using BluSoftService.Service;
using BluSoftService.Repository;

public partial class Cliente : System.Web.UI.Page
{

    #region Properties

    
    #endregion

    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    #endregion

    #region Methods


    #endregion

    #region WebMethods

    [WebMethod(EnableSession = true)]
    public static bool CadastrarCliente(string cpf, string rg, string nome, string nascimento, string telefone, string uf)
    {
        
        try
        {
            BluSoftService.Service.BluSoftService service = new BluSoftService.Service.BluSoftService();

            var cliente = new BluSoftService.Repository.Cliente();
            cliente.CPF = cpf;
            cliente.RG = rg;
            cliente.Nome = nome;
            cliente.DataNascimento = Convert.ToDateTime(nascimento);
            cliente.Telefone = telefone;
            cliente.UF = uf;

            return service.CadastrarCliente(cliente);

        
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return true;

    }

    #endregion

}

