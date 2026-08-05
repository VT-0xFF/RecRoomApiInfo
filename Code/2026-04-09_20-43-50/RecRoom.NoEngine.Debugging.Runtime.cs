using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.NoEngine.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum CanConvertPredicate
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Assignable,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Equal
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal static class FRVTEVQBCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6CA0", Offset = "0x3AD5CA0", VA = "0x183AD6CA0")]
		public static Func<Type, bool> YGLYMTCBNHB<a>(this CanConvertPredicate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6C20", Offset = "0x3AD5C20", VA = "0x183AD6C20")]
		private static bool WAJDTLTIJMF<b>(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6BC0", Offset = "0x3AD5BC0", VA = "0x183AD6BC0")]
		private static bool SBKVWYWBVDO<c>(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ATZZEMOBNRN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x337DC90", Offset = "0x337CC90", VA = "0x18337DC90")]
		public static string MVGPFTQVXYC<a>(a a, string b = ", ", [Optional] a c) where a : struct, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x337E0F0", Offset = "0x337D0F0", VA = "0x18337E0F0")]
		public static string TRGCPVBSEYJ<b>(b a, string b = ", ", params b[] excludeFlags) where b : struct, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x337E630", Offset = "0x337D630", VA = "0x18337E630")]
		private static bool ZEOWDOAMRNJ<c>(c[] a, c b, IEqualityComparer<c> c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class WXUICUFSWFU<a> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Func<Type, bool> ORQEMVEWJDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Action<JsonWriter, a> ZHXCEFHTPRZ;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B22520", Offset = "0x2B21520", VA = "0x182B22520", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x512A370", Offset = "0x5129370", VA = "0x18512A370", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x877A070", Offset = "0x8779070", VA = "0x18877A070", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72FFA50", Offset = "0x72FEA50", VA = "0x1872FFA50")]
		internal WXUICUFSWFU(Func<Type, bool> a, Action<JsonWriter, a> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class TMLUJEHOXRT
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3F68DE0", Offset = "0x3F67DE0", VA = "0x183F68DE0")]
		public static WXUICUFSWFU<T> New<T>(Action<JsonWriter, T> writeJsonAction, CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class ULEHGGZJNDR
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static JsonConverter[] HHKHWLEAWKX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static JsonConverter JJNWSWHMVPM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9B5C450", Offset = "0x9B5B450", VA = "0x189B5C450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static JsonConverter DDHFLHGUGKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9B5C4F0", Offset = "0x9B5B4F0", VA = "0x189B5C4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter YTKWLZREMHM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9B5C400", Offset = "0x9B5B400", VA = "0x189B5C400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static JsonConverter YHGFAHWWQGE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9B5C3B0", Offset = "0x9B5B3B0", VA = "0x189B5C3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static JsonConverter FVKTISLFXIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9B5C4A0", Offset = "0x9B5B4A0", VA = "0x189B5C4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class OKTKWUFGAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9B5BE00", Offset = "0x9B5AE00", VA = "0x189B5BE00")]
		public static string CHXHDIHGCOC(this object a, JsonConverter[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class CPHQHKIOJLH<a> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Func<Type, bool> ORQEMVEWJDZ;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B22520", Offset = "0x2B21520", VA = "0x182B22520", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x512A370", Offset = "0x5129370", VA = "0x18512A370", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x512A430", Offset = "0x5129430", VA = "0x18512A430", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
		internal CPHQHKIOJLH(Func<Type, bool> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class EVCUYXWHDQC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3953F10", Offset = "0x3952F10", VA = "0x183953F10")]
		public static CPHQHKIOJLH<T> New<T>(CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class SLKYPYQZOLT : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Func<Type, bool> ORQEMVEWJDZ;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B22520", Offset = "0x2B21520", VA = "0x182B22520", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B5BE60", Offset = "0x9B5AE60", VA = "0x189B5BE60", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B5BF00", Offset = "0x9B5AF00", VA = "0x189B5BF00", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
		public SLKYPYQZOLT(Func<Type, bool> a)
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
