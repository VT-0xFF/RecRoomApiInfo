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
	public class EACManager : MonoBehaviour, OHLACGDCIGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth PDMPAEAJCPM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool FNMNFALGEMJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7292AF0", Offset = "0x72910F0", VA = "0x187292AF0")]
		public static string GenerateChallengeResponse(string OBMOAAFAEOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7292DE0", Offset = "0x72913E0", VA = "0x187292DE0")]
		private static void OJDGPIPDHBP(FJJHNEOJLPA.MCKPCMFBLJM AJFODGMHKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7292820", Offset = "0x7290E20", VA = "0x187292820")]
		private static bool CGHIOAHHHMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7292EB0", Offset = "0x72914B0", VA = "0x187292EB0")]
		private static void PJPCHDLCNCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7292710", Offset = "0x7290D10", VA = "0x187292710")]
		private static void ANLOOEOBDNN(object PONAMMMCEME, LoadProgressEventArgs CECPNEMKKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7292540", Offset = "0x7290B40", VA = "0x187292540")]
		private static void ABHNIGOAPAE(object PONAMMMCEME, LoadCompletedEventArgs CECPNEMKKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7292C00", Offset = "0x7291200", VA = "0x187292C00")]
		private static void HDBDDALBHOC(object PONAMMMCEME, StateChangedEventArgs CECPNEMKKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7293120", Offset = "0x7291720", VA = "0x187293120")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72932A0", Offset = "0x72918A0", VA = "0x1872932A0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7292F30", Offset = "0x7291530", VA = "0x187292F30")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7292EB0", Offset = "0x72914B0", VA = "0x187292EB0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7292DA0", Offset = "0x72913A0", VA = "0x187292DA0")]
		private void KMADCJHPJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7293050", Offset = "0x7291650", VA = "0x187293050", Slot = "4")]
		public void PushNetworkMessage(FJJHNEOJLPA.MCKPCMFBLJM AJFODGMHKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
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
