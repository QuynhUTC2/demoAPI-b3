using System;
using System.Reflection;

namespace _5951071089_ToVoNhuQuynh_Demob3API.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}