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
	public class EACManager : MonoBehaviour, BMENKHIKGOB
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth GMMBMLDFPID;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KIFGKCEJFAF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6770C70", Offset = "0x676FE70", VA = "0x186770C70")]
		public static string GenerateChallengeResponse(string BOOFKAFGDNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6770800", Offset = "0x676FA00", VA = "0x186770800")]
		private static void BPOLDDNABLE(DMOJAFKDEKF.FBBOPIJFMJJ ECJANKACADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6770F20", Offset = "0x6770120", VA = "0x186770F20")]
		private static bool OIHLHIMDLLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67708D0", Offset = "0x676FAD0", VA = "0x1867708D0")]
		private static void CHCNCNBDJLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6770990", Offset = "0x676FB90", VA = "0x186770990")]
		private static void FIMFOFKMIAE(object NHCBDDAGJEG, LoadProgressEventArgs GMJEDEAGCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6770AA0", Offset = "0x676FCA0", VA = "0x186770AA0")]
		private static void FOFPJMGLIIJ(object NHCBDDAGJEG, LoadCompletedEventArgs GMJEDEAGCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6770D80", Offset = "0x676FF80", VA = "0x186770D80")]
		private static void IKLBFNIPMAC(object NHCBDDAGJEG, StateChangedEventArgs GMJEDEAGCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67713F0", Offset = "0x67705F0", VA = "0x1867713F0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6771580", Offset = "0x6770780", VA = "0x186771580")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x67711F0", Offset = "0x67703F0", VA = "0x1867711F0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67708D0", Offset = "0x676FAD0", VA = "0x1867708D0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6770950", Offset = "0x676FB50", VA = "0x186770950")]
		private void EHPKPIDJJNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6771320", Offset = "0x6770520", VA = "0x186771320", Slot = "4")]
		public void PushNetworkMessage(DMOJAFKDEKF.FBBOPIJFMJJ ECJANKACADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
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
