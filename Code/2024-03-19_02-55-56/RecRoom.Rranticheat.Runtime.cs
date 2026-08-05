using System;
using System.Reflection;
using Cpp2IlInjected;
using EasyAntiCheat.Client;
using EasyAntiCheat.Client.ClientAuth;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AntiCheat
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class EACManager : MonoBehaviour, EABDAPFPNPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth DPFNJONLPGH;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool CAOPBFIKLEK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67E9D10", Offset = "0x67E8D10", VA = "0x1867E9D10")]
		public static string GenerateChallengeResponse(string DDOICJHANNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67E9C40", Offset = "0x67E8C40", VA = "0x1867E9C40")]
		private static void GCBELPOODFH(LIKLEAAJPLL.GGJBEMLOGEA CEFJMHIOKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x67E96C0", Offset = "0x67E86C0", VA = "0x1867E96C0")]
		private static bool BODJCFNACLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67E9FF0", Offset = "0x67E8FF0", VA = "0x1867E9FF0")]
		private static void NHGPGKMGPJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67E9990", Offset = "0x67E8990", VA = "0x1867E9990")]
		private static void EFKLCADAFOO(object IOMJEFCJMEB, LoadProgressEventArgs COBEHODEMLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67E9E20", Offset = "0x67E8E20", VA = "0x1867E9E20")]
		private static void LOLKBMHCOPP(object IOMJEFCJMEB, LoadCompletedEventArgs COBEHODEMLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67E9AA0", Offset = "0x67E8AA0", VA = "0x1867E9AA0")]
		private static void ELEPCIILKOD(object IOMJEFCJMEB, StateChangedEventArgs COBEHODEMLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67EA270", Offset = "0x67E9270", VA = "0x1867EA270")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67EA400", Offset = "0x67E9400", VA = "0x1867EA400")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x67EA070", Offset = "0x67E9070", VA = "0x1867EA070")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67E9FF0", Offset = "0x67E8FF0", VA = "0x1867E9FF0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67E9680", Offset = "0x67E8680", VA = "0x1867E9680")]
		private void AAEIJLMHKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67EA1A0", Offset = "0x67E91A0", VA = "0x1867EA1A0", Slot = "4")]
		public void PushNetworkMessage(LIKLEAAJPLL.GGJBEMLOGEA CEFJMHIOKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
		public EACManager()
		{
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
