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
	public static class SBKJMIKPVZP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D40070", Offset = "0x8D3EE70", VA = "0x188D40070")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D40040", Offset = "0x8D3EE40", VA = "0x188D40040")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D400F0", Offset = "0x8D3EEF0", VA = "0x188D400F0")]
		public static Color? XIJNMENRMTR(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class XKRFULYBPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D40170", Offset = "0x8D3EF70", VA = "0x188D40170")]
		public static Quaternion DUKNONBBDBK(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D40380", Offset = "0x8D3F180", VA = "0x188D40380")]
		public static JWNXTQMLXBH KRUNAGFVQKQ(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D40470", Offset = "0x8D3F270", VA = "0x188D40470")]
		public static Quaternion YBSZMKINAGT(JWNXTQMLXBH a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class CWBHEJHVXTA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FC20", Offset = "0x8D3EA20", VA = "0x188D3FC20")]
		public static PXCHFCBZFDF Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FBB0", Offset = "0x8D3E9B0", VA = "0x188D3FBB0")]
		public static Quaternion Deserialize(this PXCHFCBZFDF self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FCA0", Offset = "0x8D3EAA0", VA = "0x188D3FCA0")]
		public static Quaternion? XIJNMENRMTR(this PXCHFCBZFDF a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class DBATKYBSEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FDA0", Offset = "0x8D3EBA0", VA = "0x188D3FDA0")]
		public static MVJLJJVXCZY Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FD40", Offset = "0x8D3EB40", VA = "0x188D3FD40")]
		public static Vector2 Deserialize(this MVJLJJVXCZY self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class RSGBTLXAJBW
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FF40", Offset = "0x8D3ED40", VA = "0x188D3FF40")]
		public static JWNXTQMLXBH Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FE10", Offset = "0x8D3EC10", VA = "0x188D3FE10")]
		public static JWNXTQMLXBH DUDMTAEQWGW([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FED0", Offset = "0x8D3ECD0", VA = "0x188D3FED0")]
		public static Vector3 Deserialize(this JWNXTQMLXBH self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FFB0", Offset = "0x8D3EDB0", VA = "0x188D3FFB0")]
		public static Vector3? XIJNMENRMTR(this JWNXTQMLXBH a)
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
