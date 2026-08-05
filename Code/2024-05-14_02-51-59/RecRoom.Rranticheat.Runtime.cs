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
	public class EACManager : MonoBehaviour, BHBIJJHMCGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth EKNJJAFOHND;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool ANIKGIMEKLB;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69CD560", Offset = "0x69CBF60", VA = "0x1869CD560")]
		public static string GenerateChallengeResponse(string DBIIILPLAAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69CD490", Offset = "0x69CBE90", VA = "0x1869CD490")]
		private static void GPGOOJLILKO(NHMCPKCKGPK.FAFHACEBNGN PEFGDLBLMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69CD890", Offset = "0x69CC290", VA = "0x1869CD890")]
		private static bool JGBJBCFKEAN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69CD810", Offset = "0x69CC210", VA = "0x1869CD810")]
		private static void HPNANJGNHIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69CD380", Offset = "0x69CBD80", VA = "0x1869CD380")]
		private static void GKNHCJFIAAG(object OOGBIJCMMLL, LoadProgressEventArgs AICAMDEGIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69CDB60", Offset = "0x69CC560", VA = "0x1869CDB60")]
		private static void LGODCMENGFM(object OOGBIJCMMLL, LoadCompletedEventArgs AICAMDEGIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69CD670", Offset = "0x69CC070", VA = "0x1869CD670")]
		private static void HKBBLCNJGMO(object OOGBIJCMMLL, StateChangedEventArgs AICAMDEGIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69CDF30", Offset = "0x69CC930", VA = "0x1869CDF30")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69CE0C0", Offset = "0x69CCAC0", VA = "0x1869CE0C0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69CDD30", Offset = "0x69CC730", VA = "0x1869CDD30")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69CD810", Offset = "0x69CC210", VA = "0x1869CD810")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69CD340", Offset = "0x69CBD40", VA = "0x1869CD340")]
		private void CFGPNFFBIOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69CDE60", Offset = "0x69CC860", VA = "0x1869CDE60", Slot = "4")]
		public void PushNetworkMessage(NHMCPKCKGPK.FAFHACEBNGN PEFGDLBLMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
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
