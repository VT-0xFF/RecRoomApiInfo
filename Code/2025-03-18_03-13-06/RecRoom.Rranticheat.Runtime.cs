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
	public class EACManager : MonoBehaviour, COPJMHLFKAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth HCJIHJDIPHP;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool ICLPEIHHDBE;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C030", Offset = "0x7E1B230", VA = "0x187E1C030")]
		public static string GenerateChallengeResponse(string KEAFLBKJEPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BF60", Offset = "0x7E1B160", VA = "0x187E1BF60")]
		private static void GKKABMJJENN(FOCIDMJNMLP.ONDMMFCMION FKKLLADNDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BA70", Offset = "0x7E1AC70", VA = "0x187E1BA70")]
		private static bool AOLKEAGGFHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BEE0", Offset = "0x7E1B0E0", VA = "0x187E1BEE0")]
		private static void GIEDNEMPEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C470", Offset = "0x7E1B670", VA = "0x187E1C470")]
		private static void POGABEMDAKB(object LBNPCIOEFIP, LoadProgressEventArgs GKHKLDFLOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C180", Offset = "0x7E1B380", VA = "0x187E1C180")]
		private static void LIFJKAOJJEJ(object LBNPCIOEFIP, LoadCompletedEventArgs GKHKLDFLOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BD40", Offset = "0x7E1AF40", VA = "0x187E1BD40")]
		private static void GGDBIBGOABA(object LBNPCIOEFIP, StateChangedEventArgs GKHKLDFLOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C650", Offset = "0x7E1B850", VA = "0x187E1C650")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C7D0", Offset = "0x7E1B9D0", VA = "0x187E1C7D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C350", Offset = "0x7E1B550", VA = "0x187E1C350")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BEE0", Offset = "0x7E1B0E0", VA = "0x187E1BEE0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C140", Offset = "0x7E1B340", VA = "0x187E1C140")]
		private void ILAGACBOJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C580", Offset = "0x7E1B780", VA = "0x187E1C580", Slot = "4")]
		public void PushNetworkMessage(FOCIDMJNMLP.ONDMMFCMION FKKLLADNDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
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
