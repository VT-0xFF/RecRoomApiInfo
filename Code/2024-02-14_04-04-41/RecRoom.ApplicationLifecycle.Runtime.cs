using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KINDNMMJKLC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread MPBPOAKIAJE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool INGPLJPPGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5E05CE0", Offset = "0x5E050E0", VA = "0x185E05CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E05D30", Offset = "0x5E05130", VA = "0x185E05D30")]
	[DDPIKLHKBPE(PCHEJJBEMBB.Unity_AfterSceneLoad)]
	private static void JAMHGAPJMJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NHFHGODLONK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LFEONJBNHDH IFAPDLELCBB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event IEKCAGPGEEL JPBFJKJIHMJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EKGFHLMOEPE GOMIOHKPIIK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EPFEPHLDIIN EFDEIJJMCBD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event BKGIOMJJOCI KLPFCOGNFEL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event LNGGFOBFAKB JJAHLLFJLLJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event AMNAJPAMHFA PCJGAAEAMAI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event HLOHKCKIHLA GPIEBECHJEB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event IEEDPLFNFFG JFPHKOJBAAC;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void IEKCAGPGEEL();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void EKGFHLMOEPE();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void EPFEPHLDIIN();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LNGGFOBFAKB();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void AMNAJPAMHFA();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void HLOHKCKIHLA();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void BKGIOMJJOCI();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void LFEONJBNHDH(bool HFPFFAODCGA);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void IEEDPLFNFFG();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E05A20", Offset = "0x5E04E20", VA = "0x185E05A20")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E05B00", Offset = "0x5E04F00", VA = "0x185E05B00")]
		public static void SafeDestroyGameObject(GameObject IPBNGJILMJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x79E360", Offset = "0x79D760", VA = "0x18079E360")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HHKCMMIFNOC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool KAOICDPBNON
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5E05CA0", Offset = "0x5E050A0", VA = "0x185E05CA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E05BE0", Offset = "0x5E04FE0", VA = "0x185E05BE0")]
	[DDPIKLHKBPE(PCHEJJBEMBB.Unity_AfterSceneLoad)]
	private static void NGFHLNOOHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E05BA0", Offset = "0x5E04FA0", VA = "0x185E05BA0")]
	internal static void GHABGDNOCFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MKIJNCAIOOL
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> PAIFLCEPJNJ;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(MKIJNCAIOOL DFFABIFLCGE);
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
