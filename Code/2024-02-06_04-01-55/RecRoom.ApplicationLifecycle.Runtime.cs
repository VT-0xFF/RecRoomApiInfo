using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HMEJLFMPINK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread DCDGJCOIJOF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool GHIEPDOGBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5F5A0C0", Offset = "0x5F594C0", VA = "0x185F5A0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A060", Offset = "0x5F59460", VA = "0x185F5A060")]
	[AGCEEPPEOHJ(PHBLJIALGCE.Unity_AfterSceneLoad)]
	private static void BEDMHIEHCCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MKJDOMGIMCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BCPMPHOHHLM LDIDLIBIDPF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KBDCBCHCHON NEPLKJNDANP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LPJCJDKDBBF MBFELDBDGBB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CPJOLEKNFMG MIPBKPIGOKL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event LGALGHGIEGB HLLBHGAKKEB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event HHFCHEAJNFG MDILLFHAMKD;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event LGPPDPOILPA KLEINKJIFPK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NJFBBBFDBGN JLJDHJJHJJC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event PGAEJFCEIKM OOKAJANOMEC;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void KBDCBCHCHON();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void LPJCJDKDBBF();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void CPJOLEKNFMG();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HHFCHEAJNFG();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void LGPPDPOILPA();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void NJFBBBFDBGN();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void LGALGHGIEGB();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void BCPMPHOHHLM(bool AHHJFJNLADM);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void PGAEJFCEIKM();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5F59EE0", Offset = "0x5F592E0", VA = "0x185F59EE0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F59FC0", Offset = "0x5F593C0", VA = "0x185F59FC0")]
		public static void SafeDestroyGameObject(GameObject ILLDLCGIGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NEKADOFJCPC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool JEOIAPKMHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5F5A150", Offset = "0x5F59550", VA = "0x185F5A150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A190", Offset = "0x5F59590", VA = "0x185F5A190")]
	[AGCEEPPEOHJ(PHBLJIALGCE.Unity_AfterSceneLoad)]
	private static void OBMDJKKOMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A110", Offset = "0x5F59510", VA = "0x185F5A110")]
	internal static void BGIBDBBMLGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LDIJCEEJBHG
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> EMJPANBMOHI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(LDIJCEEJBHG MGEJJCOEGGI);
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
