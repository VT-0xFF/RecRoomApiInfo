using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Core;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
public sealed class GBNIFNFIODI<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class MEOBOACFJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::GBNIFNFIODI<T> ECFCKFIIIJI;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] EOBPNDCILIF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public MEOBOACFJLM(global::GBNIFNFIODI<T> ECFCKFIIIJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class BOKJINEIABJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::GBNIFNFIODI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <count>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "4")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[DebuggerHidden]
		public BOKJINEIABJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const int HADJAFMDCAP = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> KAIHBFEMCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int COJMBAMJJEL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private bool DPHPNEKDHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool CCJFGFPCMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool OFBBACANJOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IGIALMEDHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	public GBNIFNFIODI(int KOHJKAOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public GBNIFNFIODI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void FLGEOLMPKHB(int KLEGICPDLIF, T ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void OKDMEHCANKP(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] JDIBDDEDEKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void GBNCEPLFEAH(NativeArray<T> NMDKCEHJACP, int JBNOJAIGFDO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::GBNIFNFIODI<>.BOKJINEIABJ))]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	public int GOBCNAPLMBL(T ALHICNJOIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool KFPKFODPJHB(T ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void HKIFOKIMJCI(int MGFMPAHALCJ, int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void NFEEAMCKLJO(int MGFMPAHALCJ, int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void PNKJAJPCKAE(int MGFMPAHALCJ, int IHKOJLKELAD, int GGKDNLHEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int DLLGAPDGHFA(int KLEGICPDLIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T HOAFKHGLBGD(int KLEGICPDLIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void KABKIEGMDMA(int KLEGICPDLIF, T ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void NCAHICBGLOG(int KLEGICPDLIF, T ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void JKIHIGMBJHB(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int MJLCNKOIFJM(int NENFOEKGNGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int LFPNGJCHFNG(int NENFOEKGNGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void PBABIIEJOHP(T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void LPDBCNFGEAK(T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T MFDGEIGMLDP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T AFBDIMIPHPO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void EFFGGMEMAIH(int KLEGICPDLIF, IReadOnlyCollection<T> OPJMPLOLCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void OCEEALGELJF(int KLEGICPDLIF, int EHPMNCJEEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void AIACKNFJNLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void NMFDIPFOLNC(T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void PGIAOFDILOM(T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void AAMMGCPMAJF(int IHKOJLKELAD, int GGKDNLHEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T JEGKMEEJDDB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T GJOOAJIALDF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[HOHJMEEIHJO]
public static class EPHGBELDJAE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x31B6630", Offset = "0x31B5230", VA = "0x1831B6630")]
	static EPHGBELDJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x280AA10", Offset = "0x2809610", VA = "0x18280AA10")]
	public static void MIEOHBDNLGD<T>(T CJMCKLJFKJI, ref T AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31B6360", Offset = "0x31B4F60", VA = "0x1831B6360")]
	public static void MIEOHBDNLGD(FixedString32 CJMCKLJFKJI, ref string AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x31B6460", Offset = "0x31B5060", VA = "0x1831B6460")]
	public static void MIEOHBDNLGD(string CJMCKLJFKJI, ref FixedString32 AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x31B6430", Offset = "0x31B5030", VA = "0x1831B6430")]
	public static void MIEOHBDNLGD(FixedString64 CJMCKLJFKJI, ref string AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x31B6300", Offset = "0x31B4F00", VA = "0x1831B6300")]
	public static void MIEOHBDNLGD(string CJMCKLJFKJI, ref FixedString64 AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x31B6500", Offset = "0x31B5100", VA = "0x1831B6500")]
	public static void MIEOHBDNLGD(EIIELPAFEAN CJMCKLJFKJI, ref Vector3 AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x31B64A0", Offset = "0x31B50A0", VA = "0x1831B64A0")]
	public static void MIEOHBDNLGD(Vector3 CJMCKLJFKJI, ref EIIELPAFEAN AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x31B6390", Offset = "0x31B4F90", VA = "0x1831B6390")]
	public static void MIEOHBDNLGD(IJLBFFHOIFO CJMCKLJFKJI, ref Vector4 AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x31B63C0", Offset = "0x31B4FC0", VA = "0x1831B63C0")]
	public static void MIEOHBDNLGD(Vector4 CJMCKLJFKJI, ref IJLBFFHOIFO AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x31B6390", Offset = "0x31B4F90", VA = "0x1831B6390")]
	public static void MIEOHBDNLGD(IJLBFFHOIFO CJMCKLJFKJI, ref Quaternion AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x31B63C0", Offset = "0x31B4FC0", VA = "0x1831B63C0")]
	public static void MIEOHBDNLGD(Quaternion CJMCKLJFKJI, ref IJLBFFHOIFO AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x31B6600", Offset = "0x31B5200", VA = "0x1831B6600")]
	public static void MIEOHBDNLGD(EIIELPAFEAN CJMCKLJFKJI, ref float3 AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x31B64A0", Offset = "0x31B50A0", VA = "0x1831B64A0")]
	public static void MIEOHBDNLGD(float3 CJMCKLJFKJI, ref EIIELPAFEAN AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x31B62C0", Offset = "0x31B4EC0", VA = "0x1831B62C0")]
	public static void MIEOHBDNLGD(IJLBFFHOIFO CJMCKLJFKJI, ref float4 AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x31B63C0", Offset = "0x31B4FC0", VA = "0x1831B63C0")]
	public static void MIEOHBDNLGD(float4 CJMCKLJFKJI, ref IJLBFFHOIFO AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x31B62C0", Offset = "0x31B4EC0", VA = "0x1831B62C0")]
	public static void MIEOHBDNLGD(IJLBFFHOIFO CJMCKLJFKJI, ref quaternion AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x31B6590", Offset = "0x31B5190", VA = "0x1831B6590")]
	public static void MIEOHBDNLGD(quaternion CJMCKLJFKJI, ref IJLBFFHOIFO AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31B6550", Offset = "0x31B5150", VA = "0x1831B6550")]
	public static void MIEOHBDNLGD(Entity CJMCKLJFKJI, ref AIPKNAHMDLH AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x31B6530", Offset = "0x31B5130", VA = "0x1831B6530")]
	public static void MIEOHBDNLGD(AIPKNAHMDLH CJMCKLJFKJI, ref Entity AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NIHNIOJKONF]
public class BHPPBMKPAON : ComponentSystem, BLCFKNFGJJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PJJBBDFFHDI FKFIJLLACLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BA2B0", Offset = "0x6B8EB0", VA = "0x1806BA2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LBOBEHCDDDO AABEJCEFACP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x766940", Offset = "0x765540", VA = "0x180766940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x319D500", Offset = "0x319C100", VA = "0x18319D500", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780")]
	public BHPPBMKPAON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NIHNIOJKONF]
[UpdateInGroup(typeof(JPNCJBNDHJP))]
internal class AMDANEBIDFE : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x319A350", Offset = "0x3198F50", VA = "0x18319A350", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x319A2D0", Offset = "0x3198ED0", VA = "0x18319A2D0")]
	[Preserve]
	private void LFDAMBPLJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public AMDANEBIDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NIHNIOJKONF]
[UpdateInGroup(typeof(JPNCJBNDHJP))]
internal class JJEEGAJBGNH : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35E0D70", Offset = "0x35DF970", VA = "0x1835E0D70", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public JJEEGAJBGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CreateAssetMenu]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x30919E0", Offset = "0x30905E0", VA = "0x1830919E0")]
		public static ObjectModelConfigAsset EDDILCKGGEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x71C1E0", Offset = "0x71ADE0", VA = "0x18071C1E0")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[GKALNADHNEP(DAHLALKJFLL.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[GKALNADHNEP(DAHLALKJFLL.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int EABHPAGIEPM = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly FCNKBCOKGMK OIFMFCIPKIK;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x43B08A0", Offset = "0x43AF4A0", VA = "0x1843B08A0")]
			public static KFMKFJINGPH EHCEDMNGDJA(int IKGFKMOLIOF)
			{
				return default(KFMKFJINGPH);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x43B0690", Offset = "0x43AF290", VA = "0x1843B0690")]
			private static void BHJLMHLFBKO(CGECBEAFDFK BPKELGGFFPE, CGECBEAFDFK KMBHENFOAPO, KFMKFJINGPH AAEPEKAJNKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x43B0C90", Offset = "0x43AF890", VA = "0x1843B0C90")]
			public static int LEKPAJEJEKO(GameObject OKGHLJEDAEA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x43B0820", Offset = "0x43AF420", VA = "0x1843B0820")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void DBABECPOHBO(CGECBEAFDFK HGAMKJKNDDL, int IKGFKMOLIOF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static FNLADHKGADM MDGENIFLAAI;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static DADKCOOMCAC EMGBIPOKPBC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static FNLADHKGADM KPMJHCFFCHI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x30928D0", Offset = "0x30914D0", VA = "0x1830928D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x30924D0", Offset = "0x30910D0", VA = "0x1830924D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static DADKCOOMCAC OIFHCNMNBHB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x30922B0", Offset = "0x3090EB0", VA = "0x1830922B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3092A10", Offset = "0x3091610", VA = "0x183092A10")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool FIFANFNEDMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3091ED0", Offset = "0x3090AD0", VA = "0x183091ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static PJJBBDFFHDI FKFIJLLACLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3093480", Offset = "0x3092080", VA = "0x183093480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static LBOBEHCDDDO AABEJCEFACP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x30926F0", Offset = "0x30912F0", VA = "0x1830926F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static JOIOCJOMOCG HONENAHEKDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3092850", Offset = "0x3091450", VA = "0x183092850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static AIEOMKFDHLJ JPKLCFOPFFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x30933A0", Offset = "0x3091FA0", VA = "0x1830933A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static BKJKHIFBPPC DDGEHDJMFFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3091A80", Offset = "0x3090680", VA = "0x183091A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ALKOEFHOGFF ACFPHCDKPOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3092E20", Offset = "0x3091A20", VA = "0x183092E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool MEMBGGHIBFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3092930", Offset = "0x3091530", VA = "0x183092930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool JPPOHKCBJNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3092EA0", Offset = "0x3091AA0", VA = "0x183092EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool IPDLBFEABBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3092150", Offset = "0x3090D50", VA = "0x183092150")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x3093420", Offset = "0x3092020", VA = "0x183093420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool HFDLECAEDAA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3092DC0", Offset = "0x30919C0", VA = "0x183092DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x30925B0", Offset = "0x30911B0", VA = "0x1830925B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action OBFHJEIBPFO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x30923D0", Offset = "0x3090FD0", VA = "0x1830923D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x30921B0", Offset = "0x3090DB0", VA = "0x1830921B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x30932B0", Offset = "0x3091EB0", VA = "0x1830932B0")]
		public static CGECBEAFDFK OCFNCIECCMF(GameObject OKGHLJEDAEA)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3093120", Offset = "0x3091D20", VA = "0x183093120")]
		public static bool MPPNAACIKBL(ByteString PGJDMPEOAIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3091B00", Offset = "0x3090700", VA = "0x183091B00")]
		public static DABKEOMEIOA AMPMANOOLJI(KFMKFJINGPH AAEPEKAJNKI)
		{
			return default(DABKEOMEIOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3091C20", Offset = "0x3090820", VA = "0x183091C20")]
		public static (ByteString, IDisposable) ANBECOLJJND()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3093180", Offset = "0x3091D80", VA = "0x183093180")]
		public static (ByteString, IDisposable) NBOMDJCCCPB(IEnumerable<CGECBEAFDFK> FOEOIMMDDDC)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3092C90", Offset = "0x3091890", VA = "0x183092C90")]
		public static bool LLGHFJOGIGH(GameObject OKGHLJEDAEA, out KFMKFJINGPH AAEPEKAJNKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3093090", Offset = "0x3091C90", VA = "0x183093090")]
		public static bool MMLFCBFHEON(IEnumerable<OHBEHHAFFLC> GOMDFIBJCOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3092770", Offset = "0x3091370", VA = "0x183092770")]
		public static void IJKOAEEDEOD(bool PJNMHBFDAHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3091D50", Offset = "0x3090950", VA = "0x183091D50")]
		public static Task BDHMBBHPIEG(bool PJNMHBFDAHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3092610", Offset = "0x3091210", VA = "0x183092610")]
		private static DADKCOOMCAC GICBJBLJLDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3092030", Offset = "0x3090C30", VA = "0x183092030")]
		private static bool CBIODHCGNBA()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[GKALNADHNEP(DAHLALKJFLL.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3097D80", Offset = "0x3096980", VA = "0x183097D80")]
		public static bool BEFECFMIAGF(GIHALPBFOMC NPMGCKHFCBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3098120", Offset = "0x3096D20", VA = "0x183098120")]
		public static GIHALPBFOMC JHOMPJHMJJA(GameObject OKGHLJEDAEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3097F20", Offset = "0x3096B20", VA = "0x183097F20")]
		public static GIHALPBFOMC JHOMPJHMJJA(GameObject OKGHLJEDAEA, KFMKFJINGPH AAEPEKAJNKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3098550", Offset = "0x3097150", VA = "0x183098550")]
		public static bool MBKMBEDJILM(GameObject IOHAHKHBMPK, string BNGEJLKNOEH, bool HINCAMJOLJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3098350", Offset = "0x3096F50", VA = "0x183098350")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void KKNGJEDBNME(GameObject IOHAHKHBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3097E30", Offset = "0x3096A30", VA = "0x183097E30")]
		[CompilerGenerated]
		internal static string IBEINANKIJB((GameObject go, string prefabName) JGHKPEFMHLD)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, PJMJAGMOIHL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool MCPCPIJGIOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6AD850", Offset = "0x6AC450", VA = "0x1806AD850", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CGECBEAFDFK GCABFJCPFNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x714C90", Offset = "0x713890", VA = "0x180714C90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(CGECBEAFDFK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x77AF30", Offset = "0x779B30", VA = "0x18077AF30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[GKALNADHNEP(DAHLALKJFLL.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, GIHALPBFOMC, PJMJAGMOIHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string PDMCDFOHEPM = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private PCFEBKCIGDF DBOAJCAFPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private CGECBEAFDFK EJOAECOFOFF;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CGECBEAFDFK GCABFJCPFNE
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x31B7C60", Offset = "0x31B6860", VA = "0x1831B7C60", Slot = "15")]
			get
			{
				return default(CGECBEAFDFK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public DABKEOMEIOA GLBNKDGCEAC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x31B7D10", Offset = "0x31B6910", VA = "0x1831B7D10", Slot = "6")]
			get
			{
				return default(DABKEOMEIOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool MCPCPIJGIOB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x31B7C50", Offset = "0x31B6850", VA = "0x1831B7C50", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public PCFEBKCIGDF MCIKGPOOFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x703250", Offset = "0x701E50", VA = "0x180703250", Slot = "7")]
			get
			{
				return default(PCFEBKCIGDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private LBOBEHCDDDO AABEJCEFACP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x31B72F0", Offset = "0x31B5EF0", VA = "0x1831B72F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private IHMCHCLHMKB KPONFOPHJHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x31B7190", Offset = "0x31B5D90", VA = "0x1831B7190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool JKIAMMMCHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7C4280", Offset = "0x7C2E80", VA = "0x1807C4280", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7C4300", Offset = "0x7C2F00", VA = "0x1807C4300", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> OFMGLPGDFED
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x31B7B10", Offset = "0x31B6710", VA = "0x1831B7B10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x31B7D40", Offset = "0x31B6940", VA = "0x1831B7D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<GIHALPBFOMC> NGKGNFMOJAC
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x31B7BB0", Offset = "0x31B67B0", VA = "0x1831B7BB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x31B7DE0", Offset = "0x31B69E0", VA = "0x1831B7DE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x31B7010", Offset = "0x31B5C10", VA = "0x1831B7010")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x31B7970", Offset = "0x31B6570", VA = "0x1831B7970", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x31B75B0", Offset = "0x31B61B0", VA = "0x1831B75B0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x31B78E0", Offset = "0x31B64E0", VA = "0x1831B78E0", Slot = "10")]
		public void OnEmbody(HOONHJLELFO EELLGOEIJJC, CGECBEAFDFK EJOAECOFOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x31B7960", Offset = "0x31B6560", VA = "0x1831B7960", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x31B76D0", Offset = "0x31B62D0", VA = "0x1831B76D0", Slot = "12")]
		public void OnDisembody(bool IGOHCNBJKDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x31B71F0", Offset = "0x31B5DF0", VA = "0x1831B71F0")]
		private void FCMNKFKNMED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x31B73D0", Offset = "0x31B5FD0", VA = "0x1831B73D0")]
		private void LPEGIJCGAGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x31B7460", Offset = "0x31B6060", VA = "0x1831B7460")]
		private void LPIOMFJAKJE(bool NNIHJHMHBAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x31B7550", Offset = "0x31B6150", VA = "0x1831B7550", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x106CEE0", Offset = "0x106BAE0", VA = "0x18106CEE0", Slot = "9")]
		private GameObject EGCKICDALBG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[GKALNADHNEP(DAHLALKJFLL.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override KLHKIJHKJFB GKGJEPAIAAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x30A3EB0", Offset = "0x30A2AB0", VA = "0x1830A3EB0", Slot = "6")]
			get
			{
				return default(KLHKIJHKJFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x30A3E50", Offset = "0x30A2A50", VA = "0x1830A3E50")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[GKALNADHNEP(DAHLALKJFLL.Registration)]
	public class TransformEntity : MonoBehaviour, PJMJAGMOIHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private KLHKIJHKJFB prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private CGECBEAFDFK HGAMKJKNDDL;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual KLHKIJHKJFB GKGJEPAIAAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080", Slot = "6")]
			get
			{
				return default(KLHKIJHKJFB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x749E90", Offset = "0x748A90", VA = "0x180749E90", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CGECBEAFDFK GCABFJCPFNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x706ED0", Offset = "0x705AD0", VA = "0x180706ED0", Slot = "5")]
			get
			{
				return default(CGECBEAFDFK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool MCPCPIJGIOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x733530", Offset = "0x732130", VA = "0x180733530", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x92F060", Offset = "0x92DC60", VA = "0x18092F060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal Entity CNGGBCAMAFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal BKJKHIFBPPC DDGEHDJMFFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal IHMCHCLHMKB MIPFAJPFHJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x333BA20", Offset = "0x333A620", VA = "0x18333BA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x333B700", Offset = "0x333A300", VA = "0x18333B700")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x333BB60", Offset = "0x333A760", VA = "0x18333BB60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x333B710", Offset = "0x333A310", VA = "0x18333B710")]
		internal void CKNDJHJGHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x333BAC0", Offset = "0x333A6C0", VA = "0x18333BAC0")]
		private bool LGGMHJJACIA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x333BA90", Offset = "0x333A690", VA = "0x18333BA90")]
		private void JJHOMAFCKIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x333BB60", Offset = "0x333A760", VA = "0x18333BB60")]
		internal void MCMCELGEBEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x333BC50", Offset = "0x333A850", VA = "0x18333BC50")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x333BD30", Offset = "0x333A930", VA = "0x18333BD30")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BOFOPPKAPFG(typeof(CJPGLNNDGCM))]
[HJBMNHLGPOF(typeof(DADKCOOMCAC), new string[] { })]
public class PFJBODGOGHJ : ECMHFPHCDAF, KJICOMEDOCG, DADKCOOMCAC, FNHCFHNDIBD, CJPGLNNDGCM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NDJKPGPHDPI FAEIDGPFAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private LBOBEHCDDDO OAMEEAPEBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OHGMKNKEOOJ OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private FANFOMEKGMF EAIGKMCMNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BBLPMAIBLPO MBOFEPLPGLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xC867D0", Offset = "0xC853D0", VA = "0x180C867D0", Slot = "19")]
		get
		{
			return default(BBLPMAIBLPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NDJKPGPHDPI FKFIJLLACLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public OHGMKNKEOOJ NNDPCGNEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public LBOBEHCDDDO AABEJCEFACP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EHAKBDFLKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x733530", Offset = "0x732130", VA = "0x180733530", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool CBCJINGKOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3098D30", Offset = "0x3097930", VA = "0x183098D30", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3098E20", Offset = "0x3097A20", VA = "0x183098E20", Slot = "20")]
	public void LHJKNFEKFKF(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0xA8F640", Offset = "0xA8E240", VA = "0x180A8F640")]
	private void PHKHGJFAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3098C80", Offset = "0x3097880", VA = "0x183098C80")]
	private void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3098BD0", Offset = "0x30977D0", VA = "0x183098BD0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3098DE0", Offset = "0x30979E0", VA = "0x183098DE0", Slot = "10")]
	public void KFLKFIIBAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "4")]
	public void AONBMAKKMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3098D70", Offset = "0x3097970", VA = "0x183098D70", Slot = "5")]
	public void JAOJCFOKLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3098C30", Offset = "0x3097830", VA = "0x183098C30", Slot = "6")]
	public void EBJNMECMOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3098B60", Offset = "0x3097760", VA = "0x183098B60", Slot = "7")]
	public void DPGFLFNLDNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3098FA0", Offset = "0x3097BA0", VA = "0x183098FA0", Slot = "8")]
	public bool MMLFCBFHEON(IEnumerable<OHBEHHAFFLC> GOMDFIBJCOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3098F30", Offset = "0x3097B30", VA = "0x183098F30", Slot = "9")]
	public void LIJFJNNBPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x30989F0", Offset = "0x30975F0", VA = "0x1830989F0", Slot = "11")]
	public void AENALMHIDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3098AE0", Offset = "0x30976E0", VA = "0x183098AE0", Slot = "12")]
	public void DEFEDJOODIB(bool BAGBIJPDAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3098D40", Offset = "0x3097940", VA = "0x183098D40")]
	private void IMLJCGHCOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3098A60", Offset = "0x3097660", VA = "0x183098A60", Slot = "13")]
	public ByteString ANBECOLJJND(out IDisposable PIBIFPAGGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3099110", Offset = "0x3097D10", VA = "0x183099110", Slot = "14")]
	public void PPPEOPKFADK(ByteString GAGLKGONONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3099020", Offset = "0x3097C20", VA = "0x183099020")]
	public static PFJBODGOGHJ NBONEDNFGGC(NDJKPGPHDPI FAEIDGPFAHD, POONLCEGOCM BMNJICJIDIA = POONLCEGOCM.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private static void ECCLFKPKFAL(NDJKPGPHDPI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private static void FCBANNDHAJM(NDJKPGPHDPI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public PFJBODGOGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JJFNIGKKJFD
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x35E0EC0", Offset = "0x35DFAC0", VA = "0x1835E0EC0")]
	public static DABKEOMEIOA EFHFPJLEEJK(this DADKCOOMCAC EMGBIPOKPBC, KFMKFJINGPH AAEPEKAJNKI, KLHKIJHKJFB IBFKFNLEDKN)
	{
		return default(DABKEOMEIOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x35E1000", Offset = "0x35DFC00", VA = "0x1835E1000")]
	public static LNHMFCPBDMC FHEDOIMEBMO(this DADKCOOMCAC EMGBIPOKPBC)
	{
		return default(LNHMFCPBDMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x35E1240", Offset = "0x35DFE40", VA = "0x1835E1240")]
	public static CGECBEAFDFK OCFNCIECCMF(this DADKCOOMCAC EMGBIPOKPBC, Entity BODOHICDFAL)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x35E12F0", Offset = "0x35DFEF0", VA = "0x1835E12F0")]
	public static CGECBEAFDFK OCFNCIECCMF(this DADKCOOMCAC EMGBIPOKPBC, KFMKFJINGPH AAEPEKAJNKI)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x35E1120", Offset = "0x35DFD20", VA = "0x1835E1120")]
	public static KFMKFJINGPH KOMMHBLAJKC(this DADKCOOMCAC EMGBIPOKPBC, CGECBEAFDFK HGAMKJKNDDL)
	{
		return default(KFMKFJINGPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum POONLCEGOCM
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class MJEMKOIGOJL<T> : global::GCJJALLACMJ<T>, global::BOGNFFDCMBC<KFMKFJINGPH, T>, global::EGPFOCNAHLG<KFMKFJINGPH>, CAOLLMGGINC, IDisposable, MAKJLBJHHHB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::EGPFOCNAHLG<Entity> FCPNPIIHNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate CNMDDANPPHJ;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string JBHHONFDCDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x39D6150", Offset = "0x39D4D50", VA = "0x1839D6150", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type JDLMMGPDBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x39CEEB0", Offset = "0x39CDAB0", VA = "0x1839CEEB0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HHFMDBGAKBP GBDDNDOCCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x39D82D0", Offset = "0x39D6ED0", VA = "0x1839D82D0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DJOCBDPOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x39CF570", Offset = "0x39CE170", VA = "0x1839CF570", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EJCDMKIGFAE GDPPPHCHFHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x39D33C0", Offset = "0x39D1FC0", VA = "0x1839D33C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AD57F0", Offset = "0x2AD43F0", VA = "0x182AD57F0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x39D4900", Offset = "0x39D3500", VA = "0x1839D4900", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::GHJCHPNLLMO<KFMKFJINGPH> OBFHJEIBPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x39D07F0", Offset = "0x39CF3F0", VA = "0x1839D07F0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x39D0320", Offset = "0x39CEF20", VA = "0x1839D0320", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x304D8E0", Offset = "0x304C4E0", VA = "0x18304D8E0")]
	public MJEMKOIGOJL(global::EGPFOCNAHLG<Entity> FCPNPIIHNJJ, BKJKHIFBPPC MKDFNPEFILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x39D0E80", Offset = "0x39CFA80", VA = "0x1839D0E80")]
	private Entity ENBHIILOAJE(KFMKFJINGPH AAEPEKAJNKI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x39D0E70", Offset = "0x39CFA70", VA = "0x1839D0E70")]
	private KFMKFJINGPH ENBHIILOAJE(Entity BODOHICDFAL)
	{
		return default(KFMKFJINGPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x39D1D60", Offset = "0x39D0960", VA = "0x1839D1D60", Slot = "4")]
	public T FABELHKIKFB(KFMKFJINGPH AAEPEKAJNKI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x39CF920", Offset = "0x39CE520", VA = "0x1839CF920")]
	public bool CKBKODEFPCJ(KFMKFJINGPH AAEPEKAJNKI, in T KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x39D8A80", Offset = "0x39D7680", VA = "0x1839D8A80")]
	public bool NBKJFCHIAGB(KFMKFJINGPH AAEPEKAJNKI, in T KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x39D8100", Offset = "0x39D6D00", VA = "0x1839D8100", Slot = "9")]
	public bool MKAKFEIOKNJ(KFMKFJINGPH AAEPEKAJNKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x39CF2E0", Offset = "0x39CDEE0", VA = "0x1839CF2E0", Slot = "26")]
	public object BOGKNCKKKJD(KFMKFJINGPH AAEPEKAJNKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x39D2C80", Offset = "0x39D1880", VA = "0x1839D2C80")]
	public bool FCKGIGAEDMG(KFMKFJINGPH AAEPEKAJNKI, in object KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x39D1C10", Offset = "0x39D0810", VA = "0x1839D1C10")]
	public void FABELHKIKFB(KFMKFJINGPH AAEPEKAJNKI, in DADHEMOPEJD NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x39CF660", Offset = "0x39CE260", VA = "0x1839CF660")]
	public bool CKBKODEFPCJ(KFMKFJINGPH AAEPEKAJNKI, in ODIFAJLFLNC KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x39D8740", Offset = "0x39D7340", VA = "0x1839D8740")]
	public bool NBKJFCHIAGB(KFMKFJINGPH AAEPEKAJNKI, in ODIFAJLFLNC KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x304A120", Offset = "0x3048D20", VA = "0x18304A120", Slot = "22")]
	public void HNMKKLJOBAM(HAPMABPDHHK KCLMBFCDJGI, [Optional] object MAMKOIKAADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x39D5190", Offset = "0x39D3D90", VA = "0x1839D5190", Slot = "15")]
	public void HNMKKLJOBAM(KFMKFJINGPH NANBEBOOGPM, KPFEFKKAOKL KCLMBFCDJGI, object MAMKOIKAADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x39D7BA0", Offset = "0x39D67A0", VA = "0x1839D7BA0", Slot = "14")]
	public bool KPPKKNOGHLH(KFMKFJINGPH AOGGOAKADIJ, KFMKFJINGPH CJMCKLJFKJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A365D0", Offset = "0x2A351D0", VA = "0x182A365D0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x39D9CA0", Offset = "0x39D88A0", VA = "0x1839D9CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x39CF210", Offset = "0x39CDE10", VA = "0x1839CF210")]
	public string BECKMGCJPJN(in ODIFAJLFLNC FNNPKPIMIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x39D9610", Offset = "0x39D8210", VA = "0x1839D9610")]
	private void OJJGAMANEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x39D5B80", Offset = "0x39D4780", VA = "0x1839D5B80")]
	private void JLILHDIEJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x39D61A0", Offset = "0x39D4DA0", VA = "0x1839D61A0")]
	private void KODANHPELKD(Entity BODOHICDFAL, in ODIFAJLFLNC CCOPHGFCELI, in ODIFAJLFLNC KCIMCONOGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x39D0AB0", Offset = "0x39CF6B0", VA = "0x1839D0AB0")]
	private void ELPMELABKDG(Entity BODOHICDFAL, in ODIFAJLFLNC CCOPHGFCELI, in ODIFAJLFLNC KCIMCONOGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x39D37D0", Offset = "0x39D23D0", VA = "0x1839D37D0")]
	[Conditional("DEBUG_BUILD")]
	private static void FOFJGJLNLCF(Entity BODOHICDFAL, KFMKFJINGPH AAEPEKAJNKI, string DKMDGLKPPGF, string IOLLNAPHBNK, [CallerMemberName] string HMIBDBAIIKD = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D976D0", Offset = "0x2D962D0", VA = "0x182D976D0", Slot = "5")]
	private bool MFAIFIPLPLO(KFMKFJINGPH NANBEBOOGPM, in T KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3705480", Offset = "0x3704080", VA = "0x183705480", Slot = "6")]
	private bool EIEDFIEJAME(KFMKFJINGPH NANBEBOOGPM, in T KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x30F5EB0", Offset = "0x30F4AB0", VA = "0x1830F5EB0", Slot = "10")]
	private bool IPMMJMMKMPH(KFMKFJINGPH NANBEBOOGPM, in object KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x39CF2B0", Offset = "0x39CDEB0", VA = "0x1839CF2B0", Slot = "11")]
	private void BEPGDIDGKOH(KFMKFJINGPH NANBEBOOGPM, in DADHEMOPEJD NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x39D49F0", Offset = "0x39D35F0", VA = "0x1839D49F0", Slot = "12")]
	private bool GECIMOIKPBB(KFMKFJINGPH NANBEBOOGPM, in ODIFAJLFLNC KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x39D4A20", Offset = "0x39D3620", VA = "0x1839D4A20", Slot = "13")]
	private bool HDEJFBMLBND(KFMKFJINGPH NANBEBOOGPM, in ODIFAJLFLNC KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x304A2F0", Offset = "0x3048EF0", VA = "0x18304A2F0", Slot = "16")]
	private string KLMIDIMNGBO(in ODIFAJLFLNC NENFOEKGNGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class ABMGDPOGEKP<T> : global::CEDJPBFOOFP<T>, global::BOGNFFDCMBC<CGECBEAFDFK, T>, global::EGPFOCNAHLG<CGECBEAFDFK>, CAOLLMGGINC, IDisposable, FNAFHEBBEAB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly global::EGPFOCNAHLG<Entity> FCPNPIIHNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Delegate CNMDDANPPHJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string JBHHONFDCDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4ADB0D0", Offset = "0x4AD9CD0", VA = "0x184ADB0D0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Type JDLMMGPDBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4AD39F0", Offset = "0x4AD25F0", VA = "0x184AD39F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HHFMDBGAKBP GBDDNDOCCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4ADDF60", Offset = "0x4ADCB60", VA = "0x184ADDF60", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int DJOCBDPOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4AD3E80", Offset = "0x4AD2A80", VA = "0x184AD3E80", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public EJCDMKIGFAE GDPPPHCHFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4AD8FF0", Offset = "0x4AD7BF0", VA = "0x184AD8FF0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4ADD910", Offset = "0x4ADC510", VA = "0x184ADD910", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4AD90E0", Offset = "0x4AD7CE0", VA = "0x184AD90E0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::GHJCHPNLLMO<CGECBEAFDFK> OBFHJEIBPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4AD5AE0", Offset = "0x4AD46E0", VA = "0x184AD5AE0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4AD5610", Offset = "0x4AD4210", VA = "0x184AD5610", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x304D8E0", Offset = "0x304C4E0", VA = "0x18304D8E0")]
	public ABMGDPOGEKP(global::EGPFOCNAHLG<Entity> FCPNPIIHNJJ, BKJKHIFBPPC MKDFNPEFILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1A02050", Offset = "0x1A00C50", VA = "0x181A02050")]
	private Entity ENBHIILOAJE(CGECBEAFDFK HGAMKJKNDDL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3048440", Offset = "0x3047040", VA = "0x183048440")]
	private CGECBEAFDFK ENBHIILOAJE(Entity BODOHICDFAL)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4AD7190", Offset = "0x4AD5D90", VA = "0x184AD7190", Slot = "4")]
	public T FABELHKIKFB(CGECBEAFDFK HGAMKJKNDDL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4AD4A00", Offset = "0x4AD3600", VA = "0x184AD4A00")]
	public bool CKBKODEFPCJ(CGECBEAFDFK HGAMKJKNDDL, in T KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4ADE260", Offset = "0x4ADCE60", VA = "0x184ADE260")]
	public bool NBKJFCHIAGB(CGECBEAFDFK HGAMKJKNDDL, in T KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4ADDD80", Offset = "0x4ADC980", VA = "0x184ADDD80", Slot = "9")]
	public bool MKAKFEIOKNJ(CGECBEAFDFK HGAMKJKNDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4AD3BA0", Offset = "0x4AD27A0", VA = "0x184AD3BA0", Slot = "26")]
	public object BOGKNCKKKJD(CGECBEAFDFK HGAMKJKNDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8C50", Offset = "0x4AD7850", VA = "0x184AD8C50")]
	public bool FCKGIGAEDMG(CGECBEAFDFK HGAMKJKNDDL, in object KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4AD6970", Offset = "0x4AD5570", VA = "0x184AD6970")]
	public void FABELHKIKFB(CGECBEAFDFK HGAMKJKNDDL, in DADHEMOPEJD NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4AD41D0", Offset = "0x4AD2DD0", VA = "0x184AD41D0")]
	public bool CKBKODEFPCJ(CGECBEAFDFK HGAMKJKNDDL, in ODIFAJLFLNC KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4ADE5C0", Offset = "0x4ADD1C0", VA = "0x184ADE5C0")]
	public bool NBKJFCHIAGB(CGECBEAFDFK HGAMKJKNDDL, in ODIFAJLFLNC KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x304A120", Offset = "0x3048D20", VA = "0x18304A120", Slot = "22")]
	public void HNMKKLJOBAM(HAPMABPDHHK KCLMBFCDJGI, [Optional] object MAMKOIKAADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4AD9660", Offset = "0x4AD8260", VA = "0x184AD9660", Slot = "15")]
	public void HNMKKLJOBAM(CGECBEAFDFK NANBEBOOGPM, KPFEFKKAOKL KCLMBFCDJGI, object MAMKOIKAADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4ADD520", Offset = "0x4ADC120", VA = "0x184ADD520", Slot = "14")]
	public bool KPPKKNOGHLH(CGECBEAFDFK AOGGOAKADIJ, CGECBEAFDFK CJMCKLJFKJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4ADF350", Offset = "0x4ADDF50", VA = "0x184ADF350")]
	private void OJJGAMANEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4ADA4A0", Offset = "0x4AD90A0", VA = "0x184ADA4A0")]
	private void JLILHDIEJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4ADB600", Offset = "0x4ADA200", VA = "0x184ADB600")]
	private void KODANHPELKD(Entity BODOHICDFAL, in ODIFAJLFLNC CCOPHGFCELI, in ODIFAJLFLNC KCIMCONOGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4AD5DA0", Offset = "0x4AD49A0", VA = "0x184AD5DA0")]
	private void ELPMELABKDG(Entity BODOHICDFAL, in ODIFAJLFLNC CCOPHGFCELI, in ODIFAJLFLNC KCIMCONOGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3048150", Offset = "0x3046D50", VA = "0x183048150", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0750", Offset = "0x4ADF350", VA = "0x184AE0750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x39CF210", Offset = "0x39CDE10", VA = "0x1839CF210")]
	public string BECKMGCJPJN(in ODIFAJLFLNC FNNPKPIMIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3049BE0", Offset = "0x30487E0", VA = "0x183049BE0", Slot = "5")]
	private bool ONGAELJJKMD(CGECBEAFDFK NANBEBOOGPM, in T KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3049C20", Offset = "0x3048820", VA = "0x183049C20", Slot = "6")]
	private bool HDEPMNPGKGC(CGECBEAFDFK NANBEBOOGPM, in T KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3048110", Offset = "0x3046D10", VA = "0x183048110", Slot = "10")]
	private bool DPFIBBJMPNB(CGECBEAFDFK NANBEBOOGPM, in object KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x304CD60", Offset = "0x304B960", VA = "0x18304CD60", Slot = "11")]
	private void NOHBDGABFOO(CGECBEAFDFK NANBEBOOGPM, in DADHEMOPEJD NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x304C000", Offset = "0x304AC00", VA = "0x18304C000", Slot = "12")]
	private bool LHEDJLGJMMN(CGECBEAFDFK NANBEBOOGPM, in ODIFAJLFLNC KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3047070", Offset = "0x3045C70", VA = "0x183047070", Slot = "13")]
	private bool BNAJMKLPPMH(CGECBEAFDFK NANBEBOOGPM, in ODIFAJLFLNC KCIMCONOGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x304A2F0", Offset = "0x3048EF0", VA = "0x18304A2F0", Slot = "16")]
	private string IFIFKMANLHO(in ODIFAJLFLNC NENFOEKGNGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OLNIAFCMFJG : IDisposable, HFMHDJKBJLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> KJHEIHJFOOP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> HOAGLADAPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C90", Offset = "0x6D8890", VA = "0x1806D9C90", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1362210", Offset = "0x1360E10", VA = "0x181362210")]
	public OLNIAFCMFJG(NativeArray<EntityRemapUtility.EntityRemapInfo> KJHEIHJFOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x308BD40", Offset = "0x308A940", VA = "0x18308BD40", Slot = "6")]
	public CGECBEAFDFK KLIGGLODMHE(CGECBEAFDFK HGAMKJKNDDL)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x308BD90", Offset = "0x308A990", VA = "0x18308BD90", Slot = "7")]
	public Entity KLIGGLODMHE(Entity BODOHICDFAL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x308BCA0", Offset = "0x308A8A0", VA = "0x18308BCA0", Slot = "8")]
	public IEnumerable<CGECBEAFDFK> KLIGGLODMHE(IEnumerable<CGECBEAFDFK> FOEOIMMDDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x308BC40", Offset = "0x308A840", VA = "0x18308BC40", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[GKALNADHNEP(DAHLALKJFLL.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly FCNKBCOKGMK KIELCGPFBCM;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int DDDHOIIBBIP;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static HFMHDJKBJLI ACLHMBHBJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool KKKOFIEELBD;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> HOAGLADAPDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x3333F50", Offset = "0x3332B50", VA = "0x183333F50")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static bool OACPAKOIBBB
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3333DB0", Offset = "0x33329B0", VA = "0x183333DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3333D50", Offset = "0x3332950", VA = "0x183333D50")]
		public static SerializationRemapScope BBPKOBOLAOO()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3334380", Offset = "0x3332F80", VA = "0x183334380")]
		public SerializationRemapScope(HFMHDJKBJLI MMEFGLKPDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3333E40", Offset = "0x3332A40", VA = "0x183333E40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3334060", Offset = "0x3332C60", VA = "0x183334060")]
		public static CGECBEAFDFK KLIGGLODMHE(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x33341C0", Offset = "0x3332DC0", VA = "0x1833341C0")]
		public static Entity KLIGGLODMHE(Entity BODOHICDFAL)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[HJBMNHLGPOF(typeof(CKJOAENOAJD), new string[] { "Editor" })]
[IEBMFBANONN(EBEBOFNGILK.Application)]
public sealed class CKJOAENOAJD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void JDNAMCJJFLP(KFMKFJINGPH EKECHFNHCFB, IGIIAIKJJLE GAGLKGONONJ, bool LLBLAMPDMIL);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void HENENODNLJP(KFMKFJINGPH EKECHFNHCFB, bool LLBLAMPDMIL);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void AOHNCILIMFA(KFMKFJINGPH EKECHFNHCFB, FOCFMDNOICJ FCPNPIIHNJJ, in ODIFAJLFLNC NENFOEKGNGK, bool LLBLAMPDMIL);

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JDNAMCJJFLP HBDNCDDLGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x31A1E40", Offset = "0x31A0A40", VA = "0x1831A1E40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x31A1DA0", Offset = "0x31A09A0", VA = "0x1831A1DA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event HENENODNLJP EAFBOMFJFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x31A1EE0", Offset = "0x31A0AE0", VA = "0x1831A1EE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x31A2070", Offset = "0x31A0C70", VA = "0x1831A2070")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event AOHNCILIMFA BAIAOHCDKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x31A2130", Offset = "0x31A0D30", VA = "0x1831A2130")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x31A1FD0", Offset = "0x31A0BD0", VA = "0x1831A1FD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x31A1F80", Offset = "0x31A0B80", VA = "0x1831A1F80")]
	[Conditional("UNITY_EDITOR")]
	public void HODEHDKMFIB(KFMKFJINGPH EKECHFNHCFB, in IGIIAIKJJLE GAGLKGONONJ, bool LLBLAMPDMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x31A2110", Offset = "0x31A0D10", VA = "0x1831A2110")]
	[Conditional("UNITY_EDITOR")]
	public void PJJDOCKGEDK(KFMKFJINGPH EKECHFNHCFB, bool LLBLAMPDMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x31A1FA0", Offset = "0x31A0BA0", VA = "0x1831A1FA0")]
	[Conditional("UNITY_EDITOR")]
	public void ILPPCCMOCAK(KFMKFJINGPH EKECHFNHCFB, FOCFMDNOICJ FCPNPIIHNJJ, in ODIFAJLFLNC NENFOEKGNGK, bool LLBLAMPDMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public CKJOAENOAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[HJBMNHLGPOF(typeof(IABLEKNFLJJ), new string[] { "Editor" })]
[IEBMFBANONN(EBEBOFNGILK.Application)]
public sealed class IABLEKNFLJJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void DAAAODCPGPI(KFMKFJINGPH AAEPEKAJNKI, IGIIAIKJJLE GAGLKGONONJ, bool LLBLAMPDMIL);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void JCECMGLJDOB(KFMKFJINGPH AAEPEKAJNKI, bool LLBLAMPDMIL);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void MFIACGGCOGE(KFMKFJINGPH AAEPEKAJNKI, FOCFMDNOICJ FCPNPIIHNJJ, in ODIFAJLFLNC NENFOEKGNGK, bool LLBLAMPDMIL, bool PJBGKCGJPBJ);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void BMCGLKKKOLN(KFMKFJINGPH AAEPEKAJNKI, FOCFMDNOICJ FCPNPIIHNJJ, in ODIFAJLFLNC CCOPHGFCELI, in ODIFAJLFLNC KCIMCONOGCA);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void LGEJJBELFIK(GPBBJELIBKL NANBEBOOGPM, ReadOnlyMemory<byte> ADEMJHPFLJL);

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event DAAAODCPGPI HBDNCDDLGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x35DC410", Offset = "0x35DB010", VA = "0x1835DC410")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x35DC370", Offset = "0x35DAF70", VA = "0x1835DC370")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event JCECMGLJDOB EAFBOMFJFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x35DC550", Offset = "0x35DB150", VA = "0x1835DC550")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x35DCD50", Offset = "0x35DB950", VA = "0x1835DCD50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event DAAAODCPGPI KNOMHCEMPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x35DC9D0", Offset = "0x35DB5D0", VA = "0x1835DC9D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x35DCCB0", Offset = "0x35DB8B0", VA = "0x1835DCCB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event JCECMGLJDOB CHDDMDJCEAE
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x35DC5F0", Offset = "0x35DB1F0", VA = "0x1835DC5F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x35DC4B0", Offset = "0x35DB0B0", VA = "0x1835DC4B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event MFIACGGCOGE BAIAOHCDKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x35DCDF0", Offset = "0x35DB9F0", VA = "0x1835DCDF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x35DC8E0", Offset = "0x35DB4E0", VA = "0x1835DC8E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event BMCGLKKKOLN PKDHOLIDBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x35DCA70", Offset = "0x35DB670", VA = "0x1835DCA70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x35DC6D0", Offset = "0x35DB2D0", VA = "0x1835DC6D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<string, object> PKKDHIOHPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x35DCC10", Offset = "0x35DB810", VA = "0x1835DCC10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x35DC7A0", Offset = "0x35DB3A0", VA = "0x1835DC7A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event LGEJJBELFIK NFABOHIJMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x35DCB70", Offset = "0x35DB770", VA = "0x1835DCB70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x35DC840", Offset = "0x35DB440", VA = "0x1835DC840")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x35DCB40", Offset = "0x35DB740", VA = "0x1835DCB40")]
	[Conditional("UNITY_EDITOR")]
	public void OLLINGEEGJJ(KFMKFJINGPH AAEPEKAJNKI, in IGIIAIKJJLE GAGLKGONONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x35DC690", Offset = "0x35DB290", VA = "0x1835DC690")]
	[Conditional("UNITY_EDITOR")]
	public void GLANKOPGMOM(KFMKFJINGPH AAEPEKAJNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x35DC770", Offset = "0x35DB370", VA = "0x1835DC770")]
	[Conditional("UNITY_EDITOR")]
	public void JJNKBKNLJKL(KFMKFJINGPH AAEPEKAJNKI, in IGIIAIKJJLE GAGLKGONONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x35DC6B0", Offset = "0x35DB2B0", VA = "0x1835DC6B0")]
	[Conditional("UNITY_EDITOR")]
	public void IHGAFLNKFNE(KFMKFJINGPH AAEPEKAJNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x35DC9A0", Offset = "0x35DB5A0", VA = "0x1835DC9A0")]
	[Conditional("UNITY_EDITOR")]
	public void LANCBKOAMLC(KFMKFJINGPH AAEPEKAJNKI, FOCFMDNOICJ FCPNPIIHNJJ, in ODIFAJLFLNC NENFOEKGNGK, bool PJBGKCGJPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x35DC980", Offset = "0x35DB580", VA = "0x1835DC980")]
	[Conditional("UNITY_EDITOR")]
	public void LAJOKCCIAPP(KFMKFJINGPH AAEPEKAJNKI, FOCFMDNOICJ FCPNPIIHNJJ, in ODIFAJLFLNC CCOPHGFCELI, in ODIFAJLFLNC KCIMCONOGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x35DC310", Offset = "0x35DAF10", VA = "0x1835DC310")]
	[Conditional("UNITY_EDITOR")]
	public void ANLABLJKINB(string MKPDFAEIFFO, object ADEMJHPFLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x35DCB10", Offset = "0x35DB710", VA = "0x1835DCB10")]
	[Conditional("UNITY_EDITOR")]
	public void NPJEOLPBBCC(GPBBJELIBKL NANBEBOOGPM, ReadOnlyMemory<byte> ADEMJHPFLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public IABLEKNFLJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HJBMNHLGPOF(typeof(GFEOCDIGBNL), new string[] { })]
public class BBEOOGFNPLG : GFEOCDIGBNL
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x319CC90", Offset = "0x319B890", VA = "0x18319CC90", Slot = "5")]
	public void DEOMBKCGIBE(object DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x319CD70", Offset = "0x319B970", VA = "0x18319CD70", Slot = "6")]
	public void FPMEBJOKELF(object DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x319CE50", Offset = "0x319BA50", VA = "0x18319CE50", Slot = "7")]
	public void IDEOPHMGJLJ(object DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x319CB80", Offset = "0x319B780", VA = "0x18319CB80", Slot = "4")]
	public IDisposable AGJBNJLLEIB(object DPNJMDFICMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public BBEOOGFNPLG()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[HJBMNHLGPOF(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	[GKALNADHNEP(DAHLALKJFLL.Serialization)]
	internal class BulkInstantiateSceneObjectService : BLCFKNFGJJJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string DAKGHLEBNMC = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[NNMLOJPMNKB]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[NNMLOJPMNKB]
		private HOONHJLELFO GMKNLKMJIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[NNMLOJPMNKB]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[NNMLOJPMNKB]
		private IHMCHCLHMKB OBDKJOBOIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private EntityQuery NBOCKBFOLOF;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private EntityManager CNOHAEKAHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x319E6C0", Offset = "0x319D2C0", VA = "0x18319E6C0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x319E8F0", Offset = "0x319D4F0", VA = "0x18319E8F0", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x319E8E0", Offset = "0x319D4E0", VA = "0x18319E8E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x319F950", Offset = "0x319E550", VA = "0x18319F950")]
		public bool MMLFCBFHEON(IEnumerable<OHBEHHAFFLC> GCLNBMJNKIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x319F670", Offset = "0x319E270", VA = "0x18319F670")]
		public static bool JLCKKEHDIOP(OHBEHHAFFLC PJCBPMCBLEN, out KFMKFJINGPH AAEPEKAJNKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x319EA70", Offset = "0x319D670", VA = "0x18319EA70")]
		private void FLMPKLGAPBJ(Dictionary<KFMKFJINGPH, OHBEHHAFFLC> FDJAPCCPCPN, IEnumerable<OHBEHHAFFLC> GCLNBMJNKIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x319DBF0", Offset = "0x319C7F0", VA = "0x18319DBF0")]
		private void AECJKBDHJOL(Dictionary<KFMKFJINGPH, OHBEHHAFFLC> FDJAPCCPCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x319F1F0", Offset = "0x319DDF0", VA = "0x18319F1F0")]
		private void IPGGMIICNBJ(Dictionary<KFMKFJINGPH, OHBEHHAFFLC> FDJAPCCPCPN, KFMKFJINGPH AAEPEKAJNKI, string MKPDFAEIFFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x319EDF0", Offset = "0x319D9F0", VA = "0x18319EDF0")]
		private void GHDEIIKHNPO(Dictionary<KFMKFJINGPH, OHBEHHAFFLC> FDJAPCCPCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x319DE20", Offset = "0x319CA20", VA = "0x18319DE20")]
		private void BIJIFGCBMPN(Dictionary<KFMKFJINGPH, OHBEHHAFFLC> FDJAPCCPCPN, List<OHBEHHAFFLC> MAOLCKOBLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x319E710", Offset = "0x319D310", VA = "0x18319E710")]
		private NativeList<KFMKFJINGPH> CJOKKFIPEFL(Dictionary<KFMKFJINGPH, OHBEHHAFFLC> FDJAPCCPCPN)
		{
			return default(NativeList<KFMKFJINGPH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x319F780", Offset = "0x319E380", VA = "0x18319F780")]
		private NativeArray<Entity> MDMGMEDNBBG(NativeList<KFMKFJINGPH> DCCMIEBFMJG)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x319F150", Offset = "0x319DD50", VA = "0x18319F150")]
		private static void HAOIEHIGIFE(Dictionary<KFMKFJINGPH, OHBEHHAFFLC> FDJAPCCPCPN, KFMKFJINGPH AAEPEKAJNKI, OHBEHHAFFLC PJCBPMCBLEN, string MKPDFAEIFFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[IEBMFBANONN(EBEBOFNGILK.Application)]
	[GKALNADHNEP(DAHLALKJFLL.Serialization)]
	[HJBMNHLGPOF(typeof(DebugWorldsService), new string[] { })]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal static bool CBCJINGKOAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x31B2370", Offset = "0x31B0F70", VA = "0x1831B2370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x31B2330", Offset = "0x31B0F30", VA = "0x1831B2330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal static bool EAHFIKFNPFK
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x31B23F0", Offset = "0x31B0FF0", VA = "0x1831B23F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x31B23B0", Offset = "0x31B0FB0", VA = "0x1831B23B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public void HEAAEKLKDNH(string MKPDFAEIFFO, EntityManager JOKFOKELNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public static void GGNFLDPHLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[HJBMNHLGPOF(typeof(FANFOMEKGMF), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.Application)]
internal class FANFOMEKGMF
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool CBCJINGKOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x711D10", Offset = "0x710910", VA = "0x180711D10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x711D30", Offset = "0x710930", VA = "0x180711D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool FJNAHEJEPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x711D20", Offset = "0x710920", VA = "0x180711D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x711D40", Offset = "0x710940", VA = "0x180711D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public FANFOMEKGMF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[BOFOPPKAPFG(typeof(SerializationService))]
	[HJBMNHLGPOF(typeof(ONMHIEOMAFC), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.Serialization)]
	internal class SerializationService : ONMHIEOMAFC, IDisposable, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly FCNKBCOKGMK CKDMHIIFFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[NNMLOJPMNKB]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[NNMLOJPMNKB]
		private HLPCBJEKDII AKFDIHCNLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[NNMLOJPMNKB]
		private FANFOMEKGMF EAIGKMCMNFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private PGLDJELHFCF BKEMBKPNFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private KNMBPCAIHOP GOJGMOFDEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private SerializationRemapScope PIBIFPAGGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool? GPCMOLGNBJA;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool DFBBHKOECPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3335300", Offset = "0x3333F00", VA = "0x183335300", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3335970", Offset = "0x3334570", VA = "0x183335970", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool JDNJPOAFPNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8D9480", Offset = "0x8D8080", VA = "0x1808D9480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C10", Offset = "0x8D8810", VA = "0x1808D9C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public KNMBPCAIHOP KILOANPBNIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3335310", Offset = "0x3333F10", VA = "0x183335310", Slot = "16")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3334CA0", Offset = "0x33338A0", VA = "0x183334CA0", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3335FE0", Offset = "0x3334BE0", VA = "0x183335FE0")]
		public static bool MPPNAACIKBL(ByteString PGJDMPEOAIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x766940", Offset = "0x765540", VA = "0x180766940")]
		public void MEHPKNNMJDF(PGLDJELHFCF KCHOPLNIILF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3335A10", Offset = "0x3334610", VA = "0x183335A10", Slot = "5")]
		public void KMKGEIMIBEL(bool PJNMHBFDAHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3335980", Offset = "0x3334580", VA = "0x183335980", Slot = "6")]
		public Task IOHGDICJCGN(bool PJNMHBFDAHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x33347C0", Offset = "0x33333C0", VA = "0x1833347C0", Slot = "7")]
		public ByteString ANBECOLJJND(out IDisposable PIBIFPAGGCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x33345E0", Offset = "0x33331E0", VA = "0x1833345E0", Slot = "19")]
		public ByteString ANBECOLJJND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3336310", Offset = "0x3334F10", VA = "0x183336310", Slot = "9")]
		public bool PPPEOPKFADK(ByteString PGGKAMACIAM, PKPEMMPMLNH BMNJICJIDIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3334CB0", Offset = "0x33338B0", VA = "0x183334CB0")]
		private bool EAHLIABJKJL(ByteString PGGKAMACIAM, PKPEMMPMLNH BMNJICJIDIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3336140", Offset = "0x3334D40", VA = "0x183336140", Slot = "8")]
		public void OIPKFECHCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3334A30", Offset = "0x3333630", VA = "0x183334A30", Slot = "10")]
		public bool DPGFLFNLDNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3335D10", Offset = "0x3334910", VA = "0x183335D10", Slot = "11")]
		public bool MMLFCBFHEON(IEnumerable<OHBEHHAFFLC> GOMDFIBJCOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x33348A0", Offset = "0x33334A0", VA = "0x1833348A0")]
		public bool CAFJDEEOPOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3335AE0", Offset = "0x33346E0", VA = "0x183335AE0", Slot = "12")]
		public bool LIJFJNNBPJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x33354C0", Offset = "0x33340C0", VA = "0x1833354C0")]
		public void GEOIDIANKEM(KNMBPCAIHOP.IJPFAAALKFI.PMOJCACECNN PENAEKEAGKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3334FD0", Offset = "0x3333BD0", VA = "0x183334FD0")]
		private bool EKFHBEFDPAF(ByteString PGGKAMACIAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3335920", Offset = "0x3334520", VA = "0x183335920")]
		private void GJEKPACDGND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3335F80", Offset = "0x3334B80", VA = "0x183335F80")]
		private ByteString MOPFKIIKKHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x33353B0", Offset = "0x3333FB0", VA = "0x1833353B0")]
		private ByteString FPABIIIDOOM(ByteString PGJDMPEOAIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3335260", Offset = "0x3333E60", VA = "0x183335260")]
		private KNMBPCAIHOP.IJPFAAALKFI.PMOJCACECNN FACLINBLNHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3336110", Offset = "0x3334D10", VA = "0x183336110")]
		private void OGLDIJJCPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3334410", Offset = "0x3333010", VA = "0x183334410", Slot = "13")]
		public bool AENALMHIDCK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3334980", Offset = "0x3333580", VA = "0x183334980", Slot = "14")]
		public void DEFEDJOODIB(bool BAGBIJPDAHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3335750", Offset = "0x3334350", VA = "0x183335750")]
		private void GGNFLDPHLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[HJBMNHLGPOF(typeof(NFBIPKALIAH), new string[] { })]
[BOFOPPKAPFG(typeof(HLPCBJEKDII))]
internal class HLPCBJEKDII : NFBIPKALIAH
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action JAOJCFOKLBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x35D9C50", Offset = "0x35D8850", VA = "0x1835D9C50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x35D9980", Offset = "0x35D8580", VA = "0x1835D9980", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HFMHDJKBJLI> GHDHMELJNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x35D98E0", Offset = "0x35D84E0", VA = "0x1835D98E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x35D9BB0", Offset = "0x35D87B0", VA = "0x1835D9BB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action PCHJIANIEIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x35D97A0", Offset = "0x35D83A0", VA = "0x1835D97A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x35D9A20", Offset = "0x35D8620", VA = "0x1835D9A20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action ILPFIGCMDBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x35D9DE0", Offset = "0x35D89E0", VA = "0x1835D9DE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x35D9D40", Offset = "0x35D8940", VA = "0x1835D9D40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<HFMHDJKBJLI> BBDBAAJMCLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x35D9840", Offset = "0x35D8440", VA = "0x1835D9840", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x35D9B10", Offset = "0x35D8710", VA = "0x1835D9B10", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x15E2E00", Offset = "0x15E1A00", VA = "0x1815E2E00")]
	public void OIPKFECHCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x185F540", Offset = "0x185E140", VA = "0x18185F540")]
	public void CKMHBPGFPJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x198DA70", Offset = "0x198C670", VA = "0x18198DA70")]
	public void NNMHJEFNANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x35D9AC0", Offset = "0x35D86C0", VA = "0x1835D9AC0")]
	public void GCPEEGBGKHO(HFMHDJKBJLI ACLHMBHBJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x35D9CF0", Offset = "0x35D88F0", VA = "0x1835D9CF0")]
	public void MKECMLGNMAI(HFMHDJKBJLI ACLHMBHBJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public HLPCBJEKDII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[HJBMNHLGPOF(typeof(ALKOEFHOGFF), new string[] { })]
public class AGHBPGFOMJH : ALKOEFHOGFF, CLILAOIFPFK, AHBNMIIEDML, BLCFKNFGJJJ, JGJNINBGNFN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EntityHierarchyParents IGDNBGHNGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private JNBNBKGEFGN ACKCFCFAEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ObjectEmbodimentService NIENOEJANLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::CEDJPBFOOFP<CGECBEAFDFK> GJANBAOLOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x698150", Offset = "0x696D50", VA = "0x180698150", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6983E0", Offset = "0x696FE0", VA = "0x1806983E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EntityManager CNOHAEKAHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3199470", Offset = "0x3198070", VA = "0x183199470")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7EF0B0", Offset = "0x7EDCB0", VA = "0x1807EF0B0", Slot = "14")]
	public void PHKHGJFAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x31998E0", Offset = "0x31984E0", VA = "0x1831998E0", Slot = "15")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x31994C0", Offset = "0x31980C0", VA = "0x1831994C0", Slot = "16")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0xB52010", Offset = "0xB50C10", VA = "0x180B52010", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x308DF70", Offset = "0x308CB70", VA = "0x18308DF70")]
	private CGECBEAFDFK PDMPJPKNAPJ(Entity BODOHICDFAL)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x31995B0", Offset = "0x31981B0", VA = "0x1831995B0", Slot = "4")]
	public CGECBEAFDFK CNPKLEJKNMM(CGECBEAFDFK HGAMKJKNDDL)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3199EE0", Offset = "0x3198AE0", VA = "0x183199EE0", Slot = "19")]
	public void PLAGPOEAHMG(ref List<CGECBEAFDFK> HFEFAFDMCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x319A100", Offset = "0x3198D00", VA = "0x18319A100", Slot = "20")]
	public IEnumerable<CGECBEAFDFK> PMEDJAOPCCA(CGECBEAFDFK HGAMKJKNDDL, bool DGGHOPFGFBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x31999B0", Offset = "0x31985B0", VA = "0x1831999B0", Slot = "21")]
	public CGECBEAFDFK FIGJBPANHLK(CGECBEAFDFK HGAMKJKNDDL, int KLEGICPDLIF)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3199350", Offset = "0x3197F50", VA = "0x183199350", Slot = "22")]
	public int BHGMGMPCAHN(CGECBEAFDFK HGAMKJKNDDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3199CA0", Offset = "0x31988A0", VA = "0x183199CA0", Slot = "8")]
	public int JBHPONJDOMF(CGECBEAFDFK HGAMKJKNDDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x3199AE0", Offset = "0x31986E0", VA = "0x183199AE0", Slot = "9")]
	public DLCEAGAIHLE HHPKBCLDIHJ(CGECBEAFDFK HGAMKJKNDDL)
	{
		return default(DLCEAGAIHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x31996E0", Offset = "0x31982E0", VA = "0x1831996E0", Slot = "23")]
	public bool DFEHPMKEKNJ(CGECBEAFDFK HGAMKJKNDDL, out DLCEAGAIHLE AHEPMGGHINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3199BD0", Offset = "0x31987D0", VA = "0x183199BD0", Slot = "24")]
	public IEnumerable<CGECBEAFDFK> IHCPDKHDGPA(CGECBEAFDFK HGAMKJKNDDL, bool DGGHOPFGFBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3199610", Offset = "0x3198210", VA = "0x183199610", Slot = "12")]
	public CGECBEAFDFK CPOPEGHBHBO(CGECBEAFDFK NOFIECLFCLK, CGECBEAFDFK EDMOBKKEKCA)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3199E10", Offset = "0x3198A10", VA = "0x183199E10", Slot = "13")]
	public bool OELKOOEENGO(CGECBEAFDFK NOFIECLFCLK, CGECBEAFDFK EDMOBKKEKCA, out CGECBEAFDFK OGFAOKKNMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3199DB0", Offset = "0x31989B0", VA = "0x183199DB0", Slot = "5")]
	public CGECBEAFDFK OBGHCIILFKA(CGECBEAFDFK HGAMKJKNDDL)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3199D80", Offset = "0x3198980", VA = "0x183199D80", Slot = "11")]
	public bool NOFNCJFGCLB(CGECBEAFDFK HGAMKJKNDDL, CGECBEAFDFK DGPJCMKHAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3199320", Offset = "0x3197F20", VA = "0x183199320", Slot = "25")]
	public bool ANAKHBDCABO(CGECBEAFDFK HGAMKJKNDDL, CGECBEAFDFK JAFNGMFCAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x3199AB0", Offset = "0x31986B0", VA = "0x183199AB0", Slot = "10")]
	public bool GFIOHCEGLHC(CGECBEAFDFK HGAMKJKNDDL, CGECBEAFDFK NOFIECLFCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x31998B0", Offset = "0x31984B0", VA = "0x1831998B0", Slot = "6")]
	public bool FANOFILKGIA(CGECBEAFDFK HGAMKJKNDDL, CGECBEAFDFK NIGFDFKEKGM, bool FOIBGKBOOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3199D50", Offset = "0x3198950", VA = "0x183199D50", Slot = "7")]
	public bool KOPFKOOKJCP(CGECBEAFDFK HGAMKJKNDDL, CGECBEAFDFK NIGFDFKEKGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public AGHBPGFOMJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
[HJBMNHLGPOF(typeof(OHCBPBOEABE), new string[] { })]
internal class OHCBPBOEABE : BLCFKNFGJJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[NNMLOJPMNKB]
	private IPPGPHBJPJM MBLNNIKAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<int, KFMIEMINHBG> FLHECBPDCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3089E60", Offset = "0x3088A60", VA = "0x183089E60", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3089D10", Offset = "0x3088910", VA = "0x183089D10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x308A000", Offset = "0x3088C00", VA = "0x18308A000")]
	public KFMIEMINHBG GBCOIKCMNBA(PCEOKBPAGGO DKMDGLKPPGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3089EB0", Offset = "0x3088AB0", VA = "0x183089EB0")]
	public KFMIEMINHBG GBCOIKCMNBA(FOCFMDNOICJ FHMECPEDGNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x308A210", Offset = "0x3088E10", VA = "0x18308A210")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x308A330", Offset = "0x3088F30", VA = "0x18308A330")]
	public OHCBPBOEABE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class KFMIEMINHBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<KCPJFHKGPHD> KLJDDOAOOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<EHEJDJANAMP> EHMAJALGMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<HACAPEBHNOF> IGOALINBHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<EHEJDJANAMP> OKOPAJDBHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NativeList<KCPJFHKGPHD> ECNIJGCNIIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C90", Offset = "0x6D8890", VA = "0x1806D9C90")]
		get
		{
			return default(NativeList<KCPJFHKGPHD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<EHEJDJANAMP> ALGIBMABHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x706ED0", Offset = "0x705AD0", VA = "0x180706ED0")]
		get
		{
			return default(NativeList<EHEJDJANAMP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<HACAPEBHNOF> AKFGNKICMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x994530", Offset = "0x993130", VA = "0x180994530")]
		get
		{
			return default(NativeList<HACAPEBHNOF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<EHEJDJANAMP> FJJJJFBIJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA70", Offset = "0x7F9670", VA = "0x1807FAA70")]
		get
		{
			return default(NativeList<EHEJDJANAMP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JobHandle IIOKGMMPMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x706DA0", Offset = "0x7059A0", VA = "0x180706DA0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x20BF020", Offset = "0x20BDC20", VA = "0x1820BF020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool EHAKBDFLKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x772830", Offset = "0x771430", VA = "0x180772830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool OMCBBNHKCKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x35E3B50", Offset = "0x35E2750", VA = "0x1835E3B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x35E3C00", Offset = "0x35E2800", VA = "0x1835E3C00")]
	public KFMIEMINHBG(Allocator JMMNDPMBMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x35E3AC0", Offset = "0x35E26C0", VA = "0x1835E3AC0")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x35E3990", Offset = "0x35E2590", VA = "0x1835E3990")]
	public void EKCDHDCHCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x35E3670", Offset = "0x35E2270", VA = "0x1835E3670")]
	public void AABPNGPFBPJ(Entity BODOHICDFAL, Entity FIFCKAAEEOG, Entity FJCPKFBPJEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[HJBMNHLGPOF(typeof(ONIAJDKOMKH), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
public class ONIAJDKOMKH : BLCFKNFGJJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[NNMLOJPMNKB]
	private SceneService HHAEJHNBEEM;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x308C380", Offset = "0x308AF80", VA = "0x18308C380", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x308C360", Offset = "0x308AF60", VA = "0x18308C360", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public ONIAJDKOMKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal abstract class LPJAPBDBBPJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private uint AIKHCLBDHAF;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract uint COOEICEDEJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xE49A20", Offset = "0xE48620", VA = "0x180E49A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x35E7B70", Offset = "0x35E6770", VA = "0x1835E7B70")]
	public KFMKFJINGPH BBMGFHCOHLB()
	{
		return default(KFMKFJINGPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x35E7BC0", Offset = "0x35E67C0", VA = "0x1835E7BC0")]
	public void GGJNAPLFEJF(KFMKFJINGPH AAEPEKAJNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x16DCEC0", Offset = "0x16DBAC0", VA = "0x1816DCEC0", Slot = "6")]
	public virtual void PACBOHNGOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	protected LPJAPBDBBPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
[HJBMNHLGPOF(typeof(EHNMCNDHHBO), new string[] { })]
internal sealed class EHNMCNDHHBO : LPJAPBDBBPJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[NNMLOJPMNKB]
	private OHGMKNKEOOJ OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private uint NKHNEPFILOP;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override uint COOEICEDEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6948E0", Offset = "0x6934E0", VA = "0x1806948E0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x31B48F0", Offset = "0x31B34F0", VA = "0x1831B48F0", Slot = "7")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x31B48A0", Offset = "0x31B34A0", VA = "0x1831B48A0")]
	private void EMBHJEDGDFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x31B4990", Offset = "0x31B3590", VA = "0x1831B4990", Slot = "6")]
	public override void PACBOHNGOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780")]
	public EHNMCNDHHBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[HJBMNHLGPOF(typeof(NBDICGGJILM), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
internal sealed class NBDICGGJILM : LPJAPBDBBPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override uint COOEICEDEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8D0", Offset = "0x6AC4D0", VA = "0x1806AD8D0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780")]
	public NBDICGGJILM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
[HJBMNHLGPOF(typeof(OAAGFCMFOON), new string[] { })]
internal sealed class OAAGFCMFOON : CLILAOIFPFK, AHBNMIIEDML, BLCFKNFGJJJ, JGJNINBGNFN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[NNMLOJPMNKB]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery FOOEKIIKOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery GMKCHAKAELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery NJKAEJOKNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery AFLGMFFDEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EntityQuery DAHKLPPLEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EntityQuery GIPLAMFOEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private EntityManager CNOHAEKAHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3085A70", Offset = "0x3084670", VA = "0x183085A70")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery CMMPBFKPDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x714C90", Offset = "0x713890", VA = "0x180714C90")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery IPFFJOLDGNA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E2D50", VA = "0x1806E4150")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery LAGGGJDODAM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6A2D90", Offset = "0x6A1990", VA = "0x1806A2D90")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery LDIIAHNNCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x706DA0", Offset = "0x7059A0", VA = "0x180706DA0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery NJIEJMHJKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x706E90", Offset = "0x705A90", VA = "0x180706E90")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery DFHHOFIDNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x30859F0", Offset = "0x30845F0", VA = "0x1830859F0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int MPILIMPBMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x30861F0", Offset = "0x3084DF0", VA = "0x1830861F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int IEAMDKJNKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3085FC0", Offset = "0x3084BC0", VA = "0x183085FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int ALFEGOICLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x30861D0", Offset = "0x3084DD0", VA = "0x1830861D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int CIGEHKBFDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3086050", Offset = "0x3084C50", VA = "0x183086050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int CBLDJJCOCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3086320", Offset = "0x3084F20", VA = "0x183086320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int ODOGCKFEDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3086030", Offset = "0x3084C30", VA = "0x183086030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "4")]
	public void PHKHGJFAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x3085FE0", Offset = "0x3084BE0", VA = "0x183085FE0", Slot = "5")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x3085AC0", Offset = "0x30846C0", VA = "0x183085AC0", Slot = "6")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x30862C0", Offset = "0x3084EC0", VA = "0x1830862C0")]
	private EntityQueryDesc PGDEMMFOMIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3085F60", Offset = "0x3084B60", VA = "0x183085F60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3086120", Offset = "0x3084D20", VA = "0x183086120")]
	public MNCKDPANEBF LBOPOJFBCIC(CGECBEAFDFK EJOAECOFOFF)
	{
		return default(MNCKDPANEBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3086070", Offset = "0x3084C70", VA = "0x183086070")]
	public MNCKDPANEBF LBOPOJFBCIC(Entity BODOHICDFAL)
	{
		return default(MNCKDPANEBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3086210", Offset = "0x3084E10", VA = "0x183086210")]
	public KLHKIJHKJFB OPKJGOEEEBP(Entity BODOHICDFAL)
	{
		return default(KLHKIJHKJFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3086340", Offset = "0x3084F40", VA = "0x183086340")]
	public OAAGFCMFOON()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[GKALNADHNEP(DAHLALKJFLL.All)]
	[HJBMNHLGPOF(typeof(BKJKHIFBPPC), new string[] { })]
	public class ObjectService : BLCFKNFGJJJ, BKJKHIFBPPC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly FCNKBCOKGMK BIFJOLBPCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[NNMLOJPMNKB]
		private LBOBEHCDDDO OAMEEAPEBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[NNMLOJPMNKB]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[NNMLOJPMNKB]
		private ObjectLifecycleService LPHFEOKHKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[NNMLOJPMNKB]
		private ObjectEmbodimentService NIENOEJANLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[NNMLOJPMNKB]
		private ObjectInstantiationService BCDJFKMHLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[NNMLOJPMNKB]
		private OAAGFCMFOON ACKCFCFAEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private ObjectNetworkToLocalMapService GMAKJKHGELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool JIGLPOGPBPP;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public LBOBEHCDDDO AABEJCEFACP
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int MPILIMPBMGH
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x3097980", Offset = "0x3096580", VA = "0x183097980", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int IEAMDKJNKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x30966E0", Offset = "0x30952E0", VA = "0x1830966E0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int ALFEGOICLNL
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x3097570", Offset = "0x3096170", VA = "0x183097570", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int CIGEHKBFDHE
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x3097020", Offset = "0x3095C20", VA = "0x183097020", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int CBLDJJCOCBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x3097CD0", Offset = "0x30968D0", VA = "0x183097CD0", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int ODOGCKFEDEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x3096E70", Offset = "0x3095A70", VA = "0x183096E70", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<CGECBEAFDFK, KLHKIJHKJFB> CJIMPENILAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x3097830", Offset = "0x3096430", VA = "0x183097830", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x3097790", Offset = "0x3096390", VA = "0x183097790", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<CGECBEAFDFK> DDKJCMMGEOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x3096F80", Offset = "0x3095B80", VA = "0x183096F80", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x3096980", Offset = "0x3095580", VA = "0x183096980", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3096710", Offset = "0x3095310", VA = "0x183096710", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3096310", Offset = "0x3094F10", VA = "0x183096310", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3097320", Offset = "0x3095F20", VA = "0x183097320")]
		private void KHHHOGEHFLP(Entity BODOHICDFAL, KLHKIJHKJFB IBFKFNLEDKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3096C90", Offset = "0x3095890", VA = "0x183096C90")]
		private void GGJNJBJGHJE(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3097CB0", Offset = "0x30968B0", VA = "0x183097CB0")]
		internal CGECBEAFDFK PDMPJPKNAPJ(Entity BODOHICDFAL)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3096D70", Offset = "0x3095970", VA = "0x183096D70", Slot = "41")]
		public DLCEAGAIHLE HOEJAMHJELL()
		{
			return default(DLCEAGAIHLE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x30970C0", Offset = "0x3095CC0", VA = "0x1830970C0", Slot = "42")]
		public DLCEAGAIHLE JJJOOIMFHGG()
		{
			return default(DLCEAGAIHLE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3096EE0", Offset = "0x3095AE0", VA = "0x183096EE0", Slot = "43")]
		public DLCEAGAIHLE IPEPMAKDGNL()
		{
			return default(DLCEAGAIHLE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3097460", Offset = "0x3096060", VA = "0x183097460", Slot = "10")]
		public MNCKDPANEBF LBOPOJFBCIC(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(MNCKDPANEBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3097BE0", Offset = "0x30967E0", VA = "0x183097BE0", Slot = "11")]
		public KLHKIJHKJFB OPKJGOEEEBP(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(KLHKIJHKJFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x30978D0", Offset = "0x30964D0", VA = "0x1830978D0")]
		private DLCEAGAIHLE NGGOAMJPAJD(EntityQuery GJLGONPKKFL)
		{
			return default(DLCEAGAIHLE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3097700", Offset = "0x3096300", VA = "0x183097700", Slot = "33")]
		public bool MKAKFEIOKNJ(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3097520", Offset = "0x3096120", VA = "0x183097520", Slot = "29")]
		public void LFFHDJLOGBM(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3096E10", Offset = "0x3095A10", VA = "0x183096E10", Slot = "30")]
		public void IAEFGMFEHKD(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3097660", Offset = "0x3096260", VA = "0x183097660", Slot = "31")]
		public void MJBIBDCIAFJ(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3095FC0", Offset = "0x3094BC0", VA = "0x183095FC0", Slot = "22")]
		public DABKEOMEIOA DALGLOOJHAM(KLHKIJHKJFB IBFKFNLEDKN, bool KFDIKAODEFK)
		{
			return default(DABKEOMEIOA);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3095F10", Offset = "0x3094B10", VA = "0x183095F10", Slot = "23")]
		public DABKEOMEIOA DALGLOOJHAM(KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(DABKEOMEIOA);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3096AE0", Offset = "0x30956E0", VA = "0x183096AE0", Slot = "24")]
		public DABKEOMEIOA FNCJJJDBDFN(KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(DABKEOMEIOA);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3096490", Offset = "0x3095090", VA = "0x183096490", Slot = "25")]
		public DABKEOMEIOA EFHFPJLEEJK(KFMKFJINGPH AAEPEKAJNKI, KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(DABKEOMEIOA);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x30960F0", Offset = "0x3094CF0", VA = "0x1830960F0", Slot = "44")]
		public DABKEOMEIOA DNEINJMPNMI(int DJBOCFKJJOF, KLHKIJHKJFB IBFKFNLEDKN, GameObject OKGHLJEDAEA)
		{
			return default(DABKEOMEIOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3096A20", Offset = "0x3095620", VA = "0x183096A20", Slot = "26")]
		public LNHMFCPBDMC FHEDOIMEBMO()
		{
			return default(LNHMFCPBDMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3095D00", Offset = "0x3094900", VA = "0x183095D00", Slot = "45")]
		public KHKNHHHGPNN ANBHKNODMOE(KLCDDLDEKAP JMPEGNOKOOB)
		{
			return default(KHKNHHHGPNN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x30971D0", Offset = "0x3095DD0", VA = "0x1830971D0", Slot = "27")]
		public BGJLOKHHLBE JKLMHEPOIBM()
		{
			return default(BGJLOKHHLBE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3097AA0", Offset = "0x30966A0", VA = "0x183097AA0", Slot = "28")]
		public EENIFFFHBAP OKPJCNHAAOH(IELMBOEFPKD JMPEGNOKOOB)
		{
			return default(EENIFFFHBAP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x30970A0", Offset = "0x3095CA0", VA = "0x1830970A0", Slot = "12")]
		public void JHOMPJHMJJA(KFMKFJINGPH AAEPEKAJNKI, GIHALPBFOMC CIGKIBHLLHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3096160", Offset = "0x3094D60", VA = "0x183096160", Slot = "13")]
		public DABKEOMEIOA DPNDGAHFFFB(CGECBEAFDFK HGAMKJKNDDL, [Optional] object GIHOLCNOBIB)
		{
			return default(DABKEOMEIOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3096B70", Offset = "0x3095770", VA = "0x183096B70", Slot = "14")]
		public bool FPHGMCENCAM(CGECBEAFDFK HGAMKJKNDDL, out GIHALPBFOMC HJIMPKKMPML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3095E40", Offset = "0x3094A40", VA = "0x183095E40", Slot = "46")]
		public Transform COMAPDCJDEE(CGECBEAFDFK HGAMKJKNDDL, [Optional] object GIHOLCNOBIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3096D20", Offset = "0x3095920", VA = "0x183096D20", Slot = "16")]
		public bool GMKBAMGDIBP(CGECBEAFDFK HGAMKJKNDDL, out Transform IGPPDIMEFDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3097050", Offset = "0x3095C50", VA = "0x183097050", Slot = "17")]
		public bool JGDPEEKPKPM(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x30975A0", Offset = "0x30961A0", VA = "0x1830975A0")]
		public bool LOHCHGPIOFF(GIHALPBFOMC NENFOEKGNGK, [Optional] object GIHOLCNOBIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x30975D0", Offset = "0x30961D0", VA = "0x1830975D0", Slot = "47")]
		public bool LOHCHGPIOFF(CGECBEAFDFK HGAMKJKNDDL, [Optional] object GIHOLCNOBIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3095E20", Offset = "0x3094A20", VA = "0x183095E20", Slot = "48")]
		public void CGMFOPNEPKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3095B50", Offset = "0x3094750", VA = "0x183095B50", Slot = "15")]
		public void AJFMEIAJEBM(GIHALPBFOMC AOEMDAGAALP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3096EA0", Offset = "0x3095AA0", VA = "0x183096EA0", Slot = "49")]
		public void IKGIOAEJKHG(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3096C10", Offset = "0x3095810", VA = "0x183096C10", Slot = "18")]
		public bool GGEFHCLJENA(Entity BODOHICDFAL, object GIHOLCNOBIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3095E90", Offset = "0x3094A90", VA = "0x183095E90", Slot = "19")]
		public bool CPGKOJILLPP(Entity BODOHICDFAL, object GIHOLCNOBIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x30972B0", Offset = "0x3095EB0", VA = "0x1830972B0", Slot = "50")]
		public bool KBDPKMKACNJ(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3096080", Offset = "0x3094C80", VA = "0x183096080", Slot = "51")]
		public bool DICAIFOEDLB(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3097600", Offset = "0x3096200", VA = "0x183097600", Slot = "32")]
		public NativeArray<(CGECBEAFDFK, CGECBEAFDFK)> MFDGEAABOHF(NativeArray<CGECBEAFDFK> EKNGCDBNDEG, Allocator JMMNDPMBMFC)
		{
			return default(NativeArray<(CGECBEAFDFK, CGECBEAFDFK)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x30973C0", Offset = "0x3095FC0", VA = "0x1830973C0", Slot = "21")]
		public KFMKFJINGPH KOMMHBLAJKC(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(KFMKFJINGPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x30979B0", Offset = "0x30965B0", VA = "0x1830979B0", Slot = "20")]
		public CGECBEAFDFK OCFNCIECCMF(KFMKFJINGPH AAEPEKAJNKI)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3095A90", Offset = "0x3094690", VA = "0x183095A90")]
		private void ACFAJPCKCNK(KLHKIJHKJFB IBFKFNLEDKN, CGECBEAFDFK HGAMKJKNDDL, KFMKFJINGPH AAEPEKAJNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HJBMNHLGPOF(typeof(FPOKIFLFFKB), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
internal sealed class FPOKIFLFFKB : BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private ObjectInstantiationService BCDJFKMHLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[NNMLOJPMNKB]
	private OAAGFCMFOON ACKCFCFAEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[NNMLOJPMNKB]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x35D3300", Offset = "0x35D1F00", VA = "0x1835D3300", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x35D3390", Offset = "0x35D1F90", VA = "0x1835D3390")]
	public NativeArray<(CGECBEAFDFK, CGECBEAFDFK)> MFDGEAABOHF(NativeArray<CGECBEAFDFK> EKNGCDBNDEG, Allocator JMMNDPMBMFC)
	{
		return default(NativeArray<(CGECBEAFDFK, CGECBEAFDFK)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x35D3490", Offset = "0x35D2090", VA = "0x1835D3490")]
	private void MLKGIKOOMAJ(NativeMultiHashMap<int, (CGECBEAFDFK src, CGECBEAFDFK dst)> MHPJKEIANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x35D3670", Offset = "0x35D2270", VA = "0x1835D3670")]
	private void PEJJFHNAFIP(NativeMultiHashMap<int, (CGECBEAFDFK src, CGECBEAFDFK dst)> MHPJKEIANEB, int IBFKFNLEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x35D2E90", Offset = "0x35D1A90", VA = "0x1835D2E90")]
	private void BBJKDDCFICM(NativeMultiHashMap<int, (CGECBEAFDFK src, CGECBEAFDFK dst)> MHPJKEIANEB, int IBFKFNLEDKN, ELGFJHKNNCH MBLNNIKAAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x35D3020", Offset = "0x35D1C20", VA = "0x1835D3020")]
	private NativeMultiHashMap<int, (CGECBEAFDFK, CGECBEAFDFK)> BPDKGFCBHAP(Allocator JMMNDPMBMFC, NativeArray<CGECBEAFDFK> EKNGCDBNDEG, out NativeArray<(CGECBEAFDFK src, CGECBEAFDFK dst)> JEBPOGILAHJ)
	{
		return default(NativeMultiHashMap<int, (CGECBEAFDFK, CGECBEAFDFK)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public FPOKIFLFFKB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[BOFOPPKAPFG(typeof(TransformService))]
	[HJBMNHLGPOF(typeof(IHMCHCLHMKB), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.TransformSyncing)]
	public class TransformService : IHMCHCLHMKB, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly FCNKBCOKGMK NGPEGMKOGCJ;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly FCNKBCOKGMK DMOPMEJKJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private CLKGEBGIDIH LJMHKNOAABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private HOONHJLELFO EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private ALKOEFHOGFF MMELHHCFIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TransformOwnershipPhase LNJKAHDBACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ObjectEmbodimentService MDBFILFJAMO;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private EntityManager CNOHAEKAHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x333C8F0", Offset = "0x333B4F0", VA = "0x18333C8F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private OAJACFAFCNG LALBODAPNEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x333FF40", Offset = "0x333EB40", VA = "0x18333FF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x333D190", Offset = "0x333BD90", VA = "0x18333D190", Slot = "33")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x333D790", Offset = "0x333C390", VA = "0x18333D790", Slot = "34")]
		public bool FIGGDEKFPLE(Transform IGPPDIMEFDL, out CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x333FA70", Offset = "0x333E670", VA = "0x18333FA70", Slot = "35")]
		public Transform MFIFGEHCCFE(Entity BODOHICDFAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x333DDB0", Offset = "0x333C9B0", VA = "0x18333DDB0", Slot = "30")]
		public bool GMKBAMGDIBP(Entity BODOHICDFAL, out Transform IGPPDIMEFDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x333E740", Offset = "0x333D340", VA = "0x18333E740")]
		private void IHLCDNFPDGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3340420", Offset = "0x333F020", VA = "0x183340420", Slot = "29")]
		public void OIBHFGDNCLA(Entity BODOHICDFAL, out Matrix4x4 LGOBMECJHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x333F7E0", Offset = "0x333E3E0", VA = "0x18333F7E0", Slot = "4")]
		public void LPEGIJCGAGA(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x333E670", Offset = "0x333D270", VA = "0x18333E670")]
		public void IGJNMKCLDJH(Entity BODOHICDFAL, Vector3 LHHJFJDBODB, Quaternion EOGJNLADAMN, Vector3 BJHMGLJAIIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3340000", Offset = "0x333EC00", VA = "0x183340000")]
		public void NHFEBGEGNGP(Entity BODOHICDFAL, Vector3 LHHJFJDBODB, Quaternion EOGJNLADAMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3340DE0", Offset = "0x333F9E0", VA = "0x183340DE0", Slot = "27")]
		public void PPNBDDCPLCF(Entity BODOHICDFAL, out Matrix4x4 BHIJFOOCEMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x333C420", Offset = "0x333B020", VA = "0x18333C420")]
		public void BBLLILNEFMD(Entity BODOHICDFAL, in Matrix4x4 LGOBMECJHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x33409D0", Offset = "0x333F5D0", VA = "0x1833409D0")]
		public void OMGDCPOLMFE(Entity BODOHICDFAL, in Matrix4x4 LGOBMECJHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3340C20", Offset = "0x333F820", VA = "0x183340C20")]
		public void PEBBEDHGDEM(Entity BODOHICDFAL, in Matrix4x4 NNIAMDOIIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3340B00", Offset = "0x333F700", VA = "0x183340B00", Slot = "5")]
		public void PBKEOGOMGBM(Entity BODOHICDFAL, Vector3 NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x333CA50", Offset = "0x333B650", VA = "0x18333CA50", Slot = "6")]
		public Vector3 CHIGHBEFPPO(Entity BODOHICDFAL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3340110", Offset = "0x333ED10", VA = "0x183340110", Slot = "7")]
		public void NPFJGHOCACK(Entity BODOHICDFAL, Quaternion NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x333ECF0", Offset = "0x333D8F0", VA = "0x18333ECF0", Slot = "8")]
		public Quaternion JMMKMHPHKEJ(Entity BODOHICDFAL)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x333FD60", Offset = "0x333E960", VA = "0x18333FD60", Slot = "12")]
		public void MKEDJKHNJAE(Entity BODOHICDFAL, Vector3 NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x333C940", Offset = "0x333B540", VA = "0x18333C940", Slot = "11")]
		public Vector3 CGFAPJADIDB(Entity BODOHICDFAL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x333EF60", Offset = "0x333DB60", VA = "0x18333EF60")]
		public void KNJGECCLNHO(Entity BODOHICDFAL, Vector3 NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x333F9D0", Offset = "0x333E5D0", VA = "0x18333F9D0")]
		private Vector3 MCINHFCFAKK(Entity BODOHICDFAL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x333D0F0", Offset = "0x333BCF0", VA = "0x18333D0F0", Slot = "14")]
		public float ELJKPONMPOM(Entity BODOHICDFAL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x333C7E0", Offset = "0x333B3E0", VA = "0x18333C7E0", Slot = "13")]
		public void BFAAIPCDCFP(Entity BODOHICDFAL, float NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x333D950", Offset = "0x333C550", VA = "0x18333D950")]
		private float FKGOBGKNACB(Entity BODOHICDFAL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x333DBF0", Offset = "0x333C7F0", VA = "0x18333DBF0")]
		public void FNPELKOFHOA(Entity BODOHICDFAL, float PENFCAMNOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x333FE60", Offset = "0x333EA60", VA = "0x18333FE60", Slot = "16")]
		public Vector3 MKHPJIJHOPC(Entity BODOHICDFAL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x333E290", Offset = "0x333CE90", VA = "0x18333E290", Slot = "15")]
		public void HLOAPIBLMCE(Entity BODOHICDFAL, Vector3 OGCLALCAGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x333DC80", Offset = "0x333C880", VA = "0x18333DC80")]
		private Vector3 GGENFMEMJIP(Entity BODOHICDFAL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x333FC90", Offset = "0x333E890", VA = "0x18333FC90")]
		public void MHMMPMPKHKN(Entity BODOHICDFAL, Vector3 NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x333DA40", Offset = "0x333C640", VA = "0x18333DA40")]
		[Conditional("DEBUG_BUILD")]
		private void FLPKAGGMNAK(Entity BODOHICDFAL, Vector3 NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x333FB30", Offset = "0x333E730", VA = "0x18333FB30", Slot = "36")]
		public void MGDIJNMCBEA(Entity BODOHICDFAL, Vector3 BBEHPKKOBDE, Quaternion IDIJNBAPGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x333E520", Offset = "0x333D120", VA = "0x18333E520", Slot = "9")]
		public void IDNONOMJHDA(Entity BODOHICDFAL, out Vector3 BBEHPKKOBDE, out Quaternion IDIJNBAPGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x333E980", Offset = "0x333D580", VA = "0x18333E980", Slot = "10")]
		public void JKMHCFAOEAN(Entity BODOHICDFAL, out Vector3 BBEHPKKOBDE, out Quaternion IDIJNBAPGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x333E760", Offset = "0x333D360", VA = "0x18333E760", Slot = "37")]
		public void JHGADFJMFHF(Entity BODOHICDFAL, Vector3 BBEHPKKOBDE, Quaternion IDIJNBAPGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x333E0D0", Offset = "0x333CCD0", VA = "0x18333E0D0")]
		public void HCHAPLHPAGG(Entity BODOHICDFAL, Vector3 BBEHPKKOBDE, Quaternion IDIJNBAPGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x333DEA0", Offset = "0x333CAA0", VA = "0x18333DEA0", Slot = "17")]
		public void GOBACJLCPAE(Entity BODOHICDFAL, Vector3 NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x333E3C0", Offset = "0x333CFC0", VA = "0x18333E3C0", Slot = "18")]
		public Vector3 HNLPBANCEBO(Entity BODOHICDFAL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x333EAB0", Offset = "0x333D6B0", VA = "0x18333EAB0", Slot = "19")]
		public void JMHLKLGMBLK(Entity BODOHICDFAL, Quaternion NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3340330", Offset = "0x333EF30", VA = "0x183340330", Slot = "20")]
		public Quaternion OFHBAPAAIGI(Entity BODOHICDFAL)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3340570", Offset = "0x333F170", VA = "0x183340570", Slot = "22")]
		public void OICLKJICHKA(Entity BODOHICDFAL, Vector3 NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x333CD90", Offset = "0x333B990", VA = "0x18333CD90", Slot = "21")]
		public Vector3 DOBGAJGGNLF(Entity BODOHICDFAL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x333EDE0", Offset = "0x333D9E0", VA = "0x18333EDE0", Slot = "23")]
		public void KFDFIKFOOIL(Entity BODOHICDFAL, float FJCJNMLDBLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x333CE80", Offset = "0x333BA80", VA = "0x18333CE80", Slot = "24")]
		public float EBFFNMEPALG(Entity BODOHICDFAL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x333D2A0", Offset = "0x333BEA0", VA = "0x18333D2A0", Slot = "25")]
		public void FEPFMPGPNJK(Entity BODOHICDFAL, Vector3 JHOIGAGHPMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x333F000", Offset = "0x333DC00", VA = "0x18333F000", Slot = "26")]
		public Vector3 LEAKNAOHLCH(Entity BODOHICDFAL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x333F140", Offset = "0x333DD40", VA = "0x18333F140", Slot = "31")]
		public void LFHEMIJJMFN(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x333CFA0", Offset = "0x333BBA0", VA = "0x18333CFA0")]
		private CGECBEAFDFK ECJHGKJJEBL(Transform IGPPDIMEFDL)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x333CB60", Offset = "0x333B760", VA = "0x18333CB60")]
		private static TransformEntity DOBGAFKAMCK(KLHKIJHKJFB JMPEGNOKOOB, GameObject IOHAHKHBMPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3340210", Offset = "0x333EE10", VA = "0x183340210", Slot = "32")]
		public void OAJMIHFMKCI(Entity BODOHICDFAL, Entity FIFCKAAEEOG, Entity FJCPKFBPJEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x333E4A0", Offset = "0x333D0A0", VA = "0x18333E4A0")]
		private NDMKIEPFODE IDNONOMJHDA(Entity BODOHICDFAL)
		{
			return default(NDMKIEPFODE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x333BDF0", Offset = "0x333A9F0", VA = "0x18333BDF0")]
		private bool ACOGGMDPKEE(Entity BODOHICDFAL, out Entity NIGFDFKEKGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x333BED0", Offset = "0x333AAD0", VA = "0x18333BED0")]
		private void AHIHIKGMNBD(Entity BODOHICDFAL, out Matrix4x4 LGOBMECJHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x333C080", Offset = "0x333AC80", VA = "0x18333C080")]
		private void ALEGHKPLLEP(Entity BODOHICDFAL, out Matrix4x4 NNIAMDOIIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x333EF50", Offset = "0x333DB50", VA = "0x18333EF50", Slot = "28")]
		private void KKDBHAJBDNO(Entity BODOHICDFAL, in Matrix4x4 BHIJFOOCEMI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HJBMNHLGPOF(typeof(OENDBEELIED), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
internal sealed class OENDBEELIED : BLCFKNFGJJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[NNMLOJPMNKB]
	private OHGMKNKEOOJ OPBBALMJDDI;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x30882C0", Offset = "0x3086EC0", VA = "0x1830882C0", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x3088250", Offset = "0x3086E50", VA = "0x183088250", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public OENDBEELIED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
[HJBMNHLGPOF(typeof(GGIGBKCIJFH), new string[] { })]
public class GGIGBKCIJFH
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct JMEDIOCHEED : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly GGIGBKCIJFH NIGFDFKEKGM;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x43AC380", Offset = "0x43AAF80", VA = "0x1843AC380")]
		public JMEDIOCHEED(GGIGBKCIJFH NIGFDFKEKGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x43AC360", Offset = "0x43AAF60", VA = "0x1843AC360", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int ABIADDGHNNG;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool PEDDHEADACC
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x18EA3F0", Offset = "0x18E8FF0", VA = "0x1818EA3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action GLIEMEDKGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x35D4020", Offset = "0x35D2C20", VA = "0x1835D4020")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x35D3F80", Offset = "0x35D2B80", VA = "0x1835D3F80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x35D3F50", Offset = "0x35D2B50", VA = "0x1835D3F50")]
	public JMEDIOCHEED JGCHPOLDOCM()
	{
		return default(JMEDIOCHEED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x8DA110", Offset = "0x8D8D10", VA = "0x1808DA110")]
	public void JKLEFHOAAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x35D3F30", Offset = "0x35D2B30", VA = "0x1835D3F30")]
	public void GKMLDGEOLHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public GGIGBKCIJFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[HJBMNHLGPOF(typeof(JAECADCCJOD), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
public class JAECADCCJOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int ABIADDGHNNG;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool CBCJINGKOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x92F950", Offset = "0x92E550", VA = "0x18092F950")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x92F9E0", Offset = "0x92E5E0", VA = "0x18092F9E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JAECADCCJOD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[HJBMNHLGPOF(typeof(EnableComponentSystemsInScope), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.ComponentSystemTypes)]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	public class EnableComponentSystemsInScope : BLCFKNFGJJJ, AOEOCLOIFAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct MCLDHLLPLAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<int> OLNHHFJPDKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<int> MALHNKJOHLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private Dictionary<ComponentSystemBase, int> HMIEHEIMDBO;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x43AD430", Offset = "0x43AC030", VA = "0x1843AD430")]
			public MCLDHLLPLAP(NativeArray<int> OLNHHFJPDKN, NativeArray<int> MALHNKJOHLB, Dictionary<ComponentSystemBase, int> HMIEHEIMDBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x43AD1B0", Offset = "0x43ABDB0", VA = "0x1843AD1B0")]
			public void OECAOLGJDDG(IEnumerable<ComponentSystemBase> OAMEEAPEBME, EBEBOFNGILK LKJDEHBDJKO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class GOLLIJLCDLI : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private ComponentSystemBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public EnableComponentSystemsInScope <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private int start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>3__start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private int end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>3__end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
			[DebuggerHidden]
			public GOLLIJLCDLI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x43A9E90", Offset = "0x43A8A90", VA = "0x1843A9E90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x43AA060", Offset = "0x43A8C60", VA = "0x1843AA060", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x43A9FB0", Offset = "0x43A8BB0", VA = "0x1843A9FB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x43A9FB0", Offset = "0x43A8BB0", VA = "0x1843A9FB0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public const EBEBOFNGILK MGMOJEDIHAJ = EBEBOFNGILK.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly FCNKBCOKGMK NMOPGDIOCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[NNMLOJPMNKB]
		private HOONHJLELFO GMKNLKMJIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private World EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private PJJBBDFFHDI FAEIDGPFAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private NativeArray<int> CMPGLKCHHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private NativeArray<int> HKHOHDKKFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int OLOLCGEOMNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private EBEBOFNGILK CBFBJGECJOF;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x35CD320", Offset = "0x35CBF20", VA = "0x1835CD320", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x35CCFA0", Offset = "0x35CBBA0", VA = "0x1835CCFA0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x35CD6B0", Offset = "0x35CC2B0", VA = "0x1835CD6B0")]
		[IteratorStateMachine(typeof(GOLLIJLCDLI))]
		private IEnumerable<ComponentSystemBase> OBDOHKELBLN(int IOMMLLJBIGB, int IEPBHGAJDBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x35CD800", Offset = "0x35CC400", VA = "0x1835CD800", Slot = "5")]
		public void PGBEGPOIMNL(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x35CCCA0", Offset = "0x35CB8A0", VA = "0x1835CCCA0")]
		private void COHKICAGAPI(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x35CCDF0", Offset = "0x35CB9F0", VA = "0x1835CCDF0")]
		public void COHKICAGAPI(EBEBOFNGILK GAKBENHFHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x35CD090", Offset = "0x35CBC90", VA = "0x1835CD090")]
		private void FAOLJCNADMB(EBEBOFNGILK GAKBENHFHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x35CCEF0", Offset = "0x35CBAF0", VA = "0x1835CCEF0")]
		private void DFMMFAJCACC(EBEBOFNGILK GAKBENHFHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x35CD4C0", Offset = "0x35CC0C0", VA = "0x1835CD4C0")]
		private void JMALJDFNGHK(EBEBOFNGILK GAKBENHFHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x35CD740", Offset = "0x35CC340", VA = "0x1835CD740")]
		private void OFFFMHHFOKD(int IOMMLLJBIGB, int IEPBHGAJDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x35CD400", Offset = "0x35CC000", VA = "0x1835CD400")]
		private void IJKOAEEDEOD(int IOMMLLJBIGB, int IEPBHGAJDBG, bool PJNMHBFDAHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x35CCF80", Offset = "0x35CBB80", VA = "0x1835CCF80")]
		private int DHOBIPGBHKF(EBEBOFNGILK GAKBENHFHPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x35CC660", Offset = "0x35CB260", VA = "0x1835CC660")]
		private bool AFIFOLMKHJJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x35CD520", Offset = "0x35CC120", VA = "0x1835CD520")]
		private Dictionary<ComponentSystemBase, int> KEHCKHFHJGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x35CD670", Offset = "0x35CC270", VA = "0x1835CD670")]
		private void NHINMGMGODH(NativeArray<int> OLNHHFJPDKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x35CCBF0", Offset = "0x35CB7F0", VA = "0x1835CCBF0")]
		private void AOEJBCIBIBO(NativeArray<int> MALHNKJOHLB, NativeArray<int> OLNHHFJPDKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x35CD030", Offset = "0x35CBC30", VA = "0x1835CD030")]
		private static EBEBOFNGILK EMDDDGOLJMF(Type JMPEGNOKOOB, EBEBOFNGILK DOOMMHJABHL)
		{
			return default(EBEBOFNGILK);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x35CD8A0", Offset = "0x35CC4A0", VA = "0x1835CD8A0")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x35CD3A0", Offset = "0x35CBFA0", VA = "0x1835CD3A0")]
		[CompilerGenerated]
		private void IIFCGIACCBO(BLCFKNFGJJJ EAPBKFBMEPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x35CD610", Offset = "0x35CC210", VA = "0x1835CD610")]
		[CompilerGenerated]
		private void MNOILADGEED(JGJNINBGNFN EAPBKFBMEPN)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[GKALNADHNEP(DAHLALKJFLL.WorldService)]
	[HJBMNHLGPOF(typeof(GDJBNBLIMAN), new string[] { })]
	public class TickService : BLCFKNFGJJJ, GDJBNBLIMAN
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly ProfilerMarker NHMLNBBMOAA;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly ProfilerMarker HMKMHPLNKLM;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly ProfilerMarker GPCGLBNJHAF;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly ProfilerMarker CJBJIKDHAGI;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly ProfilerMarker JIOIFLBNADG;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly ProfilerMarker AAGPIBBJEAI;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly ProfilerMarker HOKBGNPFEOM;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly ProfilerMarker MKPGKPIAKAH;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly ProfilerMarker CBMANENIIKJ;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly ProfilerMarker EJKAIFPJIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[NNMLOJPMNKB]
		private HOONHJLELFO GMKNLKMJIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[NNMLOJPMNKB]
		private ONMHIEOMAFC HOAFPJNBADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[NNMLOJPMNKB]
		private FANFOMEKGMF EJKPJGAAFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[NNMLOJPMNKB]
		private TransformOwnershipPhase EMBIDFBFENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[NNMLOJPMNKB]
		private TimeService IOBEJOJDLDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private DEDLBKJDALP EELLGOEIJJC;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private bool CBJOOODBGPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x333A030", Offset = "0x3338C30", VA = "0x18333A030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private bool FOHNEOIADBC
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x333AAD0", Offset = "0x33396D0", VA = "0x18333AAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool OGDLPCEGGLA
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x333A030", Offset = "0x3338C30", VA = "0x18333A030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool MGKKANPAFEC
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x333A030", Offset = "0x3338C30", VA = "0x18333A030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x333A7E0", Offset = "0x33393E0", VA = "0x18333A7E0", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x333B100", Offset = "0x3339D00", VA = "0x18333B100", Slot = "14")]
		public void PPLJACHOONL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x333A220", Offset = "0x3338E20", VA = "0x18333A220", Slot = "15")]
		public void CMJJFEIOGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x333A4C0", Offset = "0x33390C0", VA = "0x18333A4C0", Slot = "5")]
		public void DPEEAJHHNCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x333A950", Offset = "0x3339550", VA = "0x18333A950", Slot = "6")]
		public void JLIJLOGLDJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x333A590", Offset = "0x3339190", VA = "0x18333A590", Slot = "7")]
		public void EODLIPAGOBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x333A340", Offset = "0x3338F40", VA = "0x18333A340", Slot = "8")]
		public void DKPDBMHKANI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x333A0A0", Offset = "0x3338CA0", VA = "0x18333A0A0", Slot = "9")]
		public void CFJDEPALCCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x333ACC0", Offset = "0x33398C0", VA = "0x18333ACC0", Slot = "10")]
		public void OEHNAPDDHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x333A710", Offset = "0x3339310", VA = "0x18333A710", Slot = "11")]
		public void FCLOLGPBHOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "13")]
		public void NHDDCHLOCCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x333AB70", Offset = "0x3339770", VA = "0x18333AB70", Slot = "12")]
		public void NKLLPPCAJPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[GKALNADHNEP(DAHLALKJFLL.WorldService)]
	[HJBMNHLGPOF(typeof(HOONHJLELFO), new string[] { })]
	public class WorldService : HOONHJLELFO, IDisposable, AHBNMIIEDML
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DEDLBKJDALP EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool JIGLPOGPBPP;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public DEDLBKJDALP JJBDOGEBBHK
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public OAJACFAFCNG LALBODAPNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x3349340", Offset = "0x3347F40", VA = "0x183349340", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EntityManager CNOHAEKAHFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x3348FE0", Offset = "0x3347BE0", VA = "0x183348FE0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool EHAKBDFLKEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x76C5D0", Offset = "0x76B1D0", VA = "0x18076C5D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x3349380", Offset = "0x3347F80", VA = "0x183349380", Slot = "10")]
		public void PHKHGJFAMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x3349230", Offset = "0x3347E30", VA = "0x183349230")]
		private void NBONEDNFGGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x3349000", Offset = "0x3347C00", VA = "0x183349000", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x3349360", Offset = "0x3347F60", VA = "0x183349360", Slot = "8")]
		public ComponentSystemBase PEOPPEJBAEH(Type JMPEGNOKOOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[HJBMNHLGPOF(typeof(DOGHCLFJBOC), new string[] { })]
public sealed class OGEKIFFHMIH : DOGHCLFJBOC, CLILAOIFPFK, AHBNMIIEDML, BLCFKNFGJJJ, JGJNINBGNFN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class BMALKFKMGDF : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x714C90", Offset = "0x713890", VA = "0x180714C90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x43A6840", Offset = "0x43A5440", VA = "0x1843A6840", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x714D30", Offset = "0x713930", VA = "0x180714D30")]
		[DebuggerHidden]
		public BMALKFKMGDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x43A6530", Offset = "0x43A5130", VA = "0x1843A6530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x43A6800", Offset = "0x43A5400", VA = "0x1843A6800", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x43A6760", Offset = "0x43A5360", VA = "0x1843A6760", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x43A6760", Offset = "0x43A5360", VA = "0x1843A6760", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[NNMLOJPMNKB]
	private BPKIFHOOJOE MBLNNIKAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly MBGDBAAHIJP DPCHNMJDNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Dictionary<string, AHCMBCDFFFB> OHFBAMFPJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<int, LBECIDMFBGB> KFJIEABHLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<FNAFHEBBEAB> CIFNFCOGAPH;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public LBECIDMFBGB MEGFNCEIPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x3088B70", Offset = "0x3087770", VA = "0x183088B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<FNAFHEBBEAB> DFHJFOKPIJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
	public void PHKHGJFAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x3088BD0", Offset = "0x30877D0", VA = "0x183088BD0", Slot = "8")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x3088A70", Offset = "0x3087670", VA = "0x183088A70", Slot = "9")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x3088A90", Offset = "0x3087690", VA = "0x183088A90", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x3088C30", Offset = "0x3087830", VA = "0x183088C30", Slot = "6")]
	public bool IPHLKLNBFML(FNAFHEBBEAB FCPNPIIHNJJ, out LBECIDMFBGB INPEIBCNMCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x30886E0", Offset = "0x30872E0", VA = "0x1830886E0")]
	private void CGDDCGBLLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x3088DA0", Offset = "0x30879A0", VA = "0x183088DA0")]
	private void KHGBGIEBOIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x3089040", Offset = "0x3087C40", VA = "0x183089040")]
	private AHCMBCDFFFB MGBIGDEEKHI(string LCICOHHANFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x3088B70", Offset = "0x3087770", VA = "0x183088B70")]
	private AHCMBCDFFFB EHHIIHOKMGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x3088390", Offset = "0x3086F90", VA = "0x183088390")]
	private AHCMBCDFFFB ACADAAAACKP(string LCICOHHANFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x3089180", Offset = "0x3087D80", VA = "0x183089180")]
	private AHCMBCDFFFB PDJHDNNINNM(string HKLHFKDNFJF, string GIHOLCNOBIB, [Optional] AHCMBCDFFFB HPEMMPJLFPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x3088FD0", Offset = "0x3087BD0", VA = "0x183088FD0")]
	[IteratorStateMachine(typeof(BMALKFKMGDF))]
	private IEnumerable<(string, string)> LHGIGEBCIDB(string LCICOHHANFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x3088B20", Offset = "0x3087720", VA = "0x183088B20")]
	private bool EBIILGIOCJM(FNAFHEBBEAB FCPNPIIHNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x30890A0", Offset = "0x3087CA0", VA = "0x1830890A0")]
	private MBGDBAAHIJP OFPDNICMAFF(FNAFHEBBEAB FCPNPIIHNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x3088D50", Offset = "0x3087950", VA = "0x183088D50")]
	private MBGDBAAHIJP KHEGHLJKOFI(FNAFHEBBEAB FCPNPIIHNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3088F40", Offset = "0x3087B40", VA = "0x183088F40")]
	private MBGDBAAHIJP LGMCJNKHJHI(FNAFHEBBEAB FCPNPIIHNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A05740", Offset = "0x2A04340", VA = "0x182A05740")]
	private T BNEGDLAFHFN<T>(FNAFHEBBEAB FCPNPIIHNJJ) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x3088600", Offset = "0x3087200", VA = "0x183088600")]
	private FieldInfo BODBLFIDCNA(FNAFHEBBEAB FCPNPIIHNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x3089290", Offset = "0x3087E90", VA = "0x183089290")]
	public OGEKIFFHMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3088CC0", Offset = "0x30878C0", VA = "0x183088CC0")]
	[CompilerGenerated]
	private int KBNBEPGAOEN(FNAFHEBBEAB APGJBFJMIBK, FNAFHEBBEAB APLKEMLCGID)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class AHCMBCDFFFB : LBECIDMFBGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly string HGODPPGOKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly AHCMBCDFFFB HPEMMPJLFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly List<AHCMBCDFFFB> CDJJMDNFJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly List<FNAFHEBBEAB> MBLNNIKAAIG;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string EMPFILBCEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public LBECIDMFBGB JJJIICDPELC
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<LBECIDMFBGB> LLIGPLMGEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IEnumerable<FNAFHEBBEAB> GJDECGOJDFI
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x319A1D0", Offset = "0x3198DD0", VA = "0x18319A1D0")]
	public AHCMBCDFFFB(string MKPDFAEIFFO, AHCMBCDFFFB NIGFDFKEKGM)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[GKALNADHNEP(DAHLALKJFLL.History)]
	[HJBMNHLGPOF(typeof(AIEOMKFDHLJ), new string[] { })]
	[BOFOPPKAPFG(typeof(HistoryService))]
	public class HistoryService : BLCFKNFGJJJ, IDisposable, AIEOMKFDHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private enum BLKIBAHFDIM
		{
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private readonly struct OHPBCDIBBJF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly BLKIBAHFDIM OFCGKGAJIDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly HistoryService JKANGDEKCLI;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x43AF800", Offset = "0x43AE400", VA = "0x1843AF800")]
			public OHPBCDIBBJF(HistoryService JKANGDEKCLI, bool BNJLFDPCIFI, uint OLOLCGEOMNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x43AF7D0", Offset = "0x43AE3D0", VA = "0x1843AF7D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public class EBECFNKNPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct JEDFFBEKIBP : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				private readonly EBECFNKNPMJ ELLFPNJNAMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private readonly bool OFAGJOAPDPK;

				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0x43ABC30", Offset = "0x43AA830", VA = "0x1843ABC30")]
				public JEDFFBEKIBP(EBECFNKNPMJ ELLFPNJNAMH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x43A9D60", Offset = "0x43A8960", VA = "0x1843A9D60", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct GLNFGCDGIKL : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private readonly EBECFNKNPMJ ELLFPNJNAMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				private readonly bool OFAGJOAPDPK;

				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x43A9D90", Offset = "0x43A8990", VA = "0x1843A9D90")]
				public GLNFGCDGIKL(EBECFNKNPMJ ELLFPNJNAMH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x43A9D60", Offset = "0x43A8960", VA = "0x1843A9D60", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private readonly HistoryService MCAOIMGHJGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool MDPBGHGHNAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private int NMJKMOKLMNL;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x43A8800", Offset = "0x43A7400", VA = "0x1843A8800")]
			public EBECFNKNPMJ(HistoryService MCAOIMGHJGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x43A8780", Offset = "0x43A7380", VA = "0x1843A8780")]
			public bool CABADMBKHAE(KFMKFJINGPH EJOAECOFOFF, FOCFMDNOICJ FHMECPEDGNJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x43A8730", Offset = "0x43A7330", VA = "0x1843A8730")]
			public GLNFGCDGIKL BDNOCJIEKMO()
			{
				return default(GLNFGCDGIKL);
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x43A87B0", Offset = "0x43A73B0", VA = "0x1843A87B0")]
			public JEDFFBEKIBP EGIJHNLKLIH()
			{
				return default(JEDFFBEKIBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class EHEJEFAKJKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public EHEJEFAKJKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x43A9000", Offset = "0x43A7C00", VA = "0x1843A9000")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class HDHGDBOCIMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public HDHGDBOCIMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x43AA400", Offset = "0x43A9000", VA = "0x1843AA400")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class DEBIGLGGIIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public DEBIGLGGIIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x43A7E30", Offset = "0x43A6A30", VA = "0x1843A7E30")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly UndoAction FOCKHBIFLCK;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly RedoAction EKKAINJAKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private OMHELAJGNAP NELFIKLBOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private ActionBuffer ANABOBKLFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private ActionBuffer HMIANDIKKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private DCKKFGFBMIB AFNBFFGLAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TransformOwnershipPhase EMBIDFBFENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private PropertyChangeRouterService OOMGBAGIIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private EFPGJFHDIFM MLFHIDMIELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private BLKIBAHFDIM MBGDJDKCPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private EBECFNKNPMJ ELLFPNJNAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool JIGLPOGPBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private BKAMJJFLMHO FBDEICGFAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private IPPGPHBJPJM DMPLABKFJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private FOCFMDNOICJ BHPODNIIMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly GatherPropertiesForUndelete MCAGOJLFDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private uint BBHDJIJANIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private uint KDIFOJDHFPN;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private EBECFNKNPMJ FDBECEFOFFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x7315F0", Offset = "0x7301F0", VA = "0x1807315F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool CEPCHCAEJND
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x35DB320", Offset = "0x35D9F20", VA = "0x1835DB320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool IBHPALDHKOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x35DB280", Offset = "0x35D9E80", VA = "0x1835DB280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool GKOBKCHHPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x35DA110", Offset = "0x35D8D10", VA = "0x1835DA110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int HFDNANKGKDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x35DBED0", Offset = "0x35DAAD0", VA = "0x1835DBED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int IHGNKHPEMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x35DB8D0", Offset = "0x35DA4D0", VA = "0x1835DB8D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool LMGCOPKFFMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x35DBF70", Offset = "0x35DAB70", VA = "0x1835DBF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private bool JHBDHNJAMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x35DAE80", Offset = "0x35D9A80", VA = "0x1835DAE80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool MKHEINBEPOP
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xC142F0", Offset = "0xC12EF0", VA = "0x180C142F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xC14320", Offset = "0xC12F20", VA = "0x180C14320", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private ActionBuffer CKGGAOMPAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x35DC1A0", Offset = "0x35DADA0", VA = "0x1835DC1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action MHLHGMAHHDN
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x35DB830", Offset = "0x35DA430", VA = "0x1835DB830", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x35DBD70", Offset = "0x35DA970", VA = "0x1835DBD70", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action GFAKLCCOBIB
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x35DADE0", Offset = "0x35D99E0", VA = "0x1835DADE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x35DAD40", Offset = "0x35D9940", VA = "0x1835DAD40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x35DA870", Offset = "0x35D9470", VA = "0x1835DA870", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x35DA5D0", Offset = "0x35D91D0", VA = "0x1835DA5D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x35DB740", Offset = "0x35DA340", VA = "0x1835DB740")]
		private void KCDKKANKHDG(KFMKFJINGPH EJOAECOFOFF, IGIIAIKJJLE OJPDCALHNDJ, bool HEDFLCHCPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x35DAD20", Offset = "0x35D9920", VA = "0x1835DAD20")]
		private void FDLNMDPNEOP(KFMKFJINGPH EJOAECOFOFF, FOCFMDNOICJ FHMECPEDGNJ, ODIFAJLFLNC HKDANJEKEFE, ODIFAJLFLNC KCIMCONOGCA, bool HEDFLCHCPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x35DBFC0", Offset = "0x35DABC0", VA = "0x1835DBFC0")]
		private void PIGMKPJFMBG(KFMKFJINGPH EJOAECOFOFF, bool HEDFLCHCPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x35DB8F0", Offset = "0x35DA4F0", VA = "0x1835DB8F0", Slot = "14")]
		public IDisposable MJBABPCHEGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x35DBE10", Offset = "0x35DAA10", VA = "0x1835DBE10", Slot = "9")]
		public IDisposable OKOIFOOKCCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x35DA220", Offset = "0x35D8E20", VA = "0x1835DA220", Slot = "6")]
		public UndoAction BPEJJHBJHLN()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x35DAE90", Offset = "0x35D9A90", VA = "0x1835DAE90", Slot = "15")]
		public RedoAction FOMDHEMCLML()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x35DB4B0", Offset = "0x35DA0B0", VA = "0x1835DB4B0", Slot = "16")]
		public UndoAction ILBNCHDGKCF()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x35DAF50", Offset = "0x35D9B50", VA = "0x1835DAF50", Slot = "7")]
		public RedoAction FOMDHEMCLML(UndoAction GNFCHOKJPJE)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x35DB390", Offset = "0x35D9F90", VA = "0x1835DB390", Slot = "8")]
		public UndoAction ILBNCHDGKCF(RedoAction GNFCHOKJPJE)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x35DB070", Offset = "0x35D9C70", VA = "0x1835DB070")]
		public bool GABALPCJLEL(BKNPOMPHCIC LBBDGBEPAND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x35DB0B0", Offset = "0x35D9CB0", VA = "0x1835DB0B0", Slot = "17")]
		public void GGNFLDPHLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x35DA390", Offset = "0x35D8F90", VA = "0x1835DA390")]
		public void DALGLOOJHAM(KFMKFJINGPH EJOAECOFOFF, IGIIAIKJJLE OJPDCALHNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x35DBC90", Offset = "0x35DA890", VA = "0x1835DBC90")]
		public void NNANFIFGNIH(KFMKFJINGPH EJOAECOFOFF, FOCFMDNOICJ FHMECPEDGNJ, in ODIFAJLFLNC KCIMCONOGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x35DA2E0", Offset = "0x35D8EE0", VA = "0x1835DA2E0")]
		public void CMEJNNPKBOP(KFMKFJINGPH EJOAECOFOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x35DBF80", Offset = "0x35DAB80", VA = "0x1835DBF80")]
		private void PFCNNDHAALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x35DB970", Offset = "0x35DA570", VA = "0x1835DB970")]
		private void NDJCHBCEIEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x35DB9B0", Offset = "0x35DA5B0", VA = "0x1835DB9B0")]
		private void NLMGMIMHKMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x35DA010", Offset = "0x35D8C10", VA = "0x1835DA010")]
		private IKAEPEMHKHH AAGMBDNKKCF()
		{
			return default(IKAEPEMHKHH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x35DB950", Offset = "0x35DA550", VA = "0x1835DB950")]
		private uint NDHDCNICBLM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x35DB570", Offset = "0x35DA170", VA = "0x1835DB570")]
		private bool JBHPNCLGEPH(out IKAEPEMHKHH MNJNLIAKBME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x35DB260", Offset = "0x35D9E60", VA = "0x1835DB260")]
		private bool HDLLEGCHJCG(out IKAEPEMHKHH MNJNLIAKBME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x35DB590", Offset = "0x35DA190", VA = "0x1835DB590")]
		private RedoAction JFIBABIIHAC(IKAEPEMHKHH MNJNLIAKBME)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x35DBE70", Offset = "0x35DAA70", VA = "0x1835DBE70")]
		private UndoAction OONKKDMKLPB(IKAEPEMHKHH MNJNLIAKBME)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x35DB9D0", Offset = "0x35DA5D0", VA = "0x1835DB9D0")]
		private IKAEPEMHKHH NMCJLMPAHOK(IKAEPEMHKHH MNJNLIAKBME, ActionBuffer NHEDIFDPOOG, bool BNJLFDPCIFI)
		{
			return default(IKAEPEMHKHH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x35DA140", Offset = "0x35D8D40", VA = "0x1835DA140")]
		private void AMEMPNFNIBA(Action MNJNLIAKBME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2C72A80", Offset = "0x2C71680", VA = "0x182C72A80")]
		private T AMEMPNFNIBA<T>(Func<T> EIMBHBEPIKG)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x35DB800", Offset = "0x35DA400", VA = "0x1835DB800")]
		private OHPBCDIBBJF LKONMBGCNCN(bool BNJLFDPCIFI, uint OLOLCGEOMNE)
		{
			return default(OHPBCDIBBJF);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x35DC290", Offset = "0x35DAE90", VA = "0x1835DC290")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x35DB5F0", Offset = "0x35DA1F0", VA = "0x1835DB5F0")]
		[CompilerGenerated]
		private UndoAction JLLHBJLJCKK()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x35DA450", Offset = "0x35D9050", VA = "0x1835DA450")]
		[CompilerGenerated]
		private RedoAction DEHGPJDLBAB()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x35DB100", Offset = "0x35D9D00", VA = "0x1835DB100")]
		[CompilerGenerated]
		private UndoAction GLJHMONDFDG()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class KEOGBBDOEIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NativeArray<byte> NMDKCEHJACP;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int JGBMPNHDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x1362210", Offset = "0x1360E10", VA = "0x181362210")]
	public KEOGBBDOEIN(NativeArray<byte> NMDKCEHJACP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x35E3610", Offset = "0x35E2210", VA = "0x1835E3610")]
	public static KEOGBBDOEIN GGDPAIJEDCE(NativeArray<byte> NMDKCEHJACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	public T AINEJELOIFN<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	public NativeArray<T> PGIBMKJKHLD<T>(int LNLAAEPHJPC, Allocator JMMNDPMBMFC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	public NativeArray<T> MCOJLCHFLLP<T>(Allocator JMMNDPMBMFC) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class PDPLGDAKMIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NativeArray<byte> NMDKCEHJACP;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public int JGBMPNHDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x1362210", Offset = "0x1360E10", VA = "0x181362210")]
	public PDPLGDAKMIC(NativeArray<byte> NMDKCEHJACP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3098930", Offset = "0x3097530", VA = "0x183098930")]
	public static PDPLGDAKMIC GGDPAIJEDCE(NativeArray<byte> NMDKCEHJACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BF10", Offset = "0x2A0AB10", VA = "0x182A0BF10")]
	public T AINEJELOIFN<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	public NativeArray<T> PGIBMKJKHLD<T>(int LNLAAEPHJPC, Allocator JMMNDPMBMFC) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class DHANCJFOPDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private NativeArray<byte> NMDKCEHJACP;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int JGBMPNHDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1362210", Offset = "0x1360E10", VA = "0x181362210")]
	public DHANCJFOPDG(NativeArray<byte> NMDKCEHJACP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x31B0CA0", Offset = "0x31AF8A0", VA = "0x1831B0CA0")]
	public static DHANCJFOPDG GGDPAIJEDCE(NativeArray<byte> NMDKCEHJACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x2556620", Offset = "0x2555220", VA = "0x182556620")]
	public void AANCNMFJLMI<T>(in T NENFOEKGNGK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2556680", Offset = "0x2555280", VA = "0x182556680")]
	public void AGPLPEOFCPA<T>(NativeArray<T> CJMCKLJFKJI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	public void EPPDDAAGBKI<T>(NativeArray<T> NENFOEKGNGK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class IAECBBJLMKC
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x35DD110", Offset = "0x35DBD10", VA = "0x1835DD110")]
	public static Span<byte> LDEHEGGBBPD(this NativeArray<byte> NMDKCEHJACP)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x35DCF90", Offset = "0x35DBB90", VA = "0x1835DCF90")]
	public static ReadOnlySpan<byte> KNOADGKEFEB(this NativeArray<byte> NMDKCEHJACP)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x35DD300", Offset = "0x35DBF00", VA = "0x1835DD300")]
	public static NativeArray<byte> PIOGODFBJOG(this NativeArray<byte> NMDKCEHJACP, int IOMMLLJBIGB)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x35DCE90", Offset = "0x35DBA90", VA = "0x1835DCE90")]
	public static NativeArray<byte> BFLKHOMFNHM(this NativeArray<byte> NMDKCEHJACP, int GGKDNLHEHMD = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2C74480", Offset = "0x2C73080", VA = "0x182C74480")]
	public static NativeArray<byte> BFLKHOMFNHM<T>(this NativeArray<byte> NMDKCEHJACP, int GGKDNLHEHMD = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x35DD290", Offset = "0x35DBE90", VA = "0x1835DD290")]
	public static NativeArray<byte> OHLKPLJLMNK(this NativeArray<byte> NMDKCEHJACP, int GGKDNLHEHMD)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2C75A20", Offset = "0x2C74620", VA = "0x182C75A20")]
	public static NativeArray<byte> OHLKPLJLMNK<T>(this NativeArray<byte> NMDKCEHJACP, int GGKDNLHEHMD = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x35DCF10", Offset = "0x35DBB10", VA = "0x1835DCF10")]
	public static NativeArray<byte> KCGGMAFOCBO(this NativeArray<byte> NMDKCEHJACP, int GGKDNLHEHMD = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2C744E0", Offset = "0x2C730E0", VA = "0x182C744E0")]
	public static NativeArray<byte> KCGGMAFOCBO<T>(this NativeArray<byte> NMDKCEHJACP, int GGKDNLHEHMD = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class PEHODDHIIHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private NativeList<byte> FOLHIKGIGJA;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1362210", Offset = "0x1360E10", VA = "0x181362210")]
	public PEHODDHIIHE(NativeList<byte> FOLHIKGIGJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3098990", Offset = "0x3097590", VA = "0x183098990")]
	public static PEHODDHIIHE GGDPAIJEDCE(NativeList<byte> NMDKCEHJACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public void AANCNMFJLMI<T>(in T NENFOEKGNGK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public void AGPLPEOFCPA<T>(NativeArray<T> NENFOEKGNGK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public void EPPDDAAGBKI<T>(NativeArray<T> NENFOEKGNGK) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	[HJBMNHLGPOF(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.PropertyChanges)]
	public class PropertyChangeNetworkRouter : AHBNMIIEDML, BLCFKNFGJJJ, HAPMABPDHHK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[NNMLOJPMNKB]
		private HEPOFMDEONM GPEIELKLHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[NNMLOJPMNKB]
		private GOLLMGIECKP MBLNNIKAAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[NNMLOJPMNKB]
		private GGIGBKCIJFH LLKIGIMOEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[NNMLOJPMNKB]
		private PropertyChangeRouterService OOMGBAGIIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private OMHELAJGNAP CEKFHLPOBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private AMPFNOBIAML FPCFBNCLFDG;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public OMHELAJGNAP GAMBIGCOPEG
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x30A1B90", Offset = "0x30A0790", VA = "0x1830A1B90")]
		public OMHELAJGNAP.MPIHGGNFCEG JGCHPOLDOCM()
		{
			return default(OMHELAJGNAP.MPIHGGNFCEG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x30A2140", Offset = "0x30A0D40", VA = "0x1830A2140", Slot = "4")]
		public void PHKHGJFAMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x30A17C0", Offset = "0x30A03C0", VA = "0x1830A17C0", Slot = "5")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x30A14E0", Offset = "0x30A00E0", VA = "0x1830A14E0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x30A13D0", Offset = "0x309FFD0", VA = "0x1830A13D0")]
		public void BPEJJHBJHLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x30A1B40", Offset = "0x30A0740", VA = "0x1830A1B40")]
		public void GGNFLDPHLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x30A2030", Offset = "0x30A0C30", VA = "0x1830A2030")]
		private void NFLCMCNOCHC(KFMKFJINGPH EJOAECOFOFF, IGIIAIKJJLE OJPDCALHNDJ, bool HEDFLCHCPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x30A1320", Offset = "0x309FF20", VA = "0x1830A1320")]
		private void BEJNFEJNGCO(KFMKFJINGPH EJOAECOFOFF, FOCFMDNOICJ FHMECPEDGNJ, ODIFAJLFLNC HKDANJEKEFE, ODIFAJLFLNC KCIMCONOGCA, bool HEDFLCHCPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x30A1A40", Offset = "0x30A0640", VA = "0x1830A1A40")]
		private void FGHLOLFOPLA(KFMKFJINGPH EJOAECOFOFF, bool HEDFLCHCPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x30A1CE0", Offset = "0x30A08E0", VA = "0x1830A1CE0")]
		private void NAPGIIODACO(AMPFNOBIAML CNJLPBGBOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x30A11D0", Offset = "0x309FDD0", VA = "0x1830A11D0")]
		private void BBMBHCPPKIO(AMPFNOBIAML CNJLPBGBOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x30A1700", Offset = "0x30A0300", VA = "0x1830A1700")]
		private void EBKIPHGDBMF(AMPFNOBIAML CNJLPBGBOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x30A1BD0", Offset = "0x30A07D0", VA = "0x1830A1BD0")]
		private void JKLEFHOAAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x30A1B70", Offset = "0x30A0770", VA = "0x1830A1B70")]
		private void GKMLDGEOLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x30A1BF0", Offset = "0x30A07F0", VA = "0x1830A1BF0")]
		private void LIHBOALKDKP(AMPFNOBIAML CNJLPBGBOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x419F630", Offset = "0x419E230", VA = "0x18419F630", Slot = "6")]
		private void PILLECLBAFC<TKey, T>(global::BOGNFFDCMBC<TKey, T> FCPNPIIHNJJ, object MAMKOIKAADI) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[GKALNADHNEP(DAHLALKJFLL.History)]
	[HJBMNHLGPOF(typeof(PropertyChangeRouterService), new string[] { })]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public delegate void CHLJKHPJGNB(KFMKFJINGPH EJOAECOFOFF, IGIIAIKJJLE OJPDCALHNDJ, bool HEDFLCHCPOL);

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public delegate void NGOMFGPPJKP(KFMKFJINGPH EJOAECOFOFF, FOCFMDNOICJ FHMECPEDGNJ, ODIFAJLFLNC HKDANJEKEFE, ODIFAJLFLNC KCIMCONOGCA, bool HEDFLCHCPOL);

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void HPNBFCELNMD(KFMKFJINGPH EJOAECOFOFF, bool HEDFLCHCPOL);

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public CHLJKHPJGNB NBONEDNFGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public NGOMFGPPJKP OANABCKBHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public HPNBFCELNMD LFFHDJLOGBM;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x30A22A0", Offset = "0x30A0EA0", VA = "0x1830A22A0")]
		public void DALGLOOJHAM(KFMKFJINGPH EJOAECOFOFF, IGIIAIKJJLE OJPDCALHNDJ, bool HEDFLCHCPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x30A22C0", Offset = "0x30A0EC0", VA = "0x1830A22C0")]
		public void NNANFIFGNIH(KFMKFJINGPH EJOAECOFOFF, FOCFMDNOICJ FHMECPEDGNJ, in ODIFAJLFLNC HKDANJEKEFE, in ODIFAJLFLNC KCIMCONOGCA, bool HEDFLCHCPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x30A2280", Offset = "0x30A0E80", VA = "0x1830A2280")]
		public void CMEJNNPKBOP(KFMKFJINGPH EJOAECOFOFF, bool HEDFLCHCPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[DebuggerTypeProxy(typeof(CJMHDENCGPA))]
	[GKALNADHNEP(DAHLALKJFLL.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		internal class CJMHDENCGPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly ActionBuffer MMDGIKEBLFM;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int GEHHFJONLGN
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x332BDF0", Offset = "0x332A9F0", VA = "0x18332BDF0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public OIPFBNDHGOO[] GPDOGOPFNKA
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x332BD20", Offset = "0x332A920", VA = "0x18332BD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
			public CJMHDENCGPA(ActionBuffer FAMOPCJLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x332BE40", Offset = "0x332AA40", VA = "0x18332BE40")]
			[CompilerGenerated]
			private OIPFBNDHGOO JDHCCKGBEBG(IKAEPEMHKHH MNJNLIAKBME)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		internal class OIPFBNDHGOO : HAPMABPDHHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly ActionBuffer MMDGIKEBLFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly IKAEPEMHKHH MNJNLIAKBME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private List<(AMPFNOBIAML, string, object)> AKFDIHCNLLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private PDPLGDAKMIC OFAOLOCAHKK;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public int GEHHFJONLGN
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x332F9C0", Offset = "0x332E5C0", VA = "0x18332F9C0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public List<(AMPFNOBIAML, string, object)> DHNGGFCOACC
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x332FE50", Offset = "0x332EA50", VA = "0x18332FE50")]
			public OIPFBNDHGOO(ActionBuffer FAMOPCJLCNI, IKAEPEMHKHH MNJNLIAKBME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x332FA10", Offset = "0x332E610", VA = "0x18332FA10")]
			private string HOKDINDBCOA(AMPFNOBIAML FPCFBNCLFDG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x332FB10", Offset = "0x332E710", VA = "0x18332FB10")]
			private void OEKJIJPBJKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x2EC2A80", Offset = "0x2EC1680", VA = "0x182EC2A80", Slot = "4")]
			public void PNDJKENIJFE<TKey, T>(global::BOGNFFDCMBC<TKey, T> FCPNPIIHNJJ, [Optional] object MAMKOIKAADI) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private NativeList<byte> PGOAEBLMINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Stack<IKAEPEMHKHH> IEKLOCPHEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly BCAFKEKHIKE BPHKDBJMNNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly BKAMJJFLMHO FBDEICGFAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly GOLLMGIECKP MBLNNIKAAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly bool OIBCCCEPKCH;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public HCPPBAALMIA LEMCHMBGFHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x319B500", Offset = "0x319A100", VA = "0x18319B500")]
			get
			{
				return default(HCPPBAALMIA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int GEHHFJONLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x319AC00", Offset = "0x3199800", VA = "0x18319AC00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x319B8D0", Offset = "0x319A4D0", VA = "0x18319B8D0")]
		public ActionBuffer(BKAMJJFLMHO FBDEICGFAKB, GOLLMGIECKP MBLNNIKAAIG, bool OIBCCCEPKCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x319AFE0", Offset = "0x3199BE0", VA = "0x18319AFE0")]
		public bool GBODKCOJPAN(out IKAEPEMHKHH MNJNLIAKBME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x319B070", Offset = "0x3199C70", VA = "0x18319B070")]
		public void GGNFLDPHLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x319AC40", Offset = "0x3199840", VA = "0x18319AC40")]
		public IKAEPEMHKHH BPEJJHBJHLN(IDLDLIPPPOF AKFDIHCNLLI, EFPGJFHDIFM MLFHIDMIELC, uint LNCPDEKGBMJ)
		{
			return default(IKAEPEMHKHH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x319B0E0", Offset = "0x3199CE0", VA = "0x18319B0E0")]
		public bool HIAJPECDOEI(uint LNCPDEKGBMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x319ADF0", Offset = "0x31999F0", VA = "0x18319ADF0")]
		public bool EKHGLFPLFDE(uint LNCPDEKGBMJ, out IKAEPEMHKHH GNFCHOKJPJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x319B650", Offset = "0x319A250", VA = "0x18319B650")]
		public void OIENFGOAIIJ(IKAEPEMHKHH GNFCHOKJPJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x319B170", Offset = "0x3199D70", VA = "0x18319B170")]
		[Conditional("DEBUG_BUILD")]
		private void KBENILAGJEO(IKAEPEMHKHH GNFCHOKJPJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x319B540", Offset = "0x319A140", VA = "0x18319B540")]
		private void NMCJLMPAHOK(IKAEPEMHKHH PFGNDBGMDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x319B2B0", Offset = "0x3199EB0", VA = "0x18319B2B0")]
		private void LDDFOKLGEIO(PDPLGDAKMIC GGNOJFHJPIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x319B110", Offset = "0x3199D10", VA = "0x18319B110")]
		private void JLICGBNENBA(IKAEPEMHKHH MNJNLIAKBME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x319B7C0", Offset = "0x319A3C0", VA = "0x18319B7C0")]
		private PDPLGDAKMIC OPBPOMAIOAJ(IKAEPEMHKHH MNJNLIAKBME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x319AD80", Offset = "0x3199980", VA = "0x18319AD80", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class BCAFKEKHIKE : HAPMABPDHHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly BKAMJJFLMHO FBDEICGFAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly GOLLMGIECKP MBLNNIKAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private KFMKFJINGPH EJOAECOFOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private PDPLGDAKMIC CDPIKPBMDNI;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x733BB0", Offset = "0x7327B0", VA = "0x180733BB0")]
	public BCAFKEKHIKE(BKAMJJFLMHO FBDEICGFAKB, GOLLMGIECKP MBLNNIKAAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C5BC60", Offset = "0x2C5A860", VA = "0x182C5BC60", Slot = "4")]
	public void PNDJKENIJFE<TKey, T>(global::BOGNFFDCMBC<TKey, T> OJEANEJJMFE, [Optional] object MAMKOIKAADI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x319CF30", Offset = "0x319BB30", VA = "0x18319CF30")]
	public void HNMKKLJOBAM(AMPFNOBIAML FPCFBNCLFDG, ref PDPLGDAKMIC GGNOJFHJPIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class OMHELAJGNAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct MPIHGGNFCEG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly OMHELAJGNAP NIGFDFKEKGM;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x43AEBE0", Offset = "0x43AD7E0", VA = "0x1843AEBE0")]
		public MPIHGGNFCEG(OMHELAJGNAP NIGFDFKEKGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x43AEBC0", Offset = "0x43AD7C0", VA = "0x1843AEBC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected IDLDLIPPPOF AKFDIHCNLLI;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IDLDLIPPPOF DHNGGFCOACC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x308C260", Offset = "0x308AE60", VA = "0x18308C260")]
		get
		{
			return default(IDLDLIPPPOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool LHOMIONEHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x308BDA0", Offset = "0x308A9A0", VA = "0x18308BDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x308C2A0", Offset = "0x308AEA0", VA = "0x18308C2A0")]
	public OMHELAJGNAP(IDLDLIPPPOF.LLEAGMDGGMP FOGILNMKPAD = IDLDLIPPPOF.LLEAGMDGGMP.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x308BF90", Offset = "0x308AB90", VA = "0x18308BF90")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x308BE90", Offset = "0x308AA90", VA = "0x18308BE90")]
	public void DALGLOOJHAM(KFMKFJINGPH EJOAECOFOFF, IGIIAIKJJLE OJPDCALHNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x308C1D0", Offset = "0x308ADD0", VA = "0x18308C1D0")]
	public void NNANFIFGNIH(KFMKFJINGPH EJOAECOFOFF, FOCFMDNOICJ FHMECPEDGNJ, in ODIFAJLFLNC KCIMCONOGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x308BDB0", Offset = "0x308A9B0", VA = "0x18308BDB0")]
	public void CMEJNNPKBOP(KFMKFJINGPH EJOAECOFOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x308C0D0", Offset = "0x308ACD0", VA = "0x18308C0D0")]
	public void JKLEFHOAAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x308BFA0", Offset = "0x308ABA0", VA = "0x18308BFA0")]
	public void GKMLDGEOLHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x308BF80", Offset = "0x308AB80", VA = "0x18308BF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x308C0A0", Offset = "0x308ACA0", VA = "0x18308C0A0")]
	public MPIHGGNFCEG JGCHPOLDOCM()
	{
		return default(MPIHGGNFCEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct AMPFNOBIAML : IComparable<AMPFNOBIAML>, IEquatable<AMPFNOBIAML>
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static readonly AMPFNOBIAML EABHPAGIEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public KFMKFJINGPH EJOAECOFOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public FOCFMDNOICJ FHMECPEDGNJ;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool BPOKJGMAKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2FA1E30", Offset = "0x2FA0A30", VA = "0x182FA1E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x702C80", Offset = "0x701880", VA = "0x180702C80")]
	public AMPFNOBIAML(KFMKFJINGPH EJOAECOFOFF, FOCFMDNOICJ FHMECPEDGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x319A710", Offset = "0x3199310", VA = "0x18319A710")]
	public void FIDFMNBBKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x319A5E0", Offset = "0x31991E0", VA = "0x18319A5E0", Slot = "4")]
	public int CompareTo(AMPFNOBIAML GHLMPEGFGCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x319A7A0", Offset = "0x31993A0", VA = "0x18319A7A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x319A670", Offset = "0x3199270", VA = "0x18319A670", Slot = "0")]
	public override bool Equals(object AOEMDAGAALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x319A620", Offset = "0x3199220", VA = "0x18319A620", Slot = "5")]
	public bool Equals(AMPFNOBIAML GHLMPEGFGCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x319A760", Offset = "0x3199360", VA = "0x18319A760")]
	public static bool HIPCOIHOPDI(AMPFNOBIAML NEDFKMIBIEI, AMPFNOBIAML FMLJLFCAJGB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x319A590", Offset = "0x3199190", VA = "0x18319A590")]
	public static bool AMPJPPMBCJP(AMPFNOBIAML NEDFKMIBIEI, AMPFNOBIAML FMLJLFCAJGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x319A720", Offset = "0x3199320", VA = "0x18319A720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[GKALNADHNEP(DAHLALKJFLL.History)]
	public class GatherPropertiesForUndelete : KPFEFKKAOKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private BKAMJJFLMHO FBDEICGFAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private KFMKFJINGPH EJOAECOFOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private HistoryService MCAOIMGHJGL;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x35D6540", Offset = "0x35D5140", VA = "0x1835D6540")]
		public void KOMEHOAJBND(KFMKFJINGPH EJOAECOFOFF, BKAMJJFLMHO FBDEICGFAKB, HistoryService MCAOIMGHJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x35D6470", Offset = "0x35D5070", VA = "0x1835D6470", Slot = "4")]
		private void KAILCLFDBOG(CAOLLMGGINC FCPNPIIHNJJ, in ODIFAJLFLNC NENFOEKGNGK, object MAMKOIKAADI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NJMJIJBKINB
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x3085690", Offset = "0x3084290", VA = "0x183085690")]
	public static void BBMBHCPPKIO(IDLDLIPPPOF AKFDIHCNLLI, AMPFNOBIAML FPCFBNCLFDG, IGIIAIKJJLE OJPDCALHNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x30857E0", Offset = "0x30843E0", VA = "0x1830857E0")]
	public static void HONADLBEDJN(IDLDLIPPPOF AKFDIHCNLLI, AMPFNOBIAML FPCFBNCLFDG, in ODIFAJLFLNC KCIMCONOGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3085790", Offset = "0x3084390", VA = "0x183085790")]
	public static void EBKIPHGDBMF(IDLDLIPPPOF AKFDIHCNLLI, AMPFNOBIAML FPCFBNCLFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3085940", Offset = "0x3084540", VA = "0x183085940")]
	public static void PNICCFNMJBJ(IDLDLIPPPOF AKFDIHCNLLI, AMPFNOBIAML FPCFBNCLFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x30858A0", Offset = "0x30844A0", VA = "0x1830858A0")]
	public static IGIIAIKJJLE KHFHIACEANE(IDLDLIPPPOF AKFDIHCNLLI, AMPFNOBIAML FPCFBNCLFDG)
	{
		return default(IGIIAIKJJLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3B33450", Offset = "0x3B32050", VA = "0x183B33450")]
	public static T PDNIFJLKLIM<T>(IDLDLIPPPOF AKFDIHCNLLI, AMPFNOBIAML FPCFBNCLFDG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x3B33470", Offset = "0x3B32070", VA = "0x183B33470")]
	public static T PDNIFJLKLIM<T>(ref PDPLGDAKMIC GAGLKGONONJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x30858F0", Offset = "0x30844F0", VA = "0x1830858F0")]
	public static IGIIAIKJJLE KHFHIACEANE(ref PDPLGDAKMIC GAGLKGONONJ)
	{
		return default(IGIIAIKJJLE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct IDLDLIPPPOF : IEnumerable<AMPFNOBIAML>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum LLEAGMDGGMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct OMLOENBEGEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly IDLDLIPPPOF FOLHIKGIGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly EFPGJFHDIFM MLFHIDMIELC;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x43B0180", Offset = "0x43AED80", VA = "0x1843B0180")]
		public OMLOENBEGEK(IDLDLIPPPOF FOLHIKGIGJA, EFPGJFHDIFM MLFHIDMIELC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x43AF960", Offset = "0x43AE560", VA = "0x1843AF960")]
		public void CICCNCOFHHD(NativeList<byte> LBBCPGHIOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x43AFC00", Offset = "0x43AE800", VA = "0x1843AFC00")]
		private void JDKDMCDLBEL(AMPFNOBIAML FPCFBNCLFDG, ref DHANCJFOPDG EBGBKAMCMDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x43AFC50", Offset = "0x43AE850", VA = "0x1843AFC50")]
		private void LCPAAKFAECL(AMPFNOBIAML FPCFBNCLFDG, ref DHANCJFOPDG EBGBKAMCMDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x43AF870", Offset = "0x43AE470", VA = "0x1843AF870")]
		private NativeArray<byte> BJOHKIFGHKM(NativeList<byte> LBBCPGHIOFP)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x43AFCE0", Offset = "0x43AE8E0", VA = "0x1843AFCE0")]
		private NativeArray<byte> LHJFFCAPOHK(NativeList<byte> LBBCPGHIOFP, int LNLAAEPHJPC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x43AFDD0", Offset = "0x43AE9D0", VA = "0x1843AFDD0")]
		private int MBCFEKPGMFF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x43B0020", Offset = "0x43AEC20", VA = "0x1843B0020")]
		private bool MFGFEFOOEAP(AMPFNOBIAML FPCFBNCLFDG, out NativeArray<byte> HIKOMFGOCLH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct BPEJKMMLLHP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NativeList<byte> GAGLKGONONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private IDLDLIPPPOF FOLHIKGIGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly AMPFNOBIAML CNJLPBGBOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly int IOMMLLJBIGB;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x43A6F50", Offset = "0x43A5B50", VA = "0x1843A6F50")]
		internal BPEJKMMLLHP(IDLDLIPPPOF FOLHIKGIGJA, AMPFNOBIAML CNJLPBGBOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x43A6CD0", Offset = "0x43A58D0", VA = "0x1843A6CD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x43A6D00", Offset = "0x43A5900", VA = "0x1843A6D00")]
		public void FFEJMBONBBE(NativeArray<byte> NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x43A6D60", Offset = "0x43A5960", VA = "0x1843A6D60")]
		public void FJONDNJPDCM(NativeArray<byte> NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x43A6DC0", Offset = "0x43A59C0", VA = "0x1843A6DC0")]
		public void LCPAAKFAECL(in ODIFAJLFLNC NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x300F3A0", Offset = "0x300DFA0", VA = "0x18300F3A0")]
		public void LCPAAKFAECL<T>(T NENFOEKGNGK) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x43A6EE0", Offset = "0x43A5AE0", VA = "0x1843A6EE0")]
		private void OENGKIPMKNA(int NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x43A6E30", Offset = "0x43A5A30", VA = "0x1843A6E30")]
		private void OENGKIPMKNA(in ODIFAJLFLNC NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x43A6DD0", Offset = "0x43A59D0", VA = "0x1843A6DD0")]
		private unsafe void OENGKIPMKNA(void* KIEPAJMKIEO, int LNLAAEPHJPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x43A6D00", Offset = "0x43A5900", VA = "0x1843A6D00")]
		private void OENGKIPMKNA(NativeArray<byte> CJMCKLJFKJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct LHKEHCDNHPF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private IDLDLIPPPOF FOLHIKGIGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NativeArray<byte> GAGLKGONONJ;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x43ACC80", Offset = "0x43AB880", VA = "0x1843ACC80")]
		internal LHKEHCDNHPF(IDLDLIPPPOF FOLHIKGIGJA, NativeArray<byte> GAGLKGONONJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x43ACAC0", Offset = "0x43AB6C0", VA = "0x1843ACAC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x43ACBC0", Offset = "0x43AB7C0", VA = "0x1843ACBC0")]
		public NativeArray<byte> PGIBMKJKHLD(int LNLAAEPHJPC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x43ACAD0", Offset = "0x43AB6D0", VA = "0x1843ACAD0")]
		public NativeArray<byte> MCOJLCHFLLP()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x30130A0", Offset = "0x3011CA0", VA = "0x1830130A0")]
		public T AINEJELOIFN<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x43AC9C0", Offset = "0x43AB5C0", VA = "0x1843AC9C0")]
		public void AINEJELOIFN(in DADHEMOPEJD NENFOEKGNGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct DCICPFAEGDL : IEnumerator<AMPFNOBIAML>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly NativeList<AMPFNOBIAML> NMDKCEHJACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private int KLEGICPDLIF;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public AMPFNOBIAML LEMCHMBGFHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x43A7DD0", Offset = "0x43A69D0", VA = "0x1843A7DD0", Slot = "4")]
			get
			{
				return default(AMPFNOBIAML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x43A7D90", Offset = "0x43A6990", VA = "0x1843A7D90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x35F0A70", Offset = "0x35EF670", VA = "0x1835F0A70")]
		internal DCICPFAEGDL(NativeList<AMPFNOBIAML> CJMCKLJFKJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x43A7C50", Offset = "0x43A6850", VA = "0x1843A7C50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x43A7D50", Offset = "0x43A6950", VA = "0x1843A7D50", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct IAMADICAMJI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private const int JMKBDMPMJLI = 0;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private const int CIDDCNNDDDP = 1;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private const int HPLBCCNLPCP = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private NativeArray<int> GAGLKGONONJ;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool LLDLPKJFACL
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x43AB0F0", Offset = "0x43A9CF0", VA = "0x1843AB0F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public int LJLKOFODBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x43AB0E0", Offset = "0x43A9CE0", VA = "0x1843AB0E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x43AB130", Offset = "0x43A9D30", VA = "0x1843AB130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public LLEAGMDGGMP EHBDGOMDIBA
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x43AB140", Offset = "0x43A9D40", VA = "0x1843AB140")]
			get
			{
				return default(LLEAGMDGGMP);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x43AB050", Offset = "0x43A9C50", VA = "0x1843AB050")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool LHOMIONEHIO
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x43AB000", Offset = "0x43A9C00", VA = "0x1843AB000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x43AB150", Offset = "0x43A9D50", VA = "0x1843AB150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool HLODCPPDJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x43AB0A0", Offset = "0x43A9CA0", VA = "0x1843AB0A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x43AB170", Offset = "0x43A9D70", VA = "0x1843AB170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x43AB190", Offset = "0x43A9D90", VA = "0x1843AB190")]
		public IAMADICAMJI(LLEAGMDGGMP FOGILNMKPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x43AB0B0", Offset = "0x43A9CB0", VA = "0x1843AB0B0")]
		private int FABELHKIKFB(int IHKOJLKELAD, int JMMBGDBPFMD = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x43AB010", Offset = "0x43A9C10", VA = "0x1843AB010")]
		private void CKBKODEFPCJ(int IHKOJLKELAD, int NENFOEKGNGK, int JMMBGDBPFMD = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x43AB060", Offset = "0x43A9C60", VA = "0x1843AB060", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private const int PFFILNEKFEL = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private const int JBDPBMMFKFJ = 0;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly AMPFNOBIAML NOPHLLEEMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private NativeHashMap<AMPFNOBIAML, int> LPAOCJLOJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private NativeList<AMPFNOBIAML> AKFDIHCNLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private NativeList<int> HKHOHDKKFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private NativeList<byte> HEDEDPHDGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private NativeList<byte> GAGLKGONONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private IAMADICAMJI FPLMCNNAFEE;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool LHOMIONEHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x35DD3C0", Offset = "0x35DBFC0", VA = "0x1835DD3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool OMCBBNHKCKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x35DDF50", Offset = "0x35DCB50", VA = "0x1835DDF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int LJLKOFODBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x35DD6D0", Offset = "0x35DC2D0", VA = "0x1835DD6D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int GNPPEIJJFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x35DD380", Offset = "0x35DBF80", VA = "0x1835DD380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool LLDLPKJFACL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x35DD6E0", Offset = "0x35DC2E0", VA = "0x1835DD6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x35DDDF0", Offset = "0x35DC9F0", VA = "0x1835DDDF0")]
	public static IDLDLIPPPOF NBONEDNFGGC(LLEAGMDGGMP FOGILNMKPAD = LLEAGMDGGMP.Last, int FCHNFFFOCGM = 16, int POJLKDIEEEB = 256)
	{
		return default(IDLDLIPPPOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x35DE070", Offset = "0x35DCC70", VA = "0x1835DE070")]
	private IDLDLIPPPOF(LLEAGMDGGMP FOGILNMKPAD, int FCHNFFFOCGM, int POJLKDIEEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x35DD4C0", Offset = "0x35DC0C0", VA = "0x1835DD4C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x35DDD60", Offset = "0x35DC960", VA = "0x1835DDD60")]
	public BPEJKMMLLHP NAPGIIODACO(AMPFNOBIAML CNJLPBGBOKD)
	{
		return default(BPEJKMMLLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x35DDAE0", Offset = "0x35DC6E0", VA = "0x1835DDAE0")]
	public LHKEHCDNHPF LGPMCDJJCLI(AMPFNOBIAML CNJLPBGBOKD)
	{
		return default(LHKEHCDNHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x35DDB70", Offset = "0x35DC770", VA = "0x1835DDB70")]
	public bool MIGDLGMGGIJ(AMPFNOBIAML CNJLPBGBOKD, out LHKEHCDNHPF HDECCMEOGJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x35DDF00", Offset = "0x35DCB00", VA = "0x1835DDF00")]
	public bool OONBNIMMMNA(AMPFNOBIAML CNJLPBGBOKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x35DDE30", Offset = "0x35DCA30", VA = "0x1835DDE30")]
	public bool NEKFMHCJJMI(AMPFNOBIAML CNJLPBGBOKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x35DD3D0", Offset = "0x35DBFD0", VA = "0x1835DD3D0")]
	public void CFDJKNBAJHD(NativeList<byte> LBBCPGHIOFP, EFPGJFHDIFM MLFHIDMIELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C750", Offset = "0x2C7B350", VA = "0x182C7C750")]
	public T LGHOHGDAHCA<T>(AMPFNOBIAML CNJLPBGBOKD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x35DD910", Offset = "0x35DC510", VA = "0x1835DD910")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x35DD5A0", Offset = "0x35DC1A0", VA = "0x1835DD5A0")]
	public DCICPFAEGDL EEAMIAJAFGO()
	{
		return default(DCICPFAEGDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x35DD720", Offset = "0x35DC320", VA = "0x1835DD720")]
	private void GENIBBACCIB(AMPFNOBIAML CNJLPBGBOKD, int IOMMLLJBIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x35DD5E0", Offset = "0x35DC1E0", VA = "0x1835DD5E0")]
	private void FIDFMNBBKBN(int LJKBKIEKNPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x35DD9F0", Offset = "0x35DC5F0", VA = "0x1835DD9F0")]
	private void IAHKAECLCEE(AMPFNOBIAML CNJLPBGBOKD, int IOMMLLJBIGB, int LNLAAEPHJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C6D0", Offset = "0x2C7B2D0", VA = "0x182C7C6D0")]
	private static T LGHOHGDAHCA<T>(NativeArray<byte> NMDKCEHJACP, int IHKOJLKELAD = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x35DDFB0", Offset = "0x35DCBB0", VA = "0x1835DDFB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x35DDF70", Offset = "0x35DCB70", VA = "0x1835DDF70", Slot = "4")]
	private IEnumerator<AMPFNOBIAML> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Preserve]
internal sealed class OJACHFPEKPF<T> : IKDACLPDLNJ where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private EntityQuery GJLGONPKKFL;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2F9FCB0", Offset = "0x2F9E8B0", VA = "0x182F9FCB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2F9FDD0", Offset = "0x2F9E9D0", VA = "0x182F9FDD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2F9FE40", Offset = "0x2F9EA40", VA = "0x182F9FE40")]
	public OJACHFPEKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2F9FC90", Offset = "0x2F9E890", VA = "0x182F9FC90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	internal class CleanupRigidbodyExImpl : IKDACLPDLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private EntityQuery GJLGONPKKFL;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x31A4A40", Offset = "0x31A3640", VA = "0x1831A4A40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x31A4AE0", Offset = "0x31A36E0", VA = "0x1831A4AE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Preserve]
internal class FFJPHFMPLNK : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private EntityQuery BPNFCKPIIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x35D1B10", Offset = "0x35D0710", VA = "0x1835D1B10", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x35D1B60", Offset = "0x35D0760", VA = "0x1835D1B60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x35D1BF0", Offset = "0x35D07F0", VA = "0x1835D1BF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public FFJPHFMPLNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
internal class MHJBPIJEFGB : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private PropertyDiffStateService OGIPOJMLAEH;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x35E9410", Offset = "0x35E8010", VA = "0x1835E9410", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x35E9460", Offset = "0x35E8060", VA = "0x1835E9460", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public MHJBPIJEFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private EntityQuery GJLGONPKKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private SceneService LJMHKNOAABK;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x31B2B50", Offset = "0x31B1750", VA = "0x1831B2B50", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x31B2BA0", Offset = "0x31B17A0", VA = "0x1831B2BA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x31B2C30", Offset = "0x31B1830", VA = "0x1831B2C30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[HJBMNHLGPOF(typeof(CullingBandService), new string[] { })]
	[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	public class CullingBandService : BLCFKNFGJJJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly List<global::GFPHNEMLNOJ<NAICAHDKLBJ>> FIELAFDPAJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[NNMLOJPMNKB]
		private HOONHJLELFO GMKNLKMJIPP;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x31ADBA0", Offset = "0x31AC7A0", VA = "0x1831ADBA0", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x31AE060", Offset = "0x31ACC60", VA = "0x1831AE060")]
		public void NGIAFJFOJMO(global::GFPHNEMLNOJ<NAICAHDKLBJ> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x31ADBF0", Offset = "0x31AC7F0", VA = "0x1831ADBF0")]
		public void MMHLAPNEBGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x31ADA30", Offset = "0x31AC630", VA = "0x1831ADA30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x31AE120", Offset = "0x31ACD20", VA = "0x1831AE120")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	[HJBMNHLGPOF(typeof(LJDHCEKPEIN), new string[] { })]
	public class PhysicsService : BLCFKNFGJJJ, JGJNINBGNFN, LJDHCEKPEIN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly FCNKBCOKGMK NLJIHMBGDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private EntityManager JOKFOKELNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private HOONHJLELFO EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private FICBCEGLJFC FHPPAGJLCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private PropertyEventCallbacksService LNOIJGAOPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private global::ILIGGOFIJKG<IGJGJHGBJGI> OEPIMNECGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool JIGLPOGPBPP;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<CGECBEAFDFK, IGJGJHGBJGI> EMGPGBNIJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x309EC10", Offset = "0x309D810", VA = "0x18309EC10", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x309E770", Offset = "0x309D370", VA = "0x18309E770", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x309E960", Offset = "0x309D560", VA = "0x18309E960", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x309E600", Offset = "0x309D200", VA = "0x18309E600", Slot = "5")]
		public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x309E810", Offset = "0x309D410", VA = "0x18309E810", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x309EB40", Offset = "0x309D740", VA = "0x18309EB40", Slot = "8")]
		public bool KLKNKAPHOCK(CGECBEAFDFK HGAMKJKNDDL, out Collider DJJJIMGAJHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x309EA80", Offset = "0x309D680", VA = "0x18309EA80")]
		private void IGPELJDDEHG(Entity BODOHICDFAL, FOCFMDNOICJ FHMECPEDGNJ, ODIFAJLFLNC BNKKPEFEMPA, ODIFAJLFLNC AIGOLOAIBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x309E8A0", Offset = "0x309D4A0", VA = "0x18309E8A0", Slot = "9")]
		public void EPGHHAAAPJD(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[HJBMNHLGPOF(typeof(DLAKHJCBFNN), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	public class RbexService : BLCFKNFGJJJ, DLAKHJCBFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private HOONHJLELFO GMKNLKMJIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private World EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private GKAGBEJKMIF PMPDCMPMAIG;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private EntityManager CNOHAEKAHFB
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x30A4A90", Offset = "0x30A3690", VA = "0x1830A4A90")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x30A55E0", Offset = "0x30A41E0", VA = "0x1830A55E0", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x30A5910", Offset = "0x30A4510", VA = "0x1830A5910", Slot = "6")]
		public OOGACJCDOJG GBIHECHPBEC(CGECBEAFDFK HGAMKJKNDDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x30A4B90", Offset = "0x30A3790", VA = "0x1830A4B90", Slot = "5")]
		public void CGGPMHGBOHK(CGECBEAFDFK HGAMKJKNDDL, OOGACJCDOJG NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x30A6460", Offset = "0x30A5060", VA = "0x1830A6460", Slot = "34")]
		public CollisionDetectionMode KKPFJPFPLCK(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x30A6730", Offset = "0x30A5330", VA = "0x1830A6730", Slot = "35")]
		public void LGHPMFIKFEB(CGECBEAFDFK HGAMKJKNDDL, CollisionDetectionMode NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x30A5270", Offset = "0x30A3E70", VA = "0x1830A5270", Slot = "36")]
		public PIKCEJEDDOK ECHIFIPDIMF(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(PIKCEJEDDOK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x30A72C0", Offset = "0x30A5EC0", VA = "0x1830A72C0", Slot = "37")]
		public void PLMLIFDHECD(CGECBEAFDFK HGAMKJKNDDL, PIKCEJEDDOK NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x30A5B30", Offset = "0x30A4730", VA = "0x1830A5B30", Slot = "38")]
		public bool GMECLKKFCPL(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x30A6890", Offset = "0x30A5490", VA = "0x1830A6890", Slot = "39")]
		public void LOOFGEGAIEC(CGECBEAFDFK HGAMKJKNDDL, bool NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x30A4E90", Offset = "0x30A3A90", VA = "0x1830A4E90", Slot = "40")]
		public CGECBEAFDFK CNPKLEJKNMM(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x30A4E10", Offset = "0x30A3A10", VA = "0x1830A4E10", Slot = "41")]
		public void CNKNFMMBMHB(CGECBEAFDFK HGAMKJKNDDL, CGECBEAFDFK NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x30A6E70", Offset = "0x30A5A70", VA = "0x1830A6E70", Slot = "42")]
		public CGECBEAFDFK OBGHCIILFKA(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x30A5560", Offset = "0x30A4160", VA = "0x1830A5560", Slot = "43")]
		public void FANOFILKGIA(CGECBEAFDFK HGAMKJKNDDL, CGECBEAFDFK NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x30A6620", Offset = "0x30A5220", VA = "0x1830A6620", Slot = "7")]
		public void LFGMLIPOPPB(CGECBEAFDFK HGAMKJKNDDL, CGECBEAFDFK NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x30A5BF0", Offset = "0x30A47F0", VA = "0x1830A5BF0", Slot = "8")]
		public void HHDMGPKPALL(CGECBEAFDFK HGAMKJKNDDL, CGECBEAFDFK NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x30A6190", Offset = "0x30A4D90", VA = "0x1830A6190", Slot = "9")]
		public int JBHPONJDOMF(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x30A5690", Offset = "0x30A4290", VA = "0x1830A5690", Slot = "10")]
		public CGECBEAFDFK FIGJBPANHLK(CGECBEAFDFK HGAMKJKNDDL, int KLEGICPDLIF)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x30A5470", Offset = "0x30A4070", VA = "0x1830A5470", Slot = "11")]
		public void FANMJKCJLDO(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x30A6A60", Offset = "0x30A5660", VA = "0x1830A6A60", Slot = "12")]
		public void MJBHEDLDDAB(CGECBEAFDFK HGAMKJKNDDL, object GIHOLCNOBIB, CGECBEAFDFK NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x30A6350", Offset = "0x30A4F50", VA = "0x1830A6350", Slot = "13")]
		public void KAIHOHAFJLF(CGECBEAFDFK HGAMKJKNDDL, object GIHOLCNOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x30A3EC0", Offset = "0x30A2AC0", VA = "0x1830A3EC0", Slot = "14")]
		public bool ADLGMGBJHMP(CGECBEAFDFK HGAMKJKNDDL, out CGECBEAFDFK NENFOEKGNGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x30A6110", Offset = "0x30A4D10", VA = "0x1830A6110", Slot = "15")]
		public void IJMLAECELOH(CGECBEAFDFK HGAMKJKNDDL, float3 NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x30A64C0", Offset = "0x30A50C0", VA = "0x1830A64C0", Slot = "16")]
		public bool KMPABDCFLMO(CGECBEAFDFK HGAMKJKNDDL, out float3 NENFOEKGNGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x30A4B10", Offset = "0x30A3710", VA = "0x1830A4B10", Slot = "17")]
		public void CGDEHHOBJGC(CGECBEAFDFK HGAMKJKNDDL, float3 NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x30A4150", Offset = "0x30A2D50", VA = "0x1830A4150", Slot = "18")]
		public bool ANABIKLMINF(CGECBEAFDFK HGAMKJKNDDL, out float3 NENFOEKGNGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x30A4740", Offset = "0x30A3340", VA = "0x1830A4740", Slot = "26")]
		public float3 BHPOJLAKCIP(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x30A69E0", Offset = "0x30A55E0", VA = "0x1830A69E0", Slot = "27")]
		public void MIBLMOMKLFO(CGECBEAFDFK HGAMKJKNDDL, float3 NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x30A7260", Offset = "0x30A5E60", VA = "0x1830A7260", Slot = "28")]
		public float PLIEMGMJNGN(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x30A6B90", Offset = "0x30A5790", VA = "0x1830A6B90", Slot = "29")]
		public void MPIDENPOAPL(CGECBEAFDFK HGAMKJKNDDL, float NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x30A57B0", Offset = "0x30A43B0", VA = "0x1830A57B0", Slot = "30")]
		public float FLFBCLIOOMN(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x30A5010", Offset = "0x30A3C10", VA = "0x1830A5010", Slot = "31")]
		public void DOMJKHNPBLH(CGECBEAFDFK HGAMKJKNDDL, float NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x30A5B90", Offset = "0x30A4790", VA = "0x1830A5B90", Slot = "32")]
		public bool HGJMGELMOOK(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x30A4DA0", Offset = "0x30A39A0", VA = "0x1830A4DA0", Slot = "33")]
		public void CLGDKCFIIHP(CGECBEAFDFK HGAMKJKNDDL, bool NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x30A63E0", Offset = "0x30A4FE0", VA = "0x1830A63E0", Slot = "19")]
		public void KFPMKGCJMPJ(CGECBEAFDFK HGAMKJKNDDL, float3 NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x30A4500", Offset = "0x30A3100", VA = "0x1830A4500", Slot = "20")]
		public bool BAOIDCMBODA(CGECBEAFDFK HGAMKJKNDDL, out float3 NENFOEKGNGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x30A6D20", Offset = "0x30A5920", VA = "0x1830A6D20", Slot = "21")]
		public void NLOJCJDCFDI(CGECBEAFDFK HGAMKJKNDDL, quaternion NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x30A5110", Offset = "0x30A3D10", VA = "0x1830A5110", Slot = "22")]
		public bool EBADCCOIHCI(CGECBEAFDFK HGAMKJKNDDL, out quaternion NENFOEKGNGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x30A47C0", Offset = "0x30A33C0", VA = "0x1830A47C0", Slot = "23")]
		public bool BLHMLDBGPMH(CGECBEAFDFK HGAMKJKNDDL, out float3 JHGLHJIPNBF, out quaternion EPEEGBFFLDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x30A62F0", Offset = "0x30A4EF0", VA = "0x1830A62F0", Slot = "44")]
		public GFOHABGAENN JJFNMNJIDLO(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(GFOHABGAENN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x30A6280", Offset = "0x30A4E80", VA = "0x1830A6280", Slot = "45")]
		public void JGKOENHJLKG(CGECBEAFDFK HGAMKJKNDDL, GFOHABGAENN NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x30A6F20", Offset = "0x30A5B20", VA = "0x1830A6F20", Slot = "72")]
		public void ODFNJKFIHCC(CGECBEAFDFK HGAMKJKNDDL, object GIHOLCNOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x30A5A30", Offset = "0x30A4630", VA = "0x1830A5A30", Slot = "73")]
		public void GEIHMCIOMEO(CGECBEAFDFK HGAMKJKNDDL, object GIHOLCNOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x30A4480", Offset = "0x30A3080", VA = "0x1830A4480", Slot = "74")]
		public bool BAEDBPOJBOD(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x30A59A0", Offset = "0x30A45A0", VA = "0x1830A59A0", Slot = "81")]
		public void GDOINLGACDM(CGECBEAFDFK HGAMKJKNDDL, object GIHOLCNOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x30A5080", Offset = "0x30A3C80", VA = "0x1830A5080", Slot = "82")]
		public void EAPFEOHHBKM(CGECBEAFDFK HGAMKJKNDDL, object GIHOLCNOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x30A6C30", Offset = "0x30A5830", VA = "0x1830A6C30", Slot = "83")]
		public bool NJHHNCKOIPI(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x30A42B0", Offset = "0x30A2EB0", VA = "0x1830A42B0", Slot = "84")]
		public IEnumerable<object> ANIGDGMEDGG(CGECBEAFDFK HGAMKJKNDDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x30A4020", Offset = "0x30A2C20", VA = "0x1830A4020", Slot = "46")]
		public bool AECBLGFEHGP(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x30A7140", Offset = "0x30A5D40", VA = "0x1830A7140", Slot = "47")]
		public void OMJEOANLILB(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x30A6E10", Offset = "0x30A5A10", VA = "0x1830A6E10", Slot = "48")]
		public bool NPCBPOEJEIK(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x30A6CB0", Offset = "0x30A58B0", VA = "0x1830A6CB0", Slot = "49")]
		public void NLMBCCHDPCP(CGECBEAFDFK HGAMKJKNDDL, bool NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x30A46E0", Offset = "0x30A32E0", VA = "0x1830A46E0", Slot = "50")]
		public bool BHPLMMCHKPE(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x30A6970", Offset = "0x30A5570", VA = "0x1830A6970", Slot = "51")]
		public void MEKPBCICEGD(CGECBEAFDFK HGAMKJKNDDL, bool NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x30A6050", Offset = "0x30A4C50", VA = "0x1830A6050", Slot = "52")]
		public RigidbodyConstraints IFBJKNPPEMM(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x30A4080", Offset = "0x30A2C80", VA = "0x1830A4080", Slot = "53")]
		public void AFGCOFKLIAK(CGECBEAFDFK HGAMKJKNDDL, RigidbodyConstraints NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x30A67A0", Offset = "0x30A53A0", VA = "0x1830A67A0", Slot = "54")]
		public float LOHCFEFLJBB(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x30A4410", Offset = "0x30A3010", VA = "0x1830A4410", Slot = "55")]
		public void BACOCKPDEGE(CGECBEAFDFK HGAMKJKNDDL, float NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x30A4AB0", Offset = "0x30A36B0", VA = "0x1830A4AB0", Slot = "56")]
		public float CFPAHFIACJO(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x30A7040", Offset = "0x30A5C40", VA = "0x1830A7040", Slot = "57")]
		public void OJEFLAGKDMN(CGECBEAFDFK HGAMKJKNDDL, float NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x30A60B0", Offset = "0x30A4CB0", VA = "0x1830A60B0", Slot = "58")]
		public bool IHIBLGCFBAP(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x30A5AC0", Offset = "0x30A46C0", VA = "0x1830A5AC0", Slot = "59")]
		public void GHGNDDKKPGC(CGECBEAFDFK HGAMKJKNDDL, bool NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x30A7200", Offset = "0x30A5E00", VA = "0x1830A7200", Slot = "60")]
		public bool PJBHNOJHCPP(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x30A58A0", Offset = "0x30A44A0", VA = "0x1830A58A0", Slot = "61")]
		public void FPHGAFMKNPC(CGECBEAFDFK HGAMKJKNDDL, bool NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x30A4A30", Offset = "0x30A3630", VA = "0x1830A4A30", Slot = "62")]
		public int BMKFBKEPCNP(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x30A4F10", Offset = "0x30A3B10", VA = "0x1830A4F10", Slot = "63")]
		public void DIEDJEIBMEM(CGECBEAFDFK HGAMKJKNDDL, int NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x30A4F80", Offset = "0x30A3B80", VA = "0x1830A4F80", Slot = "64")]
		public Rigidbody DJKHCMJKCPP(CGECBEAFDFK HGAMKJKNDDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x30A4C40", Offset = "0x30A3840", VA = "0x1830A4C40", Slot = "65")]
		public void CJGGBBEJODA(CGECBEAFDFK HGAMKJKNDDL, Rigidbody NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x30A5810", Offset = "0x30A4410", VA = "0x1830A5810", Slot = "75")]
		public void FMJPECPKMGH(CGECBEAFDFK HGAMKJKNDDL, object GIHOLCNOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x30A6FB0", Offset = "0x30A5BB0", VA = "0x1830A6FB0", Slot = "76")]
		public void OIMLDNAIMFE(CGECBEAFDFK HGAMKJKNDDL, object GIHOLCNOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x30A4660", Offset = "0x30A3260", VA = "0x1830A4660", Slot = "77")]
		public bool BECILBIBNKF(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x30A5310", Offset = "0x30A3F10", VA = "0x1830A5310", Slot = "66")]
		public object EJNGKBEKOJE(CGECBEAFDFK HGAMKJKNDDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x30A5EF0", Offset = "0x30A4AF0", VA = "0x1830A5EF0", Slot = "67")]
		public void IABLMDNOHNA(CGECBEAFDFK HGAMKJKNDDL, object NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x30A70B0", Offset = "0x30A5CB0", VA = "0x1830A70B0", Slot = "68")]
		public object OMIKAEKJBNI(CGECBEAFDFK HGAMKJKNDDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x30A5D00", Offset = "0x30A4900", VA = "0x1830A5D00", Slot = "69")]
		public void HKHLLOFPEAH(CGECBEAFDFK HGAMKJKNDDL, object NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x30A40F0", Offset = "0x30A2CF0", VA = "0x1830A40F0", Slot = "70")]
		public float AKNDEEJOKNC(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x30A6900", Offset = "0x30A5500", VA = "0x1830A6900", Slot = "71")]
		public void MCPBGHAAINO(CGECBEAFDFK HGAMKJKNDDL, float NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x30A6800", Offset = "0x30A5400", VA = "0x1830A6800", Slot = "78")]
		public void LOKEBFFBAMG(CGECBEAFDFK HGAMKJKNDDL, object GIHOLCNOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x30A5E60", Offset = "0x30A4A60", VA = "0x1830A5E60", Slot = "79")]
		public void HPDFPOKFLJA(CGECBEAFDFK HGAMKJKNDDL, object GIHOLCNOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x30A6D90", Offset = "0x30A5990", VA = "0x1830A6D90", Slot = "80")]
		public bool NMPCBIAODKG(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x30A43B0", Offset = "0x30A2FB0", VA = "0x1830A43B0", Slot = "24")]
		public void AOJOGAAMCML(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x30A71A0", Offset = "0x30A5DA0", VA = "0x1830A71A0", Slot = "25")]
		public void PFKDFGBLOKI(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x41B5800", Offset = "0x41B4400", VA = "0x1841B5800")]
		private void HPNNBFOJOIM<T>(CGECBEAFDFK HGAMKJKNDDL, bool NENFOEKGNGK) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x41B58B0", Offset = "0x41B44B0", VA = "0x1841B58B0")]
		private bool NDKHEHOJICB<T>(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x41B5850", Offset = "0x41B4450", VA = "0x1841B5850")]
		private void KFPKFODPJHB<T>(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x41B4AD0", Offset = "0x41B36D0", VA = "0x1841B4AD0")]
		private bool GHKPMGIIHHB<TC, TV>(CGECBEAFDFK HGAMKJKNDDL, Func<TC, TV> EIMBHBEPIKG, out TV NENFOEKGNGK) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x41B4A50", Offset = "0x41B3650", VA = "0x1841B4A50")]
		private bool GHKPMGIIHHB<T>(CGECBEAFDFK HGAMKJKNDDL, out T NENFOEKGNGK) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x41B4600", Offset = "0x41B3200", VA = "0x1841B4600")]
		private T DJIHPIGILDM<T>(CGECBEAFDFK HGAMKJKNDDL) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x41B4C50", Offset = "0x41B3850", VA = "0x1841B4C50")]
		private void HNHCMHKAHFN<T>(CGECBEAFDFK HGAMKJKNDDL, T NENFOEKGNGK) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x41B51A0", Offset = "0x41B3DA0", VA = "0x1841B51A0")]
		private void HPAOOFACBCA<T>(CGECBEAFDFK HGAMKJKNDDL, T NENFOEKGNGK) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x41B4A50", Offset = "0x41B3650", VA = "0x1841B4A50")]
		private bool HHLPHBDHEOB<T>(CGECBEAFDFK HGAMKJKNDDL, out T NENFOEKGNGK) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x41B59C0", Offset = "0x41B45C0", VA = "0x1841B59C0")]
		private T PKGJEMDGEPD<T>(CGECBEAFDFK HGAMKJKNDDL) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x41B4A50", Offset = "0x41B3650", VA = "0x1841B4A50")]
		private void EEACDDPOGCH<T>(CGECBEAFDFK HGAMKJKNDDL, T NENFOEKGNGK) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x41B5910", Offset = "0x41B4510", VA = "0x1841B5910")]
		private void NEGMKDPCGKJ<T>(CGECBEAFDFK HGAMKJKNDDL, T NENFOEKGNGK) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x30A6C00", Offset = "0x30A5800", VA = "0x1830A6C00")]
		private CGECBEAFDFK NGHNPNLEHEM(Entity BODOHICDFAL)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x30A53A0", Offset = "0x30A3FA0", VA = "0x1830A53A0")]
		private DynamicBuffer<Entity> ELGPENIMGAA(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x41B4540", Offset = "0x41B3140", VA = "0x1841B4540")]
		private void CAJAILMGDJC<T>(CGECBEAFDFK HGAMKJKNDDL, object NENFOEKGNGK, Func<object, T> EIMBHBEPIKG) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		private void OEKJIJPBJKA<T>(ref global::KDBALECIHLC<T> FHIGBPAOILI) where T : struct, PGKDDODDOMH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		private void OEKJIJPBJKA<TC, TV>(ref global::GHGBKHFBJNN<TC, TV> FHIGBPAOILI) where TC : struct, PGKDDODDOMH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
	[HJBMNHLGPOF(typeof(KinematicSleepChangeService), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	public class KinematicSleepChangeService : BLCFKNFGJJJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class FPKLHPJHJPB : IEnumerable<OOGACJCDOJG>, IEnumerable, IEnumerator<OOGACJCDOJG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private OOGACJCDOJG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public KinematicSleepChangeService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			private NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public NativeArray<Entity> <>3__entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			private EntityManager <entityManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			private OOGACJCDOJG System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
			[DebuggerHidden]
			public FPKLHPJHJPB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x43A94C0", Offset = "0x43A80C0", VA = "0x1843A94C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x43A9180", Offset = "0x43A7D80", VA = "0x1843A9180", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x43A9540", Offset = "0x43A8140", VA = "0x1843A9540")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x43A9480", Offset = "0x43A8080", VA = "0x1843A9480", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x43A93D0", Offset = "0x43A7FD0", VA = "0x1843A93D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<OOGACJCDOJG> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x43A93D0", Offset = "0x43A7FD0", VA = "0x1843A93D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> EFJFEHBGIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[NNMLOJPMNKB]
		private HOONHJLELFO GMKNLKMJIPP;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x35E4C70", Offset = "0x35E3870", VA = "0x1835E4C70", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x35E5690", Offset = "0x35E4290", VA = "0x1835E5690")]
		public void NGIAFJFOJMO(NativeArray<Entity> EADNCMDNEKI, bool OIDEKBPOKDE, bool CPFNEHAOLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x35E5480", Offset = "0x35E4080", VA = "0x1835E5480")]
		public void MMHLAPNEBGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x35E4CC0", Offset = "0x35E38C0", VA = "0x1835E4CC0")]
		private void IACLAMEDGOK(NativeArray<Entity> EADNCMDNEKI, bool OIDEKBPOKDE, bool CPFNEHAOLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x35E4A90", Offset = "0x35E3690", VA = "0x1835E4A90")]
		[IteratorStateMachine(typeof(FPKLHPJHJPB))]
		private IEnumerable<OOGACJCDOJG> BFNGLPCMGLO(NativeArray<Entity> EADNCMDNEKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x35E4B20", Offset = "0x35E3720", VA = "0x1835E4B20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x35E5800", Offset = "0x35E4400", VA = "0x1835E5800")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DefaultMember("Item")]
[HJBMNHLGPOF(typeof(IPPGPHBJPJM), new string[] { })]
public class IGFMCNEJDMA : IPPGPHBJPJM, IEnumerable<CFLHDMKEGPM>, IEnumerable, CLILAOIFPFK, AHBNMIIEDML, BLCFKNFGJJJ, JGJNINBGNFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[NNMLOJPMNKB]
	private BBELCFKDMAL MBLNNIKAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<(Type, string), int> HBNAKKEABOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private JNJILNFMLLJ FAFPAKEOAIA;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x35DF040", Offset = "0x35DDC40", VA = "0x1835DF040", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public CFLHDMKEGPM KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x35DF8A0", Offset = "0x35DE4A0", VA = "0x1835DF8A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public CFLHDMKEGPM KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x35DF8A0", Offset = "0x35DE4A0", VA = "0x1835DF8A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x35DF8C0", Offset = "0x35DE4C0", VA = "0x1835DF8C0", Slot = "11")]
	public void PHKHGJFAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x35DF610", Offset = "0x35DE210", VA = "0x1835DF610", Slot = "12")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "13")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x35DF310", Offset = "0x35DDF10", VA = "0x1835DF310")]
	private void DAACJNHIGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1A56E10", Offset = "0x1A55A10", VA = "0x181A56E10")]
	private string ANCDDLGMHDP(string MKPDFAEIFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x35DF7C0", Offset = "0x35DE3C0", VA = "0x1835DF7C0", Slot = "7")]
	public CFLHDMKEGPM MFFOMGIAINP(PCEOKBPAGGO DKMDGLKPPGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x35DF060", Offset = "0x35DDC60", VA = "0x1835DF060")]
	private bool CCLLKAAOFKH(Type DGIABMCLHLD, string MKPDFAEIFFO, out CFLHDMKEGPM PJBLNEEFIAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x35DF6B0", Offset = "0x35DE2B0", VA = "0x1835DF6B0", Slot = "8")]
	public FOCFMDNOICJ JJJHJBDDMIJ(PCEOKBPAGGO DKMDGLKPPGF)
	{
		return default(FOCFMDNOICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x35DF690", Offset = "0x35DE290", VA = "0x1835DF690", Slot = "9")]
	public IEnumerator<CFLHDMKEGPM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x35DF690", Offset = "0x35DE290", VA = "0x1835DF690", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x35DF910", Offset = "0x35DE510", VA = "0x1835DF910")]
	public IGFMCNEJDMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
[DefaultMember("Item")]
public interface EFPGJFHDIFM
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGMOPFAJLMN(FOCFMDNOICJ BEAOEMMHBNI, out int PJGFFECCBBF);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
[HJBMNHLGPOF(typeof(EFPGJFHDIFM), new string[] { })]
public class LKGJGLBPNFC : BLCFKNFGJJJ, JGJNINBGNFN, EFPGJFHDIFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[NNMLOJPMNKB]
	private GOLLMGIECKP MBLNNIKAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Dictionary<FOCFMDNOICJ, int> HIDGDCNNEFB;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x35E7280", Offset = "0x35E5E80", VA = "0x1835E7280", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x35E72E0", Offset = "0x35E5EE0", VA = "0x1835E72E0", Slot = "6")]
	public bool NGMOPFAJLMN(FOCFMDNOICJ BEAOEMMHBNI, out int PJGFFECCBBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x35E6FB0", Offset = "0x35E5BB0", VA = "0x1835E6FB0", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x35E6FA0", Offset = "0x35E5BA0", VA = "0x1835E6FA0", Slot = "5")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x35E7010", Offset = "0x35E5C10", VA = "0x1835E7010")]
	private void GBEIEIPLFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x35E7350", Offset = "0x35E5F50", VA = "0x1835E7350")]
	public LKGJGLBPNFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[HJBMNHLGPOF(typeof(GOLLMGIECKP), new string[] { })]
[DefaultMember("Item")]
public class HEMBPCEIJOC : GOLLMGIECKP, IEnumerable<MAKJLBJHHHB>, IEnumerable, CLILAOIFPFK, AHBNMIIEDML, BLCFKNFGJJJ, JGJNINBGNFN, HAPMABPDHHK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[NNMLOJPMNKB]
	private BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[NNMLOJPMNKB]
	private IPPGPHBJPJM DMPLABKFJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private MAKJLBJHHHB[] OKOCIHPADGP;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x35D7AB0", Offset = "0x35D66B0", VA = "0x1835D7AB0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public MAKJLBJHHHB KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x35D7A70", Offset = "0x35D6670", VA = "0x1835D7A70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public MAKJLBJHHHB KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x35D7A70", Offset = "0x35D6670", VA = "0x1835D7A70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "10")]
	public void PHKHGJFAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x35D7C00", Offset = "0x35D6800", VA = "0x1835D7C00", Slot = "11")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "12")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x35D8050", Offset = "0x35D6C50", VA = "0x1835D8050", Slot = "6")]
	public MAKJLBJHHHB MFFOMGIAINP(PCEOKBPAGGO DKMDGLKPPGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x35D7F80", Offset = "0x35D6B80", VA = "0x1835D7F80", Slot = "7")]
	public FOCFMDNOICJ JJJHJBDDMIJ(PCEOKBPAGGO DKMDGLKPPGF)
	{
		return default(FOCFMDNOICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x35D7EA0", Offset = "0x35D6AA0", VA = "0x1835D7EA0", Slot = "8")]
	public IEnumerator<MAKJLBJHHHB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x35D8180", Offset = "0x35D6D80", VA = "0x1835D8180", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x37477A0", Offset = "0x37463A0", VA = "0x1837477A0", Slot = "13")]
	public void PNDJKENIJFE<TKey, T>(global::BOGNFFDCMBC<TKey, T> FCPNPIIHNJJ, [Optional] object MAMKOIKAADI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x35D7AC0", Offset = "0x35D66C0", VA = "0x1835D7AC0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public HEMBPCEIJOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x35D7A70", Offset = "0x35D6670", VA = "0x1835D7A70")]
	[CompilerGenerated]
	private MAKJLBJHHHB AAHOAEODOBH(int NFLKAEEEFMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[HJBMNHLGPOF(typeof(BPKIFHOOJOE), new string[] { })]
[DefaultMember("Item")]
public class LELMAOLJPEO : BPKIFHOOJOE, IEnumerable<FNAFHEBBEAB>, IEnumerable, BLCFKNFGJJJ, JGJNINBGNFN, HAPMABPDHHK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[NNMLOJPMNKB]
	private BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[NNMLOJPMNKB]
	private IPPGPHBJPJM DMPLABKFJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private FNAFHEBBEAB[] OKOCIHPADGP;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x35E6630", Offset = "0x35E5230", VA = "0x1835E6630", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public FNAFHEBBEAB KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x35E6620", Offset = "0x35E5220", VA = "0x1835E6620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public FNAFHEBBEAB KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x35E6620", Offset = "0x35E5220", VA = "0x1835E6620", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x35E6980", Offset = "0x35E5580", VA = "0x1835E6980", Slot = "9")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x35E6680", Offset = "0x35E5280", VA = "0x1835E6680", Slot = "10")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x35E69F0", Offset = "0x35E55F0", VA = "0x1835E69F0")]
	private FNAFHEBBEAB GDJBELAKEOB(int KLEGICPDLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x35E6CB0", Offset = "0x35E58B0", VA = "0x1835E6CB0", Slot = "6")]
	public FNAFHEBBEAB MFFOMGIAINP(PCEOKBPAGGO DKMDGLKPPGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x35E6BE0", Offset = "0x35E57E0", VA = "0x1835E6BE0", Slot = "14")]
	public FOCFMDNOICJ JJJHJBDDMIJ(PCEOKBPAGGO DKMDGLKPPGF)
	{
		return default(FOCFMDNOICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x35E6AD0", Offset = "0x35E56D0", VA = "0x1835E6AD0", Slot = "7")]
	public IEnumerator<FNAFHEBBEAB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x35E6AD0", Offset = "0x35E56D0", VA = "0x1835E6AD0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x3FAB7B0", Offset = "0x3FAA3B0", VA = "0x183FAB7B0", Slot = "11")]
	public void PNDJKENIJFE<TKey, T>(global::BOGNFFDCMBC<TKey, T> FCPNPIIHNJJ, [Optional] object MAMKOIKAADI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x35E68E0", Offset = "0x35E54E0", VA = "0x1835E68E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public LELMAOLJPEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x35E6620", Offset = "0x35E5220", VA = "0x1835E6620")]
	[CompilerGenerated]
	private FNAFHEBBEAB AAHOAEODOBH(int NFLKAEEEFMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
[HJBMNHLGPOF(typeof(BBELCFKDMAL), new string[] { })]
internal class BBELCFKDMAL : BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private IPPGPHBJPJM DMPLABKFJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private BPKIFHOOJOE FAOOMPMEBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private GOLLMGIECKP IBHEHCKAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private global::PEENCLMLKDL<ELGFJHKNNCH> GNCEPKOENKG;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public JNJILNFMLLJ EJJFACOCBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x694E70", Offset = "0x693A70", VA = "0x180694E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x695830", Offset = "0x694430", VA = "0x180695830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x319C6F0", Offset = "0x319B2F0", VA = "0x18319C6F0", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x319C820", Offset = "0x319B420", VA = "0x18319C820")]
	private void IEGDEMGDJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AE60", Offset = "0x2C59A60", VA = "0x182C5AE60")]
	public T EBKDDGCOBJO<T>() where T : ELGFJHKNNCH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x319C9E0", Offset = "0x319B5E0", VA = "0x18319C9E0")]
	public CFLHDMKEGPM LHHMCJEIFKK(PCEOKBPAGGO MKPDFAEIFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	public global::ILIGGOFIJKG<T> LHHMCJEIFKK<T>(PCEOKBPAGGO MKPDFAEIFFO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x319C910", Offset = "0x319B510", VA = "0x18319C910")]
	public FNAFHEBBEAB JGKBNJBNDHC(PCEOKBPAGGO MKPDFAEIFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AE90", Offset = "0x2C59A90", VA = "0x182C5AE90")]
	public global::ABMGDPOGEKP<T> JGKBNJBNDHC<T>(PCEOKBPAGGO MKPDFAEIFFO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x319CAB0", Offset = "0x319B6B0", VA = "0x18319CAB0")]
	public MAKJLBJHHHB PEAMNFLHIHJ(PCEOKBPAGGO MKPDFAEIFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	public global::MJEMKOIGOJL<T> PEAMNFLHIHJ<T>(PCEOKBPAGGO MKPDFAEIFFO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public BBELCFKDMAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class BIHCJJNBMFF
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2C69CA0", Offset = "0x2C688A0", VA = "0x182C69CA0")]
	public static global::ILIGGOFIJKG<T> LHHMCJEIFKK<T>(this BBELCFKDMAL BBOBIMBEMON, global::ANDBNBJKMBA<T> MKPDFAEIFFO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	public static global::ABMGDPOGEKP<T> JGKBNJBNDHC<T>(this BBELCFKDMAL BBOBIMBEMON, global::ANDBNBJKMBA<T> MKPDFAEIFFO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	public static global::MJEMKOIGOJL<T> PEAMNFLHIHJ<T>(this BBELCFKDMAL BBOBIMBEMON, global::ANDBNBJKMBA<T> MKPDFAEIFFO) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
[HJBMNHLGPOF(typeof(HBCODPNFHII), new string[] { })]
public class HBCODPNFHII : BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private BKAMJJFLMHO FBDEICGFAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private FOCFMDNOICJ[] IGGOEPKCFKA;

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x35D6710", Offset = "0x35D5310", VA = "0x1835D6710", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x35D69A0", Offset = "0x35D55A0", VA = "0x1835D69A0")]
	public void LPIOMFJAKJE(KFMKFJINGPH AAEPEKAJNKI, bool NNIHJHMHBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public HBCODPNFHII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[HJBMNHLGPOF(typeof(OINEMHPHHMM), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
public sealed class OINEMHPHHMM : BLCFKNFGJJJ, JGJNINBGNFN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class IEOKDMLBNAE : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
		[DebuggerHidden]
		public IEOKDMLBNAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x43AB980", Offset = "0x43AA580", VA = "0x1843AB980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x43AB5D0", Offset = "0x43AA1D0", VA = "0x1843AB5D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x43ABA00", Offset = "0x43AA600", VA = "0x1843ABA00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x43AB940", Offset = "0x43AA540", VA = "0x1843AB940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x43AB8B0", Offset = "0x43AA4B0", VA = "0x1843AB8B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x43AB8B0", Offset = "0x43AA4B0", VA = "0x1843AB8B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private const string COLKPDIBFAF = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<SerializableGuid, OCPOGNCIOAC> BFFGLPGCJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly List<SerializableGuid> LKAFEKKDOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly Dictionary<SerializableGuid, GameObject> BCDJFKMHLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private BPKIFHOOJOE MBLNNIKAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private OHGMKNKEOOJ OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private NFBIPKALIAH HOAFPJNBADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private OAJACFAFCNG KKILKFBEMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private global::CEDJPBFOOFP<OCPOGNCIOAC> PEJKHOLMBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GameObject CNKDHCAHJPD;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x308A9B0", Offset = "0x30895B0", VA = "0x18308A9B0", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x308A5E0", Offset = "0x30891E0", VA = "0x18308A5E0", Slot = "5")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x308A810", Offset = "0x3089410", VA = "0x18308A810", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x308BB30", Offset = "0x308A730", VA = "0x18308BB30")]
	private void NEGGKMEMIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x308B140", Offset = "0x3089D40", VA = "0x18308B140")]
	internal void JDBEBMNDNGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x308AE60", Offset = "0x3089A60", VA = "0x18308AE60")]
	private void HECIPBKDCIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x308B040", Offset = "0x3089C40", VA = "0x18308B040")]
	private void IBAKKBONPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x308A590", Offset = "0x3089190", VA = "0x18308A590")]
	[IteratorStateMachine(typeof(IEOKDMLBNAE))]
	private IEnumerable<RRCustomPropTag> AJMMBGBGLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x308B6B0", Offset = "0x308A2B0", VA = "0x18308B6B0")]
	private void KDALEGELFKK(CGECBEAFDFK HGAMKJKNDDL, in ODIFAJLFLNC CCOPHGFCELI, in ODIFAJLFLNC KCIMCONOGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x308B570", Offset = "0x308A170", VA = "0x18308B570")]
	private void JHOMPJHMJJA(SerializableGuid PKLNDGIEPCP, GameObject OKGHLJEDAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x308AA80", Offset = "0x3089680", VA = "0x18308AA80")]
	private void FPALPGJNEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x308A3B0", Offset = "0x3088FB0", VA = "0x18308A3B0")]
	private bool AIOPFPGEOIG(OCPOGNCIOAC OBKMEDBBOAF, Transform NIGFDFKEKGM, out GameObject JBMLNCPMHCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x308AE10", Offset = "0x3089A10", VA = "0x18308AE10")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x308BB40", Offset = "0x308A740", VA = "0x18308BB40")]
	public OINEMHPHHMM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public SerializableGuid KCOHNGJJALD
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x714C90", Offset = "0x713890", VA = "0x180714C90")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x30A3DD0", Offset = "0x30A29D0", VA = "0x1830A3DD0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[HJBMNHLGPOF(typeof(IEMEICIPCPC), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
public class IEMEICIPCPC : BLCFKNFGJJJ
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const string PCOOOBNKPMM = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private SceneService HHAEJHNBEEM;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x35DEF20", Offset = "0x35DDB20", VA = "0x1835DEF20", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public IEMEICIPCPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
[HJBMNHLGPOF(typeof(EFMABKBBKIB), new string[] { })]
public class EFMABKBBKIB : BLCFKNFGJJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[NNMLOJPMNKB]
	private EnableComponentSystemsInScope GCPIEPCEPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[NNMLOJPMNKB]
	private SceneService HHAEJHNBEEM;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x31B4020", Offset = "0x31B2C20", VA = "0x1831B4020", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x31B3FE0", Offset = "0x31B2BE0", VA = "0x1831B3FE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x31B3FC0", Offset = "0x31B2BC0", VA = "0x1831B3FC0")]
	private void CCCDHLNHNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x31B3F90", Offset = "0x31B2B90", VA = "0x1831B3F90")]
	private void BNFHKJIPAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public EFMABKBBKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[HJBMNHLGPOF(typeof(JOIOCJOMOCG), new string[] { })]
public class PPGIIFMCGNL : BLCFKNFGJJJ, JGJNINBGNFN, JOIOCJOMOCG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private ALKOEFHOGFF MMELHHCFIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private LKELAMDLPDE LKHKIGJHLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private PropertyEventCallbacksService LNOIJGAOPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private LocalPlayerScopeSystem GHJGLNMFEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int POPBPCHNOPC;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool MEMBGGHIBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x309B8A0", Offset = "0x309A4A0", VA = "0x18309B8A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public CGECBEAFDFK HIHNIBMGBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x309BA70", Offset = "0x309A670", VA = "0x18309BA70", Slot = "9")]
		get
		{
			return default(CGECBEAFDFK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x309B750", Offset = "0x309A350", VA = "0x18309B750", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public DABKEOMEIOA EIFBBAOPJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x309B8E0", Offset = "0x309A4E0", VA = "0x18309B8E0", Slot = "11")]
		get
		{
			return default(DABKEOMEIOA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x309B750", Offset = "0x309A350", VA = "0x18309B750", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public DABKEOMEIOA OHKEDFELBGM
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x309B340", Offset = "0x3099F40", VA = "0x18309B340", Slot = "13")]
		get
		{
			return default(DABKEOMEIOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private uint HDMDHBEELOE
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x309B7F0", Offset = "0x309A3F0", VA = "0x18309B7F0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event DMLKPIJPLCD PGBEGPOIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x309B9D0", Offset = "0x309A5D0", VA = "0x18309B9D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x309B930", Offset = "0x309A530", VA = "0x18309B930", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x309B390", Offset = "0x3099F90", VA = "0x18309B390", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x309AFE0", Offset = "0x3099BE0", VA = "0x18309AFE0", Slot = "5")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x309B290", Offset = "0x3099E90", VA = "0x18309B290", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x309ADE0", Offset = "0x30999E0", VA = "0x18309ADE0")]
	private void BAMMIJGIPPP(Entity BODOHICDFAL, FOCFMDNOICJ FHMECPEDGNJ, ODIFAJLFLNC BNKKPEFEMPA, ODIFAJLFLNC AIGOLOAIBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x309B180", Offset = "0x3099D80", VA = "0x18309B180", Slot = "14")]
	public CGECBEAFDFK CPOPEGHBHBO(CGECBEAFDFK NOFIECLFCLK, CGECBEAFDFK EDMOBKKEKCA)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x309BAB0", Offset = "0x309A6B0", VA = "0x18309BAB0", Slot = "15")]
	public bool OELKOOEENGO(CGECBEAFDFK NOFIECLFCLK, CGECBEAFDFK EDMOBKKEKCA, out CGECBEAFDFK OGFAOKKNMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x309B460", Offset = "0x309A060", VA = "0x18309B460", Slot = "16")]
	public void FJKBNDOCNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x309BBB0", Offset = "0x309A7B0", VA = "0x18309BBB0", Slot = "17")]
	public void PEMAKHNFPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x309B5F0", Offset = "0x309A1F0", VA = "0x18309B5F0", Slot = "18")]
	public bool HAACCHOEEPF(CGECBEAFDFK GNFCHOKJPJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x309B750", Offset = "0x309A350", VA = "0x18309B750")]
	private void NBGIHCLCMIL(CGECBEAFDFK FEKDKFEDCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public PPGIIFMCGNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[HJBMNHLGPOF(typeof(GKFPLKMFEAO), new string[] { })]
public class ACCBJICGOMJ : BLCFKNFGJJJ, GKFPLKMFEAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private EntityManager JOKFOKELNGA;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x3198C50", Offset = "0x3197850", VA = "0x183198C50", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x3198CD0", Offset = "0x31978D0", VA = "0x183198CD0", Slot = "5")]
	public void OLMMLCDGECP(CGECBEAFDFK EJOAECOFOFF, bool NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x1E31B40", Offset = "0x1E30740", VA = "0x181E31B40")]
	private void CKBKODEFPCJ<T>(CGECBEAFDFK EJOAECOFOFF, bool NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public ACCBJICGOMJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[HJBMNHLGPOF(typeof(NMCMPKFGGMJ), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.RenderEffects)]
	public class SelectionService : BLCFKNFGJJJ, NMCMPKFGGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private EntityManager JOKFOKELNGA;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x3333C10", Offset = "0x3332810", VA = "0x183333C10", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x3333BA0", Offset = "0x33327A0", VA = "0x183333BA0", Slot = "5")]
		public void DAEHFDMPBEM(CGECBEAFDFK EJOAECOFOFF, bool NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x3333C90", Offset = "0x3332890", VA = "0x183333C90", Slot = "6")]
		public void GIOJLKMANKC(CGECBEAFDFK EJOAECOFOFF, bool NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x1E31B40", Offset = "0x1E30740", VA = "0x181E31B40")]
		private void CKBKODEFPCJ<T>(CGECBEAFDFK EJOAECOFOFF, bool NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
[HJBMNHLGPOF(typeof(KPGEIFMNFJC), new string[] { })]
internal sealed class KPGEIFMNFJC : BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[NNMLOJPMNKB]
	private ObjectEmbodimentService NIENOEJANLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[NNMLOJPMNKB]
	private HOONHJLELFO GMKNLKMJIPP;

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x35E49D0", Offset = "0x35E35D0", VA = "0x1835E49D0", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public KPGEIFMNFJC()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[GKALNADHNEP(DAHLALKJFLL.Serialization)]
	[HJBMNHLGPOF(typeof(WorldSerialization), new string[] { })]
	[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
	internal sealed class WorldSerialization : BLCFKNFGJJJ, PGLDJELHFCF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly FCNKBCOKGMK CKDMHIIFFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[NNMLOJPMNKB]
		private HOONHJLELFO EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[NNMLOJPMNKB]
		private GDJBNBLIMAN OFNAANAICLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[NNMLOJPMNKB]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[NNMLOJPMNKB]
		private SerializationService HOAFPJNBADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[NNMLOJPMNKB]
		private HLPCBJEKDII AKFDIHCNLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[NNMLOJPMNKB]
		private DebugWorldsService HECGGBOMMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[NNMLOJPMNKB]
		private BulkInstantiateSceneObjectService GHAAFMHMKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private PJJBBDFFHDI FAEIDGPFAHD;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private KNMBPCAIHOP KILOANPBNIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x121F910", Offset = "0x121E510", VA = "0x18121F910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x3348580", Offset = "0x3347180", VA = "0x183348580", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI DENLCPNOJMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x3348070", Offset = "0x3346C70", VA = "0x183348070", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x3347E20", Offset = "0x3346A20", VA = "0x183347E20", Slot = "6")]
		public bool AMFNNGOIJOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x3348F30", Offset = "0x3347B30", VA = "0x183348F30", Slot = "7")]
		public bool OMMOEGPOPDL(IEnumerable<OHBEHHAFFLC> GOMDFIBJCOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x3348A50", Offset = "0x3347650", VA = "0x183348A50", Slot = "5")]
		public ByteString KLGJHJHMALA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x3348050", Offset = "0x3346C50", VA = "0x183348050")]
		private void CDIEIAGCICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x3347F80", Offset = "0x3346B80", VA = "0x183347F80")]
		private void BIFAMPJLIFE(OLNIAFCMFJG ACLHMBHBJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x33480A0", Offset = "0x3346CA0", VA = "0x1833480A0")]
		private void EOAINJJAMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x33486D0", Offset = "0x33472D0", VA = "0x1833486D0")]
		private void HMLHEPPDAAM(HFMHDJKBJLI ACLHMBHBJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x3348EE0", Offset = "0x3347AE0", VA = "0x183348EE0", Slot = "8")]
		public void LIJFJNNBPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x33489B0", Offset = "0x33475B0", VA = "0x1833489B0")]
		private OLNIAFCMFJG HNAPMDBGKPC(EntityManager LLOFGIFGEHE, EntityManager PJPJGDJABGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[HJBMNHLGPOF(typeof(PHBANPHEDAA), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
public class PHBANPHEDAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly Dictionary<IELMBOEFPKD, string> CIHNLLOFDFM;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x3099240", Offset = "0x3097E40", VA = "0x183099240")]
	public GameObject AAPOOCGIOAJ(IELMBOEFPKD IKOIOKHCHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x3099310", Offset = "0x3097F10", VA = "0x183099310")]
	public PHBANPHEDAA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	[HJBMNHLGPOF(typeof(TimeService), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	public class TimeService : AHBNMIIEDML, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[NNMLOJPMNKB]
		private SingletonComponentService HAINONMDOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private bool KDLFJMDAAKO;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public TimeData HIIDLCINHIN
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x333B580", Offset = "0x333A180", VA = "0x18333B580")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x333B500", Offset = "0x333A100", VA = "0x18333B500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool PLIPJJFAOEA
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x76C5D0", Offset = "0x76B1D0", VA = "0x18076C5D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x7CC0E0", Offset = "0x7CACE0", VA = "0x1807CC0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x9CDD00", Offset = "0x9CC900", VA = "0x1809CDD00", Slot = "4")]
		public void PHKHGJFAMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x333B4B0", Offset = "0x333A0B0", VA = "0x18333B4B0", Slot = "5")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x333B5F0", Offset = "0x333A1F0", VA = "0x18333B5F0")]
		public void PPOHOKPNPEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[GKALNADHNEP(DAHLALKJFLL.TransformSyncing)]
	[HJBMNHLGPOF(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
	internal class SetTransformParentIfParentPropertyChanges : BLCFKNFGJJJ, JGJNINBGNFN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private IHMCHCLHMKB OBDKJOBOIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private global::ILIGGOFIJKG<Entity> NIGFDFKEKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private ObjectEmbodimentService MDBFILFJAMO;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x3337800", Offset = "0x3336400", VA = "0x183337800", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x3337630", Offset = "0x3336230", VA = "0x183337630", Slot = "5")]
		public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x3337760", Offset = "0x3336360", VA = "0x183337760", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x3337870", Offset = "0x3336470", VA = "0x183337870")]
		private void IDONOFNBCKA(Entity BODOHICDFAL, in ODIFAJLFLNC CCOPHGFCELI, in ODIFAJLFLNC KCIMCONOGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[GKALNADHNEP(DAHLALKJFLL.Services)]
	[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
	[HJBMNHLGPOF(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	public class EnableTransmissionOnlyInLoadInstance : BLCFKNFGJJJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[NNMLOJPMNKB]
		private HOONHJLELFO EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[NNMLOJPMNKB]
		private JAECADCCJOD PJNMHBFDAHL;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private CLNBNGJEBPM AJMFGCKHLBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x35CD9A0", Offset = "0x35CC5A0", VA = "0x1835CD9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private KADGOFEHHKM IGJGPAMPAOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x35CD8B0", Offset = "0x35CC4B0", VA = "0x1835CD8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x35CD920", Offset = "0x35CC520", VA = "0x1835CD920", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x35CD900", Offset = "0x35CC500", VA = "0x1835CD900", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
[HJBMNHLGPOF(typeof(NFDDEPIHOMJ), new string[] { })]
public class NFDDEPIHOMJ : FNHCFHNDIBD, CLILAOIFPFK, AHBNMIIEDML, BLCFKNFGJJJ, JGJNINBGNFN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class BPIDCNDPNIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public PJJBBDFFHDI services;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BPIDCNDPNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x43A6FF0", Offset = "0x43A5BF0", VA = "0x1843A6FF0")]
		internal void <InitReferences>b__0(BLCFKNFGJJJ svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class EPNPKMECMOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public PJJBBDFFHDI services;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public EPNPKMECMOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x43A9120", Offset = "0x43A7D20", VA = "0x1843A9120")]
		internal void <InitExternal>b__0(JGJNINBGNFN svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	[NNMLOJPMNKB]
	private HOONHJLELFO GMKNLKMJIPP;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public BBLPMAIBLPO MBOFEPLPGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xC867D0", Offset = "0xC853D0", VA = "0x180C867D0", Slot = "4")]
		get
		{
			return default(BBLPMAIBLPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private DEDLBKJDALP JJBDOGEBBHK
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x3084D70", Offset = "0x3083970", VA = "0x183084D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x3084E20", Offset = "0x3083A20", VA = "0x183084E20", Slot = "5")]
	public void LHJKNFEKFKF(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x3084E70", Offset = "0x3083A70", VA = "0x183084E70", Slot = "6")]
	public void PHKHGJFAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x3084C90", Offset = "0x3083890", VA = "0x183084C90", Slot = "7")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x3084A80", Offset = "0x3083680", VA = "0x183084A80", Slot = "8")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x3084B60", Offset = "0x3083760", VA = "0x183084B60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x3B326F0", Offset = "0x3B312F0", VA = "0x183B326F0")]
	private void DLLKAHLMIJO<T>(Action<T> FAECFNPKHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public NFDDEPIHOMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class OLJJFFKJMMO<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly Func<From, To> FDBGEGDEIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly Func<To, From> EIANMFPBAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public DynamicBuffer<From> MMDGIKEBLFM;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public To KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool AALAJCGHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	public OLJJFFKJMMO(Func<From, To> FDBGEGDEIEF, Func<To, From> EIANMFPBAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] NMDKCEHJACP, int JBNOJAIGFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To ALHICNJOIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int KLEGICPDLIF, To ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DefaultMember("Item")]
public class BBFLKEKCHHJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly Func<From, To> FDBGEGDEIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly Func<To, From> EIANMFPBAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public List<From> FOLHIKGIGJA;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x368FFA0", Offset = "0x368EBA0", VA = "0x18368FFA0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x3690000", Offset = "0x368EC00", VA = "0x183690000", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x368FF70", Offset = "0x368EB70", VA = "0x18368FF70", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool AALAJCGHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7C4280", Offset = "0x7C2E80", VA = "0x1807C4280", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7C4300", Offset = "0x7C2F00", VA = "0x1807C4300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1080", Offset = "0x2DAFC80", VA = "0x182DB1080")]
	public BBFLKEKCHHJ(Func<From, To> FDBGEGDEIEF, Func<To, From> EIANMFPBAKI, bool GEAOBIGLECL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x368FB90", Offset = "0x368E790", VA = "0x18368FB90", Slot = "11")]
	public void Add(To ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x368FBF0", Offset = "0x368E7F0", VA = "0x18368FBF0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x368FC20", Offset = "0x368E820", VA = "0x18368FC20", Slot = "13")]
	public bool Contains(To ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x368FC80", Offset = "0x368E880", VA = "0x18368FC80", Slot = "14")]
	public void CopyTo(To[] NMDKCEHJACP, int JBNOJAIGFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x368FD90", Offset = "0x368E990", VA = "0x18368FD90", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x368FE00", Offset = "0x368EA00", VA = "0x18368FE00", Slot = "6")]
	public int IndexOf(To ALHICNJOIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x368FE60", Offset = "0x368EA60", VA = "0x18368FE60", Slot = "7")]
	public void Insert(int KLEGICPDLIF, To ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x368FF10", Offset = "0x368EB10", VA = "0x18368FF10", Slot = "15")]
	public bool Remove(To ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x368FEE0", Offset = "0x368EAE0", VA = "0x18368FEE0", Slot = "8")]
	public void RemoveAt(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2FCF280", Offset = "0x2FCDE80", VA = "0x182FCF280", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DefaultMember("Item")]
public class CPFDJOMHNCG<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly Func<From, To> FDBGEGDEIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Func<To, From> EIANMFPBAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<From> NMDKCEHJACP;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x30F6A60", Offset = "0x30F5660", VA = "0x1830F6A60", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x30F6AB0", Offset = "0x30F56B0", VA = "0x1830F6AB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x30F6A20", Offset = "0x30F5620", VA = "0x1830F6A20", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool AALAJCGHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD850", Offset = "0x6AC450", VA = "0x1806AD850", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x270DD20", Offset = "0x270C920", VA = "0x18270DD20")]
	public CPFDJOMHNCG(Func<From, To> FDBGEGDEIEF, Func<To, From> EIANMFPBAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x30F6630", Offset = "0x30F5230", VA = "0x1830F6630", Slot = "11")]
	public void Add(To ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x30F6670", Offset = "0x30F5270", VA = "0x1830F6670", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x30F66B0", Offset = "0x30F52B0", VA = "0x1830F66B0", Slot = "13")]
	public bool Contains(To ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x30F6770", Offset = "0x30F5370", VA = "0x1830F6770", Slot = "14")]
	public void CopyTo(To[] NMDKCEHJACP, int JBNOJAIGFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x30F6830", Offset = "0x30F5430", VA = "0x1830F6830", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x30F68F0", Offset = "0x30F54F0", VA = "0x1830F68F0", Slot = "6")]
	public int IndexOf(To ALHICNJOIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x30F6960", Offset = "0x30F5560", VA = "0x1830F6960", Slot = "7")]
	public void Insert(int KLEGICPDLIF, To ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x30F69E0", Offset = "0x30F55E0", VA = "0x1830F69E0", Slot = "15")]
	public bool Remove(To ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x30F69A0", Offset = "0x30F55A0", VA = "0x1830F69A0", Slot = "8")]
	public void RemoveAt(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x26FE980", Offset = "0x26FD580", VA = "0x1826FE980", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class PFNPDBMDOFF<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly Func<From, To> FDBGEGDEIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly Func<To, From> EIANMFPBAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeList<From> FOLHIKGIGJA;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool AALAJCGHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	public PFNPDBMDOFF(Func<From, To> FDBGEGDEIEF, Func<To, From> EIANMFPBAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] NMDKCEHJACP, int JBNOJAIGFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To ALHICNJOIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int KLEGICPDLIF, To ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class NAHFPNEFHFA
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public const string HOFAKMDIHBB = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public const string JICABILCFDB = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public const string GANNJILLCOF = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public const string OJPGDKOABEI = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public const string FEIPCCAJNEI = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public const string ADLGDBBGPEH = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public const string HDNAAFKJMJH = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public const string MMBDLJFFHIJ = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class LBFDMKEKDPF
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class EJALGOPOKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public PJJBBDFFHDI services;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public EJALGOPOKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x43A9060", Offset = "0x43A7C60", VA = "0x1843A9060")]
		internal void <InitServices>b__1(BLCFKNFGJJJ svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x43A90C0", Offset = "0x43A7CC0", VA = "0x1843A90C0")]
		internal void <InitServices>b__2(JGJNINBGNFN svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x35E5CC0", Offset = "0x35E48C0", VA = "0x1835E5CC0")]
	public static void MIJACMJFMEL(this DEDLBKJDALP EELLGOEIJJC, PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x3FA9D60", Offset = "0x3FA8960", VA = "0x183FA9D60")]
	public static void DLLKAHLMIJO<T>(this DEDLBKJDALP EELLGOEIJJC, Action<T> FAECFNPKHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x3FA9DD0", Offset = "0x3FA89D0", VA = "0x183FA9DD0")]
	public static void EIBJIKDDFAG<T>(this DEDLBKJDALP EELLGOEIJJC, Action<T> FAECFNPKHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x3FAA0E0", Offset = "0x3FA8CE0", VA = "0x183FAA0E0")]
	public static void LFBCDOENEGD<T>(this DEDLBKJDALP EELLGOEIJJC, Action<T> FAECFNPKHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x3FA9BB0", Offset = "0x3FA87B0", VA = "0x183FA9BB0")]
	public static void CIFBBCJINOF<T>(this DEDLBKJDALP EELLGOEIJJC, Action<T> FAECFNPKHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x3FAA350", Offset = "0x3FA8F50", VA = "0x183FAA350")]
	public static void OOMMGHECKCO<T>(this DEDLBKJDALP EELLGOEIJJC, Action<T> FAECFNPKHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x3FA9F70", Offset = "0x3FA8B70", VA = "0x183FA9F70")]
	public static void EIBJIKDDFAG<T>(IEnumerable<ComponentSystemBase> OAMEEAPEBME, Action<T> FAECFNPKHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x3FAA290", Offset = "0x3FA8E90", VA = "0x183FAA290")]
	private static void OMFNICDLAGP<T>(object BHDJNCHMFPK, Action<T> FAECFNPKHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class CBHDELEBPIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class MHHOBDBKCDJ
{
	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x35E93C0", Offset = "0x35E7FC0", VA = "0x1835E93C0")]
	public static void GGMCFBACAIM(ComponentSystemBase BHDJNCHMFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class CGEIMFAJOAN
{
	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	public static bool HNBIKOLCNLA<T>(ref T APGJBFJMIBK, ref T APLKEMLCGID) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class MKEDDGAPNIA
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class CMKHEBMNCOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public CMKHEBMNCOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x35E9EB0", Offset = "0x35E8AB0", VA = "0x1835E9EB0")]
	public static string NNANAEMFLAC(Transform IGPPDIMEFDL, Transform GNFCHOKJPJE)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[GKALNADHNEP(DAHLALKJFLL.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x3336510", Offset = "0x3335110", VA = "0x183336510")]
		public static void AEKGKLFJGGK(this NDJKPGPHDPI FAEIDGPFAHD, POONLCEGOCM BMNJICJIDIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x3336740", Offset = "0x3335340", VA = "0x183336740")]
		public static void BLENIBDBNGG(this NDJKPGPHDPI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x3336400", Offset = "0x3335000", VA = "0x183336400")]
		public static void AEKGKLFJGGK(this NDJKPGPHDPI FAEIDGPFAHD, [Optional] string[] OBJPENGPILK, [Optional] string[] IJAIKKKLKHB, [Optional] string[] CBAKKLEDJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x3336A40", Offset = "0x3335640", VA = "0x183336A40")]
		public static void NCLIIMLPCED(this NDJKPGPHDPI FAEIDGPFAHD, params string[] PIPGAIJJOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x3336AF0", Offset = "0x33356F0", VA = "0x183336AF0")]
		public static void ODOJMKKEDJL(this NDJKPGPHDPI FAEIDGPFAHD, params string[] PIPGAIJJOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x3336840", Offset = "0x3335440", VA = "0x183336840")]
		private static string[] HFGOPJCCIDO(POONLCEGOCM BMNJICJIDIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x3336BA0", Offset = "0x33357A0", VA = "0x183336BA0")]
		private static bool PNOCEHNJCOP(POONLCEGOCM BMNJICJIDIA, out string[] AJCDMIDICMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0")]
		private static bool JMCILJPJBNM()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public abstract class LNDLIGBCMHM : INCILGIJKHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly MethodInfo NPPOCEBBIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Type[] JGHKPEFMHLD;

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x35E7AC0", Offset = "0x35E66C0", VA = "0x1835E7AC0")]
	public LNDLIGBCMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action DHOBBKHLMCN();

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x35E78D0", Offset = "0x35E64D0", VA = "0x1835E78D0")]
	public MethodInfo GOPNOEDJHPC(Action MNJNLIAKBME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x35E7910", Offset = "0x35E6510", VA = "0x1835E7910", Slot = "4")]
	public void JHOMPJHMJJA(Type JMPEGNOKOOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public abstract class BBECNNNHKCG : LNDLIGBCMHM
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private enum MHFCKACNNCK
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x319C5D0", Offset = "0x319B1D0", VA = "0x18319C5D0", Slot = "5")]
	public override Action DHOBBKHLMCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void GEFHDMHNDCN<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x319C660", Offset = "0x319B260", VA = "0x18319C660")]
	[Preserve]
	public void GAFIPDIFEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x3098800", Offset = "0x3097400", VA = "0x183098800")]
	protected BBECNNNHKCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class PACKLJCBOAJ : LNDLIGBCMHM
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x30986E0", Offset = "0x30972E0", VA = "0x1830986E0", Slot = "5")]
	public override Action DHOBBKHLMCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void EOOOBMNCMCH<T>() where T : LJHEIOKMCOC;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x3098770", Offset = "0x3097370", VA = "0x183098770")]
	[Preserve]
	public void GAFIPDIFEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x3098800", Offset = "0x3097400", VA = "0x183098800")]
	protected PACKLJCBOAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class PDGNHAPOCFN : LNDLIGBCMHM
{
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x3098810", Offset = "0x3097410", VA = "0x183098810", Slot = "5")]
	public override Action DHOBBKHLMCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void DOFDOLHKOKK<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x30988A0", Offset = "0x30974A0", VA = "0x1830988A0")]
	[Preserve]
	public void GAFIPDIFEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x3098800", Offset = "0x3097400", VA = "0x183098800")]
	protected PDGNHAPOCFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class PJMIIHEDCGG
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x309A970", Offset = "0x3099570", VA = "0x18309A970")]
	public static Entity EINJLEAHFPK(this EntityManager JOKFOKELNGA)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[GKALNADHNEP(DAHLALKJFLL.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class JPPPACFMKEB : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600060C")]
				[Cpp2IlInjected.Address(RVA = "0x1B15F10", Offset = "0x1B14B10", VA = "0x181B15F10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CD")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600060E")]
				[Cpp2IlInjected.Address(RVA = "0x43AC580", Offset = "0x43AB180", VA = "0x1843AC580", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x43A8690", Offset = "0x43A7290", VA = "0x1843A8690")]
			[DebuggerHidden]
			public JPPPACFMKEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x43AC3B0", Offset = "0x43AAFB0", VA = "0x1843AC3B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x43AC540", Offset = "0x43AB140", VA = "0x1843AC540", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x43AC490", Offset = "0x43AB090", VA = "0x1843AC490", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x43AC490", Offset = "0x43AB090", VA = "0x1843AC490", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class MOOEHKLLJNJ : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private IEnumerator<Entity> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000615")]
				[Cpp2IlInjected.Address(RVA = "0x1B15F10", Offset = "0x1B14B10", VA = "0x181B15F10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000617")]
				[Cpp2IlInjected.Address(RVA = "0x43AEA90", Offset = "0x43AD690", VA = "0x1843AEA90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x43A8690", Offset = "0x43A7290", VA = "0x1843A8690")]
			[DebuggerHidden]
			public MOOEHKLLJNJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x43AEAE0", Offset = "0x43AD6E0", VA = "0x1843AEAE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x43AE7B0", Offset = "0x43AD3B0", VA = "0x1843AE7B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x43AEB70", Offset = "0x43AD770", VA = "0x1843AEB70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x43AEA50", Offset = "0x43AD650", VA = "0x1843AEA50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x43AE9A0", Offset = "0x43AD5A0", VA = "0x1843AE9A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x43AE9A0", Offset = "0x43AD5A0", VA = "0x1843AE9A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class DLLCPHHNGAJ : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private ChildrenData <childData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private IEnumerator<Entity> <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600061F")]
				[Cpp2IlInjected.Address(RVA = "0x1B15F10", Offset = "0x1B14B10", VA = "0x181B15F10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000621")]
				[Cpp2IlInjected.Address(RVA = "0x43A84D0", Offset = "0x43A70D0", VA = "0x1843A84D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x43A8690", Offset = "0x43A7290", VA = "0x1843A8690")]
			[DebuggerHidden]
			public DLLCPHHNGAJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x43A8520", Offset = "0x43A7120", VA = "0x1843A8520", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x43A80C0", Offset = "0x43A6CC0", VA = "0x1843A80C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x43A85F0", Offset = "0x43A71F0", VA = "0x1843A85F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x43A8640", Offset = "0x43A7240", VA = "0x1843A8640")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x43A8490", Offset = "0x43A7090", VA = "0x1843A8490", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x43A83F0", Offset = "0x43A6FF0", VA = "0x1843A83F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x43A83F0", Offset = "0x43A6FF0", VA = "0x1843A83F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x35D0F10", Offset = "0x35CFB10", VA = "0x1835D0F10")]
		public static Entity LADBBJOGEOO(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x35D0980", Offset = "0x35CF580", VA = "0x1835D0980")]
		public static DynamicBuffer<ChildrenData> HEIMEEPFOFB(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x35D0B10", Offset = "0x35CF710", VA = "0x1835D0B10")]
		public static DynamicBuffer<ChildrenData> IACCIIOMPIA(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x35D1010", Offset = "0x35CFC10", VA = "0x1835D1010")]
		public static NativeArray<Entity> MJPHKBCFBIM(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL, Allocator JMMNDPMBMFC)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x35CFD10", Offset = "0x35CE910", VA = "0x1835CFD10")]
		public static bool AJDEHGOADBE(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL, Allocator JMMNDPMBMFC, out NativeArray<Entity> NMOJBIJMNDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x35D0220", Offset = "0x35CEE20", VA = "0x1835D0220")]
		public static NativeArray<Entity> DLPCLBKBGFL(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x35D0690", Offset = "0x35CF290", VA = "0x1835D0690")]
		public static Entity FIGJBPANHLK(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL, int KLEGICPDLIF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x35D0E00", Offset = "0x35CFA00", VA = "0x1835D0E00")]
		public static int JBHPONJDOMF(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x35CFEC0", Offset = "0x35CEAC0", VA = "0x1835CFEC0")]
		public static void CNCNJMGJABG(NativeArray<Entity> IGDNBGHNGMF, NativeArray<Entity> LBMPGEENEFO, EntityManager JOKFOKELNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x35D07C0", Offset = "0x35CF3C0", VA = "0x1835D07C0")]
		public static int FPMMEGLFAHD(this EntityManager JOKFOKELNGA, Entity NIGFDFKEKGM, Entity JAFNGMFCAPA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x35D1140", Offset = "0x35CFD40", VA = "0x1835D1140")]
		public static bool NOFNCJFGCLB(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL, Entity DGPJCMKHAEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x35D1440", Offset = "0x35D0040", VA = "0x1835D1440")]
		public static IEnumerable<Entity> PMEDJAOPCCA(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL, bool DGGHOPFGFBI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x35CFE10", Offset = "0x35CEA10", VA = "0x1835CFE10")]
		public static bool ANAKHBDCABO(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL, Entity JAFNGMFCAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x35D0870", Offset = "0x35CF470", VA = "0x1835D0870")]
		public static bool GFIOHCEGLHC(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL, Entity NOFIECLFCLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x35D0400", Offset = "0x35CF000", VA = "0x1835D0400")]
		public static NativeList<Entity> EKEJBPKFDPH(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL, bool DGGHOPFGFBI = false, Allocator JMMNDPMBMFC = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x35D0BA0", Offset = "0x35CF7A0", VA = "0x1835D0BA0")]
		public static IEnumerable<Entity> IHCPDKHDGPA(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL, bool DGGHOPFGFBI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x35D0120", Offset = "0x35CED20", VA = "0x1835D0120")]
		public static Entity CNPKLEJKNMM(this EntityManager JOKFOKELNGA, Entity BODOHICDFAL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x35D12A0", Offset = "0x35CFEA0", VA = "0x1835D12A0")]
		public static bool OELKOOEENGO(this EntityManager JOKFOKELNGA, Entity NOFIECLFCLK, Entity EDMOBKKEKCA, out Entity OGFAOKKNMJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x35D0610", Offset = "0x35CF210", VA = "0x1835D0610")]
		internal static void FDJHKNJPNIF(EntityManager JOKFOKELNGA, Entity NIGFDFKEKGM, Entity JAFNGMFCAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x35D0A10", Offset = "0x35CF610", VA = "0x1835D0A10")]
		internal static void HHIJAAMPMJK(EntityManager JOKFOKELNGA, Entity NIGFDFKEKGM, Entity JAFNGMFCAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x35D0F80", Offset = "0x35CFB80", VA = "0x1835D0F80")]
		[IteratorStateMachine(typeof(JPPPACFMKEB))]
		private static IEnumerable<Entity> LMKGKHJAPMN(EntityManager JOKFOKELNGA, Entity BODOHICDFAL, bool DGGHOPFGFBI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x35D08F0", Offset = "0x35CF4F0", VA = "0x1835D08F0")]
		[IteratorStateMachine(typeof(MOOEHKLLJNJ))]
		private static IEnumerable<Entity> HDDIAHBJCFB(EntityManager JOKFOKELNGA, Entity BODOHICDFAL, bool DGGHOPFGFBI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x35D0380", Offset = "0x35CEF80", VA = "0x1835D0380")]
		[IteratorStateMachine(typeof(DLLCPHHNGAJ))]
		private static IEnumerable<Entity> EBPEAEPANCK(EntityManager JOKFOKELNGA, Entity BODOHICDFAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x35D0D20", Offset = "0x35CF920", VA = "0x1835D0D20")]
		private static bool IIHIOEJPDMJ(EntityManager JOKFOKELNGA, Entity BODOHICDFAL, Entity DGPJCMKHAEC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[HJBMNHLGPOF(typeof(LBOBEHCDDDO), new string[] { })]
public class DIPDBLMEGBG : LBOBEHCDDDO, FNHCFHNDIBD, AOEOCLOIFAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private PJJBBDFFHDI FAEIDGPFAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private OHGMKNKEOOJ OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private GDJBNBLIMAN OFNAANAICLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private DADKCOOMCAC EMGBIPOKPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private ALKOEFHOGFF MMELHHCFIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private IHMCHCLHMKB OBDKJOBOIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private ONMHIEOMAFC HOAFPJNBADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private EIMKOOLGBOC KKHJJOGANHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private BPKIFHOOJOE MBLNNIKAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private GPJLOKCOMGC OGEAIBAHPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private JKBPJAOBJFL BOBDLPECAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private JOIOCJOMOCG HDECCMEOGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private AIEOMKFDHLJ MCAOIMGHJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private LJDHCEKPEIN KLPMEEBCEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private GKFPLKMFEAO DHBHEAOPPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private NMCMPKFGGMJ LCNBHHNBBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private LNFFKHFBNMG ECEJBDFJHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private BCNNFIFPIOL AIKGBLLBDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private DLAKHJCBFNN PGIKNFEAKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public PJJBBDFFHDI FKFIJLLACLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public OHGMKNKEOOJ NNDPCGNEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public HOONHJLELFO JJBDOGEBBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public GDJBNBLIMAN KHLEGDAJKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public DADKCOOMCAC OIFHCNMNBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public BKJKHIFBPPC DDGEHDJMFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x694E70", Offset = "0x693A70", VA = "0x180694E70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public ALKOEFHOGFF ACFPHCDKPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x698150", Offset = "0x696D50", VA = "0x180698150", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IHMCHCLHMKB MIPFAJPFHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x69B9C0", Offset = "0x69A5C0", VA = "0x18069B9C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public ONMHIEOMAFC OLEFIEENBHE
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x77FB40", Offset = "0x77E740", VA = "0x18077FB40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public EIMKOOLGBOC GMBNJCPCEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7335A0", Offset = "0x7321A0", VA = "0x1807335A0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public BPKIFHOOJOE GJDECGOJDFI
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x7315F0", Offset = "0x7301F0", VA = "0x1807315F0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public GPJLOKCOMGC AAEIONBEEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x731600", Offset = "0x730200", VA = "0x180731600", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public JKBPJAOBJFL LBMIDEEBHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B50", Offset = "0x6A3750", VA = "0x1806A4B50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public JOIOCJOMOCG HONENAHEKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C80", Offset = "0x6D8880", VA = "0x1806D9C80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public AIEOMKFDHLJ JPKLCFOPFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x758AB0", Offset = "0x7576B0", VA = "0x180758AB0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public LJDHCEKPEIN CFLLKBPPKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x70BC60", Offset = "0x70A860", VA = "0x18070BC60", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public GKFPLKMFEAO ALJPDCIIBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x73A230", Offset = "0x738E30", VA = "0x18073A230", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public NMCMPKFGGMJ DBIOFMLCFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1B0", Offset = "0x6A9DB0", VA = "0x1806AB1B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public LNFFKHFBNMG HBMCHMAINEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x731610", Offset = "0x730210", VA = "0x180731610", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public BCNNFIFPIOL GPIKILKNEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x6A0370", Offset = "0x69EF70", VA = "0x1806A0370", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public DLAKHJCBFNN KLEPLBELCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x6A0430", Offset = "0x69F030", VA = "0x1806A0430", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public BBLPMAIBLPO MBOFEPLPGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x7933D0", Offset = "0x791FD0", VA = "0x1807933D0", Slot = "21")]
		get
		{
			return default(BBLPMAIBLPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x31B0D00", Offset = "0x31AF900", VA = "0x1831B0D00", Slot = "22")]
	public void LHJKNFEKFKF(PJJBBDFFHDI DENLCPNOJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x25C0B10", Offset = "0x25BF710", VA = "0x1825C0B10", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x31B0FF0", Offset = "0x31AFBF0", VA = "0x1831B0FF0", Slot = "23")]
	public void PGBEGPOIMNL(PJJBBDFFHDI DENLCPNOJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public DIPDBLMEGBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[DefaultMember("Item")]
public class GMLANCJBMPM : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class NKHMCBPAMNI : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public GMLANCJBMPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x7072A0", Offset = "0x705EA0", VA = "0x1807072A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0x43AF440", Offset = "0x43AE040", VA = "0x1843AF440", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public NKHMCBPAMNI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x43AF290", Offset = "0x43ADE90", VA = "0x1843AF290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x43AF400", Offset = "0x43AE000", VA = "0x1843AF400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	protected const ulong PBAGJDFCGOE = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	protected const ulong NKDDBILBAJD = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	protected const int MEJMEDDONPF = 8;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	protected const int LEHHJKLKMLF = 6;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public const int EAKBKMHLIBH = 64;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	protected const int MHKKEHKMPCF = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private readonly List<ulong> HPODHAIAFAD;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x749E90", Offset = "0x748A90", VA = "0x180749E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int GGIPGBFGDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x749E50", Offset = "0x748A50", VA = "0x180749E50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x749EA0", Offset = "0x748AA0", VA = "0x180749EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x35D5120", Offset = "0x35D3D20", VA = "0x1835D5120")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x35D4870", Offset = "0x35D3470", VA = "0x1835D4870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x35D5250", Offset = "0x35D3E50", VA = "0x1835D5250")]
	public GMLANCJBMPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x35D51C0", Offset = "0x35D3DC0", VA = "0x1835D51C0")]
	public GMLANCJBMPM(int OPNEFEADCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x35D5040", Offset = "0x35D3C40", VA = "0x1835D5040")]
	public bool KMLIINLIKGF(int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x35D4700", Offset = "0x35D3300", VA = "0x1835D4700")]
	public bool EFGHAMNAAGJ(int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x35D47F0", Offset = "0x35D33F0", VA = "0x1835D47F0")]
	public bool FICDGGNLJKO(int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x35D4570", Offset = "0x35D3170", VA = "0x1835D4570")]
	public bool BPOKJGMAKGF(int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x35D4DF0", Offset = "0x35D39F0", VA = "0x1835D4DF0")]
	public void HGPIJOLFGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x35D4A20", Offset = "0x35D3620", VA = "0x1835D4A20")]
	public void GFECJDHOEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x35D4580", Offset = "0x35D3180", VA = "0x1835D4580")]
	public void CKBKODEFPCJ(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x35D4B10", Offset = "0x35D3710", VA = "0x1835D4B10")]
	public void GGNFLDPHLOD(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x35D4670", Offset = "0x35D3270", VA = "0x1835D4670")]
	public bool CLGLOPPJHNF(int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x35D4CD0", Offset = "0x35D38D0", VA = "0x1835D4CD0")]
	public void HCIBFKMEGHN(int IHKOJLKELAD, int GGKDNLHEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x35D4E80", Offset = "0x35D3A80", VA = "0x1835D4E80")]
	public void IKDOMHFINOD(int BKJJDIDFIIM, int OFFOENLINKP, int GGKDNLHEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x35D4430", Offset = "0x35D3030", VA = "0x1835D4430")]
	public int AABPNGPFBPJ(int GGKDNLHEHMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x35D4500", Offset = "0x35D3100", VA = "0x1835D4500")]
	public int AABPNGPFBPJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x35D4C10", Offset = "0x35D3810", VA = "0x1835D4C10")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x35D4C60", Offset = "0x35D3860", VA = "0x1835D4C60", Slot = "4")]
	[IteratorStateMachine(typeof(NKHMCBPAMNI))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x35D4C60", Offset = "0x35D3860", VA = "0x1835D4C60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class HMKODMAEFGD<T> : global::ODMIIMGNGMF<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	protected global::JHNIAHCBCPO<T> JEOOGGKNIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	protected global::IFIIIDIONFH<T> AMEGAECGLGO;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x1C29DE0", Offset = "0x1C289E0", VA = "0x181C29DE0")]
	public HMKODMAEFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x3CF5CE0", Offset = "0x3CF48E0", VA = "0x183CF5CE0")]
	public HMKODMAEFGD(global::JHNIAHCBCPO<T> JEOOGGKNIIN, global::IFIIIDIONFH<T> AMEGAECGLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x3CF5AA0", Offset = "0x3CF46A0", VA = "0x183CF5AA0", Slot = "11")]
	public override T PPPEOPKFADK(CGMMAJHBNBK PFLAJOHNBGL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x3CF5690", Offset = "0x3CF4290", VA = "0x183CF5690", Slot = "12")]
	public override void ANBECOLJJND(CGMMAJHBNBK PFLAJOHNBGL, T NENFOEKGNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class DPJHDCMPFLA
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x2C960E0", Offset = "0x2C94CE0", VA = "0x182C960E0")]
	public static FOCFMDNOICJ JHOMPJHMJJA<T>(this FPMKPNJEPNL MBLNNIKAAIG, global::ANDBNBJKMBA<T> MKPDFAEIFFO, global::JHNIAHCBCPO<T> JEOOGGKNIIN, global::IFIIIDIONFH<T> AMEGAECGLGO) where T : struct
	{
		return default(FOCFMDNOICJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class JEFABKMMADC<T> : global::HMKODMAEFGD<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x3C03EF0", Offset = "0x3C02AF0", VA = "0x183C03EF0")]
	public JEFABKMMADC(T OMNMFNNFBDJ, T CCAKNLFDCEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class BOKHGBONJBM<T> : global::ODMIIMGNGMF<T> where T : struct, LJHEIOKMCOC
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F080", Offset = "0x2A6DC80", VA = "0x182A6F080", Slot = "11")]
	public override T PPPEOPKFADK(CGMMAJHBNBK PFLAJOHNBGL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EFF0", Offset = "0x2A6DBF0", VA = "0x182A6EFF0", Slot = "12")]
	public override void ANBECOLJJND(CGMMAJHBNBK PFLAJOHNBGL, T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x238AD50", Offset = "0x2389950", VA = "0x18238AD50")]
	public BOKHGBONJBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public abstract class CIDEJFFEJHM : LDKBNMOODCG
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public abstract Type KAOGCFDDDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void PPPEOPKFADK(CGMMAJHBNBK PFLAJOHNBGL, in DADHEMOPEJD NENFOEKGNGK);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void ANBECOLJJND(CGMMAJHBNBK PFLAJOHNBGL, in ODIFAJLFLNC NENFOEKGNGK);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void HNMKKLJOBAM(CGMMAJHBNBK PFLAJOHNBGL, NKMNCDCPDAP KCLMBFCDJGI, [Optional] object MAMKOIKAADI);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	protected CIDEJFFEJHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public abstract class ODMIIMGNGMF<T> : CIDEJFFEJHM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override Type KAOGCFDDDGA
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x2F92330", Offset = "0x2F90F30", VA = "0x182F92330", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T PPPEOPKFADK(CGMMAJHBNBK PFLAJOHNBGL);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void ANBECOLJJND(CGMMAJHBNBK PFLAJOHNBGL, T NENFOEKGNGK);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2F929F0", Offset = "0x2F915F0", VA = "0x182F929F0", Slot = "8")]
	public override void PPPEOPKFADK(CGMMAJHBNBK PFLAJOHNBGL, in DADHEMOPEJD GNFCHOKJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2F90680", Offset = "0x2F8F280", VA = "0x182F90680", Slot = "9")]
	public override void ANBECOLJJND(CGMMAJHBNBK PFLAJOHNBGL, in ODIFAJLFLNC CNJLPBGBOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x2F91270", Offset = "0x2F8FE70", VA = "0x182F91270", Slot = "10")]
	public override void HNMKKLJOBAM(CGMMAJHBNBK PFLAJOHNBGL, NKMNCDCPDAP KCLMBFCDJGI, object MAMKOIKAADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB490", Offset = "0x1DCA090", VA = "0x181DCB490")]
	protected ODMIIMGNGMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class OAJGCBOFGEB
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class BDHGLBKLPGC
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class GDKIEINGMIB<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
			public GDKIEINGMIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x393C890", Offset = "0x393B490", VA = "0x18393C890")]
			internal void <RegisterFixedString>b__0(CGMMAJHBNBK p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x393CC50", Offset = "0x393B850", VA = "0x18393CC50")]
			internal T <RegisterFixedString>b__1(CGMMAJHBNBK p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x43A61B0", Offset = "0x43A4DB0", VA = "0x1843A61B0")]
		public static void IKEFNDJMJNN(ECDHIELMBME KDLJOPEEIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x300F0C0", Offset = "0x300DCC0", VA = "0x18300F0C0")]
		private static void PEGAPBAMOMM<T>(ECDHIELMBME KDLJOPEEIEB, int CCAKNLFDCEM) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x300E9E0", Offset = "0x300D5E0", VA = "0x18300E9E0")]
		private static void LJPKFJEKOHJ<T>(CGMMAJHBNBK NMDDPCLMDNL, T ILBEOCCCHNM, int CCAKNLFDCEM) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x300EA70", Offset = "0x300D670", VA = "0x18300EA70")]
		private static T OKDJDEMNFAL<T>(CGMMAJHBNBK NMDDPCLMDNL, int CCAKNLFDCEM) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BDHGLBKLPGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class BJLKOPINOKI : BBECNNNHKCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private ECDHIELMBME KDLJOPEEIEB;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x300F1E0", Offset = "0x300DDE0", VA = "0x18300F1E0", Slot = "6")]
		public override void GEFHDMHNDCN<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x43A6390", Offset = "0x43A4F90", VA = "0x1843A6390")]
		public static void KCHAHPPGJOJ(ECDHIELMBME KDLJOPEEIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x43A6440", Offset = "0x43A5040", VA = "0x1843A6440")]
		public BJLKOPINOKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x3086360", Offset = "0x3084F60", VA = "0x183086360")]
	public static void OOMINICLBGF(ECDHIELMBME KDLJOPEEIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x29FECF0", Offset = "0x29FD8F0", VA = "0x1829FECF0")]
	public static void PKHNEOIDGKD<T>(ECDHIELMBME KDLJOPEEIEB, global::JHNIAHCBCPO<T> JEOOGGKNIIN, global::IFIIIDIONFH<T> AMEGAECGLGO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x29FEC80", Offset = "0x29FD880", VA = "0x1829FEC80")]
	public static void JNIPFAJCOHP<T>(ECDHIELMBME AILCJINKCMI) where T : struct, LJHEIOKMCOC
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
public interface ECDHIELMBME : global::FDGABHEOIMM<ECDHIELMBME>
{
	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHOMPJHMJJA(Type JMPEGNOKOOB, LDKBNMOODCG AILCJINKCMI);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JIJNIMCPPHN(Type JMPEGNOKOOB, out LDKBNMOODCG AILCJINKCMI);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class FGOBPLLNPMC
{
	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x35D1C30", Offset = "0x35D0830", VA = "0x1835D1C30")]
	public static void JHOMPJHMJJA(this ECDHIELMBME JKANGDEKCLI, LDKBNMOODCG AILCJINKCMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[HJBMNHLGPOF(typeof(FPMKPNJEPNL), new string[] { })]
public sealed class GNNPPMODBON : FPMKPNJEPNL, global::FDGABHEOIMM<FPMKPNJEPNL>, AHBNMIIEDML, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly Dictionary<FOCFMDNOICJ, LDKBNMOODCG> KDLJOPEEIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private ECDHIELMBME ABCAGNDDGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private GOLLMGIECKP MBLNNIKAAIG;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool CIPDBDLFOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C4280", Offset = "0x7C2E80", VA = "0x1807C4280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C4300", Offset = "0x7C2F00", VA = "0x1807C4300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x35D5AD0", Offset = "0x35D46D0", VA = "0x1835D5AD0")]
	public GNNPPMODBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x35D5A10", Offset = "0x35D4610", VA = "0x1835D5A10")]
	public GNNPPMODBON(Dictionary<FOCFMDNOICJ, LDKBNMOODCG> KDLJOPEEIEB, bool IOPBAJOCGIN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x35D59B0", Offset = "0x35D45B0", VA = "0x1835D59B0", Slot = "7")]
	public void PHKHGJFAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x35D54F0", Offset = "0x35D40F0", VA = "0x1835D54F0", Slot = "8")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x35D5570", Offset = "0x35D4170", VA = "0x1835D5570", Slot = "9")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x35D58E0", Offset = "0x35D44E0", VA = "0x1835D58E0", Slot = "4")]
	public FOCFMDNOICJ JJJHJBDDMIJ(PCEOKBPAGGO MKPDFAEIFFO)
	{
		return default(FOCFMDNOICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x35D55C0", Offset = "0x35D41C0", VA = "0x1835D55C0", Slot = "5")]
	public void JHOMPJHMJJA(FOCFMDNOICJ BEAOEMMHBNI, LDKBNMOODCG AILCJINKCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x35D52D0", Offset = "0x35D3ED0", VA = "0x1835D52D0")]
	[Conditional("DEBUG_BUILD")]
	private void BNDNOKIJGOP(FOCFMDNOICJ BEAOEMMHBNI, Type JMPEGNOKOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x35D5730", Offset = "0x35D4330", VA = "0x1835D5730", Slot = "6")]
	public bool JIJNIMCPPHN(FOCFMDNOICJ BEAOEMMHBNI, out LDKBNMOODCG AILCJINKCMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x35D5410", Offset = "0x35D4010", VA = "0x1835D5410", Slot = "10")]
	public FPMKPNJEPNL DKIGMHDCDAC()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[HJBMNHLGPOF(typeof(ECDHIELMBME), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.TypeSerializer)]
	public sealed class TypeSerializerService : AHBNMIIEDML, ECDHIELMBME, global::FDGABHEOIMM<ECDHIELMBME>
	{
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly Dictionary<Type, LDKBNMOODCG> KDLJOPEEIEB;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public bool CIPDBDLFOBK
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x76C5D0", Offset = "0x76B1D0", VA = "0x18076C5D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x7CC0E0", Offset = "0x7CACE0", VA = "0x1807CC0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x33413B0", Offset = "0x333FFB0", VA = "0x1833413B0")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x33412F0", Offset = "0x333FEF0", VA = "0x1833412F0")]
		public TypeSerializerService(Dictionary<Type, LDKBNMOODCG> KDLJOPEEIEB, bool IOPBAJOCGIN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x3341240", Offset = "0x333FE40", VA = "0x183341240", Slot = "4")]
		public void PHKHGJFAMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x3341040", Offset = "0x333FC40", VA = "0x183341040", Slot = "5")]
		public void JHOMPJHMJJA(Type JMPEGNOKOOB, LDKBNMOODCG AILCJINKCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x3341160", Offset = "0x333FD60", VA = "0x183341160", Slot = "6")]
		public bool JIJNIMCPPHN(Type JMPEGNOKOOB, out LDKBNMOODCG AILCJINKCMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x3340F60", Offset = "0x333FB60", VA = "0x183340F60", Slot = "7")]
		public ECDHIELMBME DKIGMHDCDAC()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[HJBMNHLGPOF(typeof(GOFHHCIFHKK), new string[] { })]
internal sealed class DKMCMDHAEFG : GOFHHCIFHKK, AHBNMIIEDML, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly Dictionary<FOCFMDNOICJ, MNINALBIOCE> JHCIGJOOEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private GOLLMGIECKP MBLNNIKAAIG;

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x31B12E0", Offset = "0x31AFEE0", VA = "0x1831B12E0", Slot = "6")]
	public void PHKHGJFAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x31B1010", Offset = "0x31AFC10", VA = "0x1831B1010", Slot = "7")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x31B1200", Offset = "0x31AFE00", VA = "0x1831B1200", Slot = "4")]
	public void JHOMPJHMJJA(FOCFMDNOICJ FHMECPEDGNJ, Type MNJIHIJOGEG, MNINALBIOCE NHJGMFCCPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x31B1270", Offset = "0x31AFE70", VA = "0x1831B1270", Slot = "5")]
	public bool LNJIPFDOBMB(FOCFMDNOICJ FHMECPEDGNJ, out MNINALBIOCE NHJGMFCCPPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x31B1070", Offset = "0x31AFC70", VA = "0x1831B1070")]
	[Conditional("DEBUG_BUILD")]
	private void HFHGEKLOIDC(FOCFMDNOICJ FHMECPEDGNJ, Type MNJIHIJOGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x31B1330", Offset = "0x31AFF30", VA = "0x1831B1330")]
	public DKMCMDHAEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[HJBMNHLGPOF(typeof(LOEICIOIHNF), new string[] { })]
internal sealed class MJHHHALEHHF : LOEICIOIHNF, CLILAOIFPFK, AHBNMIIEDML, BLCFKNFGJJJ, JGJNINBGNFN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private readonly GMLANCJBMPM KAGHGBJNENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private readonly Dictionary<KFMKFJINGPH, int> BLGMHHDENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly Stack<int> PIEJKOCBEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	[NNMLOJPMNKB]
	private GOLLMGIECKP MBLNNIKAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	[NNMLOJPMNKB]
	private BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private int PPJNDJFIPED
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x35E9710", Offset = "0x35E8310", VA = "0x1835E9710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool CBCJINGKOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x698370", Offset = "0x696F70", VA = "0x180698370", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x6983F0", Offset = "0x696FF0", VA = "0x1806983F0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x35E9760", Offset = "0x35E8360", VA = "0x1835E9760", Slot = "6")]
	public void PHKHGJFAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x35E98A0", Offset = "0x35E84A0", VA = "0x1835E98A0", Slot = "7")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x35E95C0", Offset = "0x35E81C0", VA = "0x1835E95C0", Slot = "8")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x35E9670", Offset = "0x35E8270", VA = "0x1835E9670")]
	private void CODEMEGGGNC(CGECBEAFDFK HGAMKJKNDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x35E9480", Offset = "0x35E8080", VA = "0x1835E9480", Slot = "4")]
	public bool BKOCFJALNAF(KFMKFJINGPH AAEPEKAJNKI, FOCFMDNOICJ FCPNPIIHNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x35E9920", Offset = "0x35E8520", VA = "0x1835E9920", Slot = "5")]
	public void HAJDOJEHFAA(KFMKFJINGPH AAEPEKAJNKI, Span<FOCFMDNOICJ> MBLNNIKAAIG, bool NKHNGJFEMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x35E9760", Offset = "0x35E8360", VA = "0x1835E9760", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x35E9C70", Offset = "0x35E8870", VA = "0x1835E9C70")]
	public MJHHHALEHHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class ODKHPEPFPAJ
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x3088080", Offset = "0x3086C80", VA = "0x183088080")]
	public static void GHNHODPIIGG(this CGMMAJHBNBK PFLAJOHNBGL, ReadOnlyMemory<byte> ACOJEFAHOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A05490", Offset = "0x2A04090", VA = "0x182A05490")]
	public static void GDIADOLFKJJ<T>(this CGMMAJHBNBK PFLAJOHNBGL, in T NENFOEKGNGK) where T : struct, LJHEIOKMCOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A055C0", Offset = "0x2A041C0", VA = "0x182A055C0")]
	public static T JCDANHOCELK<T>(this CGMMAJHBNBK PFLAJOHNBGL) where T : struct, LJHEIOKMCOC
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x3088050", Offset = "0x3086C50", VA = "0x183088050")]
	public static void GDIADOLFKJJ(this CGMMAJHBNBK PFLAJOHNBGL, ACKFPDHGNMB OBDDOIIMHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x3088220", Offset = "0x3086E20", VA = "0x183088220")]
	public static ACKFPDHGNMB OCFKDGPHPHI(this CGMMAJHBNBK PFLAJOHNBGL)
	{
		return default(ACKFPDHGNMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x3087EA0", Offset = "0x3086AA0", VA = "0x183087EA0")]
	public static void FFMDKFGCCAO(this CGMMAJHBNBK GPEIELKLHFF, uint AEBNCDFJMPH, bool BHLANLDKJLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x3088100", Offset = "0x3086D00", VA = "0x183088100")]
	public static uint HDLBFAHJOHL(this CGMMAJHBNBK OFAOLOCAHKK, bool BHLANLDKJLE = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class EHOHNDIJEIK
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class BGFNHAGHJMK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public BGFNHAGHJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x369B400", Offset = "0x369A000", VA = "0x18369B400")]
		internal void <GetByteEnumDelegates>b__0(CGMMAJHBNBK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x369B470", Offset = "0x369A070", VA = "0x18369B470")]
		internal T <GetByteEnumDelegates>b__1(CGMMAJHBNBK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class KLFDAJOEPGN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public KLFDAJOEPGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x37C5C40", Offset = "0x37C4840", VA = "0x1837C5C40")]
		internal void <GetSByteEnumDelegates>b__0(CGMMAJHBNBK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x37C5CB0", Offset = "0x37C48B0", VA = "0x1837C5CB0")]
		internal T <GetSByteEnumDelegates>b__1(CGMMAJHBNBK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class IELHKGLKEGJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public IELHKGLKEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2F026A0", Offset = "0x2F012A0", VA = "0x182F026A0")]
		internal void <GetShortEnumDelegates>b__0(CGMMAJHBNBK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2F02710", Offset = "0x2F01310", VA = "0x182F02710")]
		internal T <GetShortEnumDelegates>b__1(CGMMAJHBNBK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class GMDABEENBIM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public GMDABEENBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x33B4610", Offset = "0x33B3210", VA = "0x1833B4610")]
		internal void <GetUShortEnumDelegates>b__0(CGMMAJHBNBK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x33B4680", Offset = "0x33B3280", VA = "0x1833B4680")]
		internal T <GetUShortEnumDelegates>b__1(CGMMAJHBNBK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class DBOAMBJAPPD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public DBOAMBJAPPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2D7BE10", Offset = "0x2D7AA10", VA = "0x182D7BE10")]
		internal void <GetIntEnumDelegates>b__0(CGMMAJHBNBK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D7BE70", Offset = "0x2D7AA70", VA = "0x182D7BE70")]
		internal T <GetIntEnumDelegates>b__1(CGMMAJHBNBK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class KMOHLHNPCEO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public KMOHLHNPCEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x37C82D0", Offset = "0x37C6ED0", VA = "0x1837C82D0")]
		internal void <GetUIntEnumDelegates>b__0(CGMMAJHBNBK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x37C8330", Offset = "0x37C6F30", VA = "0x1837C8330")]
		internal T <GetUIntEnumDelegates>b__1(CGMMAJHBNBK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA750", Offset = "0x2CA9350", VA = "0x182CAA750")]
	public static void BDCJJOFCJBC<T>(T OMNMFNNFBDJ, T CCAKNLFDCEM, out global::JHNIAHCBCPO<T> MELHOGNDJLH, out global::IFIIIDIONFH<T> JDKEKJKLPMN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA600", Offset = "0x2CA9200", VA = "0x182CAA600")]
	private static void AOPMALEJOME<T>(T OMNMFNNFBDJ, T CCAKNLFDCEM, out global::JHNIAHCBCPO<T> MELHOGNDJLH, out global::IFIIIDIONFH<T> JDKEKJKLPMN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA600", Offset = "0x2CA9200", VA = "0x182CAA600")]
	private static void CNLLFKLBPAP<T>(T OMNMFNNFBDJ, T CCAKNLFDCEM, out global::JHNIAHCBCPO<T> MELHOGNDJLH, out global::IFIIIDIONFH<T> JDKEKJKLPMN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA4B0", Offset = "0x2CA90B0", VA = "0x182CAA4B0")]
	private static void ABBLHPNLBJN<T>(T OMNMFNNFBDJ, T CCAKNLFDCEM, out global::JHNIAHCBCPO<T> MELHOGNDJLH, out global::IFIIIDIONFH<T> JDKEKJKLPMN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA4B0", Offset = "0x2CA90B0", VA = "0x182CAA4B0")]
	private static void IBFEHPAHLHJ<T>(T OMNMFNNFBDJ, T CCAKNLFDCEM, out global::JHNIAHCBCPO<T> MELHOGNDJLH, out global::IFIIIDIONFH<T> JDKEKJKLPMN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA970", Offset = "0x2CA9570", VA = "0x182CAA970")]
	private static void FFNDPFFHGCG<T>(T OMNMFNNFBDJ, T CCAKNLFDCEM, out global::JHNIAHCBCPO<T> MELHOGNDJLH, out global::IFIIIDIONFH<T> JDKEKJKLPMN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA970", Offset = "0x2CA9570", VA = "0x182CAA970")]
	private static void FHENBDEEEKD<T>(T OMNMFNNFBDJ, T CCAKNLFDCEM, out global::JHNIAHCBCPO<T> MELHOGNDJLH, out global::IFIIIDIONFH<T> JDKEKJKLPMN) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class NDJEBPLNGPE : OIFFKKBIOLH, JGJNINBGNFN
{
	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x3084990", Offset = "0x3083590", VA = "0x183084990", Slot = "4")]
	private void LNKHGAFLKOI(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void HLLJILGEOKB(FPMKPNJEPNL MBLNNIKAAIG);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780")]
	protected NDJEBPLNGPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[GDPFPDEGDCA(typeof(LocalPoseData))]
public sealed class APDFIGCBFLG : NDJEBPLNGPE
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x319A9B0", Offset = "0x31995B0", VA = "0x18319A9B0", Slot = "5")]
	protected override void HLLJILGEOKB(FPMKPNJEPNL MBLNNIKAAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0")]
	public APDFIGCBFLG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.Scope)]
	internal class CopyAuthorityToEntity : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private EntityQuery LFNDIANHBBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private EntityQuery CDHMNMMIAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private EntityQuery ENPKNDNEDOB;

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x31AA7E0", Offset = "0x31A93E0", VA = "0x1831AA7E0", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x31AB2A0", Offset = "0x31A9EA0", VA = "0x1831AB2A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x31AB420", Offset = "0x31AA020", VA = "0x1831AB420", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x31AB3F0", Offset = "0x31A9FF0", VA = "0x1831AB3F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x31AAA00", Offset = "0x31A9600", VA = "0x1831AAA00")]
		private void GMDMNHPEEGD(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x31AAE20", Offset = "0x31A9A20", VA = "0x1831AAE20")]
		private void KJIKBODHDJN(NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x31AAFC0", Offset = "0x31A9BC0", VA = "0x1831AAFC0")]
		private void NLMGMNLCHCB(NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x31AA850", Offset = "0x31A9450", VA = "0x1831AA850")]
		private void GEELOGECNMD(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x31AA5D0", Offset = "0x31A91D0", VA = "0x1831AA5D0")]
		private void ABKLHEEENEE(NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x31AAD40", Offset = "0x31A9940", VA = "0x1831AAD40")]
		private void KFJIIHBBLKK(CGECBEAFDFK HGAMKJKNDDL, int NKHNEPFILOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class DDJANBLPIPA : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EntityQuery GJLGONPKKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private OHGMKNKEOOJ OPBBALMJDDI;

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x31B0010", Offset = "0x31AEC10", VA = "0x1831B0010", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x31B0640", Offset = "0x31AF240", VA = "0x1831B0640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x31B0700", Offset = "0x31AF300", VA = "0x1831B0700", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x31B0060", Offset = "0x31AEC60", VA = "0x1831B0060")]
	private void HGBKKGFCOBE(NativeArray<Entity> EADNCMDNEKI, NativeList<Entity> FIELAFDPAJH, ComponentDataFromEntity<DFPOBPFIMGB> HNBLEIKPBLN, BufferFromEntity<ChildrenData> FLCMJBPOBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public DDJANBLPIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class DNAINFKMDAD : ParentSystemBase<AuthoredParentData, DAPGAPAJHEO, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x31B1790", Offset = "0x31B0390", VA = "0x1831B1790", Slot = "14")]
	protected override EntityQueryDesc MALOFCDGMHB(EntityQueryDesc GJLGONPKKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x801380", Offset = "0x7FFF80", VA = "0x180801380", Slot = "15")]
	protected override EntityQueryDesc EFLINLPKAAB(EntityQueryDesc GJLGONPKKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x31B1750", Offset = "0x31B0350", VA = "0x1831B1750", Slot = "16")]
	protected override EntityQueryDesc AEKPHAFLELM(EntityQueryDesc GJLGONPKKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x31B17D0", Offset = "0x31B03D0", VA = "0x1831B17D0", Slot = "17")]
	protected override EntityQueryDesc MHDPFBLNDKI(EntityQueryDesc GJLGONPKKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x31B1850", Offset = "0x31B0450", VA = "0x1831B1850")]
	public DNAINFKMDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x31B1810", Offset = "0x31B0410", VA = "0x1831B1810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class HGOKKMPEPBA : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private EntityQuery GJLGONPKKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private object HANCEEPCFLP;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x35D81A0", Offset = "0x35D6DA0", VA = "0x1835D81A0", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x35D8220", Offset = "0x35D6E20", VA = "0x1835D8220", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x35D82C0", Offset = "0x35D6EC0", VA = "0x1835D82C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public HGOKKMPEPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class KLHIOCNNELA : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery GJLGONPKKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private object HANCEEPCFLP;

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x35E45C0", Offset = "0x35E31C0", VA = "0x1835E45C0", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x35E4640", Offset = "0x35E3240", VA = "0x1835E4640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x35E46E0", Offset = "0x35E32E0", VA = "0x1835E46E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public KLHIOCNNELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[InternalBufferCapacity(1)]
internal struct INFADOENKML : ISystemStateBufferElementData, IBufferElementData, IEquatable<INFADOENKML>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public ODAKPCOAOHL LBLAJOOMAIC;

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x35DFFE0", Offset = "0x35DEBE0", VA = "0x1835DFFE0", Slot = "4")]
	public bool Equals(INFADOENKML GHLMPEGFGCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0B0", Offset = "0x6D8CB0", VA = "0x1806DA0B0")]
	public static INFADOENKML GGDPAIJEDCE(ODAKPCOAOHL LBLAJOOMAIC)
	{
		return default(INFADOENKML);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[InternalBufferCapacity(4)]
internal struct MLDOABDCLCH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public ODAKPCOAOHL LBLAJOOMAIC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0B0", Offset = "0x6D8CB0", VA = "0x1806DA0B0")]
	public static MLDOABDCLCH GGDPAIJEDCE(ODAKPCOAOHL LBLAJOOMAIC)
	{
		return default(MLDOABDCLCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal abstract class ELHDPGFCGCJ : AEDFEOJBGCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x31B5030", Offset = "0x31B3C30", VA = "0x1831B5030", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x31B51C0", Offset = "0x31B3DC0", VA = "0x1831B51C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	protected ELHDPGFCGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[FJJLKPGAMCM]
internal abstract class AEDFEOJBGCJ : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	protected EntityQuery GJLGONPKKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	protected BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	protected DLAKHJCBFNN PGIKNFEAKLP;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	protected abstract BEFFDHAPBGG NBPGIABICNO
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x3198D40", Offset = "0x3197940", VA = "0x183198D40", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x3199030", Offset = "0x3197C30", VA = "0x183199030")]
	protected void MKHHABKEKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x3198DB0", Offset = "0x31979B0", VA = "0x183198DB0")]
	protected void MAACLCEOLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x31992B0", Offset = "0x3197EB0", VA = "0x1831992B0")]
	protected DLCEAGAIHLE NGGOAMJPAJD()
	{
		return default(DLCEAGAIHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	protected AEDFEOJBGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class ONOBKAHEMEP : AEDFEOJBGCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x308C3D0", Offset = "0x308AFD0", VA = "0x18308C3D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x308C560", Offset = "0x308B160", VA = "0x18308C560", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x3084A60", Offset = "0x3083660", VA = "0x183084A60")]
	protected ONOBKAHEMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class LIPBDFJDOAG : AEDFEOJBGCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x35E6E00", Offset = "0x35E5A00", VA = "0x1835E6E00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x35E6F10", Offset = "0x35E5B10", VA = "0x1835E6F10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x3084A60", Offset = "0x3083660", VA = "0x183084A60")]
	protected LIPBDFJDOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class CGMCFNMBJNB : ELHDPGFCGCJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected override BEFFDHAPBGG NBPGIABICNO
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x319FDA0", Offset = "0x319E9A0", VA = "0x18319FDA0", Slot = "15")]
		get
		{
			return default(BEFFDHAPBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public CGMCFNMBJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class KNECMHGNOHD : ONOBKAHEMEP
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected override BEFFDHAPBGG NBPGIABICNO
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x35E4960", Offset = "0x35E3560", VA = "0x1835E4960", Slot = "15")]
		get
		{
			return default(BEFFDHAPBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x3084A70", Offset = "0x3083670", VA = "0x183084A70")]
	public KNECMHGNOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x3084A60", Offset = "0x3083660", VA = "0x183084A60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class NEDEHOGHHFB : LIPBDFJDOAG
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected override BEFFDHAPBGG NBPGIABICNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x30849F0", Offset = "0x30835F0", VA = "0x1830849F0", Slot = "15")]
		get
		{
			return default(BEFFDHAPBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x3084A70", Offset = "0x3083670", VA = "0x183084A70")]
	public NEDEHOGHHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x3084A60", Offset = "0x3083660", VA = "0x183084A60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class JIKMEONKKPH : ELHDPGFCGCJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override BEFFDHAPBGG NBPGIABICNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x35E0C60", Offset = "0x35DF860", VA = "0x1835E0C60", Slot = "15")]
		get
		{
			return default(BEFFDHAPBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x3084A60", Offset = "0x3083660", VA = "0x183084A60")]
	public JIKMEONKKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class FDAEMFDNOIG : ONOBKAHEMEP
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override BEFFDHAPBGG NBPGIABICNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x35D1640", Offset = "0x35D0240", VA = "0x1835D1640", Slot = "15")]
		get
		{
			return default(BEFFDHAPBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x3084A70", Offset = "0x3083670", VA = "0x183084A70")]
	public FDAEMFDNOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x3084A60", Offset = "0x3083660", VA = "0x183084A60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class FONDDAFCMOK : LIPBDFJDOAG
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override BEFFDHAPBGG NBPGIABICNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x35D2900", Offset = "0x35D1500", VA = "0x1835D2900", Slot = "15")]
		get
		{
			return default(BEFFDHAPBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x3084A60", Offset = "0x3083660", VA = "0x183084A60")]
	public FONDDAFCMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct MANOAPAHJEH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal struct PMGCAJJPEBL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct HHOPKACONJA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly struct BEFFDHAPBGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly ComponentType PAACCECGPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly ComponentType BGECKNDEKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly object GIHOLCNOBIB;

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x319D110", Offset = "0x319BD10", VA = "0x18319D110")]
	public BEFFDHAPBGG(ComponentType PAACCECGPOA, ComponentType BGECKNDEKMC, object GIHOLCNOBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2C65360", Offset = "0x2C63F60", VA = "0x182C65360")]
	public static BEFFDHAPBGG ENBHIILOAJE<TReq, TTag>(object GIHOLCNOBIB)
	{
		return default(BEFFDHAPBGG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class BNADNDPLODM
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public const string IJCKOBFOHII = "Parented";

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public const string FHDOKNNNPBF = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly BEFFDHAPBGG DBIOFMLCFCP;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly BEFFDHAPBGG CHBCNKGANAM;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct ODAKPCOAOHL : global::AHIMPCNGIKJ<ODAKPCOAOHL>, IIENHJEKFBL, IEquatable<ODAKPCOAOHL>
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public int KLCIKJBGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CB0", Offset = "0x6D88B0", VA = "0x1806D9CB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x6DB530", Offset = "0x6DA130", VA = "0x1806DB530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int LKNCJMEJAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x715000", Offset = "0x713C00", VA = "0x180715000", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x715010", Offset = "0x713C10", VA = "0x180715010", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool BPOKJGMAKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x3087E10", Offset = "0x3086A10", VA = "0x183087E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x3087DC0", Offset = "0x30869C0", VA = "0x183087DC0", Slot = "8")]
	public bool Equals(ODAKPCOAOHL GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x3087E50", Offset = "0x3086A50", VA = "0x183087E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[FJJLKPGAMCM]
	[GKALNADHNEP(DAHLALKJFLL.Connectables)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	public class UpdateConnectableVisuals : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private struct GLAKMBONMNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public ODAKPCOAOHL LBLAJOOMAIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public float3 BBEHPKKOBDE;

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x43A9D40", Offset = "0x43A8940", VA = "0x1843A9D40")]
			public GLAKMBONMNN(ODAKPCOAOHL LBLAJOOMAIC, float3 BBEHPKKOBDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x43A9D20", Offset = "0x43A8920", VA = "0x1843A9D20")]
			public void ECFLPLOIBIB(out ODAKPCOAOHL LBLAJOOMAIC, out float3 BBEHPKKOBDE)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private struct EODLJOEDLMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public NativeList<GLAKMBONMNN> list;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
			public EODLJOEDLMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<MLDOABDCLCH> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private struct DNAMOKEHBEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public NativeList<GLAKMBONMNN> list;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
			public DNAMOKEHBEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<INFADOENKML> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private struct NPAEKDHLKPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public NativeList<GLAKMBONMNN> list;

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
			public NPAEKDHLKPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in OFFGBLCDOIB com, in DynamicBuffer<INFADOENKML> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct ADGFACLDICJ : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E2")]
			private struct IOEHDMOBABF
			{
				[Cpp2IlInjected.Token(Token = "0x20000E3")]
				public struct BICPJDBPKGL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BE")]
					public LambdaParameterValueProvider_Entity.Runtime ILAODBKEPEJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002BF")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime LCMBNEKNANB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002C0")]
					public LambdaParameterValueProvider_DynamicBuffer<MLDOABDCLCH>.Runtime CLMIGANPPIK;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity FFFAHLBALFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002BC")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> BDLHEBBKBPE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002BD")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<MLDOABDCLCH> MBMKDPNIOOB;

				[Cpp2IlInjected.Token(Token = "0x600077D")]
				[Cpp2IlInjected.Address(RVA = "0x43ABB10", Offset = "0x43AA710", VA = "0x1843ABB10")]
				public void GDFFALHKOBH(UpdateConnectableVisuals IEKCOPFEHBF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0x43ABA50", Offset = "0x43AA650", VA = "0x1843ABA50")]
				public BICPJDBPKGL DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
				{
					return default(BICPJDBPKGL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public UpdateConnectableVisuals CNNCDNBBCBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public NativeList<GLAKMBONMNN> FOLHIKGIGJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private IOEHDMOBABF KHJPHIECPAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe IOEHDMOBABF.BICPJDBPKGL* MKHNGJINIJK;

			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PHJMPFOKBGL;

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x43A5870", Offset = "0x43A4470", VA = "0x1843A5870")]
			internal void HECHOFEKDHF(Entity BODOHICDFAL, WorldPoseData EOAIJOAIBMM, in DynamicBuffer<MLDOABDCLCH> DBOAJCAFPEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x43A5AB0", Offset = "0x43A46B0", VA = "0x1843A5AB0", Slot = "5")]
			public void ReadFromDisplayClass(ref EODLJOEDLMI HNPKAGHHMHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x43A5AE0", Offset = "0x43A46E0", VA = "0x1843A5AE0", Slot = "6")]
			public void WriteToDisplayClass(ref EODLJOEDLMI HNPKAGHHMHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x43A55A0", Offset = "0x43A41A0", VA = "0x1843A55A0", Slot = "4")]
			public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x43A5680", Offset = "0x43A4280", VA = "0x1843A5680")]
			public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, ref IOEHDMOBABF.BICPJDBPKGL IKHKHMKOEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x43A57C0", Offset = "0x43A43C0", VA = "0x1843A57C0")]
			public void GDFFALHKOBH(UpdateConnectableVisuals IEKCOPFEHBF, ref EODLJOEDLMI HNPKAGHHMHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x43A5800", Offset = "0x43A4400", VA = "0x1843A5800")]
			public unsafe static void GGIFGIINNMA(ArchetypeChunkIterator* PCLDPFNHHHB, void* AKDGMOCNLFL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct CCBHJNBCGBE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct NLABAHICMKI
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				[NoAlias]
				public struct GEDIIPDLOKE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime LCMBNEKNANB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<INFADOENKML>.Runtime CLMIGANPPIK;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002C4")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> BDLHEBBKBPE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002C5")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<INFADOENKML> MBMKDPNIOOB;

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0x43AF530", Offset = "0x43AE130", VA = "0x1843AF530")]
				public void GDFFALHKOBH(UpdateConnectableVisuals IEKCOPFEHBF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x43AF490", Offset = "0x43AE090", VA = "0x1843AF490")]
				public GEDIIPDLOKE DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
				{
					return default(GEDIIPDLOKE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public NativeList<GLAKMBONMNN> FOLHIKGIGJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			private NLABAHICMKI KHJPHIECPAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NLABAHICMKI.GEDIIPDLOKE* MKHNGJINIJK;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x43A7290", Offset = "0x43A5E90", VA = "0x1843A7290")]
			internal void HECHOFEKDHF(in WorldPoseData EOAIJOAIBMM, in DynamicBuffer<INFADOENKML> DBOAJCAFPEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0xDB5E00", Offset = "0xDB4A00", VA = "0x180DB5E00", Slot = "5")]
			public void ReadFromDisplayClass(ref DNAMOKEHBEI HNPKAGHHMHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x43A7050", Offset = "0x43A5C50", VA = "0x1843A7050", Slot = "4")]
			public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x43A7120", Offset = "0x43A5D20", VA = "0x1843A7120")]
			public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, [NoAlias] ref NLABAHICMKI.GEDIIPDLOKE IKHKHMKOEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x43A71F0", Offset = "0x43A5DF0", VA = "0x1843A71F0")]
			public void GDFFALHKOBH(UpdateConnectableVisuals IEKCOPFEHBF, ref DNAMOKEHBEI HNPKAGHHMHE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct MJDACCEINJN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct JGKIDDGMPIJ
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct BPCALHAGNCC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CE")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime LCMBNEKNANB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002CF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<OFFGBLCDOIB>.Runtime EKDKPCEMEPN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<INFADOENKML>.Runtime CLMIGANPPIK;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CB")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> BDLHEBBKBPE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002CC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<OFFGBLCDOIB> AHFNNJJNPBF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002CD")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<INFADOENKML> MBMKDPNIOOB;

				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0x43ABD40", Offset = "0x43AA940", VA = "0x1843ABD40")]
				public void GDFFALHKOBH(UpdateConnectableVisuals IEKCOPFEHBF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0x43ABC70", Offset = "0x43AA870", VA = "0x1843ABC70")]
				public BPCALHAGNCC DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
				{
					return default(BPCALHAGNCC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<GLAKMBONMNN> FOLHIKGIGJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			private JGKIDDGMPIJ KHJPHIECPAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JGKIDDGMPIJ.BPCALHAGNCC* MKHNGJINIJK;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x43AE240", Offset = "0x43ACE40", VA = "0x1843AE240")]
			internal void HECHOFEKDHF(in WorldPoseData EOAIJOAIBMM, in OFFGBLCDOIB DJHIPONIIDE, in DynamicBuffer<INFADOENKML> DBOAJCAFPEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0xDB5E00", Offset = "0xDB4A00", VA = "0x180DB5E00", Slot = "5")]
			public void ReadFromDisplayClass(ref NPAEKDHLKPL HNPKAGHHMHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x43AE060", Offset = "0x43ACC60", VA = "0x1843AE060", Slot = "4")]
			public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x43AE0E0", Offset = "0x43ACCE0", VA = "0x1843AE0E0")]
			public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, [NoAlias] ref JGKIDDGMPIJ.BPCALHAGNCC IKHKHMKOEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x43AE200", Offset = "0x43ACE00", VA = "0x1843AE200")]
			public void GDFFALHKOBH(UpdateConnectableVisuals IEKCOPFEHBF, ref NPAEKDHLKPL HNPKAGHHMHE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery GIFGMBJCKKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery KLCJLBCDJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery MEBNIIEBKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EntityQuery HOGLHNHPGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private EntityQuery DKNKDBNPNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private EntityQuery DCCONCHHDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private EntityQuery IMJPIDPGBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private EntityQuery KPHFCDBEKGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private EntityQuery CKCFNGMHJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EntityQuery IOGPGBLPNPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private global::FNIOGEGGNAD<ODAKPCOAOHL, DJEMEHPGIMI> EEPPEBAJJAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private BCNNFIFPIOL AIKGBLLBDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private JOIOCJOMOCG HDECCMEOGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private NMDGOJHKHPM KNHNKMCPMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private EntityQuery DPNLMPOBLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private ProfilerMarker NMKKENDFALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private EntityQuery BELKHEANPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private EntityQuery HGELGCOOAMG;

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int GEHHFJONLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x3342380", Offset = "0x3340F80", VA = "0x183342380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x3343C60", Offset = "0x3342860", VA = "0x183343C60")]
		internal DJEMEHPGIMI JHPAAIEDEMK(ODAKPCOAOHL LBLAJOOMAIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x3342A10", Offset = "0x3341610", VA = "0x183342A10", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x33456A0", Offset = "0x33442A0", VA = "0x1833456A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x3345920", Offset = "0x3344520", VA = "0x183345920", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x3345AB0", Offset = "0x33446B0", VA = "0x183345AB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x33458E0", Offset = "0x33444E0", VA = "0x1833458E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x3342530", Offset = "0x3341130", VA = "0x183342530")]
		private void DFDDPHPNGCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x3343F20", Offset = "0x3342B20", VA = "0x183343F20")]
		private void KACEDLKHGIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x3345C20", Offset = "0x3344820", VA = "0x183345C20")]
		private void PFEAFKMHLLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x3345AF0", Offset = "0x33446F0", VA = "0x183345AF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x33447F0", Offset = "0x33433F0", VA = "0x1833447F0")]
		private void KLLCLICJMAF(EntityQuery LFNDIANHBBH, EntityQuery KLNFHKKKGLI, EntityQuery CDHMNMMIAFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x3344720", Offset = "0x3343320", VA = "0x183344720")]
		private void KFPKFODPJHB(EntityQuery CDHMNMMIAFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x3343980", Offset = "0x3342580", VA = "0x183343980")]
		private void IHDDJBDIDDC(global::OEJJJGPOENI<Entity> GJPLCJIIMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x3342900", Offset = "0x3341500", VA = "0x183342900")]
		private void EHDOJPPKEHC(global::OEJJJGPOENI<Entity> DHPEPDCJFGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x3342F80", Offset = "0x3341B80", VA = "0x183342F80")]
		private void FJKEKLLDECL(global::OEJJJGPOENI<Entity> BBNDBGOPGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x33423C0", Offset = "0x3340FC0", VA = "0x1833423C0")]
		private void DDFOIKFKKIP(NativeList<ODAKPCOAOHL> KINBIAMHHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x3341CA0", Offset = "0x33408A0", VA = "0x183341CA0")]
		private NativeList<ODAKPCOAOHL> BFIKDOJHPJC(NativeArray<Entity> EADNCMDNEKI)
		{
			return default(NativeList<ODAKPCOAOHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x3344100", Offset = "0x3342D00", VA = "0x183344100")]
		private void KDHHGAHJHAA(NativeArray<Entity> EADNCMDNEKI, NativeList<ODAKPCOAOHL> KINBIAMHHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x3343250", Offset = "0x3341E50", VA = "0x183343250")]
		private void GPLNIKMKKIN(NativeArray<Entity> HOPOCEMAKOD, NativeArray<Entity> MBPEJBEMMOK, NativeList<ODAKPCOAOHL> PIEJKOCBEKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x3342AD0", Offset = "0x33416D0", VA = "0x183342AD0")]
		private void FFDACHFOHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x3344CD0", Offset = "0x33438D0", VA = "0x183344CD0")]
		private global::GFPHNEMLNOJ<GLAKMBONMNN> LAPDEIPIPEJ(EntityQuery GJLGONPKKFL, Func<NativeList<GLAKMBONMNN>, JobHandle> IGGOBEBBAFI)
		{
			return default(global::GFPHNEMLNOJ<GLAKMBONMNN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x3341B10", Offset = "0x3340710", VA = "0x183341B10")]
		private JobHandle BEHIPOBBBBA(NativeList<GLAKMBONMNN> FOLHIKGIGJA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x33450A0", Offset = "0x3343CA0", VA = "0x1833450A0")]
		private JobHandle LNMPAIIMIEA(NativeList<GLAKMBONMNN> FOLHIKGIGJA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x3343120", Offset = "0x3341D20", VA = "0x183343120")]
		private JobHandle GGHOIJCBEEL(NativeList<GLAKMBONMNN> FOLHIKGIGJA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x33451E0", Offset = "0x3343DE0", VA = "0x1833451E0")]
		private void NHLJGACIBOD(global::GFPHNEMLNOJ<GLAKMBONMNN> FOLHIKGIGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x3344E10", Offset = "0x3343A10", VA = "0x183344E10")]
		private void LMDGJICAADH(global::GFPHNEMLNOJ<GLAKMBONMNN> FOLHIKGIGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x33428A0", Offset = "0x33414A0", VA = "0x1833428A0")]
		private bool EFNJINGDNNJ(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x3345470", Offset = "0x3344070", VA = "0x183345470")]
		private NativeArray<Entity> NIPBGLHLMFI(Entity BODOHICDFAL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x33421C0", Offset = "0x3340DC0", VA = "0x1833421C0")]
		private ODAKPCOAOHL BMECADHGIKK(NativeList<ODAKPCOAOHL> PIEJKOCBEKC)
		{
			return default(ODAKPCOAOHL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x3344070", Offset = "0x3342C70", VA = "0x183344070")]
		private void KCIMPEPMMNK(ODAKPCOAOHL LBLAJOOMAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x3345540", Offset = "0x3344140", VA = "0x183345540", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x3343780", Offset = "0x3342380", VA = "0x183343780")]
		public static EntityQuery HBHIJCLPLKL(ComponentSystemBase IEKCOPFEHBF)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x3342640", Offset = "0x3341240", VA = "0x183342640")]
		public static EntityQuery DGKGMILIJOH(ComponentSystemBase IEKCOPFEHBF)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x3343CB0", Offset = "0x33428B0", VA = "0x183343CB0")]
		public static EntityQuery JIILLNHNBHB(ComponentSystemBase IEKCOPFEHBF)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[GKALNADHNEP(DAHLALKJFLL.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery GJLGONPKKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private ALKOEFHOGFF MMELHHCFIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private EAFNDEHOKAD LHHKGEDBHIG;

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x30A0900", Offset = "0x309F500", VA = "0x1830A0900", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x30A0870", Offset = "0x309F470", VA = "0x1830A0870", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x30A0A00", Offset = "0x309F600", VA = "0x1830A0A00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class PLDEPHBAMAD : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public GIHALPBFOMC NIENOEJANLD;

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public PLDEPHBAMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
	public PLDEPHBAMAD(GIHALPBFOMC NIENOEJANLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x309AD70", Offset = "0x3099970", VA = "0x18309AD70", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class BDEAENJNPOE : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private ObjectEmbodimentService MDBFILFJAMO;

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x319D060", Offset = "0x319BC60", VA = "0x18319D060", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x319D0C0", Offset = "0x319BCC0", VA = "0x18319D0C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x319D0F0", Offset = "0x319BCF0", VA = "0x18319D0F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	protected BDEAENJNPOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class GONCFJLLCOJ : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private EntityQuery CCFGHFHFALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private EntityQuery JDKKMOMLDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private EntityQuery IGMPDAOLNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private EntityQuery MHAMFCFHIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private ObjectEmbodimentService HJLKELCOPFJ;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int OOMGAPHHKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x35D5D20", Offset = "0x35D4920", VA = "0x1835D5D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int LHKGJEDBJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x35D6440", Offset = "0x35D5040", VA = "0x1835D6440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x35D5D30", Offset = "0x35D4930", VA = "0x1835D5D30", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x35D6220", Offset = "0x35D4E20", VA = "0x1835D6220", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x35D6420", Offset = "0x35D5020", VA = "0x1835D6420", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x35D6450", Offset = "0x35D5050", VA = "0x1835D6450")]
	public int PPDNGLEPOCJ(SceneTag IPMKKEICEKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x35D5EF0", Offset = "0x35D4AF0", VA = "0x1835D5EF0")]
	public int JHENNDFMOPA(SceneTag IPMKKEICEKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x35D5FA0", Offset = "0x35D4BA0", VA = "0x1835D5FA0")]
	protected void NLELDKPCJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x35D5C10", Offset = "0x35D4810", VA = "0x1835D5C10")]
	protected void EALIJBLHKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x35D5B50", Offset = "0x35D4750", VA = "0x1835D5B50")]
	public global::OEJJJGPOENI<Entity> AAOHEBLCLLI(SceneTag IPMKKEICEKI, Allocator JMMNDPMBMFC = Allocator.TempJob)
	{
		return default(global::OEJJJGPOENI<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x35D5F10", Offset = "0x35D4B10", VA = "0x1835D5F10")]
	public global::OEJJJGPOENI<Entity> LBKPFBIKHGN(SceneTag IPMKKEICEKI, Allocator JMMNDPMBMFC = Allocator.TempJob)
	{
		return default(global::OEJJJGPOENI<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x35D5E00", Offset = "0x35D4A00", VA = "0x1835D5E00")]
	public bool GJJJHBDLKGJ(SceneTag IPMKKEICEKI, out global::OEJJJGPOENI<Entity> NIENOEJANLD, Allocator JMMNDPMBMFC = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x35D5E90", Offset = "0x35D4A90", VA = "0x1835D5E90")]
	public bool JGDPEEKPKPM(Entity BODOHICDFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x35D5BA0", Offset = "0x35D47A0", VA = "0x1835D5BA0")]
	public GIHALPBFOMC ALFIAMOFMBB(Entity BODOHICDFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x35D5D90", Offset = "0x35D4990", VA = "0x1835D5D90")]
	public bool FPHGMCENCAM(Entity BODOHICDFAL, out PLDEPHBAMAD NIENOEJANLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x35D5F60", Offset = "0x35D4B60", VA = "0x1835D5F60")]
	public void NAADIJEBGDG(Entity BODOHICDFAL, PLDEPHBAMAD NIENOEJANLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x35D61C0", Offset = "0x35D4DC0", VA = "0x1835D61C0")]
	public bool OHPEAADOJMC(Entity BODOHICDFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void JBIKFDCLFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public GONCFJLLCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class FDIKDEAOBGJ : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private EntityQuery BNKLEKDJAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private OHGMKNKEOOJ OPBBALMJDDI;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x35D1720", Offset = "0x35D0320", VA = "0x1835D1720", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x35D1770", Offset = "0x35D0370", VA = "0x1835D1770", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x35D1830", Offset = "0x35D0430", VA = "0x1835D1830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x2B5CA30", Offset = "0x2B5B630", VA = "0x182B5CA30")]
	private bool FKFOPCACBMB<TComponentData>(EntityQuery GJLGONPKKFL, out NativeArray<Entity> EADNCMDNEKI, out NativeArray<TComponentData> MFLNELLNMCD) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x35D16B0", Offset = "0x35D02B0", VA = "0x1835D16B0")]
	public GIHALPBFOMC ALFIAMOFMBB(Entity BODOHICDFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public FDIKDEAOBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[GKALNADHNEP(DAHLALKJFLL.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private EntityQuery GOAOEBJLAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private EntityQuery JMCDPCNLNNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private EntityQuery IJJEDGEOAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private EntityQuery ENPKNDNEDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x33371C0", Offset = "0x3335DC0", VA = "0x1833371C0", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x3337280", Offset = "0x3335E80", VA = "0x183337280", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x33374B0", Offset = "0x33360B0", VA = "0x1833374B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x3336DF0", Offset = "0x33359F0", VA = "0x183336DF0")]
		private void AABPNGPFBPJ(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x3337210", Offset = "0x3335E10", VA = "0x183337210")]
		private void KFPKFODPJHB(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x3337440", Offset = "0x3336040", VA = "0x183337440", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x3336E60", Offset = "0x3335A60", VA = "0x183336E60")]
		private void EJBNDNJOLLN(EntityQuery GJLGONPKKFL, bool EMKILHIJCOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class OGPCPJFLPEJ : IKDACLPDLNJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct GOIIPCNPHHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public GOIIPCNPHHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct HGJJHOIBIPM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private struct MCLKKAOBIKE
		{
			[Cpp2IlInjected.Token(Token = "0x20000F5")]
			[NoAlias]
			public struct GHLLMKFCHOM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LGMHFMJGEKK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime DEFPJPDHANO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime PAGMKHBELLA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BMEHEJEIFFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> OILHHDGCNPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> HEPFOHBCKIK;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x43AD7F0", Offset = "0x43AC3F0", VA = "0x1843AD7F0")]
			public void GDFFALHKOBH(OGPCPJFLPEJ IEKCOPFEHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x43AD730", Offset = "0x43AC330", VA = "0x1843AD730")]
			public GHLLMKFCHOM DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
			{
				return default(GHLLMKFCHOM);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private MCLKKAOBIKE KHJPHIECPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MCLKKAOBIKE.GHLLMKFCHOM* MKHNGJINIJK;

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x43AA660", Offset = "0x43A9260", VA = "0x1843AA660")]
		internal void HECHOFEKDHF(Entity LKNPALMCIDH, SplineShapeData DGKCGFAKKDB, DynamicBuffer<LinkedEntityGroup> MMDGIKEBLFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x43AA460", Offset = "0x43A9060", VA = "0x1843AA460", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x43AA530", Offset = "0x43A9130", VA = "0x1843AA530")]
		public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, [NoAlias] ref MCLKKAOBIKE.GHLLMKFCHOM IKHKHMKOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x43AA650", Offset = "0x43A9250", VA = "0x1843AA650")]
		public void GDFFALHKOBH(OGPCPJFLPEJ IEKCOPFEHBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct AJHLOEPIKOB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct PFKMNEJMJJH
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct HMIKAFNCDLG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F8")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime GDPCHJOHLBL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F9")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime CHNCJMFENMB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BHNNNEHLDHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> LFMBCLIPLGC;

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0x43B02B0", Offset = "0x43AEEB0", VA = "0x1843B02B0")]
			public void GDFFALHKOBH(OGPCPJFLPEJ IEKCOPFEHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x43B0230", Offset = "0x43AEE30", VA = "0x1843B0230")]
			public HMIKAFNCDLG DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
			{
				return default(HMIKAFNCDLG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public BufferFromEntity<LinkedEntityGroup> OEDDJNHHNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private PFKMNEJMJJH KHJPHIECPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PFKMNEJMJJH.HMIKAFNCDLG* MKHNGJINIJK;

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x43A5D00", Offset = "0x43A4900", VA = "0x1843A5D00")]
		internal void HECHOFEKDHF(Entity IKBEJODAAKB, SplinePointParentData BPCJMHBEMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x148EE60", Offset = "0x148DA60", VA = "0x18148EE60", Slot = "5")]
		public void ReadFromDisplayClass(ref GOIIPCNPHHH HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x43A5B20", Offset = "0x43A4720", VA = "0x1843A5B20", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x43A5BC0", Offset = "0x43A47C0", VA = "0x1843A5BC0")]
		public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, [NoAlias] ref PFKMNEJMJJH.HMIKAFNCDLG IKHKHMKOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x43A5C70", Offset = "0x43A4870", VA = "0x1843A5C70")]
		public void GDFFALHKOBH(OGPCPJFLPEJ IEKCOPFEHBF, ref GOIIPCNPHHH HNPKAGHHMHE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private EntityQuery GJLGONPKKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private EntityQuery JJDALPIPBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private EntityQuery DBFADAIEKFH;

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x3089A20", Offset = "0x3088620", VA = "0x183089A20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x3089AD0", Offset = "0x30886D0", VA = "0x183089AD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public OGPCPJFLPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x3089780", Offset = "0x3088380", VA = "0x183089780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x3089480", Offset = "0x3088080", VA = "0x183089480")]
	public static EntityQuery MMHJIAMDNIK(ComponentSystemBase IEKCOPFEHBF)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x3089620", Offset = "0x3088220", VA = "0x183089620")]
	public static EntityQuery OGIAHDKKKIJ(ComponentSystemBase IEKCOPFEHBF)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
public sealed class GGPBOMDPMNA : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private OHCBPBOEABE HEGJONDKOJK;

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x35D40C0", Offset = "0x35D2CC0", VA = "0x1835D40C0", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x35D4120", Offset = "0x35D2D20", VA = "0x1835D4120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public GGPBOMDPMNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class FLEOIAKEDLB : IKDACLPDLNJ, JGJNINBGNFN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct IJMKFPMEKLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NativeList<EHEJDJANAMP> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NativeList<HACAPEBHNOF> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeList<EHEJDJANAMP> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public IJMKFPMEKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, GFMLGHAEBHB previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
		internal void <OnUpdate>b__2(Entity entity, GFMLGHAEBHB previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct PIOGKIHGIGE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct AKBCMMFADBI
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct AFKFAOJEPKN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000307")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ILAODBKEPEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000308")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime PCPALNOEFOJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FFFAHLBALFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> CDDGOJMFJDM;

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x43A5E10", Offset = "0x43A4A10", VA = "0x1843A5E10")]
			public void GDFFALHKOBH(FLEOIAKEDLB IEKCOPFEHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x43A5D90", Offset = "0x43A4990", VA = "0x1843A5D90")]
			public AFKFAOJEPKN DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
			{
				return default(AFKFAOJEPKN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NativeList<EHEJDJANAMP> EHMAJALGMJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private AKBCMMFADBI KHJPHIECPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe AKBCMMFADBI.AFKFAOJEPKN* MKHNGJINIJK;

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x43B0610", Offset = "0x43AF210", VA = "0x1843B0610")]
		internal void HECHOFEKDHF(Entity BODOHICDFAL, ParentData CEKFHLPOBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xDB5E00", Offset = "0xDB4A00", VA = "0x180DB5E00", Slot = "5")]
		public void ReadFromDisplayClass(ref IJMKFPMEKLD HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x43B0430", Offset = "0x43AF030", VA = "0x1843B0430", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x43B04D0", Offset = "0x43AF0D0", VA = "0x1843B04D0")]
		public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, [NoAlias] ref AKBCMMFADBI.AFKFAOJEPKN IKHKHMKOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x43B0580", Offset = "0x43AF180", VA = "0x1843B0580")]
		public void GDFFALHKOBH(FLEOIAKEDLB IEKCOPFEHBF, ref IJMKFPMEKLD HNPKAGHHMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct HKDBBHCBALB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct PIGOAAEEMDN
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct DIFDAKOCHGN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ILAODBKEPEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000310")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime PCPALNOEFOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000311")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<GFMLGHAEBHB>.Runtime MBEJAPEBLCA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FFFAHLBALFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> CDDGOJMFJDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<GFMLGHAEBHB> GPDJFCAPLJC;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x43B03B0", Offset = "0x43AEFB0", VA = "0x1843B03B0")]
			public void GDFFALHKOBH(FLEOIAKEDLB IEKCOPFEHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x43B0310", Offset = "0x43AEF10", VA = "0x1843B0310")]
			public DIFDAKOCHGN DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
			{
				return default(DIFDAKOCHGN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeList<HACAPEBHNOF> IGOALINBHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private PIGOAAEEMDN KHJPHIECPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PIGOAAEEMDN.DIFDAKOCHGN* MKHNGJINIJK;

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x43AAAE0", Offset = "0x43A96E0", VA = "0x1843AAAE0")]
		internal void HECHOFEKDHF(Entity BODOHICDFAL, ParentData CEKFHLPOBFL, GFMLGHAEBHB BMHMPPDEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x43AABA0", Offset = "0x43A97A0", VA = "0x1843AABA0", Slot = "5")]
		public void ReadFromDisplayClass(ref IJMKFPMEKLD HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x43AA8F0", Offset = "0x43A94F0", VA = "0x1843AA8F0", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x43AA9C0", Offset = "0x43A95C0", VA = "0x1843AA9C0")]
		public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, [NoAlias] ref PIGOAAEEMDN.DIFDAKOCHGN IKHKHMKOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x43AAAA0", Offset = "0x43A96A0", VA = "0x1843AAAA0")]
		public void GDFFALHKOBH(FLEOIAKEDLB IEKCOPFEHBF, ref IJMKFPMEKLD HNPKAGHHMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct MKLDOAHEGCJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct ODPNOBDNMKC
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct FDMLMIEIHLC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000317")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ILAODBKEPEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000318")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<GFMLGHAEBHB>.Runtime MBEJAPEBLCA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FFFAHLBALFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<GFMLGHAEBHB> GPDJFCAPLJC;

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x43AF770", Offset = "0x43AE370", VA = "0x1843AF770")]
			public void GDFFALHKOBH(FLEOIAKEDLB IEKCOPFEHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x43AF6F0", Offset = "0x43AE2F0", VA = "0x1843AF6F0")]
			public FDMLMIEIHLC DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
			{
				return default(FDMLMIEIHLC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<EHEJDJANAMP> OKOPAJDBHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private ODPNOBDNMKC KHJPHIECPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ODPNOBDNMKC.FDMLMIEIHLC* MKHNGJINIJK;

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0x43AE580", Offset = "0x43AD180", VA = "0x1843AE580")]
		internal void HECHOFEKDHF(Entity BODOHICDFAL, GFMLGHAEBHB BMHMPPDEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x43AE600", Offset = "0x43AD200", VA = "0x1843AE600", Slot = "5")]
		public void ReadFromDisplayClass(ref IJMKFPMEKLD HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x43AE3A0", Offset = "0x43ACFA0", VA = "0x1843AE3A0", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x43AE440", Offset = "0x43AD040", VA = "0x1843AE440")]
		public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, [NoAlias] ref ODPNOBDNMKC.FDMLMIEIHLC IKHKHMKOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x43AE4F0", Offset = "0x43AD0F0", VA = "0x1843AE4F0")]
		public void GDFFALHKOBH(FLEOIAKEDLB IEKCOPFEHBF, ref IJMKFPMEKLD HNPKAGHHMHE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private KFMIEMINHBG GAFNGAGNIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery OCFLOEMGKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery CCNKAJNCNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private EntityQuery LFBKPFBKJPA;

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x35D2070", Offset = "0x35D0C70", VA = "0x1835D2070", Slot = "14")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x35D2410", Offset = "0x35D1010", VA = "0x1835D2410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public FLEOIAKEDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x35D23B0", Offset = "0x35D0FB0", VA = "0x1835D23B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x35D2150", Offset = "0x35D0D50", VA = "0x1835D2150")]
	public static EntityQuery DNGKBDCNKAA(ComponentSystemBase IEKCOPFEHBF)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x35D26D0", Offset = "0x35D12D0", VA = "0x1835D26D0")]
	public static EntityQuery PBMJNHPGBBJ(ComponentSystemBase IEKCOPFEHBF)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x35D1E70", Offset = "0x35D0A70", VA = "0x1835D1E70")]
	public static EntityQuery ABGGBMINGBO(ComponentSystemBase IEKCOPFEHBF)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[GKALNADHNEP(DAHLALKJFLL.Connectables)]
	public class InitializeRigidbodyExHierarchy : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private EntityQuery GJLGONPKKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private GKBNHKPDNGH OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x35E03D0", Offset = "0x35DEFD0", VA = "0x1835E03D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x35E0360", Offset = "0x35DEF60", VA = "0x1835E0360", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x35E0460", Offset = "0x35DF060", VA = "0x1835E0460", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class NGOGMHFHMBD : ParentSystemBase<ParentData, GFMLGHAEBHB, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x3084FE0", Offset = "0x3083BE0", VA = "0x183084FE0", Slot = "14")]
	protected override EntityQueryDesc MALOFCDGMHB(EntityQueryDesc GJLGONPKKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x801380", Offset = "0x7FFF80", VA = "0x180801380", Slot = "15")]
	protected override EntityQueryDesc EFLINLPKAAB(EntityQueryDesc GJLGONPKKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x3084FA0", Offset = "0x3083BA0", VA = "0x183084FA0", Slot = "16")]
	protected override EntityQueryDesc AEKPHAFLELM(EntityQueryDesc GJLGONPKKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x3085020", Offset = "0x3083C20", VA = "0x183085020", Slot = "17")]
	protected override EntityQueryDesc MHDPFBLNDKI(EntityQueryDesc GJLGONPKKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x30850A0", Offset = "0x3083CA0", VA = "0x1830850A0")]
	public NGOGMHFHMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x3085060", Offset = "0x3083C60", VA = "0x183085060", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : IKDACLPDLNJ where ParentData : struct, IComponentData, EEPPNJCBMLI where PreviousParentData : struct, IComponentData, EEPPNJCBMLI where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, EEPPNJCBMLI
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[BurstCompile]
		private struct IENALKCCOJE : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter CICFLHDJLID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter CIKKLOLMHND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public NativeHashMap<Entity, int>.ParallelWriter IPPMDBBLLAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public ArchetypeChunkComponentType<PreviousParentData> MKAFECEEAEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> GHOIDLOAFBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			[ReadOnly]
			public ArchetypeChunkEntityType KGCNCPGOCAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public uint HDMFBMPHKLP;

			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0x2F02770", Offset = "0x2F01370", VA = "0x182F02770", Slot = "4")]
			public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000109")]
		[BurstCompile]
		private struct PHLGBCPDDMM : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeHashMap<Entity, int> IPPMDBBLLAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> MJALLBPFDJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public NativeList<Entity> LAKJCJHBBJL;

			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0x2DDDDF0", Offset = "0x2DDC9F0", VA = "0x182DDDDF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[BurstCompile]
		private struct OLECBGKHIGO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> CICFLHDJLID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> CIKKLOLMHND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			[ReadOnly]
			public NativeHashMap<Entity, int> IPPMDBBLLAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public BufferFromEntity<ChildrenData> MJALLBPFDJN;

			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0x461C040", Offset = "0x461AC40", VA = "0x18461C040")]
			private int JAKAIBKELCB(DynamicBuffer<ChildrenData> LBMPGEENEFO, Entity BODOHICDFAL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x461B750", Offset = "0x461A350", VA = "0x18461B750")]
			private void ADBPLLAEEFP(Entity NIGFDFKEKGM, DynamicBuffer<ChildrenData> LBMPGEENEFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x461BCD0", Offset = "0x461A8D0", VA = "0x18461BCD0")]
			private void FOMHOBCMLGC(Entity NIGFDFKEKGM, DynamicBuffer<ChildrenData> LBMPGEENEFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x461BB70", Offset = "0x461A770", VA = "0x18461BB70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct HEPPNDAMOLI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public NativeArray<Entity> ELDHOOIOEEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public NativeList<Entity> NJFILFAEPLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public BufferFromEntity<ChildrenData> MJALLBPFDJN;

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x390EDE0", Offset = "0x390D9E0", VA = "0x18390EDE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected EntityQuery NGPKDNJBFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected EntityQuery OBKNEGFEGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected EntityQuery EIPKGAKPCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected EntityQuery JKNEKFPEFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected ProfilerMarker PGFNPFLHOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected ProfilerMarker BPHDNFGMELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected ProfilerMarker HNLBNPEADBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected ProfilerMarker GJEPPOBLHPM;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x300A400", Offset = "0x3009000", VA = "0x18300A400")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x3009820", Offset = "0x3008420", VA = "0x183009820")]
		private int JAKAIBKELCB(DynamicBuffer<ChildrenData> LBMPGEENEFO, Entity BODOHICDFAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x3008EB0", Offset = "0x3007AB0", VA = "0x183008EB0")]
		private void BGFAMNHOBLB(Entity APEKMDLDKDH, Entity BPFDJHBNCGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x801380", Offset = "0x7FFF80", VA = "0x180801380", Slot = "14")]
		protected virtual EntityQueryDesc MALOFCDGMHB(EntityQueryDesc GJLGONPKKFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x801380", Offset = "0x7FFF80", VA = "0x180801380", Slot = "15")]
		protected virtual EntityQueryDesc EFLINLPKAAB(EntityQueryDesc GJLGONPKKFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x801380", Offset = "0x7FFF80", VA = "0x180801380", Slot = "16")]
		protected virtual EntityQueryDesc AEKPHAFLELM(EntityQueryDesc GJLGONPKKFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc MHDPFBLNDKI(EntityQueryDesc GJLGONPKKFL);

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x3009C90", Offset = "0x3008890", VA = "0x183009C90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x3008380", Offset = "0x3006F80", VA = "0x183008380")]
		private void AOKHCIOJDAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x3009910", Offset = "0x3008510", VA = "0x183009910")]
		private void LLABFKCEKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x3008450", Offset = "0x3007050", VA = "0x183008450")]
		private JobHandle BFJHOAFLBFB(JobHandle PJNPMKLPJLL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x3009170", Offset = "0x3007D70", VA = "0x183009170")]
		private void DKCJJGJOFEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x300A1D0", Offset = "0x3008DD0", VA = "0x18300A1D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x2FE1780", Offset = "0x2FE0380", VA = "0x182FE1780", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x2F9FC90", Offset = "0x2F9E890", VA = "0x182F9FC90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[AlwaysUpdateSystem]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
public abstract class DAHJDDBJINO : IKDACLPDLNJ, JGJNINBGNFN
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private struct HHIKNFHMEMC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public global::GFPHNEMLNOJ<Entity> JKHJBKGECCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public global::GFPHNEMLNOJ<Entity> PPFMFAIEOBN;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x332D0E0", Offset = "0x332BCE0", VA = "0x18332D0E0")]
		public HHIKNFHMEMC(NativeList<Entity> JKHJBKGECCI, NativeList<Entity> PPFMFAIEOBN, JobHandle HJBACIKDILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x332CFD0", Offset = "0x332BBD0", VA = "0x18332CFD0")]
		public JobHandle CFPLNJKCFKK(JobHandle PJNPMKLPJLL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x332D050", Offset = "0x332BC50", VA = "0x18332D050", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct PBDPGHKHEHE : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		public enum CMLGPGKLMLD
		{
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[WriteOnly]
		public NativeList<Entity> NHEANLIOGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[WriteOnly]
		public NativeList<Entity> ENIDDOPKPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[ReadOnly]
		public NativeArray<Entity> GOIBDGEJALP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> BPMIBKIBMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[ReadOnly]
		public ACOGKCNIFAF PKCLEMOPHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		[ReadOnly]
		public ACOGKCNIFAF COBCDBNODPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> EGACNKCAPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int FJOPDNEFBEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int FOFEKNGHDBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private CMLGPGKLMLD PMMHENGNOJP;

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x33303B0", Offset = "0x332EFB0", VA = "0x1833303B0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x33305C0", Offset = "0x332F1C0", VA = "0x1833305C0")]
		private void GMAKBKNHBLN(Entity BODOHICDFAL, bool EIKOEMCAPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x3330730", Offset = "0x332F330", VA = "0x183330730")]
		private void PPCJFNOBMFO(Entity BODOHICDFAL, bool EIKOEMCAPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x3330540", Offset = "0x332F140", VA = "0x183330540")]
		public HHIKNFHMEMC FNCJJKMFNCD(NativeArray<Entity> HFEFAFDMCBB, JobHandle PJNPMKLPJLL)
		{
			return default(HHIKNFHMEMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x332FF10", Offset = "0x332EB10", VA = "0x18332FF10")]
		public HHIKNFHMEMC CGPOPJGLMBC(NativeArray<Entity> HFEFAFDMCBB, JobHandle PJNPMKLPJLL)
		{
			return default(HHIKNFHMEMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x3330650", Offset = "0x332F250", VA = "0x183330650")]
		public HHIKNFHMEMC KHPPMLFNNAO(NativeList<EHEJDJANAMP> FOLHIKGIGJA, JobHandle PJNPMKLPJLL)
		{
			return default(HHIKNFHMEMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x33301F0", Offset = "0x332EDF0", VA = "0x1833301F0")]
		public HHIKNFHMEMC DAFJPEMPFGG(NativeList<EHEJDJANAMP> FOLHIKGIGJA, JobHandle PJNPMKLPJLL)
		{
			return default(HHIKNFHMEMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x33302D0", Offset = "0x332EED0", VA = "0x1833302D0")]
		public HHIKNFHMEMC EFFGPFMHMJP(NativeList<HACAPEBHNOF> FOLHIKGIGJA, JobHandle PJNPMKLPJLL)
		{
			return default(HHIKNFHMEMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x301D6D0", Offset = "0x301C2D0", VA = "0x18301D6D0")]
		private HHIKNFHMEMC CKOOMMCIDHH<T>(NativeList<T> FOLHIKGIGJA, int CDPBBLOLCBO, int GNJNJDOCPEA, CMLGPGKLMLD NGMKMMBHLMI, JobHandle PJNPMKLPJLL) where T : struct
		{
			return default(HHIKNFHMEMC);
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x332FF90", Offset = "0x332EB90", VA = "0x18332FF90")]
		private HHIKNFHMEMC CKOOMMCIDHH(NativeArray<Entity> EADNCMDNEKI, int CDPBBLOLCBO, int GNJNJDOCPEA, CMLGPGKLMLD NGMKMMBHLMI, JobHandle PJNPMKLPJLL)
		{
			return default(HHIKNFHMEMC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly FCNKBCOKGMK OIFMFCIPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private EntityQuery NDNPHAMJBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private EntityQuery HINIPELMJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private KFMIEMINHBG NFGCOACNJLI;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	protected abstract ComponentType FJCHDPGIIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	protected abstract ComponentType PFLHOHIOIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	protected abstract ComponentType DBHLLFFIHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x31AF930", Offset = "0x31AE530", VA = "0x1831AF930")]
	protected DAHJDDBJINO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x31AE4C0", Offset = "0x31AD0C0", VA = "0x1831AE4C0", Slot = "14")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x31AE890", Offset = "0x31AD490", VA = "0x1831AE890", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x31AEAC0", Offset = "0x31AD6C0", VA = "0x1831AEAC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0xA0FC70", Offset = "0xA0E870", VA = "0x180A0FC70", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x31AE460", Offset = "0x31AD060", VA = "0x1831AE460")]
	private void BNCHHINEKPH(NativeArray<Entity> FOLHIKGIGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x31AE7F0", Offset = "0x31AD3F0", VA = "0x1831AE7F0")]
	private void HDBHAFHMKKB(NativeArray<Entity> FOLHIKGIGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x31AE5A0", Offset = "0x31AD1A0", VA = "0x1831AE5A0")]
	private void DAKJHOBOJPB(HHIKNFHMEMC PILOMCEPGEM, string LBONDKPAKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x31AE6E0", Offset = "0x31AD2E0", VA = "0x1831AE6E0")]
	private void DAKJHOBOJPB(global::GFPHNEMLNOJ<Entity> AKJFNDEFPDP, string LBONDKPAKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x31AE320", Offset = "0x31ACF20", VA = "0x1831AE320")]
	private void AMADLHAELPN(HHIKNFHMEMC PILOMCEPGEM, string LBONDKPAKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x31AE210", Offset = "0x31ACE10", VA = "0x1831AE210")]
	private void AMADLHAELPN(global::GFPHNEMLNOJ<Entity> AKJFNDEFPDP, string LBONDKPAKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x31AE1A0", Offset = "0x31ACDA0", VA = "0x1831AE1A0")]
	private bool AHFEKFMCDED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
public class NJAGBACNJAM : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct OCIKDDCEECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public NJAGBACNJAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public OCIKDDCEECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct JLEBFLDEDEK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct KEBIAMJIAGG
		{
			[Cpp2IlInjected.Token(Token = "0x2000114")]
			public struct PLJGENFNAKC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000358")]
				public LambdaParameterValueProvider_Entity.Runtime IIOOHENLIBP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GDJODNFJAHB;

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x43AC5E0", Offset = "0x43AB1E0", VA = "0x1843AC5E0")]
			public void GDFFALHKOBH(NJAGBACNJAM IEKCOPFEHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x43AC5D0", Offset = "0x43AB1D0", VA = "0x1843AC5D0")]
			public PLJGENFNAKC DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
			{
				return default(PLJGENFNAKC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public NJAGBACNJAM CNNCDNBBCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public EntityCommandBuffer ICAFLEIIPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private KEBIAMJIAGG KHJPHIECPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KEBIAMJIAGG.PLJGENFNAKC* MKHNGJINIJK;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PHJMPFOKBGL;

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x43AC250", Offset = "0x43AAE50", VA = "0x1843AC250")]
		internal void HECHOFEKDHF(Entity MPIBPKBJNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x43AB560", Offset = "0x43AA160", VA = "0x1843AB560", Slot = "5")]
		public void ReadFromDisplayClass(ref OCIKDDCEECM HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA190", VA = "0x1843AB590", Slot = "6")]
		public void WriteToDisplayClass(ref OCIKDDCEECM HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x43AC0E0", Offset = "0x43AACE0", VA = "0x1843AC0E0", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x43AC130", Offset = "0x43AAD30", VA = "0x1843AC130")]
		public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, ref KEBIAMJIAGG.PLJGENFNAKC IKHKHMKOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x43AC1A0", Offset = "0x43AADA0", VA = "0x1843AC1A0")]
		public void GDFFALHKOBH(NJAGBACNJAM IEKCOPFEHBF, ref OCIKDDCEECM HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x43AC1E0", Offset = "0x43AADE0", VA = "0x1843AC1E0")]
		public unsafe static void GGIFGIINNMA(ArchetypeChunkIterator* PCLDPFNHHHB, void* AKDGMOCNLFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private LFCDEBLNINK GNMAGPOAKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private FICBCEGLJFC AFPEGMLCABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private EntityQuery FNKMEFCLMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private ProfilerMarker LGJNCAFJKFK;

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x30854E0", Offset = "0x30840E0", VA = "0x1830854E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x30853A0", Offset = "0x3083FA0", VA = "0x1830853A0", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x3085540", Offset = "0x3084140", VA = "0x183085540", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public NJAGBACNJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x3085400", Offset = "0x3084000", VA = "0x183085400", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x30851D0", Offset = "0x3083DD0", VA = "0x1830851D0")]
	public static EntityQuery AKFBDJMFPEN(ComponentSystemBase IEKCOPFEHBF)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[FJJLKPGAMCM]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
public class PJIJNLHBCCI : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private FICBCEGLJFC AFPEGMLCABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private SceneService LJMHKNOAABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private EntityQuery GJLGONPKKFL;

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x309A510", Offset = "0x3099110", VA = "0x18309A510", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x309A580", Offset = "0x3099180", VA = "0x18309A580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x309A620", Offset = "0x3099220", VA = "0x18309A620", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public PJIJNLHBCCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public struct MJAODLLEDLM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public LKIMDJNJKEE LBLAJOOMAIC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x695E30", Offset = "0x694A30", VA = "0x180695E30")]
	public static MJAODLLEDLM GGDPAIJEDCE(in LKIMDJNJKEE BJEPNJEAIBA)
	{
		return default(MJAODLLEDLM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x695E30", Offset = "0x694A30", VA = "0x180695E30")]
	public static LKIMDJNJKEE GGDPAIJEDCE(in MJAODLLEDLM LGJJILEMOJN)
	{
		return default(LKIMDJNJKEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[AlwaysUpdateSystem]
public class LFCDEBLNINK : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x35E6DD0", Offset = "0x35E59D0", VA = "0x1835E6DD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0")]
	public LFCDEBLNINK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[AlwaysUpdateSystem]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
public class EKAKEBNKPCJ : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct KIDMAKCIDNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public EKAKEBNKPCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public KIDMAKCIDNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
		internal void <OnUpdate>b__0(Entity e, MJAODLLEDLM ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct IBNKMOFFNIP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct BLCEOHCMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			public struct OJKOHLFBGBK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public LambdaParameterValueProvider_Entity.Runtime IIOOHENLIBP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_IComponentData<MJAODLLEDLM>.Runtime CEHDAJMKKPM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GDJODNFJAHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<MJAODLLEDLM> IJIONDDLHBC;

			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0x43A64D0", Offset = "0x43A50D0", VA = "0x1843A64D0")]
			public void GDFFALHKOBH(EKAKEBNKPCJ IEKCOPFEHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x43A6450", Offset = "0x43A5050", VA = "0x1843A6450")]
			public OJKOHLFBGBK DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
			{
				return default(OJKOHLFBGBK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public EKAKEBNKPCJ CNNCDNBBCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer ICAFLEIIPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private BLCEOHCMBGN KHJPHIECPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BLCEOHCMBGN.OJKOHLFBGBK* MKHNGJINIJK;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PHJMPFOKBGL;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x43AB460", Offset = "0x43AA060", VA = "0x1843AB460")]
		internal void HECHOFEKDHF(Entity MPIBPKBJNBB, MJAODLLEDLM PBFNNMCFCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x43AB560", Offset = "0x43AA160", VA = "0x1843AB560", Slot = "5")]
		public void ReadFromDisplayClass(ref KIDMAKCIDNG HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA190", VA = "0x1843AB590", Slot = "6")]
		public void WriteToDisplayClass(ref KIDMAKCIDNG HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x43AB210", Offset = "0x43A9E10", VA = "0x1843AB210", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x43AB2B0", Offset = "0x43A9EB0", VA = "0x1843AB2B0")]
		public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, ref BLCEOHCMBGN.OJKOHLFBGBK IKHKHMKOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x43AB360", Offset = "0x43A9F60", VA = "0x1843AB360")]
		public void GDFFALHKOBH(EKAKEBNKPCJ IEKCOPFEHBF, ref KIDMAKCIDNG HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x43AB3F0", Offset = "0x43A9FF0", VA = "0x1843AB3F0")]
		public unsafe static void GGIFGIINNMA(ArchetypeChunkIterator* PCLDPFNHHHB, void* AKDGMOCNLFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private LFCDEBLNINK GNMAGPOAKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private FICBCEGLJFC AFPEGMLCABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery GCPOKPJFCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private ProfilerMarker JLDELNAHEPL;

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x31B4B50", Offset = "0x31B3750", VA = "0x1831B4B50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x31B4A10", Offset = "0x31B3610", VA = "0x1831B4A10", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x31B4BB0", Offset = "0x31B37B0", VA = "0x1831B4BB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public EKAKEBNKPCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x31B4A70", Offset = "0x31B3670", VA = "0x1831B4A70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x31B4D10", Offset = "0x31B3910", VA = "0x1831B4D10")]
	public static EntityQuery PGGBNNLNDKA(ComponentSystemBase IEKCOPFEHBF)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct ALBPFHPOKEI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public IPFANALALDA OBDKJOBOIMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeHashMap<Entity, CJFIGKJMGNA> EADNCMDNEKI;

			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x43A5EF0", Offset = "0x43A4AF0", VA = "0x1843A5EF0")]
			public ALBPFHPOKEI(int KOHJKAOCDIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x43A5E70", Offset = "0x43A4A70", VA = "0x1843A5E70", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[BurstCompile]
		private struct MLIGHAODLKB : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			[ReadOnly]
			public NativeArray<Entity> EADNCMDNEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> GMLLOMLHODK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> GKHEBHLINOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> JFNGAAKAHCD;

			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0x43AE610", Offset = "0x43AD210", VA = "0x1843AE610", Slot = "4")]
			public void Execute(int KLEGICPDLIF, TransformAccess IGPPDIMEFDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[BurstCompile]
		private struct NLLNKAHKJPD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			public NativeArray<Entity> EADNCMDNEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> GMLLOMLHODK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> JFNGAAKAHCD;

			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x43AF5A0", Offset = "0x43AE1A0", VA = "0x1843AF5A0", Slot = "4")]
			public void Execute(int KLEGICPDLIF, TransformAccess IGPPDIMEFDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private FICBCEGLJFC AFPEGMLCABP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private EntityQuery DHHELDLOAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private EntityQuery KDLKAOEHKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EntityQuery JOILNKFBOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private EntityQuery NJNNBIJJKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private EntityQuery JNLGPPMDFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private JobHandle PCHPGEJFDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private ALBPFHPOKEI ANFCCKKMOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private ALBPFHPOKEI MOCBNALJICC;

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x309D1B0", Offset = "0x309BDB0", VA = "0x18309D1B0", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x309DB50", Offset = "0x309C750", VA = "0x18309DB50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x309DB10", Offset = "0x309C710", VA = "0x18309DB10", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x309DE10", Offset = "0x309CA10", VA = "0x18309DE10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x309D9D0", Offset = "0x309C5D0", VA = "0x18309D9D0")]
		private void LEHFDGFLPAD(EntityQuery GJLGONPKKFL, out (global::OEJJJGPOENI<MJAODLLEDLM> handles, global::OEJJJGPOENI<DAMMKIPJFBC> bounds) GAGLKGONONJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x309D770", Offset = "0x309C370", VA = "0x18309D770")]
		private void JMGEKCLFBHO((global::OEJJJGPOENI<MJAODLLEDLM> handles, global::OEJJJGPOENI<DAMMKIPJFBC> bounds) GAGLKGONONJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x309DB10", Offset = "0x309C710", VA = "0x18309DB10")]
		private void OINPLJBAPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x309D500", Offset = "0x309C100", VA = "0x18309D500")]
		private void GAEPIMGKOHO(EntityQuery GJLGONPKKFL, out (global::OEJJJGPOENI<Entity> entities, global::OEJJJGPOENI<MJAODLLEDLM> handles) GAGLKGONONJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x309D210", Offset = "0x309BE10", VA = "0x18309D210")]
		private void FJDMBMMEKCN((global::OEJJJGPOENI<Entity> entities, global::OEJJJGPOENI<MJAODLLEDLM> handles) GAGLKGONONJ, ALBPFHPOKEI LIDKKHLDANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x309D050", Offset = "0x309BC50", VA = "0x18309D050")]
		private JobHandle CLOFKJEEEBM(ALBPFHPOKEI LIDKKHLDANL, ComponentDataFromEntity<WorldPoseData> GMLLOMLHODK, ComponentDataFromEntity<WorldUniformScaleData> JFNGAAKAHCD, ComponentDataFromEntity<WorldDeformableScaleData> GKHEBHLINOJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x309D640", Offset = "0x309C240", VA = "0x18309D640")]
		private JobHandle HMPNLAOAEMC(ALBPFHPOKEI LIDKKHLDANL, ComponentDataFromEntity<WorldPoseData> GMLLOMLHODK, ComponentDataFromEntity<WorldUniformScaleData> JFNGAAKAHCD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
public struct GODHBCGOIOJ : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[FJJLKPGAMCM]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	public class SplineLocalBoundsSystem : IKDACLPDLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct GMIPLGAHMNI : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			[ReadOnly]
			public NativeArray<Entity> AFJBMFALKML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> ADNBFNOJKPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			[ReadOnly]
			public ComponentDataFromEntity<DAMMKIPJFBC> LFHHPAJLBDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			[WriteOnly]
			public NativeHashMap<Entity, CJFIGKJMGNA>.ParallelWriter KEEFKLLCIEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter DPNGDDECAMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter BDGNCALJMPK;

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x43A9DD0", Offset = "0x43A89D0", VA = "0x1843A9DD0", Slot = "4")]
			public void Execute(int KLEGICPDLIF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[BurstCompile]
		private struct DAEMAONNOCK : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			[ReadOnly]
			public NativeArray<Entity> GJPBKAHMOHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> DNDOLEONONB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> JIOFHPEODIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> GCIECFPOJNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<DAMMKIPJFBC> ABGBBNOFPCF;

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0x43A79C0", Offset = "0x43A65C0", VA = "0x1843A79C0", Slot = "4")]
			public void Execute(int KLEGICPDLIF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private EntityQuery BACNOCJCOOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery HHEIPCNIGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery OPIDCMJFPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery BEGFOBPLBFL;

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x3339270", Offset = "0x3337E70", VA = "0x183339270", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x3339480", Offset = "0x3338080", VA = "0x183339480", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x3338FE0", Offset = "0x3337BE0", VA = "0x183338FE0")]
		private JobHandle LPAJHKOIHLD(global::OEJJJGPOENI<Entity> NMDKCEHJACP, int LNLAAEPHJPC, JobHandle PJNPMKLPJLL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x3338E00", Offset = "0x3337A00", VA = "0x183338E00")]
		private JobHandle LPAJHKOIHLD(NativeArray<Entity> CDCHLFDINPA, int LNLAAEPHJPC, [Optional] JobHandle PJNPMKLPJLL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x33391F0", Offset = "0x3337DF0", VA = "0x1833391F0")]
		private global::OEJJJGPOENI<Entity> MOMAFJOFJII(EntityQuery GJLGONPKKFL)
		{
			return default(global::OEJJJGPOENI<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x33399A0", Offset = "0x33385A0", VA = "0x1833399A0")]
		private (global::GFPHNEMLNOJ<Entity>, global::GFPHNEMLNOJ<Entity>) PIAPFAKJECA(global::OEJJJGPOENI<Entity> FFKAKPFEFHK)
		{
			return default((global::GFPHNEMLNOJ<Entity>, global::GFPHNEMLNOJ<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x3339F50", Offset = "0x3338B50", VA = "0x183339F50")]
		private void PMFGNKGDEGB(out NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x3339DF0", Offset = "0x33389F0", VA = "0x183339DF0")]
		private void PKIBCEBHEGD(NativeList<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x3339E80", Offset = "0x3338A80", VA = "0x183339E80")]
		private void PKIBCEBHEGD(NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x33390C0", Offset = "0x3337CC0", VA = "0x1833390C0")]
		private void LPLAGLODPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		private static void JOCNOEMNJAI(int COKDPLPFJLK, int MFNEILOGABO, int MEFPMMEGHLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x3338AD0", Offset = "0x33376D0", VA = "0x183338AD0")]
		private static DAMMKIPJFBC FPBCHMENENJ(NativeArray<Entity> CMCKCBMPFEP, ComponentDataFromEntity<SplinePointPositionData> JIOFHPEODIC, ComponentDataFromEntity<SplinePointScaleData> GCIECFPOJNC)
		{
			return default(DAMMKIPJFBC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct DGLOCFKJHFM : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[FJJLKPGAMCM]
	[GKALNADHNEP(DAHLALKJFLL.Lifecycle)]
	public class DestroyLocalObjects : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		[NNMLOJPMNKB]
		private ObjectNetworkToLocalMapService GMAKJKHGELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		[NNMLOJPMNKB]
		private ObjectLifecycleService LPHFEOKHKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private EntityQuery BFMBMNIDGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery HDCHEAILJKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery ENPKNDNEDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private bool JIGLPOGPBPP;

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x31B2620", Offset = "0x31B1220", VA = "0x1831B2620", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x31B2570", Offset = "0x31B1170", VA = "0x1831B2570")]
		public bool DDJIPOAPDGI(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x31B27A0", Offset = "0x31B13A0", VA = "0x1831B27A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x31B28F0", Offset = "0x31B14F0", VA = "0x1831B28F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x31B28D0", Offset = "0x31B14D0", VA = "0x1831B28D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x22DB920", Offset = "0x22DA520", VA = "0x1822DB920", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x31B28F0", Offset = "0x31B14F0", VA = "0x1831B28F0")]
		private void PIHBONFAOMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x31B2A50", Offset = "0x31B1650", VA = "0x1831B2A50")]
		private void PGIBEIJIGAM(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x31B2430", Offset = "0x31B1030", VA = "0x1831B2430")]
		private void ABNICIMKMMK(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x31B2690", Offset = "0x31B1290", VA = "0x1831B2690")]
		private void OFFMEOFFPKD(NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x31B2930", Offset = "0x31B1530", VA = "0x1831B2930")]
		private void PELFMCFEDNF(NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.NetworkSend)]
	public sealed class EnqueuePropertyDifferenceToNetwork : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private static JEGPFMALOAP[] BBJLLBIINKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private HLAAIMIPCBN KEEEFNKODDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private IPPGPHBJPJM OHLGCBLDIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private PropertyDiffStateService GBMKHHIBDOI;

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x35CF090", Offset = "0x35CDC90", VA = "0x1835CF090", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x35CF6D0", Offset = "0x35CE2D0", VA = "0x1835CF6D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x35CF140", Offset = "0x35CDD40", VA = "0x1835CF140")]
		private void MGOICBCDCAP(JEGPFMALOAP PEMMOPHCPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		private void IBCNOAOJBMA(Entity BODOHICDFAL, KFMKFJINGPH AAEPEKAJNKI, CFLHDMKEGPM PJBLNEEFIAM, DBLNAIGHAJO CAPDOMOPGCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[GKALNADHNEP(DAHLALKJFLL.Callbacks)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	public sealed class PropertyEventCallbacks : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private PropertyEventCallbacksService EJGPHLKANJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private PropertyDiffStateService GBMKHHIBDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TransformOwnershipPhase PEMMOPHCPHE;

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x30A3C70", Offset = "0x30A2870", VA = "0x1830A3C70", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x30A3D00", Offset = "0x30A2900", VA = "0x1830A3D00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[GKALNADHNEP(DAHLALKJFLL.NetworkSend)]
	internal class TransmitNetworkDataSystem : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private EIMKOOLGBOC KKHJJOGANHE;

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x3340EC0", Offset = "0x333FAC0", VA = "0x183340EC0", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x3340F10", Offset = "0x333FB10", VA = "0x183340F10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[FJJLKPGAMCM]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	public class CalculateCullingBandChanges : IKDACLPDLNJ, AHBNMIIEDML, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[BurstCompile]
		private struct EOBOGDKFFCC : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			[ReadOnly]
			public ArchetypeChunkEntityType GOEDEOHJACL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> KDODCPCENJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			[WriteOnly]
			public NativeList<NAICAHDKLBJ>.ParallelWriter LDLMPJJNLCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public ArchetypeChunkComponentType<NCJHAPOJBAO> MGPJINDEMLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public float3 GNFCHOKJPJE;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private static readonly float4x2 ODAONAMNABA;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private static readonly float4x2 GPFGIGLEKFA;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private static readonly int4x2 AGIHAJAIICE;

			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x332C610", Offset = "0x332B210", VA = "0x18332C610", Slot = "4")]
			public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private static FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private const int CFGIKOFBGFB = 10;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private const double PEMPGIGFECC = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private EntityQuery DHDDICLHHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private EntityQuery PMEGBLGMKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private double OFJODHPMHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private CullingBandService JHMJHNHHMOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private TimeService IOBEJOJDLDH;

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x31A3730", Offset = "0x31A2330", VA = "0x1831A3730", Slot = "14")]
		public void PHKHGJFAMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x31A2FF0", Offset = "0x31A1BF0", VA = "0x1831A2FF0", Slot = "15")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x31A33C0", Offset = "0x31A1FC0", VA = "0x1831A33C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x31A3510", Offset = "0x31A2110", VA = "0x1831A3510", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x31A2F80", Offset = "0x31A1B80", VA = "0x1831A2F80")]
		private bool AFDOFPOJDME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x31A3080", Offset = "0x31A1C80", VA = "0x1831A3080")]
		private void FMOFJMNPDDJ(EntityQuery GJLGONPKKFL, float3 BBGCFAKGOHO, string MKPDFAEIFFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct NAICAHDKLBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public Entity BODOHICDFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public GLFCIJEPLEC BNKKPEFEMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public GLFCIJEPLEC AIGOLOAIBCA;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	public class ProcessCullingBandChangeCallbacks : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private CullingBandService JHMJHNHHMOF;

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x30A0790", Offset = "0x309F390", VA = "0x1830A0790", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x30A07E0", Offset = "0x309F3E0", VA = "0x1830A07E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[GKALNADHNEP(DAHLALKJFLL.Connectables)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	public class UpdateInertialProperties : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery NIPDKPAMNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private BOFPEDCAMNK JCHOHPDLFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x3347A80", Offset = "0x3346680", VA = "0x183347A80", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x3347AF0", Offset = "0x33466F0", VA = "0x183347AF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x3347B80", Offset = "0x3346780", VA = "0x183347B80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[FJJLKPGAMCM]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> JLIDGEPBCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MHLDHOOLLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> EEBDNMABLMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private KinematicSleepChangeService BLIMGEOGFDA;

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x35CE4B0", Offset = "0x35CD0B0", VA = "0x1835CE4B0", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x35CE8A0", Offset = "0x35CD4A0", VA = "0x1835CE8A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x35CDF90", Offset = "0x35CCB90", VA = "0x1835CDF90")]
		private void BLNCAOEILIA(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> FOLHIKGIGJA, EntityQueryDesc KNAFEBCEPNN, bool AGNPIGFLDBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x35CDE50", Offset = "0x35CCA50", VA = "0x1835CDE50")]
		private void BLNCAOEILIA(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> FOLHIKGIGJA, EntityQueryDesc KNAFEBCEPNN, bool AGNPIGFLDBJ, bool NPDJDHDPINH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x35CEB00", Offset = "0x35CD700", VA = "0x1835CEB00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x35CE0A0", Offset = "0x35CCCA0", VA = "0x1835CE0A0")]
		private void CFKKPCLIDHN(EntityQuery GJLGONPKKFL, bool IKOPEBFIMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x35CDBB0", Offset = "0x35CC7B0", VA = "0x1835CDBB0")]
		private void AOLADDNJJCF(EntityQuery GJLGONPKKFL, bool CPFNEHAOLOM, bool IKOPEBFIMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x35CE290", Offset = "0x35CCE90", VA = "0x1835CE290")]
		private void CJGLOGHDPJM(NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x35CDA40", Offset = "0x35CC640", VA = "0x1835CDA40")]
		private void AMJAJHAOBCD(NativeList<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x35CE780", Offset = "0x35CD380", VA = "0x1835CE780")]
		private void OPOPBGHCDEI(NativeArray<Entity> EADNCMDNEKI, bool CPFNEHAOLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x35CE540", Offset = "0x35CD140", VA = "0x1835CE540")]
		private NativeList<Entity> LIIHAGDIIOB(NativeArray<Entity> EADNCMDNEKI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x35CE740", Offset = "0x35CD340", VA = "0x1835CE740")]
		private NativeList<Entity> NPBAGBAPEIF(NativeArray<Entity> EADNCMDNEKI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x35CE500", Offset = "0x35CD100", VA = "0x1835CE500")]
		private NativeList<Entity> GJIEDEMIOGP(NativeArray<Entity> EADNCMDNEKI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x35CEDD0", Offset = "0x35CD9D0", VA = "0x1835CEDD0")]
		private NativeList<Entity> PNCNCCADGFD(NativeArray<Entity> EADNCMDNEKI, bool IGPEJGGOMFA)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x35CDDC0", Offset = "0x35CC9C0", VA = "0x1835CDDC0")]
		private JBODLEJMMDI BFNGLPCMGLO(NativeArray<Entity> EADNCMDNEKI)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(JBODLEJMMDI);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x35CEFC0", Offset = "0x35CDBC0", VA = "0x1835CEFC0")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private KinematicSleepChangeService BLIMGEOGFDA;

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x30A0800", Offset = "0x309F400", VA = "0x1830A0800", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x30A0850", Offset = "0x309F450", VA = "0x1830A0850", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : PDHHEADABLB
	{
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private static FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery NAPPFEPBGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EntityQuery MCOLLHBLGEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private EntityQuery HFOINHKNDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery CGLIMHOBEDL;

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x31B20A0", Offset = "0x31B0CA0", VA = "0x1831B20A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x31B2260", Offset = "0x31B0E60", VA = "0x1831B2260", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x31B1E60", Offset = "0x31B0A60", VA = "0x1831B1E60")]
		private void LJBOHFHDLHA(EntityQuery GJLGONPKKFL, bool BBIFELIGBKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x31B1C20", Offset = "0x31B0820", VA = "0x1831B1C20")]
		private void FJJFKLCAJNC(EntityQuery GJLGONPKKFL, bool BBIFELIGBKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[GKALNADHNEP(DAHLALKJFLL.Scope)]
	internal class AssignPlayerIdsSystem : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery KJDPDIACCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private EntityQuery IOFKAFHPPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private SceneService HHAEJHNBEEM;

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x319C130", Offset = "0x319AD30", VA = "0x18319C130", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x319C3F0", Offset = "0x319AFF0", VA = "0x18319C3F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x319C500", Offset = "0x319B100", VA = "0x18319C500", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x319BD00", Offset = "0x319A900", VA = "0x18319BD00")]
		private void AHPKJLOOOJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x319BB90", Offset = "0x319A790", VA = "0x18319BB90")]
		private void ACPGCLOLDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x319BE10", Offset = "0x319AA10", VA = "0x18319BE10")]
		private void CAIOINFBJCL(NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x319C2B0", Offset = "0x319AEB0", VA = "0x18319C2B0")]
		private void MPHOLLKCLLA(NativeArray<Entity> EADNCMDNEKI, int BMPJNPENBOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x319C1A0", Offset = "0x319ADA0", VA = "0x18319C1A0")]
		private void JHDPFKPNDLC(NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x319C520", Offset = "0x319B120", VA = "0x18319C520")]
		private void PALCKPHMPLG(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		private static void EGBPJBAIBIJ(int NKHNEPFILOP, Transform IGPPDIMEFDL, Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class IFKHHDGBPLJ
{
	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x35DEFB0", Offset = "0x35DDBB0", VA = "0x1835DEFB0")]
	public static bool OEHOIAFFFEJ(this SystemBase BHDJNCHMFPK, out Entity BODOHICDFAL)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery OIOMBDJFFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private JOIOCJOMOCG OKPEPNEHKJN;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x31A4E90", Offset = "0x31A3A90", VA = "0x1831A4E90", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x31A4EE0", Offset = "0x31A3AE0", VA = "0x1831A4EE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x31A4FA0", Offset = "0x31A3BA0", VA = "0x1831A4FA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[GKALNADHNEP(DAHLALKJFLL.Scope)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<FEKLBDGBDNL>, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private const string KLOGELIBLJI = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private GKFPLKMFEAO DHBHEAOPPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery MIJOCAFNPEH;

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		private Entity MMCFPOFEMJD
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x35E8390", Offset = "0x35E6F90", VA = "0x1835E8390")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x35E82A0", Offset = "0x35E6EA0", VA = "0x1835E82A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		private Entity GPLHNLDJALE
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x35E7C70", Offset = "0x35E6870", VA = "0x1835E7C70")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public CGECBEAFDFK BKFBKMLBLDO
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0x35E8300", Offset = "0x35E6F00", VA = "0x1835E8300")]
			get
			{
				return default(CGECBEAFDFK);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x35E8480", Offset = "0x35E7080", VA = "0x1835E8480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public CGECBEAFDFK IPEDJINONCD
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x35E8210", Offset = "0x35E6E10", VA = "0x1835E8210")]
			get
			{
				return default(CGECBEAFDFK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x35E8530", Offset = "0x35E7130", VA = "0x1835E8530", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x35E80C0", Offset = "0x35E6CC0", VA = "0x1835E80C0", Slot = "15")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x35E85D0", Offset = "0x35E71D0", VA = "0x1835E85D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x35E7CD0", Offset = "0x35E68D0", VA = "0x1835E7CD0", Slot = "14")]
		protected override void BDAIFNFBDDP(NativeArray<Entity> EADNCMDNEKI, NativeArray<Entity> DNJCNCMHKDP, NativeArray<Entity> DKBBJDPENCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x35E8130", Offset = "0x35E6D30", VA = "0x1835E8130")]
		private void GGCFLJPFOJC(NativeArray<Entity> EADNCMDNEKI, NativeArray<Entity> DKBBJDPENCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x35E7E20", Offset = "0x35E6A20", VA = "0x1835E7E20")]
		private void EFJPOMKLAAM(Entity BODOHICDFAL, Entity INDCMGIALMH, Entity ICLODOFJOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1F60", Offset = "0x3DD0B60", VA = "0x183DD1F60")]
		private bool JIJNIMCPPHN<T>(out T NENFOEKGNGK) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1EA0", Offset = "0x3DD0AA0", VA = "0x183DD1EA0")]
		private void FFIBKKMIOAO<T>(T NENFOEKGNGK) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x35E8420", Offset = "0x35E7020", VA = "0x1835E8420")]
		public bool NJGHNEEFFCB(CGECBEAFDFK MPAFOPEFJOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x35E83F0", Offset = "0x35E6FF0", VA = "0x1835E83F0")]
		private static bool NDJCLFLOMCI(CGECBEAFDFK MMBNHFNIJHJ, CGECBEAFDFK GDPCKEMLGJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x35E86A0", Offset = "0x35E72A0", VA = "0x1835E86A0")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x35E84F0", Offset = "0x35E70F0", VA = "0x1835E84F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[GKALNADHNEP(DAHLALKJFLL.Scope)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private EntityQuery GJLGONPKKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x31AD240", Offset = "0x31ABE40", VA = "0x1831AD240", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x31AD4F0", Offset = "0x31AC0F0", VA = "0x1831AD4F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x31AD590", Offset = "0x31AC190", VA = "0x1831AD590", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x31AD3A0", Offset = "0x31ABFA0", VA = "0x1831AD3A0")]
		private NativeArray<Entity> NIMEHHFBKAA(int GGKDNLHEHMD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x31AD290", Offset = "0x31ABE90", VA = "0x1831AD290")]
		private void FJHKKMDFDPA(NativeArray<Entity> FOMLJAOCNJN, NativeArray<Entity> OOMAPPLLDPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[GKALNADHNEP(DAHLALKJFLL.Scope)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	internal class HideRemotePivotsNotInScope : IKDACLPDLNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery CPALPDNNICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery HBDLIAHGKKP;

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x35D9E80", Offset = "0x35D8A80", VA = "0x1835D9E80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x35D9F70", Offset = "0x35D8B70", VA = "0x1835D9F70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal static class MELDKEELPLJ
{
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public const string LJNNOIFLIEE = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6F00", Offset = "0x3DD5B00", VA = "0x183DD6F00")]
	public static NativeArray<T> CKOOMMCIDHH<T>(NativeArray<Entity> EADNCMDNEKI, EntityManager JOKFOKELNGA) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x35E8AB0", Offset = "0x35E76B0", VA = "0x1835E8AB0")]
	public static void JPJJCNHBOFD(EntityQuery GJLGONPKKFL, EntityManager JOKFOKELNGA, BKJKHIFBPPC MKDFNPEFILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x35E8850", Offset = "0x35E7450", VA = "0x1835E8850")]
	public static void ANOOMKGJJFG(NativeArray<Entity> FOMLJAOCNJN, BKJKHIFBPPC MKDFNPEFILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x35E8980", Offset = "0x35E7580", VA = "0x1835E8980")]
	public static void EMOJALBLEED(NativeArray<Entity> FOMLJAOCNJN, BKJKHIFBPPC MKDFNPEFILM)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.Scope)]
	internal class UpdateContainerPivotOnExitScopeSystem : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private EntityQuery GJLGONPKKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private TransformService OBDKJOBOIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private ObjectLifecycleService LPHFEOKHKGH;

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x3346DD0", Offset = "0x33459D0", VA = "0x183346DD0", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x3347980", Offset = "0x3346580", VA = "0x183347980", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x3347A20", Offset = "0x3346620", VA = "0x183347A20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x3346130", Offset = "0x3344D30", VA = "0x183346130")]
		private void EEJPMCKHEHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x3346020", Offset = "0x3344C20", VA = "0x183346020")]
		private void EBIFIIIHAOJ(NativeArray<Entity> FOMLJAOCNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x3346E60", Offset = "0x3345A60", VA = "0x183346E60")]
		private void ILLGFPNADJA(NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x3347730", Offset = "0x3346330", VA = "0x183347730")]
		private void KBMHHGPEKNL(NativeArray<Entity> OOMAPPLLDPC, NativeArray<RigidTransform> CMNLMCKACNA, NativeArray<RigidTransform> AGBPCPACBMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x3346940", Offset = "0x3345540", VA = "0x183346940")]
		private void ENICAIFOKHD(NativeArray<RigidTransform> AGBPCPACBMC, NativeArray<Entity> OOMAPPLLDPC, NativeList<Entity> FBJIKDGDDPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[GKALNADHNEP(DAHLALKJFLL.Scope)]
	internal class PostGameplayOnScopeChange : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery OIOMBDJFFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private EntityQuery PKHLLMOGEKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x309ED40", Offset = "0x309D940", VA = "0x18309ED40", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x309EE20", Offset = "0x309DA20", VA = "0x18309EE20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x309EF70", Offset = "0x309DB70", VA = "0x18309EF70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x309EDB0", Offset = "0x309D9B0", VA = "0x18309EDB0")]
		private void HAPPPJJBLCF(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[GKALNADHNEP(DAHLALKJFLL.Scope)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	internal class PreventDisembodiedScopesSystem : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery OCGBKFEBPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityHierarchyParents IGDNBGHNGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private JOIOCJOMOCG OKPEPNEHKJN;

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x30A0600", Offset = "0x309F200", VA = "0x1830A0600", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x30A0690", Offset = "0x309F290", VA = "0x1830A0690", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x30A0730", Offset = "0x309F330", VA = "0x1830A0730", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x30A0470", Offset = "0x309F070", VA = "0x1830A0470")]
		private void FBLIGPLMNKO(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.Scope)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<GIFHAGCLFGE>
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x3331C80", Offset = "0x3330880", VA = "0x183331C80", Slot = "14")]
		protected override void BDAIFNFBDDP(NativeArray<Entity> EADNCMDNEKI, NativeArray<Entity> DNJCNCMHKDP, NativeArray<Entity> DKBBJDPENCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x3331DD0", Offset = "0x33309D0", VA = "0x183331DD0")]
		[BurstCompile]
		private static void BDAIFNFBDDP(NativeArray<Entity> EADNCMDNEKI, NativeArray<Entity> DKBBJDPENCG, ComponentDataFromEntity<global::FMCMCGBHDOO> BMGCCJMACGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x3331EE0", Offset = "0x3330AE0", VA = "0x183331EE0")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x3331EA0", Offset = "0x3330AA0", VA = "0x183331EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[GKALNADHNEP(DAHLALKJFLL.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : IKDACLPDLNJ where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private EntityQuery AEIEJHBIOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery PFONHKDEGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery LJBCNAOKHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private EntityQuery KGKAMHIAHMK;

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x3702220", Offset = "0x3700E20", VA = "0x183702220", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x3702420", Offset = "0x3701020", VA = "0x183702420", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x37023F0", Offset = "0x3700FF0", VA = "0x1837023F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x3700B90", Offset = "0x36FF790", VA = "0x183700B90")]
		private void APFGPGONMGI(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x3700FD0", Offset = "0x36FFBD0", VA = "0x183700FD0")]
		private void BFKJLMPFJHF(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x3701C00", Offset = "0x3700800", VA = "0x183701C00")]
		private void IHLGJNFPAOK(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void BDAIFNFBDDP(NativeArray<Entity> EADNCMDNEKI, NativeArray<Entity> DNJCNCMHKDP, NativeArray<Entity> DKBBJDPENCG);

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2F9FE40", Offset = "0x2F9EA40", VA = "0x182F9FE40")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2F9FC90", Offset = "0x2F9E890", VA = "0x182F9FC90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public sealed class BHIBHGDIEAC : IKDACLPDLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private List<(EntityQuery, ComponentType)> ACKCFCFAEJP;

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x319D130", Offset = "0x319BD30", VA = "0x18319D130", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x319D330", Offset = "0x319BF30", VA = "0x18319D330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x319D480", Offset = "0x319C080", VA = "0x18319D480")]
	public BHIBHGDIEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct MCMPBJHIJFM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public int KLCIKJBGNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public int LKNCJMEJAON;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0x1481A90", Offset = "0x1480690", VA = "0x181481A90")]
	public static Entity GGDPAIJEDCE(MCMPBJHIJFM GAGLKGONONJ)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x1481A90", Offset = "0x1480690", VA = "0x181481A90")]
	public static MCMPBJHIJFM GGDPAIJEDCE(Entity BODOHICDFAL)
	{
		return default(MCMPBJHIJFM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct EHHDAHPOJPC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public struct DPHOJDFKMFJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public readonly ComponentType FDMNMHNCFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public readonly NativeList<int> MALHNKJOHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public readonly NativeList<int> HNLKMINBLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public readonly NativeArray<Entity> EADNCMDNEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public readonly NativeArray<Entity> GEJLGGJOLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public readonly NativeArray<byte> BMHMPPDEFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly NativeArray<byte> CEKFHLPOBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly int FAFDDEJCIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public readonly int HDCBDPNOBLC;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool LBOBGEGDFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x31B1B40", Offset = "0x31B0740", VA = "0x1831B1B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x31B1BC0", Offset = "0x31B07C0", VA = "0x1831B1BC0")]
	public DPHOJDFKMFJ(ComponentType FDMNMHNCFEK, NativeList<int> MALHNKJOHLB, NativeList<int> HNLKMINBLKK, NativeArray<Entity> EADNCMDNEKI, NativeArray<Entity> GEJLGGJOLLE, NativeArray<byte> BMHMPPDEFNN, NativeArray<byte> CEKFHLPOBFL, int FAFDDEJCIAF, int HDCBDPNOBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x31B1890", Offset = "0x31B0490", VA = "0x1831B1890")]
	private ODIFAJLFLNC AAAIIAEFCNJ(NativeArray<byte> NMDKCEHJACP, int KLEGICPDLIF)
	{
		return default(ODIFAJLFLNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	private T AAAIIAEFCNJ<T>(NativeArray<byte> NMDKCEHJACP, int KLEGICPDLIF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x31B1AA0", Offset = "0x31B06A0", VA = "0x1831B1AA0")]
	public ODIFAJLFLNC FMBCGLDODLK(int KLEGICPDLIF)
	{
		return default(ODIFAJLFLNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	public T FMBCGLDODLK<T>(int KLEGICPDLIF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x31B1AF0", Offset = "0x31B06F0", VA = "0x1831B1AF0")]
	public ODIFAJLFLNC GGPKMIHMFDO(int KLEGICPDLIF)
	{
		return default(ODIFAJLFLNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	public T GGPKMIHMFDO<T>(int KLEGICPDLIF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x31B19C0", Offset = "0x31B05C0", VA = "0x1831B19C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public readonly struct OGKBIEFBAJI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public readonly EntityQuery GJLGONPKKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public readonly NativeArray<DPFJLGGHGIE> MBLNNIKAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public readonly ComponentType FDMNMHNCFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public readonly int FAFDDEJCIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public readonly int HDCBDPNOBLC;

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x3089450", Offset = "0x3088050", VA = "0x183089450")]
	public OGKBIEFBAJI(ComponentType FDMNMHNCFEK, int FAFDDEJCIAF, int HDCBDPNOBLC, EntityQuery GJLGONPKKFL, NativeArray<DPFJLGGHGIE> MBLNNIKAAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x3089400", Offset = "0x3088000", VA = "0x183089400", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct AJILBIKFGIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public int KLEGICPDLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public int LCLBEMMLBCM;

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x702C80", Offset = "0x701880", VA = "0x180702C80")]
	public AJILBIKFGIK(int KLEGICPDLIF, int LCLBEMMLBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct DPFJLGGHGIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly int IHKOJLKELAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly int PJGFFECCBBF;

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x702C80", Offset = "0x701880", VA = "0x180702C80")]
	public DPFJLGGHGIE(int IHKOJLKELAD, int PJGFFECCBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public struct DBLNAIGHAJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private readonly FOCFMDNOICJ BEAOEMMHBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private readonly int FAFDDEJCIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private unsafe readonly byte* BMHMPPDEFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private unsafe readonly byte* CEKFHLPOBFL;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool BPOKJGMAKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x31AFA60", Offset = "0x31AE660", VA = "0x1831AFA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public FOCFMDNOICJ EHMEPDKHBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CB0", Offset = "0x6D88B0", VA = "0x1806D9CB0")]
		get
		{
			return default(FOCFMDNOICJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x31AFA70", Offset = "0x31AE670", VA = "0x1831AFA70")]
	public ODIFAJLFLNC LMHMIKCBMIM(Type JMPEGNOKOOB)
	{
		return default(ODIFAJLFLNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x31AF970", Offset = "0x31AE570", VA = "0x1831AF970")]
	public ODIFAJLFLNC CFKPNIMFABI(Type JMPEGNOKOOB)
	{
		return default(ODIFAJLFLNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x2553940", Offset = "0x2552540", VA = "0x182553940")]
	public T LMHMIKCBMIM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x2553920", Offset = "0x2552520", VA = "0x182553920")]
	public T CFKPNIMFABI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x31AFB60", Offset = "0x31AE760", VA = "0x1831AFB60")]
	public unsafe DBLNAIGHAJO(FOCFMDNOICJ BEAOEMMHBNI, int PJGFFECCBBF, byte* BMHMPPDEFNN, byte* CEKFHLPOBFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class JHEJCNNDOGF : GEPHOAAGCCO, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private PropertyDiffStateService GBMKHHIBDOI;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected abstract JEGPFMALOAP FIKJKCNFGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x35E06A0", Offset = "0x35DF2A0", VA = "0x1835E06A0", Slot = "17")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x35E06F0", Offset = "0x35DF2F0", VA = "0x1835E06F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x35E0780", Offset = "0x35DF380", VA = "0x1835E0780", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	protected JHEJCNNDOGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public static class MBDDGOAHJHL
{
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] KKEKABMDFDB;
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[DefaultMember("Item")]
internal class CLLGJDGBHAC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly FCNKBCOKGMK OIFMFCIPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly Dictionary<ComponentType, OGKBIEFBAJI> IIKEHPJNMBH;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public OGKBIEFBAJI KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x31A28A0", Offset = "0x31A14A0", VA = "0x1831A28A0")]
		get
		{
			return default(OGKBIEFBAJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x31A21D0", Offset = "0x31A0DD0", VA = "0x1831A21D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x31A2CF0", Offset = "0x31A18F0", VA = "0x1831A2CF0")]
	public CLLGJDGBHAC(HOONHJLELFO GMKNLKMJIPP, FCNKBCOKGMK OIFMFCIPKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x31A2C80", Offset = "0x31A1880", VA = "0x1831A2C80")]
	public bool PDCGIMKGOOO(ComponentType FDMNMHNCFEK, out OGKBIEFBAJI PENAEKEAGKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x31A23B0", Offset = "0x31A0FB0", VA = "0x1831A23B0")]
	public Dictionary<ComponentType, OGKBIEFBAJI>.Enumerator EEAMIAJAFGO()
	{
		return default(Dictionary<ComponentType, OGKBIEFBAJI>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x31A2220", Offset = "0x31A0E20", VA = "0x1831A2220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x31A2440", Offset = "0x31A1040", VA = "0x1831A2440")]
	private void JEGELIJKKPE(IEnumerable<ELGFJHKNNCH> MBIJEENFFFA, EntityManager JOKFOKELNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x31A2BD0", Offset = "0x31A17D0", VA = "0x1831A2BD0")]
	private static int ODGKJFICIFP(ELGFJHKNNCH GNCEPKOENKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x31A2930", Offset = "0x31A1530", VA = "0x1831A2930")]
	private static NativeArray<DPFJLGGHGIE> MIBANDKAIMJ(ELGFJHKNNCH GNCEPKOENKG, Allocator JMMNDPMBMFC = Allocator.Persistent)
	{
		return default(NativeArray<DPFJLGGHGIE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal interface PLNGMBEJLHF
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool LBOBGEGDFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	World MFHAIABCKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KNEFHNFJIJB(out NativeArray<int> DLNFNCOODDK, Allocator JMMNDPMBMFC);

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JCHPDCGPMBH(ComponentType FDMNMHNCFEK, out DPHOJDFKMFJ IAFDEMBPEME, out OGKBIEFBAJI LONACBPNEFB);

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JCHPDCGPMBH(ComponentType FDMNMHNCFEK, out DPHOJDFKMFJ IAFDEMBPEME);

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DPHOJDFKMFJ BJBDAFHBEHJ(ComponentType FDMNMHNCFEK);

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BMBNENMHEAI LGEIGHLFBBE();

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HJGDBOAKAFJ(JobHandle HJBACIKDILJ);
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
internal interface INPGCFJJNFC
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	World MFHAIABCKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	CLLGJDGBHAC FNFAKGKGAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	EFMCGLDCNFF HHNLMGPAAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	NativeMultiHashMap<Entity, DBLNAIGHAJO> AIBDDAKMBBK
	{
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	JobHandle APAINILAFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OEKJIJPBJKA();

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GGNFLDPHLOD();

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KHDPAIFINIF(ComponentType FDMNMHNCFEK, in DPHOJDFKMFJ CEEIDPKELAB);

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DPGJNMGDJNH(KLHKIJHKJFB IBFKFNLEDKN, out Entity HLABNIGHLFE);
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct BMBNENMHEAI
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public struct EAHICBNJOOI : IEnumerator<DBLNAIGHAJO>, IEnumerator, IDisposable, IEnumerable<DBLNAIGHAJO>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly NativeMultiHashMap<Entity, DBLNAIGHAJO> FDJAPCCPCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly Entity BODOHICDFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private NativeMultiHashMapIterator<Entity> DLKJHCBLOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private DBLNAIGHAJO CEKFHLPOBFL;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public DBLNAIGHAJO LEMCHMBGFHM
		{
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0x7B7C20", Offset = "0x7B6820", VA = "0x1807B7C20", Slot = "4")]
			get
			{
				return default(DBLNAIGHAJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0x332C5A0", Offset = "0x332B1A0", VA = "0x18332C5A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x332C5F0", Offset = "0x332B1F0", VA = "0x18332C5F0")]
		internal EAHICBNJOOI(NativeMultiHashMap<Entity, DBLNAIGHAJO> FDJAPCCPCPN, Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x332C390", Offset = "0x332AF90", VA = "0x18332C390", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x332C360", Offset = "0x332AF60", VA = "0x18332C360")]
		public EAHICBNJOOI EEAMIAJAFGO()
		{
			return default(EAHICBNJOOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x332C460", Offset = "0x332B060", VA = "0x18332C460", Slot = "9")]
		private IEnumerator<DBLNAIGHAJO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x332C500", Offset = "0x332B100", VA = "0x18332C500", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly INPGCFJJNFC DBOAJCAFPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly JobHandle EGCKAHDPKAE;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public int NEJCOCDONKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x319D6E0", Offset = "0x319C2E0", VA = "0x18319D6E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool LLDLPKJFACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x319D8F0", Offset = "0x319C4F0", VA = "0x18319D8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2702E90", Offset = "0x2701A90", VA = "0x182702E90")]
	public BMBNENMHEAI(INPGCFJJNFC DBOAJCAFPEK, JobHandle EGCKAHDPKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x319D9D0", Offset = "0x319C5D0", VA = "0x18319D9D0")]
	public bool HNEFKIAOFAI(Allocator JMMNDPMBMFC, out NativeKeyValueArrays<Entity, DBLNAIGHAJO> HJIMPKKMPML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x319D570", Offset = "0x319C170", VA = "0x18319D570")]
	public bool CNAMOBPFLKC(Allocator JMMNDPMBMFC, out (NativeArray<Entity> entities, int uniqueCount) HJIMPKKMPML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x319D7D0", Offset = "0x319C3D0", VA = "0x18319D7D0")]
	public EAHICBNJOOI DLCIEPGBFON(Entity BODOHICDFAL)
	{
		return default(EAHICBNJOOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[DefaultMember("Item")]
internal class EFMCGLDCNFF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly FCNKBCOKGMK OIFMFCIPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private readonly List<OGKBIEFBAJI> FOLHIKGIGJA;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public OGKBIEFBAJI KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x31B4600", Offset = "0x31B3200", VA = "0x1831B4600")]
		get
		{
			return default(OGKBIEFBAJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x31B4090", Offset = "0x31B2C90", VA = "0x1831B4090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x31B4690", Offset = "0x31B3290", VA = "0x1831B4690")]
	public EFMCGLDCNFF(CLLGJDGBHAC IIKEHPJNMBH, HOONHJLELFO GMKNLKMJIPP, FCNKBCOKGMK OIFMFCIPKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x31B4250", Offset = "0x31B2E50", VA = "0x1831B4250")]
	public List<OGKBIEFBAJI>.Enumerator EEAMIAJAFGO()
	{
		return default(List<OGKBIEFBAJI>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x31B40D0", Offset = "0x31B2CD0", VA = "0x1831B40D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x31B42D0", Offset = "0x31B2ED0", VA = "0x1831B42D0")]
	private void JEGELIJKKPE(CLLGJDGBHAC IIKEHPJNMBH, EntityManager JOKFOKELNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class CKIHFGJDFJO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly FCNKBCOKGMK OIFMFCIPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly ObjectInstantiationService BCDJFKMHLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly global::PEENCLMLKDL<ELGFJHKNNCH> FAFPAKEOAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly World FAAHAAFMLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly EntityManager JOKFOKELNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private NativeHashMap<int, Entity> PDHHBLJFHEJ;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x31A1CB0", Offset = "0x31A08B0", VA = "0x1831A1CB0")]
	public CKIHFGJDFJO(ObjectInstantiationService BCDJFKMHLLG, HOONHJLELFO GMKNLKMJIPP, FCNKBCOKGMK OIFMFCIPKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x31A1210", Offset = "0x319FE10", VA = "0x1831A1210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x31A1C50", Offset = "0x31A0850", VA = "0x1831A1C50")]
	public bool MMPCGCNJKNA(KLHKIJHKJFB IBFKFNLEDKN, out Entity HLABNIGHLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x31A0680", Offset = "0x319F280", VA = "0x1831A0680")]
	private void CDDOPHFKEJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x31A0CE0", Offset = "0x319F8E0", VA = "0x1831A0CE0")]
	private EntityArchetype CFPCMCFDOHP(EntityArchetype MMMMDNBKKFE)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x31A12E0", Offset = "0x319FEE0", VA = "0x1831A12E0")]
	public static void FFHEICJJJHO(EntityManager LLOFGIFGEHE, EntityManager PJPJGDJABGC, NativeArray<Entity> EECJKEGNNBI, NativeArray<EntityArchetype> JBHLLFKAGCE, [Optional] NativeArray<Entity> MGHPHJNDJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x31A18C0", Offset = "0x31A04C0", VA = "0x1831A18C0")]
	[Conditional("DEBUG_BUILD")]
	private static void ILCDMFBLCCO(NativeArray<EntityArchetype> DHBCLLNNNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x31A0440", Offset = "0x319F040", VA = "0x1831A0440")]
	private static string BECKMGCJPJN(EntityArchetype JIDCFBAAHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x31A1B10", Offset = "0x31A0710", VA = "0x1831A1B10")]
	[CompilerGenerated]
	internal static void JNAOEHCLKFA(ref Span<ComponentType> GMMDLIHIIOK, ComponentType NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x31A1710", Offset = "0x31A0310", VA = "0x1831A1710")]
	[CompilerGenerated]
	internal static void GIIJICGDKEM(Span<ComponentType> NMDKCEHJACP, ref Span<ComponentType> GMMDLIHIIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x31A1A30", Offset = "0x31A0630", VA = "0x1831A1A30")]
	[CompilerGenerated]
	internal static void JGDCELMFEBP(Span<ComponentType> NMDKCEHJACP, ref Span<ComponentType> GMMDLIHIIOK, ComponentType PAACCECGPOA)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.PropertyChanges)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld EOCDBLFOBPI;

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x319BA20", Offset = "0x319A620", VA = "0x18319BA20", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x319BAE0", Offset = "0x319A6E0", VA = "0x18319BAE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[AlwaysUpdateSystem]
	[GKALNADHNEP(DAHLALKJFLL.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : IKDACLPDLNJ, BLCFKNFGJJJ, JGJNINBGNFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[BurstCompile]
		internal struct MFEFJIPEMPP : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			[ReadOnly]
			public NativeArray<byte> ONIFNBCCGGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			[ReadOnly]
			public NativeArray<byte> GLCMGLDJDBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			[ReadOnly]
			public NativeArray<DPFJLGGHGIE> GJDECGOJDFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			[WriteOnly]
			public NativeList<AJILBIKFGIK>.ParallelWriter HNILPEKDOGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public int NAANNDGJPJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public int OCNAHEEJEIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public ProfilerMarker NKPGFEJKNAE;

			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x332F7F0", Offset = "0x332E3F0", VA = "0x18332F7F0", Slot = "4")]
			public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x332F930", Offset = "0x332E530", VA = "0x18332F930")]
			private unsafe int JEEKOPCHGBM(byte* AGKMGMBFDHA, byte* CNBPNBOALAL)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000152")]
		[BurstCompile]
		internal struct KGKMNMBAMPK : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			[WriteOnly]
			public NativeList<int> MALHNKJOHLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			[WriteOnly]
			public NativeList<int> BKBBNPKFLFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			[ReadOnly]
			public NativeList<AJILBIKFGIK> FIELAFDPAJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public ProfilerMarker NKPGFEJKNAE;

			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x332DBD0", Offset = "0x332C7D0", VA = "0x18332DBD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000153")]
		[BurstCompile]
		internal struct BPKNPIOBLEN : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			[WriteOnly]
			public NativeArray<byte> PBKCKHDEEEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			[ReadOnly]
			public NativeArray<Entity> EADNCMDNEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			[ReadOnly]
			public ACOGKCNIFAF PKKBBEGLBAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public int FAFDDEJCIAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public ProfilerMarker NKPGFEJKNAE;

			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x332B3E0", Offset = "0x3329FE0", VA = "0x18332B3E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct KCLPIEDLICF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, DBLNAIGHAJO> NFPKEGIKMEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			[ReadOnly]
			public NativeArray<byte> BMHMPPDEFNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			[ReadOnly]
			public NativeArray<byte> CEKFHLPOBFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<Entity> EADNCMDNEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<DPFJLGGHGIE> NOHHGCLILCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeList<int> HNLKMINBLKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[ReadOnly]
			public NativeList<int> MALHNKJOHLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int BNLMICDGDGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int HDCBDPNOBLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker NKPGFEJKNAE;

			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x332D950", Offset = "0x332C550", VA = "0x18332D950", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly ProfilerMarker LILNOEECOHM;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private static readonly ProfilerMarker GAIMOKPJGDI;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private static readonly ProfilerMarker KNFHPIELODM;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private static readonly ProfilerMarker PEANOGANFIJ;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly ProfilerMarker AFMADAAAEEJ;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly ProfilerMarker PFEKBLFLKEM;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly ProfilerMarker FEFDJNCONED;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly ProfilerMarker OLEKEJPMGPM;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private static readonly ProfilerMarker CNPKEEHCCKI;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private static readonly ProfilerMarker BAEOHIEOMCO;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private static readonly ProfilerMarker BDGLEJDEFCN;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private static readonly ProfilerMarker NJKLKLCJHEG;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private static readonly ProfilerMarker IJNDIIOPCJE;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private static readonly ProfilerMarker FOIANFFKLJM;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private static readonly ProfilerMarker CGCGCDCBJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private PropertyDiffStateService GBMKHHIBDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private EntityQuery LFNDIANHBBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private EntityQuery CDHMNMMIAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private EntityQuery ENPKNDNEDOB;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		internal World MFHAIABCKDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x31A53C0", Offset = "0x31A3FC0", VA = "0x1831A53C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private INPGCFJJNFC MCIKGPOOFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x31A7BF0", Offset = "0x31A67F0", VA = "0x1831A7BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x31A5480", Offset = "0x31A4080", VA = "0x1831A5480", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "15")]
		public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x31A7CC0", Offset = "0x31A68C0", VA = "0x1831A7CC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x31A7E80", Offset = "0x31A6A80", VA = "0x1831A7E80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x31A7E10", Offset = "0x31A6A10", VA = "0x1831A7E10", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x31A7FC0", Offset = "0x31A6BC0", VA = "0x1831A7FC0")]
		private void PFJPMGFEKGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x31A5A00", Offset = "0x31A4600", VA = "0x1831A5A00")]
		internal void ILJIGMJIEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x31A5A20", Offset = "0x31A4620", VA = "0x1831A5A20")]
		private void ILJIGMJIEKC(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x31A6C00", Offset = "0x31A5800", VA = "0x1831A6C00")]
		private void KIAIMMKFANI(NativeArray<Entity> EECJKEGNNBI, NativeArray<RRObjectPrefabData> HFECDFGOING, ref NativeArray<Entity> GLMIOHGDIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x31A54D0", Offset = "0x31A40D0", VA = "0x1831A54D0")]
		internal void HAPAPPJMAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x31A54F0", Offset = "0x31A40F0", VA = "0x1831A54F0")]
		private void HAPAPPJMAFI(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x31A6460", Offset = "0x31A5060", VA = "0x1831A6460")]
		internal void JIIPDBGOACF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x31A5060", Offset = "0x31A3C60", VA = "0x1831A5060")]
		private void BANMDHICNNJ(INPGCFJJNFC DBOAJCAFPEK, OGKBIEFBAJI LONACBPNEFB, bool FLELMCLMEHB, ref JobHandle IBJGBAEANNP, ref JobHandle FFICOJADPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x31A6E40", Offset = "0x31A5A40", VA = "0x1831A6E40")]
		internal bool LKNFLHPHBIK(in OGKBIEFBAJI CNBPNBOALAL, out JobHandle LBLAJOOMAIC, out DPHOJDFKMFJ KKKDFMJCDKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x31A6E70", Offset = "0x31A5A70", VA = "0x1831A6E70")]
		private bool LKNFLHPHBIK(in OGKBIEFBAJI CNBPNBOALAL, bool FLELMCLMEHB, out JobHandle LBLAJOOMAIC, out DPHOJDFKMFJ KKKDFMJCDKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x31A7A30", Offset = "0x31A6630", VA = "0x1831A7A30")]
		internal (NativeList<int>, NativeList<int>) NDNDALHDPMG(NativeList<AJILBIKFGIK> FIELAFDPAJH, int KOHJKAOCDIM, JobHandle PJNPMKLPJLL, out JobHandle HJBACIKDILJ, Allocator JMMNDPMBMFC = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x31A7C10", Offset = "0x31A6810", VA = "0x1831A7C10")]
		internal static NativeArray<Entity> OKAJFBIKNJK(EntityQuery GJLGONPKKFL, out JobHandle ECAEKHPCOPM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x31A5340", Offset = "0x31A3F40", VA = "0x1831A5340")]
		internal static NativeArray<byte> BFLOBDCINKO(int FCLGIGIIKEH, out JobHandle KOCGABKMFBK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x31A58F0", Offset = "0x31A44F0", VA = "0x1831A58F0")]
		internal static NativeArray<byte> HJBFGDGJKII(EntityQuery GJLGONPKKFL, int FKPCJKABBEA, out JobHandle KOCGABKMFBK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x31A7930", Offset = "0x31A6530", VA = "0x1831A7930")]
		internal static NativeArray<Entity> MOMAFJOFJII(EntityQuery GJLGONPKKFL, out JobHandle LCFDAOCNPNP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x31A61F0", Offset = "0x31A4DF0", VA = "0x1831A61F0")]
		internal NativeArray<byte> JAOLPFKNHME(NativeArray<Entity> EADNCMDNEKI, OGKBIEFBAJI LONACBPNEFB, JobHandle PJNPMKLPJLL, out JobHandle HJBACIKDILJ, Allocator JMMNDPMBMFC = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x31A77A0", Offset = "0x31A63A0", VA = "0x1831A77A0")]
		internal JobHandle LOLAKLALENK(in DPHOJDFKMFJ GAGLKGONONJ, in OGKBIEFBAJI LONACBPNEFB, NativeMultiHashMap<Entity, DBLNAIGHAJO> NFPKEGIKMEP, JobHandle PJNPMKLPJLL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x261C1E0", Offset = "0x261ADE0", VA = "0x18261C1E0")]
		private JobHandle EEKAOPHEOKK(JobHandle HGJIOGKHLIK, JobHandle EGLNMGDKNPO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x261C1E0", Offset = "0x261ADE0", VA = "0x18261C1E0")]
		private JobHandle EEKAOPHEOKK(JobHandle HGJIOGKHLIK, JobHandle EGLNMGDKNPO, JobHandle FEFCFPFLNIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[GKALNADHNEP(DAHLALKJFLL.RenderEffects)]
	internal class PropagateHoverRootTag : DAHJDDBJINO
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		public struct DKGMNDBPEFK : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		protected override ComponentType FJCHDPGIIMO
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x30A1010", Offset = "0x309FC10", VA = "0x1830A1010", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType PFLHOHIOIDC
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x30A1040", Offset = "0x309FC40", VA = "0x1830A1040", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override ComponentType DBHLLFFIHFA
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x30A1070", Offset = "0x309FC70", VA = "0x1830A1070", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x30A10A0", Offset = "0x309FCA0", VA = "0x1830A10A0")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[GKALNADHNEP(DAHLALKJFLL.RenderEffects)]
	internal class PropagateSelectionRootTag : DAHJDDBJINO
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		public struct CCJPFLBDJNB : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType FJCHDPGIIMO
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x30A10B0", Offset = "0x309FCB0", VA = "0x1830A10B0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType PFLHOHIOIDC
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x30A10E0", Offset = "0x309FCE0", VA = "0x1830A10E0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType DBHLLFFIHFA
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x30A1110", Offset = "0x309FD10", VA = "0x1830A1110", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x30A10A0", Offset = "0x309FCA0", VA = "0x1830A10A0")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[FJJLKPGAMCM]
public class JLGJFICGOAI : PDHHEADABLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private EntityQuery GJLGONPKKFL;

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x35E1A50", Offset = "0x35E0650", VA = "0x1835E1A50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x35E1AE0", Offset = "0x35E06E0", VA = "0x1835E1AE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public JLGJFICGOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[FJJLKPGAMCM]
public class IMMKBKONENH : PDHHEADABLB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct PACMCDGGDAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public PACMCDGGDAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct MCLIAAPGBCF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		private struct IAAKPIMGEOE
		{
			[Cpp2IlInjected.Token(Token = "0x200015E")]
			[NoAlias]
			public struct BJAEPEBEOLL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000450")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ILAODBKEPEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000451")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime NFGENPKAIFB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FFFAHLBALFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> ENJHDLBJLHA;

			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x43AAFA0", Offset = "0x43A9BA0", VA = "0x1843AAFA0")]
			public void GDFFALHKOBH(IMMKBKONENH IEKCOPFEHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x43AAF20", Offset = "0x43A9B20", VA = "0x1843AAF20")]
			public BJAEPEBEOLL DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
			{
				return default(BJAEPEBEOLL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public EntityManager JOKFOKELNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public NativeList<Entity> MEPFMPPEFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private IAAKPIMGEOE KHJPHIECPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IAAKPIMGEOE.BJAEPEBEOLL* MKHNGJINIJK;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PHJMPFOKBGL;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PDEOFBGFNON;

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x43AD6A0", Offset = "0x43AC2A0", VA = "0x1843AD6A0")]
		internal void HECHOFEKDHF(Entity BODOHICDFAL, SplinePointParentData LGCBMACDBHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x43AD710", Offset = "0x43AC310", VA = "0x1843AD710", Slot = "5")]
		public void ReadFromDisplayClass(ref PACMCDGGDAH HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x43AD720", Offset = "0x43AC320", VA = "0x1843AD720", Slot = "6")]
		public void WriteToDisplayClass(ref PACMCDGGDAH HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x43AD450", Offset = "0x43AC050", VA = "0x1843AD450", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x43AD4F0", Offset = "0x43AC0F0", VA = "0x1843AD4F0")]
		public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, [NoAlias] ref IAAKPIMGEOE.BJAEPEBEOLL IKHKHMKOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x43AD5A0", Offset = "0x43AC1A0", VA = "0x1843AD5A0")]
		public void GDFFALHKOBH(IMMKBKONENH IEKCOPFEHBF, ref PACMCDGGDAH HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x43AD630", Offset = "0x43AC230", VA = "0x1843AD630")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void GGIFGIINNMA(ArchetypeChunkIterator* PCLDPFNHHHB, void* AKDGMOCNLFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery JJDALPIPBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private ProfilerMarker CIHBCDBGBNE;

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x35DFD20", Offset = "0x35DE920", VA = "0x1835DFD20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public IMMKBKONENH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x35DFAF0", Offset = "0x35DE6F0", VA = "0x1835DFAF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x35DF990", Offset = "0x35DE590", VA = "0x1835DF990")]
	public static EntityQuery MMHJIAMDNIK(ComponentSystemBase IEKCOPFEHBF)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[FJJLKPGAMCM]
public class ANBEKCKDDHJ : PDHHEADABLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private EntityQuery LFNHBKHEJCL;

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x319A860", Offset = "0x3199460", VA = "0x18319A860", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x319A8F0", Offset = "0x31994F0", VA = "0x18319A8F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public ANBEKCKDDHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[UpdateAfter(typeof(JLGJFICGOAI))]
public class MFMNDOBCGFP : IKDACLPDLNJ
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x35E8BF0", Offset = "0x35E77F0", VA = "0x1835E8BF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public MFMNDOBCGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public class LLFLLLHNOLM : PDHHEADABLB, BLCFKNFGJJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct DCIJLIMGMBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public NativeHashMap<KFMKFJINGPH, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public DCIJLIMGMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MCAMLBHLKNM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct HNEAPPFLGOF
		{
			[Cpp2IlInjected.Token(Token = "0x2000165")]
			public struct JILNMHGPEHI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400045D")]
				public LambdaParameterValueProvider_Entity.Runtime ILAODBKEPEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400045E")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime KOLLMBGLEOO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FFFAHLBALFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> MENOPIDBIFB;

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x43AAC30", Offset = "0x43A9830", VA = "0x1843AAC30")]
			public void GDFFALHKOBH(LLFLLLHNOLM IEKCOPFEHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x43AABB0", Offset = "0x43A97B0", VA = "0x1843AABB0")]
			public JILNMHGPEHI DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
			{
				return default(JILNMHGPEHI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public NativeHashMap<KFMKFJINGPH, Entity> FDJAPCCPCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private HNEAPPFLGOF KHJPHIECPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HNEAPPFLGOF.JILNMHGPEHI* MKHNGJINIJK;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PHJMPFOKBGL;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x43AD130", Offset = "0x43ABD30", VA = "0x1843AD130")]
		internal void HECHOFEKDHF(Entity BODOHICDFAL, ObjectNetworkIdComponentData MCCMABIINID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0xDB5E00", Offset = "0xDB4A00", VA = "0x180DB5E00", Slot = "5")]
		public void ReadFromDisplayClass(ref DCIJLIMGMBL HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x2E043E0", Offset = "0x2E02FE0", VA = "0x182E043E0", Slot = "6")]
		public void WriteToDisplayClass(ref DCIJLIMGMBL HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x43ACEE0", Offset = "0x43ABAE0", VA = "0x1843ACEE0", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x43ACF80", Offset = "0x43ABB80", VA = "0x1843ACF80")]
		public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, ref HNEAPPFLGOF.JILNMHGPEHI IKHKHMKOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x43AD030", Offset = "0x43ABC30", VA = "0x1843AD030")]
		public void GDFFALHKOBH(LLFLLLHNOLM IEKCOPFEHBF, ref DCIJLIMGMBL HNPKAGHHMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x43AD0C0", Offset = "0x43ABCC0", VA = "0x1843AD0C0")]
		public unsafe static void GGIFGIINNMA(ArchetypeChunkIterator* PCLDPFNHHHB, void* AKDGMOCNLFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private ObjectNetworkToLocalMapService GMAKJKHGELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private EntityQuery JJDALPIPBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private ProfilerMarker CIHBCDBGBNE;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x35E73D0", Offset = "0x35E5FD0", VA = "0x1835E73D0", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x35E7790", Offset = "0x35E6390", VA = "0x1835E7790", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public LLFLLLHNOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x35E7590", Offset = "0x35E6190", VA = "0x1835E7590", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x35E7430", Offset = "0x35E6030", VA = "0x1835E7430")]
	public static EntityQuery MMHJIAMDNIK(ComponentSystemBase IEKCOPFEHBF)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public class MGNBOOMMFEE : PDHHEADABLB, BLCFKNFGJJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct DELBKBLBAHG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000168")]
		private struct BCOAOCGOELM
		{
			[Cpp2IlInjected.Token(Token = "0x2000169")]
			public struct HDBMOOCCJAO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000468")]
				public LambdaParameterValueProvider_Entity.Runtime ILAODBKEPEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000469")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime PNFGNKJICLM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FFFAHLBALFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> EHHHJKHKOAJ;

			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x43A6150", Offset = "0x43A4D50", VA = "0x1843A6150")]
			public void GDFFALHKOBH(MGNBOOMMFEE IEKCOPFEHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x43A60D0", Offset = "0x43A4CD0", VA = "0x1843A60D0")]
			public HDBMOOCCJAO DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
			{
				return default(HDBMOOCCJAO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public MGNBOOMMFEE OOGLCPPFFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private BCOAOCGOELM KHJPHIECPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BCOAOCGOELM.HDBMOOCCJAO* MKHNGJINIJK;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PHJMPFOKBGL;

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x43A80A0", Offset = "0x43A6CA0", VA = "0x1843A80A0")]
		public void HECHOFEKDHF(Entity BODOHICDFAL, ParentData JIHPAGKIFKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x43A7E60", Offset = "0x43A6A60", VA = "0x1843A7E60", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x43A7F00", Offset = "0x43A6B00", VA = "0x1843A7F00")]
		public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, ref BCOAOCGOELM.HDBMOOCCJAO IKHKHMKOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x43A7FB0", Offset = "0x43A6BB0", VA = "0x1843A7FB0")]
		public void GDFFALHKOBH(MGNBOOMMFEE IEKCOPFEHBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x43A8030", Offset = "0x43A6C30", VA = "0x1843A8030")]
		public unsafe static void GGIFGIINNMA(ArchetypeChunkIterator* PCLDPFNHHHB, void* AKDGMOCNLFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private EntityQuery JJDALPIPBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private ProfilerMarker CIHBCDBGBNE;

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x35E8D00", Offset = "0x35E7900", VA = "0x1835E8D00", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x35E92B0", Offset = "0x35E7EB0", VA = "0x1835E92B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public MGNBOOMMFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x35E8D60", Offset = "0x35E7960", VA = "0x1835E8D60")]
	[CompilerGenerated]
	private void LCEMLDAGIHH(Entity BODOHICDFAL, ParentData JIHPAGKIFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x35E90B0", Offset = "0x35E7CB0", VA = "0x1835E90B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x35E8F50", Offset = "0x35E7B50", VA = "0x1835E8F50")]
	public static EntityQuery MMHJIAMDNIK(ComponentSystemBase IEKCOPFEHBF)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public class PHKPKJDCEKD : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private int FHFLOHIINEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private EntityQuery GJLGONPKKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private ObjectPrefabs BCDJFKMHLLG;

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x3099640", Offset = "0x3098240", VA = "0x183099640", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x3099A30", Offset = "0x3098630", VA = "0x183099A30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x3099B10", Offset = "0x3098710", VA = "0x183099B10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x3099690", Offset = "0x3098290", VA = "0x183099690")]
	private void HAOBFFEEJHM(Entity BODOHICDFAL, KLHKIJHKJFB IBFKFNLEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public PHKPKJDCEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[UpdateBefore(typeof(PHKPKJDCEKD))]
	[GKALNADHNEP(DAHLALKJFLL.Serialization)]
	public class PostLoadAddSceneTagEntity : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private SceneService HHAEJHNBEEM;

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x309F080", Offset = "0x309DC80", VA = "0x18309F080", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x309F0D0", Offset = "0x309DCD0", VA = "0x18309F0D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[GKALNADHNEP(DAHLALKJFLL.Serialization)]
	[HHHAKBKHMPJ(EBEBOFNGILK.OMRoom)]
	public class PostLoadInitializeNetworkId : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		[CompilerGenerated]
		private struct LAMODOOHBAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public NativeHashMap<KFMKFJINGPH, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
			public LAMODOOHBAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct GOOHIHKBOAK : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200016F")]
			private struct BEECPJPBIGE
			{
				[Cpp2IlInjected.Token(Token = "0x2000170")]
				[NoAlias]
				public struct EOOHKMJGGJM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400047E")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ILAODBKEPEJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400047F")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime OKAMJEEFPKB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000480")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime KOLLMBGLEOO;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity FFFAHLBALFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_EntityInQueryIndex DEDCPDHMPCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047D")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> MENOPIDBIFB;

				[Cpp2IlInjected.Token(Token = "0x6000A19")]
				[Cpp2IlInjected.Address(RVA = "0x43A6320", Offset = "0x43A4F20", VA = "0x1843A6320")]
				public void GDFFALHKOBH(PostLoadInitializeNetworkId IEKCOPFEHBF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A1A")]
				[Cpp2IlInjected.Address(RVA = "0x43A6270", Offset = "0x43A4E70", VA = "0x1843A6270")]
				public EOOHKMJGGJM DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
				{
					return default(EOOHKMJGGJM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public NativeHashMap<KFMKFJINGPH, Entity> FDJAPCCPCPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private BEECPJPBIGE KHJPHIECPAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BEECPJPBIGE.EOOHKMJGGJM* MKHNGJINIJK;

			[Cpp2IlInjected.Token(Token = "0x4000479")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PHJMPFOKBGL;

			[Cpp2IlInjected.Token(Token = "0x400047A")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PDEOFBGFNON;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x43AA370", Offset = "0x43A8F70", VA = "0x1843AA370")]
			internal void HECHOFEKDHF(Entity BODOHICDFAL, int DJKIALDIELB, ref ObjectNetworkIdComponentData MCCMABIINID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xDB5E00", Offset = "0xDB4A00", VA = "0x180DB5E00", Slot = "5")]
			public void ReadFromDisplayClass(ref LAMODOOHBAO HNPKAGHHMHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x2E043E0", Offset = "0x2E02FE0", VA = "0x182E043E0", Slot = "6")]
			public void WriteToDisplayClass(ref LAMODOOHBAO HNPKAGHHMHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x43AA0A0", Offset = "0x43A8CA0", VA = "0x1843AA0A0", Slot = "4")]
			public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x43AA190", Offset = "0x43A8D90", VA = "0x1843AA190")]
			public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, [NoAlias] ref BEECPJPBIGE.EOOHKMJGGJM IKHKHMKOEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0x43AA260", Offset = "0x43A8E60", VA = "0x1843AA260")]
			public void GDFFALHKOBH(PostLoadInitializeNetworkId IEKCOPFEHBF, ref LAMODOOHBAO HNPKAGHHMHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x43AA300", Offset = "0x43A8F00", VA = "0x1843AA300")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void GGIFGIINNMA(ArchetypeChunkIterator* PCLDPFNHHHB, void* AKDGMOCNLFL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[NNMLOJPMNKB]
		private ObjectNetworkToLocalMapService GMAKJKHGELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[NNMLOJPMNKB]
		private SceneService LJMHKNOAABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private EntityQuery GJLGONPKKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private EntityQuery EGANJJINNCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private ProfilerMarker GBNNIHIIFGO;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x309F2E0", Offset = "0x309DEE0", VA = "0x18309F2E0", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x30A0000", Offset = "0x309EC00", VA = "0x1830A0000", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x309F750", Offset = "0x309E350", VA = "0x18309F750", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x309F750", Offset = "0x309E350", VA = "0x18309F750")]
		public void KHCIIHGHGBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x309F820", Offset = "0x309E420", VA = "0x18309F820")]
		private void MDGNBJPKFHH(NativeHashMap<KFMKFJINGPH, Entity> FDJAPCCPCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x309F350", Offset = "0x309DF50", VA = "0x18309F350")]
		private void HAPLINGJGDH(NativeHashMap<KFMKFJINGPH, Entity> FDJAPCCPCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x309FD70", Offset = "0x309E970", VA = "0x18309FD70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x309F5B0", Offset = "0x309E1B0", VA = "0x18309F5B0")]
		public static EntityQuery JJPCEJBOAJO(ComponentSystemBase IEKCOPFEHBF)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public class HCEKFEEBNOF : IKDACLPDLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private EntityQuery CCFGHFHFALF;

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x35D6AC0", Offset = "0x35D56C0", VA = "0x1835D6AC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x35D6B50", Offset = "0x35D5750", VA = "0x1835D6B50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public HCEKFEEBNOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public class IDLEFILGHNK : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private global::PEENCLMLKDL<NPOFMEGBCMP> KANKLFOHMDM;

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x35DE7E0", Offset = "0x35DD3E0", VA = "0x1835DE7E0", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x35DEC20", Offset = "0x35DD820", VA = "0x1835DEC20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x35DEA90", Offset = "0x35DD690", VA = "0x1835DEA90")]
	private void MOLIMJDFMGD(NativeList<EntityArchetype> DHBCLLNNNED, NativeHashMap<int, CJFIGKJMGNA> PGFKIFDOBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x35DE880", Offset = "0x35DD480", VA = "0x1835DE880")]
	private Span<int> GNKPAGGMCFF(EntityArchetype JIDCFBAAHAH)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x35DE9C0", Offset = "0x35DD5C0", VA = "0x1835DE9C0")]
	private bool HIHAAIKNABN(int FKPCJKABBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x35DE1E0", Offset = "0x35DCDE0", VA = "0x1835DE1E0")]
	private void DBOHKDMHBLK(NativeHashMap<int, CJFIGKJMGNA> PGFKIFDOBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public IDLEFILGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[GKALNADHNEP(DAHLALKJFLL.Serialization)]
	public class PreSerializeRemoveEntities : IKDACLPDLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private static FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery HEBKMAPFFDG;

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x30A00F0", Offset = "0x309ECF0", VA = "0x1830A00F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x30A0370", Offset = "0x309EF70", VA = "0x1830A0370", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[GKALNADHNEP(DAHLALKJFLL.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[CompilerGenerated]
		private struct HEGLDCEIGIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public ACOGKCNIFAF dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x6000A33")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
			public HEGLDCEIGIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x43A7E20", Offset = "0x43A6A20", VA = "0x1843A7E20")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct JKDCIIGLHPM : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			[ReadOnly]
			public NativeList<int> MALHNKJOHLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			[ReadOnly]
			public NativeArray<Entity> GEJLGGJOLLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public ACOGKCNIFAF PMDBMDGJECK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			[ReadOnly]
			public NativeArray<byte> CEKFHLPOBFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int FAFDDEJCIAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public ComponentType FDMNMHNCFEK;

			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0x43ABE00", Offset = "0x43AAA00", VA = "0x1843ABE00")]
			internal void HECHOFEKDHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0x43ABFC0", Offset = "0x43AABC0", VA = "0x1843ABFC0", Slot = "5")]
			public void ReadFromDisplayClass(ref HEGLDCEIGIP HNPKAGHHMHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x43ABDD0", Offset = "0x43AA9D0", VA = "0x1843ABDD0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x43ABDE0", Offset = "0x43AA9E0", VA = "0x1843ABDE0")]
			public void GDFFALHKOBH(ShadowWorldApplyPropertyDifferencesToShadowWorld IEKCOPFEHBF, ref HEGLDCEIGIP HNPKAGHHMHE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private PropertyDiffStateService GBMKHHIBDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private JobHandle BGNCDPNILKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private JobHandle OCOFLCKBDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private PLNGMBEJLHF DBOAJCAFPEK;

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x3337A40", Offset = "0x3336640", VA = "0x183337A40", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x3337A00", Offset = "0x3336600", VA = "0x183337A00")]
		public JobHandle COGKPBNNGCO(JobHandle PJNPMKLPJLL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x3337DB0", Offset = "0x33369B0", VA = "0x183337DB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x3337AA0", Offset = "0x33366A0", VA = "0x183337AA0")]
		private bool GJLHLJMHLNK(JobHandle PJNPMKLPJLL, int FKPCJKABBEA, out JobHandle EPBLMBFOJLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[ExecuteAlways]
[NIHNIOJKONF]
[UpdateInGroup(typeof(GPDKACJMAKJ))]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
internal sealed class MJMPBEJELPG : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x35E9DD0", Offset = "0x35E89D0", VA = "0x1835E9DD0", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public MJMPBEJELPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[ExecuteAlways]
[NIHNIOJKONF]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
[UpdateInGroup(typeof(FJBGJNJJNNH))]
internal sealed class GDFLCHAMAJA : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x35D3DE0", Offset = "0x35D29E0", VA = "0x1835D3DE0", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public GDFLCHAMAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[NIHNIOJKONF]
[ExecuteAlways]
[UpdateInGroup(typeof(OEJIAGBNNJL))]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
internal sealed class ECGBLJNDCGG : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x31B3E40", Offset = "0x31B2A40", VA = "0x1831B3E40", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public ECGBLJNDCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[ExecuteAlways]
[NIHNIOJKONF]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
[UpdateInGroup(typeof(PBFLNCPBEHC))]
internal sealed class CLNBNGJEBPM : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x31A2E00", Offset = "0x31A1A00", VA = "0x1831A2E00", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public CLNBNGJEBPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class OADPMKJHHBP : JHEJCNNDOGF
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	protected override JEGPFMALOAP FIKJKCNFGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x7933D0", Offset = "0x791FD0", VA = "0x1807933D0", Slot = "18")]
		get
		{
			return default(JEGPFMALOAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x3086350", Offset = "0x3084F50", VA = "0x183086350")]
	public OADPMKJHHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[ExecuteAlways]
[NIHNIOJKONF]
[UpdateInGroup(typeof(DJPIIOCFNMB))]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
internal sealed class PIDGCNOMIHA : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x3099CF0", Offset = "0x30988F0", VA = "0x183099CF0", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public PIDGCNOMIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class ELMHKKKMOOL : LPEKBLLHNJF
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public ELMHKKKMOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class FKOHPMPBAKP : JHEJCNNDOGF
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override JEGPFMALOAP FIKJKCNFGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8D0", Offset = "0x6AC4D0", VA = "0x1806AD8D0", Slot = "18")]
		get
		{
			return default(JEGPFMALOAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public FKOHPMPBAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[ExecuteAlways]
[NIHNIOJKONF]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
[UpdateInGroup(typeof(HAPANKCAPFM))]
internal sealed class EODBGINAJGO : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x31B52D0", Offset = "0x31B3ED0", VA = "0x1831B52D0", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public EODBGINAJGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class NCJAJFMGEON : LPEKBLLHNJF
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public NCJAJFMGEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class IJMFHJIPBDM : LPEKBLLHNJF
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public IJMFHJIPBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class FLCOBPJMOOF : IKDACLPDLNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public FLCOBPJMOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[FJJLKPGAMCM]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
public class ENECHNEOFGK : IKDACLPDLNJ, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private TimeService IOBEJOJDLDH;

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x31B5260", Offset = "0x31B3E60", VA = "0x1831B5260", Slot = "14")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x31B52B0", Offset = "0x31B3EB0", VA = "0x1831B52B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public ENECHNEOFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[GKALNADHNEP(DAHLALKJFLL.TransformSyncing)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	public class CopyTransformDataFromGameObjects : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile]
		private struct LKBIODALAHJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private const float OINDAIIPNIG = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			[ReadOnly]
			public NativeArray<Entity> EADNCMDNEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> IEIAKLMCPJC;

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x332F630", Offset = "0x332E230", VA = "0x18332F630", Slot = "4")]
			public void Execute(int KLEGICPDLIF, TransformAccess IGPPDIMEFDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x332F5F0", Offset = "0x332E1F0", VA = "0x18332F5F0")]
			private bool DDLILCGNNDF(float3 AIGOLOAIBCA, float3 BNKKPEFEMPA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x332F580", Offset = "0x332E180", VA = "0x18332F580")]
			private bool BGEBGMHGLNC(quaternion AIGOLOAIBCA, quaternion BNKKPEFEMPA)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		private struct IINCGABFLOH : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			[ReadOnly]
			public NativeArray<Entity> EADNCMDNEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> OPJMABJMLKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> IKLAPKMFINF;

			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0x332D1D0", Offset = "0x332BDD0", VA = "0x18332D1D0", Slot = "4")]
			public void Execute(int KLEGICPDLIF, TransformAccess IGPPDIMEFDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly FCNKBCOKGMK NDOEEGBHACM;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private static readonly FCNKBCOKGMK PAMGBPNPABG;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private static readonly FCNKBCOKGMK EBIEENPAIJJ;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private static readonly ProfilerMarker JBJADKAAEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private GHHDLKLILLB HJBJIIJLLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private HOONHJLELFO GMKNLKMJIPP;

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x31AB4B0", Offset = "0x31AA0B0", VA = "0x1831AB4B0", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x31AB520", Offset = "0x31AA120", VA = "0x1831AB520", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x31AB550", Offset = "0x31AA150", VA = "0x1831AB550", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[GKALNADHNEP(DAHLALKJFLL.TransformSyncing)]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	public class RegisterTransforms : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct MDGLLIPJFKK : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018A")]
			private struct ALPCEEICNMB
			{
				[Cpp2IlInjected.Token(Token = "0x200018B")]
				public struct NJNNKGGCFMO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004B7")]
					public LambdaParameterValueProvider_Entity.Runtime ILAODBKEPEJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004B8")]
					public LambdaParameterValueProvider_IComponentData<LMANEMNPLBB>.Runtime PBJCOJJHJKH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004B9")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime HMHEPNCPFIG;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity FFFAHLBALFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<LMANEMNPLBB> HHBNGHMEBMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004B6")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> KNKKPLHKMNJ;

				[Cpp2IlInjected.Token(Token = "0x6000A84")]
				[Cpp2IlInjected.Address(RVA = "0x43A6050", Offset = "0x43A4C50", VA = "0x1843A6050")]
				public void GDFFALHKOBH(RegisterTransforms IEKCOPFEHBF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0x43A5F90", Offset = "0x43A4B90", VA = "0x1843A5F90")]
				public NJNNKGGCFMO DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
				{
					return default(NJNNKGGCFMO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private ALPCEEICNMB KHJPHIECPAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe ALPCEEICNMB.NJNNKGGCFMO* MKHNGJINIJK;

			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PHJMPFOKBGL;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x43ADAC0", Offset = "0x43AC6C0", VA = "0x1843ADAC0")]
			internal void HECHOFEKDHF(Entity BODOHICDFAL, LMANEMNPLBB JBNOJAIGFDO, Transform IGPPDIMEFDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x43AD870", Offset = "0x43AC470", VA = "0x1843AD870", Slot = "4")]
			public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x43AD960", Offset = "0x43AC560", VA = "0x1843AD960")]
			public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, ref ALPCEEICNMB.NJNNKGGCFMO IKHKHMKOEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x43ADA40", Offset = "0x43AC640", VA = "0x1843ADA40")]
			public void GDFFALHKOBH(RegisterTransforms IEKCOPFEHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x43ADA50", Offset = "0x43AC650", VA = "0x1843ADA50")]
			public unsafe static void GGIFGIINNMA(ArchetypeChunkIterator* PCLDPFNHHHB, void* AKDGMOCNLFL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct LJJBMIMBGLF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct JKPOBPGOMEF
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				[NoAlias]
				public struct MLCJNJPIIKF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004BE")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ILAODBKEPEJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004BF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<LMANEMNPLBB>.Runtime PBJCOJJHJKH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004BC")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity FFFAHLBALFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004BD")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<LMANEMNPLBB> HHBNGHMEBMI;

				[Cpp2IlInjected.Token(Token = "0x6000A8A")]
				[Cpp2IlInjected.Address(RVA = "0x43AC080", Offset = "0x43AAC80", VA = "0x1843AC080")]
				public void GDFFALHKOBH(RegisterTransforms IEKCOPFEHBF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8B")]
				[Cpp2IlInjected.Address(RVA = "0x43AC000", Offset = "0x43AAC00", VA = "0x1843AC000")]
				public MLCJNJPIIKF DOOHIBKCALH(ref ArchetypeChunk GMMHHABKAFI, int JANFMBACFJE, int NJMCFLEPBKB)
				{
					return default(MLCJNJPIIKF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			private JKPOBPGOMEF KHJPHIECPAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JKPOBPGOMEF.MLCJNJPIIKF* MKHNGJINIJK;

			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x43ACE00", Offset = "0x43ABA00", VA = "0x1843ACE00")]
			internal void HECHOFEKDHF(Entity BODOHICDFAL, LMANEMNPLBB JBNOJAIGFDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x43ACCC0", Offset = "0x43AB8C0", VA = "0x1843ACCC0", Slot = "4")]
			public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0x43ACD50", Offset = "0x43AB950", VA = "0x1843ACD50")]
			public void FEGBABHPFPK(ref ArchetypeChunk AEGPPFELHPO, [NoAlias] ref JKPOBPGOMEF.MLCJNJPIIKF IKHKHMKOEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x43AC080", Offset = "0x43AAC80", VA = "0x1843AC080")]
			public void GDFFALHKOBH(RegisterTransforms IEKCOPFEHBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private GHHDLKLILLB HJBJIIJLLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private EntityQuery JGGJBGKGKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private EntityQuery LCCICJPOKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private EntityQuery LCFJENBDFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private EntityQuery BLMBBBLDGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private EntityQuery ICHGGGIMLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private ProfilerMarker BMOMDDJICAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private EntityQuery JHJBJELNCGG;

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x3331370", Offset = "0x332FF70", VA = "0x183331370", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x3331950", Offset = "0x3330550", VA = "0x183331950", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x3331B60", Offset = "0x3330760", VA = "0x183331B60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x3330F90", Offset = "0x332FB90", VA = "0x183330F90")]
		private void DOLIGNJOJJM(EntityQuery GJLGONPKKFL, IPFANALALDA NODDICIBMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x3330840", Offset = "0x332F440", VA = "0x183330840")]
		private void CJNPMLDJIKC(EntityQuery GJLGONPKKFL, IPFANALALDA NODDICIBMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x3331B00", Offset = "0x3330700", VA = "0x183331B00", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x33315A0", Offset = "0x33301A0", VA = "0x1833315A0")]
		private void HDACKNKDOMA(NativeArray<Entity> EADNCMDNEKI, IPFANALALDA NODDICIBMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x3330AB0", Offset = "0x332F6B0", VA = "0x183330AB0")]
		[BurstCompile]
		internal static void CMDBAJOANGE(NativeArray<LMANEMNPLBB> MNDEELJKLIB, ComponentDataFromEntity<LMANEMNPLBB> AADIJPDBJDO, IPFANALALDA NODDICIBMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		private static void CNPAGOGEOGM(Transform IGPPDIMEFDL, Entity BODOHICDFAL, int KLEGICPDLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		private static void MNNIFDMBOAO(Entity BODOHICDFAL, int KLEGICPDLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		private static void OMFEEMBIBMD(int KLEGICPDLIF, IPFANALALDA NODDICIBMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x33313C0", Offset = "0x332FFC0", VA = "0x1833313C0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void HAIILLAPOHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x33316E0", Offset = "0x33302E0", VA = "0x1833316E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x33311D0", Offset = "0x332FDD0", VA = "0x1833311D0")]
		public static EntityQuery DPLEOAJKNKF(ComponentSystemBase IEKCOPFEHBF)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x3330DC0", Offset = "0x332F9C0", VA = "0x183330DC0")]
		public static EntityQuery DNOCMEPFNKF(ComponentSystemBase IEKCOPFEHBF)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.TransformSyncing)]
	public class CopyTransformDataToGameObjects : IKDACLPDLNJ, BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[BurstCompile]
		private struct JGDKDHHLPKC : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> IEIAKLMCPJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			[ReadOnly]
			public NativeArray<Entity> EADNCMDNEKI;

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x332D870", Offset = "0x332C470", VA = "0x18332D870", Slot = "4")]
			public void Execute(int KLEGICPDLIF, TransformAccess IGPPDIMEFDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[BurstCompile]
		private struct JFKDJICGCON : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> OPJMABJMLKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[ReadOnly]
			public NativeArray<Entity> EADNCMDNEKI;

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x332D7D0", Offset = "0x332C3D0", VA = "0x18332D7D0", Slot = "4")]
			public void Execute(int KLEGICPDLIF, TransformAccess IGPPDIMEFDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[BurstCompile]
		private struct FIJMCHHNEOG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> OPJMABJMLKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> IKLAPKMFINF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			[ReadOnly]
			public NativeArray<Entity> EADNCMDNEKI;

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0x332CB20", Offset = "0x332B720", VA = "0x18332CB20", Slot = "4")]
			public void Execute(int KLEGICPDLIF, TransformAccess IGPPDIMEFDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private static readonly FCNKBCOKGMK NDOEEGBHACM;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly FCNKBCOKGMK PAMGBPNPABG;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private static readonly FCNKBCOKGMK EBIEENPAIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private GHHDLKLILLB HJBJIIJLLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private EntityQuery LHEKLFJNHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private EntityQuery AOCFAMPIAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private EntityQuery MPFGMNFOGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TransformAccessArray DPFMPIKBDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TransformAccessArray OLBPFAHHAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TransformAccessArray BAPJABCCLNA;

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x31ABB80", Offset = "0x31AA780", VA = "0x1831ABB80", Slot = "14")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x31ABBD0", Offset = "0x31AA7D0", VA = "0x1831ABBD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x31ABDC0", Offset = "0x31AA9C0", VA = "0x1831ABDC0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x31ABE50", Offset = "0x31AAA50", VA = "0x1831ABE50", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x31ABE80", Offset = "0x31AAA80", VA = "0x1831ABE80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x31ABA00", Offset = "0x31AA600", VA = "0x1831ABA00")]
		private NativeArray<Entity> DCDAMMFDMAM(NativeArray<LMANEMNPLBB> MALHNKJOHLB, NativeList<Entity> EECJKEGNNBI, TransformAccessArray KPBGHPNFHIH, TransformAccessArray AJINKLJELGL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.TransformSyncing)]
	public class CopyTransformParentsToGameObjects : IKDACLPDLNJ, JGJNINBGNFN
	{
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private OHCBPBOEABE HEGJONDKOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private KFMIEMINHBG FFDFLABPLPF;

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x30A0730", Offset = "0x309F330", VA = "0x1830A0730", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x31AC7B0", Offset = "0x31AB3B0", VA = "0x1831AC7B0", Slot = "14")]
		public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x31ACAE0", Offset = "0x31AB6E0", VA = "0x1831ACAE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x31AC960", Offset = "0x31AB560", VA = "0x1831AC960")]
		private static void HCDEDPFKDEF(EntityManager JOKFOKELNGA, Entity BODOHICDFAL, Entity NIGFDFKEKGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x31AC8C0", Offset = "0x31AB4C0", VA = "0x1831AC8C0")]
		private static bool GMKBAMGDIBP(EntityManager JOKFOKELNGA, Entity BODOHICDFAL, out Transform IGPPDIMEFDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[GKALNADHNEP(DAHLALKJFLL.TransformSyncing)]
	public class L2PToL2WHierarchy : IKDACLPDLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct EBFLEHOLGMF : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> FOACPCBJCEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> ONKGHDNJJAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> BPMIBKIBMFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> KLJBJPMBDPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public ArchetypeChunkComponentType<LocalToWorldData> JAIPCFCBIOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> KHOMKFDIIDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public uint HDMFBMPHKLP;

			[Cpp2IlInjected.Token(Token = "0x6000AA5")]
			[Cpp2IlInjected.Address(RVA = "0x43A8840", Offset = "0x43A7440", VA = "0x1843A8840")]
			[Conditional("DEBUG_BUILD")]
			private void ABIFLJAEKEM(Entity BODOHICDFAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x43A8910", Offset = "0x43A7510", VA = "0x1843A8910", Slot = "4")]
			public void Execute(ArchetypeChunk AEGPPFELHPO, int KLEGICPDLIF, int HNGFIHCCBEP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0x43A8C00", Offset = "0x43A7800", VA = "0x1843A8C00")]
			private void IHDHDCFPKJJ(float4x4 NAFKIMKJKIM, Entity BODOHICDFAL, bool DNJIPBNKKNJ, int NDIGJOEOGLI = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery KINIJLBBPIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private EntityQuery PNBDGBFFGAH;

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x35E5880", Offset = "0x35E4480", VA = "0x1835E5880", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x35E59A0", Offset = "0x35E45A0", VA = "0x1835E59A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class MOBIHIJJFFK : NCJGNNIGIPP
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[BurstCompile]
	private struct GKIOOBGMGDP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> FOACPCBJCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public ArchetypeChunkComponentType<LocalToWorldData> JAIPCFCBIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public uint HDMFBMPHKLP;

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x43A9BA0", Offset = "0x43A87A0", VA = "0x1843A9BA0", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int KLEGICPDLIF, int HNGFIHCCBEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x43A9CA0", Offset = "0x43A88A0", VA = "0x1843A9CA0")]
		public bool HNBIKOLCNLA(ArchetypeChunk AEGPPFELHPO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery KINIJLBBPIE;

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x35EA5A0", Offset = "0x35E91A0", VA = "0x1835EA5A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x35EA6D0", Offset = "0x35E92D0", VA = "0x1835EA6D0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DAPBMLHBHPM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public MOBIHIJJFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class CEIDDNHBDEB : NCJGNNIGIPP
{
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[BurstCompile]
	private struct CNOMMJHLENO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> KNMKJLHCAPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public ArchetypeChunkComponentType<WorldPoseData> PGJOBEGACNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> NAFPGEBCMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> FHFLLBIHCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public uint HDMFBMPHKLP;

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x332BF30", Offset = "0x332AB30", VA = "0x18332BF30", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int KLEGICPDLIF, int HNGFIHCCBEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x332C2E0", Offset = "0x332AEE0", VA = "0x18332C2E0")]
		public bool HNBIKOLCNLA(ArchetypeChunk AEGPPFELHPO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private EntityQuery OBDKJOBOIMH;

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x319FB20", Offset = "0x319E720", VA = "0x18319FB20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x319FC30", Offset = "0x319E830", VA = "0x18319FC30", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DAPBMLHBHPM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public CEIDDNHBDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public class DLGHDICGBMJ : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[BurstCompile]
	private struct CIECIIFGAMI : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> OMMNKJKIBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> KLJMBFGENEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> HJCBJFFGOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public ArchetypeChunkComponentType<LocalToParentData> EIIALDHPIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public uint HDMFBMPHKLP;

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x332B530", Offset = "0x332A130", VA = "0x18332B530", Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int KLEGICPDLIF, int HNGFIHCCBEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x332BC40", Offset = "0x332A840", VA = "0x18332BC40")]
		public bool HNBIKOLCNLA(ArchetypeChunk AEGPPFELHPO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private EntityQuery OBDKJOBOIMH;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x31B13B0", Offset = "0x31AFFB0", VA = "0x1831B13B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x31B14E0", Offset = "0x31B00E0", VA = "0x1831B14E0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DAPBMLHBHPM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0")]
	public DLGHDICGBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[GKALNADHNEP(DAHLALKJFLL.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : DAHJDDBJINO
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		public struct ELFLNLPGEKD : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType FJCHDPGIIMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0x30A1140", Offset = "0x309FD40", VA = "0x1830A1140", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override ComponentType PFLHOHIOIDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x30A1170", Offset = "0x309FD70", VA = "0x1830A1170", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override ComponentType DBHLLFFIHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x30A11A0", Offset = "0x309FDA0", VA = "0x1830A11A0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x30A10A0", Offset = "0x309FCA0", VA = "0x1830A10A0")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[LFODFFJJMDP(HMDFJLNCJCF.Game)]
public class JPFCDLNGPFF : AODHPHPILFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Type OGFMKMJHNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0x35E2E40", Offset = "0x35E1A40", VA = "0x1835E2E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] MGGFEECCEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x35E2EB0", Offset = "0x35E1AB0", VA = "0x1835E2EB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JPFCDLNGPFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[LFODFFJJMDP(HMDFJLNCJCF.Loading)]
public class NHDEFEKBFNE : AODHPHPILFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Type OGFMKMJHNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8D0", Offset = "0x6AC4D0", VA = "0x1806AD8D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] MGGFEECCEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x30850E0", Offset = "0x3083CE0", VA = "0x1830850E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public NHDEFEKBFNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public sealed class EBCBMPNCMAI : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x31B3B00", Offset = "0x31B2700", VA = "0x1831B3B00", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public EBCBMPNCMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[LFODFFJJMDP(HMDFJLNCJCF.Saving)]
public class EGMCICHMAFN : AODHPHPILFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type OGFMKMJHNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8D0", Offset = "0x6AC4D0", VA = "0x1806AD8D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type[] MGGFEECCEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x31B4770", Offset = "0x31B3370", VA = "0x1831B4770", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public EGMCICHMAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public sealed class DFCFIMMPNOE : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x31B0AD0", Offset = "0x31AF6D0", VA = "0x1831B0AD0", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public DFCFIMMPNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[LFODFFJJMDP(HMDFJLNCJCF.Simulation)]
public class EALCPFGGIOD : AODHPHPILFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type OGFMKMJHNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x31B3170", Offset = "0x31B1D70", VA = "0x1831B3170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type[] MGGFEECCEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x31B31E0", Offset = "0x31B1DE0", VA = "0x1831B31E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public EALCPFGGIOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[HJBMNHLGPOF(typeof(JIOAOCNGOEP), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
internal class JIOAOCNGOEP : JGJNINBGNFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private global::EHOLOLGNBGE<AuthoredParentData, DAPGAPAJHEO, JFLGHAGCKJF, AuthoredChildrenData> KHFCHJCGLHI;

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x35E0CD0", Offset = "0x35DF8D0", VA = "0x1835E0CD0", Slot = "4")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JIOAOCNGOEP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	[GKALNADHNEP(DAHLALKJFLL.HierarchySystems)]
	[HJBMNHLGPOF(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : BLCFKNFGJJJ, JGJNINBGNFN
	{
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[NNMLOJPMNKB]
		private IHMCHCLHMKB OBDKJOBOIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[NNMLOJPMNKB]
		private PropertyChangeNetworkRouter EJKFDMBLCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private global::ILIGGOFIJKG<Entity> FCPNPIIHNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private global::EHOLOLGNBGE<ParentData, GFMLGHAEBHB, KNDBOOGJODG, ChildrenData> KHFCHJCGLHI;

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x35CF9C0", Offset = "0x35CE5C0", VA = "0x1835CF9C0", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x35CF820", Offset = "0x35CE420", VA = "0x1835CF820", Slot = "5")]
		public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x35CFC70", Offset = "0x35CE870", VA = "0x1835CFC70")]
		public Entity OBGHCIILFKA(Entity BODOHICDFAL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x35CFC10", Offset = "0x35CE810", VA = "0x1835CFC10")]
		public bool KOPFKOOKJCP(Entity BODOHICDFAL, Entity FJCPKFBPJEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x35CF920", Offset = "0x35CE520", VA = "0x1835CF920")]
		public bool FANOFILKGIA(Entity BODOHICDFAL, Entity FJCPKFBPJEK, bool FOIBGKBOOBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x35CFA30", Offset = "0x35CE630", VA = "0x1835CFA30")]
		private bool GNCHHFLJECP(Entity BODOHICDFAL, Entity FJCPKFBPJEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[HJBMNHLGPOF(typeof(JNBNBKGEFGN), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
internal sealed class JNBNBKGEFGN : BLCFKNFGJJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	[NNMLOJPMNKB]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery LAFACGKEAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private EntityManager CNOHAEKAHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x35E22A0", Offset = "0x35E0EA0", VA = "0x1835E22A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x35E24A0", Offset = "0x35E10A0", VA = "0x1835E24A0", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x35E23A0", Offset = "0x35E0FA0", VA = "0x1835E23A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x35E2990", Offset = "0x35E1590", VA = "0x1835E2990")]
	public bool NOFNCJFGCLB(Entity BODOHICDFAL, Entity DGPJCMKHAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x35E2CC0", Offset = "0x35E18C0", VA = "0x1835E2CC0")]
	public IEnumerable<Entity> PMEDJAOPCCA(Entity BODOHICDFAL, bool DGGHOPFGFBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x35E2170", Offset = "0x35E0D70", VA = "0x1835E2170")]
	public bool ANAKHBDCABO(Entity BODOHICDFAL, Entity JAFNGMFCAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x35E25A0", Offset = "0x35E11A0", VA = "0x1835E25A0")]
	public bool GFIOHCEGLHC(Entity BODOHICDFAL, Entity NOFIECLFCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x35E23C0", Offset = "0x35E0FC0", VA = "0x1835E23C0")]
	public NativeList<Entity> EKEJBPKFDPH(Entity BODOHICDFAL, bool DGGHOPFGFBI = false, Allocator JMMNDPMBMFC = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x35E26A0", Offset = "0x35E12A0", VA = "0x1835E26A0")]
	public IEnumerable<Entity> IHCPDKHDGPA(Entity BODOHICDFAL, bool DGGHOPFGFBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x35E22F0", Offset = "0x35E0EF0", VA = "0x1835E22F0")]
	public Entity CNPKLEJKNMM(Entity BODOHICDFAL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x35E2C70", Offset = "0x35E1870", VA = "0x1835E2C70")]
	public NativeArray<Entity> PLAGPOEAHMG()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x35E2A50", Offset = "0x35E1650", VA = "0x1835E2A50")]
	public bool OELKOOEENGO(Entity NOFIECLFCLK, Entity EDMOBKKEKCA, out Entity OGFAOKKNMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x35E28A0", Offset = "0x35E14A0", VA = "0x1835E28A0")]
	private Entity LADBBJOGEOO(Entity BODOHICDFAL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JNBNBKGEFGN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[GKALNADHNEP(DAHLALKJFLL.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x46BA3C0", Offset = "0x46B8FC0", VA = "0x1846BA3C0")]
		public static void OEKJIJPBJKA<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(PJJBBDFFHDI FAEIDGPFAHD, global::ANDBNBJKMBA<Entity> DKMDGLKPPGF, out global::EHOLOLGNBGE<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> EKGCAIDIMNC) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, EEPPNJCBMLI where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, EEPPNJCBMLI, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x309BC50", Offset = "0x309A850", VA = "0x18309BC50")]
		public static bool JFAIKNKINBO(DABKEOMEIOA ENAFFFEEEOK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public class EHOLOLGNBGE<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, EEPPNJCBMLI where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, EEPPNJCBMLI, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private static readonly FCNKBCOKGMK OIFMFCIPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly global::ILIGGOFIJKG<Entity> FCPNPIIHNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly OAAGFCMFOON HDLDPNOPBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly MAKJLBJHHHB NIGFDFKEKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly EntityManager JOKFOKELNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly KFMIEMINHBG FFDFLABPLPF;

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x23863D0", Offset = "0x2384FD0", VA = "0x1823863D0")]
	public EHOLOLGNBGE(PJJBBDFFHDI FAEIDGPFAHD, global::ANDBNBJKMBA<Entity> DKMDGLKPPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x2385FD0", Offset = "0x2384BD0", VA = "0x182385FD0")]
	private bool NKLIEGJPEGN(Entity BODOHICDFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x2385F80", Offset = "0x2384B80", VA = "0x182385F80")]
	private bool LOCPDAMPJLE(Entity BODOHICDFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x2385E30", Offset = "0x2384A30", VA = "0x182385E30")]
	public bool KOPFKOOKJCP(Entity BODOHICDFAL, in Entity FJCPKFBPJEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x2385590", Offset = "0x2384190", VA = "0x182385590")]
	public bool FGLJAFFILJB(Entity BODOHICDFAL, in Entity FJCPKFBPJEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x2385150", Offset = "0x2383D50", VA = "0x182385150")]
	private bool FGLJAFFILJB(Entity BODOHICDFAL, in Entity FJCPKFBPJEK, bool NPPLBBCDKHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private static void HKJMNCMKBCN(Entity BODOHICDFAL, in Entity FJCPKFBPJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private static void NKNKCMEBBKE(Entity BODOHICDFAL, in Entity FJCPKFBPJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private static void CLENCDDDNDA(Entity BODOHICDFAL, in Entity FJCPKFBPJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private static void DJDBPANPJDD(Entity BODOHICDFAL, in Entity FJCPKFBPJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private static void NOBJGJEDOBP(Entity BODOHICDFAL, in Entity FJCPKFBPJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x2386170", Offset = "0x2384D70", VA = "0x182386170")]
	private bool NOFNCJFGCLB(Entity BODOHICDFAL, Entity DGPJCMKHAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x2385060", Offset = "0x2383C60", VA = "0x182385060")]
	private void COBIEMFCGDI(Entity BODOHICDFAL, in Entity FIFCKAAEEOG, in Entity FJCPKFBPJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x2385760", Offset = "0x2384360", VA = "0x182385760")]
	private void GHAPMEOBPNG(Entity BODOHICDFAL, in Entity FIFCKAAEEOG, in Entity FJCPKFBPJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x2385A30", Offset = "0x2384630", VA = "0x182385A30")]
	private bool KMHDBLFHIKH(CAGCLBIMFOH GLMJCGAOOBN, in KFMKFJINGPH ECGBKLNPCNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x2385900", Offset = "0x2384500", VA = "0x182385900")]
	private void HHDMGPKPALL(Entity NIGFDFKEKGM, Entity JAFNGMFCAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x2385EF0", Offset = "0x2384AF0", VA = "0x182385EF0")]
	private void LFGMLIPOPPB(Entity NIGFDFKEKGM, Entity JAFNGMFCAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private void OMFEEMBIBMD(Entity BODOHICDFAL, Entity FIFCKAAEEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private void CNPAGOGEOGM(Entity BODOHICDFAL, Entity FJCPKFBPJEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public struct LMGOPADFAFE : PGKDDODDOMH, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public KCHKFBIFFEM JMFFPDJDGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x695E30", Offset = "0x694A30", VA = "0x180695E30", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KCHKFBIFFEM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x6A2F60", Offset = "0x6A1B60", VA = "0x1806A2F60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[HJBMNHLGPOF(typeof(ObjectEmbodimentService), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.Embodiment)]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	internal sealed class ObjectEmbodimentService : CLILAOIFPFK, AHBNMIIEDML, BLCFKNFGJJJ, JGJNINBGNFN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private ObjectLifecycleService LPHFEOKHKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[NNMLOJPMNKB]
		private HOONHJLELFO EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[NNMLOJPMNKB]
		private IHMCHCLHMKB OBDKJOBOIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[NNMLOJPMNKB]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		[NNMLOJPMNKB]
		private NFBIPKALIAH HOAFPJNBADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		[NNMLOJPMNKB]
		private GKAGBEJKMIF HLBMACJEJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		[NNMLOJPMNKB]
		private TransformOwnershipPhase PEMMOPHCPHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private readonly Dictionary<KFMKFJINGPH, GIHALPBFOMC> ADGPHJBPCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private GONCFJLLCOJ CJPAJNHICEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private bool JIGLPOGPBPP;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		private EntityManager CNOHAEKAHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0x308CAA0", Offset = "0x308B6A0", VA = "0x18308CAA0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int OOMGAPHHKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x308D550", Offset = "0x308C150", VA = "0x18308D550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public int LHKGJEDBJIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x3090060", Offset = "0x308EC60", VA = "0x183090060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x1CFD590", Offset = "0x1CFC190", VA = "0x181CFD590", Slot = "4")]
		public void PHKHGJFAMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x308D570", Offset = "0x308C170", VA = "0x18308D570", Slot = "5")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x3090010", Offset = "0x308EC10", VA = "0x183090010")]
		public void PFBDIIKFHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x308CAF0", Offset = "0x308B6F0", VA = "0x18308CAF0", Slot = "6")]
		public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x308D390", Offset = "0x308BF90", VA = "0x18308D390", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x30902A0", Offset = "0x308EEA0", VA = "0x1830902A0")]
		public int PPDNGLEPOCJ(SceneTag IPMKKEICEKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x308E520", Offset = "0x308D120", VA = "0x18308E520")]
		public int JHENNDFMOPA(SceneTag IPMKKEICEKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x308C600", Offset = "0x308B200", VA = "0x18308C600")]
		public bool ADMCGCOGFDH(Entity BODOHICDFAL, Allocator JMMNDPMBMFC, out NativeList<Entity> BHKDCKAHEGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x308C850", Offset = "0x308B450", VA = "0x18308C850")]
		public bool BIOOCENEIMC(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x308E500", Offset = "0x308D100", VA = "0x18308E500")]
		public bool JGDPEEKPKPM(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x308D8D0", Offset = "0x308C4D0", VA = "0x18308D8D0")]
		public bool FPHGMCENCAM(Entity BODOHICDFAL, out GIHALPBFOMC NIENOEJANLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x308D940", Offset = "0x308C540", VA = "0x18308D940")]
		private bool FPHGMCENCAM(Transform IGPPDIMEFDL, out GIHALPBFOMC NIENOEJANLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x308F540", Offset = "0x308E140", VA = "0x18308F540")]
		private void NAADIJEBGDG(Entity BODOHICDFAL, GIHALPBFOMC NIENOEJANLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x308FEE0", Offset = "0x308EAE0", VA = "0x18308FEE0")]
		private bool OHPEAADOJMC(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x308E540", Offset = "0x308D140", VA = "0x18308E540")]
		public void JHOMPJHMJJA(KFMKFJINGPH AAEPEKAJNKI, GIHALPBFOMC CIGKIBHLLHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x308F9A0", Offset = "0x308E5A0", VA = "0x18308F9A0")]
		public bool NNFCPKJNIPH(Entity BODOHICDFAL, object GIHOLCNOBIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x308EDB0", Offset = "0x308D9B0", VA = "0x18308EDB0")]
		public bool LOHCHGPIOFF(CGECBEAFDFK HGAMKJKNDDL, object GIHOLCNOBIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x308F4F0", Offset = "0x308E0F0", VA = "0x18308F4F0")]
		public bool LOHCHGPIOFF(Entity BODOHICDFAL, [Optional] object GIHOLCNOBIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x308F160", Offset = "0x308DD60", VA = "0x18308F160")]
		public bool LOHCHGPIOFF(GIHALPBFOMC ENAFFFEEEOK, object GIHOLCNOBIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x308DFA0", Offset = "0x308CBA0", VA = "0x18308DFA0")]
		public bool IKGIOAEJKHG(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x308E370", Offset = "0x308CF70", VA = "0x18308E370")]
		public bool IKGIOAEJKHG(GIHALPBFOMC NIENOEJANLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x308F180", Offset = "0x308DD80", VA = "0x18308F180")]
		public bool LOHCHGPIOFF(GIHALPBFOMC NIENOEJANLD, [Optional] object GIHOLCNOBIB, bool HLLKIIKCMBO = false, bool APGOOEHNGDP = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x308CFF0", Offset = "0x308BBF0", VA = "0x18308CFF0")]
		public Transform COMAPDCJDEE(Entity BODOHICDFAL, [Optional] object GIHOLCNOBIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x308DCB0", Offset = "0x308C8B0", VA = "0x18308DCB0")]
		public bool GMKBAMGDIBP(Entity BODOHICDFAL, out Transform IGPPDIMEFDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x308D2A0", Offset = "0x308BEA0", VA = "0x18308D2A0")]
		public GIHALPBFOMC DPNDGAHFFFB(Entity BODOHICDFAL, [Optional] object GIHOLCNOBIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x308CC40", Offset = "0x308B840", VA = "0x18308CC40")]
		public void CGMFOPNEPKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x308E740", Offset = "0x308D340", VA = "0x18308E740")]
		public void JOAMFBDMOBA(SceneTag IPMKKEICEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x308F5E0", Offset = "0x308E1E0", VA = "0x18308F5E0")]
		private void NHPKIFAJHOK(Entity BODOHICDFAL, bool GKNPPFODAJB, bool ALNJMJJJIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x308E3A0", Offset = "0x308CFA0", VA = "0x18308E3A0")]
		private void IOPMBLMELCI(Entity BODOHICDFAL, GIHALPBFOMC NIENOEJANLD, bool GKNPPFODAJB, bool ALNJMJJJIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x308D1E0", Offset = "0x308BDE0", VA = "0x18308D1E0")]
		public GIHALPBFOMC DCHODLPLJKF(Entity BODOHICDFAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x308D9F0", Offset = "0x308C5F0", VA = "0x18308D9F0")]
		public bool GGEFHCLJENA(Entity BODOHICDFAL, object GIHOLCNOBIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x308D160", Offset = "0x308BD60", VA = "0x18308D160")]
		public bool CPGKOJILLPP(Entity BODOHICDFAL, object GIHOLCNOBIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x308D230", Offset = "0x308BE30", VA = "0x18308D230")]
		public bool DICAIFOEDLB(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x308EBD0", Offset = "0x308D7D0", VA = "0x18308EBD0")]
		public bool KBDPKMKACNJ(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x308EB00", Offset = "0x308D700", VA = "0x18308EB00")]
		public bool KBDPKMKACNJ(KCHKFBIFFEM LBLAJOOMAIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void JBIKFDCLFPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x308FE20", Offset = "0x308EA20", VA = "0x18308FE20")]
		private void OFDBNANHALB(bool MPHAJJJFIEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x308D4C0", Offset = "0x308C0C0", VA = "0x18308D4C0")]
		private bool ECHPAOCKBEN(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x308ED10", Offset = "0x308D910", VA = "0x18308ED10")]
		private GIHALPBFOMC LFMAPAKMLEJ(Entity BODOHICDFAL, object GIHOLCNOBIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x308DD80", Offset = "0x308C980", VA = "0x18308DD80")]
		private GIHALPBFOMC IEDEDADBIFH(Entity BODOHICDFAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x3090080", Offset = "0x308EC80", VA = "0x183090080")]
		private (Vector3, Quaternion, Vector3) PJMGHEADCAM(Entity BODOHICDFAL)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x308FF00", Offset = "0x308EB00", VA = "0x18308FF00")]
		private void OILEOBILBPL(Entity BODOHICDFAL, KLHKIJHKJFB IBFKFNLEDKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x308E440", Offset = "0x308D040", VA = "0x18308E440")]
		private void IPCBACFGPGC(CGECBEAFDFK HGAMKJKNDDL, GIHALPBFOMC CIGKIBHLLHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x308CED0", Offset = "0x308BAD0", VA = "0x18308CED0")]
		private void CNOIAJLAGGF(GIHALPBFOMC CIGKIBHLLHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x308D6A0", Offset = "0x308C2A0", VA = "0x18308D6A0")]
		private void FOEIBIAHNMI(GIHALPBFOMC NIENOEJANLD, Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x308DA70", Offset = "0x308C670", VA = "0x18308DA70")]
		private void GIOGPEDHLNP(Entity BODOHICDFAL, GIHALPBFOMC NIENOEJANLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x308FD40", Offset = "0x308E940", VA = "0x18308FD40")]
		private void OFCLGPLCJEB(Entity BODOHICDFAL, Transform IGPPDIMEFDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x308DF70", Offset = "0x308CB70", VA = "0x18308DF70")]
		private CGECBEAFDFK IEIMPFPGAIG(Entity BODOHICDFAL)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x3090310", Offset = "0x308EF10", VA = "0x183090310")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x308EC40", Offset = "0x308D840", VA = "0x18308EC40")]
		[CompilerGenerated]
		private void KGJDKOMDOPL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal static class EJGEOIOHIIE
{
	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x31B49F0", Offset = "0x31B35F0", VA = "0x1831B49F0")]
	public static GIHALPBFOMC DPNDGAHFFFB(this ObjectEmbodimentService MDBFILFJAMO, CGECBEAFDFK HGAMKJKNDDL, [Optional] object GIHOLCNOBIB)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[GKALNADHNEP(DAHLALKJFLL.Lifecycle)]
	[HJBMNHLGPOF(typeof(ObjectLifecycleService), new string[] { })]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	internal sealed class ObjectLifecycleService : BLCFKNFGJJJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private ObjectEmbodimentService NIENOEJANLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		[NNMLOJPMNKB]
		private HOONHJLELFO GMKNLKMJIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private IABLEKNFLJJ FLNDCJKEOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private DestroyLocalObjects MJPMKCPAHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private bool JIGLPOGPBPP;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager CNOHAEKAHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0x3090A50", Offset = "0x308F650", VA = "0x183090A50")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<Entity, KLHKIJHKJFB> CJIMPENILAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x3091800", Offset = "0x3090400", VA = "0x183091800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x3091760", Offset = "0x3090360", VA = "0x183091760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<Entity> NCDPPJCBHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x30918F0", Offset = "0x30904F0", VA = "0x1830918F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x3090C60", Offset = "0x308F860", VA = "0x183090C60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x3091010", Offset = "0x308FC10", VA = "0x183091010", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0xB52010", Offset = "0xB50C10", VA = "0x180B52010", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x30916E0", Offset = "0x30902E0", VA = "0x1830916E0")]
		public bool MKAKFEIOKNJ(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x30911F0", Offset = "0x308FDF0", VA = "0x1830911F0")]
		internal void KCGOBJIPNOI(Entity BODOHICDFAL, KLHKIJHKJFB IBFKFNLEDKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x30911B0", Offset = "0x308FDB0", VA = "0x1830911B0")]
		public void IAEFGMFEHKD(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x3090D60", Offset = "0x308F960", VA = "0x183090D60")]
		public void EIJAODBIHGI(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x30910F0", Offset = "0x308FCF0", VA = "0x1830910F0")]
		private bool FLCCPOIANMB(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x3091250", Offset = "0x308FE50", VA = "0x183091250")]
		public void LFFHDJLOGBM(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x3090AA0", Offset = "0x308F6A0", VA = "0x183090AA0")]
		private bool CPHPIPHECIJ(Entity BODOHICDFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x3091650", Offset = "0x3090250", VA = "0x183091650")]
		public void MJBIBDCIAFJ(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x3090D00", Offset = "0x308F900", VA = "0x183090D00")]
		private void DKBGGPJHBGK(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x3090DB0", Offset = "0x308F9B0", VA = "0x183090DB0")]
		private void ENKHGHCJHHD(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x30918A0", Offset = "0x30904A0", VA = "0x1830918A0")]
		public void OFFMEOFFPKD(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		private void MFFLODJLKPA(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x3091450", Offset = "0x3090050", VA = "0x183091450")]
		private void MIMCAEMOPFE(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[HJBMNHLGPOF(typeof(ObjectPrefabs), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.Prefabs)]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	internal class ObjectPrefabs : EODDOIBLEIP, BLCFKNFGJJJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private sealed class HHDAFHOMBOD : IEnumerable<(IELMBOEFPKD, KLHKIJHKJFB)>, IEnumerable, IEnumerator<(IELMBOEFPKD, KLHKIJHKJFB)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private (IELMBOEFPKD primitiveType, KLHKIJHKJFB prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000137")]
			private (IELMBOEFPKD, KLHKIJHKJFB) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6C")]
				[Cpp2IlInjected.Address(RVA = "0x1B15F10", Offset = "0x1B14B10", VA = "0x181B15F10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((IELMBOEFPKD, KLHKIJHKJFB));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000138")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6E")]
				[Cpp2IlInjected.Address(RVA = "0x43AA8A0", Offset = "0x43A94A0", VA = "0x1843AA8A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x43A8690", Offset = "0x43A7290", VA = "0x1843A8690")]
			[DebuggerHidden]
			public HHDAFHOMBOD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0x43AA6C0", Offset = "0x43A92C0", VA = "0x1843AA6C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x43AA860", Offset = "0x43A9460", VA = "0x1843AA860", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x43AA7C0", Offset = "0x43A93C0", VA = "0x1843AA7C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(IELMBOEFPKD, KLHKIJHKJFB)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0x43AA7C0", Offset = "0x43A93C0", VA = "0x1843AA7C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[NNMLOJPMNKB]
		private HOONHJLELFO GMKNLKMJIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private World EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private readonly Dictionary<KLHKIJHKJFB, Entity> BCDJFKMHLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private readonly Dictionary<KLHKIJHKJFB, EntityArchetype> DHBCLLNNNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private readonly Dictionary<IELMBOEFPKD, KLHKIJHKJFB> FJMEAEPOGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private readonly Dictionary<KLCDDLDEKAP, KLHKIJHKJFB> DIGPBIHJDGJ;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int GEHHFJONLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0x3093EE0", Offset = "0x3092AE0", VA = "0x183093EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public EntityManager CNOHAEKAHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x3093FA0", Offset = "0x3092BA0", VA = "0x183093FA0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x3094460", Offset = "0x3093060", VA = "0x183094460", Slot = "5")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x3094130", Offset = "0x3092D30", VA = "0x183094130", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x3095280", Offset = "0x3093E80", VA = "0x183095280")]
		internal IEnumerable<Type> MNPDCEAEMBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x3094F30", Offset = "0x3093B30", VA = "0x183094F30")]
		internal MNEBACPACPN GLMGEGNJNFP(Type JMPEGNOKOOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x3093E30", Offset = "0x3092A30", VA = "0x183093E30")]
		public EntityArchetype AAKOMKKBPIK(KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x3094C90", Offset = "0x3093890", VA = "0x183094C90")]
		public NativeHashMap<int, EntityArchetype> GEHGPMEAJFO(Allocator JMMNDPMBMFC = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x3095340", Offset = "0x3093F40", VA = "0x183095340")]
		public bool OIGJNFPBONF(KLHKIJHKJFB IBFKFNLEDKN, out EntityArchetype JIDCFBAAHAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x3093F30", Offset = "0x3092B30", VA = "0x183093F30", Slot = "4")]
		[IteratorStateMachine(typeof(HHDAFHOMBOD))]
		public IEnumerable<(IELMBOEFPKD, KLHKIJHKJFB)> CCJPNMOLCBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x3095100", Offset = "0x3093D00", VA = "0x183095100")]
		public Entity MFDGEAABOHF(KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x3095410", Offset = "0x3094010", VA = "0x183095410")]
		public KLHKIJHKJFB OPKJGOEEEBP(KLCDDLDEKAP JMPEGNOKOOB)
		{
			return default(KLHKIJHKJFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x30953B0", Offset = "0x3093FB0", VA = "0x1830953B0")]
		public KLHKIJHKJFB OPKJGOEEEBP(IELMBOEFPKD JMPEGNOKOOB)
		{
			return default(KLHKIJHKJFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x3093FC0", Offset = "0x3092BC0", VA = "0x183093FC0")]
		public NativeHashMap<int, Entity> DBEDCMKMPFB(Allocator JMMNDPMBMFC = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x3093E90", Offset = "0x3092A90", VA = "0x183093E90")]
		public IEnumerable<KLHKIJHKJFB> AEIECOBANJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x30952E0", Offset = "0x3093EE0", VA = "0x1830952E0")]
		public Entity NGJEDKFGNCI(KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x3095210", Offset = "0x3093E10", VA = "0x183095210")]
		public bool MMPCGCNJKNA(KLHKIJHKJFB IBFKFNLEDKN, out Entity HLABNIGHLFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x3094840", Offset = "0x3093440", VA = "0x183094840")]
		private void FEINNFIOIPE(MNEBACPACPN OAMONHGICNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x3095470", Offset = "0x3094070", VA = "0x183095470")]
		internal void PBIGCIHACFD(KLHKIJHKJFB IBFKFNLEDKN, LCDDHADEHJF LBAAFHJDAHD, NFCEFKHBPLO NMPNKJGAHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x3094FA0", Offset = "0x3093BA0", VA = "0x183094FA0")]
		private void MBIHPHPJILK(KLHKIJHKJFB IBFKFNLEDKN, LCDDHADEHJF MFLNELLNMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x3094E10", Offset = "0x3093A10", VA = "0x183094E10")]
		internal Entity GELDKGJBIPP(KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x30956F0", Offset = "0x30942F0", VA = "0x1830956F0")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public enum JEGPFMALOAP
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface CPKJCKHOIEB
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	World MFHAIABCKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	CLLGJDGBHAC FNFAKGKGAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
internal class HDAOKBFJBEN : INPGCFJJNFC, PLNGMBEJLHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly FBOAEPFOCDG EDCFGHOEAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private readonly JEGPFMALOAP PEMMOPHCPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private readonly List<DPHOJDFKMFJ> MKFJCIHGJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private NativeMultiHashMap<Entity, DBLNAIGHAJO> FNDDGIOPJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private NativeHashMap<int, int> ADMDCPNFGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private JobHandle FHKLIBNCGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private JobHandle DPMLFPCOIAC;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private World NMBJODMMPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x35D7450", Offset = "0x35D6050", VA = "0x1835D7450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private CLLGJDGBHAC MIPOPIGILCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x3349340", Offset = "0x3347F40", VA = "0x183349340", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private EFMCGLDCNFF NMFJFPKCEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x748100", Offset = "0x746D00", VA = "0x180748100", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NativeMultiHashMap<Entity, DBLNAIGHAJO> FDDDMHJJBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E2D50", VA = "0x1806E4150", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, DBLNAIGHAJO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JobHandle NLCDNEKOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x706EC0", Offset = "0x705AC0", VA = "0x180706EC0", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xC14360", Offset = "0xC12F60", VA = "0x180C14360", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private bool CDNGPCMCAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x35D7000", Offset = "0x35D5C00", VA = "0x1835D7000", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private World JOEELIAJNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x35D6EB0", Offset = "0x35D5AB0", VA = "0x1835D6EB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x35D79C0", Offset = "0x35D65C0", VA = "0x1835D79C0")]
	public HDAOKBFJBEN(FBOAEPFOCDG EDCFGHOEAKC, JEGPFMALOAP PEMMOPHCPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x35D6BF0", Offset = "0x35D57F0", VA = "0x1835D6BF0", Slot = "11")]
	private void AGCLBNMJPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x35D7710", Offset = "0x35D6310", VA = "0x1835D7710", Slot = "10")]
	private bool KBBFHGKPAGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x35D6F10", Offset = "0x35D5B10", VA = "0x1835D6F10", Slot = "12")]
	private void DMLJLEELMOM(ComponentType FDMNMHNCFEK, in DPHOJDFKMFJ CEEIDPKELAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x35D78F0", Offset = "0x35D64F0", VA = "0x1835D78F0", Slot = "13")]
	private bool NOOFLNPEIPA(KLHKIJHKJFB IBFKFNLEDKN, out Entity HLABNIGHLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x35D7920", Offset = "0x35D6520", VA = "0x1835D7920", Slot = "16")]
	private bool POIAGGOLKHG(out NativeArray<int> DLNFNCOODDK, Allocator JMMNDPMBMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x35D6C00", Offset = "0x35D5800", VA = "0x1835D6C00", Slot = "17")]
	private bool BENOIKPIKCB(ComponentType FDMNMHNCFEK, out DPHOJDFKMFJ IAFDEMBPEME, out OGKBIEFBAJI LONACBPNEFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x35D6D80", Offset = "0x35D5980", VA = "0x1835D6D80", Slot = "18")]
	private bool BENOIKPIKCB(ComponentType FDMNMHNCFEK, out DPHOJDFKMFJ IAFDEMBPEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x35D7800", Offset = "0x35D6400", VA = "0x1835D7800", Slot = "19")]
	private DPHOJDFKMFJ LKGMPALKIEP(ComponentType FDMNMHNCFEK)
	{
		return default(DPHOJDFKMFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x35D7160", Offset = "0x35D5D60", VA = "0x1835D7160", Slot = "20")]
	private BMBNENMHEAI GFICFOAOCAD()
	{
		return default(BMBNENMHEAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x35D74B0", Offset = "0x35D60B0", VA = "0x1835D74B0", Slot = "21")]
	private void INCFPOGIMAB(JobHandle HJBACIKDILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x35D71A0", Offset = "0x35D5DA0", VA = "0x1835D71A0")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x35D74F0", Offset = "0x35D60F0", VA = "0x1835D74F0")]
	private bool JODDLHLJHND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x35D7010", Offset = "0x35D5C10", VA = "0x1835D7010")]
	private int EONOKMBFEBK()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal class FBOAEPFOCDG : CPKJCKHOIEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public HOONHJLELFO GMKNLKMJIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public ObjectInstantiationService BCDJFKMHLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public CLLGJDGBHAC IIKEHPJNMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public EFMCGLDCNFF JAEJKEDBHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public CKIHFGJDFJO PDHHBLJFHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public bool JIGLPOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public World MFHAIABCKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x35D15E0", Offset = "0x35D01E0", VA = "0x1835D15E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public CLLGJDGBHAC FNFAKGKGAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public FBOAEPFOCDG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	[GKALNADHNEP(DAHLALKJFLL.PropertyChanges)]
	[HJBMNHLGPOF(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : BLCFKNFGJJJ, JGJNINBGNFN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		internal readonly struct DMJBJJDBPBJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private readonly JEGPFMALOAP LFGDPLDKHJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private readonly PropertyDiffStateService JKANGDEKCLI;

			[Cpp2IlInjected.Token(Token = "0x6000B98")]
			[Cpp2IlInjected.Address(RVA = "0x43A86E0", Offset = "0x43A72E0", VA = "0x1843A86E0")]
			public DMJBJJDBPBJ(PropertyDiffStateService JKANGDEKCLI, JEGPFMALOAP EALEBGNMGEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0x43A86C0", Offset = "0x43A72C0", VA = "0x1843A86C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private readonly FBOAEPFOCDG EDCFGHOEAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private readonly HDAOKBFJBEN[] JGHHLALIFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private JEGPFMALOAP MJFAKODNDOJ;

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public CPKJCKHOIEB ILJGMLCMOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public PLNGMBEJLHF DKCBPNFDFHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0x2389D70", Offset = "0x2388970", VA = "0x182389D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public INPGCFJJNFC OACJNEKNGKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0x2389D70", Offset = "0x2388970", VA = "0x182389D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0xCAAB00", Offset = "0xCA9700", VA = "0x180CAAB00")]
		public PLNGMBEJLHF OAIGPCGCCNK(JEGPFMALOAP PEMMOPHCPHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0xCAAB00", Offset = "0xCA9700", VA = "0x180CAAB00")]
		public INPGCFJJNFC ECEBNNPMBCC(JEGPFMALOAP PEMMOPHCPHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x30A26F0", Offset = "0x30A12F0", VA = "0x1830A26F0", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x30A2380", Offset = "0x30A0F80", VA = "0x1830A2380", Slot = "5")]
		public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x30A2790", Offset = "0x30A1390", VA = "0x1830A2790")]
		public void GGNFLDPHLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x30A2610", Offset = "0x30A1210", VA = "0x1830A2610", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x30A2770", Offset = "0x30A1370", VA = "0x1830A2770")]
		public DMJBJJDBPBJ GEDCMCIINGG(JEGPFMALOAP PEMMOPHCPHE)
		{
			return default(DMJBJJDBPBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x30A2840", Offset = "0x30A1440", VA = "0x1830A2840")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	[HJBMNHLGPOF(typeof(SceneService), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.HierarchySystems)]
	internal class SceneService : BLCFKNFGJJJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public static readonly SceneTag NONKOPOFNDK;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public const string OJIJDHKKFCM = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private const string PCJKKKAOJCB = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		[NNMLOJPMNKB]
		private HOONHJLELFO EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		[NNMLOJPMNKB]
		private GDJBNBLIMAN OFNAANAICLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		[NNMLOJPMNKB]
		private ObjectEmbodimentService NIENOEJANLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		[NNMLOJPMNKB]
		private OAAGFCMFOON ACKCFCFAEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		[NNMLOJPMNKB]
		private SingletonComponentService EFKLOFGEHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private EntityQuery KPDIBEFFIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private EntityQuery JCKGFBENGMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private EntityQuery CPLLOPBOHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private Entity JIJOMBGJPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private bool JIGLPOGPBPP;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public bool NHEPCFHMLAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9A")]
			[Cpp2IlInjected.Address(RVA = "0x33329A0", Offset = "0x33315A0", VA = "0x1833329A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NativeArray<Entity> HOAADHEGLAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0x706EA0", Offset = "0x705AA0", VA = "0x180706EA0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x22D9780", Offset = "0x22D8380", VA = "0x1822D9780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity CIHCPOMAGCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x3332190", Offset = "0x3330D90", VA = "0x183332190")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public SceneTag OODHBFAAACH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x3332080", Offset = "0x3330C80", VA = "0x183332080")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Entity NFDJLPAFKBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x3332080", Offset = "0x3330C80", VA = "0x183332080")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x3332A90", Offset = "0x3331690", VA = "0x183332A90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private EntityManager CNOHAEKAHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x33320D0", Offset = "0x3330CD0", VA = "0x1833320D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x33323D0", Offset = "0x3330FD0", VA = "0x1833323D0", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x3332150", Offset = "0x3330D50", VA = "0x183332150", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x33322E0", Offset = "0x3330EE0", VA = "0x1833322E0")]
		public void FAEECABAHDE(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x3332030", Offset = "0x3330C30", VA = "0x183332030")]
		public NativeArray<Entity> BJAGMOLLDIL(Allocator JMMNDPMBMFC = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x33324B0", Offset = "0x33310B0", VA = "0x1833324B0")]
		public void FEBBJOPJBDJ(Entity IPMKKEICEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x3332D90", Offset = "0x3331990", VA = "0x183332D90")]
		public Entity LBDPGDNNCLP(string MKPDFAEIFFO = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x3332B00", Offset = "0x3331700", VA = "0x183332B00")]
		public void IBOPANAMDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x3332060", Offset = "0x3330C60", VA = "0x183332060")]
		public void CCCDHLNHNDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x33338E0", Offset = "0x33324E0", VA = "0x1833338E0")]
		public void NNNNHGHLMGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x3332D00", Offset = "0x3331900", VA = "0x183332D00")]
		public void IKCNABFIBPD(Entity IPMKKEICEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x3333830", Offset = "0x3332430", VA = "0x183333830")]
		public bool NJIPJNMGOOI(Entity IPMKKEICEKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x3332120", Offset = "0x3330D20", VA = "0x183332120")]
		public void DGHCAGPOBNC(Entity IPMKKEICEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x3332740", Offset = "0x3331340", VA = "0x183332740")]
		public string FOFICEOPLKP(Entity IPMKKEICEKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public void COCFIBFPODE(Entity IPMKKEICEKI, string MKPDFAEIFFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x3332130", Offset = "0x3330D30", VA = "0x183332130")]
		public bool DJAGFPHGCOF(string MKPDFAEIFFO, out Entity IPMKKEICEKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x3331F20", Offset = "0x3330B20", VA = "0x183331F20")]
		public void BCNJEPMAKOB(Entity IPMKKEICEKI, bool AKCEPHCNGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x3332B20", Offset = "0x3331720", VA = "0x183332B20")]
		public void IDPBHDNINHH(Entity BODOHICDFAL, bool ELNKFODIMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x3332BA0", Offset = "0x33317A0", VA = "0x183332BA0")]
		public void IDPBHDNINHH(NativeArray<Entity> EADNCMDNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x3332C10", Offset = "0x3331810", VA = "0x183332C10")]
		public void IDPBHDNINHH(EntityQuery GJLGONPKKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x3332FC0", Offset = "0x3331BC0", VA = "0x183332FC0")]
		public void MIHBKCANJGN(Entity BODOHICDFAL, Entity IPMKKEICEKI, bool ELNKFODIMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x33332A0", Offset = "0x3331EA0", VA = "0x1833332A0")]
		public void MIHBKCANJGN(NativeArray<Entity> EADNCMDNEKI, Entity IPMKKEICEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x33331F0", Offset = "0x3331DF0", VA = "0x1833331F0")]
		public void MIHBKCANJGN(EntityQuery GJLGONPKKFL, Entity IPMKKEICEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x3332E10", Offset = "0x3331A10", VA = "0x183332E10")]
		private void LNFLAHLAFPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x3332D10", Offset = "0x3331910", VA = "0x183332D10")]
		private void IMBLGJEFNFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x3332190", Offset = "0x3330D90", VA = "0x183332190")]
		private Entity OJNPKHEGKDP()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x3332850", Offset = "0x3331450", VA = "0x183332850")]
		private void GBBINFMADIC(Entity IPMKKEICEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x3333480", Offset = "0x3332080", VA = "0x183333480")]
		private void MIMHJIHIEDA(EntityQuery JILKAJDOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x3333550", Offset = "0x3332150", VA = "0x183333550")]
		private void MIMHJIHIEDA(NativeArray<Entity> LJMHKNOAABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x3332320", Offset = "0x3330F20", VA = "0x183332320")]
		private void FAKHNLEKKEE(Entity IPMKKEICEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x33325B0", Offset = "0x33311B0", VA = "0x1833325B0")]
		private void FLGOMLCDNJA(Entity IPMKKEICEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x3332900", Offset = "0x3331500", VA = "0x183332900")]
		private void GLIGPDBGKFB(SceneTag INCLGPDOCJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x3332D40", Offset = "0x3331940", VA = "0x183332D40")]
		private void JDHPHGHBLJJ(SceneTag INCLGPDOCJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x33339A0", Offset = "0x33325A0", VA = "0x1833339A0")]
		private void POKKDCFLKDG(SceneTag INCLGPDOCJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x33329F0", Offset = "0x33315F0", VA = "0x1833329F0")]
		private void HFNDEPPCMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5EC0", Offset = "0x3CB4AC0", VA = "0x183CB5EC0")]
		private void BEHFLCIGAFC<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void LIGNOCKIJNC(SceneTag INCLGPDOCJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x3333940", Offset = "0x3332540", VA = "0x183333940")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void OMGEGCNBHMK(EntityQuery GJLGONPKKFL, string MKPDFAEIFFO, SceneTag INCLGPDOCJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x3332D60", Offset = "0x3331960", VA = "0x183332D60")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void JHGBKFNKJJA(Entity IPMKKEICEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void FCPHAJDGEIN(Entity IPMKKEICEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[HJBMNHLGPOF(typeof(CLKGEBGIDIH), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.HierarchySystems)]
	[IEBMFBANONN(EBEBOFNGILK.PhotonRoom)]
	internal class UnitySceneService : BLCFKNFGJJJ, CLKGEBGIDIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		[NNMLOJPMNKB]
		private HOONHJLELFO EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[NNMLOJPMNKB]
		private SceneService LJMHKNOAABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private readonly Dictionary<int, Entity> GIGLJGOHBJB;

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		private EntityManager CNOHAEKAHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCB")]
			[Cpp2IlInjected.Address(RVA = "0x33415E0", Offset = "0x33401E0", VA = "0x1833415E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x33417A0", Offset = "0x33403A0", VA = "0x1833417A0", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x3341630", Offset = "0x3340230", VA = "0x183341630", Slot = "5")]
		public void FAEECABAHDE(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x3341830", Offset = "0x3340430", VA = "0x183341830", Slot = "6")]
		public bool GMCGCCKIHAM(CGECBEAFDFK HGAMKJKNDDL, Transform IGPPDIMEFDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x3341A20", Offset = "0x3340620", VA = "0x183341A20")]
		private bool NHLNGGPEMHF(Scene IPMKKEICEKI, out Entity HANIBJFDDLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x3341A90", Offset = "0x3340690", VA = "0x183341A90")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[GKALNADHNEP(DAHLALKJFLL.ComponentSystemTypes)]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	[HJBMNHLGPOF(typeof(SingletonComponentService), new string[] { })]
	internal sealed class SingletonComponentService : BLCFKNFGJJJ, JGJNINBGNFN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		[NNMLOJPMNKB]
		private HOONHJLELFO EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		[NNMLOJPMNKB]
		private OAAGFCMFOON ACKCFCFAEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private Entity BODOHICDFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private LCDDHADEHJF MFLNELLNMCD;

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public int GEHHFJONLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0x33381A0", Offset = "0x3336DA0", VA = "0x1833381A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Entity CNGGBCAMAFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager CNOHAEKAHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x33381B0", Offset = "0x3336DB0", VA = "0x1833381B0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x3CB78C0", Offset = "0x3CB64C0", VA = "0x183CB78C0")]
		public T FABELHKIKFB<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x3CB77F0", Offset = "0x3CB63F0", VA = "0x183CB77F0")]
		public void CKBKODEFPCJ<T>(T NENFOEKGNGK) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x3338710", Offset = "0x3337310", VA = "0x183338710", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x3338200", Offset = "0x3336E00", VA = "0x183338200", Slot = "5")]
		public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x3338200", Offset = "0x3336E00", VA = "0x183338200")]
		private void MMMHAJKDEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x3338440", Offset = "0x3337040", VA = "0x183338440", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x3338780", Offset = "0x3337380", VA = "0x183338780")]
		private LCDDHADEHJF IJKILDBKPKM()
		{
			return default(LCDDHADEHJF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		private static void GIKBHPKMPKH(int GGKDNLHEHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		private static void JGPKFJCNPLJ(Type JMPEGNOKOOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x33383A0", Offset = "0x3336FA0", VA = "0x1833383A0")]
		private static void DIPOIKFGLJD(Type JMPEGNOKOOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001B9")]
internal struct KBKNEBBJDOD : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[HJBMNHLGPOF(typeof(GKAGBEJKMIF), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
internal sealed class GKAGBEJKMIF : BLCFKNFGJJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	[NNMLOJPMNKB]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private global::GHGBKHFBJNN<IGKHHBNOAFF, Entity> DLKOKCLGLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private global::KDBALECIHLC<JLLPNPJGKKD> KEGDMALALEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private global::KDBALECIHLC<HLDAAPPIDDB> HMGFPBKNOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private global::KDBALECIHLC<IAKAIECPJOA> KKOKGFABLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private global::KDBALECIHLC<BGNCDLNDLOI> FPGBFAACNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private global::KDBALECIHLC<LMGOPADFAFE> MDBFILFJAMO;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public global::NDFLGEHBCNM<Entity> FHAAONDDMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public INIILNIDGKG LMPMCELOPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public INIILNIDGKG NACMALOJCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public INIILNIDGKG EGBBJDJNKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public INIILNIDGKG GDIBNHEALJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x694E70", Offset = "0x693A70", VA = "0x180694E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public INIILNIDGKG OHHFFDBLCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x698150", Offset = "0x696D50", VA = "0x180698150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EntityManager CNOHAEKAHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x35D41E0", Offset = "0x35D2DE0", VA = "0x1835D41E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x35D4320", Offset = "0x35D2F20", VA = "0x1835D4320", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x35D4230", Offset = "0x35D2E30", VA = "0x1835D4230", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x373EE00", Offset = "0x373DA00", VA = "0x18373EE00")]
	private void OEKJIJPBJKA<T>(ref global::KDBALECIHLC<T> FHIGBPAOILI) where T : struct, PGKDDODDOMH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x373EE00", Offset = "0x373DA00", VA = "0x18373EE00")]
	private void OEKJIJPBJKA<TC, TV>(ref global::GHGBKHFBJNN<TC, TV> FHIGBPAOILI) where TC : struct, PGKDDODDOMH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public GKAGBEJKMIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[HJBMNHLGPOF(typeof(GHHDLKLILLB), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
internal sealed class GHHDLKLILLB : AHBNMIIEDML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private IPFANALALDA BAAELDOEDKA;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public IPFANALALDA JIILCEEBDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0xFF6920", Offset = "0xFF5520", VA = "0x180FF6920")]
		get
		{
			return default(IPFANALALDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x35D4150", Offset = "0x35D2D50", VA = "0x1835D4150", Slot = "4")]
	public void PHKHGJFAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x35D4140", Offset = "0x35D2D40", VA = "0x1835D4140", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public GHHDLKLILLB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	[HJBMNHLGPOF(typeof(TransformOwnershipPhase), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		public enum BCOMACJPLIF
		{
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		public struct ONNNDPJKGLP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private BCOMACJPLIF DMNMAHGKBCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private readonly TransformOwnershipPhase NIGFDFKEKGM;

			[Cpp2IlInjected.Token(Token = "0x6000BF8")]
			[Cpp2IlInjected.Address(RVA = "0x43B01E0", Offset = "0x43AEDE0", VA = "0x1843B01E0")]
			public ONNNDPJKGLP(TransformOwnershipPhase NIGFDFKEKGM, BCOMACJPLIF PEMMOPHCPHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x43B01C0", Offset = "0x43AEDC0", VA = "0x1843B01C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public BCOMACJPLIF PEMMOPHCPHE;

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public BCOMACJPLIF MGMCGGDBKIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF0")]
			[Cpp2IlInjected.Address(RVA = "0x678060", Offset = "0x676C60", VA = "0x180678060")]
			get
			{
				return default(BCOMACJPLIF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x7072B0", Offset = "0x705EB0", VA = "0x1807072B0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool GHBMCBCMFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0x112A490", Offset = "0x1129090", VA = "0x18112A490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool IFFBMKMKAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x1867E30", Offset = "0x1866A30", VA = "0x181867E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x333BD40", Offset = "0x333A940", VA = "0x18333BD40")]
		public ONNNDPJKGLP FLMPJEGICLA()
		{
			return default(ONNNDPJKGLP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x333BD70", Offset = "0x333A970", VA = "0x18333BD70")]
		public ONNNDPJKGLP NLECDCHIEHG()
		{
			return default(ONNNDPJKGLP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[HJBMNHLGPOF(typeof(LNFFKHFBNMG), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.Circuits)]
	public class CircuitsService : BLCFKNFGJJJ, LNFFKHFBNMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		[NNMLOJPMNKB]
		private AJOMKFKCJKI OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private EntityManager JOKFOKELNGA;

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x31A3D80", Offset = "0x31A2980", VA = "0x1831A3D80", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x31A42A0", Offset = "0x31A2EA0", VA = "0x1831A42A0", Slot = "5")]
		public bool KFDOGAGDPFE(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x31A39F0", Offset = "0x31A25F0", VA = "0x1831A39F0", Slot = "7")]
		public Guid COCDBOHALKO(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x31A3790", Offset = "0x31A2390", VA = "0x1831A3790", Slot = "8")]
		public void BHOBDNMLCEM(CGECBEAFDFK HGAMKJKNDDL, Guid AFGLICOMBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x31A3E20", Offset = "0x31A2A20", VA = "0x1831A3E20", Slot = "9")]
		public Guid HGHPLHKPAPG(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x31A3AC0", Offset = "0x31A26C0", VA = "0x1831A3AC0", Slot = "10")]
		public void DENMGDHABKL(CGECBEAFDFK HGAMKJKNDDL, Guid IANDBHNJFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x31A49A0", Offset = "0x31A35A0", VA = "0x1831A49A0", Slot = "11")]
		public bool OMLFGIEFENE(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x31A4930", Offset = "0x31A3530", VA = "0x1831A4930", Slot = "12")]
		public void OKKJDHHJFJE(CGECBEAFDFK HGAMKJKNDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x31A4570", Offset = "0x31A3170", VA = "0x1831A4570", Slot = "13")]
		public void OAPBLCHJJPF(CGECBEAFDFK GNFCHOKJPJE, CGECBEAFDFK NIGFDFKEKGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x31A4130", Offset = "0x31A2D30", VA = "0x1831A4130")]
		private void JKJEICJIKEE(BDAOJFBPJCL AHDKKHIHGGE, CGECBEAFDFK NIGFDFKEKGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x31A3FA0", Offset = "0x31A2BA0", VA = "0x1831A3FA0")]
		private void JCIKDCCGIKE(BDAOJFBPJCL AHDKKHIHGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x31A43A0", Offset = "0x31A2FA0", VA = "0x1831A43A0")]
		private bool MJJANMFDMLP(DABKEOMEIOA AOEMDAGAALP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x31A3EF0", Offset = "0x31A2AF0", VA = "0x1831A3EF0")]
		private bool ILOPHFAJPAB(DABKEOMEIOA AOEMDAGAALP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x31A3D20", Offset = "0x31A2920", VA = "0x1831A3D20", Slot = "6")]
		public bool EGLEMKHGNMB(CGECBEAFDFK EJOAECOFOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[GKALNADHNEP(DAHLALKJFLL.Connectables)]
	[HJBMNHLGPOF(typeof(BCNNFIFPIOL), new string[] { })]
	internal class ConnectableService : BCNNFIFPIOL, BLCFKNFGJJJ, JGJNINBGNFN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		[CompilerGenerated]
		private sealed class LDDIKNPFOKP : IEnumerable<CGECBEAFDFK>, IEnumerable, IEnumerator<CGECBEAFDFK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private CGECBEAFDFK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private CGECBEAFDFK localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public CGECBEAFDFK <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700015D")]
			private CGECBEAFDFK System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C30")]
				[Cpp2IlInjected.Address(RVA = "0x714C90", Offset = "0x713890", VA = "0x180714C90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(CGECBEAFDFK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C32")]
				[Cpp2IlInjected.Address(RVA = "0x332F3C0", Offset = "0x332DFC0", VA = "0x18332F3C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x714D30", Offset = "0x713930", VA = "0x180714D30")]
			[DebuggerHidden]
			public LDDIKNPFOKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x332F410", Offset = "0x332E010", VA = "0x18332F410", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x332EFD0", Offset = "0x332DBD0", VA = "0x18332EFD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x332F4E0", Offset = "0x332E0E0", VA = "0x18332F4E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x332F530", Offset = "0x332E130", VA = "0x18332F530")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x332F380", Offset = "0x332DF80", VA = "0x18332F380", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x332F2D0", Offset = "0x332DED0", VA = "0x18332F2D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CGECBEAFDFK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x332F2D0", Offset = "0x332DED0", VA = "0x18332F2D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private static readonly FCNKBCOKGMK NLJIHMBGDKE;

		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public const int JCKDAIMPGGG = 0;

		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public const int AEJBMICGNMP = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private IHMCHCLHMKB OBDKJOBOIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private HOONHJLELFO EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private OHGMKNKEOOJ OPBBALMJDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private PropertyEventCallbacksService LNOIJGAOPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private global::ILIGGOFIJKG<Entity> BFFALLJOOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private global::ILIGGOFIJKG<float3> OKGGLLIOLMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private global::ILIGGOFIJKG<quaternion> GHDGKDEPJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private global::ILIGGOFIJKG<Entity> NIGFDFKEKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private global::ILIGGOFIJKG<float3> LHHJFJDBODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private global::ILIGGOFIJKG<quaternion> EOGJNLADAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private HashSet<Entity> GPPIOPJNHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private HashSet<Entity> FCKJDFCLHPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private EntityQuery LAFACGKEAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private bool JIGLPOGPBPP;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public Func<DJEMEHPGIMI> ANNKBHJGHLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x6A0430", Offset = "0x69F030", VA = "0x1806A0430", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x6A05E0", Offset = "0x69F1E0", VA = "0x1806A05E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action<CGECBEAFDFK, CGECBEAFDFK> NHMIKBNCGCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x31A91A0", Offset = "0x31A7DA0", VA = "0x1831A91A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x31A9750", Offset = "0x31A8350", VA = "0x1831A9750", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<CGECBEAFDFK, CGECBEAFDFK> LJMIHNGANMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x31A9B30", Offset = "0x31A8730", VA = "0x1831A9B30", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x31A9610", Offset = "0x31A8210", VA = "0x1831A9610", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<CGECBEAFDFK, CGECBEAFDFK, CGECBEAFDFK> HMLODFGECPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x31A8750", Offset = "0x31A7350", VA = "0x1831A8750", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x31A89F0", Offset = "0x31A75F0", VA = "0x1831A89F0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<CGECBEAFDFK> MGOEHBDIHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x31A86B0", Offset = "0x31A72B0", VA = "0x1831A86B0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x31A96B0", Offset = "0x31A82B0", VA = "0x1831A96B0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x31A93F0", Offset = "0x31A7FF0", VA = "0x1831A93F0", Slot = "25")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x31A8D00", Offset = "0x31A7900", VA = "0x1831A8D00", Slot = "26")]
		public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x31A9240", Offset = "0x31A7E40", VA = "0x1831A9240", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x31AA430", Offset = "0x31A9030", VA = "0x1831AA430")]
		private void PMPFGLABKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x31A99C0", Offset = "0x31A85C0", VA = "0x1831A99C0")]
		private void KFAKDJADILB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x31AA000", Offset = "0x31A8C00", VA = "0x1831AA000")]
		private void NECFALCKKHM(Entity BODOHICDFAL, FOCFMDNOICJ FHMECPEDGNJ, ODIFAJLFLNC BNKKPEFEMPA, ODIFAJLFLNC AIGOLOAIBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x31AA250", Offset = "0x31A8E50", VA = "0x1831AA250")]
		private void ONICMFAGMGG(Entity BODOHICDFAL, FOCFMDNOICJ FHMECPEDGNJ, ODIFAJLFLNC BNKKPEFEMPA, ODIFAJLFLNC AIGOLOAIBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x261C1E0", Offset = "0x261ADE0", VA = "0x18261C1E0", Slot = "14")]
		public CGECBEAFDFK DLHMIKNHNGK(CGECBEAFDFK HGAMKJKNDDL, int KGOHLKHNGBL)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x1B5E3B0", Offset = "0x1B5CFB0", VA = "0x181B5E3B0", Slot = "15")]
		public Color MDGFICGKKJA(CGECBEAFDFK HGAMKJKNDDL, int KGOHLKHNGBL)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x31A8B20", Offset = "0x31A7720", VA = "0x1831A8B20", Slot = "16")]
		public float3 CBKILBLFJND(CGECBEAFDFK HGAMKJKNDDL, int KGOHLKHNGBL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x31A9BD0", Offset = "0x31A87D0", VA = "0x1831A9BD0", Slot = "17")]
		public bool LDMGPDJCBOJ(CGECBEAFDFK HGAMKJKNDDL, CGECBEAFDFK MIDFEACJGMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x31A87F0", Offset = "0x31A73F0", VA = "0x1831A87F0", Slot = "18")]
		public CGECBEAFDFK ADLACHOJICK(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x31A88A0", Offset = "0x31A74A0", VA = "0x1831A88A0", Slot = "21")]
		public void ALIANHOOMEM(CGECBEAFDFK HGAMKJKNDDL, Vector3 HHNFHBNNLLJ, Quaternion KKNMGDIFACJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x31A9570", Offset = "0x31A8170", VA = "0x1831A9570", Slot = "23")]
		public float3 FHMIMBAJFKF(HGOPGJANFPC CNBNMAEDENE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x31AA1C0", Offset = "0x31A8DC0", VA = "0x1831AA1C0", Slot = "24")]
		public quaternion ONAJFNMLOML(HGOPGJANFPC CNBNMAEDENE)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x31A9C80", Offset = "0x31A8880", VA = "0x1831A9C80", Slot = "28")]
		public RigidTransform MLGAMJFAEPF(HGOPGJANFPC CNBNMAEDENE)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x31AA2B0", Offset = "0x31A8EB0", VA = "0x1831AA2B0", Slot = "22")]
		public bool PCAJEPJPOGP(CGECBEAFDFK HGAMKJKNDDL, out RigidTransform GMAOCDJNAHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x31A8A90", Offset = "0x31A7690", VA = "0x1831A8A90", Slot = "19")]
		[IteratorStateMachine(typeof(LDDIKNPFOKP))]
		public IEnumerable<CGECBEAFDFK> BJGOCBEOHKN(CGECBEAFDFK HGAMKJKNDDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x31A9EA0", Offset = "0x31A8AA0", VA = "0x1831A9EA0", Slot = "20")]
		public CGECBEAFDFK NBIPFGMLIKL(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x31A97F0", Offset = "0x31A83F0", VA = "0x1831A97F0", Slot = "29")]
		public void KEFPKHKNGFE(ref List<CGECBEAFDFK> HFEFAFDMCBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x31A9D80", Offset = "0x31A8980", VA = "0x1831A9D80")]
		private Entity NBIPFGMLIKL(Entity BODOHICDFAL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x31AA520", Offset = "0x31A9120", VA = "0x1831AA520")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	[HJBMNHLGPOF(typeof(ObjectInstantiationService), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.Prefabs)]
	internal sealed class ObjectInstantiationService : BLCFKNFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		[NNMLOJPMNKB]
		private HOONHJLELFO EELLGOEIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		[NNMLOJPMNKB]
		private NBDICGGJILM LPLBLMAEOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		[NNMLOJPMNKB]
		private EHNMCNDHHBO JDBNEMIJADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		[NNMLOJPMNKB]
		private ObjectNetworkToLocalMapService GMAKJKHGELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		[NNMLOJPMNKB]
		private ObjectLifecycleService LPHFEOKHKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		[NNMLOJPMNKB]
		private ObjectPrefabs BCDJFKMHLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[NNMLOJPMNKB]
		private FPOKIFLFFKB AALJNFKPDCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private IABLEKNFLJJ FLNDCJKEOLK;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public int IEAMDKJNKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000C35")]
			[Cpp2IlInjected.Address(RVA = "0x30905C0", Offset = "0x308F1C0", VA = "0x1830905C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x3090610", Offset = "0x308F210", VA = "0x183090610", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x3090740", Offset = "0x308F340", VA = "0x183090740")]
		public Entity FNCJJJDBDFN(KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x3090560", Offset = "0x308F160", VA = "0x183090560")]
		public Entity EFHFPJLEEJK(KFMKFJINGPH AAEPEKAJNKI, KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x30904D0", Offset = "0x308F0D0", VA = "0x1830904D0")]
		public Entity DALGLOOJHAM(KLHKIJHKJFB IBFKFNLEDKN, bool KFDIKAODEFK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x3090520", Offset = "0x308F120", VA = "0x183090520")]
		public Entity DALGLOOJHAM(KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x3090880", Offset = "0x308F480", VA = "0x183090880")]
		public Entity JKLMHEPOIBM()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x3090970", Offset = "0x308F570", VA = "0x183090970")]
		public Entity OKPJCNHAAOH(IELMBOEFPKD JMPEGNOKOOB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x3090440", Offset = "0x308F040", VA = "0x183090440")]
		public Entity ANBHKNODMOE(KLCDDLDEKAP JMPEGNOKOOB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x30908C0", Offset = "0x308F4C0", VA = "0x1830908C0")]
		public NativeArray<(CGECBEAFDFK, CGECBEAFDFK)> MFDGEAABOHF(NativeArray<CGECBEAFDFK> EKNGCDBNDEG, Allocator JMMNDPMBMFC)
		{
			return default(NativeArray<(CGECBEAFDFK, CGECBEAFDFK)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x30903F0", Offset = "0x308EFF0", VA = "0x1830903F0")]
		public IEnumerable<KLHKIJHKJFB> AEIECOBANJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x3090390", Offset = "0x308EF90", VA = "0x183090390")]
		public EntityArchetype AAKOMKKBPIK(KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x3090910", Offset = "0x308F510", VA = "0x183090910")]
		public Entity NGJEDKFGNCI(KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x3090520", Offset = "0x308F120", VA = "0x183090520")]
		private Entity IBDAJBPPIED(KLHKIJHKJFB IBFKFNLEDKN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x30904D0", Offset = "0x308F0D0", VA = "0x1830904D0")]
		private Entity IBDAJBPPIED(KLHKIJHKJFB IBFKFNLEDKN, bool KFDIKAODEFK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x3090760", Offset = "0x308F360", VA = "0x183090760")]
		private Entity IBDAJBPPIED(KLHKIJHKJFB IBFKFNLEDKN, KFMKFJINGPH AAEPEKAJNKI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[GKALNADHNEP(DAHLALKJFLL.Physics)]
	[HJBMNHLGPOF(typeof(FICBCEGLJFC), new string[] { })]
	public sealed class PhysicsSceneColliderService : FICBCEGLJFC, OGINAGMEJGB, AHBNMIIEDML, BLCFKNFGJJJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private const string IJFALPNMIJC = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private const int PLMGJMAIMDA = -1;

		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private const int LMGIDLBJPKM = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		[NNMLOJPMNKB]
		private NFBIPKALIAH HOAFPJNBADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private Collider[] CDFGJDJLLMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private RaycastHit[] ELAAKLFMDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private global::FNIOGEGGNAD<LKIMDJNJKEE, BoxCollider> OLOHIDBDNGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private Scene IPMKKEICEKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private PhysicsScene OCOKILPIMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private GameObject HLABNIGHLFE;

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public int JKJBAAJCKEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x309C120", Offset = "0x309AD20", VA = "0x18309C120", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x309CE90", Offset = "0x309BA90", VA = "0x18309CE90", Slot = "9")]
		public void PHKHGJFAMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x309C010", Offset = "0x309AC10", VA = "0x18309C010", Slot = "10")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x309BEC0", Offset = "0x309AAC0", VA = "0x18309BEC0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x309BC90", Offset = "0x309A890", VA = "0x18309BC90", Slot = "4")]
		public LKIMDJNJKEE APCICKCDHFN(Entity BODOHICDFAL)
		{
			return default(LKIMDJNJKEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x309C470", Offset = "0x309B070", VA = "0x18309C470", Slot = "5")]
		public void HADPCADGKED(NativeArray<LKIMDJNJKEE> MIICOLKKHLK, NativeArray<DAMMKIPJFBC> ACMFNPPAOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x309C810", Offset = "0x309B410", VA = "0x18309C810", Slot = "6")]
		public void JIGHCDHPEPJ(LKIMDJNJKEE LBLAJOOMAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x309BDF0", Offset = "0x309A9F0", VA = "0x18309BDF0", Slot = "7")]
		public bool BHMFJMGPGNI(LKIMDJNJKEE LBLAJOOMAIC, out Collider DJJJIMGAJHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x309C160", Offset = "0x309AD60", VA = "0x18309C160")]
		public bool GNNMPGNKACK(in float3 DPAIPIEINKF, in float3 KBHFFJHBAKD, float IEGEAIOEFAA, Allocator JMMNDPMBMFC, out NativeArray<Entity> EADNCMDNEKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x309C0D0", Offset = "0x309ACD0", VA = "0x18309C0D0")]
		private void FLIBKLLLAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CF0", Offset = "0x6A08F0", VA = "0x1806A1CF0")]
		private void LFLLPKBPOOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x309BFC0", Offset = "0x309ABC0", VA = "0x18309BFC0")]
		private void EHJEJMBLCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x262B610", Offset = "0x262A210", VA = "0x18262B610")]
		private void NHJGBLKGEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x309CCF0", Offset = "0x309B8F0", VA = "0x18309CCF0")]
		private BoxCollider OLPOACBEPNB(Entity BODOHICDFAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x309C790", Offset = "0x309B390", VA = "0x18309C790")]
		private void JFMOKJFFDLG(BoxCollider FBAONBEOHOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x309CE10", Offset = "0x309BA10", VA = "0x18309CE10")]
		[Conditional("UNITY_EDITOR")]
		private void ONOEFBHBLGG(GameObject OKGHLJEDAEA, Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x309C8E0", Offset = "0x309B4E0", VA = "0x18309C8E0")]
		private void LGPNHMHEMKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x309C680", Offset = "0x309B280", VA = "0x18309C680")]
		private void HHKDLJAFFAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x309CAE0", Offset = "0x309B6E0", VA = "0x18309CAE0")]
		private void NHLNKDFECBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x309BE90", Offset = "0x309AA90", VA = "0x18309BE90")]
		private void DCKNMMMEAKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x309CAD0", Offset = "0x309B6D0", VA = "0x18309CAD0")]
		private void LHDABILDINH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x309CE50", Offset = "0x309BA50", VA = "0x18309CE50")]
		private void PAMAEDNLIID(Scene FEKMLIAAGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x309BDE0", Offset = "0x309A9E0", VA = "0x18309BDE0", Slot = "8")]
		private bool BBNLFALDEFF(in float3 DPAIPIEINKF, in float3 KBHFFJHBAKD, float IEGEAIOEFAA, Allocator JMMNDPMBMFC, out NativeArray<Entity> EADNCMDNEKI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[HJBMNHLGPOF(typeof(JKBPJAOBJFL), new string[] { })]
public sealed class CJGDGFGEIPE : JKBPJAOBJFL, BLCFKNFGJJJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	private struct HIJAAFDIPAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public float NMCJHFHBDED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public uint EDEMBAPNNBE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private OGINAGMEJGB CJCHFEMHNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private EAJJCHGGKEF JMLBLHIEFCC;

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x319FE20", Offset = "0x319EA20", VA = "0x18319FE20", Slot = "5")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x319FE90", Offset = "0x319EA90", VA = "0x18319FE90")]
	public bool GNNMPGNKACK(in float3 DPAIPIEINKF, in float3 KBHFFJHBAKD, float IEGEAIOEFAA, out FKJJIEMFDMH KFEGFNHHFJH, out Entity HPEMMCPLMCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x31A0340", Offset = "0x319EF40", VA = "0x1831A0340")]
	public static bool MAMIGMMDNFB(in Span<FKJJIEMFDMH> JLMKJIMLFHH, float IEGEAIOEFAA, out int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x31A0310", Offset = "0x319EF10", VA = "0x1831A0310")]
	public static float JLAFFNHGIMK(float NMCJHFHBDED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public CJGDGFGEIPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x319FE10", Offset = "0x319EA10", VA = "0x18319FE10", Slot = "4")]
	private bool DEEFMCMAMEO(in float3 DPAIPIEINKF, in float3 KBHFFJHBAKD, float IEGEAIOEFAA, out FKJJIEMFDMH KFEGFNHHFJH, out Entity HPEMMCPLMCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
[HJBMNHLGPOF(typeof(EAJJCHGGKEF), new string[] { })]
public sealed class EANPIHGFMEN : EAJJCHGGKEF, BLCFKNFGJJJ
{
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[BurstCompile]
	private struct LCHOMCDEIAI : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[ReadOnly]
		public NativeArray<Entity> EADNCMDNEKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[ReadOnly]
		public float3 HKDAKJNCBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[ReadOnly]
		public float3 DDBOPPEHLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> HGDJDJAFPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> PAKGDJOJGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> DNDOLEONONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> MECBKGGBALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> GCIECFPOJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		[WriteOnly]
		public NativeArray<FKJJIEMFDMH> MEEHHLLNOFN;

		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private static readonly FKJJIEMFDMH IAIHBCCBILP;

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x332DE70", Offset = "0x332CA70", VA = "0x18332DE70", Slot = "4")]
		public void Execute(int KLEGICPDLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x332EB40", Offset = "0x332D740", VA = "0x18332EB40")]
		private static float3 LGFLECJHAGM(in float4x4 IAKNPDHJEDA, in float3 NMDDPCLMDNL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x332DCB0", Offset = "0x332C8B0", VA = "0x18332DCB0")]
		private static float3 EGLGHFBKFNK(in float4x4 IAKNPDHJEDA, in float3 KIKJFLFODPG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x332EA40", Offset = "0x332D640", VA = "0x18332EA40")]
		private static float3 KEIIBBEDPJJ(in float4x4 IAKNPDHJEDA, in float3 NMDDPCLMDNL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x332E820", Offset = "0x332D420", VA = "0x18332E820")]
		private static float3 JNOKILIMIBM(in float4x4 IAKNPDHJEDA, in float3 KIKJFLFODPG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x332EC10", Offset = "0x332D810", VA = "0x18332EC10")]
		private bool OKEINEKEDJI(in float3 DPAIPIEINKF, in float3 KBHFFJHBAKD, in NativeArray<Entity> AKFEFKPGPEF, out float3 KFEGFNHHFJH, out float3 MPEEKKBPMPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x332E150", Offset = "0x332CD50", VA = "0x18332E150")]
		public static bool HOCLNMABOMN(in float3 PAJMHEDAECA, in float3 ENKCKEJCALA, in float3 GKOFNLCPJHG, in float3 PMHEHKKCALE, float LDPMMKPKJFO, float LMNNHNOAOFM, out float KKEIOLMHDBP, out float3 PAOKLGNMLPJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityManager JOKFOKELNGA;

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x31B3590", Offset = "0x31B2190", VA = "0x1831B3590", Slot = "5")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x31B3620", Offset = "0x31B2220", VA = "0x1831B3620")]
	public void GNNMPGNKACK(in NativeArray<Entity> EADNCMDNEKI, in float3 DPAIPIEINKF, in float3 KBHFFJHBAKD, in NativeArray<FKJJIEMFDMH> LEKJMHBMFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public EANPIHGFMEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x31B3610", Offset = "0x31B2210", VA = "0x1831B3610", Slot = "4")]
	private void FGPBKFJLMLP(in NativeArray<Entity> EADNCMDNEKI, in float3 DPAIPIEINKF, in float3 KBHFFJHBAKD, in NativeArray<FKJJIEMFDMH> LEKJMHBMFKA)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[HJBMNHLGPOF(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[GKALNADHNEP(DAHLALKJFLL.Embodiment)]
	[IEBMFBANONN(EBEBOFNGILK.OMRoom)]
	internal sealed class ObjectNetworkToLocalMapService : BLCFKNFGJJJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		[NNMLOJPMNKB]
		private HOONHJLELFO GMKNLKMJIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		[NNMLOJPMNKB]
		private NBDICGGJILM DGOOKONPICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		[NNMLOJPMNKB]
		private EHNMCNDHHBO ILBALNBJNAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private BKJKHIFBPPC MKDFNPEFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private NativeHashMap<KFMKFJINGPH, Entity> BEJGCKOEBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private EntityManager JOKFOKELNGA;

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		internal NativeHashMap<KFMKFJINGPH, Entity> EMBDOBPEFAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000C72")]
			[Cpp2IlInjected.Address(RVA = "0x994530", Offset = "0x993130", VA = "0x180994530")]
			get
			{
				return default(NativeHashMap<KFMKFJINGPH, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal uint DNJOFLLDDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x3093C70", Offset = "0x3092870", VA = "0x183093C70")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool EHAKBDFLKEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x6B9CF0", Offset = "0x6B88F0", VA = "0x1806B9CF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x6BA1E0", Offset = "0x6B8DE0", VA = "0x1806BA1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x3093690", Offset = "0x3092290", VA = "0x183093690", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x3093620", Offset = "0x3092220", VA = "0x183093620", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x30937B0", Offset = "0x30923B0", VA = "0x1830937B0")]
		public void GGNFLDPHLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x30938C0", Offset = "0x30924C0", VA = "0x1830938C0")]
		public void IBCFIOIFOGG(KFMKFJINGPH AAEPEKAJNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x3093A80", Offset = "0x3092680", VA = "0x183093A80")]
		private CGECBEAFDFK IEIMPFPGAIG(Entity BODOHICDFAL)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x3093CA0", Offset = "0x30928A0", VA = "0x183093CA0")]
		public CGECBEAFDFK OCFNCIECCMF(KFMKFJINGPH AAEPEKAJNKI)
		{
			return default(CGECBEAFDFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x3093B10", Offset = "0x3092710", VA = "0x183093B10")]
		public KFMKFJINGPH KOMMHBLAJKC(CGECBEAFDFK HGAMKJKNDDL)
		{
			return default(KFMKFJINGPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x3093830", Offset = "0x3092430", VA = "0x183093830")]
		public void GMGAIJFLBIF(Entity BODOHICDFAL, KFMKFJINGPH AAEPEKAJNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x3093AB0", Offset = "0x30926B0", VA = "0x183093AB0")]
		public void IJGHGOLJBLE(Entity BODOHICDFAL, KFMKFJINGPH AAEPEKAJNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x3093D80", Offset = "0x3092980", VA = "0x183093D80")]
		public void PFPJGLOLJLP(Entity BODOHICDFAL, KFMKFJINGPH AAEPEKAJNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x3093BA0", Offset = "0x30927A0", VA = "0x183093BA0")]
		public void KPNPHEADOHN(Entity BODOHICDFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[HJBMNHLGPOF(typeof(PropertyEventCallbacksService), new string[] { })]
	[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
	[GKALNADHNEP(DAHLALKJFLL.Callbacks)]
	public class PropertyEventCallbacksService : BLCFKNFGJJJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		private struct MIGFNPHNKEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public GAMKHBOBIPC JGLIBPMCCNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public Type JMPEGNOKOOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public int PJGFFECCBBF;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct FBIEBIOLNLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public MIGFNPHNKEL[] MBLNNIKAAIG;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CC")]
		public delegate void GAMKHBOBIPC(Entity BODOHICDFAL, FOCFMDNOICJ FHMECPEDGNJ, ODIFAJLFLNC BNKKPEFEMPA, ODIFAJLFLNC AIGOLOAIBCA);

		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private readonly Dictionary<FOCFMDNOICJ, GAMKHBOBIPC> PEAOHOCIPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private readonly Dictionary<int, FBIEBIOLNLM> HDABOIBEBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private IPPGPHBJPJM MBLNNIKAAIG;

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action LGDEDEEKOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C83")]
			[Cpp2IlInjected.Address(RVA = "0x30A2D80", Offset = "0x30A1980", VA = "0x1830A2D80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0x30A2A10", Offset = "0x30A1610", VA = "0x1830A2A10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action GIEDDLGKALN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x30A3580", Offset = "0x30A2180", VA = "0x1830A3580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x30A2970", Offset = "0x30A1570", VA = "0x1830A2970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x30A2AB0", Offset = "0x30A16B0", VA = "0x1830A2AB0", Slot = "4")]
		public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x30A28E0", Offset = "0x30A14E0", VA = "0x1830A28E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x30A3320", Offset = "0x30A1F20", VA = "0x1830A3320")]
		public void JHOMPJHMJJA(FOCFMDNOICJ FHMECPEDGNJ, GAMKHBOBIPC JGLIBPMCCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x30A3490", Offset = "0x30A2090", VA = "0x1830A3490")]
		public void KLOCLKBHMPP(FOCFMDNOICJ FHMECPEDGNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x30A2E20", Offset = "0x30A1A20", VA = "0x1830A2E20")]
		internal void HCKFAHKLNDN(PLNGMBEJLHF DBOAJCAFPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x30A3620", Offset = "0x30A2220", VA = "0x1830A3620")]
		private void NMPNLEPBIEM(PLNGMBEJLHF DBOAJCAFPEK, int FKPCJKABBEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x30A2B00", Offset = "0x30A1700", VA = "0x1830A2B00")]
		private void GDOKCBHNOGP(CFLHDMKEGPM PJBLNEEFIAM, HHFMDBGAKBP GJLJPGJACEP, MIGFNPHNKEL JNCOONBEANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x30A31A0", Offset = "0x30A1DA0", VA = "0x1830A31A0")]
		private FBIEBIOLNLM HOBIHDLDGII(CFLHDMKEGPM PJBLNEEFIAM, HHFMDBGAKBP GJLJPGJACEP)
		{
			return default(FBIEBIOLNLM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x30A30B0", Offset = "0x30A1CB0", VA = "0x1830A30B0")]
		private MIGFNPHNKEL HEKCGCEGHAP(FBIEBIOLNLM LONACBPNEFB, CFLHDMKEGPM PJBLNEEFIAM, HHFMDBGAKBP GJLJPGJACEP)
		{
			return default(MIGFNPHNKEL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x30A3BB0", Offset = "0x30A27B0", VA = "0x1830A3BB0")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[HJBMNHLGPOF(typeof(GPJLOKCOMGC), new string[] { })]
public class HHOJEAJMPCP : BLCFKNFGJJJ, JGJNINBGNFN, GPJLOKCOMGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[CompilerGenerated]
	private sealed class CEAFBIBGLFL : IEnumerable<CGECBEAFDFK>, IEnumerable, IEnumerator<CGECBEAFDFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private CGECBEAFDFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public HHOJEAJMPCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private CGECBEAFDFK splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public CGECBEAFDFK <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		private CGECBEAFDFK System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAD")]
			[Cpp2IlInjected.Address(RVA = "0x714C90", Offset = "0x713890", VA = "0x180714C90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CGECBEAFDFK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0x43A7550", Offset = "0x43A6150", VA = "0x1843A7550", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x714D30", Offset = "0x713930", VA = "0x180714D30")]
		[DebuggerHidden]
		public CEAFBIBGLFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x43A73A0", Offset = "0x43A5FA0", VA = "0x1843A73A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x43A7510", Offset = "0x43A6110", VA = "0x1843A7510", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x43A7460", Offset = "0x43A6060", VA = "0x1843A7460", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CGECBEAFDFK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x43A7460", Offset = "0x43A6060", VA = "0x1843A7460", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private BKJKHIFBPPC MKDFNPEFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private CILLAFEMMGK CPIBOLACKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private ObjectInstantiationService BCDJFKMHLLG;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private EntityManager CNOHAEKAHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x35D86C0", Offset = "0x35D72C0", VA = "0x1835D86C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private OAJACFAFCNG LALBODAPNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x35D96E0", Offset = "0x35D82E0", VA = "0x1835D96E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x35D8E00", Offset = "0x35D7A00", VA = "0x1835D8E00", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x35D8710", Offset = "0x35D7310", VA = "0x1835D8710", Slot = "5")]
	public void CGDNBGOOBLD(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x35D8BB0", Offset = "0x35D77B0", VA = "0x1835D8BB0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x35D8ED0", Offset = "0x35D7AD0", VA = "0x1835D8ED0")]
	private void HDEGJFGJLLP(Entity CGONCDEAMHB, in ODIFAJLFLNC CCOPHGFCELI, in ODIFAJLFLNC KCIMCONOGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x35D9240", Offset = "0x35D7E40", VA = "0x1835D9240", Slot = "14")]
	public CGECBEAFDFK JKLMHEPOIBM()
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x35D8600", Offset = "0x35D7200", VA = "0x1835D8600", Slot = "10")]
	public void AMFODAAGBII(CGECBEAFDFK HGAMKJKNDDL, MGBPPLNEBMH FPLMCNNAFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x35D9360", Offset = "0x35D7F60", VA = "0x1835D9360", Slot = "9")]
	public MGBPPLNEBMH KGKLMGNKCLF(CGECBEAFDFK HGAMKJKNDDL)
	{
		return default(MGBPPLNEBMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x35D8810", Offset = "0x35D7410", VA = "0x1835D8810", Slot = "11")]
	public CGECBEAFDFK CLPJHJOOJJE(CGECBEAFDFK LKNPALMCIDH, [Optional] Vector3? BBEHPKKOBDE, [Optional] Quaternion? IDIJNBAPGMK, [Optional] Vector3? CGDLHLIKGDL)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x35D8E90", Offset = "0x35D7A90", VA = "0x1835D8E90", Slot = "15")]
	public CGECBEAFDFK FMOHLJAGJEG(CGECBEAFDFK PEMJDJPBOIF, int KLEGICPDLIF, [Optional] Vector3? BBEHPKKOBDE, [Optional] Quaternion? IDIJNBAPGMK, [Optional] Vector3? CGDLHLIKGDL)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x35D9150", Offset = "0x35D7D50", VA = "0x1835D9150", Slot = "7")]
	public CGECBEAFDFK HJMPKDKJGOF(CGECBEAFDFK PEMJDJPBOIF, int KLEGICPDLIF)
	{
		return default(CGECBEAFDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x35D92A0", Offset = "0x35D7EA0", VA = "0x1835D92A0", Slot = "16")]
	public void KCJLPCEHKBP(CGECBEAFDFK PEMJDJPBOIF, CGECBEAFDFK IKBEJODAAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x35D8C60", Offset = "0x35D7860", VA = "0x1835D8C60", Slot = "12")]
	public void EOLHFOGGIPM(CGECBEAFDFK PEMJDJPBOIF, int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x35D94B0", Offset = "0x35D80B0", VA = "0x1835D94B0", Slot = "17")]
	public void LPLFLMGHKNP(CGECBEAFDFK PEMJDJPBOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x35D8B10", Offset = "0x35D7710", VA = "0x1835D8B10", Slot = "8")]
	public int DGCKLJHAJEM(CGECBEAFDFK PEMJDJPBOIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x35D9420", Offset = "0x35D8020", VA = "0x1835D9420", Slot = "6")]
	[IteratorStateMachine(typeof(CEAFBIBGLFL))]
	public IEnumerable<CGECBEAFDFK> LNONMHCKJCG(CGECBEAFDFK PEMJDJPBOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x35D9650", Offset = "0x35D8250", VA = "0x1835D9650")]
	private bool MEIGANHOOIE(CGECBEAFDFK PEMJDJPBOIF, out NativeArray<Entity> LBMPGEENEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x35D8540", Offset = "0x35D7140", VA = "0x1835D8540")]
	private NativeArray<Entity> AGKMJKOOJED(CGECBEAFDFK PEMJDJPBOIF)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public HHOJEAJMPCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[HJBMNHLGPOF(typeof(DCKKFGFBMIB), new string[] { })]
[IEBMFBANONN(EBEBOFNGILK.LoadInstance)]
internal sealed class DCKKFGFBMIB : BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private HOONHJLELFO EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private TransformOwnershipPhase EMBIDFBFENK;

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private DEDLBKJDALP JJBDOGEBBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x31AFFC0", Offset = "0x31AEBC0", VA = "0x1831AFFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x31AFF40", Offset = "0x31AEB40", VA = "0x1831AFF40", Slot = "4")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x31AFE50", Offset = "0x31AEA50", VA = "0x1831AFE50")]
	public void BKOCHMCPMHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x31AFB80", Offset = "0x31AE780", VA = "0x1831AFB80")]
	public void AKLCEOOMMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public DCKKFGFBMIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public readonly struct JIICLNEAJIF : IEquatable<JIICLNEAJIF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private readonly int FKPCJKABBEA;

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public Type JDLMMGPDBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x35E09C0", Offset = "0x35DF5C0", VA = "0x1835E09C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x35E0BA0", Offset = "0x35DF7A0", VA = "0x1835E0BA0")]
	public JIICLNEAJIF(Type JMPEGNOKOOB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x35E0B20", Offset = "0x35DF720", VA = "0x1835E0B20")]
	public static JIICLNEAJIF GGDPAIJEDCE(Type JMPEGNOKOOB)
	{
		return default(JIICLNEAJIF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x35E0B50", Offset = "0x35DF750", VA = "0x1835E0B50")]
	public static Type GGDPAIJEDCE(JIICLNEAJIF LBLAJOOMAIC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x716550", Offset = "0x715150", VA = "0x180716550")]
	public static bool HIPCOIHOPDI(JIICLNEAJIF APGJBFJMIBK, JIICLNEAJIF APLKEMLCGID)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x716550", Offset = "0x715150", VA = "0x180716550")]
	public static bool AMPJPPMBCJP(JIICLNEAJIF APGJBFJMIBK, JIICLNEAJIF APLKEMLCGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x716110", Offset = "0x714D10", VA = "0x180716110", Slot = "4")]
	public bool Equals(JIICLNEAJIF GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x35E0AA0", Offset = "0x35DF6A0", VA = "0x1835E0AA0", Slot = "0")]
	public override bool Equals(object AOEMDAGAALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CB0", Offset = "0x6D88B0", VA = "0x1806D9CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x35E0B70", Offset = "0x35DF770", VA = "0x1835E0B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public static class MNPBAOJLJKK
{
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private static Dictionary<Type, int> ADPGBJGPLBJ;

	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private static List<Type> ANDMALKCABP;

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x35EA430", Offset = "0x35E9030", VA = "0x1835EA430")]
	static MNPBAOJLJKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x3104000", Offset = "0x3102C00", VA = "0x183104000")]
	public static bool AABPNGPFBPJ<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x35EA0F0", Offset = "0x35E8CF0", VA = "0x1835EA0F0")]
	public static bool AABPNGPFBPJ(Type JMPEGNOKOOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x35E9F80", Offset = "0x35E8B80", VA = "0x1835E9F80")]
	private static bool AABPNGPFBPJ(Type JMPEGNOKOOB, out int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x3104090", Offset = "0x3102C90", VA = "0x183104090")]
	public static int CNKGCNPMHJF<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x35EA160", Offset = "0x35E8D60", VA = "0x1835EA160")]
	public static int CNKGCNPMHJF(Type JMPEGNOKOOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x3104120", Offset = "0x3102D20", VA = "0x183104120")]
	public static bool JIJNIMCPPHN<T>(out int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x35EA390", Offset = "0x35E8F90", VA = "0x1835EA390")]
	public static bool JIJNIMCPPHN(Type JMPEGNOKOOB, out int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x35EA1D0", Offset = "0x35E8DD0", VA = "0x1835EA1D0")]
	public static Type FABELHKIKFB(int KLEGICPDLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x35EA270", Offset = "0x35E8E70", VA = "0x1835EA270")]
	public static bool JIJNIMCPPHN(int KLEGICPDLIF, out Type JMPEGNOKOOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[DefaultMember("Item")]
public struct GMJECKJKGAB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private T[] GAGLKGONONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private int LNLAAEPHJPC;

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public int JGBMPNHDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x71A020", Offset = "0x718C20", VA = "0x18071A020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public T KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x33B4EC0", Offset = "0x33B3AC0", VA = "0x1833B4EC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> LAAHNALACLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x33B4F00", Offset = "0x33B3B00", VA = "0x1833B4F00")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool LLDLPKJFACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0x92F040", Offset = "0x92DC40", VA = "0x18092F040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x33B4FA0", Offset = "0x33B3BA0", VA = "0x1833B4FA0")]
	public GMJECKJKGAB(int LNLAAEPHJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x33B4E10", Offset = "0x33B3A10", VA = "0x1833B4E10")]
	public int GOBCNAPLMBL(T NENFOEKGNGK, int IOMMLLJBIGB, int GGKDNLHEHMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x33B4D50", Offset = "0x33B3950", VA = "0x1833B4D50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[DefaultMember("Item")]
public struct FHBCHKHADMD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private global::GMJECKJKGAB<T> GAGLKGONONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private int LNLAAEPHJPC;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0x3A02A10", Offset = "0x3A01610", VA = "0x183A02A10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int JGBMPNHDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x678060", Offset = "0x676C60", VA = "0x180678060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x3A01F30", Offset = "0x3A00B30", VA = "0x183A01F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public int IGIALMEDHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x3A01B50", Offset = "0x3A00750", VA = "0x183A01B50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x3A02380", Offset = "0x3A00F80", VA = "0x183A02380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool LLDLPKJFACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x3A02040", Offset = "0x3A00C40", VA = "0x183A02040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Span<T> LAAHNALACLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x3A02B10", Offset = "0x3A01710", VA = "0x183A02B10")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x3A031D0", Offset = "0x3A01DD0", VA = "0x183A031D0")]
	public FHBCHKHADMD(int LNLAAEPHJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x3A02FB0", Offset = "0x3A01BB0", VA = "0x183A02FB0")]
	public T OKECPHJJBMG(int KLEGICPDLIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x3A02AA0", Offset = "0x3A016A0", VA = "0x183A02AA0")]
	public void MKNPADHGFJH(T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x3A02DE0", Offset = "0x3A019E0", VA = "0x183A02DE0")]
	public void OGFOMIIDOND(Span<T> FOLHIKGIGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x3A01830", Offset = "0x3A00430", VA = "0x183A01830")]
	public void AABPNGPFBPJ(T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x3A02C60", Offset = "0x3A01860", VA = "0x183A02C60")]
	private void OFCOEGAGIIH(int KOHJKAOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x3A02430", Offset = "0x3A01030", VA = "0x183A02430")]
	public void IPAEIBMBLLJ(Span<T> IBDDKLPMGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x3A029B0", Offset = "0x3A015B0", VA = "0x183A029B0")]
	public void MHDMIHAEPGJ(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x3A01B80", Offset = "0x3A00780", VA = "0x183A01B80")]
	public void BCKMKFGEOJN(int OAHFHAFCNDN, int IEPBHGAJDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x3A02F50", Offset = "0x3A01B50", VA = "0x183A02F50")]
	public void OKDMEHCANKP(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x3A01940", Offset = "0x3A00540", VA = "0x183A01940")]
	public void AAMMGCPMAJF(int OAHFHAFCNDN, int IEPBHGAJDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x3A01F80", Offset = "0x3A00B80", VA = "0x183A01F80")]
	public void EKEIDCMIBAG(int KOHJKAOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x3A02230", Offset = "0x3A00E30", VA = "0x183A02230")]
	public void GKLGCFCEJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x3A022F0", Offset = "0x3A00EF0", VA = "0x183A022F0")]
	public int GOBCNAPLMBL(T NENFOEKGNGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x3A023D0", Offset = "0x3A00FD0", VA = "0x183A023D0")]
	public bool INBBKHIKIAC(T NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x3A01EE0", Offset = "0x3A00AE0", VA = "0x183A01EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x3A03160", Offset = "0x3A01D60", VA = "0x183A03160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x3A021C0", Offset = "0x3A00DC0", VA = "0x183A021C0")]
	public static Span<T> GGDPAIJEDCE(global::FHBCHKHADMD<T> FOLHIKGIGJA)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x3A02670", Offset = "0x3A01270", VA = "0x183A02670")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void KCFCLAMGDGE(int NENFOEKGNGK, int LNLAAEPHJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PCLDAFBJJLL(int LNLAAEPHJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x3A03000", Offset = "0x3A01C00", VA = "0x183A03000")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void PCLDAFBJJLL(int LNLAAEPHJPC, int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x3A01DA0", Offset = "0x3A009A0", VA = "0x183A01DA0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CJFNMKKNCGC(int NENFOEKGNGK, int LNLAAEPHJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x3A027B0", Offset = "0x3A013B0", VA = "0x183A027B0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void MABANGLAICJ(int OAHFHAFCNDN, int IEPBHGAJDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x3A02080", Offset = "0x3A00C80", VA = "0x183A02080")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private static void GFHBMNGEMPP(int NENFOEKGNGK, int LNLAAEPHJPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public struct IPFANALALDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private const int BGEOFHNBAEC = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private NativeList<Entity> EADNCMDNEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private TransformAccessArray OBDKJOBOIMH;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x35E00C0", Offset = "0x35DECC0", VA = "0x1835E00C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public NativeList<Entity> MNJPJPFNGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A20", Offset = "0x6A2620", VA = "0x1806A3A20")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public TransformAccessArray JHJLIMGLPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool EHAKBDFLKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x35E0270", Offset = "0x35DEE70", VA = "0x1835E0270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x35E02E0", Offset = "0x35DEEE0", VA = "0x1835E02E0")]
	public IPFANALALDA(int KOHJKAOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x35E00D0", Offset = "0x35DECD0", VA = "0x1835E00D0")]
	public Entity DJOEMLPNMCL(int KLEGICPDLIF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x35E01E0", Offset = "0x35DEDE0", VA = "0x1835E01E0")]
	public Transform MFIFGEHCCFE(int KLEGICPDLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x35E0290", Offset = "0x35DEE90", VA = "0x1835E0290")]
	public void ONHBAJDBLLO(int KOHJKAOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x35DFFF0", Offset = "0x35DEBF0", VA = "0x1835DFFF0")]
	public int AABPNGPFBPJ(Transform IGPPDIMEFDL, Entity BODOHICDFAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x35E01F0", Offset = "0x35DEDF0", VA = "0x1835E01F0")]
	public int MHDMIHAEPGJ(int KLEGICPDLIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x35E0120", Offset = "0x35DED20", VA = "0x1835E0120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x35E01A0", Offset = "0x35DEDA0", VA = "0x1835E01A0")]
	private void JMOAELKCMFD(int BGJFBNEJEJG = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
internal class KJMLBHLMHHI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private NativeHashMap<JIICLNEAJIF, int2> JAHDPIHECLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private NativeList<byte> MMDGIKEBLFM;

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x35E4520", Offset = "0x35E3120", VA = "0x1835E4520")]
	public KJMLBHLMHHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x35E44C0", Offset = "0x35E30C0", VA = "0x1835E44C0")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	public void CKBKODEFPCJ<T>(T NENFOEKGNGK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	public T FABELHKIKFB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x35E3CF0", Offset = "0x35E28F0", VA = "0x1835E3CF0")]
	public void CKBKODEFPCJ(Type JMPEGNOKOOB, ODIFAJLFLNC NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x35E4070", Offset = "0x35E2C70", VA = "0x1835E4070")]
	public ODIFAJLFLNC FABELHKIKFB(Type JMPEGNOKOOB)
	{
		return default(ODIFAJLFLNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x35E3F30", Offset = "0x35E2B30", VA = "0x1835E3F30")]
	private NativeArray<byte> DJCALOACCME(int2 IOHECBLGMAF)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x35E3FD0", Offset = "0x35E2BD0", VA = "0x1835E3FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x35E43A0", Offset = "0x35E2FA0", VA = "0x1835E43A0", Slot = "1")]
	~KJMLBHLMHHI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D6")]
public struct HDALIFCNIGL<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	internal static T FGHAAIAMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	public static global::HDALIFCNIGL<T> GGDPAIJEDCE(T NENFOEKGNGK)
	{
		return default(global::HDALIFCNIGL<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	public static T GGDPAIJEDCE(global::HDALIFCNIGL<T> DOOMMHJABHL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public static class FPPCNDAOLMF
{
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private static readonly KJMLBHLMHHI KAKJNCHKPCL;

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x35D3C40", Offset = "0x35D2840", VA = "0x1835D3C40")]
	internal static void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	public static void CKBKODEFPCJ<T>(T NENFOEKGNGK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x35D3B00", Offset = "0x35D2700", VA = "0x1835D3B00")]
	public static void CKBKODEFPCJ(Type JMPEGNOKOOB, ODIFAJLFLNC NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	public static T FABELHKIKFB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0x35D3BA0", Offset = "0x35D27A0", VA = "0x1835D3BA0")]
	public static ODIFAJLFLNC FABELHKIKFB(Type JMPEGNOKOOB)
	{
		return default(ODIFAJLFLNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public class DLOKHBPAFDH : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	public static readonly DLOKHBPAFDH DJCOHFHFNJC;

	[Cpp2IlInjected.Token(Token = "0x6000D0F")]
	[Cpp2IlInjected.Address(RVA = "0x31B1650", Offset = "0x31B0250", VA = "0x1831B1650", Slot = "4")]
	public bool Equals(LinkedEntityGroup CCOKEBDEHII, LinkedEntityGroup DEGPJNBMBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x31B1670", Offset = "0x31B0270", VA = "0x1831B1670", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup AOEMDAGAALP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public DLOKHBPAFDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal class PKFJHOEINCC
{
	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("DEBUG_BUILD")]
	public static void GOEEFCCMGCD(in Vector3 BBEHPKKOBDE, in Quaternion IDIJNBAPGMK, in Vector3 CGDLHLIKGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("DEBUG_BUILD")]
	public static void MEDABCAEAIP(in Vector3 AJHGOAIFEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("DEBUG_BUILD")]
	public static void BKJIKIMLMIC(in Quaternion IDIJNBAPGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("DEBUG_BUILD")]
	public static void BKLJFGLJACM(in Vector3 ELMHGMHEIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("DEBUG_BUILD")]
	public static void BDJHIIOILFJ(in Vector3 ELMHGMHEIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("DEBUG_BUILD")]
	public static void ABBFNJKLIEC(in float APLAAADNCNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x309AA70", Offset = "0x3099670", VA = "0x18309AA70")]
	[Conditional("DEBUG_BUILD")]
	public static void DLJGDFGAJCL(in float3 NENFOEKGNGK, string DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("DEBUG_BUILD")]
	public static void EIKIDOBMJEO(in float NENFOEKGNGK, string DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x309AB20", Offset = "0x3099720", VA = "0x18309AB20")]
	[Conditional("DEBUG_BUILD")]
	public static void EIKIDOBMJEO(in Vector3 NENFOEKGNGK, string DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x309AB70", Offset = "0x3099770", VA = "0x18309AB70")]
	[Conditional("DEBUG_BUILD")]
	public static void EIKIDOBMJEO(in Quaternion NENFOEKGNGK, string DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x309AC10", Offset = "0x3099810", VA = "0x18309AC10")]
	[Conditional("DEBUG_BUILD")]
	public static void LADJBBIPHMK(in float NENFOEKGNGK, string DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x309ABD0", Offset = "0x30997D0", VA = "0x18309ABD0")]
	[Conditional("DEBUG_BUILD")]
	public static void LADJBBIPHMK(in Vector3 NENFOEKGNGK, string DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x309ABA0", Offset = "0x30997A0", VA = "0x18309ABA0")]
	[Conditional("DEBUG_BUILD")]
	public static void LADJBBIPHMK(in Quaternion NENFOEKGNGK, string DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public PKFJHOEINCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public struct HACAPEBHNOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	public Entity BODOHICDFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	public Entity FIFCKAAEEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	public Entity FJCPKFBPJEK;

	[Cpp2IlInjected.Token(Token = "0x6000D21")]
	[Cpp2IlInjected.Address(RVA = "0x35D6700", Offset = "0x35D5300", VA = "0x1835D6700")]
	public HACAPEBHNOF(Entity BODOHICDFAL, Entity FIFCKAAEEOG, Entity FJCPKFBPJEK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x35D66C0", Offset = "0x35D52C0", VA = "0x1835D66C0")]
	public static HACAPEBHNOF GGDPAIJEDCE((Entity entity, Entity oldParent, Entity newParent) DMJHOCGLNDF)
	{
		return default(HACAPEBHNOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x35D66A0", Offset = "0x35D52A0", VA = "0x1835D66A0")]
	public void ECFLPLOIBIB(out Entity BODOHICDFAL, out Entity FIFCKAAEEOG, out Entity FJCPKFBPJEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public struct EHEJDJANAMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public Entity BODOHICDFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public Entity NIGFDFKEKGM;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x92F5C0", Offset = "0x92E1C0", VA = "0x18092F5C0")]
	public EHEJDJANAMP(Entity BODOHICDFAL, Entity NIGFDFKEKGM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0x31B4870", Offset = "0x31B3470", VA = "0x1831B4870")]
	public static EHEJDJANAMP GGDPAIJEDCE((Entity entity, Entity parent) DMJHOCGLNDF)
	{
		return default(EHEJDJANAMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x31B4860", Offset = "0x31B3460", VA = "0x1831B4860")]
	public void ECFLPLOIBIB(out Entity BODOHICDFAL, out Entity NIGFDFKEKGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
public struct OKEKGNBJMJC<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private GCHandle LBLAJOOMAIC;

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool INGJAPFBAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0x2FA1E30", Offset = "0x2FA0A30", VA = "0x182FA1E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public T FGHAAIAMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x2FA1E40", Offset = "0x2FA0A40", VA = "0x182FA1E40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA1D40", Offset = "0x2FA0940", VA = "0x182FA1D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1EE0", Offset = "0x2FA0AE0", VA = "0x182FA1EE0")]
	public OKEKGNBJMJC(T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1E00", Offset = "0x2FA0A00", VA = "0x182FA1E00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public enum ANHOPMHCAKD
{
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct KCPJFHKGPHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	public ANHOPMHCAKD MPPBIPBPONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	public int LJKBKIEKNPK;

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x702C80", Offset = "0x701880", VA = "0x180702C80")]
	public KCPJFHKGPHD(ANHOPMHCAKD MPPBIPBPONG, int LJKBKIEKNPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0x1481A90", Offset = "0x1480690", VA = "0x181481A90")]
	public static KCPJFHKGPHD GGDPAIJEDCE((ANHOPMHCAKD eventType, int eventIndex) CCOKEBDEHII)
	{
		return default(KCPJFHKGPHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x35E3600", Offset = "0x35E2200", VA = "0x1835E3600")]
	public void ECFLPLOIBIB(out ANHOPMHCAKD MPPBIPBPONG, out int LJKBKIEKNPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[HJBMNHLGPOF(typeof(OGINAGMEJGB), new string[] { })]
public sealed class FIPFPKNINOM : OGINAGMEJGB, BLCFKNFGJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private FICBCEGLJFC AFPEGMLCABP;

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x35D1E20", Offset = "0x35D0A20", VA = "0x1835D1E20", Slot = "5")]
	public void FDJBLAOPMBN(PJJBBDFFHDI FAEIDGPFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x35D1D30", Offset = "0x35D0930", VA = "0x1835D1D30")]
	public bool GNNMPGNKACK(in float3 DPAIPIEINKF, in float3 KBHFFJHBAKD, float IEGEAIOEFAA, Allocator JMMNDPMBMFC, out NativeArray<Entity> EADNCMDNEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public FIPFPKNINOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x35D1D30", Offset = "0x35D0930", VA = "0x1835D1D30", Slot = "4")]
	private bool BBNLFALDEFF(in float3 DPAIPIEINKF, in float3 KBHFFJHBAKD, float IEGEAIOEFAA, Allocator JMMNDPMBMFC, out NativeArray<Entity> EADNCMDNEKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[NIHNIOJKONF]
[UpdateInGroup(typeof(HGPPPNLMFMK))]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
internal sealed class FPJOCJHLCOA : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x35D2970", Offset = "0x35D1570", VA = "0x1835D2970", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public FPJOCJHLCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[NIHNIOJKONF]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
[UpdateInGroup(typeof(IHAINNAIACB))]
public sealed class EAHOMOLBHAF : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x31B3090", Offset = "0x31B1C90", VA = "0x1831B3090", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public EAHOMOLBHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[NIHNIOJKONF]
[UpdateInGroup(typeof(IJFIFDAPELI))]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
internal sealed class LCHAPAONHDI : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x35E5F10", Offset = "0x35E4B10", VA = "0x1835E5F10", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public LCHAPAONHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal class OOGJIFDFNNK : LPEKBLLHNJF
{
	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public OOGJIFDFNNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[ExecuteAlways]
[NIHNIOJKONF]
[HHHAKBKHMPJ(EBEBOFNGILK.LoadInstance)]
[UpdateInGroup(typeof(OHEDMFPCHNC))]
internal sealed class KADGOFEHHKM : GEPHOAAGCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x35E3520", Offset = "0x35E2120", VA = "0x1835E3520", Slot = "16")]
	protected override ComponentSystemBase PIDBAMCONIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083580", VA = "0x183084980")]
	public KADGOFEHHKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[CEBCBLLOONF(typeof(AuthoredLocalPoseData))]
public sealed class PKONEFNALKG : AGILOPMBNLH
{
	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x309AC20", Offset = "0x3099820", VA = "0x18309AC20", Slot = "8")]
	protected override bool GEMOCHBHCPJ(ReadOnlySpan<AuthoredLocalPoseData> IBDDKLPMGNI, GFBPCLDKMCE OBMKDNADDIP, out ReadOnlySpan<byte> PGJDMPEOAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x309ACA0", Offset = "0x30998A0", VA = "0x18309ACA0", Slot = "9")]
	protected override bool ILAPNIOHNJM(int OLOLCGEOMNE, Span<AuthoredLocalPoseData> IBDDKLPMGNI, in ReadOnlySpan<byte> PGJDMPEOAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0x309AD60", Offset = "0x3099960", VA = "0x18309AD60")]
	public PKONEFNALKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[CEBCBLLOONF(typeof(LocalPoseData))]
public sealed class EKMPPGAMMGM : INMGFCHEIGP
{
	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0x31B4EE0", Offset = "0x31B3AE0", VA = "0x1831B4EE0", Slot = "8")]
	protected override bool GEMOCHBHCPJ(ReadOnlySpan<LocalPoseData> IBDDKLPMGNI, GFBPCLDKMCE OBMKDNADDIP, out ReadOnlySpan<byte> PGJDMPEOAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0x31B4F60", Offset = "0x31B3B60", VA = "0x1831B4F60", Slot = "9")]
	protected override bool ILAPNIOHNJM(int OLOLCGEOMNE, Span<LocalPoseData> IBDDKLPMGNI, in ReadOnlySpan<byte> PGJDMPEOAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x31B5020", Offset = "0x31B3C20", VA = "0x1831B5020")]
	public EKMPPGAMMGM()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
	[Preserve]
	internal class _RRAssemblyIndex : BBLLDMGLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000D47")]
		[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x33494E0", Offset = "0x33480E0", VA = "0x1833494E0", Slot = "6")]
		public sealed override void AEKGKLFJGGK(FMHFAFGMDBB JGLIBPMCCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x334A480", Offset = "0x3349080", VA = "0x18334A480", Slot = "4")]
		public sealed override void LOFJJDLCKCK()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001E8")]
public class JKMMEKILHLE
{
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private static byte[] AGGHFJMNIJN;

	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private static int BFFGPOMCPJB;

	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static int MBPNPBCPPJJ;

	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private static BigInteger ELICCIFCIHI;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKMMEKILHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x35E1420", Offset = "0x35E0020", VA = "0x1835E1420")]
	private static string HIPMGELGEMF(byte[] APLKEMLCGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x35E1530", Offset = "0x35E0130", VA = "0x1835E1530")]
	public static string OIADEFGOGFH(byte[] FCLGIGIIKEH, bool ABEBLNADKAB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001E9")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001EA")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000D4E")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001EB")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
