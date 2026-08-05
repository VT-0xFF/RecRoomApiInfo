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
	public abstract class LWRIJZENKRR<a> : JsonConverter<a> where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		protected delegate void ReaderAction(Utf8JsonReader r);

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x697A0B0", Offset = "0x69790B0", VA = "0x18697A0B0", Slot = "33")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x697A2A0", Offset = "0x69792A0", VA = "0x18697A2A0", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "41")]
		protected virtual void TOHQEIVLYOI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "42")]
		protected virtual void IEVLMFHKPNX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "43")]
		public abstract void JCANTHJIKXF(Utf8JsonReader a, JsonSerializerOptions b, string c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "44")]
		public abstract void NGRKNORFQEQ(Utf8JsonWriter a, a b, JsonSerializerOptions c);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x697A440", Offset = "0x6979440", VA = "0x18697A440")]
		protected LWRIJZENKRR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class UnhandledJsonPropertyException : JsonException
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A07310", Offset = "0x9A06310", VA = "0x189A07310")]
		public UnhandledJsonPropertyException(string propertyName)
		{
		}
	}
}
namespace RecRoom.JsonSerialization
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SSELUPKMMVQ<a> : JsonConverter<Dictionary<a, int>> where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8440", Offset = "0x7AC7440", VA = "0x187AC8440", Slot = "33")]
		public override Dictionary<a, int> Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8C30", Offset = "0x7AC7C30", VA = "0x187AC8C30", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, Dictionary<a, int> value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8E20", Offset = "0x7AC7E20", VA = "0x187AC8E20")]
		public SSELUPKMMVQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class FMQWGTUXAMM<a> : JsonConverter<a[]> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62D5830", Offset = "0x62D4830", VA = "0x1862D5830", Slot = "33")]
		public override a[] Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62D5D30", Offset = "0x62D4D30", VA = "0x1862D5D30", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a[] value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x62D6000", Offset = "0x62D5000", VA = "0x1862D6000")]
		protected FMQWGTUXAMM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class UOTHDSIMLPN<a> : JsonConverter<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected abstract int XKLXOHCJQTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int? JBWFJRJVIMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCF4140", Offset = "0xCF3140", VA = "0x180CF4140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "42")]
		protected abstract a YCXOVXZBLRZ(float[] a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "43")]
		protected abstract float[] TTMPAXROIBO(a a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F18BB0", Offset = "0x7F17BB0", VA = "0x187F18BB0", Slot = "33")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7F19670", Offset = "0x7F18670", VA = "0x187F19670", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F197A0", Offset = "0x7F187A0", VA = "0x187F197A0")]
		protected UOTHDSIMLPN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ECHTLGGOZEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A070D0", Offset = "0x9A060D0", VA = "0x189A070D0")]
		public static void WXQQRWPQNPV(this Utf8JsonWriter a, string b, bool c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A07100", Offset = "0x9A06100", VA = "0x189A07100")]
		public static bool YVJBQUIYMRA(this Utf8JsonReader a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A07020", Offset = "0x9A06020", VA = "0x189A07020")]
		public static void QTHYWSUJPRB(this Utf8JsonWriter a, string b, int? c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A06F70", Offset = "0x9A05F70", VA = "0x189A06F70")]
		public static void BWZMNAUTNUR(this Utf8JsonWriter a, string b, long? c, long d = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3945E40", Offset = "0x3944E40", VA = "0x183945E40")]
		public static void HGQNKROMNWI<a>(this Utf8JsonWriter a, string b, JsonSerializerOptions c, a d, a e) where a : IEquatable<a>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A06DD0", Offset = "0x9A05DD0", VA = "0x189A06DD0")]
		public static void BAQDNNPRTXL(this Utf8JsonWriter a, float b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class DPBLYZSKIRX<a> : JsonConverter<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x53BB410", Offset = "0x53BA410", VA = "0x1853BB410", Slot = "33")]
		public override a Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x53BB560", Offset = "0x53BA560", VA = "0x1853BB560", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, a value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x53BB6F0", Offset = "0x53BA6F0", VA = "0x1853BB6F0")]
		public DPBLYZSKIRX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class QLAQENITTVT : JsonConverter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int DMWYMHHEXKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD24DA0", Offset = "0xD23DA0", VA = "0x180D24DA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDEFC00", Offset = "0xDEEC00", VA = "0x180DEFC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A07120", Offset = "0x9A06120", VA = "0x189A07120", Slot = "33")]
		public override float Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9A07130", Offset = "0x9A06130", VA = "0x189A07130", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A072D0", Offset = "0x9A062D0", VA = "0x189A072D0")]
		public QLAQENITTVT()
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
