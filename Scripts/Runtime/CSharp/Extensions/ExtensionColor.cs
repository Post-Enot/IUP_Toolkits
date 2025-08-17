using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionColor
    {
        public static Color WithR(this Color self, float r) => new(r, self.g, self.b, self.a);

        public static Color WithG(this Color self, float g) => new(self.r, g, self.b, self.a);

        public static Color WithB(this Color self, float b) => new(self.r, self.g, b, self.a);

        public static Color WithA(this Color self, float a) => new(self.r, self.g, self.b, a);
    }
}
