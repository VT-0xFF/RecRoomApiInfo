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
	public class EACManager : MonoBehaviour, EHPOEAIOKFP
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth EBCJDFNHCGA;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool NGCECMIKJLD;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6432C70", Offset = "0x6431C70", VA = "0x186432C70")]
		public static string GenerateChallengeResponse(string KLLMNEJLPDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64329D0", Offset = "0x64319D0", VA = "0x1864329D0")]
		private static void EKHMDNAOOJO(JEGAFBDIBLP.CILLIHHEBJL HPEDGLBMGED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6432E90", Offset = "0x6431E90", VA = "0x186432E90")]
		private static bool LIJHKAILNLN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64327B0", Offset = "0x64317B0", VA = "0x1864327B0")]
		private static void BCLKFDNHMNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6432D80", Offset = "0x6431D80", VA = "0x186432D80")]
		private static void KDFGADHACAF(object JLLLCCKENOB, LoadProgressEventArgs CIIGGILFKNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6432AA0", Offset = "0x6431AA0", VA = "0x186432AA0")]
		private static void EMAGDAEPMIM(object JLLLCCKENOB, LoadCompletedEventArgs CIIGGILFKNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6432830", Offset = "0x6431830", VA = "0x186432830")]
		private static void CLELFAPCPOF(object JLLLCCKENOB, StateChangedEventArgs CIIGGILFKNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6433360", Offset = "0x6432360", VA = "0x186433360")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64334F0", Offset = "0x64324F0", VA = "0x1864334F0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6433160", Offset = "0x6432160", VA = "0x186433160")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64327B0", Offset = "0x64317B0", VA = "0x1864327B0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6432770", Offset = "0x6431770", VA = "0x186432770")]
		private void ALLHLMDGGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6433290", Offset = "0x6432290", VA = "0x186433290", Slot = "4")]
		public void PushNetworkMessage(JEGAFBDIBLP.CILLIHHEBJL HPEDGLBMGED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
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
