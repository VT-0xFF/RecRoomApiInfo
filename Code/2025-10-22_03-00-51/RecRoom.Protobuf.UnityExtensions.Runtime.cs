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
	public static class UFUGLIQGUQK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD8E0", Offset = "0x8CBBEE0", VA = "0x188CBD8E0")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD8B0", Offset = "0x8CBBEB0", VA = "0x188CBD8B0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD960", Offset = "0x8CBBF60", VA = "0x188CBD960")]
		public static Color? VRPADCYYROW(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class JTDBCISHBPW
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD510", Offset = "0x8CBBB10", VA = "0x188CBD510")]
		public static Quaternion XCDLGDMRROJ(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD380", Offset = "0x8CBB980", VA = "0x188CBD380")]
		public static DVPPXNCGIGY CHVSBAQXJIP(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD470", Offset = "0x8CBBA70", VA = "0x188CBD470")]
		public static Quaternion GDAIVNJJJME(DVPPXNCGIGY a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class LYQVJSGDJZV
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD790", Offset = "0x8CBBD90", VA = "0x188CBD790")]
		public static GTGTHLAQOQA Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD720", Offset = "0x8CBBD20", VA = "0x188CBD720")]
		public static Quaternion Deserialize(this GTGTHLAQOQA self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD810", Offset = "0x8CBBE10", VA = "0x188CBD810")]
		public static Quaternion? VRPADCYYROW(this GTGTHLAQOQA a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class XDSHMZSNWDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDA40", Offset = "0x8CBC040", VA = "0x188CBDA40")]
		public static LKRROYDXSRN Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD9E0", Offset = "0x8CBBFE0", VA = "0x188CBD9E0")]
		public static Vector2 Deserialize(this LKRROYDXSRN self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class BIFJPPMGRHV
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD1C0", Offset = "0x8CBB7C0", VA = "0x188CBD1C0")]
		public static DVPPXNCGIGY Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD230", Offset = "0x8CBB830", VA = "0x188CBD230")]
		public static DVPPXNCGIGY TZXUXBIEQNZ([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD150", Offset = "0x8CBB750", VA = "0x188CBD150")]
		public static Vector3 Deserialize(this DVPPXNCGIGY self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD2F0", Offset = "0x8CBB8F0", VA = "0x188CBD2F0")]
		public static Vector3? VRPADCYYROW(this DVPPXNCGIGY a)
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
