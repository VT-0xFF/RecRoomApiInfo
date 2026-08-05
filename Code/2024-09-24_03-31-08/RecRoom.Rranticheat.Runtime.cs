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
	public class EACManager : MonoBehaviour, FCIFBBAIMMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth MBFGEEIEAKL;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool DJOAABIMILF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72C2B50", Offset = "0x72C1550", VA = "0x1872C2B50")]
		public static string GenerateChallengeResponse(string MLJEMHDAELN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72C28B0", Offset = "0x72C12B0", VA = "0x1872C28B0")]
		private static void DJMDDOHOONG(DLJJBHCGHBJ.JDDACKAHKAC HDOCILHNNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72C2440", Offset = "0x72C0E40", VA = "0x1872C2440")]
		private static bool BCPGOJCNGKJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72C2CA0", Offset = "0x72C16A0", VA = "0x1872C2CA0")]
		private static void NBKLJMADHOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72C2D20", Offset = "0x72C1720", VA = "0x1872C2D20")]
		private static void OGBJHNMKIOC(object JPOLOLOCDFN, LoadProgressEventArgs BBFOLDBBNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72C2980", Offset = "0x72C1380", VA = "0x1872C2980")]
		private static void GFMFKGEKJPB(object JPOLOLOCDFN, LoadCompletedEventArgs BBFOLDBBNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72C2710", Offset = "0x72C1110", VA = "0x1872C2710")]
		private static void BKKLLAHPGLC(object JPOLOLOCDFN, StateChangedEventArgs BBFOLDBBNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72C3020", Offset = "0x72C1A20", VA = "0x1872C3020")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72C31A0", Offset = "0x72C1BA0", VA = "0x1872C31A0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72C2E30", Offset = "0x72C1830", VA = "0x1872C2E30")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72C2CA0", Offset = "0x72C16A0", VA = "0x1872C2CA0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72C2C60", Offset = "0x72C1660", VA = "0x1872C2C60")]
		private void IAGFLLPAPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72C2F50", Offset = "0x72C1950", VA = "0x1872C2F50", Slot = "4")]
		public void PushNetworkMessage(DLJJBHCGHBJ.JDDACKAHKAC HDOCILHNNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
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
