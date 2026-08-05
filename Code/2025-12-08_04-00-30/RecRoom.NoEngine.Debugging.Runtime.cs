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
	internal static class RCKDZIHHWYC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x395A170", Offset = "0x3958970", VA = "0x18395A170")]
		public static Func<Type, bool> EJUFSITENLW<a>(this CanConvertPredicate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x395A260", Offset = "0x3958A60", VA = "0x18395A260")]
		private static bool ZDCYATWBWGC<b>(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x395A200", Offset = "0x3958A00", VA = "0x18395A200")]
		private static bool MMGRMYUSKQB<c>(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class TYOBMADHZMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3A6D160", Offset = "0x3A6B960", VA = "0x183A6D160")]
		public static string TQOLVWDWOFJ<a>(a a, string b = ", ", [Optional] a c) where a : struct, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3A6CCB0", Offset = "0x3A6B4B0", VA = "0x183A6CCB0")]
		public static string KXVFTBEMFOU<b>(b a, string b = ", ", params b[] excludeFlags) where b : struct, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3A6C7B0", Offset = "0x3A6AFB0", VA = "0x183A6C7B0")]
		private static bool KDTDVOXYTNM<c>(c[] a, c b, IEqualityComparer<c> c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class TGNMCUDLJFB<a> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Func<Type, bool> AVSWCMPGJUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Action<JsonWriter, a> XSIERFVAPZE;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2847B80", Offset = "0x2846380", VA = "0x182847B80", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4CA1870", Offset = "0x4CA0070", VA = "0x184CA1870", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F0BE50", Offset = "0x5F0A650", VA = "0x185F0BE50", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x54B77E0", Offset = "0x54B5FE0", VA = "0x1854B77E0")]
		internal TGNMCUDLJFB(Func<Type, bool> a, Action<JsonWriter, a> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class ETXLRXYUKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x35A9DE0", Offset = "0x35A85E0", VA = "0x1835A9DE0")]
		public static TGNMCUDLJFB<T> New<T>(Action<JsonWriter, T> writeJsonAction, CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class GGOOHLQEXVS
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static JsonConverter[] ZFKELIQIJWG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static JsonConverter ZPJGPYOOQHL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x83976C0", Offset = "0x8395EC0", VA = "0x1883976C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static JsonConverter ZWYRIREHRWE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8397710", Offset = "0x8395F10", VA = "0x188397710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter VBIMSGPCNBF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8397760", Offset = "0x8395F60", VA = "0x188397760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static JsonConverter IKQTJDIATHD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x83977B0", Offset = "0x8395FB0", VA = "0x1883977B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static JsonConverter QYIIXLDASQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8397800", Offset = "0x8396000", VA = "0x188397800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class JIFVYGXRTLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8397E50", Offset = "0x8396650", VA = "0x188397E50")]
		public static string EOCWERJTYZF(this object a, JsonConverter[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class FVKRWYTYVSE<a> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Func<Type, bool> AVSWCMPGJUY;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2847B80", Offset = "0x2846380", VA = "0x182847B80", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4CA1870", Offset = "0x4CA0070", VA = "0x184CA1870", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4CA1930", Offset = "0x4CA0130", VA = "0x184CA1930", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
		internal FVKRWYTYVSE(Func<Type, bool> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class QFOOAUEGBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x394BDA0", Offset = "0x394A5A0", VA = "0x18394BDA0")]
		public static FVKRWYTYVSE<T> New<T>(CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class IGJUWINOCXA : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Func<Type, bool> AVSWCMPGJUY;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2847B80", Offset = "0x2846380", VA = "0x182847B80", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8397D40", Offset = "0x8396540", VA = "0x188397D40", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8397DE0", Offset = "0x83965E0", VA = "0x188397DE0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
		public IGJUWINOCXA(Func<Type, bool> a)
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
