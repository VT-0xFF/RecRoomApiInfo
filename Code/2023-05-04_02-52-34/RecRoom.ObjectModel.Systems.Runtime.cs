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
public sealed class BPCEAGBBAHL<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class FFDPINOOKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::BPCEAGBBAHL<T> JBLDDIOLADK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] HHNEIKKOEJG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public FFDPINOOKIP(global::BPCEAGBBAHL<T> JBLDDIOLADK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class NKAAHOMOLMK : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::BPCEAGBBAHL<T> <>4__this;

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
		public NKAAHOMOLMK(int <>1__state)
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
	private const int OONGCCMPNKD = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> GBDFJNFGEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int IKJNGENNKBD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T JNKMHBEEDBP
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
	private bool JEJILLMBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool PGJHDGOINHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool MLLGMCBBONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CMKLLLCOEGO
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
	public int JAMIBFCLJNH
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
	public BPCEAGBBAHL(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public BPCEAGBBAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void CHOPNOPODPD(int EGNHJGKABLC, T JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void MDGCJLLGPHG(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] JPMGPEBODFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void IHGHMNONCIK(NativeArray<T> BGAKDGCGOMH, int HJEGHEJBGPH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::BPCEAGBBAHL<>.NKAAHOMOLMK))]
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
	public int JPAOIDBBCIF(T JPOBIIKLHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool FJEBMLODAAK(T JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void FFJCDHMPLCJ(int CIBNCNLAIOE, int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void EJKPLLJKEAI(int CIBNCNLAIOE, int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void BCKOBGNMHNH(int CIBNCNLAIOE, int LBOLDANMBMA, int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int ILBKCGABBFG(int EGNHJGKABLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T KAHFPMDLFCH(int EGNHJGKABLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void JPIDMEJPMOB(int EGNHJGKABLC, T JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void KINLAAIPNNN(int EGNHJGKABLC, T JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void IAJDLDOAKHK(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int OKKLONNLIGE(int LPJDDLMPNCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int LBHNMKLPFGC(int LPJDDLMPNCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void NFHFBMKNGLP(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void JPLBMOIAEBF(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T JBOEKAIIPBA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T KAGAODFKBNC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void GPGDGIFGMMI(int EGNHJGKABLC, IReadOnlyCollection<T> BDDEAAJFJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void HFMPHPLBIKF(int EGNHJGKABLC, int FNMDHKPCBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void PBBLAFEFEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void ENLNBJPDCFC(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void CHLCOLJIFML(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void AALDKJEFAAP(int LBOLDANMBMA, int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T DKFPFOLCMAN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T OPPAJPENCPP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[ILCDEIKDENM]
public static class HGGDMFKIBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2350", Offset = "0x2DE1750", VA = "0x182DE2350")]
	static HGGDMFKIBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x29FC2C0", Offset = "0x29FB6C0", VA = "0x1829FC2C0")]
	public static void KHPMEFGGEHC<T>(T EBCEJCLCIMI, ref T AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2DE20B0", Offset = "0x2DE14B0", VA = "0x182DE20B0")]
	public static void KHPMEFGGEHC(FixedString32 EBCEJCLCIMI, ref string AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2200", Offset = "0x2DE1600", VA = "0x182DE2200")]
	public static void KHPMEFGGEHC(string EBCEJCLCIMI, ref FixedString32 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2180", Offset = "0x2DE1580", VA = "0x182DE2180")]
	public static void KHPMEFGGEHC(FixedString64 EBCEJCLCIMI, ref string AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2DE22F0", Offset = "0x2DE16F0", VA = "0x182DE22F0")]
	public static void KHPMEFGGEHC(string EBCEJCLCIMI, ref FixedString64 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2020", Offset = "0x2DE1420", VA = "0x182DE2020")]
	public static void KHPMEFGGEHC(BODJKGEBDLM EBCEJCLCIMI, ref Vector3 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2050", Offset = "0x2DE1450", VA = "0x182DE2050")]
	public static void KHPMEFGGEHC(Vector3 EBCEJCLCIMI, ref BODJKGEBDLM AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE20E0", Offset = "0x2DE14E0", VA = "0x182DE20E0")]
	public static void KHPMEFGGEHC(MJNCEHHMBIG EBCEJCLCIMI, ref Vector4 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2110", Offset = "0x2DE1510", VA = "0x182DE2110")]
	public static void KHPMEFGGEHC(Vector4 EBCEJCLCIMI, ref MJNCEHHMBIG AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2DE20E0", Offset = "0x2DE14E0", VA = "0x182DE20E0")]
	public static void KHPMEFGGEHC(MJNCEHHMBIG EBCEJCLCIMI, ref Quaternion AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2110", Offset = "0x2DE1510", VA = "0x182DE2110")]
	public static void KHPMEFGGEHC(Quaternion EBCEJCLCIMI, ref MJNCEHHMBIG AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2DE21D0", Offset = "0x2DE15D0", VA = "0x182DE21D0")]
	public static void KHPMEFGGEHC(BODJKGEBDLM EBCEJCLCIMI, ref float3 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2050", Offset = "0x2DE1450", VA = "0x182DE2050")]
	public static void KHPMEFGGEHC(float3 EBCEJCLCIMI, ref BODJKGEBDLM AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1FE0", Offset = "0x2DE13E0", VA = "0x182DE1FE0")]
	public static void KHPMEFGGEHC(MJNCEHHMBIG EBCEJCLCIMI, ref float4 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2110", Offset = "0x2DE1510", VA = "0x182DE2110")]
	public static void KHPMEFGGEHC(float4 EBCEJCLCIMI, ref MJNCEHHMBIG AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1FE0", Offset = "0x2DE13E0", VA = "0x182DE1FE0")]
	public static void KHPMEFGGEHC(MJNCEHHMBIG EBCEJCLCIMI, ref quaternion AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2240", Offset = "0x2DE1640", VA = "0x182DE2240")]
	public static void KHPMEFGGEHC(quaternion EBCEJCLCIMI, ref MJNCEHHMBIG AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2DE22B0", Offset = "0x2DE16B0", VA = "0x182DE22B0")]
	public static void KHPMEFGGEHC(Entity EBCEJCLCIMI, ref CKDICGNIBHK AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2DE21B0", Offset = "0x2DE15B0", VA = "0x182DE21B0")]
	public static void KHPMEFGGEHC(CKDICGNIBHK EBCEJCLCIMI, ref Entity AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NDAPPBGAMDM]
public class NKANJLHPBOJ : ComponentSystem, GBCNOEIKEOL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FJEOEPCCLME PICFDDKMBKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7A04D0", Offset = "0x79F8D0", VA = "0x1807A04D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JDFPNHDAOJJ HHNOCIKFPBE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1920", Offset = "0x7B0D20", VA = "0x1807B1920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x296E740", Offset = "0x296DB40", VA = "0x18296E740", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
	public NKANJLHPBOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NDAPPBGAMDM]
[UpdateInGroup(typeof(MHFPHLOIMAP))]
internal class AJHMDEDDOCH : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC4F0", Offset = "0x2FAB8F0", VA = "0x182FAC4F0", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC730", Offset = "0x2FABB30", VA = "0x182FAC730")]
	[Preserve]
	private void FJOHEDNBPFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public AJHMDEDDOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NDAPPBGAMDM]
[UpdateInGroup(typeof(MHFPHLOIMAP))]
internal class HEBLFKHFOLL : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1DA0", Offset = "0x2DE11A0", VA = "0x182DE1DA0", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public HEBLFKHFOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2978DD0", Offset = "0x29781D0", VA = "0x182978DD0")]
		public static ObjectModelConfigAsset FJIIOICABEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xC5D680", Offset = "0xC5CA80", VA = "0x180C5D680")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[JEGJCCBDMOE(OLCAJGBKOGB.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int LGIPBIEPLIP = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly KLBHBMBPLOA JFFPIFJCILI;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x439BFF0", Offset = "0x439B3F0", VA = "0x18439BFF0")]
			public static KHMECMDAALD HLOKFJBEBKF(int KBKKOGKPBAI)
			{
				return default(KHMECMDAALD);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x439C3E0", Offset = "0x439B7E0", VA = "0x18439C3E0")]
			private static void KDJBEAEGEDG(MBEDCJLMHEO ICMMFLADFNF, MBEDCJLMHEO IDPCFPPKJBE, KHMECMDAALD HBKLDKCICEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x439C5F0", Offset = "0x439B9F0", VA = "0x18439C5F0")]
			public static int NNNCBCDMHIH(GameObject DLNMCGFEPOP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x439C570", Offset = "0x439B970", VA = "0x18439C570")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void LNHMEACABCA(MBEDCJLMHEO LKHNLAILFFL, int KBKKOGKPBAI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static AOONKACGDKK ONILLNPEPMK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static OJMGIHLPABJ EGACOJLEBML;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static AOONKACGDKK LCNJLEALFLE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x297A100", Offset = "0x2979500", VA = "0x18297A100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2979270", Offset = "0x2978670", VA = "0x182979270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static OJMGIHLPABJ BJCANCIPCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x29795E0", Offset = "0x29789E0", VA = "0x1829795E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2979EE0", Offset = "0x29792E0", VA = "0x182979EE0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool LMGGCGGPPIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x297A3B0", Offset = "0x29797B0", VA = "0x18297A3B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static FJEOEPCCLME PICFDDKMBKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2979350", Offset = "0x2978750", VA = "0x182979350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static JDFPNHDAOJJ HHNOCIKFPBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x297AA30", Offset = "0x2979E30", VA = "0x18297AA30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static NDFDMPICGAG CIJDLCNILKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2979E60", Offset = "0x2979260", VA = "0x182979E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static OECKLJAFLCL PKCMHFFGIFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2979700", Offset = "0x2978B00", VA = "0x182979700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static DDOLHFHMLOP DIPPIPKFCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2978E70", Offset = "0x2978270", VA = "0x182978E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static CLIHAPFPPDO EHJMHIENHGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2979CC0", Offset = "0x29790C0", VA = "0x182979CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool PKNHJACHMKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x297A7A0", Offset = "0x2979BA0", VA = "0x18297A7A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool HNOCEMCIMKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x29794B0", Offset = "0x29788B0", VA = "0x1829794B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool FDLOOBIMIDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x297A1C0", Offset = "0x29795C0", VA = "0x18297A1C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool BABLNMMPFNP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2979450", Offset = "0x2978850", VA = "0x182979450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x297A610", Offset = "0x2979A10", VA = "0x18297A610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool OFLAHCDJPDM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x29793F0", Offset = "0x29787F0", VA = "0x1829793F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x297A880", Offset = "0x2979C80", VA = "0x18297A880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action KOKLFFIBABB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2979780", Offset = "0x2978B80", VA = "0x182979780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x297A510", Offset = "0x2979910", VA = "0x18297A510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2979A80", Offset = "0x2978E80", VA = "0x182979A80")]
		public static MBEDCJLMHEO HKKALCMCNLF(GameObject DLNMCGFEPOP)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x297A160", Offset = "0x2979560", VA = "0x18297A160")]
		public static bool LAKKFOOAFLA(ByteString EICPLPLLHGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2979880", Offset = "0x2978C80", VA = "0x182979880")]
		public static EMFDOJECCDF HABBDICMEHL(KHMECMDAALD HBKLDKCICEJ)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2979B70", Offset = "0x2978F70", VA = "0x182979B70")]
		public static (ByteString, IDisposable) HLHCEBOKDMG()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x297A8E0", Offset = "0x2979CE0", VA = "0x18297A8E0")]
		public static (ByteString, IDisposable) NFKGFNBBBGA(IEnumerable<MBEDCJLMHEO> LLDOOGBMLGH)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x297A670", Offset = "0x2979A70", VA = "0x18297A670")]
		public static bool LOKBJALKGIO(GameObject DLNMCGFEPOP, out KHMECMDAALD HBKLDKCICEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2979D40", Offset = "0x2979140", VA = "0x182979D40")]
		public static bool IAKKNNBJDOH(IEnumerable<BMLJODFLIKN> JGGHOCFLFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x29799A0", Offset = "0x2978DA0", VA = "0x1829799A0")]
		public static void HHABOMGLDEF(bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2978FD0", Offset = "0x29783D0", VA = "0x182978FD0")]
		public static Task ALFGEPCJFIN(bool EFCPHECCPHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2978EF0", Offset = "0x29782F0", VA = "0x182978EF0")]
		private static OJMGIHLPABJ AHNJBIMGOKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2979150", Offset = "0x2978550", VA = "0x182979150")]
		private static bool BJDCFEGJMNB()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x297FC40", Offset = "0x297F040", VA = "0x18297FC40")]
		public static bool GMGNOMIKBCG(APKFPLGDLPH NKLGMCFCMKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x297F710", Offset = "0x297EB10", VA = "0x18297F710")]
		public static APKFPLGDLPH EHOMCGHPBHE(GameObject DLNMCGFEPOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x297F940", Offset = "0x297ED40", VA = "0x18297F940")]
		public static APKFPLGDLPH EHOMCGHPBHE(GameObject DLNMCGFEPOP, KHMECMDAALD HBKLDKCICEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x297FB40", Offset = "0x297EF40", VA = "0x18297FB40")]
		public static bool FCLGIKKCKBI(GameObject JNONJGMFMNE, string KJMIGPLGEHH, bool MPPBOICGLCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x297F510", Offset = "0x297E910", VA = "0x18297F510")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void BBCOBPDEPPC(GameObject JNONJGMFMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x297FCF0", Offset = "0x297F0F0", VA = "0x18297FCF0")]
		[CompilerGenerated]
		internal static string OOHFOFLMNIG((GameObject go, string prefabName) FKFCAPAEHKO)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, GFAGKLPBCJA
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool CDOMMGFPCNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public MBEDCJLMHEO BEFNGGLNHMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x735A00", Offset = "0x734E00", VA = "0x180735A00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(MBEDCJLMHEO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x26E3850", Offset = "0x26E2C50", VA = "0x1826E3850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[JEGJCCBDMOE(OLCAJGBKOGB.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, APKFPLGDLPH, GFAGKLPBCJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string GIGJANBHHOA = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private BKLPIBADGOF OJNFGJAPBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MBEDCJLMHEO LMLBLIDPKCN;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public MBEDCJLMHEO BEFNGGLNHMI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2FCAE80", Offset = "0x2FCA280", VA = "0x182FCAE80", Slot = "15")]
			get
			{
				return default(MBEDCJLMHEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public EMFDOJECCDF JELKDBJJLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2FCAF30", Offset = "0x2FCA330", VA = "0x182FCAF30", Slot = "6")]
			get
			{
				return default(EMFDOJECCDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool CDOMMGFPCNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2FCAE70", Offset = "0x2FCA270", VA = "0x182FCAE70", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public BKLPIBADGOF FJJGKFADCDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xBB0130", Offset = "0xBAF530", VA = "0x180BB0130", Slot = "7")]
			get
			{
				return default(BKLPIBADGOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private JDFPNHDAOJJ HHNOCIKFPBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2FCABA0", Offset = "0x2FC9FA0", VA = "0x182FCABA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private AMBNPJKGCOF KHMONBGGGOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2FCAC80", Offset = "0x2FCA080", VA = "0x182FCAC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool MCOBJCCBOMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x754680", Offset = "0x753A80", VA = "0x180754680", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x754690", Offset = "0x753A90", VA = "0x180754690", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> ABFJJJEGBKB
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2FCAD30", Offset = "0x2FCA130", VA = "0x182FCAD30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2FCAF60", Offset = "0x2FCA360", VA = "0x182FCAF60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<APKFPLGDLPH> FFINDFOAIKL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2FCADD0", Offset = "0x2FCA1D0", VA = "0x182FCADD0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2FCB000", Offset = "0x2FCA400", VA = "0x182FCB000", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA230", Offset = "0x2FC9630", VA = "0x182FCA230")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2FCAA50", Offset = "0x2FC9E50", VA = "0x182FCAA50", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA690", Offset = "0x2FC9A90", VA = "0x182FCA690", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA9C0", Offset = "0x2FC9DC0", VA = "0x182FCA9C0", Slot = "10")]
		public void OnEmbody(BHHDNNCMGLM ACFGKGFDFPL, MBEDCJLMHEO LMLBLIDPKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2FCAA40", Offset = "0x2FC9E40", VA = "0x182FCAA40", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA7B0", Offset = "0x2FC9BB0", VA = "0x182FCA7B0", Slot = "12")]
		public void OnDisembody(bool IFNFKGMGNPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA3B0", Offset = "0x2FC97B0", VA = "0x182FCA3B0")]
		private void FLFHNONBGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA4B0", Offset = "0x2FC98B0", VA = "0x182FCA4B0")]
		private void JBMEJJDGLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA540", Offset = "0x2FC9940", VA = "0x182FCA540")]
		private void KNBIFBCEKPM(bool GGAFPKHNBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA630", Offset = "0x2FC9A30", VA = "0x182FCA630", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xE4B010", Offset = "0xE4A410", VA = "0x180E4B010", Slot = "9")]
		private GameObject NPKFPOHNGFP()
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

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[JEGJCCBDMOE(OLCAJGBKOGB.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override GODNFBOIBNJ BFODBIDEHJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x298A220", Offset = "0x2989620", VA = "0x18298A220", Slot = "6")]
			get
			{
				return default(GODNFBOIBNJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x298A1C0", Offset = "0x29895C0", VA = "0x18298A1C0")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[JEGJCCBDMOE(OLCAJGBKOGB.Registration)]
	public class TransformEntity : MonoBehaviour, GFAGKLPBCJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private GODNFBOIBNJ prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private MBEDCJLMHEO LKHNLAILFFL;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual GODNFBOIBNJ BFODBIDEHJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x788950", Offset = "0x787D50", VA = "0x180788950", Slot = "6")]
			get
			{
				return default(GODNFBOIBNJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xBB01E0", Offset = "0xBAF5E0", VA = "0x180BB01E0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public MBEDCJLMHEO BEFNGGLNHMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB04540", Offset = "0xB03940", VA = "0x180B04540", Slot = "5")]
			get
			{
				return default(MBEDCJLMHEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool CDOMMGFPCNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9A6950", Offset = "0x9A5D50", VA = "0x1809A6950", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xCCB670", Offset = "0xCCAA70", VA = "0x180CCB670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity PBIJGMNGOLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal DDOLHFHMLOP DIPPIPKFCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal AMBNPJKGCOF EFDNLJHDPEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2BD6FE0", Offset = "0x2BD63E0", VA = "0x182BD6FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6BA0", Offset = "0x2BD5FA0", VA = "0x182BD6BA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6BB0", Offset = "0x2BD5FB0", VA = "0x182BD6BB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6CD0", Offset = "0x2BD60D0", VA = "0x182BD6CD0")]
		internal void KADCCJJCHBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7050", Offset = "0x2BD6450", VA = "0x182BD7050")]
		private bool OLONBOIGDEL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6CA0", Offset = "0x2BD60A0", VA = "0x182BD6CA0")]
		private void DGDHLAKHIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6BB0", Offset = "0x2BD5FB0", VA = "0x182BD6BB0")]
		internal void CKAJENPILHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD70F0", Offset = "0x2BD64F0", VA = "0x182BD70F0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2BD71D0", Offset = "0x2BD65D0", VA = "0x182BD71D0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[HAMPPOKOPOP(typeof(OJMGIHLPABJ), new string[] { })]
[AFHOMLJMOLI(typeof(LPHNFCPFJBF))]
public class LAFHCMFONED : OJMGIHLPABJ, EADCECODNBJ, LPHNFCPFJBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private HJOJGGNKDFB JGMMDACFJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JDFPNHDAOJJ DFKHIBLIHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private BFHOGDONKCB NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GFDALGCABGM KBGCNJEEGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private LBFECDDPFBD GOBBGGBLGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private LOFJFJMIAMG FKLLILMDAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public HJOJGGNKDFB PICFDDKMBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public BFHOGDONKCB CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public JDFPNHDAOJJ HHNOCIKFPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LBFECDDPFBD GPIPEIHLBFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LOFJFJMIAMG ILJEAOBGMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x735A10", Offset = "0x734E10", VA = "0x180735A10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AMOPNJPCIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x883440", Offset = "0x882840", VA = "0x180883440", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool OEENHAMLKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x296A230", Offset = "0x2969630", VA = "0x18296A230", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HNJBILHOIMC DMGKCMGPDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8F57D0", Offset = "0x8F4BD0", VA = "0x1808F57D0", Slot = "10")]
		get
		{
			return default(HNJBILHOIMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x296A390", Offset = "0x2969790", VA = "0x18296A390")]
	public static LAFHCMFONED IDIKGABNBEI(HJOJGGNKDFB JGMMDACFJLC, HKCMLMJLMKG CAAHBOFLBKP = HKCMLMJLMKG.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void PMOPAEHOABF(HJOJGGNKDFB JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void OBMDHEFKOBA(HJOJGGNKDFB JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x296A0E0", Offset = "0x29694E0", VA = "0x18296A0E0", Slot = "11")]
	public void AHPFPMIFNAG(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2500000", Offset = "0x24FF400", VA = "0x182500000")]
	private void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x296A2A0", Offset = "0x29696A0", VA = "0x18296A2A0")]
	private void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x296A240", Offset = "0x2969640", VA = "0x18296A240", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public LAFHCMFONED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PMLFKOIGNFB
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x29811F0", Offset = "0x29805F0", VA = "0x1829811F0")]
	public static EMFDOJECCDF PLLGILFFNLD(this OJMGIHLPABJ EGACOJLEBML, KHMECMDAALD HBKLDKCICEJ, GODNFBOIBNJ KLFAINNONJC)
	{
		return default(EMFDOJECCDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2980DD0", Offset = "0x29801D0", VA = "0x182980DD0")]
	public static NCAJJMMMNLG CIPMNLGHOOM(this OJMGIHLPABJ EGACOJLEBML)
	{
		return default(NCAJJMMMNLG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2981140", Offset = "0x2980540", VA = "0x182981140")]
	public static MBEDCJLMHEO HKKALCMCNLF(this OJMGIHLPABJ EGACOJLEBML, Entity LCLDFKAJPDK)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2981010", Offset = "0x2980410", VA = "0x182981010")]
	public static MBEDCJLMHEO HKKALCMCNLF(this OJMGIHLPABJ EGACOJLEBML, KHMECMDAALD HBKLDKCICEJ)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2980EF0", Offset = "0x29802F0", VA = "0x182980EF0")]
	public static KHMECMDAALD FLJOHMEAAKD(this OJMGIHLPABJ EGACOJLEBML, MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(KHMECMDAALD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum HKCMLMJLMKG
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[HAMPPOKOPOP(typeof(LOFJFJMIAMG), new string[] { })]
public class AAPHKJCJPDD : LOFJFJMIAMG, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[OMAMNFHDGBM]
	private LPHNFCPFJBF KHKOGBBOGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HJOJGGNKDFB JGMMDACFJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private HNIIKODBKKD GOBBGGBLGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private GFDALGCABGM KBGCNJEEGBM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action MMKGHFNGGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2FAC010", Offset = "0x2FAB410", VA = "0x182FAC010", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2FAC310", Offset = "0x2FAB710", VA = "0x182FAC310", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC130", Offset = "0x2FAB530", VA = "0x182FAC130", Slot = "16")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC450", Offset = "0x2FAB850", VA = "0x182FAC450", Slot = "13")]
	public void KCDJNNCAGCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "6")]
	public void CEPOPFLPLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC400", Offset = "0x2FAB800", VA = "0x182FAC400", Slot = "7")]
	public void KBJLMOBAMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC240", Offset = "0x2FAB640", VA = "0x182FAC240", Slot = "8")]
	public void IPJGDPGFFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1BEDFC0", Offset = "0x1BED3C0", VA = "0x181BEDFC0", Slot = "9")]
	public void AOLADNPFIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC2C0", Offset = "0x2FAB6C0", VA = "0x182FAC2C0", Slot = "10")]
	public void JCKGABHBCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC1E0", Offset = "0x2FAB5E0", VA = "0x182FAC1E0", Slot = "11")]
	public bool IAKKNNBJDOH(IEnumerable<BMLJODFLIKN> JGGHOCFLFBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC3B0", Offset = "0x2FAB7B0", VA = "0x182FAC3B0", Slot = "12")]
	public void JPJDNINPFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC0B0", Offset = "0x2FAB4B0", VA = "0x182FAC0B0", Slot = "14")]
	public void BGHNIINFJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC490", Offset = "0x2FAB890", VA = "0x182FAC490", Slot = "15")]
	public void OIMBFBLLJAN(bool COEOEBHKOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC100", Offset = "0x2FAB500", VA = "0x182FAC100")]
	private void CDKAKDPMAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public AAPHKJCJPDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[HAMPPOKOPOP(typeof(LBFECDDPFBD), new string[] { })]
public class JBJIAGMLJJH : LBFECDDPFBD, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[OMAMNFHDGBM]
	private LPHNFCPFJBF KHKOGBBOGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private HJOJGGNKDFB JGMMDACFJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private HNIIKODBKKD GOBBGGBLGMH;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE370", Offset = "0x2DED770", VA = "0x182DEE370", Slot = "6")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE400", Offset = "0x2DED800", VA = "0x182DEE400", Slot = "4")]
	public ByteString HLHCEBOKDMG(out IDisposable BOKADHKDELF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE4C0", Offset = "0x2DED8C0", VA = "0x182DEE4C0", Slot = "5")]
	public void JDGCKOHAIDJ(ByteString HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public JBJIAGMLJJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class OLHLEPICNBD<T> : global::MCGADBCALCK<T>, global::CCCEMKOEGOF<KHMECMDAALD, T>, global::NMNPBFGHJBG<KHMECMDAALD>, EJMAGAGALIM, IDisposable, LEDNIENHLNM where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly global::NMNPBFGHJBG<Entity> GJEJKJANAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Delegate BCAOHILKLHL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string HOIPOKICKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3258B70", Offset = "0x3257F70", VA = "0x183258B70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type BELDJPAAHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3251B50", Offset = "0x3250F50", VA = "0x183251B50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HPEJEEPDKIC EOPNOIAHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3254FC0", Offset = "0x32543C0", VA = "0x183254FC0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int KBEFCFCFPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x32540E0", Offset = "0x32534E0", VA = "0x1832540E0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FPHAAJEGEDJ KHPNIPMAHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3258BC0", Offset = "0x3257FC0", VA = "0x183258BC0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3251CD0", Offset = "0x32510D0", VA = "0x183251CD0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3256790", Offset = "0x3255B90", VA = "0x183256790", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::FHOJCPPIDAI<KHMECMDAALD> KOKLFFIBABB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x32541B0", Offset = "0x32535B0", VA = "0x1832541B0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x32556A0", Offset = "0x3254AA0", VA = "0x1832556A0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3258F80", Offset = "0x3258380", VA = "0x183258F80")]
	public OLHLEPICNBD(global::NMNPBFGHJBG<Entity> GJEJKJANAJD, DDOLHFHMLOP CGCNGCLEGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3251870", Offset = "0x3250C70", VA = "0x183251870")]
	private Entity AENBDOEOIOH(KHMECMDAALD HBKLDKCICEJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3251940", Offset = "0x3250D40", VA = "0x183251940")]
	private KHMECMDAALD AENBDOEOIOH(Entity LCLDFKAJPDK)
	{
		return default(KHMECMDAALD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3257C50", Offset = "0x3257050", VA = "0x183257C50", Slot = "4")]
	public T MKLBNKEKMJE(KHMECMDAALD HBKLDKCICEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x32530C0", Offset = "0x32524C0", VA = "0x1832530C0")]
	public bool EFMALMFMJGL(KHMECMDAALD HBKLDKCICEJ, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3251E50", Offset = "0x3251250", VA = "0x183251E50")]
	public bool DHEEHCCONBN(KHMECMDAALD HBKLDKCICEJ, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3253680", Offset = "0x3252A80", VA = "0x183253680", Slot = "9")]
	public bool FIKLEKNKGJP(KHMECMDAALD HBKLDKCICEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3258A00", Offset = "0x3257E00", VA = "0x183258A00", Slot = "26")]
	public object OCMIFEJBKHP(KHMECMDAALD HBKLDKCICEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3253A30", Offset = "0x3252E30", VA = "0x183253A30")]
	public bool FKIKBBIJKBK(KHMECMDAALD HBKLDKCICEJ, in object CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x32578E0", Offset = "0x3256CE0", VA = "0x1832578E0")]
	public void MKLBNKEKMJE(KHMECMDAALD HBKLDKCICEJ, in LGDIAIHEOID LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3252E70", Offset = "0x3252270", VA = "0x183252E70")]
	public bool EFMALMFMJGL(KHMECMDAALD HBKLDKCICEJ, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3251DA0", Offset = "0x32511A0", VA = "0x183251DA0")]
	public bool DHEEHCCONBN(KHMECMDAALD HBKLDKCICEJ, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3255340", Offset = "0x3254740", VA = "0x183255340", Slot = "22")]
	public void KJCIHCOFJEN(OHLAKFFIOHD DNIKKNNGFMM, [Optional] object PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3255370", Offset = "0x3254770", VA = "0x183255370", Slot = "15")]
	public void KJCIHCOFJEN(KHMECMDAALD OGFDNCPKECB, AJOKFLMHEKN DNIKKNNGFMM, object PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3258580", Offset = "0x3257980", VA = "0x183258580", Slot = "14")]
	public bool MLOEOOCDIIH(KHMECMDAALD AJINCMEHCPE, KHMECMDAALD EBCEJCLCIMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x162C6C0", Offset = "0x162BAC0", VA = "0x18162C6C0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3258E40", Offset = "0x3258240", VA = "0x183258E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x32545A0", Offset = "0x32539A0", VA = "0x1832545A0")]
	public string GIKBMFAGOAC(in HAMGOKKMMPI EJAGMODIJNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3252BC0", Offset = "0x3251FC0", VA = "0x183252BC0")]
	private void EABMMMFJIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3254890", Offset = "0x3253C90", VA = "0x183254890")]
	private void HHGBIJMIDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x32567C0", Offset = "0x3255BC0", VA = "0x1832567C0")]
	private void MAOOGIIDNPH(Entity LCLDFKAJPDK, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x32587C0", Offset = "0x3257BC0", VA = "0x1832587C0")]
	private void NJOIFCKABHM(Entity LCLDFKAJPDK, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3255CD0", Offset = "0x32550D0", VA = "0x183255CD0")]
	[Conditional("DEBUG_BUILD")]
	private static void LKENIIBICCL(Entity LCLDFKAJPDK, KHMECMDAALD HBKLDKCICEJ, string IHNHAGGGBIH, string JCDOBNCJIFP, [CallerMemberName] string JAPNAIGHAPC = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3251B20", Offset = "0x3250F20", VA = "0x183251B20", Slot = "5")]
	private bool BGDLPLLOMGH(KHMECMDAALD OGFDNCPKECB, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3251AF0", Offset = "0x3250EF0", VA = "0x183251AF0", Slot = "6")]
	private bool AKNMKCGEJPH(KHMECMDAALD OGFDNCPKECB, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2EA0950", Offset = "0x2E9FD50", VA = "0x182EA0950", Slot = "10")]
	private bool ONMGOCKLLGE(KHMECMDAALD OGFDNCPKECB, in object CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3255670", Offset = "0x3254A70", VA = "0x183255670", Slot = "11")]
	private void KPPMELKOHFN(KHMECMDAALD OGFDNCPKECB, in LGDIAIHEOID LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3256720", Offset = "0x3255B20", VA = "0x183256720", Slot = "12")]
	private bool LMDKPIIOMHA(KHMECMDAALD OGFDNCPKECB, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3254180", Offset = "0x3253580", VA = "0x183254180", Slot = "13")]
	private bool GBOBKJDKPAM(KHMECMDAALD OGFDNCPKECB, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3254EF0", Offset = "0x32542F0", VA = "0x183254EF0", Slot = "16")]
	private string HPMOBGMNKBP(in HAMGOKKMMPI LPJDDLMPNCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class JHEEGHNCDEJ<T> : global::BHJMFFBJHCN<T>, global::CCCEMKOEGOF<MBEDCJLMHEO, T>, global::NMNPBFGHJBG<MBEDCJLMHEO>, EJMAGAGALIM, IDisposable, PPBNAGHDKKA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly global::NMNPBFGHJBG<Entity> GJEJKJANAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Delegate BCAOHILKLHL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string HOIPOKICKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3A963B0", Offset = "0x3A957B0", VA = "0x183A963B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type BELDJPAAHJO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3A833B0", Offset = "0x3A827B0", VA = "0x183A833B0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public HPEJEEPDKIC EOPNOIAHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D3C0", Offset = "0x3A8C7C0", VA = "0x183A8D3C0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int KBEFCFCFPNH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3A8AAA0", Offset = "0x3A89EA0", VA = "0x183A8AAA0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public FPHAAJEGEDJ KHPNIPMAHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3A96860", Offset = "0x3A95C60", VA = "0x183A96860", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3A836F0", Offset = "0x3A82AF0", VA = "0x183A836F0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D5A0", Offset = "0x3A8C9A0", VA = "0x183A8D5A0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::FHOJCPPIDAI<MBEDCJLMHEO> KOKLFFIBABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3A8AE80", Offset = "0x3A8A280", VA = "0x183A8AE80", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3A8F010", Offset = "0x3A8E410", VA = "0x183A8F010", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3258F80", Offset = "0x3258380", VA = "0x183258F80")]
	public JHEEGHNCDEJ(global::NMNPBFGHJBG<Entity> GJEJKJANAJD, DDOLHFHMLOP CGCNGCLEGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1DD1E50", Offset = "0x1DD1250", VA = "0x181DD1E50")]
	private Entity AENBDOEOIOH(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3A831C0", Offset = "0x3A825C0", VA = "0x183A831C0")]
	private MBEDCJLMHEO AENBDOEOIOH(Entity LCLDFKAJPDK)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3A939F0", Offset = "0x3A92DF0", VA = "0x183A939F0", Slot = "4")]
	public T MKLBNKEKMJE(MBEDCJLMHEO LKHNLAILFFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3A88090", Offset = "0x3A87490", VA = "0x183A88090")]
	public bool EFMALMFMJGL(MBEDCJLMHEO LKHNLAILFFL, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3A84B80", Offset = "0x3A83F80", VA = "0x183A84B80")]
	public bool DHEEHCCONBN(MBEDCJLMHEO LKHNLAILFFL, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A88D00", Offset = "0x3A88100", VA = "0x183A88D00", Slot = "9")]
	public bool FIKLEKNKGJP(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3A962D0", Offset = "0x3A956D0", VA = "0x183A962D0", Slot = "26")]
	public object OCMIFEJBKHP(MBEDCJLMHEO LKHNLAILFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A650", Offset = "0x3A89A50", VA = "0x183A8A650")]
	public bool FKIKBBIJKBK(MBEDCJLMHEO LKHNLAILFFL, in object CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3A94E70", Offset = "0x3A94270", VA = "0x183A94E70")]
	public void MKLBNKEKMJE(MBEDCJLMHEO LKHNLAILFFL, in LGDIAIHEOID LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3A87600", Offset = "0x3A86A00", VA = "0x183A87600")]
	public bool EFMALMFMJGL(MBEDCJLMHEO LKHNLAILFFL, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3A83F70", Offset = "0x3A83370", VA = "0x183A83F70")]
	public bool DHEEHCCONBN(MBEDCJLMHEO LKHNLAILFFL, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3255340", Offset = "0x3254740", VA = "0x183255340", Slot = "22")]
	public void KJCIHCOFJEN(OHLAKFFIOHD DNIKKNNGFMM, [Optional] object PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E390", Offset = "0x3A8D790", VA = "0x183A8E390", Slot = "15")]
	public void KJCIHCOFJEN(MBEDCJLMHEO OGFDNCPKECB, AJOKFLMHEKN DNIKKNNGFMM, object PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3A94F50", Offset = "0x3A94350", VA = "0x183A94F50", Slot = "14")]
	public bool MLOEOOCDIIH(MBEDCJLMHEO AJINCMEHCPE, MBEDCJLMHEO EBCEJCLCIMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3A85520", Offset = "0x3A84920", VA = "0x183A85520")]
	private void EABMMMFJIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3A8BA40", Offset = "0x3A8AE40", VA = "0x183A8BA40")]
	private void HHGBIJMIDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3A90740", Offset = "0x3A8FB40", VA = "0x183A90740")]
	private void MAOOGIIDNPH(Entity LCLDFKAJPDK, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3A95C00", Offset = "0x3A95000", VA = "0x183A95C00")]
	private void NJOIFCKABHM(Entity LCLDFKAJPDK, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3A852C0", Offset = "0x3A846C0", VA = "0x183A852C0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3A96C20", Offset = "0x3A96020", VA = "0x183A96C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x32545A0", Offset = "0x32539A0", VA = "0x1832545A0")]
	public string GIKBMFAGOAC(in HAMGOKKMMPI EJAGMODIJNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3A8D5A0", Offset = "0x3A8C9A0", VA = "0x183A8D5A0", Slot = "5")]
	private bool IIMFIMJPEDC(MBEDCJLMHEO OGFDNCPKECB, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3A8D1A0", Offset = "0x3A8C5A0", VA = "0x183A8D1A0", Slot = "6")]
	private bool HPBNBLPHNNH(MBEDCJLMHEO OGFDNCPKECB, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3A831F0", Offset = "0x3A825F0", VA = "0x183A831F0", Slot = "10")]
	private bool AGPKJBNLKLB(MBEDCJLMHEO OGFDNCPKECB, in object CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3A94F10", Offset = "0x3A94310", VA = "0x183A94F10", Slot = "11")]
	private void MLDDLCPIHPH(MBEDCJLMHEO OGFDNCPKECB, in LGDIAIHEOID LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3A887C0", Offset = "0x3A87BC0", VA = "0x183A887C0", Slot = "12")]
	private bool ENLIMJAKMPC(MBEDCJLMHEO OGFDNCPKECB, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3A8AC30", Offset = "0x3A8A030", VA = "0x183A8AC30", Slot = "13")]
	private bool FPNMFCIKIEK(MBEDCJLMHEO OGFDNCPKECB, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3254EF0", Offset = "0x32542F0", VA = "0x183254EF0", Slot = "16")]
	private string FCHMOHHIAAD(in HAMGOKKMMPI LPJDDLMPNCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MANAEOMEHPG : IDisposable, JPHKJJNABPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> IGIGBKFKHFC;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> CGKFEKJDFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9F0", Offset = "0xA3DDF0", VA = "0x180A3E9F0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xCD6020", Offset = "0xCD5420", VA = "0x180CD6020")]
	public MANAEOMEHPG(NativeArray<EntityRemapUtility.EntityRemapInfo> IGIGBKFKHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x296BFF0", Offset = "0x296B3F0", VA = "0x18296BFF0", Slot = "6")]
	public MBEDCJLMHEO PIECOAJPBNK(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x296C040", Offset = "0x296B440", VA = "0x18296C040", Slot = "7")]
	public Entity PIECOAJPBNK(Entity LCLDFKAJPDK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x296BF50", Offset = "0x296B350", VA = "0x18296BF50", Slot = "8")]
	public IEnumerable<MBEDCJLMHEO> PIECOAJPBNK(IEnumerable<MBEDCJLMHEO> LLDOOGBMLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x296BEF0", Offset = "0x296B2F0", VA = "0x18296BEF0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly KLBHBMBPLOA GIOBIKAOEAA;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static int JBOPMNJDBKD;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static JPHKJJNABPK FIANHALABNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool NKOHEMBMFOO;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> CGKFEKJDFAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x2BCF1F0", Offset = "0x2BCE5F0", VA = "0x182BCF1F0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool ADOEMHIFDMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2BCF360", Offset = "0x2BCE760", VA = "0x182BCF360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF300", Offset = "0x2BCE700", VA = "0x182BCF300")]
		public static SerializationRemapScope BFOBHHOJHHG()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF820", Offset = "0x2BCEC20", VA = "0x182BCF820")]
		public SerializationRemapScope(JPHKJJNABPK OFMOCNNCKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF3F0", Offset = "0x2BCE7F0", VA = "0x182BCF3F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF630", Offset = "0x2BCEA30", VA = "0x182BCF630")]
		public static MBEDCJLMHEO PIECOAJPBNK(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF500", Offset = "0x2BCE900", VA = "0x182BCF500")]
		public static Entity PIECOAJPBNK(Entity LCLDFKAJPDK)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DCBDIJCKLAD(IKIGKMLBEFF.Application)]
[HAMPPOKOPOP(typeof(CNLINPPILPM), new string[] { "Editor" })]
public sealed class CNLINPPILPM
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void NHAGAJMJACF(KHMECMDAALD BPJDIEJACOD, DMLPNPICGMP HIDEHJGLNHO, bool GNCEPPHMFLM);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate void KJGHIOPPKDM(KHMECMDAALD BPJDIEJACOD, bool GNCEPPHMFLM);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void BIEMHMDOAIL(KHMECMDAALD BPJDIEJACOD, AHKPLOLMABO GJEJKJANAJD, in HAMGOKKMMPI LPJDDLMPNCG, bool GNCEPPHMFLM);

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event NHAGAJMJACF OPBILEONKAI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7DA0", Offset = "0x2FB71A0", VA = "0x182FB7DA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7E40", Offset = "0x2FB7240", VA = "0x182FB7E40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event KJGHIOPPKDM FIFKFFPNHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7AB0", Offset = "0x2FB6EB0", VA = "0x182FB7AB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7D00", Offset = "0x2FB7100", VA = "0x182FB7D00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event BIEMHMDOAIL OLGFDJEAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7BC0", Offset = "0x2FB6FC0", VA = "0x182FB7BC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7C60", Offset = "0x2FB7060", VA = "0x182FB7C60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7BA0", Offset = "0x2FB6FA0", VA = "0x182FB7BA0")]
	[Conditional("UNITY_EDITOR")]
	public void ECJEAKCPPMC(KHMECMDAALD BPJDIEJACOD, in DMLPNPICGMP HIDEHJGLNHO, bool GNCEPPHMFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7B80", Offset = "0x2FB6F80", VA = "0x182FB7B80")]
	[Conditional("UNITY_EDITOR")]
	public void EACHOIILEAJ(KHMECMDAALD BPJDIEJACOD, bool GNCEPPHMFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7B50", Offset = "0x2FB6F50", VA = "0x182FB7B50")]
	[Conditional("UNITY_EDITOR")]
	public void DACDBPPDPMD(KHMECMDAALD BPJDIEJACOD, AHKPLOLMABO GJEJKJANAJD, in HAMGOKKMMPI LPJDDLMPNCG, bool GNCEPPHMFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public CNLINPPILPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[HAMPPOKOPOP(typeof(FOLBIIPDBJB), new string[] { "Editor" })]
[DCBDIJCKLAD(IKIGKMLBEFF.Application)]
public sealed class FOLBIIPDBJB
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void AJJKEGNLGMM(KHMECMDAALD HBKLDKCICEJ, DMLPNPICGMP HIDEHJGLNHO, bool GNCEPPHMFLM);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void KIDCJNHGKJG(KHMECMDAALD HBKLDKCICEJ, bool GNCEPPHMFLM);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void LJHHLIEKJJP(KHMECMDAALD HBKLDKCICEJ, AHKPLOLMABO GJEJKJANAJD, in HAMGOKKMMPI LPJDDLMPNCG, bool GNCEPPHMFLM, bool NDNBCLJHJHB);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate void IGEDCGLCEKE(KHMECMDAALD HBKLDKCICEJ, AHKPLOLMABO GJEJKJANAJD, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate void HONKAGNNBLJ(AJGHFPGHPHG OGFDNCPKECB, ReadOnlyMemory<byte> GJNIFGAPEDN);

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event Action<World> AGHICMADJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2DDEDA0", Offset = "0x2DDE1A0", VA = "0x182DDEDA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2DDEA90", Offset = "0x2DDDE90", VA = "0x182DDEA90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> EKICLMLDLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE890", Offset = "0x2DDDC90", VA = "0x182DDE890")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE330", Offset = "0x2DDD730", VA = "0x182DDE330")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event AJJKEGNLGMM OPBILEONKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2DDEE60", Offset = "0x2DDE260", VA = "0x182DDEE60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2DDEF30", Offset = "0x2DDE330", VA = "0x182DDEF30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event KIDCJNHGKJG FIFKFFPNHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE290", Offset = "0x2DDD690", VA = "0x182DDE290")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2DDEB50", Offset = "0x2DDDF50", VA = "0x182DDEB50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event AJJKEGNLGMM FGNNOFILCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE750", Offset = "0x2DDDB50", VA = "0x182DDE750")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE950", Offset = "0x2DDDD50", VA = "0x182DDE950")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event KIDCJNHGKJG PNLLMCFJJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE6B0", Offset = "0x2DDDAB0", VA = "0x182DDE6B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2DDEBF0", Offset = "0x2DDDFF0", VA = "0x182DDEBF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event LJHHLIEKJJP OLGFDJEAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE570", Offset = "0x2DDD970", VA = "0x182DDE570")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE7F0", Offset = "0x2DDDBF0", VA = "0x182DDE7F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event IGEDCGLCEKE CNKOHKFFGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2DDF100", Offset = "0x2DDE500", VA = "0x182DDF100")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2DDED00", Offset = "0x2DDE100", VA = "0x182DDED00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> BBFDHAPBEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE9F0", Offset = "0x2DDDDF0", VA = "0x182DDE9F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE610", Offset = "0x2DDDA10", VA = "0x182DDE610")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event HONKAGNNBLJ HFHCKMDCNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE4D0", Offset = "0x2DDD8D0", VA = "0x182DDE4D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2DDEFD0", Offset = "0x2DDE3D0", VA = "0x182DDEFD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2DDEF00", Offset = "0x2DDE300", VA = "0x182DDEF00")]
	[Conditional("UNITY_EDITOR")]
	public void KJIPHGJGGPN(KHMECMDAALD HBKLDKCICEJ, in DMLPNPICGMP HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE480", Offset = "0x2DDD880", VA = "0x182DDE480")]
	[Conditional("UNITY_EDITOR")]
	public void DHIKNDMJDEJ(KHMECMDAALD HBKLDKCICEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE450", Offset = "0x2DDD850", VA = "0x182DDE450")]
	[Conditional("UNITY_EDITOR")]
	public void BMDLMKKMHGB(KHMECMDAALD HBKLDKCICEJ, in DMLPNPICGMP HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF0E0", Offset = "0x2DDE4E0", VA = "0x182DDF0E0")]
	[Conditional("UNITY_EDITOR")]
	public void NGIELHEOLOM(KHMECMDAALD HBKLDKCICEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE4A0", Offset = "0x2DDD8A0", VA = "0x182DDE4A0")]
	[Conditional("UNITY_EDITOR")]
	public void DHOADLBAICA(KHMECMDAALD HBKLDKCICEJ, AHKPLOLMABO GJEJKJANAJD, in HAMGOKKMMPI LPJDDLMPNCG, bool NDNBCLJHJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE270", Offset = "0x2DDD670", VA = "0x182DDE270")]
	[Conditional("UNITY_EDITOR")]
	public void AOHNFMIDDFO(KHMECMDAALD HBKLDKCICEJ, AHKPLOLMABO GJEJKJANAJD, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE3F0", Offset = "0x2DDD7F0", VA = "0x182DDE3F0")]
	[Conditional("UNITY_EDITOR")]
	public void BFBCCHACLPK(string AMNLGEBHFHK, object GJNIFGAPEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF1A0", Offset = "0x2DDE5A0", VA = "0x182DDF1A0")]
	[Conditional("UNITY_EDITOR")]
	public void PMKDCGOKBHF(AJGHFPGHPHG OGFDNCPKECB, ReadOnlyMemory<byte> GJNIFGAPEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2DDEC90", Offset = "0x2DDE090", VA = "0x182DDEC90")]
	[Conditional("UNITY_EDITOR")]
	public void ILGFGKEGAIP(World ACFGKGFDFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF070", Offset = "0x2DDE470", VA = "0x182DDF070")]
	[Conditional("UNITY_EDITOR")]
	public void MMMBMKAFPCH(World ACFGKGFDFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public FOLBIIPDBJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[HAMPPOKOPOP(typeof(OMPOCFBEAJG), new string[] { })]
public class LHCIBBFMEIC : OMPOCFBEAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x296AAD0", Offset = "0x2969ED0", VA = "0x18296AAD0", Slot = "5")]
	public void FHOOHLBLACA(object BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x296ACB0", Offset = "0x296A0B0", VA = "0x18296ACB0", Slot = "6")]
	public void OPNFAPPAAHA(object BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x296ABC0", Offset = "0x2969FC0", VA = "0x18296ABC0", Slot = "7")]
	public void MEEAPNCKCCB(object BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x296A9B0", Offset = "0x2969DB0", VA = "0x18296A9B0", Slot = "4")]
	public IDisposable FFLCBOKHBEO(object BALNMHDNCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public LHCIBBFMEIC()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Serialization)]
	[HAMPPOKOPOP(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	internal class BulkInstantiateSceneObjectService : GBCNOEIKEOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string JAKNKGCLCMH = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[OMAMNFHDGBM]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM GHDOFHADNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[OMAMNFHDGBM]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[OMAMNFHDGBM]
		private AMBNPJKGCOF HFKINOFBOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private EntityQuery FNLMKLMEEMK;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2FB44E0", Offset = "0x2FB38E0", VA = "0x182FB44E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3890", Offset = "0x2FB2C90", VA = "0x182FB3890", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3880", Offset = "0x2FB2C80", VA = "0x182FB3880", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3F40", Offset = "0x2FB3340", VA = "0x182FB3F40")]
		public bool IAKKNNBJDOH(IEnumerable<BMLJODFLIKN> LCIODACOIFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2FB4530", Offset = "0x2FB3930", VA = "0x182FB4530")]
		public static bool KLKAOHLENHA(BMLJODFLIKN FLDKBCEOGMK, out KHMECMDAALD HBKLDKCICEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3500", Offset = "0x2FB2900", VA = "0x182FB3500")]
		private void DOAJOGHAOBC(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB, IEnumerable<BMLJODFLIKN> LCIODACOIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2FB4640", Offset = "0x2FB3A40", VA = "0x182FB4640")]
		private void NFPOGBIOOJI(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2FB4060", Offset = "0x2FB3460", VA = "0x182FB4060")]
		private void ICKOEHOHMEP(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB, KHMECMDAALD HBKLDKCICEJ, string AMNLGEBHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3BE0", Offset = "0x2FB2FE0", VA = "0x182FB3BE0")]
		private void HLJMFHAPNOM(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2FB29F0", Offset = "0x2FB1DF0", VA = "0x182FB29F0")]
		private void BMHAFEDOAIG(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB, List<BMLJODFLIKN> CIKHIHLMGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3A10", Offset = "0x2FB2E10", VA = "0x182FB3A10")]
		private NativeList<KHMECMDAALD> GHHPBIGBFHB(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB)
		{
			return default(NativeList<KHMECMDAALD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3290", Offset = "0x2FB2690", VA = "0x182FB3290")]
		private NativeArray<Entity> CFPCEDGKIDC(NativeList<KHMECMDAALD> JENPCIBFABJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3460", Offset = "0x2FB2860", VA = "0x182FB3460")]
		private static void CHJFGMJLAIG(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB, KHMECMDAALD HBKLDKCICEJ, BMLJODFLIKN FLDKBCEOGMK, string AMNLGEBHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[DCBDIJCKLAD(IKIGKMLBEFF.Application)]
	[HAMPPOKOPOP(typeof(DebugWorldsService), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.Serialization)]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal static bool OEENHAMLKEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x2FC6F30", Offset = "0x2FC6330", VA = "0x182FC6F30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x2FC6EF0", Offset = "0x2FC62F0", VA = "0x182FC6EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool IDFICGLPIDA
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x2FC6FB0", Offset = "0x2FC63B0", VA = "0x182FC6FB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x2FC6F70", Offset = "0x2FC6370", VA = "0x182FC6F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		public void FDOOFFDPHJL(string AMNLGEBHFHK, EntityManager MABCFMECCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		public static void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[HAMPPOKOPOP(typeof(GFDALGCABGM), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.Application)]
internal class GFDALGCABGM
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool OEENHAMLKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B1910", Offset = "0x7B0D10", VA = "0x1807B1910")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0D40", VA = "0x1807B1940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool FGNLPJNLABH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8011E0", Offset = "0x8005E0", VA = "0x1808011E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA959A0", Offset = "0xA94DA0", VA = "0x180A959A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public GFDALGCABGM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[HAMPPOKOPOP(typeof(HNIIKODBKKD), new string[] { })]
	[AFHOMLJMOLI(typeof(SerializationService))]
	[JEGJCCBDMOE(OLCAJGBKOGB.Serialization)]
	internal class SerializationService : HNIIKODBKKD, IDisposable, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly KLBHBMBPLOA CFECLIGCGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[OMAMNFHDGBM]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[OMAMNFHDGBM]
		private BJINHAHEIOO ADLONPJHLHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[OMAMNFHDGBM]
		private GFDALGCABGM KBGCNJEEGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private BOEJNPPLNGC MHHGGFDNGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private DKLNHGPFNEC PCODIMJBAJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private SerializationRemapScope BOKADHKDELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool? OAFIJNIHLMJ;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool IBEFEMCBCCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2BCFDD0", Offset = "0x2BCF1D0", VA = "0x182BCFDD0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1640", Offset = "0x2BD0A40", VA = "0x182BD1640", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool MHHEFKPEDID
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xBCA970", Offset = "0xBC9D70", VA = "0x180BCA970", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x16A5AF0", Offset = "0x16A4EF0", VA = "0x1816A5AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public DKLNHGPFNEC FLJPALOIENA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFDF0", Offset = "0x2BCF1F0", VA = "0x182BCFDF0", Slot = "16")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFDE0", Offset = "0x2BCF1E0", VA = "0x182BCFDE0", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1150", Offset = "0x2BD0550", VA = "0x182BD1150")]
		public static bool LAKKFOOAFLA(ByteString EICPLPLLHGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B1920", Offset = "0x7B0D20", VA = "0x1807B1920")]
		public void CJOFDIBGDMM(BOEJNPPLNGC DEJCFCAINJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1280", Offset = "0x2BD0680", VA = "0x182BD1280", Slot = "5")]
		public void LOGAJLAGOFJ(bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1780", Offset = "0x2BD0B80", VA = "0x182BD1780", Slot = "6")]
		public Task PNPPFMJBEGG(bool EFCPHECCPHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2BD01B0", Offset = "0x2BCF5B0", VA = "0x182BD01B0", Slot = "7")]
		public ByteString HLHCEBOKDMG(out IDisposable BOKADHKDELF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0290", Offset = "0x2BCF690", VA = "0x182BD0290", Slot = "19")]
		public ByteString HLHCEBOKDMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0CF0", Offset = "0x2BD00F0", VA = "0x182BD0CF0", Slot = "9")]
		public bool JDGCKOHAIDJ(ByteString ONBFCOOCFOA, POJDIDMJDPL CAAHBOFLBKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFE90", Offset = "0x2BCF290", VA = "0x182BCFE90")]
		private bool HGGPFAICBGA(ByteString ONBFCOOCFOA, POJDIDMJDPL CAAHBOFLBKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0F80", Offset = "0x2BD0380", VA = "0x182BD0F80", Slot = "8")]
		public void KGDOHLOFGLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0A80", Offset = "0x2BCFE80", VA = "0x182BD0A80", Slot = "10")]
		public bool JCKGABHBCJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0470", Offset = "0x2BCF870", VA = "0x182BD0470", Slot = "11")]
		public bool IAKKNNBJDOH(IEnumerable<BMLJODFLIKN> JGGHOCFLFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF8B0", Offset = "0x2BCECB0", VA = "0x182BCF8B0")]
		public bool ANALFDAFLAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0D50", Offset = "0x2BD0150", VA = "0x182BD0D50", Slot = "12")]
		public bool JPJDNINPFFI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1350", Offset = "0x2BD0750", VA = "0x182BD1350")]
		public void MFPECCHOJNI(DKLNHGPFNEC.DEKMLIHHNED.HKJCHCPFJPL COEEJIEMCIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2BD07F0", Offset = "0x2BCFBF0", VA = "0x182BD07F0")]
		private bool IIBDCMKOIND(ByteString ONBFCOOCFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1700", Offset = "0x2BD0B00", VA = "0x182BD1700")]
		private void ONEAHBLDLCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2BD15E0", Offset = "0x2BD09E0", VA = "0x182BD15E0")]
		private ByteString NLHHOMBFPLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BD06E0", Offset = "0x2BCFAE0", VA = "0x182BD06E0")]
		private ByteString IBAGNILGFLI(ByteString EICPLPLLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFB60", Offset = "0x2BCEF60", VA = "0x182BCFB60")]
		private DKLNHGPFNEC.DEKMLIHHNED.HKJCHCPFJPL BGJKLCEKMLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1750", Offset = "0x2BD0B50", VA = "0x182BD1750")]
		private void OPELIDIKLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF990", Offset = "0x2BCED90", VA = "0x182BCF990", Slot = "13")]
		public bool BGHNIINFJBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1650", Offset = "0x2BD0A50", VA = "0x182BD1650", Slot = "14")]
		public void OIMBFBLLJAN(bool COEOEBHKOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFC00", Offset = "0x2BCF000", VA = "0x182BCFC00")]
		private void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[HAMPPOKOPOP(typeof(FBCAFMCBMPK), new string[] { })]
[AFHOMLJMOLI(typeof(BJINHAHEIOO))]
internal class BJINHAHEIOO : FBCAFMCBMPK
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action KBJLMOBAMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1950", Offset = "0x2FB0D50", VA = "0x182FB1950", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2FB14F0", Offset = "0x2FB08F0", VA = "0x182FB14F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<JPHKJJNABPK> FPICFLCPIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1630", Offset = "0x2FB0A30", VA = "0x182FB1630", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2FB16D0", Offset = "0x2FB0AD0", VA = "0x182FB16D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action GHHOMKOFCDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1810", Offset = "0x2FB0C10", VA = "0x182FB1810", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1590", Offset = "0x2FB0990", VA = "0x182FB1590", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action OLLHMNBMFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2FB13B0", Offset = "0x2FB07B0", VA = "0x182FB13B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2FB18B0", Offset = "0x2FB0CB0", VA = "0x182FB18B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<JPHKJJNABPK> NHPEANCHECK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1450", Offset = "0x2FB0850", VA = "0x182FB1450", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1770", Offset = "0x2FB0B70", VA = "0x182FB1770", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0xCDC8D0", Offset = "0xCDBCD0", VA = "0x180CDC8D0")]
	public void KGDOHLOFGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xCDCD20", Offset = "0xCDC120", VA = "0x180CDCD20")]
	public void BOIKFIPMHMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0xCDC5A0", Offset = "0xCDB9A0", VA = "0x180CDC5A0")]
	public void OLGLICDJLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1A40", Offset = "0x2FB0E40", VA = "0x182FB1A40")]
	public void NCPIJGPAEFA(JPHKJJNABPK FIANHALABNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2FB19F0", Offset = "0x2FB0DF0", VA = "0x182FB19F0")]
	public void MJGOKLJLGOJ(JPHKJJNABPK FIANHALABNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public BJINHAHEIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[HAMPPOKOPOP(typeof(CLIHAPFPPDO), new string[] { })]
public class IENIHAANBKE : CLIHAPFPPDO, HBEOAMPLBKH, BJDLFHICAGD, GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityHierarchyParents EOPPFFEOLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private AMBCMIPCLOI EODGEOJGIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ObjectEmbodimentService MPIEEKNKAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public global::BHJMFFBJHCN<MBEDCJLMHEO> GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x77E9A0", Offset = "0x77DDA0", VA = "0x18077E9A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x77EAD0", Offset = "0x77DED0", VA = "0x18077EAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager BFILENFCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2DE7C70", Offset = "0x2DE7070", VA = "0x182DE7C70")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x14E1D00", Offset = "0x14E1100", VA = "0x1814E1D00", Slot = "14")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DE78B0", Offset = "0x2DE6CB0", VA = "0x182DE78B0", Slot = "15")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7E20", Offset = "0x2DE7220", VA = "0x182DE7E20", Slot = "16")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x14E1C30", Offset = "0x14E1030", VA = "0x1814E1C30", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2974690", Offset = "0x2973A90", VA = "0x182974690")]
	private MBEDCJLMHEO IFLEFNACDDH(Entity LCLDFKAJPDK)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7FE0", Offset = "0x2DE73E0", VA = "0x182DE7FE0", Slot = "4")]
	public MBEDCJLMHEO NKAKDLGIEDI(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8040", Offset = "0x2DE7440", VA = "0x182DE8040", Slot = "19")]
	public void PADFFCJKHOD(ref List<MBEDCJLMHEO> NNDAPMCFFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7460", Offset = "0x2DE6860", VA = "0x182DE7460", Slot = "20")]
	public IEnumerable<MBEDCJLMHEO> CMGIHGILOAF(MBEDCJLMHEO LKHNLAILFFL, bool PNGNAFIFALL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2DE70F0", Offset = "0x2DE64F0", VA = "0x182DE70F0", Slot = "21")]
	public MBEDCJLMHEO AFFCJINMNLA(MBEDCJLMHEO LKHNLAILFFL, int EGNHJGKABLC)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7B50", Offset = "0x2DE6F50", VA = "0x182DE7B50", Slot = "22")]
	public int ILEAONCNDBH(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7980", Offset = "0x2DE6D80", VA = "0x182DE7980", Slot = "8")]
	public int FOLBFCNBPGG(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7CC0", Offset = "0x2DE70C0", VA = "0x182DE7CC0", Slot = "9")]
	public GKNDEBMEIID LBBKCNNGHFP(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(GKNDEBMEIID);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2DE76B0", Offset = "0x2DE6AB0", VA = "0x182DE76B0", Slot = "23")]
	public bool FFJNEFEMNPN(MBEDCJLMHEO LKHNLAILFFL, out GKNDEBMEIID KOGMIHECDBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7390", Offset = "0x2DE6790", VA = "0x182DE7390", Slot = "24")]
	public IEnumerable<MBEDCJLMHEO> CEAEBLDPEEN(MBEDCJLMHEO LKHNLAILFFL, bool PNGNAFIFALL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2DE72C0", Offset = "0x2DE66C0", VA = "0x182DE72C0", Slot = "12")]
	public MBEDCJLMHEO AFNHNOEFCOI(MBEDCJLMHEO AGDKLNJDAPF, MBEDCJLMHEO NMPDJFDFMIN)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2DE75E0", Offset = "0x2DE69E0", VA = "0x182DE75E0", Slot = "13")]
	public bool EDCKHKPPKHK(MBEDCJLMHEO AGDKLNJDAPF, MBEDCJLMHEO NMPDJFDFMIN, out MBEDCJLMHEO NFENBCEFMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7F40", Offset = "0x2DE7340", VA = "0x182DE7F40", Slot = "5")]
	public MBEDCJLMHEO NGLDHLBMECO(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7880", Offset = "0x2DE6C80", VA = "0x182DE7880", Slot = "11")]
	public bool FFKLPDDAEHN(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO NLBEDCCLIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7B20", Offset = "0x2DE6F20", VA = "0x182DE7B20", Slot = "25")]
	public bool HMKPBKJMFKD(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO ILLPMKANGKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7F10", Offset = "0x2DE7310", VA = "0x182DE7F10", Slot = "10")]
	public bool NBCMHKFAKCC(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO AGDKLNJDAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7530", Offset = "0x2DE6930", VA = "0x182DE7530", Slot = "6")]
	public bool DEIBNNOCJKC(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO GGEKFPEBLKN, bool NFCHCDFCFMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7DB0", Offset = "0x2DE71B0", VA = "0x182DE7DB0", Slot = "7")]
	public bool LGLAJNBPHCD(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO GGEKFPEBLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public IENIHAANBKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
[HAMPPOKOPOP(typeof(IMDHGBFPAOD), new string[] { })]
internal class IMDHGBFPAOD : GBCNOEIKEOL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[OMAMNFHDGBM]
	private JIGOCJGIGJA FNBGFGCHFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<int, HBFGHIOELIO> JGMGHKIGDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB8C0", Offset = "0x2DEACC0", VA = "0x182DEB8C0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB640", Offset = "0x2DEAA40", VA = "0x182DEB640", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB540", Offset = "0x2DEA940", VA = "0x182DEB540")]
	public HBFGHIOELIO CKDGICHNPCA(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB320", Offset = "0x2DEA720", VA = "0x182DEB320")]
	public HBFGHIOELIO CKDGICHNPCA(AHKPLOLMABO CBPECCEKJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB190", Offset = "0x2DEA590", VA = "0x182DEB190")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB910", Offset = "0x2DEAD10", VA = "0x182DEB910")]
	public IMDHGBFPAOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class HBFGHIOELIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<BCAIIOMBBGG> OEPECLFHJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private NativeList<LBCACEFDDPD> KLAEADJPMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeList<EBCGMCIBBDB> JDALMNBHCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<LBCACEFDDPD> JIAFKIGMPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<BCAIIOMBBGG> LDIMGEKMIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9F0", Offset = "0xA3DDF0", VA = "0x180A3E9F0")]
		get
		{
			return default(NativeList<BCAIIOMBBGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<LBCACEFDDPD> PIAHFLGFADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xB04540", Offset = "0xB03940", VA = "0x180B04540")]
		get
		{
			return default(NativeList<LBCACEFDDPD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<EBCGMCIBBDB> FPIAPMGLLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xCCB560", Offset = "0xCCA960", VA = "0x180CCB560")]
		get
		{
			return default(NativeList<EBCGMCIBBDB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<LBCACEFDDPD> OOPLJEAECKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xDD7710", Offset = "0xDD6B10", VA = "0x180DD7710")]
		get
		{
			return default(NativeList<LBCACEFDDPD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle KICFFBDCCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x118F350", Offset = "0x118E750", VA = "0x18118F350")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x15D5D50", Offset = "0x15D5150", VA = "0x1815D5D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool AMOPNJPCIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x13E3880", Offset = "0x13E2C80", VA = "0x1813E3880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool MJGLDBCMJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2DE16F0", Offset = "0x2DE0AF0", VA = "0x182DE16F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1960", Offset = "0x2DE0D60", VA = "0x182DE1960")]
	public HBFGHIOELIO(Allocator FKHAEPDPDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2DE18D0", Offset = "0x2DE0CD0", VA = "0x182DE18D0")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2DE17A0", Offset = "0x2DE0BA0", VA = "0x182DE17A0")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2DE13C0", Offset = "0x2DE07C0", VA = "0x182DE13C0")]
	public void AGMLDLCGDGN(Entity LCLDFKAJPDK, Entity LOFGAAGHIJI, Entity BJNIPOLNMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[HAMPPOKOPOP(typeof(GFILFHHOKJA), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
public class GFILFHHOKJA : GBCNOEIKEOL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[OMAMNFHDGBM]
	private SceneService EDPMKCELNON;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFB10", Offset = "0x2DDEF10", VA = "0x182DDFB10", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFAF0", Offset = "0x2DDEEF0", VA = "0x182DDFAF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public GFILFHHOKJA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[HAMPPOKOPOP(typeof(PhotonInstanceCleanupService), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.Lifecycle)]
	[DCBDIJCKLAD(IKIGKMLBEFF.PhotonRoom)]
	public class PhotonInstanceCleanupService : GBCNOEIKEOL, BJDLFHICAGD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private LOFJFJMIAMG HGHLKFIAIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private LPHNFCPFJBF KHKOGBBOGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeList<int> LOEHLMGBKLM;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2981800", Offset = "0x2980C00", VA = "0x182981800", Slot = "5")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2981B60", Offset = "0x2980F60", VA = "0x182981B60", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2981C10", Offset = "0x2981010", VA = "0x182981C10")]
		public void LOIIDKBBIDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2981A70", Offset = "0x2980E70", VA = "0x182981A70", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2981860", Offset = "0x2980C60", VA = "0x182981860")]
		public void DPHIICBNAFD(global::GMANFPIPMBB<int> MODCBBJJAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2981BD0", Offset = "0x2980FD0", VA = "0x182981BD0")]
		public void KAEKDKOONGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PhotonInstanceCleanupService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal abstract class HPMCOHOPHAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private uint KCJGILDDOPE;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public abstract uint EOEAHOFNGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xAF8350", Offset = "0xAF7750", VA = "0x180AF8350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2DE45E0", Offset = "0x2DE39E0", VA = "0x182DE45E0")]
	public KHMECMDAALD FBPBDBBLOOA()
	{
		return default(KHMECMDAALD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2DE4530", Offset = "0x2DE3930", VA = "0x182DE4530")]
	public void AKEEEJIMJIC(KHMECMDAALD HBKLDKCICEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x11BC490", Offset = "0x11BB890", VA = "0x1811BC490", Slot = "6")]
	public virtual void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	protected HPMCOHOPHAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
[HAMPPOKOPOP(typeof(PKFMHONIPFJ), new string[] { })]
internal sealed class PKFMHONIPFJ : HPMCOHOPHAM, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[OMAMNFHDGBM]
	private BFHOGDONKCB NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private uint ENNAKHLEBJN;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override uint EOEAHOFNGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x735750", Offset = "0x734B50", VA = "0x180735750", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2980C80", Offset = "0x2980080", VA = "0x182980C80", Slot = "7")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2980D20", Offset = "0x2980120", VA = "0x182980D20")]
	private void IEOEJLMBMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2980D70", Offset = "0x2980170", VA = "0x182980D70", Slot = "6")]
	public override void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
	public PKFMHONIPFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HAMPPOKOPOP(typeof(NFEKAMEEIBH), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
internal sealed class NFEKAMEEIBH : HPMCOHOPHAM
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint EOEAHOFNGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
	public NFEKAMEEIBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
[HAMPPOKOPOP(typeof(ONJBKOIKDCG), new string[] { })]
internal sealed class ONJBKOIKDCG : HBEOAMPLBKH, BJDLFHICAGD, GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[OMAMNFHDGBM]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery DJAIJCNANNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery AECEPIKDCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery HBICJEJPAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery IBJALOJPGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery DILKLHJLHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery JCHCEAHOMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private EntityManager BFILENFCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2972CB0", Offset = "0x29720B0", VA = "0x182972CB0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery ILGKIBHLIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x735A00", Offset = "0x734E00", VA = "0x180735A00")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery PBMEJFAFIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7359F0", Offset = "0x734DF0", VA = "0x1807359F0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery GHJEMIAOOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x10C6D70", Offset = "0x10C6170", VA = "0x1810C6D70")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery BFPEBJKLIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x118F350", Offset = "0x118E750", VA = "0x18118F350")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery LCAJPMDFBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x14F6EE0", Offset = "0x14F62E0", VA = "0x1814F6EE0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery AEMHBANALGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2973220", Offset = "0x2972620", VA = "0x182973220")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int HDHBHHLNBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2972B30", Offset = "0x2971F30", VA = "0x182972B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int IHMDCDCEGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2972950", Offset = "0x2971D50", VA = "0x182972950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int LJPOFJDGCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2972C90", Offset = "0x2972090", VA = "0x182972C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int OFFFLBBKILE
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2972D00", Offset = "0x2972100", VA = "0x182972D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int MDOIOGDICPN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2972C70", Offset = "0x2972070", VA = "0x182972C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int KGPAICNOICC
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2972B50", Offset = "0x2971F50", VA = "0x182972B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "4")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2972C20", Offset = "0x2972020", VA = "0x182972C20", Slot = "5")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2972D20", Offset = "0x2972120", VA = "0x182972D20", Slot = "6")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x29731C0", Offset = "0x29725C0", VA = "0x1829731C0")]
	private EntityQueryDesc NCAIOHNGJPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2972AD0", Offset = "0x2971ED0", VA = "0x182972AD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2972A20", Offset = "0x2971E20", VA = "0x182972A20")]
	public BDPFCKONNMG CNLDDDHJFJE(MBEDCJLMHEO LMLBLIDPKCN)
	{
		return default(BDPFCKONNMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2972970", Offset = "0x2971D70", VA = "0x182972970")]
	public BDPFCKONNMG CNLDDDHJFJE(Entity LCLDFKAJPDK)
	{
		return default(BDPFCKONNMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2972B70", Offset = "0x2971F70", VA = "0x182972B70")]
	public GODNFBOIBNJ FKGBCFJDCGK(Entity LCLDFKAJPDK)
	{
		return default(GODNFBOIBNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x29732A0", Offset = "0x29726A0", VA = "0x1829732A0")]
	public ONJBKOIKDCG()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[JEGJCCBDMOE(OLCAJGBKOGB.All)]
	[HAMPPOKOPOP(typeof(DDOLHFHMLOP), new string[] { })]
	public class ObjectService : GBCNOEIKEOL, DDOLHFHMLOP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly KLBHBMBPLOA IHJIENPFPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[OMAMNFHDGBM]
		private JDFPNHDAOJJ DFKHIBLIHPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[OMAMNFHDGBM]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[OMAMNFHDGBM]
		private ObjectLifecycleService LCMHIEKJLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[OMAMNFHDGBM]
		private ObjectEmbodimentService MPIEEKNKAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[OMAMNFHDGBM]
		private ObjectInstantiationService IIPJHFKNDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[OMAMNFHDGBM]
		private ONJBKOIKDCG EODGEOJGIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ObjectNetworkToLocalMapService PJFKIMDFNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public JDFPNHDAOJJ HHNOCIKFPBE
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int HDHBHHLNBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x297DAE0", Offset = "0x297CEE0", VA = "0x18297DAE0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int IHMDCDCEGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x297D640", Offset = "0x297CA40", VA = "0x18297D640", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int LJPOFJDGCEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x297EC00", Offset = "0x297E000", VA = "0x18297EC00", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int OFFFLBBKILE
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x297EC80", Offset = "0x297E080", VA = "0x18297EC80", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int MDOIOGDICPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x297E980", Offset = "0x297DD80", VA = "0x18297E980", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int KGPAICNOICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x297DB90", Offset = "0x297CF90", VA = "0x18297DB90", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<MBEDCJLMHEO, GODNFBOIBNJ> NDEJJCMOJOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x297EB60", Offset = "0x297DF60", VA = "0x18297EB60", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x297D3E0", Offset = "0x297C7E0", VA = "0x18297D3E0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<MBEDCJLMHEO> KNEJPGEJOOE
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x297D220", Offset = "0x297C620", VA = "0x18297D220", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x297D2C0", Offset = "0x297C6C0", VA = "0x18297D2C0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x297DF70", Offset = "0x297D370", VA = "0x18297DF70", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x297D960", Offset = "0x297CD60", VA = "0x18297D960", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x297D480", Offset = "0x297C880", VA = "0x18297D480")]
		private void BHFLAOMNNIM(Entity LCLDFKAJPDK, GODNFBOIBNJ KLFAINNONJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x297F010", Offset = "0x297E410", VA = "0x18297F010")]
		private void OLDMMPMDNME(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x297E730", Offset = "0x297DB30", VA = "0x18297E730")]
		internal MBEDCJLMHEO IFLEFNACDDH(Entity LCLDFKAJPDK)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x297DD70", Offset = "0x297D170", VA = "0x18297DD70", Slot = "41")]
		public GKNDEBMEIID FIHFHPIKDOE()
		{
			return default(GKNDEBMEIID);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x297E3F0", Offset = "0x297D7F0", VA = "0x18297E3F0", Slot = "42")]
		public GKNDEBMEIID HCMEACAGEBA()
		{
			return default(GKNDEBMEIID);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x297E750", Offset = "0x297DB50", VA = "0x18297E750", Slot = "43")]
		public GKNDEBMEIID IPJEPCFEEGL()
		{
			return default(GKNDEBMEIID);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x297D730", Offset = "0x297CB30", VA = "0x18297D730", Slot = "10")]
		public BDPFCKONNMG CNLDDDHJFJE(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(BDPFCKONNMG);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x297DEA0", Offset = "0x297D2A0", VA = "0x18297DEA0", Slot = "11")]
		public GODNFBOIBNJ FKGBCFJDCGK(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(GODNFBOIBNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x297EE00", Offset = "0x297E200", VA = "0x18297EE00")]
		private GKNDEBMEIID MOCHLPAFENL(EntityQuery ANBHGOBNOFE)
		{
			return default(GKNDEBMEIID);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x297DE10", Offset = "0x297D210", VA = "0x18297DE10", Slot = "33")]
		public bool FIKLEKNKGJP(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x297E7F0", Offset = "0x297DBF0", VA = "0x18297E7F0", Slot = "29")]
		public void JALMAFNAIBH(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x297E500", Offset = "0x297D900", VA = "0x18297E500", Slot = "30")]
		public void HDLFCKJDPBO(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x297EEB0", Offset = "0x297E2B0", VA = "0x18297EEB0", Slot = "31")]
		public void NAMPHNFBBEJ(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x297E330", Offset = "0x297D730", VA = "0x18297E330", Slot = "22")]
		public EMFDOJECCDF FMBHGNBEDKM(GODNFBOIBNJ KLFAINNONJC, bool GKHKAHGPIJJ)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x297E280", Offset = "0x297D680", VA = "0x18297E280", Slot = "23")]
		public EMFDOJECCDF FMBHGNBEDKM(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x297F110", Offset = "0x297E510", VA = "0x18297F110", Slot = "24")]
		public EMFDOJECCDF PFNKHCBELDA(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x297F240", Offset = "0x297E640", VA = "0x18297F240", Slot = "25")]
		public EMFDOJECCDF PLLGILFFNLD(KHMECMDAALD HBKLDKCICEJ, GODNFBOIBNJ KLFAINNONJC)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x297D7F0", Offset = "0x297CBF0", VA = "0x18297D7F0", Slot = "44")]
		public EMFDOJECCDF DBMENANGLFB(int PMIJHDHOHOF, GODNFBOIBNJ KLFAINNONJC, GameObject DLNMCGFEPOP)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x297D670", Offset = "0x297CA70", VA = "0x18297D670", Slot = "26")]
		public NCAJJMMMNLG CIPMNLGHOOM()
		{
			return default(NCAJJMMMNLG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x297D520", Offset = "0x297C920", VA = "0x18297D520", Slot = "45")]
		public JJCNHDGDNMH BHGFCNAGJLA(ECHOKHJACKM OGILDIMGIOH)
		{
			return default(JJCNHDGDNMH);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x297E650", Offset = "0x297DA50", VA = "0x18297E650", Slot = "27")]
		public LNEELJPGMBI HNGEDIPEFKF()
		{
			return default(LNEELJPGMBI);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x297E840", Offset = "0x297DC40", VA = "0x18297E840", Slot = "28")]
		public NAAJAJPNJEO JHOHELNIPGN(LFEIHDPDPKH OGILDIMGIOH)
		{
			return default(NAAJAJPNJEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x297DB70", Offset = "0x297CF70", VA = "0x18297DB70", Slot = "12")]
		public void EHOMCGHPBHE(KHMECMDAALD HBKLDKCICEJ, APKFPLGDLPH CNEFEEJPMMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x297DBC0", Offset = "0x297CFC0", VA = "0x18297DBC0", Slot = "13")]
		public EMFDOJECCDF EKICMIMOHBL(MBEDCJLMHEO LKHNLAILFFL, [Optional] object MIFCLBEAOPM)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x297F1A0", Offset = "0x297E5A0", VA = "0x18297F1A0", Slot = "14")]
		public bool PHONMIEGPBF(MBEDCJLMHEO LKHNLAILFFL, out APKFPLGDLPH JGINNNKFHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x297D910", Offset = "0x297CD10", VA = "0x18297D910", Slot = "46")]
		public Transform DHHOPPBKOBH(MBEDCJLMHEO LKHNLAILFFL, [Optional] object MIFCLBEAOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x297EC30", Offset = "0x297E030", VA = "0x18297EC30", Slot = "16")]
		public bool KGFFBHKEPBA(MBEDCJLMHEO LKHNLAILFFL, out Transform CACALPHNCBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x297D8C0", Offset = "0x297CCC0", VA = "0x18297D8C0", Slot = "17")]
		public bool DGBCKPEIJJH(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x297ECE0", Offset = "0x297E0E0", VA = "0x18297ECE0")]
		public bool LFIKAPHEHNB(APKFPLGDLPH LPJDDLMPNCG, [Optional] object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x297ECB0", Offset = "0x297E0B0", VA = "0x18297ECB0", Slot = "47")]
		public bool LFIKAPHEHNB(MBEDCJLMHEO LKHNLAILFFL, [Optional] object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x297DB50", Offset = "0x297CF50", VA = "0x18297DB50", Slot = "48")]
		public void EHGKANMEAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x297E9B0", Offset = "0x297DDB0", VA = "0x18297E9B0", Slot = "15")]
		public void JINAKIKBBNA(APKFPLGDLPH NBNOMDAKOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x297DB10", Offset = "0x297CF10", VA = "0x18297DB10", Slot = "49")]
		public void EDFNPEPIDIC(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x297D360", Offset = "0x297C760", VA = "0x18297D360", Slot = "18")]
		public bool BALOOPDBMDO(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x297ED10", Offset = "0x297E110", VA = "0x18297ED10", Slot = "19")]
		public bool LGIJADFEFLD(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x297ED90", Offset = "0x297E190", VA = "0x18297ED90", Slot = "50")]
		public bool MFDJBBJBCKH(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x297F0A0", Offset = "0x297E4A0", VA = "0x18297F0A0", Slot = "51")]
		public bool OOCDJKEDMNO(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x297D860", Offset = "0x297CC60", VA = "0x18297D860", Slot = "32")]
		public NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)> DBMKBBAHMAH(NativeArray<MBEDCJLMHEO> HNAFJFFPIOE, Allocator FKHAEPDPDAI)
		{
			return default(NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x297E1E0", Offset = "0x297D5E0", VA = "0x18297E1E0", Slot = "21")]
		public KHMECMDAALD FLJOHMEAAKD(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(KHMECMDAALD);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x297E560", Offset = "0x297D960", VA = "0x18297E560", Slot = "20")]
		public MBEDCJLMHEO HKKALCMCNLF(KHMECMDAALD HBKLDKCICEJ)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x297EF50", Offset = "0x297E350", VA = "0x18297EF50")]
		private void ODMDPMLLGAD(GODNFBOIBNJ KLFAINNONJC, MBEDCJLMHEO LKHNLAILFFL, KHMECMDAALD HBKLDKCICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
[HAMPPOKOPOP(typeof(KGKMOEPDGKA), new string[] { })]
internal sealed class KGKMOEPDGKA : GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private ObjectInstantiationService IIPJHFKNDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[OMAMNFHDGBM]
	private ONJBKOIKDCG EODGEOJGIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[OMAMNFHDGBM]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3CB0", Offset = "0x2DF30B0", VA = "0x182DF3CB0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3720", Offset = "0x2DF2B20", VA = "0x182DF3720")]
	public NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)> DBMKBBAHMAH(NativeArray<MBEDCJLMHEO> HNAFJFFPIOE, Allocator FKHAEPDPDAI)
	{
		return default(NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3D40", Offset = "0x2DF3140", VA = "0x182DF3D40")]
	private void MOFMOGBMPMO(NativeMultiHashMap<int, (MBEDCJLMHEO src, MBEDCJLMHEO dst)> ODJEPGAJPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3820", Offset = "0x2DF2C20", VA = "0x182DF3820")]
	private void FBAAJFDJOAL(NativeMultiHashMap<int, (MBEDCJLMHEO src, MBEDCJLMHEO dst)> ODJEPGAJPAF, int KLFAINNONJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2DF32B0", Offset = "0x2DF26B0", VA = "0x182DF32B0")]
	private void CPHPKOOGEPE(NativeMultiHashMap<int, (MBEDCJLMHEO src, MBEDCJLMHEO dst)> ODJEPGAJPAF, int KLFAINNONJC, HOOPFMCFMDE FNBGFGCHFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3440", Offset = "0x2DF2840", VA = "0x182DF3440")]
	private NativeMultiHashMap<int, (MBEDCJLMHEO, MBEDCJLMHEO)> DBBCBGIHNIK(Allocator FKHAEPDPDAI, NativeArray<MBEDCJLMHEO> HNAFJFFPIOE, out NativeArray<(MBEDCJLMHEO src, MBEDCJLMHEO dst)> AOBIHALIFEN)
	{
		return default(NativeMultiHashMap<int, (MBEDCJLMHEO, MBEDCJLMHEO)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KGKMOEPDGKA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[JEGJCCBDMOE(OLCAJGBKOGB.TransformSyncing)]
	[AFHOMLJMOLI(typeof(TransformService))]
	[HAMPPOKOPOP(typeof(AMBNPJKGCOF), new string[] { })]
	public class TransformService : AMBNPJKGCOF, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly KLBHBMBPLOA KNDAOAFIEIE;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly KLBHBMBPLOA KGJDFKNBGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private ICKDLDAIKCD OOCMFKEPGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private BHHDNNCMGLM ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private CLIHAPFPPDO BKOBOKBHBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TransformOwnershipPhase AHLFEPAKGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ObjectEmbodimentService HAJHHEFGJLE;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x2BDAAB0", Offset = "0x2BD9EB0", VA = "0x182BDAAB0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private PHIPKIFAENI PDFOFNPFHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x2BDAE10", Offset = "0x2BDA210", VA = "0x182BDAE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8E60", Offset = "0x2BD8260", VA = "0x182BD8E60", Slot = "33")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7590", Offset = "0x2BD6990", VA = "0x182BD7590", Slot = "34")]
		public bool ANOEAMLDKOO(Transform CACALPHNCBH, out MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9310", Offset = "0x2BD8710", VA = "0x182BD9310", Slot = "35")]
		public Transform GEBNBHFHKBB(Entity LCLDFKAJPDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAB00", Offset = "0x2BD9F00", VA = "0x182BDAB00", Slot = "30")]
		public bool KGFFBHKEPBA(Entity LCLDFKAJPDK, out Transform CACALPHNCBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD98C0", Offset = "0x2BD8CC0", VA = "0x182BD98C0")]
		private void HCKCKECDNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7750", Offset = "0x2BD6B50", VA = "0x182BD7750", Slot = "29")]
		public void BIAJBLEHIDE(Entity LCLDFKAJPDK, out Matrix4x4 IEBPCDDDDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA470", Offset = "0x2BD9870", VA = "0x182BDA470", Slot = "4")]
		public void JBMEJJDGLKC(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA9E0", Offset = "0x2BD9DE0", VA = "0x182BDA9E0")]
		public void KDLFDECFOOE(Entity LCLDFKAJPDK, Vector3 KPEIOCLIHAH, Quaternion LOFMMAJIGJA, Vector3 NINOFHJAAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2BD83E0", Offset = "0x2BD77E0", VA = "0x182BD83E0")]
		public void DLHLCKFJCJC(Entity LCLDFKAJPDK, Vector3 KPEIOCLIHAH, Quaternion LOFMMAJIGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8010", Offset = "0x2BD7410", VA = "0x182BD8010", Slot = "27")]
		public void CMIIDOENKIB(Entity LCLDFKAJPDK, out Matrix4x4 JHHKIHMHCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8020", Offset = "0x2BD7420", VA = "0x182BD8020")]
		public void DFGDFPIMAIA(Entity LCLDFKAJPDK, in Matrix4x4 IEBPCDDDDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBE60", Offset = "0x2BDB260", VA = "0x182BDBE60")]
		public void OHNOPHPCMGB(Entity LCLDFKAJPDK, in Matrix4x4 IEBPCDDDDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC0D0", Offset = "0x2BDB4D0", VA = "0x182BDC0D0")]
		public void PHIPNHEMLHD(Entity LCLDFKAJPDK, in Matrix4x4 MFPAEIALJBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8890", Offset = "0x2BD7C90", VA = "0x182BD8890", Slot = "5")]
		public void ENJCMBFDOCN(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB0E0", Offset = "0x2BDA4E0", VA = "0x182BDB0E0", Slot = "6")]
		public Vector3 MGLKMFBJJJO(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9C20", Offset = "0x2BD9020", VA = "0x182BD9C20", Slot = "7")]
		public void HKJLMAEMPJL(Entity LCLDFKAJPDK, Quaternion LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAFF0", Offset = "0x2BDA3F0", VA = "0x182BDAFF0", Slot = "8")]
		public Quaternion MGKDEKAMFIK(Entity LCLDFKAJPDK)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAD10", Offset = "0x2BDA110", VA = "0x182BDAD10", Slot = "12")]
		public void KJNDNEEMEPE(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAEE0", Offset = "0x2BDA2E0", VA = "0x182BDAEE0", Slot = "11")]
		public Vector3 LMBPHPKOIIE(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA0F0", Offset = "0x2BD94F0", VA = "0x182BDA0F0")]
		public void ICCLKGEMNIJ(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA190", Offset = "0x2BD9590", VA = "0x182BDA190")]
		private Vector3 IJNECEMADJP(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBAA0", Offset = "0x2BDAEA0", VA = "0x182BDBAA0", Slot = "14")]
		public float NFKMPIKGOMK(Entity LCLDFKAJPDK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7970", Offset = "0x2BD6D70", VA = "0x182BD7970", Slot = "13")]
		public void BPGKJMGHFCP(Entity LCLDFKAJPDK, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2BD74A0", Offset = "0x2BD68A0", VA = "0x182BD74A0")]
		private float AHOEKDOFPDL(Entity LCLDFKAJPDK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2BD98E0", Offset = "0x2BD8CE0", VA = "0x182BD98E0")]
		public void HEHJHHHCLLI(Entity LCLDFKAJPDK, float NOPOHLIFOBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB320", Offset = "0x2BDA720", VA = "0x182BDB320", Slot = "16")]
		public Vector3 MIEGHDBEPFP(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7290", Offset = "0x2BD6690", VA = "0x182BD7290", Slot = "15")]
		public void ABOEGJAMAKF(Entity LCLDFKAJPDK, Vector3 FHPAIIENFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7A80", Offset = "0x2BD6E80", VA = "0x182BD7A80")]
		private Vector3 CAJOKKMJFJC(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2BD78A0", Offset = "0x2BD6CA0", VA = "0x182BD78A0")]
		public void BLJEKABEIFP(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA830", Offset = "0x2BD9C30", VA = "0x182BDA830")]
		[Conditional("DEBUG_BUILD")]
		private void JPLLBOBFFNO(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9D20", Offset = "0x2BD9120", VA = "0x182BD9D20", Slot = "36")]
		public void HMELKJLDAKP(Entity LCLDFKAJPDK, Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA660", Offset = "0x2BD9A60", VA = "0x182BDA660", Slot = "9")]
		public void JOFDDLBLBGK(Entity LCLDFKAJPDK, out Vector3 PICDPPHNNLH, out Quaternion IHCJBCJFELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB1F0", Offset = "0x2BDA5F0", VA = "0x182BDB1F0", Slot = "10")]
		public void MHKPHDAEAKB(Entity LCLDFKAJPDK, out Vector3 PICDPPHNNLH, out Quaternion IHCJBCJFELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD89B0", Offset = "0x2BD7DB0", VA = "0x182BD89B0", Slot = "37")]
		public void EPIGNDLPMLM(Entity LCLDFKAJPDK, Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9A60", Offset = "0x2BD8E60", VA = "0x182BD9A60")]
		public void HGGPFPNHOFA(Entity LCLDFKAJPDK, Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD84F0", Offset = "0x2BD78F0", VA = "0x182BD84F0", Slot = "17")]
		public void DMJNFFDPBKN(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8D80", Offset = "0x2BD8180", VA = "0x182BD8D80", Slot = "18")]
		public Vector3 FKDOPKDDHMF(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA230", Offset = "0x2BD9630", VA = "0x182BDA230", Slot = "19")]
		public void JAKPDFNLCHO(Entity LCLDFKAJPDK, Quaternion LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBD70", Offset = "0x2BDB170", VA = "0x182BDBD70", Slot = "20")]
		public Quaternion ODJCFLIEMJB(Entity LCLDFKAJPDK)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7BB0", Offset = "0x2BD6FB0", VA = "0x182BD7BB0", Slot = "22")]
		public void CKKEKOJAIHB(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9970", Offset = "0x2BD8D70", VA = "0x182BD9970", Slot = "21")]
		public Vector3 HFPPHOLJIBN(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8720", Offset = "0x2BD7B20", VA = "0x182BD8720", Slot = "23")]
		public void DPFFHDIBMOP(Entity LCLDFKAJPDK, float DFOHKDPDMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9E80", Offset = "0x2BD9280", VA = "0x182BD9E80", Slot = "24")]
		public float HOLALLCIGIB(Entity LCLDFKAJPDK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2BD93D0", Offset = "0x2BD87D0", VA = "0x182BD93D0", Slot = "25")]
		public void HACOEDCCHCG(Entity LCLDFKAJPDK, Vector3 GIIDNHCLPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBF90", Offset = "0x2BDB390", VA = "0x182BDBF90", Slot = "26")]
		public Vector3 OJPHFLPPBNB(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB400", Offset = "0x2BDA800", VA = "0x182BDB400", Slot = "31")]
		public void NBGBFKAPKMB(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9FA0", Offset = "0x2BD93A0", VA = "0x182BD9FA0")]
		private MBEDCJLMHEO ICCEPAOEIDF(Transform CACALPHNCBH)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBB40", Offset = "0x2BDAF40", VA = "0x182BDBB40")]
		private static TransformEntity NGOIFIJNHJH(GODNFBOIBNJ OGILDIMGIOH, GameObject JNONJGMFMNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2BDABF0", Offset = "0x2BD9FF0", VA = "0x182BDABF0", Slot = "32")]
		public void KIOFIHAAPLG(Entity LCLDFKAJPDK, Entity LOFGAAGHIJI, Entity BJNIPOLNMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA7B0", Offset = "0x2BD9BB0", VA = "0x182BDA7B0")]
		private GBBHKGHOJBF JOFDDLBLBGK(Entity LCLDFKAJPDK)
		{
			return default(GBBHKGHOJBF);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2BD73C0", Offset = "0x2BD67C0", VA = "0x182BD73C0")]
		private bool AFJCDFMCJLH(Entity LCLDFKAJPDK, out Entity GGEKFPEBLKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8BD0", Offset = "0x2BD7FD0", VA = "0x182BD8BD0")]
		private void FACMOPHDIAL(Entity LCLDFKAJPDK, out Matrix4x4 IEBPCDDDDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8F70", Offset = "0x2BD8370", VA = "0x182BD8F70")]
		private void FLJLPPIJLGB(Entity LCLDFKAJPDK, out Matrix4x4 MFPAEIALJBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAED0", Offset = "0x2BDA2D0", VA = "0x182BDAED0", Slot = "28")]
		private void LFDAOOFDHGB(Entity LCLDFKAJPDK, in Matrix4x4 JHHKIHMHCJE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
[HAMPPOKOPOP(typeof(DFBILPFAEEG), new string[] { })]
internal sealed class DFBILPFAEEG : GBCNOEIKEOL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[OMAMNFHDGBM]
	private BFHOGDONKCB NOHGMFJPJKL;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5330", Offset = "0x2FC4730", VA = "0x182FC5330", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC52C0", Offset = "0x2FC46C0", VA = "0x182FC52C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public DFBILPFAEEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
[HAMPPOKOPOP(typeof(MEPABEFJJDI), new string[] { })]
public class MEPABEFJJDI
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct POGGHNCPHIM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly MEPABEFJJDI GGEKFPEBLKN;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x439BFC0", Offset = "0x439B3C0", VA = "0x18439BFC0")]
		public POGGHNCPHIM(MEPABEFJJDI GGEKFPEBLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x439BFA0", Offset = "0x439B3A0", VA = "0x18439BFA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int DDIPGNABLGA;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool CMGOLCHPDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x128D9F0", Offset = "0x128CDF0", VA = "0x18128D9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action FAFIMLJNNIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x296C130", Offset = "0x296B530", VA = "0x18296C130")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x296C090", Offset = "0x296B490", VA = "0x18296C090")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x296C1D0", Offset = "0x296B5D0", VA = "0x18296C1D0")]
	public POGGHNCPHIM OKABAIPNHMA()
	{
		return default(POGGHNCPHIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1480E20", Offset = "0x1480220", VA = "0x181480E20")]
	public void ENLMEGIJPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x296C070", Offset = "0x296B470", VA = "0x18296C070")]
	public void CAKMAAHNNLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public MEPABEFJJDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[HAMPPOKOPOP(typeof(OAHBPGDADMG), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
public class OAHBPGDADMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int DDIPGNABLGA;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool OEENHAMLKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x14BFE40", Offset = "0x14BF240", VA = "0x1814BFE40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x953970", Offset = "0x952D70", VA = "0x180953970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public OAHBPGDADMG()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[HAMPPOKOPOP(typeof(EnableComponentSystemsInScope), new string[] { })]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	[JEGJCCBDMOE(OLCAJGBKOGB.ComponentSystemTypes)]
	public class EnableComponentSystemsInScope : GBCNOEIKEOL, OFGHLKBBKBB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct MLJHPCKPIBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private NativeArray<int> PGIOKMAFKEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private NativeArray<int> JDFBPHJNCCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private Dictionary<ComponentSystemBase, int> LAPCNIFNLJB;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x43979C0", Offset = "0x4396DC0", VA = "0x1843979C0")]
			public MLJHPCKPIBB(NativeArray<int> PGIOKMAFKEF, NativeArray<int> JDFBPHJNCCJ, Dictionary<ComponentSystemBase, int> LAPCNIFNLJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x4397740", Offset = "0x4396B40", VA = "0x184397740")]
			public void FKEPMIILPKG(IEnumerable<ComponentSystemBase> DFKHIBLIHPO, IKIGKMLBEFF FIPJNENCJMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class OFBLMEGCFOJ : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private ComponentSystemBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public EnableComponentSystemsInScope <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private int start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public int <>3__start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private int end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>3__end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
			[DebuggerHidden]
			public OFBLMEGCFOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x4399310", Offset = "0x4398710", VA = "0x184399310", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x43994E0", Offset = "0x43988E0", VA = "0x1843994E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x4399430", Offset = "0x4398830", VA = "0x184399430", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x4399430", Offset = "0x4398830", VA = "0x184399430", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const IKIGKMLBEFF FEOPPNKCDMO = IKIGKMLBEFF.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly KLBHBMBPLOA DHNBNFHKOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM GHDOFHADNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private World ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private FJEOEPCCLME JGMMDACFJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeArray<int> LNHDJHKDHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NativeArray<int> FFPJNOFDLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int NHBDMCDLELK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private IKIGKMLBEFF DKFGFIDIHIC;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6EA0", Offset = "0x2DD62A0", VA = "0x182DD6EA0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6E10", Offset = "0x2DD6210", VA = "0x182DD6E10", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7B20", Offset = "0x2DD6F20", VA = "0x182DD7B20")]
		[IteratorStateMachine(typeof(OFBLMEGCFOJ))]
		private IEnumerable<ComponentSystemBase> PJEELELNIJJ(int LOEMONDJCMM, int FHNIHLGHOIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6D40", Offset = "0x2DD6140", VA = "0x182DD6D40", Slot = "5")]
		public void CCCAANGKKJB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6A00", Offset = "0x2DD5E00", VA = "0x182DD6A00")]
		private void ABFKDFLIKKK(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6B50", Offset = "0x2DD5F50", VA = "0x182DD6B50")]
		public void ABFKDFLIKKK(IKIGKMLBEFF MJMOJANEIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7020", Offset = "0x2DD6420", VA = "0x182DD7020")]
		private void IOAIEHLOOOB(IKIGKMLBEFF MJMOJANEIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6C50", Offset = "0x2DD6050", VA = "0x182DD6C50")]
		private void BFBGOMEJCMJ(IKIGKMLBEFF MJMOJANEIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6CE0", Offset = "0x2DD60E0", VA = "0x182DD6CE0")]
		private void BGNODGEIMCE(IKIGKMLBEFF MJMOJANEIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7990", Offset = "0x2DD6D90", VA = "0x182DD7990")]
		private void NPNDPEOIBDD(int LOEMONDJCMM, int FHNIHLGHOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6F20", Offset = "0x2DD6320", VA = "0x182DD6F20")]
		private void HHABOMGLDEF(int LOEMONDJCMM, int FHNIHLGHOIB, bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7B00", Offset = "0x2DD6F00", VA = "0x182DD7B00")]
		private int PGKBDOJLGJJ(IKIGKMLBEFF MJMOJANEIJI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x2DD72B0", Offset = "0x2DD66B0", VA = "0x182DD72B0")]
		private bool KNKBJFIEPNH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7840", Offset = "0x2DD6C40", VA = "0x182DD7840")]
		private Dictionary<ComponentSystemBase, int> LAPEBDIDLCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6FE0", Offset = "0x2DD63E0", VA = "0x182DD6FE0")]
		private void IINEJHILOGC(NativeArray<int> PGIOKMAFKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7A50", Offset = "0x2DD6E50", VA = "0x182DD7A50")]
		private void PDAFFGGBMMC(NativeArray<int> JDFBPHJNCCJ, NativeArray<int> PGIOKMAFKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6D50", Offset = "0x2DD6150", VA = "0x182DD6D50")]
		private static IKIGKMLBEFF CMMJEHEAENG(Type OGILDIMGIOH, IKIGKMLBEFF LGCPJJBBDLH)
		{
			return default(IKIGKMLBEFF);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7C40", Offset = "0x2DD7040", VA = "0x182DD7C40")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6DB0", Offset = "0x2DD61B0", VA = "0x182DD6DB0")]
		[CompilerGenerated]
		private void DGNGMEDGKAG(GBCNOEIKEOL BKMJIJNEKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7930", Offset = "0x2DD6D30", VA = "0x182DD7930")]
		[CompilerGenerated]
		private void NPBOHDHIOHM(IJGJDJPFIAJ BKMJIJNEKAE)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[JEGJCCBDMOE(OLCAJGBKOGB.WorldService)]
	[HAMPPOKOPOP(typeof(FDCCILJEAIN), new string[] { })]
	public class TickService : GBCNOEIKEOL, FDCCILJEAIN
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly ProfilerMarker FMNBGBAMMEO;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ProfilerMarker EDHDPGLGBHH;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly ProfilerMarker BAFJMBFJLJL;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly ProfilerMarker PHDFMMKNNJO;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly ProfilerMarker CPIPNLFAEJP;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly ProfilerMarker EPIACDEDBKA;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly ProfilerMarker OBHEKMBGEAK;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly ProfilerMarker JHDFHINABCD;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly ProfilerMarker DBBLKLNJMFJ;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly ProfilerMarker CMNCPMNIFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM GHDOFHADNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[OMAMNFHDGBM]
		private HNIIKODBKKD GOBBGGBLGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[OMAMNFHDGBM]
		private GFDALGCABGM LPJAIJAHPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[OMAMNFHDGBM]
		private TransformOwnershipPhase BBFGLLAHILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[OMAMNFHDGBM]
		private TimeService BMDOHFOEMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private MKDEFAJNDJH ACFGKGFDFPL;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool JNGKEMBEDPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x2BD5B60", Offset = "0x2BD4F60", VA = "0x182BD5B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool CGHDMOJFHAK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2BD5F90", Offset = "0x2BD5390", VA = "0x182BD5F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool EPOEGFNGCBC
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x2BD5B60", Offset = "0x2BD4F60", VA = "0x182BD5B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool ODNLFCJEPLO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x2BD5B60", Offset = "0x2BD4F60", VA = "0x182BD5B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5D50", Offset = "0x2BD5150", VA = "0x182BD5D50", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BD61B0", Offset = "0x2BD55B0", VA = "0x182BD61B0", Slot = "14")]
		public void KELKNBJLCKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BD62D0", Offset = "0x2BD56D0", VA = "0x182BD62D0", Slot = "15")]
		public void KNCLOPNPPPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5EC0", Offset = "0x2BD52C0", VA = "0x182BD5EC0", Slot = "5")]
		public void GGAJJIABCDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5910", Offset = "0x2BD4D10", VA = "0x182BD5910", Slot = "6")]
		public void CCKLGGGOKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6030", Offset = "0x2BD5430", VA = "0x182BD6030", Slot = "7")]
		public void JJNLKDIEAMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BD63F0", Offset = "0x2BD57F0", VA = "0x182BD63F0", Slot = "8")]
		public void OCHBDEIBIOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5BD0", Offset = "0x2BD4FD0", VA = "0x182BD5BD0", Slot = "9")]
		public void FBFEIKPMFHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BD54D0", Offset = "0x2BD48D0", VA = "0x182BD54D0", Slot = "10")]
		public void ANNKCDNFBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5A90", Offset = "0x2BD4E90", VA = "0x182BD5A90", Slot = "11")]
		public void CGMEJIBOEEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "13")]
		public void ADDOOMCCINB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6570", Offset = "0x2BD5970", VA = "0x182BD6570", Slot = "12")]
		public void PEJPDMMCALD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[HAMPPOKOPOP(typeof(BHHDNNCMGLM), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.WorldService)]
	public class WorldService : BHHDNNCMGLM, IDisposable, BJDLFHICAGD, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private MKDEFAJNDJH ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private FOLBIIPDBJB KNOOGBNOMKA;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MKDEFAJNDJH LJDGEIMOGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public PHIPKIFAENI PDFOFNPFHNA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x296F090", Offset = "0x296E490", VA = "0x18296F090", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2BE4890", Offset = "0x2BE3C90", VA = "0x182BE4890", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool AMOPNJPCIDE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x72F260", Offset = "0x72E660", VA = "0x18072F260", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BE43F0", Offset = "0x2BE37F0", VA = "0x182BE43F0", Slot = "10")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4730", Offset = "0x2BE3B30", VA = "0x182BE4730", Slot = "11")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4780", Offset = "0x2BE3B80", VA = "0x182BE4780")]
		private void IDIKGABNBEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4500", Offset = "0x2BE3900", VA = "0x182BE4500", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BE43D0", Offset = "0x2BE37D0", VA = "0x182BE43D0", Slot = "8")]
		public ComponentSystemBase DBEBPEAGNJB(Type OGILDIMGIOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[HAMPPOKOPOP(typeof(MDIHCNNBEEC), new string[] { })]
public sealed class OKLHDBBNMAL : MDIHCNNBEEC, HBEOAMPLBKH, BJDLFHICAGD, GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class KEMLJDKDHNH : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x735A00", Offset = "0x734E00", VA = "0x180735A00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x43960A0", Offset = "0x43954A0", VA = "0x1843960A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x913060", Offset = "0x912460", VA = "0x180913060")]
		[DebuggerHidden]
		public KEMLJDKDHNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x4395D90", Offset = "0x4395190", VA = "0x184395D90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x4396060", Offset = "0x4395460", VA = "0x184396060", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x4395FC0", Offset = "0x43953C0", VA = "0x184395FC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x4395FC0", Offset = "0x43953C0", VA = "0x184395FC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[OMAMNFHDGBM]
	private ILADIFIOBIK FNBGFGCHFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly DPGGCLGJEJM OPLJOCLACLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Dictionary<string, KFAMFFBNBDO> IPHCLAMBJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Dictionary<int, EONMLKEIFOO> NKFCEPMCCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<PPBNAGHDKKA> DOBOAJIBKJC;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public EONMLKEIFOO JAIAOBOGNCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x29718C0", Offset = "0x2970CC0", VA = "0x1829718C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<PPBNAGHDKKA> GEDCKBGJGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2971A40", Offset = "0x2970E40", VA = "0x182971A40", Slot = "8")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2971E40", Offset = "0x2971240", VA = "0x182971E40", Slot = "9")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x29719B0", Offset = "0x2970DB0", VA = "0x1829719B0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2971AA0", Offset = "0x2970EA0", VA = "0x182971AA0", Slot = "6")]
	public bool HFLPPPJPPFB(PPBNAGHDKKA GJEJKJANAJD, out EONMLKEIFOO KJJMKJFNPPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2971390", Offset = "0x2970790", VA = "0x182971390")]
	private void AECLDAOPKNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2971B90", Offset = "0x2970F90", VA = "0x182971B90")]
	private void KEPBPBLJBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2971B30", Offset = "0x2970F30", VA = "0x182971B30")]
	private KFAMFFBNBDO ILBOHGGDLBB(string BOEEPHGJCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x29718C0", Offset = "0x2970CC0", VA = "0x1829718C0")]
	private KFAMFFBNBDO EBDCJLPADGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2971F60", Offset = "0x2971360", VA = "0x182971F60")]
	private KFAMFFBNBDO OPFFMEJHFBM(string BOEEPHGJCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2971D30", Offset = "0x2971130", VA = "0x182971D30")]
	private KFAMFFBNBDO KMNGBEDECEH(string CCJFOCJJBJG, string MIFCLBEAOPM, [Optional] KFAMFFBNBDO PEACMLAHANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2971770", Offset = "0x2970B70", VA = "0x182971770")]
	[IteratorStateMachine(typeof(KEMLJDKDHNH))]
	private IEnumerable<(string, string)> AOOLKBJPDDE(string BOEEPHGJCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2971720", Offset = "0x2970B20", VA = "0x182971720")]
	private bool AGCIABNPEKD(PPBNAGHDKKA GJEJKJANAJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x29717E0", Offset = "0x2970BE0", VA = "0x1829717E0")]
	private DPGGCLGJEJM BNMOMJINKEM(PPBNAGHDKKA GJEJKJANAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x29721D0", Offset = "0x29715D0", VA = "0x1829721D0")]
	private DPGGCLGJEJM PJMDKFFHMFO(PPBNAGHDKKA GJEJKJANAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2971920", Offset = "0x2970D20", VA = "0x182971920")]
	private DPGGCLGJEJM DFIEAADCIBJ(PPBNAGHDKKA GJEJKJANAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x25B7EE0", Offset = "0x25B72E0", VA = "0x1825B7EE0")]
	private T LNKJFDFNMEI<T>(PPBNAGHDKKA GJEJKJANAJD) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2971E60", Offset = "0x2971260", VA = "0x182971E60")]
	private FieldInfo NJMIFPHEHGP(PPBNAGHDKKA GJEJKJANAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2972220", Offset = "0x2971620", VA = "0x182972220")]
	public OKLHDBBNMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2971ED0", Offset = "0x29712D0", VA = "0x182971ED0")]
	[CompilerGenerated]
	private int OGAMEFKODJA(PPBNAGHDKKA HFOFADIOHHP, PPBNAGHDKKA GFCGIJPPCBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class KFAMFFBNBDO : EONMLKEIFOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly string IMGLEPAOIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly KFAMFFBNBDO PEACMLAHANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly List<KFAMFFBNBDO> DEAFCCDGDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly List<PPBNAGHDKKA> FNBGFGCHFDN;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string JKHFCFCKIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public EONMLKEIFOO MLJCCBIJDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<EONMLKEIFOO> HBGFCDLIBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<PPBNAGHDKKA> BDOBIEBIADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2900", Offset = "0x2DF1D00", VA = "0x182DF2900")]
	public KFAMFFBNBDO(string AMNLGEBHFHK, KFAMFFBNBDO GGEKFPEBLKN)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[HAMPPOKOPOP(typeof(OECKLJAFLCL), new string[] { })]
	[AFHOMLJMOLI(typeof(HistoryService))]
	[JEGJCCBDMOE(OLCAJGBKOGB.History)]
	public class HistoryService : GBCNOEIKEOL, IDisposable, OECKLJAFLCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private enum ILEGMNPFAOB
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private readonly struct ICEDKDOEOFC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly ILEGMNPFAOB ANAPHPFKODC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly HistoryService LHDJJEMNOIF;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x43948E0", Offset = "0x4393CE0", VA = "0x1843948E0")]
			public ICEDKDOEOFC(HistoryService LHDJJEMNOIF, bool HFOICHHBMOA, uint NHBDMCDLELK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x43948B0", Offset = "0x4393CB0", VA = "0x1843948B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public class HLPDAPBGAHJ
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct OPPGPJJNFJI : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private readonly HLPDAPBGAHJ DGJHENDBKJI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private readonly bool NAKCDNLAFIO;

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x4399D10", Offset = "0x4399110", VA = "0x184399D10")]
				public OPPGPJJNFJI(HLPDAPBGAHJ DGJHENDBKJI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x4391710", Offset = "0x4390B10", VA = "0x184391710", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct AMHCLMKFEHN : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private readonly HLPDAPBGAHJ DGJHENDBKJI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private readonly bool NAKCDNLAFIO;

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x4391740", Offset = "0x4390B40", VA = "0x184391740")]
				public AMHCLMKFEHN(HLPDAPBGAHJ DGJHENDBKJI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x4391710", Offset = "0x4390B10", VA = "0x184391710", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly HistoryService GGCACBKODOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private bool AKOOFLFCLAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int DBJFJOFAGMF;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x43942C0", Offset = "0x43936C0", VA = "0x1843942C0")]
			public HLPDAPBGAHJ(HistoryService GGCACBKODOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x43941F0", Offset = "0x43935F0", VA = "0x1843941F0")]
			public bool DOPLAFEBOLO(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x4394270", Offset = "0x4393670", VA = "0x184394270")]
			public AMHCLMKFEHN IPGHKHPLCMH()
			{
				return default(AMHCLMKFEHN);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x4394220", Offset = "0x4393620", VA = "0x184394220")]
			public OPPGPJJNFJI FDENNJBDAFB()
			{
				return default(OPPGPJJNFJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class GDDCDLFBOIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public GDDCDLFBOIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x43934D0", Offset = "0x43928D0", VA = "0x1843934D0")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class HFPFEJIJGHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public HFPFEJIJGHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x4393E30", Offset = "0x4393230", VA = "0x184393E30")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class NHDMFPLCLNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public NHDMFPLCLNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x4397E90", Offset = "0x4397290", VA = "0x184397E90")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly UndoAction GANEOPNPABO;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly RedoAction NMGMJLJKDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private OMIODPKIBFL MOLDFLJBPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ActionBuffer OLAIDLEJIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ActionBuffer MPFAJNNLFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private JNCEDOJAEEO GCAPKJMNGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TransformOwnershipPhase BBFGLLAHILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private PropertyChangeRouterService ELDPHHBCMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private PAOJOGODKBK NMHINGLMCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private ILEGMNPFAOB AKIBMMOILFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private HLPDAPBGAHJ DGJHENDBKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private PDEHIBGGEFM MAAOOBLKAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private JIGOCJGIGJA OANHFHBMFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private AHKPLOLMABO MGMDHPFPIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly GatherPropertiesForUndelete KFAKAGPLGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private uint DFBHONACMBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private uint NFOBEBGFGJF;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private HLPDAPBGAHJ BBKEGNIEFBK
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x72B0B0", Offset = "0x72A4B0", VA = "0x18072B0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool PKNLHBBEOAO
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x2DE4B90", Offset = "0x2DE3F90", VA = "0x182DE4B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool AMJJEBMJHAH
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x2DE64C0", Offset = "0x2DE58C0", VA = "0x182DE64C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool HGFNBODEFIE
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x2DE5EC0", Offset = "0x2DE52C0", VA = "0x182DE5EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int PHNODGMOOPM
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x2DE65A0", Offset = "0x2DE59A0", VA = "0x182DE65A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int HOLPDDPFGJK
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x2DE6710", Offset = "0x2DE5B10", VA = "0x182DE6710")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool EKOBFMMELJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2DE6870", Offset = "0x2DE5C70", VA = "0x182DE6870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool EMKOBLHNLJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2DE6560", Offset = "0x2DE5960", VA = "0x182DE6560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool EGPBHODFHNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0xF2A1F0", Offset = "0xF295F0", VA = "0x180F2A1F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xF2A200", Offset = "0xF29600", VA = "0x180F2A200", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer GJCBIBFODKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x2DE6590", Offset = "0x2DE5990", VA = "0x182DE6590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action NLFHNPDJFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x2DE5900", Offset = "0x2DE4D00", VA = "0x182DE5900", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x2DE4C20", Offset = "0x2DE4020", VA = "0x182DE4C20", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action DMALGBLGJGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x2DE47C0", Offset = "0x2DE3BC0", VA = "0x182DE47C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2DE67D0", Offset = "0x2DE5BD0", VA = "0x182DE67D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5450", Offset = "0x2DE4850", VA = "0x182DE5450", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4EF0", Offset = "0x2DE42F0", VA = "0x182DE4EF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6400", Offset = "0x2DE5800", VA = "0x182DE6400")]
		private void IPAKJGIELLA(KHMECMDAALD LMLBLIDPKCN, DMLPNPICGMP BGJLDEPELCD, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6570", Offset = "0x2DE5970", VA = "0x182DE6570")]
		private void JHEAAEHKBLC(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI OKDANAFGKFK, HAMGOKKMMPI CKCLLMGGJFK, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4880", Offset = "0x2DE3C80", VA = "0x182DE4880")]
		private void AMEMCPIPABM(KHMECMDAALD LMLBLIDPKCN, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6900", Offset = "0x2DE5D00", VA = "0x182DE6900", Slot = "14")]
		public IDisposable PMLHEABDGFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE68A0", Offset = "0x2DE5CA0", VA = "0x182DE68A0", Slot = "9")]
		public IDisposable OHECDJKPJIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4A60", Offset = "0x2DE3E60", VA = "0x182DE4A60", Slot = "6")]
		public UndoAction BJEGBDPPJJP()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5390", Offset = "0x2DE4790", VA = "0x182DE5390", Slot = "15")]
		public RedoAction FIFKEGOMBKF()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE61C0", Offset = "0x2DE55C0", VA = "0x182DE61C0", Slot = "16")]
		public UndoAction IENCPBALNFG()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5270", Offset = "0x2DE4670", VA = "0x182DE5270", Slot = "7")]
		public RedoAction FIFKEGOMBKF(UndoAction ELODBNLDLIK)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2DE60A0", Offset = "0x2DE54A0", VA = "0x182DE60A0", Slot = "8")]
		public UndoAction IENCPBALNFG(RedoAction ELODBNLDLIK)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6790", Offset = "0x2DE5B90", VA = "0x182DE6790")]
		public bool MOBLHDJKPEF(ENMJMOMJFJC DHMHOPMBNDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4B40", Offset = "0x2DE3F40", VA = "0x182DE4B40", Slot = "17")]
		public void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x2DE59A0", Offset = "0x2DE4DA0", VA = "0x182DE59A0")]
		public void FMBHGNBEDKM(KHMECMDAALD LMLBLIDPKCN, DMLPNPICGMP BGJLDEPELCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4E10", Offset = "0x2DE4210", VA = "0x182DE4E10")]
		public void DLMLBFOLJCO(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB, in HAMGOKKMMPI CKCLLMGGJFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5EF0", Offset = "0x2DE52F0", VA = "0x182DE5EF0")]
		public void HGOPOIHHGFH(KHMECMDAALD LMLBLIDPKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5A60", Offset = "0x2DE4E60", VA = "0x182DE5A60")]
		private void FOJHHJAAKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2DE66D0", Offset = "0x2DE5AD0", VA = "0x182DE66D0")]
		private void MEDPFOBOCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6880", Offset = "0x2DE5C80", VA = "0x182DE6880")]
		private void NKCCNPPBMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5FA0", Offset = "0x2DE53A0", VA = "0x182DE5FA0")]
		private KICGPFCFCEA HONHHAPNJML()
		{
			return default(KICGPFCFCEA);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4860", Offset = "0x2DE3C60", VA = "0x182DE4860")]
		private uint AJCMFAALKJD()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4C00", Offset = "0x2DE4000", VA = "0x182DE4C00")]
		private bool CJMONCBCHHP(out KICGPFCFCEA DAAMKALKLMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4B20", Offset = "0x2DE3F20", VA = "0x182DE4B20")]
		private bool BLADFKDHGAG(out KICGPFCFCEA DAAMKALKLMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6640", Offset = "0x2DE5A40", VA = "0x182DE6640")]
		private RedoAction LAEJLNJLCMF(KICGPFCFCEA DAAMKALKLMO)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6730", Offset = "0x2DE5B30", VA = "0x182DE6730")]
		private UndoAction MLMIENAPKNI(KICGPFCFCEA DAAMKALKLMO)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5C00", Offset = "0x2DE5000", VA = "0x182DE5C00")]
		private KICGPFCFCEA GOMMHHDDNAK(KICGPFCFCEA DAAMKALKLMO, ActionBuffer OPOCKIBHDMM, bool HFOICHHBMOA)
		{
			return default(KICGPFCFCEA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5190", Offset = "0x2DE4590", VA = "0x182DE5190")]
		private void EDPOKMIDNLF(Action DAAMKALKLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC140", Offset = "0x1DBB540", VA = "0x181DBC140")]
		private T EDPOKMIDNLF<T>(Func<T> MJJFBDCGCEG)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x2DE66A0", Offset = "0x2DE5AA0", VA = "0x182DE66A0")]
		private ICEDKDOEOFC LPBCLKGFNOO(bool HFOICHHBMOA, uint NHBDMCDLELK)
		{
			return default(ICEDKDOEOFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6A40", Offset = "0x2DE5E40", VA = "0x182DE6A40")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4CC0", Offset = "0x2DE40C0", VA = "0x182DE4CC0")]
		[CompilerGenerated]
		private UndoAction CPOCPCENOKD()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6280", Offset = "0x2DE5680", VA = "0x182DE6280")]
		[CompilerGenerated]
		private RedoAction IKPABGBGLFD()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5AA0", Offset = "0x2DE4EA0", VA = "0x182DE5AA0")]
		[CompilerGenerated]
		private UndoAction GMOLMNFLLEF()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class IOLMFOLDNDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<byte> BGAKDGCGOMH;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int JJINKJIBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x788950", Offset = "0x787D50", VA = "0x180788950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xCD6020", Offset = "0xCD5420", VA = "0x180CD6020")]
	public IOLMFOLDNDP(NativeArray<byte> BGAKDGCGOMH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2DED940", Offset = "0x2DECD40", VA = "0x182DED940")]
	public static IOLMFOLDNDP HPHCHABBDNG(NativeArray<byte> BGAKDGCGOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public T NHFGEFLKDIC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public NativeArray<T> EHHANNAAJOE<T>(int OEMPOIHBNFL, Allocator FKHAEPDPDAI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public NativeArray<T> GNCIDMDEEJC<T>(Allocator FKHAEPDPDAI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class FHOILCJKJKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<byte> BGAKDGCGOMH;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int JJINKJIBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x788950", Offset = "0x787D50", VA = "0x180788950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0xCD6020", Offset = "0xCD5420", VA = "0x180CD6020")]
	public FHOILCJKJKH(NativeArray<byte> BGAKDGCGOMH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2DDDAE0", Offset = "0x2DDCEE0", VA = "0x182DDDAE0")]
	public static FHOILCJKJKH HPHCHABBDNG(NativeArray<byte> BGAKDGCGOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x261ADE0", Offset = "0x261A1E0", VA = "0x18261ADE0")]
	public T NHFGEFLKDIC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	public NativeArray<T> EHHANNAAJOE<T>(int OEMPOIHBNFL, Allocator FKHAEPDPDAI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class LOLHGONHIIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NativeArray<byte> BGAKDGCGOMH;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int JJINKJIBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x788950", Offset = "0x787D50", VA = "0x180788950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xCD6020", Offset = "0xCD5420", VA = "0x180CD6020")]
	public LOLHGONHIIC(NativeArray<byte> BGAKDGCGOMH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x296B3E0", Offset = "0x296A7E0", VA = "0x18296B3E0")]
	public static LOLHGONHIIC HPHCHABBDNG(NativeArray<byte> BGAKDGCGOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x28895D0", Offset = "0x28889D0", VA = "0x1828895D0")]
	public void GLHEMHMMOJH<T>(in T LPJDDLMPNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x28894D0", Offset = "0x28888D0", VA = "0x1828894D0")]
	public void BABNACMOKBA<T>(NativeArray<T> EBCEJCLCIMI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	public void HPKPDILBOGA<T>(NativeArray<T> LPJDDLMPNCG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class ICIKGCLDMEB
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6B30", Offset = "0x2DE5F30", VA = "0x182DE6B30")]
	public static Span<byte> BDONJNMPHKP(this NativeArray<byte> BGAKDGCGOMH)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6CB0", Offset = "0x2DE60B0", VA = "0x182DE6CB0")]
	public static ReadOnlySpan<byte> KLMAFPAACIB(this NativeArray<byte> BGAKDGCGOMH)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6EB0", Offset = "0x2DE62B0", VA = "0x182DE6EB0")]
	public static NativeArray<byte> OPFJJLLMJHI(this NativeArray<byte> BGAKDGCGOMH, int LOEMONDJCMM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6C30", Offset = "0x2DE6030", VA = "0x182DE6C30")]
	public static NativeArray<byte> JNPELLADDLL(this NativeArray<byte> BGAKDGCGOMH, int EJMNNLNLAFJ = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE380", Offset = "0x1DBD780", VA = "0x181DBE380")]
	public static NativeArray<byte> JNPELLADDLL<T>(this NativeArray<byte> BGAKDGCGOMH, int EJMNNLNLAFJ = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6BC0", Offset = "0x2DE5FC0", VA = "0x182DE6BC0")]
	public static NativeArray<byte> CNMIJOCAHOK(this NativeArray<byte> BGAKDGCGOMH, int EJMNNLNLAFJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE320", Offset = "0x1DBD720", VA = "0x181DBE320")]
	public static NativeArray<byte> CNMIJOCAHOK<T>(this NativeArray<byte> BGAKDGCGOMH, int EJMNNLNLAFJ = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6E30", Offset = "0x2DE6230", VA = "0x182DE6E30")]
	public static NativeArray<byte> OCDKLLKBGGK(this NativeArray<byte> BGAKDGCGOMH, int EJMNNLNLAFJ = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE3E0", Offset = "0x1DBD7E0", VA = "0x181DBE3E0")]
	public static NativeArray<byte> OCDKLLKBGGK<T>(this NativeArray<byte> BGAKDGCGOMH, int EJMNNLNLAFJ = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BFDMOCAKPAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeList<byte> BDHPAGCMKHB;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0xCD6020", Offset = "0xCD5420", VA = "0x180CD6020")]
	public BFDMOCAKPAC(NativeList<byte> BDHPAGCMKHB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2FB03F0", Offset = "0x2FAF7F0", VA = "0x182FB03F0")]
	public static BFDMOCAKPAC HPHCHABBDNG(NativeList<byte> BGAKDGCGOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	public void GLHEMHMMOJH<T>(in T LPJDDLMPNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	public void BABNACMOKBA<T>(NativeArray<T> LPJDDLMPNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	public void HPKPDILBOGA<T>(NativeArray<T> LPJDDLMPNCG) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	[HAMPPOKOPOP(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.PropertyChanges)]
	public class PropertyChangeNetworkRouter : BJDLFHICAGD, GBCNOEIKEOL, OHLAKFFIOHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[OMAMNFHDGBM]
		private GNIPCNKMBLL PFBBPOBMKBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[OMAMNFHDGBM]
		private IMLNJKELEFP FNBGFGCHFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[OMAMNFHDGBM]
		private MEPABEFJJDI DNPLJHIKEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[OMAMNFHDGBM]
		private PropertyChangeRouterService ELDPHHBCMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private OMIODPKIBFL IECLCEDGDAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private IPCMKODPKEI DBFAEACKJAP;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public OMIODPKIBFL PICEKDIMDBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2988320", Offset = "0x2987720", VA = "0x182988320")]
		public OMIODPKIBFL.LMAJADMPFNM OKABAIPNHMA()
		{
			return default(OMIODPKIBFL.LMAJADMPFNM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x29875D0", Offset = "0x29869D0", VA = "0x1829875D0", Slot = "4")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2987A10", Offset = "0x2986E10", VA = "0x182987A10", Slot = "5")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x29876C0", Offset = "0x2986AC0", VA = "0x1829876C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2987450", Offset = "0x2986850", VA = "0x182987450")]
		public void BJEGBDPPJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2987560", Offset = "0x2986960", VA = "0x182987560")]
		public void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2987900", Offset = "0x2986D00", VA = "0x182987900")]
		private void EOLMPJJKKNN(KHMECMDAALD LMLBLIDPKCN, DMLPNPICGMP BGJLDEPELCD, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2987F80", Offset = "0x2987380", VA = "0x182987F80")]
		private void JMJKBJDFHGK(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI OKDANAFGKFK, HAMGOKKMMPI CKCLLMGGJFK, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2988160", Offset = "0x2987560", VA = "0x182988160")]
		private void NKMAPFPPLGO(KHMECMDAALD LMLBLIDPKCN, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2987C90", Offset = "0x2987090", VA = "0x182987C90")]
		private void HOKMDCKMDPF(IPCMKODPKEI KCGHNGOMAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2988030", Offset = "0x2987430", VA = "0x182988030")]
		private void MIBHMLPFBPM(IPCMKODPKEI KCGHNGOMAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2988260", Offset = "0x2987660", VA = "0x182988260")]
		private void ODHIAINGNAC(IPCMKODPKEI KCGHNGOMAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x29878E0", Offset = "0x2986CE0", VA = "0x1829878E0")]
		private void ENLMEGIJPNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2987590", Offset = "0x2986990", VA = "0x182987590")]
		private void CAKMAAHNNLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2988360", Offset = "0x2987760", VA = "0x182988360")]
		private void OMCJGNANDCO(IPCMKODPKEI KCGHNGOMAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x410D560", Offset = "0x410C960", VA = "0x18410D560", Slot = "6")]
		private void BGCDHBMGEIL<TKey, T>(global::CCCEMKOEGOF<TKey, T> GJEJKJANAJD, object PKDAKJPDDGD) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[JEGJCCBDMOE(OLCAJGBKOGB.History)]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	[HAMPPOKOPOP(typeof(PropertyChangeRouterService), new string[] { })]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public delegate void IBNJOAONEAL(KHMECMDAALD LMLBLIDPKCN, DMLPNPICGMP BGJLDEPELCD, bool NBAKJOACACA);

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public delegate void HDMNOBNHFDN(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI OKDANAFGKFK, HAMGOKKMMPI CKCLLMGGJFK, bool NBAKJOACACA);

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public delegate void JHADGCNCLMC(KHMECMDAALD LMLBLIDPKCN, bool NBAKJOACACA);

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IBNJOAONEAL IDIKGABNBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HDMNOBNHFDN FFPDGMKBION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public JHADGCNCLMC JALMAFNAIBH;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x29884C0", Offset = "0x29878C0", VA = "0x1829884C0")]
		public void FMBHGNBEDKM(KHMECMDAALD LMLBLIDPKCN, DMLPNPICGMP BGJLDEPELCD, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2988450", Offset = "0x2987850", VA = "0x182988450")]
		public void DLMLBFOLJCO(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB, in HAMGOKKMMPI OKDANAFGKFK, in HAMGOKKMMPI CKCLLMGGJFK, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x29884E0", Offset = "0x29878E0", VA = "0x1829884E0")]
		public void HGOPOIHHGFH(KHMECMDAALD LMLBLIDPKCN, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DebuggerTypeProxy(typeof(HGPKIMEHPDG))]
	[JEGJCCBDMOE(OLCAJGBKOGB.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		internal class HGPKIMEHPDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private readonly ActionBuffer NPOGECPDPEK;

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public int JAMIBFCLJNH
			{
				[Cpp2IlInjected.Token(Token = "0x60003BC")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9CB0", Offset = "0x2BC90B0", VA = "0x182BC9CB0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public JIHAFMIAAIC[] JKNNMEHLMAH
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9D00", Offset = "0x2BC9100", VA = "0x182BC9D00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
			public HGPKIMEHPDG(ActionBuffer PMJAJGIIPLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9BC0", Offset = "0x2BC8FC0", VA = "0x182BC9BC0")]
			[CompilerGenerated]
			private JIHAFMIAAIC IEBEFCGEICD(KICGPFCFCEA DAAMKALKLMO)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		internal class JIHAFMIAAIC : OHLAKFFIOHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private readonly ActionBuffer NPOGECPDPEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly KICGPFCFCEA DAAMKALKLMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private List<(IPCMKODPKEI, string, object)> ADLONPJHLHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private FHOILCJKJKH ACJLKOBBOEH;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public int JAMIBFCLJNH
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0x2BCA570", Offset = "0x2BC9970", VA = "0x182BCA570")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(IPCMKODPKEI, string, object)> JHEKMFNFJAE
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA5C0", Offset = "0x2BC99C0", VA = "0x182BCA5C0")]
			public JIHAFMIAAIC(ActionBuffer PMJAJGIIPLC, KICGPFCFCEA DAAMKALKLMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA130", Offset = "0x2BC9530", VA = "0x182BCA130")]
			private string ECMIJIDIAKO(IPCMKODPKEI DBFAEACKJAP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA230", Offset = "0x2BC9630", VA = "0x182BCA230")]
			private void GJPLHHGHDFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x452A6D0", Offset = "0x4529AD0", VA = "0x18452A6D0", Slot = "4")]
			public void BHJDIJLHOEC<TKey, T>(global::CCCEMKOEGOF<TKey, T> GJEJKJANAJD, [Optional] object PKDAKJPDDGD) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NativeList<byte> MNNEHHHEKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly Stack<KICGPFCFCEA> FOCLCMJDFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly FCMEBFGKGAD GJDODKHNCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly PDEHIBGGEFM MAAOOBLKAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly IMLNJKELEFP FNBGFGCHFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly bool ONBNLMJEALH;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public AGCEJKCDEOB IFFLDLNKLFF
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x2FAF070", Offset = "0x2FAE470", VA = "0x182FAF070")]
			get
			{
				return default(AGCEJKCDEOB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int JAMIBFCLJNH
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x2FAEF10", Offset = "0x2FAE310", VA = "0x182FAEF10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2FAF3E0", Offset = "0x2FAE7E0", VA = "0x182FAF3E0")]
		public ActionBuffer(PDEHIBGGEFM MAAOOBLKAKG, IMLNJKELEFP FNBGFGCHFDN, bool ONBNLMJEALH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2FAE710", Offset = "0x2FADB10", VA = "0x182FAE710")]
		public bool ALJCOBBBGHP(out KICGPFCFCEA DAAMKALKLMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2FAE8E0", Offset = "0x2FADCE0", VA = "0x182FAE8E0")]
		public void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2FAE7A0", Offset = "0x2FADBA0", VA = "0x182FAE7A0")]
		public KICGPFCFCEA BJEGBDPPJJP(FEPGBIOBLKH ADLONPJHLHJ, PAOJOGODKBK NMHINGLMCCB, uint ILCGCMHKGIB)
		{
			return default(KICGPFCFCEA);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2FAF360", Offset = "0x2FAE760", VA = "0x182FAF360")]
		public bool PAGIPLMHKNM(uint ILCGCMHKGIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2FAE950", Offset = "0x2FADD50", VA = "0x182FAE950")]
		public bool DPOAMBADENB(uint ILCGCMHKGIB, out KICGPFCFCEA ELODBNLDLIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2FAF0B0", Offset = "0x2FAE4B0", VA = "0x182FAF0B0")]
		public void NPKOPBOEEMM(KICGPFCFCEA ELODBNLDLIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2FAF220", Offset = "0x2FAE620", VA = "0x182FAF220")]
		[Conditional("DEBUG_BUILD")]
		private void OBJGDMGDHME(KICGPFCFCEA ELODBNLDLIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2FAEE00", Offset = "0x2FAE200", VA = "0x182FAEE00")]
		private void GOMMHHDDNAK(KICGPFCFCEA JMIBENEKCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2FAEBB0", Offset = "0x2FADFB0", VA = "0x182FAEBB0")]
		private void FMGACEJBBCA(FHOILCJKJKH GBAHMLMAEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2FAEF50", Offset = "0x2FAE350", VA = "0x182FAEF50")]
		private void JCFFJFIBCFL(KICGPFCFCEA DAAMKALKLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2FAEFB0", Offset = "0x2FAE3B0", VA = "0x182FAEFB0")]
		private FHOILCJKJKH JLEMFPMNDKC(KICGPFCFCEA DAAMKALKLMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2FAEB40", Offset = "0x2FADF40", VA = "0x182FAEB40", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class FCMEBFGKGAD : OHLAKFFIOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly PDEHIBGGEFM MAAOOBLKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly IMLNJKELEFP FNBGFGCHFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private KHMECMDAALD LMLBLIDPKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private FHOILCJKJKH FOFOAJFBPON;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DE200", Offset = "0x7DD600", VA = "0x1807DE200")]
	public FCMEBFGKGAD(PDEHIBGGEFM MAAOOBLKAKG, IMLNJKELEFP FNBGFGCHFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A9C0", VA = "0x18226B5C0", Slot = "4")]
	public void BHJDIJLHOEC<TKey, T>(global::CCCEMKOEGOF<TKey, T> HFBHMHPIKOM, [Optional] object PKDAKJPDDGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC3E0", Offset = "0x2DDB7E0", VA = "0x182DDC3E0")]
	public void KJCIHCOFJEN(IPCMKODPKEI DBFAEACKJAP, ref FHOILCJKJKH GBAHMLMAEME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class OMIODPKIBFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct LMAJADMPFNM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly OMIODPKIBFL GGEKFPEBLKN;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x4396D90", Offset = "0x4396190", VA = "0x184396D90")]
		public LMAJADMPFNM(OMIODPKIBFL GGEKFPEBLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x4396D70", Offset = "0x4396170", VA = "0x184396D70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	protected FEPGBIOBLKH ADLONPJHLHJ;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public FEPGBIOBLKH JHEKMFNFJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2972820", Offset = "0x2971C20", VA = "0x182972820")]
		get
		{
			return default(FEPGBIOBLKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool LCEGKFHJAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2972540", Offset = "0x2971940", VA = "0x182972540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2972890", Offset = "0x2971C90", VA = "0x182972890")]
	public OMIODPKIBFL(FEPGBIOBLKH.ENKLKGKBNCP GNBMALGACIE = FEPGBIOBLKH.ENKLKGKBNCP.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2972390", Offset = "0x2971790", VA = "0x182972390")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2972650", Offset = "0x2971A50", VA = "0x182972650")]
	public void FMBHGNBEDKM(KHMECMDAALD LMLBLIDPKCN, DMLPNPICGMP BGJLDEPELCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x29724A0", Offset = "0x29718A0", VA = "0x1829724A0")]
	public void DLMLBFOLJCO(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2972740", Offset = "0x2971B40", VA = "0x182972740")]
	public void HGOPOIHHGFH(KHMECMDAALD LMLBLIDPKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2972550", Offset = "0x2971950", VA = "0x182972550")]
	public void ENLMEGIJPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x29723A0", Offset = "0x29717A0", VA = "0x1829723A0")]
	public void CAKMAAHNNLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2972530", Offset = "0x2971930", VA = "0x182972530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2972860", Offset = "0x2971C60", VA = "0x182972860")]
	public LMAJADMPFNM OKABAIPNHMA()
	{
		return default(LMAJADMPFNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct IPCMKODPKEI : IComparable<IPCMKODPKEI>, IEquatable<IPCMKODPKEI>
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly IPCMKODPKEI LGIPBIEPLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public KHMECMDAALD LMLBLIDPKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public AHKPLOLMABO CBPECCEKJOB;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2DEDA20", Offset = "0x2DECE20", VA = "0x182DEDA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x735A30", Offset = "0x734E30", VA = "0x180735A30")]
	public IPCMKODPKEI(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDBB0", Offset = "0x2DECFB0", VA = "0x182DEDBB0")]
	public void PANBANONDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2DED9E0", Offset = "0x2DECDE0", VA = "0x182DED9E0", Slot = "4")]
	public int CompareTo(IPCMKODPKEI MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDBC0", Offset = "0x2DECFC0", VA = "0x182DEDBC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDA80", Offset = "0x2DECE80", VA = "0x182DEDA80", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDA30", Offset = "0x2DECE30", VA = "0x182DEDA30", Slot = "5")]
	public bool Equals(IPCMKODPKEI MPHACEGLFIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2DED9A0", Offset = "0x2DECDA0", VA = "0x182DED9A0")]
	public static bool BOBJELOEACN(IPCMKODPKEI GBEJHLEFDJM, IPCMKODPKEI BDGBOHJLNIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDB20", Offset = "0x2DECF20", VA = "0x182DEDB20")]
	public static bool GPCPOEGFAHL(IPCMKODPKEI GBEJHLEFDJM, IPCMKODPKEI BDGBOHJLNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDB70", Offset = "0x2DECF70", VA = "0x182DEDB70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[JEGJCCBDMOE(OLCAJGBKOGB.History)]
	public class GatherPropertiesForUndelete : AJOKFLMHEKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private PDEHIBGGEFM MAAOOBLKAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private KHMECMDAALD LMLBLIDPKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HistoryService GGCACBKODOP;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0B70", Offset = "0x2DDFF70", VA = "0x182DE0B70")]
		public void EIPBGIFBMDC(KHMECMDAALD LMLBLIDPKCN, PDEHIBGGEFM MAAOOBLKAKG, HistoryService GGCACBKODOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0AA0", Offset = "0x2DDFEA0", VA = "0x182DE0AA0", Slot = "4")]
		private void AAMAEIAIBKE(EJMAGAGALIM GJEJKJANAJD, in HAMGOKKMMPI LPJDDLMPNCG, object PKDAKJPDDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class KGIMDLLPJLE
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2D80", Offset = "0x2DF2180", VA = "0x182DF2D80")]
	public static void MIBHMLPFBPM(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP, DMLPNPICGMP BGJLDEPELCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2C40", Offset = "0x2DF2040", VA = "0x182DF2C40")]
	public static void LBFNOMMPJKL(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2F20", Offset = "0x2DF2320", VA = "0x182DF2F20")]
	public static void ODHIAINGNAC(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2A70", Offset = "0x2DF1E70", VA = "0x182DF2A70")]
	public static void BJBKIBPJLBP(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2BF0", Offset = "0x2DF1FF0", VA = "0x182DF2BF0")]
	public static DMLPNPICGMP KDFHHGMLGCF(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP)
	{
		return default(DMLPNPICGMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F08880", Offset = "0x1F07C80", VA = "0x181F08880")]
	public static T HFCOOPOGKAC<T>(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F08830", Offset = "0x1F07C30", VA = "0x181F08830")]
	public static T HFCOOPOGKAC<T>(ref FHOILCJKJKH HIDEHJGLNHO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2BA0", Offset = "0x2DF1FA0", VA = "0x182DF2BA0")]
	public static DMLPNPICGMP KDFHHGMLGCF(ref FHOILCJKJKH HIDEHJGLNHO)
	{
		return default(DMLPNPICGMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct FEPGBIOBLKH : IEnumerable<IPCMKODPKEI>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum ENKLKGKBNCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct ALDAIOMGCAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly FEPGBIOBLKH BDHPAGCMKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly PAOJOGODKBK NMHINGLMCCB;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4391610", Offset = "0x4390A10", VA = "0x184391610")]
		public ALDAIOMGCAP(FEPGBIOBLKH BDHPAGCMKHB, PAOJOGODKBK NMHINGLMCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4390F50", Offset = "0x4390350", VA = "0x184390F50")]
		public void EHGGJACIGMB(NativeList<byte> NEHKLODBFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x43915C0", Offset = "0x43909C0", VA = "0x1843915C0")]
		private void KAAFJKHDADI(IPCMKODPKEI DBFAEACKJAP, ref LOLHGONHIIC IHEOGLOJMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4391530", Offset = "0x4390930", VA = "0x184391530")]
		private void HNLNPFNFMMG(IPCMKODPKEI DBFAEACKJAP, ref LOLHGONHIIC IHEOGLOJMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x4391440", Offset = "0x4390840", VA = "0x184391440")]
		private NativeArray<byte> HLABFODDMCH(NativeList<byte> NEHKLODBFEL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x4390E60", Offset = "0x4390260", VA = "0x184390E60")]
		private NativeArray<byte> BJAKMJPOHDB(NativeList<byte> NEHKLODBFEL, int OEMPOIHBNFL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x43911F0", Offset = "0x43905F0", VA = "0x1843911F0")]
		private int EKIPDEMPEMI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x4390D00", Offset = "0x4390100", VA = "0x184390D00")]
		private bool BBIFOCGDKAK(IPCMKODPKEI DBFAEACKJAP, out NativeArray<byte> CAHFAPEBALA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct DOIGOCBAIEH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NativeList<byte> HIDEHJGLNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private FEPGBIOBLKH BDHPAGCMKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly IPCMKODPKEI KCGHNGOMAMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly int LOEMONDJCMM;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x4392340", Offset = "0x4391740", VA = "0x184392340")]
		internal DOIGOCBAIEH(FEPGBIOBLKH BDHPAGCMKHB, IPCMKODPKEI KCGHNGOMAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x4392180", Offset = "0x4391580", VA = "0x184392180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x43920C0", Offset = "0x43914C0", VA = "0x1843920C0")]
		public void ANEGIJJPHFF(NativeArray<byte> LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x4392120", Offset = "0x4391520", VA = "0x184392120")]
		public void DJKEKMKGPEL(NativeArray<byte> LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x43921B0", Offset = "0x43915B0", VA = "0x1843921B0")]
		public void HNLNPFNFMMG(in HAMGOKKMMPI LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x4416EF0", Offset = "0x44162F0", VA = "0x184416EF0")]
		public void HNLNPFNFMMG<T>(T LPJDDLMPNCG) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x4392270", Offset = "0x4391670", VA = "0x184392270")]
		private void LCLHPBKHPAM(int LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x43921C0", Offset = "0x43915C0", VA = "0x1843921C0")]
		private void LCLHPBKHPAM(in HAMGOKKMMPI LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x43922E0", Offset = "0x43916E0", VA = "0x1843922E0")]
		private unsafe void LCLHPBKHPAM(void* NODHJJDGNEC, int OEMPOIHBNFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x43920C0", Offset = "0x43914C0", VA = "0x1843920C0")]
		private void LCLHPBKHPAM(NativeArray<byte> EBCEJCLCIMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct OJADLINNLEO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private FEPGBIOBLKH BDHPAGCMKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private NativeArray<byte> HIDEHJGLNHO;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x43998C0", Offset = "0x4398CC0", VA = "0x1843998C0")]
		internal OJADLINNLEO(FEPGBIOBLKH BDHPAGCMKHB, NativeArray<byte> HIDEHJGLNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x4399600", Offset = "0x4398A00", VA = "0x184399600", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x4399610", Offset = "0x4398A10", VA = "0x184399610")]
		public NativeArray<byte> EHHANNAAJOE(int OEMPOIHBNFL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x43996D0", Offset = "0x4398AD0", VA = "0x1843996D0")]
		public NativeArray<byte> GNCIDMDEEJC()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x4418DD0", Offset = "0x44181D0", VA = "0x184418DD0")]
		public T NHFGEFLKDIC<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x43997C0", Offset = "0x4398BC0", VA = "0x1843997C0")]
		public void NHFGEFLKDIC(in LGDIAIHEOID LPJDDLMPNCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct DMEMOAGPHPJ : IEnumerator<IPCMKODPKEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly NativeList<IPCMKODPKEI> BGAKDGCGOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int EGNHJGKABLC;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public IPCMKODPKEI IFFLDLNKLFF
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x4392070", Offset = "0x4391470", VA = "0x184392070", Slot = "4")]
			get
			{
				return default(IPCMKODPKEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x4392030", Offset = "0x4391430", VA = "0x184392030", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0FAC0", Offset = "0x2F0EEC0", VA = "0x182F0FAC0")]
		internal DMEMOAGPHPJ(NativeList<IPCMKODPKEI> EBCEJCLCIMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x4391EF0", Offset = "0x43912F0", VA = "0x184391EF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x4391FF0", Offset = "0x43913F0", VA = "0x184391FF0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct PBPAEEIBCAL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const int FLCKDPJFNDD = 0;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const int KJDCKGBIHCK = 1;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private const int BCNIHCPDNCP = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NativeArray<int> HIDEHJGLNHO;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool JKIEOPECNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x4399E30", Offset = "0x4399230", VA = "0x184399E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int DFHLMIKLJID
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x4399F40", Offset = "0x4399340", VA = "0x184399F40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x4399F30", Offset = "0x4399330", VA = "0x184399F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public ENKLKGKBNCP OBJCLKADGKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x4399F80", Offset = "0x4399380", VA = "0x184399F80")]
			get
			{
				return default(ENKLKGKBNCP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x4399F20", Offset = "0x4399320", VA = "0x184399F20")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool LCEGKFHJAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x4399EF0", Offset = "0x43992F0", VA = "0x184399EF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x4399E10", Offset = "0x4399210", VA = "0x184399E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool ECFKBIKFFBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x4399F90", Offset = "0x4399390", VA = "0x184399F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x4399F00", Offset = "0x4399300", VA = "0x184399F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x4399FA0", Offset = "0x43993A0", VA = "0x184399FA0")]
		public PBPAEEIBCAL(ENKLKGKBNCP GNBMALGACIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x4399F50", Offset = "0x4399350", VA = "0x184399F50")]
		private int MKLBNKEKMJE(int LBOLDANMBMA, int IDHBPAJKMCA = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x4399EB0", Offset = "0x43992B0", VA = "0x184399EB0")]
		private void EFMALMFMJGL(int LBOLDANMBMA, int LPJDDLMPNCG, int IDHBPAJKMCA = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x4399E70", Offset = "0x4399270", VA = "0x184399E70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private const int HNMJBEGIPIP = -1;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private const int BELEHAOHPDK = 0;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly IPCMKODPKEI FIMOIPKNDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeHashMap<IPCMKODPKEI, int> OHGGELBOFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NativeList<IPCMKODPKEI> ADLONPJHLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NativeList<int> FFPJNOFDLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NativeList<byte> MFEOMNIGPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private NativeList<byte> HIDEHJGLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private PBPAEEIBCAL BHGFJLDJJON;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool LCEGKFHJAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC920", Offset = "0x2DDBD20", VA = "0x182DDC920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MJGLDBCMJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC550", Offset = "0x2DDB950", VA = "0x182DDC550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int DFHLMIKLJID
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2DDCE90", Offset = "0x2DDC290", VA = "0x182DDCE90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int BPBPJHBANKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2DDD0C0", Offset = "0x2DDC4C0", VA = "0x182DDD0C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC510", Offset = "0x2DDB910", VA = "0x182DDC510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCB20", Offset = "0x2DDBF20", VA = "0x182DDCB20")]
	public static FEPGBIOBLKH IDIKGABNBEI(ENKLKGKBNCP GNBMALGACIE = ENKLKGKBNCP.Last, int IDDJMNODLHM = 16, int ELEILMCPPJC = 256)
	{
		return default(FEPGBIOBLKH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD200", Offset = "0x2DDC600", VA = "0x182DDD200")]
	private FEPGBIOBLKH(ENKLKGKBNCP GNBMALGACIE, int IDDJMNODLHM, int ELEILMCPPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC840", Offset = "0x2DDBC40", VA = "0x182DDC840", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCA90", Offset = "0x2DDBE90", VA = "0x182DDCA90")]
	public DOIGOCBAIEH HOKMDCKMDPF(IPCMKODPKEI KCGHNGOMAMI)
	{
		return default(DOIGOCBAIEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCA00", Offset = "0x2DDBE00", VA = "0x182DDCA00")]
	public OJADLINNLEO FOGLOKNECFM(IPCMKODPKEI KCGHNGOMAMI)
	{
		return default(OJADLINNLEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC650", Offset = "0x2DDBA50", VA = "0x182DDC650")]
	public bool CJLKEHONHIG(IPCMKODPKEI KCGHNGOMAMI, out OJADLINNLEO GEFBMNBCACO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCB60", Offset = "0x2DDBF60", VA = "0x182DDCB60")]
	public bool IDLANPBCNKF(IPCMKODPKEI KCGHNGOMAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC930", Offset = "0x2DDBD30", VA = "0x182DDC930")]
	public bool EONDDIADOFD(IPCMKODPKEI KCGHNGOMAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCBB0", Offset = "0x2DDBFB0", VA = "0x182DDCBB0")]
	public void INGGJNILIID(NativeList<byte> NEHKLODBFEL, PAOJOGODKBK NMHINGLMCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x26145B0", Offset = "0x26139B0", VA = "0x1826145B0")]
	public T PKFLHEEHOPC<T>(IPCMKODPKEI KCGHNGOMAMI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC570", Offset = "0x2DDB970", VA = "0x182DDC570")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCF90", Offset = "0x2DDC390", VA = "0x182DDCF90")]
	public DMEMOAGPHPJ OKFDNCHLPHK()
	{
		return default(DMEMOAGPHPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCCA0", Offset = "0x2DDC0A0", VA = "0x182DDCCA0")]
	private void JOADFNLLICE(IPCMKODPKEI KCGHNGOMAMI, int LOEMONDJCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCFD0", Offset = "0x2DDC3D0", VA = "0x182DDCFD0")]
	private void PANBANONDJF(int KLIKLNGCPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCEA0", Offset = "0x2DDC2A0", VA = "0x182DDCEA0")]
	private void NPCLCFJAHMH(IPCMKODPKEI KCGHNGOMAMI, int LOEMONDJCMM, int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2614760", Offset = "0x2613B60", VA = "0x182614760")]
	private static T PKFLHEEHOPC<T>(NativeArray<byte> BGAKDGCGOMH, int LBOLDANMBMA = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD140", Offset = "0x2DDC540", VA = "0x182DDD140", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD100", Offset = "0x2DDC500", VA = "0x182DDD100", Slot = "4")]
	private IEnumerator<IPCMKODPKEI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class IPKINOFCIHN<T> : KHECDAFCLCI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private EntityQuery ANBHGOBNOFE;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x33EA720", Offset = "0x33E9B20", VA = "0x1833EA720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x33EA7B0", Offset = "0x33E9BB0", VA = "0x1833EA7B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x33EA820", Offset = "0x33E9C20", VA = "0x1833EA820")]
	public IPKINOFCIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xF93720", Offset = "0xF92B20", VA = "0x180F93720", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	internal class CleanupRigidbodyExImpl : KHECDAFCLCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private EntityQuery ANBHGOBNOFE;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2FB9CC0", Offset = "0x2FB90C0", VA = "0x182FB9CC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2FB9D60", Offset = "0x2FB9160", VA = "0x182FB9D60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[Preserve]
internal class GBOJBDKCCOB : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private EntityQuery MOMGMJKCAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF570", Offset = "0x2DDE970", VA = "0x182DDF570", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF5C0", Offset = "0x2DDE9C0", VA = "0x182DDF5C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF650", Offset = "0x2DDEA50", VA = "0x182DDF650", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public GBOJBDKCCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
internal class KEIMIAKJBIK : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private PropertyDiffStateService IMDNHHNOAIO;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2890", Offset = "0x2DF1C90", VA = "0x182DF2890", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF28E0", Offset = "0x2DF1CE0", VA = "0x182DF28E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public KEIMIAKJBIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private EntityQuery ANBHGOBNOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private SceneService OOCMFKEPGII;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7710", Offset = "0x2FC6B10", VA = "0x182FC7710", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7760", Offset = "0x2FC6B60", VA = "0x182FC7760", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2FC77F0", Offset = "0x2FC6BF0", VA = "0x182FC77F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
	[HAMPPOKOPOP(typeof(CullingBandService), new string[] { })]
	public class CullingBandService : GBCNOEIKEOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly List<NativeListAsync<FJIBCOPGCCJ>> LJLPNNBCCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM GHDOFHADNOC;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3280", Offset = "0x2FC2680", VA = "0x182FC3280", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2FC32D0", Offset = "0x2FC26D0", VA = "0x182FC32D0")]
		public void JCNPEJMIGKN(NativeListAsync<FJIBCOPGCCJ> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2CA0", Offset = "0x2FC20A0", VA = "0x182FC2CA0")]
		public void ALLCGBCGAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3110", Offset = "0x2FC2510", VA = "0x182FC3110", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3390", Offset = "0x2FC2790", VA = "0x182FC3390")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[HAMPPOKOPOP(typeof(LJHBPFAFOIK), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	public class PhysicsService : GBCNOEIKEOL, IJGJDJPFIAJ, LJHBPFAFOIK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly KLBHBMBPLOA GHMIDHHIPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private EntityManager MABCFMECCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private BHHDNNCMGLM ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private EMJHKMNAGIL GGLAGPKGINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private PropertyEventCallbacksService JEKKGCEPDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private global::CEGMBHOPAIF<ILMHKAKENLF> PPJGPOKMNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<MBEDCJLMHEO, ILMHKAKENLF> IMPEAMIJDMC
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x29847F0", Offset = "0x2983BF0", VA = "0x1829847F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x29849F0", Offset = "0x2983DF0", VA = "0x1829849F0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2984A90", Offset = "0x2983E90", VA = "0x182984A90", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2984C80", Offset = "0x2984080", VA = "0x182984C80", Slot = "5")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2984890", Offset = "0x2983C90", VA = "0x182984890", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2984BB0", Offset = "0x2983FB0", VA = "0x182984BB0", Slot = "8")]
		public bool LNGFLCBAKIP(MBEDCJLMHEO LKHNLAILFFL, out Collider CMHAOFFOOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2984730", Offset = "0x2983B30", VA = "0x182984730")]
		private void CBMAJNODLMB(Entity LCLDFKAJPDK, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI DKOFAPECACL, HAMGOKKMMPI JFNADPGFOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2984670", Offset = "0x2983A70", VA = "0x182984670", Slot = "9")]
		public void BFCCMJHFDMK(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	[HAMPPOKOPOP(typeof(ABGDBOLFPHD), new string[] { })]
	public class RbexService : GBCNOEIKEOL, ABGDBOLFPHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private BHHDNNCMGLM GHDOFHADNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private World ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private NBFPIMPGEPM JBBKLNBCCLO;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x298C4A0", Offset = "0x298B8A0", VA = "0x18298C4A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x298B0C0", Offset = "0x298A4C0", VA = "0x18298B0C0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x298D260", Offset = "0x298C660", VA = "0x18298D260", Slot = "6")]
		public KDBGLABEDCA PFFFDOEGHBO(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x298D5B0", Offset = "0x298C9B0", VA = "0x18298D5B0", Slot = "5")]
		public void PNOHJMGOEGC(MBEDCJLMHEO LKHNLAILFFL, KDBGLABEDCA LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x298A7A0", Offset = "0x2989BA0", VA = "0x18298A7A0", Slot = "34")]
		public CollisionDetectionMode DBALPFALMHB(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x298B9A0", Offset = "0x298ADA0", VA = "0x18298B9A0", Slot = "35")]
		public void HEMGCFGIIHJ(MBEDCJLMHEO LKHNLAILFFL, CollisionDetectionMode LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x298BDE0", Offset = "0x298B1E0", VA = "0x18298BDE0", Slot = "36")]
		public GGPABLKNBJB IEJIBOLKGMO(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(GGPABLKNBJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x298C760", Offset = "0x298BB60", VA = "0x18298C760", Slot = "37")]
		public void LHNNICANLHA(MBEDCJLMHEO LKHNLAILFFL, GGPABLKNBJB LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x298AC20", Offset = "0x298A020", VA = "0x18298AC20", Slot = "38")]
		public bool EJCMKPHGFNN(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x298D030", Offset = "0x298C430", VA = "0x18298D030", Slot = "39")]
		public void NPNKOHPAGGE(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x298CFB0", Offset = "0x298C3B0", VA = "0x18298CFB0", Slot = "40")]
		public MBEDCJLMHEO NKAKDLGIEDI(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x298A570", Offset = "0x2989970", VA = "0x18298A570", Slot = "41")]
		public void CIAELCNFLBC(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x298CE20", Offset = "0x298C220", VA = "0x18298CE20", Slot = "42")]
		public MBEDCJLMHEO NGLDHLBMECO(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x298A870", Offset = "0x2989C70", VA = "0x18298A870", Slot = "43")]
		public void DEIBNNOCJKC(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x298C4F0", Offset = "0x298B8F0", VA = "0x18298C4F0", Slot = "7")]
		public void LBIPGKKJCGE(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x298AE50", Offset = "0x298A250", VA = "0x18298AE50", Slot = "8")]
		public void FHJPDJCNJIO(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x298B200", Offset = "0x298A600", VA = "0x18298B200", Slot = "9")]
		public int FOLBFCNBPGG(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x298A230", Offset = "0x2989630", VA = "0x18298A230", Slot = "10")]
		public MBEDCJLMHEO AFFCJINMNLA(MBEDCJLMHEO LKHNLAILFFL, int EGNHJGKABLC)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x298A480", Offset = "0x2989880", VA = "0x18298A480", Slot = "11")]
		public void BPPDOOIJNCK(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x298D2F0", Offset = "0x298C6F0", VA = "0x18298D2F0", Slot = "12")]
		public void PHOAGLHHAKF(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM, MBEDCJLMHEO LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x298D4A0", Offset = "0x298C8A0", VA = "0x18298D4A0", Slot = "13")]
		public void PMFNLELDECK(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x298B6B0", Offset = "0x298AAB0", VA = "0x18298B6B0", Slot = "14")]
		public bool GOIAOANMDLM(MBEDCJLMHEO LKHNLAILFFL, out MBEDCJLMHEO LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x298C6E0", Offset = "0x298BAE0", VA = "0x18298C6E0", Slot = "15")]
		public void LGHADIIEOMO(MBEDCJLMHEO LKHNLAILFFL, float3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x298C9D0", Offset = "0x298BDD0", VA = "0x18298C9D0", Slot = "16")]
		public bool LNJIEHOODNE(MBEDCJLMHEO LKHNLAILFFL, out float3 LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x298D420", Offset = "0x298C820", VA = "0x18298D420", Slot = "17")]
		public void PJFBMEDDOMI(MBEDCJLMHEO LKHNLAILFFL, float3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x298CB30", Offset = "0x298BF30", VA = "0x18298CB30", Slot = "18")]
		public bool LPAOBNMILFA(MBEDCJLMHEO LKHNLAILFFL, out float3 LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x298BD60", Offset = "0x298B160", VA = "0x18298BD60", Slot = "26")]
		public float3 IEDIGKGOOFH(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x298D530", Offset = "0x298C930", VA = "0x18298D530", Slot = "27")]
		public void PNBIFKFCFEF(MBEDCJLMHEO LKHNLAILFFL, float3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x298A680", Offset = "0x2989A80", VA = "0x18298A680", Slot = "28")]
		public float CLGPBIPODBA(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x298CD50", Offset = "0x298C150", VA = "0x18298CD50", Slot = "29")]
		public void MMGDLCDAMEC(MBEDCJLMHEO LKHNLAILFFL, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x298BA10", Offset = "0x298AE10", VA = "0x18298BA10", Slot = "30")]
		public float HIEEMPLBCBL(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x298BC00", Offset = "0x298B000", VA = "0x18298BC00", Slot = "31")]
		public void IAOOGBCNABD(MBEDCJLMHEO LKHNLAILFFL, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x298B650", Offset = "0x298AA50", VA = "0x18298B650", Slot = "32")]
		public bool GOGNADAHOLJ(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x298A8F0", Offset = "0x2989CF0", VA = "0x18298A8F0", Slot = "33")]
		public void DGBINAHEAEE(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x298A9E0", Offset = "0x2989DE0", VA = "0x18298A9E0", Slot = "19")]
		public void DPAOADDDONC(MBEDCJLMHEO LKHNLAILFFL, float3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x298AF60", Offset = "0x298A360", VA = "0x18298AF60", Slot = "20")]
		public bool FJGKPONAGMO(MBEDCJLMHEO LKHNLAILFFL, out float3 LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x298B450", Offset = "0x298A850", VA = "0x18298B450", Slot = "21")]
		public void GGEOIJADDAL(MBEDCJLMHEO LKHNLAILFFL, quaternion LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x298C340", Offset = "0x298B740", VA = "0x18298C340", Slot = "22")]
		public bool KDFDPKKDFBE(MBEDCJLMHEO LKHNLAILFFL, out quaternion LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x298BF40", Offset = "0x298B340", VA = "0x18298BF40", Slot = "23")]
		public bool JEPPPKKDFAL(MBEDCJLMHEO LKHNLAILFFL, out float3 LDCILLCEGOA, out quaternion JLHJJCGNBIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x298A740", Offset = "0x2989B40", VA = "0x18298A740", Slot = "44")]
		public JGBCGHMDEIJ DAJNHLLCKKK(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(JGBCGHMDEIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x298C960", Offset = "0x298BD60", VA = "0x18298C960", Slot = "45")]
		public void LMHKMBLLNKH(MBEDCJLMHEO LKHNLAILFFL, JGBCGHMDEIJ LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x298BC70", Offset = "0x298B070", VA = "0x18298BC70", Slot = "72")]
		public void IDKBLHEFGGI(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x298C1B0", Offset = "0x298B5B0", VA = "0x18298C1B0", Slot = "73")]
		public void JKNDEMFHIOF(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x298CED0", Offset = "0x298C2D0", VA = "0x18298CED0", Slot = "74")]
		public bool NHKDMHMIKIK(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x298B170", Offset = "0x298A570", VA = "0x18298B170", Slot = "81")]
		public void FMPBDGIJBJD(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x298B530", Offset = "0x298A930", VA = "0x18298B530", Slot = "82")]
		public void GJAIHIHFBDH(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x298B890", Offset = "0x298AC90", VA = "0x18298B890", Slot = "83")]
		public bool HDGJBBOFHJN(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x298C240", Offset = "0x298B640", VA = "0x18298C240", Slot = "84")]
		public IEnumerable<object> KAFMOCCIOJA(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x298A6E0", Offset = "0x2989AE0", VA = "0x18298A6E0", Slot = "46")]
		public bool CNKKOFMMENM(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x298ABC0", Offset = "0x2989FC0", VA = "0x18298ABC0", Slot = "47")]
		public void EHLPGNEBPIO(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x298BE80", Offset = "0x298B280", VA = "0x18298BE80", Slot = "48")]
		public bool JCCHEICONKJ(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x298A3B0", Offset = "0x29897B0", VA = "0x18298A3B0", Slot = "49")]
		public void BINFNPDGILF(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x298BD00", Offset = "0x298B100", VA = "0x18298BD00", Slot = "50")]
		public bool IDLIKPAABMC(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x298D0A0", Offset = "0x298C4A0", VA = "0x18298D0A0", Slot = "51")]
		public void OCCHINDKMIM(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x298CF50", Offset = "0x298C350", VA = "0x18298CF50", Slot = "52")]
		public RigidbodyConstraints NILPJFHJIGA(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x298A800", Offset = "0x2989C00", VA = "0x18298A800", Slot = "53")]
		public void DDHOHLCNECK(MBEDCJLMHEO LKHNLAILFFL, RigidbodyConstraints LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x298CDC0", Offset = "0x298C1C0", VA = "0x18298CDC0", Slot = "54")]
		public float NCABHLAACGB(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x298C670", Offset = "0x298BA70", VA = "0x18298C670", Slot = "55")]
		public void LFIHLJEIFHA(MBEDCJLMHEO LKHNLAILFFL, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x298CC90", Offset = "0x298C090", VA = "0x18298CC90", Slot = "56")]
		public float LPDKNFGEPGF(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x298C600", Offset = "0x298BA00", VA = "0x18298C600", Slot = "57")]
		public void LDNBNFLIDKJ(MBEDCJLMHEO LKHNLAILFFL, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x298BEE0", Offset = "0x298B2E0", VA = "0x18298BEE0", Slot = "58")]
		public bool JCCNHDCLLAE(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x298B4C0", Offset = "0x298A8C0", VA = "0x18298B4C0", Slot = "59")]
		public void GGMJOFJLDAP(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x298D110", Offset = "0x298C510", VA = "0x18298D110", Slot = "60")]
		public bool OHOPFPFHPPJ(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x298BB00", Offset = "0x298AF00", VA = "0x18298BB00", Slot = "61")]
		public void HMDLPKBMGDD(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x298A350", Offset = "0x2989750", VA = "0x18298A350", Slot = "62")]
		public int AOCMJNELMED(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x298ADE0", Offset = "0x298A1E0", VA = "0x18298ADE0", Slot = "63")]
		public void EODNJMDIBLP(MBEDCJLMHEO LKHNLAILFFL, int LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x298BA70", Offset = "0x298AE70", VA = "0x18298BA70", Slot = "64")]
		public Rigidbody HLAFBBKOEEP(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x298C800", Offset = "0x298BC00", VA = "0x18298C800", Slot = "65")]
		public void LIAHODNPDEH(MBEDCJLMHEO LKHNLAILFFL, Rigidbody LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x298A5F0", Offset = "0x29899F0", VA = "0x18298A5F0", Slot = "75")]
		public void CKHAMKLFKNJ(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x298AB30", Offset = "0x2989F30", VA = "0x18298AB30", Slot = "76")]
		public void EBMHEPBKMJO(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x298A960", Offset = "0x2989D60", VA = "0x18298A960", Slot = "77")]
		public bool DNEELFHOJEJ(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x298B910", Offset = "0x298AD10", VA = "0x18298B910", Slot = "66")]
		public object HEHNIDIDKOJ(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x298B2F0", Offset = "0x298A6F0", VA = "0x18298B2F0", Slot = "67")]
		public void GGBBFOEBNDJ(MBEDCJLMHEO LKHNLAILFFL, object LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x298B5C0", Offset = "0x298A9C0", VA = "0x18298B5C0", Slot = "68")]
		public object GKGFKHDLJPB(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x298AC80", Offset = "0x298A080", VA = "0x18298AC80", Slot = "69")]
		public void EJGBENLMOLA(MBEDCJLMHEO LKHNLAILFFL, object LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x298D170", Offset = "0x298C570", VA = "0x18298D170", Slot = "70")]
		public float PAMPBGKMLGP(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x298D660", Offset = "0x298CA60", VA = "0x18298D660", Slot = "71")]
		public void PPEMJOPAMJI(MBEDCJLMHEO LKHNLAILFFL, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x298D1D0", Offset = "0x298C5D0", VA = "0x18298D1D0", Slot = "78")]
		public void PDDALBPHINP(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x298BB70", Offset = "0x298AF70", VA = "0x18298BB70", Slot = "79")]
		public void HOPOKGLJMFO(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x298B810", Offset = "0x298AC10", VA = "0x18298B810", Slot = "80")]
		public bool GOLOOKPJCBN(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x298A420", Offset = "0x2989820", VA = "0x18298A420", Slot = "24")]
		public void BOGLFGOCNEB(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x298CCF0", Offset = "0x298C0F0", VA = "0x18298CCF0", Slot = "25")]
		public void MLKFOKMBAIJ(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x43423A0", Offset = "0x43417A0", VA = "0x1843423A0")]
		private void CIJNLCELIGO<T>(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x4342D70", Offset = "0x4342170", VA = "0x184342D70")]
		private bool ODLOGLIACAA<T>(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x4342940", Offset = "0x4341D40", VA = "0x184342940")]
		private void FJEBMLODAAK<T>(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x4342B40", Offset = "0x4341F40", VA = "0x184342B40")]
		private bool KNFMPDHAKHF<TC, TV>(MBEDCJLMHEO LKHNLAILFFL, Func<TC, TV> MJJFBDCGCEG, out TV LPJDDLMPNCG) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x4342AC0", Offset = "0x4341EC0", VA = "0x184342AC0")]
		private bool KNFMPDHAKHF<T>(MBEDCJLMHEO LKHNLAILFFL, out T LPJDDLMPNCG) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x4342DD0", Offset = "0x43421D0", VA = "0x184342DD0")]
		private T OPFGHFGPOHB<T>(MBEDCJLMHEO LKHNLAILFFL) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x43423F0", Offset = "0x43417F0", VA = "0x1843423F0")]
		private void DOJCFHAFHEH<T>(MBEDCJLMHEO LKHNLAILFFL, T LPJDDLMPNCG) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x4341D40", Offset = "0x4341140", VA = "0x184341D40")]
		private void AEFMCMBFLEO<T>(MBEDCJLMHEO LKHNLAILFFL, T LPJDDLMPNCG) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x4342AC0", Offset = "0x4341EC0", VA = "0x184342AC0")]
		private bool HGIAEFPBKHD<T>(MBEDCJLMHEO LKHNLAILFFL, out T LPJDDLMPNCG) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x43429A0", Offset = "0x4341DA0", VA = "0x1843429A0")]
		private T FOHGHHOIINM<T>(MBEDCJLMHEO LKHNLAILFFL) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x4342AC0", Offset = "0x4341EC0", VA = "0x184342AC0")]
		private void LFPDPHNGMGG<T>(MBEDCJLMHEO LKHNLAILFFL, T LPJDDLMPNCG) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x4342CC0", Offset = "0x43420C0", VA = "0x184342CC0")]
		private void NKOECMNAHED<T>(MBEDCJLMHEO LKHNLAILFFL, T LPJDDLMPNCG) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x298C4C0", Offset = "0x298B8C0", VA = "0x18298C4C0")]
		private MBEDCJLMHEO KONFHNOEBBE(Entity LCLDFKAJPDK)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x298AA60", Offset = "0x2989E60", VA = "0x18298AA60")]
		private DynamicBuffer<Entity> EAAPNLKKNIM(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x4342A00", Offset = "0x4341E00", VA = "0x184342A00")]
		private void GEAHKKHLMPD<T>(MBEDCJLMHEO LKHNLAILFFL, object LPJDDLMPNCG, Func<object, T> MJJFBDCGCEG) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		private void GJPLHHGHDFM<T>(ref global::NFKGLAFFMGG<T> EFOCNJAEIPA) where T : struct, NIJKBPKBPOC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		private void GJPLHHGHDFM<TC, TV>(ref global::MIOAAOMMLGI<TC, TV> EFOCNJAEIPA) where TC : struct, NIJKBPKBPOC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
	[HAMPPOKOPOP(typeof(KinematicSleepChangeService), new string[] { })]
	public class KinematicSleepChangeService : GBCNOEIKEOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class OKPJGCBJBDI : IEnumerable<KDBGLABEDCA>, IEnumerable, IEnumerator<KDBGLABEDCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private KDBGLABEDCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public KinematicSleepChangeService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public NativeArray<Entity> <>3__entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private EntityManager <entityManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			private KDBGLABEDCA System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
			[DebuggerHidden]
			public OKPJGCBJBDI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x4399C40", Offset = "0x4399040", VA = "0x184399C40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x4399900", Offset = "0x4398D00", VA = "0x184399900", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x4399CC0", Offset = "0x43990C0", VA = "0x184399CC0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x4399C00", Offset = "0x4399000", VA = "0x184399C00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x4399B50", Offset = "0x4398F50", VA = "0x184399B50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KDBGLABEDCA> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x4399B50", Offset = "0x4398F50", VA = "0x184399B50", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> GOHDNAIOAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM GHDOFHADNOC;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4B00", Offset = "0x2DF3F00", VA = "0x182DF4B00", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4B50", Offset = "0x2DF3F50", VA = "0x182DF4B50")]
		public void JCNPEJMIGKN(NativeArray<Entity> ABBIPALBHCK, bool MGBDBJDLAFG, bool FPFOJOEOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4710", Offset = "0x2DF3B10", VA = "0x182DF4710")]
		public void ALLCGBCGAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4C70", Offset = "0x2DF4070", VA = "0x182DF4C70")]
		private void LFGHFGFKNPM(NativeArray<Entity> ABBIPALBHCK, bool MGBDBJDLAFG, bool FPFOJOEOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4920", Offset = "0x2DF3D20", VA = "0x182DF4920")]
		[IteratorStateMachine(typeof(OKPJGCBJBDI))]
		private IEnumerable<KDBGLABEDCA> APKNAMIOHAO(NativeArray<Entity> ABBIPALBHCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x2DF49B0", Offset = "0x2DF3DB0", VA = "0x182DF49B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5480", Offset = "0x2DF4880", VA = "0x182DF5480")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
[HAMPPOKOPOP(typeof(JIGOCJGIGJA), new string[] { })]
public class CKKIHKPBCOH : JIGOCJGIGJA, IEnumerable<ANIKAMAEHJJ>, IEnumerable, HBEOAMPLBKH, BJDLFHICAGD, GBCNOEIKEOL, IJGJDJPFIAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[OMAMNFHDGBM]
	private BLMENLBLGJF FNBGFGCHFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<(Type, string), int> NPEPACPLOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private EDNDEDONICN ANPEAPDPJIL;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7A10", Offset = "0x2FB6E10", VA = "0x182FB7A10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public ANIKAMAEHJJ JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7570", Offset = "0x2FB6970", VA = "0x182FB7570", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public ANIKAMAEHJJ JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7570", Offset = "0x2FB6970", VA = "0x182FB7570", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7590", Offset = "0x2FB6990", VA = "0x182FB7590", Slot = "11")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2FB76C0", Offset = "0x2FB6AC0", VA = "0x182FB76C0", Slot = "12")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "13")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FB71C0", Offset = "0x2FB65C0", VA = "0x182FB71C0")]
	private void ANPBMIHAFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x249B460", Offset = "0x249A860", VA = "0x18249B460")]
	private string NPDEJCBEAOF(string AMNLGEBHFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2FB75E0", Offset = "0x2FB69E0", VA = "0x182FB75E0", Slot = "7")]
	public ANIKAMAEHJJ EEFKBJFGHAC(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7760", Offset = "0x2FB6B60", VA = "0x182FB7760")]
	private bool HHMJMOMICKB(Type HCAPMBLBEEA, string AMNLGEBHFHK, out ANIKAMAEHJJ HDLEMAAGOPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7460", Offset = "0x2FB6860", VA = "0x182FB7460", Slot = "8")]
	public AHKPLOLMABO DCNFHPDCNKA(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return default(AHKPLOLMABO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7740", Offset = "0x2FB6B40", VA = "0x182FB7740", Slot = "9")]
	public IEnumerator<ANIKAMAEHJJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7740", Offset = "0x2FB6B40", VA = "0x182FB7740", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7A30", Offset = "0x2FB6E30", VA = "0x182FB7A30")]
	public CKKIHKPBCOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
[DefaultMember("Item")]
public interface PAOJOGODKBK
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDPNENBLNBJ(AHKPLOLMABO PKNOIGMENLD, out int GBNBGNMHGLO);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
[HAMPPOKOPOP(typeof(PAOJOGODKBK), new string[] { })]
public class LKGBNFJIJHO : GBCNOEIKEOL, IJGJDJPFIAJ, PAOJOGODKBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[OMAMNFHDGBM]
	private IMLNJKELEFP FNBGFGCHFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<AHKPLOLMABO, int> JJGKICHCPJI;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x296B090", Offset = "0x296A490", VA = "0x18296B090", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x296B0F0", Offset = "0x296A4F0", VA = "0x18296B0F0", Slot = "6")]
	public bool FDPNENBLNBJ(AHKPLOLMABO PKNOIGMENLD, out int GBNBGNMHGLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x296B160", Offset = "0x296A560", VA = "0x18296B160", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x296B1C0", Offset = "0x296A5C0", VA = "0x18296B1C0", Slot = "5")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x296AE20", Offset = "0x296A220", VA = "0x18296AE20")]
	private void AKMMJMPOPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x296B1D0", Offset = "0x296A5D0", VA = "0x18296B1D0")]
	public LKGBNFJIJHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[HAMPPOKOPOP(typeof(IMLNJKELEFP), new string[] { })]
[DefaultMember("Item")]
public class DAFHHABAFPH : IMLNJKELEFP, IEnumerable<LEDNIENHLNM>, IEnumerable, HBEOAMPLBKH, BJDLFHICAGD, GBCNOEIKEOL, IJGJDJPFIAJ, OHLAKFFIOHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[OMAMNFHDGBM]
	private DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[OMAMNFHDGBM]
	private JIGOCJGIGJA OANHFHBMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private LEDNIENHLNM[] EMMKHDGMFKP;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3B10", Offset = "0x2FC2F10", VA = "0x182FC3B10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public LEDNIENHLNM JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3410", Offset = "0x2FC2810", VA = "0x182FC3410", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LEDNIENHLNM JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3410", Offset = "0x2FC2810", VA = "0x182FC3410", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "10")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3790", Offset = "0x2FC2B90", VA = "0x182FC3790", Slot = "11")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "12")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3660", Offset = "0x2FC2A60", VA = "0x182FC3660", Slot = "6")]
	public LEDNIENHLNM EEFKBJFGHAC(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3450", Offset = "0x2FC2850", VA = "0x182FC3450", Slot = "7")]
	public AHKPLOLMABO DCNFHPDCNKA(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return default(AHKPLOLMABO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3A30", Offset = "0x2FC2E30", VA = "0x182FC3A30", Slot = "8")]
	public IEnumerator<LEDNIENHLNM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3B20", Offset = "0x2FC2F20", VA = "0x182FC3B20", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x22C4B70", Offset = "0x22C3F70", VA = "0x1822C4B70", Slot = "13")]
	public void BHJDIJLHOEC<TKey, T>(global::CCCEMKOEGOF<TKey, T> GJEJKJANAJD, [Optional] object PKDAKJPDDGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3520", Offset = "0x2FC2920", VA = "0x182FC3520", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public DAFHHABAFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3410", Offset = "0x2FC2810", VA = "0x182FC3410")]
	[CompilerGenerated]
	private LEDNIENHLNM DCDBLIEBCNM(int FMPGMDDDGFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
[HAMPPOKOPOP(typeof(ILADIFIOBIK), new string[] { })]
public class OBNEHJAFPCA : ILADIFIOBIK, IEnumerable<PPBNAGHDKKA>, IEnumerable, GBCNOEIKEOL, IJGJDJPFIAJ, OHLAKFFIOHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[OMAMNFHDGBM]
	private DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[OMAMNFHDGBM]
	private JIGOCJGIGJA OANHFHBMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private PPBNAGHDKKA[] EMMKHDGMFKP;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x2970F90", Offset = "0x2970390", VA = "0x182970F90", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PPBNAGHDKKA JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2970A90", Offset = "0x296FE90", VA = "0x182970A90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public PPBNAGHDKKA JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x2970A90", Offset = "0x296FE90", VA = "0x182970A90", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2970D30", Offset = "0x2970130", VA = "0x182970D30", Slot = "9")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2970FE0", Offset = "0x29703E0", VA = "0x182970FE0", Slot = "10")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2970EB0", Offset = "0x29702B0", VA = "0x182970EB0")]
	private PPBNAGHDKKA HGOGJDFNLCL(int EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2970C10", Offset = "0x2970010", VA = "0x182970C10", Slot = "6")]
	public PPBNAGHDKKA EEFKBJFGHAC(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2970AA0", Offset = "0x296FEA0", VA = "0x182970AA0", Slot = "14")]
	public AHKPLOLMABO DCNFHPDCNKA(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return default(AHKPLOLMABO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2970DA0", Offset = "0x29701A0", VA = "0x182970DA0", Slot = "7")]
	public IEnumerator<PPBNAGHDKKA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2970DA0", Offset = "0x29701A0", VA = "0x182970DA0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x25A9960", Offset = "0x25A8D60", VA = "0x1825A9960", Slot = "11")]
	public void BHJDIJLHOEC<TKey, T>(global::CCCEMKOEGOF<TKey, T> GJEJKJANAJD, [Optional] object PKDAKJPDDGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2970B70", Offset = "0x296FF70", VA = "0x182970B70", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public OBNEHJAFPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2970A90", Offset = "0x296FE90", VA = "0x182970A90")]
	[CompilerGenerated]
	private PPBNAGHDKKA DCDBLIEBCNM(int FMPGMDDDGFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[HAMPPOKOPOP(typeof(BLMENLBLGJF), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
internal class BLMENLBLGJF : GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private JIGOCJGIGJA OANHFHBMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private ILADIFIOBIK COBFIHPKHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private IMLNJKELEFP EOAEPCIPGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private global::EILPMGINBJG<HOOPFMCFMDE> BILIICLNGJO;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public EDNDEDONICN ICBPLLEEPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x735A10", Offset = "0x734E10", VA = "0x180735A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x735A20", Offset = "0x734E20", VA = "0x180735A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1D20", Offset = "0x2FB1120", VA = "0x182FB1D20", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1C30", Offset = "0x2FB1030", VA = "0x182FB1C30")]
	private void CGBIJPLIGIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x1A871E0", Offset = "0x1A865E0", VA = "0x181A871E0")]
	public T FHKHGMAFILK<T>() where T : HOOPFMCFMDE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1E50", Offset = "0x2FB1250", VA = "0x182FB1E50")]
	public ANIKAMAEHJJ HDEJJGLLACM(DDIEEGNDNAH AMNLGEBHFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	public global::CEGMBHOPAIF<T> HDEJJGLLACM<T>(DDIEEGNDNAH AMNLGEBHFHK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1A90", Offset = "0x2FB0E90", VA = "0x182FB1A90")]
	public PPBNAGHDKKA BNIPHJEGIHL(DDIEEGNDNAH AMNLGEBHFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x1A87160", Offset = "0x1A86560", VA = "0x181A87160")]
	public global::JHEEGHNCDEJ<T> BNIPHJEGIHL<T>(DDIEEGNDNAH AMNLGEBHFHK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1B60", Offset = "0x2FB0F60", VA = "0x182FB1B60")]
	public LEDNIENHLNM CDHDOJEIMPE(DDIEEGNDNAH AMNLGEBHFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	public global::OLHLEPICNBD<T> CDHDOJEIMPE<T>(DDIEEGNDNAH AMNLGEBHFHK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public BLMENLBLGJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class ANMOJHOMNKG
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2435790", Offset = "0x2434B90", VA = "0x182435790")]
	public static global::CEGMBHOPAIF<T> HDEJJGLLACM<T>(this BLMENLBLGJF OAMPBIMBKMB, global::OBMHIPHOPOO<T> AMNLGEBHFHK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	public static global::JHEEGHNCDEJ<T> BNIPHJEGIHL<T>(this BLMENLBLGJF OAMPBIMBKMB, global::OBMHIPHOPOO<T> AMNLGEBHFHK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	public static global::OLHLEPICNBD<T> CDHDOJEIMPE<T>(this BLMENLBLGJF OAMPBIMBKMB, global::OBMHIPHOPOO<T> AMNLGEBHFHK) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[HAMPPOKOPOP(typeof(POLJKOKPBLE), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
public class POLJKOKPBLE : GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private PDEHIBGGEFM MAAOOBLKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private AHKPLOLMABO[] FCPIAPOPLMG;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x2981410", Offset = "0x2980810", VA = "0x182981410", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x29816A0", Offset = "0x2980AA0", VA = "0x1829816A0")]
	public void KNBIFBCEKPM(KHMECMDAALD HBKLDKCICEJ, bool GGAFPKHNBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public POLJKOKPBLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[HAMPPOKOPOP(typeof(MFNNEGEJOCH), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
public sealed class MFNNEGEJOCH : GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class MKGNHNLIIOO : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
		[DebuggerHidden]
		public MKGNHNLIIOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x4397440", Offset = "0x4396840", VA = "0x184397440", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x4397090", Offset = "0x4396490", VA = "0x184397090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x43974C0", Offset = "0x43968C0", VA = "0x1843974C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x4397400", Offset = "0x4396800", VA = "0x184397400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x4397370", Offset = "0x4396770", VA = "0x184397370", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x4397370", Offset = "0x4396770", VA = "0x184397370", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string ABPBMEDNGDG = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<SerializableGuid, OMJADPLKEJB> MJEDNJMJMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<SerializableGuid> LPOFHAMLIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Dictionary<SerializableGuid, GameObject> IIPJHFKNDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private ILADIFIOBIK FNBGFGCHFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private BFHOGDONKCB NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private FBCAFMCBMPK GOBBGGBLGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private PHIPKIFAENI GPADBKAKFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private global::BHJMFFBJHCN<OMJADPLKEJB> BIHECIHEKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject EACAEPAKMMG;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x296D200", Offset = "0x296C600", VA = "0x18296D200", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x296D3D0", Offset = "0x296C7D0", VA = "0x18296D3D0", Slot = "5")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x296C8C0", Offset = "0x296BCC0", VA = "0x18296C8C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x296C250", Offset = "0x296B650", VA = "0x18296C250")]
	private void AIKOEPHPLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x296C260", Offset = "0x296B660", VA = "0x18296C260")]
	internal void BECPPEGJCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x296CBA0", Offset = "0x296BFA0", VA = "0x18296CBA0")]
	private void ELMHAANGAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x296D2D0", Offset = "0x296C6D0", VA = "0x18296D2D0")]
	private void JJLCFMEFDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x296C200", Offset = "0x296B600", VA = "0x18296C200")]
	[IteratorStateMachine(typeof(MKGNHNLIIOO))]
	private IEnumerable<RRCustomPropTag> AFEHFMEHMJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x296CD80", Offset = "0x296C180", VA = "0x18296CD80")]
	private void FAOEEKNFHOB(MBEDCJLMHEO LKHNLAILFFL, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x296CA60", Offset = "0x296BE60", VA = "0x18296CA60")]
	private void EHOMCGHPBHE(SerializableGuid NPIFLODGAHD, GameObject DLNMCGFEPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x296D600", Offset = "0x296CA00", VA = "0x18296D600")]
	private void OALNCCFGGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x296C6E0", Offset = "0x296BAE0", VA = "0x18296C6E0")]
	private bool DNKPHOIPEBM(OMJADPLKEJB BDMMNPPMGDN, Transform GGEKFPEBLKN, out GameObject MLLKBCFLFJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x296C690", Offset = "0x296BA90", VA = "0x18296C690")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x296D990", Offset = "0x296CD90", VA = "0x18296D990")]
	public MFNNEGEJOCH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public SerializableGuid EEPADLGCONN
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x735A00", Offset = "0x734E00", VA = "0x180735A00")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x298A140", Offset = "0x2989540", VA = "0x18298A140")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[HAMPPOKOPOP(typeof(JDILNHMGLLM), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
public class JDILNHMGLLM : GBCNOEIKEOL
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private const string ANFCKBCBKDJ = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private SceneService EDPMKCELNON;

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE5E0", Offset = "0x2DED9E0", VA = "0x182DEE5E0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public JDILNHMGLLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[HAMPPOKOPOP(typeof(AACCBNLPADA), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
public class AACCBNLPADA : GBCNOEIKEOL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[OMAMNFHDGBM]
	private EnableComponentSystemsInScope GHGCDACGEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[OMAMNFHDGBM]
	private SceneService EDPMKCELNON;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2FABF70", Offset = "0x2FAB370", VA = "0x182FABF70", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2FABF30", Offset = "0x2FAB330", VA = "0x182FABF30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2FABF10", Offset = "0x2FAB310", VA = "0x182FABF10")]
	private void CNMMEOHJGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2FABFE0", Offset = "0x2FAB3E0", VA = "0x182FABFE0")]
	private void LKCJPMHFGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public AACCBNLPADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[HAMPPOKOPOP(typeof(NDFDMPICGAG), new string[] { })]
public class JMBPAIPOGLF : GBCNOEIKEOL, IJGJDJPFIAJ, NDFDMPICGAG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private CLIHAPFPPDO BKOBOKBHBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private IIBNDGKILME JEMFDIJKPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private PropertyEventCallbacksService JEKKGCEPDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private LocalPlayerScopeSystem MEFDPDKNAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private int NMDCIIIFDNA;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool PKNHJACHMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1CB0", Offset = "0x2DF10B0", VA = "0x182DF1CB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public MBEDCJLMHEO KHIHMEEEPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1A30", Offset = "0x2DF0E30", VA = "0x182DF1A30", Slot = "9")]
		get
		{
			return default(MBEDCJLMHEO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1230", Offset = "0x2DF0630", VA = "0x182DF1230", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public EMFDOJECCDF EIFDGFOLJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1AC0", Offset = "0x2DF0EC0", VA = "0x182DF1AC0", Slot = "11")]
		get
		{
			return default(EMFDOJECCDF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1230", Offset = "0x2DF0630", VA = "0x182DF1230", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public EMFDOJECCDF LCMNPPIFGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1A70", Offset = "0x2DF0E70", VA = "0x182DF1A70", Slot = "13")]
		get
		{
			return default(EMFDOJECCDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint MNHOECAAJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1810", Offset = "0x2DF0C10", VA = "0x182DF1810")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ICMCAGOGJBG CCCAANGKKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1CF0", Offset = "0x2DF10F0", VA = "0x182DF1CF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF18C0", Offset = "0x2DF0CC0", VA = "0x182DF18C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1960", Offset = "0x2DF0D60", VA = "0x182DF1960", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1B10", Offset = "0x2DF0F10", VA = "0x182DF1B10", Slot = "5")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1660", Offset = "0x2DF0A60", VA = "0x182DF1660", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1460", Offset = "0x2DF0860", VA = "0x182DF1460")]
	private void DHGJMJCNJCH(Entity LCLDFKAJPDK, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI DKOFAPECACL, HAMGOKKMMPI JFNADPGFOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0FC0", Offset = "0x2DF03C0", VA = "0x182DF0FC0", Slot = "14")]
	public MBEDCJLMHEO AFNHNOEFCOI(MBEDCJLMHEO AGDKLNJDAPF, MBEDCJLMHEO NMPDJFDFMIN)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1710", Offset = "0x2DF0B10", VA = "0x182DF1710", Slot = "15")]
	public bool EDCKHKPPKHK(MBEDCJLMHEO AGDKLNJDAPF, MBEDCJLMHEO NMPDJFDFMIN, out MBEDCJLMHEO NFENBCEFMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2DF12D0", Offset = "0x2DF06D0", VA = "0x182DF12D0", Slot = "16")]
	public void CDINMBMKCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1D90", Offset = "0x2DF1190", VA = "0x182DF1D90", Slot = "17")]
	public void OAHBFJKDMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF10D0", Offset = "0x2DF04D0", VA = "0x182DF10D0", Slot = "18")]
	public bool BLOJEJKHCIB(MBEDCJLMHEO ELODBNLDLIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1230", Offset = "0x2DF0630", VA = "0x182DF1230")]
	private void BOBMPNALDEI(MBEDCJLMHEO BPCHIIFCMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public JMBPAIPOGLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[HAMPPOKOPOP(typeof(DECKIFJOPPL), new string[] { })]
public class HFIPEJNAIEL : GBCNOEIKEOL, DECKIFJOPPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private EntityManager MABCFMECCKD;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1EF0", Offset = "0x2DE12F0", VA = "0x182DE1EF0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1F70", Offset = "0x2DE1370", VA = "0x182DE1F70", Slot = "5")]
	public void JDEEJAHJMPF(MBEDCJLMHEO LMLBLIDPKCN, bool LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x29F6390", Offset = "0x29F5790", VA = "0x1829F6390")]
	private void EFMALMFMJGL<T>(MBEDCJLMHEO LMLBLIDPKCN, bool LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public HFIPEJNAIEL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[HAMPPOKOPOP(typeof(OJOLPKHEEIB), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.RenderEffects)]
	public class SelectionService : GBCNOEIKEOL, OJOLPKHEEIB
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private EntityManager MABCFMECCKD;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF040", Offset = "0x2BCE440", VA = "0x182BCF040", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF0C0", Offset = "0x2BCE4C0", VA = "0x182BCF0C0", Slot = "5")]
		public void JLHHKLACIFH(MBEDCJLMHEO LMLBLIDPKCN, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF130", Offset = "0x2BCE530", VA = "0x182BCF130", Slot = "6")]
		public void KMKKOPLGPDG(MBEDCJLMHEO LMLBLIDPKCN, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x29F6390", Offset = "0x29F5790", VA = "0x1829F6390")]
		private void EFMALMFMJGL<T>(MBEDCJLMHEO LMLBLIDPKCN, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
[HAMPPOKOPOP(typeof(LLKMHGHECCN), new string[] { })]
internal sealed class LLKMHGHECCN : GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[OMAMNFHDGBM]
	private ObjectEmbodimentService MPIEEKNKAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[OMAMNFHDGBM]
	private BHHDNNCMGLM GHDOFHADNOC;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x296B2B0", Offset = "0x296A6B0", VA = "0x18296B2B0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public LLKMHGHECCN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Serialization)]
	[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
	[HAMPPOKOPOP(typeof(WorldSerialization), new string[] { })]
	internal sealed class WorldSerialization : GBCNOEIKEOL, BOEJNPPLNGC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly KLBHBMBPLOA CFECLIGCGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[OMAMNFHDGBM]
		private FDCCILJEAIN CNAGLHOPGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[OMAMNFHDGBM]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[OMAMNFHDGBM]
		private SerializationService GOBBGGBLGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[OMAMNFHDGBM]
		private BJINHAHEIOO ADLONPJHLHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[OMAMNFHDGBM]
		private DebugWorldsService LELLCNLAJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[OMAMNFHDGBM]
		private BulkInstantiateSceneObjectService FGHHJHJAJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private FJEOEPCCLME JGMMDACFJLC;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private DKLNHGPFNEC FLJPALOIENA
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xB29B00", Offset = "0xB28F00", VA = "0x180B29B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3520", Offset = "0x2BE2920", VA = "0x182BE3520", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME HKIDKBKDNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE34F0", Offset = "0x2BE28F0", VA = "0x182BE34F0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3D50", Offset = "0x2BE3150", VA = "0x182BE3D50", Slot = "6")]
		public bool OKDEPPDEPBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3710", Offset = "0x2BE2B10", VA = "0x182BE3710", Slot = "7")]
		public bool ICNIONFFCDE(IEnumerable<BMLJODFLIKN> JGGHOCFLFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3EB0", Offset = "0x2BE32B0", VA = "0x182BE3EB0", Slot = "5")]
		public ByteString PEEAKNCHPCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3730", Offset = "0x2BE2B30", VA = "0x182BE3730")]
		private void IILCPJJLOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2BE37A0", Offset = "0x2BE2BA0", VA = "0x182BE37A0")]
		private void KJGLKDBOJJL(MANAEOMEHPG FIANHALABNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3870", Offset = "0x2BE2C70", VA = "0x182BE3870")]
		private void LCABLNOIOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3210", Offset = "0x2BE2610", VA = "0x182BE3210")]
		private void AEOLEJBOPLN(JPHKJJNABPK FIANHALABNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3750", Offset = "0x2BE2B50", VA = "0x182BE3750", Slot = "8")]
		public void JPJDNINPFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3670", Offset = "0x2BE2A70", VA = "0x182BE3670")]
		private MANAEOMEHPG HFEDJIELLHD(EntityManager MENKGFBPIJM, EntityManager DLKHAOHFHOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[HAMPPOKOPOP(typeof(AKPOGEHIEGM), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
public class AKPOGEHIEGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly Dictionary<LFEIHDPDPKH, string> JEBHCCFODNJ;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC7C0", Offset = "0x2FABBC0", VA = "0x182FAC7C0")]
	public GameObject JBOLOPOLCHP(LFEIHDPDPKH OINKDHOAIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC890", Offset = "0x2FABC90", VA = "0x182FAC890")]
	public AKPOGEHIEGM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	[HAMPPOKOPOP(typeof(TimeService), new string[] { })]
	public class TimeService : BJDLFHICAGD, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[OMAMNFHDGBM]
		private SingletonComponentService CCKICNECOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private bool PLBECFJMPDA;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public TimeData KCFJKPKMGPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x2BD6AE0", Offset = "0x2BD5EE0", VA = "0x182BD6AE0")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x2BD6A10", Offset = "0x2BD5E10", VA = "0x182BD6A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool FODPFPNFNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x72F260", Offset = "0x72E660", VA = "0x18072F260")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x754190", Offset = "0x753590", VA = "0x180754190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1DACFD0", Offset = "0x1DAC3D0", VA = "0x181DACFD0", Slot = "4")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6A90", Offset = "0x2BD5E90", VA = "0x182BD6A90", Slot = "5")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6950", Offset = "0x2BD5D50", VA = "0x182BD6950")]
		public void EAJAFFCLIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[JEGJCCBDMOE(OLCAJGBKOGB.TransformSyncing)]
	[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
	[HAMPPOKOPOP(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	internal class SetTransformParentIfParentPropertyChanges : GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private AMBNPJKGCOF HFKINOFBOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private global::CEGMBHOPAIF<Entity> GGEKFPEBLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ObjectEmbodimentService HAJHHEFGJLE;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2B70", Offset = "0x2BD1F70", VA = "0x182BD2B70", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2D20", Offset = "0x2BD2120", VA = "0x182BD2D20", Slot = "5")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2AD0", Offset = "0x2BD1ED0", VA = "0x182BD2AD0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2BE0", Offset = "0x2BD1FE0", VA = "0x182BD2BE0")]
		private void LIFHLNGOOHF(Entity LCLDFKAJPDK, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Services)]
	[HAMPPOKOPOP(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
	public class EnableTransmissionOnlyInLoadInstance : GBCNOEIKEOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[OMAMNFHDGBM]
		private OAHBPGDADMG EFCPHECCPHK;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private MNCHCDHIHID IFKPAKMNMCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x2DD7D40", Offset = "0x2DD7140", VA = "0x182DD7D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private FJLFIPEFALG OLEEICMKEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x2DD7CF0", Offset = "0x2DD70F0", VA = "0x182DD7CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7C70", Offset = "0x2DD7070", VA = "0x182DD7C70", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7C50", Offset = "0x2DD7050", VA = "0x182DD7C50", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[HAMPPOKOPOP(typeof(CJPJNEKLKGP), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
public class CJPJNEKLKGP : EADCECODNBJ, HBEOAMPLBKH, BJDLFHICAGD, GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class NLCELAKFEEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public FJEOEPCCLME services;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NLCELAKFEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB8D0", Offset = "0x2BCACD0", VA = "0x182BCB8D0")]
		internal void <InitReferences>b__0(GBCNOEIKEOL svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class DLLFCFKOHFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public FJEOEPCCLME services;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DLLFCFKOHFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x2BC83B0", Offset = "0x2BC77B0", VA = "0x182BC83B0")]
		internal void <InitExternal>b__0(IJGJDJPFIAJ svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[OMAMNFHDGBM]
	private BHHDNNCMGLM GHDOFHADNOC;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public HNJBILHOIMC DMGKCMGPDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x8F57D0", Offset = "0x8F4BD0", VA = "0x1808F57D0", Slot = "4")]
		get
		{
			return default(HNJBILHOIMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private MKDEFAJNDJH LJDGEIMOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x2FB6D50", Offset = "0x2FB6150", VA = "0x182FB6D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6D00", Offset = "0x2FB6100", VA = "0x182FB6D00", Slot = "5")]
	public void AHPFPMIFNAG(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6DA0", Offset = "0x2FB61A0", VA = "0x182FB6DA0", Slot = "6")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7000", Offset = "0x2FB6400", VA = "0x182FB7000", Slot = "7")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2FB70E0", Offset = "0x2FB64E0", VA = "0x182FB70E0", Slot = "8")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6ED0", Offset = "0x2FB62D0", VA = "0x182FB6ED0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x22ADB10", Offset = "0x22ACF10", VA = "0x1822ADB10")]
	private void DKLEEIMJLHM<T>(Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public CJPJNEKLKGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class LGCMJKILOIO<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly Func<From, To> FHJNDBAFJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly Func<To, From> JJKFOPGJCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public DynamicBuffer<From> NPOGECPDPEK;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	public LGCMJKILOIO(Func<From, To> FHJNDBAFJCD, Func<To, From> JJKFOPGJCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To JPOBIIKLHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int EGNHJGKABLC, To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public class KKKPEFJDDAI<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Func<From, To> FHJNDBAFJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly Func<To, From> JJKFOPGJCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public List<From> BDHPAGCMKHB;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x3399160", Offset = "0x3398560", VA = "0x183399160", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x33991C0", Offset = "0x33985C0", VA = "0x1833991C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x3399130", Offset = "0x3398530", VA = "0x183399130", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x754680", Offset = "0x753A80", VA = "0x180754680", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x754690", Offset = "0x753A90", VA = "0x180754690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x33990A0", Offset = "0x33984A0", VA = "0x1833990A0")]
	public KKKPEFJDDAI(Func<From, To> FHJNDBAFJCD, Func<To, From> JJKFOPGJCGG, bool GLNNHMBNJIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x3398C60", Offset = "0x3398060", VA = "0x183398C60", Slot = "11")]
	public void Add(To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x3398CC0", Offset = "0x33980C0", VA = "0x183398CC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x3398CF0", Offset = "0x33980F0", VA = "0x183398CF0", Slot = "13")]
	public bool Contains(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x3398D50", Offset = "0x3398150", VA = "0x183398D50", Slot = "14")]
	public void CopyTo(To[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x3398E60", Offset = "0x3398260", VA = "0x183398E60", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x3398F30", Offset = "0x3398330", VA = "0x183398F30", Slot = "6")]
	public int IndexOf(To JPOBIIKLHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x3398F90", Offset = "0x3398390", VA = "0x183398F90", Slot = "7")]
	public void Insert(int EGNHJGKABLC, To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x3399040", Offset = "0x3398440", VA = "0x183399040", Slot = "15")]
	public bool Remove(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x3399010", Offset = "0x3398410", VA = "0x183399010", Slot = "8")]
	public void RemoveAt(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x2846380", Offset = "0x2845780", VA = "0x182846380", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DefaultMember("Item")]
public class LPHOIOIKFHI<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Func<From, To> FHJNDBAFJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly Func<To, From> JJKFOPGJCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<From> BGAKDGCGOMH;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x1F9ED60", Offset = "0x1F9E160", VA = "0x181F9ED60", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x1F9EDB0", Offset = "0x1F9E1B0", VA = "0x181F9EDB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x1F9ED20", Offset = "0x1F9E120", VA = "0x181F9ED20", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9ECC0", Offset = "0x1F9E0C0", VA = "0x181F9ECC0")]
	public LPHOIOIKFHI(Func<From, To> FHJNDBAFJCD, Func<To, From> JJKFOPGJCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E8D0", Offset = "0x1F9DCD0", VA = "0x181F9E8D0", Slot = "11")]
	public void Add(To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E910", Offset = "0x1F9DD10", VA = "0x181F9E910", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E950", Offset = "0x1F9DD50", VA = "0x181F9E950", Slot = "13")]
	public bool Contains(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EA10", Offset = "0x1F9DE10", VA = "0x181F9EA10", Slot = "14")]
	public void CopyTo(To[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EAD0", Offset = "0x1F9DED0", VA = "0x181F9EAD0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EB90", Offset = "0x1F9DF90", VA = "0x181F9EB90", Slot = "6")]
	public int IndexOf(To JPOBIIKLHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EC00", Offset = "0x1F9E000", VA = "0x181F9EC00", Slot = "7")]
	public void Insert(int EGNHJGKABLC, To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EC80", Offset = "0x1F9E080", VA = "0x181F9EC80", Slot = "15")]
	public bool Remove(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EC40", Offset = "0x1F9E040", VA = "0x181F9EC40", Slot = "8")]
	public void RemoveAt(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x1D001E0", Offset = "0x1CFF5E0", VA = "0x181D001E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public class EIPLJMILMML<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly Func<From, To> FHJNDBAFJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly Func<To, From> JJKFOPGJCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeList<From> BDHPAGCMKHB;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public To JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	public EIPLJMILMML(Func<From, To> FHJNDBAFJCD, Func<To, From> JJKFOPGJCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To JPOBIIKLHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int EGNHJGKABLC, To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class LCMIIBLNCML
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public const string BBLGIINMLOP = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public const string EJDMFLIGPHG = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const string DOFJJECPPKF = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public const string JJKAKMMHOLH = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const string DLJEPACOCOJ = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public const string FIEJEPEDBBL = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public const string HIAELGMBGHK = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public const string EPMFOBDFHLM = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class EJJABGJLEBE
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class ALLAKMMAOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public FJEOEPCCLME services;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ALLAKMMAOIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x4391650", Offset = "0x4390A50", VA = "0x184391650")]
		internal void <InitServices>b__1(GBCNOEIKEOL svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x43916B0", Offset = "0x4390AB0", VA = "0x1843916B0")]
		internal void <InitServices>b__2(IJGJDJPFIAJ svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC95E0", Offset = "0x2FC89E0", VA = "0x182FC95E0")]
	public static void PCLKGJBKNNM(this MKDEFAJNDJH ACFGKGFDFPL, FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x169F1D0", Offset = "0x169E5D0", VA = "0x18169F1D0")]
	public static void DKLEEIMJLHM<T>(this MKDEFAJNDJH ACFGKGFDFPL, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x169F620", Offset = "0x169EA20", VA = "0x18169F620")]
	public static void LDGHCFFPNLF<T>(this MKDEFAJNDJH ACFGKGFDFPL, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x169F970", Offset = "0x169ED70", VA = "0x18169F970")]
	public static void OCPFIMEBHGJ<T>(this MKDEFAJNDJH ACFGKGFDFPL, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x169F7C0", Offset = "0x169EBC0", VA = "0x18169F7C0")]
	public static void MJBBHNFIDIE<T>(this MKDEFAJNDJH ACFGKGFDFPL, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x169F240", Offset = "0x169E640", VA = "0x18169F240")]
	public static void IHPACNHNKEG<T>(this MKDEFAJNDJH ACFGKGFDFPL, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x169F4B0", Offset = "0x169E8B0", VA = "0x18169F4B0")]
	public static void LDGHCFFPNLF<T>(IEnumerable<ComponentSystemBase> DFKHIBLIHPO, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x169F3F0", Offset = "0x169E7F0", VA = "0x18169F3F0")]
	private static void IKEHILFMCDJ<T>(object HFKGGLPFCMG, Action<T> MOJNBGAOCCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class MJGNCJMFLFH
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class LMFCLIODLGF
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x296B390", Offset = "0x296A790", VA = "0x18296B390")]
	public static void ADLCBAGNIEO(ComponentSystemBase HFKGGLPFCMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class CIPDJIIGFFL
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	public static bool DMLNPENFHLB<T>(ref T HFOFADIOHHP, ref T GFCGIJPPCBN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class AOJNGLIFNKF
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class MMABKGNGAFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public MMABKGNGAFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x2FAE640", Offset = "0x2FADA40", VA = "0x182FAE640")]
	public static string PMOJLOOHEIO(Transform CACALPHNCBH, Transform ELODBNLDLIK)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1C50", Offset = "0x2BD1050", VA = "0x182BD1C50")]
		public static void MNNDBLCHNEL(this HJOJGGNKDFB JGMMDACFJLC, HKCMLMJLMKG CAAHBOFLBKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BD18A0", Offset = "0x2BD0CA0", VA = "0x182BD18A0")]
		public static void DJHEHHELFNE(this HJOJGGNKDFB JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1E80", Offset = "0x2BD1280", VA = "0x182BD1E80")]
		public static void MNNDBLCHNEL(this HJOJGGNKDFB JGMMDACFJLC, [Optional] string[] FGNJBPFPMMH, [Optional] string[] JMEMMLMPMKE, [Optional] string[] IIPEDEHICDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1F90", Offset = "0x2BD1390", VA = "0x182BD1F90")]
		public static void OEIKFPMDIHL(this HJOJGGNKDFB JGMMDACFJLC, params string[] AFFPJFFGLAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1BA0", Offset = "0x2BD0FA0", VA = "0x182BD1BA0")]
		public static void KNKJLJCLAMC(this HJOJGGNKDFB JGMMDACFJLC, params string[] AFFPJFFGLAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD19A0", Offset = "0x2BD0DA0", VA = "0x182BD19A0")]
		private static string[] KHPPMKMMLDE(HKCMLMJLMKG CAAHBOFLBKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2040", Offset = "0x2BD1440", VA = "0x182BD2040")]
		private static bool PFJPMDKFGKO(HKCMLMJLMKG CAAHBOFLBKP, out string[] AEFFIHCGMFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820")]
		private static bool KMOKDBPIPOH()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class MIFCJABFCAI : JJMIJJELAPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly MethodInfo PDHDLHKNOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Type[] FKFCAPAEHKO;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x296DC80", Offset = "0x296D080", VA = "0x18296DC80")]
	public MIFCJABFCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action EKKOICMAFIL();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x296DA90", Offset = "0x296CE90", VA = "0x18296DA90")]
	public MethodInfo EBGNNKPPDEL(Action DAAMKALKLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x296DAD0", Offset = "0x296CED0", VA = "0x18296DAD0", Slot = "4")]
	public void EHOMCGHPBHE(Type OGILDIMGIOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class KKMMBOAGKPG : MIFCJABFCAI
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum DOHFGLMIJLL
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4550", Offset = "0x2DF3950", VA = "0x182DF4550", Slot = "5")]
	public override Action EKKOICMAFIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void GONJADLODAI<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2DF45E0", Offset = "0x2DF39E0", VA = "0x182DF45E0")]
	[Preserve]
	public void OLFPMMGLCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2DE70E0", Offset = "0x2DE64E0", VA = "0x182DE70E0")]
	protected KKMMBOAGKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class ILLNANCIIHL : MIFCJABFCAI
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB070", Offset = "0x2DEA470", VA = "0x182DEB070", Slot = "5")]
	public override Action EKKOICMAFIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void BLDMFMKOAGE<T>() where T : HLLCIEEAKDG;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB100", Offset = "0x2DEA500", VA = "0x182DEB100")]
	[Preserve]
	public void OLFPMMGLCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x2DE70E0", Offset = "0x2DE64E0", VA = "0x182DE70E0")]
	protected ILLNANCIIHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class IDIFLMJNOJP : MIFCJABFCAI
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6FC0", Offset = "0x2DE63C0", VA = "0x182DE6FC0", Slot = "5")]
	public override Action EKKOICMAFIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void IPNDLBGHJJA<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7050", Offset = "0x2DE6450", VA = "0x182DE7050")]
	[Preserve]
	public void OLFPMMGLCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x2DE70E0", Offset = "0x2DE64E0", VA = "0x182DE70E0")]
	protected IDIFLMJNOJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class KEGPFJEJOHN
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2790", Offset = "0x2DF1B90", VA = "0x182DF2790")]
	public static Entity FLPEOIDMNGL(this EntityManager MABCFMECCKD)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[JEGJCCBDMOE(OLCAJGBKOGB.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class HJAIMDHOKKF : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000625")]
				[Cpp2IlInjected.Address(RVA = "0x1F92290", Offset = "0x1F91690", VA = "0x181F92290", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000627")]
				[Cpp2IlInjected.Address(RVA = "0x43941A0", Offset = "0x43935A0", VA = "0x1843941A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x43907A0", Offset = "0x438FBA0", VA = "0x1843907A0")]
			[DebuggerHidden]
			public HJAIMDHOKKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x4393FD0", Offset = "0x43933D0", VA = "0x184393FD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x4394160", Offset = "0x4393560", VA = "0x184394160", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x43940B0", Offset = "0x43934B0", VA = "0x1843940B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x43940B0", Offset = "0x43934B0", VA = "0x1843940B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class ADFMFLJNPFP : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private IEnumerator<Entity> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600062E")]
				[Cpp2IlInjected.Address(RVA = "0x1F92290", Offset = "0x1F91690", VA = "0x181F92290", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000630")]
				[Cpp2IlInjected.Address(RVA = "0x4390670", Offset = "0x438FA70", VA = "0x184390670", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x43907A0", Offset = "0x438FBA0", VA = "0x1843907A0")]
			[DebuggerHidden]
			public ADFMFLJNPFP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x43906C0", Offset = "0x438FAC0", VA = "0x1843906C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x4390390", Offset = "0x438F790", VA = "0x184390390", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x4390750", Offset = "0x438FB50", VA = "0x184390750")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x4390630", Offset = "0x438FA30", VA = "0x184390630", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x4390580", Offset = "0x438F980", VA = "0x184390580", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x4390580", Offset = "0x438F980", VA = "0x184390580", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class FLPDOIGIIML : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			private ChildrenData <childData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			private IEnumerator<Entity> <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x170000D3")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000638")]
				[Cpp2IlInjected.Address(RVA = "0x1F92290", Offset = "0x1F91690", VA = "0x181F92290", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D4")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600063A")]
				[Cpp2IlInjected.Address(RVA = "0x4392FB0", Offset = "0x43923B0", VA = "0x184392FB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x43907A0", Offset = "0x438FBA0", VA = "0x1843907A0")]
			[DebuggerHidden]
			public FLPDOIGIIML(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x4393000", Offset = "0x4392400", VA = "0x184393000", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x4392BA0", Offset = "0x4391FA0", VA = "0x184392BA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x43930D0", Offset = "0x43924D0", VA = "0x1843930D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x4393120", Offset = "0x4392520", VA = "0x184393120")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x4392F70", Offset = "0x4392370", VA = "0x184392F70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x4392ED0", Offset = "0x43922D0", VA = "0x184392ED0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x4392ED0", Offset = "0x43922D0", VA = "0x184392ED0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAED0", Offset = "0x2DDA2D0", VA = "0x182DDAED0")]
		public static Entity IJHIFONNBOI(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB8C0", Offset = "0x2DDACC0", VA = "0x182DDB8C0")]
		public static DynamicBuffer<ChildrenData> OEDLEMFHJKD(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA290", Offset = "0x2DD9690", VA = "0x182DDA290")]
		public static DynamicBuffer<ChildrenData> ANBALFNDFEP(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAC70", Offset = "0x2DDA070", VA = "0x182DDAC70")]
		public static NativeArray<Entity> HGCEPDCEEAC(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Allocator FKHAEPDPDAI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB530", Offset = "0x2DDA930", VA = "0x182DDB530")]
		public static bool KKCLHCMAHPD(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Allocator FKHAEPDPDAI, out NativeArray<Entity> JFBBGIJLDJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA320", Offset = "0x2DD9720", VA = "0x182DDA320")]
		public static NativeArray<Entity> BMPHHKPCLFL(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA0B0", Offset = "0x2DD94B0", VA = "0x182DDA0B0")]
		public static Entity AFFCJINMNLA(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, int EGNHJGKABLC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAB60", Offset = "0x2DD9F60", VA = "0x182DDAB60")]
		public static int FOLBFCNBPGG(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB2D0", Offset = "0x2DDA6D0", VA = "0x182DDB2D0")]
		public static void KCFMHGFOPJA(NativeArray<Entity> EOPPFFEOLEM, NativeArray<Entity> BOGHIFKGACA, EntityManager MABCFMECCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA1E0", Offset = "0x2DD95E0", VA = "0x182DDA1E0")]
		public static int AJILHEJIKOP(this EntityManager MABCFMECCKD, Entity GGEKFPEBLKN, Entity ILLPMKANGKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAA00", Offset = "0x2DD9E00", VA = "0x182DDAA00")]
		public static bool FFKLPDDAEHN(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Entity NLBEDCCLIFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA690", Offset = "0x2DD9A90", VA = "0x182DDA690")]
		public static IEnumerable<Entity> CMGIHGILOAF(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x2DDADA0", Offset = "0x2DDA1A0", VA = "0x182DDADA0")]
		public static bool HMKPBKJMFKD(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Entity ILLPMKANGKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB630", Offset = "0x2DDAA30", VA = "0x182DDB630")]
		public static bool NBCMHKFAKCC(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Entity AGDKLNJDAPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAF40", Offset = "0x2DDA340", VA = "0x182DDAF40")]
		public static NativeList<Entity> JCKMNEBEMBO(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, bool PNGNAFIFALL = false, Allocator FKHAEPDPDAI = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA480", Offset = "0x2DD9880", VA = "0x182DDA480")]
		public static IEnumerable<Entity> CEAEBLDPEEN(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB7C0", Offset = "0x2DDABC0", VA = "0x182DDB7C0")]
		public static Entity NKAKDLGIEDI(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA7A0", Offset = "0x2DD9BA0", VA = "0x182DDA7A0")]
		public static bool EDCKHKPPKHK(this EntityManager MABCFMECCKD, Entity AGDKLNJDAPF, Entity NMPDJFDFMIN, out Entity NFENBCEFMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB250", Offset = "0x2DDA650", VA = "0x182DDB250")]
		internal static void JKKBLJHDAPI(EntityManager MABCFMECCKD, Entity GGEKFPEBLKN, Entity ILLPMKANGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB150", Offset = "0x2DDA550", VA = "0x182DDB150")]
		internal static void JHCKGPFNFMN(EntityManager MABCFMECCKD, Entity GGEKFPEBLKN, Entity ILLPMKANGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA600", Offset = "0x2DD9A00", VA = "0x182DDA600")]
		[IteratorStateMachine(typeof(HJAIMDHOKKF))]
		private static IEnumerable<Entity> CIHMFIOEHIE(EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB950", Offset = "0x2DDAD50", VA = "0x182DDB950")]
		[IteratorStateMachine(typeof(ADFMFLJNPFP))]
		private static IEnumerable<Entity> OMDGDKOFGEA(EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAE50", Offset = "0x2DDA250", VA = "0x182DDAE50")]
		[IteratorStateMachine(typeof(FLPDOIGIIML))]
		private static IEnumerable<Entity> HOECHHIKJAL(EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB9E0", Offset = "0x2DDADE0", VA = "0x182DDB9E0")]
		private static bool PBMIFOPHGLE(EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Entity NLBEDCCLIFO)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[HAMPPOKOPOP(typeof(JDFPNHDAOJJ), new string[] { })]
public class BELCBELMDMF : JDFPNHDAOJJ, EADCECODNBJ, OFGHLKBBKBB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private FJEOEPCCLME JGMMDACFJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private BFHOGDONKCB NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private FDCCILJEAIN CNAGLHOPGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private OJMGIHLPABJ EGACOJLEBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private CLIHAPFPPDO BKOBOKBHBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private AMBNPJKGCOF HFKINOFBOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private HNIIKODBKKD GOBBGGBLGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private MMCKNDDCKHO PGKJLOKPPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private ILADIFIOBIK FNBGFGCHFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private LOEKKAPPCFD JOCOFLLIADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private OONCEOFLMII ONFLMFMBJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private NDFDMPICGAG GEFBMNBCACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private OECKLJAFLCL GGCACBKODOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private LJHBPFAFOIK GHANEJHPALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private DECKIFJOPPL PLJOMALPEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private OJOLPKHEEIB PKMLOGOMCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private GCEEGFGLLJD MPCNOCLAJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private FDHGKOHMFEH PNHFNLJOOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private ABGDBOLFPHD IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public FJEOEPCCLME PICFDDKMBKH
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public BFHOGDONKCB CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public BHHDNNCMGLM LJDGEIMOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public FDCCILJEAIN GOLAHAFEIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public OJMGIHLPABJ BJCANCIPCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public DDOLHFHMLOP DIPPIPKFCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x735A10", Offset = "0x734E10", VA = "0x180735A10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public CLIHAPFPPDO EHJMHIENHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x77E9A0", Offset = "0x77DDA0", VA = "0x18077E9A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public AMBNPJKGCOF EFDNLJHDPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x72B0F0", Offset = "0x72A4F0", VA = "0x18072B0F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public HNIIKODBKKD GPIPEIHLBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x72B0A0", Offset = "0x72A4A0", VA = "0x18072B0A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public MMCKNDDCKHO MLIMCCODDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x72B0D0", Offset = "0x72A4D0", VA = "0x18072B0D0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public ILADIFIOBIK BDOBIEBIADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x72B0B0", Offset = "0x72A4B0", VA = "0x18072B0B0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public LOEKKAPPCFD OKFLBOELOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x72B0C0", Offset = "0x72A4C0", VA = "0x18072B0C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public OONCEOFLMII NHHIFAJBKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x72B040", Offset = "0x72A440", VA = "0x18072B040", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public NDFDMPICGAG CIJDLCNILKP
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x72B050", Offset = "0x72A450", VA = "0x18072B050", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public OECKLJAFLCL PKCMHFFGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x802C90", Offset = "0x802090", VA = "0x180802C90", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public LJHBPFAFOIK BOJCKHHDBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x803620", Offset = "0x802A20", VA = "0x180803620", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public DECKIFJOPPL OOJOBGNBJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x765AF0", Offset = "0x764EF0", VA = "0x180765AF0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public OJOLPKHEEIB HLMHOICHEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x803640", Offset = "0x802A40", VA = "0x180803640", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public GCEEGFGLLJD BPEFMKPADKP
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x72B060", Offset = "0x72A460", VA = "0x18072B060", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public FDHGKOHMFEH HOLIGPGDLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x72B070", Offset = "0x72A470", VA = "0x18072B070", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public ABGDBOLFPHD OFCGPOGBJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x72B090", Offset = "0x72A490", VA = "0x18072B090", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public HNJBILHOIMC DMGKCMGPDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x73B4E0", Offset = "0x73A8E0", VA = "0x18073B4E0", Slot = "21")]
		get
		{
			return default(HNJBILHOIMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2FB00E0", Offset = "0x2FAF4E0", VA = "0x182FB00E0", Slot = "22")]
	public void AHPFPMIFNAG(FJEOEPCCLME HKIDKBKDNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B540", Offset = "0x1E3A940", VA = "0x181E3B540", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2FB03D0", Offset = "0x2FAF7D0", VA = "0x182FB03D0", Slot = "23")]
	public void CCCAANGKKJB(FJEOEPCCLME HKIDKBKDNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public BELCBELMDMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
public class IJMIEGCMPPA : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class AANHDIOFKDH : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public IJMIEGCMPPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x72B0E0", Offset = "0x72A4E0", VA = "0x18072B0E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x4390340", Offset = "0x438F740", VA = "0x184390340", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public AANHDIOFKDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x4390190", Offset = "0x438F590", VA = "0x184390190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x4390300", Offset = "0x438F700", VA = "0x184390300", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected const ulong FBBPFDMGFIE = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected const ulong HJDNNEFKOBD = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected const int ICOPLNPJGGA = 8;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	protected const int ABGPFFIADPB = 6;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public const int ALMKIJPHBPG = 64;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	protected const int NFODDMEOMEJ = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly List<ulong> JMOLMFFIBKN;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x788950", Offset = "0x787D50", VA = "0x180788950")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xBB01E0", Offset = "0xBAF5E0", VA = "0x180BB01E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int CODCLFMHLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x730630", Offset = "0x72FA30", VA = "0x180730630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x7B05E0", Offset = "0x7AF9E0", VA = "0x1807B05E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA450", Offset = "0x2DE9850", VA = "0x182DEA450")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x2DEAB90", Offset = "0x2DE9F90", VA = "0x182DEAB90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x2DEADD0", Offset = "0x2DEA1D0", VA = "0x182DEADD0")]
	public IJMIEGCMPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x2DEAE50", Offset = "0x2DEA250", VA = "0x182DEAE50")]
	public IJMIEGCMPPA(int DBHCHJIPCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA800", Offset = "0x2DE9C00", VA = "0x182DEA800")]
	public bool INLNHMHBIFH(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA8E0", Offset = "0x2DE9CE0", VA = "0x182DEA8E0")]
	public bool JKMCEKMFFED(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA4F0", Offset = "0x2DE98F0", VA = "0x182DEA4F0")]
	public bool DIJLMCJOFIG(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA660", Offset = "0x2DE9A60", VA = "0x182DEA660")]
	public bool FAKGJGPBFFP(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2DEAD40", Offset = "0x2DEA140", VA = "0x182DEAD40")]
	public void PMDMHBPEGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA360", Offset = "0x2DE9760", VA = "0x182DEA360")]
	public void COONODJIOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA570", Offset = "0x2DE9970", VA = "0x182DEA570")]
	public void EFMALMFMJGL(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA210", Offset = "0x2DE9610", VA = "0x182DEA210")]
	public void BONIBAPHNIO(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA040", Offset = "0x2DE9440", VA = "0x182DEA040")]
	public bool AAMENLIPJIG(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA670", Offset = "0x2DE9A70", VA = "0x182DEA670")]
	public void FDLCGMLBEAK(int LBOLDANMBMA, int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA9D0", Offset = "0x2DE9DD0", VA = "0x182DEA9D0")]
	public void KGJHGEOFPEA(int CNHDJCCEHGI, int EKOBHOLKDHO, int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA0D0", Offset = "0x2DE94D0", VA = "0x182DEA0D0")]
	public int AGMLDLCGDGN(int EJMNNLNLAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA1A0", Offset = "0x2DE95A0", VA = "0x182DEA1A0")]
	public int AGMLDLCGDGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA310", Offset = "0x2DE9710", VA = "0x182DEA310")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA790", Offset = "0x2DE9B90", VA = "0x182DEA790", Slot = "4")]
	[IteratorStateMachine(typeof(AANHDIOFKDH))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA790", Offset = "0x2DE9B90", VA = "0x182DEA790", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class KFDFIBEHNAO<T> : global::CNGNALLHOAD<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	protected global::KAEJMNENLIM<T> FCFIJAMEHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected global::IKBIBPMEKFA<T> COIKOAPILOH;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x1379D50", Offset = "0x1379150", VA = "0x181379D50")]
	public KFDFIBEHNAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A9B0", Offset = "0x2A99DB0", VA = "0x182A9A9B0")]
	public KFDFIBEHNAO(global::KAEJMNENLIM<T> FCFIJAMEHIP, global::IKBIBPMEKFA<T> COIKOAPILOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A790", Offset = "0x2A99B90", VA = "0x182A9A790", Slot = "11")]
	public override T JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A2C0", Offset = "0x2A996C0", VA = "0x182A9A2C0", Slot = "12")]
	public override void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH, T LPJDDLMPNCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class ELGHCECBPLF
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x218F2E0", Offset = "0x218E6E0", VA = "0x18218F2E0")]
	public static AHKPLOLMABO EHOMCGHPBHE<T>(this ACAPACFAGOM FNBGFGCHFDN, global::OBMHIPHOPOO<T> AMNLGEBHFHK, global::KAEJMNENLIM<T> FCFIJAMEHIP, global::IKBIBPMEKFA<T> COIKOAPILOH) where T : struct
	{
		return default(AHKPLOLMABO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class BDJFOKEEEDN<T> : global::KFDFIBEHNAO<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x2238280", Offset = "0x2237680", VA = "0x182238280")]
	public BDJFOKEEEDN(T ONLKOJHBEOC, T JKHCMKCHKPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class DCNLKAGJLKE<T> : global::CNGNALLHOAD<T> where T : struct, HLLCIEEAKDG
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x299B830", Offset = "0x299AC30", VA = "0x18299B830", Slot = "11")]
	public override T JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x299B740", Offset = "0x299AB40", VA = "0x18299B740", Slot = "12")]
	public override void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH, T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x1614FC0", Offset = "0x16143C0", VA = "0x181614FC0")]
	public DCNLKAGJLKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class NDBPKAKFANK : FFICJKMIKPC
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public abstract Type NAGJKAGCKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH, in LGDIAIHEOID LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH, in HAMGOKKMMPI LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void KJCIHCOFJEN(CDCPEIFBKAJ MPOAAENBMAH, JPBCALOAEAE DNIKKNNGFMM, [Optional] object PKDAKJPDDGD);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	protected NDBPKAKFANK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public abstract class CNGNALLHOAD<T> : NDBPKAKFANK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public override Type NAGJKAGCKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x259D070", Offset = "0x259C470", VA = "0x18259D070", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH, T LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x259DDC0", Offset = "0x259D1C0", VA = "0x18259DDC0", Slot = "8")]
	public override void JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH, in LGDIAIHEOID ELODBNLDLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x259C8F0", Offset = "0x259BCF0", VA = "0x18259C8F0", Slot = "9")]
	public override void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH, in HAMGOKKMMPI KCGHNGOMAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x259E270", Offset = "0x259D670", VA = "0x18259E270", Slot = "10")]
	public override void KJCIHCOFJEN(CDCPEIFBKAJ MPOAAENBMAH, JPBCALOAEAE DNIKKNNGFMM, object PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0xF93720", Offset = "0xF92B20", VA = "0x180F93720")]
	protected CNGNALLHOAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class JDJKOHNMHPB
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class PBOIJIAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class CILGBKBODEH<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
			public CILGBKBODEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x258BD90", Offset = "0x258B190", VA = "0x18258BD90")]
			internal void <RegisterFixedString>b__0(CDCPEIFBKAJ p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x258C000", Offset = "0x258B400", VA = "0x18258C000")]
			internal T <RegisterFixedString>b__1(CDCPEIFBKAJ p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x4399D50", Offset = "0x4399150", VA = "0x184399D50")]
		public static void EIFKPHBGFFD(HEBPACNMIJJ DKLBPBGOMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x4419550", Offset = "0x4418950", VA = "0x184419550")]
		private static void LPJFGHJAPIG<T>(HEBPACNMIJJ DKLBPBGOMJE, int JKHCMKCHKPC) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x44194C0", Offset = "0x44188C0", VA = "0x1844194C0")]
		private static void CNAJGFMGADB<T>(CDCPEIFBKAJ JOFEJELEMJH, T CMBMGCLLFDP, int JKHCMKCHKPC) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x4418E70", Offset = "0x4418270", VA = "0x184418E70")]
		private static T BACNOJCDKLG<T>(CDCPEIFBKAJ JOFEJELEMJH, int JKHCMKCHKPC) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PBOIJIAFDPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class NIONPCHEGJF : KKMMBOAGKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private HEBPACNMIJJ DKLBPBGOMJE;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x4418AD0", Offset = "0x4417ED0", VA = "0x184418AD0", Slot = "6")]
		public override void GONJADLODAI<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x4397FA0", Offset = "0x43973A0", VA = "0x184397FA0")]
		public static void AOCHDJJDHOC(HEBPACNMIJJ DKLBPBGOMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x4398050", Offset = "0x4397450", VA = "0x184398050")]
		public NIONPCHEGJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE670", Offset = "0x2DEDA70", VA = "0x182DEE670")]
	public static void KNEILNAKNGH(HEBPACNMIJJ DKLBPBGOMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x2108C60", Offset = "0x2108060", VA = "0x182108C60")]
	public static void LKAOJPAILAL<T>(HEBPACNMIJJ DKLBPBGOMJE, global::KAEJMNENLIM<T> FCFIJAMEHIP, global::IKBIBPMEKFA<T> COIKOAPILOH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x2108CF0", Offset = "0x21080F0", VA = "0x182108CF0")]
	public static void OKALENPJFBO<T>(HEBPACNMIJJ BLNCBNBKOBM) where T : struct, HLLCIEEAKDG
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
public interface HEBPACNMIJJ : global::PEBAANKICOC<HEBPACNMIJJ>
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHOMCGHPBHE(Type OGILDIMGIOH, FFICJKMIKPC BLNCBNBKOBM);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OBCGBBDEENH(Type OGILDIMGIOH, out FFICJKMIKPC BLNCBNBKOBM);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class CFEMONPFCCP
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x2FB54D0", Offset = "0x2FB48D0", VA = "0x182FB54D0")]
	public static void EHOMCGHPBHE(this HEBPACNMIJJ LHDJJEMNOIF, FFICJKMIKPC BLNCBNBKOBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[HAMPPOKOPOP(typeof(ACAPACFAGOM), new string[] { })]
public sealed class BLPEEOFFJDN : ACAPACFAGOM, global::PEBAANKICOC<ACAPACFAGOM>, BJDLFHICAGD, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly Dictionary<AHKPLOLMABO, FFICJKMIKPC> DKLBPBGOMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private HEBPACNMIJJ JPBDBLCHBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private IMLNJKELEFP FNBGFGCHFDN;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool IODIKMLJACL
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x754680", Offset = "0x753A80", VA = "0x180754680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x754690", Offset = "0x753A90", VA = "0x180754690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2660", Offset = "0x2FB1A60", VA = "0x182FB2660")]
	public BLPEEOFFJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x2FB26E0", Offset = "0x2FB1AE0", VA = "0x182FB26E0")]
	public BLPEEOFFJDN(Dictionary<AHKPLOLMABO, FFICJKMIKPC> DKLBPBGOMJE, bool HAIDDAMPLEF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2040", Offset = "0x2FB1440", VA = "0x182FB2040", Slot = "7")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2210", Offset = "0x2FB1610", VA = "0x182FB2210", Slot = "8")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1F20", Offset = "0x2FB1320", VA = "0x182FB1F20", Slot = "9")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1F70", Offset = "0x2FB1370", VA = "0x182FB1F70", Slot = "4")]
	public AHKPLOLMABO DCNFHPDCNKA(DDIEEGNDNAH AMNLGEBHFHK)
	{
		return default(AHKPLOLMABO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2FB20A0", Offset = "0x2FB14A0", VA = "0x182FB20A0", Slot = "5")]
	public void EHOMCGHPBHE(AHKPLOLMABO PKNOIGMENLD, FFICJKMIKPC BLNCBNBKOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2290", Offset = "0x2FB1690", VA = "0x182FB2290")]
	[Conditional("DEBUG_BUILD")]
	private void KNBAPPCJBKN(AHKPLOLMABO PKNOIGMENLD, Type OGILDIMGIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2FB24B0", Offset = "0x2FB18B0", VA = "0x182FB24B0", Slot = "6")]
	public bool OBCGBBDEENH(AHKPLOLMABO PKNOIGMENLD, out FFICJKMIKPC BLNCBNBKOBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2FB23D0", Offset = "0x2FB17D0", VA = "0x182FB23D0", Slot = "10")]
	public ACAPACFAGOM LAPMDFGBALG()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[HAMPPOKOPOP(typeof(HEBPACNMIJJ), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.TypeSerializer)]
	public sealed class TypeSerializerService : BJDLFHICAGD, HEBPACNMIJJ, global::PEBAANKICOC<HEBPACNMIJJ>
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly Dictionary<Type, FFICJKMIKPC> DKLBPBGOMJE;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public bool IODIKMLJACL
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x72F260", Offset = "0x72E660", VA = "0x18072F260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x754190", Offset = "0x753590", VA = "0x180754190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC790", Offset = "0x2BDBB90", VA = "0x182BDC790")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC810", Offset = "0x2BDBC10", VA = "0x182BDC810")]
		public TypeSerializerService(Dictionary<Type, FFICJKMIKPC> DKLBPBGOMJE, bool HAIDDAMPLEF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC400", Offset = "0x2BDB800", VA = "0x182BDC400", Slot = "4")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC460", Offset = "0x2BDB860", VA = "0x182BDC460", Slot = "5")]
		public void EHOMCGHPBHE(Type OGILDIMGIOH, FFICJKMIKPC BLNCBNBKOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC660", Offset = "0x2BDBA60", VA = "0x182BDC660", Slot = "6")]
		public bool OBCGBBDEENH(Type OGILDIMGIOH, out FFICJKMIKPC BLNCBNBKOBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC580", Offset = "0x2BDB980", VA = "0x182BDC580", Slot = "7")]
		public HEBPACNMIJJ LAPMDFGBALG()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[HAMPPOKOPOP(typeof(IIAHDFNAEEE), new string[] { })]
internal sealed class PIAIPDDBNHH : IIAHDFNAEEE, BJDLFHICAGD, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Dictionary<AHKPLOLMABO, MNMLDAEHJEP> MLFDDPEMNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private IMLNJKELEFP FNBGFGCHFDN;

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x2980690", Offset = "0x297FA90", VA = "0x182980690", Slot = "6")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x29807C0", Offset = "0x297FBC0", VA = "0x1829807C0", Slot = "7")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x29806E0", Offset = "0x297FAE0", VA = "0x1829806E0", Slot = "4")]
	public void EHOMCGHPBHE(AHKPLOLMABO CBPECCEKJOB, Type GGKOLFHJEEI, MNMLDAEHJEP IKMIEJANNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2980750", Offset = "0x297FB50", VA = "0x182980750", Slot = "5")]
	public bool FFBJODJAHOH(AHKPLOLMABO CBPECCEKJOB, out MNMLDAEHJEP IKMIEJANNMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2980820", Offset = "0x297FC20", VA = "0x182980820")]
	[Conditional("DEBUG_BUILD")]
	private void JEACGGEHGFN(AHKPLOLMABO CBPECCEKJOB, Type GGKOLFHJEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x29809B0", Offset = "0x297FDB0", VA = "0x1829809B0")]
	public PIAIPDDBNHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[HAMPPOKOPOP(typeof(OCPMLJHNLDH), new string[] { })]
internal sealed class CDDPMEICGNK : OCPMLJHNLDH, HBEOAMPLBKH, BJDLFHICAGD, GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly IJMIEGCMPPA HCAMGFFBIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly Dictionary<KHMECMDAALD, int> HNPNICELIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly Stack<int> OEFGDAGFKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[OMAMNFHDGBM]
	private IMLNJKELEFP FNBGFGCHFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[OMAMNFHDGBM]
	private DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private int GONPCHCMDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5040", Offset = "0x2FB4440", VA = "0x182FB5040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool OEENHAMLKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B1900", Offset = "0x7B0D00", VA = "0x1807B1900", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x8E96C0", Offset = "0x8E8AC0", VA = "0x1808E96C0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x2FB4D50", Offset = "0x2FB4150", VA = "0x182FB4D50", Slot = "6")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FB4E60", Offset = "0x2FB4260", VA = "0x182FB4E60", Slot = "7")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5090", Offset = "0x2FB4490", VA = "0x182FB5090", Slot = "8")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x2FB4FA0", Offset = "0x2FB43A0", VA = "0x182FB4FA0")]
	private void GGNOBJONILD(MBEDCJLMHEO LKHNLAILFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x2FB4EE0", Offset = "0x2FB42E0", VA = "0x182FB4EE0", Slot = "4")]
	public bool GDJKHHLIDNH(KHMECMDAALD HBKLDKCICEJ, AHKPLOLMABO GJEJKJANAJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5140", Offset = "0x2FB4540", VA = "0x182FB5140", Slot = "5")]
	public void PPMMFHFIIKL(KHMECMDAALD HBKLDKCICEJ, Span<AHKPLOLMABO> FNBGFGCHFDN, bool IKNMKFDCOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x2FB4D50", Offset = "0x2FB4150", VA = "0x182FB4D50", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5360", Offset = "0x2FB4760", VA = "0x182FB5360")]
	public CDDPMEICGNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class IPOBCHIKFGH
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDE60", Offset = "0x2DED260", VA = "0x182DEDE60")]
	public static void MJJPOKGHHFF(this CDCPEIFBKAJ MPOAAENBMAH, ReadOnlyMemory<byte> INNICGEDFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x20F46B0", Offset = "0x20F3AB0", VA = "0x1820F46B0")]
	public static void BBEFEPKHMJH<T>(this CDCPEIFBKAJ MPOAAENBMAH, in T LPJDDLMPNCG) where T : struct, HLLCIEEAKDG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x20F47E0", Offset = "0x20F3BE0", VA = "0x1820F47E0")]
	public static T PBNCMLICAHG<T>(this CDCPEIFBKAJ MPOAAENBMAH) where T : struct, HLLCIEEAKDG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDC80", Offset = "0x2DED080", VA = "0x182DEDC80")]
	public static void BBEFEPKHMJH(this CDCPEIFBKAJ MPOAAENBMAH, IFOLEJGFJIO KDHKIHNDDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDEE0", Offset = "0x2DED2E0", VA = "0x182DEDEE0")]
	public static IFOLEJGFJIO NFEBJEJGOJJ(this CDCPEIFBKAJ MPOAAENBMAH)
	{
		return default(IFOLEJGFJIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDCB0", Offset = "0x2DED0B0", VA = "0x182DEDCB0")]
	public static void FLFEIHJLBDD(this CDCPEIFBKAJ PFBBPOBMKBB, uint FBJJAHHBOIC, bool DOGHCHIFBPB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDF10", Offset = "0x2DED310", VA = "0x182DEDF10")]
	public static uint PENMPCIGIPE(this CDCPEIFBKAJ ACJLKOBBOEH, bool DOGHCHIFBPB = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class BDDBKJMEEMN
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class KEENPNBIOCM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public KEENPNBIOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A995D0", Offset = "0x2A989D0", VA = "0x182A995D0")]
		internal void <GetByteEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A99640", Offset = "0x2A98A40", VA = "0x182A99640")]
		internal T <GetByteEnumDelegates>b__1(CDCPEIFBKAJ b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class HNHPOFNADLL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public HNHPOFNADLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x35A5DB0", Offset = "0x35A51B0", VA = "0x1835A5DB0")]
		internal void <GetSByteEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x35A5E20", Offset = "0x35A5220", VA = "0x1835A5E20")]
		internal T <GetSByteEnumDelegates>b__1(CDCPEIFBKAJ b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class BMDFMGPGNLI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public BMDFMGPGNLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x20B6810", Offset = "0x20B5C10", VA = "0x1820B6810")]
		internal void <GetShortEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x20B6880", Offset = "0x20B5C80", VA = "0x1820B6880")]
		internal T <GetShortEnumDelegates>b__1(CDCPEIFBKAJ b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class AFMMIDLONJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public AFMMIDLONJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A720", Offset = "0x2B99B20", VA = "0x182B9A720")]
		internal void <GetUShortEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A790", Offset = "0x2B99B90", VA = "0x182B9A790")]
		internal T <GetUShortEnumDelegates>b__1(CDCPEIFBKAJ b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class ECIFJGEELOM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public ECIFJGEELOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x3435280", Offset = "0x3434680", VA = "0x183435280")]
		internal void <GetIntEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x34352E0", Offset = "0x34346E0", VA = "0x1834352E0")]
		internal T <GetIntEnumDelegates>b__1(CDCPEIFBKAJ b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class PGEAKGCLANF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public PGEAKGCLANF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8600", Offset = "0x2AB7A00", VA = "0x182AB8600")]
		internal void <GetUIntEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8660", Offset = "0x2AB7A60", VA = "0x182AB8660")]
		internal T <GetUIntEnumDelegates>b__1(CDCPEIFBKAJ b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x1A835B0", Offset = "0x1A829B0", VA = "0x181A835B0")]
	public static void PCMHGMMAMIM<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x1A83310", Offset = "0x1A82710", VA = "0x181A83310")]
	private static void DIMKIGFFMED<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x1A83310", Offset = "0x1A82710", VA = "0x181A83310")]
	private static void EBCKOFMBEFB<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x1A831C0", Offset = "0x1A825C0", VA = "0x181A831C0")]
	private static void NCHMFNBAEGF<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x1A831C0", Offset = "0x1A825C0", VA = "0x181A831C0")]
	private static void CGPGLILELOA<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x1A83460", Offset = "0x1A82860", VA = "0x181A83460")]
	private static void KNMGLDJKBHM<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x1A83460", Offset = "0x1A82860", VA = "0x181A83460")]
	private static void HDOEOEBJCGP<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class FKOMPPMBIHI : EHHACAEHLKG, IJGJDJPFIAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE040", Offset = "0x2DDD440", VA = "0x182DDE040", Slot = "4")]
	private void DNCPKOEGODG(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void AOAAIONKNHE(ACAPACFAGOM FNBGFGCHFDN);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
	protected FKOMPPMBIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[NOJIPINFHEG(typeof(LocalPoseData))]
public sealed class PIHLHFOHAGP : FKOMPPMBIHI
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x2980A30", Offset = "0x297FE30", VA = "0x182980A30", Slot = "5")]
	protected override void AOAAIONKNHE(ACAPACFAGOM FNBGFGCHFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
	public PIHLHFOHAGP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Scope)]
	internal class CopyAuthorityToEntity : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private EntityQuery FLGNKDDLJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private EntityQuery PKFGFHPBIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EntityQuery EBOENLLDHHB;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFEF0", Offset = "0x2FBF2F0", VA = "0x182FBFEF0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0530", Offset = "0x2FBF930", VA = "0x182FC0530", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2FC06B0", Offset = "0x2FBFAB0", VA = "0x182FC06B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0680", Offset = "0x2FBFA80", VA = "0x182FC0680", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0110", Offset = "0x2FBF510", VA = "0x182FC0110")]
		private void INHACONLPBL(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFD50", Offset = "0x2FBF150", VA = "0x182FBFD50")]
		private void FLAAPMPCOFO(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFA70", Offset = "0x2FBEE70", VA = "0x182FBFA70")]
		private void ECPGIBLDAAD(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFF60", Offset = "0x2FBF360", VA = "0x182FBFF60")]
		private void FOIMKEJPBLA(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2FBF860", Offset = "0x2FBEC60", VA = "0x182FBF860")]
		private void BIBMDLCKLNL(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0450", Offset = "0x2FBF850", VA = "0x182FC0450")]
		private void NINBKJMFEFA(MBEDCJLMHEO LKHNLAILFFL, int ENNAKHLEBJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class EEEIKJFDJMK : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityQuery ANBHGOBNOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private BFHOGDONKCB NOHGMFJPJKL;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8990", Offset = "0x2FC7D90", VA = "0x182FC8990", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2FC89E0", Offset = "0x2FC7DE0", VA = "0x182FC89E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8AA0", Offset = "0x2FC7EA0", VA = "0x182FC8AA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x2FC83B0", Offset = "0x2FC77B0", VA = "0x182FC83B0")]
	private void AILHPOBFNHC(NativeArray<Entity> ABBIPALBHCK, NativeList<Entity> LJLPNNBCCEF, ComponentDataFromEntity<MAFMNDNCKFB> IGPMINLHPHN, BufferFromEntity<ChildrenData> DLIGBEOLLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public EEEIKJFDJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class CPDBMAOPMJE : ParentSystemBase<AuthoredParentData, OFDDALEFPDF, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7EE0", Offset = "0x2FB72E0", VA = "0x182FB7EE0", Slot = "14")]
	protected override EntityQueryDesc AJBCBAODHIH(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x7D8560", Offset = "0x7D7960", VA = "0x1807D8560", Slot = "15")]
	protected override EntityQueryDesc OJLONFAPHKN(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7F60", Offset = "0x2FB7360", VA = "0x182FB7F60", Slot = "16")]
	protected override EntityQueryDesc GJLPABAIIHN(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7F20", Offset = "0x2FB7320", VA = "0x182FB7F20", Slot = "17")]
	protected override EntityQueryDesc FLFKHDOCMLI(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7FE0", Offset = "0x2FB73E0", VA = "0x182FB7FE0")]
	public CPDBMAOPMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7FA0", Offset = "0x2FB73A0", VA = "0x182FB7FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class CFJIBBMMPHO : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EntityQuery ANBHGOBNOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private object GBMJNKIPLAM;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x2FB55D0", Offset = "0x2FB49D0", VA = "0x182FB55D0", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5650", Offset = "0x2FB4A50", VA = "0x182FB5650", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x2FB56F0", Offset = "0x2FB4AF0", VA = "0x182FB56F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public CFJIBBMMPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class CJIHFHOPDJD : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private EntityQuery ANBHGOBNOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private object GBMJNKIPLAM;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6960", Offset = "0x2FB5D60", VA = "0x182FB6960", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2FB69E0", Offset = "0x2FB5DE0", VA = "0x182FB69E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6A80", Offset = "0x2FB5E80", VA = "0x182FB6A80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public CJIHFHOPDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[InternalBufferCapacity(1)]
internal struct IBKKPFNMPDF : ISystemStateBufferElementData, IBufferElementData, IEquatable<IBKKPFNMPDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public GNJFKFOLPLJ IGELLPOEMHM;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFBC0", Offset = "0x2DDEFC0", VA = "0x182DDFBC0", Slot = "4")]
	public bool Equals(IBKKPFNMPDF MPHACEGLFIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x7532F0", Offset = "0x7526F0", VA = "0x1807532F0")]
	public static IBKKPFNMPDF HPHCHABBDNG(GNJFKFOLPLJ IGELLPOEMHM)
	{
		return default(IBKKPFNMPDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(4)]
internal struct IKLJBGNMCHM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public GNJFKFOLPLJ IGELLPOEMHM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x7532F0", Offset = "0x7526F0", VA = "0x1807532F0")]
	public static IKLJBGNMCHM HPHCHABBDNG(GNJFKFOLPLJ IGELLPOEMHM)
	{
		return default(IKLJBGNMCHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class DGLGNJJCAMK : OPCKHODOLIL
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5400", Offset = "0x2FC4800", VA = "0x182FC5400", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5590", Offset = "0x2FC4990", VA = "0x182FC5590", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFE00", Offset = "0x2DDF200", VA = "0x182DDFE00")]
	protected DGLGNJJCAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[JGLBKJACABL]
internal abstract class OPCKHODOLIL : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	protected EntityQuery ANBHGOBNOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	protected DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	protected ABGDBOLFPHD IILFNNEDNCJ;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected abstract JGLPINIBHEE ODOOPBEOJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x29732B0", Offset = "0x29726B0", VA = "0x1829732B0", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x2973320", Offset = "0x2972720", VA = "0x182973320")]
	protected void INHIKBBJFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x29735A0", Offset = "0x29729A0", VA = "0x1829735A0")]
	protected void JBOPGKDJEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x2973820", Offset = "0x2972C20", VA = "0x182973820")]
	protected GKNDEBMEIID MOCHLPAFENL()
	{
		return default(GKNDEBMEIID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	protected OPCKHODOLIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class INCNPIGOHPD : OPCKHODOLIL
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x2DED710", Offset = "0x2DECB10", VA = "0x182DED710", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x2DED8A0", Offset = "0x2DECCA0", VA = "0x182DED8A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFE00", Offset = "0x2DDF200", VA = "0x182DDFE00")]
	protected INCNPIGOHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class GNNNCFIPELJ : OPCKHODOLIL
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFC60", Offset = "0x2DDF060", VA = "0x182DDFC60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFD70", Offset = "0x2DDF170", VA = "0x182DDFD70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFE00", Offset = "0x2DDF200", VA = "0x182DDFE00")]
	protected GNNNCFIPELJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class CEHNKOBAHDP : DGLGNJJCAMK
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override JGLPINIBHEE ODOOPBEOJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5460", Offset = "0x2FB4860", VA = "0x182FB5460", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFE00", Offset = "0x2DDF200", VA = "0x182DDFE00")]
	public CEHNKOBAHDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class KNMMHMEJDHP : INCNPIGOHPD
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override JGLPINIBHEE ODOOPBEOJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4670", Offset = "0x2DF3A70", VA = "0x182DF4670", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFE00", Offset = "0x2DDF200", VA = "0x182DDFE00")]
	public KNMMHMEJDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class KFFGEGFHGHF : GNNNCFIPELJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override JGLPINIBHEE ODOOPBEOJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2A00", Offset = "0x2DF1E00", VA = "0x182DF2A00", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFE00", Offset = "0x2DDF200", VA = "0x182DDFE00")]
	public KFFGEGFHGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class KCBBJOJKDKC : DGLGNJJCAMK
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	protected override JGLPINIBHEE ODOOPBEOJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2710", Offset = "0x2DF1B10", VA = "0x182DF2710", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2780", Offset = "0x2DF1B80", VA = "0x182DF2780")]
	public KCBBJOJKDKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class HIDGLPJGGJL : INCNPIGOHPD
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected override JGLPINIBHEE ODOOPBEOJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2E20", Offset = "0x2DE2220", VA = "0x182DE2E20", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFE00", Offset = "0x2DDF200", VA = "0x182DDFE00")]
	public HIDGLPJGGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class EPJJPDNOOAB : GNNNCFIPELJ
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected override JGLPINIBHEE ODOOPBEOJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA1C0", Offset = "0x2FC95C0", VA = "0x182FCA1C0", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2780", Offset = "0x2DF1B80", VA = "0x182DF2780")]
	public EPJJPDNOOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct KPGKCDGAGFF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct DLLHGNKGINI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct GMFALNCOBCJ : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct JGLPINIBHEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly ComponentType NNIHDPDHNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly ComponentType JDKEMCFCFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly object MIFCLBEAOPM;

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x2DF06D0", Offset = "0x2DEFAD0", VA = "0x182DF06D0")]
	public JGLPINIBHEE(ComponentType NNIHDPDHNJD, ComponentType JDKEMCFCFIL, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x2109CA0", Offset = "0x21090A0", VA = "0x182109CA0")]
	public static JGLPINIBHEE AENBDOEOIOH<TReq, TTag>(object MIFCLBEAOPM)
	{
		return default(JGLPINIBHEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class DPOFEOFNIDO
{
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public const string GIKABMFHPLE = "Parented";

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public const string EEINODMOJGL = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly JGLPINIBHEE HLMHOICHEFL;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly JGLPINIBHEE JFNBCMPAMAB;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct GNJFKFOLPLJ : global::CMECDGBHMLE<GNJFKFOLPLJ>, AHPPOODHHGC, IEquatable<GNJFKFOLPLJ>
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int CMHFEELAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0xBF6690", Offset = "0xBF5A90", VA = "0x180BF6690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int PELKNHEANOH
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x899ED0", Offset = "0x8992D0", VA = "0x180899ED0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xBF66A0", Offset = "0xBF5AA0", VA = "0x180BF66A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2DDFB80", Offset = "0x2DDEF80", VA = "0x182DDFB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFBC0", Offset = "0x2DDEFC0", VA = "0x182DDFBC0", Slot = "8")]
	public bool Equals(GNJFKFOLPLJ MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFC10", Offset = "0x2DDF010", VA = "0x182DDFC10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[JGLBKJACABL]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Connectables)]
	public class UpdateConnectableVisuals : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		private struct CMGCOHKPCKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public GNJFKFOLPLJ IGELLPOEMHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public float3 PICDPPHNNLH;

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x4391ED0", Offset = "0x43912D0", VA = "0x184391ED0")]
			public CMGCOHKPCKP(GNJFKFOLPLJ IGELLPOEMHM, float3 PICDPPHNNLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x4391EB0", Offset = "0x43912B0", VA = "0x184391EB0")]
			public void LOCCMPKKMAH(out GNJFKFOLPLJ IGELLPOEMHM, out float3 PICDPPHNNLH)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct FGJNFKGNFHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public NativeList<CMGCOHKPCKP> list;

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
			public FGJNFKGNFHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<IKLJBGNMCHM> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct MBHELCJMGFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeList<CMGCOHKPCKP> list;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
			public MBHELCJMGFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<IBKKPFNMPDF> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private struct AFAAEGBIMJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<CMGCOHKPCKP> list;

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
			public AFAAEGBIMJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in JLMBEOKAAAA com, in DynamicBuffer<IBKKPFNMPDF> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct NNDKFCGAIED : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct HINBFOCPFGP
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				public struct BBNEMJMEGNA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					public LambdaParameterValueProvider_Entity.Runtime FICJNOIKPAH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime HGHKMMPOGLM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public LambdaParameterValueProvider_DynamicBuffer<IKLJBGNMCHM>.Runtime CIEFGPIFLIJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CE")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity ONBCEAPJNBD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002CF")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NFFOHGNHAKH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002D0")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<IKLJBGNMCHM> BHJKIFLAJND;

				[Cpp2IlInjected.Token(Token = "0x6000796")]
				[Cpp2IlInjected.Address(RVA = "0x4393E90", Offset = "0x4393290", VA = "0x184393E90")]
				public void KMHCJEDMEHN(UpdateConnectableVisuals LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x4393F10", Offset = "0x4393310", VA = "0x184393F10")]
				public BBNEMJMEGNA MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
				{
					return default(BBNEMJMEGNA);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public UpdateConnectableVisuals CJLIKMLCFHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public NativeList<CMGCOHKPCKP> BDHPAGCMKHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			private HINBFOCPFGP GBKOBJGLANO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HINBFOCPFGP.BBNEMJMEGNA* IIGLDGPLJFM;

			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AGFEFLCLAEJ;

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x4398AE0", Offset = "0x4397EE0", VA = "0x184398AE0")]
			internal void JACNCLCPMJH(Entity LCLDFKAJPDK, WorldPoseData BPEDABAJFBJ, in DynamicBuffer<IKLJBGNMCHM> OJNFGJAPBNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x4398EA0", Offset = "0x43982A0", VA = "0x184398EA0", Slot = "5")]
			public void ReadFromDisplayClass(ref FGJNFKGNFHJ LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x4398ED0", Offset = "0x43982D0", VA = "0x184398ED0", Slot = "6")]
			public void WriteToDisplayClass(ref FGJNFKGNFHJ LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x4398990", Offset = "0x4397D90", VA = "0x184398990", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x4398D60", Offset = "0x4398160", VA = "0x184398D60")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref HINBFOCPFGP.BBNEMJMEGNA MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x4398D20", Offset = "0x4398120", VA = "0x184398D20")]
			public void KMHCJEDMEHN(UpdateConnectableVisuals LFKHFKIBGCJ, ref FGJNFKGNFHJ LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x4398A70", Offset = "0x4397E70", VA = "0x184398A70")]
			public unsafe static void FEOHLEHDMJK(ArchetypeChunkIterator* JCPGCEEJMGC, void* AIFJMENHIAF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct JGLFILAGFNC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct LNPFNPLEKKO
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct HIBGNNDPFAJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime HGHKMMPOGLM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<IBKKPFNMPDF>.Runtime CIEFGPIFLIJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002D7")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NFFOHGNHAKH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002D8")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<IBKKPFNMPDF> BHJKIFLAJND;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x4396DC0", Offset = "0x43961C0", VA = "0x184396DC0")]
				public void KMHCJEDMEHN(UpdateConnectableVisuals LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x4396E30", Offset = "0x4396230", VA = "0x184396E30")]
				public HIBGNNDPFAJ MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
				{
					return default(HIBGNNDPFAJ);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public NativeList<CMGCOHKPCKP> BDHPAGCMKHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private LNPFNPLEKKO GBKOBJGLANO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe LNPFNPLEKKO.HIBGNNDPFAJ* IIGLDGPLJFM;

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x4395880", Offset = "0x4394C80", VA = "0x184395880")]
			internal void JACNCLCPMJH(in WorldPoseData BPEDABAJFBJ, in DynamicBuffer<IBKKPFNMPDF> OJNFGJAPBNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x1372980", Offset = "0x1371D80", VA = "0x181372980", Slot = "5")]
			public void ReadFromDisplayClass(ref MBHELCJMGFC LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x43957B0", Offset = "0x4394BB0", VA = "0x1843957B0", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x4395A30", Offset = "0x4394E30", VA = "0x184395A30")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref LNPFNPLEKKO.HIBGNNDPFAJ MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x4395990", Offset = "0x4394D90", VA = "0x184395990")]
			public void KMHCJEDMEHN(UpdateConnectableVisuals LFKHFKIBGCJ, ref MBHELCJMGFC LNLMJEFNJAK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct OCKGIIGGPFJ : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			private struct KKJMDKIJHCC
			{
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				[NoAlias]
				public struct KDCLCIDJKCO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime HGHKMMPOGLM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<JLMBEOKAAAA>.Runtime NMHPCLKMPCC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002E3")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<IBKKPFNMPDF>.Runtime CIEFGPIFLIJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NFFOHGNHAKH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<JLMBEOKAAAA> POBDAOBLBBL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<IBKKPFNMPDF> BHJKIFLAJND;

				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0x4396190", Offset = "0x4395590", VA = "0x184396190")]
				public void KMHCJEDMEHN(UpdateConnectableVisuals LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x4396220", Offset = "0x4395620", VA = "0x184396220")]
				public KDCLCIDJKCO MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
				{
					return default(KDCLCIDJKCO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public NativeList<CMGCOHKPCKP> BDHPAGCMKHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private KKJMDKIJHCC GBKOBJGLANO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe KKJMDKIJHCC.KDCLCIDJKCO* IIGLDGPLJFM;

			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x4399050", Offset = "0x4398450", VA = "0x184399050")]
			internal void JACNCLCPMJH(in WorldPoseData BPEDABAJFBJ, in JLMBEOKAAAA DGIFBEPHKIB, in DynamicBuffer<IBKKPFNMPDF> OJNFGJAPBNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x1372980", Offset = "0x1371D80", VA = "0x181372980", Slot = "5")]
			public void ReadFromDisplayClass(ref AFAAEGBIMJF LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x4398FD0", Offset = "0x43983D0", VA = "0x184398FD0", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x43991F0", Offset = "0x43985F0", VA = "0x1843991F0")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref KKJMDKIJHCC.KDCLCIDJKCO MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x43991B0", Offset = "0x43985B0", VA = "0x1843991B0")]
			public void KMHCJEDMEHN(UpdateConnectableVisuals LFKHFKIBGCJ, ref AFAAEGBIMJF LNLMJEFNJAK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private EntityQuery OJPLLEHKLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery JJDHOCBNJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery KCOLMANNJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery OOIIELEKJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery CBOEOLFIPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery JDOCPAMKHJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private EntityQuery OODNFODAFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery JEEEBNDMGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery JCLACOGGDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery KFBKMGLFNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private global::EAJFHNJEBAG<GNJFKFOLPLJ, IFKHEAGAGMF> JKMLACDFOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private FDHGKOHMFEH PNHFNLJOOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private NDFDMPICGAG GEFBMNBCACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private KBHCMIFKGLJ OHMMMCPAHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private EntityQuery MAJMMHNMCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private ProfilerMarker HJBNKCKNGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery OGPCCDIBMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery GJMINKAGFGP;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public int JAMIBFCLJNH
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2BDF320", Offset = "0x2BDE720", VA = "0x182BDF320")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF360", Offset = "0x2BDE760", VA = "0x182BDF360")]
		internal IFKHEAGAGMF JCINPFGBNCN(GNJFKFOLPLJ IGELLPOEMHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE780", Offset = "0x2BDDB80", VA = "0x182BDE780", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0B70", Offset = "0x2BDFF70", VA = "0x182BE0B70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0DF0", Offset = "0x2BE01F0", VA = "0x182BE0DF0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0F80", Offset = "0x2BE0380", VA = "0x182BE0F80", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0DB0", Offset = "0x2BE01B0", VA = "0x182BE0DB0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD5B0", Offset = "0x2BDC9B0", VA = "0x182BDD5B0")]
		private void CLKANKBLJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE840", Offset = "0x2BDDC40", VA = "0x182BDE840")]
		private void HFIFKIHOMLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE3D0", Offset = "0x2BDD7D0", VA = "0x182BDE3D0")]
		private void FKOIHCLFCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0FC0", Offset = "0x2BE03C0", VA = "0x182BE0FC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE990", Offset = "0x2BDDD90", VA = "0x182BDE990")]
		private void HGAJENLLFEE(EntityQuery FLGNKDDLJNL, EntityQuery KPOMAEBEHKO, EntityQuery PKFGFHPBIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE300", Offset = "0x2BDD700", VA = "0x182BDE300")]
		private void FJEBMLODAAK(EntityQuery PKFGFHPBIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDEB0", Offset = "0x2BDD2B0", VA = "0x182BDDEB0")]
		private void EKJDHHJNBGL(NativeArrayAsync<Entity> ICMLKIFLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD4A0", Offset = "0x2BDC8A0", VA = "0x182BDD4A0")]
		private void CEBJHIAEEDE(NativeArrayAsync<Entity> AFFHBMKJGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0580", Offset = "0x2BDF980", VA = "0x182BE0580")]
		private void NONFDBDPCCM(NativeArrayAsync<Entity> FEOJDDCBKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE190", Offset = "0x2BDD590", VA = "0x182BDE190")]
		private void FJAAFLFHOHC(NativeList<GNJFKFOLPLJ> OHPGIIDCCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0060", Offset = "0x2BDF460", VA = "0x182BE0060")]
		private NativeList<GNJFKFOLPLJ> MLKABDOKHGP(NativeArray<Entity> ABBIPALBHCK)
		{
			return default(NativeList<GNJFKFOLPLJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD800", Offset = "0x2BDCC00", VA = "0x182BDD800")]
		private void EBEKKNDOIIA(NativeArray<Entity> ABBIPALBHCK, NativeList<GNJFKFOLPLJ> OHPGIIDCCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF8A0", Offset = "0x2BDECA0", VA = "0x182BDF8A0")]
		private void LBFJFCFHHJG(NativeArray<Entity> OCOFIPGFIEL, NativeArray<Entity> NOLOEOAPAOM, NativeList<GNJFKFOLPLJ> OEFGDAGFKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEE70", Offset = "0x2BDE270", VA = "0x182BDEE70")]
		private void HHHOOEDJKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD360", Offset = "0x2BDC760", VA = "0x182BDD360")]
		private NativeListAsync<CMGCOHKPCKP> BJJDHEGNPKD(EntityQuery ANBHGOBNOFE, Func<NativeList<CMGCOHKPCKP>, JobHandle> GKGCJOBINLE)
		{
			return default(NativeListAsync<CMGCOHKPCKP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD100", Offset = "0x2BDC500", VA = "0x182BDD100")]
		private JobHandle AMDAIKNCDNG(NativeList<CMGCOHKPCKP> BDHPAGCMKHB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD6C0", Offset = "0x2BDCAC0", VA = "0x182BDD6C0")]
		private JobHandle DGBKFCOOAKH(NativeList<CMGCOHKPCKP> BDHPAGCMKHB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2BE08E0", Offset = "0x2BDFCE0", VA = "0x182BE08E0")]
		private JobHandle OJKADDMJEOJ(NativeList<CMGCOHKPCKP> BDHPAGCMKHB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFDD0", Offset = "0x2BDF1D0", VA = "0x182BDFDD0")]
		private void MEPPDGPJCKD(NativeListAsync<CMGCOHKPCKP> BDHPAGCMKHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF610", Offset = "0x2BDEA10", VA = "0x182BDF610")]
		private void KGLPKFEBKFD(NativeListAsync<CMGCOHKPCKP> BDHPAGCMKHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1360", Offset = "0x2BE0760", VA = "0x182BE1360")]
		private bool POPBJPGMBBK(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD290", Offset = "0x2BDC690", VA = "0x182BDD290")]
		private NativeArray<Entity> BFAPEGALJNN(Entity LCLDFKAJPDK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0720", Offset = "0x2BDFB20", VA = "0x182BE0720")]
		private GNJFKFOLPLJ OJAGPHECJEF(NativeList<GNJFKFOLPLJ> OEFGDAGFKCG)
		{
			return default(GNJFKFOLPLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDE20", Offset = "0x2BDD220", VA = "0x182BDDE20")]
		private void EIKJNKDPNKK(GNJFKFOLPLJ IGELLPOEMHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0A10", Offset = "0x2BDFE10", VA = "0x182BE0A10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCF00", Offset = "0x2BDC300", VA = "0x182BDCF00")]
		public static EntityQuery AFBINOIPIHD(ComponentSystemBase LFKHFKIBGCJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF3B0", Offset = "0x2BDE7B0", VA = "0x182BDF3B0")]
		public static EntityQuery KFLKNBKKKGG(ComponentSystemBase LFKHFKIBGCJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2BE10F0", Offset = "0x2BE04F0", VA = "0x182BE10F0")]
		public static EntityQuery PBCGEHAAKBG(ComponentSystemBase LFKHFKIBGCJ)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[JEGJCCBDMOE(OLCAJGBKOGB.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private EntityQuery ANBHGOBNOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private CLIHAPFPPDO BKOBOKBHBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private JDCCMAICBBN COMAEFHPEEB;

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2986B80", Offset = "0x2985F80", VA = "0x182986B80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2986AF0", Offset = "0x2985EF0", VA = "0x182986AF0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x2986C80", Offset = "0x2986080", VA = "0x182986C80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class IBKFHADKBMO : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public APKFPLGDLPH MPIEEKNKAMO;

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public IBKFHADKBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
	public IBKFHADKBMO(APKFPLGDLPH MPIEEKNKAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6AC0", Offset = "0x2DE5EC0", VA = "0x182DE6AC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public abstract class HBOBLIMOCKN : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private ObjectEmbodimentService HAJHHEFGJLE;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1A50", Offset = "0x2DE0E50", VA = "0x182DE1A50", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1AB0", Offset = "0x2DE0EB0", VA = "0x182DE1AB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1AE0", Offset = "0x2DE0EE0", VA = "0x182DE1AE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	protected HBOBLIMOCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class EMAMPNJOLBK : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EntityQuery GFJMAJDHGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery BNGAEHDCPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery OJLKEJCNPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery FGOBIDKOBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private ObjectEmbodimentService DLFJBGMCLLC;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public int LBGJAHIFKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x2FC99F0", Offset = "0x2FC8DF0", VA = "0x182FC99F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int CDJBKJOLKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x2FC9D20", Offset = "0x2FC9120", VA = "0x182FC9D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9950", Offset = "0x2FC8D50", VA = "0x182FC9950", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9F10", Offset = "0x2FC9310", VA = "0x182FC9F10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA110", Offset = "0x2FC9510", VA = "0x182FCA110", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA130", Offset = "0x2FC9530", VA = "0x182FCA130")]
	public int PHDIMBKCLEF(SceneTag OOOMPFGDEEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9D30", Offset = "0x2FC9130", VA = "0x182FC9D30")]
	public int NHBEOEOMDAO(SceneTag OOOMPFGDEEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9A00", Offset = "0x2FC8E00", VA = "0x182FC9A00")]
	protected void GMOLNPMNBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9DA0", Offset = "0x2FC91A0", VA = "0x182FC9DA0")]
	protected void OLDLAMGIADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9900", Offset = "0x2FC8D00", VA = "0x182FC9900")]
	public NativeArrayAsync<Entity> EPEKCCFJICO(SceneTag OOOMPFGDEEN, Allocator FKHAEPDPDAI = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9D50", Offset = "0x2FC9150", VA = "0x182FC9D50")]
	public NativeArrayAsync<Entity> OGDBBLCMJPJ(SceneTag OOOMPFGDEEN, Allocator FKHAEPDPDAI = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9C90", Offset = "0x2FC9090", VA = "0x182FC9C90")]
	public bool MEJIBNNKJPK(SceneTag OOOMPFGDEEN, out NativeArrayAsync<Entity> MPIEEKNKAMO, Allocator FKHAEPDPDAI = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC98A0", Offset = "0x2FC8CA0", VA = "0x182FC98A0")]
	public bool DGBCKPEIJJH(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9C20", Offset = "0x2FC9020", VA = "0x182FC9C20")]
	public APKFPLGDLPH HIOCOIPKIEF(Entity LCLDFKAJPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA150", Offset = "0x2FC9550", VA = "0x182FCA150")]
	public bool PHONMIEGPBF(Entity LCLDFKAJPDK, out IBKFHADKBMO MPIEEKNKAMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC99B0", Offset = "0x2FC8DB0", VA = "0x182FC99B0")]
	public void GBIFKHPFBNE(Entity LCLDFKAJPDK, IBKFHADKBMO MPIEEKNKAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9EB0", Offset = "0x2FC92B0", VA = "0x182FC9EB0")]
	public bool OPKIHFBPPFC(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void KLMKIDBPMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public EMAMPNJOLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class NFLHLIEFOCI : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery MNMDFKMHEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private BFHOGDONKCB NOHGMFJPJKL;

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x296E110", Offset = "0x296D510", VA = "0x18296E110", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x296E1D0", Offset = "0x296D5D0", VA = "0x18296E1D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x296E290", Offset = "0x296D690", VA = "0x18296E290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x2832640", Offset = "0x2831A40", VA = "0x182832640")]
	private bool BCCJGCPMEPP<TComponentData>(EntityQuery ANBHGOBNOFE, out NativeArray<Entity> ABBIPALBHCK, out NativeArray<TComponentData> MCGONHKIMDB) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x296E160", Offset = "0x296D560", VA = "0x18296E160")]
	public APKFPLGDLPH HIOCOIPKIEF(Entity LCLDFKAJPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public NFLHLIEFOCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery IGPPCDJJPFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery FLHHKGDHJKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EntityQuery FIMLMBNHGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EntityQuery EBOENLLDHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BD26D0", Offset = "0x2BD1AD0", VA = "0x182BD26D0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2720", Offset = "0x2BD1B20", VA = "0x182BD2720", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2950", Offset = "0x2BD1D50", VA = "0x182BD2950", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2290", Offset = "0x2BD1690", VA = "0x182BD2290")]
		private void AGMLDLCGDGN(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2660", Offset = "0x2BD1A60", VA = "0x182BD2660")]
		private void FJEBMLODAAK(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD28E0", Offset = "0x2BD1CE0", VA = "0x182BD28E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2300", Offset = "0x2BD1700", VA = "0x182BD2300")]
		private void DDJHPCHLILF(EntityQuery ANBHGOBNOFE, bool KHJHBNPBBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal sealed class FBEPKKIJION : KHECDAFCLCI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct PPFCEDCNBJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		public PPFCEDCNBJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct EMGOBJCDGON : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct LAPFECNNADA
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct KGPIPMKCJHC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ACMFEMEEMKL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000304")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime IHIGKJMHFMB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime POHPFNFNHEK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity DFLEJOKGJLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> MIKDBANCNDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> LEFMFCNOPJM;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x43962F0", Offset = "0x43956F0", VA = "0x1843962F0")]
			public void KMHCJEDMEHN(FBEPKKIJION LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x4396370", Offset = "0x4395770", VA = "0x184396370")]
			public KGPIPMKCJHC MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
			{
				return default(KGPIPMKCJHC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private LAPFECNNADA GBKOBJGLANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LAPFECNNADA.KGPIPMKCJHC* IIGLDGPLJFM;

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x4392870", Offset = "0x4391C70", VA = "0x184392870")]
		internal void JACNCLCPMJH(Entity MDGOLEBJDDG, SplineShapeData PJEHHDIBMKL, DynamicBuffer<LinkedEntityGroup> NPOGECPDPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x43927A0", Offset = "0x4391BA0", VA = "0x1843927A0", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x43928E0", Offset = "0x4391CE0", VA = "0x1843928E0")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref LAPFECNNADA.KGPIPMKCJHC MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x43928D0", Offset = "0x4391CD0", VA = "0x1843928D0")]
		public void KMHCJEDMEHN(FBEPKKIJION LFKHFKIBGCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct GMGBBBBFHKB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private struct EJJPLGJGCHM
		{
			[Cpp2IlInjected.Token(Token = "0x20000FB")]
			[NoAlias]
			public struct FPHGFFAGGGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030B")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime KPLJDKHIJLI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400030C")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime GNDABLBGOGO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity EMFLACFKBPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> BAJJOMNINKH;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x43926C0", Offset = "0x4391AC0", VA = "0x1843926C0")]
			public void KMHCJEDMEHN(FBEPKKIJION LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x4392720", Offset = "0x4391B20", VA = "0x184392720")]
			public FPHGFFAGGGP MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
			{
				return default(FPHGFFAGGGP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public BufferFromEntity<LinkedEntityGroup> AOKFACCGJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private EJJPLGJGCHM GBKOBJGLANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe EJJPLGJGCHM.FPHGFFAGGGP* IIGLDGPLJFM;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x43935D0", Offset = "0x43929D0", VA = "0x1843935D0")]
		internal void JACNCLCPMJH(Entity HIBFCDNCMKO, SplinePointParentData IMEJGNOGGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x43937A0", Offset = "0x4392BA0", VA = "0x1843937A0", Slot = "5")]
		public void ReadFromDisplayClass(ref PPFCEDCNBJJ LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x4393530", Offset = "0x4392930", VA = "0x184393530", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x43936F0", Offset = "0x4392AF0", VA = "0x1843936F0")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref EJJPLGJGCHM.FPHGFFAGGGP MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x4393660", Offset = "0x4392A60", VA = "0x184393660")]
		public void KMHCJEDMEHN(FBEPKKIJION LFKHFKIBGCJ, ref PPFCEDCNBJJ LNLMJEFNJAK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private EntityQuery ANBHGOBNOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private EntityQuery IEDIFHICGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery KGCAMGOGJPL;

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC0F0", Offset = "0x2DDB4F0", VA = "0x182DDC0F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1A0", Offset = "0x2DDB5A0", VA = "0x182DDC1A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public FBEPKKIJION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBE50", Offset = "0x2DDB250", VA = "0x182DDBE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBCB0", Offset = "0x2DDB0B0", VA = "0x182DDBCB0")]
	public static EntityQuery MEILPLGKBIE(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBB50", Offset = "0x2DDAF50", VA = "0x182DDBB50")]
	public static EntityQuery EIGFGCHNFGF(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
public sealed class NGBAOJHLINM : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private IMDHGBFPAOD IILMLAIBNCD;

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x296E570", Offset = "0x296D970", VA = "0x18296E570", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x296E5D0", Offset = "0x296D9D0", VA = "0x18296E5D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public NGBAOJHLINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class DLMABNIPDBP : KHECDAFCLCI, IJGJDJPFIAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct GNAFMNLGHHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<LBCACEFDDPD> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NativeList<EBCGMCIBBDB> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public NativeList<LBCACEFDDPD> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		public GNAFMNLGHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, KLGHMJKGANI previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
		internal void <OnUpdate>b__2(Entity entity, KLGHMJKGANI previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct MFHNFGEGFLD : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct NAOFLLBEJAH
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct PMLKHGHKEJB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400031A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FICJNOIKPAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400031B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime AKGCJAKNNKJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity ONBCEAPJNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> KIIKLHJOCCD;

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x4397DB0", Offset = "0x43971B0", VA = "0x184397DB0")]
			public void KMHCJEDMEHN(DLMABNIPDBP LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x4397E10", Offset = "0x4397210", VA = "0x184397E10")]
			public PMLKHGHKEJB MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
			{
				return default(PMLKHGHKEJB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public NativeList<LBCACEFDDPD> KLAEADJPMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private NAOFLLBEJAH GBKOBJGLANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NAOFLLBEJAH.PMLKHGHKEJB* IIGLDGPLJFM;

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAD70", Offset = "0x2BCA170", VA = "0x182BCAD70")]
		internal void JACNCLCPMJH(Entity LCLDFKAJPDK, ParentData IECLCEDGDAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x1372980", Offset = "0x1371D80", VA = "0x181372980", Slot = "5")]
		public void ReadFromDisplayClass(ref GNAFMNLGHHN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAD00", Offset = "0x2BCA100", VA = "0x182BCAD00", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAE30", Offset = "0x2BCA230", VA = "0x182BCAE30")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref NAOFLLBEJAH.PMLKHGHKEJB MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x2BCADF0", Offset = "0x2BCA1F0", VA = "0x182BCADF0")]
		public void KMHCJEDMEHN(DLMABNIPDBP LFKHFKIBGCJ, ref GNAFMNLGHHN LNLMJEFNJAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MGEBFCOMJIA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct AJPOIGNAMKP
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct GEIHIHGCLNI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000322")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FICJNOIKPAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000323")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime AKGCJAKNNKJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<KLGHMJKGANI>.Runtime IGAFNCMIIEP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity ONBCEAPJNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> KIIKLHJOCCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<KLGHMJKGANI> NHOEKHNOFBA;

			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x4390BE0", Offset = "0x438FFE0", VA = "0x184390BE0")]
			public void KMHCJEDMEHN(DLMABNIPDBP LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x4390C60", Offset = "0x4390060", VA = "0x184390C60")]
			public GEIHIHGCLNI MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
			{
				return default(GEIHIHGCLNI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public NativeList<EBCGMCIBBDB> JDALMNBHCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private AJPOIGNAMKP GBKOBJGLANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe AJPOIGNAMKP.GEIHIHGCLNI* IIGLDGPLJFM;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAF50", Offset = "0x2BCA350", VA = "0x182BCAF50")]
		internal void JACNCLCPMJH(Entity LCLDFKAJPDK, ParentData IECLCEDGDAE, KLGHMJKGANI CHHFOFIKHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB130", Offset = "0x2BCA530", VA = "0x182BCB130", Slot = "5")]
		public void ReadFromDisplayClass(ref GNAFMNLGHHN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAEE0", Offset = "0x2BCA2E0", VA = "0x182BCAEE0", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB050", Offset = "0x2BCA450", VA = "0x182BCB050")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref AJPOIGNAMKP.GEIHIHGCLNI MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB010", Offset = "0x2BCA410", VA = "0x182BCB010")]
		public void KMHCJEDMEHN(DLMABNIPDBP LFKHFKIBGCJ, ref GNAFMNLGHHN LNLMJEFNJAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct LGIDGOFMNIJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private struct NICHEDBEKJM
		{
			[Cpp2IlInjected.Token(Token = "0x2000107")]
			[NoAlias]
			public struct HLOLHCODINE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FICJNOIKPAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<KLGHMJKGANI>.Runtime IGAFNCMIIEP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity ONBCEAPJNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<KLGHMJKGANI> NHOEKHNOFBA;

			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x4397EC0", Offset = "0x43972C0", VA = "0x184397EC0")]
			public void KMHCJEDMEHN(DLMABNIPDBP LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x4397F20", Offset = "0x4397320", VA = "0x184397F20")]
			public HLOLHCODINE MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
			{
				return default(HLOLHCODINE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NativeList<LBCACEFDDPD> JIAFKIGMPPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private NICHEDBEKJM GBKOBJGLANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NICHEDBEKJM.HLOLHCODINE* IIGLDGPLJFM;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAB80", Offset = "0x2BC9F80", VA = "0x182BCAB80")]
		internal void JACNCLCPMJH(Entity LCLDFKAJPDK, KLGHMJKGANI CHHFOFIKHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCACF0", Offset = "0x2BCA0F0", VA = "0x182BCACF0", Slot = "5")]
		public void ReadFromDisplayClass(ref GNAFMNLGHHN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAB10", Offset = "0x2BC9F10", VA = "0x182BCAB10", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAC40", Offset = "0x2BCA040", VA = "0x182BCAC40")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref NICHEDBEKJM.HLOLHCODINE MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAC00", Offset = "0x2BCA000", VA = "0x182BCAC00")]
		public void KMHCJEDMEHN(DLMABNIPDBP LFKHFKIBGCJ, ref GNAFMNLGHHN LNLMJEFNJAK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private HBFGHIOELIO GIBCCCOGLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private EntityQuery EDNJGEFLLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private EntityQuery NLDGFOCANCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private EntityQuery PCNDIJNMPCI;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5A60", Offset = "0x2FC4E60", VA = "0x182FC5A60", Slot = "14")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5E00", Offset = "0x2FC5200", VA = "0x182FC5E00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public DLMABNIPDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5DA0", Offset = "0x2FC51A0", VA = "0x182FC5DA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5B40", Offset = "0x2FC4F40", VA = "0x182FC5B40")]
	public static EntityQuery NDPCLOMOMOC(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5830", Offset = "0x2FC4C30", VA = "0x182FC5830")]
	public static EntityQuery EPIFHIHMOMF(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5630", Offset = "0x2FC4A30", VA = "0x182FC5630")]
	public static EntityQuery CJJJCKADBHH(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Connectables)]
	public class InitializeRigidbodyExHierarchy : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private EntityQuery ANBHGOBNOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private LFFINPKKCFD NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE0A0", Offset = "0x2DED4A0", VA = "0x182DEE0A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE030", Offset = "0x2DED430", VA = "0x182DEE030", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE130", Offset = "0x2DED530", VA = "0x182DEE130", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class JGFKCHEFFEJ : ParentSystemBase<ParentData, KLGHMJKGANI, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0590", Offset = "0x2DEF990", VA = "0x182DF0590", Slot = "14")]
	protected override EntityQueryDesc AJBCBAODHIH(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x7D8560", Offset = "0x7D7960", VA = "0x1807D8560", Slot = "15")]
	protected override EntityQueryDesc OJLONFAPHKN(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0610", Offset = "0x2DEFA10", VA = "0x182DF0610", Slot = "16")]
	protected override EntityQueryDesc GJLPABAIIHN(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF05D0", Offset = "0x2DEF9D0", VA = "0x182DF05D0", Slot = "17")]
	protected override EntityQueryDesc FLFKHDOCMLI(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0690", Offset = "0x2DEFA90", VA = "0x182DF0690")]
	public JGFKCHEFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0650", Offset = "0x2DEFA50", VA = "0x182DF0650", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : KHECDAFCLCI where ParentData : struct, IComponentData, JJCEHBPPLLO where PreviousParentData : struct, IComponentData, JJCEHBPPLLO where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, JJCEHBPPLLO
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct BOJEALOPOGL : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter GNLEEDNOHAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter JDGLCHLPLIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public NativeHashMap<Entity, int>.ParallelWriter FNPFHOOJPJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ArchetypeChunkComponentType<PreviousParentData> PIAKJCBFEFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> CJKILAPCNPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public ArchetypeChunkEntityType LIDPBDCBJJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public uint AGMHPLEHLFG;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x20B98F0", Offset = "0x20B8CF0", VA = "0x1820B98F0", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[BurstCompile]
		private struct ILJAADBHAEB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> FNPFHOOJPJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> MFINMHPCDOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public NativeList<Entity> GDAMJBBGHIL;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x24F8EF0", Offset = "0x24F82F0", VA = "0x1824F8EF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[BurstCompile]
		private struct HLODFOKEHMO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> GNLEEDNOHAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> JDGLCHLPLIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeHashMap<Entity, int> FNPFHOOJPJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public BufferFromEntity<ChildrenData> MFINMHPCDOG;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x3AB1B70", Offset = "0x3AB0F70", VA = "0x183AB1B70")]
			private int PMCIBNMJNOM(DynamicBuffer<ChildrenData> BOGHIFKGACA, Entity LCLDFKAJPDK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x3AB18B0", Offset = "0x3AB0CB0", VA = "0x183AB18B0")]
			private void MDDBLDBDKFE(Entity GGEKFPEBLKN, DynamicBuffer<ChildrenData> BOGHIFKGACA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x3AB1780", Offset = "0x3AB0B80", VA = "0x183AB1780")]
			private void FIKMLAEALOE(Entity GGEKFPEBLKN, DynamicBuffer<ChildrenData> BOGHIFKGACA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x3AB14F0", Offset = "0x3AB08F0", VA = "0x183AB14F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[BurstCompile]
		private struct IOBDFIDCAME : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public NativeArray<Entity> PHGJINDNNFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public NativeList<Entity> PHPDFDJEEEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public BufferFromEntity<ChildrenData> MFINMHPCDOG;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x2507800", Offset = "0x2506C00", VA = "0x182507800", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected EntityQuery LFBANBFJELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected EntityQuery KCKBBFINKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected EntityQuery BNOGEGNBIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected EntityQuery HOCDEBJLLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ProfilerMarker CDAJODIONOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected ProfilerMarker KIMCOFJBONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected ProfilerMarker ANINMNPDEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected ProfilerMarker MHEIGLEFIMG;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x2516770", Offset = "0x2515B70", VA = "0x182516770")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x2516520", Offset = "0x2515920", VA = "0x182516520")]
		private int PMCIBNMJNOM(DynamicBuffer<ChildrenData> BOGHIFKGACA, Entity LCLDFKAJPDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2515940", Offset = "0x2514D40", VA = "0x182515940")]
		private void MNMNNJLPJJK(Entity FEJPDMGONFP, Entity EHPDOFEPKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x7D8560", Offset = "0x7D7960", VA = "0x1807D8560", Slot = "14")]
		protected virtual EntityQueryDesc AJBCBAODHIH(EntityQueryDesc ANBHGOBNOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x7D8560", Offset = "0x7D7960", VA = "0x1807D8560", Slot = "15")]
		protected virtual EntityQueryDesc OJLONFAPHKN(EntityQueryDesc ANBHGOBNOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x7D8560", Offset = "0x7D7960", VA = "0x1807D8560", Slot = "16")]
		protected virtual EntityQueryDesc GJLPABAIIHN(EntityQueryDesc ANBHGOBNOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc FLFKHDOCMLI(EntityQueryDesc ANBHGOBNOFE);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x2515D40", Offset = "0x2515140", VA = "0x182515D40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x2515640", Offset = "0x2514A40", VA = "0x182515640")]
		private void GKMOGHOPELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x25160B0", Offset = "0x25154B0", VA = "0x1825160B0")]
		private void PFDBMOCKNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x2514620", Offset = "0x2513A20", VA = "0x182514620")]
		private JobHandle BLCPNIIPEFG(JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2515360", Offset = "0x2514760", VA = "0x182515360")]
		private void DDLDEENGCJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2515FE0", Offset = "0x25153E0", VA = "0x182515FE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x21FDF20", Offset = "0x21FD320", VA = "0x1821FDF20", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xF93720", Offset = "0xF92B20", VA = "0x180F93720", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[AlwaysUpdateSystem]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
public abstract class IMFEAONBJNA : KHECDAFCLCI, IJGJDJPFIAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private struct BCCFLHCLHEK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NativeListAsync<Entity> AGJHBEGCBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NativeListAsync<Entity> DALNPIMPKCG;

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x4391890", Offset = "0x4390C90", VA = "0x184391890")]
		public BCCFLHCLHEK(NativeList<Entity> AGJHBEGCBBM, NativeList<Entity> DALNPIMPKCG, JobHandle DNPFDFHMBNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x4391810", Offset = "0x4390C10", VA = "0x184391810")]
		public JobHandle KNACJPGANJJ(JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x4391780", Offset = "0x4390B80", VA = "0x184391780", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct NKPCGAKJPCD : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[Flags]
		public enum GJKDPEMNOGO
		{
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		[WriteOnly]
		public NativeList<Entity> GNGHAPMLMKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[WriteOnly]
		public NativeList<Entity> OIJMDIPGAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[ReadOnly]
		public NativeArray<Entity> LPJDMLKJAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> FEBAJELDMCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[ReadOnly]
		public ComponentDataFromEntity KLGDEALCGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[ReadOnly]
		public ComponentDataFromEntity FFFDMEHPAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> EJGNMMDBKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int KKKHEHCBEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int LAHLCHINEJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private GJKDPEMNOGO PAEMELMEBEE;

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x43980F0", Offset = "0x43974F0", VA = "0x1843980F0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x4398060", Offset = "0x4397460", VA = "0x184398060")]
		private void EFPOEHDJHKK(Entity LCLDFKAJPDK, bool IHPGPKBBPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x4398300", Offset = "0x4397700", VA = "0x184398300")]
		private void JBBHFLCOHIG(Entity LCLDFKAJPDK, bool IHPGPKBBPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x4398410", Offset = "0x4397810", VA = "0x184398410")]
		public BCCFLHCLHEK JHPMKCHOCGF(NativeArray<Entity> NNDAPMCFFMN, JobHandle ELLADMEAHLJ)
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x4398280", Offset = "0x4397680", VA = "0x184398280")]
		public BCCFLHCLHEK IAFGFHMGFBJ(NativeArray<Entity> NNDAPMCFFMN, JobHandle ELLADMEAHLJ)
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x4398490", Offset = "0x4397890", VA = "0x184398490")]
		public BCCFLHCLHEK JNEFHBLADBC(NativeList<LBCACEFDDPD> BDHPAGCMKHB, JobHandle ELLADMEAHLJ)
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x43988B0", Offset = "0x4397CB0", VA = "0x1843988B0")]
		public BCCFLHCLHEK NEOAKIJNFNB(NativeList<LBCACEFDDPD> BDHPAGCMKHB, JobHandle ELLADMEAHLJ)
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x43987D0", Offset = "0x4397BD0", VA = "0x1843987D0")]
		public BCCFLHCLHEK LOFAGKJHFGI(NativeList<EBCGMCIBBDB> BDHPAGCMKHB, JobHandle ELLADMEAHLJ)
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x4418C90", Offset = "0x4418090", VA = "0x184418C90")]
		private BCCFLHCLHEK LHFHFEJFHPJ<T>(NativeList<T> BDHPAGCMKHB, int IMJIIGINGEP, int GJGJMGODAOO, GJKDPEMNOGO FLAGJIBPLNC, JobHandle ELLADMEAHLJ) where T : struct
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x4398570", Offset = "0x4397970", VA = "0x184398570")]
		private BCCFLHCLHEK LHFHFEJFHPJ(NativeArray<Entity> ABBIPALBHCK, int IMJIIGINGEP, int GJGJMGODAOO, GJKDPEMNOGO FLAGJIBPLNC, JobHandle ELLADMEAHLJ)
		{
			return default(BCCFLHCLHEK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private readonly KLBHBMBPLOA JFFPIFJCILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery DBJNNCJIJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery PPBHNIMEFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private HBFGHIOELIO HAKKJJIEELJ;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	protected abstract ComponentType JAHEBDOFOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected abstract ComponentType EPMEBHFHEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected abstract ComponentType HCFNJFHMEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x2DED300", Offset = "0x2DEC700", VA = "0x182DED300")]
	protected IMFEAONBJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x2DEBF30", Offset = "0x2DEB330", VA = "0x182DEBF30", Slot = "14")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC1D0", Offset = "0x2DEB5D0", VA = "0x182DEC1D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC400", Offset = "0x2DEB800", VA = "0x182DEC400", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0xB5A2E0", Offset = "0xB596E0", VA = "0x180B5A2E0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2DEBED0", Offset = "0x2DEB2D0", VA = "0x182DEBED0")]
	private void DMKHFPCIBKG(NativeArray<Entity> BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2DEBE30", Offset = "0x2DEB230", VA = "0x182DEBE30")]
	private void BIOIJCJDDPA(NativeArray<Entity> BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x2DEBAA0", Offset = "0x2DEAEA0", VA = "0x182DEBAA0")]
	private void AACILMDKMCM(BCCFLHCLHEK LACFMNHKMPJ, string OECHCNGOMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB990", Offset = "0x2DEAD90", VA = "0x182DEB990")]
	private void AACILMDKMCM(NativeListAsync<Entity> JPIPAGGDBKP, string OECHCNGOMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x2DEBCF0", Offset = "0x2DEB0F0", VA = "0x182DEBCF0")]
	private void AFFMMGKCEHO(BCCFLHCLHEK LACFMNHKMPJ, string OECHCNGOMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x2DEBBE0", Offset = "0x2DEAFE0", VA = "0x182DEBBE0")]
	private void AFFMMGKCEHO(NativeListAsync<Entity> JPIPAGGDBKP, string OECHCNGOMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC0C0", Offset = "0x2DEB4C0", VA = "0x182DEC0C0")]
	private bool NDDMDJOBHLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
public class JFBMPKEDBGA : KHECDAFCLCI, GBCNOEIKEOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct BKKHNOAFDFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public JFBMPKEDBGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		public BKKHNOAFDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct LFMPBGBDLAK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct IJFKDHPHNGE
		{
			[Cpp2IlInjected.Token(Token = "0x2000117")]
			public struct ACJCCODAALN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime AGKHCLHNFMM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity ODPKKCNFKHP;

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x4394D90", Offset = "0x4394190", VA = "0x184394D90")]
			public void KMHCJEDMEHN(JFBMPKEDBGA LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x4394DA0", Offset = "0x43941A0", VA = "0x184394DA0")]
			public ACJCCODAALN MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
			{
				return default(ACJCCODAALN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public JFBMPKEDBGA CJLIKMLCFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public EntityCommandBuffer DBFHOMIIBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private IJFKDHPHNGE GBKOBJGLANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IJFKDHPHNGE.ACJCCODAALN* IIGLDGPLJFM;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AGFEFLCLAEJ;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x4396710", Offset = "0x4395B10", VA = "0x184396710")]
		internal void JACNCLCPMJH(Entity CCICIDAGDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB410", Offset = "0x2BCA810", VA = "0x182BCB410", Slot = "5")]
		public void ReadFromDisplayClass(ref BKKHNOAFDFN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB440", Offset = "0x2BCA840", VA = "0x182BCB440", Slot = "6")]
		public void WriteToDisplayClass(ref BKKHNOAFDFN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x4396650", Offset = "0x4395A50", VA = "0x184396650", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x4396860", Offset = "0x4395C60", VA = "0x184396860")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref IJFKDHPHNGE.ACJCCODAALN MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x4396820", Offset = "0x4395C20", VA = "0x184396820")]
		public void KMHCJEDMEHN(JFBMPKEDBGA LFKHFKIBGCJ, ref BKKHNOAFDFN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x43966A0", Offset = "0x4395AA0", VA = "0x1843966A0")]
		public unsafe static void FEOHLEHDMJK(ArchetypeChunkIterator* JCPGCEEJMGC, void* AIFJMENHIAF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private KPNGJMMLELP BPOFPNMKGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EMJHKMNAGIL NDJDLGONCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery EAOCBOMHKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private ProfilerMarker EKFKFNAAFEG;

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x2DF03E0", Offset = "0x2DEF7E0", VA = "0x182DF03E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x2DF02A0", Offset = "0x2DEF6A0", VA = "0x182DF02A0", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0440", Offset = "0x2DEF840", VA = "0x182DF0440", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public JFBMPKEDBGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0300", Offset = "0x2DEF700", VA = "0x182DF0300", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x2DF00D0", Offset = "0x2DEF4D0", VA = "0x182DF00D0")]
	public static EntityQuery BHFNEEEAMFI(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[JGLBKJACABL]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
public class GEJKCANKGIO : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private EMJHKMNAGIL NDJDLGONCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private SceneService OOCMFKEPGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EntityQuery ANBHGOBNOFE;

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF690", Offset = "0x2DDEA90", VA = "0x182DDF690", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF700", Offset = "0x2DDEB00", VA = "0x182DDF700", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF7A0", Offset = "0x2DDEBA0", VA = "0x182DDF7A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public GEJKCANKGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public struct BLJIGMNCCHF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public CMKEFKIFPMD IGELLPOEMHM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x74C840", Offset = "0x74BC40", VA = "0x18074C840")]
	public static BLJIGMNCCHF HPHCHABBDNG(in CMKEFKIFPMD PGGLNMCAEIC)
	{
		return default(BLJIGMNCCHF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x74C840", Offset = "0x74BC40", VA = "0x18074C840")]
	public static CMKEFKIFPMD HPHCHABBDNG(in BLJIGMNCCHF MLAEFPAFLKC)
	{
		return default(CMKEFKIFPMD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[AlwaysUpdateSystem]
public class KPNGJMMLELP : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF46E0", Offset = "0x2DF3AE0", VA = "0x182DF46E0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
	public KPNGJMMLELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[AlwaysUpdateSystem]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
public class EIBDKJJIMPG : KHECDAFCLCI, GBCNOEIKEOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct KDFPIDMGHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public EIBDKJJIMPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		public KDFPIDMGHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
		internal void <OnUpdate>b__0(Entity e, BLJIGMNCCHF ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MIBMHIEEBJL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct OIKOACLLPHK
		{
			[Cpp2IlInjected.Token(Token = "0x200011F")]
			public struct KNFILCOFLHK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				public LambdaParameterValueProvider_Entity.Runtime AGKHCLHNFMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				public LambdaParameterValueProvider_IComponentData<BLJIGMNCCHF>.Runtime IFKEBLOBADO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity ODPKKCNFKHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<BLJIGMNCCHF> FEJKIIHIJOB;

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x4399520", Offset = "0x4398920", VA = "0x184399520")]
			public void KMHCJEDMEHN(EIBDKJJIMPG LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x4399580", Offset = "0x4398980", VA = "0x184399580")]
			public KNFILCOFLHK MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
			{
				return default(KNFILCOFLHK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public EIBDKJJIMPG CJLIKMLCFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EntityCommandBuffer DBFHOMIIBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private OIKOACLLPHK GBKOBJGLANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe OIKOACLLPHK.KNFILCOFLHK* IIGLDGPLJFM;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AGFEFLCLAEJ;

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB220", Offset = "0x2BCA620", VA = "0x182BCB220")]
		internal void JACNCLCPMJH(Entity CCICIDAGDNF, BLJIGMNCCHF EBGAMGGEFDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB410", Offset = "0x2BCA810", VA = "0x182BCB410", Slot = "5")]
		public void ReadFromDisplayClass(ref KDFPIDMGHGG LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB440", Offset = "0x2BCA840", VA = "0x182BCB440", Slot = "6")]
		public void WriteToDisplayClass(ref KDFPIDMGHGG LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB140", Offset = "0x2BCA540", VA = "0x182BCB140", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB360", Offset = "0x2BCA760", VA = "0x182BCB360")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref OIKOACLLPHK.KNFILCOFLHK MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB320", Offset = "0x2BCA720", VA = "0x182BCB320")]
		public void KMHCJEDMEHN(EIBDKJJIMPG LFKHFKIBGCJ, ref KDFPIDMGHGG LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB1B0", Offset = "0x2BCA5B0", VA = "0x182BCB1B0")]
		public unsafe static void FEOHLEHDMJK(ArchetypeChunkIterator* JCPGCEEJMGC, void* AIFJMENHIAF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private KPNGJMMLELP BPOFPNMKGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private EMJHKMNAGIL NDJDLGONCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery INAFGHCEAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private ProfilerMarker MDFEJFFEGFH;

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9180", Offset = "0x2FC8580", VA = "0x182FC9180", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8E70", Offset = "0x2FC8270", VA = "0x182FC8E70", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x2FC91E0", Offset = "0x2FC85E0", VA = "0x182FC91E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public EIBDKJJIMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x2FC90A0", Offset = "0x2FC84A0", VA = "0x182FC90A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8ED0", Offset = "0x2FC82D0", VA = "0x182FC8ED0")]
	public static EntityQuery KIMBFODFMHG(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct HMPAMAPJMNM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public HIEGLBAPNMB HFKINOFBOBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public NativeHashMap<Entity, JAPIHNFIDBB> ABBIPALBHCK;

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x4394380", Offset = "0x4393780", VA = "0x184394380")]
			public HMPAMAPJMNM(int IPADGNLNKOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x4394300", Offset = "0x4393700", VA = "0x184394300", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct EMHDCPHECAO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public NativeArray<Entity> ABBIPALBHCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> BLOPEONEHFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> MEEEGALMKOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> PDIMBINENIO;

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x4392A00", Offset = "0x4391E00", VA = "0x184392A00", Slot = "4")]
			public void Execute(int EGNHJGKABLC, TransformAccess CACALPHNCBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct MIHPJLDPIIF : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[ReadOnly]
			public NativeArray<Entity> ABBIPALBHCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> BLOPEONEHFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> PDIMBINENIO;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x4396ED0", Offset = "0x43962D0", VA = "0x184396ED0", Slot = "4")]
			public void Execute(int EGNHJGKABLC, TransformAccess CACALPHNCBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private EMJHKMNAGIL NDJDLGONCJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery EHOONLKHDCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery HLNFCFBLDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery PDIHPCBONNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private EntityQuery JKBECIPLDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery JFGFPALEPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private JobHandle LNBCJKBCOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private HMPAMAPJMNM CPBNHEAIJKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private HMPAMAPJMNM EOMCEEADBLN;

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2983360", Offset = "0x2982760", VA = "0x182983360", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2983BC0", Offset = "0x2982FC0", VA = "0x182983BC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x29833C0", Offset = "0x29827C0", VA = "0x1829833C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x2983E80", Offset = "0x2983280", VA = "0x182983E80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x29836F0", Offset = "0x2982AF0", VA = "0x1829836F0")]
		private void KPIGFBDCMID(EntityQuery ANBHGOBNOFE, out (NativeArrayAsync<BLJIGMNCCHF> handles, NativeArrayAsync<CNEHLCBOJKB> bounds) HIDEHJGLNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2983830", Offset = "0x2982C30", VA = "0x182983830")]
		private void MGNKCPCFKEH((NativeArrayAsync<BLJIGMNCCHF> handles, NativeArrayAsync<CNEHLCBOJKB> bounds) HIDEHJGLNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x29833C0", Offset = "0x29827C0", VA = "0x1829833C0")]
		private void GAPAHLBLDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x29830C0", Offset = "0x29824C0", VA = "0x1829830C0")]
		private void COCOGMCAIHN(EntityQuery ANBHGOBNOFE, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<BLJIGMNCCHF> handles) HIDEHJGLNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x2983400", Offset = "0x2982800", VA = "0x182983400")]
		private void IHJOKKAELNM((NativeArrayAsync<Entity> entities, NativeArrayAsync<BLJIGMNCCHF> handles) HIDEHJGLNHO, HMPAMAPJMNM CPLDDCNHBMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2983200", Offset = "0x2982600", VA = "0x182983200")]
		private JobHandle EGCABOFJJEO(HMPAMAPJMNM CPLDDCNHBMK, ComponentDataFromEntity<WorldPoseData> BLOPEONEHFC, ComponentDataFromEntity<WorldUniformScaleData> PDIMBINENIO, ComponentDataFromEntity<WorldDeformableScaleData> MEEEGALMKOM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2983A90", Offset = "0x2982E90", VA = "0x182983A90")]
		private JobHandle OJHLLNJIFGB(HMPAMAPJMNM CPLDDCNHBMK, ComponentDataFromEntity<WorldPoseData> BLOPEONEHFC, ComponentDataFromEntity<WorldUniformScaleData> PDIMBINENIO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct GLHLECMHHCN : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[JGLBKJACABL]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	public class SplineLocalBoundsSystem : KHECDAFCLCI
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[BurstCompile]
		private struct OANACJMHMNC : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			[ReadOnly]
			public NativeArray<Entity> POHMMCCAEIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> NPGJLKABGCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			[ReadOnly]
			public ComponentDataFromEntity<CNEHLCBOJKB> LHHPOGICBIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[WriteOnly]
			public NativeHashMap<Entity, JAPIHNFIDBB>.ParallelWriter CHCPIEKLJGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter MJJAMIPOKFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter HECIECGMAAL;

			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x4398F10", Offset = "0x4398310", VA = "0x184398F10", Slot = "4")]
			public void Execute(int EGNHJGKABLC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[BurstCompile]
		private struct MPAIACEMNEH : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[ReadOnly]
			public NativeArray<Entity> JCGJHHIFLDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> NLEMNNLCKJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> LJFJJMNEOOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> EHCANGIBCCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<CNEHLCBOJKB> FGFOFHBIJFH;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x4397B20", Offset = "0x4396F20", VA = "0x184397B20", Slot = "4")]
			public void Execute(int EGNHJGKABLC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery FBGKKJBNKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery PDDGOABOHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EntityQuery HCDMHMPMLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery HDGBICAABLO;

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4960", Offset = "0x2BD3D60", VA = "0x182BD4960", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4B70", Offset = "0x2BD3F70", VA = "0x182BD4B70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5270", Offset = "0x2BD4670", VA = "0x182BD5270")]
		private JobHandle PBAOLCJOOBO(NativeArrayAsync<Entity> BGAKDGCGOMH, int OEMPOIHBNFL, JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5090", Offset = "0x2BD4490", VA = "0x182BD5090")]
		private JobHandle PBAOLCJOOBO(NativeArray<Entity> EEDADAHMOAC, int OEMPOIHBNFL, [Optional] JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x2BD48E0", Offset = "0x2BD3CE0", VA = "0x182BD48E0")]
		private NativeArrayAsync<Entity> GKLEPMBLOBK(EntityQuery ANBHGOBNOFE)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4160", Offset = "0x2BD3560", VA = "0x182BD4160")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) BBNIODDBAPF(NativeArrayAsync<Entity> BKEINAHPOBL)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x2BD40D0", Offset = "0x2BD34D0", VA = "0x182BD40D0")]
		private void AMMLAPDPDIB(out NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4040", Offset = "0x2BD3440", VA = "0x182BD4040")]
		private void AEGALBBHMGP(NativeList<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3F70", Offset = "0x2BD3370", VA = "0x182BD3F70")]
		private void AEGALBBHMGP(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5350", Offset = "0x2BD4750", VA = "0x182BD5350")]
		private void PDPGMHIANFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		private static void AHMIOJLCNCH(int MHOKPBNHDDK, int DBIMGDEHOGC, int AJLFMJHNOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD45B0", Offset = "0x2BD39B0", VA = "0x182BD45B0")]
		private static CNEHLCBOJKB DFEPMIEPNBD(NativeArray<Entity> BLAOODBKMOD, ComponentDataFromEntity<SplinePointPositionData> LJFJJMNEOOD, ComponentDataFromEntity<SplinePointScaleData> EHCANGIBCCL)
		{
			return default(CNEHLCBOJKB);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct DMEELCACHKA : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[JGLBKJACABL]
	[JEGJCCBDMOE(OLCAJGBKOGB.Lifecycle)]
	public class DestroyLocalObjects : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[OMAMNFHDGBM]
		private ObjectNetworkToLocalMapService PJFKIMDFNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[OMAMNFHDGBM]
		private ObjectLifecycleService LCMHIEKJLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private EntityQuery GDHOFFFKNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EntityQuery OCAAOJCAOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery EBOENLLDHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x2FC70A0", Offset = "0x2FC64A0", VA = "0x182FC70A0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6FF0", Offset = "0x2FC63F0", VA = "0x182FC6FF0")]
		public bool BEJIAFMNDPH(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7570", Offset = "0x2FC6970", VA = "0x182FC7570", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7530", Offset = "0x2FC6930", VA = "0x182FC7530", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2FC76A0", Offset = "0x2FC6AA0", VA = "0x182FC76A0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x11BD010", Offset = "0x11BC410", VA = "0x1811BD010", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7530", Offset = "0x2FC6930", VA = "0x182FC7530")]
		private void MCDBHPJONPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7250", Offset = "0x2FC6650", VA = "0x182FC7250")]
		private void HBELFKCBMLE(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7110", Offset = "0x2FC6510", VA = "0x182FC7110")]
		private void GEBGICBGKAO(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7300", Offset = "0x2FC6700", VA = "0x182FC7300")]
		private void HICCDFAGLMP(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7410", Offset = "0x2FC6810", VA = "0x182FC7410")]
		private void LMIMAEBKDAA(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[JEGJCCBDMOE(OLCAJGBKOGB.NetworkSend)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	public sealed class EnqueuePropertyDifferenceToNetwork : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private static IECIGCFEBBH[] DBIABHIKIAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private DIKFAAMEOIH HNMKLOOGEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private JIGOCJGIGJA FCNFBBEHBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PropertyDiffStateService AMGEMOKKAOG;

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9430", Offset = "0x2DD8830", VA = "0x182DD9430", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9A70", Offset = "0x2DD8E70", VA = "0x182DD9A70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x2DD94E0", Offset = "0x2DD88E0", VA = "0x182DD94E0")]
		private void JIIDDDBGOPD(IECIGCFEBBH HJGAFKLFBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		private void KAKCHCJLHDE(Entity LCLDFKAJPDK, KHMECMDAALD HBKLDKCICEJ, ANIKAMAEHJJ HDLEMAAGOPN, CBFIIKBAJEL CKNLGGBDBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Callbacks)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	public sealed class PropertyEventCallbacks : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private PropertyEventCallbacksService CMIHNHHBGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private PropertyDiffStateService AMGEMOKKAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TransformOwnershipPhase HJGAFKLFBEI;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2989FB0", Offset = "0x29893B0", VA = "0x182989FB0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x298A040", Offset = "0x2989440", VA = "0x18298A040", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[JEGJCCBDMOE(OLCAJGBKOGB.NetworkSend)]
	internal class TransmitNetworkDataSystem : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private MMCKNDDCKHO PGKJLOKPPDB;

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC360", Offset = "0x2BDB760", VA = "0x182BDC360", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC3B0", Offset = "0x2BDB7B0", VA = "0x182BDC3B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[JGLBKJACABL]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	public class CalculateCullingBandChanges : KHECDAFCLCI, BJDLFHICAGD, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct DNEENACNMEL : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ArchetypeChunkEntityType MIKHNFECBKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> NBAKPDOONMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[WriteOnly]
			public NativeList<FJIBCOPGCCJ>.ParallelWriter HBFJAAHBLGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public ArchetypeChunkComponentType<AGEBNMMIEBF> GDCIBNFHLFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public float3 ELODBNLDLIK;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private static readonly float4x2 JKLLPFODBKG;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private static readonly float4x2 PLFMKJDFEIB;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private static readonly int4x2 PCPOLOHPLLK;

			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8410", Offset = "0x2BC7810", VA = "0x182BC8410", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private static KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private const int AMLDAADAMNK = 10;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private const double LFOPOIIFAJI = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery IBHHBDONFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery GHLNHFKJBAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private double FOAEBKGGEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private CullingBandService FGMPGOOJPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TimeService BMDOHFOEMDB;

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8020", Offset = "0x2FB7420", VA = "0x182FB8020", Slot = "14")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8030", Offset = "0x2FB7430", VA = "0x182FB8030", Slot = "15")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8470", Offset = "0x2FB7870", VA = "0x182FB8470", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2FB85C0", Offset = "0x2FB79C0", VA = "0x182FB85C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2FB80C0", Offset = "0x2FB74C0", VA = "0x182FB80C0")]
		private bool GLDNOODBCGF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8130", Offset = "0x2FB7530", VA = "0x182FB8130")]
		private void HOBJJEKJEKN(EntityQuery ANBHGOBNOFE, float3 MKKFMGKLFLF, string AMNLGEBHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public struct FJIBCOPGCCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Entity LCLDFKAJPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public PHOCPPOEDBC DKOFAPECACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public PHOCPPOEDBC JFNADPGFOAB;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	public class ProcessCullingBandChangeCallbacks : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CullingBandService FGMPGOOJPNE;

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x2986A10", Offset = "0x2985E10", VA = "0x182986A10", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x2986A60", Offset = "0x2985E60", VA = "0x182986A60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Connectables)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	public class UpdateInertialProperties : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery CLFLJFBGNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private NKLBMAPECJD OMEHINJBEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2E70", Offset = "0x2BE2270", VA = "0x182BE2E70", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2EE0", Offset = "0x2BE22E0", VA = "0x182BE2EE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2F70", Offset = "0x2BE2370", VA = "0x182BE2F70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[JGLBKJACABL]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> JMGDDGOEEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> IFEPAIBPHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OFHGEMGHPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private KinematicSleepChangeService MMEMGFEGDLG;

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8100", Offset = "0x2DD7500", VA = "0x182DD8100", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x2DD89E0", Offset = "0x2DD7DE0", VA = "0x182DD89E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8750", Offset = "0x2DD7B50", VA = "0x182DD8750")]
		private void NNDLOHAOMID(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> BDHPAGCMKHB, EntityQueryDesc FIKHDCDGJAH, bool HKPNCKPHHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8860", Offset = "0x2DD7C60", VA = "0x182DD8860")]
		private void NNDLOHAOMID(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> BDHPAGCMKHB, EntityQueryDesc FIKHDCDGJAH, bool HKPNCKPHHLB, bool GCAABCBBBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8C40", Offset = "0x2DD8040", VA = "0x182DD8C40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9120", Offset = "0x2DD8520", VA = "0x182DD9120")]
		private void PKFLOCAHJCK(EntityQuery ANBHGOBNOFE, bool AOBLOMCJEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8F10", Offset = "0x2DD8310", VA = "0x182DD8F10")]
		private void PJHFAPEGHGG(EntityQuery ANBHGOBNOFE, bool FPFOJOEOBCC, bool AOBLOMCJEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8530", Offset = "0x2DD7930", VA = "0x182DD8530")]
		private void KBOILNBEFIK(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7F90", Offset = "0x2DD7390", VA = "0x182DD7F90")]
		private void COIAIKENNBF(NativeList<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7E70", Offset = "0x2DD7270", VA = "0x182DD7E70")]
		private void BANLJKLFCEJ(NativeArray<Entity> ABBIPALBHCK, bool FPFOJOEOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8330", Offset = "0x2DD7730", VA = "0x182DD8330")]
		private NativeList<Entity> IKKMHDKJPLG(NativeArray<Entity> ABBIPALBHCK)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2DD89A0", Offset = "0x2DD7DA0", VA = "0x182DD89A0")]
		private NativeList<Entity> ONHONCKJMHC(NativeArray<Entity> ABBIPALBHCK)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8150", Offset = "0x2DD7550", VA = "0x182DD8150")]
		private NativeList<Entity> IADGBFLEJIF(NativeArray<Entity> ABBIPALBHCK)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8190", Offset = "0x2DD7590", VA = "0x182DD8190")]
		private NativeList<Entity> IBPDGLAOPGP(NativeArray<Entity> ABBIPALBHCK, bool JLGKAHIIONN)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7DE0", Offset = "0x2DD71E0", VA = "0x182DD7DE0")]
		private INIIDGJPOCP APKNAMIOHAO(NativeArray<Entity> ABBIPALBHCK)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(INIIDGJPOCP);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9360", Offset = "0x2DD8760", VA = "0x182DD9360")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private KinematicSleepChangeService MMEMGFEGDLG;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2986A80", Offset = "0x2985E80", VA = "0x182986A80", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2986AD0", Offset = "0x2985ED0", VA = "0x182986AD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : OCHAMNFOLEM
	{
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery KACJBNFEAKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery MLNHDIPPIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery LPIFOFMLIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private EntityQuery LIJPHLINFDI;

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6C60", Offset = "0x2FC6060", VA = "0x182FC6C60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6E20", Offset = "0x2FC6220", VA = "0x182FC6E20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x2FC67E0", Offset = "0x2FC5BE0", VA = "0x182FC67E0")]
		private void CMNGGPGFOEN(EntityQuery ANBHGOBNOFE, bool PBEMIFAFADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6A20", Offset = "0x2FC5E20", VA = "0x182FC6A20")]
		private void DOOAIAGCBFD(EntityQuery ANBHGOBNOFE, bool PBEMIFAFADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Scope)]
	internal class AssignPlayerIdsSystem : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private EntityQuery GKCOCLHPCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery AGPMGJABEHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private SceneService EDPMKCELNON;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x2FAF690", Offset = "0x2FAEA90", VA = "0x182FAF690", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2FAFF50", Offset = "0x2FAF350", VA = "0x182FAFF50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2FB0060", Offset = "0x2FAF460", VA = "0x182FB0060", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2FAFBF0", Offset = "0x2FAEFF0", VA = "0x182FAFBF0")]
		private void LDIKLPEIDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2FAF700", Offset = "0x2FAEB00", VA = "0x182FAF700")]
		private void HMODCOFHGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2FAF8D0", Offset = "0x2FAECD0", VA = "0x182FAF8D0")]
		private void KOEJKGOEEDM(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2FAFE10", Offset = "0x2FAF210", VA = "0x182FAFE10")]
		private void NDGIGJIBDPE(NativeArray<Entity> ABBIPALBHCK, int AACCOCAILJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2FAFD00", Offset = "0x2FAF100", VA = "0x182FAFD00")]
		private void MKMCGGEACJD(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2FAF870", Offset = "0x2FAEC70", VA = "0x182FAF870")]
		private void IHBJKCKLNML(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		private static void LHHAOAIOLLK(int ENNAKHLEBJN, Transform CACALPHNCBH, Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class IDGMKDENIPD
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6F30", Offset = "0x2DE6330", VA = "0x182DE6F30")]
	public static bool NFNLILJEJIH(this SystemBase HFKGGLPFCMG, out Entity LCLDFKAJPDK)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery PCNFNINMICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private NDFDMPICGAG FAFAJOBAHCN;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x2FBA110", Offset = "0x2FB9510", VA = "0x182FBA110", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2FBA160", Offset = "0x2FB9560", VA = "0x182FBA160", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2FBA220", Offset = "0x2FB9620", VA = "0x182FBA220", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Scope)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<NGPLPBCNPIA>, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private const string HMJIFCIIFNN = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private DECKIFJOPPL PLJOMALPEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityQuery NHPCDAAHPEM;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private Entity IGKILEFGBBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x296BA60", Offset = "0x296AE60", VA = "0x18296BA60")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x296BA00", Offset = "0x296AE00", VA = "0x18296BA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity LAOOOAJFNIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x296BAC0", Offset = "0x296AEC0", VA = "0x18296BAC0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public MBEDCJLMHEO JGPDOBJLKHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x296BB20", Offset = "0x296AF20", VA = "0x18296BB20")]
			get
			{
				return default(MBEDCJLMHEO);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x296BDF0", Offset = "0x296B1F0", VA = "0x18296BDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public MBEDCJLMHEO MDDFNIPLHDH
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x296B850", Offset = "0x296AC50", VA = "0x18296B850")]
			get
			{
				return default(MBEDCJLMHEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x296BCD0", Offset = "0x296B0D0", VA = "0x18296BCD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x296B910", Offset = "0x296AD10", VA = "0x18296B910", Slot = "15")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x296BD70", Offset = "0x296B170", VA = "0x18296BD70", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x296B440", Offset = "0x296A840", VA = "0x18296B440", Slot = "14")]
		protected override void AIIANEBGMBI(NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> BFCOFODCAGL, NativeArray<Entity> AGLEENNCIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x296BBB0", Offset = "0x296AFB0", VA = "0x18296BBB0")]
		private void OAHIGPGAAHG(NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> AGLEENNCIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x296B590", Offset = "0x296A990", VA = "0x18296B590")]
		private void CIIPGPLFMDM(Entity LCLDFKAJPDK, Entity BHICEBOIFIN, Entity IIHIMCBGDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2896070", Offset = "0x2895470", VA = "0x182896070")]
		private bool OBCGBBDEENH<T>(out T LPJDDLMPNCG) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2895FB0", Offset = "0x28953B0", VA = "0x182895FB0")]
		private void NFPBPFFPICN<T>(T LPJDDLMPNCG) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x296B980", Offset = "0x296AD80", VA = "0x18296B980")]
		public bool GCAKJKBOGHP(MBEDCJLMHEO AHKCJNCACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x296B8E0", Offset = "0x296ACE0", VA = "0x18296B8E0")]
		private static bool EEGPGHNGBOP(MBEDCJLMHEO CLLGFHPMKMI, MBEDCJLMHEO IAJNOLPBJLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x296BEB0", Offset = "0x296B2B0", VA = "0x18296BEB0")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x296BC90", Offset = "0x296B090", VA = "0x18296BC90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Scope)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EntityQuery ANBHGOBNOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2710", Offset = "0x2FC1B10", VA = "0x182FC2710", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2760", Offset = "0x2FC1B60", VA = "0x182FC2760", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2800", Offset = "0x2FC1C00", VA = "0x182FC2800", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x2FC25C0", Offset = "0x2FC19C0", VA = "0x182FC25C0")]
		private NativeArray<Entity> CEHHALOGAPJ(int EJMNNLNLAFJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2FC24B0", Offset = "0x2FC18B0", VA = "0x182FC24B0")]
		private void BPLIHAGPMGL(NativeArray<Entity> IAOKKFHHHBO, NativeArray<Entity> LJBLHPIOCMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Scope)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	internal class HideRemotePivotsNotInScope : KHECDAFCLCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery GJDMNEGJHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery PEDNKMJABGD;

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4630", Offset = "0x2DE3A30", VA = "0x182DE4630", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4720", Offset = "0x2DE3B20", VA = "0x182DE4720", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal static class GAEJKHFGOBJ
{
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public const string BCGOOCPMCNO = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x262ABC0", Offset = "0x2629FC0", VA = "0x18262ABC0")]
	public static NativeArray<T> LHFHFEJFHPJ<T>(NativeArray<Entity> ABBIPALBHCK, EntityManager MABCFMECCKD) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF300", Offset = "0x2DDE700", VA = "0x182DDF300")]
	public static void DBBBNELOAIL(EntityQuery ANBHGOBNOFE, EntityManager MABCFMECCKD, DDOLHFHMLOP CGCNGCLEGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF440", Offset = "0x2DDE840", VA = "0x182DDF440")]
	public static void NALLNOKALJL(NativeArray<Entity> IAOKKFHHHBO, DDOLHFHMLOP CGCNGCLEGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF1D0", Offset = "0x2DDE5D0", VA = "0x182DDF1D0")]
	public static void COBCIALDJLP(NativeArray<Entity> IAOKKFHHHBO, DDOLHFHMLOP CGCNGCLEGIG)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Scope)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	internal class UpdateContainerPivotOnExitScopeSystem : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private EntityQuery ANBHGOBNOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TransformService HFKINOFBOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ObjectLifecycleService LCMHIEKJLJH;

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1770", Offset = "0x2BE0B70", VA = "0x182BE1770", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2D70", Offset = "0x2BE2170", VA = "0x182BE2D70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2E10", Offset = "0x2BE2210", VA = "0x182BE2E10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2560", Offset = "0x2BE1960", VA = "0x182BE2560")]
		private void KMNGHEPDPHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1660", Offset = "0x2BE0A60", VA = "0x182BE1660")]
		private void ECGKALCIHJD(NativeArray<Entity> IAOKKFHHHBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1800", Offset = "0x2BE0C00", VA = "0x182BE1800")]
		private void FNBBDNOKBLM(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1410", Offset = "0x2BE0810", VA = "0x182BE1410")]
		private void CHKCHJDEEJP(NativeArray<Entity> LJBLHPIOCMG, NativeArray<RigidTransform> KEPFCGGNCDG, NativeArray<RigidTransform> PKEPOCGFOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x2BE20D0", Offset = "0x2BE14D0", VA = "0x182BE20D0")]
		private void GPLHEEJMOEK(NativeArray<RigidTransform> PKEPOCGFOCE, NativeArray<Entity> LJBLHPIOCMG, NativeList<Entity> KHEODJCPNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Scope)]
	internal class PostGameplayOnScopeChange : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EntityQuery PCNFNINMICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery FABBEGFFOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x2985020", Offset = "0x2984420", VA = "0x182985020", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2985090", Offset = "0x2984490", VA = "0x182985090", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x29851E0", Offset = "0x29845E0", VA = "0x1829851E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2984FB0", Offset = "0x29843B0", VA = "0x182984FB0")]
		private void EMHNIKBGLPN(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Scope)]
	internal class PreventDisembodiedScopesSystem : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private EntityQuery MHANFNOEALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private EntityHierarchyParents EOPPFFEOLEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private NDFDMPICGAG FAFAJOBAHCN;

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x2986880", Offset = "0x2985C80", VA = "0x182986880", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2986910", Offset = "0x2985D10", VA = "0x182986910", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x29869B0", Offset = "0x2985DB0", VA = "0x1829869B0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x29866F0", Offset = "0x2985AF0", VA = "0x1829866F0")]
		private void CGOOCKPINID(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Scope)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<FIAAPFIFKGI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD040", Offset = "0x2BCC440", VA = "0x182BCD040", Slot = "14")]
		protected override void AIIANEBGMBI(NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> BFCOFODCAGL, NativeArray<Entity> AGLEENNCIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD190", Offset = "0x2BCC590", VA = "0x182BCD190")]
		[BurstCompile]
		private static void AIIANEBGMBI(NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> AGLEENNCIPN, ComponentDataFromEntity<global::CDKPNOKKLBK> CNADBBPDFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD2A0", Offset = "0x2BCC6A0", VA = "0x182BCD2A0")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD260", Offset = "0x2BCC660", VA = "0x182BCD260", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : KHECDAFCLCI where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private EntityQuery EFNJKPDMBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery KBFIBJBFIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private EntityQuery LOIFECGBEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private EntityQuery AENOEBBBNAN;

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x378E1E0", Offset = "0x378D5E0", VA = "0x18378E1E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x378E3E0", Offset = "0x378D7E0", VA = "0x18378E3E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x378E3B0", Offset = "0x378D7B0", VA = "0x18378E3B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x378D3F0", Offset = "0x378C7F0", VA = "0x18378D3F0")]
		private void AJMFKJCFPCL(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x378D830", Offset = "0x378CC30", VA = "0x18378D830")]
		private void CJHMKOKFKPI(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x378CB60", Offset = "0x378BF60", VA = "0x18378CB60")]
		private void ABMPGMIIJPI(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void AIIANEBGMBI(NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> BFCOFODCAGL, NativeArray<Entity> AGLEENNCIPN);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x33EA820", Offset = "0x33E9C20", VA = "0x1833EA820")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0xF93720", Offset = "0xF92B20", VA = "0x180F93720", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class INBPEPEPNJB : KHECDAFCLCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private List<(EntityQuery, ComponentType)> EODGEOJGIGD;

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2DED340", Offset = "0x2DEC740", VA = "0x182DED340", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x2DED540", Offset = "0x2DEC940", VA = "0x182DED540", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x2DED690", Offset = "0x2DECA90", VA = "0x182DED690")]
	public INBPEPEPNJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct MBHJMBGECFD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public int CMHFEELAEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public int PELKNHEANOH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x296C050", Offset = "0x296B450", VA = "0x18296C050")]
	public static Entity HPHCHABBDNG(MBHJMBGECFD HIDEHJGLNHO)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x296C050", Offset = "0x296B450", VA = "0x18296C050")]
	public static MBHJMBGECFD HPHCHABBDNG(Entity LCLDFKAJPDK)
	{
		return default(MBHJMBGECFD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct OGPCFLPBDCL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct IGNMPNCMIDA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly ComponentType KCEEKGALKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly NativeList<int> JDFBPHJNCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly NativeList<int> EIDHOHCPCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly NativeArray<Entity> ABBIPALBHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly NativeArray<Entity> KKBMAODLFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly NativeArray<byte> CHHFOFIKHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly NativeArray<byte> IECLCEDGDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public readonly int LPECOOCMGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public readonly int NIFIKABPPCH;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool FBGGOCODCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9E30", Offset = "0x2DE9230", VA = "0x182DE9E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9FE0", Offset = "0x2DE93E0", VA = "0x182DE9FE0")]
	public IGNMPNCMIDA(ComponentType KCEEKGALKFC, NativeList<int> JDFBPHJNCCJ, NativeList<int> EIDHOHCPCDL, NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> KKBMAODLFPI, NativeArray<byte> CHHFOFIKHKL, NativeArray<byte> IECLCEDGDAE, int LPECOOCMGPK, int NIFIKABPPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9EB0", Offset = "0x2DE92B0", VA = "0x182DE9EB0")]
	private HAMGOKKMMPI KNJNJIOFBMK(NativeArray<byte> BGAKDGCGOMH, int EGNHJGKABLC)
	{
		return default(HAMGOKKMMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	private T KNJNJIOFBMK<T>(NativeArray<byte> BGAKDGCGOMH, int EGNHJGKABLC) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9CB0", Offset = "0x2DE90B0", VA = "0x182DE9CB0")]
	public HAMGOKKMMPI BJPPGOKMHCP(int EGNHJGKABLC)
	{
		return default(HAMGOKKMMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	public T BJPPGOKMHCP<T>(int EGNHJGKABLC) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9DE0", Offset = "0x2DE91E0", VA = "0x182DE9DE0")]
	public HAMGOKKMMPI EHIJKEJJMFD(int EGNHJGKABLC)
	{
		return default(HAMGOKKMMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	public T EHIJKEJJMFD<T>(int EGNHJGKABLC) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9D00", Offset = "0x2DE9100", VA = "0x182DE9D00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct LHKPICCFKEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public readonly EntityQuery ANBHGOBNOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public readonly NativeArray<GKBBNJFKKEL> FNBGFGCHFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly ComponentType KCEEKGALKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly int LPECOOCMGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly int NIFIKABPPCH;

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x296ADF0", Offset = "0x296A1F0", VA = "0x18296ADF0")]
	public LHKPICCFKEL(ComponentType KCEEKGALKFC, int LPECOOCMGPK, int NIFIKABPPCH, EntityQuery ANBHGOBNOFE, NativeArray<GKBBNJFKKEL> FNBGFGCHFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x296ADA0", Offset = "0x296A1A0", VA = "0x18296ADA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct FAEMGOHDEBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public int EGNHJGKABLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public int PBKKPBPLHFF;

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x735A30", Offset = "0x734E30", VA = "0x180735A30")]
	public FAEMGOHDEBA(int EGNHJGKABLC, int PBKKPBPLHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct GKBBNJFKKEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly int LBOLDANMBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly int GBNBGNMHGLO;

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x735A30", Offset = "0x734E30", VA = "0x180735A30")]
	public GKBBNJFKKEL(int LBOLDANMBMA, int GBNBGNMHGLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct CBFIIKBAJEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly AHKPLOLMABO PKNOIGMENLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly int LPECOOCMGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private unsafe readonly byte* CHHFOFIKHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private unsafe readonly byte* IECLCEDGDAE;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x2FB4B40", Offset = "0x2FB3F40", VA = "0x182FB4B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public AHKPLOLMABO IKLMOKJELML
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0")]
		get
		{
			return default(AHKPLOLMABO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x2FB4B50", Offset = "0x2FB3F50", VA = "0x182FB4B50")]
	public HAMGOKKMMPI FHIIKIODOHE(Type OGILDIMGIOH)
	{
		return default(HAMGOKKMMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x2FB4C40", Offset = "0x2FB4040", VA = "0x182FB4C40")]
	public HAMGOKKMMPI HCDJDJNOCCF(Type OGILDIMGIOH)
	{
		return default(HAMGOKKMMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x1A8CED0", Offset = "0x1A8C2D0", VA = "0x181A8CED0")]
	public T FHIIKIODOHE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x1A8CEF0", Offset = "0x1A8C2F0", VA = "0x181A8CEF0")]
	public T HCDJDJNOCCF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x2FB4D30", Offset = "0x2FB4130", VA = "0x182FB4D30")]
	public unsafe CBFIIKBAJEL(AHKPLOLMABO PKNOIGMENLD, int GBNBGNMHGLO, byte* CHHFOFIKHKL, byte* IECLCEDGDAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal abstract class KAADPHHJBDD : BPBHIFGCFAP, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private PropertyDiffStateService AMGEMOKKAOG;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected abstract IECIGCFEBBH FHEEODAALOO
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2630", Offset = "0x2DF1A30", VA = "0x182DF2630", Slot = "17")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2680", Offset = "0x2DF1A80", VA = "0x182DF2680", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF23F0", Offset = "0x2DF17F0", VA = "0x182DF23F0", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	protected KAADPHHJBDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class PEEEEPHOJHA
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] KGOEKINJEPJ;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[DefaultMember("Item")]
internal class NOBLONKDMFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly KLBHBMBPLOA JFFPIFJCILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly Dictionary<ComponentType, LHKPICCFKEL> AILOFIFIOME;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public LHKPICCFKEL JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x296F850", Offset = "0x296EC50", VA = "0x18296F850")]
		get
		{
			return default(LHKPICCFKEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x296FD40", Offset = "0x296F140", VA = "0x18296FD40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x29702D0", Offset = "0x296F6D0", VA = "0x1829702D0")]
	public NOBLONKDMFK(BHHDNNCMGLM GHDOFHADNOC, KLBHBMBPLOA JFFPIFJCILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x296F8E0", Offset = "0x296ECE0", VA = "0x18296F8E0")]
	public bool DJKANKJNGBD(ComponentType KCEEKGALKFC, out LHKPICCFKEL COEEJIEMCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x296FE40", Offset = "0x296F240", VA = "0x18296FE40")]
	public Dictionary<ComponentType, LHKPICCFKEL>.Enumerator OKFDNCHLPHK()
	{
		return default(Dictionary<ComponentType, LHKPICCFKEL>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x296F950", Offset = "0x296ED50", VA = "0x18296F950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x296FED0", Offset = "0x296F2D0", VA = "0x18296FED0")]
	private void PPFJDIAPFKL(IEnumerable<HOOPFMCFMDE> IAPHJIOPDJO, EntityManager MABCFMECCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x296FD90", Offset = "0x296F190", VA = "0x18296FD90")]
	private static int KAFNFDJEMFD(HOOPFMCFMDE BILIICLNGJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x296FAF0", Offset = "0x296EEF0", VA = "0x18296FAF0")]
	private static NativeArray<GKBBNJFKKEL> GAODJLAMAMK(HOOPFMCFMDE BILIICLNGJO, Allocator FKHAEPDPDAI = Allocator.Persistent)
	{
		return default(NativeArray<GKBBNJFKKEL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal interface KIPPNPAOMDE
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	bool FBGGOCODCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	World JAPDBJIMKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DBIBJNIBGAD(out NativeArray<int> AOMENFOEHAP, Allocator FKHAEPDPDAI);

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NIOGCILKHIC(ComponentType KCEEKGALKFC, out IGNMPNCMIDA IDHFJEIFJJF, out LHKPICCFKEL OCNEBCDHANP);

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NIOGCILKHIC(ComponentType KCEEKGALKFC, out IGNMPNCMIDA IDHFJEIFJJF);

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IGNMPNCMIDA OIPJFDEPDCG(ComponentType KCEEKGALKFC);

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DLNMECKPKMF BHHHNPGLMCA();

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AFDAKOHNPHE(JobHandle DNPFDFHMBNH);
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
internal interface IIEECLOJGND
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	World JAPDBJIMKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	NOBLONKDMFK FEPPIANMPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	HAMGBPFOOHJ EFFOHGKPMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	NativeMultiHashMap<Entity, CBFIIKBAJEL> PIAACNHOMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	JobHandle CGCDHAJDOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GJPLHHGHDFM();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BONIBAPHNIO();

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MFEIBBPOOHL(ComponentType KCEEKGALKFC, in IGNMPNCMIDA GKOCLMPMONP);

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OOHHEPJLLDC(GODNFBOIBNJ KLFAINNONJC, out Entity OPBBFNOFOIK);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct DLNMECKPKMF
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public struct GHFLNGADFNO : IEnumerator<CBFIIKBAJEL>, IEnumerator, IDisposable, IEnumerable<CBFIIKBAJEL>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly NativeMultiHashMap<Entity, CBFIIKBAJEL> MCHKFDMHGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly Entity LCLDFKAJPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private NativeMultiHashMapIterator<Entity> DIBHDLJNMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private CBFIIKBAJEL IECLCEDGDAE;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public CBFIIKBAJEL IFFLDLNKLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0x1C8C820", Offset = "0x1C8BC20", VA = "0x181C8C820", Slot = "4")]
			get
			{
				return default(CBFIIKBAJEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9350", Offset = "0x2BC8750", VA = "0x182BC9350", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x2BC93A0", Offset = "0x2BC87A0", VA = "0x182BC93A0")]
		internal GHFLNGADFNO(NativeMultiHashMap<Entity, CBFIIKBAJEL> MCHKFDMHGLB, Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9110", Offset = "0x2BC8510", VA = "0x182BC9110", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x2BC91E0", Offset = "0x2BC85E0", VA = "0x182BC91E0")]
		public GHFLNGADFNO OKFDNCHLPHK()
		{
			return default(GHFLNGADFNO);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9210", Offset = "0x2BC8610", VA = "0x182BC9210", Slot = "9")]
		private IEnumerator<CBFIIKBAJEL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC92B0", Offset = "0x2BC86B0", VA = "0x182BC92B0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly IIEECLOJGND OJNFGJAPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly JobHandle NNDGCIEGNDD;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int HOPNCAHGHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6450", Offset = "0x2FC5850", VA = "0x182FC6450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x2FC60C0", Offset = "0x2FC54C0", VA = "0x182FC60C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x1D04E00", Offset = "0x1D04200", VA = "0x181D04E00")]
	public DLNMECKPKMF(IIEECLOJGND OJNFGJAPBNC, JobHandle NNDGCIEGNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6310", Offset = "0x2FC5710", VA = "0x182FC6310")]
	public bool GDNLBEAOCAH(Allocator FKHAEPDPDAI, out NativeKeyValueArrays<Entity, CBFIIKBAJEL> JGINNNKFHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x2FC61A0", Offset = "0x2FC55A0", VA = "0x182FC61A0")]
	public bool CAJPAIFJPHE(Allocator FKHAEPDPDAI, out (NativeArray<Entity> entities, int uniqueCount) JGINNNKFHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6540", Offset = "0x2FC5940", VA = "0x182FC6540")]
	public GHFLNGADFNO OAANCEFAOCG(Entity LCLDFKAJPDK)
	{
		return default(GHFLNGADFNO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[DefaultMember("Item")]
internal class HAMGBPFOOHJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly KLBHBMBPLOA JFFPIFJCILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly List<LHKPICCFKEL> BDHPAGCMKHB;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public LHKPICCFKEL JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0CD0", Offset = "0x2DE00D0", VA = "0x182DE0CD0")]
		get
		{
			return default(LHKPICCFKEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0EE0", Offset = "0x2DE02E0", VA = "0x182DE0EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE12E0", Offset = "0x2DE06E0", VA = "0x182DE12E0")]
	public HAMGBPFOOHJ(NOBLONKDMFK AILOFIFIOME, BHHDNNCMGLM GHDOFHADNOC, KLBHBMBPLOA JFFPIFJCILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0F20", Offset = "0x2DE0320", VA = "0x182DE0F20")]
	public List<LHKPICCFKEL>.Enumerator OKFDNCHLPHK()
	{
		return default(List<LHKPICCFKEL>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0D60", Offset = "0x2DE0160", VA = "0x182DE0D60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0FA0", Offset = "0x2DE03A0", VA = "0x182DE0FA0")]
	private void PPFJDIAPFKL(NOBLONKDMFK AILOFIFIOME, EntityManager MABCFMECCKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class IFJOIMFECNJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private readonly KLBHBMBPLOA JFFPIFJCILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly ObjectInstantiationService IIPJHFKNDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly global::EILPMGINBJG<HOOPFMCFMDE> ANPEAPDPJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly World INEGJJDGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly EntityManager MABCFMECCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private NativeHashMap<int, Entity> BCAMCAPCPNI;

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9AD0", Offset = "0x2DE8ED0", VA = "0x182DE9AD0")]
	public IFJOIMFECNJ(ObjectInstantiationService IIPJHFKNDGJ, BHHDNNCMGLM GHDOFHADNOC, KLBHBMBPLOA JFFPIFJCILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8580", Offset = "0x2DE7980", VA = "0x182DE8580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9640", Offset = "0x2DE8A40", VA = "0x182DE9640")]
	public bool LJBAPKMEOLK(GODNFBOIBNJ KLFAINNONJC, out Entity OPBBFNOFOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8650", Offset = "0x2DE7A50", VA = "0x182DE8650")]
	private void GAOHHEODLEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8EF0", Offset = "0x2DE82F0", VA = "0x182DE8EF0")]
	private EntityArchetype HFDCFDHFBEL(EntityArchetype MPNBIOGEFCF)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x2DE96A0", Offset = "0x2DE8AA0", VA = "0x182DE96A0")]
	public static void PCDPNHDBPBD(EntityManager MENKGFBPIJM, EntityManager DLKHAOHFHOB, NativeArray<Entity> JILBKCFLHPF, NativeArray<EntityArchetype> NIIPLLMCLJE, [Optional] NativeArray<Entity> IIAJPNPCDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8260", Offset = "0x2DE7660", VA = "0x182DE8260")]
	[Conditional("DEBUG_BUILD")]
	private static void BCIOMPIOHHA(NativeArray<EntityArchetype> NOKEICPGEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8CB0", Offset = "0x2DE80B0", VA = "0x182DE8CB0")]
	private static string GIKBMFAGOAC(EntityArchetype NCPPLDKIKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9420", Offset = "0x2DE8820", VA = "0x182DE9420")]
	[CompilerGenerated]
	internal static void HGKFNOBMKEF(ref Span<ComponentType> OJBOAKGOJFN, ComponentType LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x2DE83D0", Offset = "0x2DE77D0", VA = "0x182DE83D0")]
	[CompilerGenerated]
	internal static void DEMKHLGIABF(Span<ComponentType> BGAKDGCGOMH, ref Span<ComponentType> OJBOAKGOJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9560", Offset = "0x2DE8960", VA = "0x182DE9560")]
	[CompilerGenerated]
	internal static void ILHNKBAPLNP(Span<ComponentType> BGAKDGCGOMH, ref Span<ComponentType> OJBOAKGOJFN, ComponentType NNIHDPDHNJD)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[JEGJCCBDMOE(OLCAJGBKOGB.PropertyChanges)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld ENPKHBCBHMC;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2FAF520", Offset = "0x2FAE920", VA = "0x182FAF520", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2FAF5E0", Offset = "0x2FAE9E0", VA = "0x182FAF5E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[AlwaysUpdateSystem]
	[JEGJCCBDMOE(OLCAJGBKOGB.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : KHECDAFCLCI, GBCNOEIKEOL, IJGJDJPFIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct OPJPHKNEKEA : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<byte> HKCIEEAONAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<byte> GLFBNFMLOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeArray<GKBBNJFKKEL> BDOBIEBIADC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[WriteOnly]
			public NativeList<FAEMGOHDEBA>.ParallelWriter JMPDBJONJND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int IBPICFHGLDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int KDFADIEEGKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker MPNNKDDAEPB;

			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB930", Offset = "0x2BCAD30", VA = "0x182BCB930", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBA70", Offset = "0x2BCAE70", VA = "0x182BCBA70")]
			private unsafe int MKMNAJHKEIL(byte* IOANNICCPJA, byte* AFCHMEJMNBE)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[BurstCompile]
		internal struct JAGJPGAGFJA : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			[WriteOnly]
			public NativeList<int> JDFBPHJNCCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			[WriteOnly]
			public NativeList<int> NFCIFLDGGNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			[ReadOnly]
			public NativeList<FAEMGOHDEBA> LJLPNNBCCEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public ProfilerMarker MPNNKDDAEPB;

			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA050", Offset = "0x2BC9450", VA = "0x182BCA050", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[BurstCompile]
		internal struct DHHBJAADKGC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			[WriteOnly]
			public NativeArray<byte> POBAFCNEMHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			[ReadOnly]
			public NativeArray<Entity> ABBIPALBHCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			[ReadOnly]
			public ComponentDataFromEntity LDLJLOGEFBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int LPECOOCMGPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public ProfilerMarker MPNNKDDAEPB;

			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7FF0", Offset = "0x2BC73F0", VA = "0x182BC7FF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[BurstCompile]
		internal struct HKKCGNDFBGC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, CBFIIKBAJEL> DIAFLBCAEMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			[ReadOnly]
			public NativeArray<byte> CHHFOFIKHKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			public NativeArray<byte> IECLCEDGDAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			public NativeArray<Entity> ABBIPALBHCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			[ReadOnly]
			public NativeArray<GKBBNJFKKEL> FOAOHLOIMBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			[ReadOnly]
			public NativeList<int> EIDHOHCPCDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			[ReadOnly]
			public NativeList<int> JDFBPHJNCCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int PHMOFECGGMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public int NIFIKABPPCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public ProfilerMarker MPNNKDDAEPB;

			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9DD0", Offset = "0x2BC91D0", VA = "0x182BC9DD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private static readonly ProfilerMarker HNLGLFODEBL;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private static readonly ProfilerMarker DILBDJDIIBG;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private static readonly ProfilerMarker ALGGLGBDIDE;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private static readonly ProfilerMarker HEIHEOHECEO;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private static readonly ProfilerMarker ILLMIMGJJIB;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private static readonly ProfilerMarker CDHJKMDKLGC;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private static readonly ProfilerMarker MOINBDAHBCI;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private static readonly ProfilerMarker GDKALBKPOAN;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private static readonly ProfilerMarker BFIECANMMBO;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private static readonly ProfilerMarker MOCFNJNIHFM;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private static readonly ProfilerMarker AIFIKFOOAGN;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private static readonly ProfilerMarker AHPDAFBHGAL;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private static readonly ProfilerMarker PAILCELKGDO;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private static readonly ProfilerMarker GCIHHDFCNCD;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly ProfilerMarker MAJGAPHNCKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private PropertyDiffStateService AMGEMOKKAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private EntityQuery FLGNKDDLJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private EntityQuery PKFGFHPBIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private EntityQuery EBOENLLDHHB;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		internal World JAPDBJIMKDG
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x2FBCAF0", Offset = "0x2FBBEF0", VA = "0x182FBCAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private IIEECLOJGND FJJGKFADCDD
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x2FBB870", Offset = "0x2FBAC70", VA = "0x182FBB870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x2FBB890", Offset = "0x2FBAC90", VA = "0x182FBB890", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "15")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x2FBD290", Offset = "0x2FBC690", VA = "0x182FBD290", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x2FBD450", Offset = "0x2FBC850", VA = "0x182FBD450", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x2FBD3E0", Offset = "0x2FBC7E0", VA = "0x182FBD3E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x2FBA470", Offset = "0x2FB9870", VA = "0x182FBA470")]
		private void BDDFDHBKPPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x2FBC910", Offset = "0x2FBBD10", VA = "0x182FBC910")]
		internal void IDIJPFOCBOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2FBC140", Offset = "0x2FBB540", VA = "0x182FBC140")]
		private void IDIJPFOCBOK(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x2FBA7E0", Offset = "0x2FB9BE0", VA = "0x182FBA7E0")]
		private void CEONFKHJOOK(NativeArray<Entity> JILBKCFLHPF, NativeArray<RRObjectPrefabData> EMBJJIPONBD, ref NativeArray<Entity> ODOKAALFGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x2FBB850", Offset = "0x2FBAC50", VA = "0x182FBB850")]
		internal void CPPGJLKJHAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2FBB450", Offset = "0x2FBA850", VA = "0x182FBB450")]
		private void CPPGJLKJHAE(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2FBB9E0", Offset = "0x2FBADE0", VA = "0x182FBB9E0")]
		internal void GNCLJJHPAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2FBCBB0", Offset = "0x2FBBFB0", VA = "0x182FBCBB0")]
		private void JPHHEOJGFNM(IIEECLOJGND OJNFGJAPBNC, LHKPICCFKEL OCNEBCDHANP, bool LMHNPCCHOCO, ref JobHandle ACNKHGAIBKH, ref JobHandle BKCDJAHDOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2FBB420", Offset = "0x2FBA820", VA = "0x182FBB420")]
		internal bool CNGDPCKLLKJ(in LHKPICCFKEL AFCHMEJMNBE, out JobHandle IGELLPOEMHM, out IGNMPNCMIDA JDCHPBICAGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2FBAA20", Offset = "0x2FB9E20", VA = "0x182FBAA20")]
		private bool CNGDPCKLLKJ(in LHKPICCFKEL AFCHMEJMNBE, bool LMHNPCCHOCO, out JobHandle IGELLPOEMHM, out IGNMPNCMIDA JDCHPBICAGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2FBC930", Offset = "0x2FBBD30", VA = "0x182FBC930")]
		internal (NativeList<int>, NativeList<int>) ILABJGIGNIG(NativeList<FAEMGOHDEBA> LJLPNNBCCEF, int IPADGNLNKOB, JobHandle ELLADMEAHLJ, out JobHandle DNPFDFHMBNH, Allocator FKHAEPDPDAI = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2FBA730", Offset = "0x2FB9B30", VA = "0x182FBA730")]
		internal static NativeArray<Entity> CEBHKFDCONB(EntityQuery ANBHGOBNOFE, out JobHandle CDOLDCAEBLK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2FBD210", Offset = "0x2FBC610", VA = "0x182FBD210")]
		internal static NativeArray<byte> OICINKFKBEL(int EMIAMELGKNF, out JobHandle FDNADPEBPPO)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2FBCE90", Offset = "0x2FBC290", VA = "0x182FBCE90")]
		internal static NativeArray<byte> KJCMNPGIMNP(EntityQuery ANBHGOBNOFE, int ODMCPPPIBBH, out JobHandle FDNADPEBPPO)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2FBB8E0", Offset = "0x2FBACE0", VA = "0x182FBB8E0")]
		internal static NativeArray<Entity> GKLEPMBLOBK(EntityQuery ANBHGOBNOFE, out JobHandle IHJJIBIIDLN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x2FBCFA0", Offset = "0x2FBC3A0", VA = "0x182FBCFA0")]
		internal NativeArray<byte> LGAHHFHPDHP(NativeArray<Entity> ABBIPALBHCK, LHKPICCFKEL OCNEBCDHANP, JobHandle ELLADMEAHLJ, out JobHandle DNPFDFHMBNH, Allocator FKHAEPDPDAI = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x2FBA2E0", Offset = "0x2FB96E0", VA = "0x182FBA2E0")]
		internal JobHandle AHOGNABDEDL(in IGNMPNCMIDA HIDEHJGLNHO, in LHKPICCFKEL OCNEBCDHANP, NativeMultiHashMap<Entity, CBFIIKBAJEL> DIAFLBCAEMB, JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1376F10", Offset = "0x1376310", VA = "0x181376F10")]
		private JobHandle DCHBNNMAEFD(JobHandle KMKICIADJJL, JobHandle IOLEGKJGFEA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1376F10", Offset = "0x1376310", VA = "0x181376F10")]
		private JobHandle DCHBNNMAEFD(JobHandle KMKICIADJJL, JobHandle IOLEGKJGFEA, JobHandle BHPAAJNIHEK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[JEGJCCBDMOE(OLCAJGBKOGB.RenderEffects)]
	internal class PropagateHoverRootTag : IMFEAONBJNA
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		public struct JHHDMFPAOOF : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType JAHEBDOFOME
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x2987290", Offset = "0x2986690", VA = "0x182987290", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType EPMEBHFHEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x29872F0", Offset = "0x29866F0", VA = "0x1829872F0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType HCFNJFHMEDN
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x29872C0", Offset = "0x29866C0", VA = "0x1829872C0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x2987320", Offset = "0x2986720", VA = "0x182987320")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[JEGJCCBDMOE(OLCAJGBKOGB.RenderEffects)]
	internal class PropagateSelectionRootTag : IMFEAONBJNA
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public struct NPGFHBIINOL : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		protected override ComponentType JAHEBDOFOME
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x2987330", Offset = "0x2986730", VA = "0x182987330", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType EPMEBHFHEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x2987390", Offset = "0x2986790", VA = "0x182987390", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType HCFNJFHMEDN
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x2987360", Offset = "0x2986760", VA = "0x182987360", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x2987320", Offset = "0x2986720", VA = "0x182987320")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[JGLBKJACABL]
public class GPLINALFPNN : OCHAMNFOLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private EntityQuery ANBHGOBNOFE;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0380", Offset = "0x2DDF780", VA = "0x182DE0380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0410", Offset = "0x2DDF810", VA = "0x182DE0410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public GPLINALFPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[JGLBKJACABL]
public class OBJCKFABAJI : OCHAMNFOLEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct IEJMOIPJOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		public IEJMOIPJOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct EGFJOBHCDIO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct PLALMAJACPD
		{
			[Cpp2IlInjected.Token(Token = "0x2000161")]
			[NoAlias]
			public struct NBANCJBMIHI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000463")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FICJNOIKPAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000464")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime PCPBPPGNFCC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity ONBCEAPJNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> IFJLAEDEKID;

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x439BE50", Offset = "0x439B250", VA = "0x18439BE50")]
			public void KMHCJEDMEHN(OBJCKFABAJI LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x439BEB0", Offset = "0x439B2B0", VA = "0x18439BEB0")]
			public NBANCJBMIHI MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
			{
				return default(NBANCJBMIHI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EntityManager MABCFMECCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NativeList<Entity> IPADCIOGMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private PLALMAJACPD GBKOBJGLANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PLALMAJACPD.NBANCJBMIHI* IIGLDGPLJFM;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AGFEFLCLAEJ;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate ONCIGALGDPE;

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x43924F0", Offset = "0x43918F0", VA = "0x1843924F0")]
		internal void JACNCLCPMJH(Entity LCLDFKAJPDK, SplinePointParentData JDJHGHDNLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x43926A0", Offset = "0x4391AA0", VA = "0x1843926A0", Slot = "5")]
		public void ReadFromDisplayClass(ref IEJMOIPJOGL LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x43926B0", Offset = "0x4391AB0", VA = "0x1843926B0", Slot = "6")]
		public void WriteToDisplayClass(ref IEJMOIPJOGL LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x43923E0", Offset = "0x43917E0", VA = "0x1843923E0", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x43925F0", Offset = "0x43919F0", VA = "0x1843925F0")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref PLALMAJACPD.NBANCJBMIHI MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x4392560", Offset = "0x4391960", VA = "0x184392560")]
		public void KMHCJEDMEHN(OBJCKFABAJI LFKHFKIBGCJ, ref IEJMOIPJOGL LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x4392480", Offset = "0x4391880", VA = "0x184392480")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void FEOHLEHDMJK(ArchetypeChunkIterator* JCPGCEEJMGC, void* AIFJMENHIAF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery IEDIFHICGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private ProfilerMarker EGICLJHLCOB;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x29707D0", Offset = "0x296FBD0", VA = "0x1829707D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public OBJCKFABAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x29705A0", Offset = "0x296F9A0", VA = "0x1829705A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x2970440", Offset = "0x296F840", VA = "0x182970440")]
	public static EntityQuery MEILPLGKBIE(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[JGLBKJACABL]
public class FEPOMBPKHOJ : OCHAMNFOLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityQuery NFBGBMJJEHJ;

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD370", Offset = "0x2DDC770", VA = "0x182DDD370", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD400", Offset = "0x2DDC800", VA = "0x182DDD400", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public FEPOMBPKHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(GPLINALFPNN))]
public class LBJDKKJAEHH : KHECDAFCLCI
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x296A6F0", Offset = "0x2969AF0", VA = "0x18296A6F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public LBJDKKJAEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class HKNNNHGIALJ : OCHAMNFOLEM, GBCNOEIKEOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct JMAHJJCKCEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NativeHashMap<KHMECMDAALD, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		public JMAHJJCKCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BFJJELAMMPD : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct ILBBJCNDDGF
		{
			[Cpp2IlInjected.Token(Token = "0x2000168")]
			public struct GIPFBBNJFDA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000470")]
				public LambdaParameterValueProvider_Entity.Runtime FICJNOIKPAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000471")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime GKNFAIPEKPO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity ONBCEAPJNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> DAHODJCGDFM;

			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x4394DB0", Offset = "0x43941B0", VA = "0x184394DB0")]
			public void KMHCJEDMEHN(HKNNNHGIALJ LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x4394E10", Offset = "0x4394210", VA = "0x184394E10")]
			public GIPFBBNJFDA MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
			{
				return default(GIPFBBNJFDA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public NativeHashMap<KHMECMDAALD, Entity> MCHKFDMHGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private ILBBJCNDDGF GBKOBJGLANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ILBBJCNDDGF.GIPFBBNJFDA* IIGLDGPLJFM;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AGFEFLCLAEJ;

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x4391A90", Offset = "0x4390E90", VA = "0x184391A90")]
		internal void JACNCLCPMJH(Entity LCLDFKAJPDK, ObjectNetworkIdComponentData AHJABOIJHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x1372980", Offset = "0x1371D80", VA = "0x181372980", Slot = "5")]
		public void ReadFromDisplayClass(ref JMAHJJCKCEP LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x2026810", Offset = "0x2025C10", VA = "0x182026810", Slot = "6")]
		public void WriteToDisplayClass(ref JMAHJJCKCEP LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x4391980", Offset = "0x4390D80", VA = "0x184391980", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x4391BA0", Offset = "0x4390FA0", VA = "0x184391BA0")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref ILBBJCNDDGF.GIPFBBNJFDA MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x4391B10", Offset = "0x4390F10", VA = "0x184391B10")]
		public void KMHCJEDMEHN(HKNNNHGIALJ LFKHFKIBGCJ, ref JMAHJJCKCEP LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x4391A20", Offset = "0x4390E20", VA = "0x184391A20")]
		public unsafe static void FEOHLEHDMJK(ArchetypeChunkIterator* JCPGCEEJMGC, void* AIFJMENHIAF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private ObjectNetworkToLocalMapService PJFKIMDFNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private EntityQuery IEDIFHICGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private ProfilerMarker EGICLJHLCOB;

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3830", Offset = "0x2DE2C30", VA = "0x182DE3830", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3BF0", Offset = "0x2DE2FF0", VA = "0x182DE3BF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public HKNNNHGIALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x2DE39F0", Offset = "0x2DE2DF0", VA = "0x182DE39F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3890", Offset = "0x2DE2C90", VA = "0x182DE3890")]
	public static EntityQuery MEILPLGKBIE(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public class ANNMOPKLGEN : OCHAMNFOLEM, GBCNOEIKEOL
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct DOEJKFKHJMJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct CGCBGFEBNKC
		{
			[Cpp2IlInjected.Token(Token = "0x200016C")]
			public struct LGNHGFIIFIN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				public LambdaParameterValueProvider_Entity.Runtime FICJNOIKPAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime KCMCMJDLGGP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity ONBCEAPJNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> FBDPMIIPCOA;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x4391DD0", Offset = "0x43911D0", VA = "0x184391DD0")]
			public void KMHCJEDMEHN(ANNMOPKLGEN LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x4391E30", Offset = "0x4391230", VA = "0x184391E30")]
			public LGNHGFIIFIN MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
			{
				return default(LGNHGFIIFIN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public ANNMOPKLGEN DMENDIIOFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private CGCBGFEBNKC GBKOBJGLANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CGCBGFEBNKC.LGNHGFIIFIN* IIGLDGPLJFM;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AGFEFLCLAEJ;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8A50", Offset = "0x2BC7E50", VA = "0x182BC8A50")]
		public void JACNCLCPMJH(Entity LCLDFKAJPDK, ParentData GMGPEPOBPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8970", Offset = "0x2BC7D70", VA = "0x182BC8970", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8AB0", Offset = "0x2BC7EB0", VA = "0x182BC8AB0")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref CGCBGFEBNKC.LGNHGFIIFIN MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8A70", Offset = "0x2BC7E70", VA = "0x182BC8A70")]
		public void KMHCJEDMEHN(ANNMOPKLGEN LFKHFKIBGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x2BC89E0", Offset = "0x2BC7DE0", VA = "0x182BC89E0")]
		public unsafe static void FEOHLEHDMJK(ArchetypeChunkIterator* JCPGCEEJMGC, void* AIFJMENHIAF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private EntityQuery IEDIFHICGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private ProfilerMarker EGICLJHLCOB;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x2FADF80", Offset = "0x2FAD380", VA = "0x182FADF80", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x2FAE530", Offset = "0x2FAD930", VA = "0x182FAE530", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public ANNMOPKLGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2FADFE0", Offset = "0x2FAD3E0", VA = "0x182FADFE0")]
	[CompilerGenerated]
	private void LHDJPMBKDMA(Entity LCLDFKAJPDK, ParentData GMGPEPOBPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x2FAE330", Offset = "0x2FAD730", VA = "0x182FAE330", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x2FAE1D0", Offset = "0x2FAD5D0", VA = "0x182FAE1D0")]
	public static EntityQuery MEILPLGKBIE(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class PDIINLCNDBJ : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private int MAINMEJANEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EntityQuery ANBHGOBNOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private ObjectPrefabs IIPJHFKNDGJ;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x297FE70", Offset = "0x297F270", VA = "0x18297FE70", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x2980260", Offset = "0x297F660", VA = "0x182980260", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x2980340", Offset = "0x297F740", VA = "0x182980340", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x297FEC0", Offset = "0x297F2C0", VA = "0x18297FEC0")]
	private void HMMEMOBNCMI(Entity LCLDFKAJPDK, GODNFBOIBNJ KLFAINNONJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public PDIINLCNDBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Serialization)]
	[UpdateBefore(typeof(PDIINLCNDBJ))]
	public class PostLoadAddSceneTagEntity : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private SceneService EDPMKCELNON;

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x29852F0", Offset = "0x29846F0", VA = "0x1829852F0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x2985340", Offset = "0x2984740", VA = "0x182985340", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[OKPMAHGBOHA(IKIGKMLBEFF.OMRoom)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Serialization)]
	public class PostLoadInitializeNetworkId : KHECDAFCLCI, GBCNOEIKEOL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct AIGBJEEFACO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public NativeHashMap<KHMECMDAALD, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
			public AIGBJEEFACO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct FMDAIKLDDND : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000172")]
			private struct AHAENJOOACO
			{
				[Cpp2IlInjected.Token(Token = "0x2000173")]
				[NoAlias]
				public struct OCLCOLFPIOF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000491")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime FICJNOIKPAH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000492")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime NHDJFALCDCL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000493")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime GKNFAIPEKPO;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400048E")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity ONBCEAPJNBD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400048F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex CBLGKCGNCDG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000490")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> DAHODJCGDFM;

				[Cpp2IlInjected.Token(Token = "0x6000A32")]
				[Cpp2IlInjected.Address(RVA = "0x43907D0", Offset = "0x438FBD0", VA = "0x1843907D0")]
				public void KMHCJEDMEHN(PostLoadInitializeNetworkId LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x4390840", Offset = "0x438FC40", VA = "0x184390840")]
				public OCLCOLFPIOF MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
				{
					return default(OCLCOLFPIOF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public NativeHashMap<KHMECMDAALD, Entity> MCHKFDMHGLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private AHAENJOOACO GBKOBJGLANO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe AHAENJOOACO.OCLCOLFPIOF* IIGLDGPLJFM;

			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AGFEFLCLAEJ;

			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate ONCIGALGDPE;

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x43932D0", Offset = "0x43926D0", VA = "0x1843932D0")]
			internal void JACNCLCPMJH(Entity LCLDFKAJPDK, int AOIHDODPBAH, ref ObjectNetworkIdComponentData AHJABOIJHEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x1372980", Offset = "0x1371D80", VA = "0x181372980", Slot = "5")]
			public void ReadFromDisplayClass(ref AIGBJEEFACO LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x2026810", Offset = "0x2025C10", VA = "0x182026810", Slot = "6")]
			public void WriteToDisplayClass(ref AIGBJEEFACO LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x4393170", Offset = "0x4392570", VA = "0x184393170", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x4393400", Offset = "0x4392800", VA = "0x184393400")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref AHAENJOOACO.OCLCOLFPIOF MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x4393360", Offset = "0x4392760", VA = "0x184393360")]
			public void KMHCJEDMEHN(PostLoadInitializeNetworkId LFKHFKIBGCJ, ref AIGBJEEFACO LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x4393260", Offset = "0x4392660", VA = "0x184393260")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void FEOHLEHDMJK(ArchetypeChunkIterator* JCPGCEEJMGC, void* AIFJMENHIAF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[OMAMNFHDGBM]
		private ObjectNetworkToLocalMapService PJFKIMDFNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		[OMAMNFHDGBM]
		private SceneService OOCMFKEPGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery ANBHGOBNOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EntityQuery ONIEJOBBKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private ProfilerMarker PCNPKLNGMCD;

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x2985D00", Offset = "0x2985100", VA = "0x182985D00", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x2986270", Offset = "0x2985670", VA = "0x182986270", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2986310", Offset = "0x2985710", VA = "0x182986310", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2985D70", Offset = "0x2985170", VA = "0x182985D70")]
		public void MJCNCJPGIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2985550", Offset = "0x2984950", VA = "0x182985550")]
		private void BGNEADEJGDP(NativeHashMap<KHMECMDAALD, Entity> MCHKFDMHGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2985AA0", Offset = "0x2984EA0", VA = "0x182985AA0")]
		private void FAGLOLIJHKB(NativeHashMap<KHMECMDAALD, Entity> MCHKFDMHGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2985FE0", Offset = "0x29853E0", VA = "0x182985FE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2985E40", Offset = "0x2985240", VA = "0x182985E40")]
		public static EntityQuery MLADAFBCBNK(ComponentSystemBase LFKHFKIBGCJ)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class JPMEMIFMBML : KHECDAFCLCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery GFJMAJDHGOE;

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x2DF22C0", Offset = "0x2DF16C0", VA = "0x182DF22C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2350", Offset = "0x2DF1750", VA = "0x182DF2350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public JPMEMIFMBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public class BGEHHCGMNJJ : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::EILPMGINBJG<FGEMEIPGJHN> LCAKNGGMCFC;

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x2FB0590", Offset = "0x2FAF990", VA = "0x182FB0590", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2FB0E90", Offset = "0x2FB0290", VA = "0x182FB0E90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2FB0630", Offset = "0x2FAFA30", VA = "0x182FB0630")]
	private void IICPADHKKEM(NativeList<EntityArchetype> NOKEICPGEDG, NativeHashMap<int, JAPIHNFIDBB> OHDGELKDLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x2FB0450", Offset = "0x2FAF850", VA = "0x182FB0450")]
	private Span<int> DMOJKOIIBNL(EntityArchetype NCPPLDKIKPK)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2FB07C0", Offset = "0x2FAFBC0", VA = "0x182FB07C0")]
	private bool LNPFKNKDNIM(int ODMCPPPIBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x2FB0890", Offset = "0x2FAFC90", VA = "0x182FB0890")]
	private void MNPJCMKKDKA(NativeHashMap<int, JAPIHNFIDBB> OHDGELKDLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public BGEHHCGMNJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Serialization)]
	public class PreSerializeRemoveEntities : KHECDAFCLCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private EntityQuery PAFKEIFANBA;

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x2986370", Offset = "0x2985770", VA = "0x182986370", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x29865F0", Offset = "0x29859F0", VA = "0x1829865F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[JEGJCCBDMOE(OLCAJGBKOGB.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : KHECDAFCLCI, GBCNOEIKEOL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[CompilerGenerated]
		private struct BGMFLFHPBOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public ComponentDataFromEntity dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
			public BGMFLFHPBOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC8FB0", VA = "0x182BC9BB0")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct MLHJLEFNBMM : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[ReadOnly]
			public NativeList<int> JDFBPHJNCCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			[ReadOnly]
			public NativeArray<Entity> KKBMAODLFPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public ComponentDataFromEntity EHCJKODKCOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			[ReadOnly]
			public NativeArray<byte> IECLCEDGDAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public int LPECOOCMGPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public ComponentType KCEEKGALKFC;

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x4397520", Offset = "0x4396920", VA = "0x184397520")]
			internal void JACNCLCPMJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x4397700", Offset = "0x4396B00", VA = "0x184397700", Slot = "5")]
			public void ReadFromDisplayClass(ref BGMFLFHPBOL LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x4397510", Offset = "0x4396910", VA = "0x184397510", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x43976E0", Offset = "0x4396AE0", VA = "0x1843976E0")]
			public void KMHCJEDMEHN(ShadowWorldApplyPropertyDifferencesToShadowWorld LFKHFKIBGCJ, ref BGMFLFHPBOL LNLMJEFNJAK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private PropertyDiffStateService AMGEMOKKAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private JobHandle ENCDFFONANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private JobHandle EIEALJDDMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private KIPPNPAOMDE OJNFGJAPBNC;

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2EA0", Offset = "0x2BD22A0", VA = "0x182BD2EA0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2BD35B0", Offset = "0x2BD29B0", VA = "0x182BD35B0")]
		public JobHandle PFDCJAJGMKJ(JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3210", Offset = "0x2BD2610", VA = "0x182BD3210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2F00", Offset = "0x2BD2300", VA = "0x182BD2F00")]
		private bool MBPGIKKDKCG(JobHandle ELLADMEAHLJ, int ODMCPPPIBBH, out JobHandle NEKDMAACJDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[NDAPPBGAMDM]
[ExecuteAlways]
[UpdateInGroup(typeof(FINEFFIBJOC))]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
internal sealed class POAONHOIGAB : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x2981330", Offset = "0x2980730", VA = "0x182981330", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public POAONHOIGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[NDAPPBGAMDM]
[ExecuteAlways]
[UpdateInGroup(typeof(HMOJICADFJI))]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
internal sealed class BMOFBIMGGJM : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x2FB27A0", Offset = "0x2FB1BA0", VA = "0x182FB27A0", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public BMOFBIMGGJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[NDAPPBGAMDM]
[ExecuteAlways]
[UpdateInGroup(typeof(JEJGIJMBBJC))]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
internal sealed class NGPMJPMOHGP : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x296E5F0", Offset = "0x296D9F0", VA = "0x18296E5F0", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public NGPMJPMOHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[NDAPPBGAMDM]
[ExecuteAlways]
[UpdateInGroup(typeof(MAPEDCOMLFB))]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
internal sealed class MNCHCDHIHID : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x296DD30", Offset = "0x296D130", VA = "0x18296DD30", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public MNCHCDHIHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class AKEOGAPEAAP : KAADPHHJBDD
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override IECIGCFEBBH FHEEODAALOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x73B4E0", Offset = "0x73A8E0", VA = "0x18073B4E0", Slot = "18")]
		get
		{
			return default(IECIGCFEBBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC7B0", Offset = "0x2FABBB0", VA = "0x182FAC7B0")]
	public AKEOGAPEAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[NDAPPBGAMDM]
[ExecuteAlways]
[UpdateInGroup(typeof(CPNGMNNGNAD))]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
internal sealed class AMNHJHGAIAF : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD760", Offset = "0x2FACB60", VA = "0x182FAD760", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public AMNHJHGAIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class IDGLDKHPCOC : LLPKLCJBNBL
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public IDGLDKHPCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class KLMPJIOHGKL : KAADPHHJBDD
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override IECIGCFEBBH FHEEODAALOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "18")]
		get
		{
			return default(IECIGCFEBBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public KLMPJIOHGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[NDAPPBGAMDM]
[ExecuteAlways]
[UpdateInGroup(typeof(NEKDNJJLLHF))]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
internal sealed class CGLJFPNEMAD : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5970", Offset = "0x2FB4D70", VA = "0x182FB5970", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public CGLJFPNEMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class JEEDCDDFIAH : LLPKLCJBNBL
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public JEEDCDDFIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class HCMDGBKLNFM : LLPKLCJBNBL
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public HCMDGBKLNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class NBDEPOOOIKG : KHECDAFCLCI
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public NBDEPOOOIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[JGLBKJACABL]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
public class ELCGEJIHCPC : KHECDAFCLCI, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private TimeService BMDOHFOEMDB;

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9830", Offset = "0x2FC8C30", VA = "0x182FC9830", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9880", Offset = "0x2FC8C80", VA = "0x182FC9880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public ELCGEJIHCPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.TransformSyncing)]
	public class CopyTransformDataFromGameObjects : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		private struct DINMGBMDGBJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private const float EPKGBDFGEJH = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			[ReadOnly]
			public NativeArray<Entity> ABBIPALBHCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> GMAFIDNKMBL;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8140", Offset = "0x2BC7540", VA = "0x182BC8140", Slot = "4")]
			public void Execute(int EGNHJGKABLC, TransformAccess CACALPHNCBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8370", Offset = "0x2BC7770", VA = "0x182BC8370")]
			private bool PKIKFJJNMEI(float3 JFNADPGFOAB, float3 DKOFAPECACL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8300", Offset = "0x2BC7700", VA = "0x182BC8300")]
			private bool IFCIJIEIELH(quaternion JFNADPGFOAB, quaternion DKOFAPECACL)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile]
		private struct CLGLHAANHHK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			[ReadOnly]
			public NativeArray<Entity> ABBIPALBHCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> JLEGLCPOIHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> DDFIKFADEEB;

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x2BC79A0", Offset = "0x2BC6DA0", VA = "0x182BC79A0", Slot = "4")]
			public void Execute(int EGNHJGKABLC, TransformAccess CACALPHNCBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly KLBHBMBPLOA OIDNLPLMKPP;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly KLBHBMBPLOA FCCGGIMCHAM;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private static readonly KLBHBMBPLOA NAIMBIJGKDL;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private static readonly ProfilerMarker AEIIPEMFLAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private NOGNNNFDDDD GCGLMMIFJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private BHHDNNCMGLM GHDOFHADNOC;

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0740", Offset = "0x2FBFB40", VA = "0x182FC0740", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC07B0", Offset = "0x2FBFBB0", VA = "0x182FC07B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x2FC07E0", Offset = "0x2FBFBE0", VA = "0x182FC07E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[JEGJCCBDMOE(OLCAJGBKOGB.TransformSyncing)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	public class RegisterTransforms : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct PLALDBMJKCE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct MMLKEAKDDLA
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				public struct KFKOLCLDFGJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004CA")]
					public LambdaParameterValueProvider_Entity.Runtime FICJNOIKPAH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004CB")]
					public LambdaParameterValueProvider_IComponentData<FCKMCCGOFNE>.Runtime MGHNFKEBEON;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004CC")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime CGNNCNMBJDM;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004C7")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity ONBCEAPJNBD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<FCKMCCGOFNE> JEIEOGJCCDI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> KEGMEHMFDEA;

				[Cpp2IlInjected.Token(Token = "0x6000A9D")]
				[Cpp2IlInjected.Address(RVA = "0x43979E0", Offset = "0x4396DE0", VA = "0x1843979E0")]
				public void KMHCJEDMEHN(RegisterTransforms LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x4397A60", Offset = "0x4396E60", VA = "0x184397A60")]
				public KFKOLCLDFGJ MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
				{
					return default(KFKOLCLDFGJ);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private MMLKEAKDDLA GBKOBJGLANO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe MMLKEAKDDLA.KFKOLCLDFGJ* IIGLDGPLJFM;

			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AGFEFLCLAEJ;

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0x439BC60", Offset = "0x439B060", VA = "0x18439BC60")]
			internal void JACNCLCPMJH(Entity LCLDFKAJPDK, FCKMCCGOFNE HJEGHEJBGPH, Transform CACALPHNCBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x439BB00", Offset = "0x439AF00", VA = "0x18439BB00", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x439BD70", Offset = "0x439B170", VA = "0x18439BD70")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref MMLKEAKDDLA.KFKOLCLDFGJ MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x439BD60", Offset = "0x439B160", VA = "0x18439BD60")]
			public void KMHCJEDMEHN(RegisterTransforms LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x439BBF0", Offset = "0x439AFF0", VA = "0x18439BBF0")]
			public unsafe static void FEOHLEHDMJK(ArchetypeChunkIterator* JCPGCEEJMGC, void* AIFJMENHIAF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LEPBMJCOGIN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000190")]
			private struct JDOKOGBDNNI
			{
				[Cpp2IlInjected.Token(Token = "0x2000191")]
				[NoAlias]
				public struct GHCMOJPLBKO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004D1")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime FICJNOIKPAH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004D2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<FCKMCCGOFNE>.Runtime MGHNFKEBEON;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004CF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity ONBCEAPJNBD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004D0")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<FCKMCCGOFNE> JEIEOGJCCDI;

				[Cpp2IlInjected.Token(Token = "0x6000AA3")]
				[Cpp2IlInjected.Address(RVA = "0x4394E90", Offset = "0x4394290", VA = "0x184394E90")]
				public void KMHCJEDMEHN(RegisterTransforms LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x4394EF0", Offset = "0x43942F0", VA = "0x184394EF0")]
				public GHCMOJPLBKO MJBOEEFIAOC(ref ArchetypeChunk JFIBFLBEMLK, int NMEBKNJKPKL, int LLKMMCPHHFF)
				{
					return default(GHCMOJPLBKO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private JDOKOGBDNNI GBKOBJGLANO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JDOKOGBDNNI.GHCMOJPLBKO* IIGLDGPLJFM;

			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x43964C0", Offset = "0x43958C0", VA = "0x1843964C0")]
			internal void JACNCLCPMJH(Entity LCLDFKAJPDK, FCKMCCGOFNE HJEGHEJBGPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x4396430", Offset = "0x4395830", VA = "0x184396430", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x43965A0", Offset = "0x43959A0", VA = "0x1843965A0")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref JDOKOGBDNNI.GHCMOJPLBKO MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x4394E90", Offset = "0x4394290", VA = "0x184394E90")]
			public void KMHCJEDMEHN(RegisterTransforms LFKHFKIBGCJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private NOGNNNFDDDD GCGLMMIFJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private EntityQuery MOPKBHIBONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityQuery IKPNLOEIKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private EntityQuery CFJHAIEIKON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private EntityQuery NPMKCIFBFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private EntityQuery GINCCDPLFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private ProfilerMarker EJLAILJCOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private EntityQuery BMAECOKDNJK;

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC460", Offset = "0x2BCB860", VA = "0x182BCC460", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCD10", Offset = "0x2BCC110", VA = "0x182BCCD10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCF20", Offset = "0x2BCC320", VA = "0x182BCCF20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC860", Offset = "0x2BCBC60", VA = "0x182BCC860")]
		private void NCLJCHLPHLA(EntityQuery ANBHGOBNOFE, HIEGLBAPNMB GPFPPMDAEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC0B0", Offset = "0x2BCB4B0", VA = "0x182BCC0B0")]
		private void DIHFPACHJPD(EntityQuery ANBHGOBNOFE, HIEGLBAPNMB GPFPPMDAEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCEC0", Offset = "0x2BCC2C0", VA = "0x182BCCEC0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC320", Offset = "0x2BCB720", VA = "0x182BCC320")]
		private void EKDHEIDHMJO(NativeArray<Entity> ABBIPALBHCK, HIEGLBAPNMB GPFPPMDAEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBC00", Offset = "0x2BCB000", VA = "0x182BCBC00")]
		[BurstCompile]
		internal static void CLMNFPBKGPG(NativeArray<FCKMCCGOFNE> EPFCCIEGCBE, ComponentDataFromEntity<FCKMCCGOFNE> ACEEBHDOPPF, HIEGLBAPNMB GPFPPMDAEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		private static void MPMGKKFBPMB(Transform CACALPHNCBH, Entity LCLDFKAJPDK, int EGNHJGKABLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		private static void CBAHHKDKLHN(Entity LCLDFKAJPDK, int EGNHJGKABLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		private static void JIJINPIFOGF(int EGNHJGKABLC, HIEGLBAPNMB GPFPPMDAEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC4B0", Offset = "0x2BCB8B0", VA = "0x182BCC4B0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void MGGJNOKKAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCAA0", Offset = "0x2BCBEA0", VA = "0x182BCCAA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBF10", Offset = "0x2BCB310", VA = "0x182BCBF10")]
		public static EntityQuery DDAGGAOCIEH(ComponentSystemBase LFKHFKIBGCJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC690", Offset = "0x2BCBA90", VA = "0x182BCC690")]
		public static EntityQuery NALOEKKGAEJ(ComponentSystemBase LFKHFKIBGCJ)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	[JEGJCCBDMOE(OLCAJGBKOGB.TransformSyncing)]
	public class CopyTransformDataToGameObjects : KHECDAFCLCI, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[BurstCompile]
		private struct KAHNOIOMGIM : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> GMAFIDNKMBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			[ReadOnly]
			public NativeArray<Entity> ABBIPALBHCK;

			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA680", Offset = "0x2BC9A80", VA = "0x182BCA680", Slot = "4")]
			public void Execute(int EGNHJGKABLC, TransformAccess CACALPHNCBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[BurstCompile]
		private struct BFEHOGLIPKF : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> JLEGLCPOIHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public NativeArray<Entity> ABBIPALBHCK;

			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x2BC72B0", Offset = "0x2BC66B0", VA = "0x182BC72B0", Slot = "4")]
			public void Execute(int EGNHJGKABLC, TransformAccess CACALPHNCBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct PBEGCAJIHOF : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> JLEGLCPOIHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> DDFIKFADEEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			[ReadOnly]
			public NativeArray<Entity> ABBIPALBHCK;

			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBB00", Offset = "0x2BCAF00", VA = "0x182BCBB00", Slot = "4")]
			public void Execute(int EGNHJGKABLC, TransformAccess CACALPHNCBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly KLBHBMBPLOA OIDNLPLMKPP;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly KLBHBMBPLOA FCCGGIMCHAM;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private static readonly KLBHBMBPLOA NAIMBIJGKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private NOGNNNFDDDD GCGLMMIFJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private EntityQuery PKCHDICFNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EntityQuery HOEBOGLNHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private EntityQuery DIMBKMDKKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TransformAccessArray PGFMDNNIJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TransformAccessArray BFOELELHJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TransformAccessArray LMIKDDPKKHF;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0E10", Offset = "0x2FC0210", VA = "0x182FC0E10", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0E60", Offset = "0x2FC0260", VA = "0x182FC0E60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1050", Offset = "0x2FC0450", VA = "0x182FC1050", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x2FC10E0", Offset = "0x2FC04E0", VA = "0x182FC10E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1110", Offset = "0x2FC0510", VA = "0x182FC1110", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0C90", Offset = "0x2FC0090", VA = "0x182FC0C90")]
		private NativeArray<Entity> FKFMDGIJMFB(NativeArray<FCKMCCGOFNE> JDFBPHJNCCJ, NativeList<Entity> JILBKCFLHPF, TransformAccessArray MAJCINIPNKO, TransformAccessArray BHHALGBFGOI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[JEGJCCBDMOE(OLCAJGBKOGB.TransformSyncing)]
	[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
	public class CopyTransformParentsToGameObjects : KHECDAFCLCI, IJGJDJPFIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private IMDHGBFPAOD IILMLAIBNCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private HBFGHIOELIO OFLALIMFMPN;

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x29869B0", Offset = "0x2985DB0", VA = "0x1829869B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1C60", Offset = "0x2FC1060", VA = "0x182FC1C60", Slot = "14")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1D70", Offset = "0x2FC1170", VA = "0x182FC1D70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1A40", Offset = "0x2FC0E40", VA = "0x182FC1A40")]
		private static void APLEKHBAIEH(EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Entity GGEKFPEBLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1BC0", Offset = "0x2FC0FC0", VA = "0x182FC1BC0")]
		private static bool KGFFBHKEPBA(EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, out Transform CACALPHNCBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[JEGJCCBDMOE(OLCAJGBKOGB.TransformSyncing)]
	public class L2PToL2WHierarchy : KHECDAFCLCI
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[BurstCompile]
		private struct PJCCGJGFPNH : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> HPCIJNCMLCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> MJFIMKOFKFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> FEBAJELDMCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> CPOLMBIPLCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public ArchetypeChunkComponentType<LocalToWorldData> HFIJNJBGPPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> FJHOHCHGGCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public uint AGMHPLEHLFG;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x439A310", Offset = "0x4399710", VA = "0x18439A310")]
			[Conditional("DEBUG_BUILD")]
			private void MANEPGOHPFN(Entity LCLDFKAJPDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x439A020", Offset = "0x4399420", VA = "0x18439A020", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int EGNHJGKABLC, int OLEGPGLEHEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x439A3E0", Offset = "0x43997E0", VA = "0x18439A3E0")]
			private void NIMPODIBFNE(float4x4 FIBKIACEBAE, Entity LCLDFKAJPDK, bool EBHFJOOGEHI, int GDPPOOAONKL = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery NONEKIBDKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private EntityQuery MCDKIDCNDKN;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x2969C90", Offset = "0x2969090", VA = "0x182969C90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x2969DB0", Offset = "0x29691B0", VA = "0x182969DB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class LAHBGKACFGB : CJKBCGBAKBI
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[BurstCompile]
	private struct BKFHCNGIDNB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> HPCIJNCMLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ArchetypeChunkComponentType<LocalToWorldData> HFIJNJBGPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public uint AGMHPLEHLFG;

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x4391CD0", Offset = "0x43910D0", VA = "0x184391CD0", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int EGNHJGKABLC, int OLEGPGLEHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x4391C50", Offset = "0x4391050", VA = "0x184391C50")]
		public bool DMLNPENFHLB(ArchetypeChunk ONPLFJPHGKJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery NONEKIBDKLA;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x296A480", Offset = "0x2969880", VA = "0x18296A480", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x296A5B0", Offset = "0x29699B0", VA = "0x18296A5B0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PEGJJCPFDDP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public LAHBGKACFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class CADODBIICJP : CJKBCGBAKBI
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct CLKDLFPNHNA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> GPBHAHIADEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public ArchetypeChunkComponentType<WorldPoseData> PHFLONDKLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> INABJFMCMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> DJIANMGDBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public uint AGMHPLEHLFG;

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7C40", Offset = "0x2BC7040", VA = "0x182BC7C40", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int EGNHJGKABLC, int OLEGPGLEHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7BC0", Offset = "0x2BC6FC0", VA = "0x182BC7BC0")]
		public bool DMLNPENFHLB(ArchetypeChunk ONPLFJPHGKJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery HFKINOFBOBG;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x2FB48C0", Offset = "0x2FB3CC0", VA = "0x182FB48C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x2FB49D0", Offset = "0x2FB3DD0", VA = "0x182FB49D0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PEGJJCPFDDP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public CADODBIICJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public class EILNAOCAPHL : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct GIPPGKMEGDG : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> JNHEBAMNPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> AOLODICIDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> DBLPDFHEBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public ArchetypeChunkComponentType<LocalToParentData> ELABECNFKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public uint AGMHPLEHLFG;

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC94A0", Offset = "0x2BC88A0", VA = "0x182BC94A0", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int EGNHJGKABLC, int OLEGPGLEHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC93C0", Offset = "0x2BC87C0", VA = "0x182BC93C0")]
		public bool DMLNPENFHLB(ArchetypeChunk ONPLFJPHGKJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery HFKINOFBOBG;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9340", Offset = "0x2FC8740", VA = "0x182FC9340", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9470", Offset = "0x2FC8870", VA = "0x182FC9470", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PEGJJCPFDDP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
	public EILNAOCAPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[JEGJCCBDMOE(OLCAJGBKOGB.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : IMFEAONBJNA
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		public struct DFADNLOMDMM : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		protected override ComponentType JAHEBDOFOME
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x29873C0", Offset = "0x29867C0", VA = "0x1829873C0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType EPMEBHFHEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x2987420", Offset = "0x2986820", VA = "0x182987420", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType HCFNJFHMEDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x29873F0", Offset = "0x29867F0", VA = "0x1829873F0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2987320", Offset = "0x2986720", VA = "0x182987320")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[DLJAHAIEDHD(BFEMEIIIFID.Game)]
public class EAENJOCDJAP : DAFHCDFAPLO
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type ODEEJHODFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2FC82D0", Offset = "0x2FC76D0", VA = "0x182FC82D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] OOKOOBEKHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7C60", Offset = "0x2FC7060", VA = "0x182FC7C60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public EAENJOCDJAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[DLJAHAIEDHD(BFEMEIIIFID.Loading)]
public class IGJDHNEKPCL : DAFHCDFAPLO
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type ODEEJHODFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] OOKOOBEKHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9BC0", Offset = "0x2DE8FC0", VA = "0x182DE9BC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public IGJDHNEKPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class KGJNNENIMHE : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2F70", Offset = "0x2DF2370", VA = "0x182DF2F70", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public KGJNNENIMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[DLJAHAIEDHD(BFEMEIIIFID.Saving)]
public class HHCKMKBLANE : DAFHCDFAPLO
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type ODEEJHODFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] OOKOOBEKHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2D30", Offset = "0x2DE2130", VA = "0x182DE2D30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public HHCKMKBLANE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class FMIKHLJEPIB : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE0A0", Offset = "0x2DDD4A0", VA = "0x182DDE0A0", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public FMIKHLJEPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[DLJAHAIEDHD(BFEMEIIIFID.Simulation)]
public class FIIPPCOMGCG : DAFHCDFAPLO
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public Type ODEEJHODFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x2DDDEF0", Offset = "0x2DDD2F0", VA = "0x182DDDEF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] OOKOOBEKHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x2DDDB40", Offset = "0x2DDCF40", VA = "0x182DDDB40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public FIIPPCOMGCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[HAMPPOKOPOP(typeof(DPAGHCJLPGM), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
internal class DPAGHCJLPGM : IJGJDJPFIAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private global::LHALHIEHJOK<AuthoredParentData, OFDDALEFPDF, IOKCFDFGMOK, AuthoredChildrenData> BHFGJPOBPBE;

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6660", Offset = "0x2FC5A60", VA = "0x182FC6660", Slot = "4")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public DPAGHCJLPGM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	[HAMPPOKOPOP(typeof(EntityHierarchyParents), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.HierarchySystems)]
	internal sealed class EntityHierarchyParents : GBCNOEIKEOL, IJGJDJPFIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[OMAMNFHDGBM]
		private AMBNPJKGCOF HFKINOFBOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[OMAMNFHDGBM]
		private PropertyChangeNetworkRouter NBEGIFPAGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private global::CEGMBHOPAIF<Entity> GJEJKJANAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private global::LHALHIEHJOK<ParentData, KLGHMJKGANI, BGCCCKOCKHF, ChildrenData> BHFGJPOBPBE;

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9C60", Offset = "0x2DD9060", VA = "0x182DD9C60", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9D30", Offset = "0x2DD9130", VA = "0x182DD9D30", Slot = "5")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA010", Offset = "0x2DD9410", VA = "0x182DDA010")]
		public Entity NGLDHLBMECO(Entity LCLDFKAJPDK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9CD0", Offset = "0x2DD90D0", VA = "0x182DD9CD0")]
		public bool LGLAJNBPHCD(Entity LCLDFKAJPDK, Entity BJNIPOLNMLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9BC0", Offset = "0x2DD8FC0", VA = "0x182DD9BC0")]
		public bool DEIBNNOCJKC(Entity LCLDFKAJPDK, Entity BJNIPOLNMLD, bool NFCHCDFCFMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9E30", Offset = "0x2DD9230", VA = "0x182DD9E30")]
		private bool MJCAIGLJGIG(Entity LCLDFKAJPDK, Entity BJNIPOLNMLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
[HAMPPOKOPOP(typeof(AMBCMIPCLOI), new string[] { })]
internal sealed class AMBCMIPCLOI : GBCNOEIKEOL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	[OMAMNFHDGBM]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery DDECEPCAGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private EntityManager BFILENFCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x2FAD550", Offset = "0x2FAC950", VA = "0x182FAD550")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD200", Offset = "0x2FAC600", VA = "0x182FAD200", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD050", Offset = "0x2FAC450", VA = "0x182FAD050", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD140", Offset = "0x2FAC540", VA = "0x182FAD140")]
	public bool FFKLPDDAEHN(Entity LCLDFKAJPDK, Entity NLBEDCCLIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x2FACF90", Offset = "0x2FAC390", VA = "0x182FACF90")]
	public IEnumerable<Entity> CMGIHGILOAF(Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD300", Offset = "0x2FAC700", VA = "0x182FAD300")]
	public bool HMKPBKJMFKD(Entity LCLDFKAJPDK, Entity ILLPMKANGKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD5A0", Offset = "0x2FAC9A0", VA = "0x182FAD5A0")]
	public bool NBCMHKFAKCC(Entity LCLDFKAJPDK, Entity AGDKLNJDAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD470", Offset = "0x2FAC870", VA = "0x182FAD470")]
	public NativeList<Entity> JCKMNEBEMBO(Entity LCLDFKAJPDK, bool PNGNAFIFALL = false, Allocator FKHAEPDPDAI = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x2FACED0", Offset = "0x2FAC2D0", VA = "0x182FACED0")]
	public IEnumerable<Entity> CEAEBLDPEEN(Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD660", Offset = "0x2FACA60", VA = "0x182FAD660")]
	public Entity NKAKDLGIEDI(Entity LCLDFKAJPDK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD710", Offset = "0x2FACB10", VA = "0x182FAD710")]
	public NativeArray<Entity> PADFFCJKHOD()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD070", Offset = "0x2FAC470", VA = "0x182FAD070")]
	public bool EDCKHKPPKHK(Entity AGDKLNJDAPF, Entity NMPDJFDFMIN, out Entity NFENBCEFMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD3C0", Offset = "0x2FAC7C0", VA = "0x182FAD3C0")]
	private Entity IJHIFONNBOI(Entity LCLDFKAJPDK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public AMBCMIPCLOI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[JEGJCCBDMOE(OLCAJGBKOGB.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F320", Offset = "0x2D0E720", VA = "0x182D0F320")]
		public static void GJPLHHGHDFM<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(FJEOEPCCLME JGMMDACFJLC, global::OBMHIPHOPOO<Entity> IHNHAGGGBIH, out global::LHALHIEHJOK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> MJCHNIAODLH) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, JJCEHBPPLLO where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, JJCEHBPPLLO, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x29817C0", Offset = "0x2980BC0", VA = "0x1829817C0")]
		public static bool FDBGCBDJFAH(EMFDOJECCDF KANBPIJHFNA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class LHALHIEHJOK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, JJCEHBPPLLO where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, JJCEHBPPLLO, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly KLBHBMBPLOA JFFPIFJCILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private readonly BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private readonly global::CEGMBHOPAIF<Entity> GJEJKJANAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private readonly ONJBKOIKDCG HBPMPMKJOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private readonly LEDNIENHLNM GGEKFPEBLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly EntityManager MABCFMECCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private readonly HBFGHIOELIO OFLALIMFMPN;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x33CC790", Offset = "0x33CBB90", VA = "0x1833CC790")]
	public LHALHIEHJOK(FJEOEPCCLME JGMMDACFJLC, global::OBMHIPHOPOO<Entity> IHNHAGGGBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x33CC160", Offset = "0x33CB560", VA = "0x1833CC160")]
	private bool FCAKMAPDICF(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x334A6A0", Offset = "0x3349AA0", VA = "0x18334A6A0")]
	private bool CNHODMGHFJP(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x334AAE0", Offset = "0x3349EE0", VA = "0x18334AAE0")]
	public bool LGLAJNBPHCD(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x334B150", Offset = "0x334A550", VA = "0x18334B150")]
	public bool MEAILOEIHJH(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x334AD10", Offset = "0x334A110", VA = "0x18334AD10")]
	private bool MEAILOEIHJH(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD, bool KDJOAFGCAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void PHFLMNLHLLF(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void GLLDFBLNOAA(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void INBEDGMAHFC(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void CCHNFLOIMCF(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void KHEEEKLEONJ(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x33CC1C0", Offset = "0x33CB5C0", VA = "0x1833CC1C0")]
	private bool FFKLPDDAEHN(Entity LCLDFKAJPDK, Entity NLBEDCCLIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x334A960", Offset = "0x3349D60", VA = "0x18334A960")]
	private void FMLGJONEGLB(Entity LCLDFKAJPDK, in Entity LOFGAAGHIJI, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x33CC530", Offset = "0x33CB930", VA = "0x1833CC530")]
	private void PIALGDMPBFM(Entity LCLDFKAJPDK, in Entity LOFGAAGHIJI, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x33CC330", Offset = "0x33CB730", VA = "0x1833CC330")]
	private bool MAICBACFIKK(FAPEEHIPGCB NNDGEEDPDKD, in KHMECMDAALD OJPJGALEFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x334A830", Offset = "0x3349C30", VA = "0x18334A830")]
	private void FHJPDJCNJIO(Entity GGEKFPEBLKN, Entity ILLPMKANGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x33CC2A0", Offset = "0x33CB6A0", VA = "0x1833CC2A0")]
	private void LBIPGKKJCGE(Entity GGEKFPEBLKN, Entity ILLPMKANGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private void JIJINPIFOGF(Entity LCLDFKAJPDK, Entity LOFGAAGHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private void MPMGKKFBPMB(Entity LCLDFKAJPDK, Entity BJNIPOLNMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct CLLGJLBHHLK : NIJKBPKBPOC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public GELFNNAOOFF PIBPGDOMAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x74C840", Offset = "0x74BC40", VA = "0x18074C840", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GELFNNAOOFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x7838F0", Offset = "0x782CF0", VA = "0x1807838F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[HAMPPOKOPOP(typeof(ObjectEmbodimentService), new string[] { })]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	[JEGJCCBDMOE(OLCAJGBKOGB.Embodiment)]
	internal sealed class ObjectEmbodimentService : HBEOAMPLBKH, BJDLFHICAGD, GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private ObjectLifecycleService LCMHIEKJLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[OMAMNFHDGBM]
		private AMBNPJKGCOF HFKINOFBOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		[OMAMNFHDGBM]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[OMAMNFHDGBM]
		private FBCAFMCBMPK GOBBGGBLGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[OMAMNFHDGBM]
		private NBFPIMPGEPM JNMOAKAELEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[OMAMNFHDGBM]
		private TransformOwnershipPhase HJGAFKLFBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private readonly Dictionary<KHMECMDAALD, APKFPLGDLPH> OAOIEIBJBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private EMAMPNJOLBK NJJLFKMJCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x2975B90", Offset = "0x2974F90", VA = "0x182975B90")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int LBGJAHIFKCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x29752E0", Offset = "0x29746E0", VA = "0x1829752E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int CDJBKJOLKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x29770A0", Offset = "0x29764A0", VA = "0x1829770A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x1434FB0", Offset = "0x14343B0", VA = "0x181434FB0", Slot = "4")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2975120", Offset = "0x2974520", VA = "0x182975120", Slot = "5")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2977450", Offset = "0x2976850", VA = "0x182977450")]
		public void PCBJCBJMJKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2976950", Offset = "0x2975D50", VA = "0x182976950", Slot = "6")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2974560", Offset = "0x2973960", VA = "0x182974560", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x29774A0", Offset = "0x29768A0", VA = "0x1829774A0")]
		public int PHDIMBKCLEF(SceneTag OOOMPFGDEEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x29772E0", Offset = "0x29766E0", VA = "0x1829772E0")]
		public int NHBEOEOMDAO(SceneTag OOOMPFGDEEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2974180", Offset = "0x2973580", VA = "0x182974180")]
		public bool CEKHMFLDFGM(Entity LCLDFKAJPDK, Allocator FKHAEPDPDAI, out NativeList<Entity> PBEMBFBGMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2975EF0", Offset = "0x29752F0", VA = "0x182975EF0")]
		public bool LDOPCOPODDB(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x29743D0", Offset = "0x29737D0", VA = "0x1829743D0")]
		public bool DGBCKPEIJJH(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x29774C0", Offset = "0x29768C0", VA = "0x1829774C0")]
		public bool PHONMIEGPBF(Entity LCLDFKAJPDK, out APKFPLGDLPH MPIEEKNKAMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2977530", Offset = "0x2976930", VA = "0x182977530")]
		private bool PHONMIEGPBF(Transform CACALPHNCBH, out APKFPLGDLPH MPIEEKNKAMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2975250", Offset = "0x2974650", VA = "0x182975250")]
		private void GBIFKHPFBNE(Entity LCLDFKAJPDK, APKFPLGDLPH MPIEEKNKAMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2977430", Offset = "0x2976830", VA = "0x182977430")]
		private bool OPKIHFBPPFC(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2974DE0", Offset = "0x29741E0", VA = "0x182974DE0")]
		public void EHOMCGHPBHE(KHMECMDAALD HBKLDKCICEJ, APKFPLGDLPH CNEFEEJPMMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2976AA0", Offset = "0x2975EA0", VA = "0x182976AA0")]
		public bool MBELIAOAHEJ(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x29764B0", Offset = "0x29758B0", VA = "0x1829764B0")]
		public bool LFIKAPHEHNB(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2976880", Offset = "0x2975C80", VA = "0x182976880")]
		public bool LFIKAPHEHNB(Entity LCLDFKAJPDK, [Optional] object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x2976860", Offset = "0x2975C60", VA = "0x182976860")]
		public bool LFIKAPHEHNB(APKFPLGDLPH KANBPIJHFNA, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x29746F0", Offset = "0x2973AF0", VA = "0x1829746F0")]
		public bool EDFNPEPIDIC(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x29746C0", Offset = "0x2973AC0", VA = "0x1829746C0")]
		public bool EDFNPEPIDIC(APKFPLGDLPH MPIEEKNKAMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2976140", Offset = "0x2975540", VA = "0x182976140")]
		public bool LFIKAPHEHNB(APKFPLGDLPH MPIEEKNKAMO, [Optional] object MIFCLBEAOPM, bool HKPPDHFDHMN = false, bool BHPLNOFGJEF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x29743F0", Offset = "0x29737F0", VA = "0x1829743F0")]
		public Transform DHHOPPBKOBH(Entity LCLDFKAJPDK, [Optional] object MIFCLBEAOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2975BE0", Offset = "0x2974FE0", VA = "0x182975BE0")]
		public bool KGFFBHKEPBA(Entity LCLDFKAJPDK, out Transform CACALPHNCBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x2974FE0", Offset = "0x29743E0", VA = "0x182974FE0")]
		public APKFPLGDLPH EKICMIMOHBL(Entity LCLDFKAJPDK, [Optional] object MIFCLBEAOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2974B50", Offset = "0x2973F50", VA = "0x182974B50")]
		public void EHGKANMEAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x2973930", Offset = "0x2972D30", VA = "0x182973930")]
		public void APCOFGFCCHC(SceneTag OOOMPFGDEEN, bool HONEAFDLBMH, global::GMANFPIPMBB<int> NGFDMJGEJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x2975690", Offset = "0x2974A90", VA = "0x182975690")]
		private void JNBJMGNEBFI(Entity LCLDFKAJPDK, bool HONEAFDLBMH, bool KMPPFLJHBHE, global::GMANFPIPMBB<int> NGFDMJGEJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x29753C0", Offset = "0x29747C0", VA = "0x1829753C0")]
		private void HOINELOCENC(Entity LCLDFKAJPDK, APKFPLGDLPH MPIEEKNKAMO, bool HONEAFDLBMH, bool KMPPFLJHBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x29750D0", Offset = "0x29744D0", VA = "0x1829750D0")]
		public APKFPLGDLPH ELDOOGALMKM(Entity LCLDFKAJPDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x2973D20", Offset = "0x2973120", VA = "0x182973D20")]
		public bool BALOOPDBMDO(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x29768D0", Offset = "0x2975CD0", VA = "0x1829768D0")]
		public bool LGIJADFEFLD(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x29773C0", Offset = "0x29767C0", VA = "0x1829773C0")]
		public bool OOCDJKEDMNO(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2976E40", Offset = "0x2976240", VA = "0x182976E40")]
		public bool MFDJBBJBCKH(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2976EB0", Offset = "0x29762B0", VA = "0x182976EB0")]
		public bool MFDJBBJBCKH(GELFNNAOOFF IGELLPOEMHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void KLMKIDBPMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2975300", Offset = "0x2974700", VA = "0x182975300")]
		private void GHGDPFPAJHH(bool GNCHPDAPALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2974AC0", Offset = "0x2973EC0", VA = "0x182974AC0")]
		private bool EGENMMIAIHO(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2973890", Offset = "0x2972C90", VA = "0x182973890")]
		private APKFPLGDLPH AFDOLMHKKDO(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2973F90", Offset = "0x2973390", VA = "0x182973F90")]
		private APKFPLGDLPH CAJKIOGIOMA(Entity LCLDFKAJPDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x29770C0", Offset = "0x29764C0", VA = "0x1829770C0")]
		private (Vector3, Quaternion, Vector3) NEFGADJAFKN(Entity LCLDFKAJPDK)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2973E80", Offset = "0x2973280", VA = "0x182973E80")]
		private void BENIODBEGGG(Entity LCLDFKAJPDK, GODNFBOIBNJ KLFAINNONJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2977300", Offset = "0x2976700", VA = "0x182977300")]
		private void OHFDJMLMNPK(MBEDCJLMHEO LKHNLAILFFL, APKFPLGDLPH CNEFEEJPMMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2976F80", Offset = "0x2976380", VA = "0x182976F80")]
		private void MHCOPBNAICC(APKFPLGDLPH CNEFEEJPMMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2975460", Offset = "0x2974860", VA = "0x182975460")]
		private void JBCIDFGPJDD(APKFPLGDLPH MPIEEKNKAMO, Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2975CB0", Offset = "0x29750B0", VA = "0x182975CB0")]
		private void KOAOPJPJAEC(Entity LCLDFKAJPDK, APKFPLGDLPH MPIEEKNKAMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2973DA0", Offset = "0x29731A0", VA = "0x182973DA0")]
		private void BECPHPFPPFP(Entity LCLDFKAJPDK, Transform CACALPHNCBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x2974690", Offset = "0x2973A90", VA = "0x182974690")]
		private MBEDCJLMHEO EAFCGHBLJOG(Entity LCLDFKAJPDK)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x2977700", Offset = "0x2976B00", VA = "0x182977700")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x29775E0", Offset = "0x29769E0", VA = "0x1829775E0")]
		[CompilerGenerated]
		private void PIILIFKNKJD()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class GIJBCLCIDFK
{
	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFB60", Offset = "0x2DDEF60", VA = "0x182DDFB60")]
	public static APKFPLGDLPH EKICMIMOHBL(this ObjectEmbodimentService HAJHHEFGJLE, MBEDCJLMHEO LKHNLAILFFL, [Optional] object MIFCLBEAOPM)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[HAMPPOKOPOP(typeof(ObjectLifecycleService), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.Lifecycle)]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	internal sealed class ObjectLifecycleService : GBCNOEIKEOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private ObjectEmbodimentService MPIEEKNKAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM GHDOFHADNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private FOLBIIPDBJB KNOOGBNOMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DestroyLocalObjects EDOGDEDOBPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		private EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x2978A90", Offset = "0x2977E90", VA = "0x182978A90")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, GODNFBOIBNJ> NDEJJCMOJOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x29789F0", Offset = "0x2977DF0", VA = "0x1829789F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x2977EE0", Offset = "0x29772E0", VA = "0x182977EE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> KHIOIHMLPND
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x2978C00", Offset = "0x2978000", VA = "0x182978C00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x2977E40", Offset = "0x2977240", VA = "0x182977E40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x29782C0", Offset = "0x29776C0", VA = "0x1829782C0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x14E1C30", Offset = "0x14E1030", VA = "0x1814E1C30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2978240", Offset = "0x2977640", VA = "0x182978240")]
		public bool FIKLEKNKGJP(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2977F80", Offset = "0x2977380", VA = "0x182977F80")]
		internal void CJJJNDCJKEI(Entity LCLDFKAJPDK, GODNFBOIBNJ KLFAINNONJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x29783A0", Offset = "0x29777A0", VA = "0x1829783A0")]
		public void HDLFCKJDPBO(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2978D30", Offset = "0x2978130", VA = "0x182978D30")]
		public void PLFCEMPLJCD(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2978AE0", Offset = "0x2977EE0", VA = "0x182978AE0")]
		private bool KMEPBCOCGKA(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x29787F0", Offset = "0x2977BF0", VA = "0x1829787F0")]
		public void JALMAFNAIBH(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2978430", Offset = "0x2977830", VA = "0x182978430")]
		private bool HJJGIAGJEBI(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2978CA0", Offset = "0x29780A0", VA = "0x182978CA0")]
		public void NAMPHNFBBEJ(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2978BA0", Offset = "0x2977FA0", VA = "0x182978BA0")]
		private void LCAMDLJOOKD(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2977FE0", Offset = "0x29773E0", VA = "0x182977FE0")]
		private void DPBFIMKMINF(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x29783E0", Offset = "0x29777E0", VA = "0x1829783E0")]
		public void HICCDFAGLMP(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		private void IBMPPHJLICD(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x29785F0", Offset = "0x29779F0", VA = "0x1829785F0")]
		private void HLLCKMPHGEH(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	[HAMPPOKOPOP(typeof(ObjectPrefabs), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.Prefabs)]
	internal class ObjectPrefabs : KIBOIPKLGGN, GBCNOEIKEOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private sealed class JFILPPKKOHN : IEnumerable<(LFEIHDPDPKH, GODNFBOIBNJ)>, IEnumerable, IEnumerator<(LFEIHDPDPKH, GODNFBOIBNJ)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private (LFEIHDPDPKH primitiveType, GODNFBOIBNJ prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700013A")]
			private (LFEIHDPDPKH, GODNFBOIBNJ) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B85")]
				[Cpp2IlInjected.Address(RVA = "0x1F92290", Offset = "0x1F91690", VA = "0x181F92290", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((LFEIHDPDPKH, GODNFBOIBNJ));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B87")]
				[Cpp2IlInjected.Address(RVA = "0x4395760", Offset = "0x4394B60", VA = "0x184395760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x43907A0", Offset = "0x438FBA0", VA = "0x1843907A0")]
			[DebuggerHidden]
			public JFILPPKKOHN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x4395580", Offset = "0x4394980", VA = "0x184395580", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x4395720", Offset = "0x4394B20", VA = "0x184395720", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x4395680", Offset = "0x4394A80", VA = "0x184395680", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(LFEIHDPDPKH, GODNFBOIBNJ)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x4395680", Offset = "0x4394A80", VA = "0x184395680", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM GHDOFHADNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private World ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private readonly Dictionary<GODNFBOIBNJ, Entity> IIPJHFKNDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly Dictionary<GODNFBOIBNJ, EntityArchetype> NOKEICPGEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private readonly Dictionary<LFEIHDPDPKH, GODNFBOIBNJ> OIDBIJEAELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<ECHOKHJACKM, GODNFBOIBNJ> IDDEMDCJHHB;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public int JAMIBFCLJNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x297C660", Offset = "0x297BA60", VA = "0x18297C660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x297C720", Offset = "0x297BB20", VA = "0x18297C720")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x297BCD0", Offset = "0x297B0D0", VA = "0x18297BCD0", Slot = "5")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x297B8E0", Offset = "0x297ACE0", VA = "0x18297B8E0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x297B3C0", Offset = "0x297A7C0", VA = "0x18297B3C0")]
		internal IEnumerable<Type> AKGLONNPMJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x297CA50", Offset = "0x297BE50", VA = "0x18297CA50")]
		internal AGDNGEJKLKF ODHFBDBIEEH(Type OGILDIMGIOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x297C930", Offset = "0x297BD30", VA = "0x18297C930")]
		public EntityArchetype LGNAHADHJJD(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x297C740", Offset = "0x297BB40", VA = "0x18297C740")]
		public NativeHashMap<int, EntityArchetype> KFKJCKFILDI(Allocator FKHAEPDPDAI = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x297C8C0", Offset = "0x297BCC0", VA = "0x18297C8C0")]
		public bool KNIHHJKNKII(GODNFBOIBNJ KLFAINNONJC, out EntityArchetype NCPPLDKIKPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x297C6B0", Offset = "0x297BAB0", VA = "0x18297C6B0", Slot = "4")]
		[IteratorStateMachine(typeof(JFILPPKKOHN))]
		public IEnumerable<(LFEIHDPDPKH, GODNFBOIBNJ)> JHIPBENLCDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x297B7D0", Offset = "0x297ABD0", VA = "0x18297B7D0")]
		public Entity DBMKBBAHMAH(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x297BC70", Offset = "0x297B070", VA = "0x18297BC70")]
		public GODNFBOIBNJ FKGBCFJDCGK(ECHOKHJACKM OGILDIMGIOH)
		{
			return default(GODNFBOIBNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x297BC10", Offset = "0x297B010", VA = "0x18297BC10")]
		public GODNFBOIBNJ FKGBCFJDCGK(LFEIHDPDPKH OGILDIMGIOH)
		{
			return default(GODNFBOIBNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x297CAC0", Offset = "0x297BEC0", VA = "0x18297CAC0")]
		public NativeHashMap<int, Entity> OPJOAFDHOFB(Allocator FKHAEPDPDAI = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x297CA00", Offset = "0x297BE00", VA = "0x18297CA00")]
		public IEnumerable<GODNFBOIBNJ> MOCMAPEEAAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x297B770", Offset = "0x297AB70", VA = "0x18297B770")]
		public Entity COIHJJFIIGJ(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x297C990", Offset = "0x297BD90", VA = "0x18297C990")]
		public bool LJBAPKMEOLK(GODNFBOIBNJ KLFAINNONJC, out Entity OPBBFNOFOIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x297C210", Offset = "0x297B610", VA = "0x18297C210")]
		private void HPDNGGNLOFA(AGDNGEJKLKF EAEDDCOHLGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x297B420", Offset = "0x297A820", VA = "0x18297B420")]
		internal void CCEIADDIBAF(GODNFBOIBNJ KLFAINNONJC, ComponentTypeList LLBOFFMHDFO, PFIJAJNBJFD PKFEKGEJIFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x297C0B0", Offset = "0x297B4B0", VA = "0x18297C0B0")]
		private void GLBKHGKIINJ(GODNFBOIBNJ KLFAINNONJC, ComponentTypeList MCGONHKIMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x297B650", Offset = "0x297AA50", VA = "0x18297B650")]
		internal Entity CEPFIDMILML(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x297CC80", Offset = "0x297C080", VA = "0x18297CC80")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum IECIGCFEBBH
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal interface OKNJOFPLNEI
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World JAPDBJIMKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	NOBLONKDMFK FEPPIANMPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal class NMMCCNJGHJL : IIEECLOJGND, KIPPNPAOMDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly LKOHPCAHLLK LJKPAKFPMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly IECIGCFEBBH HJGAFKLFBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly List<IGNMPNCMIDA> AOMFALJNJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private NativeMultiHashMap<Entity, CBFIIKBAJEL> MHGCIOOPPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private NativeHashMap<int, int> COFCNJHAJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private JobHandle EEJFEAJJLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private JobHandle EBCGJJHAEGD;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private World EDHELHHIHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x296E7B0", Offset = "0x296DBB0", VA = "0x18296E7B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private NOBLONKDMFK IJLPOHKNBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x296F090", Offset = "0x296E490", VA = "0x18296F090", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private HAMGBPFOOHJ IINCGJPKHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x2480520", Offset = "0x247F920", VA = "0x182480520", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, CBFIIKBAJEL> NBOLBAJBHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x7359F0", Offset = "0x734DF0", VA = "0x1807359F0", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, CBFIIKBAJEL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle KJBLPCOCDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x118F340", Offset = "0x118E740", VA = "0x18118F340", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x1900D90", Offset = "0x1900190", VA = "0x181900D90", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool OLEOCMNDHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x296ED10", Offset = "0x296E110", VA = "0x18296ED10", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World CFJNIKBCPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x296EF40", Offset = "0x296E340", VA = "0x18296EF40", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x296F650", Offset = "0x296EA50", VA = "0x18296F650")]
	public NMMCCNJGHJL(LKOHPCAHLLK LJKPAKFPMLM, IECIGCFEBBH HJGAFKLFBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x296ECC0", Offset = "0x296E0C0", VA = "0x18296ECC0", Slot = "11")]
	private void FBNLAJDICMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x296EB60", Offset = "0x296DF60", VA = "0x18296EB60", Slot = "10")]
	private bool EBJPFKHFOLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x296F270", Offset = "0x296E670", VA = "0x18296F270", Slot = "12")]
	private void PIAEICICBFC(ComponentType KCEEKGALKFC, in IGNMPNCMIDA GKOCLMPMONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x296F240", Offset = "0x296E640", VA = "0x18296F240", Slot = "13")]
	private bool NDMBIFFIPPK(GODNFBOIBNJ KLFAINNONJC, out Entity OPBBFNOFOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x296EAC0", Offset = "0x296DEC0", VA = "0x18296EAC0", Slot = "16")]
	private bool CGHJIAGCHBG(out NativeArray<int> AOMENFOEHAP, Allocator FKHAEPDPDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x296F490", Offset = "0x296E890", VA = "0x18296F490", Slot = "17")]
	private bool POIIOILEHCD(ComponentType KCEEKGALKFC, out IGNMPNCMIDA IDHFJEIFJJF, out LHKPICCFKEL OCNEBCDHANP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x296F360", Offset = "0x296E760", VA = "0x18296F360", Slot = "18")]
	private bool POIIOILEHCD(ComponentType KCEEKGALKFC, out IGNMPNCMIDA IDHFJEIFJJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x296EFA0", Offset = "0x296E3A0", VA = "0x18296EFA0", Slot = "19")]
	private IGNMPNCMIDA KMEPCJNMJEI(ComponentType KCEEKGALKFC)
	{
		return default(IGNMPNCMIDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x296ECD0", Offset = "0x296E0D0", VA = "0x18296ECD0", Slot = "20")]
	private DLNMECKPKMF IBMDOMNMPHD()
	{
		return default(DLNMECKPKMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x296EC80", Offset = "0x296E080", VA = "0x18296EC80", Slot = "21")]
	private void EBPGHPPNJPN(JobHandle DNPFDFHMBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x296E810", Offset = "0x296DC10", VA = "0x18296E810")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x296ED20", Offset = "0x296E120", VA = "0x18296ED20")]
	private bool JCKAJKIMOCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x296F0B0", Offset = "0x296E4B0", VA = "0x18296F0B0")]
	private int MIDLOMLGFDD()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal class LKOHPCAHLLK : OKNJOFPLNEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public BHHDNNCMGLM GHDOFHADNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public ObjectInstantiationService IIPJHFKNDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public NOBLONKDMFK AILOFIFIOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public HAMGBPFOOHJ KBAMFLIBBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public IFJOIMFECNJ BCAMCAPCPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public World JAPDBJIMKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x296B250", Offset = "0x296A650", VA = "0x18296B250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public NOBLONKDMFK FEPPIANMPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public LKOHPCAHLLK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	[HAMPPOKOPOP(typeof(PropertyDiffStateService), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.PropertyChanges)]
	internal class PropertyDiffStateService : GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		internal readonly struct MIMBMNPBNKL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private readonly IECIGCFEBBH NEDDKJHHCFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private readonly PropertyDiffStateService LHDJJEMNOIF;

			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0x4397040", Offset = "0x4396440", VA = "0x184397040")]
			public MIMBMNPBNKL(PropertyDiffStateService LHDJJEMNOIF, IECIGCFEBBH IJPCPLACKHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x4397020", Offset = "0x4396420", VA = "0x184397020", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private readonly LKOHPCAHLLK LJKPAKFPMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly NMMCCNJGHJL[] PEGHCCIEFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private IECIGCFEBBH IGJMFMIPGGL;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public OKNJOFPLNEI OGLPKILOPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public KIPPNPAOMDE EFCKPEGFCCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x2988550", Offset = "0x2987950", VA = "0x182988550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public IIEECLOJGND KBAFKHGDOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x2988550", Offset = "0x2987950", VA = "0x182988550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x9020B0", Offset = "0x9014B0", VA = "0x1809020B0")]
		public KIPPNPAOMDE BJOIIHANBNN(IECIGCFEBBH HJGAFKLFBEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x9020B0", Offset = "0x9014B0", VA = "0x1809020B0")]
		public IIEECLOJGND DGFFJEDALFN(IECIGCFEBBH HJGAFKLFBEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x29886D0", Offset = "0x2987AD0", VA = "0x1829886D0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2988770", Offset = "0x2987B70", VA = "0x182988770", Slot = "5")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2988590", Offset = "0x2987990", VA = "0x182988590")]
		public void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x29885F0", Offset = "0x29879F0", VA = "0x1829885F0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2988750", Offset = "0x2987B50", VA = "0x182988750")]
		public MIMBMNPBNKL JIPPPMADBFC(IECIGCFEBBH HJGAFKLFBEI)
		{
			return default(MIMBMNPBNKL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x2988B80", Offset = "0x2987F80", VA = "0x182988B80")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	[JEGJCCBDMOE(OLCAJGBKOGB.HierarchySystems)]
	[HAMPPOKOPOP(typeof(SceneService), new string[] { })]
	internal class SceneService : GBCNOEIKEOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public static readonly SceneTag NIKDLIEBOLM;

		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public const string POHFEOJBPEA = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private const string ACBGFLHNEPL = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[OMAMNFHDGBM]
		private FDCCILJEAIN CNAGLHOPGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[OMAMNFHDGBM]
		private ObjectEmbodimentService MPIEEKNKAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[OMAMNFHDGBM]
		private ONJBKOIKDCG EODGEOJGIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[OMAMNFHDGBM]
		private SingletonComponentService MIOELNIDILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[OMAMNFHDGBM]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		[OMAMNFHDGBM]
		private PhotonInstanceCleanupService FFBOHIEKEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery JBFDIPFEGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery GIGDBKLKMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery AOGMHFCDAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private Entity NIMNGIEIOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public bool KMOJIFJJMAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x2BCD490", Offset = "0x2BCC890", VA = "0x182BCD490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> NAKBHKKJAKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0xF199A0", Offset = "0xF18DA0", VA = "0x180F199A0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0x20787E0", Offset = "0x2077BE0", VA = "0x1820787E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity AGIHNPJFODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE4F0", Offset = "0x2BCD8F0", VA = "0x182BCE4F0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag ONHAKDGHMFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE160", Offset = "0x2BCD560", VA = "0x182BCE160")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity HOEOHPFHNCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE160", Offset = "0x2BCD560", VA = "0x182BCE160")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE2B0", Offset = "0x2BCD6B0", VA = "0x182BCE2B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE650", Offset = "0x2BCDA50", VA = "0x182BCE650")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE320", Offset = "0x2BCD720", VA = "0x182BCE320", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE110", Offset = "0x2BCD510", VA = "0x182BCE110", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEF60", Offset = "0x2BCE360", VA = "0x182BCEF60")]
		public void POCNDCJFBPN(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE700", Offset = "0x2BCDB00", VA = "0x182BCE700")]
		public NativeArray<Entity> KNKAKBGPJKL(Allocator FKHAEPDPDAI = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE1B0", Offset = "0x2BCD5B0", VA = "0x182BCE1B0")]
		public void EHJKKDFOPEF(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2BCED30", Offset = "0x2BCE130", VA = "0x182BCED30")]
		public Entity OEGIECJCAJK(string AMNLGEBHFHK = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEA40", Offset = "0x2BCDE40", VA = "0x182BCEA40")]
		public void MMGNOIMFFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD5F0", Offset = "0x2BCC9F0", VA = "0x182BCD5F0")]
		public void CNMMEOHJGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE6A0", Offset = "0x2BCDAA0", VA = "0x182BCE6A0")]
		public void KNHMDCGAKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE640", Offset = "0x2BCDA40", VA = "0x182BCE640")]
		public void KAGFEKFHOHE(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE440", Offset = "0x2BCD840", VA = "0x182BCE440")]
		public bool JEMFIJABFKF(Entity OOOMPFGDEEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEA60", Offset = "0x2BCDE60", VA = "0x182BCEA60")]
		public void NDDAOAAFMJK(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD4E0", Offset = "0x2BCC8E0", VA = "0x182BCD4E0")]
		public string CLCLKGNBGGN(Entity OOOMPFGDEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		public void GOOBCFDELOA(Entity OOOMPFGDEEN, string AMNLGEBHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x2BCED10", Offset = "0x2BCE110", VA = "0x182BCED10")]
		public bool NMCIGPFNFPA(string AMNLGEBHFHK, out Entity OOOMPFGDEEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEC00", Offset = "0x2BCE000", VA = "0x182BCEC00")]
		public void NHLMFBBOOAM(Entity OOOMPFGDEEN, bool NJMABCMAFIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD730", Offset = "0x2BCCB30", VA = "0x182BCD730")]
		public void DEOPGDILMFN(Entity LCLDFKAJPDK, bool ILECBDFCKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD6C0", Offset = "0x2BCCAC0", VA = "0x182BCD6C0")]
		public void DEOPGDILMFN(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD7B0", Offset = "0x2BCCBB0", VA = "0x182BCD7B0")]
		public void DEOPGDILMFN(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDA80", Offset = "0x2BCCE80", VA = "0x182BCDA80")]
		public void DMNJAEHNICL(Entity LCLDFKAJPDK, Entity OOOMPFGDEEN, bool ILECBDFCKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD8A0", Offset = "0x2BCCCA0", VA = "0x182BCD8A0")]
		public void DMNJAEHNICL(NativeArray<Entity> ABBIPALBHCK, Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDCB0", Offset = "0x2BCD0B0", VA = "0x182BCDCB0")]
		public void DMNJAEHNICL(EntityQuery ANBHGOBNOFE, Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEDB0", Offset = "0x2BCE1B0", VA = "0x182BCEDB0")]
		private void PDHBPIIONMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEFA0", Offset = "0x2BCE3A0", VA = "0x182BCEFA0")]
		private void POGNBINJLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE4F0", Offset = "0x2BCD8F0", VA = "0x182BCE4F0")]
		private Entity MFAPILJGENM()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD610", Offset = "0x2BCCA10", VA = "0x182BCD610")]
		private void DDADPABJJKH(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE040", Offset = "0x2BCD440", VA = "0x182BCE040")]
		private void DODOFNHEHBD(EntityQuery IMAJPHALFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDD60", Offset = "0x2BCD160", VA = "0x182BCDD60")]
		private void DODOFNHEHBD(NativeArray<Entity> OOCMFKEPGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD3E0", Offset = "0x2BCC7E0", VA = "0x182BCD3E0")]
		private void CDNPFOCKEIP(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE8E0", Offset = "0x2BCDCE0", VA = "0x182BCE8E0")]
		private void LMCBJECPLNJ(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE730", Offset = "0x2BCDB30", VA = "0x182BCE730")]
		private void KOBBOOCEIHM(SceneTag MNLIIBDIJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE8A0", Offset = "0x2BCDCA0", VA = "0x182BCE8A0")]
		private void LGBPMHFGAAN(SceneTag MNLIIBDIJCN, global::GMANFPIPMBB<int> NGFDMJGEJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEA70", Offset = "0x2BCDE70", VA = "0x182BCEA70")]
		private void NGGLPDNGPIO(SceneTag MNLIIBDIJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD2E0", Offset = "0x2BCC6E0", VA = "0x182BCD2E0")]
		private void ACJHLDBJDEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x3824170", Offset = "0x3823570", VA = "0x183824170")]
		private void AAKLEGAPBEL<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void LBBICLCDLNJ(SceneTag MNLIIBDIJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD380", Offset = "0x2BCC780", VA = "0x182BCD380")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void BGALIFGCGAB(EntityQuery ANBHGOBNOFE, string AMNLGEBHFHK, SceneTag MNLIIBDIJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEA10", Offset = "0x2BCDE10", VA = "0x182BCEA10")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void MKCEICNBBHB(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void LIBFDHIKFAP(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[DCBDIJCKLAD(IKIGKMLBEFF.PhotonRoom)]
	[HAMPPOKOPOP(typeof(ICKDLDAIKCD), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.HierarchySystems)]
	internal class UnitySceneService : GBCNOEIKEOL, ICKDLDAIKCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		[OMAMNFHDGBM]
		private SceneService OOCMFKEPGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private readonly Dictionary<int, Entity> NNCADMAOFMK;

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x2BDCC50", Offset = "0x2BDC050", VA = "0x182BDCC50")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCBC0", Offset = "0x2BDBFC0", VA = "0x182BDCBC0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCD10", Offset = "0x2BDC110", VA = "0x182BDCD10", Slot = "5")]
		public void POCNDCJFBPN(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC9D0", Offset = "0x2BDBDD0", VA = "0x182BDC9D0", Slot = "6")]
		public bool DHOMPHFDFBB(MBEDCJLMHEO LKHNLAILFFL, Transform CACALPHNCBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCCA0", Offset = "0x2BDC0A0", VA = "0x182BDCCA0")]
		private bool KIJELLAOMOI(Scene OOOMPFGDEEN, out Entity MFBJOFKPAKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCE80", Offset = "0x2BDC280", VA = "0x182BDCE80")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[JEGJCCBDMOE(OLCAJGBKOGB.ComponentSystemTypes)]
	[HAMPPOKOPOP(typeof(SingletonComponentService), new string[] { })]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	internal sealed class SingletonComponentService : GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		[OMAMNFHDGBM]
		private ONJBKOIKDCG EODGEOJGIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private Entity LCLDFKAJPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private ComponentTypeList MCGONHKIMDB;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int JAMIBFCLJNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0x2BD3980", Offset = "0x2BD2D80", VA = "0x182BD3980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity PBIJGMNGOLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x2BD3C90", Offset = "0x2BD3090", VA = "0x182BD3C90")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x3825B30", Offset = "0x3824F30", VA = "0x183825B30")]
		public T MKLBNKEKMJE<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x3825A60", Offset = "0x3824E60", VA = "0x183825A60")]
		public void EFMALMFMJGL<T>(T LPJDDLMPNCG) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3910", Offset = "0x2BD2D10", VA = "0x182BD3910", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3CE0", Offset = "0x2BD30E0", VA = "0x182BD3CE0", Slot = "5")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3CE0", Offset = "0x2BD30E0", VA = "0x182BD3CE0")]
		private void MNCBKDJCMEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3640", Offset = "0x2BD2A40", VA = "0x182BD3640", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3990", Offset = "0x2BD2D90", VA = "0x182BD3990")]
		private ComponentTypeList JBHAHIPKGHA()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		private static void HKCPHNLCJJH(int EJMNNLNLAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		private static void FNLAKDINAOD(Type OGILDIMGIOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3E80", Offset = "0x2BD3280", VA = "0x182BD3E80")]
		private static void PJEGMHHBLLI(Type OGILDIMGIOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal struct OLAKGCJKPHC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
[HAMPPOKOPOP(typeof(NBFPIMPGEPM), new string[] { })]
internal sealed class NBFPIMPGEPM : GBCNOEIKEOL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	[OMAMNFHDGBM]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private global::MIOAAOMMLGI<ODJLKCLLLBM, Entity> OJAHNBGMLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private global::NFKGLAFFMGG<NMLPINBEDCF> MKCIMHFIFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private global::NFKGLAFFMGG<JACFLKOCHDH> PJGNEAJEJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private global::NFKGLAFFMGG<MEPMOPELKDN> CAGMFGLDJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private global::NFKGLAFFMGG<POOAGDAKJNG> LNOJDMDCBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private global::NFKGLAFFMGG<CLLGJLBHHLK> HAJHHEFGJLE;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public global::OOEJJHOEKAD<Entity> CDOBKCGCKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public AJNLODPELOG LBFLJDPNOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public AJNLODPELOG IBMIOPPDFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public AJNLODPELOG PNLGEEBOKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public AJNLODPELOG MLCKCLKBELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x735A10", Offset = "0x734E10", VA = "0x180735A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public AJNLODPELOG OCDIGFPMION
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x77E9A0", Offset = "0x77DDA0", VA = "0x18077E9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager BFILENFCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x296E0C0", Offset = "0x296D4C0", VA = "0x18296E0C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x296DFB0", Offset = "0x296D3B0", VA = "0x18296DFB0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x296DEC0", Offset = "0x296D2C0", VA = "0x18296DEC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x282E930", Offset = "0x282DD30", VA = "0x18282E930")]
	private void GJPLHHGHDFM<T>(ref global::NFKGLAFFMGG<T> EFOCNJAEIPA) where T : struct, NIJKBPKBPOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x282E930", Offset = "0x282DD30", VA = "0x18282E930")]
	private void GJPLHHGHDFM<TC, TV>(ref global::MIOAAOMMLGI<TC, TV> EFOCNJAEIPA) where TC : struct, NIJKBPKBPOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public NBFPIMPGEPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[HAMPPOKOPOP(typeof(NOGNNNFDDDD), new string[] { })]
[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
internal sealed class NOGNNNFDDDD : BJDLFHICAGD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private HIEGLBAPNMB DOELLMGADLI;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public HIEGLBAPNMB LMJNOLIPNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x1D06040", Offset = "0x1D05440", VA = "0x181D06040")]
		get
		{
			return default(HIEGLBAPNMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x29703E0", Offset = "0x296F7E0", VA = "0x1829703E0", Slot = "4")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x2970430", Offset = "0x296F830", VA = "0x182970430", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public NOGNNNFDDDD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	[HAMPPOKOPOP(typeof(TransformOwnershipPhase), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		public enum MIAKCDFPOCC
		{
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		public struct PNPFBPANAGP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private MIAKCDFPOCC NMNDDDIDDGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private readonly TransformOwnershipPhase GGEKFPEBLKN;

			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x439BF50", Offset = "0x439B350", VA = "0x18439BF50")]
			public PNPFBPANAGP(TransformOwnershipPhase GGEKFPEBLKN, MIAKCDFPOCC HJGAFKLFBEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x439BF30", Offset = "0x439B330", VA = "0x18439BF30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public MIAKCDFPOCC HJGAFKLFBEI;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public MIAKCDFPOCC ADJHONNAHAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0x72B020", Offset = "0x72A420", VA = "0x18072B020")]
			get
			{
				return default(MIAKCDFPOCC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x7358F0", Offset = "0x734CF0", VA = "0x1807358F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool HMKNALALOKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0xAA4F40", Offset = "0xAA4340", VA = "0x180AA4F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool CLLNCFKENJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0xE17D80", Offset = "0xE17180", VA = "0x180E17D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD71E0", Offset = "0x2BD65E0", VA = "0x182BD71E0")]
		public PNPFBPANAGP FPNGJFPEMBK()
		{
			return default(PNPFBPANAGP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7210", Offset = "0x2BD6610", VA = "0x182BD7210")]
		public PNPFBPANAGP MMCEOGPMJIG()
		{
			return default(PNPFBPANAGP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[HAMPPOKOPOP(typeof(GCEEGFGLLJD), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.Circuits)]
	public class CircuitsService : GBCNOEIKEOL, GCEEGFGLLJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		[OMAMNFHDGBM]
		private BOAPBHCNJFP NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private EntityManager MABCFMECCKD;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8DC0", Offset = "0x2FB81C0", VA = "0x182FB8DC0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8980", Offset = "0x2FB7D80", VA = "0x182FB8980", Slot = "5")]
		public bool ANGDAPPADEE(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8CD0", Offset = "0x2FB80D0", VA = "0x182FB8CD0", Slot = "7")]
		public bool FIIHLFKEHCN(MBEDCJLMHEO LKHNLAILFFL, out Guid HDIHCPHNJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2FB9A50", Offset = "0x2FB8E50", VA = "0x182FB9A50", Slot = "8")]
		public Guid KJPMLGCGPFO(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2FB9120", Offset = "0x2FB8520", VA = "0x182FB9120", Slot = "9")]
		public void IGNAMIFGHND(MBEDCJLMHEO LKHNLAILFFL, Guid HDIHCPHNJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2FB9030", Offset = "0x2FB8430", VA = "0x182FB9030", Slot = "10")]
		public bool IDDOCBKNLHA(MBEDCJLMHEO LKHNLAILFFL, out Guid FKJKGACLIOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2FB9B60", Offset = "0x2FB8F60", VA = "0x182FB9B60", Slot = "11")]
		public Guid MOCNOFCDGIC(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2FB9740", Offset = "0x2FB8B40", VA = "0x182FB9740", Slot = "12")]
		public void KAOLONFHDKA(MBEDCJLMHEO LKHNLAILFFL, Guid FKJKGACLIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8A80", Offset = "0x2FB7E80", VA = "0x182FB8A80", Slot = "13")]
		public bool DCNFJIIMMDM(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8C60", Offset = "0x2FB8060", VA = "0x182FB8C60", Slot = "14")]
		public void FCKHLPCCGFF(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2FB9380", Offset = "0x2FB8780", VA = "0x182FB9380", Slot = "15")]
		public void JGMELKLBMOL(MBEDCJLMHEO ELODBNLDLIK, MBEDCJLMHEO GGEKFPEBLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8E60", Offset = "0x2FB8260", VA = "0x182FB8E60")]
		private void HDBKIANEFJD(EAGNNFCOCKO GGHIDBJGFCN, MBEDCJLMHEO GGEKFPEBLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8AD0", Offset = "0x2FB7ED0", VA = "0x182FB8AD0")]
		private void DGNBIJBOMLF(EAGNNFCOCKO GGHIDBJGFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8830", Offset = "0x2FB7C30", VA = "0x182FB8830")]
		private bool AFCJDOHOMMF(EMFDOJECCDF NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2FB99A0", Offset = "0x2FB8DA0", VA = "0x182FB99A0")]
		private bool KHDLAAJPNII(EMFDOJECCDF NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8FD0", Offset = "0x2FB83D0", VA = "0x182FB8FD0", Slot = "6")]
		public bool HKEACDLHMCP(MBEDCJLMHEO LMLBLIDPKCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[HAMPPOKOPOP(typeof(FDHGKOHMFEH), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.Connectables)]
	internal class ConnectableService : FDHGKOHMFEH, GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class FKOJFDJCIAF : IEnumerable<MBEDCJLMHEO>, IEnumerable, IEnumerator<MBEDCJLMHEO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private MBEDCJLMHEO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			private MBEDCJLMHEO localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public MBEDCJLMHEO <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			private MBEDCJLMHEO System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4B")]
				[Cpp2IlInjected.Address(RVA = "0x735A00", Offset = "0x734E00", VA = "0x180735A00", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MBEDCJLMHEO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8F50", Offset = "0x2BC8350", VA = "0x182BC8F50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x913060", Offset = "0x912460", VA = "0x180913060")]
			[DebuggerHidden]
			public FKOJFDJCIAF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8FA0", Offset = "0x2BC83A0", VA = "0x182BC8FA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8B60", Offset = "0x2BC7F60", VA = "0x182BC8B60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9070", Offset = "0x2BC8470", VA = "0x182BC9070")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x2BC90C0", Offset = "0x2BC84C0", VA = "0x182BC90C0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8F10", Offset = "0x2BC8310", VA = "0x182BC8F10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8E60", Offset = "0x2BC8260", VA = "0x182BC8E60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MBEDCJLMHEO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8E60", Offset = "0x2BC8260", VA = "0x182BC8E60", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly KLBHBMBPLOA GHMIDHHIPEP;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public const int BKKOLAEANEI = 0;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public const int JOGAIHIIDOF = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private AMBNPJKGCOF HFKINOFBOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private BHHDNNCMGLM ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private BFHOGDONKCB NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private PropertyEventCallbacksService JEKKGCEPDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private global::CEGMBHOPAIF<Entity> IGNKDMBJEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private global::CEGMBHOPAIF<float3> IKMNKNJEGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private global::CEGMBHOPAIF<quaternion> JNEHIGHOCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private global::CEGMBHOPAIF<Entity> GGEKFPEBLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private global::CEGMBHOPAIF<float3> KPEIOCLIHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private global::CEGMBHOPAIF<quaternion> LOFMMAJIGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private HashSet<Entity> AGNFCKJPGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private HashSet<Entity> JBAEBJNPJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private EntityQuery DDECEPCAGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public Func<IFKHEAGAGMF> MECCBGIBHFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x72B090", Offset = "0x72A490", VA = "0x18072B090", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x8038C0", Offset = "0x802CC0", VA = "0x1808038C0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<MBEDCJLMHEO, MBEDCJLMHEO> EDGGDJFKPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x2FBE980", Offset = "0x2FBDD80", VA = "0x182FBE980", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x2FBE660", Offset = "0x2FBDA60", VA = "0x182FBE660", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<MBEDCJLMHEO, MBEDCJLMHEO> PCBBNEAHOBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x2FBF680", Offset = "0x2FBEA80", VA = "0x182FBF680", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x2FBDE50", Offset = "0x2FBD250", VA = "0x182FBDE50", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<MBEDCJLMHEO, MBEDCJLMHEO, MBEDCJLMHEO> INKODGPCFLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x2FBE440", Offset = "0x2FBD840", VA = "0x182FBE440", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x2FBDDB0", Offset = "0x2FBD1B0", VA = "0x182FBDDB0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<MBEDCJLMHEO> HMJMHIGBAHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x2FBF3A0", Offset = "0x2FBE7A0", VA = "0x182FBF3A0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2FBDBC0", Offset = "0x2FBCFC0", VA = "0x182FBDBC0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE4E0", Offset = "0x2FBD8E0", VA = "0x182FBE4E0", Slot = "25")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x2FBEF00", Offset = "0x2FBE300", VA = "0x182FBEF00", Slot = "26")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE0B0", Offset = "0x2FBD4B0", VA = "0x182FBE0B0", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE260", Offset = "0x2FBD660", VA = "0x182FBE260")]
		private void EKGDECLKKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x2FBEA20", Offset = "0x2FBDE20", VA = "0x182FBEA20")]
		private void IGAIOIBGIII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x2FBDEF0", Offset = "0x2FBD2F0", VA = "0x182FBDEF0")]
		private void DHKFMFLKANM(Entity LCLDFKAJPDK, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI DKOFAPECACL, HAMGOKKMMPI JFNADPGFOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x2FBF620", Offset = "0x2FBEA20", VA = "0x182FBF620")]
		private void OHDIHGKABAA(Entity LCLDFKAJPDK, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI DKOFAPECACL, HAMGOKKMMPI JFNADPGFOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x1376F10", Offset = "0x1376310", VA = "0x181376F10", Slot = "14")]
		public MBEDCJLMHEO DBMFKACBPJP(MBEDCJLMHEO LKHNLAILFFL, int CHIMMHOJJPG)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x12AAD20", Offset = "0x12AA120", VA = "0x1812AAD20", Slot = "15")]
		public Color HGPGACLBBON(MBEDCJLMHEO LKHNLAILFFL, int CHIMMHOJJPG)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x2FBED20", Offset = "0x2FBE120", VA = "0x182FBED20", Slot = "16")]
		public float3 KACCOCEONIB(MBEDCJLMHEO LKHNLAILFFL, int CHIMMHOJJPG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x2FBF440", Offset = "0x2FBE840", VA = "0x182FBF440", Slot = "17")]
		public bool NKKFLAJKMBF(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO MCIFJHLGFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE8D0", Offset = "0x2FBDCD0", VA = "0x182FBE8D0", Slot = "18")]
		public MBEDCJLMHEO HPNJPLPKLJD(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x2FBDC60", Offset = "0x2FBD060", VA = "0x182FBDC60", Slot = "21")]
		public void CAABHGHOFIH(MBEDCJLMHEO LKHNLAILFFL, Vector3 GPANIELDIGF, Quaternion DBPJHIKNNJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x2FBF580", Offset = "0x2FBE980", VA = "0x182FBF580", Slot = "23")]
		public float3 OGBFLDPHPPC(MNPGLJDFPEI HFAEPNPFGOA)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x2FBEB90", Offset = "0x2FBDF90", VA = "0x182FBEB90", Slot = "24")]
		public quaternion JBJGILFHGEH(MNPGLJDFPEI HFAEPNPFGOA)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2FBEC20", Offset = "0x2FBE020", VA = "0x182FBEC20", Slot = "28")]
		public RigidTransform JIFNPFBGKDL(MNPGLJDFPEI HFAEPNPFGOA)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE2C0", Offset = "0x2FBD6C0", VA = "0x182FBE2C0", Slot = "22")]
		public bool EMMOCFOCGKM(MBEDCJLMHEO LKHNLAILFFL, out RigidTransform EFCKMMEMLMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2FBF4F0", Offset = "0x2FBE8F0", VA = "0x182FBF4F0", Slot = "19")]
		[IteratorStateMachine(typeof(FKOJFDJCIAF))]
		public IEnumerable<MBEDCJLMHEO> OEODJGDOMJE(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x2FBDA60", Offset = "0x2FBCE60", VA = "0x182FBDA60", Slot = "20")]
		public MBEDCJLMHEO BACFLHOIANK(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE700", Offset = "0x2FBDB00", VA = "0x182FBE700", Slot = "29")]
		public void GLOLKBCIMFI(ref List<MBEDCJLMHEO> NNDAPMCFFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x2FBD940", Offset = "0x2FBCD40", VA = "0x182FBD940")]
		private Entity BACFLHOIANK(Entity LCLDFKAJPDK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x2FBF7B0", Offset = "0x2FBEBB0", VA = "0x182FBF7B0")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Prefabs)]
	[HAMPPOKOPOP(typeof(ObjectInstantiationService), new string[] { })]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	internal sealed class ObjectInstantiationService : GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM ACFGKGFDFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[OMAMNFHDGBM]
		private NFEKAMEEIBH OKIBGKGJPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		[OMAMNFHDGBM]
		private PKFMHONIPFJ FEAGJKIFELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[OMAMNFHDGBM]
		private ObjectNetworkToLocalMapService PJFKIMDFNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[OMAMNFHDGBM]
		private ObjectLifecycleService LCMHIEKJLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[OMAMNFHDGBM]
		private ObjectPrefabs IIPJHFKNDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[OMAMNFHDGBM]
		private KGKMOEPDGKA JILHNBNJKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private FOLBIIPDBJB KNOOGBNOMKA;

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public int IHMDCDCEGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0x2977810", Offset = "0x2976C10", VA = "0x182977810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x2977AC0", Offset = "0x2976EC0", VA = "0x182977AC0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x2977D70", Offset = "0x2977170", VA = "0x182977D70")]
		public Entity PFNKHCBELDA(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x2977D90", Offset = "0x2977190", VA = "0x182977D90")]
		public Entity PLLGILFFNLD(KHMECMDAALD HBKLDKCICEJ, GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x29779C0", Offset = "0x2976DC0", VA = "0x1829779C0")]
		public Entity FMBHGNBEDKM(GODNFBOIBNJ KLFAINNONJC, bool GKHKAHGPIJJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2977860", Offset = "0x2976C60", VA = "0x182977860")]
		public Entity FMBHGNBEDKM(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2977BF0", Offset = "0x2976FF0", VA = "0x182977BF0")]
		public Entity HNGEDIPEFKF()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2977C30", Offset = "0x2977030", VA = "0x182977C30")]
		public Entity JHOHELNIPGN(LFEIHDPDPKH OGILDIMGIOH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x2977780", Offset = "0x2976B80", VA = "0x182977780")]
		public Entity BHGFCNAGJLA(ECHOKHJACKM OGILDIMGIOH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2977A70", Offset = "0x2976E70", VA = "0x182977A70")]
		public NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)> DBMKBBAHMAH(NativeArray<MBEDCJLMHEO> HNAFJFFPIOE, Allocator FKHAEPDPDAI)
		{
			return default(NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2977D20", Offset = "0x2977120", VA = "0x182977D20")]
		public IEnumerable<GODNFBOIBNJ> MOCMAPEEAAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2977CC0", Offset = "0x29770C0", VA = "0x182977CC0")]
		public EntityArchetype LGNAHADHJJD(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2977A10", Offset = "0x2976E10", VA = "0x182977A10")]
		public Entity COIHJJFIIGJ(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x2977860", Offset = "0x2976C60", VA = "0x182977860")]
		private Entity CJCECJGAKAI(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x29779C0", Offset = "0x2976DC0", VA = "0x1829779C0")]
		private Entity CJCECJGAKAI(GODNFBOIBNJ KLFAINNONJC, bool GKHKAHGPIJJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x29778A0", Offset = "0x2976CA0", VA = "0x1829778A0")]
		private Entity CJCECJGAKAI(GODNFBOIBNJ KLFAINNONJC, KHMECMDAALD HBKLDKCICEJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[HAMPPOKOPOP(typeof(EMJHKMNAGIL), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	public sealed class PhysicsSceneColliderService : EMJHKMNAGIL, CIGLDIACENF, BJDLFHICAGD, GBCNOEIKEOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private const string AOGMLCFCHHC = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private const int CPCFNLGPNGL = -1;

		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private const int MJBPKAFHCBE = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		[OMAMNFHDGBM]
		private FBCAFMCBMPK GOBBGGBLGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private Collider[] APFPKONPNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private RaycastHit[] AJIHIDBMMLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private global::EAJFHNJEBAG<CMKEFKIFPMD, BoxCollider> MHJFKLLJGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private Scene OOOMPFGDEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private PhysicsScene LCLIONADLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private GameObject OPBBFNOFOIK;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public int OEKMJOLIGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x2981D80", Offset = "0x2981180", VA = "0x182981D80", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x2981EE0", Offset = "0x29812E0", VA = "0x182981EE0", Slot = "9")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x2982590", Offset = "0x2981990", VA = "0x182982590", Slot = "10")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x29820A0", Offset = "0x29814A0", VA = "0x1829820A0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x2982650", Offset = "0x2981A50", VA = "0x182982650", Slot = "4")]
		public CMKEFKIFPMD GLJAHNPFFDG(Entity LCLDFKAJPDK)
		{
			return default(CMKEFKIFPMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x2982B30", Offset = "0x2981F30", VA = "0x182982B30", Slot = "5")]
		public void ODFMHOGGBHC(NativeArray<CMKEFKIFPMD> FENIMIGFDHN, NativeArray<CNEHLCBOJKB> ABPIDODICDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x2982FA0", Offset = "0x29823A0", VA = "0x182982FA0", Slot = "6")]
		public void PJFNONPCDML(CMKEFKIFPMD IGELLPOEMHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x29824B0", Offset = "0x29818B0", VA = "0x1829824B0", Slot = "7")]
		public bool EGFFMNOOCCE(CMKEFKIFPMD IGELLPOEMHM, out Collider CMHAOFFOOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x29821A0", Offset = "0x29815A0", VA = "0x1829821A0")]
		public bool EEMPOIEDICE(in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, float CBFODBDKBEK, Allocator FKHAEPDPDAI, out NativeArray<Entity> ABBIPALBHCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2982050", Offset = "0x2981450", VA = "0x182982050")]
		private void DIJJGKONOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xB0CFE0", Offset = "0xB0C3E0", VA = "0x180B0CFE0")]
		private void NMCDHGHPHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2982F50", Offset = "0x2982350", VA = "0x182982F50")]
		private void PDNIILOBMLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x90F260", Offset = "0x90E660", VA = "0x18090F260")]
		private void BGEGPBINELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2981DC0", Offset = "0x29811C0", VA = "0x182981DC0")]
		private BoxCollider CPIODAMHIIO(Entity LCLDFKAJPDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2981D00", Offset = "0x2981100", VA = "0x182981D00")]
		private void BGFDIAKHCDD(BoxCollider GOMLNOAKNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x2982AF0", Offset = "0x2981EF0", VA = "0x182982AF0")]
		[Conditional("UNITY_EDITOR")]
		private void MAHAKEKIGBL(GameObject DLNMCGFEPOP, Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x29827F0", Offset = "0x2981BF0", VA = "0x1829827F0")]
		private void KAEFPFLEOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x29829E0", Offset = "0x2981DE0", VA = "0x1829829E0")]
		private void LAGOCFGBNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x2982D40", Offset = "0x2982140", VA = "0x182982D40")]
		private void OPEBIDDPPBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x29827C0", Offset = "0x2981BC0", VA = "0x1829827C0")]
		private void JOEKHNLAHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x29827A0", Offset = "0x2981BA0", VA = "0x1829827A0")]
		private void HBNKDMOCPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x2982550", Offset = "0x2981950", VA = "0x182982550")]
		private void EHLBGAEDHAO(Scene OCJBFGAPLBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x29827B0", Offset = "0x2981BB0", VA = "0x1829827B0", Slot = "8")]
		private bool HDJKGDBJPLB(in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, float CBFODBDKBEK, Allocator FKHAEPDPDAI, out NativeArray<Entity> ABBIPALBHCK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[HAMPPOKOPOP(typeof(OONCEOFLMII), new string[] { })]
public sealed class HILIPBHIKDB : OONCEOFLMII, GBCNOEIKEOL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	private struct DLOJHCLDOFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public float DBJKICMPHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public uint HOIFEJJDOKO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private CIGLDIACENF EEAIOLKHFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private HDFCNHAONKE HCHPFAFJCCJ;

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3690", Offset = "0x2DE2A90", VA = "0x182DE3690", Slot = "5")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3210", Offset = "0x2DE2610", VA = "0x182DE3210")]
	public bool EEMPOIEDICE(in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, float CBFODBDKBEK, out OBMPBPFAGAM AHNPMILMEKC, out Entity BADFIEDMMBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3700", Offset = "0x2DE2B00", VA = "0x182DE3700")]
	public static bool KHHHCLIODGK(in Span<OBMPBPFAGAM> DDPJAPAMPDO, float CBFODBDKBEK, out int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3800", Offset = "0x2DE2C00", VA = "0x182DE3800")]
	public static float NEIPKBHICDN(float DBJKICMPHJB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public HILIPBHIKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3200", Offset = "0x2DE2600", VA = "0x182DE3200", Slot = "4")]
	private bool AEALEHAIHAA(in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, float CBFODBDKBEK, out OBMPBPFAGAM AHNPMILMEKC, out Entity BADFIEDMMBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[HAMPPOKOPOP(typeof(HDFCNHAONKE), new string[] { })]
public sealed class GPEBHGLNPAE : HDFCNHAONKE, GBCNOEIKEOL
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[BurstCompile]
	private struct PJLJOGHMALB : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<Entity> ABBIPALBHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[ReadOnly]
		public float3 JKLIACIAOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[ReadOnly]
		public float3 BODJILKJNCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> CNNNOAPHAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> ADIOGHPPCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> NLEMNNLCKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> NFEHOLBKIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> EHCANGIBCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[WriteOnly]
		public NativeArray<OBMPBPFAGAM> AMBHNKAOPKC;

		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private static readonly OBMPBPFAGAM NCOIDMFANBP;

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x439A8B0", Offset = "0x4399CB0", VA = "0x18439A8B0", Slot = "4")]
		public void Execute(int EGNHJGKABLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x439A7E0", Offset = "0x4399BE0", VA = "0x18439A7E0")]
		private static float3 BBLDIDGICNH(in float4x4 HFKDJOHFPJL, in float3 JOFEJELEMJH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x439B7D0", Offset = "0x439ABD0", VA = "0x18439B7D0")]
		private static float3 LGMNACJJFIP(in float4x4 HFKDJOHFPJL, in float3 FHOLHGOPLFN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x439B990", Offset = "0x439AD90", VA = "0x18439B990")]
		private static float3 NHNCCCCIGNG(in float4x4 HFKDJOHFPJL, in float3 JOFEJELEMJH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x439B5B0", Offset = "0x439A9B0", VA = "0x18439B5B0")]
		private static float3 LECBAPPFJAK(in float4x4 HFKDJOHFPJL, in float3 FHOLHGOPLFN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x439AB90", Offset = "0x4399F90", VA = "0x18439AB90")]
		private bool JOAOEHNPEHF(in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, in NativeArray<Entity> EPFCJOBDAJD, out float3 AHNPMILMEKC, out float3 GCGCIPKJGGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x439AEE0", Offset = "0x439A2E0", VA = "0x18439AEE0")]
		public static bool KALAOFOOINH(in float3 IDIJOBCGPIE, in float3 NAOJLHNCLOF, in float3 FCMLNJLDLJA, in float3 PBMNJAMCBKN, float POPHLCJMFFD, float EGFCGGBAJBP, out float FOHPMIEDDCH, out float3 CLCAFOLJPCA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager MABCFMECCKD;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x2DE02F0", Offset = "0x2DDF6F0", VA = "0x182DE02F0", Slot = "5")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFE10", Offset = "0x2DDF210", VA = "0x182DDFE10")]
	public void EEMPOIEDICE(in NativeArray<Entity> ABBIPALBHCK, in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, in NativeArray<OBMPBPFAGAM> GOJDMOLEOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public GPEBHGLNPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0370", Offset = "0x2DDF770", VA = "0x182DE0370", Slot = "4")]
	private void IJKDLGIEFED(in NativeArray<Entity> ABBIPALBHCK, in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, in NativeArray<OBMPBPFAGAM> GOJDMOLEOHM)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Embodiment)]
	[DCBDIJCKLAD(IKIGKMLBEFF.OMRoom)]
	[HAMPPOKOPOP(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : GBCNOEIKEOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		[OMAMNFHDGBM]
		private BHHDNNCMGLM GHDOFHADNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		[OMAMNFHDGBM]
		private NFEKAMEEIBH ANOEEFFKHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		[OMAMNFHDGBM]
		private PKFMHONIPFJ CEACMLKHEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private DDOLHFHMLOP CGCNGCLEGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NativeHashMap<KHMECMDAALD, Entity> IPEHCBADPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private EntityManager MABCFMECCKD;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		internal NativeHashMap<KHMECMDAALD, Entity> FOCONKKIBNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0xCCB560", Offset = "0xCCA960", VA = "0x180CCB560")]
			get
			{
				return default(NativeHashMap<KHMECMDAALD, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint NNGCNJHNEJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x297AD00", Offset = "0x297A100", VA = "0x18297AD00")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool AMOPNJPCIDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x8BEB60", Offset = "0x8BDF60", VA = "0x1808BEB60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0xCCB610", Offset = "0xCCAA10", VA = "0x180CCB610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x297B020", Offset = "0x297A420", VA = "0x18297B020", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x297AD30", Offset = "0x297A130", VA = "0x18297AD30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x297AC80", Offset = "0x297A080", VA = "0x18297AC80")]
		public void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x297ADD0", Offset = "0x297A1D0", VA = "0x18297ADD0")]
		public void EHEINJKPBJH(KHMECMDAALD HBKLDKCICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x297ADA0", Offset = "0x297A1A0", VA = "0x18297ADA0")]
		private MBEDCJLMHEO EAFCGHBLJOG(Entity LCLDFKAJPDK)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x297B230", Offset = "0x297A630", VA = "0x18297B230")]
		public MBEDCJLMHEO HKKALCMCNLF(KHMECMDAALD HBKLDKCICEJ)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x297B140", Offset = "0x297A540", VA = "0x18297B140")]
		public KHMECMDAALD FLJOHMEAAKD(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(KHMECMDAALD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x297AF90", Offset = "0x297A390", VA = "0x18297AF90")]
		public void FFMJGCAAAJB(Entity LCLDFKAJPDK, KHMECMDAALD HBKLDKCICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x297B1D0", Offset = "0x297A5D0", VA = "0x18297B1D0")]
		public void HKALEDFALIG(Entity LCLDFKAJPDK, KHMECMDAALD HBKLDKCICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x297B310", Offset = "0x297A710", VA = "0x18297B310")]
		public void KIAFNFEMHGD(Entity LCLDFKAJPDK, KHMECMDAALD HBKLDKCICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x297ABB0", Offset = "0x2979FB0", VA = "0x18297ABB0")]
		public void BHEACGKKHHJ(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
	[HAMPPOKOPOP(typeof(PropertyEventCallbacksService), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.Callbacks)]
	public class PropertyEventCallbacksService : GBCNOEIKEOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		private struct JHBOIBABLAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public JFEKOCHNFPJ MIKGEIBIMCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public Type OGILDIMGIOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public int GBNBGNMHGLO;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		private struct KFNMGDMNBOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public JHBOIBABLAL[] FNBGFGCHFDN;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		public delegate void JFEKOCHNFPJ(Entity LCLDFKAJPDK, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI DKOFAPECACL, HAMGOKKMMPI JFNADPGFOAB);

		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private readonly Dictionary<AHKPLOLMABO, JFEKOCHNFPJ> AOJNPLAKNFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private readonly Dictionary<int, KFNMGDMNBOO> AHNCMNMNCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private JIGOCJGIGJA FNBGFGCHFDN;

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action PPOJLAFBGJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x2989450", Offset = "0x2988850", VA = "0x182989450")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x29893B0", Offset = "0x29887B0", VA = "0x1829893B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action PIEIPDDJIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x2989310", Offset = "0x2988710", VA = "0x182989310")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x2989270", Offset = "0x2988670", VA = "0x182989270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x2988FA0", Offset = "0x29883A0", VA = "0x182988FA0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x2988DA0", Offset = "0x29881A0", VA = "0x182988DA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x2988E30", Offset = "0x2988230", VA = "0x182988E30")]
		public void EHOMCGHPBHE(AHKPLOLMABO CBPECCEKJOB, JFEKOCHNFPJ MIKGEIBIMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x2989B20", Offset = "0x2988F20", VA = "0x182989B20")]
		public void LPEOMHLIOKB(AHKPLOLMABO CBPECCEKJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x2989C10", Offset = "0x2989010", VA = "0x182989C10")]
		internal void MNCEJMAAFEG(KIPPNPAOMDE OJNFGJAPBNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x29895E0", Offset = "0x29889E0", VA = "0x1829895E0")]
		private void KNENKCHDKIJ(KIPPNPAOMDE OJNFGJAPBNC, int ODMCPPPIBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x2988FF0", Offset = "0x29883F0", VA = "0x182988FF0")]
		private void GPDKHHBAODH(ANIKAMAEHJJ HDLEMAAGOPN, HPEJEEPDKIC JDLEDOMGLLJ, JHBOIBABLAL JCKODLGNJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x2988C20", Offset = "0x2988020", VA = "0x182988C20")]
		private KFNMGDMNBOO DIMAMDOBADA(ANIKAMAEHJJ HDLEMAAGOPN, HPEJEEPDKIC JDLEDOMGLLJ)
		{
			return default(KFNMGDMNBOO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x29894F0", Offset = "0x29888F0", VA = "0x1829894F0")]
		private JHBOIBABLAL KBMGPBGGPOI(KFNMGDMNBOO OCNEBCDHANP, ANIKAMAEHJJ HDLEMAAGOPN, HPEJEEPDKIC JDLEDOMGLLJ)
		{
			return default(JHBOIBABLAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x2989EF0", Offset = "0x29892F0", VA = "0x182989EF0")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[HAMPPOKOPOP(typeof(LOEKKAPPCFD), new string[] { })]
public class DDLMIFOPMDB : GBCNOEIKEOL, IJGJDJPFIAJ, LOEKKAPPCFD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[CompilerGenerated]
	private sealed class CJLBHMODDMJ : IEnumerable<MBEDCJLMHEO>, IEnumerable, IEnumerator<MBEDCJLMHEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private MBEDCJLMHEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public DDLMIFOPMDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private MBEDCJLMHEO splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public MBEDCJLMHEO <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		private MBEDCJLMHEO System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0x735A00", Offset = "0x734E00", VA = "0x180735A00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MBEDCJLMHEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7950", Offset = "0x2BC6D50", VA = "0x182BC7950", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x913060", Offset = "0x912460", VA = "0x180913060")]
		[DebuggerHidden]
		public CJLBHMODDMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC77A0", Offset = "0x2BC6BA0", VA = "0x182BC77A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7910", Offset = "0x2BC6D10", VA = "0x182BC7910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7860", Offset = "0x2BC6C60", VA = "0x182BC7860", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MBEDCJLMHEO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7860", Offset = "0x2BC6C60", VA = "0x182BC7860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private DDOLHFHMLOP CGCNGCLEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private BCGNHAHBMMD LJJIMBOPFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private ObjectInstantiationService IIPJHFKNDGJ;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EntityManager BFILENFCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x2FC43E0", Offset = "0x2FC37E0", VA = "0x182FC43E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private PHIPKIFAENI PDFOFNPFHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x2FC44C0", Offset = "0x2FC38C0", VA = "0x182FC44C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3F30", Offset = "0x2FC3330", VA = "0x182FC3F30", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4580", Offset = "0x2FC3980", VA = "0x182FC4580", Slot = "5")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3DC0", Offset = "0x2FC31C0", VA = "0x182FC3DC0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4770", Offset = "0x2FC3B70", VA = "0x182FC4770")]
	private void MMAOFIFDHGH(Entity LFMBJFHAJEM, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3FC0", Offset = "0x2FC33C0", VA = "0x182FC3FC0", Slot = "14")]
	public MBEDCJLMHEO HNGEDIPEFKF()
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4C50", Offset = "0x2FC4050", VA = "0x182FC4C50", Slot = "10")]
	public void ONMPADPNFGL(MBEDCJLMHEO LKHNLAILFFL, FOIGNAKKMCJ BHGFJLDJJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3E70", Offset = "0x2FC3270", VA = "0x182FC3E70", Slot = "9")]
	public FOIGNAKKMCJ EIMBJPIMGJD(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(FOIGNAKKMCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC40E0", Offset = "0x2FC34E0", VA = "0x182FC40E0", Slot = "11")]
	public MBEDCJLMHEO JELNCJOHJPG(MBEDCJLMHEO MDGOLEBJDDG, [Optional] Vector3? PICDPPHNNLH, [Optional] Quaternion? IHCJBCJFELL, [Optional] Vector3? AFPPFOOOELL)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3B40", Offset = "0x2FC2F40", VA = "0x182FC3B40", Slot = "15")]
	public MBEDCJLMHEO AEBDBMHDFKJ(MBEDCJLMHEO PIPOCKGHLKK, int EGNHJGKABLC, [Optional] Vector3? PICDPPHNNLH, [Optional] Quaternion? IHCJBCJFELL, [Optional] Vector3? AFPPFOOOELL)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4680", Offset = "0x2FC3A80", VA = "0x182FC4680", Slot = "7")]
	public MBEDCJLMHEO MBJMINBJNOB(MBEDCJLMHEO PIPOCKGHLKK, int EGNHJGKABLC)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4B90", Offset = "0x2FC3F90", VA = "0x182FC4B90", Slot = "16")]
	public void OKKIBFDCACD(MBEDCJLMHEO PIPOCKGHLKK, MBEDCJLMHEO HIBFCDNCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x2FC49F0", Offset = "0x2FC3DF0", VA = "0x182FC49F0", Slot = "12")]
	public void MPFKOEEEACC(MBEDCJLMHEO PIPOCKGHLKK, int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3C20", Offset = "0x2FC3020", VA = "0x182FC3C20", Slot = "17")]
	public void CGIOCEHLJPO(MBEDCJLMHEO PIPOCKGHLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3B80", Offset = "0x2FC2F80", VA = "0x182FC3B80", Slot = "8")]
	public int AJEIBGLJBFG(MBEDCJLMHEO PIPOCKGHLKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4D10", Offset = "0x2FC4110", VA = "0x182FC4D10", Slot = "6")]
	[IteratorStateMachine(typeof(CJLBHMODDMJ))]
	public IEnumerable<MBEDCJLMHEO> OPIFHIDCKKK(MBEDCJLMHEO PIPOCKGHLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4430", Offset = "0x2FC3830", VA = "0x182FC4430")]
	private bool KGJONKDKNJI(MBEDCJLMHEO PIPOCKGHLKK, out NativeArray<Entity> BOGHIFKGACA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4020", Offset = "0x2FC3420", VA = "0x182FC4020")]
	private NativeArray<Entity> HNMNGKDAFBE(MBEDCJLMHEO PIPOCKGHLKK)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public DDLMIFOPMDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[DCBDIJCKLAD(IKIGKMLBEFF.LoadInstance)]
[HAMPPOKOPOP(typeof(JNCEDOJAEEO), new string[] { })]
internal sealed class JNCEDOJAEEO : GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private BHHDNNCMGLM ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private TransformOwnershipPhase BBFGLLAHILF;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private MKDEFAJNDJH LJDGEIMOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1E30", Offset = "0x2DF1230", VA = "0x182DF1E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1E80", Offset = "0x2DF1280", VA = "0x182DF1E80", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x2DF21D0", Offset = "0x2DF15D0", VA = "0x182DF21D0")]
	public void PLANKGEDEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1F00", Offset = "0x2DF1300", VA = "0x182DF1F00")]
	public void HHDDIHAOJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public JNCEDOJAEEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public readonly struct HCBCHLAIJFO : IEquatable<HCBCHLAIJFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly int ODMCPPPIBBH;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Type BELDJPAAHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x2DE1B00", Offset = "0x2DE0F00", VA = "0x182DE1B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1CE0", Offset = "0x2DE10E0", VA = "0x182DE1CE0")]
	public HCBCHLAIJFO(Type OGILDIMGIOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1C80", Offset = "0x2DE1080", VA = "0x182DE1C80")]
	public static HCBCHLAIJFO HPHCHABBDNG(Type OGILDIMGIOH)
	{
		return default(HCBCHLAIJFO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1C60", Offset = "0x2DE1060", VA = "0x182DE1C60")]
	public static Type HPHCHABBDNG(HCBCHLAIJFO IGELLPOEMHM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x11369F0", Offset = "0x1135DF0", VA = "0x1811369F0")]
	public static bool BOBJELOEACN(HCBCHLAIJFO HFOFADIOHHP, HCBCHLAIJFO GFCGIJPPCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x11369F0", Offset = "0x1135DF0", VA = "0x1811369F0")]
	public static bool GPCPOEGFAHL(HCBCHLAIJFO HFOFADIOHHP, HCBCHLAIJFO GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x877E40", Offset = "0x877240", VA = "0x180877E40", Slot = "4")]
	public bool Equals(HCBCHLAIJFO MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1BE0", Offset = "0x2DE0FE0", VA = "0x182DE1BE0", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1CB0", Offset = "0x2DE10B0", VA = "0x182DE1CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public static class FFNIKEEFGPM
{
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private static Dictionary<Type, int> GICKGNFCAPI;

	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private static List<Type> LDCOEIKCNFB;

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD970", Offset = "0x2DDCD70", VA = "0x182DDD970")]
	static FFNIKEEFGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x2618E00", Offset = "0x2618200", VA = "0x182618E00")]
	public static bool AGMLDLCGDGN<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD4C0", Offset = "0x2DDC8C0", VA = "0x182DDD4C0")]
	public static bool AGMLDLCGDGN(Type OGILDIMGIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD530", Offset = "0x2DDC930", VA = "0x182DDD530")]
	private static bool AGMLDLCGDGN(Type OGILDIMGIOH, out int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x2618E90", Offset = "0x2618290", VA = "0x182618E90")]
	public static int DFDIJCKOMFL<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD6A0", Offset = "0x2DDCAA0", VA = "0x182DDD6A0")]
	public static int DFDIJCKOMFL(Type OGILDIMGIOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x2618F20", Offset = "0x2618320", VA = "0x182618F20")]
	public static bool OBCGBBDEENH<T>(out int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD7B0", Offset = "0x2DDCBB0", VA = "0x182DDD7B0")]
	public static bool OBCGBBDEENH(Type OGILDIMGIOH, out int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD710", Offset = "0x2DDCB10", VA = "0x182DDD710")]
	public static Type MKLBNKEKMJE(int EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD850", Offset = "0x2DDCC50", VA = "0x182DDD850")]
	public static bool OBCGBBDEENH(int EGNHJGKABLC, out Type OGILDIMGIOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[DefaultMember("Item")]
public struct DGECPDIGKGH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private T[] HIDEHJGLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private int OEMPOIHBNFL;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public int JJINKJIBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x899EA0", Offset = "0x8992A0", VA = "0x180899EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x1F09FC0", Offset = "0x1F093C0", VA = "0x181F09FC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> DNIFLPOBKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x29A1AC0", Offset = "0x29A0EC0", VA = "0x1829A1AC0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0xD7F230", Offset = "0xD7E630", VA = "0x180D7F230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x29A1B60", Offset = "0x29A0F60", VA = "0x1829A1B60")]
	public DGECPDIGKGH(int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x29A1A10", Offset = "0x29A0E10", VA = "0x1829A1A10")]
	public int JPAOIDBBCIF(T LPJDDLMPNCG, int LOEMONDJCMM, int EJMNNLNLAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x29A1950", Offset = "0x29A0D50", VA = "0x1829A1950", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[DefaultMember("Item")]
public struct HEFEHBFLBJH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private global::DGECPDIGKGH<T> HIDEHJGLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private int OEMPOIHBNFL;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x32E55D0", Offset = "0x32E49D0", VA = "0x1832E55D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int JJINKJIBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x72B020", Offset = "0x72A420", VA = "0x18072B020")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x32E63E0", Offset = "0x32E57E0", VA = "0x1832E63E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int CMKLLLCOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x26ED5D0", Offset = "0x26EC9D0", VA = "0x1826ED5D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x32E6430", Offset = "0x32E5830", VA = "0x1832E6430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x32E50C0", Offset = "0x32E44C0", VA = "0x1832E50C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> DNIFLPOBKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x32E6290", Offset = "0x32E5690", VA = "0x1832E6290")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x32E64F0", Offset = "0x32E58F0", VA = "0x1832E64F0")]
	public HEFEHBFLBJH(int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x32E5580", Offset = "0x32E4980", VA = "0x1832E5580")]
	public T DAGKHIGBMKO(int EGNHJGKABLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x32E5100", Offset = "0x32E4500", VA = "0x1832E5100")]
	public void BPKBEGFGHID(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x32E5410", Offset = "0x32E4810", VA = "0x1832E5410")]
	public void CNLOOLKEGEC(Span<T> BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x32E4D90", Offset = "0x32E4190", VA = "0x1832E4D90")]
	public void AGMLDLCGDGN(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x32E5850", Offset = "0x32E4C50", VA = "0x1832E5850")]
	private void HKOAAAHAEOP(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x32E5CA0", Offset = "0x32E50A0", VA = "0x1832E5CA0")]
	public void JHAKILBFFKF(Span<T> BNJGAHEFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x32E5A40", Offset = "0x32E4E40", VA = "0x1832E5A40")]
	public void IFBMNDOAGOK(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x32E4EA0", Offset = "0x32E42A0", VA = "0x1832E4EA0")]
	public void AGPAMOFMIOH(int HOOEGCCNGHE, int FHNIHLGHOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x32E6230", Offset = "0x32E5630", VA = "0x1832E6230")]
	public void MDGCJLLGPHG(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x32E4B80", Offset = "0x32E3F80", VA = "0x1832E4B80")]
	public void AALDKJEFAAP(int HOOEGCCNGHE, int FHNIHLGHOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x32E5AA0", Offset = "0x32E4EA0", VA = "0x1832E5AA0")]
	public void IMFLLMIHACN(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x32E5F70", Offset = "0x32E5370", VA = "0x1832E5F70")]
	public void LAAFGIGGPPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x32E5EE0", Offset = "0x32E52E0", VA = "0x1832E5EE0")]
	public int JPAOIDBBCIF(T LPJDDLMPNCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x32E57F0", Offset = "0x32E4BF0", VA = "0x1832E57F0")]
	public bool GMBMHDKFMPB(T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x32E57A0", Offset = "0x32E4BA0", VA = "0x1832E57A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x32E6480", Offset = "0x32E5880", VA = "0x1832E6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x32E59D0", Offset = "0x32E4DD0", VA = "0x1832E59D0")]
	public static Span<T> HPHCHABBDNG(global::HEFEHBFLBJH<T> BDHPAGCMKHB)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x32E5170", Offset = "0x32E4570", VA = "0x1832E5170")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CJJPFPPEHHF(int LPJDDLMPNCG, int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void CLAEGEOCGIN(int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x32E52B0", Offset = "0x32E46B0", VA = "0x1832E52B0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CLAEGEOCGIN(int OEMPOIHBNFL, int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x32E5B60", Offset = "0x32E4F60", VA = "0x1832E5B60")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void IODMPIPCPDC(int LPJDDLMPNCG, int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x32E6030", Offset = "0x32E5430", VA = "0x1832E6030")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void LOKLOLOCMAH(int HOOEGCCNGHE, int FHNIHLGHOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x32E5660", Offset = "0x32E4A60", VA = "0x1832E5660")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void DLBGFCAMAFL(int LPJDDLMPNCG, int OEMPOIHBNFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public struct HIEGLBAPNMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private const int PGAOCPPDOPO = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NativeList<Entity> ABBIPALBHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private TransformAccessArray HFKINOFBOBG;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE30D0", Offset = "0x2DE24D0", VA = "0x182DE30D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> LAAACCFEMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0xA40110", Offset = "0xA3F510", VA = "0x180A40110")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray MIBOBNDGGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool AMOPNJPCIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3020", Offset = "0x2DE2420", VA = "0x182DE3020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3180", Offset = "0x2DE2580", VA = "0x182DE3180")]
	public HIEGLBAPNMB(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x2DE30E0", Offset = "0x2DE24E0", VA = "0x182DE30E0")]
	public Entity JMIOABGPGOA(int EGNHJGKABLC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3040", Offset = "0x2DE2440", VA = "0x182DE3040")]
	public Transform GEBNBHFHKBB(int EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3130", Offset = "0x2DE2530", VA = "0x182DE3130")]
	public void NMGICPLAADH(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2E90", Offset = "0x2DE2290", VA = "0x182DE2E90")]
	public int AGMLDLCGDGN(Transform CACALPHNCBH, Entity LCLDFKAJPDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3050", Offset = "0x2DE2450", VA = "0x182DE3050")]
	public int IFBMNDOAGOK(int EGNHJGKABLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2FA0", Offset = "0x2DE23A0", VA = "0x182DE2FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2F60", Offset = "0x2DE2360", VA = "0x182DE2F60")]
	private void BKGDIIMJHBF(int HELIDNDMHAL = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal class JIDPFHKCIFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private NativeHashMap<HCBCHLAIJFO, int2> FGCLFJNNFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private NativeList<byte> NPOGECPDPEK;

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0F20", Offset = "0x2DF0320", VA = "0x182DF0F20")]
	public JIDPFHKCIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x2DF06F0", Offset = "0x2DEFAF0", VA = "0x182DF06F0")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	public void EFMALMFMJGL<T>(T LPJDDLMPNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	public T MKLBNKEKMJE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF07F0", Offset = "0x2DEFBF0", VA = "0x182DF07F0")]
	public void EFMALMFMJGL(Type OGILDIMGIOH, HAMGOKKMMPI LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0BF0", Offset = "0x2DEFFF0", VA = "0x182DF0BF0")]
	public HAMGOKKMMPI MKLBNKEKMJE(Type OGILDIMGIOH)
	{
		return default(HAMGOKKMMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0B50", Offset = "0x2DEFF50", VA = "0x182DF0B50")]
	private NativeArray<byte> KEAPDLLIILM(int2 OBGFBPBPFBM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0750", Offset = "0x2DEFB50", VA = "0x182DF0750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0A30", Offset = "0x2DEFE30", VA = "0x182DF0A30", Slot = "1")]
	~JIDPFHKCIFG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D9")]
public struct GFDFFMNJOOL<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	internal static T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	public static global::GFDFFMNJOOL<T> HPHCHABBDNG(T LPJDDLMPNCG)
	{
		return default(global::GFDFFMNJOOL<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	public static T HPHCHABBDNG(global::GFDFFMNJOOL<T> LGCPJJBBDLH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public static class BIGJNAGGLDA
{
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private static readonly JIDPFHKCIFG DNBKINHFIED;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1190", Offset = "0x2FB0590", VA = "0x182FB1190")]
	internal static void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void EFMALMFMJGL<T>(T LPJDDLMPNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1200", Offset = "0x2FB0600", VA = "0x182FB1200")]
	public static void EFMALMFMJGL(Type OGILDIMGIOH, HAMGOKKMMPI LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T MKLBNKEKMJE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x2FB12A0", Offset = "0x2FB06A0", VA = "0x182FB12A0")]
	public static HAMGOKKMMPI MKLBNKEKMJE(Type OGILDIMGIOH)
	{
		return default(HAMGOKKMMPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class BNOMAFMOKID : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	public static readonly BNOMAFMOKID EBMJMAANCBN;

	[Cpp2IlInjected.Token(Token = "0x6000D2A")]
	[Cpp2IlInjected.Address(RVA = "0x2FB28F0", Offset = "0x2FB1CF0", VA = "0x182FB28F0", Slot = "4")]
	public bool Equals(LinkedEntityGroup GKBCEINHOJB, LinkedEntityGroup LAMHEDHCIJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2910", Offset = "0x2FB1D10", VA = "0x182FB2910", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup NBNOMDAKOCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public BNOMAFMOKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class LEKCMOIFDJC
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("DEBUG_BUILD")]
	public static void DEKJNLGBJMC(in Vector3 PICDPPHNNLH, in Quaternion IHCJBCJFELL, in Vector3 AFPPFOOOELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("DEBUG_BUILD")]
	public static void MLNIKCAHIMN(in Vector3 PEMADDOMMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("DEBUG_BUILD")]
	public static void MIHCFEKNPJO(in Quaternion IHCJBCJFELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("DEBUG_BUILD")]
	public static void FKHACOJEBOB(in Vector3 JJGPMNKMNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("DEBUG_BUILD")]
	public static void KDENKEMFDDK(in Vector3 JJGPMNKMNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("DEBUG_BUILD")]
	public static void CAHEOEILNAF(in float NKEPFBEFOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x296A900", Offset = "0x2969D00", VA = "0x18296A900")]
	[Conditional("DEBUG_BUILD")]
	public static void LBDEMIFKHGH(in float3 LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("DEBUG_BUILD")]
	public static void DINAOCNANKJ(in float LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x296A800", Offset = "0x2969C00", VA = "0x18296A800")]
	[Conditional("DEBUG_BUILD")]
	public static void DINAOCNANKJ(in Vector3 LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x296A850", Offset = "0x2969C50", VA = "0x18296A850")]
	[Conditional("DEBUG_BUILD")]
	public static void DINAOCNANKJ(in Quaternion LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x296A8F0", Offset = "0x2969CF0", VA = "0x18296A8F0")]
	[Conditional("DEBUG_BUILD")]
	public static void KJOKPEHPPDA(in float LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x296A8B0", Offset = "0x2969CB0", VA = "0x18296A8B0")]
	[Conditional("DEBUG_BUILD")]
	public static void KJOKPEHPPDA(in Vector3 LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x296A880", Offset = "0x2969C80", VA = "0x18296A880")]
	[Conditional("DEBUG_BUILD")]
	public static void KJOKPEHPPDA(in Quaternion LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public LEKCMOIFDJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public struct EBCGMCIBBDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	public Entity LCLDFKAJPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	public Entity LOFGAAGHIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	public Entity BJNIPOLNMLD;

	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x2FC83A0", Offset = "0x2FC77A0", VA = "0x182FC83A0")]
	public EBCGMCIBBDB(Entity LCLDFKAJPDK, Entity LOFGAAGHIJI, Entity BJNIPOLNMLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8340", Offset = "0x2FC7740", VA = "0x182FC8340")]
	public static EBCGMCIBBDB HPHCHABBDNG((Entity entity, Entity oldParent, Entity newParent) HFOFEEILCNC)
	{
		return default(EBCGMCIBBDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8380", Offset = "0x2FC7780", VA = "0x182FC8380")]
	public void LOCCMPKKMAH(out Entity LCLDFKAJPDK, out Entity LOFGAAGHIJI, out Entity BJNIPOLNMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct LBCACEFDDPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	public Entity LCLDFKAJPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	public Entity GGEKFPEBLKN;

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0xCD29D0", Offset = "0xCD1DD0", VA = "0x180CD29D0")]
	public LBCACEFDDPD(Entity LCLDFKAJPDK, Entity GGEKFPEBLKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x296A6B0", Offset = "0x2969AB0", VA = "0x18296A6B0")]
	public static LBCACEFDDPD HPHCHABBDNG((Entity entity, Entity parent) HFOFEEILCNC)
	{
		return default(LBCACEFDDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x296A6E0", Offset = "0x2969AE0", VA = "0x18296A6E0")]
	public void LOCCMPKKMAH(out Entity LCLDFKAJPDK, out Entity GGEKFPEBLKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
public struct LJANFEDEEMJ<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private GCHandle IGELLPOEMHM;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public bool HMPBOLKDGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D43")]
		[Cpp2IlInjected.Address(RVA = "0x2DEDA20", Offset = "0x2DECE20", VA = "0x182DEDA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x3351BA0", Offset = "0x3350FA0", VA = "0x183351BA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x3351C40", Offset = "0x3351040", VA = "0x183351C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x3351D00", Offset = "0x3351100", VA = "0x183351D00")]
	public LJANFEDEEMJ(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x3351B70", Offset = "0x3350F70", VA = "0x183351B70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public enum PIJDLNNHGJO
{
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
public struct BCAIIOMBBGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	public PIJDLNNHGJO EAAMFEFLALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	public int KLIKLNGCPEO;

	[Cpp2IlInjected.Token(Token = "0x6000D47")]
	[Cpp2IlInjected.Address(RVA = "0x735A30", Offset = "0x734E30", VA = "0x180735A30")]
	public BCAIIOMBBGG(PIJDLNNHGJO EAAMFEFLALL, int KLIKLNGCPEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x296C050", Offset = "0x296B450", VA = "0x18296C050")]
	public static BCAIIOMBBGG HPHCHABBDNG((PIJDLNNHGJO eventType, int eventIndex) GKBCEINHOJB)
	{
		return default(BCAIIOMBBGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x2FB00D0", Offset = "0x2FAF4D0", VA = "0x182FB00D0")]
	public void LOCCMPKKMAH(out PIJDLNNHGJO EAAMFEFLALL, out int KLIKLNGCPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[HAMPPOKOPOP(typeof(CIGLDIACENF), new string[] { })]
public sealed class HNAKDCLIHKP : CIGLDIACENF, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private EMJHKMNAGIL NDJDLGONCJN;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3DD0", Offset = "0x2DE31D0", VA = "0x182DE3DD0", Slot = "5")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3D30", Offset = "0x2DE3130", VA = "0x182DE3D30")]
	public bool EEMPOIEDICE(in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, float CBFODBDKBEK, Allocator FKHAEPDPDAI, out NativeArray<Entity> ABBIPALBHCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public HNAKDCLIHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3D30", Offset = "0x2DE3130", VA = "0x182DE3D30", Slot = "4")]
	private bool HDJKGDBJPLB(in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, float CBFODBDKBEK, Allocator FKHAEPDPDAI, out NativeArray<Entity> ABBIPALBHCK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[NDAPPBGAMDM]
[UpdateInGroup(typeof(JMEOBNBNAPP))]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
internal sealed class DEGDBCALKJL : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000D4E")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4DA0", Offset = "0x2FC41A0", VA = "0x182FC4DA0", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public DEGDBCALKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[NDAPPBGAMDM]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
[UpdateInGroup(typeof(JCEOGDIEBAB))]
public sealed class IJPNANPPBIP : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000D51")]
	[Cpp2IlInjected.Address(RVA = "0x2DEAF90", Offset = "0x2DEA390", VA = "0x182DEAF90", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public IJPNANPPBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[NDAPPBGAMDM]
[UpdateInGroup(typeof(NHCLKIBEPDE))]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
internal sealed class HPCKAFJHAFO : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000D54")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3E20", Offset = "0x2DE3220", VA = "0x182DE3E20", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public HPCKAFJHAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class FGPJLPEHPGE : LLPKLCJBNBL
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public FGPJLPEHPGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[NDAPPBGAMDM]
[ExecuteAlways]
[OKPMAHGBOHA(IKIGKMLBEFF.LoadInstance)]
[UpdateInGroup(typeof(BAOCFBCJAAC))]
internal sealed class FJLFIPEFALG : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000D59")]
	[Cpp2IlInjected.Address(RVA = "0x2DDDF60", Offset = "0x2DDD360", VA = "0x182DDDF60", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x296DEB0", Offset = "0x296D2B0", VA = "0x18296DEB0")]
	public FJLFIPEFALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[KLLNJHKGGCN(typeof(AuthoredLocalPoseData))]
public sealed class NNDEKBJMBBA : HHKFFCCLOEM
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x296F7C0", Offset = "0x296EBC0", VA = "0x18296F7C0", Slot = "8")]
	protected override bool JAPPKCEDIFG(ReadOnlySpan<AuthoredLocalPoseData> BNJGAHEFJPB, NKBHFLFMPJO JCDMDNEMCAL, out ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x296F700", Offset = "0x296EB00", VA = "0x18296F700", Slot = "9")]
	protected override bool BCGHMNNLDCA(int NHBDMCDLELK, Span<AuthoredLocalPoseData> BNJGAHEFJPB, in ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x296F840", Offset = "0x296EC40", VA = "0x18296F840")]
	public NNDEKBJMBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[KLLNJHKGGCN(typeof(LocalPoseData))]
public sealed class OFJFEJBNOBP : KCNKLMKHKBD
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x2971300", Offset = "0x2970700", VA = "0x182971300", Slot = "8")]
	protected override bool JAPPKCEDIFG(ReadOnlySpan<LocalPoseData> BNJGAHEFJPB, NKBHFLFMPJO JCDMDNEMCAL, out ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x2971240", Offset = "0x2970640", VA = "0x182971240", Slot = "9")]
	protected override bool BCGHMNNLDCA(int NHBDMCDLELK, Span<LocalPoseData> BNJGAHEFJPB, in ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x2971380", Offset = "0x2970780", VA = "0x182971380")]
	public OFJFEJBNOBP()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Preserve]
	internal class _RRAssemblyIndex : AAHOHGIJHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x2BE53D0", Offset = "0x2BE47D0", VA = "0x182BE53D0", Slot = "6")]
		public sealed override void MNNDBLCHNEL(CKMMIMLGKKB MIKGEIBIMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4900", Offset = "0x2BE3D00", VA = "0x182BE4900", Slot = "4")]
		public sealed override void KLMOEJEAKPE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x6000D65")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4270", Offset = "0x2DF3670", VA = "0x182DF4270")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3F20", Offset = "0x2DF3320", VA = "0x182DF3F20")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001ED")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000D69")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001EE")]
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
