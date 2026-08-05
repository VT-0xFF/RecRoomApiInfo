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
	public class EACManager : MonoBehaviour, AIGFKBNLAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth FIBDGLALLOM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool EOJLOPPLKJN;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72D5FF0", Offset = "0x72D49F0", VA = "0x1872D5FF0")]
		public static string GenerateChallengeResponse(string DMIHJJLGBDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72D5EE0", Offset = "0x72D48E0", VA = "0x1872D5EE0")]
		private static void BEKCIOCGPHH(JBHACLBFGHJ.KPKGMIFOFOO NGDEBDJEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72D6600", Offset = "0x72D5000", VA = "0x1872D6600")]
		private static bool OGKLMLPKCBI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72D62D0", Offset = "0x72D4CD0", VA = "0x1872D62D0")]
		private static void HIFKBLJEMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72D6350", Offset = "0x72D4D50", VA = "0x1872D6350")]
		private static void ICDEBGOMLAN(object HPCEDNEDPML, LoadProgressEventArgs KBKEIEFMGMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72D6100", Offset = "0x72D4B00", VA = "0x1872D6100")]
		private static void HGKCPGPCHEI(object HPCEDNEDPML, LoadCompletedEventArgs KBKEIEFMGMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72D6460", Offset = "0x72D4E60", VA = "0x1872D6460")]
		private static void KPFIGKNAGGK(object HPCEDNEDPML, StateChangedEventArgs KBKEIEFMGMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72D6AC0", Offset = "0x72D54C0", VA = "0x1872D6AC0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72D6C40", Offset = "0x72D5640", VA = "0x1872D6C40")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72D68D0", Offset = "0x72D52D0", VA = "0x1872D68D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72D62D0", Offset = "0x72D4CD0", VA = "0x1872D62D0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72D5FB0", Offset = "0x72D49B0", VA = "0x1872D5FB0")]
		private void DLEHLDEEPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72D69F0", Offset = "0x72D53F0", VA = "0x1872D69F0", Slot = "4")]
		public void PushNetworkMessage(JBHACLBFGHJ.KPKGMIFOFOO NGDEBDJEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
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
