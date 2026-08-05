using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Protobuf.Core;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Protobuf.UnityExtensions
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class VEHLEXJPBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8981790", Offset = "0x8980390", VA = "0x188981790")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8981760", Offset = "0x8980360", VA = "0x188981760")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89816E0", Offset = "0x89802E0", VA = "0x1889816E0")]
		public static Color? AJFCFXLCFNR(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class TSPMGJILOXX
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8981340", Offset = "0x897FF40", VA = "0x188981340")]
		public static Quaternion ASXBKTIXGXS(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89815F0", Offset = "0x89801F0", VA = "0x1889815F0")]
		public static QSKCGVGRJKV OGMUAJOSRYY(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8981550", Offset = "0x8980150", VA = "0x188981550")]
		public static Quaternion KFHEMBDLKAX(QSKCGVGRJKV a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class OIFBEWHWHAW
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8980FC0", Offset = "0x897FBC0", VA = "0x188980FC0")]
		public static YMSECXBJFFB Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8980F50", Offset = "0x897FB50", VA = "0x188980F50")]
		public static Quaternion Deserialize(this YMSECXBJFFB self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8980EB0", Offset = "0x897FAB0", VA = "0x188980EB0")]
		public static Quaternion? AJFCFXLCFNR(this YMSECXBJFFB a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class OWNVEWVZHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89810A0", Offset = "0x897FCA0", VA = "0x1889810A0")]
		public static WDVDAQRJHBU Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8981040", Offset = "0x897FC40", VA = "0x188981040")]
		public static Vector2 Deserialize(this WDVDAQRJHBU self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class RREUNBLAFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89812D0", Offset = "0x897FED0", VA = "0x1889812D0")]
		public static QSKCGVGRJKV Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x89811A0", Offset = "0x897FDA0", VA = "0x1889811A0")]
		public static QSKCGVGRJKV CYZGNIUNWHE([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8981260", Offset = "0x897FE60", VA = "0x188981260")]
		public static Vector3 Deserialize(this QSKCGVGRJKV self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8981110", Offset = "0x897FD10", VA = "0x188981110")]
		public static Vector3? AJFCFXLCFNR(this QSKCGVGRJKV a)
		{
			return null;
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
