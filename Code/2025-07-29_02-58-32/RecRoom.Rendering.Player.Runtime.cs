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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8B42CB0", Offset = "0x8B416B0", VA = "0x188B42CB0", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
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
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84C6920", Offset = "0x84C5320", VA = "0x1884C6920", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B44450", Offset = "0x8B42E50", VA = "0x188B44450")]
		private void JKAPILFGJLE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B448D0", Offset = "0x8B432D0", VA = "0x188B448D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B446A0", Offset = "0x8B430A0", VA = "0x188B446A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B44930", Offset = "0x8B43330", VA = "0x188B44930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MMHLMPKLKIC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int? HPPPEFKGJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool? HIEENMPEIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GHBGGEMMFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGLFLECHMJN();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OECDBJCKLEO : MMHLMPKLKIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly string KIEIEAPKHDP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly string OFJENBFHDOD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly string JIILKOPBMPA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly string ABCCIAOPFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private OADOONOPPPN FAANHDGJJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int? PFJDFDAIKMP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int? HPPPEFKGJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GHBGGEMMFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool? HIEENMPEIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B438C0", Offset = "0x8B422C0", VA = "0x188B438C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	[UnityEngine.Scripting.Preserve]
	public OECDBJCKLEO([LNLOHEINMEO(null)][NotNull] OADOONOPPPN LJLGJHJNHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8B436E0", Offset = "0x8B420E0", VA = "0x188B436E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8B43910", Offset = "0x8B42310", VA = "0x188B43910")]
	[PPMDKOHJEBA.MBAKIOAAHOM.JHIOBJALHKC]
	[UsedImplicitly]
	public static void HLBBCJFEAHO(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8B43980", Offset = "0x8B42380", VA = "0x188B43980", Slot = "5")]
	public void IGLFLECHMJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8B43A80", Offset = "0x8B42480", VA = "0x188B43A80")]
	private void PJKAPAGJAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8B437E0", Offset = "0x8B421E0", VA = "0x188B437E0")]
	private bool EIBMMELJGNC(string CKGJCKDJMNF, [Out] CDCEEIHLBMN AHDKCKKOEAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FPHLEODIBNF
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOPEBPGBODI();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MBEKDAOEEFB : FPHLEODIBNF
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ECMGDEADFNM : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BHOPOIJKEJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public MBEKDAOEEFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public ECMGDEADFNM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B42B70", Offset = "0x8B41570", VA = "0x188B42B70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8B42C60", Offset = "0x8B41660", VA = "0x188B42C60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private NNFEFJFFOPD AAIOHNLDHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int PLJGBFGGILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool? IEGEJBMIFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool CCLNBFAHEPE;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static MEBJEIOEDLD DADGPCINNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<string> MNAFFGNMEMD;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8B435C0", Offset = "0x8B41FC0", VA = "0x188B435C0")]
	[UnityEngine.Scripting.Preserve]
	public MBEKDAOEEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8B42DC0", Offset = "0x8B417C0", VA = "0x188B42DC0")]
	private NNFEFJFFOPD FJGKBKFCOKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8B430C0", Offset = "0x8B41AC0", VA = "0x188B430C0")]
	[IteratorStateMachine(typeof(ECMGDEADFNM))]
	private IEnumerator<BHOPOIJKEJE> MENPHILMPLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8B43140", Offset = "0x8B41B40", VA = "0x188B43140")]
	private void NDBPKEOHJJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8B42ED0", Offset = "0x8B418D0", VA = "0x188B42ED0")]
	[PPMDKOHJEBA.KMGFFEOOKKA]
	public static void HLBBCJFEAHO(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8B42F40", Offset = "0x8B41940", VA = "0x188B42F40", Slot = "4")]
	public void JOPEBPGBODI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(CEKLMLEMDGI), new string[] { })]
public class CEKLMLEMDGI : KDEKANPNNED, NAGAKFIOPNO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class OLKLGIAPJLM : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BHOPOIJKEJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CEKLMLEMDGI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public OLKLGIAPJLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B441E0", Offset = "0x8B42BE0", VA = "0x188B441E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B44400", Offset = "0x8B42E00", VA = "0x188B44400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private MMHLMPKLKIC AJEHFLLCBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private JPFNCIEFDND AKPPCLEGEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IDisposable PPPAFHHHIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private IDisposable LDDMFMKAMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HashSet<ReflectionProbe> NGEELCEPDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool NHECAAGOOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private bool HCDOLJHHIED;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8B42AE0", Offset = "0x8B414E0", VA = "0x188B42AE0")]
	[UnityEngine.Scripting.Preserve]
	public CEKLMLEMDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8B427C0", Offset = "0x8B411C0", VA = "0x188B427C0", Slot = "4")]
	public void InitExternal(JFKAHIBHGGP INBLNPFFLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8B424C0", Offset = "0x8B40EC0", VA = "0x188B424C0")]
	private void FGMOEHOEPFA(Scene MDDPGPIJBCC, LoadSceneMode KMDCDIFFCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8B421B0", Offset = "0x8B40BB0", VA = "0x188B421B0")]
	private void DKNALBEHJGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8B42360", Offset = "0x8B40D60", VA = "0x188B42360")]
	private void EGMADKFFBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8B42600", Offset = "0x8B41000", VA = "0x188B42600")]
	private (ReflectionProbe, int) HDADDLNNPMP()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8B42440", Offset = "0x8B40E40", VA = "0x188B42440")]
	[IteratorStateMachine(typeof(OLKLGIAPJLM))]
	private IEnumerator<BHOPOIJKEJE> EMBBHACPMJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8B424D0", Offset = "0x8B40ED0", VA = "0x188B424D0")]
	private void GNCBBMACDNP([CanBeNull] ReflectionProbe IIFHLFBNOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8B42940", Offset = "0x8B41340", VA = "0x188B42940")]
	private void KFGOAOGDFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8B425B0", Offset = "0x8B40FB0", VA = "0x188B425B0")]
	private void HCGHODGDPGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8B42970", Offset = "0x8B41370", VA = "0x188B42970", Slot = "5")]
	public void NOAMAPCJEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8B41D10", Offset = "0x8B40710", VA = "0x188B41D10")]
	[CompilerGenerated]
	private void DGDCDAFPMCE()
	{
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
