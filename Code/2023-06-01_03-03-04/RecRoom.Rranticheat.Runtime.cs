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
		[Cpp2IlInjected.Address(RVA = "0x6FCA9E0", Offset = "0x6FC95E0", VA = "0x186FCA9E0")]
		public static string GenerateChallengeResponse(string AEGJDBLBBHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA670", Offset = "0x6FC9270", VA = "0x186FCA670")]
		private static void BDOBPKOAIMB(PHODMKIPCLM.DKBJDDNLPOI MEKBNGFFPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FCADF0", Offset = "0x6FC99F0", VA = "0x186FCADF0")]
		private static bool KOIFGPGJGKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA750", Offset = "0x6FC9350", VA = "0x186FCA750")]
		private static void EGIBEMFBPJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FCAB10", Offset = "0x6FC9710", VA = "0x186FCAB10")]
		private static void IBBBGANAAOD(object OGOCAPNGILI, LoadProgressEventArgs IKILIENHLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA7E0", Offset = "0x6FC93E0", VA = "0x186FCA7E0")]
		private static void GDGNDPLHJKL(object OGOCAPNGILI, LoadCompletedEventArgs IKILIENHLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FCAC30", Offset = "0x6FC9830", VA = "0x186FCAC30")]
		private static void IMEKCKGPHLJ(object OGOCAPNGILI, StateChangedEventArgs IKILIENHLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB2E0", Offset = "0x6FC9EE0", VA = "0x186FCB2E0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB450", Offset = "0x6FCA050", VA = "0x186FCB450")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB100", Offset = "0x6FC9D00", VA = "0x186FCB100")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA750", Offset = "0x6FC9350", VA = "0x186FCA750")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA620", Offset = "0x6FC9220", VA = "0x186FCA620")]
		private void AMNGLBBKFIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB200", Offset = "0x6FC9E00", VA = "0x186FCB200", Slot = "4")]
		public void PushNetworkMessage(PHODMKIPCLM.DKBJDDNLPOI MEKBNGFFPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87DF50", Offset = "0x87CB50", VA = "0x18087DF50")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1901CE0", Offset = "0x19008E0", VA = "0x181901CE0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
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
