using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class UELWVGGWAGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly Guid DBZKLOEHGYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly string VWKKCLSDBTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly int GETJIFMFMES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly Guid FGCIJTKAMXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly CreationInstantiationParameters IBLJFPCKTLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Vector3 YXDTVKDCPWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Quaternion YUATHBUJRCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public Vector3 PYGRIUREBTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public bool AQWXACIRDJM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x847E000", Offset = "0x847D200", VA = "0x18847E000")]
		public UELWVGGWAGL(string a, Guid b, int c, Guid d, CreationInstantiationParameters e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x847DE50", Offset = "0x847D050", VA = "0x18847DE50")]
		public BNMTUOAYRPG AKWEWWLAUIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847DF00", Offset = "0x847D100", VA = "0x18847DF00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class AZCHXGHPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x847DCB0", Offset = "0x847CEB0", VA = "0x18847DCB0")]
		public static bool EWALRLTCOGF(this RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x847DE00", Offset = "0x847D000", VA = "0x18847DE00")]
		public static object[] MQBWUYEWDJP(this RRNetworkView a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x847DD90", Offset = "0x847CF90", VA = "0x18847DD90")]
		public static ViewId IWTGZLGGUAV(this RRNetworkView a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x847DCE0", Offset = "0x847CEE0", VA = "0x18847DCE0")]
		public static CreationInstantiationParameters GLCIBSBBLNT(this RRNetworkView a)
		{
			return default(CreationInstantiationParameters);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x847DE20", Offset = "0x847D020", VA = "0x18847DE20")]
		public static CreationInstantiationParameters YMROYSFDCWU(this RRObjectCreationParameters a)
		{
			return default(CreationInstantiationParameters);
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
