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
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85D3850", Offset = "0x85D2450", VA = "0x1885D3850", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F81230", Offset = "0x7F7FE30", VA = "0x187F81230", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85D3960", Offset = "0x85D2560", VA = "0x1885D3960")]
		private void HNLBFOBJPNI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85D3DE0", Offset = "0x85D29E0", VA = "0x1885D3DE0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85D3BB0", Offset = "0x85D27B0", VA = "0x1885D3BB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85D3E40", Offset = "0x85D2A40", VA = "0x1885D3E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GABNGPODIOF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int? PPKNEJGHMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool? NFMLANCBEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MGLEDPCOOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHHPDNCNLBF();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EFPAELMOHDH : GABNGPODIOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly string OINEIICKPPG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly string EDNAMGOCPAK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly string NHFMHCAHFLE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly string ODFBNGGLKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private AHEAEJOKBNI DOGHCCBNJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int? DFOKGFHCIIN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int? PPKNEJGHMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MGLEDPCOOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA247B0", Offset = "0xA233B0", VA = "0x180A247B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA24660", Offset = "0xA23260", VA = "0x180A24660")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool? NFMLANCBEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85D15A0", Offset = "0x85D01A0", VA = "0x1885D15A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	[UnityEngine.Scripting.Preserve]
	public EFPAELMOHDH([GFNPNOLPMKK(null)][NotNull] AHEAEJOKBNI BKHLAMDGECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85D1350", Offset = "0x85CFF50", VA = "0x1885D1350", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85D1530", Offset = "0x85D0130", VA = "0x1885D1530")]
	[IGNGJLOKDFM.CHOHDINDLHJ.JBEAKNHCNNG]
	[UsedImplicitly]
	public static void HGAGPACKHHM(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x85D1250", Offset = "0x85CFE50", VA = "0x1885D1250", Slot = "5")]
	public void BHHPDNCNLBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85D15F0", Offset = "0x85D01F0", VA = "0x1885D15F0")]
	private void MNJDPOGCPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85D1450", Offset = "0x85D0050", VA = "0x1885D1450")]
	private bool FKAMCBFDKFN(string KKJNDJCGJHB, [Out] GOGBMJLGOJH LBAEDLPLBDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BGIFOGHCKOL
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHCMPDMLKFE();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IGMIBOKCPGI : BGIFOGHCKOL
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KCECACJJCCM : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public IGMIBOKCPGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public KCECACJJCCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85D2630", Offset = "0x85D1230", VA = "0x1885D2630", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85D2720", Offset = "0x85D1320", VA = "0x1885D2720", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private GCBFJNEKOIO KDNJNAIKHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int EINGNPGAILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool? GFBIIBFMFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool CCMCLFGMMIO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static JPIBGNDAFKP CCELOHCJCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<string> GBGHKOLOFEB;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85D2510", Offset = "0x85D1110", VA = "0x1885D2510")]
	[UnityEngine.Scripting.Preserve]
	public IGMIBOKCPGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85D1DA0", Offset = "0x85D09A0", VA = "0x1885D1DA0")]
	private GCBFJNEKOIO COEBOBFIIMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x85D1D20", Offset = "0x85D0920", VA = "0x1885D1D20")]
	[IteratorStateMachine(typeof(KCECACJJCCM))]
	private IEnumerator<FCPCPCAPDCM> BHJPCPCFBJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85D20A0", Offset = "0x85D0CA0", VA = "0x1885D20A0")]
	private void OJEALOBPHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85D1EB0", Offset = "0x85D0AB0", VA = "0x1885D1EB0")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	public static void HGAGPACKHHM(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85D1F20", Offset = "0x85D0B20", VA = "0x1885D1F20", Slot = "4")]
	public void IHCMPDMLKFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(KKEHCHIOJFB), new string[] { })]
public class KKEHCHIOJFB : LAMCDMNANDN, IDOBMNBOACG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KLGPMAACBOA : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public KKEHCHIOJFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public KLGPMAACBOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85D35E0", Offset = "0x85D21E0", VA = "0x1885D35E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85D3800", Offset = "0x85D2400", VA = "0x1885D3800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private GABNGPODIOF FMPDGLNAIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private PPDHIJNIFFF AGMMILODPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IDisposable IPFGJPKPFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private IDisposable BFCMNPJLIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HashSet<ReflectionProbe> IKCOLMNDFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool HEKPFPBNFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private bool JGBHCDFIMME;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85D3550", Offset = "0x85D2150", VA = "0x1885D3550")]
	[UnityEngine.Scripting.Preserve]
	public KKEHCHIOJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85D3080", Offset = "0x85D1C80", VA = "0x1885D3080", Slot = "4")]
	public void InitExternal(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x85D34C0", Offset = "0x85D20C0", VA = "0x1885D34C0")]
	private void OMJGLDPKIGC(Scene HJNMJIJFLGD, LoadSceneMode POMNCOEIPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x85D2850", Offset = "0x85D1450", VA = "0x1885D2850")]
	private void BIPEBPCJKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85D2770", Offset = "0x85D1370", VA = "0x1885D2770")]
	private void BCELDGMKNND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85D3300", Offset = "0x85D1F00", VA = "0x1885D3300")]
	private (ReflectionProbe, int) NMICIOPAENF()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85D3230", Offset = "0x85D1E30", VA = "0x1885D3230")]
	[IteratorStateMachine(typeof(KLGPMAACBOA))]
	private IEnumerator<FCPCPCAPDCM> LIPFAPEODHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x85D2EC0", Offset = "0x85D1AC0", VA = "0x1885D2EC0")]
	private void DONHFNGLFJN([CanBeNull] ReflectionProbe JOCKLFJNBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85D3200", Offset = "0x85D1E00", VA = "0x1885D3200")]
	private void JJNOEMOADGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x85D32B0", Offset = "0x85D1EB0", VA = "0x1885D32B0")]
	private void NLMKNFDNELH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85D2FA0", Offset = "0x85D1BA0", VA = "0x1885D2FA0", Slot = "5")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x85D2A00", Offset = "0x85D1600", VA = "0x1885D2A00")]
	[CompilerGenerated]
	private void DGANFEHMEME()
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
