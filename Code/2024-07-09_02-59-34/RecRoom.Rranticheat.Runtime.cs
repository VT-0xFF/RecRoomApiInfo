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
	public class EACManager : MonoBehaviour, KAIBONJOMIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth PLJPDOGIMJG;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool ADAKHEEHJIF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x70DDCF0", Offset = "0x70DC8F0", VA = "0x1870DDCF0")]
		public static string GenerateChallengeResponse(string HIAPBMCHMHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x70DDEC0", Offset = "0x70DCAC0", VA = "0x1870DDEC0")]
		private static void OJMLMPDMNOA(JIGLPIONOKB.FFKAHJNAOPP BHGBMMFNCAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x70DD850", Offset = "0x70DC450", VA = "0x1870DD850")]
		private static bool EBMPDBFPCNA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x70DDE40", Offset = "0x70DCA40", VA = "0x1870DDE40")]
		private static void JGFCPHIHDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70DD5A0", Offset = "0x70DC1A0", VA = "0x1870DD5A0")]
		private static void ABEMHOAMCKJ(object KOKLDKPOFFJ, LoadProgressEventArgs FHGGFKCANKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70DDB20", Offset = "0x70DC720", VA = "0x1870DDB20")]
		private static void FABHEHGIIBH(object KOKLDKPOFFJ, LoadCompletedEventArgs FHGGFKCANKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70DD6B0", Offset = "0x70DC2B0", VA = "0x1870DD6B0")]
		private static void BFJDODEAGDN(object KOKLDKPOFFJ, StateChangedEventArgs FHGGFKCANKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70DE190", Offset = "0x70DCD90", VA = "0x1870DE190")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70DE320", Offset = "0x70DCF20", VA = "0x1870DE320")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x70DDF90", Offset = "0x70DCB90", VA = "0x1870DDF90")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70DDE40", Offset = "0x70DCA40", VA = "0x1870DDE40")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x70DDE00", Offset = "0x70DCA00", VA = "0x1870DDE00")]
		private void HGCIGDGCLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x70DE0C0", Offset = "0x70DCCC0", VA = "0x1870DE0C0", Slot = "4")]
		public void PushNetworkMessage(JIGLPIONOKB.FFKAHJNAOPP BHGBMMFNCAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
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
