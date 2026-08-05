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
	public class EBERGZJUJEV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly Guid VAEOVLKYMMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly string SHWHPNGRTGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly int EYXXGTVVFXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly Guid ZJVRDULGPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly CreationInstantiationParameters VLRYASQKIEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Vector3 ZBMVYNORTPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Quaternion BMLZZYLQLSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public Vector3 ALBYNQGLLDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public bool FXQUVMOSHJS;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8260CD0", Offset = "0x82600D0", VA = "0x188260CD0")]
		public EBERGZJUJEV(string a, Guid b, int c, Guid d, CreationInstantiationParameters e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8260C20", Offset = "0x8260020", VA = "0x188260C20")]
		public XHCLQKPGUUK XLLOWSLJDRB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8260B20", Offset = "0x825FF20", VA = "0x188260B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class LZHLVUHIYTD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8260DF0", Offset = "0x82601F0", VA = "0x188260DF0")]
		public static bool GHZILPAHMJF(this RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8260ED0", Offset = "0x82602D0", VA = "0x188260ED0")]
		public static object[] IXSXNRBAQFJ(this RRNetworkView a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8260F20", Offset = "0x8260320", VA = "0x188260F20")]
		public static ViewId ZRMZYDTZNOT(this RRNetworkView a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8260E20", Offset = "0x8260220", VA = "0x188260E20")]
		public static CreationInstantiationParameters IUSJTROCFLJ(this RRNetworkView a)
		{
			return default(CreationInstantiationParameters);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8260EF0", Offset = "0x82602F0", VA = "0x188260EF0")]
		public static CreationInstantiationParameters JQZFNFNDQLI(this RRObjectCreationParameters a)
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
