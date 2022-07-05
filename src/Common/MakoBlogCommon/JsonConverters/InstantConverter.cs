using System.Text.Json;
using System.Text.Json.Serialization;
using NodaTime;
using NodaTime.Text;

namespace MakoBlog.Common.MakoBlogCommon.JsonConverters;

public class InstantConverter : JsonConverter<Instant>
{
	public override Instant Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var dateValueString = reader.GetString();

		if (string.IsNullOrWhiteSpace(dateValueString))
		{
			throw new ApplicationException("Cannot convert an empty string to an Instant");
		}

		var parseResult = InstantPattern.ExtendedIso.Parse(dateValueString);
		if (!parseResult.Success) throw parseResult.Exception;

		return parseResult.Value;
	}

	public override void Write(Utf8JsonWriter writer, Instant value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToString());
	}
}