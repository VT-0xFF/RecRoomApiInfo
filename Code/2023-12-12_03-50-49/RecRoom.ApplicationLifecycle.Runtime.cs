using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DAAKNBJGLDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread EEHKILOCOGO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool CGKBBCENNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D202D0", Offset = "0x5D1EAD0", VA = "0x185D202D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D20320", Offset = "0x5D1EB20", VA = "0x185D20320")]
	[LCKMJKIGHKB(BIHOHBMMECD.Unity_AfterSceneLoad)]
	private static void PIAOHNCICLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EKAPBENGAHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GNMKJAKJGAB FHEHBMEHBHG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KHPGDFOFEED OMANMGAMPNF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LCOJPHEBILK OBFGJLHMCFF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MDOGKGKHCMF LPLGEFOKLIP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JNNCDECMBJH HDLAMMIEADI;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event GBGGKPLLCNL CGMCGLIAFAM;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event LIFMLDFBGBC NLGLOLNAOJJ;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FPIKLOIGLPJ FIGKNEBNEHH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event GOKJENPLOKL ACGOHANMBLP;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void KHPGDFOFEED();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void LCOJPHEBILK();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void MDOGKGKHCMF();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GBGGKPLLCNL();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void LIFMLDFBGBC();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void FPIKLOIGLPJ();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void JNNCDECMBJH();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void GNMKJAKJGAB(bool IFGOPCANJID);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void GOKJENPLOKL();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D20150", Offset = "0x5D1E950", VA = "0x185D20150")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5D20230", Offset = "0x5D1EA30", VA = "0x185D20230")]
		public static void SafeDestroyGameObject(GameObject AOMHCMIECFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7721F0", Offset = "0x7709F0", VA = "0x1807721F0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NICLNMOGCGL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool HPHJDJEJEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5D20380", Offset = "0x5D1EB80", VA = "0x185D20380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D203C0", Offset = "0x5D1EBC0", VA = "0x185D203C0")]
	[LCKMJKIGHKB(BIHOHBMMECD.Unity_AfterSceneLoad)]
	private static void EBEAKPIECKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D20480", Offset = "0x5D1EC80", VA = "0x185D20480")]
	internal static void LJPNALBGALJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PAMMIBKNIND
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> NEEIGAINHGC;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(PAMMIBKNIND JOKLJPCNBGF);
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
