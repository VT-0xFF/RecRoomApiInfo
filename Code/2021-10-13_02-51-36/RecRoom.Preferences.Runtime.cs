using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum PPBJAPFMAPG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class LJPFFNAILBD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x40184C0", Offset = "0x40178C0", VA = "0x1840184C0")]
	[HPNPMDPOGDC]
	private static void FLBJHAFIFOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IIGPHECHDIF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GONEBMAOJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GLBAAOBOPDF;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMPNEKPBDJP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LDKNKELDCKH(long GOJLOOHDKMJ, CancellationToken JFJAKEGJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FNFMKIHKDEI(string GKJBEJBOINB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int ICGBCOFBOBF(string GKJBEJBOINB, int LMDIBPBHMLA = 0);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LOKKBCCOKCD(string GKJBEJBOINB, int ELCLILAGMPD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NCONOEPJKID(string GKJBEJBOINB, bool LMDIBPBHMLA = false);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JBCIGCIKEPM(string GKJBEJBOINB, bool ELCLILAGMPD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float FFDENILDPHJ(string GKJBEJBOINB, float LMDIBPBHMLA = 0f);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ONMMFPKHFJJ(string GKJBEJBOINB, float ELCLILAGMPD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	string ICLDDNOLFGE(string GKJBEJBOINB, [Optional] string LMDIBPBHMLA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ICPFMEGLMKF(string GKJBEJBOINB, string ELCLILAGMPD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DateTime BANKBKCCNNL(string GKJBEJBOINB, [Optional] DateTime NNHJILCIFLE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OMCHPBHBIAG(string GKJBEJBOINB, DateTime NNHJILCIFLE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	long IENEOEPOECG(string GKJBEJBOINB, long LMDIBPBHMLA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PHHPDIMFBDD(string GKJBEJBOINB, long ELCLILAGMPD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	T NDIDBHMOPHJ<T>(string GKJBEJBOINB, T LMDIBPBHMLA, global::LHKLPBILILM<T> ELDNKEBNFFE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GEGECDBGPJG<T>(string GKJBEJBOINB, T ELCLILAGMPD, global::LHKLPBILILM<T> ELDNKEBNFFE);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HIEHDDONDMJ(string GKJBEJBOINB);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GKMEBLHIJGP();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KJIFCCBBLOJ : IIGPHECHDIF
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private abstract class PMDFGKFFCHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly HashSet<PMDFGKFFCHM> KMNGFLCEIMB;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4018BC0", Offset = "0x4017FC0", VA = "0x184018BC0")]
		protected PMDFGKFFCHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void OHFILLIGFDC(string IDFIPMLKMCO);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4018A20", Offset = "0x4017E20", VA = "0x184018A20")]
		public static void BFEFMJENBJC(string IDFIPMLKMCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BPFLNFICGHE<T> : PMDFGKFFCHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly BPFLNFICGHE<T> LMLLPIIMPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Dictionary<string, T> GFKEBBCIOFC;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1FE31E0", Offset = "0x1FE25E0", VA = "0x181FE31E0")]
		public bool AJFKIGLDKOK(string PBCBOJHBCHP, out T ODEAGBPHNCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3210", Offset = "0x1FE2610", VA = "0x181FE3210")]
		public void EMMIENMPLBN(string PBCBOJHBCHP, T ELCLILAGMPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x16EF670", Offset = "0x16EEA70", VA = "0x1816EF670", Slot = "4")]
		protected override void OHFILLIGFDC(string PBCBOJHBCHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAD00", Offset = "0x2AFA100", VA = "0x182AFAD00")]
		public BPFLNFICGHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KJEILIFOHFF : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KJIFCCBBLOJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public KJEILIFOHFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4017C20", Offset = "0x4017020", VA = "0x184017C20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4017D10", Offset = "0x4017110", VA = "0x184017D10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool IJKAAFANCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool JOPFMNINLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CAHNHIMGLJM PJBMPJEIGIE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GONEBMAOJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x44EB90", Offset = "0x44DF90", VA = "0x18044EB90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GLBAAOBOPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4018350", Offset = "0x4017750", VA = "0x184018350")]
	[Preserve]
	public KJIFCCBBLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "6")]
	public void AMPNEKPBDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4018200", Offset = "0x4017600", VA = "0x184018200", Slot = "7")]
	public Task LDKNKELDCKH(long GOJLOOHDKMJ, CancellationToken JFJAKEGJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2550D50", Offset = "0x2550150", VA = "0x182550D50")]
	private static int HIKPDDHHGOL(bool ELCLILAGMPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4017EF0", Offset = "0x40172F0", VA = "0x184017EF0", Slot = "9")]
	public bool FNFMKIHKDEI(string GKJBEJBOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4018160", Offset = "0x4017560", VA = "0x184018160", Slot = "10")]
	public int ICGBCOFBOBF(string GKJBEJBOINB, int LMDIBPBHMLA = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4018250", Offset = "0x4017650", VA = "0x184018250", Slot = "11")]
	public void LOKKBCCOKCD(string GKJBEJBOINB, int ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4018260", Offset = "0x4017660", VA = "0x184018260", Slot = "12")]
	public bool NCONOEPJKID(string GKJBEJBOINB, bool LMDIBPBHMLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x40181F0", Offset = "0x40175F0", VA = "0x1840181F0", Slot = "13")]
	public void JBCIGCIKEPM(string GKJBEJBOINB, bool ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4017EE0", Offset = "0x40172E0", VA = "0x184017EE0", Slot = "14")]
	public float FFDENILDPHJ(string GKJBEJBOINB, float LMDIBPBHMLA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x40182E0", Offset = "0x40176E0", VA = "0x1840182E0", Slot = "15")]
	public void ONMMFPKHFJJ(string GKJBEJBOINB, float ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4018170", Offset = "0x4017570", VA = "0x184018170", Slot = "16")]
	public string ICLDDNOLFGE(string GKJBEJBOINB, string LMDIBPBHMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2E64E00", Offset = "0x2E64200", VA = "0x182E64E00", Slot = "17")]
	public void ICPFMEGLMKF(string GKJBEJBOINB, string ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4017D60", Offset = "0x4017160", VA = "0x184017D60", Slot = "18")]
	public DateTime BANKBKCCNNL(string GKJBEJBOINB, [Optional] DateTime LMDIBPBHMLA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4018280", Offset = "0x4017680", VA = "0x184018280", Slot = "19")]
	public void OMCHPBHBIAG(string GKJBEJBOINB, DateTime NNHJILCIFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4018190", Offset = "0x4017590", VA = "0x184018190", Slot = "20")]
	public long IENEOEPOECG(string GKJBEJBOINB, long LMDIBPBHMLA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x40182F0", Offset = "0x40176F0", VA = "0x1840182F0", Slot = "21")]
	public void PHHPDIMFBDD(string GKJBEJBOINB, long ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1629FA0", Offset = "0x16293A0", VA = "0x181629FA0", Slot = "22")]
	public T NDIDBHMOPHJ<T>(string GKJBEJBOINB, T LMDIBPBHMLA, global::LHKLPBILILM<T> ELDNKEBNFFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x17BACA0", Offset = "0x17BA0A0", VA = "0x1817BACA0", Slot = "23")]
	public void GEGECDBGPJG<T>(string GKJBEJBOINB, T ELCLILAGMPD, global::LHKLPBILILM<T> ELDNKEBNFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1635020", Offset = "0x1634420", VA = "0x181635020")]
	private T AEDKHLKNBEA<T>(string GKJBEJBOINB, T LMDIBPBHMLA, [Optional] global::LHKLPBILILM<T> NPOMBHHNMLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x29DB310", Offset = "0x29DA710", VA = "0x1829DB310")]
	private void DBPOHBMOKNL<T>(string GKJBEJBOINB, T ELCLILAGMPD, [Optional] global::LHKLPBILILM<T> NPOMBHHNMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4018100", Offset = "0x4017500", VA = "0x184018100", Slot = "24")]
	public void HIEHDDONDMJ(string GKJBEJBOINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4017F60", Offset = "0x4017360", VA = "0x184017F60", Slot = "25")]
	public void GKMEBLHIJGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4017E80", Offset = "0x4017280", VA = "0x184017E80")]
	[IteratorStateMachine(typeof(KJEILIFOHFF))]
	private IEnumerator<JKJIBOEKIAI> EPNMJKKGIDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4017E20", Offset = "0x4017220", VA = "0x184017E20")]
	private void CNHAELMNLJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4017F00", Offset = "0x4017300", VA = "0x184017F00")]
	private void GDJOILCHIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4017DC0", Offset = "0x40171C0", VA = "0x184017DC0")]
	private void CHGFPEGOFJJ(bool FBCDKOKMNKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BPGEMNECLEI : IIGPHECHDIF
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private abstract class DIFIBHDCGHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly HashSet<DIFIBHDCGHK> KMNGFLCEIMB;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4017BA0", Offset = "0x4016FA0", VA = "0x184017BA0")]
		protected DIFIBHDCGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void HFPHLCGNKJD();

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void OHFILLIGFDC(string IDFIPMLKMCO);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x40178D0", Offset = "0x4016CD0", VA = "0x1840178D0")]
		public static void BFEFMJENBJC(string IDFIPMLKMCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4017A10", Offset = "0x4016E10", VA = "0x184017A10")]
		public static void MKFNEELIEAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private class PJBDDBNOOPJ<T> : DIFIBHDCGHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly PJBDDBNOOPJ<T> LMLLPIIMPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly Dictionary<string, T> GFKEBBCIOFC;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1FE31E0", Offset = "0x1FE25E0", VA = "0x181FE31E0")]
		public bool AJFKIGLDKOK(string PBCBOJHBCHP, out T ODEAGBPHNCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3210", Offset = "0x1FE2610", VA = "0x181FE3210")]
		public void EMMIENMPLBN(string PBCBOJHBCHP, T ELCLILAGMPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1828EB0", Offset = "0x18282B0", VA = "0x181828EB0", Slot = "4")]
		protected override void HFPHLCGNKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x16EF7C0", Offset = "0x16EEBC0", VA = "0x1816EF7C0", Slot = "5")]
		protected override void OHFILLIGFDC(string PBCBOJHBCHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2EFEBC0", Offset = "0x2EFDFC0", VA = "0x182EFEBC0")]
		public PJBDDBNOOPJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Dictionary<string, string> NMOJKOJIJFA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GONEBMAOJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x44EB90", Offset = "0x44DF90", VA = "0x18044EB90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private string BMLHOIGDPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4014040", Offset = "0x4013440", VA = "0x184014040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Dictionary<string, string> EHNEADOEDKD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4014B10", Offset = "0x4013F10", VA = "0x184014B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GLBAAOBOPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
	[Preserve]
	public BPGEMNECLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "6")]
	public void AMPNEKPBDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x40148C0", Offset = "0x4013CC0", VA = "0x1840148C0", Slot = "7")]
	public Task LDKNKELDCKH(long GOJLOOHDKMJ, CancellationToken JFJAKEGJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4014370", Offset = "0x4013770", VA = "0x184014370", Slot = "14")]
	public float FFDENILDPHJ(string IDFIPMLKMCO, float LMDIBPBHMLA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4014850", Offset = "0x4013C50", VA = "0x184014850", Slot = "13")]
	public void JBCIGCIKEPM(string IDFIPMLKMCO, bool ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4014970", Offset = "0x4013D70", VA = "0x184014970", Slot = "12")]
	public bool NCONOEPJKID(string IDFIPMLKMCO, bool LMDIBPBHMLA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4014680", Offset = "0x4013A80", VA = "0x184014680", Slot = "10")]
	public int ICGBCOFBOBF(string IDFIPMLKMCO, int LMDIBPBHMLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x40140A0", Offset = "0x40134A0", VA = "0x1840140A0", Slot = "18")]
	public DateTime BANKBKCCNNL(string GKJBEJBOINB, [Optional] DateTime LMDIBPBHMLA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4014A50", Offset = "0x4013E50", VA = "0x184014A50", Slot = "19")]
	public void OMCHPBHBIAG(string IDFIPMLKMCO, DateTime ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4014AB0", Offset = "0x4013EB0", VA = "0x184014AB0", Slot = "15")]
	public void ONMMFPKHFJJ(string IDFIPMLKMCO, float ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4014910", Offset = "0x4013D10", VA = "0x184014910", Slot = "11")]
	public void LOKKBCCOKCD(string IDFIPMLKMCO, int ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x40147F0", Offset = "0x4013BF0", VA = "0x1840147F0", Slot = "20")]
	public long IENEOEPOECG(string GKJBEJBOINB, long LMDIBPBHMLA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4014B40", Offset = "0x4013F40", VA = "0x184014B40", Slot = "21")]
	public void PHHPDIMFBDD(string GKJBEJBOINB, long ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1629FA0", Offset = "0x16293A0", VA = "0x181629FA0", Slot = "22")]
	public T NDIDBHMOPHJ<T>(string GKJBEJBOINB, T LMDIBPBHMLA, global::LHKLPBILILM<T> ELDNKEBNFFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x17BACA0", Offset = "0x17BA0A0", VA = "0x1817BACA0", Slot = "23")]
	public void GEGECDBGPJG<T>(string GKJBEJBOINB, T ELCLILAGMPD, global::LHKLPBILILM<T> ELDNKEBNFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40146E0", Offset = "0x4013AE0", VA = "0x1840146E0", Slot = "16")]
	public string ICLDDNOLFGE(string IDFIPMLKMCO, string LMDIBPBHMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4014770", Offset = "0x4013B70", VA = "0x184014770", Slot = "17")]
	public void ICPFMEGLMKF(string IDFIPMLKMCO, string ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40145E0", Offset = "0x40139E0", VA = "0x1840145E0", Slot = "24")]
	public void HIEHDDONDMJ(string IDFIPMLKMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40143D0", Offset = "0x40137D0", VA = "0x1840143D0", Slot = "9")]
	public bool FNFMKIHKDEI(string IDFIPMLKMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4014440", Offset = "0x4013840", VA = "0x184014440", Slot = "25")]
	public void GKMEBLHIJGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1629900", Offset = "0x1628D00", VA = "0x181629900")]
	private T JAIEPAMNJOF<T>(string GKJBEJBOINB, T LMDIBPBHMLA, [Optional] global::LHKLPBILILM<T> NPOMBHHNMLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x17BB7F0", Offset = "0x17BABF0", VA = "0x1817BB7F0")]
	private void JFOMDNCKGDL<T>(string GKJBEJBOINB, T ELCLILAGMPD, [Optional] global::LHKLPBILILM<T> NPOMBHHNMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4014100", Offset = "0x4013500", VA = "0x184014100")]
	private Dictionary<string, string> FACNNGMPJND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EMCJLKKLOHF
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action GLBAAOBOPDF;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMPNEKPBDJP();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PJPIOJECCMN(long GOJLOOHDKMJ);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CKFPEJJDPAI(PPBJAPFMAPG HHDJDOELFAN = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LJBHGDCPAKB(string GKJBEJBOINB, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OKNJJANBEGI(string GKJBEJBOINB, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string GAKJPAIMLAC(string GKJBEJBOINB, [Optional] string LMDIBPBHMLA, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LPIOILDJBLC EDDOKDLPLAD(string GKJBEJBOINB, string ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int IHONJOJPNDM(string GKJBEJBOINB, int LMDIBPBHMLA = 0, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LPIOILDJBLC BPJGFOPFGLH(string GKJBEJBOINB, int ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OCPPMDHBBIG(string GKJBEJBOINB, bool LMDIBPBHMLA, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LPIOILDJBLC JGNIMKLGCDK(string GKJBEJBOINB, bool ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float DDOLECDECGI(string GKJBEJBOINB, float LMDIBPBHMLA = 0f, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LPIOILDJBLC ICAGHNEHNHC(string GKJBEJBOINB, float ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime GBGANAGPLJF(string GKJBEJBOINB, [Optional] DateTime LMDIBPBHMLA, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "16")]
	LPIOILDJBLC BMIDHLEAMJP(string GKJBEJBOINB, DateTime ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long GCALAPIDKIA(string GKJBEJBOINB, long LMDIBPBHMLA = 0L, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "18")]
	LPIOILDJBLC APLFMNOBJPL(string GKJBEJBOINB, long ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T JLOKKOJGBNN<T>(string GKJBEJBOINB, [Optional] T LMDIBPBHMLA, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "20")]
	LPIOILDJBLC FNGKNFIHHHJ<T>(string GKJBEJBOINB, T ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool FDAONDHFMCG(string GKJBEJBOINB);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool KODKCLANDLN(string GKJBEJBOINB);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string BJIIMOFPLAA(string GKJBEJBOINB, [Optional] string LMDIBPBHMLA);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	LPIOILDJBLC DGLBHHEHDAJ(string GKJBEJBOINB, string ELCLILAGMPD);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int ENICGNNGLOP(string GKJBEJBOINB, int LMDIBPBHMLA = 0);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	LPIOILDJBLC AFECILPNGCN(string GKJBEJBOINB, int ELCLILAGMPD);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EGPCKAJLGND(string GKJBEJBOINB, bool LMDIBPBHMLA);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	LPIOILDJBLC MBEEGEKAKOK(string GKJBEJBOINB, bool ELCLILAGMPD);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float CJAMPOOGECP(string GKJBEJBOINB, float LMDIBPBHMLA = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "30")]
	LPIOILDJBLC HBIMCDGKCOG(string GKJBEJBOINB, float ELCLILAGMPD);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime GBGPCMKAJKD(string GKJBEJBOINB, [Optional] DateTime LMDIBPBHMLA);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "32")]
	LPIOILDJBLC CKODGEFFFHK(string GKJBEJBOINB, DateTime ELCLILAGMPD);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void KEBGCBBBFHI<T>(global::LHKLPBILILM<T> ELDNKEBNFFE, [Optional] IEqualityComparer<T> NJHNCPECKEE);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void BMCNNHLGEFK<T>();

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable KLBBEOKMLKM();

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void ECGFAJNILBJ(float COFIEAPBBOI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum LPIOILDJBLC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	New,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DFPGNACEPEB : EMCJLKKLOHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private abstract class NJGEJHEOKPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected static readonly HashSet<NJGEJHEOKPM> PAHPIHGKFGO;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4018890", Offset = "0x4017C90", VA = "0x184018890")]
		public static void MKFNEELIEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void HFPHLCGNKJD();

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
		protected NJGEJHEOKPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class KJAFBKJDFLD<T> : NJGEJHEOKPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly KJAFBKJDFLD<T> EELIJCAPGCD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public global::LHKLPBILILM<T> GOMPNPKCDGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x472460", Offset = "0x471860", VA = "0x180472460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IEqualityComparer<T> ONNKBAOEKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x4F88B0", Offset = "0x4F7CB0", VA = "0x1804F88B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool OEGAMPHDJMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x24F1550", Offset = "0x24F0950", VA = "0x1824F1550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C86120", Offset = "0x2C85520", VA = "0x182C86120")]
		private KJAFBKJDFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2C85E90", Offset = "0x2C85290", VA = "0x182C85E90")]
		public void BDOIOANOOFM(global::LHKLPBILILM<T> NPOMBHHNMLJ, [Optional] IEqualityComparer<T> NJHNCPECKEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2C85FD0", Offset = "0x2C853D0", VA = "0x182C85FD0", Slot = "4")]
		public override void HFPHLCGNKJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class LDNFHFEKAJH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly DFPGNACEPEB LPLBEPNPJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly object MFJFEMMHBDO;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4018430", Offset = "0x4017830", VA = "0x184018430")]
		public LDNFHFEKAJH(DFPGNACEPEB LPLBEPNPJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4018400", Offset = "0x4017800", VA = "0x184018400", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct MLKOMNBOGOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public DFPGNACEPEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4018620", Offset = "0x4017A20", VA = "0x184018620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x546760", Offset = "0x545B60", VA = "0x180546760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BJGGGPIKOLN : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public DFPGNACEPEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public BJGGGPIKOLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4013A60", Offset = "0x4012E60", VA = "0x184013A60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4013B30", Offset = "0x4012F30", VA = "0x184013B30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IIGPHECHDIF CDILNHEGHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly IIGPHECHDIF ELNJBIBBCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HJINJKDFNGN AHIEBHKBOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HashSet<IIGPHECHDIF> FMGDLJIJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Task MFDNMKKJHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private CAHNHIMGLJM KLIGKNGOPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly object KHODOPPCCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly object FBDKCAGIJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private long GPPMFIAMPLI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool ACEEAOIGBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6543A0", Offset = "0x6537A0", VA = "0x1806543A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private CancellationTokenSource MKGBBNILLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x48E130", Offset = "0x48D530", VA = "0x18048E130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x48DA90", Offset = "0x48CE90", VA = "0x18048DA90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action GLBAAOBOPDF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4014EB0", Offset = "0x40142B0", VA = "0x184014EB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4016850", Offset = "0x4015C50", VA = "0x184016850", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4016670", Offset = "0x4015A70", VA = "0x184016670")]
	[HPNPMDPOGDC]
	private static void IOIOGKCPKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4017760", Offset = "0x4016B60", VA = "0x184017760")]
	[Preserve]
	public DFPGNACEPEB([CDNHFEFPFMM("Disk")] IIGPHECHDIF CDILNHEGHPH, [CDNHFEFPFMM("Cloud")] IIGPHECHDIF ELNJBIBBCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x40158E0", Offset = "0x4014CE0", VA = "0x1840158E0", Slot = "41")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x40170D0", Offset = "0x40164D0", VA = "0x1840170D0")]
	private void MJOHCIKDGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4014BD0", Offset = "0x4013FD0", VA = "0x184014BD0", Slot = "6")]
	public void AMPNEKPBDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4017380", Offset = "0x4016780", VA = "0x184017380", Slot = "7")]
	public Task PJPIOJECCMN(long GOJLOOHDKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4014F50", Offset = "0x4014350", VA = "0x184014F50")]
	[AsyncStateMachine(typeof(MLKOMNBOGOA))]
	private Task BHFELFDPGAN(long GOJLOOHDKMJ, CancellationToken JFJAKEGJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6543F0", Offset = "0x6537F0", VA = "0x1806543F0")]
	private void PBGDAHOCJAG(object FCBCFMOCHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4014E30", Offset = "0x4014230", VA = "0x184014E30")]
	private void BEJCCDKDEBC(object FCBCFMOCHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4015BE0", Offset = "0x4014FE0", VA = "0x184015BE0")]
	private string FJOGAAKOFLB(string CBCAIEENAEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4016A00", Offset = "0x4015E00", VA = "0x184016A00")]
	private void KKHNAJCPPHG(PPBJAPFMAPG HHDJDOELFAN, string IDFIPMLKMCO, out IIGPHECHDIF DCOHPFGALBE, out string OKHGMODGDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4017040", Offset = "0x4016440", VA = "0x184017040")]
	private IIGPHECHDIF MIOPIONLJHE(PPBJAPFMAPG HHDJDOELFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4015490", Offset = "0x4014890", VA = "0x184015490", Slot = "8")]
	public bool CKFPEJJDPAI(PPBJAPFMAPG HHDJDOELFAN = PPBJAPFMAPG.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4016D20", Offset = "0x4016120", VA = "0x184016D20", Slot = "9")]
	public bool LJBHGDCPAKB(string GKJBEJBOINB, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4017290", Offset = "0x4016690", VA = "0x184017290", Slot = "10")]
	public bool OKNJJANBEGI(string GKJBEJBOINB, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4015DA0", Offset = "0x40151A0", VA = "0x184015DA0", Slot = "11")]
	public string GAKJPAIMLAC(string GKJBEJBOINB, [Optional] string LMDIBPBHMLA, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4015940", Offset = "0x4014D40", VA = "0x184015940", Slot = "12")]
	public LPIOILDJBLC EDDOKDLPLAD(string GKJBEJBOINB, string ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4016540", Offset = "0x4015940", VA = "0x184016540", Slot = "13")]
	public int IHONJOJPNDM(string GKJBEJBOINB, int LMDIBPBHMLA = 0, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x40151C0", Offset = "0x40145C0", VA = "0x1840151C0", Slot = "14")]
	public LPIOILDJBLC BPJGFOPFGLH(string GKJBEJBOINB, int ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4017160", Offset = "0x4016560", VA = "0x184017160", Slot = "15")]
	public bool OCPPMDHBBIG(string GKJBEJBOINB, bool LMDIBPBHMLA, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4016740", Offset = "0x4015B40", VA = "0x184016740", Slot = "16")]
	public LPIOILDJBLC JGNIMKLGCDK(string GKJBEJBOINB, bool ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x40155E0", Offset = "0x40149E0", VA = "0x1840155E0", Slot = "17")]
	public float DDOLECDECGI(string GKJBEJBOINB, float LMDIBPBHMLA = 0f, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x40163D0", Offset = "0x40157D0", VA = "0x1840163D0", Slot = "18")]
	public LPIOILDJBLC ICAGHNEHNHC(string GKJBEJBOINB, float ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4015ED0", Offset = "0x40152D0", VA = "0x184015ED0", Slot = "19")]
	public DateTime GBGANAGPLJF(string GKJBEJBOINB, [Optional] DateTime LMDIBPBHMLA, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x40150C0", Offset = "0x40144C0", VA = "0x1840150C0", Slot = "20")]
	public LPIOILDJBLC BMIDHLEAMJP(string GKJBEJBOINB, DateTime ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4016070", Offset = "0x4015470", VA = "0x184016070", Slot = "21")]
	public long GCALAPIDKIA(string GKJBEJBOINB, long LMDIBPBHMLA = 0L, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4014C40", Offset = "0x4014040", VA = "0x184014C40", Slot = "22")]
	public LPIOILDJBLC APLFMNOBJPL(string GKJBEJBOINB, long ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x162B170", Offset = "0x162A570", VA = "0x18162B170", Slot = "23")]
	public T JLOKKOJGBNN<T>(string GKJBEJBOINB, [Optional] T LMDIBPBHMLA, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x15358E0", Offset = "0x1534CE0", VA = "0x1815358E0", Slot = "24")]
	public LPIOILDJBLC FNGKNFIHHHJ<T>(string GKJBEJBOINB, T ELCLILAGMPD, PPBJAPFMAPG CFEHLLLBBLI = PPBJAPFMAPG.CLOUD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4015B80", Offset = "0x4014F80", VA = "0x184015B80", Slot = "25")]
	public bool FDAONDHFMCG(string GKJBEJBOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4016BC0", Offset = "0x4015FC0", VA = "0x184016BC0", Slot = "26")]
	public bool KODKCLANDLN(string GKJBEJBOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4015050", Offset = "0x4014450", VA = "0x184015050", Slot = "27")]
	public string BJIIMOFPLAA(string GKJBEJBOINB, [Optional] string LMDIBPBHMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4015710", Offset = "0x4014B10", VA = "0x184015710", Slot = "28")]
	public LPIOILDJBLC DGLBHHEHDAJ(string GKJBEJBOINB, string ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4015B10", Offset = "0x4014F10", VA = "0x184015B10", Slot = "29")]
	public int ENICGNNGLOP(string GKJBEJBOINB, int LMDIBPBHMLA = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4014BA0", Offset = "0x4013FA0", VA = "0x184014BA0", Slot = "30")]
	public LPIOILDJBLC AFECILPNGCN(string GKJBEJBOINB, int ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4015A40", Offset = "0x4014E40", VA = "0x184015A40", Slot = "31")]
	public bool EGPCKAJLGND(string GKJBEJBOINB, bool LMDIBPBHMLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4016E40", Offset = "0x4016240", VA = "0x184016E40", Slot = "32")]
	public LPIOILDJBLC MBEEGEKAKOK(string GKJBEJBOINB, bool ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4015420", Offset = "0x4014820", VA = "0x184015420", Slot = "33")]
	public float CJAMPOOGECP(string GKJBEJBOINB, float LMDIBPBHMLA = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x40163A0", Offset = "0x40157A0", VA = "0x1840163A0", Slot = "34")]
	public LPIOILDJBLC HBIMCDGKCOG(string GKJBEJBOINB, float ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4016000", Offset = "0x4015400", VA = "0x184016000", Slot = "35")]
	public DateTime GBGPCMKAJKD(string GKJBEJBOINB, [Optional] DateTime LMDIBPBHMLA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x40155B0", Offset = "0x40149B0", VA = "0x1840155B0", Slot = "36")]
	public LPIOILDJBLC CKODGEFFFHK(string GKJBEJBOINB, DateTime ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4015AB0", Offset = "0x4014EB0", VA = "0x184015AB0")]
	private bool ENFGENAOOFG(IIGPHECHDIF DCOHPFGALBE, string GKJBEJBOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x40168F0", Offset = "0x4015CF0", VA = "0x1840168F0")]
	private bool KFMDGDIJOOA(IIGPHECHDIF DCOHPFGALBE, string GKJBEJBOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4016260", Offset = "0x4015660", VA = "0x184016260")]
	private LPIOILDJBLC GOIOOIFFILJ(IIGPHECHDIF DCOHPFGALBE, string GKJBEJBOINB, string ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4017500", Offset = "0x4016900", VA = "0x184017500")]
	private LPIOILDJBLC PLAIADNHPJL(IIGPHECHDIF DCOHPFGALBE, string GKJBEJBOINB, int ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4015C50", Offset = "0x4015050", VA = "0x184015C50")]
	private LPIOILDJBLC GAEDOLINGHO(IIGPHECHDIF DCOHPFGALBE, string GKJBEJBOINB, bool ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4016BD0", Offset = "0x4015FD0", VA = "0x184016BD0")]
	private LPIOILDJBLC LBFDEJCIOMA(IIGPHECHDIF DCOHPFGALBE, string GKJBEJBOINB, float ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x40152C0", Offset = "0x40146C0", VA = "0x1840152C0")]
	private LPIOILDJBLC CDMAOFPFMOO(IIGPHECHDIF DCOHPFGALBE, string GKJBEJBOINB, DateTime ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4017630", Offset = "0x4016A30", VA = "0x184017630")]
	private LPIOILDJBLC PLJPJFHPEIK(IIGPHECHDIF DCOHPFGALBE, string GKJBEJBOINB, long ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x162AF00", Offset = "0x162A300", VA = "0x18162AF00")]
	private T CNACAEKOCAF<T>(IIGPHECHDIF DCOHPFGALBE, string GKJBEJBOINB, T LMDIBPBHMLA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1535D40", Offset = "0x1535140", VA = "0x181535D40")]
	private LPIOILDJBLC IABPKIGCPGP<T>(IIGPHECHDIF DCOHPFGALBE, string GKJBEJBOINB, T ELCLILAGMPD)
	{
		return default(LPIOILDJBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x17BCF30", Offset = "0x17BC330", VA = "0x1817BCF30", Slot = "37")]
	public void KEBGCBBBFHI<T>(global::LHKLPBILILM<T> ELDNKEBNFFE, [Optional] IEqualityComparer<T> NJHNCPECKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x17BCE70", Offset = "0x17BC270", VA = "0x1817BCE70", Slot = "38")]
	public void BMCNNHLGEFK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x40161D0", Offset = "0x40155D0", VA = "0x1840161D0")]
	private void GKMEBLHIJGP(IIGPHECHDIF BNMKGOJKFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4015740", Offset = "0x4014B40", VA = "0x184015740")]
	private void DLPJAMIANDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4016B00", Offset = "0x4015F00", VA = "0x184016B00", Slot = "39")]
	public IDisposable KLBBEOKMLKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4015930", Offset = "0x4014D30", VA = "0x184015930", Slot = "40")]
	public void ECGFAJNILBJ(float COFIEAPBBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4016E70", Offset = "0x4016270", VA = "0x184016E70")]
	private void MEKNBIJMIMO(float IIKGFFDNKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x40164D0", Offset = "0x40158D0", VA = "0x1840164D0")]
	[IteratorStateMachine(typeof(BJGGGPIKOLN))]
	private IEnumerator<JKJIBOEKIAI> ICFPOBMKJHB(float COFIEAPBBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x40161A0", Offset = "0x40155A0", VA = "0x1840161A0")]
	[CompilerGenerated]
	private void GCGLHGNPDNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BMBKKAPALLJ : global::JLPENOCEMEB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static BMBKKAPALLJ EELIJCAPGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4013C60", Offset = "0x4013060", VA = "0x184013C60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4013B80", Offset = "0x4012F80", VA = "0x184013B80", Slot = "8")]
	public override string FPDOAEHEJEP(bool KDFNADLFBCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4013CC0", Offset = "0x40130C0", VA = "0x184013CC0", Slot = "9")]
	protected override bool NBGDKGANNDI(string KDFNADLFBCD, out bool ELCLILAGMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4014000", Offset = "0x4013400", VA = "0x184014000")]
	public BMBKKAPALLJ()
	{
	}
}
namespace Cpp2IlInjected;

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
