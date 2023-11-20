using System.ComponentModel;
using System.Reflection;
namespace PizzariaDoZe.utils;
/// <summary>
/// Classe enum de funcionários
/// </summary>
public enum EnumFuncionarioGrupo
{
    /// <summary>
    /// Funcionário administrador
    /// </summary>
    [Description("Administrador")]
    Admin = 1,
    /// <summary>
    /// Funcionário atendente
    /// </summary>
    [Description("Atendente")]
    Atende = 2,
    /// <summary>
    /// Funcionário entregador
    /// </summary>
    [Description("Entregador")]
    Entrega = 3,
}

/// <summary>
/// Classe enum dos sabores
/// </summary>
public enum EnumSaborCategoria
{
    /// <summary>
    /// Sabor tradicional
    /// </summary>
    [Description("Tradicional")]
    Tradicional = 'T',
    /// <summary>
    /// Sabor especial
    /// </summary>
    [Description("Especial")]
    Especial = 'E'
}

/// <summary>
/// Calsse enum dos tipos de saber
/// </summary>
public enum EnumSaborTipo
{
    /// <summary>
    /// Tipo Doce
    /// </summary>
    [Description("Doce")]
    Doce = 'D',
    /// <summary>
    /// Tipo Salgado
    /// </summary>
    [Description("Salgada")]
    Salgada = 'S'
}

/// <summary>
/// Classe de extensões enum
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Captura os enuns
    /// </summary>
    /// <param name="GenericEnum">Classe enum a ser consultada + valor</param>
    /// <returns>Description do enum</returns>
    public static string GetDescription(this Enum GenericEnum)
    {
        Type genericEnumType = GenericEnum.GetType();
        MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
        if ((memberInfo != null && memberInfo.Length > 0))
            {
            var _Attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            if ((_Attribs != null && _Attribs.Count() > 0))
            {
                return ((DescriptionAttribute)_Attribs.ElementAt(0)).Description;
            }
        }
    return GenericEnum.ToString();
    }
}

public enum EnumValorTamanho
{
    [Description("Pequena")]
    Pequena = 'P',
    [Description("Média")]
    Média = 'M',
    [Description("Grande")]
    Grande = 'G',
    [Description("Família")]
    Família = 'F'
}

public enum EnumProdutoTipo
{
    [Description("Refrigerante")]
    Refrigerante = 'R',
    [Description("Cerveja")]
    Cerveja = 'C',
    [Description("Suco")]
    Suco = 'S',
    [Description("Água")]
    Água = 'A',
    [Description("Outros")]
    Outros = 'O'
}