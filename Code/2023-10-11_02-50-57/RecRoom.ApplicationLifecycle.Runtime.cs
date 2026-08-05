using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HHPAHPOCHFE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread IEDHLNDDAGB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool JMFIKIPMDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEA10", Offset = "0x5BED810", VA = "0x185BEEA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE9B0", Offset = "0x5BED7B0", VA = "0x185BEE9B0")]
	[CCODNAGEEMD(JPDNIMGFJLH.Unity_AfterSceneLoad)]
	private static void LPIADHCPHKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OICAFJIFHLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GJMIINAHAKO DOLNCCFKMGI;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event OJNNMBNPKKI PFMOOMMEHLD;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event AIDBIKFOENM AAFGKGBKHHD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PBMPCFGLKOP GOBODFCNJGI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event PIMIJKAMBEM MGIHDJAGKDN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PFNILDOLHFP BJCNGFIFHEO;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event DBPFCFMHGAO FEFGAMEAHCJ;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MDGCEHGOKKF HPGEIJOCMFN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event IBOPNCNEPFB PHJEHCAHBCO;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void OJNNMBNPKKI();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void AIDBIKFOENM();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void PBMPCFGLKOP();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void PFNILDOLHFP();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void DBPFCFMHGAO();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void MDGCEHGOKKF();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void PIMIJKAMBEM();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void GJMIINAHAKO(bool HFBOANECIOL);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void IBOPNCNEPFB();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5BEE6F0", Offset = "0x5BED4F0", VA = "0x185BEE6F0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5BEE7D0", Offset = "0x5BED5D0", VA = "0x185BEE7D0")]
		public static void SafeDestroyGameObject(GameObject DEGGPBGPMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EAKNCEOAJAK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool NFPGDNKAMBN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5BEE8B0", Offset = "0x5BED6B0", VA = "0x185BEE8B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE8F0", Offset = "0x5BED6F0", VA = "0x185BEE8F0")]
	[CCODNAGEEMD(JPDNIMGFJLH.Unity_AfterSceneLoad)]
	private static void OOCIGOIJKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE870", Offset = "0x5BED670", VA = "0x185BEE870")]
	internal static void IKMGLFEIMBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ALNHJACDOBD
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> KNFLBMCPIED;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(ALNHJACDOBD CEAOEEAPGHC);
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
