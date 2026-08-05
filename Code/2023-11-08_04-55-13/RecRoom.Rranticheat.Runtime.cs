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
	public class EACManager : MonoBehaviour, JPBIEDKMKDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth EODBOIMEFGH;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool DEPALNOILLF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x642C3C0", Offset = "0x642B1C0", VA = "0x18642C3C0")]
		public static string GenerateChallengeResponse(string LEMPBKHKILN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x642C4D0", Offset = "0x642B2D0", VA = "0x18642C4D0")]
		private static void IEILHPEDODN(FHFPDBCAGOK.KJOCHPDGLPI IPHMLIFNKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x642BFE0", Offset = "0x642ADE0", VA = "0x18642BFE0")]
		private static bool DOOOAJBIEMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x642BF60", Offset = "0x642AD60", VA = "0x18642BF60")]
		private static void CCNFLEPMOMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x642C2B0", Offset = "0x642B0B0", VA = "0x18642C2B0")]
		private static void GJLJMIPBFLD(object BMCPPBALBHP, LoadProgressEventArgs GJIJDIHLINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x642BD90", Offset = "0x642AB90", VA = "0x18642BD90")]
		private static void BENFFMNPCII(object BMCPPBALBHP, LoadCompletedEventArgs GJIJDIHLINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x642BBF0", Offset = "0x642A9F0", VA = "0x18642BBF0")]
		private static void BDAABLEHEEM(object BMCPPBALBHP, StateChangedEventArgs GJIJDIHLINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x642C7E0", Offset = "0x642B5E0", VA = "0x18642C7E0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x642C970", Offset = "0x642B770", VA = "0x18642C970")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x642C5E0", Offset = "0x642B3E0", VA = "0x18642C5E0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x642BF60", Offset = "0x642AD60", VA = "0x18642BF60")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x642C5A0", Offset = "0x642B3A0", VA = "0x18642C5A0")]
		private void OINPODKDLFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x642C710", Offset = "0x642B510", VA = "0x18642C710", Slot = "4")]
		public void PushNetworkMessage(FHFPDBCAGOK.KJOCHPDGLPI IPHMLIFNKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76DFF0", VA = "0x18076F1F0")]
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
