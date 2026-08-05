using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using EasyAntiCheat.Client;
using EasyAntiCheat.Client.ClientAuth;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AntiCheat
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class EACManager : MonoBehaviour, DGJCMCIPICB
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth LBKDHIHHDBD;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool FONGLKLPNCL;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7236510", Offset = "0x7234B10", VA = "0x187236510")]
		public static string GenerateChallengeResponse(string BKFOMHOGHAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7236230", Offset = "0x7234830", VA = "0x187236230")]
		private static void DAEJMJLNCCO(FDIJGPNBJOB.ICGLJPKFJLE OGLJJNFALNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7235F20", Offset = "0x7234520", VA = "0x187235F20")]
		private static bool CDBKKBCEOFK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7236640", Offset = "0x7234C40", VA = "0x187236640")]
		private static void HGNPLKKCLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7236890", Offset = "0x7234E90", VA = "0x187236890")]
		private static void KHFIGBMJCPL(object ENMNDMMCNHL, LoadProgressEventArgs DDNFLMFAKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7236310", Offset = "0x7234910", VA = "0x187236310")]
		private static void DJBNMDJLKCC(object ENMNDMMCNHL, LoadCompletedEventArgs DDNFLMFAKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72366D0", Offset = "0x7234CD0", VA = "0x1872366D0")]
		private static void JJAENKLJHHC(object ENMNDMMCNHL, StateChangedEventArgs DDNFLMFAKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7236BE0", Offset = "0x72351E0", VA = "0x187236BE0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7236D50", Offset = "0x7235350", VA = "0x187236D50")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7236A00", Offset = "0x7235000", VA = "0x187236A00")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7236640", Offset = "0x7234C40", VA = "0x187236640")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72369B0", Offset = "0x7234FB0", VA = "0x1872369B0")]
		private void MJFGPPMLDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7236B00", Offset = "0x7235100", VA = "0x187236B00", Slot = "4")]
		public void PushNetworkMessage(FDIJGPNBJOB.ICGLJPKFJLE OGLJJNFALNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
		public EACManager()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
