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
	public static class SVYESBTFEXM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3470", Offset = "0x8CE2270", VA = "0x188CE3470")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3440", Offset = "0x8CE2240", VA = "0x188CE3440")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8CE34F0", Offset = "0x8CE22F0", VA = "0x188CE34F0")]
		public static Color? XPQBEIDJAVM(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class VXJQYTTGYTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3700", Offset = "0x8CE2500", VA = "0x188CE3700")]
		public static Quaternion YFJFHCXECEB(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3610", Offset = "0x8CE2410", VA = "0x188CE3610")]
		public static KLMPUSQCLCU YCKYERHKGBJ(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3570", Offset = "0x8CE2370", VA = "0x188CE3570")]
		public static Quaternion IGSIWTEDRJS(KLMPUSQCLCU a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class BGQPLJTPKRR
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3020", Offset = "0x8CE1E20", VA = "0x188CE3020")]
		public static JAZTGBOHMAQ Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CE2FB0", Offset = "0x8CE1DB0", VA = "0x188CE2FB0")]
		public static Quaternion Deserialize(this JAZTGBOHMAQ self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8CE30A0", Offset = "0x8CE1EA0", VA = "0x188CE30A0")]
		public static Quaternion? XPQBEIDJAVM(this JAZTGBOHMAQ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class IUPPEVBCRQW
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE33D0", Offset = "0x8CE21D0", VA = "0x188CE33D0")]
		public static WXLBPARAGPJ Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3370", Offset = "0x8CE2170", VA = "0x188CE3370")]
		public static Vector2 Deserialize(this WXLBPARAGPJ self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class CPOQDRAMZBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3270", Offset = "0x8CE2070", VA = "0x188CE3270")]
		public static KLMPUSQCLCU Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3140", Offset = "0x8CE1F40", VA = "0x188CE3140")]
		public static KLMPUSQCLCU AIAYFXWIVKT([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3200", Offset = "0x8CE2000", VA = "0x188CE3200")]
		public static Vector3 Deserialize(this KLMPUSQCLCU self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8CE32E0", Offset = "0x8CE20E0", VA = "0x188CE32E0")]
		public static Vector3? XPQBEIDJAVM(this KLMPUSQCLCU a)
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
