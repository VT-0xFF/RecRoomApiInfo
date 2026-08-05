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
		[Cpp2IlInjected.Address(RVA = "0xA006550", Offset = "0xA005350", VA = "0x18A006550")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA0064A0", Offset = "0xA0052A0", VA = "0x18A0064A0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA0064D0", Offset = "0xA0052D0", VA = "0x18A0064D0")]
		public static Color? ETYBFQMFYMB(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EFBLNZVWCZB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA005EA0", Offset = "0xA004CA0", VA = "0x18A005EA0")]
		public static Quaternion IBFZQZMPBCO(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA006150", Offset = "0xA004F50", VA = "0x18A006150")]
		public static URRJCBPFJTN WTMNULQSGEO(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA0060B0", Offset = "0xA004EB0", VA = "0x18A0060B0")]
		public static Quaternion OXLQITBVKYB(URRJCBPFJTN a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class OPNQRVSLBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA006420", Offset = "0xA005220", VA = "0x18A006420")]
		public static UAHNIFRSNPX Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA006310", Offset = "0xA005110", VA = "0x18A006310")]
		public static Quaternion Deserialize(this UAHNIFRSNPX self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA006380", Offset = "0xA005180", VA = "0x18A006380")]
		public static Quaternion? ETYBFQMFYMB(this UAHNIFRSNPX a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class FNLMCNWHZDV
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA0062A0", Offset = "0xA0050A0", VA = "0x18A0062A0")]
		public static KFOUIJMILZO Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA006240", Offset = "0xA005040", VA = "0x18A006240")]
		public static Vector2 Deserialize(this KFOUIJMILZO self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class BIYJZYCPDZM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA005E30", Offset = "0xA004C30", VA = "0x18A005E30")]
		public static URRJCBPFJTN Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA005D70", Offset = "0xA004B70", VA = "0x18A005D70")]
		public static URRJCBPFJTN IIGOGPJRXVG([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA005C70", Offset = "0xA004A70", VA = "0x18A005C70")]
		public static Vector3 Deserialize(this URRJCBPFJTN self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA005CE0", Offset = "0xA004AE0", VA = "0x18A005CE0")]
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
