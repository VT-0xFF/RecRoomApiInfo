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
	public class EACManager : MonoBehaviour, JKJDHIJAIOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth IGOILBKMJFH;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KLJIDACGJEJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x73ABA80", Offset = "0x73AA680", VA = "0x1873ABA80")]
		public static string GenerateChallengeResponse(string KMMJEPDJLCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x73ABE40", Offset = "0x73AAA40", VA = "0x1873ABE40")]
		private static void LNCLMDEMNAL(BGCLKNKGIGC.DKDEMMCCHEC NCPEFDMEFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x73ABF90", Offset = "0x73AAB90", VA = "0x1873ABF90")]
		private static bool OCHNCPNNHGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x73ABF10", Offset = "0x73AAB10", VA = "0x1873ABF10")]
		private static void MKFLACMEGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x73ABB90", Offset = "0x73AA790", VA = "0x1873ABB90")]
		private static void IKCEFIHNHNI(object CLHNBHCPIJD, LoadProgressEventArgs FDOBBOPNOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73AB8B0", Offset = "0x73AA4B0", VA = "0x1873AB8B0")]
		private static void AIKKDHADCJP(object CLHNBHCPIJD, LoadCompletedEventArgs FDOBBOPNOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73ABCA0", Offset = "0x73AA8A0", VA = "0x1873ABCA0")]
		private static void LMAMCFGDBCF(object CLHNBHCPIJD, StateChangedEventArgs FDOBBOPNOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73AC490", Offset = "0x73AB090", VA = "0x1873AC490")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x73AC610", Offset = "0x73AB210", VA = "0x1873AC610")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x73AC260", Offset = "0x73AAE60", VA = "0x1873AC260")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x73ABF10", Offset = "0x73AAB10", VA = "0x1873ABF10")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73AC380", Offset = "0x73AAF80", VA = "0x1873AC380")]
		private void PFCLPGJNAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x73AC3C0", Offset = "0x73AAFC0", VA = "0x1873AC3C0", Slot = "4")]
		public void PushNetworkMessage(BGCLKNKGIGC.DKDEMMCCHEC NCPEFDMEFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
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
