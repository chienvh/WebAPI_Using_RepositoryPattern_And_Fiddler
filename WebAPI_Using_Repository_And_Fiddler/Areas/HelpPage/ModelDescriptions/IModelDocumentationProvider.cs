using System;
using System.Reflection;

namespace WebAPI_Using_Repository_And_Fiddler.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}