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
	public class EACManager : MonoBehaviour, HPFGEFDGOME
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth COBPGCOLPBI;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool EJDJLBMOABL;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x66FFE70", Offset = "0x66FEC70", VA = "0x1866FFE70")]
		public static string GenerateChallengeResponse(string AMCKDJEKBPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x66FFBC0", Offset = "0x66FE9C0", VA = "0x1866FFBC0")]
		private static void EOEGHAFEFOF(LPKMAJOMJOD.IIOJKONLHCJ AOJMAAJAPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x66FFF80", Offset = "0x66FED80", VA = "0x1866FFF80")]
		private static bool KNJKJPEBMPH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x66FFB40", Offset = "0x66FE940", VA = "0x1866FFB40")]
		private static void CDIDMLAKKNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6700550", Offset = "0x66FF350", VA = "0x186700550")]
		private static void POLDHAGEANE(object JKJKGBOMLMO, LoadProgressEventArgs NAIIJMPLGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6700380", Offset = "0x66FF180", VA = "0x186700380")]
		private static void PJHEELMJHKK(object JKJKGBOMLMO, LoadCompletedEventArgs NAIIJMPLGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66FFC90", Offset = "0x66FEA90", VA = "0x1866FFC90")]
		private static void FBALGIFGJLO(object JKJKGBOMLMO, StateChangedEventArgs NAIIJMPLGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6700730", Offset = "0x66FF530", VA = "0x186700730")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67008C0", Offset = "0x66FF6C0", VA = "0x1867008C0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6700250", Offset = "0x66FF050", VA = "0x186700250")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x66FFB40", Offset = "0x66FE940", VA = "0x1866FFB40")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x66FFE30", Offset = "0x66FEC30", VA = "0x1866FFE30")]
		private void GJJMNECEJIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6700660", Offset = "0x66FF460", VA = "0x186700660", Slot = "4")]
		public void PushNetworkMessage(LPKMAJOMJOD.IIOJKONLHCJ AOJMAAJAPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
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
