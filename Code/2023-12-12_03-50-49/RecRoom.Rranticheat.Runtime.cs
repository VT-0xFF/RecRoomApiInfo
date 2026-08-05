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
	public class EACManager : MonoBehaviour, ADCAKJDFPMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth ONBDIDFIDPP;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool ALIBNJAEMJC;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6455120", Offset = "0x6453920", VA = "0x186455120")]
		public static string GenerateChallengeResponse(string JKEFBJOLNAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6454E30", Offset = "0x6453630", VA = "0x186454E30")]
		private static void BNIACIFDIKD(FFDJMFICFKF.IPMPFMPAKHH IOHCLNMNKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6455270", Offset = "0x6453A70", VA = "0x186455270")]
		private static bool KALAKHCFBFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6454F00", Offset = "0x6453700", VA = "0x186454F00")]
		private static void CMDDKGMCCIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6455670", Offset = "0x6453E70", VA = "0x186455670")]
		private static void PCOLPEJIAPN(object LABLENKOPIL, LoadProgressEventArgs BPLECPJMCKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6455780", Offset = "0x6453F80", VA = "0x186455780")]
		private static void PNLOMDCFOJD(object LABLENKOPIL, LoadCompletedEventArgs BPLECPJMCKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6454F80", Offset = "0x6453780", VA = "0x186454F80")]
		private static void GBGKGPIEBOM(object LABLENKOPIL, StateChangedEventArgs BPLECPJMCKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6455A20", Offset = "0x6454220", VA = "0x186455A20")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6455BB0", Offset = "0x64543B0", VA = "0x186455BB0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6455540", Offset = "0x6453D40", VA = "0x186455540")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6454F00", Offset = "0x6453700", VA = "0x186454F00")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6455230", Offset = "0x6453A30", VA = "0x186455230")]
		private void ICKHCHCFCOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6455950", Offset = "0x6454150", VA = "0x186455950", Slot = "4")]
		public void PushNetworkMessage(FFDJMFICFKF.IPMPFMPAKHH IOHCLNMNKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7721F0", Offset = "0x7709F0", VA = "0x1807721F0")]
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
