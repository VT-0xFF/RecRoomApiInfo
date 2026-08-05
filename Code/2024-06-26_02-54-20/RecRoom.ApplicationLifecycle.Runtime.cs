using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BFIKGHNPIAF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread JGAJBNGAEBI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool KPNKOPMKGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67C8710", Offset = "0x67C6D10", VA = "0x1867C8710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67C86B0", Offset = "0x67C6CB0", VA = "0x1867C86B0")]
	[JCLEFGKHEPL(LONMDOPJFCD.Unity_AfterSceneLoad)]
	private static void DBDMEAACDHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NILKNAMLKCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HFFAJDNCNJL MAGMGCHJODF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event GEBBOIDGCDH OMKLHJHPBJI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JCKFBAGDHCD LKGMHCOOGEP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JJKHPNHPJEC ELGCNFKCKBL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event LMEEMJDPPKM BFGCCLHMNLA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event GDPJJKLMGEN LBNGEFNPFLH;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event PAOHNNANEGA HCEOGLGJBKO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event EILFGEHMJKK MDCDIFHCGNL;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event GFPLCCHANCM AGGDFBLEPGD;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void GEBBOIDGCDH();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void JCKFBAGDHCD();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JJKHPNHPJEC();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GDPJJKLMGEN();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void PAOHNNANEGA();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void EILFGEHMJKK();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void LMEEMJDPPKM();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void HFFAJDNCNJL(bool FJEPCIHEMLB);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void GFPLCCHANCM();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67C8530", Offset = "0x67C6B30", VA = "0x1867C8530")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67C8610", Offset = "0x67C6C10", VA = "0x1867C8610")]
		public static void SafeDestroyGameObject(GameObject INALOLPJOHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class AEIJFIHMDOM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool LAKPADDBPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67C84B0", Offset = "0x67C6AB0", VA = "0x1867C84B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67C83F0", Offset = "0x67C69F0", VA = "0x1867C83F0")]
	[JCLEFGKHEPL(LONMDOPJFCD.Unity_AfterSceneLoad)]
	private static void BGGINNGCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67C84F0", Offset = "0x67C6AF0", VA = "0x1867C84F0")]
	internal static void LAIAGIINPLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JDNIJKLHJEP
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> ANLBHOPJLGP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(JDNIJKLHJEP IDBPDPIMDCB);
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
