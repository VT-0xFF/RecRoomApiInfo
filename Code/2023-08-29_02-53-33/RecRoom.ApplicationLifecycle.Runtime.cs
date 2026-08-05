using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EJIIGKGEGEH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread ACCDFFOHCAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool NMPBIBPGCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4E70", Offset = "0x6FA4270", VA = "0x186FA4E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FA4EC0", Offset = "0x6FA42C0", VA = "0x186FA4EC0")]
	[CIICLEENABO(ELFANDMFEMB.Unity_AfterSceneLoad)]
	private static void GMGNMHCNENI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DKPDJALLCBJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> EHGKPPCIAHO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(DKPDJALLCBJ INOAGFPGNFH);
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4CC0", Offset = "0x6FA40C0", VA = "0x186FA4CC0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4DB0", Offset = "0x6FA41B0", VA = "0x186FA4DB0")]
		public static void SafeDestroyGameObject(GameObject GACFHLOJJGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HODMPGAKLDL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool MACEADCOKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5010", Offset = "0x6FA4410", VA = "0x186FA5010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FA4F10", Offset = "0x6FA4310", VA = "0x186FA4F10")]
	[CIICLEENABO(ELFANDMFEMB.Unity_AfterSceneLoad)]
	private static void BEFDPLAELIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FA4FD0", Offset = "0x6FA43D0", VA = "0x186FA4FD0")]
	internal static void GPHGAOAFNKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PBOHIBPCHBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event ONDKCJBAGLP FLAKKECKCID;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OILLOPPIJIF COCGDBGCNKP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MOGAGGKIION ABNCHIAHMAO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FHLICADHBED KPGFNJNLOIN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PCAOGKAKBHA BEKHBMLNCEM;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event HBCMMFIGKBG JGOILNKADIM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CIJHPLNBAEA DKICDMAJCPN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NDOOAMFMMFN CNOAHKNGABB;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event HICHCPACNJB NPKEHJOIFKO;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void OILLOPPIJIF();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void MOGAGGKIION();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void FHLICADHBED();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void HBCMMFIGKBG();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void CIJHPLNBAEA();
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void NDOOAMFMMFN();
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void PCAOGKAKBHA();
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void ONDKCJBAGLP(bool KBGEKHKOJMG);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public delegate void HICHCPACNJB();
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
