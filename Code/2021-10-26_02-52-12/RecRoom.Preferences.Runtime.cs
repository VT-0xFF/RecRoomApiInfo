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
public enum INKKOCLDLIA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class LFJCPPJLIBB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4094100", Offset = "0x4093300", VA = "0x184094100")]
	[CNCOEENPANM]
	private static void GGNNOFLPBFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BNKACNIHEHM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GBGNMJCIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AOFBMPDJMJN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEMJBKBNLDJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HAFBLDHPJLK(long LNPCMNGBLIP, CancellationToken HBBKODCJALO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LLJMJGIFBGD(string GIEKPGOGCIP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PFAEHFLJPKM(string GIEKPGOGCIP, int MBFIEIOCHIJ = 0);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GNBGOLOBEMD(string GIEKPGOGCIP, int DIDEMEECIEC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KCGFJOMNDDG(string GIEKPGOGCIP, bool MBFIEIOCHIJ = false);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PNNNDDPEPNK(string GIEKPGOGCIP, bool DIDEMEECIEC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float LFCAIABPJFJ(string GIEKPGOGCIP, float MBFIEIOCHIJ = 0f);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EEONKKJNCLL(string GIEKPGOGCIP, float DIDEMEECIEC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	string BFNOBAIJLHC(string GIEKPGOGCIP, [Optional] string MBFIEIOCHIJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AOEBCKPCNFK(string GIEKPGOGCIP, string DIDEMEECIEC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DateTime JBKMBMGFFGF(string GIEKPGOGCIP, [Optional] DateTime ECACLKFPEOL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FDLGCCPLBCE(string GIEKPGOGCIP, DateTime ECACLKFPEOL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	long JDHMEMDFOMC(string GIEKPGOGCIP, long MBFIEIOCHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PILPJMEBEMM(string GIEKPGOGCIP, long DIDEMEECIEC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	T KAHIEHFEBFM<T>(string GIEKPGOGCIP, T MBFIEIOCHIJ, global::CLAIBMPFHJC<T> IDNLJKKILBB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DBCONGMMBHA<T>(string GIEKPGOGCIP, T DIDEMEECIEC, global::CLAIBMPFHJC<T> IDNLJKKILBB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DDHFNMJEBHA(string GIEKPGOGCIP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LMGMBHADFBO();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ILPHDGEHFDF : BNKACNIHEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private abstract class JLOPCKJJFEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly HashSet<JLOPCKJJFEM> DIJDNPHMEPA;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4094080", Offset = "0x4093280", VA = "0x184094080")]
		protected JLOPCKJJFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void DIMPNLHMANN(string KPLFFOGJEBN);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4093EE0", Offset = "0x40930E0", VA = "0x184093EE0")]
		public static void AELGFEDJCLP(string KPLFFOGJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GDJNOPADOJF<T> : JLOPCKJJFEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly GDJNOPADOJF<T> DCKAENMPEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Dictionary<string, T> JGNBOOBHEHN;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x23354B0", Offset = "0x23346B0", VA = "0x1823354B0")]
		public bool KLBAJGAHLAH(string BCKHJDJHJEK, out T JDEKHHPOHGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x23354E0", Offset = "0x23346E0", VA = "0x1823354E0")]
		public void LKMOKJMOENA(string BCKHJDJHJEK, T DIDEMEECIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2198450", Offset = "0x2197650", VA = "0x182198450", Slot = "4")]
		protected override void DIMPNLHMANN(string BCKHJDJHJEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x36ADD00", Offset = "0x36ACF00", VA = "0x1836ADD00")]
		public GDJNOPADOJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OCGHOJBAPJG : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public ILPHDGEHFDF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public OCGHOJBAPJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4094260", Offset = "0x4093460", VA = "0x184094260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4094350", Offset = "0x4093550", VA = "0x184094350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool HENHIICBEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool EFBAMCDHFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private INJGDFDPILJ ELMKDLFMBBF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GBGNMJCIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x449F60", Offset = "0x449160", VA = "0x180449F60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AOFBMPDJMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4093E30", Offset = "0x4093030", VA = "0x184093E30")]
	[Preserve]
	public ILPHDGEHFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "6")]
	public void HEMJBKBNLDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4093A60", Offset = "0x4092C60", VA = "0x184093A60", Slot = "7")]
	public Task HAFBLDHPJLK(long LNPCMNGBLIP, CancellationToken HBBKODCJALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C30310", Offset = "0x2C2F510", VA = "0x182C30310")]
	private static int EAMGDEKLHAE(bool DIDEMEECIEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4093C00", Offset = "0x4092E00", VA = "0x184093C00", Slot = "9")]
	public bool LLJMJGIFBGD(string GIEKPGOGCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4093DB0", Offset = "0x4092FB0", VA = "0x184093DB0", Slot = "10")]
	public int PFAEHFLJPKM(string GIEKPGOGCIP, int MBFIEIOCHIJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4093A50", Offset = "0x4092C50", VA = "0x184093A50", Slot = "11")]
	public void GNBGOLOBEMD(string GIEKPGOGCIP, int DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4093BD0", Offset = "0x4092DD0", VA = "0x184093BD0", Slot = "12")]
	public bool KCGFJOMNDDG(string GIEKPGOGCIP, bool MBFIEIOCHIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4093E20", Offset = "0x4093020", VA = "0x184093E20", Slot = "13")]
	public void PNNNDDPEPNK(string GIEKPGOGCIP, bool DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4093BF0", Offset = "0x4092DF0", VA = "0x184093BF0", Slot = "14")]
	public float LFCAIABPJFJ(string GIEKPGOGCIP, float MBFIEIOCHIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x40939E0", Offset = "0x4092BE0", VA = "0x1840939E0", Slot = "15")]
	public void EEONKKJNCLL(string GIEKPGOGCIP, float DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4093840", Offset = "0x4092A40", VA = "0x184093840", Slot = "16")]
	public string BFNOBAIJLHC(string GIEKPGOGCIP, string MBFIEIOCHIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xA2DE20", Offset = "0xA2D020", VA = "0x180A2DE20", Slot = "17")]
	public void AOEBCKPCNFK(string GIEKPGOGCIP, string DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4093B10", Offset = "0x4092D10", VA = "0x184093B10", Slot = "18")]
	public DateTime JBKMBMGFFGF(string GIEKPGOGCIP, [Optional] DateTime MBFIEIOCHIJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x40939F0", Offset = "0x4092BF0", VA = "0x1840939F0", Slot = "19")]
	public void FDLGCCPLBCE(string GIEKPGOGCIP, DateTime ECACLKFPEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4093B70", Offset = "0x4092D70", VA = "0x184093B70", Slot = "20")]
	public long JDHMEMDFOMC(string GIEKPGOGCIP, long MBFIEIOCHIJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4093DC0", Offset = "0x4092FC0", VA = "0x184093DC0", Slot = "21")]
	public void PILPJMEBEMM(string GIEKPGOGCIP, long DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2296270", Offset = "0x2295470", VA = "0x182296270", Slot = "22")]
	public T KAHIEHFEBFM<T>(string GIEKPGOGCIP, T MBFIEIOCHIJ, global::CLAIBMPFHJC<T> IDNLJKKILBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2106EA0", Offset = "0x21060A0", VA = "0x182106EA0", Slot = "23")]
	public void DBCONGMMBHA<T>(string GIEKPGOGCIP, T DIDEMEECIEC, global::CLAIBMPFHJC<T> IDNLJKKILBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x229D760", Offset = "0x229C960", VA = "0x18229D760")]
	private T ICBNPPPOHHM<T>(string GIEKPGOGCIP, T MBFIEIOCHIJ, [Optional] global::CLAIBMPFHJC<T> GAIAKEPNKAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2107250", Offset = "0x2106450", VA = "0x182107250")]
	private void FFKJOIIOELH<T>(string GIEKPGOGCIP, T DIDEMEECIEC, [Optional] global::CLAIBMPFHJC<T> GAIAKEPNKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4093980", Offset = "0x4092B80", VA = "0x184093980", Slot = "24")]
	public void DDHFNMJEBHA(string GIEKPGOGCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4093C10", Offset = "0x4092E10", VA = "0x184093C10", Slot = "25")]
	public void LMGMBHADFBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x40938C0", Offset = "0x4092AC0", VA = "0x1840938C0")]
	[IteratorStateMachine(typeof(OCGHOJBAPJG))]
	private IEnumerator<GGOLJFPNLLB> CAAFOKDBEGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4093AB0", Offset = "0x4092CB0", VA = "0x184093AB0")]
	private void HCFIOMAPJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4093860", Offset = "0x4092A60", VA = "0x184093860")]
	private void BIOIBJJDGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4093920", Offset = "0x4092B20", VA = "0x184093920")]
	private void CDGLOLICGCB(bool OMJNAKCMPBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CAGEEIOAEEF : BNKACNIHEHM
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
	private abstract class EDBBLFHPHKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly HashSet<EDBBLFHPHKN> DIJDNPHMEPA;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x40908B0", Offset = "0x408FAB0", VA = "0x1840908B0")]
		protected EDBBLFHPHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void EGONGNAPLEO();

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void DIMPNLHMANN(string KPLFFOGJEBN);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x40905E0", Offset = "0x408F7E0", VA = "0x1840905E0")]
		public static void AELGFEDJCLP(string KPLFFOGJEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4090720", Offset = "0x408F920", VA = "0x184090720")]
		public static void DLPIOOIPHGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private class DPHBAEHGKKO<T> : EDBBLFHPHKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly DPHBAEHGKKO<T> DCKAENMPEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly Dictionary<string, T> JGNBOOBHEHN;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x23354B0", Offset = "0x23346B0", VA = "0x1823354B0")]
		public bool KLBAJGAHLAH(string BCKHJDJHJEK, out T JDEKHHPOHGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x23354E0", Offset = "0x23346E0", VA = "0x1823354E0")]
		public void LKMOKJMOENA(string BCKHJDJHJEK, T DIDEMEECIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x20C8770", Offset = "0x20C7970", VA = "0x1820C8770", Slot = "4")]
		protected override void EGONGNAPLEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2335480", Offset = "0x2334680", VA = "0x182335480", Slot = "5")]
		protected override void DIMPNLHMANN(string BCKHJDJHJEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9DB0", Offset = "0x2CE8FB0", VA = "0x182CE9DB0")]
		public DPHBAEHGKKO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Dictionary<string, string> JFMADAPBOKN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GBGNMJCIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x449F60", Offset = "0x449160", VA = "0x180449F60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private string JFGMKEIAOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4090450", Offset = "0x408F650", VA = "0x184090450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Dictionary<string, string> FDMMDCBHPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4090420", Offset = "0x408F620", VA = "0x184090420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action AOFBMPDJMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
	[Preserve]
	public CAGEEIOAEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "6")]
	public void HEMJBKBNLDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x408FD50", Offset = "0x408EF50", VA = "0x18408FD50", Slot = "7")]
	public Task HAFBLDHPJLK(long LNPCMNGBLIP, CancellationToken HBBKODCJALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x408FF40", Offset = "0x408F140", VA = "0x18408FF40", Slot = "14")]
	public float LFCAIABPJFJ(string KPLFFOGJEBN, float MBFIEIOCHIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4090570", Offset = "0x408F770", VA = "0x184090570", Slot = "13")]
	public void PNNNDDPEPNK(string KPLFFOGJEBN, bool DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x408FE60", Offset = "0x408F060", VA = "0x18408FE60", Slot = "12")]
	public bool KCGFJOMNDDG(string KPLFFOGJEBN, bool MBFIEIOCHIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x40904B0", Offset = "0x408F6B0", VA = "0x1840904B0", Slot = "10")]
	public int PFAEHFLJPKM(string KPLFFOGJEBN, int MBFIEIOCHIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x408FDA0", Offset = "0x408EFA0", VA = "0x18408FDA0", Slot = "18")]
	public DateTime JBKMBMGFFGF(string GIEKPGOGCIP, [Optional] DateTime MBFIEIOCHIJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x408FC90", Offset = "0x408EE90", VA = "0x18408FC90", Slot = "19")]
	public void FDLGCCPLBCE(string KPLFFOGJEBN, DateTime DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x408FC30", Offset = "0x408EE30", VA = "0x18408FC30", Slot = "15")]
	public void EEONKKJNCLL(string KPLFFOGJEBN, float DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x408FCF0", Offset = "0x408EEF0", VA = "0x18408FCF0", Slot = "11")]
	public void GNBGOLOBEMD(string KPLFFOGJEBN, int DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x408FE00", Offset = "0x408F000", VA = "0x18408FE00", Slot = "20")]
	public long JDHMEMDFOMC(string GIEKPGOGCIP, long MBFIEIOCHIJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4090510", Offset = "0x408F710", VA = "0x184090510", Slot = "21")]
	public void PILPJMEBEMM(string GIEKPGOGCIP, long DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2296270", Offset = "0x2295470", VA = "0x182296270", Slot = "22")]
	public T KAHIEHFEBFM<T>(string GIEKPGOGCIP, T MBFIEIOCHIJ, global::CLAIBMPFHJC<T> IDNLJKKILBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2106EA0", Offset = "0x21060A0", VA = "0x182106EA0", Slot = "23")]
	public void DBCONGMMBHA<T>(string GIEKPGOGCIP, T DIDEMEECIEC, global::CLAIBMPFHJC<T> IDNLJKKILBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x408FB00", Offset = "0x408ED00", VA = "0x18408FB00", Slot = "16")]
	public string BFNOBAIJLHC(string KPLFFOGJEBN, string MBFIEIOCHIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x408FA80", Offset = "0x408EC80", VA = "0x18408FA80", Slot = "17")]
	public void AOEBCKPCNFK(string KPLFFOGJEBN, string DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x408FB90", Offset = "0x408ED90", VA = "0x18408FB90", Slot = "24")]
	public void DDHFNMJEBHA(string KPLFFOGJEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x408FFA0", Offset = "0x408F1A0", VA = "0x18408FFA0", Slot = "9")]
	public bool LLJMJGIFBGD(string KPLFFOGJEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4090010", Offset = "0x408F210", VA = "0x184090010", Slot = "25")]
	public void LMGMBHADFBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2296E60", Offset = "0x2296060", VA = "0x182296E60")]
	private T MLFCIIDAMLN<T>(string GIEKPGOGCIP, T MBFIEIOCHIJ, [Optional] global::CLAIBMPFHJC<T> GAIAKEPNKAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24D4D50", Offset = "0x24D3F50", VA = "0x1824D4D50")]
	private void BCKFLFBECFJ<T>(string GIEKPGOGCIP, T DIDEMEECIEC, [Optional] global::CLAIBMPFHJC<T> GAIAKEPNKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x40901B0", Offset = "0x408F3B0", VA = "0x1840901B0")]
	private Dictionary<string, string> LOKIOGMGOFG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LGHEGMFLLFJ
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action AOFBMPDJMJN;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEMJBKBNLDJ();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FEKMFPECCOI(long LNPCMNGBLIP);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JKNIOEIMJFF(INKKOCLDLIA KKHDLJFPAJG = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NAOCAICAEPA(string GIEKPGOGCIP, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KDKGGDIIBPJ(string GIEKPGOGCIP, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string JKEFBAKOBOP(string GIEKPGOGCIP, [Optional] string MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AMJHCNMDCEC LMPKAFJKNAJ(string GIEKPGOGCIP, string DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int MHMAHEOMNHD(string GIEKPGOGCIP, int MBFIEIOCHIJ = 0, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AMJHCNMDCEC FDMIHKIABFI(string GIEKPGOGCIP, int DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DPOJMBOBLPC(string GIEKPGOGCIP, bool MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	AMJHCNMDCEC GHHFCIPCPBO(string GIEKPGOGCIP, bool DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float KBEDHPHOKJP(string GIEKPGOGCIP, float MBFIEIOCHIJ = 0f, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AMJHCNMDCEC NCMFDNJLHPF(string GIEKPGOGCIP, float DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime NMBEHEMPLBD(string GIEKPGOGCIP, [Optional] DateTime MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "16")]
	AMJHCNMDCEC NOOPKCGJMCI(string GIEKPGOGCIP, DateTime DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long OCIKKAHOKOC(string GIEKPGOGCIP, long MBFIEIOCHIJ = 0L, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "18")]
	AMJHCNMDCEC LGOCLNJNDMG(string GIEKPGOGCIP, long DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T NCALPFOAGEA<T>(string GIEKPGOGCIP, [Optional] T MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "20")]
	AMJHCNMDCEC GHLKJGAAKPO<T>(string GIEKPGOGCIP, T DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool GPHGIDICOIA(string GIEKPGOGCIP);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool HNFGANDIKIB(string GIEKPGOGCIP);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string PEOELODGCBH(string GIEKPGOGCIP, [Optional] string MBFIEIOCHIJ);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	AMJHCNMDCEC BFBAGJHDJCD(string GIEKPGOGCIP, string DIDEMEECIEC);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int ICMIAGPEKEF(string GIEKPGOGCIP, int MBFIEIOCHIJ = 0);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AMJHCNMDCEC PFMIDMBMMHN(string GIEKPGOGCIP, int DIDEMEECIEC);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DKLDGLPJFMF(string GIEKPGOGCIP, bool MBFIEIOCHIJ);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	AMJHCNMDCEC BBCPAIAFCJK(string GIEKPGOGCIP, bool DIDEMEECIEC);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float AJCMGAJCOIG(string GIEKPGOGCIP, float MBFIEIOCHIJ = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "30")]
	AMJHCNMDCEC JABOHMGDIHI(string GIEKPGOGCIP, float DIDEMEECIEC);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime JKBOHOLPKIB(string GIEKPGOGCIP, [Optional] DateTime MBFIEIOCHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "32")]
	AMJHCNMDCEC BDJHHILCEOH(string GIEKPGOGCIP, DateTime DIDEMEECIEC);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void HOKJKBCJHEC<T>(global::CLAIBMPFHJC<T> IDNLJKKILBB, [Optional] IEqualityComparer<T> FMMPPPLBNBI);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void PGKFOOCPHIM<T>();

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable AALPFKGKCIK();

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FLDJFMAINPJ(float NFANCAJAMHK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum AMJHCNMDCEC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	New,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GLEOPOGDMBF : LGHEGMFLLFJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private abstract class BLJMDHBPBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected static readonly HashSet<BLJMDHBPBCJ> GNDAMEKIAHO;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x408F8F0", Offset = "0x408EAF0", VA = "0x18408F8F0")]
		public static void DLPIOOIPHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void EGONGNAPLEO();

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
		protected BLJMDHBPBCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class LJKIPJBFIEA<T> : BLJMDHBPBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly LJKIPJBFIEA<T> PBJALEFDLAL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public global::CLAIBMPFHJC<T> GOALGOIDIPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x449440", Offset = "0x448640", VA = "0x180449440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IEqualityComparer<T> PGGBBLKDJEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x449450", Offset = "0x448650", VA = "0x180449450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool FDKOJKFGHMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x29ACB30", Offset = "0x29ABD30", VA = "0x1829ACB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B58690", Offset = "0x2B57890", VA = "0x182B58690")]
		private LJKIPJBFIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B58290", Offset = "0x2B57490", VA = "0x182B58290")]
		public void JJNJNCCGJIN(global::CLAIBMPFHJC<T> GAIAKEPNKAE, [Optional] IEqualityComparer<T> FMMPPPLBNBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B58230", Offset = "0x2B57430", VA = "0x182B58230", Slot = "4")]
		public override void EGONGNAPLEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class EDFCJCELNCF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly GLEOPOGDMBF LPJIJOMKPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly object OMFCIKAFEHA;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4090960", Offset = "0x408FB60", VA = "0x184090960")]
		public EDFCJCELNCF(GLEOPOGDMBF LPJIJOMKPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4090930", Offset = "0x408FB30", VA = "0x184090930", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct PKKDADCKGFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public GLEOPOGDMBF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x40943A0", Offset = "0x40935A0", VA = "0x1840943A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5FD250", Offset = "0x5FC450", VA = "0x1805FD250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class FFPNGGCKPCP : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public GLEOPOGDMBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public FFPNGGCKPCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x40909F0", Offset = "0x408FBF0", VA = "0x1840909F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4090AC0", Offset = "0x408FCC0", VA = "0x184090AC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BNKACNIHEHM GEGBAPBBDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly BNKACNIHEHM CCCBNOAPBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly PHIJAMFFMFH IFBPOGNHBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HashSet<BNKACNIHEHM> HCIIKKFMGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Task LFKBFDCKPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private INJGDFDPILJ KJJDKDJOIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly object OJFOKCIBPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly object OJLLLAFIJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private long BKKAGOBNBEK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool KNBFIKDPPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xFA2100", Offset = "0xFA1300", VA = "0x180FA2100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private CancellationTokenSource AADIKOPKPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x449F90", Offset = "0x449190", VA = "0x180449F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x449FA0", Offset = "0x4491A0", VA = "0x180449FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action AOFBMPDJMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4091E00", Offset = "0x4091000", VA = "0x184091E00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4091960", Offset = "0x4090B60", VA = "0x184091960", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4091890", Offset = "0x4090A90", VA = "0x184091890")]
	[CNCOEENPANM]
	private static void EJMOLNNKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x40936D0", Offset = "0x40928D0", VA = "0x1840936D0")]
	[Preserve]
	public GLEOPOGDMBF([PAEMLBHNBOA("Disk")] BNKACNIHEHM GEGBAPBBDGI, [PAEMLBHNBOA("Cloud")] BNKACNIHEHM CCCBNOAPBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x40915A0", Offset = "0x40907A0", VA = "0x1840915A0", Slot = "41")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4091220", Offset = "0x4090420", VA = "0x184091220")]
	private void CBGGKAIIIHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x40921A0", Offset = "0x40913A0", VA = "0x1840921A0", Slot = "6")]
	public void HEMJBKBNLDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4091B70", Offset = "0x4090D70", VA = "0x184091B70", Slot = "7")]
	public Task FEKMFPECCOI(long LNPCMNGBLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4091EA0", Offset = "0x40910A0", VA = "0x184091EA0")]
	[AsyncStateMachine(typeof(PKKDADCKGFF))]
	private Task FKDLBAFMPFP(long LNPCMNGBLIP, CancellationToken HBBKODCJALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xFA2140", Offset = "0xFA1340", VA = "0x180FA2140")]
	private void GJIPIGBPHGH(object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4092120", Offset = "0x4091320", VA = "0x184092120")]
	private void HEJEFOGMBPI(object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4092610", Offset = "0x4091810", VA = "0x184092610")]
	private string JNMDCHONKOC(string BKBPJMKGBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x40915F0", Offset = "0x40907F0", VA = "0x1840915F0")]
	private void EFBEJOPKDLD(INKKOCLDLIA KKHDLJFPAJG, string KPLFFOGJEBN, out BNKACNIHEHM EGHPGNIPFCG, out string ILKCMCPAMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4092210", Offset = "0x4091410", VA = "0x184092210")]
	private BNKACNIHEHM HFCBPIKGOPJ(INKKOCLDLIA KKHDLJFPAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x40924F0", Offset = "0x40916F0", VA = "0x1840924F0", Slot = "8")]
	public bool JKNIOEIMJFF(INKKOCLDLIA KKHDLJFPAJG = INKKOCLDLIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4092F80", Offset = "0x4092180", VA = "0x184092F80", Slot = "9")]
	public bool NAOCAICAEPA(string GIEKPGOGCIP, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x40927B0", Offset = "0x40919B0", VA = "0x1840927B0", Slot = "10")]
	public bool KDKGGDIIBPJ(string GIEKPGOGCIP, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x40923C0", Offset = "0x40915C0", VA = "0x1840923C0", Slot = "11")]
	public string JKEFBAKOBOP(string GIEKPGOGCIP, [Optional] string MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4092CF0", Offset = "0x4091EF0", VA = "0x184092CF0", Slot = "12")]
	public AMJHCNMDCEC LMPKAFJKNAJ(string GIEKPGOGCIP, string DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4092E50", Offset = "0x4092050", VA = "0x184092E50", Slot = "13")]
	public int MHMAHEOMNHD(string GIEKPGOGCIP, int MBFIEIOCHIJ = 0, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4091A00", Offset = "0x4090C00", VA = "0x184091A00", Slot = "14")]
	public AMJHCNMDCEC FDMIHKIABFI(string GIEKPGOGCIP, int DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4091470", Offset = "0x4090670", VA = "0x184091470", Slot = "15")]
	public bool DPOJMBOBLPC(string GIEKPGOGCIP, bool MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4091FB0", Offset = "0x40911B0", VA = "0x184091FB0", Slot = "16")]
	public AMJHCNMDCEC GHHFCIPCPBO(string GIEKPGOGCIP, bool DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4092680", Offset = "0x4091880", VA = "0x184092680", Slot = "17")]
	public float KBEDHPHOKJP(string GIEKPGOGCIP, float MBFIEIOCHIJ = 0f, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x40930A0", Offset = "0x40922A0", VA = "0x1840930A0", Slot = "18")]
	public AMJHCNMDCEC NCMFDNJLHPF(string GIEKPGOGCIP, float DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x40931A0", Offset = "0x40923A0", VA = "0x1840931A0", Slot = "19")]
	public DateTime NMBEHEMPLBD(string GIEKPGOGCIP, [Optional] DateTime MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x40932D0", Offset = "0x40924D0", VA = "0x1840932D0", Slot = "20")]
	public AMJHCNMDCEC NOOPKCGJMCI(string GIEKPGOGCIP, DateTime DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4093500", Offset = "0x4092700", VA = "0x184093500", Slot = "21")]
	public long OCIKKAHOKOC(string GIEKPGOGCIP, long MBFIEIOCHIJ = 0L, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x40928A0", Offset = "0x4091AA0", VA = "0x1840928A0", Slot = "22")]
	public AMJHCNMDCEC LGOCLNJNDMG(string GIEKPGOGCIP, long DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x229CE30", Offset = "0x229C030", VA = "0x18229CE30", Slot = "23")]
	public T NCALPFOAGEA<T>(string GIEKPGOGCIP, [Optional] T MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x206CD60", Offset = "0x206BF60", VA = "0x18206CD60", Slot = "24")]
	public AMJHCNMDCEC GHLKJGAAKPO<T>(string GIEKPGOGCIP, T DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x40920C0", Offset = "0x40912C0", VA = "0x1840920C0", Slot = "25")]
	public bool GPHGIDICOIA(string GIEKPGOGCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x40922A0", Offset = "0x40914A0", VA = "0x1840922A0", Slot = "26")]
	public bool HNFGANDIKIB(string GIEKPGOGCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4093630", Offset = "0x4092830", VA = "0x184093630", Slot = "27")]
	public string PEOELODGCBH(string GIEKPGOGCIP, [Optional] string MBFIEIOCHIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4091090", Offset = "0x4090290", VA = "0x184091090", Slot = "28")]
	public AMJHCNMDCEC BFBAGJHDJCD(string GIEKPGOGCIP, string DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x40922B0", Offset = "0x40914B0", VA = "0x1840922B0", Slot = "29")]
	public int ICMIAGPEKEF(string GIEKPGOGCIP, int MBFIEIOCHIJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x40936A0", Offset = "0x40928A0", VA = "0x1840936A0", Slot = "30")]
	public AMJHCNMDCEC PFMIDMBMMHN(string GIEKPGOGCIP, int DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4091400", Offset = "0x4090600", VA = "0x184091400", Slot = "31")]
	public bool DKLDGLPJFMF(string GIEKPGOGCIP, bool MBFIEIOCHIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4090EE0", Offset = "0x40900E0", VA = "0x184090EE0", Slot = "32")]
	public AMJHCNMDCEC BBCPAIAFCJK(string GIEKPGOGCIP, bool DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4090D30", Offset = "0x408FF30", VA = "0x184090D30", Slot = "33")]
	public float AJCMGAJCOIG(string GIEKPGOGCIP, float MBFIEIOCHIJ = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4092320", Offset = "0x4091520", VA = "0x184092320", Slot = "34")]
	public AMJHCNMDCEC JABOHMGDIHI(string GIEKPGOGCIP, float DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4092350", Offset = "0x4091550", VA = "0x184092350", Slot = "35")]
	public DateTime JKBOHOLPKIB(string GIEKPGOGCIP, [Optional] DateTime MBFIEIOCHIJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4091060", Offset = "0x4090260", VA = "0x184091060", Slot = "36")]
	public AMJHCNMDCEC BDJHHILCEOH(string GIEKPGOGCIP, DateTime DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4092DF0", Offset = "0x4091FF0", VA = "0x184092DF0")]
	private bool MHAMDGAGENG(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4091CF0", Offset = "0x4090EF0", VA = "0x184091CF0")]
	private bool FFHACOBIAGP(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4090DA0", Offset = "0x408FFA0", VA = "0x184090DA0")]
	private AMJHCNMDCEC ANHFACELDHN(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, string DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4090BD0", Offset = "0x408FDD0", VA = "0x184090BD0")]
	private AMJHCNMDCEC AEPFCADCLDM(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, int DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x40912B0", Offset = "0x40904B0", VA = "0x1840912B0")]
	private AMJHCNMDCEC CIPALHCKNOG(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, bool DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4090F10", Offset = "0x4090110", VA = "0x184090F10")]
	private AMJHCNMDCEC BCLNEPOPPBP(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, float DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x40910C0", Offset = "0x40902C0", VA = "0x1840910C0")]
	private AMJHCNMDCEC BNGDIIHHOJM(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, DateTime DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x40933D0", Offset = "0x40925D0", VA = "0x1840933D0")]
	private AMJHCNMDCEC OBIIPLAHPPI(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, long DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x229CBC0", Offset = "0x229BDC0", VA = "0x18229CBC0")]
	private T IGFJBCOBGKB<T>(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, T MBFIEIOCHIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x206D1C0", Offset = "0x206C3C0", VA = "0x18206D1C0")]
	private AMJHCNMDCEC KLFFMIHFNOB<T>(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, T DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x21066E0", Offset = "0x21058E0", VA = "0x1821066E0", Slot = "37")]
	public void HOKJKBCJHEC<T>(global::CLAIBMPFHJC<T> IDNLJKKILBB, [Optional] IEqualityComparer<T> FMMPPPLBNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x21067C0", Offset = "0x21059C0", VA = "0x1821067C0", Slot = "38")]
	public void PGKFOOCPHIM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4092C60", Offset = "0x4091E60", VA = "0x184092C60")]
	private void LMGMBHADFBO(BNKACNIHEHM JEOJPAEMLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x40916F0", Offset = "0x40908F0", VA = "0x1840916F0")]
	private void EJJBDDHGPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4090B10", Offset = "0x408FD10", VA = "0x184090B10", Slot = "39")]
	public IDisposable AALPFKGKCIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4091FA0", Offset = "0x40911A0", VA = "0x184091FA0", Slot = "40")]
	public void FLDJFMAINPJ(float NFANCAJAMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4092A90", Offset = "0x4091C90", VA = "0x184092A90")]
	private void LHKDBJJDBLD(float DBAPHEBKPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4091B00", Offset = "0x4090D00", VA = "0x184091B00")]
	[IteratorStateMachine(typeof(FFPNGGCKPCP))]
	private IEnumerator<GGOLJFPNLLB> FDNJOMNFHHC(float NFANCAJAMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4090D00", Offset = "0x408FF00", VA = "0x184090D00")]
	[CompilerGenerated]
	private void AINKEJLHHLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ADFJECDMPPG : global::AGMPEEODDBM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static ADFJECDMPPG PBJALEFDLAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x408F7D0", Offset = "0x408E9D0", VA = "0x18408F7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x408F6F0", Offset = "0x408E8F0", VA = "0x18408F6F0", Slot = "8")]
	public override string INFKGBLMABD(bool BENDFBJLKFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x408F430", Offset = "0x408E630", VA = "0x18408F430", Slot = "9")]
	protected override bool ACFDFIJBADJ(string BENDFBJLKFH, out bool DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x408F8B0", Offset = "0x408EAB0", VA = "0x18408F8B0")]
	public ADFJECDMPPG()
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
