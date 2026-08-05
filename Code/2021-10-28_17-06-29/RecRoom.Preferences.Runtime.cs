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
	[Cpp2IlInjected.Address(RVA = "0x407E5F0", Offset = "0x407D7F0", VA = "0x18407E5F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x407E570", Offset = "0x407D770", VA = "0x18407E570")]
		protected JLOPCKJJFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void DIMPNLHMANN(string KPLFFOGJEBN);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x407E3D0", Offset = "0x407D5D0", VA = "0x18407E3D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x206D7B0", Offset = "0x206C9B0", VA = "0x18206D7B0")]
		public bool KLBAJGAHLAH(string BCKHJDJHJEK, out T JDEKHHPOHGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x206D7E0", Offset = "0x206C9E0", VA = "0x18206D7E0")]
		public void LKMOKJMOENA(string BCKHJDJHJEK, T DIDEMEECIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1EB58A0", Offset = "0x1EB4AA0", VA = "0x181EB58A0", Slot = "4")]
		protected override void DIMPNLHMANN(string BCKHJDJHJEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x360BD30", Offset = "0x360AF30", VA = "0x18360BD30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x407E750", Offset = "0x407D950", VA = "0x18407E750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x407E840", Offset = "0x407DA40", VA = "0x18407E840", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x407E320", Offset = "0x407D520", VA = "0x18407E320")]
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
	[Cpp2IlInjected.Address(RVA = "0x407DF50", Offset = "0x407D150", VA = "0x18407DF50", Slot = "7")]
	public Task HAFBLDHPJLK(long LNPCMNGBLIP, CancellationToken HBBKODCJALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2A43390", Offset = "0x2A42590", VA = "0x182A43390")]
	private static int EAMGDEKLHAE(bool DIDEMEECIEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x407E0F0", Offset = "0x407D2F0", VA = "0x18407E0F0", Slot = "9")]
	public bool LLJMJGIFBGD(string GIEKPGOGCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x407E2A0", Offset = "0x407D4A0", VA = "0x18407E2A0", Slot = "10")]
	public int PFAEHFLJPKM(string GIEKPGOGCIP, int MBFIEIOCHIJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x407DF40", Offset = "0x407D140", VA = "0x18407DF40", Slot = "11")]
	public void GNBGOLOBEMD(string GIEKPGOGCIP, int DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x407E0C0", Offset = "0x407D2C0", VA = "0x18407E0C0", Slot = "12")]
	public bool KCGFJOMNDDG(string GIEKPGOGCIP, bool MBFIEIOCHIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x407E310", Offset = "0x407D510", VA = "0x18407E310", Slot = "13")]
	public void PNNNDDPEPNK(string GIEKPGOGCIP, bool DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x407E0E0", Offset = "0x407D2E0", VA = "0x18407E0E0", Slot = "14")]
	public float LFCAIABPJFJ(string GIEKPGOGCIP, float MBFIEIOCHIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x407DED0", Offset = "0x407D0D0", VA = "0x18407DED0", Slot = "15")]
	public void EEONKKJNCLL(string GIEKPGOGCIP, float DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x407DD30", Offset = "0x407CF30", VA = "0x18407DD30", Slot = "16")]
	public string BFNOBAIJLHC(string GIEKPGOGCIP, string MBFIEIOCHIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x310B030", Offset = "0x310A230", VA = "0x18310B030", Slot = "17")]
	public void AOEBCKPCNFK(string GIEKPGOGCIP, string DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x407E000", Offset = "0x407D200", VA = "0x18407E000", Slot = "18")]
	public DateTime JBKMBMGFFGF(string GIEKPGOGCIP, [Optional] DateTime MBFIEIOCHIJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x407DEE0", Offset = "0x407D0E0", VA = "0x18407DEE0", Slot = "19")]
	public void FDLGCCPLBCE(string GIEKPGOGCIP, DateTime ECACLKFPEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x407E060", Offset = "0x407D260", VA = "0x18407E060", Slot = "20")]
	public long JDHMEMDFOMC(string GIEKPGOGCIP, long MBFIEIOCHIJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x407E2B0", Offset = "0x407D4B0", VA = "0x18407E2B0", Slot = "21")]
	public void PILPJMEBEMM(string GIEKPGOGCIP, long DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FCE510", Offset = "0x1FCD710", VA = "0x181FCE510", Slot = "22")]
	public T KAHIEHFEBFM<T>(string GIEKPGOGCIP, T MBFIEIOCHIJ, global::CLAIBMPFHJC<T> IDNLJKKILBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E06040", Offset = "0x1E05240", VA = "0x181E06040", Slot = "23")]
	public void DBCONGMMBHA<T>(string GIEKPGOGCIP, T DIDEMEECIEC, global::CLAIBMPFHJC<T> IDNLJKKILBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5A10", Offset = "0x1FD4C10", VA = "0x181FD5A10")]
	private T ICBNPPPOHHM<T>(string GIEKPGOGCIP, T MBFIEIOCHIJ, [Optional] global::CLAIBMPFHJC<T> GAIAKEPNKAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E063F0", Offset = "0x1E055F0", VA = "0x181E063F0")]
	private void FFKJOIIOELH<T>(string GIEKPGOGCIP, T DIDEMEECIEC, [Optional] global::CLAIBMPFHJC<T> GAIAKEPNKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x407DE70", Offset = "0x407D070", VA = "0x18407DE70", Slot = "24")]
	public void DDHFNMJEBHA(string GIEKPGOGCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x407E100", Offset = "0x407D300", VA = "0x18407E100", Slot = "25")]
	public void LMGMBHADFBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x407DDB0", Offset = "0x407CFB0", VA = "0x18407DDB0")]
	[IteratorStateMachine(typeof(OCGHOJBAPJG))]
	private IEnumerator<GGOLJFPNLLB> CAAFOKDBEGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x407DFA0", Offset = "0x407D1A0", VA = "0x18407DFA0")]
	private void HCFIOMAPJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x407DD50", Offset = "0x407CF50", VA = "0x18407DD50")]
	private void BIOIBJJDGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x407DE10", Offset = "0x407D010", VA = "0x18407DE10")]
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
		[Cpp2IlInjected.Address(RVA = "0x407ADA0", Offset = "0x4079FA0", VA = "0x18407ADA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x407AAD0", Offset = "0x4079CD0", VA = "0x18407AAD0")]
		public static void AELGFEDJCLP(string KPLFFOGJEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x407AC10", Offset = "0x4079E10", VA = "0x18407AC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x206D7B0", Offset = "0x206C9B0", VA = "0x18206D7B0")]
		public bool KLBAJGAHLAH(string BCKHJDJHJEK, out T JDEKHHPOHGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x206D7E0", Offset = "0x206C9E0", VA = "0x18206D7E0")]
		public void LKMOKJMOENA(string BCKHJDJHJEK, T DIDEMEECIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7910", Offset = "0x1DC6B10", VA = "0x181DC7910", Slot = "4")]
		protected override void EGONGNAPLEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x206D780", Offset = "0x206C980", VA = "0x18206D780", Slot = "5")]
		protected override void DIMPNLHMANN(string BCKHJDJHJEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C000", Offset = "0x2B1B200", VA = "0x182B1C000")]
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
		[Cpp2IlInjected.Address(RVA = "0x407A940", Offset = "0x4079B40", VA = "0x18407A940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Dictionary<string, string> FDMMDCBHPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x407A910", Offset = "0x4079B10", VA = "0x18407A910")]
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
	[Cpp2IlInjected.Address(RVA = "0x407A240", Offset = "0x4079440", VA = "0x18407A240", Slot = "7")]
	public Task HAFBLDHPJLK(long LNPCMNGBLIP, CancellationToken HBBKODCJALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x407A430", Offset = "0x4079630", VA = "0x18407A430", Slot = "14")]
	public float LFCAIABPJFJ(string KPLFFOGJEBN, float MBFIEIOCHIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x407AA60", Offset = "0x4079C60", VA = "0x18407AA60", Slot = "13")]
	public void PNNNDDPEPNK(string KPLFFOGJEBN, bool DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x407A350", Offset = "0x4079550", VA = "0x18407A350", Slot = "12")]
	public bool KCGFJOMNDDG(string KPLFFOGJEBN, bool MBFIEIOCHIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x407A9A0", Offset = "0x4079BA0", VA = "0x18407A9A0", Slot = "10")]
	public int PFAEHFLJPKM(string KPLFFOGJEBN, int MBFIEIOCHIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x407A290", Offset = "0x4079490", VA = "0x18407A290", Slot = "18")]
	public DateTime JBKMBMGFFGF(string GIEKPGOGCIP, [Optional] DateTime MBFIEIOCHIJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x407A180", Offset = "0x4079380", VA = "0x18407A180", Slot = "19")]
	public void FDLGCCPLBCE(string KPLFFOGJEBN, DateTime DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x407A120", Offset = "0x4079320", VA = "0x18407A120", Slot = "15")]
	public void EEONKKJNCLL(string KPLFFOGJEBN, float DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x407A1E0", Offset = "0x40793E0", VA = "0x18407A1E0", Slot = "11")]
	public void GNBGOLOBEMD(string KPLFFOGJEBN, int DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x407A2F0", Offset = "0x40794F0", VA = "0x18407A2F0", Slot = "20")]
	public long JDHMEMDFOMC(string GIEKPGOGCIP, long MBFIEIOCHIJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x407AA00", Offset = "0x4079C00", VA = "0x18407AA00", Slot = "21")]
	public void PILPJMEBEMM(string GIEKPGOGCIP, long DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FCE510", Offset = "0x1FCD710", VA = "0x181FCE510", Slot = "22")]
	public T KAHIEHFEBFM<T>(string GIEKPGOGCIP, T MBFIEIOCHIJ, global::CLAIBMPFHJC<T> IDNLJKKILBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E06040", Offset = "0x1E05240", VA = "0x181E06040", Slot = "23")]
	public void DBCONGMMBHA<T>(string GIEKPGOGCIP, T DIDEMEECIEC, global::CLAIBMPFHJC<T> IDNLJKKILBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4079FF0", Offset = "0x40791F0", VA = "0x184079FF0", Slot = "16")]
	public string BFNOBAIJLHC(string KPLFFOGJEBN, string MBFIEIOCHIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4079F70", Offset = "0x4079170", VA = "0x184079F70", Slot = "17")]
	public void AOEBCKPCNFK(string KPLFFOGJEBN, string DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x407A080", Offset = "0x4079280", VA = "0x18407A080", Slot = "24")]
	public void DDHFNMJEBHA(string KPLFFOGJEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x407A490", Offset = "0x4079690", VA = "0x18407A490", Slot = "9")]
	public bool LLJMJGIFBGD(string KPLFFOGJEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x407A500", Offset = "0x4079700", VA = "0x18407A500", Slot = "25")]
	public void LMGMBHADFBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF100", Offset = "0x1FCE300", VA = "0x181FCF100")]
	private T MLFCIIDAMLN<T>(string GIEKPGOGCIP, T MBFIEIOCHIJ, [Optional] global::CLAIBMPFHJC<T> GAIAKEPNKAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x223F1A0", Offset = "0x223E3A0", VA = "0x18223F1A0")]
	private void BCKFLFBECFJ<T>(string GIEKPGOGCIP, T DIDEMEECIEC, [Optional] global::CLAIBMPFHJC<T> GAIAKEPNKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x407A6A0", Offset = "0x40798A0", VA = "0x18407A6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4079DE0", Offset = "0x4078FE0", VA = "0x184079DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2757970", Offset = "0x2756B70", VA = "0x182757970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x296B270", Offset = "0x296A470", VA = "0x18296B270")]
		private LJKIPJBFIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x296AE70", Offset = "0x296A070", VA = "0x18296AE70")]
		public void JJNJNCCGJIN(global::CLAIBMPFHJC<T> GAIAKEPNKAE, [Optional] IEqualityComparer<T> FMMPPPLBNBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x296AE10", Offset = "0x296A010", VA = "0x18296AE10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x407AE50", Offset = "0x407A050", VA = "0x18407AE50")]
		public EDFCJCELNCF(GLEOPOGDMBF LPJIJOMKPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x407AE20", Offset = "0x407A020", VA = "0x18407AE20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x407E890", Offset = "0x407DA90", VA = "0x18407E890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x557D10", Offset = "0x556F10", VA = "0x180557D10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x407AEE0", Offset = "0x407A0E0", VA = "0x18407AEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x407AFB0", Offset = "0x407A1B0", VA = "0x18407AFB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xC9C040", Offset = "0xC9B240", VA = "0x180C9C040")]
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
		[Cpp2IlInjected.Address(RVA = "0x407C2F0", Offset = "0x407B4F0", VA = "0x18407C2F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x407BE50", Offset = "0x407B050", VA = "0x18407BE50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x407BD80", Offset = "0x407AF80", VA = "0x18407BD80")]
	[CNCOEENPANM]
	private static void EJMOLNNKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x407DBC0", Offset = "0x407CDC0", VA = "0x18407DBC0")]
	[Preserve]
	public GLEOPOGDMBF([PAEMLBHNBOA("Disk")] BNKACNIHEHM GEGBAPBBDGI, [PAEMLBHNBOA("Cloud")] BNKACNIHEHM CCCBNOAPBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x407BA90", Offset = "0x407AC90", VA = "0x18407BA90", Slot = "41")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x407B710", Offset = "0x407A910", VA = "0x18407B710")]
	private void CBGGKAIIIHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x407C690", Offset = "0x407B890", VA = "0x18407C690", Slot = "6")]
	public void HEMJBKBNLDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x407C060", Offset = "0x407B260", VA = "0x18407C060", Slot = "7")]
	public Task FEKMFPECCOI(long LNPCMNGBLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x407C390", Offset = "0x407B590", VA = "0x18407C390")]
	[AsyncStateMachine(typeof(PKKDADCKGFF))]
	private Task FKDLBAFMPFP(long LNPCMNGBLIP, CancellationToken HBBKODCJALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xC9C080", Offset = "0xC9B280", VA = "0x180C9C080")]
	private void GJIPIGBPHGH(object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x407C610", Offset = "0x407B810", VA = "0x18407C610")]
	private void HEJEFOGMBPI(object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x407CB00", Offset = "0x407BD00", VA = "0x18407CB00")]
	private string JNMDCHONKOC(string BKBPJMKGBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x407BAE0", Offset = "0x407ACE0", VA = "0x18407BAE0")]
	private void EFBEJOPKDLD(INKKOCLDLIA KKHDLJFPAJG, string KPLFFOGJEBN, out BNKACNIHEHM EGHPGNIPFCG, out string ILKCMCPAMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x407C700", Offset = "0x407B900", VA = "0x18407C700")]
	private BNKACNIHEHM HFCBPIKGOPJ(INKKOCLDLIA KKHDLJFPAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x407C9E0", Offset = "0x407BBE0", VA = "0x18407C9E0", Slot = "8")]
	public bool JKNIOEIMJFF(INKKOCLDLIA KKHDLJFPAJG = INKKOCLDLIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x407D470", Offset = "0x407C670", VA = "0x18407D470", Slot = "9")]
	public bool NAOCAICAEPA(string GIEKPGOGCIP, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x407CCA0", Offset = "0x407BEA0", VA = "0x18407CCA0", Slot = "10")]
	public bool KDKGGDIIBPJ(string GIEKPGOGCIP, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x407C8B0", Offset = "0x407BAB0", VA = "0x18407C8B0", Slot = "11")]
	public string JKEFBAKOBOP(string GIEKPGOGCIP, [Optional] string MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x407D1E0", Offset = "0x407C3E0", VA = "0x18407D1E0", Slot = "12")]
	public AMJHCNMDCEC LMPKAFJKNAJ(string GIEKPGOGCIP, string DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x407D340", Offset = "0x407C540", VA = "0x18407D340", Slot = "13")]
	public int MHMAHEOMNHD(string GIEKPGOGCIP, int MBFIEIOCHIJ = 0, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x407BEF0", Offset = "0x407B0F0", VA = "0x18407BEF0", Slot = "14")]
	public AMJHCNMDCEC FDMIHKIABFI(string GIEKPGOGCIP, int DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x407B960", Offset = "0x407AB60", VA = "0x18407B960", Slot = "15")]
	public bool DPOJMBOBLPC(string GIEKPGOGCIP, bool MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x407C4A0", Offset = "0x407B6A0", VA = "0x18407C4A0", Slot = "16")]
	public AMJHCNMDCEC GHHFCIPCPBO(string GIEKPGOGCIP, bool DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x407CB70", Offset = "0x407BD70", VA = "0x18407CB70", Slot = "17")]
	public float KBEDHPHOKJP(string GIEKPGOGCIP, float MBFIEIOCHIJ = 0f, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x407D590", Offset = "0x407C790", VA = "0x18407D590", Slot = "18")]
	public AMJHCNMDCEC NCMFDNJLHPF(string GIEKPGOGCIP, float DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x407D690", Offset = "0x407C890", VA = "0x18407D690", Slot = "19")]
	public DateTime NMBEHEMPLBD(string GIEKPGOGCIP, [Optional] DateTime MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x407D7C0", Offset = "0x407C9C0", VA = "0x18407D7C0", Slot = "20")]
	public AMJHCNMDCEC NOOPKCGJMCI(string GIEKPGOGCIP, DateTime DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x407D9F0", Offset = "0x407CBF0", VA = "0x18407D9F0", Slot = "21")]
	public long OCIKKAHOKOC(string GIEKPGOGCIP, long MBFIEIOCHIJ = 0L, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x407CD90", Offset = "0x407BF90", VA = "0x18407CD90", Slot = "22")]
	public AMJHCNMDCEC LGOCLNJNDMG(string GIEKPGOGCIP, long DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FD50E0", Offset = "0x1FD42E0", VA = "0x181FD50E0", Slot = "23")]
	public T NCALPFOAGEA<T>(string GIEKPGOGCIP, [Optional] T MBFIEIOCHIJ, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D6BF00", Offset = "0x1D6B100", VA = "0x181D6BF00", Slot = "24")]
	public AMJHCNMDCEC GHLKJGAAKPO<T>(string GIEKPGOGCIP, T DIDEMEECIEC, INKKOCLDLIA LABLPLLGAPN = INKKOCLDLIA.CLOUD)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x407C5B0", Offset = "0x407B7B0", VA = "0x18407C5B0", Slot = "25")]
	public bool GPHGIDICOIA(string GIEKPGOGCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x407C790", Offset = "0x407B990", VA = "0x18407C790", Slot = "26")]
	public bool HNFGANDIKIB(string GIEKPGOGCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x407DB20", Offset = "0x407CD20", VA = "0x18407DB20", Slot = "27")]
	public string PEOELODGCBH(string GIEKPGOGCIP, [Optional] string MBFIEIOCHIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x407B580", Offset = "0x407A780", VA = "0x18407B580", Slot = "28")]
	public AMJHCNMDCEC BFBAGJHDJCD(string GIEKPGOGCIP, string DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x407C7A0", Offset = "0x407B9A0", VA = "0x18407C7A0", Slot = "29")]
	public int ICMIAGPEKEF(string GIEKPGOGCIP, int MBFIEIOCHIJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x407DB90", Offset = "0x407CD90", VA = "0x18407DB90", Slot = "30")]
	public AMJHCNMDCEC PFMIDMBMMHN(string GIEKPGOGCIP, int DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x407B8F0", Offset = "0x407AAF0", VA = "0x18407B8F0", Slot = "31")]
	public bool DKLDGLPJFMF(string GIEKPGOGCIP, bool MBFIEIOCHIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x407B3D0", Offset = "0x407A5D0", VA = "0x18407B3D0", Slot = "32")]
	public AMJHCNMDCEC BBCPAIAFCJK(string GIEKPGOGCIP, bool DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x407B220", Offset = "0x407A420", VA = "0x18407B220", Slot = "33")]
	public float AJCMGAJCOIG(string GIEKPGOGCIP, float MBFIEIOCHIJ = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x407C810", Offset = "0x407BA10", VA = "0x18407C810", Slot = "34")]
	public AMJHCNMDCEC JABOHMGDIHI(string GIEKPGOGCIP, float DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x407C840", Offset = "0x407BA40", VA = "0x18407C840", Slot = "35")]
	public DateTime JKBOHOLPKIB(string GIEKPGOGCIP, [Optional] DateTime MBFIEIOCHIJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x407B550", Offset = "0x407A750", VA = "0x18407B550", Slot = "36")]
	public AMJHCNMDCEC BDJHHILCEOH(string GIEKPGOGCIP, DateTime DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x407D2E0", Offset = "0x407C4E0", VA = "0x18407D2E0")]
	private bool MHAMDGAGENG(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x407C1E0", Offset = "0x407B3E0", VA = "0x18407C1E0")]
	private bool FFHACOBIAGP(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x407B290", Offset = "0x407A490", VA = "0x18407B290")]
	private AMJHCNMDCEC ANHFACELDHN(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, string DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x407B0C0", Offset = "0x407A2C0", VA = "0x18407B0C0")]
	private AMJHCNMDCEC AEPFCADCLDM(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, int DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x407B7A0", Offset = "0x407A9A0", VA = "0x18407B7A0")]
	private AMJHCNMDCEC CIPALHCKNOG(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, bool DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x407B400", Offset = "0x407A600", VA = "0x18407B400")]
	private AMJHCNMDCEC BCLNEPOPPBP(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, float DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x407B5B0", Offset = "0x407A7B0", VA = "0x18407B5B0")]
	private AMJHCNMDCEC BNGDIIHHOJM(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, DateTime DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x407D8C0", Offset = "0x407CAC0", VA = "0x18407D8C0")]
	private AMJHCNMDCEC OBIIPLAHPPI(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, long DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4E70", Offset = "0x1FD4070", VA = "0x181FD4E70")]
	private T IGFJBCOBGKB<T>(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, T MBFIEIOCHIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C360", Offset = "0x1D6B560", VA = "0x181D6C360")]
	private AMJHCNMDCEC KLFFMIHFNOB<T>(BNKACNIHEHM EGHPGNIPFCG, string GIEKPGOGCIP, T DIDEMEECIEC)
	{
		return default(AMJHCNMDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E05880", Offset = "0x1E04A80", VA = "0x181E05880", Slot = "37")]
	public void HOKJKBCJHEC<T>(global::CLAIBMPFHJC<T> IDNLJKKILBB, [Optional] IEqualityComparer<T> FMMPPPLBNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E05960", Offset = "0x1E04B60", VA = "0x181E05960", Slot = "38")]
	public void PGKFOOCPHIM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x407D150", Offset = "0x407C350", VA = "0x18407D150")]
	private void LMGMBHADFBO(BNKACNIHEHM JEOJPAEMLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x407BBE0", Offset = "0x407ADE0", VA = "0x18407BBE0")]
	private void EJJBDDHGPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x407B000", Offset = "0x407A200", VA = "0x18407B000", Slot = "39")]
	public IDisposable AALPFKGKCIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x407C490", Offset = "0x407B690", VA = "0x18407C490", Slot = "40")]
	public void FLDJFMAINPJ(float NFANCAJAMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x407CF80", Offset = "0x407C180", VA = "0x18407CF80")]
	private void LHKDBJJDBLD(float DBAPHEBKPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x407BFF0", Offset = "0x407B1F0", VA = "0x18407BFF0")]
	[IteratorStateMachine(typeof(FFPNGGCKPCP))]
	private IEnumerator<GGOLJFPNLLB> FDNJOMNFHHC(float NFANCAJAMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x407B1F0", Offset = "0x407A3F0", VA = "0x18407B1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4079CC0", Offset = "0x4078EC0", VA = "0x184079CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4079BE0", Offset = "0x4078DE0", VA = "0x184079BE0", Slot = "8")]
	public override string INFKGBLMABD(bool BENDFBJLKFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4079920", Offset = "0x4078B20", VA = "0x184079920", Slot = "9")]
	protected override bool ACFDFIJBADJ(string BENDFBJLKFH, out bool DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4079DA0", Offset = "0x4078FA0", VA = "0x184079DA0")]
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
