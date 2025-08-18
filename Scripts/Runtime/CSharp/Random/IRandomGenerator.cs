namespace IUP.Toolkits
{
    public interface IRandomGenerator
    {
        /// <summary>
        /// Генерирует случайное неотрицательное 32-битное число в диапазоне
        /// [0, <see cref="int.MaxValue"/>).
        /// </summary>
        public int Int();

        /// <summary>
        /// Генерирует случайное неотрицательное 32-битное число в диапазоне
        /// [0, <paramref name="maxExclusive"/>).
        /// </summary>
        /// <param name="maxExclusive">
        /// Исключённый верхний предел возвращаемого случайного числа.
        /// </param>
        public int Int(int maxExclusive);

        /// <summary>
        /// Генерирует случайное 32-битное число в диапазоне
        /// [<paramref name="minInclusive"/>, <paramref name="maxExclusive"/>).
        /// </summary>
        /// <param name="minInclusive">
        /// Включённый нижний предел возвращаемого случайного числа.
        /// </param>
        /// <param name="maxExclusive">
        /// Исключённый верхний предел возвращаемого случайного числа.
        /// </param>
        /// <returns></returns>
        public int Int(int minInclusive, int maxExclusive);
    }
}
