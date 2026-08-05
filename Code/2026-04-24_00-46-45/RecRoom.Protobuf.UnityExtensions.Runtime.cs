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
	public static class ZYADXKLIWJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA190A90", Offset = "0xA18F490", VA = "0x18A190A90")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA190A60", Offset = "0xA18F460", VA = "0x18A190A60")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA190B10", Offset = "0xA18F510", VA = "0x18A190B10")]
		public static Color? ZXWVBSAGXSU(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class SETTCQZDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA190780", Offset = "0xA18F180", VA = "0x18A190780")]
		public static Quaternion SODWMVYQUHN(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA190690", Offset = "0xA18F090", VA = "0x18A190690")]
		public static QPTCXVGOMKO LQVICWAVTZD(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1905F0", Offset = "0xA18EFF0", VA = "0x18A1905F0")]
		public static Quaternion JYHZBXVJNLU(QPTCXVGOMKO a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class IEBDAITAKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1904D0", Offset = "0xA18EED0", VA = "0x18A1904D0")]
		public static RTTALYPRWDY Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA190460", Offset = "0xA18EE60", VA = "0x18A190460")]
		public static Quaternion Deserialize(this RTTALYPRWDY self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA190550", Offset = "0xA18EF50", VA = "0x18A190550")]
		public static Quaternion? ZXWVBSAGXSU(this RTTALYPRWDY a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class WOUMUFNDXXK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1909F0", Offset = "0xA18F3F0", VA = "0x18A1909F0")]
		public static NQXPIBXDGLX Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA190990", Offset = "0xA18F390", VA = "0x18A190990")]
		public static Vector2 Deserialize(this NQXPIBXDGLX self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class HXPELRRVSVX
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA1902A0", Offset = "0xA18ECA0", VA = "0x18A1902A0")]
		public static QPTCXVGOMKO Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA190310", Offset = "0xA18ED10", VA = "0x18A190310")]
		public static QPTCXVGOMKO ZQQMMDYZROB([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA190230", Offset = "0xA18EC30", VA = "0x18A190230")]
		public static Vector3 Deserialize(this QPTCXVGOMKO self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA1903D0", Offset = "0xA18EDD0", VA = "0x18A1903D0")]
		public static Vector3? ZXWVBSAGXSU(this QPTCXVGOMKO a)
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
