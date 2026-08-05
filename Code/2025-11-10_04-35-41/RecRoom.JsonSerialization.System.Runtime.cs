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
	public abstract class PFMSNKNZQGX<a> : JsonConverter<a> where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		protected delegate void ReaderAction(Utf8JsonReader r);

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5A4C830", Offset = "0x5A4BC30", VA = "0x185A4C830", Slot = "27")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5A4CD50", Offset = "0x5A4C150", VA = "0x185A4CD50", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "35")]
		protected virtual void FNLOEPMEXGU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "36")]
		protected virtual void IBHEUPEUSLP(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "37")]
		public abstract void GFFURHXYULF(Utf8JsonReader a, JsonSerializerOptions b, string c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "38")]
		public abstract void IXFRZQSWTFC(Utf8JsonWriter a, a b, JsonSerializerOptions c);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5A4CEF0", Offset = "0x5A4C2F0", VA = "0x185A4CEF0")]
		protected PFMSNKNZQGX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class UnhandledJsonPropertyException : JsonException
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82D3A20", Offset = "0x82D2E20", VA = "0x1882D3A20")]
		public UnhandledJsonPropertyException(string propertyName)
		{
		}
	}
}
namespace RecRoom.JsonSerialization
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class YWAXMQRYCES<a> : JsonConverter<Dictionary<a, int>> where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E79B00", Offset = "0x3E78F00", VA = "0x183E79B00", Slot = "27")]
		public override Dictionary<a, int> Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3E79EF0", Offset = "0x3E792F0", VA = "0x183E79EF0", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, Dictionary<a, int> value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A4A0", Offset = "0x3E798A0", VA = "0x183E7A4A0")]
		public YWAXMQRYCES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class LWWLTYTASPO<a> : JsonConverter<a[]> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5308760", Offset = "0x5307B60", VA = "0x185308760", Slot = "27")]
		public override a[] Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x53089C0", Offset = "0x5307DC0", VA = "0x1853089C0", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, a[] value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5308C80", Offset = "0x5308080", VA = "0x185308C80")]
		protected LWWLTYTASPO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class JKZZNMDYWFF<a> : JsonConverter<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected abstract int ULFDSOUXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int? KLSLZTOIAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "36")]
		protected abstract a HFRUWNVOGUH(float[] a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "37")]
		protected abstract float[] GIRNOEINUDS(a a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5103B10", Offset = "0x5102F10", VA = "0x185103B10", Slot = "27")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51042A0", Offset = "0x51036A0", VA = "0x1851042A0", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5104410", Offset = "0x5103810", VA = "0x185104410")]
		protected JKZZNMDYWFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class NCCGBCYTHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82D3940", Offset = "0x82D2D40", VA = "0x1882D3940")]
		public static void RRQJCAZZUIX(this Utf8JsonWriter a, string b, bool c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82D3920", Offset = "0x82D2D20", VA = "0x1882D3920")]
		public static bool NATSWCPAFAW(this Utf8JsonReader a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82D36D0", Offset = "0x82D2AD0", VA = "0x1882D36D0")]
		public static void BSZVKHSUNSH(this Utf8JsonWriter a, string b, int? c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82D3970", Offset = "0x82D2D70", VA = "0x1882D3970")]
		public static void ZWWVIQSCZMJ(this Utf8JsonWriter a, string b, long? c, long d = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x381D4A0", Offset = "0x381C8A0", VA = "0x18381D4A0")]
		public static void VITMANYKZNC<a>(this Utf8JsonWriter a, string b, JsonSerializerOptions c, a d, a e) where a : IEquatable<a>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82D3780", Offset = "0x82D2B80", VA = "0x1882D3780")]
		public static void HGBIXDTQHIZ(this Utf8JsonWriter a, float b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class HHNDEUNLBAF<a> : JsonConverter<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4F458B0", Offset = "0x4F44CB0", VA = "0x184F458B0", Slot = "27")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4F45A20", Offset = "0x4F44E20", VA = "0x184F45A20", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4F45AB0", Offset = "0x4F44EB0", VA = "0x184F45AB0")]
		public HHNDEUNLBAF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MMSRNAZSZFD : JsonConverter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int JTXOFNVXYBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAAF7F0", Offset = "0xAAEBF0", VA = "0x180AAF7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82D34E0", Offset = "0x82D28E0", VA = "0x1882D34E0", Slot = "27")]
		public override float Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82D34F0", Offset = "0x82D28F0", VA = "0x1882D34F0", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82D3690", Offset = "0x82D2A90", VA = "0x1882D3690")]
		public MMSRNAZSZFD()
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
