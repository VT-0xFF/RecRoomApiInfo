using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public abstract class IVZBVXPSQBJ<a> : JsonConverter<a> where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		protected delegate void ReaderAction(Utf8JsonReader r);

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x65EFCD0", Offset = "0x65EE6D0", VA = "0x1865EFCD0", Slot = "33")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x65EFEB0", Offset = "0x65EE8B0", VA = "0x1865EFEB0", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "41")]
		protected virtual void RECJAMOUYUM(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "42")]
		protected virtual void EJYISESLUAF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "43")]
		public abstract void IPAYYMEOZLJ(Utf8JsonReader a, JsonSerializerOptions b, string c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "44")]
		public abstract void MCEHAEZCAMA(Utf8JsonWriter a, a b, JsonSerializerOptions c);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x65F0050", Offset = "0x65EEA50", VA = "0x1865F0050")]
		protected IVZBVXPSQBJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class UnhandledJsonPropertyException : JsonException
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98B61F0", Offset = "0x98B4BF0", VA = "0x1898B61F0")]
		public UnhandledJsonPropertyException(string propertyName)
		{
		}
	}
}
namespace RecRoom.JsonSerialization
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class FDXCIMZUIZQ<a> : JsonConverter<Dictionary<a, int>> where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62FD330", Offset = "0x62FBD30", VA = "0x1862FD330", Slot = "33")]
		public override Dictionary<a, int> Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62FD4D0", Offset = "0x62FBED0", VA = "0x1862FD4D0", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, Dictionary<a, int> value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62FDAA0", Offset = "0x62FC4A0", VA = "0x1862FDAA0")]
		public FDXCIMZUIZQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class DHPGIKOHQZC<a> : JsonConverter<a[]> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x53B7160", Offset = "0x53B5B60", VA = "0x1853B7160", Slot = "33")]
		public override a[] Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x53B7630", Offset = "0x53B6030", VA = "0x1853B7630", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a[] value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x53B78F0", Offset = "0x53B62F0", VA = "0x1853B78F0")]
		protected DHPGIKOHQZC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class HJGKISFDTEL<a> : JsonConverter<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected abstract int AGNSAISSRJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int? YRNWQKSMVJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCE3470", Offset = "0xCE1E70", VA = "0x180CE3470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "42")]
		protected abstract a ZBXJPFABRLV(float[] a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "43")]
		protected abstract float[] GCFCJAORPHG(a a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x649FD80", Offset = "0x649E780", VA = "0x18649FD80", Slot = "33")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x64A0510", Offset = "0x649EF10", VA = "0x1864A0510", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x64A0640", Offset = "0x649F040", VA = "0x1864A0640")]
		protected HJGKISFDTEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class FQYKCAEOSGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x98B5EC0", Offset = "0x98B48C0", VA = "0x1898B5EC0")]
		public static void MGQLDBJJCWL(this Utf8JsonWriter a, string b, bool c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x98B5EA0", Offset = "0x98B48A0", VA = "0x1898B5EA0")]
		public static bool DTAVSMGQGJA(this Utf8JsonReader a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x98B6140", Offset = "0x98B4B40", VA = "0x1898B6140")]
		public static void UORKWJKNBWP(this Utf8JsonWriter a, string b, int? c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x98B6090", Offset = "0x98B4A90", VA = "0x1898B6090")]
		public static void SGCZUTGDGAN(this Utf8JsonWriter a, string b, long? c, long d = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2BB0", Offset = "0x3AB15B0", VA = "0x183AB2BB0")]
		public static void HDNEFWCAJZS<a>(this Utf8JsonWriter a, string b, JsonSerializerOptions c, a d, a e) where a : IEquatable<a>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98B5EF0", Offset = "0x98B48F0", VA = "0x1898B5EF0")]
		public static void MRJDVALEHHL(this Utf8JsonWriter a, float b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RNFPNRFSJAV<a> : JsonConverter<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x773D880", Offset = "0x773C280", VA = "0x18773D880", Slot = "33")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x773DAA0", Offset = "0x773C4A0", VA = "0x18773DAA0", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x773DB50", Offset = "0x773C550", VA = "0x18773DB50")]
		public RNFPNRFSJAV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class YZQHFEPLOOF : JsonConverter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int MYZCXAFQHYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD05F80", Offset = "0xD04980", VA = "0x180D05F80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDECAD0", Offset = "0xDEB4D0", VA = "0x180DECAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98B6260", Offset = "0x98B4C60", VA = "0x1898B6260", Slot = "33")]
		public override float Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x98B6270", Offset = "0x98B4C70", VA = "0x1898B6270", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x98B6410", Offset = "0x98B4E10", VA = "0x1898B6410")]
		public YZQHFEPLOOF()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
