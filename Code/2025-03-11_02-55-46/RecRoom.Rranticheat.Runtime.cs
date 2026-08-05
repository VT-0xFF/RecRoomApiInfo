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
	public class EACManager : MonoBehaviour, KBAMPFDGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth BNAELKEHAGE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool BMINFEJOPGK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E06190", Offset = "0x7E05590", VA = "0x187E06190")]
		public static string GenerateChallengeResponse(string DDAGBMBPJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E05C40", Offset = "0x7E05040", VA = "0x187E05C40")]
		private static void BPCPFKFMIJL(KILBLMJDGIK.CHFDKADKPEC IILBHIALBMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E062A0", Offset = "0x7E056A0", VA = "0x187E062A0")]
		private static bool IOMEEHAALDG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E06570", Offset = "0x7E05970", VA = "0x187E06570")]
		private static void NKKIAHDBCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E05D10", Offset = "0x7E05110", VA = "0x187E05D10")]
		private static void CAGGICJEKLK(object IIAPBBKGPMO, LoadProgressEventArgs EOAJDDOMCLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E05E20", Offset = "0x7E05220", VA = "0x187E05E20")]
		private static void CKBPMBKBCOC(object IIAPBBKGPMO, LoadCompletedEventArgs EOAJDDOMCLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E05FF0", Offset = "0x7E053F0", VA = "0x187E05FF0")]
		private static void FDNHGKMBOOL(object IIAPBBKGPMO, StateChangedEventArgs EOAJDDOMCLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E06820", Offset = "0x7E05C20", VA = "0x187E06820")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E069A0", Offset = "0x7E05DA0", VA = "0x187E069A0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E06630", Offset = "0x7E05A30", VA = "0x187E06630")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E06570", Offset = "0x7E05970", VA = "0x187E06570")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E065F0", Offset = "0x7E059F0", VA = "0x187E065F0")]
		private void OOCNJAMCPMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E06750", Offset = "0x7E05B50", VA = "0x187E06750", Slot = "4")]
		public void PushNetworkMessage(KILBLMJDGIK.CHFDKADKPEC IILBHIALBMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
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
