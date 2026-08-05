using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PFGHKNAIAKD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread CDPKKJJPFMG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool NDPJAHLHNCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCFE0", Offset = "0x5CFBDE0", VA = "0x185CFCFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD030", Offset = "0x5CFBE30", VA = "0x185CFD030")]
	[FLGENPOMBLL(JMPBNKBIDHL.Unity_AfterSceneLoad)]
	private static void KBMJKMKMJBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OOHPLFGDOBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HEMNIBJAKBG LLAFKLDIPLE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event DGNIOGPHIKN KHHFOFCHJNL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EHKNIIMNNHJ FAFFAHJOFAG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PIAHGBJDNJD ICIHCIIMIHL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MBHGAPHGEHI MNONNIAFCHF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event LCKOJLKLCFG JKKFPLLIKAK;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event IPCPIALEPIB CGDLBGAPJMK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event LHNJKDFPJDA ACIDECPIPEA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event BMMELENLFBL NKKJPLHOLAL;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void DGNIOGPHIKN();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void EHKNIIMNNHJ();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void PIAHGBJDNJD();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LCKOJLKLCFG();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void IPCPIALEPIB();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void LHNJKDFPJDA();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void MBHGAPHGEHI();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void HEMNIBJAKBG(bool ECOMHJDILDO);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void BMMELENLFBL();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCE60", Offset = "0x5CFBC60", VA = "0x185CFCE60")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCF40", Offset = "0x5CFBD40", VA = "0x185CFCF40")]
		public static void SafeDestroyGameObject(GameObject CJHJDJNKIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76DFF0", VA = "0x18076F1F0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PGDMJPPBKKB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool BFNKKGOKNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD150", Offset = "0x5CFBF50", VA = "0x185CFD150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD090", Offset = "0x5CFBE90", VA = "0x185CFD090")]
	[FLGENPOMBLL(JMPBNKBIDHL.Unity_AfterSceneLoad)]
	private static void CAKCEPELMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD190", Offset = "0x5CFBF90", VA = "0x185CFD190")]
	internal static void KNPIENOBJDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AJMBKJOLOEB
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> FLHILPHIKOB;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(AJMBKJOLOEB IBFLPKBCBKC);
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
