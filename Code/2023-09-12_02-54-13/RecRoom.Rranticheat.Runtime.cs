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
	public class EACManager : MonoBehaviour, FIPPNAFGLMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth NNEGJOPIBAO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool FCENGCEAPPP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x71FBDF0", Offset = "0x71FB1F0", VA = "0x1871FBDF0")]
		public static string GenerateChallengeResponse(string KOPKJKKMNHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71FBB00", Offset = "0x71FAF00", VA = "0x1871FBB00")]
		private static void BHPDHCAHLAJ(PJBIMJDKALI.DMFCBGEDDFD HOJNLEBJGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x71FC040", Offset = "0x71FB440", VA = "0x1871FC040")]
		private static bool IFMFNBLAKGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71FC350", Offset = "0x71FB750", VA = "0x1871FC350")]
		private static void LAPDFPNBOMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71FBF20", Offset = "0x71FB320", VA = "0x1871FBF20")]
		private static void HJOKJKFIHGP(object LKCBDABJCED, LoadProgressEventArgs KCCNEKLDFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71FC3E0", Offset = "0x71FB7E0", VA = "0x1871FC3E0")]
		private static void MDJBLDKNCPI(object LKCBDABJCED, LoadCompletedEventArgs KCCNEKLDFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71FBC30", Offset = "0x71FB030", VA = "0x1871FBC30")]
		private static void GGHLOAKOLCC(object LKCBDABJCED, StateChangedEventArgs KCCNEKLDFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71FC7C0", Offset = "0x71FBBC0", VA = "0x1871FC7C0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71FC930", Offset = "0x71FBD30", VA = "0x1871FC930")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71FC5E0", Offset = "0x71FB9E0", VA = "0x1871FC5E0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71FC350", Offset = "0x71FB750", VA = "0x1871FC350")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71FBBE0", Offset = "0x71FAFE0", VA = "0x1871FBBE0")]
		private void GFMCHBMPKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x71FC6E0", Offset = "0x71FBAE0", VA = "0x1871FC6E0", Slot = "4")]
		public void PushNetworkMessage(PJBIMJDKALI.DMFCBGEDDFD HOJNLEBJGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
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
