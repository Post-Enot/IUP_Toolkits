using System;
using System.Linq;
using UnityEngine.InputSystem;

namespace IUP.Toolkits.Editor
{
    public static class InputFacadeGenerator
    {
        public static string GenerateCode(
            InputActionAsset asset,
            ReadOnlySpan<char> namespaceName,
            ReadOnlySpan<char> className,
            ReadOnlySpan<char> eventsNamespace,
            ReadOnlySpan<char> eventsClassName)
        {
            CodeGenerator gen = new();
            gen.Using("IUP.Toolkits");
            gen.Using(nameof(UnityEngine));
            gen.NewLine();
            gen.Using("InputContext", "UnityEngine.InputSystem.InputAction.CallbackContext");
            gen.NewLine();
            gen.Namespace(namespaceName);
            gen.MonoBehaviourClass(className);
            gen.AddLine("[SerializeField] private EventInvoker _invoker;");
            gen.NewLine();
            gen.AddLine("private static InputActions _inputActions;");
            gen.NewLine();
            gen.MethodAwake();
            gen.AddLine("_inputActions = new InputActions();");
            foreach (InputActionMap map in asset.actionMaps)
            {
                foreach (InputAction action in map.actions)
                {
                    string mapClassName = map.name;
                    GenerateSubscribe(gen, action, mapClassName);
                }
            }
            gen.CloseBracket();
            gen.NewLine();
            gen.MethodOnDestroy();
            foreach (InputActionMap map in asset.actionMaps)
            {
                foreach (InputAction action in map.actions)
                {
                    string mapClassName = map.name;
                    GenerateUnsubscribe(gen, action, mapClassName);
                }
            }
            gen.CloseBracket();
            GenerateDisableMethods(gen, asset);
            string namespacePrefix = GetMinimalNamespace(eventsNamespace, namespaceName);
            if (namespacePrefix.IsNonEmpty())
            {
                namespacePrefix += ".";
            }
            namespacePrefix += $"{eventsClassName.ToString()}.";
            foreach (InputActionMap map in asset.actionMaps)
            {
                string mapName = map.name;
                foreach (InputAction action in map.actions)
                {
                    GenerateMethod(gen, action, mapName, namespacePrefix);
                }
            }
            gen.CloseBracket();
            gen.CloseBracket();
            return gen.ToString();
        }

        private static void GenerateDisableMethods(CodeGenerator gen, InputActionAsset inputActions)
        {
            gen.AddLine("public void DisableAll() => _inputActions.Disable();");
            gen.AddLine("public void EnableAll() => _inputActions.Enable();");

            foreach (InputActionMap map in inputActions.actionMaps)
            {
                // Enable
                gen.AddLine($"public void Enable{map.name}() => _inputActions.{map.name}.Enable();");

                // Disable
                gen.AddLine($"public void Disable{map.name}() => _inputActions.{map.name}.Disable();");

                // Enable Only
                gen.AddLine($"public void EnableOnly{map.name}()");
                gen.OpenBracket();
                gen.AddLine($"_inputActions.Disable();");
                gen.AddLine($"_inputActions.{map.name}.Enable();");
                gen.CloseBracket();
            }
        }

        private static void GenerateMethod(
            CodeGenerator gen,
            InputAction action,
            string mapName,
            string prefix)
        {
            GenerateMethod(gen, action, mapName, prefix, "Started");
            GenerateMethod(gen, action, mapName, prefix, "Performed");
            GenerateMethod(gen, action, mapName, prefix, "Canceled");
        }

        private static void GenerateMethod(CodeGenerator gen, InputAction action, string mapName, string prefix, string eventName)
        {
            gen.AddLine($"private void On{mapName}{action.name}{eventName}(InputContext inputContext)");
            gen.OpenBracket();
            gen.AddLine($"{prefix}{mapName}.{action.name}{eventName} context = new(inputContext);");
            gen.AddLine($"_invoker.Invoke(context);");
            gen.CloseBracket();
        }

        private static void GenerateSubscribe(
            CodeGenerator gen,
            InputAction action,
            string mapClassName)
        {
            gen.AddLine($"_inputActions.{mapClassName}.{action.name}.started += On{mapClassName}{action.name}Started;");
            gen.AddLine($"_inputActions.{mapClassName}.{action.name}.performed += On{mapClassName}{action.name}Performed;");
            gen.AddLine($"_inputActions.{mapClassName}.{action.name}.canceled += On{mapClassName}{action.name}Canceled;");
        }

        private static void GenerateUnsubscribe(
            CodeGenerator gen,
            InputAction action,
            string mapClassName)
        {
            gen.AddLine($"_inputActions.{mapClassName}.{action.name}.started -= On{mapClassName}{action.name}Started;");
            gen.AddLine($"_inputActions.{mapClassName}.{action.name}.performed -= On{mapClassName}{action.name}Performed;");
            gen.AddLine($"_inputActions.{mapClassName}.{action.name}.canceled -= On{mapClassName}{action.name}Canceled;");
        }

        private static string GetMinimalNamespace(ReadOnlySpan<char> ns1, ReadOnlySpan<char> ns2)
        {
            ns1 = ns1.IsEmpty ? default : ns1;
            ns2 = ns2.IsEmpty ? default : ns2;

            // Если пространства имён идентичны
            if (ns1.SequenceEqual(ns2))
                return string.Empty;

            int start1 = 0, start2 = 0;
            bool hasCommonPrefix = false;

            while (true)
            {
                int dot1 = ns1[start1..].IndexOf('.');
                int dot2 = ns2[start2..].IndexOf('.');

                ReadOnlySpan<char> seg1 = dot1 < 0 ? ns1[start1..] : ns1.Slice(start1, dot1);

                ReadOnlySpan<char> seg2 = dot2 < 0 ? ns2[start2 ..] : ns2.Slice(start2, dot2);

                // Если сегменты разные, прерываем цикл
                if (!seg1.SequenceEqual(seg2))
                {
                    break;
                }

                start1 += seg1.Length;
                start2 += seg2.Length;
                hasCommonPrefix = true;

                // Пропускаем точку (если она есть)
                if (dot1 >= 0)
                {
                    start1 += 1;
                }
                if (dot2 >= 0)
                {
                    start2 += 1;
                }

                // Проверка окончания строк
                if ((start1 >= ns1.Length) || (start2 >= ns2.Length))
                {
                    break;
                }
            }

            // Если ns2 полностью входит в ns1
            if (start2 >= ns2.Length && start1 <= ns1.Length)
            {
                // Проверка на завершающую точку
                if (start1 > 0 && start1 < ns1.Length && ns1[start1 - 1] == '.')
                    start1--;

                return start1 >= ns1.Length
                    ? string.Empty
                    : ns1[start1..].ToString();
            }

            return hasCommonPrefix ? ns1.ToString() : ns1.ToString();
        }

        private static string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return char.ToUpper(input[0]) + input[1..];
        }
    }
}
