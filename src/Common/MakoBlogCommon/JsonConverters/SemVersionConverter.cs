using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Semver;

namespace MakoBlog.Common.MakoBlogCommon.JsonConverters;

public class SemVersionConverter : JsonConverter<SemVersion>
{
	public override SemVersion? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		return SemVersion.Parse(reader.GetString(), SemVersionStyles.Strict);
	}

	public override void Write(Utf8JsonWriter writer, SemVersion value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToString());
	}
}