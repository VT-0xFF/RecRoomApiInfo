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
	public class EACManager : MonoBehaviour, MIAGAOFLCBN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth NDBMEBFKEIC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool PHHNAHNIKAH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5D10", Offset = "0x6FD4510", VA = "0x186FD5D10")]
		public static string GenerateChallengeResponse(string AEGJDBLBBHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FD59A0", Offset = "0x6FD41A0", VA = "0x186FD59A0")]
		private static void BDOBPKOAIMB(PHODMKIPCLM.DKBJDDNLPOI MEKBNGFFPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6120", Offset = "0x6FD4920", VA = "0x186FD6120")]
		private static bool KOIFGPGJGKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5A80", Offset = "0x6FD4280", VA = "0x186FD5A80")]
		private static void EGIBEMFBPJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5E40", Offset = "0x6FD4640", VA = "0x186FD5E40")]
		private static void IBBBGANAAOD(object OGOCAPNGILI, LoadProgressEventArgs IKILIENHLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5B10", Offset = "0x6FD4310", VA = "0x186FD5B10")]
		private static void GDGNDPLHJKL(object OGOCAPNGILI, LoadCompletedEventArgs IKILIENHLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5F60", Offset = "0x6FD4760", VA = "0x186FD5F60")]
		private static void IMEKCKGPHLJ(object OGOCAPNGILI, StateChangedEventArgs IKILIENHLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6610", Offset = "0x6FD4E10", VA = "0x186FD6610")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6780", Offset = "0x6FD4F80", VA = "0x186FD6780")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6430", Offset = "0x6FD4C30", VA = "0x186FD6430")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5A80", Offset = "0x6FD4280", VA = "0x186FD5A80")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5950", Offset = "0x6FD4150", VA = "0x186FD5950")]
		private void AMNGLBBKFIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6530", Offset = "0x6FD4D30", VA = "0x186FD6530", Slot = "4")]
		public void PushNetworkMessage(PHODMKIPCLM.DKBJDDNLPOI MEKBNGFFPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public EACManager()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
