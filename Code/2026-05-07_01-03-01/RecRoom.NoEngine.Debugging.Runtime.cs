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
	internal static class GNNBUKQDGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBF90", Offset = "0x3AEA990", VA = "0x183AEBF90")]
		public static Func<Type, bool> LRRJEGKSVPV<a>(this CanConvertPredicate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBF10", Offset = "0x3AEA910", VA = "0x183AEBF10")]
		private static bool IVIRWVZZIRD<b>(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBEB0", Offset = "0x3AEA8B0", VA = "0x183AEBEB0")]
		private static bool EBRXXCIGSTW<c>(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class GDAPJGXVUNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0560", Offset = "0x3ADEF60", VA = "0x183AE0560")]
		public static string KUNDRWKKCUK<a>(a a, string b = ", ", [Optional] a c) where a : struct, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3AE00B0", Offset = "0x3ADEAB0", VA = "0x183AE00B0")]
		public static string AKANOTATDFP<b>(b a, string b = ", ", params b[] excludeFlags) where b : struct, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0810", Offset = "0x3ADF210", VA = "0x183AE0810")]
		private static bool XDBZNXOCNPJ<c>(c[] a, c b, IEqualityComparer<c> c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class GUCBXTUPWDU<a> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Func<Type, bool> XHNLIIBJVCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Action<JsonWriter, a> HEMRRSCQODN;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BE10", Offset = "0x2B0A810", VA = "0x182B0BE10", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6449AB0", Offset = "0x64484B0", VA = "0x186449AB0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6449B70", Offset = "0x6448570", VA = "0x186449B70", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x644A220", Offset = "0x6448C20", VA = "0x18644A220")]
		internal GUCBXTUPWDU(Func<Type, bool> a, Action<JsonWriter, a> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class RKPGTSJHFBX
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E39A40", Offset = "0x3E38440", VA = "0x183E39A40")]
		public static GUCBXTUPWDU<T> New<T>(Action<JsonWriter, T> writeJsonAction, CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class MPELZARYOTZ
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static JsonConverter[] QVCWLBMJHKX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static JsonConverter GIBWYLOSZDY
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x99A0590", Offset = "0x999EF90", VA = "0x1899A0590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static JsonConverter CDXTGXYVKJP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x99A0540", Offset = "0x999EF40", VA = "0x1899A0540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter SWBKSYQJNNA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x99A04A0", Offset = "0x999EEA0", VA = "0x1899A04A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static JsonConverter MYBYMJOKMDW
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x99A05E0", Offset = "0x999EFE0", VA = "0x1899A05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static JsonConverter EKAHQZSWIDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x99A04F0", Offset = "0x999EEF0", VA = "0x1899A04F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MKFIBBAQLXM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99A0440", Offset = "0x999EE40", VA = "0x1899A0440")]
		public static string TTULRFTOFBU(this object a, JsonConverter[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class VCIZTCTHLSF<a> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Func<Type, bool> XHNLIIBJVCH;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BE10", Offset = "0x2B0A810", VA = "0x182B0BE10", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6449AB0", Offset = "0x64484B0", VA = "0x186449AB0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1FD0", Offset = "0x7EB09D0", VA = "0x187EB1FD0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
		internal VCIZTCTHLSF(Func<Type, bool> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class AFPLSVIPZYO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3362F80", Offset = "0x3361980", VA = "0x183362F80")]
		public static VCIZTCTHLSF<T> New<T>(CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class VZDYKNBXXLD : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Func<Type, bool> XHNLIIBJVCH;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BE10", Offset = "0x2B0A810", VA = "0x182B0BE10", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99A0F90", Offset = "0x999F990", VA = "0x1899A0F90", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99A1030", Offset = "0x999FA30", VA = "0x1899A1030", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
		public VZDYKNBXXLD(Func<Type, bool> a)
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
