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
	public class EACManager : MonoBehaviour, JOJNILNLBFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth AGIOKBPLMMO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool FHHKHMFNLIE;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5250", Offset = "0x6EF3A50", VA = "0x186EF5250")]
		public static string GenerateChallengeResponse(string NOBOPEOOPCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4DC0", Offset = "0x6EF35C0", VA = "0x186EF4DC0")]
		private static void ALEBMCCFMHD(FHLMLLHPNCB.EFBHKEDBBNE BKHMACKFNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5690", Offset = "0x6EF3E90", VA = "0x186EF5690")]
		private static bool PLHPKIDAPCE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4EA0", Offset = "0x6EF36A0", VA = "0x186EF4EA0")]
		private static void BAMAMNIIDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5130", Offset = "0x6EF3930", VA = "0x186EF5130")]
		private static void CGPJILJGBBE(object HKAMNAOODFK, LoadProgressEventArgs OOEBACGKJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4F30", Offset = "0x6EF3730", VA = "0x186EF4F30")]
		private static void BDKNGCHBLLI(object HKAMNAOODFK, LoadCompletedEventArgs OOEBACGKJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EF53D0", Offset = "0x6EF3BD0", VA = "0x186EF53D0")]
		private static void NKEPNHHJIFF(object HKAMNAOODFK, StateChangedEventArgs OOEBACGKJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5A80", Offset = "0x6EF4280", VA = "0x186EF5A80")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5BF0", Offset = "0x6EF43F0", VA = "0x186EF5BF0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5590", Offset = "0x6EF3D90", VA = "0x186EF5590")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4EA0", Offset = "0x6EF36A0", VA = "0x186EF4EA0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5380", Offset = "0x6EF3B80", VA = "0x186EF5380")]
		private void KDLPDCECJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF59A0", Offset = "0x6EF41A0", VA = "0x186EF59A0", Slot = "4")]
		public void PushNetworkMessage(FHLMLLHPNCB.EFBHKEDBBNE BKHMACKFNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
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
