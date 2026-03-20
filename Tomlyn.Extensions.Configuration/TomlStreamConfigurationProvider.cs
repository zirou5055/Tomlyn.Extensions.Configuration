using System.IO;
using Microsoft.Extensions.Configuration;

namespace Tomlyn.Extensions.Configuration
{
    public class TomlStreamConfigurationProvider(TomlStreamConfigurationSource source) : StreamConfigurationProvider(source)
    {
        public override void Load(Stream stream)
        {
            Data = TomlConfigurationFileParser.Parse(stream);
        }
    }
}