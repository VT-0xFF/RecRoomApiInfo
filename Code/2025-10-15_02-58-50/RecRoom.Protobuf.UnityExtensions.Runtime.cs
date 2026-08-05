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
	public static class QXOEPOFMBCV
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E120", Offset = "0x8C3CF20", VA = "0x188C3E120")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E0F0", Offset = "0x8C3CEF0", VA = "0x188C3E0F0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E1A0", Offset = "0x8C3CFA0", VA = "0x188C3E1A0")]
		public static Color? XDRKQRPYWXR(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class IKRYWLTEDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DB20", Offset = "0x8C3C920", VA = "0x188C3DB20")]
		public static Quaternion ACCSJQGYTIE(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DD30", Offset = "0x8C3CB30", VA = "0x188C3DD30")]
		public static HETCKYUXLUB CIICEJBZOXO(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DE20", Offset = "0x8C3CC20", VA = "0x188C3DE20")]
		public static Quaternion IGBHOCHRACT(HETCKYUXLUB a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class RTPGDRMDOQK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E290", Offset = "0x8C3D090", VA = "0x188C3E290")]
		public static DMMSBOJUDYL Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E220", Offset = "0x8C3D020", VA = "0x188C3E220")]
		public static Quaternion Deserialize(this DMMSBOJUDYL self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E310", Offset = "0x8C3D110", VA = "0x188C3E310")]
		public static Quaternion? XDRKQRPYWXR(this DMMSBOJUDYL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class UDJQXGOINSJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E410", Offset = "0x8C3D210", VA = "0x188C3E410")]
		public static SZPDAVUYAZA Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E3B0", Offset = "0x8C3D1B0", VA = "0x188C3E3B0")]
		public static Vector2 Deserialize(this SZPDAVUYAZA self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class IYPCNBLAFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DF30", Offset = "0x8C3CD30", VA = "0x188C3DF30")]
		public static HETCKYUXLUB Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E030", Offset = "0x8C3CE30", VA = "0x188C3E030")]
		public static HETCKYUXLUB YEMYFMOPVPA([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DEC0", Offset = "0x8C3CCC0", VA = "0x188C3DEC0")]
		public static Vector3 Deserialize(this HETCKYUXLUB self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DFA0", Offset = "0x8C3CDA0", VA = "0x188C3DFA0")]
		public static Vector3? XDRKQRPYWXR(this HETCKYUXLUB a)
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
