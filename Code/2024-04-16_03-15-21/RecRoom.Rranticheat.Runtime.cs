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
	public class EACManager : MonoBehaviour, KLEGAEGNPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth OPEIMAPCICL;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool JALMLFIDIAG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67B1D00", Offset = "0x67B0F00", VA = "0x1867B1D00")]
		public static string GenerateChallengeResponse(string KOCDLECFOOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67B1BF0", Offset = "0x67B0DF0", VA = "0x1867B1BF0")]
		private static void DMNGBMKKOPP(DBFFDLKLDLN.IHAMPONCFEL JAHJOCBHFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x67B1E10", Offset = "0x67B1010", VA = "0x1867B1E10")]
		private static bool HBEMABABNOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67B1B70", Offset = "0x67B0D70", VA = "0x1867B1B70")]
		private static void BAOPAIJDJAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67B23D0", Offset = "0x67B15D0", VA = "0x1867B23D0")]
		private static void PMCLDCKMNMH(object IEDPLEDIAKB, LoadProgressEventArgs MKCFHKJKOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67B20E0", Offset = "0x67B12E0", VA = "0x1867B20E0")]
		private static void NBOHOPHNGIH(object IEDPLEDIAKB, LoadCompletedEventArgs MKCFHKJKOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67B19D0", Offset = "0x67B0BD0", VA = "0x1867B19D0")]
		private static void ABCPFIHAIKF(object IEDPLEDIAKB, StateChangedEventArgs MKCFHKJKOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67B25B0", Offset = "0x67B17B0", VA = "0x1867B25B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67B2730", Offset = "0x67B1930", VA = "0x1867B2730")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x67B22B0", Offset = "0x67B14B0", VA = "0x1867B22B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67B1B70", Offset = "0x67B0D70", VA = "0x1867B1B70")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67B1CC0", Offset = "0x67B0EC0", VA = "0x1867B1CC0")]
		private void DPCAKODJNPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67B24E0", Offset = "0x67B16E0", VA = "0x1867B24E0", Slot = "4")]
		public void PushNetworkMessage(DBFFDLKLDLN.IHAMPONCFEL JAHJOCBHFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
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
