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
	public class EACManager : MonoBehaviour, PELECEFACAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth BIODNGAGGDL;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KBJBJMENGEN;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7092D80", Offset = "0x7091D80", VA = "0x187092D80")]
		public static string GenerateChallengeResponse(string CAHLKHPFCEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7093170", Offset = "0x7092170", VA = "0x187093170")]
		private static void NELMOOCCKCE(MGHPHFMLOPA.LBLPIBMAHAA KLINFCCHIED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x70928D0", Offset = "0x70918D0", VA = "0x1870928D0")]
		private static bool CCDABDILCEC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7092850", Offset = "0x7091850", VA = "0x187092850")]
		private static void AGEIDMDLGND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7093060", Offset = "0x7092060", VA = "0x187093060")]
		private static void KAJJJFDEJNL(object PMMEOKFGNHN, LoadProgressEventArgs CPHIFHELGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7092E90", Offset = "0x7091E90", VA = "0x187092E90")]
		private static void HDIOAPIKAAK(object PMMEOKFGNHN, LoadCompletedEventArgs CPHIFHELGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7092BA0", Offset = "0x7091BA0", VA = "0x187092BA0")]
		private static void EHEPLHFOAMN(object PMMEOKFGNHN, StateChangedEventArgs CPHIFHELGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7093440", Offset = "0x7092440", VA = "0x187093440")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70935D0", Offset = "0x70925D0", VA = "0x1870935D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7093240", Offset = "0x7092240", VA = "0x187093240")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7092850", Offset = "0x7091850", VA = "0x187092850")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7092D40", Offset = "0x7091D40", VA = "0x187092D40")]
		private void FMKOJBIOGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7093370", Offset = "0x7092370", VA = "0x187093370", Slot = "4")]
		public void PushNetworkMessage(MGHPHFMLOPA.LBLPIBMAHAA KLINFCCHIED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
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
