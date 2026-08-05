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
	public class EACManager : MonoBehaviour, OJGMDLADKLD
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth FAMCIMANBCI;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool JKCMODMJMAH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x70773D0", Offset = "0x70763D0", VA = "0x1870773D0")]
		public static string GenerateChallengeResponse(string JAGIMCGDAJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x70777C0", Offset = "0x70767C0", VA = "0x1870777C0")]
		private static void IPECBEKJBOO(LFCIMPCCCPJ.JJMFACLIOCP HJCJCIIFPJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x70778D0", Offset = "0x70768D0", VA = "0x1870778D0")]
		private static bool KECJHLMKLGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7077D40", Offset = "0x7076D40", VA = "0x187077D40")]
		private static void LCEKJGHNHFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70776B0", Offset = "0x70766B0", VA = "0x1870776B0")]
		private static void HLCIKEMCCHM(object GPKOPPDDFGF, LoadProgressEventArgs NMABEHBMCEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70774E0", Offset = "0x70764E0", VA = "0x1870774E0")]
		private static void HJGBHALBJDP(object GPKOPPDDFGF, LoadCompletedEventArgs NMABEHBMCEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7077BA0", Offset = "0x7076BA0", VA = "0x187077BA0")]
		private static void KKNNIGCPGAD(object GPKOPPDDFGF, StateChangedEventArgs NMABEHBMCEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7077FC0", Offset = "0x7076FC0", VA = "0x187077FC0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7078150", Offset = "0x7077150", VA = "0x187078150")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7077DC0", Offset = "0x7076DC0", VA = "0x187077DC0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7077D40", Offset = "0x7076D40", VA = "0x187077D40")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7077890", Offset = "0x7076890", VA = "0x187077890")]
		private void KALFMKNAKKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7077EF0", Offset = "0x7076EF0", VA = "0x187077EF0", Slot = "4")]
		public void PushNetworkMessage(LFCIMPCCCPJ.JJMFACLIOCP HJCJCIIFPJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
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
