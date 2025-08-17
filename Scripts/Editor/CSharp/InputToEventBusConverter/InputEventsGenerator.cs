using System;
using UnityEngine.InputSystem;

namespace IUP.Toolkits.Editor
{
    public static class InputEventsGenerator
    {
        public static string GenerateCode(
            InputActionAsset asset,
            ReadOnlySpan<char> namespaceName,
            ReadOnlySpan<char> className)
        {
            CodeGenerator gen = new();
            gen.Using(nameof(UnityEngine));
            gen.NewLine();
            gen.Using("InputContext", "UnityEngine.InputSystem.InputAction.CallbackContext");
            gen.NewLine();
            using (gen.Namespace(namespaceName))
            {
                using (gen.StaticClass(className))
                {
                    foreach (InputActionMap map in asset.actionMaps)
                    {
                        string mapClassName = map.name;
                        using (gen.StaticClass(mapClassName))
                        {
                            foreach (InputAction action in map.actions)
                            {
                                GenerateEventStructs(gen, action, mapClassName);
                            }
                        }
                        gen.NewLine();
                    }
                }
            }
            return gen.ToString();
        }

        private static void GenerateEventStructs(CodeGenerator gen, InputAction action, string context)
        {
            string valueType = GetValueType(action.expectedControlType);
            GenerateEventStruct(gen, $"{action.name}Started", valueType);
            GenerateEventStruct(gen, $"{action.name}Performed", valueType);
            GenerateEventStruct(gen, $"{action.name}Canceled", valueType);
        }

        private static void GenerateEventStruct(CodeGenerator gen, string structName, string valueType)
        {
            using (gen.ReadOnlyStruct(structName))
            {
                gen.AddLine($"public {structName}(InputContext inputContext) => InputContext = inputContext;");
                gen.NewLine();
                gen.AddLine($"public readonly InputContext InputContext {{ get; }}");
                if (valueType != null)
                {
                    gen.NewLine();
                    gen.AddLine($"public readonly {valueType} Value => InputContext.ReadValue<{valueType}>();");
                }
            }
            gen.NewLine();
        }

        private static string GetValueType(string controlType)
        {
            return controlType switch
            {
                "Vector2" => "Vector2",
                "Axis" => "float",
                _ => null
            };
        }
    }
}
