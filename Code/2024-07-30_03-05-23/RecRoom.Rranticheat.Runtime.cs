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
	public class EACManager : MonoBehaviour, DNNGEHAJNHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth DBMPIIIACNN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool AECIJMAFKBJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7119330", Offset = "0x7117930", VA = "0x187119330")]
		public static string GenerateChallengeResponse(string EAOCAGKDOEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71195E0", Offset = "0x7117BE0", VA = "0x1871195E0")]
		private static void LFFIGHOKMCG(BLLNLLCFBMN.PANKMJOILPJ OGADPHAKNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7118F50", Offset = "0x7117550", VA = "0x187118F50")]
		private static bool EMPGENADEPE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71196B0", Offset = "0x7117CB0", VA = "0x1871196B0")]
		private static void MJKDGDLDPGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7119220", Offset = "0x7117820", VA = "0x187119220")]
		private static void GBEDFMFOHCL(object ICCOGMMKEOM, LoadProgressEventArgs NOOCJDCMLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7118D80", Offset = "0x7117380", VA = "0x187118D80")]
		private static void EJHNEICFAKH(object ICCOGMMKEOM, LoadCompletedEventArgs NOOCJDCMLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7119440", Offset = "0x7117A40", VA = "0x187119440")]
		private static void KFDJBLKCCPC(object ICCOGMMKEOM, StateChangedEventArgs NOOCJDCMLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7119970", Offset = "0x7117F70", VA = "0x187119970")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7119B00", Offset = "0x7118100", VA = "0x187119B00")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7119770", Offset = "0x7117D70", VA = "0x187119770")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71196B0", Offset = "0x7117CB0", VA = "0x1871196B0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7119730", Offset = "0x7117D30", VA = "0x187119730")]
		private void ODMLPKECABH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x71198A0", Offset = "0x7117EA0", VA = "0x1871198A0", Slot = "4")]
		public void PushNetworkMessage(BLLNLLCFBMN.PANKMJOILPJ OGADPHAKNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
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
