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
	internal static class USFJQSTHCTY
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3C132A0", Offset = "0x3C122A0", VA = "0x183C132A0")]
		public static Func<Type, bool> QHMRRUQQKKY<a>(this CanConvertPredicate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3C13330", Offset = "0x3C12330", VA = "0x183C13330")]
		private static bool QVYKWVZDLRU<b>(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3C133B0", Offset = "0x3C123B0", VA = "0x183C133B0")]
		private static bool XIKBUVPKMAN<c>(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ULYIPSXGOMQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C460", Offset = "0x3C0B460", VA = "0x183C0C460")]
		public static string HIBUSCVIQST<a>(a a, string b = ", ", [Optional] a c) where a : struct, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3C0CC00", Offset = "0x3C0BC00", VA = "0x183C0CC00")]
		public static string XHIHRILKBUE<b>(b a, string b = ", ", params b[] excludeFlags) where b : struct, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C700", Offset = "0x3C0B700", VA = "0x183C0C700")]
		private static bool QBTOYQAXKMG<c>(c[] a, c b, IEqualityComparer<c> c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class AMETQGZOBMX<a> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Func<Type, bool> VNKPZEUXJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Action<JsonWriter, a> MXCKXIWIZFA;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28AF030", Offset = "0x28AE030", VA = "0x1828AF030", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x421A6D0", Offset = "0x42196D0", VA = "0x18421A6D0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x58B5360", Offset = "0x58B4360", VA = "0x1858B5360", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x58B5940", Offset = "0x58B4940", VA = "0x1858B5940")]
		internal AMETQGZOBMX(Func<Type, bool> a, Action<JsonWriter, a> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class WMKCLIOVLRC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3C5E510", Offset = "0x3C5D510", VA = "0x183C5E510")]
		public static AMETQGZOBMX<T> New<T>(Action<JsonWriter, T> writeJsonAction, CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class COUKXTKDJSE
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static JsonConverter[] DPUTXAFWZZE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static JsonConverter CHRHNKVIQFT
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x85F5000", Offset = "0x85F4000", VA = "0x1885F5000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static JsonConverter MGYOFRQATNS
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F10", Offset = "0x85F3F10", VA = "0x1885F4F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter DPILMKDPWBV
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x85F4FB0", Offset = "0x85F3FB0", VA = "0x1885F4FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static JsonConverter XQKIWRDSCRX
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F60", Offset = "0x85F3F60", VA = "0x1885F4F60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static JsonConverter UEBZZEEKXBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x85F4EC0", Offset = "0x85F3EC0", VA = "0x1885F4EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ZHXVAAJTBTV
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85F5A90", Offset = "0x85F4A90", VA = "0x1885F5A90")]
		public static string CHYTRDTTQHF(this object a, JsonConverter[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class DDAYDZDGNFK<a> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Func<Type, bool> VNKPZEUXJMM;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28AF030", Offset = "0x28AE030", VA = "0x1828AF030", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x421A6D0", Offset = "0x42196D0", VA = "0x18421A6D0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x421A9C0", Offset = "0x42199C0", VA = "0x18421A9C0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
		internal DDAYDZDGNFK(Func<Type, bool> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class WLNARQVGQFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5DE40", Offset = "0x3C5CE40", VA = "0x183C5DE40")]
		public static DDAYDZDGNFK<T> New<T>(CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class WKGCCRUWXKS : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Func<Type, bool> VNKPZEUXJMM;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28AF030", Offset = "0x28AE030", VA = "0x1828AF030", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85F5980", Offset = "0x85F4980", VA = "0x1885F5980", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85F5A20", Offset = "0x85F4A20", VA = "0x1885F5A20", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
		public WKGCCRUWXKS(Func<Type, bool> a)
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
