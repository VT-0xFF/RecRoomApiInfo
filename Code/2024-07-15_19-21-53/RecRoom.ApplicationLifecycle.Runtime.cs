using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FBNJEBEPEOE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread BJNIODHCGLP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool HEBAMEOHLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x675A1B0", Offset = "0x67589B0", VA = "0x18675A1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x675A150", Offset = "0x6758950", VA = "0x18675A150")]
	[FCFOCBHCEIP(MJLCCMEEJMA.Unity_AfterSceneLoad)]
	private static void HDHCDDINGJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IHCGHJBEAFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EFOPFMNMIGF AJAFEBCAKOM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NLADOIDFGLE LHGGKPHIKGE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BICAGGKBIIC LFENBOKJKMG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GHPMJAOODIN ECEIDBDCEGN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MDPLNGEDJFA DNFNIEOELEF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PJEJONGLOFC MALPNKLOAFE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event OGBGCGJEDCJ DPNJJDNAOBC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event IIJAAOKIJHO IAADPOODKJK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event CHDDGDFJKGD KKCFHKBMHNK;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void NLADOIDFGLE();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void BICAGGKBIIC();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void GHPMJAOODIN();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void PJEJONGLOFC();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void OGBGCGJEDCJ();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void IIJAAOKIJHO();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void MDPLNGEDJFA();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void EFOPFMNMIGF(bool OPGFDEEIDIG);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void CHDDGDFJKGD();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6759FD0", Offset = "0x67587D0", VA = "0x186759FD0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x675A0B0", Offset = "0x67588B0", VA = "0x18675A0B0")]
		public static void SafeDestroyGameObject(GameObject NBDLDMDNCAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GBIFPKBNDIK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool PFKLHOJPJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x675A300", Offset = "0x6758B00", VA = "0x18675A300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x675A240", Offset = "0x6758A40", VA = "0x18675A240")]
	[FCFOCBHCEIP(MJLCCMEEJMA.Unity_AfterSceneLoad)]
	private static void HMCGAKKBHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x675A200", Offset = "0x6758A00", VA = "0x18675A200")]
	internal static void EELMJLKHGKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MPBHPKMFDGC
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> FJFBLCDNHOA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(MPBHPKMFDGC PNNKGPPNFHO);
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
