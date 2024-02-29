using Artisan.Debugging;

namespace Artisan
{
    public class ArtisanConsts
    {
        public const string LocalizationSourceName = "Artisan";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "6755e4dffec44cf2a1411256abbf3480";
    }
}
