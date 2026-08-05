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
	public class EACManager : MonoBehaviour, EDFMBFONJMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth FBGBBMMPIEO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool DFPECCBOLLG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6289910", Offset = "0x6288110", VA = "0x186289910")]
		public static string GenerateChallengeResponse(string CLEONPPGPCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6289840", Offset = "0x6288040", VA = "0x186289840")]
		private static void DODAEPLDLNO(DLMIACIFDAE.AJFBIBFLLIN AJPCNFDACDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6289A20", Offset = "0x6288220", VA = "0x186289A20")]
		private static bool HNMFCNBMLIL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6289E90", Offset = "0x6288690", VA = "0x186289E90")]
		private static void MNEEHBNEHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6289730", Offset = "0x6287F30", VA = "0x186289730")]
		private static void DMFLFLIJMMJ(object OCBPEICPBDN, LoadProgressEventArgs JMAKDBEHALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6289560", Offset = "0x6287D60", VA = "0x186289560")]
		private static void BPAAGEHMMHK(object OCBPEICPBDN, LoadCompletedEventArgs JMAKDBEHALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6289CF0", Offset = "0x62884F0", VA = "0x186289CF0")]
		private static void KHJAFMAGMKO(object OCBPEICPBDN, StateChangedEventArgs JMAKDBEHALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x628A150", Offset = "0x6288950", VA = "0x18628A150")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x628A2E0", Offset = "0x6288AE0", VA = "0x18628A2E0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6289F10", Offset = "0x6288710", VA = "0x186289F10")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6289E90", Offset = "0x6288690", VA = "0x186289E90")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x628A040", Offset = "0x6288840", VA = "0x18628A040")]
		private void PMEGJNOLKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x628A080", Offset = "0x6288880", VA = "0x18628A080", Slot = "4")]
		public void PushNetworkMessage(DLMIACIFDAE.AJFBIBFLLIN AJPCNFDACDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
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
