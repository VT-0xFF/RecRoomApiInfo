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
	public class EACManager : MonoBehaviour, MHJFCNIOFAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth AEIFNBFGIAO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool MKFPDLHECLG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6637050", Offset = "0x6635A50", VA = "0x186637050")]
		public static string GenerateChallengeResponse(string OALCOCDOHGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6636EC0", Offset = "0x66358C0", VA = "0x186636EC0")]
		private static void DEOFGGPKAGB(MDKHBMJHAKI.MPMIBCDAGFH DNNAMOOCONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6636AE0", Offset = "0x66354E0", VA = "0x186636AE0")]
		private static bool AEJPAMAIJPG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6636FD0", Offset = "0x66359D0", VA = "0x186636FD0")]
		private static void GHMMJOKIAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6636DB0", Offset = "0x66357B0", VA = "0x186636DB0")]
		private static void CPCEIEHEDKJ(object EJNFOCPFJML, LoadProgressEventArgs EEEKBCFAGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6637160", Offset = "0x6635B60", VA = "0x186637160")]
		private static void HHNOMJDNNNJ(object EJNFOCPFJML, LoadCompletedEventArgs EEEKBCFAGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6637330", Offset = "0x6635D30", VA = "0x186637330")]
		private static void MKIKGHEKHJK(object EJNFOCPFJML, StateChangedEventArgs EEEKBCFAGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66376D0", Offset = "0x66360D0", VA = "0x1866376D0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6637860", Offset = "0x6636260", VA = "0x186637860")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66374D0", Offset = "0x6635ED0", VA = "0x1866374D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6636FD0", Offset = "0x66359D0", VA = "0x186636FD0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6636F90", Offset = "0x6635990", VA = "0x186636F90")]
		private void GFJMNFNMGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6637600", Offset = "0x6636000", VA = "0x186637600", Slot = "4")]
		public void PushNetworkMessage(MDKHBMJHAKI.MPMIBCDAGFH DNNAMOOCONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
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
