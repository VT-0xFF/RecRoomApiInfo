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
	public class EACManager : MonoBehaviour, PPPDJFKBIDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth ELONKOHANAO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool NGNGACCOEPB;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6942BC0", Offset = "0x6941BC0", VA = "0x186942BC0")]
		public static string GenerateChallengeResponse(string IJPJEHFFDAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69428E0", Offset = "0x69418E0", VA = "0x1869428E0")]
		private static void BNPOJABFJEJ(GJJDFLKDEJN.DPMBAPABIHL KKAPFENLPIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6942470", Offset = "0x6941470", VA = "0x186942470")]
		private static bool BFNJPJBPHCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6942CD0", Offset = "0x6941CD0", VA = "0x186942CD0")]
		private static void JENJPEIDIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6942D50", Offset = "0x6941D50", VA = "0x186942D50")]
		private static void LGELMOHDMEO(object GFLKCIGIMIP, LoadProgressEventArgs BKLMDLGPAPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69429B0", Offset = "0x69419B0", VA = "0x1869429B0")]
		private static void CJMEPILMOBH(object GFLKCIGIMIP, LoadCompletedEventArgs BKLMDLGPAPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6942740", Offset = "0x6941740", VA = "0x186942740")]
		private static void BKNJOCFBMDJ(object GFLKCIGIMIP, StateChangedEventArgs BKLMDLGPAPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6943060", Offset = "0x6942060", VA = "0x186943060")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69431F0", Offset = "0x69421F0", VA = "0x1869431F0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6942E60", Offset = "0x6941E60", VA = "0x186942E60")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6942CD0", Offset = "0x6941CD0", VA = "0x186942CD0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6942B80", Offset = "0x6941B80", VA = "0x186942B80")]
		private void FHNJAPHMMKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6942F90", Offset = "0x6941F90", VA = "0x186942F90", Slot = "4")]
		public void PushNetworkMessage(GJJDFLKDEJN.DPMBAPABIHL KKAPFENLPIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
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
