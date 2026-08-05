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
	public class QLKPQPWFYRW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly Guid YCVJNAZONXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly string ITHQQYFDSZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly int VOMZVWTPTTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly Guid VQKJTVJTFSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly CreationInstantiationParameters FTGXFKAPFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Vector3 ZJSBNRYHJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Quaternion UWXJAJSPRJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public Vector3 BDFPJJLKDEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public bool IVQQEIONFIL;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8290C00", Offset = "0x828F400", VA = "0x188290C00")]
		public QLKPQPWFYRW(string a, Guid b, int c, Guid d, CreationInstantiationParameters e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8290B50", Offset = "0x828F350", VA = "0x188290B50")]
		public MOFTTNXWVKL YAHCVJVBKIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8290A50", Offset = "0x828F250", VA = "0x188290A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class HYSZMJZUILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8290950", Offset = "0x828F150", VA = "0x188290950")]
		public static bool NYDTHYRAQPY(this RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8290980", Offset = "0x828F180", VA = "0x188290980")]
		public static object[] OJTPBARFSGW(this RRNetworkView a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82908A0", Offset = "0x828F0A0", VA = "0x1882908A0")]
		public static ViewId LLCYYJQGGBE(this RRNetworkView a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82909A0", Offset = "0x828F1A0", VA = "0x1882909A0")]
		public static CreationInstantiationParameters UVSOSYETHZU(this RRNetworkView a)
		{
			return default(CreationInstantiationParameters);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8290920", Offset = "0x828F120", VA = "0x188290920")]
		public static CreationInstantiationParameters MGROIQHTFIL(this RRObjectCreationParameters a)
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
