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
	public class EACManager : MonoBehaviour, HKJAFDLFOCG
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth JFACHGEBADE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool ICLDJLHOLAL;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x803C950", Offset = "0x803BD50", VA = "0x18803C950")]
		public static string GenerateChallengeResponse(string MBOLCNNLDGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x803CB70", Offset = "0x803BF70", VA = "0x18803CB70")]
		private static void NADKDAJNHNI(DDOFBBDMNPE.NPLBKGKKOFP KGCLHKOHKLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x803C460", Offset = "0x803B860", VA = "0x18803C460")]
		private static bool AKIKAMJONFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x803C8D0", Offset = "0x803BCD0", VA = "0x18803C8D0")]
		private static void CMHHJEHOPIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x803CA60", Offset = "0x803BE60", VA = "0x18803CA60")]
		private static void LEGBOPKKDPM(object BAFEKABAJGP, LoadProgressEventArgs BPIDFNFDBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x803CDA0", Offset = "0x803C1A0", VA = "0x18803CDA0")]
		private static void PEOMKLCENLI(object BAFEKABAJGP, LoadCompletedEventArgs BPIDFNFDBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x803C730", Offset = "0x803BB30", VA = "0x18803C730")]
		private static void APODGPKLKEP(object BAFEKABAJGP, StateChangedEventArgs BPIDFNFDBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x803D040", Offset = "0x803C440", VA = "0x18803D040")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x803D1C0", Offset = "0x803C5C0", VA = "0x18803D1C0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x803CC80", Offset = "0x803C080", VA = "0x18803CC80")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x803C8D0", Offset = "0x803BCD0", VA = "0x18803C8D0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x803CC40", Offset = "0x803C040", VA = "0x18803CC40")]
		private void ONCNEDOPKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x803CF70", Offset = "0x803C370", VA = "0x18803CF70", Slot = "4")]
		public void PushNetworkMessage(DDOFBBDMNPE.NPLBKGKKOFP KGCLHKOHKLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
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
