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
	public class EACManager : MonoBehaviour, DKMICAAFFPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth FCDNIALBEPA;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool OJOANCEJMIH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F74CE0", Offset = "0x6F740E0", VA = "0x186F74CE0")]
		public static string GenerateChallengeResponse(string JEHJLOJMDHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F74C00", Offset = "0x6F74000", VA = "0x186F74C00")]
		private static void FBBAFKECIGO(DCAPBGPAAPD.CJINJCMNHKA KBLLMJIHKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F751C0", Offset = "0x6F745C0", VA = "0x186F751C0")]
		private static bool MGEAHKJIIMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F75010", Offset = "0x6F74410", VA = "0x186F75010")]
		private static void IJNCPCLHGBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F750A0", Offset = "0x6F744A0", VA = "0x186F750A0")]
		private static void JMAPOMLPFMI(object PICIBPNODFG, LoadProgressEventArgs FBGMKOAGFHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F74E10", Offset = "0x6F74210", VA = "0x186F74E10")]
		private static void HINJPEHPJGO(object PICIBPNODFG, LoadCompletedEventArgs FBGMKOAGFHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F749F0", Offset = "0x6F73DF0", VA = "0x186F749F0")]
		private static void AOFHJPLDLBC(object PICIBPNODFG, StateChangedEventArgs FBGMKOAGFHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F756B0", Offset = "0x6F74AB0", VA = "0x186F756B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F75820", Offset = "0x6F74C20", VA = "0x186F75820")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F754D0", Offset = "0x6F748D0", VA = "0x186F754D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F75010", Offset = "0x6F74410", VA = "0x186F75010")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F74BB0", Offset = "0x6F73FB0", VA = "0x186F74BB0")]
		private void BHMFHDMBBII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F755D0", Offset = "0x6F749D0", VA = "0x186F755D0", Slot = "4")]
		public void PushNetworkMessage(DCAPBGPAAPD.CJINJCMNHKA KBLLMJIHKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
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
