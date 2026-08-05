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
	public abstract class QLVPVVZKKQE<a> : JsonConverter<a> where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		protected delegate void ReaderAction(Utf8JsonReader r);

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5E45D00", Offset = "0x5E44D00", VA = "0x185E45D00", Slot = "27")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E46250", Offset = "0x5E45250", VA = "0x185E46250", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "35")]
		protected virtual void FBBGKAJBDYJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "36")]
		protected virtual void PBVIJXTLKOI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "37")]
		public abstract void KUTBXMLHIZK(Utf8JsonReader a, JsonSerializerOptions b, string c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "38")]
		public abstract void AIJQTIWFUND(Utf8JsonWriter a, a b, JsonSerializerOptions c);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E46400", Offset = "0x5E45400", VA = "0x185E46400")]
		protected QLVPVVZKKQE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class UnhandledJsonPropertyException : JsonException
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x876D200", Offset = "0x876C200", VA = "0x18876D200")]
		public UnhandledJsonPropertyException(string propertyName)
		{
		}
	}
}
namespace RecRoom.JsonSerialization
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class QGIOEMWWJJT<a> : JsonConverter<Dictionary<a, int>> where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E423F0", Offset = "0x5E413F0", VA = "0x185E423F0", Slot = "27")]
		public override Dictionary<a, int> Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E42990", Offset = "0x5E41990", VA = "0x185E42990", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, Dictionary<a, int> value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E42BA0", Offset = "0x5E41BA0", VA = "0x185E42BA0")]
		public QGIOEMWWJJT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class KBVYVSBYKNP<a> : JsonConverter<a[]> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x55064C0", Offset = "0x55054C0", VA = "0x1855064C0", Slot = "27")]
		public override a[] Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5506910", Offset = "0x5505910", VA = "0x185506910", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, a[] value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5506A00", Offset = "0x5505A00", VA = "0x185506A00")]
		protected KBVYVSBYKNP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class MICNPJDMHKS<a> : JsonConverter<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected abstract int ZRHYXWVKFWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int? UNPJKJRFZTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAD8BD0", Offset = "0xAD7BD0", VA = "0x180AD8BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "36")]
		protected abstract a PQREPMRYHDY(float[] a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "37")]
		protected abstract float[] BYZVBLKPVJH(a a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1360", Offset = "0x5AE0360", VA = "0x185AE1360", Slot = "27")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1F70", Offset = "0x5AE0F70", VA = "0x185AE1F70", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2330", Offset = "0x5AE1330", VA = "0x185AE2330")]
		protected MICNPJDMHKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EUMXDKODJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x876CCC0", Offset = "0x876BCC0", VA = "0x18876CCC0")]
		public static void CUNDZAXVQWI(this Utf8JsonWriter a, string b, bool c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x876CFF0", Offset = "0x876BFF0", VA = "0x18876CFF0")]
		public static bool ZBPXLEALBJH(this Utf8JsonReader a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x876CCF0", Offset = "0x876BCF0", VA = "0x18876CCF0")]
		public static void DWRXQNSHMQQ(this Utf8JsonWriter a, string b, int? c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x876CDA0", Offset = "0x876BDA0", VA = "0x18876CDA0")]
		public static void SMZSESWAFCK(this Utf8JsonWriter a, string b, long? c, long d = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3880FA0", Offset = "0x387FFA0", VA = "0x183880FA0")]
		public static void POEHXGAVRBX<a>(this Utf8JsonWriter a, string b, JsonSerializerOptions c, a d, a e) where a : IEquatable<a>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x876CE50", Offset = "0x876BE50", VA = "0x18876CE50")]
		public static void WHTZIZIGKWC(this Utf8JsonWriter a, float b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class WUFRYTVZIZI<a> : JsonConverter<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A61D10", Offset = "0x6A60D10", VA = "0x186A61D10", Slot = "27")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A61F50", Offset = "0x6A60F50", VA = "0x186A61F50", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A61FF0", Offset = "0x6A60FF0", VA = "0x186A61FF0")]
		public WUFRYTVZIZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class KBLECXJKLOI : JsonConverter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int JVCMUMKTMEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xACFF50", Offset = "0xACEF50", VA = "0x180ACFF50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xACFF80", Offset = "0xACEF80", VA = "0x180ACFF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x876D010", Offset = "0x876C010", VA = "0x18876D010", Slot = "27")]
		public override float Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x876D020", Offset = "0x876C020", VA = "0x18876D020", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x876D1C0", Offset = "0x876C1C0", VA = "0x18876D1C0")]
		public KBLECXJKLOI()
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
