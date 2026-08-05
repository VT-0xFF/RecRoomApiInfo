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
	public class EACManager : MonoBehaviour, PJOMDHDOPAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth BOODGHKLMMA;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool CCBNDKBNEML;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FD21C0", Offset = "0x6FD0BC0", VA = "0x186FD21C0")]
		public static string GenerateChallengeResponse(string CFADLHIJEGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FD22D0", Offset = "0x6FD0CD0", VA = "0x186FD22D0")]
		private static void HKMJCCEEFAF(JJKPAHFNEHO.PMHAKCPDAIL NBBCEJPPPCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1D20", Offset = "0x6FD0720", VA = "0x186FD1D20")]
		private static bool AAOAGCGNJDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2030", Offset = "0x6FD0A30", VA = "0x186FD2030")]
		private static void DOHIKMLILLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FD20B0", Offset = "0x6FD0AB0", VA = "0x186FD20B0")]
		private static void EKPLDJNNOPK(object KJMOBOMKCOO, LoadProgressEventArgs KDCDNFMFJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FD23A0", Offset = "0x6FD0DA0", VA = "0x186FD23A0")]
		private static void JJFGCEOIDBD(object KJMOBOMKCOO, LoadCompletedEventArgs KDCDNFMFJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2570", Offset = "0x6FD0F70", VA = "0x186FD2570")]
		private static void KGKCHBFELBA(object KJMOBOMKCOO, StateChangedEventArgs KDCDNFMFJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2910", Offset = "0x6FD1310", VA = "0x186FD2910")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2AA0", Offset = "0x6FD14A0", VA = "0x186FD2AA0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2710", Offset = "0x6FD1110", VA = "0x186FD2710")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2030", Offset = "0x6FD0A30", VA = "0x186FD2030")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1FF0", Offset = "0x6FD09F0", VA = "0x186FD1FF0")]
		private void AILMHCCPNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2840", Offset = "0x6FD1240", VA = "0x186FD2840", Slot = "4")]
		public void PushNetworkMessage(JJKPAHFNEHO.PMHAKCPDAIL NBBCEJPPPCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
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
