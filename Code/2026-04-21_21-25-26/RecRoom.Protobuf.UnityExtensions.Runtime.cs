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
	public static class SFJUBMXTDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA189690", Offset = "0xA188090", VA = "0x18A189690")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1895E0", Offset = "0xA187FE0", VA = "0x18A1895E0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA189610", Offset = "0xA188010", VA = "0x18A189610")]
		public static Color? ETYBFQMFYMB(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EFBLNZVWCZB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA188FE0", Offset = "0xA1879E0", VA = "0x18A188FE0")]
		public static Quaternion IBFZQZMPBCO(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA189290", Offset = "0xA187C90", VA = "0x18A189290")]
		public static URRJCBPFJTN WTMNULQSGEO(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1891F0", Offset = "0xA187BF0", VA = "0x18A1891F0")]
		public static Quaternion OXLQITBVKYB(URRJCBPFJTN a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class OPNQRVSLBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA189560", Offset = "0xA187F60", VA = "0x18A189560")]
		public static UAHNIFRSNPX Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA189450", Offset = "0xA187E50", VA = "0x18A189450")]
		public static Quaternion Deserialize(this UAHNIFRSNPX self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA1894C0", Offset = "0xA187EC0", VA = "0x18A1894C0")]
		public static Quaternion? ETYBFQMFYMB(this UAHNIFRSNPX a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class FNLMCNWHZDV
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1893E0", Offset = "0xA187DE0", VA = "0x18A1893E0")]
		public static KFOUIJMILZO Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA189380", Offset = "0xA187D80", VA = "0x18A189380")]
		public static Vector2 Deserialize(this KFOUIJMILZO self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class BIYJZYCPDZM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA188F70", Offset = "0xA187970", VA = "0x18A188F70")]
		public static URRJCBPFJTN Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA188EB0", Offset = "0xA1878B0", VA = "0x18A188EB0")]
		public static URRJCBPFJTN IIGOGPJRXVG([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA188DB0", Offset = "0xA1877B0", VA = "0x18A188DB0")]
		public static Vector3 Deserialize(this URRJCBPFJTN self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA188E20", Offset = "0xA187820", VA = "0x18A188E20")]
		public static Vector3? ETYBFQMFYMB(this URRJCBPFJTN a)
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
