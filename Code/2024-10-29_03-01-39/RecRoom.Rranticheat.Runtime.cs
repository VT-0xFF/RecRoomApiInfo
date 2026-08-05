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
	public class EACManager : MonoBehaviour, NOPGNNEBKLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth FGICLIHFFKE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KPOOFHNEMCH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75EDE70", Offset = "0x75ECE70", VA = "0x1875EDE70")]
		public static string GenerateChallengeResponse(string IGDIFAPAOJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x75EDCE0", Offset = "0x75ECCE0", VA = "0x1875EDCE0")]
		private static void AJELCDLJFLK(BDMJHHPPBMA.PDEPFBLBFAB NDBAHEIEDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75EE400", Offset = "0x75ED400", VA = "0x1875EE400")]
		private static bool NHNHACFAOBN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75EDDF0", Offset = "0x75ECDF0", VA = "0x1875EDDF0")]
		private static void FGANJGIGECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x75EE2F0", Offset = "0x75ED2F0", VA = "0x1875EE2F0")]
		private static void MBBCABDDFHL(object IIGMJGEPAIO, LoadProgressEventArgs ALKOMCFHDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75EE120", Offset = "0x75ED120", VA = "0x1875EE120")]
		private static void HNMKFKGMNGL(object IIGMJGEPAIO, LoadCompletedEventArgs ALKOMCFHDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75EDF80", Offset = "0x75ECF80", VA = "0x1875EDF80")]
		private static void HGLLHJBCHPL(object IIGMJGEPAIO, StateChangedEventArgs ALKOMCFHDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75EE8C0", Offset = "0x75ED8C0", VA = "0x1875EE8C0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75EEA40", Offset = "0x75EDA40", VA = "0x1875EEA40")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x75EE6D0", Offset = "0x75ED6D0", VA = "0x1875EE6D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75EDDF0", Offset = "0x75ECDF0", VA = "0x1875EDDF0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75EDDB0", Offset = "0x75ECDB0", VA = "0x1875EDDB0")]
		private void BBEMBEGPDKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75EE7F0", Offset = "0x75ED7F0", VA = "0x1875EE7F0", Slot = "4")]
		public void PushNetworkMessage(BDMJHHPPBMA.PDEPFBLBFAB NDBAHEIEDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
