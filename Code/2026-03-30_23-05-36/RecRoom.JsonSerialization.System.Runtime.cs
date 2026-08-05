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
	public abstract class QKJDSYDINCN<a> : JsonConverter<a> where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		protected delegate void ReaderAction(Utf8JsonReader r);

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B100", Offset = "0x5D29F00", VA = "0x185D2B100", Slot = "33")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B640", Offset = "0x5D2A440", VA = "0x185D2B640", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "41")]
		protected virtual void OGGTMXTQIVM(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "42")]
		protected virtual void QMJKSGCEWGX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "43")]
		public abstract void QRPUFPVUSQV(Utf8JsonReader a, JsonSerializerOptions b, string c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "44")]
		public abstract void FJGSYJKDYKS(Utf8JsonWriter a, a b, JsonSerializerOptions c);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B7E0", Offset = "0x5D2A5E0", VA = "0x185D2B7E0")]
		protected QKJDSYDINCN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class UnhandledJsonPropertyException : JsonException
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85722D0", Offset = "0x85710D0", VA = "0x1885722D0")]
		public UnhandledJsonPropertyException(string propertyName)
		{
		}
	}
}
namespace RecRoom.JsonSerialization
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class LCELALEUYQQ<a> : JsonConverter<Dictionary<a, int>> where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x544E7E0", Offset = "0x544D5E0", VA = "0x18544E7E0", Slot = "33")]
		public override Dictionary<a, int> Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x544EFD0", Offset = "0x544DDD0", VA = "0x18544EFD0", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, Dictionary<a, int> value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x544F1C0", Offset = "0x544DFC0", VA = "0x18544F1C0")]
		public LCELALEUYQQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class ZWBTZNWUHPI<a> : JsonConverter<a[]> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x401FDB0", Offset = "0x401EBB0", VA = "0x18401FDB0", Slot = "33")]
		public override a[] Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x40201F0", Offset = "0x401EFF0", VA = "0x1840201F0", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a[] value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x40202E0", Offset = "0x401F0E0", VA = "0x1840202E0")]
		protected ZWBTZNWUHPI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class NEFXLXIPBUR<a> : JsonConverter<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected abstract int GREWHVQIKRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int? QPRFUWXOXUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACD980", VA = "0x180ACEB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "42")]
		protected abstract a GEWJLYXEEMR(float[] a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "43")]
		protected abstract float[] IIRRLYITOVY(a a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x59E6490", Offset = "0x59E5290", VA = "0x1859E6490", Slot = "33")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x59E6C30", Offset = "0x59E5A30", VA = "0x1859E6C30", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x59E6D60", Offset = "0x59E5B60", VA = "0x1859E6D60")]
		protected NEFXLXIPBUR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class METIWXCUZIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85722A0", Offset = "0x85710A0", VA = "0x1885722A0")]
		public static void VUTCUEQTDLX(this Utf8JsonWriter a, string b, bool c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8571F80", Offset = "0x8570D80", VA = "0x188571F80")]
		public static bool CKWGRHRBXSI(this Utf8JsonReader a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8571FA0", Offset = "0x8570DA0", VA = "0x188571FA0")]
		public static void EYSHDQJWGOJ(this Utf8JsonWriter a, string b, int? c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85721F0", Offset = "0x8570FF0", VA = "0x1885721F0")]
		public static void GVXCVSRGCKT(this Utf8JsonWriter a, string b, long? c, long d = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3879530", Offset = "0x3878330", VA = "0x183879530")]
		public static void MEKQKQWKTXM<a>(this Utf8JsonWriter a, string b, JsonSerializerOptions c, a d, a e) where a : IEquatable<a>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8572050", Offset = "0x8570E50", VA = "0x188572050")]
		public static void FHFBCMNTYCT(this Utf8JsonWriter a, float b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class DDIUPFTMLOL<a> : JsonConverter<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x417F370", Offset = "0x417E170", VA = "0x18417F370", Slot = "33")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x417F3F0", Offset = "0x417E1F0", VA = "0x18417F3F0", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x417F5A0", Offset = "0x417E3A0", VA = "0x18417F5A0")]
		public DDIUPFTMLOL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class KBKDASXYNVV : JsonConverter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int MHOYBXJDBWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAF6F50", Offset = "0xAF5D50", VA = "0x180AF6F50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xBC2620", Offset = "0xBC1420", VA = "0x180BC2620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8571D90", Offset = "0x8570B90", VA = "0x188571D90", Slot = "33")]
		public override float Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8571DA0", Offset = "0x8570BA0", VA = "0x188571DA0", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8571F40", Offset = "0x8570D40", VA = "0x188571F40")]
		public KBKDASXYNVV()
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
