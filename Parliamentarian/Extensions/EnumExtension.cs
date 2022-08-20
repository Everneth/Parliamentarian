using Discord.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Parliamentarian.Extensions
{
    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    ChoiceDisplayAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(ChoiceDisplayAttribute)) as ChoiceDisplayAttribute;
                    if (attr != null)
                    {
                        return attr.Name;
                    }
                }
            }
            return null;
        }
    }
}
