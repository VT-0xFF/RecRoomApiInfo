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
	public class EACManager : MonoBehaviour, KCGHNKGGMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth NDCFECLEAJB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool ENJECKMLJKO;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x73AA560", Offset = "0x73A9760", VA = "0x1873AA560")]
		public static string GenerateChallengeResponse(string NOBGDPLPPFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x73AAB20", Offset = "0x73A9D20", VA = "0x1873AAB20")]
		private static void KONIOGCNHOA(FEOCIJJDIAJ.BOIJAOGJBFB EGCKKGGNFOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x73AA850", Offset = "0x73A9A50", VA = "0x1873AA850")]
		private static bool JMAJDBNBJHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x73AADC0", Offset = "0x73A9FC0", VA = "0x1873AADC0")]
		private static void PIILLFAIGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x73AA450", Offset = "0x73A9650", VA = "0x1873AA450")]
		private static void EDDFHAOEGNH(object PLLKFAGKBKN, LoadProgressEventArgs EABLJACIHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73AABF0", Offset = "0x73A9DF0", VA = "0x1873AABF0")]
		private static void NDMBPNCDBPG(object PLLKFAGKBKN, LoadCompletedEventArgs EABLJACIHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73AA670", Offset = "0x73A9870", VA = "0x1873AA670")]
		private static void HCEPIDCFKJG(object PLLKFAGKBKN, StateChangedEventArgs EABLJACIHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73AB030", Offset = "0x73AA230", VA = "0x1873AB030")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x73AB1B0", Offset = "0x73AA3B0", VA = "0x1873AB1B0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x73AAE40", Offset = "0x73AA040", VA = "0x1873AAE40")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x73AADC0", Offset = "0x73A9FC0", VA = "0x1873AADC0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73AA810", Offset = "0x73A9A10", VA = "0x1873AA810")]
		private void IJHGNLJNKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x73AAF60", Offset = "0x73AA160", VA = "0x1873AAF60", Slot = "4")]
		public void PushNetworkMessage(FEOCIJJDIAJ.BOIJAOGJBFB EGCKKGGNFOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
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
