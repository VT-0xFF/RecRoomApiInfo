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
	internal static class MTDXPONMGZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3A9E2A0", Offset = "0x3A9D2A0", VA = "0x183A9E2A0")]
		public static Func<Type, bool> TXAPMKNMKDQ<a>(this CanConvertPredicate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3A9E220", Offset = "0x3A9D220", VA = "0x183A9E220")]
		private static bool LSXLGHBOFCI<b>(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3A9E330", Offset = "0x3A9D330", VA = "0x183A9E330")]
		private static bool VRGEXIXRWJB<c>(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class DHRVJYBBOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x382CF50", Offset = "0x382BF50", VA = "0x18382CF50")]
		public static string CJTFUBJLTBP<a>(a a, string b = ", ", [Optional] a c) where a : struct, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x382D700", Offset = "0x382C700", VA = "0x18382D700")]
		public static string XILPJSPAQLI<b>(b a, string b = ", ", params b[] excludeFlags) where b : struct, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x382D200", Offset = "0x382C200", VA = "0x18382D200")]
		private static bool NGYTHKMTVYU<c>(c[] a, c b, IEqualityComparer<c> c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class QJAPXGEPATH<a> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Func<Type, bool> AGJOKSXMRSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Action<JsonWriter, a> JVPWELLDKVW;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B09200", Offset = "0x2B08200", VA = "0x182B09200", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CC42F0", Offset = "0x5CC32F0", VA = "0x185CC42F0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E44CF0", Offset = "0x5E43CF0", VA = "0x185E44CF0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x58A2A40", Offset = "0x58A1A40", VA = "0x1858A2A40")]
		internal QJAPXGEPATH(Func<Type, bool> a, Action<JsonWriter, a> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class VBRTVMIENBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3F29D00", Offset = "0x3F28D00", VA = "0x183F29D00")]
		public static QJAPXGEPATH<T> New<T>(Action<JsonWriter, T> writeJsonAction, CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HRZOUUIREXM
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static JsonConverter[] BRHKOAQMKDC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static JsonConverter ZJEIWKFEIUL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8887AF0", Offset = "0x8886AF0", VA = "0x188887AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static JsonConverter KMRXQQEVSSW
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8887B90", Offset = "0x8886B90", VA = "0x188887B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter DCOEIEUVGAV
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8887B40", Offset = "0x8886B40", VA = "0x188887B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static JsonConverter WWVMLPOUJFF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8887AA0", Offset = "0x8886AA0", VA = "0x188887AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static JsonConverter JNVARKDXLTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8887A50", Offset = "0x8886A50", VA = "0x188887A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class GNPGTWJTFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88879F0", Offset = "0x88869F0", VA = "0x1888879F0")]
		public static string QYNVXMTHASZ(this object a, JsonConverter[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class ONDAZCITMWW<a> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Func<Type, bool> AGJOKSXMRSK;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B09200", Offset = "0x2B08200", VA = "0x182B09200", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC42F0", Offset = "0x5CC32F0", VA = "0x185CC42F0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC43B0", Offset = "0x5CC33B0", VA = "0x185CC43B0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
		internal ONDAZCITMWW(Func<Type, bool> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class EQYONJNEJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x387FEE0", Offset = "0x387EEE0", VA = "0x18387FEE0")]
		public static ONDAZCITMWW<T> New<T>(CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class WYCVZOYLUAU : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Func<Type, bool> AGJOKSXMRSK;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B09200", Offset = "0x2B08200", VA = "0x182B09200", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8888550", Offset = "0x8887550", VA = "0x188888550", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88885F0", Offset = "0x88875F0", VA = "0x1888885F0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
		public WYCVZOYLUAU(Func<Type, bool> a)
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
