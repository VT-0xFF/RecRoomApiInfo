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
	public class EACManager : MonoBehaviour, CAIKGBKKAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth KGPBKJPKKDI;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool GLHGAHFCMKN;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6819470", Offset = "0x6818870", VA = "0x186819470")]
		public static string GenerateChallengeResponse(string DLGHJONDAFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68191D0", Offset = "0x68185D0", VA = "0x1868191D0")]
		private static void DHCPOCGAEPJ(KBCEJHCJJGL.CAMGBLJJKIG KJOCNIDJGCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6819600", Offset = "0x6818A00", VA = "0x186819600")]
		private static bool HPPFMBNDDCJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6819580", Offset = "0x6818980", VA = "0x186819580")]
		private static void HDKKGFAPFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6819BE0", Offset = "0x6818FE0", VA = "0x186819BE0")]
		private static void PKELNCKGODI(object CKNLAPNPGOH, LoadProgressEventArgs JNICLNOBDDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68192A0", Offset = "0x68186A0", VA = "0x1868192A0")]
		private static void DMDIDJFFFBL(object CKNLAPNPGOH, LoadCompletedEventArgs JNICLNOBDDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68198D0", Offset = "0x6818CD0", VA = "0x1868198D0")]
		private static void IDGKBHFDBKC(object CKNLAPNPGOH, StateChangedEventArgs JNICLNOBDDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6819DC0", Offset = "0x68191C0", VA = "0x186819DC0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6819F50", Offset = "0x6819350", VA = "0x186819F50")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6819AB0", Offset = "0x6818EB0", VA = "0x186819AB0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6819580", Offset = "0x6818980", VA = "0x186819580")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6819A70", Offset = "0x6818E70", VA = "0x186819A70")]
		private void JJDGDCHMKOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6819CF0", Offset = "0x68190F0", VA = "0x186819CF0", Slot = "4")]
		public void PushNetworkMessage(KBCEJHCJJGL.CAMGBLJJKIG KJOCNIDJGCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
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
