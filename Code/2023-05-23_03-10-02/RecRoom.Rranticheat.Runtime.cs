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
	public class EACManager : MonoBehaviour, GBEBAAMOBDB
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth OALBPJCGGEM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool GOINCLDKBMB;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7100", Offset = "0x6FC6500", VA = "0x186FC7100")]
		public static string GenerateChallengeResponse(string JBDFCAEKLMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7660", Offset = "0x6FC6A60", VA = "0x186FC7660")]
		private static void OPHBOJEIBEH(KAEBNGNFCOM.OIHOCJCHKHH PCDLJHELPEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7350", Offset = "0x6FC6750", VA = "0x186FC7350")]
		private static bool NCODJJALDFK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7020", Offset = "0x6FC6420", VA = "0x186FC7020")]
		private static void ECONPKLIMDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7230", Offset = "0x6FC6630", VA = "0x186FC7230")]
		private static void MMOMDIJCHJD(object NKECCOEHMIJ, LoadProgressEventArgs CMEMHJFLCOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6E20", Offset = "0x6FC6220", VA = "0x186FC6E20")]
		private static void DGNIDLHBOLG(object NKECCOEHMIJ, LoadCompletedEventArgs CMEMHJFLCOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6C60", Offset = "0x6FC6060", VA = "0x186FC6C60")]
		private static void BLLMMCFGLLJ(object NKECCOEHMIJ, StateChangedEventArgs CMEMHJFLCOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7920", Offset = "0x6FC6D20", VA = "0x186FC7920")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7A90", Offset = "0x6FC6E90", VA = "0x186FC7A90")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7740", Offset = "0x6FC6B40", VA = "0x186FC7740")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7020", Offset = "0x6FC6420", VA = "0x186FC7020")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC70B0", Offset = "0x6FC64B0", VA = "0x186FC70B0")]
		private void GELAFKFNKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7840", Offset = "0x6FC6C40", VA = "0x186FC7840", Slot = "4")]
		public void PushNetworkMessage(KAEBNGNFCOM.OIHOCJCHKHH PCDLJHELPEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public EACManager()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
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
