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
	public class EACManager : MonoBehaviour, FFJIGLONEMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth GPPEAENKJEE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool DMDJKDAAJKN;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6565CC0", Offset = "0x65650C0", VA = "0x186565CC0")]
		public static string GenerateChallengeResponse(string JFBIJHLBNEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6565DD0", Offset = "0x65651D0", VA = "0x186565DD0")]
		private static void JPADCIBNNKE(KNDINGDKJOA.BDBODPOFJLF MBIDFLHPHHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x65661C0", Offset = "0x65655C0", VA = "0x1865661C0")]
		private static bool OPKBMEOBHHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6565C40", Offset = "0x6565040", VA = "0x186565C40")]
		private static void CHPAPPPBBKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6565EA0", Offset = "0x65652A0", VA = "0x186565EA0")]
		private static void LHFAAGDJHCK(object FNEGNGGOGNI, LoadProgressEventArgs INLHPKKGDHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6565FB0", Offset = "0x65653B0", VA = "0x186565FB0")]
		private static void OGNICDEPNID(object FNEGNGGOGNI, LoadCompletedEventArgs INLHPKKGDHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x65665C0", Offset = "0x65659C0", VA = "0x1865665C0")]
		private static void PGHJCOEGEDG(object FNEGNGGOGNI, StateChangedEventArgs INLHPKKGDHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6566830", Offset = "0x6565C30", VA = "0x186566830")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x65669C0", Offset = "0x6565DC0", VA = "0x1865669C0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6566490", Offset = "0x6565890", VA = "0x186566490")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6565C40", Offset = "0x6565040", VA = "0x186565C40")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6566180", Offset = "0x6565580", VA = "0x186566180")]
		private void OMGPNDIELKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6566760", Offset = "0x6565B60", VA = "0x186566760", Slot = "4")]
		public void PushNetworkMessage(KNDINGDKJOA.BDBODPOFJLF MBIDFLHPHHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x79E360", Offset = "0x79D760", VA = "0x18079E360")]
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
