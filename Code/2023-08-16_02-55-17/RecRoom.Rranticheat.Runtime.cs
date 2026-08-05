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
	public class EACManager : MonoBehaviour, OHEHEGDMIKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth BJFBCEONIIM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool GLBAMCHFMLP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F47880", Offset = "0x6F46A80", VA = "0x186F47880")]
		public static string GenerateChallengeResponse(string GKLBPMBBKEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F47EE0", Offset = "0x6F470E0", VA = "0x186F47EE0")]
		private static void NHOGJFCPKHH(JDGOFKBNEKN.JJOKMJNJPHC GJNKBDPFGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F474E0", Offset = "0x6F466E0", VA = "0x186F474E0")]
		private static bool AJFHABHILMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F477F0", Offset = "0x6F469F0", VA = "0x186F477F0")]
		private static void BIKBGJEJFIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F47DC0", Offset = "0x6F46FC0", VA = "0x186F47DC0")]
		private static void LAPLFNNNKDH(object BOHDEFHNDOO, LoadProgressEventArgs OGKCKOJNMEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F47B70", Offset = "0x6F46D70", VA = "0x186F47B70")]
		private static void IIKCKMFDOOI(object BOHDEFHNDOO, LoadCompletedEventArgs OGKCKOJNMEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F479B0", Offset = "0x6F46BB0", VA = "0x186F479B0")]
		private static void ICLHHLHNFNN(object BOHDEFHNDOO, StateChangedEventArgs OGKCKOJNMEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F481A0", Offset = "0x6F473A0", VA = "0x186F481A0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F48310", Offset = "0x6F47510", VA = "0x186F48310")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F47FC0", Offset = "0x6F471C0", VA = "0x186F47FC0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F477F0", Offset = "0x6F469F0", VA = "0x186F477F0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F47D70", Offset = "0x6F46F70", VA = "0x186F47D70")]
		private void JPCLHDACBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F480C0", Offset = "0x6F472C0", VA = "0x186F480C0", Slot = "4")]
		public void PushNetworkMessage(JDGOFKBNEKN.JJOKMJNJPHC GJNKBDPFGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
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
