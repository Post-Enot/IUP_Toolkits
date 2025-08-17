using System;
using System.Text;

namespace IUP.Toolkits.Editor
{
    public class CodeGenerator
    {
        public CodeGenerator() => _stringBuilder.AppendLine(
$@"// ===================================================================================================
// 
// Этот файл был полностью сгенерирован.
// Любые ручные изменения будут перезаписаны при следующей генерации.
// 
// Дата генерации: {DateTime.Now:dd.MM.yyyy HH:mm:ss}
// Генератор: IUP.Toolkits.Editor.CodeGenerator
// ===================================================================================================");

        public readonly struct BracketsBlock : IDisposable
        {
            public BracketsBlock(CodeGenerator codeGenerator)
            {
                _codeGenerator = codeGenerator;
                _codeGenerator.OpenBracket();
            }

            private readonly CodeGenerator _codeGenerator;

            public void Dispose() => _codeGenerator.CloseBracket();
        }

        public const string StrIndent = "    ";

        private readonly StringBuilder _stringBuilder = new();

        public int Indent { get; private set; }

        public void Using(ReadOnlySpan<char> pseudonym, ReadOnlySpan<char> element)
        {
            _stringBuilder.Append("using ");
            _stringBuilder.Append(pseudonym);
            _stringBuilder.Append(" = ");
            _stringBuilder.Append(element);
            _stringBuilder.Append(";");
            _stringBuilder.AppendLine();
        }

        public void Using(ReadOnlySpan<char> directoryName)
        {
            _stringBuilder.Append("using ");
            _stringBuilder.Append(directoryName);
            _stringBuilder.Append(";");
            _stringBuilder.AppendLine();
        }

        public BracketsBlock Namespace(ReadOnlySpan<char> namespaceName)
        {
            AppendIndent();
            _stringBuilder.Append("namespace ");
            _stringBuilder.Append(namespaceName);
            _stringBuilder.AppendLine();
            return GetBracketsBlock();
        }

        public void MethodAwake()
        {
            AppendIndent();
            _stringBuilder.AppendLine("private void Awake()");
            OpenBracket();
        }

        public void MethodOnEnable()
        {
            AppendIndent();
            _stringBuilder.AppendLine("private void OnEnable()");
            OpenBracket();
        }

        public void MethodOnDisable()
        {
            AppendIndent();
            _stringBuilder.AppendLine("private void OnDisable()");
            OpenBracket();
        }

        public void MethodOnDestroy()
        {
            AppendIndent();
            _stringBuilder.AppendLine("private void OnDestroy()");
            OpenBracket();
        }

        public void MonoBehaviourClass(ReadOnlySpan<char> className)
        {
            AppendIndent();
            _stringBuilder.Append("public sealed class ");
            _stringBuilder.Append(className);
            _stringBuilder.Append(" : MonoBehaviour");
            _stringBuilder.AppendLine();
            OpenBracket();
        }

        public BracketsBlock StaticClass(ReadOnlySpan<char> className)
        {
            AppendIndent();
            _stringBuilder.Append("public static class ");
            _stringBuilder.Append(className);
            _stringBuilder.AppendLine();
            return GetBracketsBlock();
        }

        public BracketsBlock ReadOnlyStruct(ReadOnlySpan<char> structName)
        {
            AppendIndent();
            _stringBuilder.Append("public readonly struct ");
            _stringBuilder.Append(structName);
            _stringBuilder.AppendLine();
            return GetBracketsBlock();
        }

        public void EmptyReadOnlyStruct(ReadOnlySpan<char> structName)
        {
            AppendIndent();
            _stringBuilder.Append("public readonly struct ");
            _stringBuilder.Append(structName);
            _stringBuilder.AppendLine(" {}");
            _stringBuilder.AppendLine();
        }

        public void AddLine(string line)
        {
            AppendIndent();
            _stringBuilder.AppendLine(line);
        }

        public void OpenBracket()
        {
            AppendIndent();
            _stringBuilder.AppendLine("{");
            Indent += 1;
        }

        public void CloseBracket()
        {
            Indent -= 1;
            AppendIndent();
            _stringBuilder.AppendLine("}");
        }

        public override string ToString() => _stringBuilder.ToString();

        public void NewLine() => _stringBuilder.AppendLine();

        public void AppendIndent()
        {
            for (int i = 0; i < Indent; i += 1)
            {
                _stringBuilder.Append(StrIndent);
            }
        }

        private BracketsBlock GetBracketsBlock() => new(this);
    }
}
