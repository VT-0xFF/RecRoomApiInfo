using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Google.Protobuf;
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
[DefaultMember("Item")]
public sealed class JICIEADAEEG<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class HLHMMFCNNLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::JICIEADAEEG<T> EPPLHGFKCKC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] CFGJIEBBIFD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public HLHMMFCNNLP(global::JICIEADAEEG<T> EPPLHGFKCKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class DPIKOJAHHLD : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::JICIEADAEEG<T> <>4__this;

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
		public DPIKOJAHHLD(int <>1__state)
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
	private const int EOGBGJJGCFF = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> CFAJGPDKGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int EHAGDNLEACL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T LCCNHANCGAC
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
	private bool AEDNLGNMBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool GIHHDAGHNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool GLJJLALECLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DAKMKNJEHJJ
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
	public int NAIIACDHEPJ
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
	public JICIEADAEEG(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public JICIEADAEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void OANFOENKONO(int MJNAIOAAGCG, T BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void GEKNCFKGFNI(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] EIADJMKAIGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void OBCHJIKPBMK(NativeArray<T> NAJOFPKLJJG, int LEAMOGPCOIE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::JICIEADAEEG<>.DPIKOJAHHLD))]
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
	public int CHJPILKFEHL(T BCDFAIJCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool CEDMIKNCMLN(T BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void FOMINPGFCMC(int JACNCIPHIBD, int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void LKKPHGGOCAF(int JACNCIPHIBD, int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void LALDNBDMKCI(int JACNCIPHIBD, int FDGAPOLJFKN, int AEKEPEKODMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int EMKEKNKHBCG(int MJNAIOAAGCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T DHFDAEBHOCK(int MJNAIOAAGCG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void MNBPKAFNLKG(int MJNAIOAAGCG, T BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void FCMFIHNGBDG(int MJNAIOAAGCG, T BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void EJHKOJGAJPE(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int GLHAHCGOABN(int ADBNEBBHMOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int JKGJEOOAPOI(int ADBNEBBHMOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void FGOCJGIGDHH(T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void NNCOOGJDNOJ(T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T HLGFOPONELD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T AFHNLEOHFGI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void EGGOIMFNGBC(int MJNAIOAAGCG, IReadOnlyCollection<T> EJINPPBIFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void IKJHBFMNGIK(int MJNAIOAAGCG, int GNIHBJFNNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void AHNIBPKEFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void PIJIMINKKGF(T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void ICMJHIJGBNC(T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void GEEPGDEEPPC(int FDGAPOLJFKN, int AEKEPEKODMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T HCOPEJFFEBM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T AKIPDLFMFFI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[FJNEBDHFGAC]
public static class OBDEHGNNCFE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8846B0", Offset = "0x8838B0", VA = "0x1808846B0")]
	static OBDEHGNNCFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D5C250", Offset = "0x3D5B450", VA = "0x183D5C250")]
	public static void KKHKMDDMJOF<T>(T JGKODHNKDPL, ref T MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x884550", Offset = "0x883750", VA = "0x180884550")]
	public static void KKHKMDDMJOF(FixedString32 JGKODHNKDPL, ref string MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x884660", Offset = "0x883860", VA = "0x180884660")]
	public static void KKHKMDDMJOF(string JGKODHNKDPL, ref FixedString32 MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x884610", Offset = "0x883810", VA = "0x180884610")]
	public static void KKHKMDDMJOF(FixedString64 JGKODHNKDPL, ref string MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x884410", Offset = "0x883610", VA = "0x180884410")]
	public static void KKHKMDDMJOF(string JGKODHNKDPL, ref FixedString64 MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x767CB0", Offset = "0x766EB0", VA = "0x180767CB0")]
	public static void KKHKMDDMJOF(KAHAEKANHBH JGKODHNKDPL, ref Vector3 MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x884480", Offset = "0x883680", VA = "0x180884480")]
	public static void KKHKMDDMJOF(Vector3 JGKODHNKDPL, ref KAHAEKANHBH MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8843E0", Offset = "0x8835E0", VA = "0x1808843E0")]
	public static void KKHKMDDMJOF(KFBCLCGJAGP JGKODHNKDPL, ref Vector4 MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x884580", Offset = "0x883780", VA = "0x180884580")]
	public static void KKHKMDDMJOF(Vector4 JGKODHNKDPL, ref KFBCLCGJAGP MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8843E0", Offset = "0x8835E0", VA = "0x1808843E0")]
	public static void KKHKMDDMJOF(KFBCLCGJAGP JGKODHNKDPL, ref Quaternion MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x884580", Offset = "0x883780", VA = "0x180884580")]
	public static void KKHKMDDMJOF(Quaternion JGKODHNKDPL, ref KFBCLCGJAGP MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x884510", Offset = "0x883710", VA = "0x180884510")]
	public static void KKHKMDDMJOF(KAHAEKANHBH JGKODHNKDPL, ref float3 MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x884480", Offset = "0x883680", VA = "0x180884480")]
	public static void KKHKMDDMJOF(float3 JGKODHNKDPL, ref KAHAEKANHBH MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8843C0", Offset = "0x8835C0", VA = "0x1808843C0")]
	public static void KKHKMDDMJOF(KFBCLCGJAGP JGKODHNKDPL, ref float4 MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x884580", Offset = "0x883780", VA = "0x180884580")]
	public static void KKHKMDDMJOF(float4 JGKODHNKDPL, ref KFBCLCGJAGP MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8843C0", Offset = "0x8835C0", VA = "0x1808843C0")]
	public static void KKHKMDDMJOF(KFBCLCGJAGP JGKODHNKDPL, ref quaternion MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8844E0", Offset = "0x8836E0", VA = "0x1808844E0")]
	public static void KKHKMDDMJOF(quaternion JGKODHNKDPL, ref KFBCLCGJAGP MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8845D0", Offset = "0x8837D0", VA = "0x1808845D0")]
	public static void KKHKMDDMJOF(Entity JGKODHNKDPL, ref OLDCAIPDBBL MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x884640", Offset = "0x883840", VA = "0x180884640")]
	public static void KKHKMDDMJOF(OLDCAIPDBBL JGKODHNKDPL, ref Entity MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IBPGEALOLCI : KBFAPJDPNBI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int FJLKDHBMDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CIDFIAKDCLL GPDJBEAOMLE(Entity BBPBBOAPCHN);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKJFDAEDHEJ(NativeArray<CIDFIAKDCLL> DJEDGFAAOBH, NativeArray<IAFMNOCNMND> AKHPMMFMJMO);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NHNDKNCKGNI(CIDFIAKDCLL BEDKMKLJIGF);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KEDOCKKOJFK(CIDFIAKDCLL BEDKMKLJIGF, out Collider JGDOJJPMCOG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CMNCMGDNKIL]
public class MBOIBFMDJFF : ComponentSystem, GOKNGONBKFG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AMEKELGLMNH LKELHKMJNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD20", Offset = "0x5FCF20", VA = "0x1805FDD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public KHADGDCMOKK HIAJLBNENIF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6FD450", Offset = "0x6FC650", VA = "0x1806FD450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x880970", Offset = "0x87FB70", VA = "0x180880970", Slot = "14")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270")]
	public MBOIBFMDJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CreateAssetMenu]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xBE32F0", Offset = "0xBE24F0", VA = "0x180BE32F0")]
		public static ObjectModelConfigAsset IPDKOFAOECJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6A5230", Offset = "0x6A4430", VA = "0x1806A5230")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[EJLOOKEAJML(HNJEFABFMIP.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[EJLOOKEAJML(HNJEFABFMIP.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int LEDMJNCKCFB = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly MKIMOBFPILG GPGEBBCKNMO;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xBE6D50", Offset = "0xBE5F50", VA = "0x180BE6D50")]
			public static NJKBLCBBANC GNBEALIDBDA(int HCIAPKKBLDB)
			{
				return default(NJKBLCBBANC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xBE6B50", Offset = "0xBE5D50", VA = "0x180BE6B50")]
			public static int BNDJMFEDBEF(GameObject NEFMINHNLIG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xBE6CC0", Offset = "0xBE5EC0", VA = "0x180BE6CC0")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void DDBEENNFOOM(DHOEKPEGHDF LALFNHCEDJJ, int HCIAPKKBLDB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static EIFHKIDJKKE APJAHLFEOEM;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static OKCGOAGJMMI CMJMHAFJFIP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static EIFHKIDJKKE HOMAHBAKPBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xBE3CA0", Offset = "0xBE2EA0", VA = "0x180BE3CA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xBE3D00", Offset = "0xBE2F00", VA = "0x180BE3D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static OKCGOAGJMMI LDAEFFDAJIK
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xBE41F0", Offset = "0xBE33F0", VA = "0x180BE41F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xBE3B50", Offset = "0xBE2D50", VA = "0x180BE3B50")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool DEFFKDNCJGK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xBE4130", Offset = "0xBE3330", VA = "0x180BE4130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static KHADGDCMOKK HIAJLBNENIF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xBE3EA0", Offset = "0xBE30A0", VA = "0x180BE3EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static DCEFBILCIFI MGPOHCGAMLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xBE34B0", Offset = "0xBE26B0", VA = "0x180BE34B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static FLNKGJHGIEC MNNDBMMNPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xBE3DD0", Offset = "0xBE2FD0", VA = "0x180BE3DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static AEKECOGJAHN JBHNJEIAGDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xBE4880", Offset = "0xBE3A80", VA = "0x180BE4880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static JJIAEEMGEDG OIHMKLFPNPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xBE49C0", Offset = "0xBE3BC0", VA = "0x180BE49C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool LNDNLFFPGEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xBE3370", Offset = "0xBE2570", VA = "0x180BE3370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xBE4A90", Offset = "0xBE3C90", VA = "0x180BE4A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool DOJHAIMADAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xBE40D0", Offset = "0xBE32D0", VA = "0x180BE40D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xBE3AF0", Offset = "0xBE2CF0", VA = "0x180BE3AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool FGDAJCCKHGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xBE4070", Offset = "0xBE3270", VA = "0x180BE4070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xBE4010", Offset = "0xBE3210", VA = "0x180BE4010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action KIIKDNBKLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xBE3F10", Offset = "0xBE3110", VA = "0x180BE3F10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xBE4780", Offset = "0xBE3980", VA = "0x180BE4780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xBE4350", Offset = "0xBE3550", VA = "0x180BE4350")]
		public static DHOEKPEGHDF KCKNGDOKMAD(GameObject NEFMINHNLIG)
		{
			return default(DHOEKPEGHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xBE4950", Offset = "0xBE3B50", VA = "0x180BE4950")]
		public static NJKBLCBBANC MEDMAHADGEL(GameObject NEFMINHNLIG)
		{
			return default(NJKBLCBBANC);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xBE39E0", Offset = "0xBE2BE0", VA = "0x180BE39E0")]
		public static HOFMJBLAIFM DHJGLIBOAND(NJKBLCBBANC AGHJLKKAHGN)
		{
			return default(HOFMJBLAIFM);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xBE39A0", Offset = "0xBE2BA0", VA = "0x180BE39A0")]
		public static HOFMJBLAIFM DHJGLIBOAND(DHOEKPEGHDF LALFNHCEDJJ)
		{
			return default(HOFMJBLAIFM);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xBE45F0", Offset = "0xBE37F0", VA = "0x180BE45F0")]
		public static (ByteString, IDisposable) LIOPAMDCNLD()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xBE3810", Offset = "0xBE2A10", VA = "0x180BE3810")]
		public static (ByteString, IDisposable) DAOBCFKEAJJ(IEnumerable<DHOEKPEGHDF> EEENNBFJFEM)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBE4480", Offset = "0xBE3680", VA = "0x180BE4480")]
		public static bool LBGLMFPBAMI(GameObject NEFMINHNLIG, out NJKBLCBBANC AGHJLKKAHGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xBE3580", Offset = "0xBE2780", VA = "0x180BE3580")]
		public static bool CBGMHKPIBOC(GameObject NEFMINHNLIG, out bool IPDNJODDEML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xBE36F0", Offset = "0xBE28F0", VA = "0x180BE36F0")]
		private static OKCGOAGJMMI DAGAGHCLLLK()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DEGDGGPHMDI
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA4BC10", Offset = "0xA4AE10", VA = "0x180A4BC10")]
	public static IMGFAEJLICC NKCPCCNOLCN(GameObject NEFMINHNLIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA4BA30", Offset = "0xA4AC30", VA = "0x180A4BA30")]
	public static IMGFAEJLICC NKCPCCNOLCN(GameObject NEFMINHNLIG, NJKBLCBBANC AGHJLKKAHGN)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class DisembodiedObjectView : MonoBehaviour, BMAJFELCAFM
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public DHOEKPEGHDF GCCGFCADMDG
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7EA030", Offset = "0x7E9230", VA = "0x1807EA030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(DHOEKPEGHDF);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xBDD320", Offset = "0xBDC520", VA = "0x180BDD320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	[EJLOOKEAJML(HNJEFABFMIP.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, IMGFAEJLICC, BMAJFELCAFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string MEJPNDJIMKH = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DHOEKPEGHDF PLHHAHPCHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private JIKABAOMHKI IBBEGDPIJBO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public DHOEKPEGHDF GCCGFCADMDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x887460", Offset = "0x886660", VA = "0x180887460", Slot = "11")]
			get
			{
				return default(DHOEKPEGHDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public HOFMJBLAIFM ADOBJOBPANG
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xBDDFB0", Offset = "0xBDD1B0", VA = "0x180BDDFB0", Slot = "4")]
			get
			{
				return default(HOFMJBLAIFM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private KHADGDCMOKK HIAJLBNENIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xBDD910", Offset = "0xBDCB10", VA = "0x180BDD910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private BCEBIIAIFJH GHLDPLGNIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xBDD5F0", Offset = "0xBDC7F0", VA = "0x180BDD5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public JIKABAOMHKI IHCMFHDACEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7003C0", Offset = "0x6FF5C0", VA = "0x1807003C0", Slot = "5")]
			get
			{
				return default(JIKABAOMHKI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool FHIHKIHGDKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x94F170", Offset = "0x94E370", VA = "0x18094F170", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x94F660", Offset = "0x94E860", VA = "0x18094F660", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> DLGNFCLPFBO
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xBDDF10", Offset = "0xBDD110", VA = "0x180BDDF10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xBDDFE0", Offset = "0xBDD1E0", VA = "0x180BDDFE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xBDD520", Offset = "0xBDC720", VA = "0x180BDD520")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xBDDD00", Offset = "0xBDCF00", VA = "0x180BDDD00", Slot = "13")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xBDD960", Offset = "0xBDCB60", VA = "0x180BDD960", Slot = "14")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xBDDC70", Offset = "0xBDCE70", VA = "0x180BDDC70", Slot = "8")]
		public void OnEmbody(EGHMCKEACDK DDCODOIGKNL, DHOEKPEGHDF PLHHAHPCHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xBDDCF0", Offset = "0xBDCEF0", VA = "0x180BDDCF0", Slot = "9")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xBDDA20", Offset = "0xBDCC20", VA = "0x180BDDA20", Slot = "10")]
		public void OnDisembody(bool JCKPBKBOIPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xBDD670", Offset = "0xBDC870", VA = "0x180BDD670")]
		private void FCACNFHJCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBDDE00", Offset = "0xBDD000", VA = "0x180BDDE00")]
		private void PHMOJMIPLOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xBDD790", Offset = "0xBDC990", VA = "0x180BDD790")]
		private void HAILEFEAKJO(bool BMMLDLOEMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xBDD780", Offset = "0xBDC980", VA = "0x180BDD780", Slot = "7")]
		private GameObject FCBOKGNEKKG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	[EJLOOKEAJML(HNJEFABFMIP.Registration)]
	public sealed class TransformEntity : MonoBehaviour, BMAJFELCAFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private FNCBEEHJHBJ prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private DHOEKPEGHDF LALFNHCEDJJ;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public FNCBEEHJHBJ NKFFJJHMGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6FFD60", Offset = "0x6FEF60", VA = "0x1806FFD60")]
			get
			{
				return default(FNCBEEHJHBJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6FFD70", Offset = "0x6FEF70", VA = "0x1806FFD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public DHOEKPEGHDF GCCGFCADMDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x887460", Offset = "0x886660", VA = "0x180887460", Slot = "4")]
			get
			{
				return default(DHOEKPEGHDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal Entity EDLGLNELGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal AEKECOGJAHN JBHNJEIAGDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal BCEBIIAIFJH LKNCMBAGBHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x28094B0", Offset = "0x28086B0", VA = "0x1828094B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x28094A0", Offset = "0x28086A0", VA = "0x1828094A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2809790", Offset = "0x2808990", VA = "0x182809790")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2809520", Offset = "0x2808720", VA = "0x182809520")]
		internal void MGEPLKAAEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2809790", Offset = "0x2808990", VA = "0x182809790")]
		internal void PLGIPNAJDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2809890", Offset = "0x2808A90", VA = "0x182809890")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x28099B0", Offset = "0x2808BB0", VA = "0x1828099B0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Flags]
public enum AKPAMMCDJFE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	IncludeMock = 4,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	IncludeEditor = 8,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[CLDGIFMABHG(typeof(OKCGOAGJMMI), new string[] { })]
public class NBIMPJJEHJN : OKCGOAGJMMI, IDisposable, FFBEKOPNCCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public AMEKELGLMNH LKELHKMJNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public FCFLIDMJBKH JMGKCHFPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD20", Offset = "0x5FCF20", VA = "0x1805FDD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public KHADGDCMOKK HIAJLBNENIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FD450", Offset = "0x6FC650", VA = "0x1806FD450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool LNDNLFFPGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x882CE0", Offset = "0x881EE0", VA = "0x180882CE0", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8839D0", Offset = "0x882BD0", VA = "0x1808839D0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public KGMNECFLNCJ JKNHOPNADJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x82A170", Offset = "0x829370", VA = "0x18082A170", Slot = "15")]
		get
		{
			return default(KGMNECFLNCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x882DB0", Offset = "0x881FB0", VA = "0x180882DB0")]
	public static NBIMPJJEHJN CNOGLGNGFED(OBHBKHMMNEA NHJMFHJKDFP, AKPAMMCDJFE NKBIJCGCLBL = AKPAMMCDJFE.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8834E0", Offset = "0x8826E0", VA = "0x1808834E0")]
	private static void JLJPKDMNDFP(OBHBKHMMNEA NHJMFHJKDFP, AKPAMMCDJFE NKBIJCGCLBL = AKPAMMCDJFE.ExcludeIgnore)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x883030", Offset = "0x882230", VA = "0x180883030")]
	private static void FIKAMODMEGL(OBHBKHMMNEA NHJMFHJKDFP, AKPAMMCDJFE NKBIJCGCLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x883B60", Offset = "0x882D60", VA = "0x180883B60")]
	private static string[] PPIHFLPDMKJ(AKPAMMCDJFE NKBIJCGCLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8832C0", Offset = "0x8824C0", VA = "0x1808832C0")]
	private static bool INPCDBKCOIK(AKPAMMCDJFE NKBIJCGCLBL, out string[] MLNNCIKGGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x883AA0", Offset = "0x882CA0", VA = "0x180883AA0")]
	private static void PHIFHIIKGOK(OBHBKHMMNEA NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8838F0", Offset = "0x882AF0", VA = "0x1808838F0", Slot = "16")]
	public void OBKFACFEIOH(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8833F0", Offset = "0x8825F0", VA = "0x1808833F0")]
	private void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x882FB0", Offset = "0x8821B0", VA = "0x180882FB0")]
	private void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	private void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x882F20", Offset = "0x882120", VA = "0x180882F20", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x883810", Offset = "0x882A10", VA = "0x180883810", Slot = "19")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x883400", Offset = "0x882600", VA = "0x180883400", Slot = "9")]
	public void JIAPGMHHACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "10")]
	public void GFJGPAMPAGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x883880", Offset = "0x882A80", VA = "0x180883880", Slot = "11")]
	public void NPLPPPBABMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8835D0", Offset = "0x8827D0", VA = "0x1808835D0", Slot = "7")]
	public void LGPKACCHBHO(ByteString ADIGGFBANFM, GAHHNAEDOLN NKBIJCGCLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x883470", Offset = "0x882670", VA = "0x180883470", Slot = "8")]
	public void JLFHHPLFPKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x882D40", Offset = "0x881F40", VA = "0x180882D40", Slot = "12")]
	public void BFPALEJIJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8837A0", Offset = "0x8829A0", VA = "0x1808837A0", Slot = "13")]
	public void MBJBJCHFBCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8836C0", Offset = "0x8828C0", VA = "0x1808836C0", Slot = "20")]
	public ByteString LIOPAMDCNLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270")]
	private static bool HCKHAJIMCAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public NBIMPJJEHJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BFMGGJPPIHC
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0xA476A0", Offset = "0xA468A0", VA = "0x180A476A0")]
	public static HOFMJBLAIFM IMEOGHLKMDG(this OKCGOAGJMMI CMJMHAFJFIP, NJKBLCBBANC AGHJLKKAHGN, FNCBEEHJHBJ FKFNLDMHBOL)
	{
		return default(HOFMJBLAIFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xA475A0", Offset = "0xA467A0", VA = "0x180A475A0")]
	public static MLHPHNMBAKI AADDMFMNPIF(this OKCGOAGJMMI CMJMHAFJFIP)
	{
		return default(MLHPHNMBAKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0xA478D0", Offset = "0xA46AD0", VA = "0x180A478D0")]
	public static DHOEKPEGHDF KCKNGDOKMAD(this OKCGOAGJMMI CMJMHAFJFIP, Entity BBPBBOAPCHN)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xA477C0", Offset = "0xA469C0", VA = "0x180A477C0")]
	public static DHOEKPEGHDF KCKNGDOKMAD(this OKCGOAGJMMI CMJMHAFJFIP, NJKBLCBBANC AGHJLKKAHGN)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0xA47970", Offset = "0xA46B70", VA = "0x180A47970")]
	public static NJKBLCBBANC MEDMAHADGEL(this OKCGOAGJMMI CMJMHAFJFIP, DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(NJKBLCBBANC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public class NKCIMBEGPJE<T> : global::PGLODKBMLLF<T>, global::KGLFOOFGNAB<NJKBLCBBANC, T>, global::CPOMCONKGPO<NJKBLCBBANC>, OIIHFCKLEIL, IDisposable, EMOEMMBOEPM where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly global::CPOMCONKGPO<Entity> HJJHAMKLCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly AEKECOGJAHN JGHMLHPFFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Delegate BHGFCKJLFDA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string JPGOKIEGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1B2D250", Offset = "0x1B2C450", VA = "0x181B2D250", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Type IHACIPDHDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1B25F10", Offset = "0x1B25110", VA = "0x181B25F10", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public PCMBKAMCBOF CODPGIGHGNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1B27940", Offset = "0x1B26B40", VA = "0x181B27940", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int BBPFBPMLMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1B35F50", Offset = "0x1B35150", VA = "0x181B35F50", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JILFBNEMHIE AAKBFLCECDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1B2A150", Offset = "0x1B29350", VA = "0x181B2A150", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1B36700", Offset = "0x1B35900", VA = "0x181B36700", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1B30940", Offset = "0x1B2FB40", VA = "0x181B30940", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event global::PDJKGIHHHEB<NJKBLCBBANC> NBIOLONFICM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1B36DC0", Offset = "0x1B35FC0", VA = "0x181B36DC0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1B36FD0", Offset = "0x1B361D0", VA = "0x181B36FD0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x16B2420", Offset = "0x16B1620", VA = "0x1816B2420")]
	public NKCIMBEGPJE(global::CPOMCONKGPO<Entity> HJJHAMKLCMH, AEKECOGJAHN JGHMLHPFFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1B2B100", Offset = "0x1B2A300", VA = "0x181B2B100")]
	private Entity EPFIPEGMDAC(NJKBLCBBANC AGHJLKKAHGN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1B2AE80", Offset = "0x1B2A080", VA = "0x181B2AE80")]
	private NJKBLCBBANC EPFIPEGMDAC(Entity BBPBBOAPCHN)
	{
		return default(NJKBLCBBANC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1B2C640", Offset = "0x1B2B840", VA = "0x181B2C640", Slot = "4")]
	public T FCLOOBPJBAH(NJKBLCBBANC AGHJLKKAHGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1B26B10", Offset = "0x1B25D10", VA = "0x181B26B10")]
	public bool CEAJIHNFBDD(NJKBLCBBANC AGHJLKKAHGN, in T DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1B34110", Offset = "0x1B33310", VA = "0x181B34110")]
	public bool KAJFICDLPPF(NJKBLCBBANC AGHJLKKAHGN, in T DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1B37820", Offset = "0x1B36A20", VA = "0x181B37820", Slot = "9")]
	public bool PNGIIMFCLDE(NJKBLCBBANC AGHJLKKAHGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1B30C00", Offset = "0x1B2FE00", VA = "0x181B30C00", Slot = "26")]
	public object JKNKMDHONFK(NJKBLCBBANC AGHJLKKAHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1B35CE0", Offset = "0x1B34EE0", VA = "0x181B35CE0")]
	public bool LBEBDADCKPD(NJKBLCBBANC AGHJLKKAHGN, in object DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1B2B4F0", Offset = "0x1B2A6F0", VA = "0x181B2B4F0")]
	public void FCLOOBPJBAH(NJKBLCBBANC AGHJLKKAHGN, in AINJMIEKGCE ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1B26A00", Offset = "0x1B25C00", VA = "0x181B26A00")]
	public bool CEAJIHNFBDD(NJKBLCBBANC AGHJLKKAHGN, in JFFJOIBOPJP DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1B34640", Offset = "0x1B33840", VA = "0x181B34640")]
	public bool KAJFICDLPPF(NJKBLCBBANC AGHJLKKAHGN, in JFFJOIBOPJP DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x16AF560", Offset = "0x16AE760", VA = "0x1816AF560", Slot = "21")]
	public void GMDBEOJGGFF(ANMHEGLHELN KJFBEANHPKG, [Optional] object JAEDJGBMHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1B30580", Offset = "0x1B2F780", VA = "0x181B30580", Slot = "15")]
	public void GMDBEOJGGFF(NJKBLCBBANC JCNAPFOCJDI, CBKLOHJCAHA KJFBEANHPKG, object JAEDJGBMHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1B2A760", Offset = "0x1B29960", VA = "0x181B2A760", Slot = "14")]
	public bool DOKEOMHJJHM(NJKBLCBBANC MPKGKJLGAII, NJKBLCBBANC JGKODHNKDPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1B2AAE0", Offset = "0x1B29CE0", VA = "0x181B2AAE0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1B37DC0", Offset = "0x1B36FC0", VA = "0x181B37DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1B36270", Offset = "0x1B35470", VA = "0x181B36270")]
	public string MHAPOADFLDE(in JFFJOIBOPJP PMAGHKMNNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1B27F70", Offset = "0x1B27170", VA = "0x181B27F70")]
	private void CKAFNJLGNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1B29B70", Offset = "0x1B28D70", VA = "0x181B29B70")]
	private void COFFGAAOAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1B314B0", Offset = "0x1B306B0", VA = "0x181B314B0")]
	private void JMBEEFPAFEC(Entity BBPBBOAPCHN, in JFFJOIBOPJP OENCJDKHNKI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1B256D0", Offset = "0x1B248D0", VA = "0x181B256D0")]
	private void AABEDILFPCO(Entity BBPBBOAPCHN, in JFFJOIBOPJP OENCJDKHNKI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1B2E800", Offset = "0x1B2DA00", VA = "0x181B2E800")]
	[Conditional("DEBUG_BUILD")]
	private static void GJFLPFFMFPK(Entity BBPBBOAPCHN, NJKBLCBBANC AGHJLKKAHGN, string FFIIDDPMMKG, string JJPFDNHCOOL, [CallerMemberName] string GNOBKBOKFCF = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1B25BE0", Offset = "0x1B24DE0", VA = "0x181B25BE0", Slot = "5")]
	private bool ACBBPHEBHFK(NJKBLCBBANC JCNAPFOCJDI, in T DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1B366D0", Offset = "0x1B358D0", VA = "0x181B366D0", Slot = "6")]
	private bool MPOGHKFONMK(NJKBLCBBANC JCNAPFOCJDI, in T DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1B36810", Offset = "0x1B35A10", VA = "0x181B36810", Slot = "23")]
	private string ODNEPJGHNBI(in JFFJOIBOPJP ADBNEBBHMOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1B2D570", Offset = "0x1B2C770", VA = "0x181B2D570", Slot = "10")]
	private bool GFJCAIKDEOM(NJKBLCBBANC JCNAPFOCJDI, in object DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1B2AB10", Offset = "0x1B29D10", VA = "0x181B2AB10", Slot = "11")]
	private void EFLENDEJNCN(NJKBLCBBANC JCNAPFOCJDI, in AINJMIEKGCE ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1B308D0", Offset = "0x1B2FAD0", VA = "0x181B308D0", Slot = "12")]
	private bool GONOGDOOCHH(NJKBLCBBANC JCNAPFOCJDI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1B37760", Offset = "0x1B36960", VA = "0x181B37760", Slot = "13")]
	private bool PLOJCDBALHD(NJKBLCBBANC JCNAPFOCJDI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class ILGEPPKFGJF<T> : global::PHJAOEHKDAP<T>, global::KGLFOOFGNAB<DHOEKPEGHDF, T>, global::CPOMCONKGPO<DHOEKPEGHDF>, OIIHFCKLEIL, IDisposable, DDOCKAJKBGF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::CPOMCONKGPO<Entity> HJJHAMKLCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly AEKECOGJAHN JGHMLHPFFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate BHGFCKJLFDA;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string JPGOKIEGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x16AEDE0", Offset = "0x16ADFE0", VA = "0x1816AEDE0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type IHACIPDHDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x16AC170", Offset = "0x16AB370", VA = "0x1816AC170", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public PCMBKAMCBOF CODPGIGHGNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x16ACB10", Offset = "0x16ABD10", VA = "0x1816ACB10", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BBPFBPMLMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x16B17C0", Offset = "0x16B09C0", VA = "0x1816B17C0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public JILFBNEMHIE AAKBFLCECDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x16ADA50", Offset = "0x16ACC50", VA = "0x1816ADA50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x16B18B0", Offset = "0x16B0AB0", VA = "0x1816B18B0", Slot = "23")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x16AF590", Offset = "0x16AE790", VA = "0x1816AF590", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::PDJKGIHHHEB<DHOEKPEGHDF> NBIOLONFICM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x16B1A50", Offset = "0x16B0C50", VA = "0x1816B1A50", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x16B1D10", Offset = "0x16B0F10", VA = "0x1816B1D10", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x16B2420", Offset = "0x16B1620", VA = "0x1816B2420")]
	public ILGEPPKFGJF(global::CPOMCONKGPO<Entity> HJJHAMKLCMH, AEKECOGJAHN JGHMLHPFFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x16AE0A0", Offset = "0x16AD2A0", VA = "0x1816AE0A0")]
	private Entity EPFIPEGMDAC(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x16AE0B0", Offset = "0x16AD2B0", VA = "0x1816AE0B0")]
	private DHOEKPEGHDF EPFIPEGMDAC(Entity BBPBBOAPCHN)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x16AEA50", Offset = "0x16ADC50", VA = "0x1816AEA50", Slot = "4")]
	public T FCLOOBPJBAH(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x16AC4C0", Offset = "0x16AB6C0", VA = "0x1816AC4C0")]
	public bool CEAJIHNFBDD(DHOEKPEGHDF LALFNHCEDJJ, in T DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x16B07F0", Offset = "0x16AF9F0", VA = "0x1816B07F0")]
	public bool KAJFICDLPPF(DHOEKPEGHDF LALFNHCEDJJ, in T DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x16B2100", Offset = "0x16B1300", VA = "0x1816B2100", Slot = "9")]
	public bool PNGIIMFCLDE(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x16AF650", Offset = "0x16AE850", VA = "0x1816AF650", Slot = "25")]
	public object JKNKMDHONFK(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x16B0FA0", Offset = "0x16B01A0", VA = "0x1816B0FA0")]
	public bool LBEBDADCKPD(DHOEKPEGHDF LALFNHCEDJJ, in object DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x16AE420", Offset = "0x16AD620", VA = "0x1816AE420")]
	public void FCLOOBPJBAH(DHOEKPEGHDF LALFNHCEDJJ, in AINJMIEKGCE ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x16AC1D0", Offset = "0x16AB3D0", VA = "0x1816AC1D0")]
	public bool CEAJIHNFBDD(DHOEKPEGHDF LALFNHCEDJJ, in JFFJOIBOPJP DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x16B0C60", Offset = "0x16AFE60", VA = "0x1816B0C60")]
	public bool KAJFICDLPPF(DHOEKPEGHDF LALFNHCEDJJ, in JFFJOIBOPJP DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x16AF560", Offset = "0x16AE760", VA = "0x1816AF560", Slot = "21")]
	public void GMDBEOJGGFF(ANMHEGLHELN KJFBEANHPKG, [Optional] object JAEDJGBMHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x16AF1F0", Offset = "0x16AE3F0", VA = "0x1816AF1F0", Slot = "15")]
	public void GMDBEOJGGFF(DHOEKPEGHDF JCNAPFOCJDI, CBKLOHJCAHA KJFBEANHPKG, object JAEDJGBMHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x16ADBD0", Offset = "0x16ACDD0", VA = "0x1816ADBD0", Slot = "14")]
	public bool DOKEOMHJJHM(DHOEKPEGHDF MPKGKJLGAII, DHOEKPEGHDF JGKODHNKDPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x16ACE10", Offset = "0x16AC010", VA = "0x1816ACE10")]
	private void CKAFNJLGNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x16AD6D0", Offset = "0x16AC8D0", VA = "0x1816AD6D0")]
	private void COFFGAAOAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x16AF840", Offset = "0x16AEA40", VA = "0x1816AF840")]
	private void JMBEEFPAFEC(Entity BBPBBOAPCHN, in JFFJOIBOPJP OENCJDKHNKI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x16ABE70", Offset = "0x16AB070", VA = "0x1816ABE70")]
	private void AABEDILFPCO(Entity BBPBBOAPCHN, in JFFJOIBOPJP OENCJDKHNKI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x16ADFF0", Offset = "0x16AD1F0", VA = "0x1816ADFF0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x16B22E0", Offset = "0x16B14E0", VA = "0x1816B22E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x16AF5D0", Offset = "0x16AE7D0", VA = "0x1816AF5D0", Slot = "5")]
	private bool JJODCPIMAMI(DHOEKPEGHDF JCNAPFOCJDI, in T DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x16B1730", Offset = "0x16B0930", VA = "0x1816B1730", Slot = "6")]
	private bool LEKMEMIOEIP(DHOEKPEGHDF JCNAPFOCJDI, in T DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x16AE060", Offset = "0x16AD260", VA = "0x1816AE060", Slot = "10")]
	private bool ENNEKFDDJEE(DHOEKPEGHDF JCNAPFOCJDI, in object DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x16AE020", Offset = "0x16AD220", VA = "0x1816AE020", Slot = "11")]
	private void ENBMCKEMAAA(DHOEKPEGHDF JCNAPFOCJDI, in AINJMIEKGCE ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x16B0F60", Offset = "0x16B0160", VA = "0x1816B0F60", Slot = "12")]
	private bool KDDEICCLMEK(DHOEKPEGHDF JCNAPFOCJDI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x16ADB90", Offset = "0x16ACD90", VA = "0x1816ADB90", Slot = "13")]
	private bool DODEPEJKCOO(DHOEKPEGHDF JCNAPFOCJDI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KOCANCNOGKA : IDisposable, FCJNKFAIKGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> FOGIAJLHPPF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> APJBCKPEPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6FD290", Offset = "0x6FC490", VA = "0x1806FD290", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x858EA0", Offset = "0x8580A0", VA = "0x180858EA0")]
	public KOCANCNOGKA(NativeArray<EntityRemapUtility.EntityRemapInfo> FOGIAJLHPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x87EE80", Offset = "0x87E080", VA = "0x18087EE80", Slot = "6")]
	public DHOEKPEGHDF LPLEMHIKKLM(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0", Slot = "7")]
	public Entity LPLEMHIKKLM(Entity BBPBBOAPCHN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x87EDF0", Offset = "0x87DFF0", VA = "0x18087EDF0", Slot = "8")]
	public IEnumerable<DHOEKPEGHDF> LPLEMHIKKLM(IEnumerable<DHOEKPEGHDF> EEENNBFJFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x87ED90", Offset = "0x87DF90", VA = "0x18087ED90", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[EJLOOKEAJML(HNJEFABFMIP.Serialization, new string[] { "Remap" })]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string FKIPBFBIALB = "Remap";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly MKIMOBFPILG CBFCFMDOHHC;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int DOOGHAOBMED;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static FCJNKFAIKGM GIMMGJCHPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool NAHCKHOKPKF;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> APJBCKPEPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xBE82C0", Offset = "0xBE74C0", VA = "0x180BE82C0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static bool LOGLDKKHDGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xBE8230", Offset = "0xBE7430", VA = "0x180BE8230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xBE80D0", Offset = "0xBE72D0", VA = "0x180BE80D0")]
		public static SerializationRemapScope AFFGODJLPOL()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xBE86C0", Offset = "0xBE78C0", VA = "0x180BE86C0")]
		public SerializationRemapScope(FCJNKFAIKGM EJHDMGMBLJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xBE8130", Offset = "0xBE7330", VA = "0x180BE8130", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xBE84F0", Offset = "0xBE76F0", VA = "0x180BE84F0")]
		public static DHOEKPEGHDF LPLEMHIKKLM(DHOEKPEGHDF LALFNHCEDJJ)
		{
			return default(DHOEKPEGHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xBE83C0", Offset = "0xBE75C0", VA = "0x180BE83C0")]
		public static Entity LPLEMHIKKLM(Entity BBPBBOAPCHN)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CLDGIFMABHG(typeof(JJIAEEMGEDG), new string[] { })]
public class KAAOMFMPGCD : JJIAEEMGEDG, PMOCCIAIAEL, GFHKHHPFFGF, GOKNGONBKFG, AIOPJLICFNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private AEKECOGJAHN JGHMLHPFFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityHierarchyParents CGJDIOIHEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityHierarchyChildren DKJCFPOBMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private FGPFJCJFGIL KIOLEKBJBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private ObjectEmbodimentService MBMBGCPJPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::PHJAOEHKDAP<DHOEKPEGHDF> KBODKBKLNME
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF50", Offset = "0x5FA150", VA = "0x1805FAF50", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF60", Offset = "0x5FA160", VA = "0x1805FAF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x878B00", Offset = "0x877D00", VA = "0x180878B00", Slot = "13")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x878760", Offset = "0x877960", VA = "0x180878760", Slot = "14")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8785B0", Offset = "0x8777B0", VA = "0x1808785B0", Slot = "15")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x878D40", Offset = "0x877F40", VA = "0x180878D40")]
	private DHOEKPEGHDF OBEDPFJEGGF(Entity BBPBBOAPCHN)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8789C0", Offset = "0x877BC0", VA = "0x1808789C0", Slot = "18")]
	public DHOEKPEGHDF ICNAANBPLFG(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x878D70", Offset = "0x877F70", VA = "0x180878D70", Slot = "19")]
	public void OICBMCNPMOB(ref List<DHOEKPEGHDF> KEOBIBPKNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x878A60", Offset = "0x877C60", VA = "0x180878A60", Slot = "20")]
	public IEnumerable<DHOEKPEGHDF> JEGGPJGBBHI(DHOEKPEGHDF LALFNHCEDJJ, bool BNLLAFMBMBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x878860", Offset = "0x877A60", VA = "0x180878860", Slot = "21")]
	public DHOEKPEGHDF HBLIKENLLJI(DHOEKPEGHDF LALFNHCEDJJ, int MJNAIOAAGCG)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x878B10", Offset = "0x877D10", VA = "0x180878B10", Slot = "22")]
	public int JHGLADMAJKG(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x878830", Offset = "0x877A30", VA = "0x180878830", Slot = "7")]
	public int GPDJPDFLPPN(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x877710", VA = "0x180878510", Slot = "8")]
	public PHMKDAHEPPC BHCNIMGAEOI(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(PHMKDAHEPPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8786C0", Offset = "0x8778C0", VA = "0x1808786C0", Slot = "23")]
	public IEnumerable<DHOEKPEGHDF> EBHGCDPNOFK(DHOEKPEGHDF LALFNHCEDJJ, bool BNLLAFMBMBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x8788D0", Offset = "0x877AD0", VA = "0x1808788D0", Slot = "11")]
	public DHOEKPEGHDF HCALPBDFPDF(DHOEKPEGHDF NDAHKJDCMHN, DHOEKPEGHDF HDCGKEELIMP)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x878C30", Offset = "0x877E30", VA = "0x180878C30", Slot = "12")]
	public bool JNJEOIADFEB(DHOEKPEGHDF NDAHKJDCMHN, DHOEKPEGHDF HDCGKEELIMP, out DHOEKPEGHDF CICDHHCPFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x878BC0", Offset = "0x877DC0", VA = "0x180878BC0", Slot = "4")]
	public DHOEKPEGHDF JIPNBHNLIBO(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x878A30", Offset = "0x877C30", VA = "0x180878A30", Slot = "10")]
	public bool IHHDFCDACMB(DHOEKPEGHDF LALFNHCEDJJ, DHOEKPEGHDF KIENEBDMBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x878580", Offset = "0x877780", VA = "0x180878580", Slot = "24")]
	public bool BHPOJEHMCDF(DHOEKPEGHDF LALFNHCEDJJ, DHOEKPEGHDF MEFCJLOHDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x878D10", Offset = "0x877F10", VA = "0x180878D10", Slot = "9")]
	public bool LPJCHEENNME(DHOEKPEGHDF LALFNHCEDJJ, DHOEKPEGHDF NDAHKJDCMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x878680", Offset = "0x877880", VA = "0x180878680", Slot = "5")]
	public bool DPLBOKBAOAN(DHOEKPEGHDF LALFNHCEDJJ, DHOEKPEGHDF ENAGHEEPLJN, bool IGFOOKFBPDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x878F10", Offset = "0x878110", VA = "0x180878F10", Slot = "6")]
	public bool OOCBEJCPAJA(DHOEKPEGHDF LALFNHCEDJJ, DHOEKPEGHDF ENAGHEEPLJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8786B0", Offset = "0x8778B0", VA = "0x1808786B0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public KAAOMFMPGCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class FCBOBMFMIOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeList<CDPFCBNHAID> KOKIDLHDAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private NativeList<BNPOJNEDCOI> KJLDKFLBGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private NativeList<CDPFCBNHAID> BNICMLPPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeList<CDPFCBNHAID> PINOHGCFHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6FD290", Offset = "0x6FC490", VA = "0x1806FD290")]
		get
		{
			return default(NativeList<CDPFCBNHAID>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeList<BNPOJNEDCOI> FOODJIDIGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x887460", Offset = "0x886660", VA = "0x180887460")]
		get
		{
			return default(NativeList<BNPOJNEDCOI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeList<CDPFCBNHAID> DKLHMLBIBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x96F1A0", Offset = "0x96E3A0", VA = "0x18096F1A0")]
		get
		{
			return default(NativeList<CDPFCBNHAID>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool OEAJGIGPLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7B0", Offset = "0xA4E9B0", VA = "0x180A4F7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0xA4FA20", Offset = "0xA4EC20", VA = "0x180A4FA20")]
	public FCBOBMFMIOB(Allocator MKFODJKMOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xA4F9C0", Offset = "0xA4EBC0", VA = "0x180A4F9C0")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0xA4F710", Offset = "0xA4E910", VA = "0x180A4F710")]
	public void DIPAICNNLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0xA4F830", Offset = "0xA4EA30", VA = "0x180A4F830")]
	public void KAGEPJABGKM(Entity BBPBBOAPCHN, Entity GDGMBLIDIJF, Entity NHDMOENBBDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[CLDGIFMABHG(typeof(EMAMLPGAPJK), new string[] { })]
[OCLKOGGMIFL(typeof(FJGGKJJCIJE))]
internal class EMAMLPGAPJK : GOKNGONBKFG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly Dictionary<int, FCBOBMFMIOB> DFOBAJBIJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private NMIMFDNKLJP GLODAFJJDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private FJGGKJJCIJE OMFFMMHBAGP;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xA4F1A0", Offset = "0xA4E3A0", VA = "0x180A4F1A0", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0xA4F450", Offset = "0xA4E650", VA = "0x180A4F450")]
	public FCBOBMFMIOB IIOCBGOMKDC(CFNMCCFLIFF FFIIDDPMMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xA4F260", Offset = "0xA4E460", VA = "0x180A4F260")]
	public FCBOBMFMIOB IIOCBGOMKDC(CAEHPHOEGJK FMBNLFNGBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA4F530", Offset = "0xA4E730", VA = "0x180A4F530")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0xA4EF80", Offset = "0xA4E180", VA = "0x180A4EF80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xA4F6A0", Offset = "0xA4E8A0", VA = "0x180A4F6A0")]
	public EMAMLPGAPJK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[EJLOOKEAJML(HNJEFABFMIP.History)]
	[DebuggerTypeProxy(typeof(BLDIEOFJEHI))]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		internal class BLDIEOFJEHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private readonly ActionBuffer MNCACBMIHMI;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public int NAIIACDHEPJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000155")]
				[Cpp2IlInjected.Address(RVA = "0xBD6800", Offset = "0xBD5A00", VA = "0x180BD6800")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public HMJMIONIPOH[] EODCAIDAMAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0xBD6930", Offset = "0xBD5B30", VA = "0x180BD6930")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x6270A0", Offset = "0x6262A0", VA = "0x1806270A0")]
			public BLDIEOFJEHI(ActionBuffer IFPHMKPBLKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xBD6850", Offset = "0xBD5A50", VA = "0x180BD6850")]
			[CompilerGenerated]
			private HMJMIONIPOH IBDJHONCGCO(GEEEOLNDMJA GHCLFMPOHGP)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal class HMJMIONIPOH : ANMHEGLHELN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private readonly ActionBuffer MNCACBMIHMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private readonly GEEEOLNDMJA GHCLFMPOHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private List<(FDIPDPOMECM, string, object)> NJJAOFJGDIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private KPEDBOGCHII NCACJOJKKJP;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public int NAIIACDHEPJ
			{
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xBDF5D0", Offset = "0xBDE7D0", VA = "0x180BDF5D0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public List<(FDIPDPOMECM, string, object)> NDPEKCLGLIE
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xBDF9F0", Offset = "0xBDEBF0", VA = "0x180BDF9F0")]
			public HMJMIONIPOH(ActionBuffer IFPHMKPBLKJ, GEEEOLNDMJA GHCLFMPOHGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xBDF620", Offset = "0xBDE820", VA = "0x180BDF620")]
			private string CMHHOPJGCAK(FDIPDPOMECM DMEAKEHDCBC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xBDF710", Offset = "0xBDE910", VA = "0x180BDF710")]
			private void KPGMNJIIOMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x3B267C0", Offset = "0x3B259C0", VA = "0x183B267C0", Slot = "4")]
			public void GEAAJEBIOIN<TKey, T>(global::KGLFOOFGNAB<TKey, T> HJJHAMKLCMH, [Optional] object JAEDJGBMHAP) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private NativeList<byte> JGHBFLJAGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Stack<GEEEOLNDMJA> OHLEMMHLBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly FLCJCAOIHCN CBPGAIKOEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly HNNIDMNOAIJ DKCMPFLCCIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly LIODBHBOIBI OMFFMMHBAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly bool JJHONGBGAIE;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public LICJMGOOOBB EGCCHNLJPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xBD56C0", Offset = "0xBD48C0", VA = "0x180BD56C0")]
			get
			{
				return default(LICJMGOOOBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int NAIIACDHEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xBD53A0", Offset = "0xBD45A0", VA = "0x180BD53A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xBD5E60", Offset = "0xBD5060", VA = "0x180BD5E60")]
		public ActionBuffer(HNNIDMNOAIJ DKCMPFLCCIP, LIODBHBOIBI OMFFMMHBAGP, bool JJHONGBGAIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xBD5BF0", Offset = "0xBD4DF0", VA = "0x180BD5BF0")]
		public bool PGPMBPOOGGI(out GEEEOLNDMJA GHCLFMPOHGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xBD5780", Offset = "0xBD4980", VA = "0x180BD5780")]
		public void NLALCDJNEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xBD5C80", Offset = "0xBD4E80", VA = "0x180BD5C80")]
		public GEEEOLNDMJA PKEAPKLOMGP(GLBGFFGHFDF NJJAOFJGDIP, OLINELLNIIG OGDHIEJGLOE, uint CGAJEKLIFNJ)
		{
			return default(GEEEOLNDMJA);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xBD5DE0", Offset = "0xBD4FE0", VA = "0x180BD5DE0")]
		public bool POOOKMFCKKE(uint CGAJEKLIFNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xBD5440", Offset = "0xBD4640", VA = "0x180BD5440")]
		public bool EJKFLFIBPOL(uint CGAJEKLIFNJ, out GEEEOLNDMJA MLNFOFCNKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xBD57E0", Offset = "0xBD49E0", VA = "0x180BD57E0")]
		public void ODPBMIELFPF(GEEEOLNDMJA MLNFOFCNKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xBD5260", Offset = "0xBD4460", VA = "0x180BD5260")]
		[Conditional("DEBUG_BUILD")]
		private void BMIOCNEGKAJ(GEEEOLNDMJA MLNFOFCNKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xBD5700", Offset = "0xBD4900", VA = "0x180BD5700")]
		private void LJPOIMMBKGE(GEEEOLNDMJA AGIHIPEMHFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xBD5940", Offset = "0xBD4B40", VA = "0x180BD5940")]
		private void OGBEAKAPMGD(KPEDBOGCHII IGBKMGFILBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xBD5B90", Offset = "0xBD4D90", VA = "0x180BD5B90")]
		private void PCLLHHAHDBD(GEEEOLNDMJA GHCLFMPOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xBD5600", Offset = "0xBD4800", VA = "0x180BD5600")]
		private KPEDBOGCHII GGPOBMCBBNC(GEEEOLNDMJA GHCLFMPOHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xBD53E0", Offset = "0xBD45E0", VA = "0x180BD53E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class FLCJCAOIHCN : ANMHEGLHELN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly HNNIDMNOAIJ DKCMPFLCCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly LIODBHBOIBI OMFFMMHBAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NJKBLCBBANC PLHHAHPCHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private KPEDBOGCHII FKGKBGFPBDE;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7FC900", Offset = "0x7FBB00", VA = "0x1807FC900")]
	public FLCJCAOIHCN(HNNIDMNOAIJ DKCMPFLCCIP, LIODBHBOIBI OMFFMMHBAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x45540E0", Offset = "0x45532E0", VA = "0x1845540E0", Slot = "4")]
	public void GEAAJEBIOIN<TKey, T>(global::KGLFOOFGNAB<TKey, T> NHNAHJMIKGP, [Optional] object JAEDJGBMHAP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0xA513D0", Offset = "0xA505D0", VA = "0x180A513D0")]
	public void GMDBEOJGGFF(FDIPDPOMECM DMEAKEHDCBC, ref KPEDBOGCHII IGBKMGFILBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MFIMPIBNBNO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct HGOPKMBINOO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly MFIMPIBNBNO ENAGHEEPLJN;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x873E80", Offset = "0x873080", VA = "0x180873E80")]
		public HGOPKMBINOO(MFIMPIBNBNO ENAGHEEPLJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x873D80", Offset = "0x872F80", VA = "0x180873D80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected GLBGFFGHFDF NJJAOFJGDIP;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GLBGFFGHFDF NDPEKCLGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8811F0", Offset = "0x8803F0", VA = "0x1808811F0")]
		get
		{
			return default(GLBGFFGHFDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool PAJJCFIDAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x880E10", Offset = "0x880010", VA = "0x180880E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x881230", Offset = "0x880430", VA = "0x180881230")]
	public MFIMPIBNBNO(GLBGFFGHFDF.FAEECPDMIFI IKENLIKKGKF = GLBGFFGHFDF.FAEECPDMIFI.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8810F0", Offset = "0x8802F0", VA = "0x1808810F0")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x880E30", Offset = "0x880030", VA = "0x180880E30")]
	public void FNNCFOFKCAK(NJKBLCBBANC PLHHAHPCHBA, EMKICLFMFKI JGEBAMPIEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x880D50", Offset = "0x87FF50", VA = "0x180880D50")]
	public void BDMHDIPCKLP(NJKBLCBBANC PLHHAHPCHBA, CAEHPHOEGJK FMBNLFNGBEI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x881010", Offset = "0x880210", VA = "0x180881010")]
	public void LIDJCODGNGF(NJKBLCBBANC PLHHAHPCHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x880F20", Offset = "0x880120", VA = "0x180880F20")]
	public void GDBNCDMFDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x881100", Offset = "0x880300", VA = "0x180881100")]
	public void NNILMCILDOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x880E20", Offset = "0x880020", VA = "0x180880E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x880DE0", Offset = "0x87FFE0", VA = "0x180880DE0")]
	public HGOPKMBINOO BMDNNOGKOIF()
	{
		return default(HGOPKMBINOO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FDIPDPOMECM : IComparable<FDIPDPOMECM>, IEquatable<FDIPDPOMECM>
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly FDIPDPOMECM LEDMJNCKCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NJKBLCBBANC PLHHAHPCHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public CAEHPHOEGJK FMBNLFNGBEI;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool MJFCPIFHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA4FE80", Offset = "0xA4F080", VA = "0x180A4FE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x884C10", Offset = "0x883E10", VA = "0x180884C10")]
	public FDIPDPOMECM(NJKBLCBBANC PLHHAHPCHBA, CAEHPHOEGJK FMBNLFNGBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0xA4FC70", Offset = "0xA4EE70", VA = "0x180A4FC70")]
	public void AAKDIPDDIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xA4FC80", Offset = "0xA4EE80", VA = "0x180A4FC80", Slot = "4")]
	public int CompareTo(FDIPDPOMECM GHOINNFPLDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xA4FE90", Offset = "0xA4F090", VA = "0x180A4FE90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA4FD10", Offset = "0xA4EF10", VA = "0x180A4FD10", Slot = "0")]
	public override bool Equals(object PBKPNJLDBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0xA4FCC0", Offset = "0xA4EEC0", VA = "0x180A4FCC0", Slot = "5")]
	public bool Equals(FDIPDPOMECM GHOINNFPLDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0xA4FE40", Offset = "0xA4F040", VA = "0x180A4FE40")]
	public static bool OBFGCGKAGJG(FDIPDPOMECM DHAMHGONHGF, FDIPDPOMECM ODBGDMOKIMO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0xA4FDF0", Offset = "0xA4EFF0", VA = "0x180A4FDF0")]
	public static bool IHGNJAHCODI(FDIPDPOMECM DHAMHGONHGF, FDIPDPOMECM ODBGDMOKIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0xA4FDB0", Offset = "0xA4EFB0", VA = "0x180A4FDB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KPICHBJHLDP : CBKLOHJCAHA
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private HNNIDMNOAIJ DKCMPFLCCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NJKBLCBBANC PLHHAHPCHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private KACJNGIFHBO GDGMLNGFBFE;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x87F3E0", Offset = "0x87E5E0", VA = "0x18087F3E0")]
	public void FONGEIGKHPA(NJKBLCBBANC PLHHAHPCHBA, HNNIDMNOAIJ DKCMPFLCCIP, KACJNGIFHBO GDGMLNGFBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x87F4F0", Offset = "0x87E6F0", VA = "0x18087F4F0", Slot = "4")]
	private void LPIJGGGNEFO(OIIHFCKLEIL HJJHAMKLCMH, in JFFJOIBOPJP ADBNEBBHMOP, object JAEDJGBMHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public KPICHBJHLDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class KPOJNPDMFFJ
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x87FB80", Offset = "0x87ED80", VA = "0x18087FB80")]
	public static void DMBKFMPEHJO(GLBGFFGHFDF NJJAOFJGDIP, FDIPDPOMECM DMEAKEHDCBC, EMKICLFMFKI JGEBAMPIEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x87FA90", Offset = "0x87EC90", VA = "0x18087FA90")]
	public static void DCBOLNAAJOK(GLBGFFGHFDF NJJAOFJGDIP, FDIPDPOMECM DMEAKEHDCBC, in JFFJOIBOPJP DNIHHNBJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x87FD40", Offset = "0x87EF40", VA = "0x18087FD40")]
	public static void LAAPAEDDDHF(GLBGFFGHFDF NJJAOFJGDIP, FDIPDPOMECM DMEAKEHDCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x87F9C0", Offset = "0x87EBC0", VA = "0x18087F9C0")]
	public static void CGGNAPNNJNC(GLBGFFGHFDF NJJAOFJGDIP, FDIPDPOMECM DMEAKEHDCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x87FCA0", Offset = "0x87EEA0", VA = "0x18087FCA0")]
	public static EMKICLFMFKI INHLMFCINFL(GLBGFFGHFDF NJJAOFJGDIP, FDIPDPOMECM DMEAKEHDCBC)
	{
		return default(EMKICLFMFKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x387E600", Offset = "0x387D800", VA = "0x18387E600")]
	public static T OEOBLGGFKMB<T>(GLBGFFGHFDF NJJAOFJGDIP, FDIPDPOMECM DMEAKEHDCBC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x387E570", Offset = "0x387D770", VA = "0x18387E570")]
	public static T OEOBLGGFKMB<T>(ref KPEDBOGCHII ADIGGFBANFM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x87FCF0", Offset = "0x87EEF0", VA = "0x18087FCF0")]
	public static EMKICLFMFKI INHLMFCINFL(ref KPEDBOGCHII ADIGGFBANFM)
	{
		return default(EMKICLFMFKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[CLDGIFMABHG(typeof(KACJNGIFHBO), new string[] { })]
[HKHMJEAEOCG(typeof(FLNKGJHGIEC))]
public class KACJNGIFHBO : GOKNGONBKFG, IDisposable, FLNKGJHGIEC
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum HJKOEKINAFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Undoing,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Redoing
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct EEGCBMKDOIB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly HJKOEKINAFM ILNHGOLEEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly KACJNGIFHBO DLIKPMCKNDM;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x86E800", Offset = "0x86DA00", VA = "0x18086E800")]
		public EEGCBMKDOIB(KACJNGIFHBO DLIKPMCKNDM, bool LKMCPGDOCBD, uint BCHFMCCIDMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x86E7D0", Offset = "0x86D9D0", VA = "0x18086E7D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class JOEIJEACMOK
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public struct GDNJBJKIHFN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private readonly JOEIJEACMOK ECNMDGCPMBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private readonly bool KKOIPIHKHJJ;

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x870350", Offset = "0x86F550", VA = "0x180870350")]
			public GDNJBJKIHFN(JOEIJEACMOK ECNMDGCPMBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x86E870", Offset = "0x86DA70", VA = "0x18086E870", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public struct EFEHEABPBMA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly JOEIJEACMOK ECNMDGCPMBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly bool KKOIPIHKHJJ;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x86E8A0", Offset = "0x86DAA0", VA = "0x18086E8A0")]
			public EFEHEABPBMA(JOEIJEACMOK ECNMDGCPMBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x86E870", Offset = "0x86DA70", VA = "0x18086E870", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly KACJNGIFHBO GDGMLNGFBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool KEJEKAHJPOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int FEFEMCDOLJJ;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8784C0", Offset = "0x8776C0", VA = "0x1808784C0")]
		public JOEIJEACMOK(KACJNGIFHBO GDGMLNGFBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8783F0", Offset = "0x8775F0", VA = "0x1808783F0")]
		public bool BHKKJJLAIKI(NJKBLCBBANC PLHHAHPCHBA, CAEHPHOEGJK FMBNLFNGBEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x878470", Offset = "0x877670", VA = "0x180878470")]
		public EFEHEABPBMA OAHONOHNKNG()
		{
			return default(EFEHEABPBMA);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x878420", Offset = "0x877620", VA = "0x180878420")]
		public GDNJBJKIHFN GMGJGHCDKMJ()
		{
			return default(GDNJBJKIHFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MHNACPJPKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KACJNGIFHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public UndoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public MHNACPJPKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x881A90", Offset = "0x880C90", VA = "0x180881A90")]
		internal RedoAction <Undo>b__0()
		{
			return default(RedoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class JMDFHHCHFFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KACJNGIFHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public RedoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public JMDFHHCHFFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x878380", Offset = "0x877580", VA = "0x180878380")]
		internal UndoAction <Redo>b__0()
		{
			return default(UndoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class FGBGKACJHOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public FGBGKACJHOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x86FD30", Offset = "0x86EF30", VA = "0x18086FD30")]
		internal bool <SyncProperties>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly UndoAction CGPOHJEDBNA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly RedoAction COOCJILCLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private MFIMPIBNBNO ABFMDAIHDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private ActionBuffer MKHNMICOOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private ActionBuffer LFALCHPMGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NMIMFDNKLJP GLODAFJJDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private AGKEGIGJACC EMKBFMNEDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private TransformOwnershipPhase EIMDLFDFABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private OLINELLNIIG OGDHIEJGLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private HJKOEKINAFM EKDMHOIJFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private uint JDAIGLPHHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private uint DGLOEGJJHNM;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private JOEIJEACMOK FMINBHDPAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x698F60", Offset = "0x698160", VA = "0x180698F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool MABKKBODHEH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x87A860", Offset = "0x879A60", VA = "0x18087A860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool GCKELMPMFIP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x879A70", Offset = "0x878C70", VA = "0x180879A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool NABPNKLMIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x879B10", Offset = "0x878D10", VA = "0x180879B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int LMKFCNNNOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x87A960", Offset = "0x879B60", VA = "0x18087A960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int NHLIHIMGIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x87A130", Offset = "0x879330", VA = "0x18087A130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private bool KLBPCFEMLPP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x87A730", Offset = "0x879930", VA = "0x18087A730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private bool EOMECBFNGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x879EE0", Offset = "0x8790E0", VA = "0x180879EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GANINKMEHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5F72F0", Offset = "0x5F64F0", VA = "0x1805F72F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5F6200", Offset = "0x5F5400", VA = "0x1805F6200", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private ActionBuffer DFHMKJABFPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x87A7E0", Offset = "0x8799E0", VA = "0x18087A7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action NNEBNKKLPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x87A740", Offset = "0x879940", VA = "0x18087A740", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x879EF0", Offset = "0x8790F0", VA = "0x180879EF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action HBBEGFNHHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x87A630", Offset = "0x879830", VA = "0x18087A630")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x879F90", Offset = "0x879190", VA = "0x180879F90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x87AB10", Offset = "0x879D10", VA = "0x18087AB10")]
	public KACJNGIFHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8798A0", Offset = "0x878AA0", VA = "0x1808798A0", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x879620", Offset = "0x878820", VA = "0x180879620", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x879E60", Offset = "0x879060", VA = "0x180879E60", Slot = "14")]
	public IDisposable HEDIJJLEIHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x879560", Offset = "0x878760", VA = "0x180879560", Slot = "9")]
	public IDisposable CJIKEOHCMJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x87A9B0", Offset = "0x879BB0", VA = "0x18087A9B0", Slot = "6")]
	public UndoAction PKEAPKLOMGP()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x879720", Offset = "0x878920", VA = "0x180879720", Slot = "15")]
	public RedoAction EJFGOKODDLO()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8793C0", Offset = "0x8785C0", VA = "0x1808793C0", Slot = "16")]
	public UndoAction BNANEMOLOGN()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8797B0", Offset = "0x8789B0", VA = "0x1808797B0", Slot = "7")]
	public RedoAction EJFGOKODDLO(UndoAction MLNFOFCNKEF)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x879450", Offset = "0x878650", VA = "0x180879450", Slot = "8")]
	public UndoAction BNANEMOLOGN(RedoAction MLNFOFCNKEF)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x879AC0", Offset = "0x878CC0", VA = "0x180879AC0")]
	public bool FBFPKEAPPJH(NMLLKICLAOF LKHEALCDKFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x87A7F0", Offset = "0x8799F0", VA = "0x18087A7F0", Slot = "17")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x879B40", Offset = "0x878D40", VA = "0x180879B40")]
	public void FNNCFOFKCAK(NJKBLCBBANC PLHHAHPCHBA, EMKICLFMFKI JGEBAMPIEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x879180", Offset = "0x878380", VA = "0x180879180")]
	public void BDMHDIPCKLP(NJKBLCBBANC PLHHAHPCHBA, CAEHPHOEGJK FMBNLFNGBEI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x87A150", Offset = "0x879350", VA = "0x18087A150")]
	public void LIDJCODGNGF(NJKBLCBBANC PLHHAHPCHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x87A2C0", Offset = "0x8794C0", VA = "0x18087A2C0")]
	private void LJOECIHEDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8795E0", Offset = "0x8787E0", VA = "0x1808795E0")]
	private void CNAHPELHPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x87A840", Offset = "0x879A40", VA = "0x18087A840")]
	private void OCFFPJKCMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x87A030", Offset = "0x879230", VA = "0x18087A030")]
	private GEEEOLNDMJA KKLEHODHDGP()
	{
		return default(GEEEOLNDMJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x87A940", Offset = "0x879B40", VA = "0x18087A940")]
	private uint PCKCIAMPDFC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x879540", Offset = "0x878740", VA = "0x180879540")]
	private bool CIIALHEFDJI(out GEEEOLNDMJA GHCLFMPOHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x879A50", Offset = "0x878C50", VA = "0x180879A50")]
	private bool ENDGOPMKCDM(out GEEEOLNDMJA GHCLFMPOHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x87A6D0", Offset = "0x8798D0", VA = "0x18087A6D0")]
	private RedoAction MEFLHIBPOEE(GEEEOLNDMJA GHCLFMPOHGP)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x87A8E0", Offset = "0x879AE0", VA = "0x18087A8E0")]
	private UndoAction PAIJHIPKINP(GEEEOLNDMJA GHCLFMPOHGP)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x87A300", Offset = "0x879500", VA = "0x18087A300")]
	private GEEEOLNDMJA LJPOIMMBKGE(GEEEOLNDMJA GHCLFMPOHGP, ActionBuffer BCFAIIEJHPG, bool LKMCPGDOCBD)
	{
		return default(GEEEOLNDMJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x879CC0", Offset = "0x878EC0", VA = "0x180879CC0")]
	private void GNJHAFFDGKB(Action GHCLFMPOHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x535CAA0", Offset = "0x535BCA0", VA = "0x18535CAA0")]
	private T GNJHAFFDGKB<T>(Func<T> GPHFFCBCKDN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x87A5C0", Offset = "0x8797C0", VA = "0x18087A5C0")]
	private EEGCBMKDOIB LMJGLOPEDEG(bool LKMCPGDOCBD, uint BCHFMCCIDMH)
	{
		return default(EEGCBMKDOIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x879D70", Offset = "0x878F70", VA = "0x180879D70")]
	[CompilerGenerated]
	private UndoAction HAPCFAIIILA()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x8792B0", Offset = "0x8784B0", VA = "0x1808792B0")]
	[CompilerGenerated]
	private RedoAction BMBKPDFMGKN()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x879080", Offset = "0x878280", VA = "0x180879080")]
	[CompilerGenerated]
	private UndoAction AABOOMCCKKP()
	{
		return default(UndoAction);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct GLBGFFGHFDF : IEnumerable<FDIPDPOMECM>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum FAEECPDMIFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private struct MAPEEPKMLNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly GLBGFFGHFDF MDBHJOENILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly OLINELLNIIG OGDHIEJGLOE;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA576D0", Offset = "0xA568D0", VA = "0x180A576D0")]
		public MAPEEPKMLNB(GLBGFFGHFDF MDBHJOENILE, OLINELLNIIG OGDHIEJGLOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA56FA0", Offset = "0xA561A0", VA = "0x180A56FA0")]
		public void KMAJBBIAGME(NativeList<byte> MCLKJDJHIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA57680", Offset = "0xA56880", VA = "0x180A57680")]
		private void PAEAGDBFAOE(FDIPDPOMECM DMEAKEHDCBC, ref JAKMBMMKBHA ALHBCCIDLGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA56E30", Offset = "0xA56030", VA = "0x180A56E30")]
		private void HHEDCMFLFGI(FDIPDPOMECM DMEAKEHDCBC, ref JAKMBMMKBHA ALHBCCIDLGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA56EC0", Offset = "0xA560C0", VA = "0x180A56EC0")]
		private NativeArray<byte> JKKMEMPBHAA(NativeList<byte> MCLKJDJHIOE)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA57390", Offset = "0xA56590", VA = "0x180A57390")]
		private NativeArray<byte> LFHKINIBJOG(NativeList<byte> MCLKJDJHIOE, int IPOIAMFIOLH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA57460", Offset = "0xA56660", VA = "0x180A57460")]
		private int LPMEBAJIMHA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA57230", Offset = "0xA56430", VA = "0x180A57230")]
		private bool LAEONHENALM(FDIPDPOMECM DMEAKEHDCBC, out NativeArray<byte> OIJLBMGMHAM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct EENCKCNIEMD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NativeList<byte> ADIGGFBANFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private GLBGFFGHFDF MDBHJOENILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly FDIPDPOMECM FKKKHANKMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly int FLFAMDBICFJ;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBA0", Offset = "0xA4DDA0", VA = "0x180A4EBA0")]
		internal EENCKCNIEMD(GLBGFFGHFDF MDBHJOENILE, FDIPDPOMECM FKKKHANKMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA4E910", Offset = "0xA4DB10", VA = "0x180A4E910", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA4E940", Offset = "0xA4DB40", VA = "0x180A4E940")]
		public void EDLDNKLCNHD(NativeArray<byte> ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB40", Offset = "0xA4DD40", VA = "0x180A4EB40")]
		public void HMPNLPMOAFI(NativeArray<byte> ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB30", Offset = "0xA4DD30", VA = "0x180A4EB30")]
		public void HHEDCMFLFGI(in JFFJOIBOPJP ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3E045A0", Offset = "0x3E037A0", VA = "0x183E045A0")]
		public void HHEDCMFLFGI<T>(T ADBNEBBHMOP) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA00", Offset = "0xA4DC00", VA = "0x180A4EA00")]
		private void FGDHAMDMOPA(int ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA70", Offset = "0xA4DC70", VA = "0x180A4EA70")]
		private void FGDHAMDMOPA(in JFFJOIBOPJP ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA4E9A0", Offset = "0xA4DBA0", VA = "0x180A4E9A0")]
		private unsafe void FGDHAMDMOPA(void* IMNBFKNLCNK, int IPOIAMFIOLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA4E940", Offset = "0xA4DB40", VA = "0x180A4E940")]
		private void FGDHAMDMOPA(NativeArray<byte> JGKODHNKDPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct GEJGJGKGAIB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private GLBGFFGHFDF MDBHJOENILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NativeArray<byte> ADIGGFBANFM;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA52120", Offset = "0xA51320", VA = "0x180A52120")]
		internal GEJGJGKGAIB(GLBGFFGHFDF MDBHJOENILE, NativeArray<byte> ADIGGFBANFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xA51FE0", Offset = "0xA511E0", VA = "0x180A51FE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA51FF0", Offset = "0xA511F0", VA = "0x180A51FF0")]
		public NativeArray<byte> JFPNOPEBHCN(int IPOIAMFIOLH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA520B0", Offset = "0xA512B0", VA = "0x180A520B0")]
		public NativeArray<byte> POFHLOJIOPD()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x384F030", Offset = "0x384E230", VA = "0x18384F030")]
		public T AJLOCALBIDH<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0xA51F60", Offset = "0xA51160", VA = "0x180A51F60")]
		public void AJLOCALBIDH(in AINJMIEKGCE ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct OBBBNCIDCIM : IEnumerator<FDIPDPOMECM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly NativeArray<FDIPDPOMECM> NAJOFPKLJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int MJNAIOAAGCG;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public FDIPDPOMECM EGCCHNLJPLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xA57C20", Offset = "0xA56E20", VA = "0x180A57C20", Slot = "4")]
			get
			{
				return default(FDIPDPOMECM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xA57BC0", Offset = "0xA56DC0", VA = "0x180A57BC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA57C10", Offset = "0xA56E10", VA = "0x180A57C10")]
		internal OBBBNCIDCIM(NativeArray<FDIPDPOMECM> JGKODHNKDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA57AF0", Offset = "0xA56CF0", VA = "0x180A57AF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA57B70", Offset = "0xA56D70", VA = "0x180A57B70", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct OIPBDKJFEHK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private const int LDDEKNLCLMB = 0;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private const int KJGEBCDJJJI = 1;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const int MJJIGIBNHIB = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private NativeArray<int> ADIGGFBANFM;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public int KECHMDMBNCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA580D0", Offset = "0xA572D0", VA = "0x180A580D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA580C0", Offset = "0xA572C0", VA = "0x180A580C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public FAEECPDMIFI FMBICLDNNOG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xA580B0", Offset = "0xA572B0", VA = "0x180A580B0")]
			get
			{
				return default(FAEECPDMIFI);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xA58010", Offset = "0xA57210", VA = "0x180A58010")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool PAJJCFIDAFN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xA58000", Offset = "0xA57200", VA = "0x180A58000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xA57F80", Offset = "0xA57180", VA = "0x180A57F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool EDMIEMGLBFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xA580A0", Offset = "0xA572A0", VA = "0x180A580A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xA57FA0", Offset = "0xA571A0", VA = "0x180A57FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA580E0", Offset = "0xA572E0", VA = "0x180A580E0")]
		public OIPBDKJFEHK(FAEECPDMIFI IKENLIKKGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA58070", Offset = "0xA57270", VA = "0x180A58070")]
		private int FCLOOBPJBAH(int FDGAPOLJFKN, int AMBOGPBLAMD = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA57FC0", Offset = "0xA571C0", VA = "0x180A57FC0")]
		private void CEAJIHNFBDD(int FDGAPOLJFKN, int ADBNEBBHMOP, int AMBOGPBLAMD = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA58030", Offset = "0xA57230", VA = "0x180A58030", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private const int FOPHNFBFNEK = -1;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int LAGNBGNCFNO = 0;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly FDIPDPOMECM FIPGAHKIHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private NativeHashMap<FDIPDPOMECM, int> BBNCHDJMHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private NativeList<FDIPDPOMECM> NJJAOFJGDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private NativeList<int> AJDBPGJNGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private NativeList<byte> HCFLADHDCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NativeList<byte> ADIGGFBANFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private OIPBDKJFEHK JBADGMEDNJF;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool PAJJCFIDAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA52760", Offset = "0xA51960", VA = "0x180A52760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool OEAJGIGPLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA52BD0", Offset = "0xA51DD0", VA = "0x180A52BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int KECHMDMBNCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA52DE0", Offset = "0xA51FE0", VA = "0x180A52DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int ABBLKCFDOGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA52720", Offset = "0xA51920", VA = "0x180A52720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0xA52840", Offset = "0xA51A40", VA = "0x180A52840")]
	public static GLBGFFGHFDF CNOGLGNGFED(FAEECPDMIFI IKENLIKKGKF = FAEECPDMIFI.Last, int DJLOGCBDDCM = 16, int GGNCEBLBHLK = 256)
	{
		return default(GLBGFFGHFDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0xA53260", Offset = "0xA52460", VA = "0x180A53260")]
	private GLBGFFGHFDF(FAEECPDMIFI IKENLIKKGKF, int DJLOGCBDDCM, int GGNCEBLBHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0xA528A0", Offset = "0xA51AA0", VA = "0x180A528A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xA529E0", Offset = "0xA51BE0", VA = "0x180A529E0")]
	public EENCKCNIEMD EOBCBGGANOI(FDIPDPOMECM FKKKHANKMEH)
	{
		return default(EENCKCNIEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0xA53070", Offset = "0xA52270", VA = "0x180A53070")]
	public GEJGJGKGAIB PPLMEFFHJCB(FDIPDPOMECM FKKKHANKMEH)
	{
		return default(GEJGJGKGAIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0xA52BE0", Offset = "0xA51DE0", VA = "0x180A52BE0")]
	public bool MLPPKFHLFNH(FDIPDPOMECM FKKKHANKMEH, out GEJGJGKGAIB JKCLPGJHEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0xA52AD0", Offset = "0xA51CD0", VA = "0x180A52AD0")]
	public bool FIONOEIGGFB(FDIPDPOMECM FKKKHANKMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0xA52B20", Offset = "0xA51D20", VA = "0x180A52B20")]
	public bool FKFEMBGMADP(FDIPDPOMECM FKKKHANKMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0xA52770", Offset = "0xA51970", VA = "0x180A52770")]
	public void CLBOIMOFJOH(NativeList<byte> MCLKJDJHIOE, OLINELLNIIG OGDHIEJGLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x384F6F0", Offset = "0x384E8F0", VA = "0x18384F6F0")]
	public T JPMCGEINDNN<T>(FDIPDPOMECM FKKKHANKMEH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0xA52D50", Offset = "0xA51F50", VA = "0x180A52D50")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0xA52970", Offset = "0xA51B70", VA = "0x180A52970")]
	public OBBBNCIDCIM ENNIMPBLHKI()
	{
		return default(OBBBNCIDCIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0xA52DF0", Offset = "0xA51FF0", VA = "0x180A52DF0")]
	private void PAMIGJAPFEK(FDIPDPOMECM FKKKHANKMEH, int FLFAMDBICFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0xA52660", Offset = "0xA51860", VA = "0x180A52660")]
	private void AAKDIPDDIKO(int LFHODOMHHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0xA52FB0", Offset = "0xA521B0", VA = "0x180A52FB0")]
	private void PJFOAHIFBAI(FDIPDPOMECM FKKKHANKMEH, int FLFAMDBICFJ, int IPOIAMFIOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x384F670", Offset = "0x384E870", VA = "0x18384F670")]
	private static T JPMCGEINDNN<T>(NativeArray<byte> NAJOFPKLJJG, int FDGAPOLJFKN = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0xA531A0", Offset = "0xA523A0", VA = "0x180A531A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0xA53150", Offset = "0xA52350", VA = "0x180A53150", Slot = "4")]
	private IEnumerator<FDIPDPOMECM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class NJPDCDKLJBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private NativeArray<byte> NAJOFPKLJJG;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int IPIKHFMIGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD60", Offset = "0x6FEF60", VA = "0x1806FFD60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x858EA0", Offset = "0x8580A0", VA = "0x180858EA0")]
	public NJPDCDKLJBP(NativeArray<byte> NAJOFPKLJJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8840A0", Offset = "0x8832A0", VA = "0x1808840A0")]
	public static NJPDCDKLJBP BKALKAPLPLL(NativeArray<byte> NAJOFPKLJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	public T AJLOCALBIDH<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	public NativeArray<T> JFPNOPEBHCN<T>(int IPOIAMFIOLH, Allocator MKFODJKMOCC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	public NativeArray<T> POFHLOJIOPD<T>(Allocator MKFODJKMOCC) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KPEDBOGCHII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private NativeArray<byte> NAJOFPKLJJG;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int IPIKHFMIGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD60", Offset = "0x6FEF60", VA = "0x1806FFD60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x858EA0", Offset = "0x8580A0", VA = "0x180858EA0")]
	public KPEDBOGCHII(NativeArray<byte> NAJOFPKLJJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x87F380", Offset = "0x87E580", VA = "0x18087F380")]
	public static KPEDBOGCHII BKALKAPLPLL(NativeArray<byte> NAJOFPKLJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x535D330", Offset = "0x535C530", VA = "0x18535D330")]
	public T AJLOCALBIDH<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	public NativeArray<T> JFPNOPEBHCN<T>(int IPOIAMFIOLH, Allocator MKFODJKMOCC) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JAKMBMMKBHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private NativeArray<byte> NAJOFPKLJJG;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int IPIKHFMIGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD60", Offset = "0x6FEF60", VA = "0x1806FFD60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x858EA0", Offset = "0x8580A0", VA = "0x180858EA0")]
	public JAKMBMMKBHA(NativeArray<byte> NAJOFPKLJJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x877350", Offset = "0x876550", VA = "0x180877350")]
	public static JAKMBMMKBHA BKALKAPLPLL(NativeArray<byte> NAJOFPKLJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3E130A0", Offset = "0x3E122A0", VA = "0x183E130A0")]
	public void KNAPOGBOHJD<T>(in T ADBNEBBHMOP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3E13100", Offset = "0x3E12300", VA = "0x183E13100")]
	public void LLCKEEOJKAF<T>(NativeArray<T> JGKODHNKDPL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	public void LLJIOLLMMFI<T>(NativeArray<T> ADBNEBBHMOP) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KOMBBKCALHF
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x87EF50", Offset = "0x87E150", VA = "0x18087EF50")]
	public static Span<byte> FPHCDINCHMO(this NativeArray<byte> NAJOFPKLJJG)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x87F0C0", Offset = "0x87E2C0", VA = "0x18087F0C0")]
	public static ReadOnlySpan<byte> GCIIJAABNOI(this NativeArray<byte> NAJOFPKLJJG)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x87F2A0", Offset = "0x87E4A0", VA = "0x18087F2A0")]
	public static NativeArray<byte> MNPMEKEDGCK(this NativeArray<byte> NAJOFPKLJJG, int FLFAMDBICFJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x87EEE0", Offset = "0x87E0E0", VA = "0x18087EEE0")]
	public static NativeArray<byte> DBHNMIPOMKL(this NativeArray<byte> NAJOFPKLJJG, int AEKEPEKODMN = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4301C20", Offset = "0x4300E20", VA = "0x184301C20")]
	public static NativeArray<byte> DBHNMIPOMKL<T>(this NativeArray<byte> NAJOFPKLJJG, int AEKEPEKODMN = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x87F310", Offset = "0x87E510", VA = "0x18087F310")]
	public static NativeArray<byte> NCKIEJGFFOG(this NativeArray<byte> NAJOFPKLJJG, int AEKEPEKODMN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4303120", Offset = "0x4302320", VA = "0x184303120")]
	public static NativeArray<byte> NCKIEJGFFOG<T>(this NativeArray<byte> NAJOFPKLJJG, int AEKEPEKODMN = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x87F230", Offset = "0x87E430", VA = "0x18087F230")]
	public static NativeArray<byte> GPLICKOOGNN(this NativeArray<byte> NAJOFPKLJJG, int AEKEPEKODMN = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4301E60", Offset = "0x4301060", VA = "0x184301E60")]
	public static NativeArray<byte> GPLICKOOGNN<T>(this NativeArray<byte> NAJOFPKLJJG, int AEKEPEKODMN = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class KFGLPBKOHKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private NativeList<byte> MDBHJOENILE;

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x858EA0", Offset = "0x8580A0", VA = "0x180858EA0")]
	public KFGLPBKOHKG(NativeList<byte> MDBHJOENILE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x87C210", Offset = "0x87B410", VA = "0x18087C210")]
	public static KFGLPBKOHKG BKALKAPLPLL(NativeList<byte> NAJOFPKLJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	public void KNAPOGBOHJD<T>(in T ADBNEBBHMOP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	public void LLCKEEOJKAF<T>(NativeArray<T> ADBNEBBHMOP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	public void LLJIOLLMMFI<T>(NativeArray<T> ADBNEBBHMOP) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[EJLOOKEAJML(HNJEFABFMIP.PropertyChanges)]
	[CLDGIFMABHG(typeof(PropertyChangeNetworkRouter), new string[] { })]
	public class PropertyChangeNetworkRouter : GFHKHHPFFGF, GOKNGONBKFG, ANMHEGLHELN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private MFIMPIBNBNO DCBHGCPJBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private FLIGOHAOHNA DJBGEDLHCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private LIODBHBOIBI OMFFMMHBAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private AEKBEKMKIII PJKPJHBDLFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private FDIPDPOMECM DMEAKEHDCBC;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public MFIMPIBNBNO OCBIDLFGINP
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xBE76F0", Offset = "0xBE68F0", VA = "0x180BE76F0")]
		public MFIMPIBNBNO.HGOPKMBINOO BMDNNOGKOIF()
		{
			return default(MFIMPIBNBNO.HGOPKMBINOO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xBE7B70", Offset = "0xBE6D70", VA = "0x180BE7B70", Slot = "4")]
		public void JFNNIMEOELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xBE7870", Offset = "0xBE6A70", VA = "0x180BE7870", Slot = "5")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xBE7D10", Offset = "0xBE6F10", VA = "0x180BE7D10")]
		public void PKEAPKLOMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xBE7900", Offset = "0xBE6B00", VA = "0x180BE7900")]
		private void EOBCBGGANOI(FDIPDPOMECM FKKKHANKMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xBE7710", Offset = "0xBE6910", VA = "0x180BE7710")]
		private void DMBKFMPEHJO(FDIPDPOMECM FKKKHANKMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xBE7C90", Offset = "0xBE6E90", VA = "0x180BE7C90")]
		private void LAAPAEDDDHF(FDIPDPOMECM FKKKHANKMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xBE7B50", Offset = "0xBE6D50", VA = "0x180BE7B50")]
		private void GDBNCDMFDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xBE7CF0", Offset = "0xBE6EF0", VA = "0x180BE7CF0")]
		private void NNILMCILDOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xBE7C00", Offset = "0xBE6E00", VA = "0x180BE7C00")]
		private void JNGJGONIANG(FDIPDPOMECM FKKKHANKMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3B2F130", Offset = "0x3B2E330", VA = "0x183B2F130", Slot = "6")]
		private void NFFFBLHLMIG<TKey, T>(global::KGLFOOFGNAB<TKey, T> HJJHAMKLCMH, object JAEDJGBMHAP) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xBE7840", Offset = "0xBE6A40", VA = "0x180BE7840", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[CLDGIFMABHG(typeof(DLFECIILAAA), new string[] { })]
public class DLFECIILAAA : GOKNGONBKFG, AIOPJLICFNI
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly KPICHBJHLDP PEKGANJFIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private HNNIDMNOAIJ DKCMPFLCCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private FJGGKJJCIJE OMFFMMHBAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private KACJNGIFHBO GDGMLNGFBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private PropertyChangeNetworkRouter NCELLBNMAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private CAEHPHOEGJK EKJOGKEJDNG;

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0xA4C9A0", Offset = "0xA4BBA0", VA = "0x180A4C9A0", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0xA4C8D0", Offset = "0xA4BAD0", VA = "0x180A4C8D0", Slot = "5")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0xA4CA50", Offset = "0xA4BC50", VA = "0x180A4CA50")]
	public void FNNCFOFKCAK(NJKBLCBBANC PLHHAHPCHBA, EMKICLFMFKI JGEBAMPIEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0xA4C890", Offset = "0xA4BA90", VA = "0x180A4C890")]
	public void BDMHDIPCKLP(NJKBLCBBANC PLHHAHPCHBA, CAEHPHOEGJK FMBNLFNGBEI, in JFFJOIBOPJP KNJHGCFHNJC, in JFFJOIBOPJP DNIHHNBJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0xA4CB40", Offset = "0xA4BD40", VA = "0x180A4CB40")]
	public void LIDJCODGNGF(NJKBLCBBANC PLHHAHPCHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0xA4CC00", Offset = "0xA4BE00", VA = "0x180A4CC00")]
	private void MODNAFHACEE(NJKBLCBBANC PLHHAHPCHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0xA4CC20", Offset = "0xA4BE20", VA = "0x180A4CC20")]
	public void PIKOIGJLIKK(NJKBLCBBANC PLHHAHPCHBA, CAEHPHOEGJK FMBNLFNGBEI, in JFFJOIBOPJP KNJHGCFHNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0xA4CAA0", Offset = "0xA4BCA0", VA = "0x180A4CAA0")]
	private void IIKGOBKFMHE(NJKBLCBBANC PLHHAHPCHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0xA4CCA0", Offset = "0xA4BEA0", VA = "0x180A4CCA0")]
	public DLFECIILAAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal abstract class IJIFPHJBNBE : GOKNGONBKFG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private NMIMFDNKLJP GLODAFJJDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private uint ACEJCHKNEBK;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public abstract uint IJBKPJFHPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x875790", Offset = "0x874990", VA = "0x180875790", Slot = "7")]
	public virtual void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x875710", Offset = "0x874910", VA = "0x180875710", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x8756C0", Offset = "0x8748C0", VA = "0x1808756C0")]
	public NJKBLCBBANC DONNDOFPDNP()
	{
		return default(NJKBLCBBANC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x875840", Offset = "0x874A40", VA = "0x180875840")]
	public void OIJGFLONPCF(NJKBLCBBANC OOLAJOMEKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x875830", Offset = "0x874A30", VA = "0x180875830", Slot = "8")]
	public virtual void MJIFHFDNIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	protected IJIFPHJBNBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[CLDGIFMABHG(typeof(JHJIBOLNNJM), new string[] { })]
internal sealed class JHJIBOLNNJM : IJIFPHJBNBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private FCFLIDMJBKH FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private uint JNIHCAGKOOP;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public override uint IJBKPJFHPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3A0", Offset = "0x7E95A0", VA = "0x1807EA3A0", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8781B0", Offset = "0x8773B0", VA = "0x1808781B0", Slot = "7")]
	public override void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x878160", Offset = "0x877360", VA = "0x180878160")]
	private void CEEBELPHFHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x8782C0", Offset = "0x8774C0", VA = "0x1808782C0", Slot = "8")]
	public override void MJIFHFDNIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public JHJIBOLNNJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[CLDGIFMABHG(typeof(JIIEBLBHCJD), new string[] { })]
internal sealed class JIIEBLBHCJD : IJIFPHJBNBE
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public override uint IJBKPJFHPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5F6110", Offset = "0x5F5310", VA = "0x1805F6110", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public JIIEBLBHCJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[OCLKOGGMIFL(typeof(EGHMCKEACDK))]
[CLDGIFMABHG(typeof(PDFECNJDFGM), new string[] { })]
internal sealed class PDFECNJDFGM : PMOCCIAIAEL, GFHKHHPFFGF, GOKNGONBKFG, AIOPJLICFNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private EGHMCKEACDK DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AEKECOGJAHN JGHMLHPFFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private EntityQuery JNOELCNFDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private EntityQuery NOJPOLNIEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private EntityQuery CCGCDFHCPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private EntityManager POMAKGKDHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xBE5C70", Offset = "0xBE4E70", VA = "0x180BE5C70")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EntityQuery IGNELECKCII
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x96F1A0", Offset = "0x96E3A0", VA = "0x18096F1A0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public EntityQuery MDECMCBCHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6B07F0", Offset = "0x6AF9F0", VA = "0x1806B07F0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EntityQuery CGOLBEAGLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xBE5550", Offset = "0xBE4750", VA = "0x180BE5550")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int BFNKIKJHPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xBE5AD0", Offset = "0xBE4CD0", VA = "0x180BE5AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int JMLLEMELMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xBE5C50", Offset = "0xBE4E50", VA = "0x180BE5C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int HINJMLPBFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xBE5910", Offset = "0xBE4B10", VA = "0x180BE5910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "4")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0xBE5890", Offset = "0xBE4A90", VA = "0x180BE5890", Slot = "5")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0xBE55D0", Offset = "0xBE47D0", VA = "0x180BE55D0", Slot = "6")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xBE5400", Offset = "0xBE4600", VA = "0x180BE5400")]
	public PHMKDAHEPPC APNPMPLOFEM()
	{
		return default(PHMKDAHEPPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xBE5930", Offset = "0xBE4B30", VA = "0x180BE5930")]
	public PHMKDAHEPPC GAHKLGOFFAG()
	{
		return default(PHMKDAHEPPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xBE5A30", Offset = "0xBE4C30", VA = "0x180BE5A30")]
	public PHMKDAHEPPC HJMFFIHMGID()
	{
		return default(PHMKDAHEPPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0xBE5AF0", Offset = "0xBE4CF0", VA = "0x180BE5AF0")]
	public DNJDKHAFBEJ LDLJNCFLMEB(DHOEKPEGHDF PLHHAHPCHBA)
	{
		return default(DNJDKHAFBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0xBE5BA0", Offset = "0xBE4DA0", VA = "0x180BE5BA0")]
	public DNJDKHAFBEJ LDLJNCFLMEB(Entity BBPBBOAPCHN)
	{
		return default(DNJDKHAFBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0xBE54A0", Offset = "0xBE46A0", VA = "0x180BE54A0")]
	public FNCBEEHJHBJ BAALBPNDGHP(Entity BBPBBOAPCHN)
	{
		return default(FNCBEEHJHBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0xBE5850", Offset = "0xBE4A50", VA = "0x180BE5850", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0xBE57A0", Offset = "0xBE49A0", VA = "0x180BE57A0")]
	private PHMKDAHEPPC BMEPKAAOFGK(EntityQuery IMOAAHEOFBK)
	{
		return default(PHMKDAHEPPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xBE5CC0", Offset = "0xBE4EC0", VA = "0x180BE5CC0")]
	public PDFECNJDFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[CLDGIFMABHG(typeof(AEKECOGJAHN), new string[] { })]
public class COALFCIBAMJ : GOKNGONBKFG, AEKECOGJAHN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private EGHMCKEACDK DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private FCFLIDMJBKH FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private ObjectLifecycleService KDKALCDIKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private ObjectEmbodimentService MBMBGCPJPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private ObjectPrefabCreationService ACNDAIINMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private ObjectNetworkToLocalMapService NKFKKMPLGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PDFECNJDFGM KIOLEKBJBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NMIMFDNKLJP GLODAFJJDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public KHADGDCMOKK HIAJLBNENIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xA49E20", Offset = "0xA49020", VA = "0x180A49E20", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private EntityManager POMAKGKDHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xA4A810", Offset = "0xA49A10", VA = "0x180A4A810")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int BFNKIKJHPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0B0", Offset = "0xA492B0", VA = "0x180A4A0B0", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int JMLLEMELMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA4A7F0", Offset = "0xA499F0", VA = "0x180A4A7F0", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int HINJMLPBFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA49B00", Offset = "0xA48D00", VA = "0x180A49B00", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int NDNMHIMGOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA49D20", Offset = "0xA48F20", VA = "0x180A49D20", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int IABFMDLGEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA49850", Offset = "0xA48A50", VA = "0x180A49850", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<DHOEKPEGHDF, FNCBEEHJHBJ> MOIEDBGOCJG
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA49300", Offset = "0xA48500", VA = "0x180A49300", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA4A490", Offset = "0xA49690", VA = "0x180A4A490", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<DHOEKPEGHDF> AEFHFEDKCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA4A120", Offset = "0xA49320", VA = "0x180A4A120", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA49C80", Offset = "0xA48E80", VA = "0x180A49C80", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0xA498F0", Offset = "0xA48AF0", VA = "0x180A498F0", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0xA49B70", Offset = "0xA48D70", VA = "0x180A49B70")]
	private void FGNLFKKFGAG(Entity BBPBBOAPCHN, FNCBEEHJHBJ FKFNLDMHBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0xA49580", Offset = "0xA48780", VA = "0x180A49580")]
	private void DGCKNFAKPFC(Entity BBPBBOAPCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0xA4A7C0", Offset = "0xA499C0", VA = "0x180A4A7C0")]
	internal DHOEKPEGHDF OBEDPFJEGGF(Entity BBPBBOAPCHN)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0xA4A5C0", Offset = "0xA497C0", VA = "0x180A4A5C0", Slot = "36")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	private void COEELFEPDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0xA49610", Offset = "0xA48810", VA = "0x180A49610", Slot = "38")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0xA49280", Offset = "0xA48480", VA = "0x180A49280", Slot = "11")]
	public PHMKDAHEPPC APNPMPLOFEM()
	{
		return default(PHMKDAHEPPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0xA49DC0", Offset = "0xA48FC0", VA = "0x180A49DC0", Slot = "41")]
	public PHMKDAHEPPC GAHKLGOFFAG()
	{
		return default(PHMKDAHEPPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0xA49F20", Offset = "0xA49120", VA = "0x180A49F20", Slot = "42")]
	public PHMKDAHEPPC HJMFFIHMGID()
	{
		return default(PHMKDAHEPPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0xA4A430", Offset = "0xA49630", VA = "0x180A4A430", Slot = "12")]
	public DNJDKHAFBEJ LDLJNCFLMEB(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(DNJDKHAFBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0xA492C0", Offset = "0xA484C0", VA = "0x180A492C0", Slot = "13")]
	public FNCBEEHJHBJ BAALBPNDGHP(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(FNCBEEHJHBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0xA4A9C0", Offset = "0xA49BC0", VA = "0x180A4A9C0", Slot = "35")]
	public bool PNGIIMFCLDE(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0xA4A3E0", Offset = "0xA495E0", VA = "0x180A4A3E0", Slot = "31")]
	public void LDDOKODCMGI(DHOEKPEGHDF LALFNHCEDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0xA4A970", Offset = "0xA49B70", VA = "0x180A4A970", Slot = "32")]
	public void PHICAJGHHMA(DHOEKPEGHDF LALFNHCEDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0xA4A570", Offset = "0xA49770", VA = "0x180A4A570", Slot = "33")]
	public void NCECDLLHAEG(DHOEKPEGHDF LALFNHCEDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0xA498C0", Offset = "0xA48AC0", VA = "0x180A498C0", Slot = "37")]
	public void EJFGDLHDNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0xA49D40", Offset = "0xA48F40", VA = "0x180A49D40", Slot = "25")]
	public HOFMJBLAIFM FNNCFOFKCAK(FNCBEEHJHBJ FKFNLDMHBOL)
	{
		return default(HOFMJBLAIFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0xA4A740", Offset = "0xA49940", VA = "0x180A4A740", Slot = "26")]
	public HOFMJBLAIFM NOFEFNJLLIK(FNCBEEHJHBJ FKFNLDMHBOL)
	{
		return default(HOFMJBLAIFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0xA49FD0", Offset = "0xA491D0", VA = "0x180A49FD0", Slot = "27")]
	public HOFMJBLAIFM IMEOGHLKMDG(NJKBLCBBANC AGHJLKKAHGN, FNCBEEHJHBJ FKFNLDMHBOL)
	{
		return default(HOFMJBLAIFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0xA491D0", Offset = "0xA483D0", VA = "0x180A491D0", Slot = "28")]
	public MLHPHNMBAKI AADDMFMNPIF()
	{
		return default(MLHPHNMBAKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0xA49E70", Offset = "0xA49070", VA = "0x180A49E70", Slot = "43")]
	public LCDBMBOHAJA HCDONOBCLKM(HCEPBAEMJHI BGMCKNGNOJI)
	{
		return default(LCDBMBOHAJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0xA494B0", Offset = "0xA486B0", VA = "0x180A494B0", Slot = "29")]
	public LJCFCJHOAGA DFEDBANKKAM()
	{
		return default(LJCFCJHOAGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0xA493E0", Offset = "0xA485E0", VA = "0x180A493E0", Slot = "30")]
	public JKMIJIHPBIA CHKJCDHIKDL(HLDDLEKEHIF BGMCKNGNOJI)
	{
		return default(JKMIJIHPBIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0xA4A5A0", Offset = "0xA497A0", VA = "0x180A4A5A0", Slot = "15")]
	public void NKCPCCNOLCN(NJKBLCBBANC AGHJLKKAHGN, IMGFAEJLICC FBJEHDDCEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0xA4A860", Offset = "0xA49A60", VA = "0x180A4A860", Slot = "16")]
	public HOFMJBLAIFM PCGNKLBJGLE(DHOEKPEGHDF LALFNHCEDJJ, [Optional] object HCPCDENCJBA)
	{
		return default(HOFMJBLAIFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0xA4A0D0", Offset = "0xA492D0", VA = "0x180A4A0D0", Slot = "17")]
	public bool JFINADNOEDC(DHOEKPEGHDF LALFNHCEDJJ, out IMGFAEJLICC LHPJBAGJLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0xA49F60", Offset = "0xA49160", VA = "0x180A49F60", Slot = "45")]
	public Transform ICKBGBOJLAM(DHOEKPEGHDF LALFNHCEDJJ, [Optional] object HCPCDENCJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0xA49C30", Offset = "0xA48E30", VA = "0x180A49C30", Slot = "19")]
	public bool FKHKOKAODEG(DHOEKPEGHDF LALFNHCEDJJ, out Transform EJOKPJGAPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0xA493A0", Offset = "0xA485A0", VA = "0x180A493A0", Slot = "20")]
	public bool BMLMCDCGBFJ(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0xA49870", Offset = "0xA48A70", VA = "0x180A49870")]
	public bool EGCKKKHLIGC(IMGFAEJLICC ADBNEBBHMOP, [Optional] object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0xA49890", Offset = "0xA48A90", VA = "0x180A49890", Slot = "46")]
	public bool EGCKKKHLIGC(DHOEKPEGHDF LALFNHCEDJJ, [Optional] object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0xA49E00", Offset = "0xA49000", VA = "0x180A49E00", Slot = "47")]
	public void GGEOLGDOKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0xA4A1C0", Offset = "0xA493C0", VA = "0x180A4A1C0", Slot = "18")]
	public void JHOMIFFHFON(IMGFAEJLICC PBKPNJLDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0xA4A530", Offset = "0xA49730", VA = "0x180A4A530", Slot = "48")]
	public void NAEPNJODOKA(DHOEKPEGHDF LALFNHCEDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0xA49C10", Offset = "0xA48E10", VA = "0x180A49C10", Slot = "21")]
	public void FKFAOJICEFL(Entity BBPBBOAPCHN, object HCPCDENCJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0xA49FB0", Offset = "0xA491B0", VA = "0x180A49FB0", Slot = "22")]
	public bool IKLEFPGPHBH(Entity BBPBBOAPCHN, object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0xA49AE0", Offset = "0xA48CE0", VA = "0x180A49AE0", Slot = "49")]
	public bool EPFFNFDMIHC(Entity BBPBBOAPCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0xA4A3C0", Offset = "0xA495C0", VA = "0x180A4A3C0", Slot = "50")]
	public bool KONCCENPKNG(Entity BBPBBOAPCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0xA49B20", Offset = "0xA48D20", VA = "0x180A49B20", Slot = "34")]
	public NativeArray<(DHOEKPEGHDF, DHOEKPEGHDF)> FFKFCGHMFHE(NativeArray<DHOEKPEGHDF> DAIKCJJNNID, Allocator MKFODJKMOCC)
	{
		return default(NativeArray<(DHOEKPEGHDF, DHOEKPEGHDF)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0xA4A460", Offset = "0xA49660", VA = "0x180A4A460", Slot = "24")]
	public NJKBLCBBANC MEDMAHADGEL(DHOEKPEGHDF LALFNHCEDJJ)
	{
		return default(NJKBLCBBANC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0xA4A380", Offset = "0xA49580", VA = "0x180A4A380", Slot = "23")]
	public DHOEKPEGHDF KCKNGDOKMAD(NJKBLCBBANC AGHJLKKAHGN)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public COALFCIBAMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[CLDGIFMABHG(typeof(FOGNOFJLJHO), new string[] { })]
internal sealed class FOGNOFJLJHO : GOKNGONBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private ObjectPrefabCreationService ACNDAIINMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PDFECNJDFGM KIOLEKBJBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private EDJHMIKNCNB DDCODOIGKNL;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0xA515E0", Offset = "0xA507E0", VA = "0x180A515E0", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xA51690", Offset = "0xA50890", VA = "0x180A51690")]
	public NativeArray<(DHOEKPEGHDF, DHOEKPEGHDF)> FFKFCGHMFHE(NativeArray<DHOEKPEGHDF> DAIKCJJNNID, Allocator MKFODJKMOCC)
	{
		return default(NativeArray<(DHOEKPEGHDF, DHOEKPEGHDF)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40")]
	private void NFNMJECHDMN(NativeMultiHashMap<int, (DHOEKPEGHDF src, DHOEKPEGHDF dst)> KCFCHAHJIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0xA517C0", Offset = "0xA509C0", VA = "0x180A517C0")]
	private void HAFPAMALIBE(NativeMultiHashMap<int, (DHOEKPEGHDF src, DHOEKPEGHDF dst)> KCFCHAHJIMJ, int FKFNLDMHBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xA519C0", Offset = "0xA50BC0", VA = "0x180A519C0")]
	private void MKPJELLGLJL(NativeMultiHashMap<int, (DHOEKPEGHDF src, DHOEKPEGHDF dst)> KCFCHAHJIMJ, int FKFNLDMHBOL, JJHBGAMPJOH OMFFMMHBAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xA51CD0", Offset = "0xA50ED0", VA = "0x180A51CD0")]
	private NativeMultiHashMap<int, (DHOEKPEGHDF, DHOEKPEGHDF)> OLNOBHDMNBC(Allocator MKFODJKMOCC, NativeArray<DHOEKPEGHDF> DAIKCJJNNID, out NativeArray<(DHOEKPEGHDF src, DHOEKPEGHDF dst)> IHLKFMLNGDC)
	{
		return default(NativeMultiHashMap<int, (DHOEKPEGHDF, DHOEKPEGHDF)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public FOGNOFJLJHO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CLDGIFMABHG(typeof(HHMLBHMEFHC), new string[] { })]
	[EJLOOKEAJML(HNJEFABFMIP.Physics, new string[] { "Callbacks" })]
	public class PhysicsService : GOKNGONBKFG, AIOPJLICFNI, HHMLBHMEFHC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private const string BENAJLOLCCG = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private static readonly MKIMOBFPILG ECJFIDPHOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private EntityManager KHDMOGKDGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private AEKECOGJAHN JGHMLHPFFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private EGHMCKEACDK DDCODOIGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IBPGEALOLCI DOGKIGKCFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private PropertyEventCallbacksService GDILCHBGMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private global::IPONGJGODFC<MHCAIFDFFED> BKMMHGLOLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool JGKFDLIIMNF;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<DHOEKPEGHDF, MHCAIFDFFED> HAGGGPNPNJD
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xBE6F60", Offset = "0xBE6160", VA = "0x180BE6F60", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xBE75D0", Offset = "0xBE67D0", VA = "0x180BE75D0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xBE72E0", Offset = "0xBE64E0", VA = "0x180BE72E0", Slot = "4")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xBE7000", Offset = "0xBE6200", VA = "0x180BE7000", Slot = "5")]
		public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xBE7130", Offset = "0xBE6330", VA = "0x180BE7130", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xBE73D0", Offset = "0xBE65D0", VA = "0x180BE73D0", Slot = "8")]
		public void JCACFLCKBKH(DHOEKPEGHDF LALFNHCEDJJ, Vector3 AGAHEBNHFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xBE71C0", Offset = "0xBE63C0", VA = "0x180BE71C0", Slot = "9")]
		public bool ECFHIPHAEIN(DHOEKPEGHDF LALFNHCEDJJ, out Collider JGDOJJPMCOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xBE7520", Offset = "0xBE6720", VA = "0x180BE7520")]
		private void LOJJGEENKOE(Entity BBPBBOAPCHN, CAEHPHOEGJK FMBNLFNGBEI, JFFJOIBOPJP DDKOGDKKCAE, JFFJOIBOPJP FONEHOKCGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xBE7480", Offset = "0xBE6680", VA = "0x180BE7480", Slot = "10")]
		public void LKAOLDHLABH(DHOEKPEGHDF LALFNHCEDJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PhysicsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class CLIKEFGHKCK : BEMJGPCJJME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly string AGENIHCFFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly CLIKEFGHKCK DJEPJCBHBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly List<CLIKEFGHKCK> JBKNBHIDMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly List<DDOCKAJKBGF> OMFFMMHBAGP;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string MLGPBCMHJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public BEMJGPCJJME JKCKABPIJCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public IEnumerable<BEMJGPCJJME> NHHPKPAOEOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public IEnumerable<DDOCKAJKBGF> APBOEKKLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0xA49060", Offset = "0xA48260", VA = "0x180A49060")]
	public CLIKEFGHKCK(string JFLKGPEABBP, CLIKEFGHKCK ENAGHEEPLJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[CLDGIFMABHG(typeof(CHMDLOCHHHI), new string[] { })]
[OCLKOGGMIFL(typeof(BMDCNHLNJCM))]
public sealed class CAHAHPIGFNO : CHMDLOCHHHI, PMOCCIAIAEL, GFHKHHPFFGF, GOKNGONBKFG, AIOPJLICFNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MIMJHEHCCII : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x7EA030", Offset = "0x7E9230", VA = "0x1807EA030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xA57A10", Offset = "0xA56C10", VA = "0x180A57A10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x880060", Offset = "0x87F260", VA = "0x180880060")]
		[DebuggerHidden]
		public MIMJHEHCCII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA57710", Offset = "0xA56910", VA = "0x180A57710", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA579C0", Offset = "0xA56BC0", VA = "0x180A579C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA57920", Offset = "0xA56B20", VA = "0x180A57920", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA57920", Offset = "0xA56B20", VA = "0x180A57920", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly BLAGMMEDCAO KILKGMIHEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<string, CLIKEFGHKCK> ICHNBNBEKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly Dictionary<int, BEMJGPCJJME> GCOFHIFMFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<DDOCKAJKBGF> CDOJCLOFKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private BMDCNHLNJCM OMFFMMHBAGP;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public BEMJGPCJJME KDBMHOBODEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA47F40", Offset = "0xA47140", VA = "0x180A47F40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public List<DDOCKAJKBGF> IEBEEBFLLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0xA48340", Offset = "0xA47540", VA = "0x180A48340", Slot = "8")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0xA47E60", Offset = "0xA47060", VA = "0x180A47E60", Slot = "9")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0xA47FA0", Offset = "0xA471A0", VA = "0x180A47FA0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0xA48770", Offset = "0xA47970", VA = "0x180A48770", Slot = "6")]
	public bool JNDGHLPHBFI(DDOCKAJKBGF HJJHAMKLCMH, out BEMJGPCJJME CEHEJGDEHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xA47FF0", Offset = "0xA471F0", VA = "0x180A47FF0")]
	private void EFGCEGDCNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0xA485F0", Offset = "0xA477F0", VA = "0x180A485F0")]
	private void IIIKGPJKCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xA48A40", Offset = "0xA47C40", VA = "0x180A48A40")]
	private CLIKEFGHKCK KPMGHMGLKDI(string GCFOOOMCPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xA47F40", Offset = "0xA47140", VA = "0x180A47F40")]
	private CLIKEFGHKCK DKKCOAHFJIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0xA483A0", Offset = "0xA475A0", VA = "0x180A483A0")]
	private CLIKEFGHKCK GOANKJCAAII(string GCFOOOMCPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xA488C0", Offset = "0xA47AC0", VA = "0x180A488C0")]
	private CLIKEFGHKCK KBDJOKPAIIP(string DLBDGCGKOKN, string HCPCDENCJBA, [Optional] CLIKEFGHKCK DJEPJCBHBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0xA48B60", Offset = "0xA47D60", VA = "0x180A48B60")]
	[IteratorStateMachine(typeof(MIMJHEHCCII))]
	private IEnumerable<(string, string)> NGLLFMLHGNH(string GCFOOOMCPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA47E70", VA = "0x180A48C70")]
	private bool OKIDLNFBNEH(DDOCKAJKBGF HJJHAMKLCMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xA48AA0", Offset = "0xA47CA0", VA = "0x180A48AA0")]
	private BLAGMMEDCAO NAKPEBBDCLM(DDOCKAJKBGF HJJHAMKLCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0xA47E80", Offset = "0xA47080", VA = "0x180A47E80")]
	private BLAGMMEDCAO CGCOFPCNCIH(DDOCKAJKBGF HJJHAMKLCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0xA47ED0", Offset = "0xA470D0", VA = "0x180A47ED0")]
	private BLAGMMEDCAO DELNKFMDFDD(DDOCKAJKBGF HJJHAMKLCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3846BA0", Offset = "0x3845DA0", VA = "0x183846BA0")]
	private T KHEPMFDPINN<T>(DDOCKAJKBGF HJJHAMKLCMH) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0xA487F0", Offset = "0xA479F0", VA = "0x180A487F0")]
	private FieldInfo JOMFMNOGNKA(DDOCKAJKBGF HJJHAMKLCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xA48CC0", Offset = "0xA47EC0", VA = "0x180A48CC0")]
	public CAHAHPIGFNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0xA48BD0", Offset = "0xA47DD0", VA = "0x180A48BD0")]
	[CompilerGenerated]
	private int NHNOOMPOAEP(DDOCKAJKBGF PJIOBOBOEGF, DDOCKAJKBGF KLGGEDCBMPK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[OCLKOGGMIFL(typeof(JDNBIHINJIJ))]
[CLDGIFMABHG(typeof(FJGGKJJCIJE), new string[] { })]
[DefaultMember("Item")]
public class IIAGCMFCKPJ : FJGGKJJCIJE, IEnumerable<PPDCFKFFIMN>, IEnumerable, PMOCCIAIAEL, GFHKHHPFFGF, GOKNGONBKFG, AIOPJLICFNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<(Type, string), int> GOKAFALOBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private JDNBIHINJIJ OMFFMMHBAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private FDBMGEEKLNH GJBGGLAHMOB;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x874D80", Offset = "0x873F80", VA = "0x180874D80", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public PPDCFKFFIMN LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x875550", Offset = "0x874750", VA = "0x180875550", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public PPDCFKFFIMN LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x875550", Offset = "0x874750", VA = "0x180875550", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8751C0", Offset = "0x8743C0", VA = "0x1808751C0", Slot = "11")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x874EB0", Offset = "0x8740B0", VA = "0x180874EB0", Slot = "12")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "13")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x875210", Offset = "0x874410", VA = "0x180875210")]
	private void LFJGKNMKLHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7120A0", Offset = "0x7112A0", VA = "0x1807120A0")]
	private string ELLMICAJEAK(string JFLKGPEABBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x875470", Offset = "0x874670", VA = "0x180875470", Slot = "7")]
	public PPDCFKFFIMN NNCBLAGJBAP(CFNMCCFLIFF FFIIDDPMMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x874F30", Offset = "0x874130", VA = "0x180874F30")]
	private bool GMHPDNDMIPC(Type GBCHFDDLKJO, string JFLKGPEABBP, out PPDCFKFFIMN HOBAGAEEOGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x874DA0", Offset = "0x873FA0", VA = "0x180874DA0", Slot = "8")]
	public CAEHPHOEGJK CBOIMAPADPA(CFNMCCFLIFF FFIIDDPMMKG)
	{
		return default(CAEHPHOEGJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8751A0", Offset = "0x8743A0", VA = "0x1808751A0", Slot = "9")]
	public IEnumerator<PPDCFKFFIMN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8751A0", Offset = "0x8743A0", VA = "0x1808751A0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x875570", Offset = "0x874770", VA = "0x180875570")]
	public IIAGCMFCKPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[DefaultMember("Item")]
public interface OLINELLNIIG
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FACGOKCONMI(CAEHPHOEGJK IHPCCBHNEMN, out int DFCIFDODMGE);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[OCLKOGGMIFL(typeof(LIODBHBOIBI))]
[CLDGIFMABHG(typeof(OLINELLNIIG), new string[] { })]
[DefaultMember("Item")]
public class AHPNNKPMIOJ : GOKNGONBKFG, AIOPJLICFNI, OLINELLNIIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<CAEHPHOEGJK, int> IBKKENHJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private LIODBHBOIBI OMFFMMHBAGP;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA464F0", Offset = "0xA456F0", VA = "0x180A464F0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0xA46230", Offset = "0xA45430", VA = "0x180A46230", Slot = "6")]
	public bool FACGOKCONMI(CAEHPHOEGJK IHPCCBHNEMN, out int DFCIFDODMGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0xA461D0", Offset = "0xA453D0", VA = "0x180A461D0", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xA461C0", Offset = "0xA453C0", VA = "0x180A461C0", Slot = "5")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0xA462A0", Offset = "0xA454A0", VA = "0x180A462A0")]
	private void HDDNDCHOLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xA46550", Offset = "0xA45750", VA = "0x180A46550")]
	public AHPNNKPMIOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[DefaultMember("Item")]
[CLDGIFMABHG(typeof(LIODBHBOIBI), new string[] { })]
[OCLKOGGMIFL(typeof(FJGGKJJCIJE))]
public class IPPIGBPCHEO : LIODBHBOIBI, IEnumerable<EMOEMMBOEPM>, IEnumerable, PMOCCIAIAEL, GFHKHHPFFGF, GOKNGONBKFG, AIOPJLICFNI, ANMHEGLHELN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private AEKECOGJAHN JGHMLHPFFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private FJGGKJJCIJE JDDNPNNLOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private EMOEMMBOEPM[] BPJOPKNHLGC;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x876C60", Offset = "0x875E60", VA = "0x180876C60", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public EMOEMMBOEPM LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x877110", Offset = "0x876310", VA = "0x180877110", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public EMOEMMBOEPM LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x877110", Offset = "0x876310", VA = "0x180877110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "10")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x876E80", Offset = "0x876080", VA = "0x180876E80", Slot = "11")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "12")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x877200", Offset = "0x876400", VA = "0x180877200", Slot = "6")]
	public EMOEMMBOEPM NNCBLAGJBAP(CFNMCCFLIFF FFIIDDPMMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x876C70", Offset = "0x875E70", VA = "0x180876C70", Slot = "7")]
	public CAEHPHOEGJK CBOIMAPADPA(CFNMCCFLIFF FFIIDDPMMKG)
	{
		return default(CAEHPHOEGJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x877150", Offset = "0x876350", VA = "0x180877150", Slot = "8")]
	public IEnumerator<EMOEMMBOEPM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x877330", Offset = "0x876530", VA = "0x180877330", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3E095C0", Offset = "0x3E087C0", VA = "0x183E095C0", Slot = "13")]
	public void GEAAJEBIOIN<TKey, T>(global::KGLFOOFGNAB<TKey, T> HJJHAMKLCMH, [Optional] object JAEDJGBMHAP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x876D40", Offset = "0x875F40", VA = "0x180876D40", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public IPPIGBPCHEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x877110", Offset = "0x876310", VA = "0x180877110")]
	[CompilerGenerated]
	private EMOEMMBOEPM FMBADOPAMFO(int OCLFFJGEIJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[CLDGIFMABHG(typeof(BMDCNHLNJCM), new string[] { })]
[DefaultMember("Item")]
[OCLKOGGMIFL(typeof(FJGGKJJCIJE))]
public class KMJCHLELAMO : BMDCNHLNJCM, IEnumerable<DDOCKAJKBGF>, IEnumerable, PMOCCIAIAEL, GFHKHHPFFGF, GOKNGONBKFG, AIOPJLICFNI, ANMHEGLHELN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private AEKECOGJAHN JGHMLHPFFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private FJGGKJJCIJE JDDNPNNLOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private DDOCKAJKBGF[] BPJOPKNHLGC;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x87E860", Offset = "0x87DA60", VA = "0x18087E860", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public DDOCKAJKBGF LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x87EB80", Offset = "0x87DD80", VA = "0x18087EB80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public DDOCKAJKBGF LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x87EB80", Offset = "0x87DD80", VA = "0x18087EB80", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "9")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x87EA20", Offset = "0x87DC20", VA = "0x18087EA20", Slot = "10")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x87E610", Offset = "0x87D810", VA = "0x18087E610", Slot = "11")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x87ECB0", Offset = "0x87DEB0", VA = "0x18087ECB0")]
	private DDOCKAJKBGF PHHJHBJEDKC(int MJNAIOAAGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x87EB90", Offset = "0x87DD90", VA = "0x18087EB90", Slot = "6")]
	public DDOCKAJKBGF NNCBLAGJBAP(CFNMCCFLIFF FFIIDDPMMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x87E8B0", Offset = "0x87DAB0", VA = "0x18087E8B0", Slot = "15")]
	public CAEHPHOEGJK CBOIMAPADPA(CFNMCCFLIFF FFIIDDPMMKG)
	{
		return default(CAEHPHOEGJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x87EAA0", Offset = "0x87DCA0", VA = "0x18087EAA0", Slot = "7")]
	public IEnumerator<DDOCKAJKBGF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x87EAA0", Offset = "0x87DCA0", VA = "0x18087EAA0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x3D48B70", Offset = "0x3D47D70", VA = "0x183D48B70", Slot = "12")]
	public void GEAAJEBIOIN<TKey, T>(global::KGLFOOFGNAB<TKey, T> HJJHAMKLCMH, [Optional] object JAEDJGBMHAP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x87E980", Offset = "0x87DB80", VA = "0x18087E980", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public KMJCHLELAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x87EB80", Offset = "0x87DD80", VA = "0x18087EB80")]
	[CompilerGenerated]
	private DDOCKAJKBGF HHOPJOCJHAB(int OCLFFJGEIJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[OCLKOGGMIFL(typeof(EGHMCKEACDK))]
[CLDGIFMABHG(typeof(JDNBIHINJIJ), new string[] { })]
internal class JDNBIHINJIJ : GOKNGONBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private EGHMCKEACDK DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private FJGGKJJCIJE JDDNPNNLOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private BMDCNHLNJCM FDJIJEDPJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private LIODBHBOIBI BPNDICNCALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private global::EGFHNBCKEKK<JJHBGAMPJOH> ONKMFJENELJ;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public FDBMGEEKLNH GPKFGDMOHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6FCDA0", Offset = "0x6FBFA0", VA = "0x1806FCDA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6FD080", Offset = "0x6FC280", VA = "0x1806FD080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x877D00", Offset = "0x876F00", VA = "0x180877D00", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x878070", Offset = "0x877270", VA = "0x180878070")]
	private void POMIPCFHEIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x382B3E0", Offset = "0x382A5E0", VA = "0x18382B3E0")]
	public T AHAEODBOGOD<T>() where T : JJHBGAMPJOH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x877FA0", Offset = "0x8771A0", VA = "0x180877FA0")]
	public PPDCFKFFIMN LMEMDHMOOND(CFNMCCFLIFF JFLKGPEABBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	public global::IPONGJGODFC<T> LMEMDHMOOND<T>(CFNMCCFLIFF JFLKGPEABBP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x877E00", Offset = "0x877000", VA = "0x180877E00")]
	public DDOCKAJKBGF EMIOCMDHBPA(CFNMCCFLIFF JFLKGPEABBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x398E170", Offset = "0x398D370", VA = "0x18398E170")]
	public global::ILGEPPKFGJF<T> EMIOCMDHBPA<T>(CFNMCCFLIFF JFLKGPEABBP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8770D0", VA = "0x180877ED0")]
	public EMOEMMBOEPM HJMKNFHPPLH(CFNMCCFLIFF JFLKGPEABBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	public global::NKCIMBEGPJE<T> HJMKNFHPPLH<T>(CFNMCCFLIFF JFLKGPEABBP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public JDNBIHINJIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class DPAANFIABIF
{
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3989780", Offset = "0x3988980", VA = "0x183989780")]
	public static global::IPONGJGODFC<T> LMEMDHMOOND<T>(this JDNBIHINJIJ BOEJHKMGELC, global::PCAOFNBPEMD<T> JFLKGPEABBP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	public static global::ILGEPPKFGJF<T> EMIOCMDHBPA<T>(this JDNBIHINJIJ BOEJHKMGELC, global::PCAOFNBPEMD<T> JFLKGPEABBP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	public static global::NKCIMBEGPJE<T> HJMKNFHPPLH<T>(this JDNBIHINJIJ BOEJHKMGELC, global::PCAOFNBPEMD<T> JFLKGPEABBP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[CLDGIFMABHG(typeof(KJBEODLBLDH), new string[] { })]
public sealed class KJBEODLBLDH : GOKNGONBKFG, AIOPJLICFNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class ICGIJIMAGBF : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x612CF0", Offset = "0x611EF0", VA = "0x180612CF0")]
		[DebuggerHidden]
		public ICGIJIMAGBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x874C60", Offset = "0x873E60", VA = "0x180874C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8748E0", Offset = "0x873AE0", VA = "0x1808748E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x874D00", Offset = "0x873F00", VA = "0x180874D00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x874C10", Offset = "0x873E10", VA = "0x180874C10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x874B80", Offset = "0x873D80", VA = "0x180874B80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x874B80", Offset = "0x873D80", VA = "0x180874B80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const string DEDJHDLGLJO = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Dictionary<SerializableGuid, CHGMKFJBIIK> PGABAHNJAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly List<SerializableGuid> JEIJGJKIGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly Dictionary<SerializableGuid, GameObject> ACNDAIINMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private AEKECOGJAHN JGHMLHPFFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private BMDCNHLNJCM OMFFMMHBAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private FCFLIDMJBKH FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private BPPHGPLKBFA AJFGIKGFKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private EGHMCKEACDK DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private IOOAJLENKLJ ELANOFHAKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private global::PHJAOEHKDAP<CHGMKFJBIIK> CFABMLKHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GameObject KCKCCJGOJMB;

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x87CD50", Offset = "0x87BF50", VA = "0x18087CD50", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x87C490", Offset = "0x87B690", VA = "0x18087C490", Slot = "5")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x87C7D0", Offset = "0x87B9D0", VA = "0x18087C7D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x87C7C0", Offset = "0x87B9C0", VA = "0x18087C7C0")]
	private void DDCDFAMJIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x87D400", Offset = "0x87C600", VA = "0x18087D400")]
	internal void ONHPDHAFCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x87C5F0", Offset = "0x87B7F0", VA = "0x18087C5F0")]
	private void DCAAFHPMBKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x87CE20", Offset = "0x87C020", VA = "0x18087CE20")]
	private void EMOBFAPIDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x87D240", Offset = "0x87C440", VA = "0x18087D240")]
	[IteratorStateMachine(typeof(ICGIJIMAGBF))]
	private IEnumerable<RRCustomPropTag> NJABHNHINJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x87C920", Offset = "0x87BB20", VA = "0x18087C920")]
	private void EKPJBPKBJFK(DHOEKPEGHDF LALFNHCEDJJ, in JFFJOIBOPJP OENCJDKHNKI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x87D2A0", Offset = "0x87C4A0", VA = "0x18087D2A0")]
	private void NKCPCCNOLCN(SerializableGuid DHMJIJECAJK, GameObject NEFMINHNLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x87CF00", Offset = "0x87C100", VA = "0x18087CF00")]
	private void LIDCMMLGMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x87C2E0", Offset = "0x87B4E0", VA = "0x18087C2E0")]
	private bool BFHPNBOOODO(CHGMKFJBIIK JGCEAIHDPJK, Transform ENAGHEEPLJN, out GameObject BGGBBPALEOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x87D3B0", Offset = "0x87C5B0", VA = "0x18087D3B0")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x87D7E0", Offset = "0x87C9E0", VA = "0x18087D7E0")]
	public KJBEODLBLDH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public SerializableGuid EHDJOJDDHNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7EA030", Offset = "0x7E9230", VA = "0x1807EA030")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xBE7EB0", Offset = "0xBE70B0", VA = "0x180BE7EB0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[CLDGIFMABHG(typeof(DCEFBILCIFI), new string[] { })]
public class INNFAJLBKJI : GOKNGONBKFG, DCEFBILCIFI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private const string CDHCONEEENJ = "ScopeService";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private HOFMJBLAIFM JKCLPGJHEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private AEKECOGJAHN JGHMLHPFFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private JJIAEEMGEDG CCBOCBLOHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private HPHHNPAHGBL DIAADJKCGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private ObjectEmbodimentService MBMBGCPJPOE;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public DHOEKPEGHDF DBLBDNOOBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7EA030", Offset = "0x7E9230", VA = "0x1807EA030", Slot = "7")]
		get
		{
			return default(DHOEKPEGHDF);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8766E0", Offset = "0x8758E0", VA = "0x1808766E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public HOFMJBLAIFM CHKHNNKMHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA030", Offset = "0x7E9230", VA = "0x1807EA030", Slot = "9")]
		get
		{
			return default(HOFMJBLAIFM);
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8766E0", Offset = "0x8758E0", VA = "0x1808766E0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event NGOENDNLLJE IONPBFBEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x876260", Offset = "0x875460", VA = "0x180876260", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x876190", Offset = "0x875390", VA = "0x180876190", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x8760C0", Offset = "0x8752C0", VA = "0x1808760C0", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x875FF0", Offset = "0x8751F0", VA = "0x180875FF0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x876300", Offset = "0x875500", VA = "0x180876300", Slot = "11")]
	public DHOEKPEGHDF HCALPBDFPDF(DHOEKPEGHDF NDAHKJDCMHN, DHOEKPEGHDF HDCGKEELIMP)
	{
		return default(DHOEKPEGHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x876410", Offset = "0x875610", VA = "0x180876410", Slot = "12")]
	public bool JNJEOIADFEB(DHOEKPEGHDF NDAHKJDCMHN, DHOEKPEGHDF HDCGKEELIMP, out DHOEKPEGHDF CICDHHCPFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x875ED0", Offset = "0x8750D0", VA = "0x180875ED0", Slot = "13")]
	public void BJPHGNLAGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x876230", Offset = "0x875430", VA = "0x180876230", Slot = "14")]
	public void FKPFFLFPLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x876700", Offset = "0x875900", VA = "0x180876700", Slot = "15")]
	public bool OANLNGLMECH(DHOEKPEGHDF MLNFOFCNKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x876510", Offset = "0x875710", VA = "0x180876510")]
	private bool JNPEIGDLOPE(DHOEKPEGHDF NFAGOONGDJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x876820", Offset = "0x875A20", VA = "0x180876820")]
	private void ODAGHGLFPJN(HOFMJBLAIFM PBKPNJLDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INNFAJLBKJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[CLDGIFMABHG(typeof(HPHHNPAHGBL), new string[] { })]
public class DKJIDFDDEHP : GOKNGONBKFG, HPHHNPAHGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private EntityManager KHDMOGKDGKL;

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0xA4C000", Offset = "0xA4B200", VA = "0x180A4C000", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0xA4BF90", Offset = "0xA4B190", VA = "0x180A4BF90", Slot = "5")]
	public void EAMNMEMOFLD(DHOEKPEGHDF PLHHAHPCHBA, bool ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3B34500", Offset = "0x3B33700", VA = "0x183B34500")]
	private void CEAJIHNFBDD<T>(DHOEKPEGHDF PLHHAHPCHBA, bool ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public DKJIDFDDEHP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[EJLOOKEAJML(HNJEFABFMIP.RenderEffects)]
	[CLDGIFMABHG(typeof(HLMMHDFADOA), new string[] { })]
	public class SelectionService : GOKNGONBKFG, HLMMHDFADOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private EntityManager KHDMOGKDGKL;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xBE7FA0", Offset = "0xBE71A0", VA = "0x180BE7FA0", Slot = "4")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xBE8010", Offset = "0xBE7210", VA = "0x180BE8010", Slot = "5")]
		public void OGJEJIAEELI(DHOEKPEGHDF PLHHAHPCHBA, bool ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xBE7F30", Offset = "0xBE7130", VA = "0x180BE7F30", Slot = "6")]
		public void CENPKHNLFPL(DHOEKPEGHDF PLHHAHPCHBA, bool ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x3B34500", Offset = "0x3B33700", VA = "0x183B34500")]
		private void CEAJIHNFBDD<T>(DHOEKPEGHDF PLHHAHPCHBA, bool ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[CLDGIFMABHG(typeof(FFENKBFKCFL), new string[] { })]
public class OHGEPAKIDJH : FFENKBFKCFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool APIMGFFCGJL;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool LNDNLFFPGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7CC130", Offset = "0x7CB330", VA = "0x1807CC130", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x884DD0", Offset = "0x883FD0", VA = "0x180884DD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<bool> CKADKOACOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x884D30", Offset = "0x883F30", VA = "0x180884D30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x884C90", Offset = "0x883E90", VA = "0x180884C90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public OHGEPAKIDJH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CLDGIFMABHG(typeof(BPPHGPLKBFA), new string[] { })]
	[EJLOOKEAJML(HNJEFABFMIP.Serialization, new string[] { "Timing" })]
	public class SerializationService : GOKNGONBKFG, BPPHGPLKBFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct GGOGNJCJNDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public IOGLPDMJKOD IFJHFPNANIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public IOGLPDMJKOD KACIFCJDJGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public IOGLPDMJKOD POODLFJINBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public IOGLPDMJKOD OBOJOBCGLKO;

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xBDF320", Offset = "0xBDE520", VA = "0x180BDF320")]
			public static GGOGNJCJNDO KPGMNJIIOMJ()
			{
				return default(GGOGNJCJNDO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
			[Conditional("DEBUG_WORLDS")]
			public void DIPAICNNLME()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct IOGLPDMJKOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
			public IOGLPDMJKOD(string ILPNDFPPNDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
			public void DOKEOMHJJHM(EntityManager ILPNDFPPNDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
			public void DIPAICNNLME()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private const string BEFJGNNKBAJ = "Timing";

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static readonly MKIMOBFPILG BEJEBKGLHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private AMEKELGLMNH NHJMFHJKDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private EGHMCKEACDK DDCODOIGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private FFENKBFKCFL IJGKAGDLIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private AEKECOGJAHN JGHMLHPFFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private SerializationRemapScope ANCCCNEIKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private PDFECNJDFGM KIOLEKBJBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private CKNBLIKCIHM NOBFFCOKOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private bool? PCIJIMKDJIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private GGOGNJCJNDO OPJLBHPDNFE;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool BOOBIECEIEG
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xBE8910", Offset = "0xBE7B10", VA = "0x180BE8910", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xBE9EA0", Offset = "0xBE90A0", VA = "0x180BE9EA0", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action NPLPPPBABMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xBE9590", Offset = "0xBE8790", VA = "0x180BE9590", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xBE9EB0", Offset = "0xBE90B0", VA = "0x180BE9EB0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<FCJNKFAIKGM> OJEHAGGHPMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xBEAC20", Offset = "0xBE9E20", VA = "0x180BEAC20", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xBEB530", Offset = "0xBEA730", VA = "0x180BEB530", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action KFCENFEINOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xBE8870", Offset = "0xBE7A70", VA = "0x180BE8870", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xBEA670", Offset = "0xBE9870", VA = "0x180BEA670", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action IKHOIGCNCMD
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xBEA2D0", Offset = "0xBE94D0", VA = "0x180BEA2D0", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xBE8DB0", Offset = "0xBE7FB0", VA = "0x180BE8DB0", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<FCJNKFAIKGM> DJMGKBAGAGP
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xBEAB80", Offset = "0xBE9D80", VA = "0x180BEAB80", Slot = "23")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xBE94F0", Offset = "0xBE86F0", VA = "0x180BE94F0", Slot = "24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xBE93F0", Offset = "0xBE85F0", VA = "0x180BE93F0", Slot = "4")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xBE8F50", Offset = "0xBE8150", VA = "0x180BE8F50", Slot = "11")]
		public void CMOGICPOHII(bool GOODPFDDLAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xBEAD00", Offset = "0xBE9F00", VA = "0x180BEAD00", Slot = "13")]
		public ByteString LIOPAMDCNLD(out IDisposable ANCCCNEIKMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xBEAF60", Offset = "0xBEA160", VA = "0x180BEAF60", Slot = "12")]
		public ByteString LIOPAMDCNLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xBEACC0", Offset = "0xBE9EC0", VA = "0x180BEACC0", Slot = "16")]
		public bool LGPKACCHBHO(ByteString IBDKAICGDEO, GAHHNAEDOLN NKBIJCGCLBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xBEAAB0", Offset = "0xBE9CB0", VA = "0x180BEAAB0", Slot = "17")]
		public bool JLFHHPLFPKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xBEA850", Offset = "0xBE9A50", VA = "0x180BEA850", Slot = "14")]
		public void JIAPGMHHACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xBE8920", Offset = "0xBE7B20", VA = "0x180BE8920", Slot = "27")]
		public void BCFPLKENGMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xBE9D00", Offset = "0xBE8F00", VA = "0x180BE9D00", Slot = "15")]
		public void GGMLNHBIAIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xBE8AC0", Offset = "0xBE7CC0", VA = "0x180BE8AC0", Slot = "18")]
		public bool BFPALEJIJOI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xBEB2E0", Offset = "0xBEA4E0", VA = "0x180BEB2E0", Slot = "19")]
		public bool MBJBJCHFBCC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xBE9C50", Offset = "0xBE8E50", VA = "0x180BE9C50")]
		private void GEMEEDBJJIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xBEB790", Offset = "0xBEA990", VA = "0x180BEB790")]
		private void NLMLAKCGMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xBE8750", Offset = "0xBE7950", VA = "0x180BE8750")]
		private void AHIPAOOEIAA(KOCANCNOGKA GIMMGJCHPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xBEA7B0", Offset = "0xBE99B0", VA = "0x180BEA7B0")]
		private ByteString JCFEDEBBIHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xBE8E50", Offset = "0xBE8050", VA = "0x180BE8E50")]
		private ByteString CJBCGMKDCBE(ByteString DGNKACAAPPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xBEA200", Offset = "0xBE9400", VA = "0x180BEA200")]
		private bool HBCJOPPEILP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xBE9630", Offset = "0xBE8830", VA = "0x180BE9630")]
		private void FONJGJHGEEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xBE90A0", Offset = "0xBE82A0", VA = "0x180BE90A0")]
		private void EMDJPPJOMJI(out ByteString DGNKACAAPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xBEA370", Offset = "0xBE9570", VA = "0x180BEA370")]
		private bool HFBNAFOJHJA(ByteString IBDKAICGDEO, GAHHNAEDOLN NKBIJCGCLBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xBE99A0", Offset = "0xBE8BA0", VA = "0x180BE99A0")]
		private bool FPEIFGIGCHE(ByteString IBDKAICGDEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xBEB110", Offset = "0xBEA310", VA = "0x180BEB110")]
		private bool LNGKAPKCPNP(CKNBLIKCIHM.KDANJPMPIOD.BOABFEIFLGN HBNKOANCKDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xBE9F50", Offset = "0xBE9150", VA = "0x180BE9F50")]
		private void GPNGAEKNJJK(FCJNKFAIKGM GIMMGJCHPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xBEA710", Offset = "0xBE9910", VA = "0x180BEA710")]
		private KOCANCNOGKA ILCPELBLEMF(EntityManager DEFCDNIJJDA, EntityManager IFOLEAAACCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xBEA8F0", Offset = "0xBE9AF0", VA = "0x180BEA8F0")]
		private void JKCBHIFFBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xBEB5D0", Offset = "0xBEA7D0", VA = "0x180BEB5D0")]
		private void NLALCDJNEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xBEA810", Offset = "0xBE9A10", VA = "0x180BEA810")]
		private void JHLBKDBAHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xBEA860", Offset = "0xBE9A60", VA = "0x180BEA860")]
		private CKNBLIKCIHM.KDANJPMPIOD.BOABFEIFLGN JIBHBFDHBNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[CLDGIFMABHG(typeof(MOJMKJEGPOA), new string[] { })]
public class MOJMKJEGPOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly Dictionary<HLDDLEKEHIF, string> AMCGOEBPKLN;

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x881CF0", Offset = "0x880EF0", VA = "0x180881CF0")]
	public GameObject JNJIPNFPNBG(HLDDLEKEHIF OAJEHFNGELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x881DA0", Offset = "0x880FA0", VA = "0x180881DA0")]
	public MOJMKJEGPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[CLDGIFMABHG(typeof(NMAKAILEMCE), new string[] { })]
public class HDNNAAHPFCO : NMAKAILEMCE
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x870A60", Offset = "0x86FC60", VA = "0x180870A60", Slot = "5")]
	public void NNCHDDDBOKD(object HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8708B0", Offset = "0x86FAB0", VA = "0x1808708B0", Slot = "6")]
	public void IKNAPHLFBOC(object HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x870B20", Offset = "0x86FD20", VA = "0x180870B20", Slot = "7")]
	public void PPHIBFAODNF(object HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x870970", Offset = "0x86FB70", VA = "0x180870970", Slot = "4")]
	public IDisposable KNDEDNHHGCL(object HGHEMBBLDIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public HDNNAAHPFCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[CLDGIFMABHG(typeof(HCBALMHELIH), new string[] { })]
public class MFODEMNEAFA : GOKNGONBKFG, HCBALMHELIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private EGHMCKEACDK DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private KBDEJNINBDJ LEBOMJCIFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private FFENKBFKCFL EIJIKEIPNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private TransformOwnershipPhase EIMDLFDFABL;

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x8816D0", Offset = "0x8808D0", VA = "0x1808816D0", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x881990", Offset = "0x880B90", VA = "0x180881990", Slot = "6")]
	public void PMFHFEFHDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x881890", Offset = "0x880A90", VA = "0x180881890", Slot = "5")]
	public void OBFOELDCBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x8815B0", Offset = "0x8807B0", VA = "0x1808815B0", Slot = "7")]
	public void EDICBOOHLBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x8812F0", Offset = "0x8804F0", VA = "0x1808812F0", Slot = "8")]
	public void BLHKCNJCBOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x8813F0", Offset = "0x8805F0", VA = "0x1808813F0", Slot = "9")]
	public void DNFDNGOOIJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x881780", Offset = "0x880980", VA = "0x180881780", Slot = "10")]
	public void HNIPBMAPDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x8817F0", Offset = "0x8809F0", VA = "0x1808817F0", Slot = "11")]
	public void NJPHIGCGDMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public MFODEMNEAFA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CLDGIFMABHG(typeof(BCEBIIAIFJH), new string[] { })]
	[EJLOOKEAJML(HNJEFABFMIP.TransformSyncing)]
	public class TransformService : BCEBIIAIFJH, GOKNGONBKFG, AIOPJLICFNI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private EGHMCKEACDK DDCODOIGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private AEKECOGJAHN JGHMLHPFFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private JJIAEEMGEDG CCBOCBLOHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TransformOwnershipPhase EABNCBPPNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private global::IPONGJGODFC<Entity> ENAGHEEPLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private ObjectEmbodimentService AJJHOLKBJCH;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private EntityManager POMAKGKDHPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x280E260", Offset = "0x280D460", VA = "0x18280E260")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private IOOAJLENKLJ CIDDIKGGDGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x280AFB0", Offset = "0x280A1B0", VA = "0x18280AFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x280ACF0", Offset = "0x2809EF0", VA = "0x18280ACF0", Slot = "33")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2809E90", Offset = "0x2809090", VA = "0x182809E90", Slot = "34")]
		public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x280A590", Offset = "0x2809790", VA = "0x18280A590", Slot = "35")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x280CD00", Offset = "0x280BF00", VA = "0x18280CD00", Slot = "36")]
		public bool KFLLEJFCPBG(Transform EJOKPJGAPEO, out DHOEKPEGHDF LALFNHCEDJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x280DC80", Offset = "0x280CE80", VA = "0x18280DC80", Slot = "37")]
		public Transform MLDEHACHCPK(Entity BBPBBOAPCHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x280ADC0", Offset = "0x2809FC0", VA = "0x18280ADC0", Slot = "31")]
		public bool FKHKOKAODEG(Entity BBPBBOAPCHN, out Transform EJOKPJGAPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x280DD40", Offset = "0x280CF40", VA = "0x18280DD40")]
		private void MMLHENBLLAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x280AA10", Offset = "0x2809C10", VA = "0x18280AA10", Slot = "30")]
		public void EELFCKFPCFI(Entity BBPBBOAPCHN, out Matrix4x4 IHANCHLNHGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x280E5A0", Offset = "0x280D7A0", VA = "0x18280E5A0", Slot = "4")]
		public void PHMOJMIPLOJ(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x28099C0", Offset = "0x2808BC0", VA = "0x1828099C0")]
		private void ACBGBNACCMG(Entity BBPBBOAPCHN, Vector3 EMHBBLDAMOB, Quaternion BNPOLGHMEPL, Vector3 CKEDAAHMAAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x280B410", Offset = "0x280A610", VA = "0x18280B410")]
		private void HKONKNLBFEN(Entity BBPBBOAPCHN, Vector3 EMHBBLDAMOB, Quaternion BNPOLGHMEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x280DB90", Offset = "0x280CD90", VA = "0x18280DB90", Slot = "28")]
		public void MIBLEHNOOLI(Entity BBPBBOAPCHN, out Matrix4x4 LIHPPIDMKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x280B6B0", Offset = "0x280A8B0", VA = "0x18280B6B0")]
		public void IGDNNLEEPJF(Entity BBPBBOAPCHN, in Matrix4x4 IHANCHLNHGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x280E390", Offset = "0x280D590", VA = "0x18280E390")]
		private void PFHGHKJOMFP(Entity BBPBBOAPCHN, in Matrix4x4 MHAEGOAELMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x280A3C0", Offset = "0x28095C0", VA = "0x18280A3C0", Slot = "5")]
		public void DEPHFJIKPCF(Entity BBPBBOAPCHN, Vector3 ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x280DF40", Offset = "0x280D140", VA = "0x18280DF40", Slot = "6")]
		public Vector3 NMELMNFMDNI(Entity BBPBBOAPCHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x280B560", Offset = "0x280A760", VA = "0x18280B560", Slot = "7")]
		public void ICEIMFJPDBH(Entity BBPBBOAPCHN, Quaternion ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x280BD50", Offset = "0x280AF50", VA = "0x18280BD50", Slot = "8")]
		public Quaternion IPNAFALGPDK(Entity BBPBBOAPCHN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x280AEB0", Offset = "0x280A0B0", VA = "0x18280AEB0", Slot = "13")]
		public void FNFKJPAIMJN(Entity BBPBBOAPCHN, Vector3 ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x280C4B0", Offset = "0x280B6B0", VA = "0x18280C4B0", Slot = "12")]
		public Vector3 JJAJEGNGBJC(Entity BBPBBOAPCHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x280A4F0", Offset = "0x28096F0", VA = "0x18280A4F0")]
		private void DMJDBJOCPJN(Entity BBPBBOAPCHN, Vector3 ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x280D6C0", Offset = "0x280C8C0", VA = "0x18280D6C0")]
		private Vector3 KKBCHCADOLP(Entity BBPBBOAPCHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x280E1C0", Offset = "0x280D3C0", VA = "0x18280E1C0", Slot = "15")]
		public float OMCOCJALOLK(Entity BBPBBOAPCHN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x280B070", Offset = "0x280A270", VA = "0x18280B070", Slot = "14")]
		public void GIHBGDIDMLB(Entity BBPBBOAPCHN, float ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x280DD60", Offset = "0x280CF60", VA = "0x18280DD60")]
		private float MPFJNDBDEFC(Entity BBPBBOAPCHN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x280C0A0", Offset = "0x280B2A0", VA = "0x18280C0A0")]
		private void JCKPFABKDFO(Entity BBPBBOAPCHN, float BBOOIIGFBKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x280DBA0", Offset = "0x280CDA0", VA = "0x18280DBA0", Slot = "17")]
		public Vector3 MKBOCKEFBCB(Entity BBPBBOAPCHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x280E050", Offset = "0x280D250", VA = "0x18280E050", Slot = "16")]
		public void NPDFPJCGLCF(Entity BBPBBOAPCHN, Vector3 KFFFAKDLHKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x280BC30", Offset = "0x280AE30", VA = "0x18280BC30")]
		private Vector3 ININBMJFLOO(Entity BBPBBOAPCHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x280E860", Offset = "0x280DA60", VA = "0x18280E860")]
		private void PHNJJGHFHGG(Entity BBPBBOAPCHN, Vector3 ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2809CD0", Offset = "0x2808ED0", VA = "0x182809CD0")]
		[Conditional("DEBUG_BUILD")]
		private void BGGCPAFFFOP(Entity BBPBBOAPCHN, Vector3 ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x280C5F0", Offset = "0x280B7F0", VA = "0x18280C5F0", Slot = "9")]
		public void JLFLANACICI(Entity BBPBBOAPCHN, Vector3 BCCJFEBGGPE, Quaternion PAOOIKIKMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x280B1E0", Offset = "0x280A3E0", VA = "0x18280B1E0", Slot = "10")]
		public void GONHMFIFFEI(Entity BBPBBOAPCHN, out Vector3 BCCJFEBGGPE, out Quaternion PAOOIKIKMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x280A870", Offset = "0x2809A70", VA = "0x18280A870", Slot = "11")]
		public void EEFKGKGMLDE(Entity BBPBBOAPCHN, out Vector3 BCCJFEBGGPE, out Quaternion PAOOIKIKMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x280A610", Offset = "0x2809810", VA = "0x18280A610", Slot = "18")]
		public void EANHIICINCN(Entity BBPBBOAPCHN, Vector3 ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2809B70", Offset = "0x2808D70", VA = "0x182809B70", Slot = "19")]
		public Vector3 ALKNJIIODPF(Entity BBPBBOAPCHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2809F90", Offset = "0x2809190", VA = "0x182809F90", Slot = "20")]
		public void BJLEIPKPPIO(Entity BBPBBOAPCHN, Quaternion ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x280ABF0", Offset = "0x2809DF0", VA = "0x18280ABF0", Slot = "21")]
		public Quaternion EEOFLKGLNOB(Entity BBPBBOAPCHN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x280CE90", Offset = "0x280C090", VA = "0x18280CE90", Slot = "23")]
		public void KILEJFHKDPC(Entity BBPBBOAPCHN, Vector3 ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x280DE40", Offset = "0x280D040", VA = "0x18280DE40", Slot = "22")]
		public Vector3 NHHIECNDLCI(Entity BBPBBOAPCHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x280C7D0", Offset = "0x280B9D0", VA = "0x18280C7D0", Slot = "24")]
		public void KCOLGHOMFNF(Entity BBPBBOAPCHN, float LPCDFOKGILH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x280BB10", Offset = "0x280AD10", VA = "0x18280BB10", Slot = "25")]
		public float IJOPPCJACJC(Entity BBPBBOAPCHN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x280D270", Offset = "0x280C470", VA = "0x18280D270", Slot = "26")]
		public void KJONOIJEGPD(Entity BBPBBOAPCHN, Vector3 HLCJJGGEJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x280A270", Offset = "0x2809470", VA = "0x18280A270", Slot = "27")]
		public Vector3 BMHLDBJBONA(Entity BBPBBOAPCHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x280D790", Offset = "0x280C990", VA = "0x18280D790", Slot = "32")]
		public void KPLDBANFGKE(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x280BFE0", Offset = "0x280B1E0", VA = "0x18280BFE0")]
		private void IPNCNPDNAOA(Entity BBPBBOAPCHN, in JFFJOIBOPJP OENCJDKHNKI, in JFFJOIBOPJP DNIHHNBJJIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x280BEB0", Offset = "0x280B0B0", VA = "0x18280BEB0")]
		private void IPNCNPDNAOA(Entity BBPBBOAPCHN, in Entity GDGMBLIDIJF, in Entity NHDMOENBBDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x280B390", Offset = "0x280A590", VA = "0x18280B390")]
		private MIBHOHDEJPI GONHMFIFFEI(Entity BBPBBOAPCHN)
		{
			return default(MIBHOHDEJPI);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x280E2B0", Offset = "0x280D4B0", VA = "0x18280E2B0")]
		private bool PBAPPGBPNIO(Entity BBPBBOAPCHN, out Entity ENAGHEEPLJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x280CAD0", Offset = "0x280BCD0", VA = "0x18280CAD0")]
		private void KEHICFEPGDL(Entity BBPBBOAPCHN, out Matrix4x4 IHANCHLNHGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x280C130", Offset = "0x280B330", VA = "0x18280C130")]
		public void JGBECMADANC(Entity BBPBBOAPCHN, out Matrix4x4 MHAEGOAELMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x280ABE0", Offset = "0x2809DE0", VA = "0x18280ABE0", Slot = "29")]
		private void EENPEBDHHLF(Entity BBPBBOAPCHN, in Matrix4x4 LIHPPIDMKMB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[CLDGIFMABHG(typeof(AEKBEKMKIII), new string[] { })]
public class AEKBEKMKIII
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct LMBKMAFMFOJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly AEKBEKMKIII ENAGHEEPLJN;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA56DA0", Offset = "0xA55FA0", VA = "0x180A56DA0")]
		public LMBKMAFMFOJ(AEKBEKMKIII ENAGHEEPLJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA56D60", Offset = "0xA55F60", VA = "0x180A56D60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int CEEOCEKNBME;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool BNHFDIFDOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA45890", Offset = "0xA44A90", VA = "0x180A45890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action EOKFJGAJHNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA457F0", Offset = "0xA449F0", VA = "0x180A457F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xA458A0", Offset = "0xA44AA0", VA = "0x180A458A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0xA457A0", Offset = "0xA449A0", VA = "0x180A457A0")]
	public LMBKMAFMFOJ BMDNNOGKOIF()
	{
		return default(LMBKMAFMFOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0xA457E0", Offset = "0xA449E0", VA = "0x180A457E0")]
	public void GDBNCDMFDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0xA45940", Offset = "0xA44B40", VA = "0x180A45940")]
	public void NNILMCILDOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public AEKBEKMKIII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[CLDGIFMABHG(typeof(EGHMCKEACDK), new string[] { })]
[OCLKOGGMIFL(typeof(OKCGOAGJMMI))]
public class GMMDFPCBMHE : EGHMCKEACDK, IDisposable, PMOCCIAIAEL, GFHKHHPFFGF, GOKNGONBKFG, AIOPJLICFNI
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class PLJNNLOMLAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public AMEKELGLMNH services;

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PLJNNLOMLAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xA58170", Offset = "0xA57370", VA = "0x180A58170")]
		internal void <InitReferences>b__0(GOKNGONBKFG svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class LMIJENHEEMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public AMEKELGLMNH services;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LMIJENHEEMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA56DD0", Offset = "0xA55FD0", VA = "0x180A56DD0")]
		internal void <InitExternal>b__0(AIOPJLICFNI svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker GNCKACFHCDC;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker PJMKEPHBOIG;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker GJBLADICILM;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly ProfilerMarker ALEGOGCKJFD;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly ProfilerMarker BBMPEALICDM;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly ProfilerMarker LDLJNKPCAEH;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly ProfilerMarker EGMAKBFLIGJ;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly ProfilerMarker ALFLEOJGBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private EDJHMIKNCNB DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public EDJHMIKNCNB IELCOFCMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public IOOAJLENKLJ CIDDIKGGDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA53ED0", Offset = "0xA530D0", VA = "0x180A53ED0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EntityManager POMAKGKDHPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA36750", Offset = "0xA35950", VA = "0x180A36750", Slot = "9")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public KHADGDCMOKK HIAJLBNENIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FD450", Offset = "0x6FC650", VA = "0x1806FD450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action IBHLMHNBMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA53D40", Offset = "0xA52F40", VA = "0x180A53D40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA53750", Offset = "0xA52950", VA = "0x180A53750", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0xA540D0", Offset = "0xA532D0", VA = "0x180A540D0", Slot = "21")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0xA53B70", Offset = "0xA52D70", VA = "0x180A53B70", Slot = "22")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0xA536A0", Offset = "0xA528A0", VA = "0x180A536A0", Slot = "23")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0xA54470", Offset = "0xA53670", VA = "0x180A54470", Slot = "11")]
	public void PBHLHKNKPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0xA53EF0", Offset = "0xA530F0", VA = "0x180A53EF0", Slot = "12")]
	public void HHACLDBEAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0xA54350", Offset = "0xA53550", VA = "0x180A54350", Slot = "14")]
	public void NFNIPMBIJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0xA54560", Offset = "0xA53760", VA = "0x180A54560", Slot = "15")]
	public void PCKJAIDOILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xA53C50", Offset = "0xA52E50", VA = "0x180A53C50", Slot = "13")]
	public void EPDILLFJAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0xA53DE0", Offset = "0xA52FE0", VA = "0x180A53DE0", Slot = "16")]
	public void FNBABIKNEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0xA535B0", Offset = "0xA527B0", VA = "0x180A535B0", Slot = "17")]
	public void AKGGGPHDKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xA53FE0", Offset = "0xA531E0", VA = "0x180A53FE0", Slot = "18")]
	public void IPJJBCEHFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xA54440", Offset = "0xA53640", VA = "0x180A54440", Slot = "19")]
	public void OLFLGELIMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xA54310", Offset = "0xA53510", VA = "0x180A54310", Slot = "24")]
	public void LKOFAGEBHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0xA537F0", Offset = "0xA529F0", VA = "0x180A537F0")]
	private void CNOGLGNGFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xA53980", Offset = "0xA52B80", VA = "0x180A53980", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0xA54650", Offset = "0xA53850", VA = "0x180A54650", Slot = "10")]
	public ComponentSystemBase PFGFIEDBPGP(Type BGMCKNGNOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xA53950", Offset = "0xA52B50", VA = "0x180A53950")]
	public bool DLOHPBEGKPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public GMMDFPCBMHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class FNPDLCBHAFM<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly Func<From, To> NLICJCFEPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly Func<To, From> PIGOKANGDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public DynamicBuffer<From> MNCACBMIHMI;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public To LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool BNGNOGOPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	public FNPDLCBHAFM(Func<From, To> NLICJCFEPKK, Func<To, From> PIGOKANGDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] NAJOFPKLJJG, int LEAMOGPCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To BCDFAIJCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int MJNAIOAAGCG, To BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[DefaultMember("Item")]
public class MJFEPKOILIK<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly Func<From, To> NLICJCFEPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Func<To, From> PIGOKANGDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public List<From> MDBHJOENILE;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public To LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x1C944B0", Offset = "0x1C936B0", VA = "0x181C944B0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x1C94510", Offset = "0x1C93710", VA = "0x181C94510", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1C94480", Offset = "0x1C93680", VA = "0x181C94480", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BNGNOGOPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x7E7390", Offset = "0x7E6590", VA = "0x1807E7390", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7E7600", Offset = "0x7E6800", VA = "0x1807E7600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1C943F0", Offset = "0x1C935F0", VA = "0x181C943F0")]
	public MJFEPKOILIK(Func<From, To> NLICJCFEPKK, Func<To, From> PIGOKANGDMJ, bool FOOOLENCPCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1C93FE0", Offset = "0x1C931E0", VA = "0x181C93FE0", Slot = "11")]
	public void Add(To BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1C94040", Offset = "0x1C93240", VA = "0x181C94040", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x1C94070", Offset = "0x1C93270", VA = "0x181C94070", Slot = "13")]
	public bool Contains(To BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1C940D0", Offset = "0x1C932D0", VA = "0x181C940D0", Slot = "14")]
	public void CopyTo(To[] NAJOFPKLJJG, int LEAMOGPCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x1C941E0", Offset = "0x1C933E0", VA = "0x181C941E0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1C94250", Offset = "0x1C93450", VA = "0x181C94250", Slot = "6")]
	public int IndexOf(To BCDFAIJCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x1C942B0", Offset = "0x1C934B0", VA = "0x181C942B0", Slot = "7")]
	public void Insert(int MJNAIOAAGCG, To BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x1C94360", Offset = "0x1C93560", VA = "0x181C94360", Slot = "15")]
	public bool Remove(To BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x1C94330", Offset = "0x1C93530", VA = "0x181C94330", Slot = "8")]
	public void RemoveAt(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x1C943C0", Offset = "0x1C935C0", VA = "0x181C943C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class LDMEDGCEDFK<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Func<From, To> NLICJCFEPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Func<To, From> PIGOKANGDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<From> NAJOFPKLJJG;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public To LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x21AAA70", Offset = "0x21A9C70", VA = "0x1821AAA70", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x21AAAC0", Offset = "0x21A9CC0", VA = "0x1821AAAC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x21AAA30", Offset = "0x21A9C30", VA = "0x1821AAA30", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool BNGNOGOPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x601070", Offset = "0x600270", VA = "0x180601070", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x1E06500", Offset = "0x1E05700", VA = "0x181E06500")]
	public LDMEDGCEDFK(Func<From, To> NLICJCFEPKK, Func<To, From> PIGOKANGDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x21AA5C0", Offset = "0x21A97C0", VA = "0x1821AA5C0", Slot = "11")]
	public void Add(To BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x21AA610", Offset = "0x21A9810", VA = "0x1821AA610", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x21AA660", Offset = "0x21A9860", VA = "0x1821AA660", Slot = "13")]
	public bool Contains(To BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x21AA720", Offset = "0x21A9920", VA = "0x1821AA720", Slot = "14")]
	public void CopyTo(To[] NAJOFPKLJJG, int LEAMOGPCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x21AA7E0", Offset = "0x21A99E0", VA = "0x1821AA7E0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x21AA8A0", Offset = "0x21A9AA0", VA = "0x1821AA8A0", Slot = "6")]
	public int IndexOf(To BCDFAIJCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x21AA910", Offset = "0x21A9B10", VA = "0x1821AA910", Slot = "7")]
	public void Insert(int MJNAIOAAGCG, To BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x21AA9B0", Offset = "0x21A9BB0", VA = "0x1821AA9B0", Slot = "15")]
	public bool Remove(To BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x21AA960", Offset = "0x21A9B60", VA = "0x1821AA960", Slot = "8")]
	public void RemoveAt(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x21AAA00", Offset = "0x21A9C00", VA = "0x1821AAA00", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public class GNPGKCICKNH<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly Func<From, To> NLICJCFEPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Func<To, From> PIGOKANGDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeList<From> MDBHJOENILE;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public To LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool BNGNOGOPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	public GNPGKCICKNH(Func<From, To> NLICJCFEPKK, Func<To, From> PIGOKANGDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] NAJOFPKLJJG, int LEAMOGPCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To BCDFAIJCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int MJNAIOAAGCG, To BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class PAKJLDPKNNP
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public const string HCLPOCBAOEC = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public const string EGPKGJPHOIA = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const string OCHJKMBNOAH = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public const string KMCJNCBIGAB = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public const string NBHGKCJBELG = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public const string MBHICBICBCL = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public const string KHIIALPJFJC = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class AFOBOCENCIH
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class LLEPDPHLNON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public AMEKELGLMNH services;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LLEPDPHLNON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xA56CA0", Offset = "0xA55EA0", VA = "0x180A56CA0")]
		internal void <InitServices>b__1(GOKNGONBKFG svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xA56D00", Offset = "0xA55F00", VA = "0x180A56D00")]
		internal void <InitServices>b__2(AIOPJLICFNI svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0xA45960", Offset = "0xA44B60", VA = "0x180A45960")]
	public static void DCAKHOAGEAP(this EDJHMIKNCNB DDCODOIGKNL, AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x449EAE0", Offset = "0x449DCE0", VA = "0x18449EAE0")]
	public static void GIDEMBIJCGK<T>(this EDJHMIKNCNB DDCODOIGKNL, Action<T> IKOJFLIBBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x449EDB0", Offset = "0x449DFB0", VA = "0x18449EDB0")]
	public static void PEODIAPHEOF<T>(this EDJHMIKNCNB DDCODOIGKNL, Action<T> IKOJFLIBBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x449E940", Offset = "0x449DB40", VA = "0x18449E940")]
	public static void ECJGKGBLGNE<T>(this EDJHMIKNCNB DDCODOIGKNL, Action<T> IKOJFLIBBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x449E7A0", Offset = "0x449D9A0", VA = "0x18449E7A0")]
	public static void EAHPBHGLIFB<T>(this EDJHMIKNCNB DDCODOIGKNL, Action<T> IKOJFLIBBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x449EC10", Offset = "0x449DE10", VA = "0x18449EC10")]
	public static void PBCPIEKEEDC<T>(this EDJHMIKNCNB DDCODOIGKNL, Action<T> IKOJFLIBBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x449EB50", Offset = "0x449DD50", VA = "0x18449EB50")]
	private static void LJEIILGPGJE<T>(object ENPNPHHDFHK, Action<T> IKOJFLIBBAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class LMLDKGHFOEL
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class JNPJKOHBCPF
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	public static bool MNKAKGOLKII<T>(ref T PJIOBOBOEGF, ref T KLGGEDCBMPK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class HIHLPIJCEGP
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class GBHKDHAJPPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public GBHKDHAJPPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x873F90", Offset = "0x873190", VA = "0x180873F90")]
	public static string CJBEGBAHGFJ(Transform EJOKPJGAPEO, Transform MLNFOFCNKEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class OOANADMLMDL : FAKGMCIHLJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly MethodInfo LHIPIOJJDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Type[] HHILANAMFFB;

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xBE22C0", Offset = "0xBE14C0", VA = "0x180BE22C0")]
	public OOANADMLMDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action DDGHHDOPANK();

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0xBE20F0", Offset = "0xBE12F0", VA = "0x180BE20F0")]
	public MethodInfo JFAJCCIPMDN(Action GHCLFMPOHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xBE2130", Offset = "0xBE1330", VA = "0x180BE2130", Slot = "4")]
	public void NKCPCCNOLCN(Type BGMCKNGNOJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public abstract class NEHMDFHLFAD : OOANADMLMDL
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private enum BMNBMEKIDFM
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x883CB0", Offset = "0x882EB0", VA = "0x180883CB0", Slot = "5")]
	public override Action DDGHHDOPANK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void ANCFPGDFLKA<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x883D30", Offset = "0x882F30", VA = "0x180883D30")]
	[Preserve]
	public void OHFKNGMELFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x880790", Offset = "0x87F990", VA = "0x180880790")]
	protected NEHMDFHLFAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class LKKFILKBBNL : OOANADMLMDL
{
	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x880690", Offset = "0x87F890", VA = "0x180880690", Slot = "5")]
	public override Action DDGHHDOPANK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void NPPLNEKGCAE<T>() where T : JFOPHLNANAA;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x880710", Offset = "0x87F910", VA = "0x180880710")]
	[Preserve]
	public void OHFKNGMELFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x880790", Offset = "0x87F990", VA = "0x180880790")]
	protected LKKFILKBBNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class HAPNGKNEEBN : OOANADMLMDL
{
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0xA55740", Offset = "0xA54940", VA = "0x180A55740", Slot = "5")]
	public override Action DDGHHDOPANK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void JGMGEPNCHMK<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0xA557C0", Offset = "0xA549C0", VA = "0x180A557C0")]
	[Preserve]
	public void OHFKNGMELFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x880790", Offset = "0x87F990", VA = "0x180880790")]
	protected HAPNGKNEEBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[CLDGIFMABHG(typeof(KHADGDCMOKK), new string[] { })]
public class EFLMAGNMOMO : FFBEKOPNCCJ, KHADGDCMOKK
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public AMEKELGLMNH LKELHKMJNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE480", Offset = "0x6ED680", VA = "0x1806EE480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public FCFLIDMJBKH JMGKCHFPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public EGHMCKEACDK IELCOFCMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD20", Offset = "0x5FCF20", VA = "0x1805FDD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public HCBALMHELIH NCBFHMCBIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x6FD450", Offset = "0x6FC650", VA = "0x1806FD450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public OKCGOAGJMMI LDAEFFDAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x734270", Offset = "0x733470", VA = "0x180734270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x7D6460", Offset = "0x7D5660", VA = "0x1807D6460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public AEKECOGJAHN JBHNJEIAGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x6FCDA0", Offset = "0x6FBFA0", VA = "0x1806FCDA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x6FD080", Offset = "0x6FC280", VA = "0x1806FD080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public JJIAEEMGEDG OIHMKLFPNPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF50", Offset = "0x5FA150", VA = "0x1805FAF50", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF60", Offset = "0x5FA160", VA = "0x1805FAF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public BCEBIIAIFJH LKNCMBAGBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x5F8940", Offset = "0x5F7B40", VA = "0x1805F8940", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x5F8B80", Offset = "0x5F7D80", VA = "0x1805F8B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public BPPHGPLKBFA KANAMLLJLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x6163F0", Offset = "0x6155F0", VA = "0x1806163F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x7D5FA0", Offset = "0x7D51A0", VA = "0x1807D5FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public KBDEJNINBDJ IGIFDBHNLCF
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x6A12A0", Offset = "0x6A04A0", VA = "0x1806A12A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBB10", VA = "0x1807DC910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public FFENKBFKCFL GDFGHACICFN
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x6D20C0", Offset = "0x6D12C0", VA = "0x1806D20C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF9D0", Offset = "0x5FEBD0", VA = "0x1805FF9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public BMDCNHLNJCM APBOEKKLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x698F60", Offset = "0x698160", VA = "0x180698F60", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x6FD120", Offset = "0x6FC320", VA = "0x1806FD120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public ANNKKHJFDMC DIMOKDPOAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x605680", Offset = "0x604880", VA = "0x180605680", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x604180", Offset = "0x603380", VA = "0x180604180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public ONCONOLCJEF DJBFLBBPGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6055A0", Offset = "0x6047A0", VA = "0x1806055A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x6D42F0", Offset = "0x6D34F0", VA = "0x1806D42F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public DCEFBILCIFI MGPOHCGAMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x699010", Offset = "0x698210", VA = "0x180699010", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEA0", Offset = "0x7DE0A0", VA = "0x1807DEEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public FLNKGJHGIEC MNNDBMMNPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x698F70", Offset = "0x698170", VA = "0x180698F70", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x7DE100", Offset = "0x7DD300", VA = "0x1807DE100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public HHMLBHMEFHC PGGJDLBBAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x699000", Offset = "0x698200", VA = "0x180699000", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFBA0", Offset = "0x7DEDA0", VA = "0x1807DFBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public HPHHNPAHGBL CEAKECDJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x698FE0", Offset = "0x6981E0", VA = "0x180698FE0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0E0", Offset = "0x7DD2E0", VA = "0x1807DE0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public HLMMHDFADOA IJBDKCOABJK
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x698FD0", Offset = "0x6981D0", VA = "0x180698FD0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA60", Offset = "0x7DEC60", VA = "0x1807DFA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public KGMNECFLNCJ JKNHOPNADJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x5F7190", Offset = "0x5F6390", VA = "0x1805F7190", Slot = "4")]
		get
		{
			return default(KGMNECFLNCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0xA4EC40", Offset = "0xA4DE40", VA = "0x180A4EC40", Slot = "5")]
	public void OBKFACFEIOH(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public EFLMAGNMOMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
public class EDHKIDMMCAO : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class HDPIOJCHCPF : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public EDHKIDMMCAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x7CC210", Offset = "0x7CB410", VA = "0x1807CC210", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xA55FD0", Offset = "0xA551D0", VA = "0x180A55FD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
		[DebuggerHidden]
		public HDPIOJCHCPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xA55E10", Offset = "0xA55010", VA = "0x180A55E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xA55F80", Offset = "0xA55180", VA = "0x180A55F80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400018D")]
	protected const ulong BLEEBEFPGKP = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	protected const ulong KPOFBPDKKLI = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	protected const int AMBGMDINFIP = 8;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	protected const int OADHOGOCEOE = 6;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int KHGFIFIEPBP = 64;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	protected const int LDGNDKIOJCE = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly List<ulong> BNKKIAGPBAC;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD60", Offset = "0x6FEF60", VA = "0x1806FFD60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD70", Offset = "0x6FEF70", VA = "0x1806FFD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public int PADHGINKEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x7D0780", Offset = "0x7CF980", VA = "0x1807D0780")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x7D0200", Offset = "0x7CF400", VA = "0x1807D0200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xA4E750", Offset = "0xA4D950", VA = "0x180A4E750")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF70", Offset = "0xA4D170", VA = "0x180A4DF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0xA4E880", Offset = "0xA4DA80", VA = "0x180A4E880")]
	public EDHKIDMMCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0xA4E7F0", Offset = "0xA4D9F0", VA = "0x180A4E7F0")]
	public EDHKIDMMCAO(int KKOIHHCAAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0xA4E3D0", Offset = "0xA4D5D0", VA = "0x180A4E3D0")]
	public bool KPOMJPNAFOI(int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4A0", Offset = "0xA4D6A0", VA = "0x180A4E4A0")]
	public bool LIBIBNMIDHL(int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E590", Offset = "0xA4D790", VA = "0x180A4E590")]
	public bool NCONGCKDGIG(int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0xA4E580", Offset = "0xA4D780", VA = "0x180A4E580")]
	public bool MJFCPIFHOGF(int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E110", Offset = "0xA4D310", VA = "0x180A4E110")]
	public void HEEPPDACKJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0xA4DC80", Offset = "0xA4CE80", VA = "0x180A4DC80")]
	public void EGEMNDPFOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0xA4DB90", Offset = "0xA4CD90", VA = "0x180A4DB90")]
	public void CEAJIHNFBDD(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0xA4E610", Offset = "0xA4D810", VA = "0x180A4E610")]
	public void NLALCDJNEAF(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0xA4DB00", Offset = "0xA4CD00", VA = "0x180A4DB00")]
	public bool BCDPEPAJNLF(int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0xA4E190", Offset = "0xA4D390", VA = "0x180A4E190")]
	public void ILCDOLFEGDI(int FDGAPOLJFKN, int AEKEPEKODMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0xA4DD60", Offset = "0xA4CF60", VA = "0x180A4DD60")]
	public void GLNMJNOMDKO(int BIJIDMJOAIO, int IOCAJCEENLG, int AEKEPEKODMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0xA4E2A0", Offset = "0xA4D4A0", VA = "0x180A4E2A0")]
	public int KAGEPJABGKM(int AEKEPEKODMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0xA4E360", Offset = "0xA4D560", VA = "0x180A4E360")]
	public int KAGEPJABGKM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0xA4E700", Offset = "0xA4D900", VA = "0x180A4E700")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0xA4DF00", Offset = "0xA4D100", VA = "0x180A4DF00", Slot = "4")]
	[IteratorStateMachine(typeof(HDPIOJCHCPF))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0xA4DF00", Offset = "0xA4D100", VA = "0x180A4DF00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class LHODBAJCLAJ<T> : global::POKBJDNJKFJ<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	protected global::KOMNNIGIGEG<T> MBCCCBCNMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	protected global::GPAGAMCOAPG<T> GEJBDFEKAAE;

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0xE8BA90", Offset = "0xE8AC90", VA = "0x180E8BA90")]
	public LHODBAJCLAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0xE90AA0", Offset = "0xE8FCA0", VA = "0x180E90AA0")]
	public LHODBAJCLAJ(global::KOMNNIGIGEG<T> MBCCCBCNMGK, global::GPAGAMCOAPG<T> GEJBDFEKAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0xE90470", Offset = "0xE8F670", VA = "0x180E90470", Slot = "11")]
	public override T LGPKACCHBHO(KLJNHPCCJBI JJPICLDNKPF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0xE907B0", Offset = "0xE8F9B0", VA = "0x180E907B0", Slot = "12")]
	public override void LIOPAMDCNLD(KLJNHPCCJBI JJPICLDNKPF, T ADBNEBBHMOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class MCAEFCMNLLL
{
	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A10900", Offset = "0x3A0FB00", VA = "0x183A10900")]
	public static CAEHPHOEGJK NKCPCCNOLCN<T>(this BDEJDLLDNFC OMFFMMHBAGP, global::PCAOFNBPEMD<T> JFLKGPEABBP, global::KOMNNIGIGEG<T> MBCCCBCNMGK, global::GPAGAMCOAPG<T> GEJBDFEKAAE) where T : struct
	{
		return default(CAEHPHOEGJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class GLMDEDLKCOM<T> : global::LHODBAJCLAJ<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x44E28D0", Offset = "0x44E1AD0", VA = "0x1844E28D0")]
	public GLMDEDLKCOM(T CKOAFJABJOB, T ONDKPLDODAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class MLHIIPBJCGJ<T> : global::POKBJDNJKFJ<T> where T : struct, JFOPHLNANAA
{
	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x16015D0", Offset = "0x16007D0", VA = "0x1816015D0", Slot = "11")]
	public override T LGPKACCHBHO(KLJNHPCCJBI JJPICLDNKPF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1601640", Offset = "0x1600840", VA = "0x181601640", Slot = "12")]
	public override void LIOPAMDCNLD(KLJNHPCCJBI JJPICLDNKPF, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x12085B0", Offset = "0x12077B0", VA = "0x1812085B0")]
	public MLHIIPBJCGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class OCHLKLDDDKA : PBKNEHLFIGG
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public abstract Type LFFPNIACHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void LGPKACCHBHO(KLJNHPCCJBI JJPICLDNKPF, in AINJMIEKGCE ADBNEBBHMOP);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void LIOPAMDCNLD(KLJNHPCCJBI JJPICLDNKPF, in JFFJOIBOPJP ADBNEBBHMOP);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void GMDBEOJGGFF(KLJNHPCCJBI JJPICLDNKPF, DFNPIAKFDLN KJFBEANHPKG, [Optional] object JAEDJGBMHAP);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	protected OCHLKLDDDKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class POKBJDNJKFJ<T> : OCHLKLDDDKA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public override Type LFFPNIACHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x4533100", Offset = "0x4532300", VA = "0x184533100", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T LGPKACCHBHO(KLJNHPCCJBI JJPICLDNKPF);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void LIOPAMDCNLD(KLJNHPCCJBI JJPICLDNKPF, T ADBNEBBHMOP);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x4531D70", Offset = "0x4530F70", VA = "0x184531D70", Slot = "8")]
	public override void LGPKACCHBHO(KLJNHPCCJBI JJPICLDNKPF, in AINJMIEKGCE MLNFOFCNKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x45321A0", Offset = "0x45313A0", VA = "0x1845321A0", Slot = "9")]
	public override void LIOPAMDCNLD(KLJNHPCCJBI JJPICLDNKPF, in JFFJOIBOPJP FKKKHANKMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x4530AF0", Offset = "0x452FCF0", VA = "0x184530AF0", Slot = "10")]
	public override void GMDBEOJGGFF(KLJNHPCCJBI JJPICLDNKPF, DFNPIAKFDLN KJFBEANHPKG, object JAEDJGBMHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0xF36150", Offset = "0xF35350", VA = "0x180F36150")]
	protected POKBJDNJKFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class ABFENDPJEME
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class LBEJAGNHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class MNOGLEGHIIN<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
			public MNOGLEGHIIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x37F7580", Offset = "0x37F6780", VA = "0x1837F7580")]
			internal void <RegisterFixedString>b__0(KLJNHPCCJBI p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x37F7750", Offset = "0x37F6950", VA = "0x1837F7750")]
			internal T <RegisterFixedString>b__1(KLJNHPCCJBI p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xA56940", Offset = "0xA55B40", VA = "0x180A56940")]
		public static void LEHIDKEJHIL(KONJJGIDCPF FBDLHHKBFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x3861620", Offset = "0x3860820", VA = "0x183861620")]
		private static void EFELFEFHJJP<T>(KONJJGIDCPF FBDLHHKBFLN, int ONDKPLDODAP) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x3861740", Offset = "0x3860940", VA = "0x183861740")]
		private static void EOJICBNEEMC<T>(KLJNHPCCJBI DNNNMCEHJCM, T BGOLGEMKCDC, int ONDKPLDODAP) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x38550F0", Offset = "0x38542F0", VA = "0x1838550F0")]
		private static T NBFNHBIJHEP<T>(KLJNHPCCJBI DNNNMCEHJCM, int ONDKPLDODAP) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LBEJAGNHOLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class NOPAGPCIEGP : NEHMDFHLFAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private KONJJGIDCPF FBDLHHKBFLN;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x3865600", Offset = "0x3864800", VA = "0x183865600", Slot = "6")]
		public override void ANCFPGDFLKA<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA57A60", Offset = "0xA56C60", VA = "0x180A57A60")]
		public static void EKPOKNFLHBG(KONJJGIDCPF FBDLHHKBFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xA57AE0", Offset = "0xA56CE0", VA = "0x180A57AE0")]
		public NOPAGPCIEGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0xA441C0", Offset = "0xA433C0", VA = "0x180A441C0")]
	public static void MIEIGGFDKOF(KONJJGIDCPF FBDLHHKBFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x3856840", Offset = "0x3855A40", VA = "0x183856840")]
	public static void BLDFFIHPMBH<T>(KONJJGIDCPF FBDLHHKBFLN, global::KOMNNIGIGEG<T> MBCCCBCNMGK, global::GPAGAMCOAPG<T> GEJBDFEKAAE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x38568D0", Offset = "0x3855AD0", VA = "0x1838568D0")]
	public static void JKJMOGHGOMG<T>(KONJJGIDCPF CANPFCDJMLM) where T : struct, JFOPHLNANAA
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface KONJJGIDCPF : global::OJEMFGOOHPC<KONJJGIDCPF>
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKCPCCNOLCN(Type BGMCKNGNOJI, PBKNEHLFIGG CANPFCDJMLM);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GJMMOBCKDJC(Type BGMCKNGNOJI, out PBKNEHLFIGG CANPFCDJMLM);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class IICIBKGGGGK
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x8755E0", Offset = "0x8747E0", VA = "0x1808755E0")]
	public static void NKCPCCNOLCN(this KONJJGIDCPF DLIKPMCKNDM, PBKNEHLFIGG CANPFCDJMLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[CLDGIFMABHG(typeof(BDEJDLLDNFC), new string[] { })]
public sealed class PBACGBKECBG : BDEJDLLDNFC, global::OJEMFGOOHPC<BDEJDLLDNFC>, GFHKHHPFFGF, GOKNGONBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly Dictionary<CAEHPHOEGJK, PBKNEHLFIGG> FBDLHHKBFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private KONJJGIDCPF EGOJAPAJKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private LIODBHBOIBI OMFFMMHBAGP;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool EPONKPGDPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x7E7390", Offset = "0x7E6590", VA = "0x1807E7390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7E7600", Offset = "0x7E6800", VA = "0x1807E7600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0xBE52C0", Offset = "0xBE44C0", VA = "0x180BE52C0")]
	public PBACGBKECBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0xBE5330", Offset = "0xBE4530", VA = "0x180BE5330")]
	public PBACGBKECBG(Dictionary<CAEHPHOEGJK, PBKNEHLFIGG> FBDLHHKBFLN, bool NADMEHBIBHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0xBE5030", Offset = "0xBE4230", VA = "0x180BE5030", Slot = "7")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0xBE4E30", Offset = "0xBE4030", VA = "0x180BE4E30", Slot = "8")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0xBE5270", Offset = "0xBE4470", VA = "0x180BE5270", Slot = "9")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0xBE4D60", Offset = "0xBE3F60", VA = "0x180BE4D60", Slot = "4")]
	public CAEHPHOEGJK CBOIMAPADPA(CFNMCCFLIFF JFLKGPEABBP)
	{
		return default(CAEHPHOEGJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0xBE5150", Offset = "0xBE4350", VA = "0x180BE5150", Slot = "5")]
	public void NKCPCCNOLCN(CAEHPHOEGJK IHPCCBHNEMN, PBKNEHLFIGG CANPFCDJMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0xBE4C50", Offset = "0xBE3E50", VA = "0x180BE4C50")]
	[Conditional("DEBUG_BUILD")]
	private void BKKFMJBLNCP(CAEHPHOEGJK IHPCCBHNEMN, Type BGMCKNGNOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0xBE4EB0", Offset = "0xBE40B0", VA = "0x180BE4EB0", Slot = "6")]
	public bool GJMMOBCKDJC(CAEHPHOEGJK IHPCCBHNEMN, out PBKNEHLFIGG CANPFCDJMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0xBE5080", Offset = "0xBE4280", VA = "0x180BE5080", Slot = "10")]
	public BDEJDLLDNFC LOINOKKOFKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[CLDGIFMABHG(typeof(KONJJGIDCPF), new string[] { })]
public sealed class DMGKCFMOOFJ : GFHKHHPFFGF, KONJJGIDCPF, global::OJEMFGOOHPC<KONJJGIDCPF>
{
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly Dictionary<Type, PBKNEHLFIGG> FBDLHHKBFLN;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool EPONKPGDPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D50", Offset = "0x7D0F50", VA = "0x1807D1D50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D30", Offset = "0x7D0F30", VA = "0x1807D1D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0xA4D030", Offset = "0xA4C230", VA = "0x180A4D030")]
	public DMGKCFMOOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0xA4D0A0", Offset = "0xA4C2A0", VA = "0x180A4D0A0")]
	public DMGKCFMOOFJ(Dictionary<Type, PBKNEHLFIGG> FBDLHHKBFLN, bool NADMEHBIBHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0xA4CDD0", Offset = "0xA4BFD0", VA = "0x180A4CDD0", Slot = "4")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0xA4CF00", Offset = "0xA4C100", VA = "0x180A4CF00", Slot = "5")]
	public void NKCPCCNOLCN(Type BGMCKNGNOJI, PBKNEHLFIGG CANPFCDJMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0xA4CD10", Offset = "0xA4BF10", VA = "0x180A4CD10", Slot = "6")]
	public bool GJMMOBCKDJC(Type BGMCKNGNOJI, out PBKNEHLFIGG CANPFCDJMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0xA4CE30", Offset = "0xA4C030", VA = "0x180A4CE30", Slot = "7")]
	public KONJJGIDCPF LOINOKKOFKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[CLDGIFMABHG(typeof(DBLCKNCJPKP), new string[] { })]
internal sealed class JDKEOMOEDJM : DBLCKNCJPKP, GFHKHHPFFGF, GOKNGONBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly Dictionary<CAEHPHOEGJK, BNPNGIKODDH> BLDKADLNGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private LIODBHBOIBI OMFFMMHBAGP;

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x877B60", Offset = "0x876D60", VA = "0x180877B60", Slot = "6")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x877950", Offset = "0x876B50", VA = "0x180877950", Slot = "7")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x877C20", Offset = "0x876E20", VA = "0x180877C20", Slot = "4")]
	public void NKCPCCNOLCN(CAEHPHOEGJK FMBNLFNGBEI, Type JHJGMGMFJDJ, BNPNGIKODDH IGCMOGJEIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x877BB0", Offset = "0x876DB0", VA = "0x180877BB0", Slot = "5")]
	public bool LOBENNNAMGI(CAEHPHOEGJK FMBNLFNGBEI, out BNPNGIKODDH IGCMOGJEIBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x8779B0", Offset = "0x876BB0", VA = "0x1808779B0")]
	[Conditional("DEBUG_BUILD")]
	private void HHPPHGKHKCD(CAEHPHOEGJK FMBNLFNGBEI, Type JHJGMGMFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x877C90", Offset = "0x876E90", VA = "0x180877C90")]
	public JDKEOMOEDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[OCLKOGGMIFL(typeof(LIODBHBOIBI))]
[CLDGIFMABHG(typeof(KPGKGJDBOOE), new string[] { })]
internal sealed class DKMNPBJMIAF : KPGKGJDBOOE, PMOCCIAIAEL, GFHKHHPFFGF, GOKNGONBKFG, AIOPJLICFNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly EDHKIDMMCAO COKOMGOGPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly Dictionary<NJKBLCBBANC, int> DNAIHJHFBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Stack<int> PKEEBJNLPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private LIODBHBOIBI OMFFMMHBAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private AEKECOGJAHN JGHMLHPFFHK;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private int BGNNKCLCLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xA4C620", Offset = "0xA4B820", VA = "0x180A4C620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool LFBKCCEFGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x9A4880", Offset = "0x9A3A80", VA = "0x1809A4880", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x9A48E0", Offset = "0x9A3AE0", VA = "0x1809A48E0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0xA4C400", Offset = "0xA4B600", VA = "0x180A4C400", Slot = "6")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0xA4C500", Offset = "0xA4B700", VA = "0x180A4C500", Slot = "7")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0xA4C370", Offset = "0xA4B570", VA = "0x180A4C370", Slot = "8")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0xA4C580", Offset = "0xA4B780", VA = "0x180A4C580")]
	private void LCKBGGCBLDL(DHOEKPEGHDF LALFNHCEDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0xA4C670", Offset = "0xA4B870", VA = "0x180A4C670", Slot = "4")]
	public bool OOGMFMPBNIH(NJKBLCBBANC AGHJLKKAHGN, CAEHPHOEGJK HJJHAMKLCMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0xA4C070", Offset = "0xA4B270", VA = "0x180A4C070", Slot = "5")]
	public void BHNNOFHHAKE(NJKBLCBBANC AGHJLKKAHGN, Span<CAEHPHOEGJK> OMFFMMHBAGP, bool HLLBGJPGCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0xA4C400", Offset = "0xA4B600", VA = "0x180A4C400", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0xA4C770", Offset = "0xA4B970", VA = "0x180A4C770")]
	public DKMNPBJMIAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class HEGCJCOFOBL
{
	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x870F10", Offset = "0x870110", VA = "0x180870F10")]
	public static void KMJBDALDGHJ(this KLJNHPCCJBI JJPICLDNKPF, ReadOnlyMemory<byte> OBKHKBMFJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x3E05ED0", Offset = "0x3E050D0", VA = "0x183E05ED0")]
	public static void EMEEPHFDJML<T>(this KLJNHPCCJBI JJPICLDNKPF, in T ADBNEBBHMOP) where T : struct, JFOPHLNANAA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x3852DB0", Offset = "0x3851FB0", VA = "0x183852DB0")]
	public static T GPHLJDFGACC<T>(this KLJNHPCCJBI JJPICLDNKPF) where T : struct, JFOPHLNANAA
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x870D90", Offset = "0x86FF90", VA = "0x180870D90")]
	public static void EMEEPHFDJML(this KLJNHPCCJBI JJPICLDNKPF, OABOABFNBLE OMFMLBAFFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x870EE0", Offset = "0x8700E0", VA = "0x180870EE0")]
	public static OABOABFNBLE ILMKHHBLEAB(this KLJNHPCCJBI JJPICLDNKPF)
	{
		return default(OABOABFNBLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x870BE0", Offset = "0x86FDE0", VA = "0x180870BE0")]
	public static void DEKIHBJDNIP(this KLJNHPCCJBI DJBGEDLHCFF, uint AHCPBCCEFFE, bool MACLOMDNNJB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x870DC0", Offset = "0x86FFC0", VA = "0x180870DC0")]
	public static uint IHBOAKHHDDC(this KLJNHPCCJBI NCACJOJKKJP, bool MACLOMDNNJB = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class PJIDJFCMKFD
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class MECLNAIDEJN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public MECLNAIDEJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x4529420", Offset = "0x4528620", VA = "0x184529420")]
		internal void <GetByteEnumDelegates>b__0(KLJNHPCCJBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x4529490", Offset = "0x4528690", VA = "0x184529490")]
		internal T <GetByteEnumDelegates>b__1(KLJNHPCCJBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class IJNFGMLHJPK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public IJNFGMLHJPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x4520F90", Offset = "0x4520190", VA = "0x184520F90")]
		internal void <GetSByteEnumDelegates>b__0(KLJNHPCCJBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x4521000", Offset = "0x4520200", VA = "0x184521000")]
		internal T <GetSByteEnumDelegates>b__1(KLJNHPCCJBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class ADBEIBIEMFD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public ADBEIBIEMFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x451FCD0", Offset = "0x451EED0", VA = "0x18451FCD0")]
		internal void <GetShortEnumDelegates>b__0(KLJNHPCCJBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x451FD40", Offset = "0x451EF40", VA = "0x18451FD40")]
		internal T <GetShortEnumDelegates>b__1(KLJNHPCCJBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class OBGIHDOJOEG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public OBGIHDOJOEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x4529A00", Offset = "0x4528C00", VA = "0x184529A00")]
		internal void <GetUShortEnumDelegates>b__0(KLJNHPCCJBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x4529A70", Offset = "0x4528C70", VA = "0x184529A70")]
		internal T <GetUShortEnumDelegates>b__1(KLJNHPCCJBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class ECHOHGELMJN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public ECHOHGELMJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x451FEC0", Offset = "0x451F0C0", VA = "0x18451FEC0")]
		internal void <GetIntEnumDelegates>b__0(KLJNHPCCJBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x451FF20", Offset = "0x451F120", VA = "0x18451FF20")]
		internal T <GetIntEnumDelegates>b__1(KLJNHPCCJBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class ELHICICEFMH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public ELHICICEFMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x4520AA0", Offset = "0x451FCA0", VA = "0x184520AA0")]
		internal void <GetUIntEnumDelegates>b__0(KLJNHPCCJBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x4520B00", Offset = "0x451FD00", VA = "0x184520B00")]
		internal T <GetUIntEnumDelegates>b__1(KLJNHPCCJBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x51B65D0", Offset = "0x51B57D0", VA = "0x1851B65D0")]
	public static void IBFAKMAJEPH<T>(T CKOAFJABJOB, T ONDKPLDODAP, out global::KOMNNIGIGEG<T> KALEHDLMLLJ, out global::GPAGAMCOAPG<T> IEKPJCKPEIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x51B61E0", Offset = "0x51B53E0", VA = "0x1851B61E0")]
	private static void JNEPLMJKLGA<T>(T CKOAFJABJOB, T ONDKPLDODAP, out global::KOMNNIGIGEG<T> KALEHDLMLLJ, out global::GPAGAMCOAPG<T> IEKPJCKPEIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x51B61E0", Offset = "0x51B53E0", VA = "0x1851B61E0")]
	private static void BJJAHCONHAF<T>(T CKOAFJABJOB, T ONDKPLDODAP, out global::KOMNNIGIGEG<T> KALEHDLMLLJ, out global::GPAGAMCOAPG<T> IEKPJCKPEIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x51B6330", Offset = "0x51B5530", VA = "0x1851B6330")]
	private static void FMEGEOPOKMG<T>(T CKOAFJABJOB, T ONDKPLDODAP, out global::KOMNNIGIGEG<T> KALEHDLMLLJ, out global::GPAGAMCOAPG<T> IEKPJCKPEIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x51B6330", Offset = "0x51B5530", VA = "0x1851B6330")]
	private static void DBDLGHPBJHL<T>(T CKOAFJABJOB, T ONDKPLDODAP, out global::KOMNNIGIGEG<T> KALEHDLMLLJ, out global::GPAGAMCOAPG<T> IEKPJCKPEIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x51B6480", Offset = "0x51B5680", VA = "0x1851B6480")]
	private static void GCEFCHIMMHG<T>(T CKOAFJABJOB, T ONDKPLDODAP, out global::KOMNNIGIGEG<T> KALEHDLMLLJ, out global::GPAGAMCOAPG<T> IEKPJCKPEIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x51B6480", Offset = "0x51B5680", VA = "0x1851B6480")]
	private static void IPNFLBPADLO<T>(T CKOAFJABJOB, T ONDKPLDODAP, out global::KOMNNIGIGEG<T> KALEHDLMLLJ, out global::GPAGAMCOAPG<T> IEKPJCKPEIH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public abstract class GLMJFAGHDFG : IOEKBOBEJBN, AIOPJLICFNI
{
	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0xA53400", Offset = "0xA52600", VA = "0x180A53400", Slot = "4")]
	private void NGIHMKFEIKI(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void KGFLPILKACM(BDEJDLLDNFC OMFFMMHBAGP);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270")]
	protected GLMJFAGHDFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[PDPMFPOFILI(typeof(LocalPoseData))]
public sealed class CPBDHFPPCNN : GLMJFAGHDFG
{
	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0xA4A9F0", Offset = "0xA49BF0", VA = "0x180A4A9F0", Slot = "5")]
	protected override void KGFLPILKACM(BDEJDLLDNFC OMFFMMHBAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270")]
	public CPBDHFPPCNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[InternalBufferCapacity(1)]
internal struct LFAGHCJJKOD : ISystemStateBufferElementData, IBufferElementData, IEquatable<LFAGHCJJKOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public MJCNDPANMPG BEDKMKLJIGF;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x8801A0", Offset = "0x87F3A0", VA = "0x1808801A0", Slot = "4")]
	public bool Equals(LFAGHCJJKOD GHOINNFPLDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x6D6330", Offset = "0x6D5530", VA = "0x1806D6330")]
	public static LFAGHCJJKOD BKALKAPLPLL(MJCNDPANMPG BEDKMKLJIGF)
	{
		return default(LFAGHCJJKOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[InternalBufferCapacity(4)]
internal struct POEGKKOKAOL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public MJCNDPANMPG BEDKMKLJIGF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x6D6330", Offset = "0x6D5530", VA = "0x1806D6330")]
	public static POEGKKOKAOL BKALKAPLPLL(MJCNDPANMPG BEDKMKLJIGF)
	{
		return default(POEGKKOKAOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
internal struct MJCNDPANMPG : global::FMOBBOIANPF<MJCNDPANMPG>, AMBNOAMFBPJ, IEquatable<MJCNDPANMPG>
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public int CCIFACONDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6FD360", Offset = "0x6FC560", VA = "0x1806FD360", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD370", Offset = "0x6FC570", VA = "0x1806FD370", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public int IDFONEJIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x881B10", Offset = "0x880D10", VA = "0x180881B10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x881B00", Offset = "0x880D00", VA = "0x180881B00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool MJFCPIFHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x881B20", Offset = "0x880D20", VA = "0x180881B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x8801A0", Offset = "0x87F3A0", VA = "0x1808801A0", Slot = "8")]
	public bool Equals(MJCNDPANMPG GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x881B60", Offset = "0x880D60", VA = "0x180881B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class CGJGEIIPADH : ParentSystemBase<AuthoredParentData, IHFGDFFIKAA, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48140", VA = "0x180A48F40", Slot = "14")]
	protected override EntityQueryDesc PHECNNGFGHJ(EntityQueryDesc IMOAAHEOFBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEB0", Offset = "0x6ED0B0", VA = "0x1806EDEB0", Slot = "15")]
	protected override EntityQueryDesc CPAJDJJPCGF(EntityQueryDesc IMOAAHEOFBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0xA48E80", Offset = "0xA48080", VA = "0x180A48E80", Slot = "16")]
	protected override EntityQueryDesc HKGJOKEIPJF(EntityQueryDesc IMOAAHEOFBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0xA48EC0", Offset = "0xA480C0", VA = "0x180A48EC0", Slot = "17")]
	protected override EntityQueryDesc HLPLPLPHJKP(EntityQueryDesc IMOAAHEOFBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0xA48F80", Offset = "0xA48180", VA = "0x180A48F80")]
	public CGJGEIIPADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0xA48F00", Offset = "0xA48100", VA = "0x180A48F00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[EJLOOKEAJML(HNJEFABFMIP.Connectables)]
	public class UpdateConnectableVisuals : MGFJEDJDOGN, GOKNGONBKFG
	{
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		private struct JKJPCLCAFOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public MJCNDPANMPG BEDKMKLJIGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public float3 BCCJFEBGGPE;

			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x8F4210", Offset = "0x8F3410", VA = "0x1808F4210")]
			public JKJPCLCAFOB(MJCNDPANMPG BEDKMKLJIGF, float3 BCCJFEBGGPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F33F0", VA = "0x1808F41F0")]
			public void LBLAKPOPNOG(out MJCNDPANMPG BEDKMKLJIGF, out float3 BCCJFEBGGPE)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private struct KEOJBCDDIOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public NativeList<JKJPCLCAFOB> list;

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
			public KEOJBCDDIOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<POEGKKOKAOL> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private struct BLGHKCFOEKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public NativeList<JKJPCLCAFOB> list;

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
			public BLGHKCFOEKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<LFAGHCJJKOD> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private struct JJMOCGJMFGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public NativeList<JKJPCLCAFOB> list;

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
			public JJMOCGJMFGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in GNFIALGGLMJ com, in DynamicBuffer<LFAGHCJJKOD> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct NHDJEMHEMCE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009C")]
			private struct POEBILBPFFP
			{
				[Cpp2IlInjected.Token(Token = "0x200009D")]
				public struct MHNEKAMAGOJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000205")]
					public LambdaParameterValueProvider_Entity.Runtime ABCLJOKOGIH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000206")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MECFHOHJOKE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000207")]
					public LambdaParameterValueProvider_DynamicBuffer<POEGKKOKAOL>.Runtime CMPMGEEOGCD;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000202")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity PJOHKJKECDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000203")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NGPLIHEBDJP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000204")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<POEGKKOKAOL> HEEGJJNKPLE;

				[Cpp2IlInjected.Token(Token = "0x600057A")]
				[Cpp2IlInjected.Address(RVA = "0x28093D0", Offset = "0x28085D0", VA = "0x1828093D0")]
				public void MABHDODJKAO(UpdateConnectableVisuals HJICJBAHBAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600057B")]
				[Cpp2IlInjected.Address(RVA = "0x2809320", Offset = "0x2808520", VA = "0x182809320")]
				public MHNEKAMAGOJ GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
				{
					return default(MHNEKAMAGOJ);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public UpdateConnectableVisuals JJOBHIEINGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public NativeList<JKJPCLCAFOB> MDBHJOENILE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			private POEBILBPFFP ANIEMPIBNCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe POEBILBPFFP.MHNEKAMAGOJ* AHPNEFKAFJO;

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LCJAIGMFHHE;

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D40", Offset = "0x8F3F40", VA = "0x1808F4D40")]
			internal void NFKNCPPNADH(Entity BBPBBOAPCHN, WorldPoseData FKMIADAEHNN, in DynamicBuffer<POEGKKOKAOL> IBBEGDPIJBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x8F4FC0", Offset = "0x8F41C0", VA = "0x1808F4FC0", Slot = "5")]
			public void ReadFromDisplayClass(ref KEOJBCDDIOI CHELDAKFMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x8F4FF0", Offset = "0x8F41F0", VA = "0x1808F4FF0", Slot = "6")]
			public void WriteToDisplayClass(ref KEOJBCDDIOI CHELDAKFMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x8F4B40", Offset = "0x8F3D40", VA = "0x1808F4B40", Slot = "4")]
			public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0x8F4BD0", Offset = "0x8F3DD0", VA = "0x1808F4BD0")]
			public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, ref POEBILBPFFP.MHNEKAMAGOJ LIDOEFEMELO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D00", Offset = "0x8F3F00", VA = "0x1808F4D00")]
			public void MABHDODJKAO(UpdateConnectableVisuals HJICJBAHBAD, ref KEOJBCDDIOI CHELDAKFMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x8F4F60", Offset = "0x8F4160", VA = "0x1808F4F60")]
			public unsafe static void NHFOKKFCGIG(ArchetypeChunkIterator* DMENKPONMKK, void* DPAIKCDDPBE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct BAGLGJDMBJP : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009F")]
			private struct DEFOLHIBIFC
			{
				[Cpp2IlInjected.Token(Token = "0x20000A0")]
				[NoAlias]
				public struct KNACGHNNLFM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400020D")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MECFHOHJOKE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400020E")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<LFAGHCJJKOD>.Runtime CMPMGEEOGCD;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400020B")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NGPLIHEBDJP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<LFAGHCJJKOD> HEEGJJNKPLE;

				[Cpp2IlInjected.Token(Token = "0x6000581")]
				[Cpp2IlInjected.Address(RVA = "0x8F2710", Offset = "0x8F1910", VA = "0x1808F2710")]
				public void MABHDODJKAO(UpdateConnectableVisuals HJICJBAHBAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000582")]
				[Cpp2IlInjected.Address(RVA = "0x8F2670", Offset = "0x8F1870", VA = "0x1808F2670")]
				public KNACGHNNLFM GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
				{
					return default(KNACGHNNLFM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public NativeList<JKJPCLCAFOB> MDBHJOENILE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private DEFOLHIBIFC ANIEMPIBNCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe DEFOLHIBIFC.KNACGHNNLFM* AHPNEFKAFJO;

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x8F1D80", Offset = "0x8F0F80", VA = "0x1808F1D80")]
			internal void NFKNCPPNADH(in WorldPoseData FKMIADAEHNN, in DynamicBuffer<LFAGHCJJKOD> IBBEGDPIJBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87EBA0", VA = "0x18087F9A0", Slot = "5")]
			public void ReadFromDisplayClass(ref BLGHKCFOEKI CHELDAKFMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x8F1B60", Offset = "0x8F0D60", VA = "0x1808F1B60", Slot = "4")]
			public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x8F1C30", Offset = "0x8F0E30", VA = "0x1808F1C30")]
			public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, [NoAlias] ref DEFOLHIBIFC.KNACGHNNLFM LIDOEFEMELO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x8F1CF0", Offset = "0x8F0EF0", VA = "0x1808F1CF0")]
			public void MABHDODJKAO(UpdateConnectableVisuals HJICJBAHBAD, ref BLGHKCFOEKI CHELDAKFMJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct MICHCOKCPBC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			private struct LCMGAIOJMEP
			{
				[Cpp2IlInjected.Token(Token = "0x20000A3")]
				[NoAlias]
				public struct CMNEBIHIMDG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000215")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MECFHOHJOKE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000216")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<GNFIALGGLMJ>.Runtime LLPJBJKIHPE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000217")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<LFAGHCJJKOD>.Runtime CMPMGEEOGCD;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000212")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NGPLIHEBDJP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000213")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<GNFIALGGLMJ> IFNFDFMNOHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000214")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<LFAGHCJJKOD> HEEGJJNKPLE;

				[Cpp2IlInjected.Token(Token = "0x6000588")]
				[Cpp2IlInjected.Address(RVA = "0x8F4760", Offset = "0x8F3960", VA = "0x1808F4760")]
				public void MABHDODJKAO(UpdateConnectableVisuals HJICJBAHBAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000589")]
				[Cpp2IlInjected.Address(RVA = "0x8F46B0", Offset = "0x8F38B0", VA = "0x1808F46B0")]
				public CMNEBIHIMDG GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
				{
					return default(CMNEBIHIMDG);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public NativeList<JKJPCLCAFOB> MDBHJOENILE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private LCMGAIOJMEP ANIEMPIBNCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe LCMGAIOJMEP.CMNEBIHIMDG* AHPNEFKAFJO;

			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x8F49F0", Offset = "0x8F3BF0", VA = "0x1808F49F0")]
			internal void NFKNCPPNADH(in WorldPoseData FKMIADAEHNN, in GNFIALGGLMJ NELOLHIDCBC, in DynamicBuffer<LFAGHCJJKOD> IBBEGDPIJBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87EBA0", VA = "0x18087F9A0", Slot = "5")]
			public void ReadFromDisplayClass(ref JJMOCGJMFGI CHELDAKFMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x8F47E0", Offset = "0x8F39E0", VA = "0x1808F47E0", Slot = "4")]
			public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x8F48C0", Offset = "0x8F3AC0", VA = "0x1808F48C0")]
			public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, [NoAlias] ref LCMGAIOJMEP.CMNEBIHIMDG LIDOEFEMELO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x8F49B0", Offset = "0x8F3BB0", VA = "0x1808F49B0")]
			public void MABHDODJKAO(UpdateConnectableVisuals HJICJBAHBAD, ref JJMOCGJMFGI CHELDAKFMJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private EntityQuery APGPJHIMHPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private EntityQuery IHHMOIJPELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private EntityQuery NELJGFOEDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private EntityQuery MFGKKNFAOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private EntityQuery BNNGGLIJJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private EntityQuery INBGCIJJGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private EntityQuery KPLBBKKKGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private EntityQuery PJIJCHNDPNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private EntityQuery ICLMKKNJBAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private global::NNJNOKFJADK<MJCNDPANMPG, HCPHAMJNCGD> BCIBEFHEBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private FCIBLPNBBFB NMFDFNIKPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private AEKECOGJAHN JGHMLHPFFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private DCEFBILCIFI JKCLPGJHEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private EntityQuery OFHMDLEGAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private ProfilerMarker HGLEODGGNOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private EntityQuery ABIBPJLGOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private EntityQuery ADKODIDHKGI;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public int NAIIACDHEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0x903880", Offset = "0x902A80", VA = "0x180903880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0")]
		internal HCPHAMJNCGD EGGGOLGCBEH(MJCNDPANMPG BEDKMKLJIGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x903ED0", Offset = "0x9030D0", VA = "0x180903ED0", Slot = "14")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x906CD0", Offset = "0x905ED0", VA = "0x180906CD0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x906B00", Offset = "0x905D00", VA = "0x180906B00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x905070", Offset = "0x904270", VA = "0x180905070")]
		private void JFAJGOHILNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x904D70", Offset = "0x903F70", VA = "0x180904D70")]
		private void HHPNIEBCOLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x905320", Offset = "0x904520", VA = "0x180905320")]
		private void MIJIOEDNOPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x906D10", Offset = "0x905F10", VA = "0x180906D10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x9049A0", Offset = "0x903BA0", VA = "0x1809049A0")]
		private void HGBIKKNOCLO(EntityQuery FLJAHKGCHNN, EntityQuery JGHKHHEDNNH, EntityQuery CACJKPCLCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x904E70", Offset = "0x904070", VA = "0x180904E70")]
		private void HPGLCIEKKDK(global::ENJHCOCKNOH<Entity> NEGEJDFGKKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x9042C0", Offset = "0x9034C0", VA = "0x1809042C0")]
		private void EOFMLGMHPEO(global::ENJHCOCKNOH<Entity> KBNJHLFFIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x9068C0", Offset = "0x905AC0", VA = "0x1809068C0")]
		private void OINOAMJCCIO(global::ENJHCOCKNOH<Entity> OJGIDJPIGIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x903B70", Offset = "0x902D70", VA = "0x180903B70")]
		private void EDHNPGGKBMM(NativeList<MJCNDPANMPG> LPFHAHLKLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x905790", Offset = "0x904990", VA = "0x180905790")]
		private NativeList<MJCNDPANMPG> MKNJNDEFMJL(NativeArray<Entity> JEFMGPHNDGN)
		{
			return default(NativeList<MJCNDPANMPG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x905C80", Offset = "0x904E80", VA = "0x180905C80")]
		private void NCICEMDMALP(NativeArray<Entity> JEFMGPHNDGN, NativeList<MJCNDPANMPG> LPFHAHLKLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x906180", Offset = "0x905380", VA = "0x180906180")]
		private void NJBKIPKNIMG(NativeArray<Entity> CGENDHMGGJI, NativeArray<Entity> DHDCIJLMBHK, NativeList<MJCNDPANMPG> PKEEBJNLPHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x903210", Offset = "0x902410", VA = "0x180903210")]
		private void AMHPJKECILL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x906DA0", Offset = "0x905FA0", VA = "0x180906DA0")]
		private global::CBEMPKKBCCF<JKJPCLCAFOB> PBKDGDJMMBP(EntityQuery IMOAAHEOFBK, Func<NativeList<JKJPCLCAFOB>, JobHandle> JEDALBFFCOE)
		{
			return default(global::CBEMPKKBCCF<JKJPCLCAFOB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x905150", Offset = "0x904350", VA = "0x180905150")]
		private JobHandle LDNGGEOLOGM(NativeList<JKJPCLCAFOB> MDBHJOENILE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x9067A0", Offset = "0x9059A0", VA = "0x1809067A0")]
		private JobHandle OGCBKDEMHEJ(NativeList<JKJPCLCAFOB> MDBHJOENILE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x905650", Offset = "0x904850", VA = "0x180905650")]
		private JobHandle MJKLJEGJPII(NativeList<JKJPCLCAFOB> MDBHJOENILE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x904350", Offset = "0x903550", VA = "0x180904350")]
		private void FKCNPCHPMKP(global::CBEMPKKBCCF<JKJPCLCAFOB> MDBHJOENILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x904560", Offset = "0x903760", VA = "0x180904560")]
		private void FLDBPKFLHJM(global::CBEMPKKBCCF<JKJPCLCAFOB> MDBHJOENILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x905C10", Offset = "0x904E10", VA = "0x180905C10")]
		private bool MMHBLELKEIA(Entity BBPBBOAPCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x9041F0", Offset = "0x9033F0", VA = "0x1809041F0")]
		private NativeArray<Entity> EOBJCAPCIPK(Entity BBPBBOAPCHN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x904080", Offset = "0x903280", VA = "0x180904080")]
		private MJCNDPANMPG EOADIJGEJPP(NativeList<MJCNDPANMPG> PKEEBJNLPHG)
		{
			return default(MJCNDPANMPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x903AF0", Offset = "0x902CF0", VA = "0x180903AF0")]
		private void EANAHODJFHF(MJCNDPANMPG BEDKMKLJIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x9069E0", Offset = "0x905BE0", VA = "0x1809069E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x903D00", Offset = "0x902F00", VA = "0x180903D00")]
		public static EntityQuery ELFCGHMDONF(ComponentSystemBase HJICJBAHBAD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x9038C0", Offset = "0x902AC0", VA = "0x1809038C0")]
		public static EntityQuery DIIHDIJLCDI(ComponentSystemBase HJICJBAHBAD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x904770", Offset = "0x903970", VA = "0x180904770")]
		public static EntityQuery GDODPFKPDCG(ComponentSystemBase HJICJBAHBAD)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class GPOIDAICKPD : MGFJEDJDOGN, GOKNGONBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private EntityQuery CIAIAIDBDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private FCFLIDMJBKH FEPEKJBDLDA;

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0xA555C0", Offset = "0xA547C0", VA = "0x180A555C0", Slot = "14")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0xA55690", Offset = "0xA54890", VA = "0x180A55690", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0xA55730", Offset = "0xA54930", VA = "0x180A55730", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0xA55350", Offset = "0xA54550", VA = "0x180A55350")]
	protected void AICFLDBBALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x46A0210", Offset = "0x469F410", VA = "0x1846A0210")]
	private bool ADCMPFPIPLP<TComponentData>(EntityQuery IMOAAHEOFBK, out NativeArray<Entity> JEFMGPHNDGN, out NativeArray<TComponentData> ECILHPMNAEI) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0xA55610", Offset = "0xA54810", VA = "0x180A55610")]
	public IMGFAEJLICC KHKLIDNCCBP(Entity BBPBBOAPCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public GPOIDAICKPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(SimulationSystemGroup))]
public class GOEEBLIPEIL : MGFJEDJDOGN, GOKNGONBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private ObjectEmbodimentService AJJHOLKBJCH;

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0xA552A0", Offset = "0xA544A0", VA = "0x180A552A0", Slot = "14")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0xA55300", Offset = "0xA54500", VA = "0x180A55300", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0xA55330", Offset = "0xA54530", VA = "0x180A55330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public GOEEBLIPEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class GODBNDJPCCG : MGFJEDJDOGN, GOKNGONBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private EntityQuery PDIOLCHHKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private EntityQuery HFCGIGFILMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private EntityQuery OJFJALNAFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private EntityQuery KKPHDPOAFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private ObjectEmbodimentService JHGPACCAGLA;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public int NDNMHIMGOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xA54B30", Offset = "0xA53D30", VA = "0x180A54B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int IABFMDLGEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xA54A10", Offset = "0xA53C10", VA = "0x180A54A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0xA54A20", Offset = "0xA53C20", VA = "0x180A54A20", Slot = "14")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0xA550D0", Offset = "0xA542D0", VA = "0x180A550D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0xA55280", Offset = "0xA54480", VA = "0x180A55280", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0xA54B40", Offset = "0xA53D40", VA = "0x180A54B40")]
	protected void HJPNKNOOKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0xA54D70", Offset = "0xA53F70", VA = "0x180A54D70")]
	protected void IDLLDDAIFIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xA547D0", Offset = "0xA539D0", VA = "0x180A547D0")]
	private bool ADCMPFPIPLP(EntityQuery IMOAAHEOFBK, out NativeArray<Entity> JEFMGPHNDGN, out NativeArray<MLGKNPJCKAB> DJEDGFAAOBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0xA55090", Offset = "0xA54290", VA = "0x180A55090")]
	public global::ENJHCOCKNOH<Entity> LEPPHJLFMGB(Allocator MKFODJKMOCC)
	{
		return default(global::ENJHCOCKNOH<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0xA54AF0", Offset = "0xA53CF0", VA = "0x180A54AF0")]
	public global::ENJHCOCKNOH<Entity> FDJPLLDJPNG(Allocator MKFODJKMOCC)
	{
		return default(global::ENJHCOCKNOH<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0xA54910", Offset = "0xA53B10", VA = "0x180A54910")]
	public bool BLPHNGGFPKJ(Allocator MKFODJKMOCC, out global::ENJHCOCKNOH<Entity> MBMBGCPJPOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0xA549A0", Offset = "0xA53BA0", VA = "0x180A549A0")]
	public bool BMLMCDCGBFJ(Entity BBPBBOAPCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0xA55010", Offset = "0xA54210", VA = "0x180A55010")]
	public IMGFAEJLICC KHKLIDNCCBP(Entity BBPBBOAPCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0xA54FA0", Offset = "0xA541A0", VA = "0x180A54FA0")]
	public bool JFINADNOEDC(Entity BBPBBOAPCHN, out ELFDLGFPJNI MBMBGCPJPOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0xA548C0", Offset = "0xA53AC0", VA = "0x180A548C0")]
	public void AGGPGLAGOFG(Entity BBPBBOAPCHN, ELFDLGFPJNI MBMBGCPJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0xA54A80", Offset = "0xA53C80", VA = "0x180A54A80")]
	public bool ENBEFELCKMP(Entity BBPBBOAPCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public GODBNDJPCCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class ELFDLGFPJNI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public IMGFAEJLICC MBMBGCPJPOE;

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public ELFDLGFPJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x6270A0", Offset = "0x6262A0", VA = "0x1806270A0")]
	public ELFDLGFPJNI(IMGFAEJLICC MBMBGCPJPOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(HFNBGDKNIMD))]
public class IBDPOODAOLO : MGFJEDJDOGN
{
	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public IBDPOODAOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public abstract class MDEKGFPLBJH : MGFJEDJDOGN, GOKNGONBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private EMAMLPGAPJK BDPKNEPLEBC;

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x880CD0", Offset = "0x87FED0", VA = "0x180880CD0", Slot = "14")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x880D30", Offset = "0x87FF30", VA = "0x180880D30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	protected MDEKGFPLBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class OPADFHBPHEH : MGFJEDJDOGN, AIOPJLICFNI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct KPAIOODOJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public NativeList<CDPFCBNHAID> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public NativeList<BNPOJNEDCOI> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public NativeList<CDPFCBNHAID> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		public KPAIOODOJLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, DFNCJJGLOJB previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
		internal void <OnUpdate>b__2(Entity entity, DFNCJJGLOJB previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct KAGPBCCJNFK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		private struct BAEEHGEGFCD
		{
			[Cpp2IlInjected.Token(Token = "0x20000AE")]
			[NoAlias]
			public struct AFJDDIOKKGI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400022E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ABCLJOKOGIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400022F")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime COOAECCCICK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity PJOHKJKECDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> JPGLHFJIKFO;

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xBD66A0", Offset = "0xBD58A0", VA = "0x180BD66A0")]
			public void MABHDODJKAO(OPADFHBPHEH HJICJBAHBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xBD6620", Offset = "0xBD5820", VA = "0x180BD6620")]
			public AFJDDIOKKGI GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
			{
				return default(AFJDDIOKKGI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public NativeList<CDPFCBNHAID> KOKIDLHDAAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private BAEEHGEGFCD ANIEMPIBNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BAEEHGEGFCD.AFJDDIOKKGI* AHPNEFKAFJO;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xBDFED0", Offset = "0xBDF0D0", VA = "0x180BDFED0")]
		internal void NFKNCPPNADH(Entity BBPBBOAPCHN, ParentData DCBHGCPJBOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87EBA0", VA = "0x18087F9A0", Slot = "5")]
		public void ReadFromDisplayClass(ref KPAIOODOJLM CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xBDFCF0", Offset = "0xBDEEF0", VA = "0x180BDFCF0", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xBDFD90", Offset = "0xBDEF90", VA = "0x180BDFD90")]
		public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, [NoAlias] ref BAEEHGEGFCD.AFJDDIOKKGI LIDOEFEMELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xBDFE40", Offset = "0xBDF040", VA = "0x180BDFE40")]
		public void MABHDODJKAO(OPADFHBPHEH HJICJBAHBAD, ref KPAIOODOJLM CHELDAKFMJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct CMNNCKIFIDE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		private struct JKIAIGHONME
		{
			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[NoAlias]
			public struct PBKHEINCHHL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ABCLJOKOGIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime COOAECCCICK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<DFNCJJGLOJB>.Runtime OMIKOPKEOEJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity PJOHKJKECDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> JPGLHFJIKFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<DFNCJJGLOJB> LJLPPHMMAME;

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0xBDFC70", Offset = "0xBDEE70", VA = "0x180BDFC70")]
			public void MABHDODJKAO(OPADFHBPHEH HJICJBAHBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xBDFBD0", Offset = "0xBDEDD0", VA = "0x180BDFBD0")]
			public PBKHEINCHHL GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
			{
				return default(PBKHEINCHHL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public NativeList<BNPOJNEDCOI> KJLDKFLBGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private JKIAIGHONME ANIEMPIBNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JKIAIGHONME.PBKHEINCHHL* AHPNEFKAFJO;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xBD6E00", Offset = "0xBD6000", VA = "0x180BD6E00")]
		internal void NFKNCPPNADH(Entity BBPBBOAPCHN, ParentData DCBHGCPJBOG, DFNCJJGLOJB IPBPGGBABHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xBD6EC0", Offset = "0xBD60C0", VA = "0x180BD6EC0", Slot = "5")]
		public void ReadFromDisplayClass(ref KPAIOODOJLM CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xBD6C20", Offset = "0xBD5E20", VA = "0x180BD6C20", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xBD6CF0", Offset = "0xBD5EF0", VA = "0x180BD6CF0")]
		public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, [NoAlias] ref JKIAIGHONME.PBKHEINCHHL LIDOEFEMELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xBD6DC0", Offset = "0xBD5FC0", VA = "0x180BD6DC0")]
		public void MABHDODJKAO(OPADFHBPHEH HJICJBAHBAD, ref KPAIOODOJLM CHELDAKFMJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct GINDHEGIDKF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		private struct OMHDHKMFKGB
		{
			[Cpp2IlInjected.Token(Token = "0x20000B4")]
			[NoAlias]
			public struct ICGEPANMNNA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ABCLJOKOGIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400023F")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<DFNCJJGLOJB>.Runtime OMIKOPKEOEJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity PJOHKJKECDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<DFNCJJGLOJB> LJLPPHMMAME;

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0xBE2090", Offset = "0xBE1290", VA = "0x180BE2090")]
			public void MABHDODJKAO(OPADFHBPHEH HJICJBAHBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0xBE2010", Offset = "0xBE1210", VA = "0x180BE2010")]
			public ICGEPANMNNA GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
			{
				return default(ICGEPANMNNA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public NativeList<CDPFCBNHAID> BNICMLPPNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private OMHDHKMFKGB ANIEMPIBNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe OMHDHKMFKGB.ICGEPANMNNA* AHPNEFKAFJO;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xBDF530", Offset = "0xBDE730", VA = "0x180BDF530")]
		internal void NFKNCPPNADH(Entity BBPBBOAPCHN, DFNCJJGLOJB IPBPGGBABHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xBDF5C0", Offset = "0xBDE7C0", VA = "0x180BDF5C0", Slot = "5")]
		public void ReadFromDisplayClass(ref KPAIOODOJLM CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xBDF350", Offset = "0xBDE550", VA = "0x180BDF350", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xBDF3F0", Offset = "0xBDE5F0", VA = "0x180BDF3F0")]
		public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, [NoAlias] ref OMHDHKMFKGB.ICGEPANMNNA LIDOEFEMELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xBDF4A0", Offset = "0xBDE6A0", VA = "0x180BDF4A0")]
		public void MABHDODJKAO(OPADFHBPHEH HJICJBAHBAD, ref KPAIOODOJLM CHELDAKFMJK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private FCBOBMFMIOB EONECCGLBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private EntityQuery DJEEKBFODFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private EntityQuery IPBIHKMDPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private EntityQuery FPJCGKLDMGK;

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0xBE2AB0", Offset = "0xBE1CB0", VA = "0x180BE2AB0", Slot = "14")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0xBE2DE0", Offset = "0xBE1FE0", VA = "0x180BE2DE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public OPADFHBPHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0xBE2D80", Offset = "0xBE1F80", VA = "0x180BE2D80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0xBE30C0", Offset = "0xBE22C0", VA = "0x180BE30C0")]
	public static EntityQuery PDDNMPJJEIO(ComponentSystemBase HJICJBAHBAD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0xBE2B80", Offset = "0xBE1D80", VA = "0x180BE2B80")]
	public static EntityQuery LCDEJPDJGBD(ComponentSystemBase HJICJBAHBAD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0xBE28F0", Offset = "0xBE1AF0", VA = "0x180BE28F0")]
	public static EntityQuery AOOGFBJJNKH(ComponentSystemBase HJICJBAHBAD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class DIBCLFGMLJJ : ParentSystemBase<ParentData, DFNCJJGLOJB, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0xA4BF10", Offset = "0xA4B110", VA = "0x180A4BF10", Slot = "14")]
	protected override EntityQueryDesc PHECNNGFGHJ(EntityQueryDesc IMOAAHEOFBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEB0", Offset = "0x6ED0B0", VA = "0x1806EDEB0", Slot = "15")]
	protected override EntityQueryDesc CPAJDJJPCGF(EntityQueryDesc IMOAAHEOFBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0xA4BE50", Offset = "0xA4B050", VA = "0x180A4BE50", Slot = "16")]
	protected override EntityQueryDesc HKGJOKEIPJF(EntityQueryDesc IMOAAHEOFBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0xA4BE90", Offset = "0xA4B090", VA = "0x180A4BE90", Slot = "17")]
	protected override EntityQueryDesc HLPLPLPHJKP(EntityQueryDesc IMOAAHEOFBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0xA4BF50", Offset = "0xA4B150", VA = "0x180A4BF50")]
	public DIBCLFGMLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0xA4BED0", Offset = "0xA4B0D0", VA = "0x180A4BED0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : PAJLCNMKBFJ where ParentData : struct, IComponentData, JHLIGMDNFAC where PreviousParentData : struct, IComponentData, JHLIGMDNFAC where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, JHLIGMDNFAC
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		[BurstCompile]
		private struct BHDGPFACGOH : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000248")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter BGJEOIPJGGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter BOMMMPEDJKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			public NativeHashMap<Entity, int>.ParallelWriter MFPPOOPHLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			public ArchetypeChunkComponentType<PreviousParentData> GDOGKIMELNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> BCLFNHIBMHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			[ReadOnly]
			public ArchetypeChunkEntityType LPHDDHCCMBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public uint IHDBCKAEPJH;

			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x4755000", Offset = "0x4754200", VA = "0x184755000", Slot = "4")]
			public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[BurstCompile]
		private struct NEPCGHHCEGG : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> MFPPOOPHLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> ALEBBOGAJKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public NativeList<Entity> IJCMGJEKNPJ;

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x475C7F0", Offset = "0x475B9F0", VA = "0x18475C7F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		[BurstCompile]
		private struct PJBPCCJIGOP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> BGJEOIPJGGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> BOMMMPEDJKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			[ReadOnly]
			public NativeHashMap<Entity, int> MFPPOOPHLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			public BufferFromEntity<ChildrenData> ALEBBOGAJKP;

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x475CE20", Offset = "0x475C020", VA = "0x18475CE20")]
			private int DGHMMGFEHAA(DynamicBuffer<ChildrenData> DKJCFPOBMFD, Entity BBPBBOAPCHN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x475CBD0", Offset = "0x475BDD0", VA = "0x18475CBD0")]
			private void AJDPPCDGGEF(Entity ENAGHEEPLJN, DynamicBuffer<ChildrenData> DKJCFPOBMFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x475D370", Offset = "0x475C570", VA = "0x18475D370")]
			private void JPDLJIMEJNB(Entity ENAGHEEPLJN, DynamicBuffer<ChildrenData> DKJCFPOBMFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x475CF20", Offset = "0x475C120", VA = "0x18475CF20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[BurstCompile]
		private struct MNJBMKCAKFK : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			public NativeArray<Entity> NFHPIFFPLMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			public NativeList<Entity> KGMJAAFNPCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public BufferFromEntity<ChildrenData> ALEBBOGAJKP;

			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0x47596F0", Offset = "0x47588F0", VA = "0x1847596F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		protected EntityQuery HDJAKAMJCGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		protected EntityQuery LONKACOGGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		protected EntityQuery LOMJPOOMONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		protected EntityQuery OEHDJPGPKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		protected ProfilerMarker HECFABDKGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		protected ProfilerMarker ONJJDPGINOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		protected ProfilerMarker PDCJKPAJHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		protected ProfilerMarker KGIOBJLFDMI;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x475F5B0", Offset = "0x475E7B0", VA = "0x18475F5B0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x475DC00", Offset = "0x475CE00", VA = "0x18475DC00")]
		private int DGHMMGFEHAA(DynamicBuffer<ChildrenData> DKJCFPOBMFD, Entity BBPBBOAPCHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x475D820", Offset = "0x475CA20", VA = "0x18475D820")]
		private void CPIOLALJOBM(Entity MDFKGGAELMG, Entity KHMILGHIBKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEB0", Offset = "0x6ED0B0", VA = "0x1806EDEB0", Slot = "14")]
		protected virtual EntityQueryDesc PHECNNGFGHJ(EntityQueryDesc IMOAAHEOFBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEB0", Offset = "0x6ED0B0", VA = "0x1806EDEB0", Slot = "15")]
		protected virtual EntityQueryDesc CPAJDJJPCGF(EntityQueryDesc IMOAAHEOFBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEB0", Offset = "0x6ED0B0", VA = "0x1806EDEB0", Slot = "16")]
		protected virtual EntityQueryDesc HKGJOKEIPJF(EntityQueryDesc IMOAAHEOFBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc HLPLPLPHJKP(EntityQueryDesc IMOAAHEOFBK);

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x475EEA0", Offset = "0x475E0A0", VA = "0x18475EEA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x475DD00", Offset = "0x475CF00", VA = "0x18475DD00")]
		private void HIEGDCBMDCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x475D660", Offset = "0x475C860", VA = "0x18475D660")]
		private void BPPMGOGAEDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x475DEE0", Offset = "0x475D0E0", VA = "0x18475DEE0")]
		private void MCLLIODNBAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x475E840", Offset = "0x475DA40", VA = "0x18475E840")]
		private void MFDLFLOKKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x475F3E0", Offset = "0x475E5E0", VA = "0x18475F3E0", Slot = "13")]
		protected override JobHandle OnUpdate(JobHandle PAEOIIAAEPH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x3945E40", Offset = "0x3945040", VA = "0x183945E40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[AlwaysUpdateSystem]
	[EJLOOKEAJML(HNJEFABFMIP.RenderEffects)]
	public abstract class PropagateTagsBase<TRootTag, TDescendantTag, TRootSystemTag> : MGFJEDJDOGN, AIOPJLICFNI where TRootTag : struct, IComponentData where TDescendantTag : struct, IComponentData where TRootSystemTag : struct, ISystemStateComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		private struct BNBOIPDINOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public global::CBEMPKKBCCF<Entity> NGIHOIGAPIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public global::CBEMPKKBCCF<Entity> OPMJKNPFJJB;

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x47559D0", Offset = "0x4754BD0", VA = "0x1847559D0")]
			public BNBOIPDINOA(NativeList<Entity> NGIHOIGAPIK, NativeList<Entity> OPMJKNPFJJB, JobHandle NOHHECKHGJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x47556D0", Offset = "0x47548D0", VA = "0x1847556D0")]
			public JobHandle KHNMDLILNAH(JobHandle AIOLNMINMPO)
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x47555B0", Offset = "0x47547B0", VA = "0x1847555B0")]
			public void DIPAICNNLME()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[BurstCompile]
		private struct FIEJALEIFHJ : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20000BE")]
			[Flags]
			public enum ABFDKEPPHHM
			{
				[Cpp2IlInjected.Token(Token = "0x400026A")]
				ReadParentFromArray = 1,
				[Cpp2IlInjected.Token(Token = "0x400026B")]
				FetchParentFromEntity = 2,
				[Cpp2IlInjected.Token(Token = "0x400026C")]
				AncestorTagValue = 4,
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				ConstNoAncestorTag = 0,
				[Cpp2IlInjected.Token(Token = "0x400026E")]
				ConstHasAncestorTag = 4
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			[WriteOnly]
			public NativeList<Entity> DPJJPNJBEOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			[WriteOnly]
			public NativeList<Entity> PCAMMKLFAPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			[ReadOnly]
			public NativeArray<Entity> AOLMMCGPJMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> BMJMPGCBKNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			[ReadOnly]
			public ComponentDataFromEntity<TRootTag> NPBDJICPJMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			[ReadOnly]
			public ComponentDataFromEntity<TDescendantTag> LNNMDDMJJKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			[ReadOnly]
			public ComponentDataFromEntity<ParentData> CNIJPBPABJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			public int CNGBMDJPPDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public int PNKNMPNCPLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private ABFDKEPPHHM EGPMEPNLMOB;

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x4756100", Offset = "0x4755300", VA = "0x184756100", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x4756430", Offset = "0x4755630", VA = "0x184756430")]
			private void LFCNIOMHGDN(Entity BBPBBOAPCHN, bool FNACEMCKCIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x4756510", Offset = "0x4755710", VA = "0x184756510")]
			private void LJNBNFFHFAH(Entity BBPBBOAPCHN, bool FNACEMCKCIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x4755F40", Offset = "0x4755140", VA = "0x184755F40")]
			public BNBOIPDINOA AKJJNAPLFBF(NativeArray<Entity> KEOBIBPKNFO, JobHandle AIOLNMINMPO)
			{
				return default(BNBOIPDINOA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x47568E0", Offset = "0x4755AE0", VA = "0x1847568E0")]
			public BNBOIPDINOA NJBBMJPHNOM(NativeArray<Entity> KEOBIBPKNFO, JobHandle AIOLNMINMPO)
			{
				return default(BNBOIPDINOA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x4756020", Offset = "0x4755220", VA = "0x184756020")]
			public BNBOIPDINOA DNIKOMAPBIJ(NativeList<CDPFCBNHAID> MDBHJOENILE, JobHandle AIOLNMINMPO)
			{
				return default(BNBOIPDINOA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x4755E60", Offset = "0x4755060", VA = "0x184755E60")]
			public BNBOIPDINOA AACNJNAEHNL(NativeList<CDPFCBNHAID> MDBHJOENILE, JobHandle AIOLNMINMPO)
			{
				return default(BNBOIPDINOA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x4756350", Offset = "0x4755550", VA = "0x184756350")]
			public BNBOIPDINOA HKFCIAAKBLJ(NativeList<BNPOJNEDCOI> MDBHJOENILE, JobHandle AIOLNMINMPO)
			{
				return default(BNBOIPDINOA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x4289F20", Offset = "0x4289120", VA = "0x184289F20")]
			private BNBOIPDINOA LPJEHKOMAMF<T>(NativeList<T> MDBHJOENILE, int ECFPCMIFKGA, int KFJEMJHPAOB, ABFDKEPPHHM PCDNKMPEHGG, JobHandle AIOLNMINMPO) where T : struct
			{
				return default(BNBOIPDINOA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x4756630", Offset = "0x4755830", VA = "0x184756630")]
			private BNBOIPDINOA LPJEHKOMAMF(NativeArray<Entity> JEFMGPHNDGN, int ECFPCMIFKGA, int KFJEMJHPAOB, ABFDKEPPHHM PCDNKMPEHGG, JobHandle AIOLNMINMPO)
			{
				return default(BNBOIPDINOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private EntityQuery LFGHFBCBONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private EntityQuery DEMGIGKPPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private FCBOBMFMIOB GAOAIBPHFBI;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x3969360", Offset = "0x3968560", VA = "0x183969360", Slot = "14")]
		public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x3969CF0", Offset = "0x3968EF0", VA = "0x183969CF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x396B6C0", Offset = "0x396A8C0", VA = "0x18396B6C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x39692F0", Offset = "0x39684F0", VA = "0x1839692F0")]
		private void BHGELBLFMNO(NativeArray<Entity> MDBHJOENILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x3969900", Offset = "0x3968B00", VA = "0x183969900")]
		private void CLMMMGPBCHM(NativeArray<Entity> MDBHJOENILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3969BA0", Offset = "0x3968DA0", VA = "0x183969BA0")]
		private void DNBPLEHMIIH(BNBOIPDINOA INFFKPGEFLD, string IJCJDGFBKOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x39699C0", Offset = "0x3968BC0", VA = "0x1839699C0")]
		private void DNBPLEHMIIH(global::CBEMPKKBCCF<Entity> IEADPIPLBBE, string IJCJDGFBKOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x39695D0", Offset = "0x39687D0", VA = "0x1839695D0")]
		private void CAHJKDCAGBE(BNBOIPDINOA INFFKPGEFLD, string IJCJDGFBKOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x3969810", Offset = "0x3968A10", VA = "0x183969810")]
		private void CAHJKDCAGBE(global::CBEMPKKBCCF<Entity> IEADPIPLBBE, string IJCJDGFBKOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x3969970", Offset = "0x3968B70", VA = "0x183969970")]
		private bool DHPIHLAOPJP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x396C290", Offset = "0x396B490", VA = "0x18396C290")]
		protected PropagateTagsBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x3945E40", Offset = "0x3945040", VA = "0x183945E40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct IAFMNOCNMND : ISystemStateComponentData, IComponentData, IEquatable<IAFMNOCNMND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public float3 MANFJDNPHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public float3 AFKJMIDHACP;

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x874840", Offset = "0x873A40", VA = "0x180874840", Slot = "4")]
	public bool Equals(IAFMNOCNMND GHOINNFPLDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class HBMIDPKICEC : MGFJEDJDOGN, GOKNGONBKFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct BJAJPHOCKFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public HBMIDPKICEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		public BJAJPHOCKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct LCDMMIMAKJH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		private struct GJHMJAKILLN
		{
			[Cpp2IlInjected.Token(Token = "0x20000C4")]
			public struct FIMEIPPBJIL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027D")]
				public LambdaParameterValueProvider_Entity.Runtime ICOHJGMIECE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity DPDNBIANGDI;

			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0xA52520", Offset = "0xA51720", VA = "0x180A52520")]
			public void MABHDODJKAO(HBMIDPKICEC HJICJBAHBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0xA52510", Offset = "0xA51710", VA = "0x180A52510")]
			public FIMEIPPBJIL GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
			{
				return default(FIMEIPPBJIL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public HBMIDPKICEC JJOBHIEINGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public EntityCommandBuffer NBBLDCMLGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private GJHMJAKILLN ANIEMPIBNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GJHMJAKILLN.FIMEIPPBJIL* AHPNEFKAFJO;

		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LCJAIGMFHHE;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xA56AE0", Offset = "0xA55CE0", VA = "0x180A56AE0")]
		internal void NFKNCPPNADH(Entity MAMHFFLAIIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xA56C30", Offset = "0xA55E30", VA = "0x180A56C30", Slot = "5")]
		public void ReadFromDisplayClass(ref BJAJPHOCKFI CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xA56C60", Offset = "0xA55E60", VA = "0x180A56C60", Slot = "6")]
		public void WriteToDisplayClass(ref BJAJPHOCKFI CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xA569D0", Offset = "0xA55BD0", VA = "0x180A569D0", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA56A30", Offset = "0xA55C30", VA = "0x180A56A30")]
		public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, ref GJHMJAKILLN.FIMEIPPBJIL LIDOEFEMELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA56AA0", Offset = "0xA55CA0", VA = "0x180A56AA0")]
		public void MABHDODJKAO(HBMIDPKICEC HJICJBAHBAD, ref BJAJPHOCKFI CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xA56BD0", Offset = "0xA55DD0", VA = "0x180A56BD0")]
		public unsafe static void NHFOKKFCGIG(ArchetypeChunkIterator* DMENKPONMKK, void* DPAIKCDDPBE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private POPAFNDGOBB JOPPDLOBHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private IBPGEALOLCI NDHHNKNFIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private EntityQuery FBEFMHIPBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private ProfilerMarker PNEHJLDDGIE;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0xA55AA0", Offset = "0xA54CA0", VA = "0x180A55AA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0xA55840", Offset = "0xA54A40", VA = "0x180A55840", Slot = "14")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0xA55B00", Offset = "0xA54D00", VA = "0x180A55B00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public HBMIDPKICEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0xA558A0", Offset = "0xA54AA0", VA = "0x180A558A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0xA55C80", Offset = "0xA54E80", VA = "0x180A55C80")]
	public static EntityQuery PDDBCGPFCMF(ComponentSystemBase HJICJBAHBAD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public struct EAPCPEGAKKJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public CIDFIAKDCLL BEDKMKLJIGF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660")]
	public static EAPCPEGAKKJ BKALKAPLPLL(in CIDFIAKDCLL PMLEACMOMDG)
	{
		return default(EAPCPEGAKKJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660")]
	public static CIDFIAKDCLL BKALKAPLPLL(in EAPCPEGAKKJ LFOPLKDGKKP)
	{
		return default(CIDFIAKDCLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[CLDGIFMABHG(typeof(IBPGEALOLCI), new string[] { })]
public sealed class OLLMHGNJKND : IBPGEALOLCI, KBFAPJDPNBI, GFHKHHPFFGF, GOKNGONBKFG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private const int EIKJBABJEHB = -1;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private const int DBPHFGMIPPH = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private Collider[] ECHOKKFADJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private RaycastHit[] GNMEEGPCLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private global::NNJNOKFJADK<CIDFIAKDCLL, BoxCollider> IPBKCFOFCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private Scene EHOKFNHPHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private PhysicsScene LDMHOGKHBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private GameObject DBHBBNPKELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private BPPHGPLKBFA AJFGIKGFKKO;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int FJLKDHBMDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xBE1FD0", Offset = "0xBE11D0", VA = "0x180BE1FD0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0xBE1AC0", Offset = "0xBE0CC0", VA = "0x180BE1AC0", Slot = "10")]
	public void JFNNIMEOELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0xBE1360", Offset = "0xBE0560", VA = "0x180BE1360", Slot = "11")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0xBE1190", Offset = "0xBE0390", VA = "0x180BE1190", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0xBE15D0", Offset = "0xBE07D0", VA = "0x180BE15D0", Slot = "5")]
	public CIDFIAKDCLL GPDJBEAOMLE(Entity BBPBBOAPCHN)
	{
		return default(CIDFIAKDCLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0xBE1DB0", Offset = "0xBE0FB0", VA = "0x180BE1DB0", Slot = "6")]
	public void NKJFDAEDHEJ(NativeArray<CIDFIAKDCLL> DJEDGFAAOBH, NativeArray<IAFMNOCNMND> AKHPMMFMJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0xBE1D10", Offset = "0xBE0F10", VA = "0x180BE1D10", Slot = "7")]
	public void NHNDKNCKGNI(CIDFIAKDCLL BEDKMKLJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0xBE1C10", Offset = "0xBE0E10", VA = "0x180BE1C10", Slot = "8")]
	public bool KEDOCKKOJFK(CIDFIAKDCLL BEDKMKLJIGF, out Collider JGDOJJPMCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0xBE0E50", Offset = "0xBE0050", VA = "0x180BE0E50")]
	public bool ANKEENHCMIF(in float3 HLAJBHJKKJJ, in float3 KJGKDNLKBAL, float DHPKDFNDGCD, Allocator MKFODJKMOCC, out NativeArray<Entity> JEFMGPHNDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0xBE16F0", Offset = "0xBE08F0", VA = "0x180BE16F0")]
	private void IFCLPBMJPEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0xBE1FB0", Offset = "0xBE11B0", VA = "0x180BE1FB0")]
	private void OOODMFAKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0xBE1CB0", Offset = "0xBE0EB0", VA = "0x180BE1CB0")]
	private void LEBFMIKJDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0xBE1160", Offset = "0xBE0360", VA = "0x180BE1160")]
	private void BHHMKNKIPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0xBE1270", Offset = "0xBE0470", VA = "0x180BE1270")]
	private BoxCollider EEJIJPCPOCD(Entity BBPBBOAPCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0xBE1950", Offset = "0xBE0B50", VA = "0x180BE1950")]
	private void ILPAEFFIFIK(BoxCollider JLADNPKNMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0xBE1410", Offset = "0xBE0610", VA = "0x180BE1410")]
	[Conditional("UNITY_EDITOR")]
	private void EMICICDDBGJ(GameObject NEFMINHNLIG, Entity BBPBBOAPCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0xBE1450", Offset = "0xBE0650", VA = "0x180BE1450")]
	private void FLHAMFOIFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0xBE19D0", Offset = "0xBE0BD0", VA = "0x180BE19D0")]
	private void JCFDPBODHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0xBE1780", Offset = "0xBE0980", VA = "0x180BE1780")]
	private void IJMBHOPCKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0xBE15A0", Offset = "0xBE07A0", VA = "0x180BE15A0")]
	private void GLFFKGBDLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0xBE1D00", Offset = "0xBE0F00", VA = "0x180BE1D00")]
	private void LLBGCHFNGHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0xBE1740", Offset = "0xBE0940", VA = "0x180BE1740")]
	private void IGJHACHLGJJ(Scene DJDADJJKOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public OLLMHGNJKND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0xBE1180", Offset = "0xBE0380", VA = "0x180BE1180", Slot = "9")]
	private bool CJHGIDKNHBL(in float3 HLAJBHJKKJJ, in float3 KJGKDNLKBAL, float DHPKDFNDGCD, Allocator MKFODJKMOCC, out NativeArray<Entity> JEFMGPHNDGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class POPAFNDGOBB : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640")]
	public POPAFNDGOBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class DNGHLBFGHBL : MGFJEDJDOGN, GOKNGONBKFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct PLHELGBJBJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public DNGHLBFGHBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		public PLHELGBJBJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
		internal void <OnUpdate>b__0(Entity e, EAPCPEGAKKJ ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct ODPLBEEJOEK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		private struct JHMFHIKHEOE
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			public struct PNOKBMJBGCF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000295")]
				public LambdaParameterValueProvider_Entity.Runtime ICOHJGMIECE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000296")]
				public LambdaParameterValueProvider_IComponentData<EAPCPEGAKKJ>.Runtime EEOIJGPPGCE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity DPDNBIANGDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<EAPCPEGAKKJ> MFEHODCAFCI;

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0xA56160", Offset = "0xA55360", VA = "0x180A56160")]
			public void MABHDODJKAO(DNGHLBFGHBL HJICJBAHBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0xA560E0", Offset = "0xA552E0", VA = "0x180A560E0")]
			public PNOKBMJBGCF GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
			{
				return default(PNOKBMJBGCF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public DNGHLBFGHBL JJOBHIEINGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public EntityCommandBuffer NBBLDCMLGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private JHMFHIKHEOE ANIEMPIBNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JHMFHIKHEOE.PNOKBMJBGCF* AHPNEFKAFJO;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LCJAIGMFHHE;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xA57E20", Offset = "0xA57020", VA = "0x180A57E20")]
		internal void NFKNCPPNADH(Entity MAMHFFLAIIN, EAPCPEGAKKJ JOLCELNNJEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xA56C30", Offset = "0xA55E30", VA = "0x180A56C30", Slot = "5")]
		public void ReadFromDisplayClass(ref PLHELGBJBJK CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xA56C60", Offset = "0xA55E60", VA = "0x180A56C60", Slot = "6")]
		public void WriteToDisplayClass(ref PLHELGBJBJK CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xA57C40", Offset = "0xA56E40", VA = "0x180A57C40", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xA57CE0", Offset = "0xA56EE0", VA = "0x180A57CE0")]
		public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, ref JHMFHIKHEOE.PNOKBMJBGCF LIDOEFEMELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xA57D90", Offset = "0xA56F90", VA = "0x180A57D90")]
		public void MABHDODJKAO(DNGHLBFGHBL HJICJBAHBAD, ref PLHELGBJBJK CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xA57F20", Offset = "0xA57120", VA = "0x180A57F20")]
		public unsafe static void NHFOKKFCGIG(ArchetypeChunkIterator* DMENKPONMKK, void* DPAIKCDDPBE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private POPAFNDGOBB JOPPDLOBHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private IBPGEALOLCI NDHHNKNFIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery EKMPJBNBEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private ProfilerMarker BNJBKEDKBGB;

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0xA4D540", Offset = "0xA4C740", VA = "0x180A4D540", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0xA4D150", Offset = "0xA4C350", VA = "0x180A4D150", Slot = "14")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0xA4D5A0", Offset = "0xA4C7A0", VA = "0x180A4D5A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public DNGHLBFGHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0xA4D340", Offset = "0xA4C540", VA = "0x180A4D340", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0xA4D1B0", Offset = "0xA4C3B0", VA = "0x180A4D1B0")]
	public static EntityQuery OBNMJEIPCKA(ComponentSystemBase HJICJBAHBAD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[EJLOOKEAJML(HNJEFABFMIP.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : MGFJEDJDOGN, GOKNGONBKFG
	{
		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		private struct LCLBMOABCBC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			public GFIODLFGCBC AMIFBGIBKJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			public NativeHashMap<Entity, JMNHLBPPELC> JEFMGPHNDGN;

			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x8F4610", Offset = "0x8F3810", VA = "0x1808F4610")]
			public LCLBMOABCBC(int GOCCOAPEHDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x8F45A0", Offset = "0x8F37A0", VA = "0x1808F45A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		[BurstCompile]
		private struct OAAMLBGJPPK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			[ReadOnly]
			public NativeArray<Entity> JEFMGPHNDGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> ACOAPEIDEBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> DHFAHNLEOPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> LGPHGALDDIJ;

			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x8F5030", Offset = "0x8F4230", VA = "0x1808F5030", Slot = "4")]
			public void Execute(int MJNAIOAAGCG, TransformAccess EJOKPJGAPEO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[BurstCompile]
		private struct OMIOLAEELED : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			[ReadOnly]
			public NativeArray<Entity> JEFMGPHNDGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> ACOAPEIDEBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> LGPHGALDDIJ;

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0x8F54F0", Offset = "0x8F46F0", VA = "0x1808F54F0", Slot = "4")]
			public void Execute(int MJNAIOAAGCG, TransformAccess EJOKPJGAPEO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private IBPGEALOLCI NDHHNKNFIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private EntityQuery OHBLFKJPKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private EntityQuery ICMPLEKIELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery GMCMPMKLCGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery KPGMLGAMLIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery FNKHCNCGLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private JobHandle BBMFMGHHBOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private LCLBMOABCBC HABPMBPCEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private LCLBMOABCBC MMJDBHJAHBG;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x8FC120", Offset = "0x8FB320", VA = "0x1808FC120", Slot = "14")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x8FC8B0", Offset = "0x8FBAB0", VA = "0x1808FC8B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x8FCAF0", Offset = "0x8FBCF0", VA = "0x1808FCAF0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB00", Offset = "0x8FBD00", VA = "0x1808FCB00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x8FC750", Offset = "0x8FB950", VA = "0x1808FC750")]
		private void OCHEKOJELLJ(EntityQuery IMOAAHEOFBK, out (global::ENJHCOCKNOH<EAPCPEGAKKJ> handles, global::ENJHCOCKNOH<IAFMNOCNMND> bounds) ADIGGFBANFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x8FC180", Offset = "0x8FB380", VA = "0x1808FC180")]
		private void GNGOLFCIKIL((global::ENJHCOCKNOH<EAPCPEGAKKJ> handles, global::ENJHCOCKNOH<IAFMNOCNMND> bounds) ADIGGFBANFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8FC020", Offset = "0x8FB220", VA = "0x1808FC020")]
		private void DKGICECLGJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8FC390", Offset = "0x8FB590", VA = "0x1808FC390")]
		private void HCIDOJLMFGK(EntityQuery IMOAAHEOFBK, out (global::ENJHCOCKNOH<Entity> entities, global::ENJHCOCKNOH<EAPCPEGAKKJ> handles) ADIGGFBANFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4F0", Offset = "0x8FB6F0", VA = "0x1808FC4F0")]
		private void HPGPHDFGLLK((global::ENJHCOCKNOH<Entity> entities, global::ENJHCOCKNOH<EAPCPEGAKKJ> handles) ADIGGFBANFM, LCLBMOABCBC FPFNMCEJGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x8FD360", Offset = "0x8FC560", VA = "0x1808FD360")]
		private JobHandle PEDCKCPPKAM(LCLBMOABCBC FPFNMCEJGIC, ComponentDataFromEntity<WorldPoseData> ACOAPEIDEBK, ComponentDataFromEntity<WorldUniformScaleData> LGPHGALDDIJ, ComponentDataFromEntity<WorldDeformableScaleData> DHFAHNLEOPO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8FBEF0", Offset = "0x8FB0F0", VA = "0x1808FBEF0")]
		private JobHandle CHJIIAMDAGH(LCLBMOABCBC FPFNMCEJGIC, ComponentDataFromEntity<WorldPoseData> ACOAPEIDEBK, ComponentDataFromEntity<WorldUniformScaleData> LGPHGALDDIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[CLDGIFMABHG(typeof(ONCONOLCJEF), new string[] { })]
public sealed class OOBMDMNONAF : ONCONOLCJEF, GOKNGONBKFG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private struct HEMNCMOGHLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public float BJKCOFOFGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public uint EGJEGCJLGEC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private KBFAPJDPNBI PJBDLBCGNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private CIMICFIGKNI EAAPLKOBFKC;

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0xBE2760", Offset = "0xBE1960", VA = "0x180BE2760", Slot = "5")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0xBE2370", Offset = "0xBE1570", VA = "0x180BE2370")]
	public bool ANKEENHCMIF(in float3 HLAJBHJKKJJ, in float3 KJGKDNLKBAL, float DHPKDFNDGCD, out JPIKNFHMEAP NBPHPGOKHPH, out Entity AKKLCODOHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0xBE2800", Offset = "0xBE1A00", VA = "0x180BE2800")]
	public static bool OAJHEKNLDLK(in Span<JPIKNFHMEAP> OHBEOOACNNJ, float DHPKDFNDGCD, out int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0xBE27C0", Offset = "0xBE19C0", VA = "0x180BE27C0")]
	public static float HDEPNLNKIBE(float BJKCOFOFGCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public OOBMDMNONAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0xBE27F0", Offset = "0xBE19F0", VA = "0x180BE27F0", Slot = "4")]
	private bool KBLCFEIOEIK(in float3 HLAJBHJKKJJ, in float3 KJGKDNLKBAL, float DHPKDFNDGCD, out JPIKNFHMEAP NBPHPGOKHPH, out Entity AKKLCODOHIE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct LDCEFCHIEAB : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[EJLOOKEAJML(HNJEFABFMIP.Physics)]
	public class SplineLocalBoundsSystem : MGFJEDJDOGN
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[BurstCompile]
		private struct CMMALMOFCEH : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			[ReadOnly]
			public NativeArray<Entity> JHBEKDHFBPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> PMEPBGHKFHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			[ReadOnly]
			public ComponentDataFromEntity<IAFMNOCNMND> MHLOHGIEONB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			[WriteOnly]
			public NativeHashMap<Entity, JMNHLBPPELC>.ParallelWriter AKGIPHPIFAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter KHAMKHGPPPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter PIIBIOBGDBN;

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x8F1F60", Offset = "0x8F1160", VA = "0x1808F1F60", Slot = "4")]
			public void Execute(int MJNAIOAAGCG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[BurstCompile]
		private struct ENOAINAHNNB : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[ReadOnly]
			public NativeArray<Entity> GCEDJDLEPEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> KFCDIEMCGCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> PMEPBGHKFHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<IAFMNOCNMND> MCNIACFGIJE;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F20F0", VA = "0x1808F2EF0", Slot = "4")]
			public void Execute(int MJNAIOAAGCG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery NOPOKNGOCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery ACKMHGGCKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery POFOBKKPLFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery HEOBEABFGBL;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x9028C0", Offset = "0x901AC0", VA = "0x1809028C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x902A60", Offset = "0x901C60", VA = "0x180902A60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x901E40", Offset = "0x901040", VA = "0x180901E40")]
		private JobHandle FBFPCHKCHAM(global::ENJHCOCKNOH<Entity> NAJOFPKLJJG, int IPOIAMFIOLH, JobHandle AIOLNMINMPO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x901C80", Offset = "0x900E80", VA = "0x180901C80")]
		private JobHandle FBFPCHKCHAM(NativeArray<Entity> OJEINEDBNPD, int IPOIAMFIOLH, [Optional] JobHandle AIOLNMINMPO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x901BF0", Offset = "0x900DF0", VA = "0x180901BF0")]
		private global::ENJHCOCKNOH<Entity> CCBJJOFDBLM(EntityQuery IMOAAHEOFBK)
		{
			return default(global::ENJHCOCKNOH<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x902170", Offset = "0x901370", VA = "0x180902170")]
		private (global::CBEMPKKBCCF<Entity>, global::CBEMPKKBCCF<Entity>) LMHNAEEONKI(global::ENJHCOCKNOH<Entity> NJGOCNPNHGL)
		{
			return default((global::CBEMPKKBCCF<Entity>, global::CBEMPKKBCCF<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x901B70", Offset = "0x900D70", VA = "0x180901B70")]
		private void AHBNMDGGNMB(out NativeArray<Entity> JEFMGPHNDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x901F10", Offset = "0x901110", VA = "0x180901F10")]
		private void IGDDHFKEKAG(NativeList<Entity> JEFMGPHNDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x901F90", Offset = "0x901190", VA = "0x180901F90")]
		private void IGDDHFKEKAG(NativeArray<Entity> JEFMGPHNDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x902050", Offset = "0x901250", VA = "0x180902050")]
		private void KCJHKKCGJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		private static void JKOMOAENGJA(int CNIBLEHFFNP, int BKAGHBIBNHI, int GDHHCBJFFLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x902540", Offset = "0x901740", VA = "0x180902540")]
		private static IAFMNOCNMND OKAJPEMIKOK(NativeArray<Entity> MEHBFDELOPE, ComponentDataFromEntity<SplinePointData> PMEPBGHKFHG)
		{
			return default(IAFMNOCNMND);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[CLDGIFMABHG(typeof(CIMICFIGKNI), new string[] { })]
public sealed class KCAHCHNIGFK : CIMICFIGKNI, GOKNGONBKFG
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[BurstCompile]
	private struct EIFJCODGLID : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		[ReadOnly]
		public NativeArray<Entity> JEFMGPHNDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		[ReadOnly]
		public float3 OABGDMPPAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		[ReadOnly]
		public float3 KLFHCKKEBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> CAGKMOMCPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> LCLDCNDLOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> KFCDIEMCGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointData> PMEPBGHKFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[WriteOnly]
		public NativeArray<JPIKNFHMEAP> PPEACDJMJKE;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static readonly JPIKNFHMEAP MGJELNMDEEE;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x86E9E0", Offset = "0x86DBE0", VA = "0x18086E9E0", Slot = "4")]
		public void Execute(int MJNAIOAAGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x86ED10", Offset = "0x86DF10", VA = "0x18086ED10")]
		private static float3 GOLNLLLAKIA(in float4x4 LDCAODBOOEA, in float3 DNNNMCEHJCM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x86EDD0", Offset = "0x86DFD0", VA = "0x18086EDD0")]
		private static float3 KHKGPMJLHDM(in float4x4 LDCAODBOOEA, in float3 NMCOJHAIJEG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x86E8E0", Offset = "0x86DAE0", VA = "0x18086E8E0")]
		private static float3 DGKBNKOHCIA(in float4x4 LDCAODBOOEA, in float3 DNNNMCEHJCM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x86EFA0", Offset = "0x86E1A0", VA = "0x18086EFA0")]
		private static float3 MEBBIJKEENF(in float4x4 LDCAODBOOEA, in float3 NMCOJHAIJEG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x86F1D0", Offset = "0x86E3D0", VA = "0x18086F1D0")]
		private bool NOLPCMCCJLD(in float3 HLAJBHJKKJJ, in float3 KJGKDNLKBAL, in NativeArray<Entity> NHKFBHGKIBF, out float3 NBPHPGOKHPH, out float3 DBLFCAOKHOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x86F520", Offset = "0x86E720", VA = "0x18086F520")]
		public static bool PDHJCILFMEJ(in float3 BJIHDOJEDHK, in float3 LENOLCGKIDO, in float3 MMNEEAIJFMG, in float3 AJELEADFLPH, float HPKALCJECFC, float NLFPFPEALIA, out float FOLCGJFJJMP, out float3 KPJOFMJMOJP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private EntityManager KHDMOGKDGKL;

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x87C1A0", Offset = "0x87B3A0", VA = "0x18087C1A0", Slot = "5")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x87BF90", Offset = "0x87B190", VA = "0x18087BF90")]
	public void ANKEENHCMIF(in NativeArray<Entity> JEFMGPHNDGN, in float3 HLAJBHJKKJJ, in float3 KJGKDNLKBAL, in NativeArray<JPIKNFHMEAP> LMBKHOEBKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public KCAHCHNIGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x87BF90", Offset = "0x87B190", VA = "0x18087BF90", Slot = "4")]
	private void HADLPKDPEFE(in NativeArray<Entity> JEFMGPHNDGN, in float3 HLAJBHJKKJJ, in float3 KJGKDNLKBAL, in NativeArray<JPIKNFHMEAP> LMBKHOEBKGC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct MMCJHBELOAM : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[EJLOOKEAJML(HNJEFABFMIP.Lifecycle)]
	public class DestroyLocalObjects : MGFJEDJDOGN
	{
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private bool JGKFDLIIMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private EntityQuery GIDIFBHNHOL;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0A0", Offset = "0xBDC2A0", VA = "0x180BDD0A0")]
		public bool BGCMOKAOCFH(Entity BBPBBOAPCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xBDD140", Offset = "0xBDC340", VA = "0x180BDD140", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xBDD1C0", Offset = "0xBDC3C0", VA = "0x180BDD1C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x9B5EF0", Offset = "0x9B50F0", VA = "0x1809B5EF0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[EJLOOKEAJML(HNJEFABFMIP.NetworkSend)]
	public abstract class EnqueuePropertyDifferenceToNetwork : MGFJEDJDOGN, GOKNGONBKFG
	{
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private KHLPPLBGKHH KEGFCCGIDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private AEKECOGJAHN JGHMLHPFFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private FJGGKJJCIJE APHHABICAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private KFJGJDHPGIJ IBBEGDPIJBO;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		protected abstract ComputePropertyDifferences DPLINEAEBMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xBDE080", Offset = "0xBDD280", VA = "0x180BDE080", Slot = "14")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xBDE130", Offset = "0xBDD330", VA = "0x180BDE130", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		private void EOENCAGJJJL(Entity BBPBBOAPCHN, NJKBLCBBANC AGHJLKKAHGN, PPDCFKFFIMN HOBAGAEEOGL, AHCJFBNOGLE FGGCLIBGDBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		protected EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[EJLOOKEAJML(HNJEFABFMIP.Callbacks)]
	public abstract class PropertyEventCallbacks : MGFJEDJDOGN, GOKNGONBKFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private PropertyEventCallbacksService PEKPJMOPJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private KFJGJDHPGIJ IBBEGDPIJBO;

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x9007F0", Offset = "0x8FF9F0", VA = "0x1809007F0", Slot = "14")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x900870", Offset = "0x8FFA70", VA = "0x180900870", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		protected PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public abstract class FGFCDHKEKED : MGFJEDJDOGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private List<(EntityQuery, ComponentType)> KIOLEKBJBID;

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0xA4FF30", Offset = "0xA4F130", VA = "0x180A4FF30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0xA50100", Offset = "0xA4F300", VA = "0x180A50100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0xA50250", Offset = "0xA4F450", VA = "0x180A50250")]
	protected FGFCDHKEKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal struct PBMAKNIFBLO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public int CCIFACONDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public int IDFONEJIHAP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0xBE53E0", Offset = "0xBE45E0", VA = "0x180BE53E0")]
	public static Entity BKALKAPLPLL(PBMAKNIFBLO ADIGGFBANFM)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0xBE53E0", Offset = "0xBE45E0", VA = "0x180BE53E0")]
	public static PBMAKNIFBLO BKALKAPLPLL(Entity BBPBBOAPCHN)
	{
		return default(PBMAKNIFBLO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal struct JHJNKGLJMAC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct EAFFJHCGNCC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public readonly ComponentType EPFBGGDPMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public readonly NativeList<int> OHIFGOLKNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public readonly NativeList<int> BLODFAPHALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public readonly NativeArray<Entity> JEFMGPHNDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public readonly NativeArray<Entity> NDDOCFCANCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public readonly NativeArray<byte> IPBPGGBABHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public readonly NativeArray<byte> DCBHGCPJBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public readonly int GMKBGDDNBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public readonly int BCNNHGENEDI;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool PLDPANAKIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA30", Offset = "0xA4CC30", VA = "0x180A4DA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0xA4DAA0", Offset = "0xA4CCA0", VA = "0x180A4DAA0")]
	public EAFFJHCGNCC(ComponentType EPFBGGDPMCN, NativeList<int> OHIFGOLKNPK, NativeList<int> BLODFAPHALD, NativeArray<Entity> JEFMGPHNDGN, NativeArray<Entity> NDDOCFCANCL, NativeArray<byte> IPBPGGBABHM, NativeArray<byte> DCBHGCPJBOG, int GMKBGDDNBLM, int BCNNHGENEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0xA4D8C0", Offset = "0xA4CAC0", VA = "0x180A4D8C0")]
	private JFFJOIBOPJP JIGNMJKNFOA(NativeArray<byte> NAJOFPKLJJG, int MJNAIOAAGCG)
	{
		return default(JFFJOIBOPJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	private T JIGNMJKNFOA<T>(NativeArray<byte> NAJOFPKLJJG, int MJNAIOAAGCG) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0xA4D790", Offset = "0xA4C990", VA = "0x180A4D790")]
	public JFFJOIBOPJP ABEHPLGHGIJ(int MJNAIOAAGCG)
	{
		return default(JFFJOIBOPJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	public T ABEHPLGHGIJ<T>(int MJNAIOAAGCG) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0xA4D9E0", Offset = "0xA4CBE0", VA = "0x180A4D9E0")]
	public JFFJOIBOPJP JMKHODMADJH(int MJNAIOAAGCG)
	{
		return default(JFFJOIBOPJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	public T JMKHODMADJH<T>(int MJNAIOAAGCG) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0xA4D7E0", Offset = "0xA4C9E0", VA = "0x180A4D7E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public struct LMIIOOGLAFJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public readonly EntityQuery IMOAAHEOFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public readonly NativeArray<FEDEGNHCJHF> OMFFMMHBAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public readonly ComponentType EPFBGGDPMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public readonly int GMKBGDDNBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public readonly int BCNNHGENEDI;

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x8807F0", Offset = "0x87F9F0", VA = "0x1808807F0")]
	public LMIIOOGLAFJ(ComponentType EPFBGGDPMCN, int GMKBGDDNBLM, int BCNNHGENEDI, EntityQuery IMOAAHEOFBK, NativeArray<FEDEGNHCJHF> OMFFMMHBAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x8807A0", Offset = "0x87F9A0", VA = "0x1808807A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal struct OFKILMKJFHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public int MJNAIOAAGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public int NBJCICEKBKB;

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x884C10", Offset = "0x883E10", VA = "0x180884C10")]
	public OFKILMKJFHG(int MJNAIOAAGCG, int NBJCICEKBKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public struct FEDEGNHCJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public readonly int FDGAPOLJFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public readonly int DFCIFDODMGE;

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x884C10", Offset = "0x883E10", VA = "0x180884C10")]
	public FEDEGNHCJHF(int FDGAPOLJFKN, int DFCIFDODMGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public struct AHCJFBNOGLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly CAEHPHOEGJK IHPCCBHNEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private readonly int GMKBGDDNBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private unsafe readonly byte* IPBPGGBABHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private unsafe readonly byte* DCBHGCPJBOG;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool MJFCPIFHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xA46190", Offset = "0xA45390", VA = "0x180A46190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public CAEHPHOEGJK JAEIODDCFEN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FD360", Offset = "0x6FC560", VA = "0x1806FD360")]
		get
		{
			return default(CAEHPHOEGJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0xA45FD0", Offset = "0xA451D0", VA = "0x180A45FD0")]
	public JFFJOIBOPJP ACKGENLDABJ(Type BGMCKNGNOJI)
	{
		return default(JFFJOIBOPJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0xA460B0", Offset = "0xA452B0", VA = "0x180A460B0")]
	public JFFJOIBOPJP HHBCKCBKOLJ(Type BGMCKNGNOJI)
	{
		return default(JFFJOIBOPJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x3842DF0", Offset = "0x3841FF0", VA = "0x183842DF0")]
	public T ACKGENLDABJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x3842E10", Offset = "0x3842010", VA = "0x183842E10")]
	public T HHBCKCBKOLJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0xA461A0", Offset = "0xA453A0", VA = "0x180A461A0")]
	public unsafe AHCJFBNOGLE(CAEHPHOEGJK IHPCCBHNEMN, int DFCIFDODMGE, byte* IPBPGGBABHM, byte* DCBHGCPJBOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class GKOJJFCEJCG
{
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] NGFIOIGHGEN;
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[DefaultMember("Item")]
internal class KJJMLOAIOPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private readonly Dictionary<ComponentType, LMIIOOGLAFJ> EAHECGKJECG;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public LMIIOOGLAFJ LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x87E210", Offset = "0x87D410", VA = "0x18087E210")]
		get
		{
			return default(LMIIOOGLAFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x87D8B0", Offset = "0x87CAB0", VA = "0x18087D8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x87E290", Offset = "0x87D490", VA = "0x18087E290")]
	public KJJMLOAIOPA(EGHMCKEACDK PELFBHDCPAJ, MKIMOBFPILG GPGEBBCKNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x87DA70", Offset = "0x87CC70", VA = "0x18087DA70")]
	public Dictionary<ComponentType, LMIIOOGLAFJ>.Enumerator ENNIMPBLHKI()
	{
		return default(Dictionary<ComponentType, LMIIOOGLAFJ>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x87D900", Offset = "0x87CB00", VA = "0x18087D900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x87DE60", Offset = "0x87D060", VA = "0x18087DE60")]
	private void NNGAGHKIILL(IEnumerable<JJHBGAMPJOH> PJELCPOFHEK, EntityManager KHDMOGKDGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x87DDB0", Offset = "0x87CFB0", VA = "0x18087DDB0")]
	private static int LOHDALBENDL(JJHBGAMPJOH ONKMFJENELJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x87DB00", Offset = "0x87CD00", VA = "0x18087DB00")]
	private static NativeArray<FEDEGNHCJHF> GHGJFGPEKPM(JJHBGAMPJOH ONKMFJENELJ, Allocator MKFODJKMOCC = Allocator.Persistent)
	{
		return default(NativeArray<FEDEGNHCJHF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal interface KFJGJDHPGIJ
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	World DCHGJMDAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BNPFBMDOGGG(out NativeArray<int> OJCMOMOFBEO, Allocator MKFODJKMOCC);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JJHPJBLDHBB(ComponentType EPFBGGDPMCN, out EAFFJHCGNCC DEEGNKLILCC, out LMIIOOGLAFJ JMCKGOOADHK);

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JJHPJBLDHBB(ComponentType EPFBGGDPMCN, out EAFFJHCGNCC DEEGNKLILCC);

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EAFFJHCGNCC ONIFGKOOALH(ComponentType EPFBGGDPMCN);

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JBAMKLOILAA FCCMACAAOMI();

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODHIOAPJODP(JobHandle NOHHECKHGJG);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal interface JADIANBGGHP
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	World DCHGJMDAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	KJJMLOAIOPA FNPHAIPMMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	BDDIFFHCCJM CDOJHDPJIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	NativeMultiHashMap<Entity, AHCJFBNOGLE> CFGJIELEMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	JobHandle IEONCMALIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPGMNJIIOMJ();

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NLALCDJNEAF();

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GKBPNNKHFHC(ComponentType EPFBGGDPMCN, in EAFFJHCGNCC NFBBIHCIPFO);

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HOMFJOMMNGA(FNCBEEHJHBJ FKFNLDMHBOL, out Entity DBHBBNPKELE);
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CLDGIFMABHG(typeof(PropertyDiffStateService), new string[] { })]
	[EJLOOKEAJML(HNJEFABFMIP.PropertyChanges)]
	internal class PropertyDiffStateService : GOKNGONBKFG, AIOPJLICFNI, JADIANBGGHP, KFJGJDHPGIJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private EGHMCKEACDK PELFBHDCPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private ObjectPrefabCreationService ACNDAIINMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private NMIMFDNKLJP GLODAFJJDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private KJJMLOAIOPA EAHECGKJECG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private BDDIFFHCCJM MEACCMICCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private HEMCNGFDFBO CBFKHLINGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private List<EAFFJHCGNCC> EICNDHKDEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private NativeMultiHashMap<Entity, AHCJFBNOGLE> IJBLMCGKHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private NativeHashMap<int, int> KAFHMIPDLII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private JobHandle EELJBFGKMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private JobHandle JCMGMMDMFHP;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public bool PLDPANAKIIH
		{
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x8FF2B0", Offset = "0x8FE4B0", VA = "0x1808FF2B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		private World DJHKDFKALPD
		{
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x8FEE60", Offset = "0x8FE060", VA = "0x1808FEE60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private KJJMLOAIOPA AFFPCAJOPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private BDDIFFHCCJM FMEOPEHKDHH
		{
			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x734270", Offset = "0x733470", VA = "0x180734270", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private NativeMultiHashMap<Entity, AHCJFBNOGLE> CELMHBMIDDN
		{
			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0x8FF2A0", Offset = "0x8FE4A0", VA = "0x1808FF2A0", Slot = "9")]
			get
			{
				return default(NativeMultiHashMap<Entity, AHCJFBNOGLE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		private JobHandle DDGFICKOAMN
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x8FEEC0", Offset = "0x8FE0C0", VA = "0x1808FEEC0", Slot = "10")]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x8FF4E0", Offset = "0x8FE6E0", VA = "0x1808FF4E0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		private World KDKNPHGKELM
		{
			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x8FEE00", Offset = "0x8FE000", VA = "0x1808FEE00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x8FEBC0", Offset = "0x8FDDC0", VA = "0x1808FEBC0", Slot = "13")]
		private void EDHPLBFEAPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x8FEED0", Offset = "0x8FE0D0", VA = "0x1808FEED0", Slot = "12")]
		private void JDPOCDCEOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA30", Offset = "0x8FDC30", VA = "0x1808FEA30", Slot = "14")]
		private void CBEAJCAFBPD(ComponentType EPFBGGDPMCN, in EAFFJHCGNCC NFBBIHCIPFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x8FF280", Offset = "0x8FE480", VA = "0x1808FF280", Slot = "15")]
		private bool MPLECOCDAHJ(FNCBEEHJHBJ FKFNLDMHBOL, out Entity DBHBBNPKELE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x8FF4F0", Offset = "0x8FE6F0", VA = "0x1808FF4F0", Slot = "17")]
		private bool PACOGEKFILF(out NativeArray<int> OJCMOMOFBEO, Allocator MKFODJKMOCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x8FE730", Offset = "0x8FD930", VA = "0x1808FE730", Slot = "18")]
		private bool AOBNHHMACCN(ComponentType EPFBGGDPMCN, out EAFFJHCGNCC DEEGNKLILCC, out LMIIOOGLAFJ JMCKGOOADHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x8FE620", Offset = "0x8FD820", VA = "0x1808FE620", Slot = "19")]
		private bool AOBNHHMACCN(ComponentType EPFBGGDPMCN, out EAFFJHCGNCC DEEGNKLILCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FF110", Offset = "0x8FE310", VA = "0x1808FF110", Slot = "20")]
		private EAFFJHCGNCC LIJMBHADEGK(ComponentType EPFBGGDPMCN)
		{
			return default(EAFFJHCGNCC);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x8FEF80", Offset = "0x8FE180", VA = "0x1808FEF80", Slot = "21")]
		private JBAMKLOILAA KKHHELNBDEP()
		{
			return default(JBAMKLOILAA);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x8FF240", Offset = "0x8FE440", VA = "0x1808FF240", Slot = "22")]
		private void LPAGOBKJMCA(JobHandle NOHHECKHGJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x8FED90", Offset = "0x8FDF90", VA = "0x1808FED90", Slot = "4")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x8FE890", Offset = "0x8FDA90", VA = "0x1808FE890", Slot = "5")]
		public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB00", Offset = "0x8FDD00", VA = "0x1808FEB00", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2C0", Offset = "0x8FE4C0", VA = "0x1808FF2C0")]
		private void NLALCDJNEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x8FEBD0", Offset = "0x8FDDD0", VA = "0x1808FEBD0")]
		private bool EKBEPBOCLBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x8FEFC0", Offset = "0x8FE1C0", VA = "0x1808FEFC0")]
		private int KKJNLMDAIEK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5D0", Offset = "0x8FE7D0", VA = "0x1808FF5D0")]
		public PropertyDiffStateService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal struct JBAMKLOILAA
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public struct NGFPCFEPOJF : IEnumerator<AHCJFBNOGLE>, IEnumerator, IDisposable, IEnumerable<AHCJFBNOGLE>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly NativeMultiHashMap<Entity, AHCJFBNOGLE> FIKJOBHDMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly Entity BBPBBOAPCHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private NativeMultiHashMapIterator<Entity> GOJCGILMJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private AHCJFBNOGLE DCBHGCPJBOG;

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public AHCJFBNOGLE EGCCHNLJPLC
		{
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x884080", Offset = "0x883280", VA = "0x180884080", Slot = "4")]
			get
			{
				return default(AHCJFBNOGLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x884000", Offset = "0x883200", VA = "0x180884000", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x884050", Offset = "0x883250", VA = "0x180884050")]
		internal NGFPCFEPOJF(NativeMultiHashMap<Entity, AHCJFBNOGLE> FIKJOBHDMCM, Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x883DE0", Offset = "0x882FE0", VA = "0x180883DE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x883DB0", Offset = "0x882FB0", VA = "0x180883DB0")]
		public NGFPCFEPOJF ENNIMPBLHKI()
		{
			return default(NGFPCFEPOJF);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x883EA0", Offset = "0x8830A0", VA = "0x180883EA0", Slot = "9")]
		private IEnumerator<AHCJFBNOGLE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x883F50", Offset = "0x883150", VA = "0x180883F50", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private readonly JADIANBGGHP IBBEGDPIJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private readonly JobHandle KAHLNGOHHHO;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public int JNKCDFIJNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x8774C0", Offset = "0x8766C0", VA = "0x1808774C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool GPCFLNCLBKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8775B0", Offset = "0x8767B0", VA = "0x1808775B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x877920", Offset = "0x876B20", VA = "0x180877920")]
	public JBAMKLOILAA(JADIANBGGHP IBBEGDPIJBO, JobHandle KAHLNGOHHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x8777E0", Offset = "0x8769E0", VA = "0x1808777E0")]
	public bool NGGAOKAMLIH(Allocator MKFODJKMOCC, out NativeKeyValueArrays<Entity, AHCJFBNOGLE> LHPJBAGJLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x877690", Offset = "0x876890", VA = "0x180877690")]
	public bool KBANJOCIHJC(Allocator MKFODJKMOCC, out (NativeArray<Entity> entities, int uniqueCount) LHPJBAGJLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x8773B0", Offset = "0x8765B0", VA = "0x1808773B0")]
	public NGFPCFEPOJF HBIAAHGHNAG(Entity BBPBBOAPCHN)
	{
		return default(NGFPCFEPOJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[DefaultMember("Item")]
internal class BDDIFFHCCJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly List<LMIIOOGLAFJ> MDBHJOENILE;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public LMIIOOGLAFJ LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xA47440", Offset = "0xA46640", VA = "0x180A47440")]
		get
		{
			return default(LMIIOOGLAFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA46F00", Offset = "0xA46100", VA = "0x180A46F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0xA474D0", Offset = "0xA466D0", VA = "0x180A474D0")]
	public BDDIFFHCCJM(KJJMLOAIOPA EAHECGKJECG, EGHMCKEACDK PELFBHDCPAJ, MKIMOBFPILG GPGEBBCKNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0xA470C0", Offset = "0xA462C0", VA = "0x180A470C0")]
	public List<LMIIOOGLAFJ>.Enumerator ENNIMPBLHKI()
	{
		return default(List<LMIIOOGLAFJ>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0xA46F40", Offset = "0xA46140", VA = "0x180A46F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0xA47140", Offset = "0xA46340", VA = "0x180A47140")]
	private void NNGAGHKIILL(KJJMLOAIOPA EAHECGKJECG, EntityManager KHDMOGKDGKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal class HEMCNGFDFBO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private readonly ObjectPrefabCreationService ACNDAIINMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private readonly global::EGFHNBCKEKK<JJHBGAMPJOH> GJBGGLAHMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private readonly World JLFIKLKKIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private readonly EntityManager KHDMOGKDGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private NativeHashMap<int, Entity> CBFKHLINGLH;

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x8725C0", Offset = "0x8717C0", VA = "0x1808725C0")]
	public HEMCNGFDFBO(ObjectPrefabCreationService ACNDAIINMFB, EGHMCKEACDK PELFBHDCPAJ, MKIMOBFPILG GPGEBBCKNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x871490", Offset = "0x870690", VA = "0x180871490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x8715C0", Offset = "0x8707C0", VA = "0x1808715C0")]
	public bool FCAJPPFOLOC(FNCBEEHJHBJ FKFNLDMHBOL, out Entity DBHBBNPKELE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x871AE0", Offset = "0x870CE0", VA = "0x180871AE0")]
	private void NFHHHEEEAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x8720C0", Offset = "0x8712C0", VA = "0x1808720C0")]
	private EntityArchetype OGHOFBBJKBB(EntityArchetype DIEELGAOCHH)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x8710F0", Offset = "0x8702F0", VA = "0x1808710F0")]
	public static void CNNAMEDENEA(EntityManager DEFCDNIJJDA, EntityManager IFOLEAAACCA, NativeArray<Entity> AMACFGMBPMI, NativeArray<EntityArchetype> CFPGKHANJGF, [Optional] NativeArray<Entity> LCGOCBJDGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x870F90", Offset = "0x870190", VA = "0x180870F90")]
	[Conditional("DEBUG_BUILD")]
	private static void CHFJFFKMMHC(NativeArray<EntityArchetype> CNKCIANFCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x871900", Offset = "0x870B00", VA = "0x180871900")]
	private static string MHAPOADFLDE(EntityArchetype ENFKEBIFHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x871620", Offset = "0x870820", VA = "0x180871620")]
	[CompilerGenerated]
	internal static void HIFAENLBKLB(ref Span<ComponentType> KHOGNNHICPB, ComponentType ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x871760", Offset = "0x870960", VA = "0x180871760")]
	[CompilerGenerated]
	internal static void JBFBLHPKHAO(Span<ComponentType> NAJOFPKLJJG, ref Span<ComponentType> KHOGNNHICPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x8714F0", Offset = "0x8706F0", VA = "0x1808714F0")]
	[CompilerGenerated]
	internal static void FAGCJBECMIC(Span<ComponentType> NAJOFPKLJJG, ref Span<ComponentType> KHOGNNHICPB, ComponentType HGLJNPBFLII)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[EJLOOKEAJML(HNJEFABFMIP.PropertyChanges)]
	public abstract class ApplyPropertyDifferences : MGFJEDJDOGN, GOKNGONBKFG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private struct KKKGHLGPNKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public EAHDJPAHIAA dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
			public KKKGHLGPNKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct KIDHFKGJJOD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			[ReadOnly]
			public NativeArray<byte> DCBHGCPJBOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			[ReadOnly]
			public NativeList<int> OHIFGOLKNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			[ReadOnly]
			public NativeArray<Entity> NDDOCFCANCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public int GMKBGDDNBLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public EAHDJPAHIAA HHKJNMELMAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public ComponentType EPFBGGDPMCN;

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0xBE04F0", Offset = "0xBDF6F0", VA = "0x180BE04F0")]
			internal void NFKNCPPNADH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF890", VA = "0x180BE0690", Slot = "5")]
			public void ReadFromDisplayClass(ref KKKGHLGPNKH CHELDAKFMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0xBE04C0", Offset = "0xBDF6C0", VA = "0x180BE04C0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0xBE04D0", Offset = "0xBDF6D0", VA = "0x180BE04D0")]
			public void MABHDODJKAO(ApplyPropertyDifferences HJICJBAHBAD, ref KKKGHLGPNKH CHELDAKFMJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private KFJGJDHPGIJ IBBEGDPIJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private JobHandle EELJBFGKMGB;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xBD5F80", Offset = "0xBD5180", VA = "0x180BD5F80")]
		public void EBIMOMABEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xBD5F90", Offset = "0xBD5190", VA = "0x180BD5F90", Slot = "14")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xBD6310", Offset = "0xBD5510", VA = "0x180BD6310", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xBD5FF0", Offset = "0xBD51F0", VA = "0x180BD5FF0")]
		private bool LNBEBNCIKBO(JobHandle AIOLNMINMPO, int NIDJEPOLHMB, out JobHandle NPFCJLGHIEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		protected ApplyPropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[EJLOOKEAJML(HNJEFABFMIP.PropertyChanges)]
	public abstract class ComputePropertyDifferences : MGFJEDJDOGN, GOKNGONBKFG, AIOPJLICFNI
	{
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[BurstCompile]
		internal struct ACFMELDJMNA : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			[ReadOnly]
			public NativeArray<byte> GKGEEJICFGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeArray<byte> BLOJNGCEDIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public NativeArray<FEDEGNHCJHF> APBOEKKLEGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			[WriteOnly]
			public NativeList<OFKILMKJFHG>.ParallelWriter OEHAPEJAJJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public int IDKABGLABOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public int KNBIAPDCFKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public ProfilerMarker LHAPEDFFMKI;

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0xBD5130", Offset = "0xBD4330", VA = "0x180BD5130", Slot = "4")]
			public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0xBD50A0", Offset = "0xBD42A0", VA = "0x180BD50A0")]
			private unsafe int DGBCCDDHIGO(byte* LNLNCJCKPAF, byte* OFADDADJKKI)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[BurstCompile]
		internal struct NDONNFNONNF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			[WriteOnly]
			public NativeList<int> OHIFGOLKNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			[WriteOnly]
			public NativeList<int> HGNEPPLFAFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			[ReadOnly]
			public NativeList<OFKILMKJFHG> KAFOJDJODFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public ProfilerMarker LHAPEDFFMKI;

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0xBE0800", Offset = "0xBDFA00", VA = "0x180BE0800", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[BurstCompile]
		internal struct FHMIMOKCJHL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			[WriteOnly]
			public NativeArray<byte> FHNNAOJGKBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			[ReadOnly]
			public NativeArray<Entity> JEFMGPHNDGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			[ReadOnly]
			public EAHDJPAHIAA CFCINBCFKBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public int GMKBGDDNBLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public ProfilerMarker LHAPEDFFMKI;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0xBDF260", Offset = "0xBDE460", VA = "0x180BDF260", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[BurstCompile]
		internal struct BMOIOEKHPBG : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, AHCJFBNOGLE> INLHLCMNFIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public NativeArray<byte> IPBPGGBABHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public NativeArray<byte> DCBHGCPJBOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			[ReadOnly]
			public NativeArray<Entity> JEFMGPHNDGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeArray<FEDEGNHCJHF> JIKJCGDEKDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public NativeList<int> BLODFAPHALD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			[ReadOnly]
			public NativeList<int> OHIFGOLKNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public int HMNBCPGBGEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public int BCNNHGENEDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public ProfilerMarker LHAPEDFFMKI;

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0xBD69D0", Offset = "0xBD5BD0", VA = "0x180BD69D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private static readonly ProfilerMarker BOADCKFCKLO;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private static readonly ProfilerMarker PGFCEIOJNCP;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly ProfilerMarker DFEOEOEPOCJ;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static readonly ProfilerMarker KKLMOBOPAOF;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private static readonly ProfilerMarker MCFBLNGAIBO;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private static readonly ProfilerMarker GNHBPLACIFC;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly ProfilerMarker EMBABAPPOEI;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private static readonly ProfilerMarker FOAILPAHHDN;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static readonly ProfilerMarker GGIFLMOGLNP;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private static readonly ProfilerMarker ELPDGCGGFPA;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private static readonly ProfilerMarker MIHEJKBOABH;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private static readonly ProfilerMarker ADGHHMCIANP;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private static readonly ProfilerMarker ENDKFGLIAOC;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private static readonly ProfilerMarker BAMOKDMHOMN;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private static readonly ProfilerMarker FJGPMACENFN;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static readonly ProfilerMarker FLMEGHHBFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private JADIANBGGHP IBBEGDPIJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private ApplyPropertyDifferences KGEJDIGKBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private EntityQuery LPAGNPHIIDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private EntityQuery LGHLICIGINA;

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		protected abstract ApplyPropertyDifferences PDINOLMPJNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		internal World DCHGJMDAJEA
		{
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0xBD7680", Offset = "0xBD6880", VA = "0x180BD7680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xBD89B0", Offset = "0xBD7BB0", VA = "0x180BD89B0")]
		internal LMIIOOGLAFJ HOBKNLMBDJH(ComponentType EPFBGGDPMCN)
		{
			return default(LMIIOOGLAFJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xBD7DC0", Offset = "0xBD6FC0", VA = "0x180BD7DC0", Slot = "14")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "15")]
		public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xBD9930", Offset = "0xBD8B30", VA = "0x180BD9930", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xBD9A80", Offset = "0xBD8C80", VA = "0x180BD9A80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xBD9A30", Offset = "0xBD8C30", VA = "0x180BD9A30", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xBD8A50", Offset = "0xBD7C50", VA = "0x180BD8A50")]
		private void JADOCAPECDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xBD76D0", Offset = "0xBD68D0", VA = "0x180BD76D0")]
		private void DHNLLMKECCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xBD70A0", Offset = "0xBD62A0", VA = "0x180BD70A0")]
		internal void CLCKELONLIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xBD8110", Offset = "0xBD7310", VA = "0x180BD8110")]
		private void GJKJBMCGHAM(NativeArray<Entity> AMACFGMBPMI, NativeArray<RRObjectPrefabData> EEGLEMDKBJO, ref NativeArray<Entity> NEOCLBOJJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xBD7910", Offset = "0xBD6B10", VA = "0x180BD7910")]
		internal void EGLIGNKHBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xBD8320", Offset = "0xBD7520", VA = "0x180BD8320")]
		internal void HJDCIKMOKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xBD7E20", Offset = "0xBD7020", VA = "0x180BD7E20")]
		private void FPMBODELLFP(LMIIOOGLAFJ JMCKGOOADHK, bool JOIKENDOINM, ref JobHandle IDEBLPJAPDL, ref JobHandle ECFAGPPJOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xBD8F10", Offset = "0xBD8110", VA = "0x180BD8F10")]
		internal bool NAMMHGPOOGN(in LMIIOOGLAFJ OFADDADJKKI, out JobHandle BEDKMKLJIGF, out EAFFJHCGNCC HHMKJJBKKAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xBD8F40", Offset = "0xBD8140", VA = "0x180BD8F40")]
		private bool NAMMHGPOOGN(in LMIIOOGLAFJ OFADDADJKKI, bool JOIKENDOINM, out JobHandle BEDKMKLJIGF, out EAFFJHCGNCC HHMKJJBKKAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xBD9790", Offset = "0xBD8990", VA = "0x180BD9790")]
		internal (NativeList<int>, NativeList<int>) OGAFPECEKFH(NativeList<OFKILMKJFHG> KAFOJDJODFA, int GOCCOAPEHDE, JobHandle AIOLNMINMPO, out JobHandle NOHHECKHGJG, Allocator MKFODJKMOCC = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xBD6ED0", Offset = "0xBD60D0", VA = "0x180BD6ED0")]
		internal static NativeArray<Entity> AIIDFIHMKDJ(EntityQuery IMOAAHEOFBK, out JobHandle CKOJBDGMIPO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xBD8E90", Offset = "0xBD8090", VA = "0x180BD8E90")]
		internal static NativeArray<byte> KLLDIFCKLCJ(int FAOJAOEJLMO, out JobHandle AHJDOPJANDH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xBD77C0", Offset = "0xBD69C0", VA = "0x180BD77C0")]
		internal static NativeArray<byte> EDEDOMHMFCM(EntityQuery IMOAAHEOFBK, int NIDJEPOLHMB, out JobHandle AHJDOPJANDH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xBD6F70", Offset = "0xBD6170", VA = "0x180BD6F70")]
		internal static NativeArray<Entity> CCBJJOFDBLM(EntityQuery IMOAAHEOFBK, out JobHandle POPGJEMANEN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xBD7BD0", Offset = "0xBD6DD0", VA = "0x180BD7BD0")]
		internal NativeArray<byte> EMGHBJOPBFI(NativeArray<Entity> JEFMGPHNDGN, LMIIOOGLAFJ JMCKGOOADHK, JobHandle AIOLNMINMPO, out JobHandle NOHHECKHGJG, Allocator MKFODJKMOCC = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xBD8D00", Offset = "0xBD7F00", VA = "0x180BD8D00")]
		internal JobHandle KHLMJBJLFAD(in EAFFJHCGNCC ADIGGFBANFM, in LMIIOOGLAFJ JMCKGOOADHK, NativeMultiHashMap<Entity, AHCJFBNOGLE> INLHLCMNFIL, JobHandle AIOLNMINMPO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x8DB280", Offset = "0x8DA480", VA = "0x1808DB280")]
		private JobHandle LCKFEIJFKPL(JobHandle PJIKMDNJHHB, JobHandle KAHEJPMFEFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x8DB280", Offset = "0x8DA480", VA = "0x1808DB280")]
		private JobHandle LCKFEIJFKPL(JobHandle PJIKMDNJHHB, JobHandle KAHEJPMFEFP, JobHandle EIJNOFKMCGB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		protected ComputePropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal abstract class CHFNAENAIMN : PropagateTagsBase<global::DHGFJPDPKNN, global::GHGEGPACMKB, CHFNAENAIMN.KMAHLJGLOOC>
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public struct KMAHLJGLOOC : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xA49000", Offset = "0xA48200", VA = "0x180A49000")]
	protected CHFNAENAIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0xA48FC0", Offset = "0xA481C0", VA = "0x180A48FC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal abstract class NAOGOACMBKN : PropagateTagsBase<ENDDHKGOAFI, global::BCHOLIPDPEI, NAOGOACMBKN.CBNKNOBOLOL>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public struct CBNKNOBOLOL : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x882C80", Offset = "0x881E80", VA = "0x180882C80")]
	protected NAOGOACMBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x882C40", Offset = "0x881E40", VA = "0x180882C40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class HCALCOGALML : EPCNJOMJEHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct LCIMMABOKAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public NativeArray<int> array;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		public LCIMMABOKAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
		internal void <OnUpdate>b__0(ref AuthoredLocalPoseData localPose)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct MCFCMMIFCIL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct EMEPHDKDGNN
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct BAOPGHCKLMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400034E")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData>.Runtime KEBMHFJDFHD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData> EJJFIKACEKE;

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x86FCE0", Offset = "0x86EEE0", VA = "0x18086FCE0")]
			public void MABHDODJKAO(HCALCOGALML HJICJBAHBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x86FC90", Offset = "0x86EE90", VA = "0x18086FC90")]
			public BAOPGHCKLMB GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
			{
				return default(BAOPGHCKLMB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public NativeArray<int> NAJOFPKLJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private EMEPHDKDGNN ANIEMPIBNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe EMEPHDKDGNN.BAOPGHCKLMB* AHPNEFKAFJO;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LCJAIGMFHHE;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IIPKEBFDNMD;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x880B70", Offset = "0x87FD70", VA = "0x180880B70")]
		internal void NFKNCPPNADH(ref AuthoredLocalPoseData OIEPCMEJKFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87EBA0", VA = "0x18087F9A0", Slot = "5")]
		public void ReadFromDisplayClass(ref LCIMMABOKAF CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x87F9B0", Offset = "0x87EBB0", VA = "0x18087F9B0", Slot = "6")]
		public void WriteToDisplayClass(ref LCIMMABOKAF CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x8809E0", Offset = "0x87FBE0", VA = "0x1808809E0", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x880A60", Offset = "0x87FC60", VA = "0x180880A60")]
		public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, [NoAlias] ref EMEPHDKDGNN.BAOPGHCKLMB LIDOEFEMELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x880AF0", Offset = "0x87FCF0", VA = "0x180880AF0")]
		public void MABHDODJKAO(HCALCOGALML HJICJBAHBAD, ref LCIMMABOKAF CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x880C70", Offset = "0x87FE70", VA = "0x180880C70")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void NHFOKKFCGIG(ArchetypeChunkIterator* DMENKPONMKK, void* DPAIKCDDPBE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private EntityQuery MNDBCPEAIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private ProfilerMarker OIHJOJGNCNC;

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x8706A0", Offset = "0x86F8A0", VA = "0x1808706A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public HCALCOGALML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x8704C0", Offset = "0x86F6C0", VA = "0x1808704C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x870390", Offset = "0x86F590", VA = "0x180870390")]
	public static EntityQuery KHPNGIHGPOD(ComponentSystemBase HJICJBAHBAD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public class HJBHPGDJJJJ : EPCNJOMJEHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct GDJPKMOCFFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		public GDJPKMOCFFK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct PDHCEGPHAIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public EntityManager entityManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public GDJPKMOCFFK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		public PDHCEGPHAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct KAEBMEADNPP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct BKOKEMMCGNG
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct CIBIGHCDALK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400035C")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ABCLJOKOGIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400035D")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointData>.Runtime JBFBCMACCFL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity PJOHKJKECDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplinePointData> AOFHFNPODMC;

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x86E500", Offset = "0x86D700", VA = "0x18086E500")]
			public void MABHDODJKAO(HJBHPGDJJJJ HJICJBAHBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x86E480", Offset = "0x86D680", VA = "0x18086E480")]
			public CIBIGHCDALK GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
			{
				return default(CIBIGHCDALK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public EntityManager KHDMOGKDGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public NativeList<Entity> MPLKHEJDPPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private BKOKEMMCGNG ANIEMPIBNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BKOKEMMCGNG.CIBIGHCDALK* AHPNEFKAFJO;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LCJAIGMFHHE;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IIPKEBFDNMD;

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x87AE50", Offset = "0x87A050", VA = "0x18087AE50")]
		internal void NFKNCPPNADH(Entity BBPBBOAPCHN, SplinePointData FPDOMCKPEJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x87AF30", Offset = "0x87A130", VA = "0x18087AF30", Slot = "5")]
		public void ReadFromDisplayClass(ref PDHCEGPHAIC CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x87AF40", Offset = "0x87A140", VA = "0x18087AF40", Slot = "6")]
		public void WriteToDisplayClass(ref PDHCEGPHAIC CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x87AC50", Offset = "0x879E50", VA = "0x18087AC50", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x87ACF0", Offset = "0x879EF0", VA = "0x18087ACF0")]
		public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, [NoAlias] ref BKOKEMMCGNG.CIBIGHCDALK LIDOEFEMELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x87ADC0", Offset = "0x879FC0", VA = "0x18087ADC0")]
		public void MABHDODJKAO(HJBHPGDJJJJ HJICJBAHBAD, ref PDHCEGPHAIC CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x87AED0", Offset = "0x87A0D0", VA = "0x18087AED0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void NHFOKKFCGIG(ArchetypeChunkIterator* DMENKPONMKK, void* DPAIKCDDPBE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private EntityQuery MNDBCPEAIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private ProfilerMarker OIHJOJGNCNC;

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x8743A0", Offset = "0x8735A0", VA = "0x1808743A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public HJBHPGDJJJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x8741C0", Offset = "0x8733C0", VA = "0x1808741C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x874090", Offset = "0x873290", VA = "0x180874090")]
	public static EntityQuery KHPNGIHGPOD(ComponentSystemBase HJICJBAHBAD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public class KABBJIECBFB : EPCNJOMJEHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private EntityQuery IIJBJNCOBOM;

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x878F40", Offset = "0x878140", VA = "0x180878F40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x878FC0", Offset = "0x8781C0", VA = "0x180878FC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public KABBJIECBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class LJEKEAGCOBL : EPCNJOMJEHP, GOKNGONBKFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct KGJNKHFJLFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public NativeHashMap<NJKBLCBBANC, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		public KGJNKHFJLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct KPNOPNIBNNF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		private struct DKNDLIJJAKH
		{
			[Cpp2IlInjected.Token(Token = "0x200010A")]
			public struct LGAJNNOCAKJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000369")]
				public LambdaParameterValueProvider_Entity.Runtime ABCLJOKOGIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime MOOLPOMGCHO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity PJOHKJKECDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> IHPBFJOCAGD;

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x86E770", Offset = "0x86D970", VA = "0x18086E770")]
			public void MABHDODJKAO(LJEKEAGCOBL HJICJBAHBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x86E6F0", Offset = "0x86D8F0", VA = "0x18086E6F0")]
			public LGAJNNOCAKJ GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
			{
				return default(LGAJNNOCAKJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public NativeHashMap<NJKBLCBBANC, Entity> FIKJOBHDMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private DKNDLIJJAKH ANIEMPIBNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe DKNDLIJJAKH.LGAJNNOCAKJ* AHPNEFKAFJO;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LCJAIGMFHHE;

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x87F8C0", Offset = "0x87EAC0", VA = "0x18087F8C0")]
		internal void NFKNCPPNADH(Entity BBPBBOAPCHN, ObjectNetworkIdComponentData OHHACENKJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87EBA0", VA = "0x18087F9A0", Slot = "5")]
		public void ReadFromDisplayClass(ref KGJNKHFJLFB CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x87F9B0", Offset = "0x87EBB0", VA = "0x18087F9B0", Slot = "6")]
		public void WriteToDisplayClass(ref KGJNKHFJLFB CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x87F6E0", Offset = "0x87E8E0", VA = "0x18087F6E0", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x87F780", Offset = "0x87E980", VA = "0x18087F780")]
		public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, ref DKNDLIJJAKH.LGAJNNOCAKJ LIDOEFEMELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x87F830", Offset = "0x87EA30", VA = "0x18087F830")]
		public void MABHDODJKAO(LJEKEAGCOBL HJICJBAHBAD, ref KGJNKHFJLFB CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x87F940", Offset = "0x87EB40", VA = "0x18087F940")]
		public unsafe static void NHFOKKFCGIG(ArchetypeChunkIterator* DMENKPONMKK, void* DPAIKCDDPBE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private ObjectNetworkToLocalMapService NKFKKMPLGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EntityQuery MNDBCPEAIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private ProfilerMarker OIHJOJGNCNC;

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x8801F0", Offset = "0x87F3F0", VA = "0x1808801F0", Slot = "14")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F730", VA = "0x180880530", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public LJEKEAGCOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x880380", Offset = "0x87F580", VA = "0x180880380", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x880250", Offset = "0x87F450", VA = "0x180880250")]
	public static EntityQuery KHPNGIHGPOD(ComponentSystemBase HJICJBAHBAD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[EJLOOKEAJML(HNJEFABFMIP.Embodiment)]
	public class PostLoadInitializeEmbodiment : MGFJEDJDOGN, GOKNGONBKFG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[CompilerGenerated]
		private struct INLIBOLJMIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public NativeList<NJKBLCBBANC> networkIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public BufferFromEntity<ChildrenData> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public ComponentDataFromEntity<SerializedEmbodiedData> embodiedFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> networkIdFromEntity;

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
			public INLIBOLJMIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
			internal void <AddEmbodiedTopologically>b__0(Entity entity, ObjectNetworkIdComponentData component)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct PPNNHNMGJHJ : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200010E")]
			private struct CLJPMCIPDIA
			{
				[Cpp2IlInjected.Token(Token = "0x200010F")]
				[NoAlias]
				public struct IEFMOMHONLF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000382")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ABCLJOKOGIH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000383")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime JOCPINFGNFN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000380")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity PJOHKJKECDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000381")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> MIDGHMMNEEG;

				[Cpp2IlInjected.Token(Token = "0x600077B")]
				[Cpp2IlInjected.Address(RVA = "0x8F1F00", Offset = "0x8F1100", VA = "0x1808F1F00")]
				public void MABHDODJKAO(PostLoadInitializeEmbodiment HJICJBAHBAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077C")]
				[Cpp2IlInjected.Address(RVA = "0x8F1E80", Offset = "0x8F1080", VA = "0x1808F1E80")]
				public IEFMOMHONLF GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
				{
					return default(IEFMOMHONLF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeList<Entity> JEFMGPHNDGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public NativeList<NJKBLCBBANC> AHDNMMAIPPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public BufferFromEntity<ChildrenData> DLEKIFEMLAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public ComponentDataFromEntity<SerializedEmbodiedData> OCNMEKGEJCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> MHAIMMALNKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			private CLJPMCIPDIA ANIEMPIBNCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe CLJPMCIPDIA.IEFMOMHONLF* AHPNEFKAFJO;

			[Cpp2IlInjected.Token(Token = "0x400037E")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LCJAIGMFHHE;

			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IIPKEBFDNMD;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x8FBD80", Offset = "0x8FAF80", VA = "0x1808FBD80")]
			internal void NFKNCPPNADH(Entity BBPBBOAPCHN, ObjectNetworkIdComponentData OFADDADJKKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x8FBB10", Offset = "0x8FAD10", VA = "0x1808FBB10")]
			internal void EOPJJIOLEKC(Entity BBPBBOAPCHN, ObjectNetworkIdComponentData OFADDADJKKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9E0", Offset = "0x8FABE0", VA = "0x1808FB9E0")]
			internal void BPIENCBCDFB(Entity BBPBBOAPCHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x8FBE10", Offset = "0x8FB010", VA = "0x1808FBE10", Slot = "5")]
			public void ReadFromDisplayClass(ref INLIBOLJMIA CHELDAKFMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x8FBE60", Offset = "0x8FB060", VA = "0x1808FBE60", Slot = "6")]
			public void WriteToDisplayClass(ref INLIBOLJMIA CHELDAKFMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x8FBB90", Offset = "0x8FAD90", VA = "0x1808FBB90", Slot = "4")]
			public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x8FBC40", Offset = "0x8FAE40", VA = "0x1808FBC40")]
			public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, [NoAlias] ref CLJPMCIPDIA.IEFMOMHONLF LIDOEFEMELO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x8FBCF0", Offset = "0x8FAEF0", VA = "0x1808FBCF0")]
			public void MABHDODJKAO(PostLoadInitializeEmbodiment HJICJBAHBAD, ref INLIBOLJMIA CHELDAKFMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x8FBDB0", Offset = "0x8FAFB0", VA = "0x1808FBDB0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void NHFOKKFCGIG(ArchetypeChunkIterator* DMENKPONMKK, void* DPAIKCDDPBE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private EntityQuery PDIOLCHHKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private FCFLIDMJBKH FEPEKJBDLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private AEKECOGJAHN JGHMLHPFFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private BCEBIIAIFJH AMIFBGIBKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EntityQuery ICHMNLCCHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private ProfilerMarker DLAAAPCCDKH;

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6E0", Offset = "0x8FC8E0", VA = "0x1808FD6E0", Slot = "14")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x8FDF30", Offset = "0x8FD130", VA = "0x1808FDF30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x8FDFB0", Offset = "0x8FD1B0", VA = "0x1808FDFB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x8FE040", Offset = "0x8FD240", VA = "0x1808FE040")]
		private void PHNKCBKEAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0")]
		private NativeArray<NAEJIFEJHCI> LAMDIFLHDBN(NativeArray<NJKBLCBBANC> AHDNMMAIPPF)
		{
			return default(NativeArray<NAEJIFEJHCI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x8FD500", Offset = "0x8FC700", VA = "0x1808FD500")]
		private void EKEMGBLONLE(NativeList<Entity> JEFMGPHNDGN, NativeList<NJKBLCBBANC> AHDNMMAIPPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x8FD770", Offset = "0x8FC970", VA = "0x1808FD770")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void GHAKEBCMEEO(NativeList<NJKBLCBBANC> AHDNMMAIPPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		private static void ICALBHAJBML(NativeList<NJKBLCBBANC> AHDNMMAIPPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		public PostLoadInitializeEmbodiment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x8FDE30", Offset = "0x8FD030", VA = "0x1808FDE30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x8FDC70", Offset = "0x8FCE70", VA = "0x1808FDC70")]
		public static EntityQuery LFAMINOJKLC(ComponentSystemBase HJICJBAHBAD)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public class PNCJMMDJGLI : MGFJEDJDOGN, GOKNGONBKFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct BMIEBGDKGPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public NativeHashMap<NJKBLCBBANC, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		public BMIEBGDKGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D0", Offset = "0x87B4D0", VA = "0x18087C2D0")]
		internal void <OnUpdate>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct DBCEMFBBKBF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct MKDMPHGHICJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000114")]
			[NoAlias]
			public struct ADEFNDEPLCK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000390")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ABCLJOKOGIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000391")]
				[NoAlias]
				public LambdaParameterValueProvider_EntityInQueryIndex.Runtime NOOEINJBING;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000392")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime MOOLPOMGCHO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity PJOHKJKECDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_EntityInQueryIndex PEMFOGIMCIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> IHPBFJOCAGD;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xBE0790", Offset = "0xBDF990", VA = "0x180BE0790")]
			public void MABHDODJKAO(PNCJMMDJGLI HJICJBAHBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xBE06D0", Offset = "0xBDF8D0", VA = "0x180BE06D0")]
			public ADEFNDEPLCK GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
			{
				return default(ADEFNDEPLCK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public NativeHashMap<NJKBLCBBANC, Entity> FIKJOBHDMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private MKDMPHGHICJ ANIEMPIBNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MKDMPHGHICJ.ADEFNDEPLCK* AHPNEFKAFJO;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LCJAIGMFHHE;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IIPKEBFDNMD;

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xBDCFB0", Offset = "0xBDC1B0", VA = "0x180BDCFB0")]
		internal void NFKNCPPNADH(Entity BBPBBOAPCHN, int DADPDDCCBKC, ref ObjectNetworkIdComponentData OHHACENKJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87EBA0", VA = "0x18087F9A0", Slot = "5")]
		public void ReadFromDisplayClass(ref BMIEBGDKGPK CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x87F9B0", Offset = "0x87EBB0", VA = "0x18087F9B0", Slot = "6")]
		public void WriteToDisplayClass(ref BMIEBGDKGPK CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xBDCD60", Offset = "0xBDBF60", VA = "0x180BDCD60", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xBDCE50", Offset = "0xBDC050", VA = "0x180BDCE50")]
		public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, [NoAlias] ref MKDMPHGHICJ.ADEFNDEPLCK LIDOEFEMELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xBDCF10", Offset = "0xBDC110", VA = "0x180BDCF10")]
		public void MABHDODJKAO(PNCJMMDJGLI HJICJBAHBAD, ref BMIEBGDKGPK CHELDAKFMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xBDD040", Offset = "0xBDC240", VA = "0x180BDD040")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void NHFOKKFCGIG(ArchetypeChunkIterator* DMENKPONMKK, void* DPAIKCDDPBE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private ObjectNetworkToLocalMapService NKFKKMPLGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private EntityQuery MNDBCPEAIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private ProfilerMarker OIHJOJGNCNC;

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0xBE65A0", Offset = "0xBE57A0", VA = "0x180BE65A0", Slot = "14")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0xBE6910", Offset = "0xBE5B10", VA = "0x180BE6910", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public PNCJMMDJGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0xBE6730", Offset = "0xBE5930", VA = "0x180BE6730", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0xBE6600", Offset = "0xBE5800", VA = "0x180BE6600")]
	public static EntityQuery KHPNGIHGPOD(ComponentSystemBase HJICJBAHBAD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public class DFBCIIDMPCM : MGFJEDJDOGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private EntityQuery PDIOLCHHKED;

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0xA4BD30", Offset = "0xA4AF30", VA = "0x180A4BD30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0xA4BDB0", Offset = "0xA4AFB0", VA = "0x180A4BDB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public DFBCIIDMPCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public class NAFBPLLBCDJ : MGFJEDJDOGN, GOKNGONBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private EGHMCKEACDK DDCODOIGKNL;

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x8820D0", Offset = "0x8812D0", VA = "0x1808820D0", Slot = "14")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x882940", Offset = "0x881B40", VA = "0x180882940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x882130", Offset = "0x881330", VA = "0x180882130")]
	private void GMMCAHIDICO(NativeList<EntityArchetype> CNKCIANFCPI, NativeHashMap<int, JMNHLBPPELC> CGAKHEDLNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x882440", Offset = "0x881640", VA = "0x180882440")]
	private void KLCPIKJDIPM(NativeHashMap<int, JMNHLBPPELC> CGAKHEDLNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public NAFBPLLBCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x882300", Offset = "0x881500", VA = "0x180882300")]
	[CompilerGenerated]
	internal static Span<int> KHNPABGDDBM(EntityArchetype ENFKEBIFHOI)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[EJLOOKEAJML(HNJEFABFMIP.Serialization)]
	public class PreSerializeRemoveEntities : MGFJEDJDOGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private static MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery LGHLICIGINA;

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x8FE370", Offset = "0x8FD570", VA = "0x1808FE370", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x8FE590", Offset = "0x8FD790", VA = "0x1808FE590", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[CMNCMGDNKIL]
[ExecuteAlways]
[UpdateInGroup(typeof(KDIDCFHEIJF))]
internal sealed class AFMLHAHJCAM : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public AFMLHAHJCAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(KDIDCFHEIJF))]
[UpdateAfter(typeof(AFMLHAHJCAM))]
internal sealed class JCKDODADIKE : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public JCKDODADIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[ExecuteAlways]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(MBOBDBBFLJF))]
internal sealed class MHJDHAPNNLG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public MHJDHAPNNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[CMNCMGDNKIL]
[ExecuteAlways]
[UpdateInGroup(typeof(EKHHPOPCLJJ))]
internal sealed class HKDPOGBIPIK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public HKDPOGBIPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[ExecuteAlways]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(JMMMAGGBFMJ))]
internal sealed class HFNBGDKNIMD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public HFNBGDKNIMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
[ExecuteAlways]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(AKEMGFKGCKJ))]
internal sealed class KAJKNFNKNKM : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public KAJKNFNKNKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[ExecuteAlways]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(SimulationSystemGroup))]
internal sealed class CHGKHHCOBGI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public CHGKHHCOBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
[ExecuteAlways]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(FIPNLCKOIIN))]
internal sealed class CEFMPKHDPCN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public CEFMPKHDPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[ExecuteAlways]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(SimulationSystemGroup))]
internal sealed class ILDMMPBEAJK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public ILDMMPBEAJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[EJLOOKEAJML(HNJEFABFMIP.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataFromGameObjects : MGFJEDJDOGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct NPJAAGKNOOL : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private const float OGLJHCEEBNF = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public NativeArray<Entity> JEFMGPHNDGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> EENLKKKHHGE;

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0xBE0B80", Offset = "0xBDFD80", VA = "0x180BE0B80", Slot = "4")]
			public void Execute(int MJNAIOAAGCG, TransformAccess EJOKPJGAPEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0xBE0DC0", Offset = "0xBDFFC0", VA = "0x180BE0DC0")]
			private bool JLNPFJMGFEN(float3 FONEHOKCGLG, float3 DDKOGDKKCAE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xBE0E10", Offset = "0xBE0010", VA = "0x180BE0E10")]
			private bool MCMMMOMAGCM(quaternion FONEHOKCGLG, quaternion DDKOGDKKCAE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xBE0900", Offset = "0xBDFB00", VA = "0x180BE0900")]
			private static bool AIIAFPODDKJ(float3 PJIOBOBOEGF, float3 KLGGEDCBMPK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0xBE08C0", Offset = "0xBDFAC0", VA = "0x180BE08C0")]
			private static bool AIIAFPODDKJ(quaternion DHAMHGONHGF, quaternion ODBGDMOKIMO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0xBE0E40", Offset = "0xBE0040", VA = "0x180BE0E40")]
			private static bool NFHMAAMLAIB(float LELINLLFJDO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0xBE0D70", Offset = "0xBDFF70", VA = "0x180BE0D70")]
			private static float GNPLEGKLENN(quaternion IHJCIIICPLC, quaternion JMAKLIHGHMM)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct EJNOIMBPNAM : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			[ReadOnly]
			public NativeArray<Entity> JEFMGPHNDGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> KJDDMMGFONE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> IALJDBNNGNA;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0xBDD340", Offset = "0xBDC540", VA = "0x180BDD340", Slot = "4")]
			public void Execute(int MJNAIOAAGCG, TransformAccess EJOKPJGAPEO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private const string GMNMIGEAHKD = "Pose";

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private const string OOCAMJDLCJA = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private const string GEFBJJIIKII = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private static readonly ProfilerMarker NOBJEHOABIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private RegisterTransforms IAHIMJFEAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TransformAccessArray IPJHJKHACHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private EGHMCKEACDK PELFBHDCPAJ;

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0xBDBD40", Offset = "0xBDAF40", VA = "0x180BDBD40")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xBDBDA0", Offset = "0xBDAFA0", VA = "0x180BDBDA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0xBDBE10", Offset = "0xBDB010", VA = "0x180BDBE10", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0xBDBE80", Offset = "0xBDB080", VA = "0x180BDBE80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[EJLOOKEAJML(HNJEFABFMIP.TransformSyncing)]
	public class RegisterTransforms : MGFJEDJDOGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct JGJCEOBHLFA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000127")]
			private struct JKJJPILJNGB
			{
				[Cpp2IlInjected.Token(Token = "0x2000128")]
				public struct GHLKLMONPLO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003B7")]
					public LambdaParameterValueProvider_Entity.Runtime ABCLJOKOGIH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003B8")]
					public LambdaParameterValueProvider_IComponentData<LNMOMLMLAOK>.Runtime BCKPPJFOFGA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40003B9")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime MIEOHEEKOAA;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity PJOHKJKECDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<LNMOMLMLAOK> FMCCNGOHJJI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003B6")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> AEKEKMKFMOO;

				[Cpp2IlInjected.Token(Token = "0x60007D6")]
				[Cpp2IlInjected.Address(RVA = "0x8F4170", Offset = "0x8F3370", VA = "0x1808F4170")]
				public void MABHDODJKAO(RegisterTransforms HJICJBAHBAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007D7")]
				[Cpp2IlInjected.Address(RVA = "0x8F4080", Offset = "0x8F3280", VA = "0x1808F4080")]
				public GHLKLMONPLO GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
				{
					return default(GHLKLMONPLO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			private JKJJPILJNGB ANIEMPIBNCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JKJJPILJNGB.GHLKLMONPLO* AHPNEFKAFJO;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LCJAIGMFHHE;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x8F3F40", Offset = "0x8F3140", VA = "0x1808F3F40")]
			internal void NFKNCPPNADH(Entity BBPBBOAPCHN, LNMOMLMLAOK LEAMOGPCOIE, Transform EJOKPJGAPEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x8F3DD0", Offset = "0x8F2FD0", VA = "0x1808F3DD0", Slot = "4")]
			public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x8F3E60", Offset = "0x8F3060", VA = "0x1808F3E60")]
			public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, ref JKJJPILJNGB.GHLKLMONPLO LIDOEFEMELO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x8F3F30", Offset = "0x8F3130", VA = "0x1808F3F30")]
			public void MABHDODJKAO(RegisterTransforms HJICJBAHBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0x8F4020", Offset = "0x8F3220", VA = "0x1808F4020")]
			public unsafe static void NHFOKKFCGIG(ArchetypeChunkIterator* DMENKPONMKK, void* DPAIKCDDPBE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000129")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct FCPLLBNKJDO : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200012A")]
			private struct KONNCOAFGLI
			{
				[Cpp2IlInjected.Token(Token = "0x200012B")]
				[NoAlias]
				public struct JNNPNHKFCDP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003BE")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ABCLJOKOGIH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003BF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<LNMOMLMLAOK>.Runtime BCKPPJFOFGA;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003BC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity PJOHKJKECDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003BD")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<LNMOMLMLAOK> FMCCNGOHJJI;

				[Cpp2IlInjected.Token(Token = "0x60007DC")]
				[Cpp2IlInjected.Address(RVA = "0x8F3CB0", Offset = "0x8F2EB0", VA = "0x1808F3CB0")]
				public void MABHDODJKAO(RegisterTransforms HJICJBAHBAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007DD")]
				[Cpp2IlInjected.Address(RVA = "0x8F4230", Offset = "0x8F3430", VA = "0x1808F4230")]
				public JNNPNHKFCDP GCILDGOANMF(ref ArchetypeChunk KGOCBIFIMLG, int FEMKPOEDEMI, int KMMOLIICMAD)
				{
					return default(JNNPNHKFCDP);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			private KONNCOAFGLI ANIEMPIBNCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe KONNCOAFGLI.JNNPNHKFCDP* AHPNEFKAFJO;

			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D10", Offset = "0x8F2F10", VA = "0x1808F3D10")]
			internal void NFKNCPPNADH(Entity BBPBBOAPCHN, LNMOMLMLAOK LEAMOGPCOIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0x8F3B60", Offset = "0x8F2D60", VA = "0x1808F3B60", Slot = "4")]
			public void Execute(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0x8F3C00", Offset = "0x8F2E00", VA = "0x1808F3C00")]
			public void HHCABJLMHHP(ref ArchetypeChunk PDAFMJFPOLI, [NoAlias] ref KONNCOAFGLI.JNNPNHKFCDP LIDOEFEMELO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DB")]
			[Cpp2IlInjected.Address(RVA = "0x8F3CB0", Offset = "0x8F2EB0", VA = "0x1808F3CB0")]
			public void MABHDODJKAO(RegisterTransforms HJICJBAHBAD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private KGAHPKCMHDA DDLFHAHJIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private GFIODLFGCBC MPALCCDLCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private EntityQuery LEAMCHFJHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private EntityQuery OGFGCIBGJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private EntityQuery CMPJANMILNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private EntityQuery GIELPGDKCNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private ProfilerMarker NKMFFFCNCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private EntityQuery FKPMBNPCLBO;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public GFIODLFGCBC ODHDHIEIBCP
		{
			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x901B00", Offset = "0x900D00", VA = "0x180901B00")]
			get
			{
				return default(GFIODLFGCBC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x9014C0", Offset = "0x9006C0", VA = "0x1809014C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x901650", Offset = "0x900850", VA = "0x180901650", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x901660", Offset = "0x900860", VA = "0x180901660", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x900C30", Offset = "0x8FFE30", VA = "0x180900C30")]
		private void DIBDDMBFFDO(NativeArray<Entity> JEFMGPHNDGN, GFIODLFGCBC EOFCLDGJDIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x900D60", Offset = "0x8FFF60", VA = "0x180900D60")]
		[BurstCompile]
		internal static void MLKMJEOAMKE(NativeArray<LNMOMLMLAOK> PAEEAKHADOF, ComponentDataFromEntity<LNMOMLMLAOK> HBCGFFBGMDC, GFIODLFGCBC EOFCLDGJDIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		private static void EFJPHJAMFLN(Transform EJOKPJGAPEO, Entity BBPBBOAPCHN, int MJNAIOAAGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		private static void FALMIFAKGLO(Entity BBPBBOAPCHN, int MJNAIOAAGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		private static void BJONHACMNPB(int MJNAIOAAGCG, GFIODLFGCBC EOFCLDGJDIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x900A30", Offset = "0x8FFC30", VA = "0x180900A30")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DFPAIHOPFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x901180", Offset = "0x900380", VA = "0x180901180", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x901020", Offset = "0x900220", VA = "0x180901020")]
		public static EntityQuery ODELCHDLAII(ComponentSystemBase HJICJBAHBAD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x9008A0", Offset = "0x8FFAA0", VA = "0x1809008A0")]
		public static EntityQuery APFAMGADKGJ(ComponentSystemBase HJICJBAHBAD)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[EJLOOKEAJML(HNJEFABFMIP.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataToGameObjects : MGFJEDJDOGN
	{
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		[BurstCompile]
		private struct IJBEBIMFNJJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> EENLKKKHHGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			[ReadOnly]
			public NativeArray<Entity> JEFMGPHNDGN;

			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0xBDFAA0", Offset = "0xBDECA0", VA = "0x180BDFAA0", Slot = "4")]
			public void Execute(int MJNAIOAAGCG, TransformAccess EJOKPJGAPEO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct PPPLGEPDNJM : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> KJDDMMGFONE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			[ReadOnly]
			public NativeArray<Entity> JEFMGPHNDGN;

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xBE6AA0", Offset = "0xBE5CA0", VA = "0x180BE6AA0", Slot = "4")]
			public void Execute(int MJNAIOAAGCG, TransformAccess EJOKPJGAPEO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012F")]
		[BurstCompile]
		private struct BAIMKMIBBHN : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> KJDDMMGFONE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> IALJDBNNGNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			[ReadOnly]
			public NativeArray<Entity> JEFMGPHNDGN;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0xBD6700", Offset = "0xBD5900", VA = "0x180BD6700", Slot = "4")]
			public void Execute(int MJNAIOAAGCG, TransformAccess EJOKPJGAPEO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private const string GMNMIGEAHKD = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private const string OOCAMJDLCJA = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private const string GEFBJJIIKII = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private static readonly MKIMOBFPILG MAKLNEBPCKM;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private static readonly MKIMOBFPILG FNMIFLAJAOC;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private static readonly MKIMOBFPILG PFDEBIGBFNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private OHBFKDJMNML IAHIMJFEAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private JobHandle LBOLBKFKLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery HHIACMJLAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private EntityQuery FIAGBDDJDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private EntityQuery PPICHANGGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private TransformAccessArray POKPMKAKAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TransformAccessArray IIKAELPOKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TransformAccessArray BMPPAMJGHIN;

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xBDC370", Offset = "0xBDB570", VA = "0x180BDC370", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xBDC580", Offset = "0xBDB780", VA = "0x180BDC580", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x887460", Offset = "0x886660", VA = "0x180887460")]
		internal JobHandle BMNMGOOBAFJ()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xBDC5C0", Offset = "0xBDB7C0", VA = "0x180BDC5C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xBDC1E0", Offset = "0xBDB3E0", VA = "0x180BDC1E0")]
		private NativeArray<Entity> LBNKLMBODNE(NativeArray<LNMOMLMLAOK> OHIFGOLKNPK, NativeList<Entity> AMACFGMBPMI, TransformAccessArray BLDNAFEPDAD, TransformAccessArray LPGOELGAJBH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public class CPJLLCMJMBP : MGFJEDJDOGN, AIOPJLICFNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private EMAMLPGAPJK BDPKNEPLEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private FCBOBMFMIOB ILAADJAKLMF;

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0xA4ABE0", Offset = "0xA49DE0", VA = "0x180A4ABE0", Slot = "14")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0xA4AFE0", Offset = "0xA4A1E0", VA = "0x180A4AFE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0xA4AE50", Offset = "0xA4A050", VA = "0x180A4AE50")]
	private static void MNOBDJPNCOI(EntityManager KHDMOGKDGKL, Entity BBPBBOAPCHN, Entity ENAGHEEPLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0xA4AD70", Offset = "0xA49F70", VA = "0x180A4AD70")]
	private static Transform MLDEHACHCPK(EntityManager KHDMOGKDGKL, Entity BBPBBOAPCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public CPJLLCMJMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[EJLOOKEAJML(HNJEFABFMIP.TransformSyncing)]
	public class L2PToL2WHierarchy : MGFJEDJDOGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		[BurstCompile]
		private struct EBCAFFJCIBO : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> HLKIKKCIMFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> DOKOOKCIDPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> BMJMPGCBKNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> KDKNKDHFEFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public ArchetypeChunkComponentType<LocalToWorldData> OFJLHHMKIHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> CBGMPFJDDFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public uint IHDBCKAEPJH;

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A50", Offset = "0x8F1C50", VA = "0x1808F2A50")]
			[Conditional("DEBUG_BUILD")]
			private void KIHFNEHCBGI(Entity BBPBBOAPCHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x8F2770", Offset = "0x8F1970", VA = "0x1808F2770", Slot = "4")]
			public void Execute(ArchetypeChunk PDAFMJFPOLI, int MJNAIOAAGCG, int GJOGANGOAJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x8F2E40", Offset = "0x8F2040", VA = "0x1808F2E40")]
			private bool MNKAKGOLKII(ArchetypeChunk PDAFMJFPOLI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x8F2AF0", Offset = "0x8F1CF0", VA = "0x1808F2AF0")]
			private void KOJFFHGIEMB(float4x4 NFMOMGOHMEN, Entity BBPBBOAPCHN, bool EJFDIDCBIDP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery GOEELCLMMNF;

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x8F42B0", Offset = "0x8F34B0", VA = "0x1808F42B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x8F4340", Offset = "0x8F3540", VA = "0x1808F4340", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
public class HJNCMFBLIJM : PAJLCNMKBFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[BurstCompile]
	private struct DBJLFGMOIJL : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> HLKIKKCIMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public ArchetypeChunkComponentType<LocalToWorldData> OFJLHHMKIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public uint IHDBCKAEPJH;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x86E560", Offset = "0x86D760", VA = "0x18086E560", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int MJNAIOAAGCG, int GJOGANGOAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x86E670", Offset = "0x86D870", VA = "0x18086E670")]
		public bool MNKAKGOLKII(ArchetypeChunk PDAFMJFPOLI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private EntityQuery GOEELCLMMNF;

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x874650", Offset = "0x873850", VA = "0x180874650", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x874750", Offset = "0x873950", VA = "0x180874750", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PAEOIIAAEPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public HJNCMFBLIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
public class BILFFJHONFE : PAJLCNMKBFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[BurstCompile]
	private struct DBBFDKPKMCF : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> GOMFINHPHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public ArchetypeChunkComponentType<WorldPoseData> BOIHNCJGJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> DDCPEOOJGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> FFPCNKFKDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public uint IHDBCKAEPJH;

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0xA4B5A0", Offset = "0xA4A7A0", VA = "0x180A4B5A0", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int MJNAIOAAGCG, int GJOGANGOAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0xA4B940", Offset = "0xA4AB40", VA = "0x180A4B940")]
		public bool MNKAKGOLKII(ArchetypeChunk PDAFMJFPOLI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private EntityQuery AMIFBGIBKJA;

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0xA47A70", Offset = "0xA46C70", VA = "0x180A47A70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0xA47B60", Offset = "0xA46D60", VA = "0x180A47B60", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PAEOIIAAEPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public BILFFJHONFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
public class IOJCHKDEMEF : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[BurstCompile]
	private struct GBOHFKAPGHI : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> PACENDAIDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> DONCCAHAHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> JNMLAPGANFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public ArchetypeChunkComponentType<LocalToParentData> OBOBMJLPFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public uint IHDBCKAEPJH;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x86FDD0", Offset = "0x86EFD0", VA = "0x18086FDD0", Slot = "4")]
		public void Execute(ArchetypeChunk PDAFMJFPOLI, int MJNAIOAAGCG, int GJOGANGOAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x870280", Offset = "0x86F480", VA = "0x180870280")]
		public bool MNKAKGOLKII(ArchetypeChunk PDAFMJFPOLI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private EntityQuery AMIFBGIBKJA;

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x8769F0", Offset = "0x875BF0", VA = "0x1808769F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x876B00", Offset = "0x875D00", VA = "0x180876B00", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PAEOIIAAEPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640")]
	public IOJCHKDEMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal abstract class CMGLABGFAMF : PropagateTagsBase<global::JCKCMGJJKBH, global::OCJPIEODGAM, CMGLABGFAMF.AFNDFPCCPEO>
{
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	public struct AFNDFPCCPEO : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0xA49170", Offset = "0xA48370", VA = "0x180A49170")]
	protected CMGLABGFAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0xA49130", Offset = "0xA48330", VA = "0x180A49130", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[GOMOCALIPDK(DLPFMOEFOIG.Game)]
public class BBDLGBFPBGP : LMIAJPHNJEG
{
	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public Type CKAMBPMOPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xA46DF0", Offset = "0xA45FF0", VA = "0x180A46DF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public Type[] MHOHLAFANOD
	{
		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0xA469D0", Offset = "0xA45BD0", VA = "0x180A469D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public BBDLGBFPBGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
[GOMOCALIPDK(DLPFMOEFOIG.Loading)]
public class FCFLLICECGG : LMIAJPHNJEG
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Type CKAMBPMOPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x5F6110", Offset = "0x5F5310", VA = "0x1805F6110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Type[] MHOHLAFANOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xA4FAE0", Offset = "0xA4ECE0", VA = "0x180A4FAE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public FCFLLICECGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public sealed class BNOJHCIBHLI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public BNOJHCIBHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(BNOJHCIBHLI))]
public sealed class KHIGGCEACOJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public KHIGGCEACOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(KHIGGCEACOJ))]
[UpdateInGroup(typeof(BNOJHCIBHLI))]
public sealed class EEJGANBHFAJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public EEJGANBHFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
[GOMOCALIPDK(DLPFMOEFOIG.Saving)]
public class MPOPODCPPCJ : LMIAJPHNJEG
{
	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public Type CKAMBPMOPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x5F6110", Offset = "0x5F5310", VA = "0x1805F6110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Type[] MHOHLAFANOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x881FF0", Offset = "0x8811F0", VA = "0x180881FF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public MPOPODCPPCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class CIKCBMNIMCI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public CIKCBMNIMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
[GOMOCALIPDK(DLPFMOEFOIG.Simulation)]
public class KKMBNLLGDCI : LMIAJPHNJEG
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Type CKAMBPMOPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x87E5A0", Offset = "0x87D7A0", VA = "0x18087E5A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Type[] MHOHLAFANOD
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x87E380", Offset = "0x87D580", VA = "0x18087E380", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public KKMBNLLGDCI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[EJLOOKEAJML(HNJEFABFMIP.Connectables, new string[] { "Callbacks" })]
	[CLDGIFMABHG(typeof(FCIBLPNBBFB), new string[] { })]
	internal class ConnectableService : FCIBLPNBBFB, GOKNGONBKFG, AIOPJLICFNI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		[CompilerGenerated]
		private sealed class KFBBMCPECIA : IEnumerable<DHOEKPEGHDF>, IEnumerable, IEnumerator<DHOEKPEGHDF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			private DHOEKPEGHDF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			private DHOEKPEGHDF localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public DHOEKPEGHDF <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170000EB")]
			private DHOEKPEGHDF System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000845")]
				[Cpp2IlInjected.Address(RVA = "0x7EA030", Offset = "0x7E9230", VA = "0x1807EA030", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(DHOEKPEGHDF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000847")]
				[Cpp2IlInjected.Address(RVA = "0xBE0300", Offset = "0xBDF500", VA = "0x180BE0300", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0x880060", Offset = "0x87F260", VA = "0x180880060")]
			[DebuggerHidden]
			public KFBBMCPECIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0xBE0350", Offset = "0xBDF550", VA = "0x180BE0350", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000842")]
			[Cpp2IlInjected.Address(RVA = "0xBDFF60", Offset = "0xBDF160", VA = "0x180BDFF60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000843")]
			[Cpp2IlInjected.Address(RVA = "0xBE0440", Offset = "0xBDF640", VA = "0x180BE0440")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0xBE0480", Offset = "0xBDF680", VA = "0x180BE0480")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0xBE02B0", Offset = "0xBDF4B0", VA = "0x180BE02B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0xBE0200", Offset = "0xBDF400", VA = "0x180BE0200", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DHOEKPEGHDF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0xBE0200", Offset = "0xBDF400", VA = "0x180BE0200", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private const string BENAJLOLCCG = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly MKIMOBFPILG ECJFIDPHOKE;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public const int DJBBMFAHGGO = 0;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public const int OEADIPJHMBE = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private AEKECOGJAHN JGHMLHPFFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private BCEBIIAIFJH AMIFBGIBKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private EGHMCKEACDK DDCODOIGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private FCFLIDMJBKH FEPEKJBDLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private PropertyEventCallbacksService GDILCHBGMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private global::DJGMDJCGAJC<AuthoredParentData, IHFGDFFIKAA, EJJPOMLFOPL, AuthoredChildrenData> FHJLNNFOBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private global::IPONGJGODFC<Entity> PKCNPDGFNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private global::IPONGJGODFC<float3> JCPKDOLEJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private global::IPONGJGODFC<quaternion> PMHDEDNADAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private global::IPONGJGODFC<Entity> ENAGHEEPLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private global::IPONGJGODFC<float3> EMHBBLDAMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private global::IPONGJGODFC<quaternion> BNPOLGHMEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private HashSet<Entity> BHILBDCLMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private HashSet<Entity> CLHODNBMMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private EntityQuery HKKABANNCNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private bool JGKFDLIIMNF;

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public Func<HCPHAMJNCGD> IJAJELLCADB
		{
			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0x61A100", Offset = "0x619300", VA = "0x18061A100", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000829")]
			[Cpp2IlInjected.Address(RVA = "0x7340E0", Offset = "0x7332E0", VA = "0x1807340E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<DHOEKPEGHDF, DHOEKPEGHDF> BKAOOFFBMHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0xBDB730", Offset = "0xBDA930", VA = "0x180BDB730", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xBDA6E0", Offset = "0xBD98E0", VA = "0x180BDA6E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<DHOEKPEGHDF, DHOEKPEGHDF> NPNEEFDCIBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xBDB5F0", Offset = "0xBDA7F0", VA = "0x180BDB5F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0xBDAEB0", Offset = "0xBDA0B0", VA = "0x180BDAEB0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<DHOEKPEGHDF, DHOEKPEGHDF, DHOEKPEGHDF> GDIDPKDBFGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0xBDA250", Offset = "0xBD9450", VA = "0x180BDA250", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0xBDA8D0", Offset = "0xBD9AD0", VA = "0x180BDA8D0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<DHOEKPEGHDF> OIIHAFLKDAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0xBDAF50", Offset = "0xBDA150", VA = "0x180BDAF50", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000827")]
			[Cpp2IlInjected.Address(RVA = "0xBDB7D0", Offset = "0xBDA9D0", VA = "0x180BDB7D0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0xBDAD30", Offset = "0xBD9F30", VA = "0x180BDAD30", Slot = "23")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xBD9E20", Offset = "0xBD9020", VA = "0x180BD9E20", Slot = "24")]
		public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xBDAA40", Offset = "0xBD9C40", VA = "0x180BDAA40", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xBDAE50", Offset = "0xBDA050", VA = "0x180BDAE50")]
		private void GBONMONCHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xBDA780", Offset = "0xBD9980", VA = "0x180BDA780")]
		private void DGDELBEMKKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xBDB870", Offset = "0xBDAA70", VA = "0x180BDB870")]
		private void NDEFDADEAGK(Entity BBPBBOAPCHN, CAEHPHOEGJK FMBNLFNGBEI, JFFJOIBOPJP DDKOGDKKCAE, JFFJOIBOPJP FONEHOKCGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xBDBA50", Offset = "0xBDAC50", VA = "0x180BDBA50")]
		private void ODPPDHGAILG(Entity BBPBBOAPCHN, CAEHPHOEGJK FMBNLFNGBEI, JFFJOIBOPJP DDKOGDKKCAE, JFFJOIBOPJP FONEHOKCGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x8DB280", Offset = "0x8DA480", VA = "0x1808DB280", Slot = "14")]
		public DHOEKPEGHDF OGDMDNFAJJM(DHOEKPEGHDF LALFNHCEDJJ, int BOMGJNFJNGF)
		{
			return default(DHOEKPEGHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xBDBA20", Offset = "0xBDAC20", VA = "0x180BDBA20", Slot = "15")]
		public Color NIDPEBDKNIH(DHOEKPEGHDF LALFNHCEDJJ, int BOMGJNFJNGF)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xBDA2F0", Offset = "0xBD94F0", VA = "0x180BDA2F0", Slot = "16")]
		public float3 CEJNKNACOII(DHOEKPEGHDF LALFNHCEDJJ, int BOMGJNFJNGF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xBDA970", Offset = "0xBD9B70", VA = "0x180BDA970", Slot = "17")]
		public void DPLBOKBAOAN(DHOEKPEGHDF LALFNHCEDJJ, DHOEKPEGHDF PLHGNBEAJGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0xBDB690", Offset = "0xBDA890", VA = "0x180BDB690", Slot = "18")]
		public DHOEKPEGHDF JIPNBHNLIBO(DHOEKPEGHDF LALFNHCEDJJ)
		{
			return default(DHOEKPEGHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xBDA4D0", Offset = "0xBD96D0", VA = "0x180BDA4D0", Slot = "21")]
		public void CFDKMGBBPHB(DHOEKPEGHDF LALFNHCEDJJ, Vector3 IJBCEGGDLFI, Quaternion AIACDOBOBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0xBDABD0", Offset = "0xBD9DD0", VA = "0x180BDABD0", Slot = "26")]
		public (Vector3, Quaternion) EEFKGKGMLDE(DHOEKPEGHDF LALFNHCEDJJ)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xBDAFF0", Offset = "0xBDA1F0", VA = "0x180BDAFF0", Slot = "27")]
		public (Vector3, Quaternion) GONHMFIFFEI(DHOEKPEGHDF LALFNHCEDJJ)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xBDB180", Offset = "0xBDA380", VA = "0x180BDB180", Slot = "22")]
		public (Vector3, Quaternion, bool) HLBPNKHFCEE(DHOEKPEGHDF LALFNHCEDJJ)
		{
			return default((Vector3, Quaternion, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xBDB560", Offset = "0xBDA760", VA = "0x180BDB560", Slot = "19")]
		[IteratorStateMachine(typeof(KFBBMCPECIA))]
		public IEnumerable<DHOEKPEGHDF> IHNFEIJCINK(DHOEKPEGHDF LALFNHCEDJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xBDB440", Offset = "0xBDA640", VA = "0x180BDB440", Slot = "20")]
		public DHOEKPEGHDF ICNAANBPLFG(DHOEKPEGHDF LALFNHCEDJJ)
		{
			return default(DHOEKPEGHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xBDBAB0", Offset = "0xBDACB0", VA = "0x180BDBAB0", Slot = "28")]
		public void OICBMCNPMOB(ref List<DHOEKPEGHDF> KEOBIBPKNFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xBDB340", Offset = "0xBDA540", VA = "0x180BDB340")]
		private Entity ICNAANBPLFG(Entity BBPBBOAPCHN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xBDBCA0", Offset = "0xBDAEA0", VA = "0x180BDBCA0")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CLDGIFMABHG(typeof(EntityHierarchyChildren), new string[] { })]
	[EJLOOKEAJML(HNJEFABFMIP.HierarchySystems)]
	internal sealed class EntityHierarchyChildren : GOKNGONBKFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private EGHMCKEACDK DDCODOIGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private FGPFJCJFGIL KIOLEKBJBID;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		private EntityManager POMAKGKDHPN
		{
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0xBDF1C0", Offset = "0xBDE3C0", VA = "0x180BDF1C0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0xBDE830", Offset = "0xBDDA30", VA = "0x180BDE830", Slot = "4")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0xBDE8B0", Offset = "0xBDDAB0", VA = "0x180BDE8B0")]
		internal void EPGFLKONPMH(Entity ENAGHEEPLJN, Entity MEFCJLOHDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0xBDE760", Offset = "0xBDD960", VA = "0x180BDE760")]
		internal void EAIEJIHGFLE(Entity ENAGHEEPLJN, Entity MEFCJLOHDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0xBDEBC0", Offset = "0xBDDDC0", VA = "0x180BDEBC0")]
		private int FPKHIDMAIBE(Entity ENAGHEEPLJN, Entity MEFCJLOHDGD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0xBDEF00", Offset = "0xBDE100", VA = "0x180BDEF00")]
		internal DynamicBuffer<ChildrenData> IBDNBMCEACA(Entity BBPBBOAPCHN)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0xBDEFC0", Offset = "0xBDE1C0", VA = "0x180BDEFC0")]
		internal DynamicBuffer<ChildrenData> KKHPIKMJOLO(Entity BBPBBOAPCHN)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0xBDEEA0", Offset = "0xBDE0A0", VA = "0x180BDEEA0")]
		public NativeArray<Entity> HPNBNPONGCB(Entity BBPBBOAPCHN, Allocator MKFODJKMOCC)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0xBDEA10", Offset = "0xBDDC10", VA = "0x180BDEA10")]
		public bool FJPEMKLNLLK(Entity BBPBBOAPCHN, Allocator MKFODJKMOCC, out NativeArray<Entity> GPGAAMMALLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xBDF080", Offset = "0xBDE280", VA = "0x180BDF080")]
		public NativeArray<Entity> OAEMNKDINCN(Entity BBPBBOAPCHN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0xBDED90", Offset = "0xBDDF90", VA = "0x180BDED90")]
		public Entity HBLIKENLLJI(Entity BBPBBOAPCHN, int MJNAIOAAGCG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xBDECA0", Offset = "0xBDDEA0", VA = "0x180BDECA0")]
		public int GPDJPDFLPPN(Entity BBPBBOAPCHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public EntityHierarchyChildren()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[EJLOOKEAJML(HNJEFABFMIP.HierarchySystems)]
	[CLDGIFMABHG(typeof(EntityHierarchyEvents), new string[] { })]
	internal sealed class EntityHierarchyEvents : GOKNGONBKFG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private EGHMCKEACDK DDCODOIGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private ObjectEmbodimentService MBMBGCPJPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private ObjectLifecycleService KDKALCDIKIM;

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x8F3200", Offset = "0x8F2400", VA = "0x1808F3200", Slot = "4")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x8F30F0", Offset = "0x8F22F0", VA = "0x1808F30F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		private void OPGGALCEGMH(HOFMJBLAIFM MBMBGCPJPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		private void DFDPFCGKMJG(HOFMJBLAIFM MBMBGCPJPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		private void LCKBGGCBLDL(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public EntityHierarchyEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CLDGIFMABHG(typeof(EntityHierarchyParents), new string[] { })]
	[EJLOOKEAJML(HNJEFABFMIP.HierarchySystems)]
	internal sealed class EntityHierarchyParents : GOKNGONBKFG, AIOPJLICFNI
	{
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private BCEBIIAIFJH AMIFBGIBKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private global::IPONGJGODFC<Entity> HJJHAMKLCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private PropertyChangeNetworkRouter NCELLBNMAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private global::DJGMDJCGAJC<ParentData, DFNCJJGLOJB, AJHGPGLGKCO, ChildrenData> FHJLNNFOBLD;

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x8F39E0", Offset = "0x8F2BE0", VA = "0x1808F39E0", Slot = "4")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x8F35D0", Offset = "0x8F27D0", VA = "0x1808F35D0", Slot = "5")]
		public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x8F3A60", Offset = "0x8F2C60", VA = "0x1808F3A60")]
		public Entity JIPNBHNLIBO(Entity BBPBBOAPCHN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x8F3AB0", Offset = "0x8F2CB0", VA = "0x1808F3AB0")]
		public bool OOCBEJCPAJA(Entity BBPBBOAPCHN, Entity NHDMOENBBDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x8F36B0", Offset = "0x8F28B0", VA = "0x1808F36B0")]
		public bool DPLBOKBAOAN(Entity BBPBBOAPCHN, Entity NHDMOENBBDB, bool IGFOOKFBPDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x8F3750", Offset = "0x8F2950", VA = "0x1808F3750")]
		private bool EDJPMCMPBAI(Entity BBPBBOAPCHN, Entity NHDMOENBBDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[OCLKOGGMIFL(typeof(EGHMCKEACDK))]
[CLDGIFMABHG(typeof(FGPFJCJFGIL), new string[] { })]
internal sealed class FGPFJCJFGIL : GOKNGONBKFG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class JOLPDEEABHB : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public FGPFJCJFGIL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600087A")]
			[Cpp2IlInjected.Address(RVA = "0x8F5410", Offset = "0x8F4610", VA = "0x1808F5410", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600087C")]
			[Cpp2IlInjected.Address(RVA = "0xA56360", Offset = "0xA55560", VA = "0x180A56360", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
		[DebuggerHidden]
		public JOLPDEEABHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0xA561C0", Offset = "0xA553C0", VA = "0x180A561C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0xA56310", Offset = "0xA55510", VA = "0x180A56310", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0xA56260", Offset = "0xA55460", VA = "0x180A56260", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xA56260", Offset = "0xA55460", VA = "0x180A56260", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class AKCNOCAALKB : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public FGPFJCJFGIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private IEnumerator<Entity> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0x8F5410", Offset = "0x8F4610", VA = "0x1808F5410", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0xA46880", Offset = "0xA45A80", VA = "0x180A46880", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
		[DebuggerHidden]
		public AKCNOCAALKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0xA468D0", Offset = "0xA45AD0", VA = "0x180A468D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0xA465C0", Offset = "0xA457C0", VA = "0x180A465C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0xA46980", Offset = "0xA45B80", VA = "0x180A46980")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0xA46830", Offset = "0xA45A30", VA = "0x180A46830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0xA46780", Offset = "0xA45980", VA = "0x180A46780", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0xA46780", Offset = "0xA45980", VA = "0x180A46780", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class KKABINAJHDH : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public FGPFJCJFGIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private ChildrenData <childData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private IEnumerator<Entity> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0x8F5410", Offset = "0x8F4610", VA = "0x1808F5410", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0xA56760", Offset = "0xA55960", VA = "0x180A56760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
		[DebuggerHidden]
		public KKABINAJHDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0xA567B0", Offset = "0xA559B0", VA = "0x180A567B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA563B0", Offset = "0xA555B0", VA = "0x180A563B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA568B0", Offset = "0xA55AB0", VA = "0x180A568B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xA568F0", Offset = "0xA55AF0", VA = "0x180A568F0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0xA56710", Offset = "0xA55910", VA = "0x180A56710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA56660", Offset = "0xA55860", VA = "0x180A56660", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA56660", Offset = "0xA55860", VA = "0x180A56660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private EGHMCKEACDK DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private EntityHierarchyParents CGJDIOIHEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private EntityHierarchyChildren DKJCFPOBMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private EntityQuery HKKABANNCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private EntityManager POMAKGKDHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0xA50FC0", Offset = "0xA501C0", VA = "0x180A50FC0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xA50770", Offset = "0xA4F970", VA = "0x180A50770", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0xA504A0", Offset = "0xA4F6A0", VA = "0x180A504A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0xA50910", Offset = "0xA4FB10", VA = "0x180A50910")]
	public bool IHHDFCDACMB(Entity BBPBBOAPCHN, Entity KIENEBDMBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0xA50690", Offset = "0xA4F890", VA = "0x180A50690")]
	public bool EIPOAJANOMB(Entity BBPBBOAPCHN, Entity KIENEBDMBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0xA50AB0", Offset = "0xA4FCB0", VA = "0x180A50AB0")]
	public IEnumerable<Entity> JEGGPJGBBHI(Entity BBPBBOAPCHN, bool BNLLAFMBMBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0xA505F0", Offset = "0xA4F7F0", VA = "0x180A505F0")]
	[IteratorStateMachine(typeof(JOLPDEEABHB))]
	private IEnumerable<Entity> EILJONJNKPM(Entity BBPBBOAPCHN, bool BNLLAFMBMBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0xA50340", Offset = "0xA4F540", VA = "0x180A50340")]
	public bool BHPOJEHMCDF(Entity BBPBBOAPCHN, Entity MEFCJLOHDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0xA50DD0", Offset = "0xA4FFD0", VA = "0x180A50DD0")]
	public bool LPJCHEENNME(Entity BBPBBOAPCHN, Entity NDAHKJDCMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0xA504C0", Offset = "0xA4F6C0", VA = "0x180A504C0")]
	public IEnumerable<Entity> EBHGCDPNOFK(Entity BBPBBOAPCHN, bool BNLLAFMBMBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0xA50400", Offset = "0xA4F600", VA = "0x180A50400")]
	[IteratorStateMachine(typeof(AKCNOCAALKB))]
	private IEnumerable<Entity> DHJFNDCBFLK(Entity BBPBBOAPCHN, bool BNLLAFMBMBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0xA502C0", Offset = "0xA4F4C0", VA = "0x180A502C0")]
	[IteratorStateMachine(typeof(KKABINAJHDH))]
	private IEnumerable<Entity> AKHPMCHOLEK(Entity BBPBBOAPCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0xA50880", Offset = "0xA4FA80", VA = "0x180A50880")]
	public Entity ICNAANBPLFG(Entity BBPBBOAPCHN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0xA50F70", Offset = "0xA50170", VA = "0x180A50F70")]
	public NativeArray<Entity> OICBMCNPMOB()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0xA50BE0", Offset = "0xA4FDE0", VA = "0x180A50BE0")]
	public bool JNJEOIADFEB(Entity NDAHKJDCMHN, Entity HDCGKEELIMP, out Entity CICDHHCPFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public FGPFJCJFGIL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[EJLOOKEAJML(HNJEFABFMIP.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x3B2EFE0", Offset = "0x3B2E1E0", VA = "0x183B2EFE0")]
		public static void KPGMNJIIOMJ<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData>(AMEKELGLMNH NHJMFHJKDFP, global::PCAOFNBPEMD<Entity> FFIIDDPMMKG, out global::DJGMDJCGAJC<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> IMLMCDFEGGC) where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, JHLIGMDNFAC where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, JHLIGMDNFAC, IEquatable<ChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x8FBEB0", Offset = "0x8FB0B0", VA = "0x1808FBEB0")]
		public static bool FBNGHNNPJJE(HOFMJBLAIFM KPPLLFPIALK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
public class DJGMDJCGAJC<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, JHLIGMDNFAC where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, JHLIGMDNFAC, IEquatable<ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private static readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly EGHMCKEACDK DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly global::IPONGJGODFC<Entity> HJJHAMKLCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly PDFECNJDFGM DIACOOGHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private readonly EMOEMMBOEPM ENAGHEEPLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly EntityManager KHDMOGKDGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private readonly FCBOBMFMIOB ILAADJAKLMF;

	[Cpp2IlInjected.Token(Token = "0x6000894")]
	[Cpp2IlInjected.Address(RVA = "0x46CE980", Offset = "0x46CDB80", VA = "0x1846CE980")]
	public DJGMDJCGAJC(AMEKELGLMNH NHJMFHJKDFP, global::PCAOFNBPEMD<Entity> FFIIDDPMMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0x46CD790", Offset = "0x46CC990", VA = "0x1846CD790")]
	private bool CGNAJEKNOHB(Entity BBPBBOAPCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x46CD990", Offset = "0x46CCB90", VA = "0x1846CD990")]
	private bool FBDLPMJONPI(Entity BBPBBOAPCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x46CD560", Offset = "0x46CC760", VA = "0x1846CD560")]
	public bool AGGKMPFAIPM(Entity BBPBBOAPCHN, in Entity NHDMOENBBDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	private static void KPBOOPMBPGF(Entity BBPBBOAPCHN, Entity NHDMOENBBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	private static void IIBKCILAGHE(Entity BBPBBOAPCHN, Entity NHDMOENBBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0x46CDAB0", Offset = "0x46CCCB0", VA = "0x1846CDAB0")]
	private bool IHHDFCDACMB(Entity BBPBBOAPCHN, Entity KIENEBDMBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0x46CDB80", Offset = "0x46CCD80", VA = "0x1846CDB80")]
	private void JLEBLEEIPBB(Entity BBPBBOAPCHN, in Entity GDGMBLIDIJF, in Entity NHDMOENBBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089C")]
	[Cpp2IlInjected.Address(RVA = "0x46CE2B0", Offset = "0x46CD4B0", VA = "0x1846CE2B0")]
	private void PPHLOBMNEJL(Entity BBPBBOAPCHN, in Entity GDGMBLIDIJF, in Entity NHDMOENBBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x46CDC60", Offset = "0x46CCE60", VA = "0x1846CDC60")]
	private bool NJIHLDJHNIG(PGHKNPMGDMD OBMAOBEIKGC, in NJKBLCBBANC GHOJOPHOFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0x46CDFE0", Offset = "0x46CD1E0", VA = "0x1846CDFE0")]
	private void PAEJLGGECHJ(Entity ENAGHEEPLJN, Entity MEFCJLOHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0x46CD850", Offset = "0x46CCA50", VA = "0x1846CD850")]
	private void COODBNEDKMC(Entity ENAGHEEPLJN, Entity MEFCJLOHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A0")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	private void BJONHACMNPB(Entity BBPBBOAPCHN, Entity GDGMBLIDIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A1")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	private void EFJPHJAMFLN(Entity BBPBBOAPCHN, Entity NHDMOENBBDB)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[EJLOOKEAJML(HNJEFABFMIP.HierarchySystems)]
	[CLDGIFMABHG(typeof(TransformOwnershipPhase), new string[] { })]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		public enum EKCKMLCHNBF
		{
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x2000150")]
		public struct OBHAFHOKHDF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private EKCKMLCHNBF MDMGKOEHFEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private readonly TransformOwnershipPhase ENAGHEEPLJN;

			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0x8F5230", Offset = "0x8F4430", VA = "0x1808F5230")]
			public OBHAFHOKHDF(TransformOwnershipPhase ENAGHEEPLJN, EKCKMLCHNBF PHHEJAEEKNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0x8F5210", Offset = "0x8F4410", VA = "0x1808F5210", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public EKCKMLCHNBF PHHEJAEEKNL;

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public EKCKMLCHNBF EMABAGGCPIF
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x62D550", Offset = "0x62C750", VA = "0x18062D550")]
			get
			{
				return default(EKCKMLCHNBF);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0x6EDC00", Offset = "0x6ECE00", VA = "0x1806EDC00")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public bool KEDBODHPLDB
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x903000", Offset = "0x902200", VA = "0x180903000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public bool OKCCEFCGJNL
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0x902FF0", Offset = "0x9021F0", VA = "0x180902FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x903060", Offset = "0x902260", VA = "0x180903060")]
		public OBHAFHOKHDF INILNPJICFP()
		{
			return default(OBHAFHOKHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x903010", Offset = "0x902210", VA = "0x180903010")]
		public OBHAFHOKHDF HPPJKINDOFP()
		{
			return default(OBHAFHOKHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public TransformOwnershipPhase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
public struct MLGKNPJCKAB : global::FMOBBOIANPF<MLGKNPJCKAB>, AMBNOAMFBPJ, IEquatable<MLGKNPJCKAB>
{
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly MLGKNPJCKAB LEDMJNCKCFB;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public int CCIFACONDAF
	{
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FD360", Offset = "0x6FC560", VA = "0x1806FD360", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FD370", Offset = "0x6FC570", VA = "0x1806FD370", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public int IDFONEJIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x881B10", Offset = "0x880D10", VA = "0x180881B10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x881B00", Offset = "0x880D00", VA = "0x180881B00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool MJFCPIFHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x881C00", Offset = "0x880E00", VA = "0x180881C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0x881BB0", Offset = "0x880DB0", VA = "0x180881BB0", Slot = "8")]
	public bool Equals(MLGKNPJCKAB GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B3")]
	[Cpp2IlInjected.Address(RVA = "0x881C40", Offset = "0x880E40", VA = "0x180881C40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
public struct CFCAACMHEIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public MLGKNPJCKAB BEDKMKLJIGF;
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct PEJIPOCOINB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private const int FILJDEPBOAD = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private readonly Stack<HashSet<object>> PKEEBJNLPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private global::NNJNOKFJADK<MLGKNPJCKAB, HashSet<object>> DIGIGCLIAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private EntityManager KHDMOGKDGKL;

	[Cpp2IlInjected.Token(Token = "0x60008B5")]
	[Cpp2IlInjected.Address(RVA = "0xBE6360", Offset = "0xBE5560", VA = "0x180BE6360")]
	public PEJIPOCOINB(EntityManager KHDMOGKDGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0xBE6000", Offset = "0xBE5200", VA = "0x180BE6000")]
	public void FKFAOJICEFL(Entity BBPBBOAPCHN, object HCPCDENCJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE5340", VA = "0x180BE6140")]
	public bool IKLEFPGPHBH(Entity BBPBBOAPCHN, object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0xBE5F20", Offset = "0xBE5120", VA = "0x180BE5F20")]
	public bool EPFFNFDMIHC(Entity BBPBBOAPCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B9")]
	[Cpp2IlInjected.Address(RVA = "0xBE5F60", Offset = "0xBE5160", VA = "0x180BE5F60")]
	public bool EPFFNFDMIHC(MLGKNPJCKAB BEDKMKLJIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(RVA = "0xBE6290", Offset = "0xBE5490", VA = "0x180BE6290")]
	public bool KONCCENPKNG(Entity BBPBBOAPCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0xBE5EE0", Offset = "0xBE50E0", VA = "0x180BE5EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0xBE60E0", Offset = "0xBE52E0", VA = "0x180BE60E0")]
	private void GHIJAFIGMOO(HashSet<object> FFDJKICMKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0xBE5D40", Offset = "0xBE4F40", VA = "0x180BE5D40")]
	private bool CKGNBKCNCGM(Entity BBPBBOAPCHN, out MLGKNPJCKAB BEDKMKLJIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(RVA = "0xBE5CD0", Offset = "0xBE4ED0", VA = "0x180BE5CD0")]
	private void AAKJPAOMPLP(Entity BBPBBOAPCHN, MLGKNPJCKAB BEDKMKLJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0xBE5E80", Offset = "0xBE5080", VA = "0x180BE5E80")]
	private bool DLNEDLHLGEO(MLGKNPJCKAB JELMKLCDONC, out HashSet<object> FFDJKICMKJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C0")]
	[Cpp2IlInjected.Address(RVA = "0xBE5E00", Offset = "0xBE5000", VA = "0x180BE5E00")]
	private HashSet<object> DIEDMAEJLDB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
[CLDGIFMABHG(typeof(NMIMFDNKLJP), new string[] { })]
public sealed class NMIMFDNKLJP
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action LCCGHLCIFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x884280", Offset = "0x883480", VA = "0x180884280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x8841E0", Offset = "0x8833E0", VA = "0x1808841E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action ILAOCEHPFOP
	{
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x884320", Offset = "0x883520", VA = "0x180884320")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x884120", Offset = "0x883320", VA = "0x180884120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8833C0", VA = "0x1808841C0")]
	public void FNMGHKMMJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x884100", Offset = "0x883300", VA = "0x180884100")]
	public void AFMGOMNCDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public NMIMFDNKLJP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[EJLOOKEAJML(HNJEFABFMIP.Embodiment)]
	[CLDGIFMABHG(typeof(ObjectEmbodimentService), new string[] { })]
	internal sealed class ObjectEmbodimentService : PMOCCIAIAEL, GFHKHHPFFGF, GOKNGONBKFG, AIOPJLICFNI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private readonly Dictionary<NJKBLCBBANC, IMGFAEJLICC> DIDCHHBDAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private EGHMCKEACDK DDCODOIGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private AEKECOGJAHN JGHMLHPFFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private BCEBIIAIFJH AMIFBGIBKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private FCFLIDMJBKH FEPEKJBDLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private GODBNDJPCCG MFNOBEHMFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private PEJIPOCOINB EEFHEDDMHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private EntityHierarchyChildren DKJCFPOBMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private ObjectLifecycleService KDKALCDIKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TransformOwnershipPhase PHHEJAEEKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private bool JGKFDLIIMNF;

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		private EntityManager POMAKGKDHPN
		{
			[Cpp2IlInjected.Token(Token = "0x60008CC")]
			[Cpp2IlInjected.Address(RVA = "0x8F8670", Offset = "0x8F7870", VA = "0x1808F8670")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public int NDNMHIMGOCE
		{
			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0x8F6770", Offset = "0x8F5970", VA = "0x1808F6770")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int IABFMDLGEJN
		{
			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0x8F5D20", Offset = "0x8F4F20", VA = "0x1808F5D20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<HOFMJBLAIFM> IFICOOFLKCN
		{
			[Cpp2IlInjected.Token(Token = "0x60008C8")]
			[Cpp2IlInjected.Address(RVA = "0x8F6C80", Offset = "0x8F5E80", VA = "0x1808F6C80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0x8F5700", Offset = "0x8F4900", VA = "0x1808F5700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<HOFMJBLAIFM> OFILPFLIOCH
		{
			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x8F65F0", Offset = "0x8F57F0", VA = "0x1808F65F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x8F7360", Offset = "0x8F6560", VA = "0x1808F7360", Slot = "4")]
		public void JFNNIMEOELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x8F6380", Offset = "0x8F5580", VA = "0x1808F6380", Slot = "5")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x8F57A0", Offset = "0x8F49A0", VA = "0x1808F57A0", Slot = "6")]
		public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BC0", Offset = "0x8F4DC0", VA = "0x1808F5BC0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x8F6F30", Offset = "0x8F6130", VA = "0x1808F6F30")]
		public bool JBPDAEEDMKN(Entity BBPBBOAPCHN, Allocator MKFODJKMOCC, out NativeList<Entity> EJLBGGAEJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x8F6AA0", Offset = "0x8F5CA0", VA = "0x1808F6AA0")]
		public global::ENJHCOCKNOH<Entity> GOFEJEMOGDO(Allocator MKFODJKMOCC)
		{
			return default(global::ENJHCOCKNOH<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x8F5AE0", Offset = "0x8F4CE0", VA = "0x1808F5AE0")]
		public bool BMLMCDCGBFJ(Entity BBPBBOAPCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x8F7250", Offset = "0x8F6450", VA = "0x1808F7250")]
		public bool JFINADNOEDC(Entity BBPBBOAPCHN, out IMGFAEJLICC MBMBGCPJPOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x8F72C0", Offset = "0x8F64C0", VA = "0x1808F72C0")]
		private bool JFINADNOEDC(Transform EJOKPJGAPEO, out IMGFAEJLICC MBMBGCPJPOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x8F5D00", Offset = "0x8F4F00", VA = "0x1808F5D00")]
		internal bool ECFEAMDNHLA(Entity BBPBBOAPCHN, out ELFDLGFPJNI MBMBGCPJPOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x8F5670", Offset = "0x8F4870", VA = "0x1808F5670")]
		private void AGGPGLAGOFG(Entity BBPBBOAPCHN, IMGFAEJLICC MBMBGCPJPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x8F6560", Offset = "0x8F5760", VA = "0x1808F6560")]
		private bool ENBEFELCKMP(Entity BBPBBOAPCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x8F83F0", Offset = "0x8F75F0", VA = "0x1808F83F0")]
		public void NKCPCCNOLCN(NJKBLCBBANC AGHJLKKAHGN, IMGFAEJLICC FBJEHDDCEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x8F5B00", Offset = "0x8F4D00", VA = "0x1808F5B00")]
		public bool DDOCPFCHNDD(Entity BBPBBOAPCHN, object HCPCDENCJBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x8F5D40", Offset = "0x8F4F40", VA = "0x1808F5D40")]
		public bool EGCKKKHLIGC(DHOEKPEGHDF LALFNHCEDJJ, object HCPCDENCJBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x8F5E10", Offset = "0x8F5010", VA = "0x1808F5E10")]
		public bool EGCKKKHLIGC(Entity BBPBBOAPCHN, [Optional] object HCPCDENCJBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x8F5F00", Offset = "0x8F5100", VA = "0x1808F5F00")]
		public bool EGCKKKHLIGC(IMGFAEJLICC KPPLLFPIALK, object HCPCDENCJBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x8F8340", Offset = "0x8F7540", VA = "0x1808F8340")]
		public bool NAEPNJODOKA(Entity BBPBBOAPCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x8F8310", Offset = "0x8F7510", VA = "0x1808F8310")]
		public bool NAEPNJODOKA(IMGFAEJLICC MBMBGCPJPOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x8F5F20", Offset = "0x8F5120", VA = "0x1808F5F20")]
		public bool EGCKKKHLIGC(IMGFAEJLICC MBMBGCPJPOE, [Optional] object HCPCDENCJBA, bool JCMDBKNCKJK = false, bool CGGJNLCFOMF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D20", Offset = "0x8F5F20", VA = "0x1808F6D20")]
		public Transform ICKBGBOJLAM(Entity BBPBBOAPCHN, [Optional] object HCPCDENCJBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x8F66A0", Offset = "0x8F58A0", VA = "0x1808F66A0")]
		public bool FKHKOKAODEG(Entity BBPBBOAPCHN, out Transform EJOKPJGAPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x8F86C0", Offset = "0x8F78C0", VA = "0x1808F86C0")]
		public IMGFAEJLICC PCGNKLBJGLE(Entity BBPBBOAPCHN, [Optional] object HCPCDENCJBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x8F6880", Offset = "0x8F5A80", VA = "0x1808F6880")]
		public void GGEOLGDOKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D40", Offset = "0x8F6F40", VA = "0x1808F7D40")]
		public void LNAPAFJFHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x8F7460", Offset = "0x8F6660", VA = "0x1808F7460")]
		private void LFFAMECBGEB(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x8F6580", Offset = "0x8F5780", VA = "0x1808F6580")]
		public IMGFAEJLICC EOMMGFHEFNP(Entity BBPBBOAPCHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x8F6690", Offset = "0x8F5890", VA = "0x1808F6690")]
		public void FKFAOJICEFL(Entity BBPBBOAPCHN, object HCPCDENCJBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x8F6F20", Offset = "0x8F6120", VA = "0x1808F6F20")]
		public bool IKLEFPGPHBH(Entity BBPBBOAPCHN, object HCPCDENCJBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x8F7450", Offset = "0x8F6650", VA = "0x1808F7450")]
		public bool KONCCENPKNG(Entity BBPBBOAPCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x8F65D0", Offset = "0x8F57D0", VA = "0x1808F65D0")]
		public bool EPFFNFDMIHC(Entity BBPBBOAPCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x8F65E0", Offset = "0x8F57E0", VA = "0x1808F65E0")]
		public bool EPFFNFDMIHC(MLGKNPJCKAB BEDKMKLJIGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x8F7100", Offset = "0x8F6300", VA = "0x1808F7100")]
		private void JCBAJCPFCLG(bool NIADKFKEAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x8F80E0", Offset = "0x8F72E0", VA = "0x1808F80E0")]
		private bool MENFLBJOCCJ(Entity BBPBBOAPCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x8F8070", Offset = "0x8F7270", VA = "0x1808F8070")]
		private IMGFAEJLICC MBCICKBONJK(Entity BBPBBOAPCHN, object HCPCDENCJBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x8F6AE0", Offset = "0x8F5CE0", VA = "0x1808F6AE0")]
		private IMGFAEJLICC HHPCIOKCOPL(Entity BBPBBOAPCHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x8F58D0", Offset = "0x8F4AD0", VA = "0x1808F58D0")]
		private (Vector3, Quaternion, Vector3) BMAADLKOBPJ(Entity BBPBBOAPCHN)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x8F6790", Offset = "0x8F5990", VA = "0x1808F6790")]
		private void GCCDIAAOKAG(Entity BBPBBOAPCHN, FNCBEEHJHBJ FKFNLDMHBOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x8F8170", Offset = "0x8F7370", VA = "0x1808F8170")]
		private void MFKAHNHBAHA(DHOEKPEGHDF LALFNHCEDJJ, IMGFAEJLICC FBJEHDDCEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x8F7700", Offset = "0x8F6900", VA = "0x1808F7700")]
		private void LHGEJOPCKOK(IMGFAEJLICC MBMBGCPJPOE, Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6D20", VA = "0x1808F7B20")]
		private void LKMKFHEGAKL(Entity BBPBBOAPCHN, IMGFAEJLICC MBMBGCPJPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x8F7370", Offset = "0x8F6570", VA = "0x1808F7370")]
		private void JNMCBFDMKDG(Entity BBPBBOAPCHN, Transform EJOKPJGAPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x8F6350", Offset = "0x8F5550", VA = "0x1808F6350")]
		private DHOEKPEGHDF EMEEFHIDAMC(Entity BBPBBOAPCHN)
		{
			return default(DHOEKPEGHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x8F87E0", Offset = "0x8F79E0", VA = "0x1808F87E0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x8F8520", Offset = "0x8F7720", VA = "0x1808F8520")]
		[CompilerGenerated]
		private void OBOMMKLPKBD()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal static class ELKIJJPBMJK
{
	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0xA4EF60", Offset = "0xA4E160", VA = "0x180A4EF60")]
	public static IMGFAEJLICC PCGNKLBJGLE(this ObjectEmbodimentService AJJHOLKBJCH, DHOEKPEGHDF LALFNHCEDJJ, [Optional] object HCPCDENCJBA)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CLDGIFMABHG(typeof(ObjectLifecycleService), new string[] { })]
	[EJLOOKEAJML(HNJEFABFMIP.Lifecycle)]
	internal sealed class ObjectLifecycleService : GOKNGONBKFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private EGHMCKEACDK PELFBHDCPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private ObjectEmbodimentService MBMBGCPJPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private ObjectNetworkToLocalMapService NKFKKMPLGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private EntityHierarchyChildren DKJCFPOBMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private FGPFJCJFGIL KIOLEKBJBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private EntityHierarchyParents CGJDIOIHEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private EACAABABNNF GJHJLCJCGJK;

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		private EntityManager POMAKGKDHPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000902")]
			[Cpp2IlInjected.Address(RVA = "0x8F95A0", Offset = "0x8F87A0", VA = "0x1808F95A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<Entity, FNCBEEHJHBJ> MOIEDBGOCJG
		{
			[Cpp2IlInjected.Token(Token = "0x60008FE")]
			[Cpp2IlInjected.Address(RVA = "0x8F8980", Offset = "0x8F7B80", VA = "0x1808F8980")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008FF")]
			[Cpp2IlInjected.Address(RVA = "0x8F9460", Offset = "0x8F8660", VA = "0x1808F9460")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<Entity> AEFHFEDKCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(RVA = "0x8F9280", Offset = "0x8F8480", VA = "0x1808F9280")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000901")]
			[Cpp2IlInjected.Address(RVA = "0x8F8F20", Offset = "0x8F8120", VA = "0x1808F8F20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x8F8DA0", Offset = "0x8F7FA0", VA = "0x1808F8DA0", Slot = "4")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x8F9680", Offset = "0x8F8880", VA = "0x1808F9680")]
		public bool PNGIIMFCLDE(Entity BBPBBOAPCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x8F8EC0", Offset = "0x8F80C0", VA = "0x1808F8EC0")]
		internal void EPJOIFGEBAE(Entity BBPBBOAPCHN, FNCBEEHJHBJ FKFNLDMHBOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x8F95F0", Offset = "0x8F87F0", VA = "0x1808F95F0")]
		public void PHICAJGHHMA(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x8F9320", Offset = "0x8F8520", VA = "0x1808F9320")]
		public void LDDOKODCMGI(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x8F8850", Offset = "0x8F7A50", VA = "0x1808F8850")]
		private bool AGOGAJAJDPA(Entity BBPBBOAPCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x8F9500", Offset = "0x8F8700", VA = "0x1808F9500")]
		public void NCECDLLHAEG(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FC0", Offset = "0x8F81C0", VA = "0x1808F8FC0")]
		private void GJHDOADKNEP(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x8F8A20", Offset = "0x8F7C20", VA = "0x1808F8A20")]
		private void EIBJIKBPPLP(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FF0", Offset = "0x8F81F0", VA = "0x1808F8FF0")]
		private void HJBBPDOPPCI(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x8F8C30", Offset = "0x8F7E30", VA = "0x1808F8C30")]
		private void ELNJAPOEODN(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CLDGIFMABHG(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[EJLOOKEAJML(HNJEFABFMIP.Embodiment)]
	internal sealed class ObjectNetworkToLocalMapService : GOKNGONBKFG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private NativeHashMap<NJKBLCBBANC, Entity> KHFDKHMJIHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private EGHMCKEACDK PELFBHDCPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private AEKECOGJAHN JGHMLHPFFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private EntityManager KHDMOGKDGKL;

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		internal NativeHashMap<NJKBLCBBANC, Entity> KOEOJPGEFCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000911")]
			[Cpp2IlInjected.Address(RVA = "0x6FD290", Offset = "0x6FC490", VA = "0x1806FD290")]
			get
			{
				return default(NativeHashMap<NJKBLCBBANC, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x8F97E0", Offset = "0x8F89E0", VA = "0x1808F97E0", Slot = "4")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x8F9750", Offset = "0x8F8950", VA = "0x1808F9750", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C30", Offset = "0x8F8E30", VA = "0x1808F9C30")]
		public void NLALCDJNEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x8F97B0", Offset = "0x8F89B0", VA = "0x1808F97B0")]
		private DHOEKPEGHDF EMEEFHIDAMC(Entity BBPBBOAPCHN)
		{
			return default(DHOEKPEGHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A70", Offset = "0x8F8C70", VA = "0x1808F9A70")]
		public DHOEKPEGHDF KCKNGDOKMAD(NJKBLCBBANC AGHJLKKAHGN)
		{
			return default(DHOEKPEGHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BA0", Offset = "0x8F8DA0", VA = "0x1808F9BA0")]
		public NJKBLCBBANC MEDMAHADGEL(DHOEKPEGHDF LALFNHCEDJJ)
		{
			return default(NJKBLCBBANC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x8F98B0", Offset = "0x8F8AB0", VA = "0x1808F98B0")]
		public void EPEMLOGOMPM(Entity BBPBBOAPCHN, NJKBLCBBANC AGHJLKKAHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x8F9B40", Offset = "0x8F8D40", VA = "0x1808F9B40")]
		public void LHMOEDCMOOA(Entity BBPBBOAPCHN, NJKBLCBBANC AGHJLKKAHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x8F9940", Offset = "0x8F8B40", VA = "0x1808F9940")]
		public void IHKIHMBEPNA(Entity BBPBBOAPCHN, NJKBLCBBANC AGHJLKKAHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x8F99A0", Offset = "0x8F8BA0", VA = "0x1808F99A0")]
		public void JECLAHCMAJP(Entity BBPBBOAPCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal class HGBJPNIMKNA : DJEPEGBCKPN
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public JHGKIIINABA GGMNJIEOHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x8729D0", Offset = "0x871BD0", VA = "0x1808729D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JHGKIIINABA);
		}
		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x872B80", Offset = "0x871D80", VA = "0x180872B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public JHGKIIINABA EAMPCIGKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x872CC0", Offset = "0x871EC0", VA = "0x180872CC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(JHGKIIINABA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x872E10", Offset = "0x872010", VA = "0x180872E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public JHGKIIINABA HDCIIBLABIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x872BE0", Offset = "0x871DE0", VA = "0x180872BE0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(JHGKIIINABA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x872880", Offset = "0x871A80", VA = "0x180872880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public JHGKIIINABA PCDOPEDANNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x8726C0", Offset = "0x8718C0", VA = "0x1808726C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JHGKIIINABA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x872AA0", Offset = "0x871CA0", VA = "0x180872AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public JHGKIIINABA GHFHKKJLCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x872A30", Offset = "0x871C30", VA = "0x180872A30", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(JHGKIIINABA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x872C50", Offset = "0x871E50", VA = "0x180872C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public JHGKIIINABA FBBJGIAPHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x872E80", Offset = "0x872080", VA = "0x180872E80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(JHGKIIINABA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x872730", Offset = "0x871930", VA = "0x180872730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public JHGKIIINABA LLECEMBJBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x872DA0", Offset = "0x871FA0", VA = "0x180872DA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(JHGKIIINABA);
		}
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x872B10", Offset = "0x871D10", VA = "0x180872B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public JHGKIIINABA OGKENBHPFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x872D30", Offset = "0x871F30", VA = "0x180872D30", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(JHGKIIINABA);
		}
		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x872EF0", Offset = "0x8720F0", VA = "0x180872EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public JHGKIIINABA ICKIBICMCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x872960", Offset = "0x871B60", VA = "0x180872960", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(JHGKIIINABA);
		}
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x872810", Offset = "0x871A10", VA = "0x180872810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public JHGKIIINABA HMPHNJEFCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x8727A0", Offset = "0x8719A0", VA = "0x1808727A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(JHGKIIINABA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x8728F0", Offset = "0x871AF0", VA = "0x1808728F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000931")]
	[Cpp2IlInjected.Address(RVA = "0x872F60", Offset = "0x872160", VA = "0x180872F60")]
	public HGBJPNIMKNA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[EJLOOKEAJML(HNJEFABFMIP.Prefabs)]
	[CLDGIFMABHG(typeof(ObjectPrefabCreationService), new string[] { })]
	[OCLKOGGMIFL(typeof(EGHMCKEACDK))]
	internal sealed class ObjectPrefabCreationService : PMOCCIAIAEL, GFHKHHPFFGF, GOKNGONBKFG, AIOPJLICFNI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private EGHMCKEACDK DDCODOIGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private JIIEBLBHCJD FADPCFKDAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private JHJIBOLNNJM MFKBMJBGEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private ObjectNetworkToLocalMapService NKFKKMPLGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private ObjectLifecycleService KDKALCDIKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private ObjectPrefabs ACNDAIINMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private FOGNOFJLJHO ILBDPCAAHPD;

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public int BFNKIKJHPAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000945")]
			[Cpp2IlInjected.Address(RVA = "0x8FA380", Offset = "0x8F9580", VA = "0x1808FA380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "4")]
		public void JFNNIMEOELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x8F9EF0", Offset = "0x8F90F0", VA = "0x1808F9EF0", Slot = "5")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x8F9CE0", Offset = "0x8F8EE0", VA = "0x1808F9CE0", Slot = "6")]
		public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x8F9E40", Offset = "0x8F9040", VA = "0x1808F9E40", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x8FA250", Offset = "0x8F9450", VA = "0x1808FA250")]
		private void NFJHANKBIEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x8FA540", Offset = "0x8F9740", VA = "0x1808FA540")]
		public void NGMICGCKNAF(bool JCMDBKNCKJK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x8FA250", Offset = "0x8F9450", VA = "0x1808FA250")]
		private void HNECLMLOBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x8FA040", Offset = "0x8F9240", VA = "0x1808FA040")]
		public Entity FFKFCGHMFHE(FNCBEEHJHBJ FKFNLDMHBOL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0D0", Offset = "0x8F92D0", VA = "0x1808FA0D0")]
		public Entity FFKFCGHMFHE(FNCBEEHJHBJ FKFNLDMHBOL, NJKBLCBBANC AGHJLKKAHGN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA610", Offset = "0x8F9810", VA = "0x1808FA610")]
		public Entity NOFEFNJLLIK(FNCBEEHJHBJ FKFNLDMHBOL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA280", Offset = "0x8F9480", VA = "0x1808FA280")]
		public Entity IMEOGHLKMDG(NJKBLCBBANC AGHJLKKAHGN, FNCBEEHJHBJ FKFNLDMHBOL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA040", Offset = "0x8F9240", VA = "0x1808FA040")]
		public Entity FNNCFOFKCAK(FNCBEEHJHBJ FKFNLDMHBOL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9E00", Offset = "0x8F9000", VA = "0x1808F9E00")]
		public Entity DFEDBANKKAM()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9D70", Offset = "0x8F8F70", VA = "0x1808F9D70")]
		public Entity CHKJCDHIKDL(HLDDLEKEHIF BGMCKNGNOJI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1C0", Offset = "0x8F93C0", VA = "0x1808FA1C0")]
		public Entity HCDONOBCLKM(HCEPBAEMJHI BGMCKNGNOJI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x8FA080", Offset = "0x8F9280", VA = "0x1808FA080")]
		public NativeArray<(DHOEKPEGHDF, DHOEKPEGHDF)> FFKFCGHMFHE(NativeArray<DHOEKPEGHDF> DAIKCJJNNID, Allocator MKFODJKMOCC)
		{
			return default(NativeArray<(DHOEKPEGHDF, DHOEKPEGHDF)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x8FA170", Offset = "0x8F9370", VA = "0x1808FA170")]
		public IEnumerable<FNCBEEHJHBJ> GCGIMCGNFGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4E0", Offset = "0x8F96E0", VA = "0x1808FA4E0")]
		public EntityArchetype MAIBJDPDOCJ(FNCBEEHJHBJ FKFNLDMHBOL)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x8FA320", Offset = "0x8F9520", VA = "0x1808FA320")]
		public Entity JCNCGBLDEAE(FNCBEEHJHBJ FKFNLDMHBOL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3D0", Offset = "0x8F95D0", VA = "0x1808FA3D0")]
		private Entity KJECHFAJHPI(FNCBEEHJHBJ FKFNLDMHBOL, NJKBLCBBANC AGHJLKKAHGN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ObjectPrefabCreationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[EJLOOKEAJML(HNJEFABFMIP.Prefabs)]
	internal class ObjectPrefabs : DOANLPNCIGP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200015C")]
		[CompilerGenerated]
		private sealed class OGIIDGGFGFN : IEnumerable<(HLDDLEKEHIF, FNCBEEHJHBJ)>, IEnumerable, IEnumerator<(HLDDLEKEHIF, FNCBEEHJHBJ)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private (HLDDLEKEHIF primitiveType, FNCBEEHJHBJ prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700010E")]
			private (HLDDLEKEHIF, FNCBEEHJHBJ) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000961")]
				[Cpp2IlInjected.Address(RVA = "0x8F5410", Offset = "0x8F4610", VA = "0x1808F5410", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((HLDDLEKEHIF, FNCBEEHJHBJ));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000963")]
				[Cpp2IlInjected.Address(RVA = "0x8F5470", Offset = "0x8F4670", VA = "0x1808F5470", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600095E")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
			[DebuggerHidden]
			public OGIIDGGFGFN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095F")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000960")]
			[Cpp2IlInjected.Address(RVA = "0x8F5280", Offset = "0x8F4480", VA = "0x1808F5280", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0x8F5420", Offset = "0x8F4620", VA = "0x1808F5420", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0x8F5370", Offset = "0x8F4570", VA = "0x1808F5370", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(HLDDLEKEHIF, FNCBEEHJHBJ)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0x8F5370", Offset = "0x8F4570", VA = "0x1808F5370", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private readonly World DDCODOIGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private readonly Dictionary<FNCBEEHJHBJ, Entity> ACNDAIINMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private readonly Dictionary<FNCBEEHJHBJ, EntityArchetype> CNKCIANFCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private readonly HGBJPNIMKNA FDINOBIDHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private readonly Dictionary<HLDDLEKEHIF, FNCBEEHJHBJ> HFNHLNNJHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private readonly Dictionary<HCEPBAEMJHI, FNCBEEHJHBJ> AIIGIFLPLEI;

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		private DJEPEGBCKPN JHGFPPHBAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public int NAIIACDHEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0x8FACE0", Offset = "0x8F9EE0", VA = "0x1808FACE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public EntityManager POMAKGKDHPN
		{
			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0x8FB600", Offset = "0x8FA800", VA = "0x1808FB600")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB670", Offset = "0x8FA870", VA = "0x1808FB670")]
		public ObjectPrefabs(World DDCODOIGKNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA740", Offset = "0x8F9940", VA = "0x1808FA740")]
		private void BEDKOBPPJIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEB0", Offset = "0x8FA0B0", VA = "0x1808FAEB0")]
		internal IEnumerable<Type> EGEMLKPADBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB170", Offset = "0x8FA370", VA = "0x1808FB170")]
		internal FDLFCKKMNKI KPMPJBLLCHM(Type BGMCKNGNOJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x8FA940", Offset = "0x8F9B40", VA = "0x1808FA940")]
		internal void BGEKPBFGELM(FDLFCKKMNKI CNIKMIOLBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1E0", Offset = "0x8FA3E0", VA = "0x1808FB1E0")]
		internal void LIJBKJHFGFO(FNCBEEHJHBJ FKFNLDMHBOL, JHGKIIINABA PKMKHFNHEPL, NENAGAMIMCB GHDOIEIGMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4D0", Offset = "0x8FA6D0", VA = "0x1808FB4D0")]
		private void NPIANEKLFND(FNCBEEHJHBJ FKFNLDMHBOL, JHGKIIINABA ECILHPMNAEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x8FB440", Offset = "0x8FA640", VA = "0x1808FB440")]
		public void NGMICGCKNAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3E0", Offset = "0x8FA5E0", VA = "0x1808FB3E0")]
		public EntityArchetype MAIBJDPDOCJ(FNCBEEHJHBJ FKFNLDMHBOL)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x8FB460", Offset = "0x8FA660", VA = "0x1808FB460", Slot = "4")]
		[IteratorStateMachine(typeof(OGIIDGGFGFN))]
		public IEnumerable<(HLDDLEKEHIF, FNCBEEHJHBJ)> NNMJKNDGEPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEE0", Offset = "0x8FA0E0", VA = "0x1808FAEE0")]
		public Entity FFKFCGHMFHE(FNCBEEHJHBJ FKFNLDMHBOL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x8FA680", Offset = "0x8F9880", VA = "0x1808FA680")]
		public FNCBEEHJHBJ BAALBPNDGHP(HCEPBAEMJHI BGMCKNGNOJI)
		{
			return default(FNCBEEHJHBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6E0", Offset = "0x8F98E0", VA = "0x1808FA6E0")]
		public FNCBEEHJHBJ BAALBPNDGHP(HLDDLEKEHIF BGMCKNGNOJI)
		{
			return default(FNCBEEHJHBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD30", Offset = "0x8F9F30", VA = "0x1808FAD30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFC0", Offset = "0x8FA1C0", VA = "0x1808FAFC0")]
		public IEnumerable<FNCBEEHJHBJ> GCGIMCGNFGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB010", Offset = "0x8FA210", VA = "0x1808FB010")]
		public Entity JCNCGBLDEAE(FNCBEEHJHBJ FKFNLDMHBOL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB070", Offset = "0x8FA270", VA = "0x1808FB070")]
		internal Entity JIKKFOLMPFF(FNCBEEHJHBJ FKFNLDMHBOL)
		{
			return default(Entity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CLDGIFMABHG(typeof(PropertyEventCallbacksService), new string[] { })]
	[EJLOOKEAJML(HNJEFABFMIP.Callbacks)]
	public class PropertyEventCallbacksService : GOKNGONBKFG
	{
		[Cpp2IlInjected.Token(Token = "0x200015E")]
		private struct GPEKOKFMPFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public COGCOKFBFJD ELMGCHGCEJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public Type BGMCKNGNOJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public int DFCIFDODMGE;
		}

		[Cpp2IlInjected.Token(Token = "0x200015F")]
		private struct KLAMDNGICJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public GPEKOKFMPFM[] OMFFMMHBAGP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000160")]
		public delegate void COGCOKFBFJD(Entity BBPBBOAPCHN, CAEHPHOEGJK FMBNLFNGBEI, JFFJOIBOPJP DDKOGDKKCAE, JFFJOIBOPJP FONEHOKCGLG);

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private readonly Dictionary<CAEHPHOEGJK, COGCOKFBFJD> HMLMKJCMAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private readonly Dictionary<int, KLAMDNGICJG> BLECCCGCHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private FJGGKJJCIJE OMFFMMHBAGP;

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action OOOJJPDOMBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x8FF960", Offset = "0x8FEB60", VA = "0x1808FF960")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000967")]
			[Cpp2IlInjected.Address(RVA = "0x900660", Offset = "0x8FF860", VA = "0x180900660")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action DPOCCLCLAEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0x8FFE60", Offset = "0x8FF060", VA = "0x1808FFE60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000969")]
			[Cpp2IlInjected.Address(RVA = "0x8FFF60", Offset = "0x8FF160", VA = "0x1808FFF60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF00", Offset = "0x8FF100", VA = "0x1808FFF00", Slot = "4")]
		public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x9004F0", Offset = "0x8FF6F0", VA = "0x1809004F0")]
		public void NKCPCCNOLCN(CAEHPHOEGJK FMBNLFNGBEI, COGCOKFBFJD ELMGCHGCEJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x8FF640", Offset = "0x8FE840", VA = "0x1808FF640")]
		public void ABBJGDOEHIP(CAEHPHOEGJK FMBNLFNGBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x8FF720", Offset = "0x8FE920", VA = "0x1808FF720")]
		internal void ABKGHFNJBAE(KFJGJDHPGIJ IBBEGDPIJBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x900000", Offset = "0x8FF200", VA = "0x180900000")]
		private void JCKMCFBLALD(KFJGJDHPGIJ IBBEGDPIJBO, int NIDJEPOLHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x8FFAE0", Offset = "0x8FECE0", VA = "0x1808FFAE0")]
		private void CJHAPIDCPLL(PPDCFKFFIMN HOBAGAEEOGL, PCMBKAMCBOF DHJPFJFOJIE, GPEKOKFMPFM HEAOALDAFJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x8FFD10", Offset = "0x8FEF10", VA = "0x1808FFD10")]
		private KLAMDNGICJG COPFDDNKFDA(PPDCFKFFIMN HOBAGAEEOGL, PCMBKAMCBOF DHJPFJFOJIE)
		{
			return default(KLAMDNGICJG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x8FFA00", Offset = "0x8FEC00", VA = "0x1808FFA00")]
		private GPEKOKFMPFM CDGJPJOBBAP(KLAMDNGICJG JMCKGOOADHK, PPDCFKFFIMN HOBAGAEEOGL, PCMBKAMCBOF DHJPFJFOJIE)
		{
			return default(GPEKOKFMPFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0x900750", Offset = "0x8FF950", VA = "0x180900750")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
[CLDGIFMABHG(typeof(ANNKKHJFDMC), new string[] { })]
public class KBCFNFGHKEL : GOKNGONBKFG, AIOPJLICFNI, ANNKKHJFDMC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class LAKEIDFCKIL : IEnumerable<IDBDPBMBNJI>, IEnumerable, IEnumerator<IDBDPBMBNJI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private IDBDPBMBNJI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public KBCFNFGHKEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private NGNKJMLJHGG spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public NGNKJMLJHGG <>3__spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		private IDBDPBMBNJI System.Collections.Generic.IEnumerator<RecRoom.Components.SplinePoint>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x7EA030", Offset = "0x7E9230", VA = "0x1807EA030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(IDBDPBMBNJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0x880010", Offset = "0x87F210", VA = "0x180880010", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x880060", Offset = "0x87F260", VA = "0x180880060")]
		[DebuggerHidden]
		public LAKEIDFCKIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x87FD90", Offset = "0x87EF90", VA = "0x18087FD90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x87FFC0", Offset = "0x87F1C0", VA = "0x18087FFC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x87FF10", Offset = "0x87F110", VA = "0x18087FF10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IDBDPBMBNJI> System.Collections.Generic.IEnumerable<RecRoom.Components.SplinePoint>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x87FF10", Offset = "0x87F110", VA = "0x18087FF10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private EGHMCKEACDK DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private PEFFADFEEGI GOOEPEJKJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private ObjectPrefabCreationService ACNDAIINMFB;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private EntityManager POMAKGKDHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x87BE90", Offset = "0x87B090", VA = "0x18087BE90")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private IOOAJLENKLJ CIDDIKGGDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x87B3E0", Offset = "0x87A5E0", VA = "0x18087B3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x87B360", Offset = "0x87A560", VA = "0x18087B360", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x87AFE0", Offset = "0x87A1E0", VA = "0x18087AFE0", Slot = "5")]
	public void BIJMKKGJFDP(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x87B160", Offset = "0x87A360", VA = "0x18087B160", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x87BC60", Offset = "0x87AE60", VA = "0x18087BC60")]
	private void MJLJLHBGPBB(Entity ADOANKFPOKL, in JFFJOIBOPJP OENCJDKHNKI, in JFFJOIBOPJP DNIHHNBJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x87B0A0", Offset = "0x87A2A0", VA = "0x18087B0A0", Slot = "12")]
	public NGNKJMLJHGG DFEDBANKKAM()
	{
		return default(NGNKJMLJHGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x87B920", Offset = "0x87AB20", VA = "0x18087B920", Slot = "6")]
	public IDBDPBMBNJI LGBDNHDKFMH(NGNKJMLJHGG DADCBCFIEDP, [Optional] Vector3? BCCJFEBGGPE, [Optional] Quaternion? PAOOIKIKMBJ, [Optional] Vector3? HGMELPNGMLB)
	{
		return default(IDBDPBMBNJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x87B1F0", Offset = "0x87A3F0", VA = "0x18087B1F0", Slot = "13")]
	public IDBDPBMBNJI EAMAKHFCNJA(NGNKJMLJHGG DADCBCFIEDP, int MJNAIOAAGCG, [Optional] Vector3? BCCJFEBGGPE, [Optional] Quaternion? PAOOIKIKMBJ, [Optional] Vector3? HGMELPNGMLB)
	{
		return default(IDBDPBMBNJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x87B240", Offset = "0x87A440", VA = "0x18087B240", Slot = "7")]
	public IDBDPBMBNJI ECDMOLFJOIM(NGNKJMLJHGG DADCBCFIEDP, int MJNAIOAAGCG)
	{
		return default(IDBDPBMBNJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x87B700", Offset = "0x87A900", VA = "0x18087B700", Slot = "14")]
	public void JIJOEDHHDAG(NGNKJMLJHGG DADCBCFIEDP, IDBDPBMBNJI IOBBJNEMCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x87B4C0", Offset = "0x87A6C0", VA = "0x18087B4C0", Slot = "8")]
	public void ICLFKGDDJBD(NGNKJMLJHGG DADCBCFIEDP, int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0x87B790", Offset = "0x87A990", VA = "0x18087B790", Slot = "15")]
	public void KLDHCIEHEMM(NGNKJMLJHGG DADCBCFIEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x87B660", Offset = "0x87A860", VA = "0x18087B660", Slot = "9")]
	public int IPBBGICLLEH(NGNKJMLJHGG DADCBCFIEDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x87B430", Offset = "0x87A630", VA = "0x18087B430", Slot = "10")]
	[IteratorStateMachine(typeof(LAKEIDFCKIL))]
	public IEnumerable<IDBDPBMBNJI> IBAAEFHHBBD(NGNKJMLJHGG DADCBCFIEDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x87AF50", Offset = "0x87A150", VA = "0x18087AF50")]
	private bool BHHJKFKGMAI(NGNKJMLJHGG DADCBCFIEDP, out NativeArray<Entity> DKJCFPOBMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x87BEE0", Offset = "0x87B0E0", VA = "0x18087BEE0")]
	private NativeArray<Entity> PFCOACNGGMP(NGNKJMLJHGG DADCBCFIEDP)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public KBCFNFGHKEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[CLDGIFMABHG(typeof(AGKEGIGJACC), new string[] { })]
internal sealed class AGKEGIGJACC : GOKNGONBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private EGHMCKEACDK DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private TransformOwnershipPhase EIMDLFDFABL;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private EDJHMIKNCNB IELCOFCMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0xA45B90", Offset = "0xA44D90", VA = "0x180A45B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0xA45B10", Offset = "0xA44D10", VA = "0x180A45B10", Slot = "4")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0xA45EA0", Offset = "0xA450A0", VA = "0x180A45EA0")]
	public void PALBPFAGNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0xA45BE0", Offset = "0xA44DE0", VA = "0x180A45BE0")]
	public void MJBOGHDBCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000996")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public AGKEGIGJACC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
[DefaultMember("Item")]
public struct BKILPLMJGMF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private T[] ADIGGFBANFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private int IPOIAMFIOLH;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public int IPIKHFMIGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x758560", Offset = "0x757760", VA = "0x180758560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public T LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x133E740", Offset = "0x133D940", VA = "0x18133E740")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Span<T> LANCFIEHLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x42046D0", Offset = "0x42038D0", VA = "0x1842046D0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool GPCFLNCLBKI
	{
		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0xB514B0", Offset = "0xB506B0", VA = "0x180B514B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x4204770", Offset = "0x4203970", VA = "0x184204770")]
	public BKILPLMJGMF(int IPOIAMFIOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x4204560", Offset = "0x4203760", VA = "0x184204560")]
	public int CHJPILKFEHL(T ADBNEBBHMOP, int FLFAMDBICFJ, int AEKEPEKODMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600099D")]
	[Cpp2IlInjected.Address(RVA = "0x4204610", Offset = "0x4203810", VA = "0x184204610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
[DefaultMember("Item")]
public struct DIJNENGMLLD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private global::BKILPLMJGMF<T> ADIGGFBANFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private int IPOIAMFIOLH;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public T LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x46CB7F0", Offset = "0x46CA9F0", VA = "0x1846CB7F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public int IPIKHFMIGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x62D550", Offset = "0x62C750", VA = "0x18062D550")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x46CB890", Offset = "0x46CAA90", VA = "0x1846CB890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public int DAKMKNJEHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x46CA8D0", Offset = "0x46C9AD0", VA = "0x1846CA8D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x46CA3C0", Offset = "0x46C95C0", VA = "0x1846CA3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool GPCFLNCLBKI
	{
		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x46CAFA0", Offset = "0x46CA1A0", VA = "0x1846CAFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Span<T> LANCFIEHLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x46CB350", Offset = "0x46CA550", VA = "0x1846CB350")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x46CB940", Offset = "0x46CAB40", VA = "0x1846CB940")]
	public DIJNENGMLLD(int IPOIAMFIOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x46CAF50", Offset = "0x46CA150", VA = "0x1846CAF50")]
	public T ILALFDEJMKL(int MJNAIOAAGCG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x46CA410", Offset = "0x46C9610", VA = "0x1846CA410")]
	public void DCCPOOEKCLF(T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x46CB630", Offset = "0x46CA830", VA = "0x1846CB630")]
	public void NIKGOMAFBFK(Span<T> MDBHJOENILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x46CB240", Offset = "0x46CA440", VA = "0x1846CB240")]
	public void KAGEPJABGKM(T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x46CA4D0", Offset = "0x46C96D0", VA = "0x1846CA4D0")]
	private void EGJBNGCKFIP(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x46CA900", Offset = "0x46C9B00", VA = "0x1846CA900")]
	public void HBOOAGEADLM(Span<T> EHBKMHADDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x46CB790", Offset = "0x46CA990", VA = "0x1846CB790")]
	public void NMGBNKHMLME(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x46CAD40", Offset = "0x46C9F40", VA = "0x1846CAD40")]
	public void IEDCJBDNDDB(int GNPEAGINONI, int FOKHGDFDAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x46CA870", Offset = "0x46C9A70", VA = "0x1846CA870")]
	public void GEKNCFKGFNI(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0x46CA670", Offset = "0x46C9870", VA = "0x1846CA670")]
	public void GEEPGDEEPPC(int GNPEAGINONI, int FOKHGDFDAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0x46CB420", Offset = "0x46CA620", VA = "0x1846CB420")]
	public void LNMCOBHFAAF(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0x46CAFE0", Offset = "0x46CA1E0", VA = "0x1846CAFE0")]
	public void JMBGMGALOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B2")]
	[Cpp2IlInjected.Address(RVA = "0x46CA330", Offset = "0x46C9530", VA = "0x1846CA330")]
	public int CHJPILKFEHL(T ADBNEBBHMOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x46CAAC0", Offset = "0x46C9CC0", VA = "0x1846CAAC0")]
	public bool HIPEHFAIGLD(T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x46CA480", Offset = "0x46C9680", VA = "0x1846CA480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x46CB8E0", Offset = "0x46CAAE0", VA = "0x1846CB8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x46CA1B0", Offset = "0x46C93B0", VA = "0x1846CA1B0")]
	public static Span<T> BKALKAPLPLL(global::DIJNENGMLLD<T> MDBHJOENILE)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x46CAC30", Offset = "0x46C9E30", VA = "0x1846CAC30")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void IDKLBMIHOCC(int ADBNEBBHMOP, int IPOIAMFIOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void NGBAOMMNGFL(int IPOIAMFIOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B9")]
	[Cpp2IlInjected.Address(RVA = "0x46CB4E0", Offset = "0x46CA6E0", VA = "0x1846CB4E0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void NGBAOMMNGFL(int IPOIAMFIOLH, int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BA")]
	[Cpp2IlInjected.Address(RVA = "0x46CA220", Offset = "0x46C9420", VA = "0x1846CA220")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CCMGJHDOLJM(int ADBNEBBHMOP, int IPOIAMFIOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x46CB0A0", Offset = "0x46CA2A0", VA = "0x1846CB0A0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void JPDAPKBBNGE(int GNPEAGINONI, int FOKHGDFDAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x46CAB20", Offset = "0x46C9D20", VA = "0x1846CAB20")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void HKBDCAPMDNF(int ADBNEBBHMOP, int IPOIAMFIOLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public struct GFIODLFGCBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private const int EFMDMMGPKJG = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private NativeList<Entity> JEFMGPHNDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private TransformAccessArray AMIFBGIBKJA;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0xA52160", Offset = "0xA51360", VA = "0x180A52160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public NativeList<Entity> LKKFOODKEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x88B000", Offset = "0x88A200", VA = "0x18088B000")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public TransformAccessArray HJACDNGKEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0xA52490", Offset = "0xA51690", VA = "0x180A52490")]
	public GFIODLFGCBC(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0xA521E0", Offset = "0xA513E0", VA = "0x180A521E0")]
	public Entity DMCIPIAFMEM(int MJNAIOAAGCG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C2")]
	[Cpp2IlInjected.Address(RVA = "0xA52400", Offset = "0xA51600", VA = "0x180A52400")]
	public Transform MLDEHACHCPK(int MJNAIOAAGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0xA523B0", Offset = "0xA515B0", VA = "0x180A523B0")]
	public void MKCHFELNHDH(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0xA52170", Offset = "0xA51370", VA = "0x180A52170")]
	public void CABNCNHNIPF(int GEGIDEHEEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0xA522E0", Offset = "0xA514E0", VA = "0x180A522E0")]
	public int KAGEPJABGKM(Transform EJOKPJGAPEO, Entity BBPBBOAPCHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0xA52410", Offset = "0xA51610", VA = "0x180A52410")]
	public int NMGBNKHMLME(int MJNAIOAAGCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0xA52230", Offset = "0xA51430", VA = "0x180A52230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0xA522A0", Offset = "0xA514A0", VA = "0x180A522A0")]
	private void HPMCFKLACGI(int FHPMJNICFAJ = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public class PMJHLCNENNA : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly PMJHLCNENNA HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0xBE64A0", Offset = "0xBE56A0", VA = "0x180BE64A0", Slot = "4")]
	public bool Equals(LinkedEntityGroup FMHEJMEECNK, LinkedEntityGroup EDNBLCPIBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0xBE64C0", Offset = "0xBE56C0", VA = "0x180BE64C0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup PBKPNJLDBOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public PMJHLCNENNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal class FJNPDLPEGLH
{
	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("DEBUG_BUILD")]
	public static void PFJKHBEAJEC(in Vector3 BCCJFEBGGPE, in Quaternion PAOOIKIKMBJ, in Vector3 HGMELPNGMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("DEBUG_BUILD")]
	public static void LEEMHICCPNK(in Vector3 KKONOAJGDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("DEBUG_BUILD")]
	public static void IOGGPBKBEKP(in Quaternion PAOOIKIKMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("DEBUG_BUILD")]
	public static void MNDILIHCGKP(in Vector3 IDODBLLACIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("DEBUG_BUILD")]
	public static void JNFEEAPDBFP(in Vector3 IDODBLLACIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("DEBUG_BUILD")]
	public static void IFIEMKBEMBK(in float PLFAFINCHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0xA510D0", Offset = "0xA502D0", VA = "0x180A510D0")]
	[Conditional("DEBUG_BUILD")]
	public static void AFLDIDPKNDB(in float3 ADBNEBBHMOP, string HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("DEBUG_BUILD")]
	public static void PEDDLFKJLHK(in float ADBNEBBHMOP, string HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0xA512A0", Offset = "0xA504A0", VA = "0x180A512A0")]
	[Conditional("DEBUG_BUILD")]
	public static void PEDDLFKJLHK(in Vector3 ADBNEBBHMOP, string HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0xA51340", Offset = "0xA50540", VA = "0x180A51340")]
	[Conditional("DEBUG_BUILD")]
	public static void PEDDLFKJLHK(in Quaternion ADBNEBBHMOP, string HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0xA51290", Offset = "0xA50490", VA = "0x180A51290")]
	[Conditional("DEBUG_BUILD")]
	public static void MCKECEPLLBF(in float ADBNEBBHMOP, string HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0xA51170", Offset = "0xA50370", VA = "0x180A51170")]
	[Conditional("DEBUG_BUILD")]
	public static void MCKECEPLLBF(in Vector3 ADBNEBBHMOP, string HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xA51210", Offset = "0xA50410", VA = "0x180A51210")]
	[Conditional("DEBUG_BUILD")]
	public static void MCKECEPLLBF(in Quaternion ADBNEBBHMOP, string HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public FJNPDLPEGLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public struct BNPOJNEDCOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public Entity BBPBBOAPCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public Entity GDGMBLIDIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public Entity NHDMOENBBDB;

	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0xA47E50", Offset = "0xA47050", VA = "0x180A47E50")]
	public BNPOJNEDCOI(Entity BBPBBOAPCHN, Entity GDGMBLIDIJF, Entity NHDMOENBBDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0xA47DF0", Offset = "0xA46FF0", VA = "0x180A47DF0")]
	public static BNPOJNEDCOI BKALKAPLPLL((Entity entity, Entity oldParent, Entity newParent) PLFLHMPJEKJ)
	{
		return default(BNPOJNEDCOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0xA47E30", Offset = "0xA47030", VA = "0x180A47E30")]
	public void LBLAKPOPNOG(out Entity BBPBBOAPCHN, out Entity GDGMBLIDIJF, out Entity NHDMOENBBDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public struct CDPFCBNHAID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public Entity BBPBBOAPCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public Entity ENAGHEEPLJN;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0xA48E10", Offset = "0xA48010", VA = "0x180A48E10")]
	public CDPFCBNHAID(Entity BBPBBOAPCHN, Entity ENAGHEEPLJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0xA48DD0", Offset = "0xA47FD0", VA = "0x180A48DD0")]
	public static CDPFCBNHAID BKALKAPLPLL((Entity entity, Entity parent) PLFLHMPJEKJ)
	{
		return default(CDPFCBNHAID);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0xA48E00", Offset = "0xA48000", VA = "0x180A48E00")]
	public void LBLAKPOPNOG(out Entity BBPBBOAPCHN, out Entity ENAGHEEPLJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
public struct BLHJGMHLGJE<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private GCHandle BEDKMKLJIGF;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool NMOFAIHCIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0xA4FE80", Offset = "0xA4F080", VA = "0x180A4FE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public T MDDADGNJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x4205500", Offset = "0x4204700", VA = "0x184205500")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x4205440", Offset = "0x4204640", VA = "0x184205440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x42055A0", Offset = "0x42047A0", VA = "0x1842055A0")]
	public BLHJGMHLGJE(T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E5")]
	[Cpp2IlInjected.Address(RVA = "0x4205410", Offset = "0x4204610", VA = "0x184205410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CIKCBMNIMCI))]
public sealed class ACALBAJBCFP : DFBCIIDMPCM
{
	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public ACALBAJBCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CIKCBMNIMCI))]
[UpdateAfter(typeof(ACALBAJBCFP))]
public sealed class MMMPNLNGJGF : PreSerializeRemoveEntities
{
	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0x881C90", Offset = "0x880E90", VA = "0x180881C90")]
	public MMMPNLNGJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CIKCBMNIMCI))]
[UpdateAfter(typeof(MMMPNLNGJGF))]
public sealed class NGLLCCABGKP : NAFBPLLBCDJ
{
	[Cpp2IlInjected.Token(Token = "0x60009EA")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public NGLLCCABGKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EB")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(EEJGANBHFAJ))]
public class JOHDBGBLKFO : HJBHPGDJJJJ
{
	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public JOHDBGBLKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x878500", Offset = "0x877700", VA = "0x180878500", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(EEJGANBHFAJ))]
public class IHMPBDIECJM : KABBJIECBFB
{
	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public IHMPBDIECJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(EEJGANBHFAJ))]
public class ABAKMJKMKBL : HCALCOGALML
{
	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x8758C0", Offset = "0x874AC0", VA = "0x1808758C0")]
	public ABAKMJKMKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0xA441B0", Offset = "0xA433B0", VA = "0x180A441B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(KHIGGCEACOJ))]
public sealed class NJKGOMBPCLC : DIBCLFGMLJJ
{
	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x874D70", Offset = "0x873F70", VA = "0x180874D70")]
	public NJKGOMBPCLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x874D60", Offset = "0x873F60", VA = "0x180874D60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(ILDMMPBEAJK))]
internal class EACAABABNNF : DestroyLocalObjects
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0xA4D730", Offset = "0xA4C930", VA = "0x180A4D730")]
	public EACAABABNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(EACAABABNNF))]
[UpdateInGroup(typeof(ILDMMPBEAJK))]
internal class KHACIAFCPIF : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public KHACIAFCPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CHGKHHCOBGI))]
internal class GOOAPMMGPFG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public GOOAPMMGPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(GOOAPMMGPFG))]
[UpdateInGroup(typeof(CHGKHHCOBGI))]
internal class MFDEHEFAKOI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public MFDEHEFAKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CHGKHHCOBGI))]
[UpdateAfter(typeof(MFDEHEFAKOI))]
internal class PGONDBGFDDG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public PGONDBGFDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(PGONDBGFDDG))]
internal class EEEMBFLKEKM : NAOGOACMBKN
{
	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0xA4E900", Offset = "0xA4DB00", VA = "0x180A4E900")]
	public EEEMBFLKEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0xA4E8F0", Offset = "0xA4DAF0", VA = "0x180A4E8F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(PGONDBGFDDG))]
internal class ICEJEJOLEFD : CHFNAENAIMN
{
	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x8748D0", Offset = "0x873AD0", VA = "0x1808748D0")]
	public ICEJEJOLEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x8748C0", Offset = "0x873AC0", VA = "0x1808748C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(PGONDBGFDDG))]
internal class IFEOKPIGGHN : CMGLABGFAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0x874D50", Offset = "0x873F50", VA = "0x180874D50")]
	public IFEOKPIGGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x874D40", Offset = "0x873F40", VA = "0x180874D40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(MFDEHEFAKOI))]
internal sealed class INDICIMELFJ : OPADFHBPHEH
{
	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x8758C0", Offset = "0x874AC0", VA = "0x1808758C0")]
	public INDICIMELFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x875EC0", Offset = "0x8750C0", VA = "0x180875EC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(INDICIMELFJ))]
[UpdateInGroup(typeof(MFDEHEFAKOI))]
internal sealed class IHLEONNOCOP : DIBCLFGMLJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x874D70", Offset = "0x873F70", VA = "0x180874D70")]
	public IHLEONNOCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x874D60", Offset = "0x873F60", VA = "0x180874D60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(KHACIAFCPIF))]
internal sealed class FIONOAPGPNF : CGJGEIIPADH
{
	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0xA48F80", Offset = "0xA48180", VA = "0x180A48F80")]
	public FIONOAPGPNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0xA48F00", Offset = "0xA48100", VA = "0x180A48F00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(KHACIAFCPIF))]
internal sealed class OHBFKDJMNML : RegisterTransforms
{
	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x884C30", Offset = "0x883E30", VA = "0x180884C30")]
	public OHBFKDJMNML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x884C20", Offset = "0x883E20", VA = "0x180884C20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(KHACIAFCPIF))]
[UpdateAfter(typeof(OHBFKDJMNML))]
internal sealed class FJNLNDIJDJC : CopyTransformDataFromGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0xA51070", Offset = "0xA50270", VA = "0x180A51070")]
	public FJNLNDIJDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CEFMPKHDPCN))]
internal class DNPCMMCAKKA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public DNPCMMCAKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CEFMPKHDPCN))]
internal class AGDADOBJCMJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public AGDADOBJCMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[CMNCMGDNKIL]
[ExecuteAlways]
[UpdateInGroup(typeof(CEFMPKHDPCN))]
[UpdateAfter(typeof(DNPCMMCAKKA))]
internal sealed class DAMGAOIKNJF : GODBNDJPCCG
{
	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public DAMGAOIKNJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[ExecuteAlways]
[CMNCMGDNKIL]
[UpdateAfter(typeof(DAMGAOIKNJF))]
[UpdateInGroup(typeof(CEFMPKHDPCN))]
internal sealed class KOEIHIFABKH : GPOIDAICKPD
{
	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x8758C0", Offset = "0x874AC0", VA = "0x1808758C0")]
	public KOEIHIFABKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(DAMGAOIKNJF))]
[UpdateInGroup(typeof(CEFMPKHDPCN))]
internal sealed class LEBGDMCFPLE : MDEKGFPLBJH
{
	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public LEBGDMCFPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
[AlwaysUpdateSystem]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(AGDADOBJCMJ))]
internal sealed class LANJOAHBLPH : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override ApplyPropertyDifferences PDINOLMPJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x880090", Offset = "0x87F290", VA = "0x180880090", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x8800E0", Offset = "0x87F2E0", VA = "0x1808800E0")]
	public LANJOAHBLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(LANJOAHBLPH))]
[UpdateInGroup(typeof(AGDADOBJCMJ))]
internal sealed class LBLHDKILEEE : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x880140", Offset = "0x87F340", VA = "0x180880140")]
	public LBLHDKILEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(LANJOAHBLPH))]
[UpdateInGroup(typeof(AGDADOBJCMJ))]
internal sealed class PEFIIBFDOGL : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x8758C0", Offset = "0x874AC0", VA = "0x1808758C0")]
	public PEFIIBFDOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(AGDADOBJCMJ))]
[UpdateAfter(typeof(PEFIIBFDOGL))]
internal sealed class FCONJOGFHDF : EnqueuePropertyDifferenceToNetwork
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	protected override ComputePropertyDifferences DPLINEAEBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0xA4FBC0", Offset = "0xA4EDC0", VA = "0x180A4FBC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0xA4FC10", Offset = "0xA4EE10", VA = "0x180A4FC10")]
	public FCONJOGFHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(FCONJOGFHDF))]
[UpdateInGroup(typeof(AGDADOBJCMJ))]
internal sealed class KLEAMBMNECP : FGFCDHKEKED
{
	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x87E600", Offset = "0x87D800", VA = "0x18087E600")]
	public KLEAMBMNECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(DNPCMMCAKKA))]
internal sealed class KGAHPKCMHDA : CopyTransformDataToGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x87C270", Offset = "0x87B470", VA = "0x18087C270")]
	public KGAHPKCMHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(DNPCMMCAKKA))]
internal sealed class IKMLMCDHBJC : CPJLLCMJMBP
{
	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x8758C0", Offset = "0x874AC0", VA = "0x1808758C0")]
	public IKMLMCDHBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A27")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CHGKHHCOBGI))]
internal class CCGLNPFBBPE : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A28")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public CCGLNPFBBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CHGKHHCOBGI))]
[UpdateAfter(typeof(CCGLNPFBBPE))]
internal sealed class FLJKNMHJJCN : UpdateConnectableVisuals
{
	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0xA51570", Offset = "0xA50770", VA = "0x180A51570")]
	public FLJKNMHJJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0xA51560", Offset = "0xA50760", VA = "0x180A51560", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[ExecuteAlways]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CHGKHHCOBGI))]
[UpdateAfter(typeof(CCGLNPFBBPE))]
internal sealed class PMLEPOLILMB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public PMLEPOLILMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2D")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[ExecuteAlways]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(PMLEPOLILMB))]
internal sealed class KMBOAMAFIBG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public KMBOAMAFIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[CMNCMGDNKIL]
[ExecuteAlways]
[UpdateAfter(typeof(KMBOAMAFIBG))]
[UpdateInGroup(typeof(PMLEPOLILMB))]
internal sealed class EHPNDKHPAEO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A30")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public EHPNDKHPAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(EHPNDKHPAEO))]
internal sealed class FOAEFJLBALM : HBMIDPKICEC
{
	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public FOAEFJLBALM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0xA515D0", Offset = "0xA507D0", VA = "0x180A515D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(FOAEFJLBALM))]
[UpdateInGroup(typeof(EHPNDKHPAEO))]
internal sealed class NCNDJGDCLJN : DNGHLBFGHBL
{
	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x8758C0", Offset = "0x874AC0", VA = "0x1808758C0")]
	public NCNDJGDCLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x883CA0", Offset = "0x882EA0", VA = "0x180883CA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(EHPNDKHPAEO))]
[UpdateAfter(typeof(NCNDJGDCLJN))]
internal sealed class IHPKKNLAGFD : POPAFNDGOBB
{
	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public IHPKKNLAGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(EHPNDKHPAEO))]
[UpdateAfter(typeof(IHPKKNLAGFD))]
internal class CEPMLGAGKII : PhysicsSceneUpdateCollidersSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0xA48E20", Offset = "0xA48020", VA = "0x180A48E20")]
	public CEPMLGAGKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(KMBOAMAFIBG))]
internal sealed class PKHGNIFBCBI : SplineLocalBoundsSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0xBE6440", Offset = "0xBE5640", VA = "0x180BE6440")]
	public PKHGNIFBCBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CCGLNPFBBPE))]
internal sealed class NCPNAPHLNDH : IOJCHKDEMEF
{
	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640")]
	public NCPNAPHLNDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(NCPNAPHLNDH))]
[UpdateInGroup(typeof(CCGLNPFBBPE))]
internal sealed class FJGOFFAPGCJ : L2PToL2WHierarchy
{
	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0xA51010", Offset = "0xA50210", VA = "0x180A51010")]
	public FJGOFFAPGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(NCPNAPHLNDH))]
[UpdateInGroup(typeof(CCGLNPFBBPE))]
internal sealed class PMLPLBLPOOK : HJNCMFBLIJM
{
	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x8758C0", Offset = "0x874AC0", VA = "0x1808758C0")]
	public PMLPLBLPOOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(CCGLNPFBBPE))]
[UpdateAfter(typeof(FJGOFFAPGCJ))]
[UpdateAfter(typeof(PMLPLBLPOOK))]
internal sealed class GGOJALFGOFP : BILFFJHONFE
{
	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public GGOJALFGOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(JCKDODADIKE))]
internal class DHHMFJDOIFF : LJEKEAGCOBL
{
	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x8758C0", Offset = "0x874AC0", VA = "0x1808758C0")]
	public DHHMFJDOIFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0xA4BE40", Offset = "0xA4B040", VA = "0x180A4BE40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(AFMLHAHJCAM))]
internal sealed class GBOPIEEPJOD : PNCJMMDJGLI
{
	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x8758C0", Offset = "0x874AC0", VA = "0x1808758C0")]
	public GBOPIEEPJOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0xA51F50", Offset = "0xA51150", VA = "0x180A51F50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(AFMLHAHJCAM))]
[UpdateAfter(typeof(GBOPIEEPJOD))]
internal class DBMIELONAPG : PostLoadInitializeEmbodiment
{
	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0xA4B9D0", Offset = "0xA4ABD0", VA = "0x180A4B9D0")]
	public DBMIELONAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0xA4B9C0", Offset = "0xA4ABC0", VA = "0x180A4B9C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[CMNCMGDNKIL]
[AlwaysUpdateSystem]
[UpdateAfter(typeof(DBMIELONAPG))]
[UpdateInGroup(typeof(AFMLHAHJCAM))]
internal sealed class ELEEOGOBDAH : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override ApplyPropertyDifferences PDINOLMPJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEB0", Offset = "0xA4E0B0", VA = "0x180A4EEB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0xA4EF00", Offset = "0xA4E100", VA = "0x180A4EF00")]
	public ELEEOGOBDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[CMNCMGDNKIL]
[UpdateInGroup(typeof(AFMLHAHJCAM))]
[UpdateAfter(typeof(ELEEOGOBDAH))]
internal sealed class JKOONAPAPLJ : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x878320", Offset = "0x877520", VA = "0x180878320")]
	public JKOONAPAPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[CMNCMGDNKIL]
[UpdateAfter(typeof(ELEEOGOBDAH))]
[UpdateInGroup(typeof(AFMLHAHJCAM))]
internal sealed class KEIJMHGMICF : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x8758C0", Offset = "0x874AC0", VA = "0x1808758C0")]
	public KEIJMHGMICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
[CLDGIFMABHG(typeof(KBFAPJDPNBI), new string[] { })]
public sealed class BKLLAOODKBK : KBFAPJDPNBI, GOKNGONBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private IBPGEALOLCI NDHHNKNFIHO;

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0xA47DA0", Offset = "0xA46FA0", VA = "0x180A47DA0", Slot = "5")]
	public void EMHHNLHFBIL(AMEKELGLMNH NHJMFHJKDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0xA47CC0", Offset = "0xA46EC0", VA = "0x180A47CC0")]
	public bool ANKEENHCMIF(in float3 HLAJBHJKKJJ, in float3 KJGKDNLKBAL, float DHPKDFNDGCD, Allocator MKFODJKMOCC, out NativeArray<Entity> JEFMGPHNDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public BKLLAOODKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0xA47CC0", Offset = "0xA46EC0", VA = "0x180A47CC0", Slot = "4")]
	private bool CJHGIDKNHBL(in float3 HLAJBHJKKJJ, in float3 KJGKDNLKBAL, float DHPKDFNDGCD, Allocator MKFODJKMOCC, out NativeArray<Entity> JEFMGPHNDGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[EHGELDODPME(typeof(AuthoredLocalPoseData))]
public sealed class GMBDOHGGKFD : LALLAELEDON
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0xA53460", Offset = "0xA52660", VA = "0x180A53460", Slot = "8")]
	protected override bool FLONHJHCHLG(ReadOnlySpan<AuthoredLocalPoseData> EHBKMHADDAO, DKPOHEEMLHH KIPBEBBCCCB, out ReadOnlySpan<byte> DGNKACAAPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0xA534E0", Offset = "0xA526E0", VA = "0x180A534E0", Slot = "9")]
	protected override bool NELBOOBPPPJ(int BCHFMCCIDMH, Span<AuthoredLocalPoseData> EHBKMHADDAO, in ReadOnlySpan<byte> DGNKACAAPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0xA535A0", Offset = "0xA527A0", VA = "0x180A535A0")]
	public GMBDOHGGKFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[EHGELDODPME(typeof(LocalPoseData))]
public sealed class MAMOKMGGDCJ : FBHIFCGBKLI
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x880820", Offset = "0x87FA20", VA = "0x180880820", Slot = "8")]
	protected override bool FLONHJHCHLG(ReadOnlySpan<LocalPoseData> EHBKMHADDAO, DKPOHEEMLHH KIPBEBBCCCB, out ReadOnlySpan<byte> DGNKACAAPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x8808A0", Offset = "0x87FAA0", VA = "0x1808808A0", Slot = "9")]
	protected override bool NELBOOBPPPJ(int BCHFMCCIDMH, Span<LocalPoseData> EHBKMHADDAO, in ReadOnlySpan<byte> DGNKACAAPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x880960", Offset = "0x87FB60", VA = "0x180880960")]
	public MAMOKMGGDCJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[Preserve]
	internal class _RRAssemblyIndex : BIJDGJCEPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x906F20", Offset = "0x906120", VA = "0x180906F20", Slot = "6")]
		public sealed override void FIKAMODMEGL(FDCELNCDHAG ELMGCHGCEJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0x9076D0", Offset = "0x9068D0", VA = "0x1809076D0", Slot = "4")]
		public sealed override void IGACKIBLPBJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
internal class BCDINCLGJNL : ContainerPropertyBag<ELFDLGFPJNI>
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	private class HPNNOLKPLMN : Property<ELFDLGFPJNI, IMGFAEJLICC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5F")]
			[Cpp2IlInjected.Address(RVA = "0xA560B0", Offset = "0xA552B0", VA = "0x180A560B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000A60")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0xA56070", Offset = "0xA55270", VA = "0x180A56070")]
		public HPNNOLKPLMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0xA56020", Offset = "0xA55220", VA = "0x180A56020", Slot = "11")]
		public override IMGFAEJLICC GetValue(ref ELFDLGFPJNI APJAHLFEOEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xA56040", Offset = "0xA55240", VA = "0x180A56040", Slot = "12")]
		public override void SetValue(ref ELFDLGFPJNI APJAHLFEOEM, IMGFAEJLICC ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0xA46E50", Offset = "0xA46050", VA = "0x180A46E50")]
	public BCDINCLGJNL()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x2809450", Offset = "0x2808650", VA = "0x182809450")]
		[Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001A7")]
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x875C00", Offset = "0x874E00", VA = "0x180875C00")]
	private static string JBPNMHMEPIE(byte[] KLGGEDCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x8758D0", Offset = "0x874AD0", VA = "0x1808758D0")]
	public static string HDPEGNHHKLG(byte[] FAOJAOEJLMO, bool CGIGAMOFOGM)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
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
