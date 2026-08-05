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
	public class KMQEOBVEQVZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly Guid EKOOULNOULG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly string WMOAMTEWGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly int IXGPZMQMAOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly Guid GLVCDQYTCYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly CreationInstantiationParameters QWHFMHREGQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Vector3 IIYQCROBXLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Quaternion LPLELFIJVOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public Vector3 ZMJUOEPVXPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public bool SRPJZBZCFXM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85718A0", Offset = "0x85706A0", VA = "0x1885718A0")]
		public KMQEOBVEQVZ(string a, Guid b, int c, Guid d, CreationInstantiationParameters e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x85716F0", Offset = "0x85704F0", VA = "0x1885716F0")]
		public NREMRRGPTYQ KYFTGVEPCDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85717A0", Offset = "0x85705A0", VA = "0x1885717A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class RNCNTOJUPKX
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85719C0", Offset = "0x85707C0", VA = "0x1885719C0")]
		public static bool AWRNFAMYRDL(this RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8571B10", Offset = "0x8570910", VA = "0x188571B10")]
		public static object[] TJKMRIDKXKB(this RRNetworkView a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85719F0", Offset = "0x85707F0", VA = "0x1885719F0")]
		public static ViewId KGAEWGRNTIN(this RRNetworkView a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8571A60", Offset = "0x8570860", VA = "0x188571A60")]
		public static CreationInstantiationParameters KWILGNNIYWZ(this RRNetworkView a)
		{
			return default(CreationInstantiationParameters);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8571B30", Offset = "0x8570930", VA = "0x188571B30")]
		public static CreationInstantiationParameters YTVXMFGHZEI(this RRObjectCreationParameters a)
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
