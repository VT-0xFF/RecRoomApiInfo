using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x79221F0", Offset = "0x79213F0", VA = "0x1879221F0", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0C10", Offset = "0x1DDFE10", VA = "0x181DE0C10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x79222C0", Offset = "0x79214C0", VA = "0x1879222C0")]
		private void GAEACHOPMAB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x79226D0", Offset = "0x79218D0", VA = "0x1879226D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7922500", Offset = "0x7921700", VA = "0x187922500", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7922730", Offset = "0x7921930", VA = "0x187922730")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(JLCDAIMNCDG), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class JLCDAIMNCDG : FMGJOLNHDJA, CIDGALBBDPG
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class BKALOMHLBNF : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JLCDAIMNCDG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public BKALOMHLBNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x79205B0", Offset = "0x791F7B0", VA = "0x1879205B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x79207D0", Offset = "0x791F9D0", VA = "0x1879207D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private FHKJIBGLEFM MAIOBCANDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private MEKMCOEEPLL DHGAELFLCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable ENNMKCFAHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable NLNEODMHJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> FEIJPNBPIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool LAMHMHLNBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool HDKFGONIPFB;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7922160", Offset = "0x7921360", VA = "0x187922160")]
	[UnityEngine.Scripting.Preserve]
	public JLCDAIMNCDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79216E0", Offset = "0x79208E0", VA = "0x1879216E0", Slot = "4")]
	public void IKMJEIIMCKI(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7921860", Offset = "0x7920A60", VA = "0x187921860")]
	private void IMNMHPOLHDK(Scene NOOHBLOGPAC, LoadSceneMode NDLBHCCJHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7921870", Offset = "0x7920A70", VA = "0x187921870")]
	private void MELEDBDKOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7921340", Offset = "0x7920540", VA = "0x187921340")]
	private void AHBPGDJHDMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7921F10", Offset = "0x7921110", VA = "0x187921F10")]
	private (ReflectionProbe, int) PHABFKLCEOJ()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7921530", Offset = "0x7920730", VA = "0x187921530")]
	[IteratorStateMachine(typeof(BKALOMHLBNF))]
	private IEnumerator<IOBGCLDPPJE> DEPEDMPHECH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7921600", Offset = "0x7920800", VA = "0x187921600")]
	private void HOMBFHBGPMF([CanBeNull] ReflectionProbe DBCFMFOEONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7921500", Offset = "0x7920700", VA = "0x187921500")]
	private void BPMJHCGGNGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79215B0", Offset = "0x79207B0", VA = "0x1879215B0")]
	private void FOOIICIHMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7921420", Offset = "0x7920620", VA = "0x187921420", Slot = "5")]
	public void APIIJJHOIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7921A20", Offset = "0x7920C20", VA = "0x187921A20")]
	[CompilerGenerated]
	private void MNCLOCKNPNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FHKJIBGLEFM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? GFDPFBFGOGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LNLHLAFHAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKMHCLFCDPA();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GGJOAOMAIJF : FHKJIBGLEFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string MMFCEKEOOPA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string PCPGLPILIKJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string NFPHEMJIHJB;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string BBGBMLFPNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DEGKPLDMDPH GIBLGOOHNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? BBBCKBHPGOD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? GFDPFBFGOGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LNLHLAFHAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0D0", Offset = "0x8FA2D0", VA = "0x1808FB0D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8FB090", Offset = "0x8FA290", VA = "0x1808FB090")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	[UnityEngine.Scripting.Preserve]
	public GGJOAOMAIJF([NotNull][FMJHJHHALCB(null)] DEGKPLDMDPH FFIHFEFPIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7920820", Offset = "0x791FA20", VA = "0x187920820", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x79210C0", Offset = "0x79202C0", VA = "0x1879210C0")]
	[NAOGKPPNIGE.AGGBMPJIOLK.IPOKDFJKKKA]
	[UsedImplicitly]
	public static void PJHFMNNNLAI(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7920A00", Offset = "0x791FC00", VA = "0x187920A00", Slot = "5")]
	public void FKMHCLFCDPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7920B00", Offset = "0x791FD00", VA = "0x187920B00")]
	private void PHNDIFICFOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7920920", Offset = "0x791FB20", VA = "0x187920920")]
	private bool EDGMMHINIEM(string MHCJDKOFMNO, [Out] BOHBFBLMJMH HIFEAHPGFIO)
	{
		return default(bool);
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
