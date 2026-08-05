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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BEC370", Offset = "0x7BEAF70", VA = "0x187BEC370", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCDA0", Offset = "0x1DFB9A0", VA = "0x181DFCDA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BED320", Offset = "0x7BEBF20", VA = "0x187BED320")]
		private void MPLOOPBCFDI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BED740", Offset = "0x7BEC340", VA = "0x187BED740", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BED570", Offset = "0x7BEC170", VA = "0x187BED570", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BED7A0", Offset = "0x7BEC3A0", VA = "0x187BED7A0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(OLLMEIICGAL), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class OLLMEIICGAL : HGCFNMLCHIG, PPOHJMEPICJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class BPJNGCBIGBH : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public OLLMEIICGAL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public BPJNGCBIGBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB5F0", Offset = "0x7BEA1F0", VA = "0x187BEB5F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB810", Offset = "0x7BEA410", VA = "0x187BEB810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ILDDOAJNCKK LGJDKALEGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private PHPOLMHKACA FOIMNMKKGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable HIPHEMLEPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable MJIIBBLADMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> NHEKDOIFHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool IJPFPFEHOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool DGCLGGMOFJO;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BED290", Offset = "0x7BEBE90", VA = "0x187BED290")]
	[UnityEngine.Scripting.Preserve]
	public OLLMEIICGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC490", Offset = "0x7BEB090", VA = "0x187BEC490", Slot = "4")]
	public void BMFEAEPHKJH(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BED0A0", Offset = "0x7BEBCA0", VA = "0x187BED0A0")]
	private void LCEBJIBJCKM(Scene CAGIALKBKBO, LoadSceneMode JCDBMHAMDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BECD30", Offset = "0x7BEB930", VA = "0x187BECD30")]
	private void KAMLNABNCDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7BECC50", Offset = "0x7BEB850", VA = "0x187BECC50")]
	private void JOJCOHHIPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BECEE0", Offset = "0x7BEBAE0", VA = "0x187BECEE0")]
	private (ReflectionProbe, int) KBOGDFFLBFG()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BED190", Offset = "0x7BEBD90", VA = "0x187BED190")]
	[IteratorStateMachine(typeof(BPJNGCBIGBH))]
	private IEnumerator<LNKBBFODFEI> PLLHKJMPHBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BED0B0", Offset = "0x7BEBCB0", VA = "0x187BED0B0")]
	private void MOOBBNCDGLF([CanBeNull] ReflectionProbe HPHKAKGLNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC6F0", Offset = "0x7BEB2F0", VA = "0x187BEC6F0")]
	private void JGJNPLJLBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC440", Offset = "0x7BEB040", VA = "0x187BEC440")]
	private void ALPLDNCCFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC610", Offset = "0x7BEB210", VA = "0x187BEC610", Slot = "5")]
	public void GMJHFFLJMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC720", Offset = "0x7BEB320", VA = "0x187BEC720")]
	[CompilerGenerated]
	private void JOHKHPGOCMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ILDDOAJNCKK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? IGAGKEOACKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MPMEEFDBKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIIIKHINCGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HJJDIGOCCHD : ILDDOAJNCKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string ADCDJODHAFC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string LILEBJLOOPK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string OIEMLDGHPAL;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string PKCNPNPPPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CMLMNIGHOGD CAPMHNMDOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? AEDPGOBNOJP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? IGAGKEOACKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool MPMEEFDBKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x95D150", Offset = "0x95BD50", VA = "0x18095D150", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x95CF00", Offset = "0x95BB00", VA = "0x18095CF00")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	[UnityEngine.Scripting.Preserve]
	public HJJDIGOCCHD([NotNull][GJMNBPKNJPO(null)] CMLMNIGHOGD JMOHGPBLMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB860", Offset = "0x7BEA460", VA = "0x187BEB860", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC100", Offset = "0x7BEAD00", VA = "0x187BEC100")]
	[DMDJPIBKEJJ.OPKFCOALFMB.IBOCCFBJPBC]
	[UsedImplicitly]
	public static void LDEEKAFMEEA(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBF20", Offset = "0x7BEAB20", VA = "0x187BEBF20", Slot = "5")]
	public void EIIIKHINCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB960", Offset = "0x7BEA560", VA = "0x187BEB960")]
	private void EEDDFKGEPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC020", Offset = "0x7BEAC20", VA = "0x187BEC020")]
	private bool IAMAJFEOFPK(string EPGBBIPFBPJ, [Out] NOPIMODEOFI KOMIFLPOMPL)
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
