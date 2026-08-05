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
	public class EACManager : MonoBehaviour, OHLACGDCIGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth PDMPAEAJCPM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool FNMNFALGEMJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x737DFF0", Offset = "0x737C9F0", VA = "0x18737DFF0")]
		public static string GenerateChallengeResponse(string OBMOAAFAEOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x737E2E0", Offset = "0x737CCE0", VA = "0x18737E2E0")]
		private static void OJDGPIPDHBP(FJJHNEOJLPA.MCKPCMFBLJM AJFODGMHKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x737DD20", Offset = "0x737C720", VA = "0x18737DD20")]
		private static bool CGHIOAHHHMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x737E3B0", Offset = "0x737CDB0", VA = "0x18737E3B0")]
		private static void PJPCHDLCNCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x737DC10", Offset = "0x737C610", VA = "0x18737DC10")]
		private static void ANLOOEOBDNN(object PONAMMMCEME, LoadProgressEventArgs CECPNEMKKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x737DA40", Offset = "0x737C440", VA = "0x18737DA40")]
		private static void ABHNIGOAPAE(object PONAMMMCEME, LoadCompletedEventArgs CECPNEMKKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x737E100", Offset = "0x737CB00", VA = "0x18737E100")]
		private static void HDBDDALBHOC(object PONAMMMCEME, StateChangedEventArgs CECPNEMKKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x737E620", Offset = "0x737D020", VA = "0x18737E620")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x737E7A0", Offset = "0x737D1A0", VA = "0x18737E7A0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x737E430", Offset = "0x737CE30", VA = "0x18737E430")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x737E3B0", Offset = "0x737CDB0", VA = "0x18737E3B0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x737E2A0", Offset = "0x737CCA0", VA = "0x18737E2A0")]
		private void KMADCJHPJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x737E550", Offset = "0x737CF50", VA = "0x18737E550", Slot = "4")]
		public void PushNetworkMessage(FJJHNEOJLPA.MCKPCMFBLJM AJFODGMHKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
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
