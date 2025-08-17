namespace IUP.Toolkits.Editor
{
    public sealed class MethodGenerator
    {
        public MethodGenerator(CodeGenerator codeGenerator) => _codeGenerator = codeGenerator;

        private readonly CodeGenerator _codeGenerator;

        public AcessModifier AcessModifier { get; private set; } = AcessModifier.Public;
        public string ReturnType { get; private set; } = CodeGeneratorUtility.Void;

        public void Access(AcessModifier acessModifier) => AcessModifier = acessModifier;

        //public void Static()
    }
}
