using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using EasyAntiCheat.Client;
using EasyAntiCheat.Client.ClientAuth;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AntiCheat
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class EACManager : MonoBehaviour, DCOEGPLIFMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth ABHADONOPHE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool BEOMIIHFMLM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x70E8960", Offset = "0x70E7B60", VA = "0x1870E8960")]
		public static string GenerateChallengeResponse(string NCNCPHPDPIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x70E8880", Offset = "0x70E7A80", VA = "0x1870E8880")]
		private static void GCLJCIAKHMA(OALENMGPFHP.KAECMGKKBLC DGLHFPEOHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x70E8520", Offset = "0x70E7720", VA = "0x1870E8520")]
		private static bool EJDEKGFDNMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x70E8A90", Offset = "0x70E7C90", VA = "0x1870E8A90")]
		private static void LJKHMDMHFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70E8400", Offset = "0x70E7600", VA = "0x1870E8400")]
		private static void BKBKOMPLEMD(object LJLEBBFLEIN, LoadProgressEventArgs FBMHIFMGLKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70E8DE0", Offset = "0x70E7FE0", VA = "0x1870E8DE0")]
		private static void PCCKLBCKPFA(object LJLEBBFLEIN, LoadCompletedEventArgs FBMHIFMGLKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70E8B20", Offset = "0x70E7D20", VA = "0x1870E8B20")]
		private static void MFGBGBFGDKA(object LJLEBBFLEIN, StateChangedEventArgs FBMHIFMGLKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70E90C0", Offset = "0x70E82C0", VA = "0x1870E90C0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70E9230", Offset = "0x70E8430", VA = "0x1870E9230")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x70E8CE0", Offset = "0x70E7EE0", VA = "0x1870E8CE0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70E8A90", Offset = "0x70E7C90", VA = "0x1870E8A90")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x70E8830", Offset = "0x70E7A30", VA = "0x1870E8830")]
		private void FNEFGCKPIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x70E8FE0", Offset = "0x70E81E0", VA = "0x1870E8FE0", Slot = "4")]
		public void PushNetworkMessage(OALENMGPFHP.KAECMGKKBLC DGLHFPEOHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		public EACManager()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
