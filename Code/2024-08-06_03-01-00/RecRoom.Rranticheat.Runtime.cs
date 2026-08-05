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
	public class EACManager : MonoBehaviour, OLFAOFHANKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth HACPBPPAHAG;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool ICLOODBNLAE;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x70B1FE0", Offset = "0x70B05E0", VA = "0x1870B1FE0")]
		public static string GenerateChallengeResponse(string ONMLCHOKIJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x70B2240", Offset = "0x70B0840", VA = "0x1870B2240")]
		private static void OBDAGKHGBHA(IFFKEHBLFFD.GIPOHFLJBNJ JFHMMOFAOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x70B1D10", Offset = "0x70B0310", VA = "0x1870B1D10")]
		private static bool FJDPEHKMPDI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x70B1AC0", Offset = "0x70B00C0", VA = "0x1870B1AC0")]
		private static void CKEIHGDONAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70B2130", Offset = "0x70B0730", VA = "0x1870B2130")]
		private static void NCEDMMBHOBF(object HNHPEKFFBFP, LoadProgressEventArgs ICOOCEMLCFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70B1B40", Offset = "0x70B0140", VA = "0x1870B1B40")]
		private static void EJEOECPJKAH(object HNHPEKFFBFP, LoadCompletedEventArgs ICOOCEMLCFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70B2310", Offset = "0x70B0910", VA = "0x1870B2310")]
		private static void ODOAIEBPJHK(object HNHPEKFFBFP, StateChangedEventArgs ICOOCEMLCFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70B26A0", Offset = "0x70B0CA0", VA = "0x1870B26A0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70B2820", Offset = "0x70B0E20", VA = "0x1870B2820")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x70B24B0", Offset = "0x70B0AB0", VA = "0x1870B24B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70B1AC0", Offset = "0x70B00C0", VA = "0x1870B1AC0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x70B20F0", Offset = "0x70B06F0", VA = "0x1870B20F0")]
		private void JJFAMDDJLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x70B25D0", Offset = "0x70B0BD0", VA = "0x1870B25D0", Slot = "4")]
		public void PushNetworkMessage(IFFKEHBLFFD.GIPOHFLJBNJ JFHMMOFAOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
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
