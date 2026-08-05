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
	[Cpp2IlInjected.Address(RVA = "0x3015140", Offset = "0x3013B40", VA = "0x183015140")]
	static HGGDMFKIBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x36C4D10", Offset = "0x36C3710", VA = "0x1836C4D10")]
	public static void KHPMEFGGEHC<T>(T EBCEJCLCIMI, ref T AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3014EA0", Offset = "0x30138A0", VA = "0x183014EA0")]
	public static void KHPMEFGGEHC(FixedString32 EBCEJCLCIMI, ref string AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3014FF0", Offset = "0x30139F0", VA = "0x183014FF0")]
	public static void KHPMEFGGEHC(string EBCEJCLCIMI, ref FixedString32 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3014F70", Offset = "0x3013970", VA = "0x183014F70")]
	public static void KHPMEFGGEHC(FixedString64 EBCEJCLCIMI, ref string AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x30150E0", Offset = "0x3013AE0", VA = "0x1830150E0")]
	public static void KHPMEFGGEHC(string EBCEJCLCIMI, ref FixedString64 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3014E10", Offset = "0x3013810", VA = "0x183014E10")]
	public static void KHPMEFGGEHC(BODJKGEBDLM EBCEJCLCIMI, ref Vector3 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3014E40", Offset = "0x3013840", VA = "0x183014E40")]
	public static void KHPMEFGGEHC(Vector3 EBCEJCLCIMI, ref BODJKGEBDLM AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3014ED0", Offset = "0x30138D0", VA = "0x183014ED0")]
	public static void KHPMEFGGEHC(MJNCEHHMBIG EBCEJCLCIMI, ref Vector4 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3014F00", Offset = "0x3013900", VA = "0x183014F00")]
	public static void KHPMEFGGEHC(Vector4 EBCEJCLCIMI, ref MJNCEHHMBIG AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3014ED0", Offset = "0x30138D0", VA = "0x183014ED0")]
	public static void KHPMEFGGEHC(MJNCEHHMBIG EBCEJCLCIMI, ref Quaternion AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3014F00", Offset = "0x3013900", VA = "0x183014F00")]
	public static void KHPMEFGGEHC(Quaternion EBCEJCLCIMI, ref MJNCEHHMBIG AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3014FC0", Offset = "0x30139C0", VA = "0x183014FC0")]
	public static void KHPMEFGGEHC(BODJKGEBDLM EBCEJCLCIMI, ref float3 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3014E40", Offset = "0x3013840", VA = "0x183014E40")]
	public static void KHPMEFGGEHC(float3 EBCEJCLCIMI, ref BODJKGEBDLM AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3014DD0", Offset = "0x30137D0", VA = "0x183014DD0")]
	public static void KHPMEFGGEHC(MJNCEHHMBIG EBCEJCLCIMI, ref float4 AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3014F00", Offset = "0x3013900", VA = "0x183014F00")]
	public static void KHPMEFGGEHC(float4 EBCEJCLCIMI, ref MJNCEHHMBIG AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3014DD0", Offset = "0x30137D0", VA = "0x183014DD0")]
	public static void KHPMEFGGEHC(MJNCEHHMBIG EBCEJCLCIMI, ref quaternion AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3015030", Offset = "0x3013A30", VA = "0x183015030")]
	public static void KHPMEFGGEHC(quaternion EBCEJCLCIMI, ref MJNCEHHMBIG AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x30150A0", Offset = "0x3013AA0", VA = "0x1830150A0")]
	public static void KHPMEFGGEHC(Entity EBCEJCLCIMI, ref CKDICGNIBHK AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3014FA0", Offset = "0x30139A0", VA = "0x183014FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JDFPNHDAOJJ HHNOCIKFPBE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x752CF0", Offset = "0x7516F0", VA = "0x180752CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2B29150", Offset = "0x2B27B50", VA = "0x182B29150", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
	public NKANJLHPBOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x31F8F00", Offset = "0x31F7900", VA = "0x1831F8F00", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x31F9140", Offset = "0x31F7B40", VA = "0x1831F9140")]
	[Preserve]
	private void FJOHEDNBPFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public AJHMDEDDOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3014B90", Offset = "0x3013590", VA = "0x183014B90", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public HEBLFKHFOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B337E0", Offset = "0x2B321E0", VA = "0x182B337E0")]
		public static ObjectModelConfigAsset FJIIOICABEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xDC40C0", Offset = "0xDC2AC0", VA = "0x180DC40C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4522BB0", Offset = "0x45215B0", VA = "0x184522BB0")]
			public static KHMECMDAALD HLOKFJBEBKF(int KBKKOGKPBAI)
			{
				return default(KHMECMDAALD);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4522FA0", Offset = "0x45219A0", VA = "0x184522FA0")]
			private static void KDJBEAEGEDG(MBEDCJLMHEO ICMMFLADFNF, MBEDCJLMHEO IDPCFPPKJBE, KHMECMDAALD HBKLDKCICEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x45231B0", Offset = "0x4521BB0", VA = "0x1845231B0")]
			public static int NNNCBCDMHIH(GameObject DLNMCGFEPOP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x4523130", Offset = "0x4521B30", VA = "0x184523130")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B34B10", Offset = "0x2B33510", VA = "0x182B34B10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B33C80", Offset = "0x2B32680", VA = "0x182B33C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static OJMGIHLPABJ BJCANCIPCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B33FF0", Offset = "0x2B329F0", VA = "0x182B33FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B348F0", Offset = "0x2B332F0", VA = "0x182B348F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool LMGGCGGPPIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2B34DC0", Offset = "0x2B337C0", VA = "0x182B34DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static FJEOEPCCLME PICFDDKMBKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B33D60", Offset = "0x2B32760", VA = "0x182B33D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static JDFPNHDAOJJ HHNOCIKFPBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B35440", Offset = "0x2B33E40", VA = "0x182B35440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static NDFDMPICGAG CIJDLCNILKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B34870", Offset = "0x2B33270", VA = "0x182B34870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static OECKLJAFLCL PKCMHFFGIFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B34110", Offset = "0x2B32B10", VA = "0x182B34110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static DDOLHFHMLOP DIPPIPKFCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B33880", Offset = "0x2B32280", VA = "0x182B33880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static CLIHAPFPPDO EHJMHIENHGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B346D0", Offset = "0x2B330D0", VA = "0x182B346D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool PKNHJACHMKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B351B0", Offset = "0x2B33BB0", VA = "0x182B351B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool HNOCEMCIMKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B33EC0", Offset = "0x2B328C0", VA = "0x182B33EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool FDLOOBIMIDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2B34BD0", Offset = "0x2B335D0", VA = "0x182B34BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool BABLNMMPFNP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2B33E60", Offset = "0x2B32860", VA = "0x182B33E60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B35020", Offset = "0x2B33A20", VA = "0x182B35020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool OFLAHCDJPDM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2B33E00", Offset = "0x2B32800", VA = "0x182B33E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B35290", Offset = "0x2B33C90", VA = "0x182B35290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action KOKLFFIBABB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2B34190", Offset = "0x2B32B90", VA = "0x182B34190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B34F20", Offset = "0x2B33920", VA = "0x182B34F20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B34490", Offset = "0x2B32E90", VA = "0x182B34490")]
		public static MBEDCJLMHEO HKKALCMCNLF(GameObject DLNMCGFEPOP)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B34B70", Offset = "0x2B33570", VA = "0x182B34B70")]
		public static bool LAKKFOOAFLA(ByteString EICPLPLLHGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B34290", Offset = "0x2B32C90", VA = "0x182B34290")]
		public static EMFDOJECCDF HABBDICMEHL(KHMECMDAALD HBKLDKCICEJ)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B34580", Offset = "0x2B32F80", VA = "0x182B34580")]
		public static (ByteString, IDisposable) HLHCEBOKDMG()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B352F0", Offset = "0x2B33CF0", VA = "0x182B352F0")]
		public static (ByteString, IDisposable) NFKGFNBBBGA(IEnumerable<MBEDCJLMHEO> LLDOOGBMLGH)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B35080", Offset = "0x2B33A80", VA = "0x182B35080")]
		public static bool LOKBJALKGIO(GameObject DLNMCGFEPOP, out KHMECMDAALD HBKLDKCICEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B34750", Offset = "0x2B33150", VA = "0x182B34750")]
		public static bool IAKKNNBJDOH(IEnumerable<BMLJODFLIKN> JGGHOCFLFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B343B0", Offset = "0x2B32DB0", VA = "0x182B343B0")]
		public static void HHABOMGLDEF(bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B339E0", Offset = "0x2B323E0", VA = "0x182B339E0")]
		public static Task ALFGEPCJFIN(bool EFCPHECCPHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B33900", Offset = "0x2B32300", VA = "0x182B33900")]
		private static OJMGIHLPABJ AHNJBIMGOKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B33B60", Offset = "0x2B32560", VA = "0x182B33B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3A650", Offset = "0x2B39050", VA = "0x182B3A650")]
		public static bool GMGNOMIKBCG(APKFPLGDLPH NKLGMCFCMKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A120", Offset = "0x2B38B20", VA = "0x182B3A120")]
		public static APKFPLGDLPH EHOMCGHPBHE(GameObject DLNMCGFEPOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A350", Offset = "0x2B38D50", VA = "0x182B3A350")]
		public static APKFPLGDLPH EHOMCGHPBHE(GameObject DLNMCGFEPOP, KHMECMDAALD HBKLDKCICEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A550", Offset = "0x2B38F50", VA = "0x182B3A550")]
		public static bool FCLGIKKCKBI(GameObject JNONJGMFMNE, string KJMIGPLGEHH, bool MPPBOICGLCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B39F20", Offset = "0x2B38920", VA = "0x182B39F20")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void BBCOBPDEPPC(GameObject JNONJGMFMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A700", Offset = "0x2B39100", VA = "0x182B3A700")]
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
			[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public MBEDCJLMHEO BEFNGGLNHMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x731A00", Offset = "0x730400", VA = "0x180731A00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(MBEDCJLMHEO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x27B50E0", Offset = "0x27B3AE0", VA = "0x1827B50E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
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
			[Cpp2IlInjected.Address(RVA = "0x3217890", Offset = "0x3216290", VA = "0x183217890", Slot = "15")]
			get
			{
				return default(MBEDCJLMHEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public EMFDOJECCDF JELKDBJJLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3217940", Offset = "0x3216340", VA = "0x183217940", Slot = "6")]
			get
			{
				return default(EMFDOJECCDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool CDOMMGFPCNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3217880", Offset = "0x3216280", VA = "0x183217880", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public BKLPIBADGOF FJJGKFADCDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9D9F90", Offset = "0x9D8990", VA = "0x1809D9F90", Slot = "7")]
			get
			{
				return default(BKLPIBADGOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private JDFPNHDAOJJ HHNOCIKFPBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x32175B0", Offset = "0x3215FB0", VA = "0x1832175B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private AMBNPJKGCOF KHMONBGGGOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3217690", Offset = "0x3216090", VA = "0x183217690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool MCOBJCCBOMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x800A50", VA = "0x180802050", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7CAE50", Offset = "0x7C9850", VA = "0x1807CAE50", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> ABFJJJEGBKB
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3217740", Offset = "0x3216140", VA = "0x183217740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3217970", Offset = "0x3216370", VA = "0x183217970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<APKFPLGDLPH> FFINDFOAIKL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x32177E0", Offset = "0x32161E0", VA = "0x1832177E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3217A10", Offset = "0x3216410", VA = "0x183217A10", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3216C40", Offset = "0x3215640", VA = "0x183216C40")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3217460", Offset = "0x3215E60", VA = "0x183217460", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x32170A0", Offset = "0x3215AA0", VA = "0x1832170A0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x32173D0", Offset = "0x3215DD0", VA = "0x1832173D0", Slot = "10")]
		public void OnEmbody(BHHDNNCMGLM ACFGKGFDFPL, MBEDCJLMHEO LMLBLIDPKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3217450", Offset = "0x3215E50", VA = "0x183217450", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x32171C0", Offset = "0x3215BC0", VA = "0x1832171C0", Slot = "12")]
		public void OnDisembody(bool IFNFKGMGNPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3216DC0", Offset = "0x32157C0", VA = "0x183216DC0")]
		private void FLFHNONBGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3216EC0", Offset = "0x32158C0", VA = "0x183216EC0")]
		private void JBMEJJDGLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3216F50", Offset = "0x3215950", VA = "0x183216F50")]
		private void KNBIFBCEKPM(bool GGAFPKHNBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3217040", Offset = "0x3215A40", VA = "0x183217040", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xFD8490", Offset = "0xFD6E90", VA = "0x180FD8490", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B44C30", Offset = "0x2B43630", VA = "0x182B44C30", Slot = "6")]
			get
			{
				return default(GODNFBOIBNJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B44BD0", Offset = "0x2B435D0", VA = "0x182B44BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x77AFB0", Offset = "0x7799B0", VA = "0x18077AFB0", Slot = "6")]
			get
			{
				return default(GODNFBOIBNJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F70", Offset = "0x7B3970", VA = "0x1807B4F70", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public MBEDCJLMHEO BEFNGGLNHMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xBFC260", Offset = "0xBFAC60", VA = "0x180BFC260", Slot = "5")]
			get
			{
				return default(MBEDCJLMHEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool CDOMMGFPCNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA4DB90", Offset = "0xA4C590", VA = "0x180A4DB90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA4DC10", Offset = "0xA4C610", VA = "0x180A4DC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity PBIJGMNGOLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal DDOLHFHMLOP DIPPIPKFCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal AMBNPJKGCOF EFDNLJHDPEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2D88420", Offset = "0x2D86E20", VA = "0x182D88420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D87FE0", Offset = "0x2D869E0", VA = "0x182D87FE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D87FF0", Offset = "0x2D869F0", VA = "0x182D87FF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D88110", Offset = "0x2D86B10", VA = "0x182D88110")]
		internal void KADCCJJCHBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D88490", Offset = "0x2D86E90", VA = "0x182D88490")]
		private bool OLONBOIGDEL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D880E0", Offset = "0x2D86AE0", VA = "0x182D880E0")]
		private void DGDHLAKHIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D87FF0", Offset = "0x2D869F0", VA = "0x182D87FF0")]
		internal void CKAJENPILHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D88530", Offset = "0x2D86F30", VA = "0x182D88530")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D88610", Offset = "0x2D87010", VA = "0x182D88610")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public BFHOGDONKCB CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public JDFPNHDAOJJ HHNOCIKFPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LBFECDDPFBD GPIPEIHLBFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LOFJFJMIAMG ILJEAOBGMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AMOPNJPCIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8AD650", Offset = "0x8AC050", VA = "0x1808AD650", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool OEENHAMLKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B24C40", Offset = "0x2B23640", VA = "0x182B24C40", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HNJBILHOIMC DMGKCMGPDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x94E3C0", Offset = "0x94CDC0", VA = "0x18094E3C0", Slot = "10")]
		get
		{
			return default(HNJBILHOIMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2B24DA0", Offset = "0x2B237A0", VA = "0x182B24DA0")]
	public static LAFHCMFONED IDIKGABNBEI(HJOJGGNKDFB JGMMDACFJLC, HKCMLMJLMKG CAAHBOFLBKP = HKCMLMJLMKG.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void PMOPAEHOABF(HJOJGGNKDFB JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void OBMDHEFKOBA(HJOJGGNKDFB JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B24AF0", Offset = "0x2B234F0", VA = "0x182B24AF0", Slot = "11")]
	public void AHPFPMIFNAG(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2878910", Offset = "0x2877310", VA = "0x182878910")]
	private void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2B24CB0", Offset = "0x2B236B0", VA = "0x182B24CB0")]
	private void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2B24C50", Offset = "0x2B23650", VA = "0x182B24C50", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public LAFHCMFONED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PMLFKOIGNFB
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2B3BC00", Offset = "0x2B3A600", VA = "0x182B3BC00")]
	public static EMFDOJECCDF PLLGILFFNLD(this OJMGIHLPABJ EGACOJLEBML, KHMECMDAALD HBKLDKCICEJ, GODNFBOIBNJ KLFAINNONJC)
	{
		return default(EMFDOJECCDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B7E0", Offset = "0x2B3A1E0", VA = "0x182B3B7E0")]
	public static NCAJJMMMNLG CIPMNLGHOOM(this OJMGIHLPABJ EGACOJLEBML)
	{
		return default(NCAJJMMMNLG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2B3BB50", Offset = "0x2B3A550", VA = "0x182B3BB50")]
	public static MBEDCJLMHEO HKKALCMCNLF(this OJMGIHLPABJ EGACOJLEBML, Entity LCLDFKAJPDK)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2B3BA20", Offset = "0x2B3A420", VA = "0x182B3BA20")]
	public static MBEDCJLMHEO HKKALCMCNLF(this OJMGIHLPABJ EGACOJLEBML, KHMECMDAALD HBKLDKCICEJ)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B900", Offset = "0x2B3A300", VA = "0x182B3B900")]
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
		[Cpp2IlInjected.Address(RVA = "0x31F8A20", Offset = "0x31F7420", VA = "0x1831F8A20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x31F8D20", Offset = "0x31F7720", VA = "0x1831F8D20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x31F8B40", Offset = "0x31F7540", VA = "0x1831F8B40", Slot = "16")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x31F8E60", Offset = "0x31F7860", VA = "0x1831F8E60", Slot = "13")]
	public void KCDJNNCAGCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "6")]
	public void CEPOPFLPLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x31F8E10", Offset = "0x31F7810", VA = "0x1831F8E10", Slot = "7")]
	public void KBJLMOBAMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x31F8C50", Offset = "0x31F7650", VA = "0x1831F8C50", Slot = "8")]
	public void IPJGDPGFFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x192DFA0", Offset = "0x192C9A0", VA = "0x18192DFA0", Slot = "9")]
	public void AOLADNPFIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x31F8CD0", Offset = "0x31F76D0", VA = "0x1831F8CD0", Slot = "10")]
	public void JCKGABHBCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x31F8BF0", Offset = "0x31F75F0", VA = "0x1831F8BF0", Slot = "11")]
	public bool IAKKNNBJDOH(IEnumerable<BMLJODFLIKN> JGGHOCFLFBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x31F8DC0", Offset = "0x31F77C0", VA = "0x1831F8DC0", Slot = "12")]
	public void JPJDNINPFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x31F8AC0", Offset = "0x31F74C0", VA = "0x1831F8AC0", Slot = "14")]
	public void BGHNIINFJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x31F8EA0", Offset = "0x31F78A0", VA = "0x1831F8EA0", Slot = "15")]
	public void OIMBFBLLJAN(bool COEOEBHKOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x31F8B10", Offset = "0x31F7510", VA = "0x1831F8B10")]
	private void CDKAKDPMAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x3021160", Offset = "0x301FB60", VA = "0x183021160", Slot = "6")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x30211F0", Offset = "0x301FBF0", VA = "0x1830211F0", Slot = "4")]
	public ByteString HLHCEBOKDMG(out IDisposable BOKADHKDELF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x30212B0", Offset = "0x301FCB0", VA = "0x1830212B0", Slot = "5")]
	public void JDGCKOHAIDJ(ByteString HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x33A5B00", Offset = "0x33A4500", VA = "0x1833A5B00", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type BELDJPAAHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x33A04D0", Offset = "0x339EED0", VA = "0x1833A04D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HPEJEEPDKIC EOPNOIAHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x33A2CE0", Offset = "0x33A16E0", VA = "0x1833A2CE0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int KBEFCFCFPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x33A21B0", Offset = "0x33A0BB0", VA = "0x1833A21B0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FPHAAJEGEDJ KHPNIPMAHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x33A5B50", Offset = "0x33A4550", VA = "0x1833A5B50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x33A05F0", Offset = "0x339EFF0", VA = "0x1833A05F0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x33A3EE0", Offset = "0x33A28E0", VA = "0x1833A3EE0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::FHOJCPPIDAI<KHMECMDAALD> KOKLFFIBABB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x33A2280", Offset = "0x33A0C80", VA = "0x1833A2280", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x33A3250", Offset = "0x33A1C50", VA = "0x1833A3250", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x33A5E20", Offset = "0x33A4820", VA = "0x1833A5E20")]
	public OLHLEPICNBD(global::NMNPBFGHJBG<Entity> GJEJKJANAJD, DDOLHFHMLOP CGCNGCLEGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x33A02F0", Offset = "0x339ECF0", VA = "0x1833A02F0")]
	private Entity AENBDOEOIOH(KHMECMDAALD HBKLDKCICEJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x33A03C0", Offset = "0x339EDC0", VA = "0x1833A03C0")]
	private KHMECMDAALD AENBDOEOIOH(Entity LCLDFKAJPDK)
	{
		return default(KHMECMDAALD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x33A4FB0", Offset = "0x33A39B0", VA = "0x1833A4FB0", Slot = "4")]
	public T MKLBNKEKMJE(KHMECMDAALD HBKLDKCICEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x33A1610", Offset = "0x33A0010", VA = "0x1833A1610")]
	public bool EFMALMFMJGL(KHMECMDAALD HBKLDKCICEJ, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x33A0770", Offset = "0x339F170", VA = "0x1833A0770")]
	public bool DHEEHCCONBN(KHMECMDAALD HBKLDKCICEJ, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x33A19A0", Offset = "0x33A03A0", VA = "0x1833A19A0", Slot = "9")]
	public bool FIKLEKNKGJP(KHMECMDAALD HBKLDKCICEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x33A59E0", Offset = "0x33A43E0", VA = "0x1833A59E0", Slot = "26")]
	public object OCMIFEJBKHP(KHMECMDAALD HBKLDKCICEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x33A1B50", Offset = "0x33A0550", VA = "0x1833A1B50")]
	public bool FKIKBBIJKBK(KHMECMDAALD HBKLDKCICEJ, in object CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x33A4C40", Offset = "0x33A3640", VA = "0x1833A4C40")]
	public void MKLBNKEKMJE(KHMECMDAALD HBKLDKCICEJ, in LGDIAIHEOID LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x33A13C0", Offset = "0x339FDC0", VA = "0x1833A13C0")]
	public bool EFMALMFMJGL(KHMECMDAALD HBKLDKCICEJ, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x33A06C0", Offset = "0x339F0C0", VA = "0x1833A06C0")]
	public bool DHEEHCCONBN(KHMECMDAALD HBKLDKCICEJ, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x33A2EF0", Offset = "0x33A18F0", VA = "0x1833A2EF0", Slot = "22")]
	public void KJCIHCOFJEN(OHLAKFFIOHD DNIKKNNGFMM, [Optional] object PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x33A2F20", Offset = "0x33A1920", VA = "0x1833A2F20", Slot = "15")]
	public void KJCIHCOFJEN(KHMECMDAALD OGFDNCPKECB, AJOKFLMHEKN DNIKKNNGFMM, object PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x33A5600", Offset = "0x33A4000", VA = "0x1833A5600", Slot = "14")]
	public bool MLOEOOCDIIH(KHMECMDAALD AJINCMEHCPE, KHMECMDAALD EBCEJCLCIMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1AA7500", Offset = "0x1AA5F00", VA = "0x181AA7500", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x33A5CE0", Offset = "0x33A46E0", VA = "0x1833A5CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x33A2530", Offset = "0x33A0F30", VA = "0x1833A2530")]
	public string GIKBMFAGOAC(in HAMGOKKMMPI EJAGMODIJNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x33A1110", Offset = "0x339FB10", VA = "0x1833A1110")]
	private void EABMMMFJIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x33A2820", Offset = "0x33A1220", VA = "0x1833A2820")]
	private void HHGBIJMIDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x33A3F50", Offset = "0x33A2950", VA = "0x1833A3F50")]
	private void MAOOGIIDNPH(Entity LCLDFKAJPDK, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x33A5840", Offset = "0x33A4240", VA = "0x1833A5840")]
	private void NJOIFCKABHM(Entity LCLDFKAJPDK, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x33A37D0", Offset = "0x33A21D0", VA = "0x1833A37D0")]
	[Conditional("DEBUG_BUILD")]
	private static void LKENIIBICCL(Entity LCLDFKAJPDK, KHMECMDAALD HBKLDKCICEJ, string IHNHAGGGBIH, string JCDOBNCJIFP, [CallerMemberName] string JAPNAIGHAPC = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x29D9BB0", Offset = "0x29D85B0", VA = "0x1829D9BB0", Slot = "5")]
	private bool BGDLPLLOMGH(KHMECMDAALD OGFDNCPKECB, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x33A04A0", Offset = "0x339EEA0", VA = "0x1833A04A0", Slot = "6")]
	private bool AKNMKCGEJPH(KHMECMDAALD OGFDNCPKECB, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0EF0", Offset = "0x2ECF8F0", VA = "0x182ED0EF0", Slot = "10")]
	private bool ONMGOCKLLGE(KHMECMDAALD OGFDNCPKECB, in object CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x33A3220", Offset = "0x33A1C20", VA = "0x1833A3220", Slot = "11")]
	private void KPPMELKOHFN(KHMECMDAALD OGFDNCPKECB, in LGDIAIHEOID LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x33A3EB0", Offset = "0x33A28B0", VA = "0x1833A3EB0", Slot = "12")]
	private bool LMDKPIIOMHA(KHMECMDAALD OGFDNCPKECB, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x33A2250", Offset = "0x33A0C50", VA = "0x1833A2250", Slot = "13")]
	private bool GBOBKJDKPAM(KHMECMDAALD OGFDNCPKECB, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x33A2C60", Offset = "0x33A1660", VA = "0x1833A2C60", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x39AFD80", Offset = "0x39AE780", VA = "0x1839AFD80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type BELDJPAAHJO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x39AB010", Offset = "0x39A9A10", VA = "0x1839AB010", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public HPEJEEPDKIC EOPNOIAHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x39AD8A0", Offset = "0x39AC2A0", VA = "0x1839AD8A0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int KBEFCFCFPNH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x39ACEC0", Offset = "0x39AB8C0", VA = "0x1839ACEC0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public FPHAAJEGEDJ KHPNIPMAHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x39AFE20", Offset = "0x39AE820", VA = "0x1839AFE20", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x39AB170", Offset = "0x39A9B70", VA = "0x1839AB170", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x39AD940", Offset = "0x39AC340", VA = "0x1839AD940", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::FHOJCPPIDAI<MBEDCJLMHEO> KOKLFFIBABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x39AD050", Offset = "0x39ABA50", VA = "0x1839AD050", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x39ADF90", Offset = "0x39AC990", VA = "0x1839ADF90", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x33A5E20", Offset = "0x33A4820", VA = "0x1833A5E20")]
	public JHEEGHNCDEJ(global::NMNPBFGHJBG<Entity> GJEJKJANAJD, DDOLHFHMLOP CGCNGCLEGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1EEF1D0", Offset = "0x1EEDBD0", VA = "0x181EEF1D0")]
	private Entity AENBDOEOIOH(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x39AAFE0", Offset = "0x39A99E0", VA = "0x1839AAFE0")]
	private MBEDCJLMHEO AENBDOEOIOH(Entity LCLDFKAJPDK)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x39AF370", Offset = "0x39ADD70", VA = "0x1839AF370", Slot = "4")]
	public T MKLBNKEKMJE(MBEDCJLMHEO LKHNLAILFFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x39AC1C0", Offset = "0x39AABC0", VA = "0x1839AC1C0")]
	public bool EFMALMFMJGL(MBEDCJLMHEO LKHNLAILFFL, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x39AB4D0", Offset = "0x39A9ED0", VA = "0x1839AB4D0")]
	public bool DHEEHCCONBN(MBEDCJLMHEO LKHNLAILFFL, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x39AC6F0", Offset = "0x39AB0F0", VA = "0x1839AC6F0", Slot = "9")]
	public bool FIKLEKNKGJP(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x39AFCA0", Offset = "0x39AE6A0", VA = "0x1839AFCA0", Slot = "26")]
	public object OCMIFEJBKHP(MBEDCJLMHEO LKHNLAILFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x39ACC50", Offset = "0x39AB650", VA = "0x1839ACC50")]
	public bool FKIKBBIJKBK(MBEDCJLMHEO LKHNLAILFFL, in object CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x39AF740", Offset = "0x39AE140", VA = "0x1839AF740")]
	public void MKLBNKEKMJE(MBEDCJLMHEO LKHNLAILFFL, in LGDIAIHEOID LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x39ABF50", Offset = "0x39AA950", VA = "0x1839ABF50")]
	public bool EFMALMFMJGL(MBEDCJLMHEO LKHNLAILFFL, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x39AB380", Offset = "0x39A9D80", VA = "0x1839AB380")]
	public bool DHEEHCCONBN(MBEDCJLMHEO LKHNLAILFFL, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x33A2EF0", Offset = "0x33A18F0", VA = "0x1833A2EF0", Slot = "22")]
	public void KJCIHCOFJEN(OHLAKFFIOHD DNIKKNNGFMM, [Optional] object PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x39ADB00", Offset = "0x39AC500", VA = "0x1839ADB00", Slot = "15")]
	public void KJCIHCOFJEN(MBEDCJLMHEO OGFDNCPKECB, AJOKFLMHEKN DNIKKNNGFMM, object PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x39AF820", Offset = "0x39AE220", VA = "0x1839AF820", Slot = "14")]
	public bool MLOEOOCDIIH(MBEDCJLMHEO AJINCMEHCPE, MBEDCJLMHEO EBCEJCLCIMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x39AB8C0", Offset = "0x39AA2C0", VA = "0x1839AB8C0")]
	private void EABMMMFJIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x39AD1B0", Offset = "0x39ABBB0", VA = "0x1839AD1B0")]
	private void HHGBIJMIDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x39AE4C0", Offset = "0x39ACEC0", VA = "0x1839AE4C0")]
	private void MAOOGIIDNPH(Entity LCLDFKAJPDK, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x39AFB80", Offset = "0x39AE580", VA = "0x1839AFB80")]
	private void NJOIFCKABHM(Entity LCLDFKAJPDK, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x39AB890", Offset = "0x39AA290", VA = "0x1839AB890", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x39AFF10", Offset = "0x39AE910", VA = "0x1839AFF10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x33A2530", Offset = "0x33A0F30", VA = "0x1833A2530")]
	public string GIKBMFAGOAC(in HAMGOKKMMPI EJAGMODIJNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x39AD940", Offset = "0x39AC340", VA = "0x1839AD940", Slot = "5")]
	private bool IIMFIMJPEDC(MBEDCJLMHEO OGFDNCPKECB, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x39AD810", Offset = "0x39AC210", VA = "0x1839AD810", Slot = "6")]
	private bool HPBNBLPHNNH(MBEDCJLMHEO OGFDNCPKECB, in T CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3583D00", Offset = "0x3582700", VA = "0x183583D00", Slot = "10")]
	private bool AGPKJBNLKLB(MBEDCJLMHEO OGFDNCPKECB, in object CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x39AF7E0", Offset = "0x39AE1E0", VA = "0x1839AF7E0", Slot = "11")]
	private void MLDDLCPIHPH(MBEDCJLMHEO OGFDNCPKECB, in LGDIAIHEOID LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x39AC610", Offset = "0x39AB010", VA = "0x1839AC610", Slot = "12")]
	private bool ENLIMJAKMPC(MBEDCJLMHEO OGFDNCPKECB, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x39ACF60", Offset = "0x39AB960", VA = "0x1839ACF60", Slot = "13")]
	private bool FPNMFCIKIEK(MBEDCJLMHEO OGFDNCPKECB, in HAMGOKKMMPI CKCLLMGGJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x33A2C60", Offset = "0x33A1660", VA = "0x1833A2C60", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0xCB3A00", Offset = "0xCB2400", VA = "0x180CB3A00", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xCB93D0", Offset = "0xCB7DD0", VA = "0x180CB93D0")]
	public MANAEOMEHPG(NativeArray<EntityRemapUtility.EntityRemapInfo> IGIGBKFKHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2B26A00", Offset = "0x2B25400", VA = "0x182B26A00", Slot = "6")]
	public MBEDCJLMHEO PIECOAJPBNK(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2B26A50", Offset = "0x2B25450", VA = "0x182B26A50", Slot = "7")]
	public Entity PIECOAJPBNK(Entity LCLDFKAJPDK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2B26960", Offset = "0x2B25360", VA = "0x182B26960", Slot = "8")]
	public IEnumerable<MBEDCJLMHEO> PIECOAJPBNK(IEnumerable<MBEDCJLMHEO> LLDOOGBMLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2B26900", Offset = "0x2B25300", VA = "0x182B26900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D80630", Offset = "0x2D7F030", VA = "0x182D80630")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool ADOEMHIFDMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2D807A0", Offset = "0x2D7F1A0", VA = "0x182D807A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2D80740", Offset = "0x2D7F140", VA = "0x182D80740")]
		public static SerializationRemapScope BFOBHHOJHHG()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2D80C60", Offset = "0x2D7F660", VA = "0x182D80C60")]
		public SerializationRemapScope(JPHKJJNABPK OFMOCNNCKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2D80830", Offset = "0x2D7F230", VA = "0x182D80830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2D80A70", Offset = "0x2D7F470", VA = "0x182D80A70")]
		public static MBEDCJLMHEO PIECOAJPBNK(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2D80940", Offset = "0x2D7F340", VA = "0x182D80940")]
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
		[Cpp2IlInjected.Address(RVA = "0x32047B0", Offset = "0x32031B0", VA = "0x1832047B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3204850", Offset = "0x3203250", VA = "0x183204850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event KJGHIOPPKDM FIFKFFPNHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x32044C0", Offset = "0x3202EC0", VA = "0x1832044C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3204710", Offset = "0x3203110", VA = "0x183204710")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event BIEMHMDOAIL OLGFDJEAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x32045D0", Offset = "0x3202FD0", VA = "0x1832045D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3204670", Offset = "0x3203070", VA = "0x183204670")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x32045B0", Offset = "0x3202FB0", VA = "0x1832045B0")]
	[Conditional("UNITY_EDITOR")]
	public void ECJEAKCPPMC(KHMECMDAALD BPJDIEJACOD, in DMLPNPICGMP HIDEHJGLNHO, bool GNCEPPHMFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3204590", Offset = "0x3202F90", VA = "0x183204590")]
	[Conditional("UNITY_EDITOR")]
	public void EACHOIILEAJ(KHMECMDAALD BPJDIEJACOD, bool GNCEPPHMFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3204560", Offset = "0x3202F60", VA = "0x183204560")]
	[Conditional("UNITY_EDITOR")]
	public void DACDBPPDPMD(KHMECMDAALD BPJDIEJACOD, AHKPLOLMABO GJEJKJANAJD, in HAMGOKKMMPI LPJDDLMPNCG, bool GNCEPPHMFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x3011B90", Offset = "0x3010590", VA = "0x183011B90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3011880", Offset = "0x3010280", VA = "0x183011880")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> EKICLMLDLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3011680", Offset = "0x3010080", VA = "0x183011680")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3011120", Offset = "0x300FB20", VA = "0x183011120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event AJJKEGNLGMM OPBILEONKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3011C50", Offset = "0x3010650", VA = "0x183011C50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3011D20", Offset = "0x3010720", VA = "0x183011D20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event KIDCJNHGKJG FIFKFFPNHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3011080", Offset = "0x300FA80", VA = "0x183011080")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3011940", Offset = "0x3010340", VA = "0x183011940")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event AJJKEGNLGMM FGNNOFILCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3011540", Offset = "0x300FF40", VA = "0x183011540")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3011740", Offset = "0x3010140", VA = "0x183011740")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event KIDCJNHGKJG PNLLMCFJJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x30114A0", Offset = "0x300FEA0", VA = "0x1830114A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x30119E0", Offset = "0x30103E0", VA = "0x1830119E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event LJHHLIEKJJP OLGFDJEAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3011360", Offset = "0x300FD60", VA = "0x183011360")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x30115E0", Offset = "0x300FFE0", VA = "0x1830115E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event IGEDCGLCEKE CNKOHKFFGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3011EF0", Offset = "0x30108F0", VA = "0x183011EF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3011AF0", Offset = "0x30104F0", VA = "0x183011AF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> BBFDHAPBEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x30117E0", Offset = "0x30101E0", VA = "0x1830117E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3011400", Offset = "0x300FE00", VA = "0x183011400")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event HONKAGNNBLJ HFHCKMDCNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x30112C0", Offset = "0x300FCC0", VA = "0x1830112C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3011DC0", Offset = "0x30107C0", VA = "0x183011DC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3011CF0", Offset = "0x30106F0", VA = "0x183011CF0")]
	[Conditional("UNITY_EDITOR")]
	public void KJIPHGJGGPN(KHMECMDAALD HBKLDKCICEJ, in DMLPNPICGMP HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3011270", Offset = "0x300FC70", VA = "0x183011270")]
	[Conditional("UNITY_EDITOR")]
	public void DHIKNDMJDEJ(KHMECMDAALD HBKLDKCICEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3011240", Offset = "0x300FC40", VA = "0x183011240")]
	[Conditional("UNITY_EDITOR")]
	public void BMDLMKKMHGB(KHMECMDAALD HBKLDKCICEJ, in DMLPNPICGMP HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3011ED0", Offset = "0x30108D0", VA = "0x183011ED0")]
	[Conditional("UNITY_EDITOR")]
	public void NGIELHEOLOM(KHMECMDAALD HBKLDKCICEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3011290", Offset = "0x300FC90", VA = "0x183011290")]
	[Conditional("UNITY_EDITOR")]
	public void DHOADLBAICA(KHMECMDAALD HBKLDKCICEJ, AHKPLOLMABO GJEJKJANAJD, in HAMGOKKMMPI LPJDDLMPNCG, bool NDNBCLJHJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3011060", Offset = "0x300FA60", VA = "0x183011060")]
	[Conditional("UNITY_EDITOR")]
	public void AOHNFMIDDFO(KHMECMDAALD HBKLDKCICEJ, AHKPLOLMABO GJEJKJANAJD, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x30111E0", Offset = "0x300FBE0", VA = "0x1830111E0")]
	[Conditional("UNITY_EDITOR")]
	public void BFBCCHACLPK(string AMNLGEBHFHK, object GJNIFGAPEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3011F90", Offset = "0x3010990", VA = "0x183011F90")]
	[Conditional("UNITY_EDITOR")]
	public void PMKDCGOKBHF(AJGHFPGHPHG OGFDNCPKECB, ReadOnlyMemory<byte> GJNIFGAPEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3011A80", Offset = "0x3010480", VA = "0x183011A80")]
	[Conditional("UNITY_EDITOR")]
	public void ILGFGKEGAIP(World ACFGKGFDFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3011E60", Offset = "0x3010860", VA = "0x183011E60")]
	[Conditional("UNITY_EDITOR")]
	public void MMMBMKAFPCH(World ACFGKGFDFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public FOLBIIPDBJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[HAMPPOKOPOP(typeof(OMPOCFBEAJG), new string[] { })]
public class LHCIBBFMEIC : OMPOCFBEAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2B254E0", Offset = "0x2B23EE0", VA = "0x182B254E0", Slot = "5")]
	public void FHOOHLBLACA(object BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2B256C0", Offset = "0x2B240C0", VA = "0x182B256C0", Slot = "6")]
	public void OPNFAPPAAHA(object BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2B255D0", Offset = "0x2B23FD0", VA = "0x182B255D0", Slot = "7")]
	public void MEEAPNCKCCB(object BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2B253C0", Offset = "0x2B23DC0", VA = "0x182B253C0", Slot = "4")]
	public IDisposable FFLCBOKHBEO(object BALNMHDNCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x3200EF0", Offset = "0x31FF8F0", VA = "0x183200EF0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x32002A0", Offset = "0x31FECA0", VA = "0x1832002A0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3200290", Offset = "0x31FEC90", VA = "0x183200290", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3200950", Offset = "0x31FF350", VA = "0x183200950")]
		public bool IAKKNNBJDOH(IEnumerable<BMLJODFLIKN> LCIODACOIFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3200F40", Offset = "0x31FF940", VA = "0x183200F40")]
		public static bool KLKAOHLENHA(BMLJODFLIKN FLDKBCEOGMK, out KHMECMDAALD HBKLDKCICEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x31FFF10", Offset = "0x31FE910", VA = "0x1831FFF10")]
		private void DOAJOGHAOBC(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB, IEnumerable<BMLJODFLIKN> LCIODACOIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3201050", Offset = "0x31FFA50", VA = "0x183201050")]
		private void NFPOGBIOOJI(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3200A70", Offset = "0x31FF470", VA = "0x183200A70")]
		private void ICKOEHOHMEP(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB, KHMECMDAALD HBKLDKCICEJ, string AMNLGEBHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x32005F0", Offset = "0x31FEFF0", VA = "0x1832005F0")]
		private void HLJMFHAPNOM(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x31FF400", Offset = "0x31FDE00", VA = "0x1831FF400")]
		private void BMHAFEDOAIG(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB, List<BMLJODFLIKN> CIKHIHLMGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3200420", Offset = "0x31FEE20", VA = "0x183200420")]
		private NativeList<KHMECMDAALD> GHHPBIGBFHB(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB)
		{
			return default(NativeList<KHMECMDAALD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x31FFCA0", Offset = "0x31FE6A0", VA = "0x1831FFCA0")]
		private NativeArray<Entity> CFPCEDGKIDC(NativeList<KHMECMDAALD> JENPCIBFABJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x31FFE70", Offset = "0x31FE870", VA = "0x1831FFE70")]
		private static void CHJFGMJLAIG(Dictionary<KHMECMDAALD, BMLJODFLIKN> MCHKFDMHGLB, KHMECMDAALD HBKLDKCICEJ, BMLJODFLIKN FLDKBCEOGMK, string AMNLGEBHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x3213940", Offset = "0x3212340", VA = "0x183213940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3213900", Offset = "0x3212300", VA = "0x183213900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool IDFICGLPIDA
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x32139C0", Offset = "0x32123C0", VA = "0x1832139C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3213980", Offset = "0x3212380", VA = "0x183213980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public void FDOOFFDPHJL(string AMNLGEBHFHK, EntityManager MABCFMECCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public static void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x754640", Offset = "0x753040", VA = "0x180754640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B6C20", Offset = "0x7B5620", VA = "0x1807B6C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool FGNLPJNLABH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x82B540", Offset = "0x829F40", VA = "0x18082B540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA4C770", Offset = "0xA4B170", VA = "0x180A4C770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D81210", Offset = "0x2D7FC10", VA = "0x182D81210", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2D82A80", Offset = "0x2D81480", VA = "0x182D82A80", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool MHHEFKPEDID
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x7B4840", Offset = "0x7B3240", VA = "0x1807B4840", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x7B4FF0", Offset = "0x7B39F0", VA = "0x1807B4FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public DKLNHGPFNEC FLJPALOIENA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D81230", Offset = "0x2D7FC30", VA = "0x182D81230", Slot = "16")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D81220", Offset = "0x2D7FC20", VA = "0x182D81220", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D82590", Offset = "0x2D80F90", VA = "0x182D82590")]
		public static bool LAKKFOOAFLA(ByteString EICPLPLLHGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x752CF0", Offset = "0x7516F0", VA = "0x180752CF0")]
		public void CJOFDIBGDMM(BOEJNPPLNGC DEJCFCAINJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D826C0", Offset = "0x2D810C0", VA = "0x182D826C0", Slot = "5")]
		public void LOGAJLAGOFJ(bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D82BC0", Offset = "0x2D815C0", VA = "0x182D82BC0", Slot = "6")]
		public Task PNPPFMJBEGG(bool EFCPHECCPHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D815F0", Offset = "0x2D7FFF0", VA = "0x182D815F0", Slot = "7")]
		public ByteString HLHCEBOKDMG(out IDisposable BOKADHKDELF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D816D0", Offset = "0x2D800D0", VA = "0x182D816D0", Slot = "19")]
		public ByteString HLHCEBOKDMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D82130", Offset = "0x2D80B30", VA = "0x182D82130", Slot = "9")]
		public bool JDGCKOHAIDJ(ByteString ONBFCOOCFOA, POJDIDMJDPL CAAHBOFLBKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D812D0", Offset = "0x2D7FCD0", VA = "0x182D812D0")]
		private bool HGGPFAICBGA(ByteString ONBFCOOCFOA, POJDIDMJDPL CAAHBOFLBKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D823C0", Offset = "0x2D80DC0", VA = "0x182D823C0", Slot = "8")]
		public void KGDOHLOFGLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D81EC0", Offset = "0x2D808C0", VA = "0x182D81EC0", Slot = "10")]
		public bool JCKGABHBCJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D818B0", Offset = "0x2D802B0", VA = "0x182D818B0", Slot = "11")]
		public bool IAKKNNBJDOH(IEnumerable<BMLJODFLIKN> JGGHOCFLFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D80CF0", Offset = "0x2D7F6F0", VA = "0x182D80CF0")]
		public bool ANALFDAFLAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D82190", Offset = "0x2D80B90", VA = "0x182D82190", Slot = "12")]
		public bool JPJDNINPFFI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D82790", Offset = "0x2D81190", VA = "0x182D82790")]
		public void MFPECCHOJNI(DKLNHGPFNEC.DEKMLIHHNED.HKJCHCPFJPL COEEJIEMCIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D81C30", Offset = "0x2D80630", VA = "0x182D81C30")]
		private bool IIBDCMKOIND(ByteString ONBFCOOCFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D82B40", Offset = "0x2D81540", VA = "0x182D82B40")]
		private void ONEAHBLDLCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D82A20", Offset = "0x2D81420", VA = "0x182D82A20")]
		private ByteString NLHHOMBFPLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D81B20", Offset = "0x2D80520", VA = "0x182D81B20")]
		private ByteString IBAGNILGFLI(ByteString EICPLPLLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2D80FA0", Offset = "0x2D7F9A0", VA = "0x182D80FA0")]
		private DKLNHGPFNEC.DEKMLIHHNED.HKJCHCPFJPL BGJKLCEKMLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2D82B90", Offset = "0x2D81590", VA = "0x182D82B90")]
		private void OPELIDIKLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2D80DD0", Offset = "0x2D7F7D0", VA = "0x182D80DD0", Slot = "13")]
		public bool BGHNIINFJBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D82A90", Offset = "0x2D81490", VA = "0x182D82A90", Slot = "14")]
		public void OIMBFBLLJAN(bool COEOEBHKOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D81040", Offset = "0x2D7FA40", VA = "0x182D81040")]
		private void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x31FE360", Offset = "0x31FCD60", VA = "0x1831FE360", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x31FDF00", Offset = "0x31FC900", VA = "0x1831FDF00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<JPHKJJNABPK> FPICFLCPIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x31FE040", Offset = "0x31FCA40", VA = "0x1831FE040", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x31FE0E0", Offset = "0x31FCAE0", VA = "0x1831FE0E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action GHHOMKOFCDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x31FE220", Offset = "0x31FCC20", VA = "0x1831FE220", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x31FDFA0", Offset = "0x31FC9A0", VA = "0x1831FDFA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action OLLHMNBMFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x31FDDC0", Offset = "0x31FC7C0", VA = "0x1831FDDC0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x31FE2C0", Offset = "0x31FCCC0", VA = "0x1831FE2C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<JPHKJJNABPK> NHPEANCHECK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x31FDE60", Offset = "0x31FC860", VA = "0x1831FDE60", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x31FE180", Offset = "0x31FCB80", VA = "0x1831FE180", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0xE5FD60", Offset = "0xE5E760", VA = "0x180E5FD60")]
	public void KGDOHLOFGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xE601B0", Offset = "0xE5EBB0", VA = "0x180E601B0")]
	public void BOIKFIPMHMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0xE5FA30", Offset = "0xE5E430", VA = "0x180E5FA30")]
	public void OLGLICDJLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x31FE450", Offset = "0x31FCE50", VA = "0x1831FE450")]
	public void NCPIJGPAEFA(JPHKJJNABPK FIANHALABNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x31FE400", Offset = "0x31FCE00", VA = "0x1831FE400")]
	public void MJGOKLJLGOJ(JPHKJJNABPK FIANHALABNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76F9F0", VA = "0x180770FF0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x771120", Offset = "0x76FB20", VA = "0x180771120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager BFILENFCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x301AA60", Offset = "0x3019460", VA = "0x18301AA60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x157B220", Offset = "0x1579C20", VA = "0x18157B220", Slot = "14")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x301A6A0", Offset = "0x30190A0", VA = "0x18301A6A0", Slot = "15")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x301AC10", Offset = "0x3019610", VA = "0x18301AC10", Slot = "16")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x157B150", Offset = "0x1579B50", VA = "0x18157B150", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B2F0A0", Offset = "0x2B2DAA0", VA = "0x182B2F0A0")]
	private MBEDCJLMHEO IFLEFNACDDH(Entity LCLDFKAJPDK)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x301ADD0", Offset = "0x30197D0", VA = "0x18301ADD0", Slot = "4")]
	public MBEDCJLMHEO NKAKDLGIEDI(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x301AE30", Offset = "0x3019830", VA = "0x18301AE30", Slot = "19")]
	public void PADFFCJKHOD(ref List<MBEDCJLMHEO> NNDAPMCFFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x301A250", Offset = "0x3018C50", VA = "0x18301A250", Slot = "20")]
	public IEnumerable<MBEDCJLMHEO> CMGIHGILOAF(MBEDCJLMHEO LKHNLAILFFL, bool PNGNAFIFALL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3019EE0", Offset = "0x30188E0", VA = "0x183019EE0", Slot = "21")]
	public MBEDCJLMHEO AFFCJINMNLA(MBEDCJLMHEO LKHNLAILFFL, int EGNHJGKABLC)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x301A940", Offset = "0x3019340", VA = "0x18301A940", Slot = "22")]
	public int ILEAONCNDBH(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x301A770", Offset = "0x3019170", VA = "0x18301A770", Slot = "8")]
	public int FOLBFCNBPGG(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x301AAB0", Offset = "0x30194B0", VA = "0x18301AAB0", Slot = "9")]
	public GKNDEBMEIID LBBKCNNGHFP(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(GKNDEBMEIID);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x301A4A0", Offset = "0x3018EA0", VA = "0x18301A4A0", Slot = "23")]
	public bool FFJNEFEMNPN(MBEDCJLMHEO LKHNLAILFFL, out GKNDEBMEIID KOGMIHECDBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x301A180", Offset = "0x3018B80", VA = "0x18301A180", Slot = "24")]
	public IEnumerable<MBEDCJLMHEO> CEAEBLDPEEN(MBEDCJLMHEO LKHNLAILFFL, bool PNGNAFIFALL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x301A0B0", Offset = "0x3018AB0", VA = "0x18301A0B0", Slot = "12")]
	public MBEDCJLMHEO AFNHNOEFCOI(MBEDCJLMHEO AGDKLNJDAPF, MBEDCJLMHEO NMPDJFDFMIN)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x301A3D0", Offset = "0x3018DD0", VA = "0x18301A3D0", Slot = "13")]
	public bool EDCKHKPPKHK(MBEDCJLMHEO AGDKLNJDAPF, MBEDCJLMHEO NMPDJFDFMIN, out MBEDCJLMHEO NFENBCEFMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x301AD30", Offset = "0x3019730", VA = "0x18301AD30", Slot = "5")]
	public MBEDCJLMHEO NGLDHLBMECO(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x301A670", Offset = "0x3019070", VA = "0x18301A670", Slot = "11")]
	public bool FFKLPDDAEHN(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO NLBEDCCLIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x301A910", Offset = "0x3019310", VA = "0x18301A910", Slot = "25")]
	public bool HMKPBKJMFKD(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO ILLPMKANGKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x301AD00", Offset = "0x3019700", VA = "0x18301AD00", Slot = "10")]
	public bool NBCMHKFAKCC(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO AGDKLNJDAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x301A320", Offset = "0x3018D20", VA = "0x18301A320", Slot = "6")]
	public bool DEIBNNOCJKC(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO GGEKFPEBLKN, bool NFCHCDFCFMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x301ABA0", Offset = "0x30195A0", VA = "0x18301ABA0", Slot = "7")]
	public bool LGLAJNBPHCD(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO GGEKFPEBLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x301E6B0", Offset = "0x301D0B0", VA = "0x18301E6B0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x301E430", Offset = "0x301CE30", VA = "0x18301E430", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x301E330", Offset = "0x301CD30", VA = "0x18301E330")]
	public HBFGHIOELIO CKDGICHNPCA(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x301E110", Offset = "0x301CB10", VA = "0x18301E110")]
	public HBFGHIOELIO CKDGICHNPCA(AHKPLOLMABO CBPECCEKJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x301DF80", Offset = "0x301C980", VA = "0x18301DF80")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x301E700", Offset = "0x301D100", VA = "0x18301E700")]
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
		[Cpp2IlInjected.Address(RVA = "0xCB3A00", Offset = "0xCB2400", VA = "0x180CB3A00")]
		get
		{
			return default(NativeList<BCAIIOMBBGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<LBCACEFDDPD> PIAHFLGFADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xBFC260", Offset = "0xBFAC60", VA = "0x180BFC260")]
		get
		{
			return default(NativeList<LBCACEFDDPD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<EBCGMCIBBDB> FPIAPMGLLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x11ECA90", Offset = "0x11EB490", VA = "0x1811ECA90")]
		get
		{
			return default(NativeList<EBCGMCIBBDB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<LBCACEFDDPD> OOPLJEAECKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xEF89E0", Offset = "0xEF73E0", VA = "0x180EF89E0")]
		get
		{
			return default(NativeList<LBCACEFDDPD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle KICFFBDCCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x130D430", Offset = "0x130BE30", VA = "0x18130D430")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1698260", Offset = "0x1696C60", VA = "0x181698260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool AMOPNJPCIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x13FB6E0", Offset = "0x13FA0E0", VA = "0x1813FB6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool MJGLDBCMJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x30144E0", Offset = "0x3012EE0", VA = "0x1830144E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3014750", Offset = "0x3013150", VA = "0x183014750")]
	public HBFGHIOELIO(Allocator FKHAEPDPDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x30146C0", Offset = "0x30130C0", VA = "0x1830146C0")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3014590", Offset = "0x3012F90", VA = "0x183014590")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x30141B0", Offset = "0x3012BB0", VA = "0x1830141B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3012900", Offset = "0x3011300", VA = "0x183012900", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x30128E0", Offset = "0x30112E0", VA = "0x1830128E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3C210", Offset = "0x2B3AC10", VA = "0x182B3C210", Slot = "5")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C570", Offset = "0x2B3AF70", VA = "0x182B3C570", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C620", Offset = "0x2B3B020", VA = "0x182B3C620")]
		public void LOIIDKBBIDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C480", Offset = "0x2B3AE80", VA = "0x182B3C480", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C270", Offset = "0x2B3AC70", VA = "0x182B3C270")]
		public void DPHIICBNAFD(global::GMANFPIPMBB<int> MODCBBJJAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C5E0", Offset = "0x2B3AFE0", VA = "0x182B3C5E0")]
		public void KAEKDKOONGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x9D7C90", Offset = "0x9D6690", VA = "0x1809D7C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x30173D0", Offset = "0x3015DD0", VA = "0x1830173D0")]
	public KHMECMDAALD FBPBDBBLOOA()
	{
		return default(KHMECMDAALD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x3017320", Offset = "0x3015D20", VA = "0x183017320")]
	public void AKEEEJIMJIC(KHMECMDAALD HBKLDKCICEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x17F6E40", Offset = "0x17F5840", VA = "0x1817F6E40", Slot = "6")]
	public virtual void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x731750", Offset = "0x730150", VA = "0x180731750", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B690", Offset = "0x2B3A090", VA = "0x182B3B690", Slot = "7")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B730", Offset = "0x2B3A130", VA = "0x182B3B730")]
	private void IEOEJLMBMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B780", Offset = "0x2B3A180", VA = "0x182B3B780", Slot = "6")]
	public override void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2D6C0", Offset = "0x2B2C0C0", VA = "0x182B2D6C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery ILGKIBHLIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x731A00", Offset = "0x730400", VA = "0x180731A00")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery PBMEJFAFIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7319F0", Offset = "0x7303F0", VA = "0x1807319F0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery GHJEMIAOOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x11EA9A0", Offset = "0x11E93A0", VA = "0x1811EA9A0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery BFPEBJKLIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x130D430", Offset = "0x130BE30", VA = "0x18130D430")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery LCAJPMDFBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1590380", Offset = "0x158ED80", VA = "0x181590380")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery AEMHBANALGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DC30", Offset = "0x2B2C630", VA = "0x182B2DC30")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int HDHBHHLNBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D540", Offset = "0x2B2BF40", VA = "0x182B2D540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int IHMDCDCEGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D360", Offset = "0x2B2BD60", VA = "0x182B2D360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int LJPOFJDGCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D6A0", Offset = "0x2B2C0A0", VA = "0x182B2D6A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int OFFFLBBKILE
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D710", Offset = "0x2B2C110", VA = "0x182B2D710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int MDOIOGDICPN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D680", Offset = "0x2B2C080", VA = "0x182B2D680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int KGPAICNOICC
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D560", Offset = "0x2B2BF60", VA = "0x182B2D560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "4")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D630", Offset = "0x2B2C030", VA = "0x182B2D630", Slot = "5")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D730", Offset = "0x2B2C130", VA = "0x182B2D730", Slot = "6")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2B2DBD0", Offset = "0x2B2C5D0", VA = "0x182B2DBD0")]
	private EntityQueryDesc NCAIOHNGJPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D4E0", Offset = "0x2B2BEE0", VA = "0x182B2D4E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D430", Offset = "0x2B2BE30", VA = "0x182B2D430")]
	public BDPFCKONNMG CNLDDDHJFJE(MBEDCJLMHEO LMLBLIDPKCN)
	{
		return default(BDPFCKONNMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D380", Offset = "0x2B2BD80", VA = "0x182B2D380")]
	public BDPFCKONNMG CNLDDDHJFJE(Entity LCLDFKAJPDK)
	{
		return default(BDPFCKONNMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D580", Offset = "0x2B2BF80", VA = "0x182B2D580")]
	public GODNFBOIBNJ FKGBCFJDCGK(Entity LCLDFKAJPDK)
	{
		return default(GODNFBOIBNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2B2DCB0", Offset = "0x2B2C6B0", VA = "0x182B2DCB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int HDHBHHLNBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2B384F0", Offset = "0x2B36EF0", VA = "0x182B384F0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int IHMDCDCEGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2B38050", Offset = "0x2B36A50", VA = "0x182B38050", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int LJPOFJDGCEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2B39610", Offset = "0x2B38010", VA = "0x182B39610", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int OFFFLBBKILE
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2B39690", Offset = "0x2B38090", VA = "0x182B39690", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int MDOIOGDICPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2B39390", Offset = "0x2B37D90", VA = "0x182B39390", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int KGPAICNOICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2B385A0", Offset = "0x2B36FA0", VA = "0x182B385A0", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<MBEDCJLMHEO, GODNFBOIBNJ> NDEJJCMOJOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2B39570", Offset = "0x2B37F70", VA = "0x182B39570", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2B37DF0", Offset = "0x2B367F0", VA = "0x182B37DF0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<MBEDCJLMHEO> KNEJPGEJOOE
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2B37C30", Offset = "0x2B36630", VA = "0x182B37C30", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2B37CD0", Offset = "0x2B366D0", VA = "0x182B37CD0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2B38980", Offset = "0x2B37380", VA = "0x182B38980", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2B38370", Offset = "0x2B36D70", VA = "0x182B38370", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2B37E90", Offset = "0x2B36890", VA = "0x182B37E90")]
		private void BHFLAOMNNIM(Entity LCLDFKAJPDK, GODNFBOIBNJ KLFAINNONJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2B39A20", Offset = "0x2B38420", VA = "0x182B39A20")]
		private void OLDMMPMDNME(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2B39140", Offset = "0x2B37B40", VA = "0x182B39140")]
		internal MBEDCJLMHEO IFLEFNACDDH(Entity LCLDFKAJPDK)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2B38780", Offset = "0x2B37180", VA = "0x182B38780", Slot = "41")]
		public GKNDEBMEIID FIHFHPIKDOE()
		{
			return default(GKNDEBMEIID);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2B38E00", Offset = "0x2B37800", VA = "0x182B38E00", Slot = "42")]
		public GKNDEBMEIID HCMEACAGEBA()
		{
			return default(GKNDEBMEIID);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2B39160", Offset = "0x2B37B60", VA = "0x182B39160", Slot = "43")]
		public GKNDEBMEIID IPJEPCFEEGL()
		{
			return default(GKNDEBMEIID);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2B38140", Offset = "0x2B36B40", VA = "0x182B38140", Slot = "10")]
		public BDPFCKONNMG CNLDDDHJFJE(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(BDPFCKONNMG);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2B388B0", Offset = "0x2B372B0", VA = "0x182B388B0", Slot = "11")]
		public GODNFBOIBNJ FKGBCFJDCGK(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(GODNFBOIBNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2B39810", Offset = "0x2B38210", VA = "0x182B39810")]
		private GKNDEBMEIID MOCHLPAFENL(EntityQuery ANBHGOBNOFE)
		{
			return default(GKNDEBMEIID);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2B38820", Offset = "0x2B37220", VA = "0x182B38820", Slot = "33")]
		public bool FIKLEKNKGJP(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2B39200", Offset = "0x2B37C00", VA = "0x182B39200", Slot = "29")]
		public void JALMAFNAIBH(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2B38F10", Offset = "0x2B37910", VA = "0x182B38F10", Slot = "30")]
		public void HDLFCKJDPBO(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2B398C0", Offset = "0x2B382C0", VA = "0x182B398C0", Slot = "31")]
		public void NAMPHNFBBEJ(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2B38D40", Offset = "0x2B37740", VA = "0x182B38D40", Slot = "22")]
		public EMFDOJECCDF FMBHGNBEDKM(GODNFBOIBNJ KLFAINNONJC, bool GKHKAHGPIJJ)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2B38C90", Offset = "0x2B37690", VA = "0x182B38C90", Slot = "23")]
		public EMFDOJECCDF FMBHGNBEDKM(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2B39B20", Offset = "0x2B38520", VA = "0x182B39B20", Slot = "24")]
		public EMFDOJECCDF PFNKHCBELDA(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2B39C50", Offset = "0x2B38650", VA = "0x182B39C50", Slot = "25")]
		public EMFDOJECCDF PLLGILFFNLD(KHMECMDAALD HBKLDKCICEJ, GODNFBOIBNJ KLFAINNONJC)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2B38200", Offset = "0x2B36C00", VA = "0x182B38200", Slot = "44")]
		public EMFDOJECCDF DBMENANGLFB(int PMIJHDHOHOF, GODNFBOIBNJ KLFAINNONJC, GameObject DLNMCGFEPOP)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2B38080", Offset = "0x2B36A80", VA = "0x182B38080", Slot = "26")]
		public NCAJJMMMNLG CIPMNLGHOOM()
		{
			return default(NCAJJMMMNLG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2B37F30", Offset = "0x2B36930", VA = "0x182B37F30", Slot = "45")]
		public JJCNHDGDNMH BHGFCNAGJLA(ECHOKHJACKM OGILDIMGIOH)
		{
			return default(JJCNHDGDNMH);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2B39060", Offset = "0x2B37A60", VA = "0x182B39060", Slot = "27")]
		public LNEELJPGMBI HNGEDIPEFKF()
		{
			return default(LNEELJPGMBI);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2B39250", Offset = "0x2B37C50", VA = "0x182B39250", Slot = "28")]
		public NAAJAJPNJEO JHOHELNIPGN(LFEIHDPDPKH OGILDIMGIOH)
		{
			return default(NAAJAJPNJEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2B38580", Offset = "0x2B36F80", VA = "0x182B38580", Slot = "12")]
		public void EHOMCGHPBHE(KHMECMDAALD HBKLDKCICEJ, APKFPLGDLPH CNEFEEJPMMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2B385D0", Offset = "0x2B36FD0", VA = "0x182B385D0", Slot = "13")]
		public EMFDOJECCDF EKICMIMOHBL(MBEDCJLMHEO LKHNLAILFFL, [Optional] object MIFCLBEAOPM)
		{
			return default(EMFDOJECCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2B39BB0", Offset = "0x2B385B0", VA = "0x182B39BB0", Slot = "14")]
		public bool PHONMIEGPBF(MBEDCJLMHEO LKHNLAILFFL, out APKFPLGDLPH JGINNNKFHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2B38320", Offset = "0x2B36D20", VA = "0x182B38320", Slot = "46")]
		public Transform DHHOPPBKOBH(MBEDCJLMHEO LKHNLAILFFL, [Optional] object MIFCLBEAOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2B39640", Offset = "0x2B38040", VA = "0x182B39640", Slot = "16")]
		public bool KGFFBHKEPBA(MBEDCJLMHEO LKHNLAILFFL, out Transform CACALPHNCBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2B382D0", Offset = "0x2B36CD0", VA = "0x182B382D0", Slot = "17")]
		public bool DGBCKPEIJJH(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2B396F0", Offset = "0x2B380F0", VA = "0x182B396F0")]
		public bool LFIKAPHEHNB(APKFPLGDLPH LPJDDLMPNCG, [Optional] object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2B396C0", Offset = "0x2B380C0", VA = "0x182B396C0", Slot = "47")]
		public bool LFIKAPHEHNB(MBEDCJLMHEO LKHNLAILFFL, [Optional] object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2B38560", Offset = "0x2B36F60", VA = "0x182B38560", Slot = "48")]
		public void EHGKANMEAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2B393C0", Offset = "0x2B37DC0", VA = "0x182B393C0", Slot = "15")]
		public void JINAKIKBBNA(APKFPLGDLPH NBNOMDAKOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2B38520", Offset = "0x2B36F20", VA = "0x182B38520", Slot = "49")]
		public void EDFNPEPIDIC(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2B37D70", Offset = "0x2B36770", VA = "0x182B37D70", Slot = "18")]
		public bool BALOOPDBMDO(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2B39720", Offset = "0x2B38120", VA = "0x182B39720", Slot = "19")]
		public bool LGIJADFEFLD(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2B397A0", Offset = "0x2B381A0", VA = "0x182B397A0", Slot = "50")]
		public bool MFDJBBJBCKH(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2B39AB0", Offset = "0x2B384B0", VA = "0x182B39AB0", Slot = "51")]
		public bool OOCDJKEDMNO(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2B38270", Offset = "0x2B36C70", VA = "0x182B38270", Slot = "32")]
		public NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)> DBMKBBAHMAH(NativeArray<MBEDCJLMHEO> HNAFJFFPIOE, Allocator FKHAEPDPDAI)
		{
			return default(NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2B38BF0", Offset = "0x2B375F0", VA = "0x182B38BF0", Slot = "21")]
		public KHMECMDAALD FLJOHMEAAKD(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(KHMECMDAALD);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2B38F70", Offset = "0x2B37970", VA = "0x182B38F70", Slot = "20")]
		public MBEDCJLMHEO HKKALCMCNLF(KHMECMDAALD HBKLDKCICEJ)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2B39960", Offset = "0x2B38360", VA = "0x182B39960")]
		private void ODMDPMLLGAD(GODNFBOIBNJ KLFAINNONJC, MBEDCJLMHEO LKHNLAILFFL, KHMECMDAALD HBKLDKCICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x3026AA0", Offset = "0x30254A0", VA = "0x183026AA0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x3026510", Offset = "0x3024F10", VA = "0x183026510")]
	public NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)> DBMKBBAHMAH(NativeArray<MBEDCJLMHEO> HNAFJFFPIOE, Allocator FKHAEPDPDAI)
	{
		return default(NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x3026B30", Offset = "0x3025530", VA = "0x183026B30")]
	private void MOFMOGBMPMO(NativeMultiHashMap<int, (MBEDCJLMHEO src, MBEDCJLMHEO dst)> ODJEPGAJPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x3026610", Offset = "0x3025010", VA = "0x183026610")]
	private void FBAAJFDJOAL(NativeMultiHashMap<int, (MBEDCJLMHEO src, MBEDCJLMHEO dst)> ODJEPGAJPAF, int KLFAINNONJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x30260A0", Offset = "0x3024AA0", VA = "0x1830260A0")]
	private void CPHPKOOGEPE(NativeMultiHashMap<int, (MBEDCJLMHEO src, MBEDCJLMHEO dst)> ODJEPGAJPAF, int KLFAINNONJC, HOOPFMCFMDE FNBGFGCHFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x3026230", Offset = "0x3024C30", VA = "0x183026230")]
	private NativeMultiHashMap<int, (MBEDCJLMHEO, MBEDCJLMHEO)> DBBCBGIHNIK(Allocator FKHAEPDPDAI, NativeArray<MBEDCJLMHEO> HNAFJFFPIOE, out NativeArray<(MBEDCJLMHEO src, MBEDCJLMHEO dst)> AOBIHALIFEN)
	{
		return default(NativeMultiHashMap<int, (MBEDCJLMHEO, MBEDCJLMHEO)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D8BEF0", Offset = "0x2D8A8F0", VA = "0x182D8BEF0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private PHIPKIFAENI PDFOFNPFHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x2D8C250", Offset = "0x2D8AC50", VA = "0x182D8C250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A2A0", Offset = "0x2D88CA0", VA = "0x182D8A2A0", Slot = "33")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2D889D0", Offset = "0x2D873D0", VA = "0x182D889D0", Slot = "34")]
		public bool ANOEAMLDKOO(Transform CACALPHNCBH, out MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A750", Offset = "0x2D89150", VA = "0x182D8A750", Slot = "35")]
		public Transform GEBNBHFHKBB(Entity LCLDFKAJPDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2D8BF40", Offset = "0x2D8A940", VA = "0x182D8BF40", Slot = "30")]
		public bool KGFFBHKEPBA(Entity LCLDFKAJPDK, out Transform CACALPHNCBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AD00", Offset = "0x2D89700", VA = "0x182D8AD00")]
		private void HCKCKECDNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2D88B90", Offset = "0x2D87590", VA = "0x182D88B90", Slot = "29")]
		public void BIAJBLEHIDE(Entity LCLDFKAJPDK, out Matrix4x4 IEBPCDDDDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B8B0", Offset = "0x2D8A2B0", VA = "0x182D8B8B0", Slot = "4")]
		public void JBMEJJDGLKC(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2D8BE20", Offset = "0x2D8A820", VA = "0x182D8BE20")]
		public void KDLFDECFOOE(Entity LCLDFKAJPDK, Vector3 KPEIOCLIHAH, Quaternion LOFMMAJIGJA, Vector3 NINOFHJAAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2D89820", Offset = "0x2D88220", VA = "0x182D89820")]
		public void DLHLCKFJCJC(Entity LCLDFKAJPDK, Vector3 KPEIOCLIHAH, Quaternion LOFMMAJIGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2D89450", Offset = "0x2D87E50", VA = "0x182D89450", Slot = "27")]
		public void CMIIDOENKIB(Entity LCLDFKAJPDK, out Matrix4x4 JHHKIHMHCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2D89460", Offset = "0x2D87E60", VA = "0x182D89460")]
		public void DFGDFPIMAIA(Entity LCLDFKAJPDK, in Matrix4x4 IEBPCDDDDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D2A0", Offset = "0x2D8BCA0", VA = "0x182D8D2A0")]
		public void OHNOPHPCMGB(Entity LCLDFKAJPDK, in Matrix4x4 IEBPCDDDDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D510", Offset = "0x2D8BF10", VA = "0x182D8D510")]
		public void PHIPNHEMLHD(Entity LCLDFKAJPDK, in Matrix4x4 MFPAEIALJBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2D89CD0", Offset = "0x2D886D0", VA = "0x182D89CD0", Slot = "5")]
		public void ENJCMBFDOCN(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C520", Offset = "0x2D8AF20", VA = "0x182D8C520", Slot = "6")]
		public Vector3 MGLKMFBJJJO(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B060", Offset = "0x2D89A60", VA = "0x182D8B060", Slot = "7")]
		public void HKJLMAEMPJL(Entity LCLDFKAJPDK, Quaternion LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C430", Offset = "0x2D8AE30", VA = "0x182D8C430", Slot = "8")]
		public Quaternion MGKDEKAMFIK(Entity LCLDFKAJPDK)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C150", Offset = "0x2D8AB50", VA = "0x182D8C150", Slot = "12")]
		public void KJNDNEEMEPE(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C320", Offset = "0x2D8AD20", VA = "0x182D8C320", Slot = "11")]
		public Vector3 LMBPHPKOIIE(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B530", Offset = "0x2D89F30", VA = "0x182D8B530")]
		public void ICCLKGEMNIJ(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B5D0", Offset = "0x2D89FD0", VA = "0x182D8B5D0")]
		private Vector3 IJNECEMADJP(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2D8CEE0", Offset = "0x2D8B8E0", VA = "0x182D8CEE0", Slot = "14")]
		public float NFKMPIKGOMK(Entity LCLDFKAJPDK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2D88DB0", Offset = "0x2D877B0", VA = "0x182D88DB0", Slot = "13")]
		public void BPGKJMGHFCP(Entity LCLDFKAJPDK, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2D888E0", Offset = "0x2D872E0", VA = "0x182D888E0")]
		private float AHOEKDOFPDL(Entity LCLDFKAJPDK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AD20", Offset = "0x2D89720", VA = "0x182D8AD20")]
		public void HEHJHHHCLLI(Entity LCLDFKAJPDK, float NOPOHLIFOBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C760", Offset = "0x2D8B160", VA = "0x182D8C760", Slot = "16")]
		public Vector3 MIEGHDBEPFP(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2D886D0", Offset = "0x2D870D0", VA = "0x182D886D0", Slot = "15")]
		public void ABOEGJAMAKF(Entity LCLDFKAJPDK, Vector3 FHPAIIENFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2D88EC0", Offset = "0x2D878C0", VA = "0x182D88EC0")]
		private Vector3 CAJOKKMJFJC(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2D88CE0", Offset = "0x2D876E0", VA = "0x182D88CE0")]
		public void BLJEKABEIFP(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2D8BC70", Offset = "0x2D8A670", VA = "0x182D8BC70")]
		[Conditional("DEBUG_BUILD")]
		private void JPLLBOBFFNO(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B160", Offset = "0x2D89B60", VA = "0x182D8B160", Slot = "36")]
		public void HMELKJLDAKP(Entity LCLDFKAJPDK, Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2D8BAA0", Offset = "0x2D8A4A0", VA = "0x182D8BAA0", Slot = "9")]
		public void JOFDDLBLBGK(Entity LCLDFKAJPDK, out Vector3 PICDPPHNNLH, out Quaternion IHCJBCJFELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C630", Offset = "0x2D8B030", VA = "0x182D8C630", Slot = "10")]
		public void MHKPHDAEAKB(Entity LCLDFKAJPDK, out Vector3 PICDPPHNNLH, out Quaternion IHCJBCJFELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2D89DF0", Offset = "0x2D887F0", VA = "0x182D89DF0", Slot = "37")]
		public void EPIGNDLPMLM(Entity LCLDFKAJPDK, Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AEA0", Offset = "0x2D898A0", VA = "0x182D8AEA0")]
		public void HGGPFPNHOFA(Entity LCLDFKAJPDK, Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2D89930", Offset = "0x2D88330", VA = "0x182D89930", Slot = "17")]
		public void DMJNFFDPBKN(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A1C0", Offset = "0x2D88BC0", VA = "0x182D8A1C0", Slot = "18")]
		public Vector3 FKDOPKDDHMF(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B670", Offset = "0x2D8A070", VA = "0x182D8B670", Slot = "19")]
		public void JAKPDFNLCHO(Entity LCLDFKAJPDK, Quaternion LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D1B0", Offset = "0x2D8BBB0", VA = "0x182D8D1B0", Slot = "20")]
		public Quaternion ODJCFLIEMJB(Entity LCLDFKAJPDK)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2D88FF0", Offset = "0x2D879F0", VA = "0x182D88FF0", Slot = "22")]
		public void CKKEKOJAIHB(Entity LCLDFKAJPDK, Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2D8ADB0", Offset = "0x2D897B0", VA = "0x182D8ADB0", Slot = "21")]
		public Vector3 HFPPHOLJIBN(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D89B60", Offset = "0x2D88560", VA = "0x182D89B60", Slot = "23")]
		public void DPFFHDIBMOP(Entity LCLDFKAJPDK, float DFOHKDPDMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B2C0", Offset = "0x2D89CC0", VA = "0x182D8B2C0", Slot = "24")]
		public float HOLALLCIGIB(Entity LCLDFKAJPDK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A810", Offset = "0x2D89210", VA = "0x182D8A810", Slot = "25")]
		public void HACOEDCCHCG(Entity LCLDFKAJPDK, Vector3 GIIDNHCLPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D3D0", Offset = "0x2D8BDD0", VA = "0x182D8D3D0", Slot = "26")]
		public Vector3 OJPHFLPPBNB(Entity LCLDFKAJPDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C840", Offset = "0x2D8B240", VA = "0x182D8C840", Slot = "31")]
		public void NBGBFKAPKMB(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B3E0", Offset = "0x2D89DE0", VA = "0x182D8B3E0")]
		private MBEDCJLMHEO ICCEPAOEIDF(Transform CACALPHNCBH)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2D8CF80", Offset = "0x2D8B980", VA = "0x182D8CF80")]
		private static TransformEntity NGOIFIJNHJH(GODNFBOIBNJ OGILDIMGIOH, GameObject JNONJGMFMNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C030", Offset = "0x2D8AA30", VA = "0x182D8C030", Slot = "32")]
		public void KIOFIHAAPLG(Entity LCLDFKAJPDK, Entity LOFGAAGHIJI, Entity BJNIPOLNMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D8BBF0", Offset = "0x2D8A5F0", VA = "0x182D8BBF0")]
		private GBBHKGHOJBF JOFDDLBLBGK(Entity LCLDFKAJPDK)
		{
			return default(GBBHKGHOJBF);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D88800", Offset = "0x2D87200", VA = "0x182D88800")]
		private bool AFJCDFMCJLH(Entity LCLDFKAJPDK, out Entity GGEKFPEBLKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A010", Offset = "0x2D88A10", VA = "0x182D8A010")]
		private void FACMOPHDIAL(Entity LCLDFKAJPDK, out Matrix4x4 IEBPCDDDDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A3B0", Offset = "0x2D88DB0", VA = "0x182D8A3B0")]
		private void FLJLPPIJLGB(Entity LCLDFKAJPDK, out Matrix4x4 MFPAEIALJBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C310", Offset = "0x2D8AD10", VA = "0x182D8C310", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x3211D40", Offset = "0x3210740", VA = "0x183211D40", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3211CD0", Offset = "0x32106D0", VA = "0x183211CD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x4522B80", Offset = "0x4521580", VA = "0x184522B80")]
		public POGGHNCPHIM(MEPABEFJJDI GGEKFPEBLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x4522B60", Offset = "0x4521560", VA = "0x184522B60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1366D20", Offset = "0x1365720", VA = "0x181366D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action FAFIMLJNNIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B26B40", Offset = "0x2B25540", VA = "0x182B26B40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B26AA0", Offset = "0x2B254A0", VA = "0x182B26AA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2B26BE0", Offset = "0x2B255E0", VA = "0x182B26BE0")]
	public POGGHNCPHIM OKABAIPNHMA()
	{
		return default(POGGHNCPHIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x15151B0", Offset = "0x1513BB0", VA = "0x1815151B0")]
	public void ENLMEGIJPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2B26A80", Offset = "0x2B25480", VA = "0x182B26A80")]
	public void CAKMAAHNNLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD7F000", Offset = "0xD7DA00", VA = "0x180D7F000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9E4870", Offset = "0x9E3270", VA = "0x1809E4870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x451E580", Offset = "0x451CF80", VA = "0x18451E580")]
			public MLJHPCKPIBB(NativeArray<int> PGIOKMAFKEF, NativeArray<int> JDFBPHJNCCJ, Dictionary<ComponentSystemBase, int> LAPCNIFNLJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x451E300", Offset = "0x451CD00", VA = "0x18451E300")]
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
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
			[DebuggerHidden]
			public OFBLMEGCFOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x451FED0", Offset = "0x451E8D0", VA = "0x18451FED0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x45200A0", Offset = "0x451EAA0", VA = "0x1845200A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x451FFF0", Offset = "0x451E9F0", VA = "0x18451FFF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x451FFF0", Offset = "0x451E9F0", VA = "0x18451FFF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3009C90", Offset = "0x3008690", VA = "0x183009C90", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x3009C00", Offset = "0x3008600", VA = "0x183009C00", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x300A910", Offset = "0x3009310", VA = "0x18300A910")]
		[IteratorStateMachine(typeof(OFBLMEGCFOJ))]
		private IEnumerable<ComponentSystemBase> PJEELELNIJJ(int LOEMONDJCMM, int FHNIHLGHOIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x3009B30", Offset = "0x3008530", VA = "0x183009B30", Slot = "5")]
		public void CCCAANGKKJB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x30097F0", Offset = "0x30081F0", VA = "0x1830097F0")]
		private void ABFKDFLIKKK(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x3009940", Offset = "0x3008340", VA = "0x183009940")]
		public void ABFKDFLIKKK(IKIGKMLBEFF MJMOJANEIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x3009E10", Offset = "0x3008810", VA = "0x183009E10")]
		private void IOAIEHLOOOB(IKIGKMLBEFF MJMOJANEIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x3009A40", Offset = "0x3008440", VA = "0x183009A40")]
		private void BFBGOMEJCMJ(IKIGKMLBEFF MJMOJANEIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x3009AD0", Offset = "0x30084D0", VA = "0x183009AD0")]
		private void BGNODGEIMCE(IKIGKMLBEFF MJMOJANEIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x300A780", Offset = "0x3009180", VA = "0x18300A780")]
		private void NPNDPEOIBDD(int LOEMONDJCMM, int FHNIHLGHOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3009D10", Offset = "0x3008710", VA = "0x183009D10")]
		private void HHABOMGLDEF(int LOEMONDJCMM, int FHNIHLGHOIB, bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x300A8F0", Offset = "0x30092F0", VA = "0x18300A8F0")]
		private int PGKBDOJLGJJ(IKIGKMLBEFF MJMOJANEIJI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x300A0A0", Offset = "0x3008AA0", VA = "0x18300A0A0")]
		private bool KNKBJFIEPNH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x300A630", Offset = "0x3009030", VA = "0x18300A630")]
		private Dictionary<ComponentSystemBase, int> LAPEBDIDLCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x3009DD0", Offset = "0x30087D0", VA = "0x183009DD0")]
		private void IINEJHILOGC(NativeArray<int> PGIOKMAFKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x300A840", Offset = "0x3009240", VA = "0x18300A840")]
		private void PDAFFGGBMMC(NativeArray<int> JDFBPHJNCCJ, NativeArray<int> PGIOKMAFKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x3009B40", Offset = "0x3008540", VA = "0x183009B40")]
		private static IKIGKMLBEFF CMMJEHEAENG(Type OGILDIMGIOH, IKIGKMLBEFF LGCPJJBBDLH)
		{
			return default(IKIGKMLBEFF);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x300AA30", Offset = "0x3009430", VA = "0x18300AA30")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x3009BA0", Offset = "0x30085A0", VA = "0x183009BA0")]
		[CompilerGenerated]
		private void DGNGMEDGKAG(GBCNOEIKEOL BKMJIJNEKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x300A720", Offset = "0x3009120", VA = "0x18300A720")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D86FA0", Offset = "0x2D859A0", VA = "0x182D86FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool CGHDMOJFHAK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2D873D0", Offset = "0x2D85DD0", VA = "0x182D873D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool EPOEGFNGCBC
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x2D86FA0", Offset = "0x2D859A0", VA = "0x182D86FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool ODNLFCJEPLO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x2D86FA0", Offset = "0x2D859A0", VA = "0x182D86FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D87190", Offset = "0x2D85B90", VA = "0x182D87190", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D875F0", Offset = "0x2D85FF0", VA = "0x182D875F0", Slot = "14")]
		public void KELKNBJLCKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2D87710", Offset = "0x2D86110", VA = "0x182D87710", Slot = "15")]
		public void KNCLOPNPPPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2D87300", Offset = "0x2D85D00", VA = "0x182D87300", Slot = "5")]
		public void GGAJJIABCDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2D86D50", Offset = "0x2D85750", VA = "0x182D86D50", Slot = "6")]
		public void CCKLGGGOKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2D87470", Offset = "0x2D85E70", VA = "0x182D87470", Slot = "7")]
		public void JJNLKDIEAMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D87830", Offset = "0x2D86230", VA = "0x182D87830", Slot = "8")]
		public void OCHBDEIBIOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D87010", Offset = "0x2D85A10", VA = "0x182D87010", Slot = "9")]
		public void FBFEIKPMFHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D86910", Offset = "0x2D85310", VA = "0x182D86910", Slot = "10")]
		public void ANNKCDNFBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D86ED0", Offset = "0x2D858D0", VA = "0x182D86ED0", Slot = "11")]
		public void CGMEJIBOEEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "13")]
		public void ADDOOMCCINB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2D879B0", Offset = "0x2D863B0", VA = "0x182D879B0", Slot = "12")]
		public void PEJPDMMCALD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public PHIPKIFAENI PDFOFNPFHNA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B29AA0", Offset = "0x2B284A0", VA = "0x182B29AA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2D95CD0", Offset = "0x2D946D0", VA = "0x182D95CD0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool AMOPNJPCIDE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x72B260", Offset = "0x729C60", VA = "0x18072B260", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2D95830", Offset = "0x2D94230", VA = "0x182D95830", Slot = "10")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D95B70", Offset = "0x2D94570", VA = "0x182D95B70", Slot = "11")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2D95BC0", Offset = "0x2D945C0", VA = "0x182D95BC0")]
		private void IDIKGABNBEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2D95940", Offset = "0x2D94340", VA = "0x182D95940", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2D95810", Offset = "0x2D94210", VA = "0x182D95810", Slot = "8")]
		public ComponentSystemBase DBEBPEAGNJB(Type OGILDIMGIOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x731A00", Offset = "0x730400", VA = "0x180731A00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x451CC60", Offset = "0x451B660", VA = "0x18451CC60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9892A0", Offset = "0x987CA0", VA = "0x1809892A0")]
		[DebuggerHidden]
		public KEMLJDKDHNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x451C950", Offset = "0x451B350", VA = "0x18451C950", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x451CC20", Offset = "0x451B620", VA = "0x18451CC20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x451CB80", Offset = "0x451B580", VA = "0x18451CB80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x451CB80", Offset = "0x451B580", VA = "0x18451CB80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2C2D0", Offset = "0x2B2ACD0", VA = "0x182B2C2D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<PPBNAGHDKKA> GEDCKBGJGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C450", Offset = "0x2B2AE50", VA = "0x182B2C450", Slot = "8")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C850", Offset = "0x2B2B250", VA = "0x182B2C850", Slot = "9")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C3C0", Offset = "0x2B2ADC0", VA = "0x182B2C3C0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C4B0", Offset = "0x2B2AEB0", VA = "0x182B2C4B0", Slot = "6")]
	public bool HFLPPPJPPFB(PPBNAGHDKKA GJEJKJANAJD, out EONMLKEIFOO KJJMKJFNPPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2B2BDA0", Offset = "0x2B2A7A0", VA = "0x182B2BDA0")]
	private void AECLDAOPKNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C5A0", Offset = "0x2B2AFA0", VA = "0x182B2C5A0")]
	private void KEPBPBLJBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C540", Offset = "0x2B2AF40", VA = "0x182B2C540")]
	private KFAMFFBNBDO ILBOHGGDLBB(string BOEEPHGJCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C2D0", Offset = "0x2B2ACD0", VA = "0x182B2C2D0")]
	private KFAMFFBNBDO EBDCJLPADGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C970", Offset = "0x2B2B370", VA = "0x182B2C970")]
	private KFAMFFBNBDO OPFFMEJHFBM(string BOEEPHGJCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C740", Offset = "0x2B2B140", VA = "0x182B2C740")]
	private KFAMFFBNBDO KMNGBEDECEH(string CCJFOCJJBJG, string MIFCLBEAOPM, [Optional] KFAMFFBNBDO PEACMLAHANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C180", Offset = "0x2B2AB80", VA = "0x182B2C180")]
	[IteratorStateMachine(typeof(KEMLJDKDHNH))]
	private IEnumerable<(string, string)> AOOLKBJPDDE(string BOEEPHGJCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C130", Offset = "0x2B2AB30", VA = "0x182B2C130")]
	private bool AGCIABNPEKD(PPBNAGHDKKA GJEJKJANAJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C1F0", Offset = "0x2B2ABF0", VA = "0x182B2C1F0")]
	private DPGGCLGJEJM BNMOMJINKEM(PPBNAGHDKKA GJEJKJANAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CBE0", Offset = "0x2B2B5E0", VA = "0x182B2CBE0")]
	private DPGGCLGJEJM PJMDKFFHMFO(PPBNAGHDKKA GJEJKJANAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C330", Offset = "0x2B2AD30", VA = "0x182B2C330")]
	private DPGGCLGJEJM DFIEAADCIBJ(PPBNAGHDKKA GJEJKJANAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x328D9C0", Offset = "0x328C3C0", VA = "0x18328D9C0")]
	private T LNKJFDFNMEI<T>(PPBNAGHDKKA GJEJKJANAJD) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C870", Offset = "0x2B2B270", VA = "0x182B2C870")]
	private FieldInfo NJMIFPHEHGP(PPBNAGHDKKA GJEJKJANAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CC30", Offset = "0x2B2B630", VA = "0x182B2CC30")]
	public OKLHDBBNMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C8E0", Offset = "0x2B2B2E0", VA = "0x182B2C8E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public EONMLKEIFOO MLJCCBIJDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<EONMLKEIFOO> HBGFCDLIBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<PPBNAGHDKKA> BDOBIEBIADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x30256F0", Offset = "0x30240F0", VA = "0x1830256F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x451B4A0", Offset = "0x4519EA0", VA = "0x18451B4A0")]
			public ICEDKDOEOFC(HistoryService LHDJJEMNOIF, bool HFOICHHBMOA, uint NHBDMCDLELK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x451B470", Offset = "0x4519E70", VA = "0x18451B470", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x45208D0", Offset = "0x451F2D0", VA = "0x1845208D0")]
				public OPPGPJJNFJI(HLPDAPBGAHJ DGJHENDBKJI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x45182F0", Offset = "0x4516CF0", VA = "0x1845182F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4518320", Offset = "0x4516D20", VA = "0x184518320")]
				public AMHCLMKFEHN(HLPDAPBGAHJ DGJHENDBKJI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x45182F0", Offset = "0x4516CF0", VA = "0x1845182F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x451AE80", Offset = "0x4519880", VA = "0x18451AE80")]
			public HLPDAPBGAHJ(HistoryService GGCACBKODOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x451ADB0", Offset = "0x45197B0", VA = "0x18451ADB0")]
			public bool DOPLAFEBOLO(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x451AE30", Offset = "0x4519830", VA = "0x18451AE30")]
			public AMHCLMKFEHN IPGHKHPLCMH()
			{
				return default(AMHCLMKFEHN);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x451ADE0", Offset = "0x45197E0", VA = "0x18451ADE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public GDDCDLFBOIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x451A090", Offset = "0x4518A90", VA = "0x18451A090")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public HFPFEJIJGHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x451A9F0", Offset = "0x45193F0", VA = "0x18451A9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public NHDMFPLCLNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x451EA50", Offset = "0x451D450", VA = "0x18451EA50")]
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
			[Cpp2IlInjected.Address(RVA = "0x7270B0", Offset = "0x725AB0", VA = "0x1807270B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool PKNLHBBEOAO
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x3017980", Offset = "0x3016380", VA = "0x183017980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool AMJJEBMJHAH
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x30192B0", Offset = "0x3017CB0", VA = "0x1830192B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool HGFNBODEFIE
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x3018CB0", Offset = "0x30176B0", VA = "0x183018CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int PHNODGMOOPM
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x3019390", Offset = "0x3017D90", VA = "0x183019390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int HOLPDDPFGJK
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x3019500", Offset = "0x3017F00", VA = "0x183019500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool EKOBFMMELJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x3019660", Offset = "0x3018060", VA = "0x183019660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool EMKOBLHNLJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x3019350", Offset = "0x3017D50", VA = "0x183019350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool EGPBHODFHNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x146D210", Offset = "0x146BC10", VA = "0x18146D210", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x146D220", Offset = "0x146BC20", VA = "0x18146D220", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer GJCBIBFODKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x3019380", Offset = "0x3017D80", VA = "0x183019380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action NLFHNPDJFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x30186F0", Offset = "0x30170F0", VA = "0x1830186F0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x3017A10", Offset = "0x3016410", VA = "0x183017A10", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action DMALGBLGJGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x30175B0", Offset = "0x3015FB0", VA = "0x1830175B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x30195C0", Offset = "0x3017FC0", VA = "0x1830195C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3018240", Offset = "0x3016C40", VA = "0x183018240", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3017CE0", Offset = "0x30166E0", VA = "0x183017CE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x30191F0", Offset = "0x3017BF0", VA = "0x1830191F0")]
		private void IPAKJGIELLA(KHMECMDAALD LMLBLIDPKCN, DMLPNPICGMP BGJLDEPELCD, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3019360", Offset = "0x3017D60", VA = "0x183019360")]
		private void JHEAAEHKBLC(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI OKDANAFGKFK, HAMGOKKMMPI CKCLLMGGJFK, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x3017670", Offset = "0x3016070", VA = "0x183017670")]
		private void AMEMCPIPABM(KHMECMDAALD LMLBLIDPKCN, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x30196F0", Offset = "0x30180F0", VA = "0x1830196F0", Slot = "14")]
		public IDisposable PMLHEABDGFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x3019690", Offset = "0x3018090", VA = "0x183019690", Slot = "9")]
		public IDisposable OHECDJKPJIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x3017850", Offset = "0x3016250", VA = "0x183017850", Slot = "6")]
		public UndoAction BJEGBDPPJJP()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x3018180", Offset = "0x3016B80", VA = "0x183018180", Slot = "15")]
		public RedoAction FIFKEGOMBKF()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x3018FB0", Offset = "0x30179B0", VA = "0x183018FB0", Slot = "16")]
		public UndoAction IENCPBALNFG()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x3018060", Offset = "0x3016A60", VA = "0x183018060", Slot = "7")]
		public RedoAction FIFKEGOMBKF(UndoAction ELODBNLDLIK)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x3018E90", Offset = "0x3017890", VA = "0x183018E90", Slot = "8")]
		public UndoAction IENCPBALNFG(RedoAction ELODBNLDLIK)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x3019580", Offset = "0x3017F80", VA = "0x183019580")]
		public bool MOBLHDJKPEF(ENMJMOMJFJC DHMHOPMBNDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x3017930", Offset = "0x3016330", VA = "0x183017930", Slot = "17")]
		public void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x3018790", Offset = "0x3017190", VA = "0x183018790")]
		public void FMBHGNBEDKM(KHMECMDAALD LMLBLIDPKCN, DMLPNPICGMP BGJLDEPELCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x3017C00", Offset = "0x3016600", VA = "0x183017C00")]
		public void DLMLBFOLJCO(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB, in HAMGOKKMMPI CKCLLMGGJFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x3018CE0", Offset = "0x30176E0", VA = "0x183018CE0")]
		public void HGOPOIHHGFH(KHMECMDAALD LMLBLIDPKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x3018850", Offset = "0x3017250", VA = "0x183018850")]
		private void FOJHHJAAKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x30194C0", Offset = "0x3017EC0", VA = "0x1830194C0")]
		private void MEDPFOBOCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x3019670", Offset = "0x3018070", VA = "0x183019670")]
		private void NKCCNPPBMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x3018D90", Offset = "0x3017790", VA = "0x183018D90")]
		private KICGPFCFCEA HONHHAPNJML()
		{
			return default(KICGPFCFCEA);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x3017650", Offset = "0x3016050", VA = "0x183017650")]
		private uint AJCMFAALKJD()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x30179F0", Offset = "0x30163F0", VA = "0x1830179F0")]
		private bool CJMONCBCHHP(out KICGPFCFCEA DAAMKALKLMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x3017910", Offset = "0x3016310", VA = "0x183017910")]
		private bool BLADFKDHGAG(out KICGPFCFCEA DAAMKALKLMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x3019430", Offset = "0x3017E30", VA = "0x183019430")]
		private RedoAction LAEJLNJLCMF(KICGPFCFCEA DAAMKALKLMO)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x3019520", Offset = "0x3017F20", VA = "0x183019520")]
		private UndoAction MLMIENAPKNI(KICGPFCFCEA DAAMKALKLMO)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x30189F0", Offset = "0x30173F0", VA = "0x1830189F0")]
		private KICGPFCFCEA GOMMHHDDNAK(KICGPFCFCEA DAAMKALKLMO, ActionBuffer OPOCKIBHDMM, bool HFOICHHBMOA)
		{
			return default(KICGPFCFCEA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x3017F80", Offset = "0x3016980", VA = "0x183017F80")]
		private void EDPOKMIDNLF(Action DAAMKALKLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2540AE0", Offset = "0x253F4E0", VA = "0x182540AE0")]
		private T EDPOKMIDNLF<T>(Func<T> MJJFBDCGCEG)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x3019490", Offset = "0x3017E90", VA = "0x183019490")]
		private ICEDKDOEOFC LPBCLKGFNOO(bool HFOICHHBMOA, uint NHBDMCDLELK)
		{
			return default(ICEDKDOEOFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x3019830", Offset = "0x3018230", VA = "0x183019830")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x3017AB0", Offset = "0x30164B0", VA = "0x183017AB0")]
		[CompilerGenerated]
		private UndoAction CPOCPCENOKD()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x3019070", Offset = "0x3017A70", VA = "0x183019070")]
		[CompilerGenerated]
		private RedoAction IKPABGBGLFD()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x3018890", Offset = "0x3017290", VA = "0x183018890")]
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
		[Cpp2IlInjected.Address(RVA = "0x77AFB0", Offset = "0x7799B0", VA = "0x18077AFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xCB93D0", Offset = "0xCB7DD0", VA = "0x180CB93D0")]
	public IOLMFOLDNDP(NativeArray<byte> BGAKDGCGOMH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3020730", Offset = "0x301F130", VA = "0x183020730")]
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
		[Cpp2IlInjected.Address(RVA = "0x77AFB0", Offset = "0x7799B0", VA = "0x18077AFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0xCB93D0", Offset = "0xCB7DD0", VA = "0x180CB93D0")]
	public FHOILCJKJKH(NativeArray<byte> BGAKDGCGOMH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x30108D0", Offset = "0x300F2D0", VA = "0x1830108D0")]
	public static FHOILCJKJKH HPHCHABBDNG(NativeArray<byte> BGAKDGCGOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2F7CC10", Offset = "0x2F7B610", VA = "0x182F7CC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x77AFB0", Offset = "0x7799B0", VA = "0x18077AFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xCB93D0", Offset = "0xCB7DD0", VA = "0x180CB93D0")]
	public LOLHGONHIIC(NativeArray<byte> BGAKDGCGOMH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2B25DF0", Offset = "0x2B247F0", VA = "0x182B25DF0")]
	public static LOLHGONHIIC HPHCHABBDNG(NativeArray<byte> BGAKDGCGOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x24D3940", Offset = "0x24D2340", VA = "0x1824D3940")]
	public void GLHEMHMMOJH<T>(in T LPJDDLMPNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x24D3840", Offset = "0x24D2240", VA = "0x1824D3840")]
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
	[Cpp2IlInjected.Address(RVA = "0x3019920", Offset = "0x3018320", VA = "0x183019920")]
	public static Span<byte> BDONJNMPHKP(this NativeArray<byte> BGAKDGCGOMH)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x3019AA0", Offset = "0x30184A0", VA = "0x183019AA0")]
	public static ReadOnlySpan<byte> KLMAFPAACIB(this NativeArray<byte> BGAKDGCGOMH)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x3019CA0", Offset = "0x30186A0", VA = "0x183019CA0")]
	public static NativeArray<byte> OPFJJLLMJHI(this NativeArray<byte> BGAKDGCGOMH, int LOEMONDJCMM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3019A20", Offset = "0x3018420", VA = "0x183019A20")]
	public static NativeArray<byte> JNPELLADDLL(this NativeArray<byte> BGAKDGCGOMH, int EJMNNLNLAFJ = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2542CF0", Offset = "0x25416F0", VA = "0x182542CF0")]
	public static NativeArray<byte> JNPELLADDLL<T>(this NativeArray<byte> BGAKDGCGOMH, int EJMNNLNLAFJ = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x30199B0", Offset = "0x30183B0", VA = "0x1830199B0")]
	public static NativeArray<byte> CNMIJOCAHOK(this NativeArray<byte> BGAKDGCGOMH, int EJMNNLNLAFJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2542C90", Offset = "0x2541690", VA = "0x182542C90")]
	public static NativeArray<byte> CNMIJOCAHOK<T>(this NativeArray<byte> BGAKDGCGOMH, int EJMNNLNLAFJ = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x3019C20", Offset = "0x3018620", VA = "0x183019C20")]
	public static NativeArray<byte> OCDKLLKBGGK(this NativeArray<byte> BGAKDGCGOMH, int EJMNNLNLAFJ = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2542D50", Offset = "0x2541750", VA = "0x182542D50")]
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
	[Cpp2IlInjected.Address(RVA = "0xCB93D0", Offset = "0xCB7DD0", VA = "0x180CB93D0")]
	public BFDMOCAKPAC(NativeList<byte> BDHPAGCMKHB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x31FCE00", Offset = "0x31FB800", VA = "0x1831FCE00")]
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
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2B42D30", Offset = "0x2B41730", VA = "0x182B42D30")]
		public OMIODPKIBFL.LMAJADMPFNM OKABAIPNHMA()
		{
			return default(OMIODPKIBFL.LMAJADMPFNM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2B41FE0", Offset = "0x2B409E0", VA = "0x182B41FE0", Slot = "4")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2B42420", Offset = "0x2B40E20", VA = "0x182B42420", Slot = "5")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2B420D0", Offset = "0x2B40AD0", VA = "0x182B420D0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2B41E60", Offset = "0x2B40860", VA = "0x182B41E60")]
		public void BJEGBDPPJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2B41F70", Offset = "0x2B40970", VA = "0x182B41F70")]
		public void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2B42310", Offset = "0x2B40D10", VA = "0x182B42310")]
		private void EOLMPJJKKNN(KHMECMDAALD LMLBLIDPKCN, DMLPNPICGMP BGJLDEPELCD, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2B42990", Offset = "0x2B41390", VA = "0x182B42990")]
		private void JMJKBJDFHGK(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI OKDANAFGKFK, HAMGOKKMMPI CKCLLMGGJFK, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2B42B70", Offset = "0x2B41570", VA = "0x182B42B70")]
		private void NKMAPFPPLGO(KHMECMDAALD LMLBLIDPKCN, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2B426A0", Offset = "0x2B410A0", VA = "0x182B426A0")]
		private void HOKMDCKMDPF(IPCMKODPKEI KCGHNGOMAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2B42A40", Offset = "0x2B41440", VA = "0x182B42A40")]
		private void MIBHMLPFBPM(IPCMKODPKEI KCGHNGOMAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2B42C70", Offset = "0x2B41670", VA = "0x182B42C70")]
		private void ODHIAINGNAC(IPCMKODPKEI KCGHNGOMAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2B422F0", Offset = "0x2B40CF0", VA = "0x182B422F0")]
		private void ENLMEGIJPNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2B41FA0", Offset = "0x2B409A0", VA = "0x182B41FA0")]
		private void CAKMAAHNNLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2B42D70", Offset = "0x2B41770", VA = "0x182B42D70")]
		private void OMCJGNANDCO(IPCMKODPKEI KCGHNGOMAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6A10", Offset = "0x3AF5410", VA = "0x183AF6A10", Slot = "6")]
		private void BGCDHBMGEIL<TKey, T>(global::CCCEMKOEGOF<TKey, T> GJEJKJANAJD, object PKDAKJPDDGD) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B42ED0", Offset = "0x2B418D0", VA = "0x182B42ED0")]
		public void FMBHGNBEDKM(KHMECMDAALD LMLBLIDPKCN, DMLPNPICGMP BGJLDEPELCD, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2B42E60", Offset = "0x2B41860", VA = "0x182B42E60")]
		public void DLMLBFOLJCO(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB, in HAMGOKKMMPI OKDANAFGKFK, in HAMGOKKMMPI CKCLLMGGJFK, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2B42EF0", Offset = "0x2B418F0", VA = "0x182B42EF0")]
		public void HGOPOIHHGFH(KHMECMDAALD LMLBLIDPKCN, bool NBAKJOACACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
				[Cpp2IlInjected.Address(RVA = "0x2D7B0F0", Offset = "0x2D79AF0", VA = "0x182D7B0F0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public JIHAFMIAAIC[] JKNNMEHLMAH
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x2D7B140", Offset = "0x2D79B40", VA = "0x182D7B140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
			public HGPKIMEHPDG(ActionBuffer PMJAJGIIPLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x2D7B000", Offset = "0x2D79A00", VA = "0x182D7B000")]
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
				[Cpp2IlInjected.Address(RVA = "0x2D7B9B0", Offset = "0x2D7A3B0", VA = "0x182D7B9B0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(IPCMKODPKEI, string, object)> JHEKMFNFJAE
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x2D7BA00", Offset = "0x2D7A400", VA = "0x182D7BA00")]
			public JIHAFMIAAIC(ActionBuffer PMJAJGIIPLC, KICGPFCFCEA DAAMKALKLMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2D7B570", Offset = "0x2D79F70", VA = "0x182D7B570")]
			private string ECMIJIDIAKO(IPCMKODPKEI DBFAEACKJAP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2D7B670", Offset = "0x2D7A070", VA = "0x182D7B670")]
			private void GJPLHHGHDFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x2B7EEE0", Offset = "0x2B7D8E0", VA = "0x182B7EEE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x31FBA80", Offset = "0x31FA480", VA = "0x1831FBA80")]
			get
			{
				return default(AGCEJKCDEOB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int JAMIBFCLJNH
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x31FB920", Offset = "0x31FA320", VA = "0x1831FB920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x31FBDF0", Offset = "0x31FA7F0", VA = "0x1831FBDF0")]
		public ActionBuffer(PDEHIBGGEFM MAAOOBLKAKG, IMLNJKELEFP FNBGFGCHFDN, bool ONBNLMJEALH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x31FB120", Offset = "0x31F9B20", VA = "0x1831FB120")]
		public bool ALJCOBBBGHP(out KICGPFCFCEA DAAMKALKLMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x31FB2F0", Offset = "0x31F9CF0", VA = "0x1831FB2F0")]
		public void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x31FB1B0", Offset = "0x31F9BB0", VA = "0x1831FB1B0")]
		public KICGPFCFCEA BJEGBDPPJJP(FEPGBIOBLKH ADLONPJHLHJ, PAOJOGODKBK NMHINGLMCCB, uint ILCGCMHKGIB)
		{
			return default(KICGPFCFCEA);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x31FBD70", Offset = "0x31FA770", VA = "0x1831FBD70")]
		public bool PAGIPLMHKNM(uint ILCGCMHKGIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x31FB360", Offset = "0x31F9D60", VA = "0x1831FB360")]
		public bool DPOAMBADENB(uint ILCGCMHKGIB, out KICGPFCFCEA ELODBNLDLIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x31FBAC0", Offset = "0x31FA4C0", VA = "0x1831FBAC0")]
		public void NPKOPBOEEMM(KICGPFCFCEA ELODBNLDLIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x31FBC30", Offset = "0x31FA630", VA = "0x1831FBC30")]
		[Conditional("DEBUG_BUILD")]
		private void OBJGDMGDHME(KICGPFCFCEA ELODBNLDLIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x31FB810", Offset = "0x31FA210", VA = "0x1831FB810")]
		private void GOMMHHDDNAK(KICGPFCFCEA JMIBENEKCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x31FB5C0", Offset = "0x31F9FC0", VA = "0x1831FB5C0")]
		private void FMGACEJBBCA(FHOILCJKJKH GBAHMLMAEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x31FB960", Offset = "0x31FA360", VA = "0x1831FB960")]
		private void JCFFJFIBCFL(KICGPFCFCEA DAAMKALKLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x31FB9C0", Offset = "0x31FA3C0", VA = "0x1831FB9C0")]
		private FHOILCJKJKH JLEMFPMNDKC(KICGPFCFCEA DAAMKALKLMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x31FB550", Offset = "0x31F9F50", VA = "0x1831FB550", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7B6A40", Offset = "0x7B5440", VA = "0x1807B6A40")]
	public FCMEBFGKGAD(PDEHIBGGEFM MAAOOBLKAKG, IMLNJKELEFP FNBGFGCHFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F6DFD0", Offset = "0x2F6C9D0", VA = "0x182F6DFD0", Slot = "4")]
	public void BHJDIJLHOEC<TKey, T>(global::CCCEMKOEGOF<TKey, T> HFBHMHPIKOM, [Optional] object PKDAKJPDDGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x300F1D0", Offset = "0x300DBD0", VA = "0x18300F1D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x451D950", Offset = "0x451C350", VA = "0x18451D950")]
		public LMAJADMPFNM(OMIODPKIBFL GGEKFPEBLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x451D930", Offset = "0x451C330", VA = "0x18451D930", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2D230", Offset = "0x2B2BC30", VA = "0x182B2D230")]
		get
		{
			return default(FEPGBIOBLKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool LCEGKFHJAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CF50", Offset = "0x2B2B950", VA = "0x182B2CF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D2A0", Offset = "0x2B2BCA0", VA = "0x182B2D2A0")]
	public OMIODPKIBFL(FEPGBIOBLKH.ENKLKGKBNCP GNBMALGACIE = FEPGBIOBLKH.ENKLKGKBNCP.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CDA0", Offset = "0x2B2B7A0", VA = "0x182B2CDA0")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D060", Offset = "0x2B2BA60", VA = "0x182B2D060")]
	public void FMBHGNBEDKM(KHMECMDAALD LMLBLIDPKCN, DMLPNPICGMP BGJLDEPELCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CEB0", Offset = "0x2B2B8B0", VA = "0x182B2CEB0")]
	public void DLMLBFOLJCO(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D150", Offset = "0x2B2BB50", VA = "0x182B2D150")]
	public void HGOPOIHHGFH(KHMECMDAALD LMLBLIDPKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CF60", Offset = "0x2B2B960", VA = "0x182B2CF60")]
	public void ENLMEGIJPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CDB0", Offset = "0x2B2B7B0", VA = "0x182B2CDB0")]
	public void CAKMAAHNNLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CF40", Offset = "0x2B2B940", VA = "0x182B2CF40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D270", Offset = "0x2B2BC70", VA = "0x182B2D270")]
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
		[Cpp2IlInjected.Address(RVA = "0x3020810", Offset = "0x301F210", VA = "0x183020810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x731A30", Offset = "0x730430", VA = "0x180731A30")]
	public IPCMKODPKEI(KHMECMDAALD LMLBLIDPKCN, AHKPLOLMABO CBPECCEKJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x30209A0", Offset = "0x301F3A0", VA = "0x1830209A0")]
	public void PANBANONDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x30207D0", Offset = "0x301F1D0", VA = "0x1830207D0", Slot = "4")]
	public int CompareTo(IPCMKODPKEI MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x30209B0", Offset = "0x301F3B0", VA = "0x1830209B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3020870", Offset = "0x301F270", VA = "0x183020870", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3020820", Offset = "0x301F220", VA = "0x183020820", Slot = "5")]
	public bool Equals(IPCMKODPKEI MPHACEGLFIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x3020790", Offset = "0x301F190", VA = "0x183020790")]
	public static bool BOBJELOEACN(IPCMKODPKEI GBEJHLEFDJM, IPCMKODPKEI BDGBOHJLNIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3020910", Offset = "0x301F310", VA = "0x183020910")]
	public static bool GPCPOEGFAHL(IPCMKODPKEI GBEJHLEFDJM, IPCMKODPKEI BDGBOHJLNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3020960", Offset = "0x301F360", VA = "0x183020960", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x3013960", Offset = "0x3012360", VA = "0x183013960")]
		public void EIPBGIFBMDC(KHMECMDAALD LMLBLIDPKCN, PDEHIBGGEFM MAAOOBLKAKG, HistoryService GGCACBKODOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x3013890", Offset = "0x3012290", VA = "0x183013890", Slot = "4")]
		private void AAMAEIAIBKE(EJMAGAGALIM GJEJKJANAJD, in HAMGOKKMMPI LPJDDLMPNCG, object PKDAKJPDDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class KGIMDLLPJLE
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x3025B70", Offset = "0x3024570", VA = "0x183025B70")]
	public static void MIBHMLPFBPM(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP, DMLPNPICGMP BGJLDEPELCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x3025A30", Offset = "0x3024430", VA = "0x183025A30")]
	public static void LBFNOMMPJKL(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x3025D10", Offset = "0x3024710", VA = "0x183025D10")]
	public static void ODHIAINGNAC(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x3025860", Offset = "0x3024260", VA = "0x183025860")]
	public static void BJBKIBPJLBP(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x30259E0", Offset = "0x30243E0", VA = "0x1830259E0")]
	public static DMLPNPICGMP KDFHHGMLGCF(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP)
	{
		return default(DMLPNPICGMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x24BE090", Offset = "0x24BCA90", VA = "0x1824BE090")]
	public static T HFCOOPOGKAC<T>(FEPGBIOBLKH ADLONPJHLHJ, IPCMKODPKEI DBFAEACKJAP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x24BE040", Offset = "0x24BCA40", VA = "0x1824BE040")]
	public static T HFCOOPOGKAC<T>(ref FHOILCJKJKH HIDEHJGLNHO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x3025990", Offset = "0x3024390", VA = "0x183025990")]
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
		[Cpp2IlInjected.Address(RVA = "0x45181F0", Offset = "0x4516BF0", VA = "0x1845181F0")]
		public ALDAIOMGCAP(FEPGBIOBLKH BDHPAGCMKHB, PAOJOGODKBK NMHINGLMCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4517B30", Offset = "0x4516530", VA = "0x184517B30")]
		public void EHGGJACIGMB(NativeList<byte> NEHKLODBFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x45181A0", Offset = "0x4516BA0", VA = "0x1845181A0")]
		private void KAAFJKHDADI(IPCMKODPKEI DBFAEACKJAP, ref LOLHGONHIIC IHEOGLOJMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4518110", Offset = "0x4516B10", VA = "0x184518110")]
		private void HNLNPFNFMMG(IPCMKODPKEI DBFAEACKJAP, ref LOLHGONHIIC IHEOGLOJMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x4518020", Offset = "0x4516A20", VA = "0x184518020")]
		private NativeArray<byte> HLABFODDMCH(NativeList<byte> NEHKLODBFEL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x4517A40", Offset = "0x4516440", VA = "0x184517A40")]
		private NativeArray<byte> BJAKMJPOHDB(NativeList<byte> NEHKLODBFEL, int OEMPOIHBNFL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x4517DD0", Offset = "0x45167D0", VA = "0x184517DD0")]
		private int EKIPDEMPEMI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x45178E0", Offset = "0x45162E0", VA = "0x1845178E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4518F00", Offset = "0x4517900", VA = "0x184518F00")]
		internal DOIGOCBAIEH(FEPGBIOBLKH BDHPAGCMKHB, IPCMKODPKEI KCGHNGOMAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x4518D40", Offset = "0x4517740", VA = "0x184518D40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x4518C80", Offset = "0x4517680", VA = "0x184518C80")]
		public void ANEGIJJPHFF(NativeArray<byte> LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x4518CE0", Offset = "0x45176E0", VA = "0x184518CE0")]
		public void DJKEKMKGPEL(NativeArray<byte> LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x4518D70", Offset = "0x4517770", VA = "0x184518D70")]
		public void HNLNPFNFMMG(in HAMGOKKMMPI LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2E70430", Offset = "0x2E6EE30", VA = "0x182E70430")]
		public void HNLNPFNFMMG<T>(T LPJDDLMPNCG) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x4518E30", Offset = "0x4517830", VA = "0x184518E30")]
		private void LCLHPBKHPAM(int LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x4518D80", Offset = "0x4517780", VA = "0x184518D80")]
		private void LCLHPBKHPAM(in HAMGOKKMMPI LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x4518EA0", Offset = "0x45178A0", VA = "0x184518EA0")]
		private unsafe void LCLHPBKHPAM(void* NODHJJDGNEC, int OEMPOIHBNFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x4518C80", Offset = "0x4517680", VA = "0x184518C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x4520480", Offset = "0x451EE80", VA = "0x184520480")]
		internal OJADLINNLEO(FEPGBIOBLKH BDHPAGCMKHB, NativeArray<byte> HIDEHJGLNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x45201C0", Offset = "0x451EBC0", VA = "0x1845201C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x45201D0", Offset = "0x451EBD0", VA = "0x1845201D0")]
		public NativeArray<byte> EHHANNAAJOE(int OEMPOIHBNFL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x4520290", Offset = "0x451EC90", VA = "0x184520290")]
		public NativeArray<byte> GNCIDMDEEJC()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2E89640", Offset = "0x2E88040", VA = "0x182E89640")]
		public T NHFGEFLKDIC<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x4520380", Offset = "0x451ED80", VA = "0x184520380")]
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
			[Cpp2IlInjected.Address(RVA = "0x4518C30", Offset = "0x4517630", VA = "0x184518C30", Slot = "4")]
			get
			{
				return default(IPCMKODPKEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x4518BF0", Offset = "0x45175F0", VA = "0x184518BF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x31E5020", Offset = "0x31E3A20", VA = "0x1831E5020")]
		internal DMEMOAGPHPJ(NativeList<IPCMKODPKEI> EBCEJCLCIMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x4518AB0", Offset = "0x45174B0", VA = "0x184518AB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x4518BB0", Offset = "0x45175B0", VA = "0x184518BB0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x45209F0", Offset = "0x451F3F0", VA = "0x1845209F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int DFHLMIKLJID
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x4520B00", Offset = "0x451F500", VA = "0x184520B00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x4520AF0", Offset = "0x451F4F0", VA = "0x184520AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public ENKLKGKBNCP OBJCLKADGKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x4520B40", Offset = "0x451F540", VA = "0x184520B40")]
			get
			{
				return default(ENKLKGKBNCP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x4520AE0", Offset = "0x451F4E0", VA = "0x184520AE0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool LCEGKFHJAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x4520AB0", Offset = "0x451F4B0", VA = "0x184520AB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x45209D0", Offset = "0x451F3D0", VA = "0x1845209D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool ECFKBIKFFBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x4520B50", Offset = "0x451F550", VA = "0x184520B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x4520AC0", Offset = "0x451F4C0", VA = "0x184520AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x4520B60", Offset = "0x451F560", VA = "0x184520B60")]
		public PBPAEEIBCAL(ENKLKGKBNCP GNBMALGACIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x4520B10", Offset = "0x451F510", VA = "0x184520B10")]
		private int MKLBNKEKMJE(int LBOLDANMBMA, int IDHBPAJKMCA = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x4520A70", Offset = "0x451F470", VA = "0x184520A70")]
		private void EFMALMFMJGL(int LBOLDANMBMA, int LPJDDLMPNCG, int IDHBPAJKMCA = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x4520A30", Offset = "0x451F430", VA = "0x184520A30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x300F710", Offset = "0x300E110", VA = "0x18300F710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MJGLDBCMJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x300F340", Offset = "0x300DD40", VA = "0x18300F340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int DFHLMIKLJID
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x300FC80", Offset = "0x300E680", VA = "0x18300FC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int BPBPJHBANKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x300FEB0", Offset = "0x300E8B0", VA = "0x18300FEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x300F300", Offset = "0x300DD00", VA = "0x18300F300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x300F910", Offset = "0x300E310", VA = "0x18300F910")]
	public static FEPGBIOBLKH IDIKGABNBEI(ENKLKGKBNCP GNBMALGACIE = ENKLKGKBNCP.Last, int IDDJMNODLHM = 16, int ELEILMCPPJC = 256)
	{
		return default(FEPGBIOBLKH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x300FFF0", Offset = "0x300E9F0", VA = "0x18300FFF0")]
	private FEPGBIOBLKH(ENKLKGKBNCP GNBMALGACIE, int IDDJMNODLHM, int ELEILMCPPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x300F630", Offset = "0x300E030", VA = "0x18300F630", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x300F880", Offset = "0x300E280", VA = "0x18300F880")]
	public DOIGOCBAIEH HOKMDCKMDPF(IPCMKODPKEI KCGHNGOMAMI)
	{
		return default(DOIGOCBAIEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x300F7F0", Offset = "0x300E1F0", VA = "0x18300F7F0")]
	public OJADLINNLEO FOGLOKNECFM(IPCMKODPKEI KCGHNGOMAMI)
	{
		return default(OJADLINNLEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x300F440", Offset = "0x300DE40", VA = "0x18300F440")]
	public bool CJLKEHONHIG(IPCMKODPKEI KCGHNGOMAMI, out OJADLINNLEO GEFBMNBCACO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x300F950", Offset = "0x300E350", VA = "0x18300F950")]
	public bool IDLANPBCNKF(IPCMKODPKEI KCGHNGOMAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x300F720", Offset = "0x300E120", VA = "0x18300F720")]
	public bool EONDDIADOFD(IPCMKODPKEI KCGHNGOMAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x300F9A0", Offset = "0x300E3A0", VA = "0x18300F9A0")]
	public void INGGJNILIID(NativeList<byte> NEHKLODBFEL, PAOJOGODKBK NMHINGLMCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x2F763E0", Offset = "0x2F74DE0", VA = "0x182F763E0")]
	public T PKFLHEEHOPC<T>(IPCMKODPKEI KCGHNGOMAMI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x300F360", Offset = "0x300DD60", VA = "0x18300F360")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x300FD80", Offset = "0x300E780", VA = "0x18300FD80")]
	public DMEMOAGPHPJ OKFDNCHLPHK()
	{
		return default(DMEMOAGPHPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x300FA90", Offset = "0x300E490", VA = "0x18300FA90")]
	private void JOADFNLLICE(IPCMKODPKEI KCGHNGOMAMI, int LOEMONDJCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x300FDC0", Offset = "0x300E7C0", VA = "0x18300FDC0")]
	private void PANBANONDJF(int KLIKLNGCPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x300FC90", Offset = "0x300E690", VA = "0x18300FC90")]
	private void NPCLCFJAHMH(IPCMKODPKEI KCGHNGOMAMI, int LOEMONDJCMM, int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2F76590", Offset = "0x2F74F90", VA = "0x182F76590")]
	private static T PKFLHEEHOPC<T>(NativeArray<byte> BGAKDGCGOMH, int LBOLDANMBMA = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x300FF30", Offset = "0x300E930", VA = "0x18300FF30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x300FEF0", Offset = "0x300E8F0", VA = "0x18300FEF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2881990", Offset = "0x2880390", VA = "0x182881990", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2881A20", Offset = "0x2880420", VA = "0x182881A20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2881A90", Offset = "0x2880490", VA = "0x182881A90")]
	public IPKINOFCIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x225B720", Offset = "0x225A120", VA = "0x18225B720", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x32066D0", Offset = "0x32050D0", VA = "0x1832066D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x3206770", Offset = "0x3205170", VA = "0x183206770", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3012360", Offset = "0x3010D60", VA = "0x183012360", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x30123B0", Offset = "0x3010DB0", VA = "0x1830123B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x3012440", Offset = "0x3010E40", VA = "0x183012440", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public GBOJBDKCCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3025680", Offset = "0x3024080", VA = "0x183025680", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x30256D0", Offset = "0x30240D0", VA = "0x1830256D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public KEIMIAKJBIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3214120", Offset = "0x3212B20", VA = "0x183214120", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x3214170", Offset = "0x3212B70", VA = "0x183214170", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x3214200", Offset = "0x3212C00", VA = "0x183214200", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x320FC90", Offset = "0x320E690", VA = "0x18320FC90", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x320FCE0", Offset = "0x320E6E0", VA = "0x18320FCE0")]
		public void JCNPEJMIGKN(NativeListAsync<FJIBCOPGCCJ> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x320F6B0", Offset = "0x320E0B0", VA = "0x18320F6B0")]
		public void ALLCGBCGAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x320FB20", Offset = "0x320E520", VA = "0x18320FB20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x320FDA0", Offset = "0x320E7A0", VA = "0x18320FDA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B3F200", Offset = "0x2B3DC00", VA = "0x182B3F200", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F400", Offset = "0x2B3DE00", VA = "0x182B3F400", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F4A0", Offset = "0x2B3DEA0", VA = "0x182B3F4A0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F690", Offset = "0x2B3E090", VA = "0x182B3F690", Slot = "5")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F2A0", Offset = "0x2B3DCA0", VA = "0x182B3F2A0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F5C0", Offset = "0x2B3DFC0", VA = "0x182B3F5C0", Slot = "8")]
		public bool LNGFLCBAKIP(MBEDCJLMHEO LKHNLAILFFL, out Collider CMHAOFFOOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F140", Offset = "0x2B3DB40", VA = "0x182B3F140")]
		private void CBMAJNODLMB(Entity LCLDFKAJPDK, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI DKOFAPECACL, HAMGOKKMMPI JFNADPGFOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F080", Offset = "0x2B3DA80", VA = "0x182B3F080", Slot = "9")]
		public void BFCCMJHFDMK(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B46EB0", Offset = "0x2B458B0", VA = "0x182B46EB0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2B45AD0", Offset = "0x2B444D0", VA = "0x182B45AD0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2B47C70", Offset = "0x2B46670", VA = "0x182B47C70", Slot = "6")]
		public KDBGLABEDCA PFFFDOEGHBO(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2B47FC0", Offset = "0x2B469C0", VA = "0x182B47FC0", Slot = "5")]
		public void PNOHJMGOEGC(MBEDCJLMHEO LKHNLAILFFL, KDBGLABEDCA LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2B451B0", Offset = "0x2B43BB0", VA = "0x182B451B0", Slot = "34")]
		public CollisionDetectionMode DBALPFALMHB(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2B463B0", Offset = "0x2B44DB0", VA = "0x182B463B0", Slot = "35")]
		public void HEMGCFGIIHJ(MBEDCJLMHEO LKHNLAILFFL, CollisionDetectionMode LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2B467F0", Offset = "0x2B451F0", VA = "0x182B467F0", Slot = "36")]
		public GGPABLKNBJB IEJIBOLKGMO(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(GGPABLKNBJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2B47170", Offset = "0x2B45B70", VA = "0x182B47170", Slot = "37")]
		public void LHNNICANLHA(MBEDCJLMHEO LKHNLAILFFL, GGPABLKNBJB LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2B45630", Offset = "0x2B44030", VA = "0x182B45630", Slot = "38")]
		public bool EJCMKPHGFNN(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2B47A40", Offset = "0x2B46440", VA = "0x182B47A40", Slot = "39")]
		public void NPNKOHPAGGE(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2B479C0", Offset = "0x2B463C0", VA = "0x182B479C0", Slot = "40")]
		public MBEDCJLMHEO NKAKDLGIEDI(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2B44F80", Offset = "0x2B43980", VA = "0x182B44F80", Slot = "41")]
		public void CIAELCNFLBC(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2B47830", Offset = "0x2B46230", VA = "0x182B47830", Slot = "42")]
		public MBEDCJLMHEO NGLDHLBMECO(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2B45280", Offset = "0x2B43C80", VA = "0x182B45280", Slot = "43")]
		public void DEIBNNOCJKC(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2B46F00", Offset = "0x2B45900", VA = "0x182B46F00", Slot = "7")]
		public void LBIPGKKJCGE(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2B45860", Offset = "0x2B44260", VA = "0x182B45860", Slot = "8")]
		public void FHJPDJCNJIO(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2B45C10", Offset = "0x2B44610", VA = "0x182B45C10", Slot = "9")]
		public int FOLBFCNBPGG(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2B44C40", Offset = "0x2B43640", VA = "0x182B44C40", Slot = "10")]
		public MBEDCJLMHEO AFFCJINMNLA(MBEDCJLMHEO LKHNLAILFFL, int EGNHJGKABLC)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2B44E90", Offset = "0x2B43890", VA = "0x182B44E90", Slot = "11")]
		public void BPPDOOIJNCK(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2B47D00", Offset = "0x2B46700", VA = "0x182B47D00", Slot = "12")]
		public void PHOAGLHHAKF(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM, MBEDCJLMHEO LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2B47EB0", Offset = "0x2B468B0", VA = "0x182B47EB0", Slot = "13")]
		public void PMFNLELDECK(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2B460C0", Offset = "0x2B44AC0", VA = "0x182B460C0", Slot = "14")]
		public bool GOIAOANMDLM(MBEDCJLMHEO LKHNLAILFFL, out MBEDCJLMHEO LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2B470F0", Offset = "0x2B45AF0", VA = "0x182B470F0", Slot = "15")]
		public void LGHADIIEOMO(MBEDCJLMHEO LKHNLAILFFL, float3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2B473E0", Offset = "0x2B45DE0", VA = "0x182B473E0", Slot = "16")]
		public bool LNJIEHOODNE(MBEDCJLMHEO LKHNLAILFFL, out float3 LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2B47E30", Offset = "0x2B46830", VA = "0x182B47E30", Slot = "17")]
		public void PJFBMEDDOMI(MBEDCJLMHEO LKHNLAILFFL, float3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2B47540", Offset = "0x2B45F40", VA = "0x182B47540", Slot = "18")]
		public bool LPAOBNMILFA(MBEDCJLMHEO LKHNLAILFFL, out float3 LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2B46770", Offset = "0x2B45170", VA = "0x182B46770", Slot = "26")]
		public float3 IEDIGKGOOFH(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2B47F40", Offset = "0x2B46940", VA = "0x182B47F40", Slot = "27")]
		public void PNBIFKFCFEF(MBEDCJLMHEO LKHNLAILFFL, float3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2B45090", Offset = "0x2B43A90", VA = "0x182B45090", Slot = "28")]
		public float CLGPBIPODBA(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2B47760", Offset = "0x2B46160", VA = "0x182B47760", Slot = "29")]
		public void MMGDLCDAMEC(MBEDCJLMHEO LKHNLAILFFL, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2B46420", Offset = "0x2B44E20", VA = "0x182B46420", Slot = "30")]
		public float HIEEMPLBCBL(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2B46610", Offset = "0x2B45010", VA = "0x182B46610", Slot = "31")]
		public void IAOOGBCNABD(MBEDCJLMHEO LKHNLAILFFL, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2B46060", Offset = "0x2B44A60", VA = "0x182B46060", Slot = "32")]
		public bool GOGNADAHOLJ(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2B45300", Offset = "0x2B43D00", VA = "0x182B45300", Slot = "33")]
		public void DGBINAHEAEE(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2B453F0", Offset = "0x2B43DF0", VA = "0x182B453F0", Slot = "19")]
		public void DPAOADDDONC(MBEDCJLMHEO LKHNLAILFFL, float3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2B45970", Offset = "0x2B44370", VA = "0x182B45970", Slot = "20")]
		public bool FJGKPONAGMO(MBEDCJLMHEO LKHNLAILFFL, out float3 LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2B45E60", Offset = "0x2B44860", VA = "0x182B45E60", Slot = "21")]
		public void GGEOIJADDAL(MBEDCJLMHEO LKHNLAILFFL, quaternion LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2B46D50", Offset = "0x2B45750", VA = "0x182B46D50", Slot = "22")]
		public bool KDFDPKKDFBE(MBEDCJLMHEO LKHNLAILFFL, out quaternion LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2B46950", Offset = "0x2B45350", VA = "0x182B46950", Slot = "23")]
		public bool JEPPPKKDFAL(MBEDCJLMHEO LKHNLAILFFL, out float3 LDCILLCEGOA, out quaternion JLHJJCGNBIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2B45150", Offset = "0x2B43B50", VA = "0x182B45150", Slot = "44")]
		public JGBCGHMDEIJ DAJNHLLCKKK(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(JGBCGHMDEIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2B47370", Offset = "0x2B45D70", VA = "0x182B47370", Slot = "45")]
		public void LMHKMBLLNKH(MBEDCJLMHEO LKHNLAILFFL, JGBCGHMDEIJ LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2B46680", Offset = "0x2B45080", VA = "0x182B46680", Slot = "72")]
		public void IDKBLHEFGGI(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2B46BC0", Offset = "0x2B455C0", VA = "0x182B46BC0", Slot = "73")]
		public void JKNDEMFHIOF(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2B478E0", Offset = "0x2B462E0", VA = "0x182B478E0", Slot = "74")]
		public bool NHKDMHMIKIK(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2B45B80", Offset = "0x2B44580", VA = "0x182B45B80", Slot = "81")]
		public void FMPBDGIJBJD(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x2B45F40", Offset = "0x2B44940", VA = "0x182B45F40", Slot = "82")]
		public void GJAIHIHFBDH(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2B462A0", Offset = "0x2B44CA0", VA = "0x182B462A0", Slot = "83")]
		public bool HDGJBBOFHJN(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2B46C50", Offset = "0x2B45650", VA = "0x182B46C50", Slot = "84")]
		public IEnumerable<object> KAFMOCCIOJA(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2B450F0", Offset = "0x2B43AF0", VA = "0x182B450F0", Slot = "46")]
		public bool CNKKOFMMENM(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2B455D0", Offset = "0x2B43FD0", VA = "0x182B455D0", Slot = "47")]
		public void EHLPGNEBPIO(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2B46890", Offset = "0x2B45290", VA = "0x182B46890", Slot = "48")]
		public bool JCCHEICONKJ(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2B44DC0", Offset = "0x2B437C0", VA = "0x182B44DC0", Slot = "49")]
		public void BINFNPDGILF(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2B46710", Offset = "0x2B45110", VA = "0x182B46710", Slot = "50")]
		public bool IDLIKPAABMC(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2B47AB0", Offset = "0x2B464B0", VA = "0x182B47AB0", Slot = "51")]
		public void OCCHINDKMIM(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2B47960", Offset = "0x2B46360", VA = "0x182B47960", Slot = "52")]
		public RigidbodyConstraints NILPJFHJIGA(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2B45210", Offset = "0x2B43C10", VA = "0x182B45210", Slot = "53")]
		public void DDHOHLCNECK(MBEDCJLMHEO LKHNLAILFFL, RigidbodyConstraints LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2B477D0", Offset = "0x2B461D0", VA = "0x182B477D0", Slot = "54")]
		public float NCABHLAACGB(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2B47080", Offset = "0x2B45A80", VA = "0x182B47080", Slot = "55")]
		public void LFIHLJEIFHA(MBEDCJLMHEO LKHNLAILFFL, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2B476A0", Offset = "0x2B460A0", VA = "0x182B476A0", Slot = "56")]
		public float LPDKNFGEPGF(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x2B47010", Offset = "0x2B45A10", VA = "0x182B47010", Slot = "57")]
		public void LDNBNFLIDKJ(MBEDCJLMHEO LKHNLAILFFL, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2B468F0", Offset = "0x2B452F0", VA = "0x182B468F0", Slot = "58")]
		public bool JCCNHDCLLAE(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2B45ED0", Offset = "0x2B448D0", VA = "0x182B45ED0", Slot = "59")]
		public void GGMJOFJLDAP(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2B47B20", Offset = "0x2B46520", VA = "0x182B47B20", Slot = "60")]
		public bool OHOPFPFHPPJ(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2B46510", Offset = "0x2B44F10", VA = "0x182B46510", Slot = "61")]
		public void HMDLPKBMGDD(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2B44D60", Offset = "0x2B43760", VA = "0x182B44D60", Slot = "62")]
		public int AOCMJNELMED(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2B457F0", Offset = "0x2B441F0", VA = "0x182B457F0", Slot = "63")]
		public void EODNJMDIBLP(MBEDCJLMHEO LKHNLAILFFL, int LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2B46480", Offset = "0x2B44E80", VA = "0x182B46480", Slot = "64")]
		public Rigidbody HLAFBBKOEEP(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2B47210", Offset = "0x2B45C10", VA = "0x182B47210", Slot = "65")]
		public void LIAHODNPDEH(MBEDCJLMHEO LKHNLAILFFL, Rigidbody LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2B45000", Offset = "0x2B43A00", VA = "0x182B45000", Slot = "75")]
		public void CKHAMKLFKNJ(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2B45540", Offset = "0x2B43F40", VA = "0x182B45540", Slot = "76")]
		public void EBMHEPBKMJO(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2B45370", Offset = "0x2B43D70", VA = "0x182B45370", Slot = "77")]
		public bool DNEELFHOJEJ(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x2B46320", Offset = "0x2B44D20", VA = "0x182B46320", Slot = "66")]
		public object HEHNIDIDKOJ(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2B45D00", Offset = "0x2B44700", VA = "0x182B45D00", Slot = "67")]
		public void GGBBFOEBNDJ(MBEDCJLMHEO LKHNLAILFFL, object LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B45FD0", Offset = "0x2B449D0", VA = "0x182B45FD0", Slot = "68")]
		public object GKGFKHDLJPB(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B45690", Offset = "0x2B44090", VA = "0x182B45690", Slot = "69")]
		public void EJGBENLMOLA(MBEDCJLMHEO LKHNLAILFFL, object LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B47B80", Offset = "0x2B46580", VA = "0x182B47B80", Slot = "70")]
		public float PAMPBGKMLGP(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B48070", Offset = "0x2B46A70", VA = "0x182B48070", Slot = "71")]
		public void PPEMJOPAMJI(MBEDCJLMHEO LKHNLAILFFL, float LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B47BE0", Offset = "0x2B465E0", VA = "0x182B47BE0", Slot = "78")]
		public void PDDALBPHINP(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B46580", Offset = "0x2B44F80", VA = "0x182B46580", Slot = "79")]
		public void HOPOKGLJMFO(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B46220", Offset = "0x2B44C20", VA = "0x182B46220", Slot = "80")]
		public bool GOLOOKPJCBN(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B44E30", Offset = "0x2B43830", VA = "0x182B44E30", Slot = "24")]
		public void BOGLFGOCNEB(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B47700", Offset = "0x2B46100", VA = "0x182B47700", Slot = "25")]
		public void MLKFOKMBAIJ(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x39E1350", Offset = "0x39DFD50", VA = "0x1839E1350")]
		private void CIJNLCELIGO<T>(MBEDCJLMHEO LKHNLAILFFL, bool LPJDDLMPNCG) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x39E1D20", Offset = "0x39E0720", VA = "0x1839E1D20")]
		private bool ODLOGLIACAA<T>(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x39E18F0", Offset = "0x39E02F0", VA = "0x1839E18F0")]
		private void FJEBMLODAAK<T>(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x39E1AF0", Offset = "0x39E04F0", VA = "0x1839E1AF0")]
		private bool KNFMPDHAKHF<TC, TV>(MBEDCJLMHEO LKHNLAILFFL, Func<TC, TV> MJJFBDCGCEG, out TV LPJDDLMPNCG) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x39E1A70", Offset = "0x39E0470", VA = "0x1839E1A70")]
		private bool KNFMPDHAKHF<T>(MBEDCJLMHEO LKHNLAILFFL, out T LPJDDLMPNCG) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x39E1D80", Offset = "0x39E0780", VA = "0x1839E1D80")]
		private T OPFGHFGPOHB<T>(MBEDCJLMHEO LKHNLAILFFL) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x39E13A0", Offset = "0x39DFDA0", VA = "0x1839E13A0")]
		private void DOJCFHAFHEH<T>(MBEDCJLMHEO LKHNLAILFFL, T LPJDDLMPNCG) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x39E0CF0", Offset = "0x39DF6F0", VA = "0x1839E0CF0")]
		private void AEFMCMBFLEO<T>(MBEDCJLMHEO LKHNLAILFFL, T LPJDDLMPNCG) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x39E1A70", Offset = "0x39E0470", VA = "0x1839E1A70")]
		private bool HGIAEFPBKHD<T>(MBEDCJLMHEO LKHNLAILFFL, out T LPJDDLMPNCG) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x39E1950", Offset = "0x39E0350", VA = "0x1839E1950")]
		private T FOHGHHOIINM<T>(MBEDCJLMHEO LKHNLAILFFL) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x39E1A70", Offset = "0x39E0470", VA = "0x1839E1A70")]
		private void LFPDPHNGMGG<T>(MBEDCJLMHEO LKHNLAILFFL, T LPJDDLMPNCG) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x39E1C70", Offset = "0x39E0670", VA = "0x1839E1C70")]
		private void NKOECMNAHED<T>(MBEDCJLMHEO LKHNLAILFFL, T LPJDDLMPNCG) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B46ED0", Offset = "0x2B458D0", VA = "0x182B46ED0")]
		private MBEDCJLMHEO KONFHNOEBBE(Entity LCLDFKAJPDK)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B45470", Offset = "0x2B43E70", VA = "0x182B45470")]
		private DynamicBuffer<Entity> EAAPNLKKNIM(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x39E19B0", Offset = "0x39E03B0", VA = "0x1839E19B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
			[DebuggerHidden]
			public OKPJGCBJBDI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x4520800", Offset = "0x451F200", VA = "0x184520800", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x45204C0", Offset = "0x451EEC0", VA = "0x1845204C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x4520880", Offset = "0x451F280", VA = "0x184520880")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x45207C0", Offset = "0x451F1C0", VA = "0x1845207C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x4520710", Offset = "0x451F110", VA = "0x184520710", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KDBGLABEDCA> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x4520710", Offset = "0x451F110", VA = "0x184520710", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x30278F0", Offset = "0x30262F0", VA = "0x1830278F0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x3027940", Offset = "0x3026340", VA = "0x183027940")]
		public void JCNPEJMIGKN(NativeArray<Entity> ABBIPALBHCK, bool MGBDBJDLAFG, bool FPFOJOEOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x3027500", Offset = "0x3025F00", VA = "0x183027500")]
		public void ALLCGBCGAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x3027A60", Offset = "0x3026460", VA = "0x183027A60")]
		private void LFGHFGFKNPM(NativeArray<Entity> ABBIPALBHCK, bool MGBDBJDLAFG, bool FPFOJOEOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x3027710", Offset = "0x3026110", VA = "0x183027710")]
		[IteratorStateMachine(typeof(OKPJGCBJBDI))]
		private IEnumerable<KDBGLABEDCA> APKNAMIOHAO(NativeArray<Entity> ABBIPALBHCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x30277A0", Offset = "0x30261A0", VA = "0x1830277A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x3028270", Offset = "0x3026C70", VA = "0x183028270")]
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
		[Cpp2IlInjected.Address(RVA = "0x3204420", Offset = "0x3202E20", VA = "0x183204420", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public ANIKAMAEHJJ JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x3203F80", Offset = "0x3202980", VA = "0x183203F80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public ANIKAMAEHJJ JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x3203F80", Offset = "0x3202980", VA = "0x183203F80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x3203FA0", Offset = "0x32029A0", VA = "0x183203FA0", Slot = "11")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x32040D0", Offset = "0x3202AD0", VA = "0x1832040D0", Slot = "12")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "13")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3203BD0", Offset = "0x32025D0", VA = "0x183203BD0")]
	private void ANPBMIHAFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x26399B0", Offset = "0x26383B0", VA = "0x1826399B0")]
	private string NPDEJCBEAOF(string AMNLGEBHFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x3203FF0", Offset = "0x32029F0", VA = "0x183203FF0", Slot = "7")]
	public ANIKAMAEHJJ EEFKBJFGHAC(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x3204170", Offset = "0x3202B70", VA = "0x183204170")]
	private bool HHMJMOMICKB(Type HCAPMBLBEEA, string AMNLGEBHFHK, out ANIKAMAEHJJ HDLEMAAGOPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x3203E70", Offset = "0x3202870", VA = "0x183203E70", Slot = "8")]
	public AHKPLOLMABO DCNFHPDCNKA(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return default(AHKPLOLMABO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3204150", Offset = "0x3202B50", VA = "0x183204150", Slot = "9")]
	public IEnumerator<ANIKAMAEHJJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x3204150", Offset = "0x3202B50", VA = "0x183204150", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x3204440", Offset = "0x3202E40", VA = "0x183204440")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B25AA0", Offset = "0x2B244A0", VA = "0x182B25AA0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B25B00", Offset = "0x2B24500", VA = "0x182B25B00", Slot = "6")]
	public bool FDPNENBLNBJ(AHKPLOLMABO PKNOIGMENLD, out int GBNBGNMHGLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2B25B70", Offset = "0x2B24570", VA = "0x182B25B70", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2B25BD0", Offset = "0x2B245D0", VA = "0x182B25BD0", Slot = "5")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2B25830", Offset = "0x2B24230", VA = "0x182B25830")]
	private void AKMMJMPOPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2B25BE0", Offset = "0x2B245E0", VA = "0x182B25BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3210520", Offset = "0x320EF20", VA = "0x183210520", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public LEDNIENHLNM JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x320FE20", Offset = "0x320E820", VA = "0x18320FE20", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LEDNIENHLNM JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x320FE20", Offset = "0x320E820", VA = "0x18320FE20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "10")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x32101A0", Offset = "0x320EBA0", VA = "0x1832101A0", Slot = "11")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "12")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x3210070", Offset = "0x320EA70", VA = "0x183210070", Slot = "6")]
	public LEDNIENHLNM EEFKBJFGHAC(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x320FE60", Offset = "0x320E860", VA = "0x18320FE60", Slot = "7")]
	public AHKPLOLMABO DCNFHPDCNKA(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return default(AHKPLOLMABO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x3210440", Offset = "0x320EE40", VA = "0x183210440", Slot = "8")]
	public IEnumerator<LEDNIENHLNM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x3210530", Offset = "0x320EF30", VA = "0x183210530", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x28A03A0", Offset = "0x289EDA0", VA = "0x1828A03A0", Slot = "13")]
	public void BHJDIJLHOEC<TKey, T>(global::CCCEMKOEGOF<TKey, T> GJEJKJANAJD, [Optional] object PKDAKJPDDGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x320FF30", Offset = "0x320E930", VA = "0x18320FF30", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public DAFHHABAFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x320FE20", Offset = "0x320E820", VA = "0x18320FE20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2B9A0", Offset = "0x2B2A3A0", VA = "0x182B2B9A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PPBNAGHDKKA JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B4A0", Offset = "0x2B29EA0", VA = "0x182B2B4A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public PPBNAGHDKKA JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B4A0", Offset = "0x2B29EA0", VA = "0x182B2B4A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B740", Offset = "0x2B2A140", VA = "0x182B2B740", Slot = "9")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B9F0", Offset = "0x2B2A3F0", VA = "0x182B2B9F0", Slot = "10")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B8C0", Offset = "0x2B2A2C0", VA = "0x182B2B8C0")]
	private PPBNAGHDKKA HGOGJDFNLCL(int EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B620", Offset = "0x2B2A020", VA = "0x182B2B620", Slot = "6")]
	public PPBNAGHDKKA EEFKBJFGHAC(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B4B0", Offset = "0x2B29EB0", VA = "0x182B2B4B0", Slot = "14")]
	public AHKPLOLMABO DCNFHPDCNKA(DDIEEGNDNAH IHNHAGGGBIH)
	{
		return default(AHKPLOLMABO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B7B0", Offset = "0x2B2A1B0", VA = "0x182B2B7B0", Slot = "7")]
	public IEnumerator<PPBNAGHDKKA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B7B0", Offset = "0x2B2A1B0", VA = "0x182B2B7B0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x327F370", Offset = "0x327DD70", VA = "0x18327F370", Slot = "11")]
	public void BHJDIJLHOEC<TKey, T>(global::CCCEMKOEGOF<TKey, T> GJEJKJANAJD, [Optional] object PKDAKJPDDGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B580", Offset = "0x2B29F80", VA = "0x182B2B580", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public OBNEHJAFPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B4A0", Offset = "0x2B29EA0", VA = "0x182B2B4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x731A20", Offset = "0x730420", VA = "0x180731A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x31FE730", Offset = "0x31FD130", VA = "0x1831FE730", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x31FE640", Offset = "0x31FD040", VA = "0x1831FE640")]
	private void CGBIJPLIGIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x1F78410", Offset = "0x1F76E10", VA = "0x181F78410")]
	public T FHKHGMAFILK<T>() where T : HOOPFMCFMDE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x31FE860", Offset = "0x31FD260", VA = "0x1831FE860")]
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
	[Cpp2IlInjected.Address(RVA = "0x31FE4A0", Offset = "0x31FCEA0", VA = "0x1831FE4A0")]
	public PPBNAGHDKKA BNIPHJEGIHL(DDIEEGNDNAH AMNLGEBHFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x1F78390", Offset = "0x1F76D90", VA = "0x181F78390")]
	public global::JHEEGHNCDEJ<T> BNIPHJEGIHL<T>(DDIEEGNDNAH AMNLGEBHFHK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x31FE570", Offset = "0x31FCF70", VA = "0x1831FE570")]
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
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public BLMENLBLGJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class ANMOJHOMNKG
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x10F8790", Offset = "0x10F7190", VA = "0x1810F8790")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B3BE20", Offset = "0x2B3A820", VA = "0x182B3BE20", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x2B3C0B0", Offset = "0x2B3AAB0", VA = "0x182B3C0B0")]
	public void KNBIFBCEKPM(KHMECMDAALD HBKLDKCICEJ, bool GGAFPKHNBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
		[DebuggerHidden]
		public MKGNHNLIIOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x451E000", Offset = "0x451CA00", VA = "0x18451E000", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x451DC50", Offset = "0x451C650", VA = "0x18451DC50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x451E080", Offset = "0x451CA80", VA = "0x18451E080")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x451DFC0", Offset = "0x451C9C0", VA = "0x18451DFC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x451DF30", Offset = "0x451C930", VA = "0x18451DF30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x451DF30", Offset = "0x451C930", VA = "0x18451DF30", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B27C10", Offset = "0x2B26610", VA = "0x182B27C10", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2B27DE0", Offset = "0x2B267E0", VA = "0x182B27DE0", Slot = "5")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2B272D0", Offset = "0x2B25CD0", VA = "0x182B272D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2B26C60", Offset = "0x2B25660", VA = "0x182B26C60")]
	private void AIKOEPHPLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2B26C70", Offset = "0x2B25670", VA = "0x182B26C70")]
	internal void BECPPEGJCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2B275B0", Offset = "0x2B25FB0", VA = "0x182B275B0")]
	private void ELMHAANGAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2B27CE0", Offset = "0x2B266E0", VA = "0x182B27CE0")]
	private void JJLCFMEFDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2B26C10", Offset = "0x2B25610", VA = "0x182B26C10")]
	[IteratorStateMachine(typeof(MKGNHNLIIOO))]
	private IEnumerable<RRCustomPropTag> AFEHFMEHMJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2B27790", Offset = "0x2B26190", VA = "0x182B27790")]
	private void FAOEEKNFHOB(MBEDCJLMHEO LKHNLAILFFL, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2B27470", Offset = "0x2B25E70", VA = "0x182B27470")]
	private void EHOMCGHPBHE(SerializableGuid NPIFLODGAHD, GameObject DLNMCGFEPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2B28010", Offset = "0x2B26A10", VA = "0x182B28010")]
	private void OALNCCFGGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2B270F0", Offset = "0x2B25AF0", VA = "0x182B270F0")]
	private bool DNKPHOIPEBM(OMJADPLKEJB BDMMNPPMGDN, Transform GGEKFPEBLKN, out GameObject MLLKBCFLFJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2B270A0", Offset = "0x2B25AA0", VA = "0x182B270A0")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2B283A0", Offset = "0x2B26DA0", VA = "0x182B283A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x731A00", Offset = "0x730400", VA = "0x180731A00")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2B44B50", Offset = "0x2B43550", VA = "0x182B44B50")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
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
	[Cpp2IlInjected.Address(RVA = "0x30213D0", Offset = "0x301FDD0", VA = "0x1830213D0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x31F8980", Offset = "0x31F7380", VA = "0x1831F8980", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x31F8940", Offset = "0x31F7340", VA = "0x1831F8940", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x31F8920", Offset = "0x31F7320", VA = "0x1831F8920")]
	private void CNMMEOHJGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x31F89F0", Offset = "0x31F73F0", VA = "0x1831F89F0")]
	private void LKCJPMHFGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x3024AA0", Offset = "0x30234A0", VA = "0x183024AA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public MBEDCJLMHEO KHIHMEEEPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x3024820", Offset = "0x3023220", VA = "0x183024820", Slot = "9")]
		get
		{
			return default(MBEDCJLMHEO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x3024020", Offset = "0x3022A20", VA = "0x183024020", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public EMFDOJECCDF EIFDGFOLJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x30248B0", Offset = "0x30232B0", VA = "0x1830248B0", Slot = "11")]
		get
		{
			return default(EMFDOJECCDF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x3024020", Offset = "0x3022A20", VA = "0x183024020", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public EMFDOJECCDF LCMNPPIFGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x3024860", Offset = "0x3023260", VA = "0x183024860", Slot = "13")]
		get
		{
			return default(EMFDOJECCDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint MNHOECAAJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x3024600", Offset = "0x3023000", VA = "0x183024600")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ICMCAGOGJBG CCCAANGKKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x3024AE0", Offset = "0x30234E0", VA = "0x183024AE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x30246B0", Offset = "0x30230B0", VA = "0x1830246B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x3024750", Offset = "0x3023150", VA = "0x183024750", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x3024900", Offset = "0x3023300", VA = "0x183024900", Slot = "5")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x3024450", Offset = "0x3022E50", VA = "0x183024450", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x3024250", Offset = "0x3022C50", VA = "0x183024250")]
	private void DHGJMJCNJCH(Entity LCLDFKAJPDK, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI DKOFAPECACL, HAMGOKKMMPI JFNADPGFOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x3023DB0", Offset = "0x30227B0", VA = "0x183023DB0", Slot = "14")]
	public MBEDCJLMHEO AFNHNOEFCOI(MBEDCJLMHEO AGDKLNJDAPF, MBEDCJLMHEO NMPDJFDFMIN)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x3024500", Offset = "0x3022F00", VA = "0x183024500", Slot = "15")]
	public bool EDCKHKPPKHK(MBEDCJLMHEO AGDKLNJDAPF, MBEDCJLMHEO NMPDJFDFMIN, out MBEDCJLMHEO NFENBCEFMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x30240C0", Offset = "0x3022AC0", VA = "0x1830240C0", Slot = "16")]
	public void CDINMBMKCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x3024B80", Offset = "0x3023580", VA = "0x183024B80", Slot = "17")]
	public void OAHBFJKDMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x3023EC0", Offset = "0x30228C0", VA = "0x183023EC0", Slot = "18")]
	public bool BLOJEJKHCIB(MBEDCJLMHEO ELODBNLDLIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x3024020", Offset = "0x3022A20", VA = "0x183024020")]
	private void BOBMPNALDEI(MBEDCJLMHEO BPCHIIFCMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x3014CE0", Offset = "0x30136E0", VA = "0x183014CE0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x3014D60", Offset = "0x3013760", VA = "0x183014D60", Slot = "5")]
	public void JDEEJAHJMPF(MBEDCJLMHEO LMLBLIDPKCN, bool LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x36BED70", Offset = "0x36BD770", VA = "0x1836BED70")]
	private void EFMALMFMJGL<T>(MBEDCJLMHEO LMLBLIDPKCN, bool LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D80480", Offset = "0x2D7EE80", VA = "0x182D80480", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x2D80500", Offset = "0x2D7EF00", VA = "0x182D80500", Slot = "5")]
		public void JLHHKLACIFH(MBEDCJLMHEO LMLBLIDPKCN, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2D80570", Offset = "0x2D7EF70", VA = "0x182D80570", Slot = "6")]
		public void KMKKOPLGPDG(MBEDCJLMHEO LMLBLIDPKCN, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x36BED70", Offset = "0x36BD770", VA = "0x1836BED70")]
		private void EFMALMFMJGL<T>(MBEDCJLMHEO LMLBLIDPKCN, bool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B25CC0", Offset = "0x2B246C0", VA = "0x182B25CC0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0xC21560", Offset = "0xC1FF60", VA = "0x180C21560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2D94960", Offset = "0x2D93360", VA = "0x182D94960", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME HKIDKBKDNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2D94930", Offset = "0x2D93330", VA = "0x182D94930", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2D95190", Offset = "0x2D93B90", VA = "0x182D95190", Slot = "6")]
		public bool OKDEPPDEPBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2D94B50", Offset = "0x2D93550", VA = "0x182D94B50", Slot = "7")]
		public bool ICNIONFFCDE(IEnumerable<BMLJODFLIKN> JGGHOCFLFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2D952F0", Offset = "0x2D93CF0", VA = "0x182D952F0", Slot = "5")]
		public ByteString PEEAKNCHPCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2D94B70", Offset = "0x2D93570", VA = "0x182D94B70")]
		private void IILCPJJLOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2D94BE0", Offset = "0x2D935E0", VA = "0x182D94BE0")]
		private void KJGLKDBOJJL(MANAEOMEHPG FIANHALABNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2D94CB0", Offset = "0x2D936B0", VA = "0x182D94CB0")]
		private void LCABLNOIOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2D94650", Offset = "0x2D93050", VA = "0x182D94650")]
		private void AEOLEJBOPLN(JPHKJJNABPK FIANHALABNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2D94B90", Offset = "0x2D93590", VA = "0x182D94B90", Slot = "8")]
		public void JPJDNINPFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2D94AB0", Offset = "0x2D934B0", VA = "0x182D94AB0")]
		private MANAEOMEHPG HFEDJIELLHD(EntityManager MENKGFBPIJM, EntityManager DLKHAOHFHOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x31F91D0", Offset = "0x31F7BD0", VA = "0x1831F91D0")]
	public GameObject JBOLOPOLCHP(LFEIHDPDPKH OINKDHOAIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x31F92A0", Offset = "0x31F7CA0", VA = "0x1831F92A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D87F20", Offset = "0x2D86920", VA = "0x182D87F20")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x2D87E50", Offset = "0x2D86850", VA = "0x182D87E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool FODPFPNFNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x72B260", Offset = "0x729C60", VA = "0x18072B260")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x74CAD0", Offset = "0x74B4D0", VA = "0x18074CAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7D10", Offset = "0x1DF6710", VA = "0x181DF7D10", Slot = "4")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2D87ED0", Offset = "0x2D868D0", VA = "0x182D87ED0", Slot = "5")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2D87D90", Offset = "0x2D86790", VA = "0x182D87D90")]
		public void EAJAFFCLIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D83FB0", Offset = "0x2D829B0", VA = "0x182D83FB0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2D84160", Offset = "0x2D82B60", VA = "0x182D84160", Slot = "5")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2D83F10", Offset = "0x2D82910", VA = "0x182D83F10", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2D84020", Offset = "0x2D82A20", VA = "0x182D84020")]
		private void LIFHLNGOOHF(Entity LCLDFKAJPDK, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x300AB30", Offset = "0x3009530", VA = "0x18300AB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private FJLFIPEFALG OLEEICMKEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x300AAE0", Offset = "0x30094E0", VA = "0x18300AAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x300AA60", Offset = "0x3009460", VA = "0x18300AA60", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x300AA40", Offset = "0x3009440", VA = "0x18300AA40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NLCELAKFEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x2D7CD10", Offset = "0x2D7B710", VA = "0x182D7CD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DLLFCFKOHFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x2D797F0", Offset = "0x2D781F0", VA = "0x182D797F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x94E3C0", Offset = "0x94CDC0", VA = "0x18094E3C0", Slot = "4")]
		get
		{
			return default(HNJBILHOIMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private MKDEFAJNDJH LJDGEIMOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x3203760", Offset = "0x3202160", VA = "0x183203760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x3203710", Offset = "0x3202110", VA = "0x183203710", Slot = "5")]
	public void AHPFPMIFNAG(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x32037B0", Offset = "0x32021B0", VA = "0x1832037B0", Slot = "6")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x3203A10", Offset = "0x3202410", VA = "0x183203A10", Slot = "7")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x3203AF0", Offset = "0x32024F0", VA = "0x183203AF0", Slot = "8")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x32038E0", Offset = "0x32022E0", VA = "0x1832038E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x1F8BCD0", Offset = "0x1F8A6D0", VA = "0x181F8BCD0")]
	private void DKLEEIMJLHM<T>(Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x38F7070", Offset = "0x38F5A70", VA = "0x1838F7070", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x38F70D0", Offset = "0x38F5AD0", VA = "0x1838F70D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x38F7040", Offset = "0x38F5A40", VA = "0x1838F7040", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x800A50", VA = "0x180802050", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE50", Offset = "0x7C9850", VA = "0x1807CAE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x33344D0", Offset = "0x3332ED0", VA = "0x1833344D0")]
	public KKKPEFJDDAI(Func<From, To> FHJNDBAFJCD, Func<To, From> JJKFOPGJCGG, bool GLNNHMBNJIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x38F6C00", Offset = "0x38F5600", VA = "0x1838F6C00", Slot = "11")]
	public void Add(To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x38F6C60", Offset = "0x38F5660", VA = "0x1838F6C60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x38F6C90", Offset = "0x38F5690", VA = "0x1838F6C90", Slot = "13")]
	public bool Contains(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x38F6CF0", Offset = "0x38F56F0", VA = "0x1838F6CF0", Slot = "14")]
	public void CopyTo(To[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x38F6E00", Offset = "0x38F5800", VA = "0x1838F6E00", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x38F6ED0", Offset = "0x38F58D0", VA = "0x1838F6ED0", Slot = "6")]
	public int IndexOf(To JPOBIIKLHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x38F6F30", Offset = "0x38F5930", VA = "0x1838F6F30", Slot = "7")]
	public void Insert(int EGNHJGKABLC, To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x38F6FE0", Offset = "0x38F59E0", VA = "0x1838F6FE0", Slot = "15")]
	public bool Remove(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x38F6FB0", Offset = "0x38F59B0", VA = "0x1838F6FB0", Slot = "8")]
	public void RemoveAt(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x298F140", Offset = "0x298DB40", VA = "0x18298F140", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x416AA40", Offset = "0x4169440", VA = "0x18416AA40", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x416AA90", Offset = "0x4169490", VA = "0x18416AA90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x416AA00", Offset = "0x4169400", VA = "0x18416AA00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2642100", Offset = "0x2640B00", VA = "0x182642100")]
	public LPHOIOIKFHI(Func<From, To> FHJNDBAFJCD, Func<To, From> JJKFOPGJCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x416A610", Offset = "0x4169010", VA = "0x18416A610", Slot = "11")]
	public void Add(To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x416A650", Offset = "0x4169050", VA = "0x18416A650", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x416A690", Offset = "0x4169090", VA = "0x18416A690", Slot = "13")]
	public bool Contains(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x416A750", Offset = "0x4169150", VA = "0x18416A750", Slot = "14")]
	public void CopyTo(To[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x416A810", Offset = "0x4169210", VA = "0x18416A810", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x416A8D0", Offset = "0x41692D0", VA = "0x18416A8D0", Slot = "6")]
	public int IndexOf(To JPOBIIKLHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x416A940", Offset = "0x4169340", VA = "0x18416A940", Slot = "7")]
	public void Insert(int EGNHJGKABLC, To JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x416A9C0", Offset = "0x41693C0", VA = "0x18416A9C0", Slot = "15")]
	public bool Remove(To JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x416A980", Offset = "0x4169380", VA = "0x18416A980", Slot = "8")]
	public void RemoveAt(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x2307500", Offset = "0x2305F00", VA = "0x182307500", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ALLAKMMAOIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x4518230", Offset = "0x4516C30", VA = "0x184518230")]
		internal void <InitServices>b__1(GBCNOEIKEOL svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x4518290", Offset = "0x4516C90", VA = "0x184518290")]
		internal void <InitServices>b__2(IJGJDJPFIAJ svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x3215FF0", Offset = "0x32149F0", VA = "0x183215FF0")]
	public static void PCLKGJBKNNM(this MKDEFAJNDJH ACFGKGFDFPL, FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A710", Offset = "0x1D79110", VA = "0x181D7A710")]
	public static void DKLEEIMJLHM<T>(this MKDEFAJNDJH ACFGKGFDFPL, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x1D7AB60", Offset = "0x1D79560", VA = "0x181D7AB60")]
	public static void LDGHCFFPNLF<T>(this MKDEFAJNDJH ACFGKGFDFPL, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x1D7AEB0", Offset = "0x1D798B0", VA = "0x181D7AEB0")]
	public static void OCPFIMEBHGJ<T>(this MKDEFAJNDJH ACFGKGFDFPL, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x1D7AD00", Offset = "0x1D79700", VA = "0x181D7AD00")]
	public static void MJBBHNFIDIE<T>(this MKDEFAJNDJH ACFGKGFDFPL, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A780", Offset = "0x1D79180", VA = "0x181D7A780")]
	public static void IHPACNHNKEG<T>(this MKDEFAJNDJH ACFGKGFDFPL, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A9F0", Offset = "0x1D793F0", VA = "0x181D7A9F0")]
	public static void LDGHCFFPNLF<T>(IEnumerable<ComponentSystemBase> DFKHIBLIHPO, Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A930", Offset = "0x1D79330", VA = "0x181D7A930")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B25DA0", Offset = "0x2B247A0", VA = "0x182B25DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MMABKGNGAFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x31FB050", Offset = "0x31F9A50", VA = "0x1831FB050")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D83090", Offset = "0x2D81A90", VA = "0x182D83090")]
		public static void MNNDBLCHNEL(this HJOJGGNKDFB JGMMDACFJLC, HKCMLMJLMKG CAAHBOFLBKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D82CE0", Offset = "0x2D816E0", VA = "0x182D82CE0")]
		public static void DJHEHHELFNE(this HJOJGGNKDFB JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D832C0", Offset = "0x2D81CC0", VA = "0x182D832C0")]
		public static void MNNDBLCHNEL(this HJOJGGNKDFB JGMMDACFJLC, [Optional] string[] FGNJBPFPMMH, [Optional] string[] JMEMMLMPMKE, [Optional] string[] IIPEDEHICDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2D833D0", Offset = "0x2D81DD0", VA = "0x182D833D0")]
		public static void OEIKFPMDIHL(this HJOJGGNKDFB JGMMDACFJLC, params string[] AFFPJFFGLAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2D82FE0", Offset = "0x2D819E0", VA = "0x182D82FE0")]
		public static void KNKJLJCLAMC(this HJOJGGNKDFB JGMMDACFJLC, params string[] AFFPJFFGLAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D82DE0", Offset = "0x2D817E0", VA = "0x182D82DE0")]
		private static string[] KHPPMKMMLDE(HKCMLMJLMKG CAAHBOFLBKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2D83480", Offset = "0x2D81E80", VA = "0x182D83480")]
		private static bool PFJPMDKFGKO(HKCMLMJLMKG CAAHBOFLBKP, out string[] AEFFIHCGMFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B28690", Offset = "0x2B27090", VA = "0x182B28690")]
	public MIFCJABFCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action EKKOICMAFIL();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x2B284A0", Offset = "0x2B26EA0", VA = "0x182B284A0")]
	public MethodInfo EBGNNKPPDEL(Action DAAMKALKLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x2B284E0", Offset = "0x2B26EE0", VA = "0x182B284E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3027340", Offset = "0x3025D40", VA = "0x183027340", Slot = "5")]
	public override Action EKKOICMAFIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void GONJADLODAI<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x30273D0", Offset = "0x3025DD0", VA = "0x1830273D0")]
	[Preserve]
	public void OLFPMMGLCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x3019ED0", Offset = "0x30188D0", VA = "0x183019ED0")]
	protected KKMMBOAGKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class ILLNANCIIHL : MIFCJABFCAI
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x301DE60", Offset = "0x301C860", VA = "0x18301DE60", Slot = "5")]
	public override Action EKKOICMAFIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void BLDMFMKOAGE<T>() where T : HLLCIEEAKDG;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x301DEF0", Offset = "0x301C8F0", VA = "0x18301DEF0")]
	[Preserve]
	public void OLFPMMGLCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x3019ED0", Offset = "0x30188D0", VA = "0x183019ED0")]
	protected ILLNANCIIHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class IDIFLMJNOJP : MIFCJABFCAI
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x3019DB0", Offset = "0x30187B0", VA = "0x183019DB0", Slot = "5")]
	public override Action EKKOICMAFIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void IPNDLBGHJJA<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x3019E40", Offset = "0x3018840", VA = "0x183019E40")]
	[Preserve]
	public void OLFPMMGLCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x3019ED0", Offset = "0x30188D0", VA = "0x183019ED0")]
	protected IDIFLMJNOJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class KEGPFJEJOHN
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x3025580", Offset = "0x3023F80", VA = "0x183025580")]
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
				[Cpp2IlInjected.Address(RVA = "0x2295790", Offset = "0x2294190", VA = "0x182295790", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x451AD60", Offset = "0x4519760", VA = "0x18451AD60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x4517380", Offset = "0x4515D80", VA = "0x184517380")]
			[DebuggerHidden]
			public HJAIMDHOKKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x451AB90", Offset = "0x4519590", VA = "0x18451AB90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x451AD20", Offset = "0x4519720", VA = "0x18451AD20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x451AC70", Offset = "0x4519670", VA = "0x18451AC70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x451AC70", Offset = "0x4519670", VA = "0x18451AC70", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x2295790", Offset = "0x2294190", VA = "0x182295790", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4517250", Offset = "0x4515C50", VA = "0x184517250", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x4517380", Offset = "0x4515D80", VA = "0x184517380")]
			[DebuggerHidden]
			public ADFMFLJNPFP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x45172A0", Offset = "0x4515CA0", VA = "0x1845172A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x4516F70", Offset = "0x4515970", VA = "0x184516F70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x4517330", Offset = "0x4515D30", VA = "0x184517330")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x4517210", Offset = "0x4515C10", VA = "0x184517210", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x4517160", Offset = "0x4515B60", VA = "0x184517160", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x4517160", Offset = "0x4515B60", VA = "0x184517160", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x2295790", Offset = "0x2294190", VA = "0x182295790", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4519B70", Offset = "0x4518570", VA = "0x184519B70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x4517380", Offset = "0x4515D80", VA = "0x184517380")]
			[DebuggerHidden]
			public FLPDOIGIIML(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x4519BC0", Offset = "0x45185C0", VA = "0x184519BC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x4519760", Offset = "0x4518160", VA = "0x184519760", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x4519C90", Offset = "0x4518690", VA = "0x184519C90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x4519CE0", Offset = "0x45186E0", VA = "0x184519CE0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x4519B30", Offset = "0x4518530", VA = "0x184519B30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x4519A90", Offset = "0x4518490", VA = "0x184519A90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x4519A90", Offset = "0x4518490", VA = "0x184519A90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x300DCC0", Offset = "0x300C6C0", VA = "0x18300DCC0")]
		public static Entity IJHIFONNBOI(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x300E6B0", Offset = "0x300D0B0", VA = "0x18300E6B0")]
		public static DynamicBuffer<ChildrenData> OEDLEMFHJKD(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x300D080", Offset = "0x300BA80", VA = "0x18300D080")]
		public static DynamicBuffer<ChildrenData> ANBALFNDFEP(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x300DA60", Offset = "0x300C460", VA = "0x18300DA60")]
		public static NativeArray<Entity> HGCEPDCEEAC(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Allocator FKHAEPDPDAI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x300E320", Offset = "0x300CD20", VA = "0x18300E320")]
		public static bool KKCLHCMAHPD(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Allocator FKHAEPDPDAI, out NativeArray<Entity> JFBBGIJLDJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x300D110", Offset = "0x300BB10", VA = "0x18300D110")]
		public static NativeArray<Entity> BMPHHKPCLFL(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x300CEA0", Offset = "0x300B8A0", VA = "0x18300CEA0")]
		public static Entity AFFCJINMNLA(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, int EGNHJGKABLC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x300D950", Offset = "0x300C350", VA = "0x18300D950")]
		public static int FOLBFCNBPGG(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x300E0C0", Offset = "0x300CAC0", VA = "0x18300E0C0")]
		public static void KCFMHGFOPJA(NativeArray<Entity> EOPPFFEOLEM, NativeArray<Entity> BOGHIFKGACA, EntityManager MABCFMECCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x300CFD0", Offset = "0x300B9D0", VA = "0x18300CFD0")]
		public static int AJILHEJIKOP(this EntityManager MABCFMECCKD, Entity GGEKFPEBLKN, Entity ILLPMKANGKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x300D7F0", Offset = "0x300C1F0", VA = "0x18300D7F0")]
		public static bool FFKLPDDAEHN(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Entity NLBEDCCLIFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x300D480", Offset = "0x300BE80", VA = "0x18300D480")]
		public static IEnumerable<Entity> CMGIHGILOAF(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x300DB90", Offset = "0x300C590", VA = "0x18300DB90")]
		public static bool HMKPBKJMFKD(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Entity ILLPMKANGKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x300E420", Offset = "0x300CE20", VA = "0x18300E420")]
		public static bool NBCMHKFAKCC(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Entity AGDKLNJDAPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x300DD30", Offset = "0x300C730", VA = "0x18300DD30")]
		public static NativeList<Entity> JCKMNEBEMBO(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, bool PNGNAFIFALL = false, Allocator FKHAEPDPDAI = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x300D270", Offset = "0x300BC70", VA = "0x18300D270")]
		public static IEnumerable<Entity> CEAEBLDPEEN(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x300E5B0", Offset = "0x300CFB0", VA = "0x18300E5B0")]
		public static Entity NKAKDLGIEDI(this EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x300D590", Offset = "0x300BF90", VA = "0x18300D590")]
		public static bool EDCKHKPPKHK(this EntityManager MABCFMECCKD, Entity AGDKLNJDAPF, Entity NMPDJFDFMIN, out Entity NFENBCEFMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x300E040", Offset = "0x300CA40", VA = "0x18300E040")]
		internal static void JKKBLJHDAPI(EntityManager MABCFMECCKD, Entity GGEKFPEBLKN, Entity ILLPMKANGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x300DF40", Offset = "0x300C940", VA = "0x18300DF40")]
		internal static void JHCKGPFNFMN(EntityManager MABCFMECCKD, Entity GGEKFPEBLKN, Entity ILLPMKANGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x300D3F0", Offset = "0x300BDF0", VA = "0x18300D3F0")]
		[IteratorStateMachine(typeof(HJAIMDHOKKF))]
		private static IEnumerable<Entity> CIHMFIOEHIE(EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x300E740", Offset = "0x300D140", VA = "0x18300E740")]
		[IteratorStateMachine(typeof(ADFMFLJNPFP))]
		private static IEnumerable<Entity> OMDGDKOFGEA(EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x300DC40", Offset = "0x300C640", VA = "0x18300DC40")]
		[IteratorStateMachine(typeof(FLPDOIGIIML))]
		private static IEnumerable<Entity> HOECHHIKJAL(EntityManager MABCFMECCKD, Entity LCLDFKAJPDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x300E7D0", Offset = "0x300D1D0", VA = "0x18300E7D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public BFHOGDONKCB CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public BHHDNNCMGLM LJDGEIMOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public FDCCILJEAIN GOLAHAFEIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public OJMGIHLPABJ BJCANCIPCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public DDOLHFHMLOP DIPPIPKFCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public CLIHAPFPPDO EHJMHIENHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76F9F0", VA = "0x180770FF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public AMBNPJKGCOF EFDNLJHDPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x7270F0", Offset = "0x725AF0", VA = "0x1807270F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public HNIIKODBKKD GPIPEIHLBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7270A0", Offset = "0x725AA0", VA = "0x1807270A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public MMCKNDDCKHO MLIMCCODDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x7270D0", Offset = "0x725AD0", VA = "0x1807270D0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public ILADIFIOBIK BDOBIEBIADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7270B0", Offset = "0x725AB0", VA = "0x1807270B0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public LOEKKAPPCFD OKFLBOELOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7270C0", Offset = "0x725AC0", VA = "0x1807270C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public OONCEOFLMII NHHIFAJBKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x727040", Offset = "0x725A40", VA = "0x180727040", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public NDFDMPICGAG CIJDLCNILKP
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x727050", Offset = "0x725A50", VA = "0x180727050", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public OECKLJAFLCL PKCMHFFGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x74D1A0", Offset = "0x74BBA0", VA = "0x18074D1A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public LJHBPFAFOIK BOJCKHHDBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x82D960", Offset = "0x82C360", VA = "0x18082D960", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public DECKIFJOPPL OOJOBGNBJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC720", Offset = "0x7EB120", VA = "0x1807EC720", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public OJOLPKHEEIB HLMHOICHEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x74D170", Offset = "0x74BB70", VA = "0x18074D170", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public GCEEGFGLLJD BPEFMKPADKP
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x727060", Offset = "0x725A60", VA = "0x180727060", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public FDHGKOHMFEH HOLIGPGDLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x727070", Offset = "0x725A70", VA = "0x180727070", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public ABGDBOLFPHD OFCGPOGBJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x727090", Offset = "0x725A90", VA = "0x180727090", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public HNJBILHOIMC DMGKCMGPDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x7374E0", Offset = "0x735EE0", VA = "0x1807374E0", Slot = "21")]
		get
		{
			return default(HNJBILHOIMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x31FCAF0", Offset = "0x31FB4F0", VA = "0x1831FCAF0", Slot = "22")]
	public void AHPFPMIFNAG(FJEOEPCCLME HKIDKBKDNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x1F58670", Offset = "0x1F57070", VA = "0x181F58670", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x31FCDE0", Offset = "0x31FB7E0", VA = "0x1831FCDE0", Slot = "23")]
	public void CCCAANGKKJB(FJEOEPCCLME HKIDKBKDNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x7270E0", Offset = "0x725AE0", VA = "0x1807270E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4516F20", Offset = "0x4515920", VA = "0x184516F20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public AANHDIOFKDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x4516D70", Offset = "0x4515770", VA = "0x184516D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x4516EE0", Offset = "0x45158E0", VA = "0x184516EE0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x77AFB0", Offset = "0x7799B0", VA = "0x18077AFB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F70", Offset = "0x7B3970", VA = "0x1807B4F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int CODCLFMHLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x72C630", Offset = "0x72B030", VA = "0x18072C630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4E80", Offset = "0x7B3880", VA = "0x1807B4E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x301D240", Offset = "0x301BC40", VA = "0x18301D240")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x301D980", Offset = "0x301C380", VA = "0x18301D980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x301DBC0", Offset = "0x301C5C0", VA = "0x18301DBC0")]
	public IJMIEGCMPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x301DC40", Offset = "0x301C640", VA = "0x18301DC40")]
	public IJMIEGCMPPA(int DBHCHJIPCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x301D5F0", Offset = "0x301BFF0", VA = "0x18301D5F0")]
	public bool INLNHMHBIFH(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x301D6D0", Offset = "0x301C0D0", VA = "0x18301D6D0")]
	public bool JKMCEKMFFED(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x301D2E0", Offset = "0x301BCE0", VA = "0x18301D2E0")]
	public bool DIJLMCJOFIG(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x301D450", Offset = "0x301BE50", VA = "0x18301D450")]
	public bool FAKGJGPBFFP(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x301DB30", Offset = "0x301C530", VA = "0x18301DB30")]
	public void PMDMHBPEGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x301D150", Offset = "0x301BB50", VA = "0x18301D150")]
	public void COONODJIOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x301D360", Offset = "0x301BD60", VA = "0x18301D360")]
	public void EFMALMFMJGL(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x301D000", Offset = "0x301BA00", VA = "0x18301D000")]
	public void BONIBAPHNIO(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x301CE30", Offset = "0x301B830", VA = "0x18301CE30")]
	public bool AAMENLIPJIG(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x301D460", Offset = "0x301BE60", VA = "0x18301D460")]
	public void FDLCGMLBEAK(int LBOLDANMBMA, int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x301D7C0", Offset = "0x301C1C0", VA = "0x18301D7C0")]
	public void KGJHGEOFPEA(int CNHDJCCEHGI, int EKOBHOLKDHO, int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x301CEC0", Offset = "0x301B8C0", VA = "0x18301CEC0")]
	public int AGMLDLCGDGN(int EJMNNLNLAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x301CF90", Offset = "0x301B990", VA = "0x18301CF90")]
	public int AGMLDLCGDGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x301D100", Offset = "0x301BB00", VA = "0x18301D100")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x301D580", Offset = "0x301BF80", VA = "0x18301D580", Slot = "4")]
	[IteratorStateMachine(typeof(AANHDIOFKDH))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x301D580", Offset = "0x301BF80", VA = "0x18301D580", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1375A20", Offset = "0x1374420", VA = "0x181375A20")]
	public KFDFIBEHNAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9A10", Offset = "0x2BC8410", VA = "0x182BC9A10")]
	public KFDFIBEHNAO(global::KAEJMNENLIM<T> FCFIJAMEHIP, global::IKBIBPMEKFA<T> COIKOAPILOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x2BC97F0", Offset = "0x2BC81F0", VA = "0x182BC97F0", Slot = "11")]
	public override T JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9320", Offset = "0x2BC7D20", VA = "0x182BC9320", Slot = "12")]
	public override void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH, T LPJDDLMPNCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class ELGHCECBPLF
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x1D85170", Offset = "0x1D83B70", VA = "0x181D85170")]
	public static AHKPLOLMABO EHOMCGHPBHE<T>(this ACAPACFAGOM FNBGFGCHFDN, global::OBMHIPHOPOO<T> AMNLGEBHFHK, global::KAEJMNENLIM<T> FCFIJAMEHIP, global::IKBIBPMEKFA<T> COIKOAPILOH) where T : struct
	{
		return default(AHKPLOLMABO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class BDJFOKEEEDN<T> : global::KFDFIBEHNAO<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x2304B50", Offset = "0x2303550", VA = "0x182304B50")]
	public BDJFOKEEEDN(T ONLKOJHBEOC, T JKHCMKCHKPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class DCNLKAGJLKE<T> : global::CNGNALLHOAD<T> where T : struct, HLLCIEEAKDG
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF0E50", Offset = "0x2CEF850", VA = "0x182CF0E50", Slot = "11")]
	public override T JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF0D60", Offset = "0x2CEF760", VA = "0x182CF0D60", Slot = "12")]
	public override void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH, T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x18E8130", Offset = "0x18E6B30", VA = "0x1818E8130")]
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
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2729C90", Offset = "0x2728690", VA = "0x182729C90", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x272A9E0", Offset = "0x27293E0", VA = "0x18272A9E0", Slot = "8")]
	public override void JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH, in LGDIAIHEOID ELODBNLDLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x2729510", Offset = "0x2727F10", VA = "0x182729510", Slot = "9")]
	public override void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH, in HAMGOKKMMPI KCGHNGOMAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x272AE90", Offset = "0x2729890", VA = "0x18272AE90", Slot = "10")]
	public override void KJCIHCOFJEN(CDCPEIFBKAJ MPOAAENBMAH, JPBCALOAEAE DNIKKNNGFMM, object PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x225B720", Offset = "0x225A120", VA = "0x18225B720")]
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
			[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
			public CILGBKBODEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x2EF8F80", Offset = "0x2EF7980", VA = "0x182EF8F80")]
			internal void <RegisterFixedString>b__0(CDCPEIFBKAJ p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x2EF91F0", Offset = "0x2EF7BF0", VA = "0x182EF91F0")]
			internal T <RegisterFixedString>b__1(CDCPEIFBKAJ p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x4520910", Offset = "0x451F310", VA = "0x184520910")]
		public static void EIFKPHBGFFD(HEBPACNMIJJ DKLBPBGOMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x2E89DC0", Offset = "0x2E887C0", VA = "0x182E89DC0")]
		private static void LPJFGHJAPIG<T>(HEBPACNMIJJ DKLBPBGOMJE, int JKHCMKCHKPC) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x2E89D30", Offset = "0x2E88730", VA = "0x182E89D30")]
		private static void CNAJGFMGADB<T>(CDCPEIFBKAJ JOFEJELEMJH, T CMBMGCLLFDP, int JKHCMKCHKPC) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x2E896E0", Offset = "0x2E880E0", VA = "0x182E896E0")]
		private static T BACNOJCDKLG<T>(CDCPEIFBKAJ JOFEJELEMJH, int JKHCMKCHKPC) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E89340", Offset = "0x2E87D40", VA = "0x182E89340", Slot = "6")]
		public override void GONJADLODAI<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x451EB60", Offset = "0x451D560", VA = "0x18451EB60")]
		public static void AOCHDJJDHOC(HEBPACNMIJJ DKLBPBGOMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x451EC10", Offset = "0x451D610", VA = "0x18451EC10")]
		public NIONPCHEGJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x3021460", Offset = "0x301FE60", VA = "0x183021460")]
	public static void KNEILNAKNGH(HEBPACNMIJJ DKLBPBGOMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x1994200", Offset = "0x1992C00", VA = "0x181994200")]
	public static void LKAOJPAILAL<T>(HEBPACNMIJJ DKLBPBGOMJE, global::KAEJMNENLIM<T> FCFIJAMEHIP, global::IKBIBPMEKFA<T> COIKOAPILOH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x1994290", Offset = "0x1992C90", VA = "0x181994290")]
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
	[Cpp2IlInjected.Address(RVA = "0x3201EE0", Offset = "0x32008E0", VA = "0x183201EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x800A50", VA = "0x180802050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE50", Offset = "0x7C9850", VA = "0x1807CAE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x31FF070", Offset = "0x31FDA70", VA = "0x1831FF070")]
	public BLPEEOFFJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x31FF0F0", Offset = "0x31FDAF0", VA = "0x1831FF0F0")]
	public BLPEEOFFJDN(Dictionary<AHKPLOLMABO, FFICJKMIKPC> DKLBPBGOMJE, bool HAIDDAMPLEF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x31FEA50", Offset = "0x31FD450", VA = "0x1831FEA50", Slot = "7")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x31FEC20", Offset = "0x31FD620", VA = "0x1831FEC20", Slot = "8")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x31FE930", Offset = "0x31FD330", VA = "0x1831FE930", Slot = "9")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x31FE980", Offset = "0x31FD380", VA = "0x1831FE980", Slot = "4")]
	public AHKPLOLMABO DCNFHPDCNKA(DDIEEGNDNAH AMNLGEBHFHK)
	{
		return default(AHKPLOLMABO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x31FEAB0", Offset = "0x31FD4B0", VA = "0x1831FEAB0", Slot = "5")]
	public void EHOMCGHPBHE(AHKPLOLMABO PKNOIGMENLD, FFICJKMIKPC BLNCBNBKOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x31FECA0", Offset = "0x31FD6A0", VA = "0x1831FECA0")]
	[Conditional("DEBUG_BUILD")]
	private void KNBAPPCJBKN(AHKPLOLMABO PKNOIGMENLD, Type OGILDIMGIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x31FEEC0", Offset = "0x31FD8C0", VA = "0x1831FEEC0", Slot = "6")]
	public bool OBCGBBDEENH(AHKPLOLMABO PKNOIGMENLD, out FFICJKMIKPC BLNCBNBKOBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x31FEDE0", Offset = "0x31FD7E0", VA = "0x1831FEDE0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B260", Offset = "0x729C60", VA = "0x18072B260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x74CAD0", Offset = "0x74B4D0", VA = "0x18074CAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2D8DBD0", Offset = "0x2D8C5D0", VA = "0x182D8DBD0")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2D8DC50", Offset = "0x2D8C650", VA = "0x182D8DC50")]
		public TypeSerializerService(Dictionary<Type, FFICJKMIKPC> DKLBPBGOMJE, bool HAIDDAMPLEF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D840", Offset = "0x2D8C240", VA = "0x182D8D840", Slot = "4")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D8A0", Offset = "0x2D8C2A0", VA = "0x182D8D8A0", Slot = "5")]
		public void EHOMCGHPBHE(Type OGILDIMGIOH, FFICJKMIKPC BLNCBNBKOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2D8DAA0", Offset = "0x2D8C4A0", VA = "0x182D8DAA0", Slot = "6")]
		public bool OBCGBBDEENH(Type OGILDIMGIOH, out FFICJKMIKPC BLNCBNBKOBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D9C0", Offset = "0x2D8C3C0", VA = "0x182D8D9C0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B3B0A0", Offset = "0x2B39AA0", VA = "0x182B3B0A0", Slot = "6")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B1D0", Offset = "0x2B39BD0", VA = "0x182B3B1D0", Slot = "7")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B0F0", Offset = "0x2B39AF0", VA = "0x182B3B0F0", Slot = "4")]
	public void EHOMCGHPBHE(AHKPLOLMABO CBPECCEKJOB, Type GGKOLFHJEEI, MNMLDAEHJEP IKMIEJANNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B160", Offset = "0x2B39B60", VA = "0x182B3B160", Slot = "5")]
	public bool FFBJODJAHOH(AHKPLOLMABO CBPECCEKJOB, out MNMLDAEHJEP IKMIEJANNMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B230", Offset = "0x2B39C30", VA = "0x182B3B230")]
	[Conditional("DEBUG_BUILD")]
	private void JEACGGEHGFN(AHKPLOLMABO CBPECCEKJOB, Type GGKOLFHJEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B3C0", Offset = "0x2B39DC0", VA = "0x182B3B3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3201A50", Offset = "0x3200450", VA = "0x183201A50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool OEENHAMLKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7DC220", Offset = "0x7DAC20", VA = "0x1807DC220", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x9427A0", Offset = "0x9411A0", VA = "0x1809427A0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x3201760", Offset = "0x3200160", VA = "0x183201760", Slot = "6")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x3201870", Offset = "0x3200270", VA = "0x183201870", Slot = "7")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x3201AA0", Offset = "0x32004A0", VA = "0x183201AA0", Slot = "8")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x32019B0", Offset = "0x32003B0", VA = "0x1832019B0")]
	private void GGNOBJONILD(MBEDCJLMHEO LKHNLAILFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x32018F0", Offset = "0x32002F0", VA = "0x1832018F0", Slot = "4")]
	public bool GDJKHHLIDNH(KHMECMDAALD HBKLDKCICEJ, AHKPLOLMABO GJEJKJANAJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x3201B50", Offset = "0x3200550", VA = "0x183201B50", Slot = "5")]
	public void PPMMFHFIIKL(KHMECMDAALD HBKLDKCICEJ, Span<AHKPLOLMABO> FNBGFGCHFDN, bool IKNMKFDCOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x3201760", Offset = "0x3200160", VA = "0x183201760", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x3201D70", Offset = "0x3200770", VA = "0x183201D70")]
	public CDDPMEICGNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class IPOBCHIKFGH
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x3020C50", Offset = "0x301F650", VA = "0x183020C50")]
	public static void MJJPOKGHHFF(this CDCPEIFBKAJ MPOAAENBMAH, ReadOnlyMemory<byte> INNICGEDFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x283F160", Offset = "0x283DB60", VA = "0x18283F160")]
	public static void BBEFEPKHMJH<T>(this CDCPEIFBKAJ MPOAAENBMAH, in T LPJDDLMPNCG) where T : struct, HLLCIEEAKDG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x283F290", Offset = "0x283DC90", VA = "0x18283F290")]
	public static T PBNCMLICAHG<T>(this CDCPEIFBKAJ MPOAAENBMAH) where T : struct, HLLCIEEAKDG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x3020A70", Offset = "0x301F470", VA = "0x183020A70")]
	public static void BBEFEPKHMJH(this CDCPEIFBKAJ MPOAAENBMAH, IFOLEJGFJIO KDHKIHNDDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x3020CD0", Offset = "0x301F6D0", VA = "0x183020CD0")]
	public static IFOLEJGFJIO NFEBJEJGOJJ(this CDCPEIFBKAJ MPOAAENBMAH)
	{
		return default(IFOLEJGFJIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x3020AA0", Offset = "0x301F4A0", VA = "0x183020AA0")]
	public static void FLFEIHJLBDD(this CDCPEIFBKAJ PFBBPOBMKBB, uint FBJJAHHBOIC, bool DOGHCHIFBPB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x3020D00", Offset = "0x301F700", VA = "0x183020D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public KEENPNBIOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC85C0", Offset = "0x2BC6FC0", VA = "0x182BC85C0")]
		internal void <GetByteEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8630", Offset = "0x2BC7030", VA = "0x182BC8630")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public HNHPOFNADLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7090", Offset = "0x2FD5A90", VA = "0x182FD7090")]
		internal void <GetSByteEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7100", Offset = "0x2FD5B00", VA = "0x182FD7100")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public BMDFMGPGNLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x25A8250", Offset = "0x25A6C50", VA = "0x1825A8250")]
		internal void <GetShortEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x25A82C0", Offset = "0x25A6CC0", VA = "0x1825A82C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public AFMMIDLONJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8D90", Offset = "0x2AA7790", VA = "0x182AA8D90")]
		internal void <GetUShortEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8E00", Offset = "0x2AA7800", VA = "0x182AA8E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public ECIFJGEELOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x4051950", Offset = "0x4050350", VA = "0x184051950")]
		internal void <GetIntEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x40519B0", Offset = "0x40503B0", VA = "0x1840519B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public PGEAKGCLANF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2C38ED0", Offset = "0x2C378D0", VA = "0x182C38ED0")]
		internal void <GetUIntEnumDelegates>b__0(CDCPEIFBKAJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2C38F30", Offset = "0x2C37930", VA = "0x182C38F30")]
		internal T <GetUIntEnumDelegates>b__1(CDCPEIFBKAJ b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F747E0", Offset = "0x1F731E0", VA = "0x181F747E0")]
	public static void PCMHGMMAMIM<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F743F0", Offset = "0x1F72DF0", VA = "0x181F743F0")]
	private static void DIMKIGFFMED<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F743F0", Offset = "0x1F72DF0", VA = "0x181F743F0")]
	private static void EBCKOFMBEFB<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F74690", Offset = "0x1F73090", VA = "0x181F74690")]
	private static void NCHMFNBAEGF<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x1F74690", Offset = "0x1F73090", VA = "0x181F74690")]
	private static void CGPGLILELOA<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x1F74540", Offset = "0x1F72F40", VA = "0x181F74540")]
	private static void KNMGLDJKBHM<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x1F74540", Offset = "0x1F72F40", VA = "0x181F74540")]
	private static void HDOEOEBJCGP<T>(T ONLKOJHBEOC, T JKHCMKCHKPC, out global::KAEJMNENLIM<T> BHLFDPNPMFI, out global::IKBIBPMEKFA<T> PBOPOBMEFBN) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class FKOMPPMBIHI : EHHACAEHLKG, IJGJDJPFIAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x3010E30", Offset = "0x300F830", VA = "0x183010E30", Slot = "4")]
	private void DNCPKOEGODG(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void AOAAIONKNHE(ACAPACFAGOM FNBGFGCHFDN);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
	protected FKOMPPMBIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[NOJIPINFHEG(typeof(LocalPoseData))]
public sealed class PIHLHFOHAGP : FKOMPPMBIHI
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B440", Offset = "0x2B39E40", VA = "0x182B3B440", Slot = "5")]
	protected override void AOAAIONKNHE(ACAPACFAGOM FNBGFGCHFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740")]
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
		[Cpp2IlInjected.Address(RVA = "0x320C900", Offset = "0x320B300", VA = "0x18320C900", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x320CF40", Offset = "0x320B940", VA = "0x18320CF40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x320D0C0", Offset = "0x320BAC0", VA = "0x18320D0C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x320D090", Offset = "0x320BA90", VA = "0x18320D090", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x320CB20", Offset = "0x320B520", VA = "0x18320CB20")]
		private void INHACONLPBL(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x320C760", Offset = "0x320B160", VA = "0x18320C760")]
		private void FLAAPMPCOFO(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x320C480", Offset = "0x320AE80", VA = "0x18320C480")]
		private void ECPGIBLDAAD(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x320C970", Offset = "0x320B370", VA = "0x18320C970")]
		private void FOIMKEJPBLA(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x320C270", Offset = "0x320AC70", VA = "0x18320C270")]
		private void BIBMDLCKLNL(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x320CE60", Offset = "0x320B860", VA = "0x18320CE60")]
		private void NINBKJMFEFA(MBEDCJLMHEO LKHNLAILFFL, int ENNAKHLEBJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x32153A0", Offset = "0x3213DA0", VA = "0x1832153A0", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x32153F0", Offset = "0x3213DF0", VA = "0x1832153F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x32154B0", Offset = "0x3213EB0", VA = "0x1832154B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x3214DC0", Offset = "0x32137C0", VA = "0x183214DC0")]
	private void AILHPOBFNHC(NativeArray<Entity> ABBIPALBHCK, NativeList<Entity> LJLPNNBCCEF, ComponentDataFromEntity<MAFMNDNCKFB> IGPMINLHPHN, BufferFromEntity<ChildrenData> DLIGBEOLLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public EEEIKJFDJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class CPDBMAOPMJE : ParentSystemBase<AuthoredParentData, OFDDALEFPDF, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x32048F0", Offset = "0x32032F0", VA = "0x1832048F0", Slot = "14")]
	protected override EntityQueryDesc AJBCBAODHIH(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC300", Offset = "0x7BAD00", VA = "0x1807BC300", Slot = "15")]
	protected override EntityQueryDesc OJLONFAPHKN(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x3204970", Offset = "0x3203370", VA = "0x183204970", Slot = "16")]
	protected override EntityQueryDesc GJLPABAIIHN(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x3204930", Offset = "0x3203330", VA = "0x183204930", Slot = "17")]
	protected override EntityQueryDesc FLFKHDOCMLI(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x32049F0", Offset = "0x32033F0", VA = "0x1832049F0")]
	public CPDBMAOPMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x32049B0", Offset = "0x32033B0", VA = "0x1832049B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3201FE0", Offset = "0x32009E0", VA = "0x183201FE0", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x3202060", Offset = "0x3200A60", VA = "0x183202060", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x3202100", Offset = "0x3200B00", VA = "0x183202100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public CFJIBBMMPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3203370", Offset = "0x3201D70", VA = "0x183203370", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x32033F0", Offset = "0x3201DF0", VA = "0x1832033F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x3203490", Offset = "0x3201E90", VA = "0x183203490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public CJIHFHOPDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x30129B0", Offset = "0x30113B0", VA = "0x1830129B0", Slot = "4")]
	public bool Equals(IBKKPFNMPDF MPHACEGLFIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
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
	[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
	public static IKLJBGNMCHM HPHCHABBDNG(GNJFKFOLPLJ IGELLPOEMHM)
	{
		return default(IKLJBGNMCHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class DGLGNJJCAMK : OPCKHODOLIL
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x3211E10", Offset = "0x3210810", VA = "0x183211E10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x3211FA0", Offset = "0x32109A0", VA = "0x183211FA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x3012BF0", Offset = "0x30115F0", VA = "0x183012BF0")]
	protected DGLGNJJCAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B2DCC0", Offset = "0x2B2C6C0", VA = "0x182B2DCC0", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x2B2DD30", Offset = "0x2B2C730", VA = "0x182B2DD30")]
	protected void INHIKBBJFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x2B2DFB0", Offset = "0x2B2C9B0", VA = "0x182B2DFB0")]
	protected void JBOPGKDJEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x2B2E230", Offset = "0x2B2CC30", VA = "0x182B2E230")]
	protected GKNDEBMEIID MOCHLPAFENL()
	{
		return default(GKNDEBMEIID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	protected OPCKHODOLIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class INCNPIGOHPD : OPCKHODOLIL
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x3020500", Offset = "0x301EF00", VA = "0x183020500", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x3020690", Offset = "0x301F090", VA = "0x183020690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x3012BF0", Offset = "0x30115F0", VA = "0x183012BF0")]
	protected INCNPIGOHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class GNNNCFIPELJ : OPCKHODOLIL
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x3012A50", Offset = "0x3011450", VA = "0x183012A50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x3012B60", Offset = "0x3011560", VA = "0x183012B60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x3012BF0", Offset = "0x30115F0", VA = "0x183012BF0")]
	protected GNNNCFIPELJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3201E70", Offset = "0x3200870", VA = "0x183201E70", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x3012BF0", Offset = "0x30115F0", VA = "0x183012BF0")]
	public CEHNKOBAHDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3027460", Offset = "0x3025E60", VA = "0x183027460", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x3012BF0", Offset = "0x30115F0", VA = "0x183012BF0")]
	public KNMMHMEJDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x30257F0", Offset = "0x30241F0", VA = "0x1830257F0", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x3012BF0", Offset = "0x30115F0", VA = "0x183012BF0")]
	public KFFGEGFHGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3025500", Offset = "0x3023F00", VA = "0x183025500", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x3025570", Offset = "0x3023F70", VA = "0x183025570")]
	public KCBBJOJKDKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3015C10", Offset = "0x3014610", VA = "0x183015C10", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x3012BF0", Offset = "0x30115F0", VA = "0x183012BF0")]
	public HIDGLPJGGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3216BD0", Offset = "0x32155D0", VA = "0x183216BD0", Slot = "15")]
		get
		{
			return default(JGLPINIBHEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x3025570", Offset = "0x3023F70", VA = "0x183025570")]
	public EPJJPDNOOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x30234C0", Offset = "0x3021EC0", VA = "0x1830234C0")]
	public JGLPINIBHEE(ComponentType NNIHDPDHNJD, ComponentType JDKEMCFCFIL, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x1995240", Offset = "0x1993C40", VA = "0x181995240")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C14C0", VA = "0x1807C2AC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A30", Offset = "0x7C1430", VA = "0x1807C2A30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int PELKNHEANOH
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x8C40C0", Offset = "0x8C2AC0", VA = "0x1808C40C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xE340B0", Offset = "0xE32AB0", VA = "0x180E340B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x3012970", Offset = "0x3011370", VA = "0x183012970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x30129B0", Offset = "0x30113B0", VA = "0x1830129B0", Slot = "8")]
	public bool Equals(GNJFKFOLPLJ MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x3012A00", Offset = "0x3011400", VA = "0x183012A00", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x4516B60", Offset = "0x4515560", VA = "0x184516B60")]
			public CMGCOHKPCKP(GNJFKFOLPLJ IGELLPOEMHM, float3 PICDPPHNNLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x4518A90", Offset = "0x4517490", VA = "0x184518A90")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
			public FGJNFKGNFHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
			public MBHELCJMGFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
			public AFAAEGBIMJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x451AA50", Offset = "0x4519450", VA = "0x18451AA50")]
				public void KMHCJEDMEHN(UpdateConnectableVisuals LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x451AAD0", Offset = "0x45194D0", VA = "0x18451AAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x451F6A0", Offset = "0x451E0A0", VA = "0x18451F6A0")]
			internal void JACNCLCPMJH(Entity LCLDFKAJPDK, WorldPoseData BPEDABAJFBJ, in DynamicBuffer<IKLJBGNMCHM> OJNFGJAPBNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x451FA60", Offset = "0x451E460", VA = "0x18451FA60", Slot = "5")]
			public void ReadFromDisplayClass(ref FGJNFKGNFHJ LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x451FA90", Offset = "0x451E490", VA = "0x18451FA90", Slot = "6")]
			public void WriteToDisplayClass(ref FGJNFKGNFHJ LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x451F550", Offset = "0x451DF50", VA = "0x18451F550", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x451F920", Offset = "0x451E320", VA = "0x18451F920")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref HINBFOCPFGP.BBNEMJMEGNA MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x451F8E0", Offset = "0x451E2E0", VA = "0x18451F8E0")]
			public void KMHCJEDMEHN(UpdateConnectableVisuals LFKHFKIBGCJ, ref FGJNFKGNFHJ LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x451F630", Offset = "0x451E030", VA = "0x18451F630")]
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
				[Cpp2IlInjected.Address(RVA = "0x451D980", Offset = "0x451C380", VA = "0x18451D980")]
				public void KMHCJEDMEHN(UpdateConnectableVisuals LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x451D9F0", Offset = "0x451C3F0", VA = "0x18451D9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x451C440", Offset = "0x451AE40", VA = "0x18451C440")]
			internal void JACNCLCPMJH(in WorldPoseData BPEDABAJFBJ, in DynamicBuffer<IBKKPFNMPDF> OJNFGJAPBNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x16805F0", Offset = "0x167EFF0", VA = "0x1816805F0", Slot = "5")]
			public void ReadFromDisplayClass(ref MBHELCJMGFC LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x451C370", Offset = "0x451AD70", VA = "0x18451C370", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x451C5F0", Offset = "0x451AFF0", VA = "0x18451C5F0")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref LNPFNPLEKKO.HIBGNNDPFAJ MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x451C550", Offset = "0x451AF50", VA = "0x18451C550")]
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
				[Cpp2IlInjected.Address(RVA = "0x451CD50", Offset = "0x451B750", VA = "0x18451CD50")]
				public void KMHCJEDMEHN(UpdateConnectableVisuals LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x451CDE0", Offset = "0x451B7E0", VA = "0x18451CDE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x451FC10", Offset = "0x451E610", VA = "0x18451FC10")]
			internal void JACNCLCPMJH(in WorldPoseData BPEDABAJFBJ, in JLMBEOKAAAA DGIFBEPHKIB, in DynamicBuffer<IBKKPFNMPDF> OJNFGJAPBNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x16805F0", Offset = "0x167EFF0", VA = "0x1816805F0", Slot = "5")]
			public void ReadFromDisplayClass(ref AFAAEGBIMJF LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x451FB90", Offset = "0x451E590", VA = "0x18451FB90", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x451FDB0", Offset = "0x451E7B0", VA = "0x18451FDB0")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref KKJMDKIJHCC.KDCLCIDJKCO MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x451FD70", Offset = "0x451E770", VA = "0x18451FD70")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D90760", Offset = "0x2D8F160", VA = "0x182D90760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2D907A0", Offset = "0x2D8F1A0", VA = "0x182D907A0")]
		internal IFKHEAGAGMF JCINPFGBNCN(GNJFKFOLPLJ IGELLPOEMHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FBC0", Offset = "0x2D8E5C0", VA = "0x182D8FBC0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2D91FB0", Offset = "0x2D909B0", VA = "0x182D91FB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2D92230", Offset = "0x2D90C30", VA = "0x182D92230", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2D923C0", Offset = "0x2D90DC0", VA = "0x182D923C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2D921F0", Offset = "0x2D90BF0", VA = "0x182D921F0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E9F0", Offset = "0x2D8D3F0", VA = "0x182D8E9F0")]
		private void CLKANKBLJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FC80", Offset = "0x2D8E680", VA = "0x182D8FC80")]
		private void HFIFKIHOMLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F810", Offset = "0x2D8E210", VA = "0x182D8F810")]
		private void FKOIHCLFCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2D92400", Offset = "0x2D90E00", VA = "0x182D92400", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FDD0", Offset = "0x2D8E7D0", VA = "0x182D8FDD0")]
		private void HGAJENLLFEE(EntityQuery FLGNKDDLJNL, EntityQuery KPOMAEBEHKO, EntityQuery PKFGFHPBIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F740", Offset = "0x2D8E140", VA = "0x182D8F740")]
		private void FJEBMLODAAK(EntityQuery PKFGFHPBIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F2F0", Offset = "0x2D8DCF0", VA = "0x182D8F2F0")]
		private void EKJDHHJNBGL(NativeArrayAsync<Entity> ICMLKIFLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E8E0", Offset = "0x2D8D2E0", VA = "0x182D8E8E0")]
		private void CEBJHIAEEDE(NativeArrayAsync<Entity> AFFHBMKJGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2D919C0", Offset = "0x2D903C0", VA = "0x182D919C0")]
		private void NONFDBDPCCM(NativeArrayAsync<Entity> FEOJDDCBKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F5D0", Offset = "0x2D8DFD0", VA = "0x182D8F5D0")]
		private void FJAAFLFHOHC(NativeList<GNJFKFOLPLJ> OHPGIIDCCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2D914A0", Offset = "0x2D8FEA0", VA = "0x182D914A0")]
		private NativeList<GNJFKFOLPLJ> MLKABDOKHGP(NativeArray<Entity> ABBIPALBHCK)
		{
			return default(NativeList<GNJFKFOLPLJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2D8EC40", Offset = "0x2D8D640", VA = "0x182D8EC40")]
		private void EBEKKNDOIIA(NativeArray<Entity> ABBIPALBHCK, NativeList<GNJFKFOLPLJ> OHPGIIDCCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2D90CE0", Offset = "0x2D8F6E0", VA = "0x182D90CE0")]
		private void LBFJFCFHHJG(NativeArray<Entity> OCOFIPGFIEL, NativeArray<Entity> NOLOEOAPAOM, NativeList<GNJFKFOLPLJ> OEFGDAGFKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2D902B0", Offset = "0x2D8ECB0", VA = "0x182D902B0")]
		private void HHHOOEDJKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E7A0", Offset = "0x2D8D1A0", VA = "0x182D8E7A0")]
		private NativeListAsync<CMGCOHKPCKP> BJJDHEGNPKD(EntityQuery ANBHGOBNOFE, Func<NativeList<CMGCOHKPCKP>, JobHandle> GKGCJOBINLE)
		{
			return default(NativeListAsync<CMGCOHKPCKP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E540", Offset = "0x2D8CF40", VA = "0x182D8E540")]
		private JobHandle AMDAIKNCDNG(NativeList<CMGCOHKPCKP> BDHPAGCMKHB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2D8EB00", Offset = "0x2D8D500", VA = "0x182D8EB00")]
		private JobHandle DGBKFCOOAKH(NativeList<CMGCOHKPCKP> BDHPAGCMKHB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2D91D20", Offset = "0x2D90720", VA = "0x182D91D20")]
		private JobHandle OJKADDMJEOJ(NativeList<CMGCOHKPCKP> BDHPAGCMKHB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2D91210", Offset = "0x2D8FC10", VA = "0x182D91210")]
		private void MEPPDGPJCKD(NativeListAsync<CMGCOHKPCKP> BDHPAGCMKHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2D90A50", Offset = "0x2D8F450", VA = "0x182D90A50")]
		private void KGLPKFEBKFD(NativeListAsync<CMGCOHKPCKP> BDHPAGCMKHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2D927A0", Offset = "0x2D911A0", VA = "0x182D927A0")]
		private bool POPBJPGMBBK(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E6D0", Offset = "0x2D8D0D0", VA = "0x182D8E6D0")]
		private NativeArray<Entity> BFAPEGALJNN(Entity LCLDFKAJPDK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2D91B60", Offset = "0x2D90560", VA = "0x182D91B60")]
		private GNJFKFOLPLJ OJAGPHECJEF(NativeList<GNJFKFOLPLJ> OEFGDAGFKCG)
		{
			return default(GNJFKFOLPLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F260", Offset = "0x2D8DC60", VA = "0x182D8F260")]
		private void EIKJNKDPNKK(GNJFKFOLPLJ IGELLPOEMHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2D91E50", Offset = "0x2D90850", VA = "0x182D91E50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E340", Offset = "0x2D8CD40", VA = "0x182D8E340")]
		public static EntityQuery AFBINOIPIHD(ComponentSystemBase LFKHFKIBGCJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2D907F0", Offset = "0x2D8F1F0", VA = "0x182D907F0")]
		public static EntityQuery KFLKNBKKKGG(ComponentSystemBase LFKHFKIBGCJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2D92530", Offset = "0x2D90F30", VA = "0x182D92530")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B41590", Offset = "0x2B3FF90", VA = "0x182B41590", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B41500", Offset = "0x2B3FF00", VA = "0x182B41500", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B41690", Offset = "0x2B40090", VA = "0x182B41690", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public IBKFHADKBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	public IBKFHADKBMO(APKFPLGDLPH MPIEEKNKAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x30198B0", Offset = "0x30182B0", VA = "0x1830198B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3014840", Offset = "0x3013240", VA = "0x183014840", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x30148A0", Offset = "0x30132A0", VA = "0x1830148A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x30148D0", Offset = "0x30132D0", VA = "0x1830148D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	protected HBOBLIMOCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3216400", Offset = "0x3214E00", VA = "0x183216400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int CDJBKJOLKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x3216730", Offset = "0x3215130", VA = "0x183216730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x3216360", Offset = "0x3214D60", VA = "0x183216360", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x3216920", Offset = "0x3215320", VA = "0x183216920", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x3216B20", Offset = "0x3215520", VA = "0x183216B20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x3216B40", Offset = "0x3215540", VA = "0x183216B40")]
	public int PHDIMBKCLEF(SceneTag OOOMPFGDEEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x3216740", Offset = "0x3215140", VA = "0x183216740")]
	public int NHBEOEOMDAO(SceneTag OOOMPFGDEEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x3216410", Offset = "0x3214E10", VA = "0x183216410")]
	protected void GMOLNPMNBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x32167B0", Offset = "0x32151B0", VA = "0x1832167B0")]
	protected void OLDLAMGIADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x3216310", Offset = "0x3214D10", VA = "0x183216310")]
	public NativeArrayAsync<Entity> EPEKCCFJICO(SceneTag OOOMPFGDEEN, Allocator FKHAEPDPDAI = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x3216760", Offset = "0x3215160", VA = "0x183216760")]
	public NativeArrayAsync<Entity> OGDBBLCMJPJ(SceneTag OOOMPFGDEEN, Allocator FKHAEPDPDAI = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x32166A0", Offset = "0x32150A0", VA = "0x1832166A0")]
	public bool MEJIBNNKJPK(SceneTag OOOMPFGDEEN, out NativeArrayAsync<Entity> MPIEEKNKAMO, Allocator FKHAEPDPDAI = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x32162B0", Offset = "0x3214CB0", VA = "0x1832162B0")]
	public bool DGBCKPEIJJH(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x3216630", Offset = "0x3215030", VA = "0x183216630")]
	public APKFPLGDLPH HIOCOIPKIEF(Entity LCLDFKAJPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x3216B60", Offset = "0x3215560", VA = "0x183216B60")]
	public bool PHONMIEGPBF(Entity LCLDFKAJPDK, out IBKFHADKBMO MPIEEKNKAMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x32163C0", Offset = "0x3214DC0", VA = "0x1832163C0")]
	public void GBIFKHPFBNE(Entity LCLDFKAJPDK, IBKFHADKBMO MPIEEKNKAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x32168C0", Offset = "0x32152C0", VA = "0x1832168C0")]
	public bool OPKIHFBPPFC(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void KLMKIDBPMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public EMAMPNJOLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B28B20", Offset = "0x2B27520", VA = "0x182B28B20", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B28BE0", Offset = "0x2B275E0", VA = "0x182B28BE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x2B28CA0", Offset = "0x2B276A0", VA = "0x182B28CA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x2B643E0", Offset = "0x2B62DE0", VA = "0x182B643E0")]
	private bool BCCJGCPMEPP<TComponentData>(EntityQuery ANBHGOBNOFE, out NativeArray<Entity> ABBIPALBHCK, out NativeArray<TComponentData> MCGONHKIMDB) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x2B28B70", Offset = "0x2B27570", VA = "0x182B28B70")]
	public APKFPLGDLPH HIOCOIPKIEF(Entity LCLDFKAJPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public NFLHLIEFOCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D83B10", Offset = "0x2D82510", VA = "0x182D83B10", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x2D83B60", Offset = "0x2D82560", VA = "0x182D83B60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D83D90", Offset = "0x2D82790", VA = "0x182D83D90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D836D0", Offset = "0x2D820D0", VA = "0x182D836D0")]
		private void AGMLDLCGDGN(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x2D83AA0", Offset = "0x2D824A0", VA = "0x182D83AA0")]
		private void FJEBMLODAAK(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D83D20", Offset = "0x2D82720", VA = "0x182D83D20", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D83740", Offset = "0x2D82140", VA = "0x182D83740")]
		private void DDJHPCHLILF(EntityQuery ANBHGOBNOFE, bool KHJHBNPBBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public PPFCEDCNBJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x451CEB0", Offset = "0x451B8B0", VA = "0x18451CEB0")]
			public void KMHCJEDMEHN(FBEPKKIJION LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x451CF30", Offset = "0x451B930", VA = "0x18451CF30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4519430", Offset = "0x4517E30", VA = "0x184519430")]
		internal void JACNCLCPMJH(Entity MDGOLEBJDDG, SplineShapeData PJEHHDIBMKL, DynamicBuffer<LinkedEntityGroup> NPOGECPDPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x4519360", Offset = "0x4517D60", VA = "0x184519360", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x45194A0", Offset = "0x4517EA0", VA = "0x1845194A0")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref LAPFECNNADA.KGPIPMKCJHC MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x4519490", Offset = "0x4517E90", VA = "0x184519490")]
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
			[Cpp2IlInjected.Address(RVA = "0x4519280", Offset = "0x4517C80", VA = "0x184519280")]
			public void KMHCJEDMEHN(FBEPKKIJION LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x45192E0", Offset = "0x4517CE0", VA = "0x1845192E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x451A190", Offset = "0x4518B90", VA = "0x18451A190")]
		internal void JACNCLCPMJH(Entity HIBFCDNCMKO, SplinePointParentData IMEJGNOGGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x451A360", Offset = "0x4518D60", VA = "0x18451A360", Slot = "5")]
		public void ReadFromDisplayClass(ref PPFCEDCNBJJ LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x451A0F0", Offset = "0x4518AF0", VA = "0x18451A0F0", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x451A2B0", Offset = "0x4518CB0", VA = "0x18451A2B0")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref EJJPLGJGCHM.FPHGFFAGGGP MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x451A220", Offset = "0x4518C20", VA = "0x18451A220")]
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
	[Cpp2IlInjected.Address(RVA = "0x300EEE0", Offset = "0x300D8E0", VA = "0x18300EEE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x300EF90", Offset = "0x300D990", VA = "0x18300EF90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public FBEPKKIJION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x300EC40", Offset = "0x300D640", VA = "0x18300EC40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x300EAA0", Offset = "0x300D4A0", VA = "0x18300EAA0")]
	public static EntityQuery MEILPLGKBIE(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x300E940", Offset = "0x300D340", VA = "0x18300E940")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B28F80", Offset = "0x2B27980", VA = "0x182B28F80", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x2B28FE0", Offset = "0x2B279E0", VA = "0x182B28FE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public NGBAOJHLINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public GNAFMNLGHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, KLGHMJKGANI previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x451E970", Offset = "0x451D370", VA = "0x18451E970")]
			public void KMHCJEDMEHN(DLMABNIPDBP LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x451E9D0", Offset = "0x451D3D0", VA = "0x18451E9D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D7C1B0", Offset = "0x2D7ABB0", VA = "0x182D7C1B0")]
		internal void JACNCLCPMJH(Entity LCLDFKAJPDK, ParentData IECLCEDGDAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x16805F0", Offset = "0x167EFF0", VA = "0x1816805F0", Slot = "5")]
		public void ReadFromDisplayClass(ref GNAFMNLGHHN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C140", Offset = "0x2D7AB40", VA = "0x182D7C140", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C270", Offset = "0x2D7AC70", VA = "0x182D7C270")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref NAOFLLBEJAH.PMLKHGHKEJB MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C230", Offset = "0x2D7AC30", VA = "0x182D7C230")]
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
			[Cpp2IlInjected.Address(RVA = "0x45177C0", Offset = "0x45161C0", VA = "0x1845177C0")]
			public void KMHCJEDMEHN(DLMABNIPDBP LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x4517840", Offset = "0x4516240", VA = "0x184517840")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D7C390", Offset = "0x2D7AD90", VA = "0x182D7C390")]
		internal void JACNCLCPMJH(Entity LCLDFKAJPDK, ParentData IECLCEDGDAE, KLGHMJKGANI CHHFOFIKHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C570", Offset = "0x2D7AF70", VA = "0x182D7C570", Slot = "5")]
		public void ReadFromDisplayClass(ref GNAFMNLGHHN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C320", Offset = "0x2D7AD20", VA = "0x182D7C320", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C490", Offset = "0x2D7AE90", VA = "0x182D7C490")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref AJPOIGNAMKP.GEIHIHGCLNI MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C450", Offset = "0x2D7AE50", VA = "0x182D7C450")]
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
			[Cpp2IlInjected.Address(RVA = "0x451EA80", Offset = "0x451D480", VA = "0x18451EA80")]
			public void KMHCJEDMEHN(DLMABNIPDBP LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x451EAE0", Offset = "0x451D4E0", VA = "0x18451EAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D7BFC0", Offset = "0x2D7A9C0", VA = "0x182D7BFC0")]
		internal void JACNCLCPMJH(Entity LCLDFKAJPDK, KLGHMJKGANI CHHFOFIKHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C130", Offset = "0x2D7AB30", VA = "0x182D7C130", Slot = "5")]
		public void ReadFromDisplayClass(ref GNAFMNLGHHN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2D7BF50", Offset = "0x2D7A950", VA = "0x182D7BF50", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C080", Offset = "0x2D7AA80", VA = "0x182D7C080")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref NICHEDBEKJM.HLOLHCODINE MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C040", Offset = "0x2D7AA40", VA = "0x182D7C040")]
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
	[Cpp2IlInjected.Address(RVA = "0x3212470", Offset = "0x3210E70", VA = "0x183212470", Slot = "14")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x3212810", Offset = "0x3211210", VA = "0x183212810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public DLMABNIPDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x32127B0", Offset = "0x32111B0", VA = "0x1832127B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x3212550", Offset = "0x3210F50", VA = "0x183212550")]
	public static EntityQuery NDPCLOMOMOC(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x3212240", Offset = "0x3210C40", VA = "0x183212240")]
	public static EntityQuery EPIFHIHMOMF(ComponentSystemBase LFKHFKIBGCJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x3212040", Offset = "0x3210A40", VA = "0x183212040")]
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
		[Cpp2IlInjected.Address(RVA = "0x3020E90", Offset = "0x301F890", VA = "0x183020E90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x3020E20", Offset = "0x301F820", VA = "0x183020E20", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x3020F20", Offset = "0x301F920", VA = "0x183020F20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class JGFKCHEFFEJ : ParentSystemBase<ParentData, KLGHMJKGANI, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x3023380", Offset = "0x3021D80", VA = "0x183023380", Slot = "14")]
	protected override EntityQueryDesc AJBCBAODHIH(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC300", Offset = "0x7BAD00", VA = "0x1807BC300", Slot = "15")]
	protected override EntityQueryDesc OJLONFAPHKN(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x3023400", Offset = "0x3021E00", VA = "0x183023400", Slot = "16")]
	protected override EntityQueryDesc GJLPABAIIHN(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x30233C0", Offset = "0x3021DC0", VA = "0x1830233C0", Slot = "17")]
	protected override EntityQueryDesc FLFKHDOCMLI(EntityQueryDesc ANBHGOBNOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x3023480", Offset = "0x3021E80", VA = "0x183023480")]
	public JGFKCHEFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x3023440", Offset = "0x3021E40", VA = "0x183023440", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x25AB380", Offset = "0x25A9D80", VA = "0x1825AB380", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2871830", Offset = "0x2870230", VA = "0x182871830", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2FCCC60", Offset = "0x2FCB660", VA = "0x182FCCC60")]
			private int PMCIBNMJNOM(DynamicBuffer<ChildrenData> BOGHIFKGACA, Entity LCLDFKAJPDK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x2FCC9A0", Offset = "0x2FCB3A0", VA = "0x182FCC9A0")]
			private void MDDBLDBDKFE(Entity GGEKFPEBLKN, DynamicBuffer<ChildrenData> BOGHIFKGACA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x2FCC870", Offset = "0x2FCB270", VA = "0x182FCC870")]
			private void FIKMLAEALOE(Entity GGEKFPEBLKN, DynamicBuffer<ChildrenData> BOGHIFKGACA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x2FCC5E0", Offset = "0x2FCAFE0", VA = "0x182FCC5E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x287F3E0", Offset = "0x287DDE0", VA = "0x18287F3E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2649AA0", Offset = "0x26484A0", VA = "0x182649AA0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x2649850", Offset = "0x2648250", VA = "0x182649850")]
		private int PMCIBNMJNOM(DynamicBuffer<ChildrenData> BOGHIFKGACA, Entity LCLDFKAJPDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2648C70", Offset = "0x2647670", VA = "0x182648C70")]
		private void MNMNNJLPJJK(Entity FEJPDMGONFP, Entity EHPDOFEPKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x7BC300", Offset = "0x7BAD00", VA = "0x1807BC300", Slot = "14")]
		protected virtual EntityQueryDesc AJBCBAODHIH(EntityQueryDesc ANBHGOBNOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x7BC300", Offset = "0x7BAD00", VA = "0x1807BC300", Slot = "15")]
		protected virtual EntityQueryDesc OJLONFAPHKN(EntityQueryDesc ANBHGOBNOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x7BC300", Offset = "0x7BAD00", VA = "0x1807BC300", Slot = "16")]
		protected virtual EntityQueryDesc GJLPABAIIHN(EntityQueryDesc ANBHGOBNOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc FLFKHDOCMLI(EntityQueryDesc ANBHGOBNOFE);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x2649070", Offset = "0x2647A70", VA = "0x182649070", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x2648970", Offset = "0x2647370", VA = "0x182648970")]
		private void GKMOGHOPELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x26493E0", Offset = "0x2647DE0", VA = "0x1826493E0")]
		private void PFDBMOCKNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x2647950", Offset = "0x2646350", VA = "0x182647950")]
		private JobHandle BLCPNIIPEFG(JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2648690", Offset = "0x2647090", VA = "0x182648690")]
		private void DDLDEENGCJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2649310", Offset = "0x2647D10", VA = "0x182649310", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2358590", Offset = "0x2356F90", VA = "0x182358590", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x225B720", Offset = "0x225A120", VA = "0x18225B720", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4518470", Offset = "0x4516E70", VA = "0x184518470")]
		public BCCFLHCLHEK(NativeList<Entity> AGJHBEGCBBM, NativeList<Entity> DALNPIMPKCG, JobHandle DNPFDFHMBNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x45183F0", Offset = "0x4516DF0", VA = "0x1845183F0")]
		public JobHandle KNACJPGANJJ(JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x4518360", Offset = "0x4516D60", VA = "0x184518360", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x451ECB0", Offset = "0x451D6B0", VA = "0x18451ECB0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x451EC20", Offset = "0x451D620", VA = "0x18451EC20")]
		private void EFPOEHDJHKK(Entity LCLDFKAJPDK, bool IHPGPKBBPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x451EEC0", Offset = "0x451D8C0", VA = "0x18451EEC0")]
		private void JBBHFLCOHIG(Entity LCLDFKAJPDK, bool IHPGPKBBPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x451EFD0", Offset = "0x451D9D0", VA = "0x18451EFD0")]
		public BCCFLHCLHEK JHPMKCHOCGF(NativeArray<Entity> NNDAPMCFFMN, JobHandle ELLADMEAHLJ)
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x451EE40", Offset = "0x451D840", VA = "0x18451EE40")]
		public BCCFLHCLHEK IAFGFHMGFBJ(NativeArray<Entity> NNDAPMCFFMN, JobHandle ELLADMEAHLJ)
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x451F050", Offset = "0x451DA50", VA = "0x18451F050")]
		public BCCFLHCLHEK JNEFHBLADBC(NativeList<LBCACEFDDPD> BDHPAGCMKHB, JobHandle ELLADMEAHLJ)
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x451F470", Offset = "0x451DE70", VA = "0x18451F470")]
		public BCCFLHCLHEK NEOAKIJNFNB(NativeList<LBCACEFDDPD> BDHPAGCMKHB, JobHandle ELLADMEAHLJ)
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x451F390", Offset = "0x451DD90", VA = "0x18451F390")]
		public BCCFLHCLHEK LOFAGKJHFGI(NativeList<EBCGMCIBBDB> BDHPAGCMKHB, JobHandle ELLADMEAHLJ)
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x2E89500", Offset = "0x2E87F00", VA = "0x182E89500")]
		private BCCFLHCLHEK LHFHFEJFHPJ<T>(NativeList<T> BDHPAGCMKHB, int IMJIIGINGEP, int GJGJMGODAOO, GJKDPEMNOGO FLAGJIBPLNC, JobHandle ELLADMEAHLJ) where T : struct
		{
			return default(BCCFLHCLHEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x451F130", Offset = "0x451DB30", VA = "0x18451F130")]
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
	[Cpp2IlInjected.Address(RVA = "0x30200F0", Offset = "0x301EAF0", VA = "0x1830200F0")]
	protected IMFEAONBJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x301ED20", Offset = "0x301D720", VA = "0x18301ED20", Slot = "14")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x301EFC0", Offset = "0x301D9C0", VA = "0x18301EFC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x301F1F0", Offset = "0x301DBF0", VA = "0x18301F1F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x999C30", Offset = "0x998630", VA = "0x180999C30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x301ECC0", Offset = "0x301D6C0", VA = "0x18301ECC0")]
	private void DMKHFPCIBKG(NativeArray<Entity> BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x301EC20", Offset = "0x301D620", VA = "0x18301EC20")]
	private void BIOIJCJDDPA(NativeArray<Entity> BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x301E890", Offset = "0x301D290", VA = "0x18301E890")]
	private void AACILMDKMCM(BCCFLHCLHEK LACFMNHKMPJ, string OECHCNGOMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x301E780", Offset = "0x301D180", VA = "0x18301E780")]
	private void AACILMDKMCM(NativeListAsync<Entity> JPIPAGGDBKP, string OECHCNGOMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x301EAE0", Offset = "0x301D4E0", VA = "0x18301EAE0")]
	private void AFFMMGKCEHO(BCCFLHCLHEK LACFMNHKMPJ, string OECHCNGOMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x301E9D0", Offset = "0x301D3D0", VA = "0x18301E9D0")]
	private void AFFMMGKCEHO(NativeListAsync<Entity> JPIPAGGDBKP, string OECHCNGOMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x301EEB0", Offset = "0x301D8B0", VA = "0x18301EEB0")]
	private bool NDDMDJOBHLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public BKKHNOAFDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x451B950", Offset = "0x451A350", VA = "0x18451B950")]
			public void KMHCJEDMEHN(JFBMPKEDBGA LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x451B960", Offset = "0x451A360", VA = "0x18451B960")]
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
		[Cpp2IlInjected.Address(RVA = "0x451D2D0", Offset = "0x451BCD0", VA = "0x18451D2D0")]
		internal void JACNCLCPMJH(Entity CCICIDAGDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C850", Offset = "0x2D7B250", VA = "0x182D7C850", Slot = "5")]
		public void ReadFromDisplayClass(ref BKKHNOAFDFN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C880", Offset = "0x2D7B280", VA = "0x182D7C880", Slot = "6")]
		public void WriteToDisplayClass(ref BKKHNOAFDFN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x451D210", Offset = "0x451BC10", VA = "0x18451D210", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x451D420", Offset = "0x451BE20", VA = "0x18451D420")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref IJFKDHPHNGE.ACJCCODAALN MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x451D3E0", Offset = "0x451BDE0", VA = "0x18451D3E0")]
		public void KMHCJEDMEHN(JFBMPKEDBGA LFKHFKIBGCJ, ref BKKHNOAFDFN LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x451D260", Offset = "0x451BC60", VA = "0x18451D260")]
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
	[Cpp2IlInjected.Address(RVA = "0x30231D0", Offset = "0x3021BD0", VA = "0x1830231D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x3023090", Offset = "0x3021A90", VA = "0x183023090", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x3023230", Offset = "0x3021C30", VA = "0x183023230", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public JFBMPKEDBGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x30230F0", Offset = "0x3021AF0", VA = "0x1830230F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x3022EC0", Offset = "0x30218C0", VA = "0x183022EC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3012480", Offset = "0x3010E80", VA = "0x183012480", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x30124F0", Offset = "0x3010EF0", VA = "0x1830124F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x3012590", Offset = "0x3010F90", VA = "0x183012590", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public GEJKCANKGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0")]
	public static BLJIGMNCCHF HPHCHABBDNG(in CMKEFKIFPMD PGGLNMCAEIC)
	{
		return default(BLJIGMNCCHF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x30274D0", Offset = "0x3025ED0", VA = "0x1830274D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740")]
	public KPNGJMMLELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public KDFPIDMGHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x45200E0", Offset = "0x451EAE0", VA = "0x1845200E0")]
			public void KMHCJEDMEHN(EIBDKJJIMPG LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x4520140", Offset = "0x451EB40", VA = "0x184520140")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D7C660", Offset = "0x2D7B060", VA = "0x182D7C660")]
		internal void JACNCLCPMJH(Entity CCICIDAGDNF, BLJIGMNCCHF EBGAMGGEFDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C850", Offset = "0x2D7B250", VA = "0x182D7C850", Slot = "5")]
		public void ReadFromDisplayClass(ref KDFPIDMGHGG LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C880", Offset = "0x2D7B280", VA = "0x182D7C880", Slot = "6")]
		public void WriteToDisplayClass(ref KDFPIDMGHGG LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C580", Offset = "0x2D7AF80", VA = "0x182D7C580", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C7A0", Offset = "0x2D7B1A0", VA = "0x182D7C7A0")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref OIKOACLLPHK.KNFILCOFLHK MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C760", Offset = "0x2D7B160", VA = "0x182D7C760")]
		public void KMHCJEDMEHN(EIBDKJJIMPG LFKHFKIBGCJ, ref KDFPIDMGHGG LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C5F0", Offset = "0x2D7AFF0", VA = "0x182D7C5F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3215B90", Offset = "0x3214590", VA = "0x183215B90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x3215880", Offset = "0x3214280", VA = "0x183215880", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x3215BF0", Offset = "0x32145F0", VA = "0x183215BF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public EIBDKJJIMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x3215AB0", Offset = "0x32144B0", VA = "0x183215AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x32158E0", Offset = "0x32142E0", VA = "0x1832158E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x451AF40", Offset = "0x4519940", VA = "0x18451AF40")]
			public HMPAMAPJMNM(int IPADGNLNKOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x451AEC0", Offset = "0x45198C0", VA = "0x18451AEC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x45195C0", Offset = "0x4517FC0", VA = "0x1845195C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x451DA90", Offset = "0x451C490", VA = "0x18451DA90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3DD70", Offset = "0x2B3C770", VA = "0x182B3DD70", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E5D0", Offset = "0x2B3CFD0", VA = "0x182B3E5D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DDD0", Offset = "0x2B3C7D0", VA = "0x182B3DDD0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E890", Offset = "0x2B3D290", VA = "0x182B3E890", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E100", Offset = "0x2B3CB00", VA = "0x182B3E100")]
		private void KPIGFBDCMID(EntityQuery ANBHGOBNOFE, out (NativeArrayAsync<BLJIGMNCCHF> handles, NativeArrayAsync<CNEHLCBOJKB> bounds) HIDEHJGLNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E240", Offset = "0x2B3CC40", VA = "0x182B3E240")]
		private void MGNKCPCFKEH((NativeArrayAsync<BLJIGMNCCHF> handles, NativeArrayAsync<CNEHLCBOJKB> bounds) HIDEHJGLNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DDD0", Offset = "0x2B3C7D0", VA = "0x182B3DDD0")]
		private void GAPAHLBLDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DAD0", Offset = "0x2B3C4D0", VA = "0x182B3DAD0")]
		private void COCOGMCAIHN(EntityQuery ANBHGOBNOFE, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<BLJIGMNCCHF> handles) HIDEHJGLNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DE10", Offset = "0x2B3C810", VA = "0x182B3DE10")]
		private void IHJOKKAELNM((NativeArrayAsync<Entity> entities, NativeArrayAsync<BLJIGMNCCHF> handles) HIDEHJGLNHO, HMPAMAPJMNM CPLDDCNHBMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DC10", Offset = "0x2B3C610", VA = "0x182B3DC10")]
		private JobHandle EGCABOFJJEO(HMPAMAPJMNM CPLDDCNHBMK, ComponentDataFromEntity<WorldPoseData> BLOPEONEHFC, ComponentDataFromEntity<WorldUniformScaleData> PDIMBINENIO, ComponentDataFromEntity<WorldDeformableScaleData> MEEEGALMKOM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E4A0", Offset = "0x2B3CEA0", VA = "0x182B3E4A0")]
		private JobHandle OJHLLNJIFGB(HMPAMAPJMNM CPLDDCNHBMK, ComponentDataFromEntity<WorldPoseData> BLOPEONEHFC, ComponentDataFromEntity<WorldUniformScaleData> PDIMBINENIO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x451FAD0", Offset = "0x451E4D0", VA = "0x18451FAD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x451E6E0", Offset = "0x451D0E0", VA = "0x18451E6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D85DA0", Offset = "0x2D847A0", VA = "0x182D85DA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2D85FB0", Offset = "0x2D849B0", VA = "0x182D85FB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2D866B0", Offset = "0x2D850B0", VA = "0x182D866B0")]
		private JobHandle PBAOLCJOOBO(NativeArrayAsync<Entity> BGAKDGCGOMH, int OEMPOIHBNFL, JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2D864D0", Offset = "0x2D84ED0", VA = "0x182D864D0")]
		private JobHandle PBAOLCJOOBO(NativeArray<Entity> EEDADAHMOAC, int OEMPOIHBNFL, [Optional] JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x2D85D20", Offset = "0x2D84720", VA = "0x182D85D20")]
		private NativeArrayAsync<Entity> GKLEPMBLOBK(EntityQuery ANBHGOBNOFE)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x2D855A0", Offset = "0x2D83FA0", VA = "0x182D855A0")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) BBNIODDBAPF(NativeArrayAsync<Entity> BKEINAHPOBL)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x2D85510", Offset = "0x2D83F10", VA = "0x182D85510")]
		private void AMMLAPDPDIB(out NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x2D85480", Offset = "0x2D83E80", VA = "0x182D85480")]
		private void AEGALBBHMGP(NativeList<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2D853B0", Offset = "0x2D83DB0", VA = "0x182D853B0")]
		private void AEGALBBHMGP(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2D86790", Offset = "0x2D85190", VA = "0x182D86790")]
		private void PDPGMHIANFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		private static void AHMIOJLCNCH(int MHOKPBNHDDK, int DBIMGDEHOGC, int AJLFMJHNOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x2D859F0", Offset = "0x2D843F0", VA = "0x182D859F0")]
		private static CNEHLCBOJKB DFEPMIEPNBD(NativeArray<Entity> BLAOODBKMOD, ComponentDataFromEntity<SplinePointPositionData> LJFJJMNEOOD, ComponentDataFromEntity<SplinePointScaleData> EHCANGIBCCL)
		{
			return default(CNEHLCBOJKB);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3213AB0", Offset = "0x32124B0", VA = "0x183213AB0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x3213A00", Offset = "0x3212400", VA = "0x183213A00")]
		public bool BEJIAFMNDPH(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x3213F80", Offset = "0x3212980", VA = "0x183213F80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x3213F40", Offset = "0x3212940", VA = "0x183213F40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x32140B0", Offset = "0x3212AB0", VA = "0x1832140B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x19D16A0", Offset = "0x19D00A0", VA = "0x1819D16A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x3213F40", Offset = "0x3212940", VA = "0x183213F40")]
		private void MCDBHPJONPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x3213C60", Offset = "0x3212660", VA = "0x183213C60")]
		private void HBELFKCBMLE(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x3213B20", Offset = "0x3212520", VA = "0x183213B20")]
		private void GEBGICBGKAO(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x3213D10", Offset = "0x3212710", VA = "0x183213D10")]
		private void HICCDFAGLMP(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x3213E20", Offset = "0x3212820", VA = "0x183213E20")]
		private void LMIMAEBKDAA(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x300C220", Offset = "0x300AC20", VA = "0x18300C220", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x300C860", Offset = "0x300B260", VA = "0x18300C860", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x300C2D0", Offset = "0x300ACD0", VA = "0x18300C2D0")]
		private void JIIDDDBGOPD(IECIGCFEBBH HJGAFKLFBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		private void KAKCHCJLHDE(Entity LCLDFKAJPDK, KHMECMDAALD HBKLDKCICEJ, ANIKAMAEHJJ HDLEMAAGOPN, CBFIIKBAJEL CKNLGGBDBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B449C0", Offset = "0x2B433C0", VA = "0x182B449C0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B44A50", Offset = "0x2B43450", VA = "0x182B44A50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D8D7A0", Offset = "0x2D8C1A0", VA = "0x182D8D7A0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D7F0", Offset = "0x2D8C1F0", VA = "0x182D8D7F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D79850", Offset = "0x2D78250", VA = "0x182D79850", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3204A30", Offset = "0x3203430", VA = "0x183204A30", Slot = "14")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x3204A40", Offset = "0x3203440", VA = "0x183204A40", Slot = "15")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x3204E80", Offset = "0x3203880", VA = "0x183204E80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x3204FD0", Offset = "0x32039D0", VA = "0x183204FD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x3204AD0", Offset = "0x32034D0", VA = "0x183204AD0")]
		private bool GLDNOODBCGF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x3204B40", Offset = "0x3203540", VA = "0x183204B40")]
		private void HOBJJEKJEKN(EntityQuery ANBHGOBNOFE, float3 MKKFMGKLFLF, string AMNLGEBHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B41420", Offset = "0x2B3FE20", VA = "0x182B41420", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B41470", Offset = "0x2B3FE70", VA = "0x182B41470", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D942B0", Offset = "0x2D92CB0", VA = "0x182D942B0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D94320", Offset = "0x2D92D20", VA = "0x182D94320", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D943B0", Offset = "0x2D92DB0", VA = "0x182D943B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x300AEF0", Offset = "0x30098F0", VA = "0x18300AEF0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x300B7D0", Offset = "0x300A1D0", VA = "0x18300B7D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x300B540", Offset = "0x3009F40", VA = "0x18300B540")]
		private void NNDLOHAOMID(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> BDHPAGCMKHB, EntityQueryDesc FIKHDCDGJAH, bool HKPNCKPHHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x300B650", Offset = "0x300A050", VA = "0x18300B650")]
		private void NNDLOHAOMID(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> BDHPAGCMKHB, EntityQueryDesc FIKHDCDGJAH, bool HKPNCKPHHLB, bool GCAABCBBBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x300BA30", Offset = "0x300A430", VA = "0x18300BA30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x300BF10", Offset = "0x300A910", VA = "0x18300BF10")]
		private void PKFLOCAHJCK(EntityQuery ANBHGOBNOFE, bool AOBLOMCJEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x300BD00", Offset = "0x300A700", VA = "0x18300BD00")]
		private void PJHFAPEGHGG(EntityQuery ANBHGOBNOFE, bool FPFOJOEOBCC, bool AOBLOMCJEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x300B320", Offset = "0x3009D20", VA = "0x18300B320")]
		private void KBOILNBEFIK(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x300AD80", Offset = "0x3009780", VA = "0x18300AD80")]
		private void COIAIKENNBF(NativeList<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x300AC60", Offset = "0x3009660", VA = "0x18300AC60")]
		private void BANLJKLFCEJ(NativeArray<Entity> ABBIPALBHCK, bool FPFOJOEOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x300B120", Offset = "0x3009B20", VA = "0x18300B120")]
		private NativeList<Entity> IKKMHDKJPLG(NativeArray<Entity> ABBIPALBHCK)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x300B790", Offset = "0x300A190", VA = "0x18300B790")]
		private NativeList<Entity> ONHONCKJMHC(NativeArray<Entity> ABBIPALBHCK)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x300AF40", Offset = "0x3009940", VA = "0x18300AF40")]
		private NativeList<Entity> IADGBFLEJIF(NativeArray<Entity> ABBIPALBHCK)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x300AF80", Offset = "0x3009980", VA = "0x18300AF80")]
		private NativeList<Entity> IBPDGLAOPGP(NativeArray<Entity> ABBIPALBHCK, bool JLGKAHIIONN)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x300ABD0", Offset = "0x30095D0", VA = "0x18300ABD0")]
		private INIIDGJPOCP APKNAMIOHAO(NativeArray<Entity> ABBIPALBHCK)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(INIIDGJPOCP);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x300C150", Offset = "0x300AB50", VA = "0x18300C150")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B41490", Offset = "0x2B3FE90", VA = "0x182B41490", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B414E0", Offset = "0x2B3FEE0", VA = "0x182B414E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3213670", Offset = "0x3212070", VA = "0x183213670", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x3213830", Offset = "0x3212230", VA = "0x183213830", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x32131F0", Offset = "0x3211BF0", VA = "0x1832131F0")]
		private void CMNGGPGFOEN(EntityQuery ANBHGOBNOFE, bool PBEMIFAFADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x3213430", Offset = "0x3211E30", VA = "0x183213430")]
		private void DOOAIAGCBFD(EntityQuery ANBHGOBNOFE, bool PBEMIFAFADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x31FC0A0", Offset = "0x31FAAA0", VA = "0x1831FC0A0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x31FC960", Offset = "0x31FB360", VA = "0x1831FC960", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x31FCA70", Offset = "0x31FB470", VA = "0x1831FCA70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x31FC600", Offset = "0x31FB000", VA = "0x1831FC600")]
		private void LDIKLPEIDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x31FC110", Offset = "0x31FAB10", VA = "0x1831FC110")]
		private void HMODCOFHGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x31FC2E0", Offset = "0x31FACE0", VA = "0x1831FC2E0")]
		private void KOEJKGOEEDM(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x31FC820", Offset = "0x31FB220", VA = "0x1831FC820")]
		private void NDGIGJIBDPE(NativeArray<Entity> ABBIPALBHCK, int AACCOCAILJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x31FC710", Offset = "0x31FB110", VA = "0x1831FC710")]
		private void MKMCGGEACJD(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x31FC280", Offset = "0x31FAC80", VA = "0x1831FC280")]
		private void IHBJKCKLNML(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		private static void LHHAOAIOLLK(int ENNAKHLEBJN, Transform CACALPHNCBH, Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class IDGMKDENIPD
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x3019D20", Offset = "0x3018720", VA = "0x183019D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x3206B20", Offset = "0x3205520", VA = "0x183206B20", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x3206B70", Offset = "0x3205570", VA = "0x183206B70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x3206C30", Offset = "0x3205630", VA = "0x183206C30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B26470", Offset = "0x2B24E70", VA = "0x182B26470")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x2B26410", Offset = "0x2B24E10", VA = "0x182B26410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity LAOOOAJFNIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x2B264D0", Offset = "0x2B24ED0", VA = "0x182B264D0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public MBEDCJLMHEO JGPDOBJLKHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x2B26530", Offset = "0x2B24F30", VA = "0x182B26530")]
			get
			{
				return default(MBEDCJLMHEO);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x2B26800", Offset = "0x2B25200", VA = "0x182B26800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public MBEDCJLMHEO MDDFNIPLHDH
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x2B26260", Offset = "0x2B24C60", VA = "0x182B26260")]
			get
			{
				return default(MBEDCJLMHEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x2B266E0", Offset = "0x2B250E0", VA = "0x182B266E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x2B26320", Offset = "0x2B24D20", VA = "0x182B26320", Slot = "15")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x2B26780", Offset = "0x2B25180", VA = "0x182B26780", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x2B25E50", Offset = "0x2B24850", VA = "0x182B25E50", Slot = "14")]
		protected override void AIIANEBGMBI(NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> BFCOFODCAGL, NativeArray<Entity> AGLEENNCIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2B265C0", Offset = "0x2B24FC0", VA = "0x182B265C0")]
		private void OAHIGPGAAHG(NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> AGLEENNCIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2B25FA0", Offset = "0x2B249A0", VA = "0x182B25FA0")]
		private void CIIPGPLFMDM(Entity LCLDFKAJPDK, Entity BHICEBOIFIN, Entity IIHIMCBGDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x366CF10", Offset = "0x366B910", VA = "0x18366CF10")]
		private bool OBCGBBDEENH<T>(out T LPJDDLMPNCG) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x366CE50", Offset = "0x366B850", VA = "0x18366CE50")]
		private void NFPBPFFPICN<T>(T LPJDDLMPNCG) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2B26390", Offset = "0x2B24D90", VA = "0x182B26390")]
		public bool GCAKJKBOGHP(MBEDCJLMHEO AHKCJNCACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2B262F0", Offset = "0x2B24CF0", VA = "0x182B262F0")]
		private static bool EEGPGHNGBOP(MBEDCJLMHEO CLLGFHPMKMI, MBEDCJLMHEO IAJNOLPBJLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2B268C0", Offset = "0x2B252C0", VA = "0x182B268C0")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2B266A0", Offset = "0x2B250A0", VA = "0x182B266A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x320F120", Offset = "0x320DB20", VA = "0x18320F120", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x320F170", Offset = "0x320DB70", VA = "0x18320F170", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x320F210", Offset = "0x320DC10", VA = "0x18320F210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x320EFD0", Offset = "0x320D9D0", VA = "0x18320EFD0")]
		private NativeArray<Entity> CEHHALOGAPJ(int EJMNNLNLAFJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x320EEC0", Offset = "0x320D8C0", VA = "0x18320EEC0")]
		private void BPLIHAGPMGL(NativeArray<Entity> IAOKKFHHHBO, NativeArray<Entity> LJBLHPIOCMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3017420", Offset = "0x3015E20", VA = "0x183017420", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x3017510", Offset = "0x3015F10", VA = "0x183017510", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x259A380", Offset = "0x2598D80", VA = "0x18259A380")]
	public static NativeArray<T> LHFHFEJFHPJ<T>(NativeArray<Entity> ABBIPALBHCK, EntityManager MABCFMECCKD) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x30120F0", Offset = "0x3010AF0", VA = "0x1830120F0")]
	public static void DBBBNELOAIL(EntityQuery ANBHGOBNOFE, EntityManager MABCFMECCKD, DDOLHFHMLOP CGCNGCLEGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x3012230", Offset = "0x3010C30", VA = "0x183012230")]
	public static void NALLNOKALJL(NativeArray<Entity> IAOKKFHHHBO, DDOLHFHMLOP CGCNGCLEGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x3011FC0", Offset = "0x30109C0", VA = "0x183011FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D92BB0", Offset = "0x2D915B0", VA = "0x182D92BB0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2D941B0", Offset = "0x2D92BB0", VA = "0x182D941B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2D94250", Offset = "0x2D92C50", VA = "0x182D94250", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2D939A0", Offset = "0x2D923A0", VA = "0x182D939A0")]
		private void KMNGHEPDPHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2D92AA0", Offset = "0x2D914A0", VA = "0x182D92AA0")]
		private void ECGKALCIHJD(NativeArray<Entity> IAOKKFHHHBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2D92C40", Offset = "0x2D91640", VA = "0x182D92C40")]
		private void FNBBDNOKBLM(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2D92850", Offset = "0x2D91250", VA = "0x182D92850")]
		private void CHKCHJDEEJP(NativeArray<Entity> LJBLHPIOCMG, NativeArray<RigidTransform> KEPFCGGNCDG, NativeArray<RigidTransform> PKEPOCGFOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x2D93510", Offset = "0x2D91F10", VA = "0x182D93510")]
		private void GPLHEEJMOEK(NativeArray<RigidTransform> PKEPOCGFOCE, NativeArray<Entity> LJBLHPIOCMG, NativeList<Entity> KHEODJCPNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3FA30", Offset = "0x2B3E430", VA = "0x182B3FA30", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FAA0", Offset = "0x2B3E4A0", VA = "0x182B3FAA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FBF0", Offset = "0x2B3E5F0", VA = "0x182B3FBF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F9C0", Offset = "0x2B3E3C0", VA = "0x182B3F9C0")]
		private void EMHNIKBGLPN(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B41290", Offset = "0x2B3FC90", VA = "0x182B41290", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2B41320", Offset = "0x2B3FD20", VA = "0x182B41320", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2B413C0", Offset = "0x2B3FDC0", VA = "0x182B413C0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x2B41100", Offset = "0x2B3FB00", VA = "0x182B41100")]
		private void CGOOCKPINID(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D7E480", Offset = "0x2D7CE80", VA = "0x182D7E480", Slot = "14")]
		protected override void AIIANEBGMBI(NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> BFCOFODCAGL, NativeArray<Entity> AGLEENNCIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E5D0", Offset = "0x2D7CFD0", VA = "0x182D7E5D0")]
		[BurstCompile]
		private static void AIIANEBGMBI(NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> AGLEENNCIPN, ComponentDataFromEntity<global::CDKPNOKKLBK> CNADBBPDFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E6E0", Offset = "0x2D7D0E0", VA = "0x182D7E6E0")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E6A0", Offset = "0x2D7D0A0", VA = "0x182D7E6A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3653720", Offset = "0x3652120", VA = "0x183653720", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x3653920", Offset = "0x3652320", VA = "0x183653920", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x36538F0", Offset = "0x36522F0", VA = "0x1836538F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x3652930", Offset = "0x3651330", VA = "0x183652930")]
		private void AJMFKJCFPCL(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x3652D70", Offset = "0x3651770", VA = "0x183652D70")]
		private void CJHMKOKFKPI(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x36520A0", Offset = "0x3650AA0", VA = "0x1836520A0")]
		private void ABMPGMIIJPI(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void AIIANEBGMBI(NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> BFCOFODCAGL, NativeArray<Entity> AGLEENNCIPN);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x2881A90", Offset = "0x2880490", VA = "0x182881A90")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x225B720", Offset = "0x225A120", VA = "0x18225B720", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3020130", Offset = "0x301EB30", VA = "0x183020130", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x3020330", Offset = "0x301ED30", VA = "0x183020330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x3020480", Offset = "0x301EE80", VA = "0x183020480")]
	public INBPEPEPNJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B26A60", Offset = "0x2B25460", VA = "0x182B26A60")]
	public static Entity HPHCHABBDNG(MBHJMBGECFD HIDEHJGLNHO)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x2B26A60", Offset = "0x2B25460", VA = "0x182B26A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x301CC20", Offset = "0x301B620", VA = "0x18301CC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x301CDD0", Offset = "0x301B7D0", VA = "0x18301CDD0")]
	public IGNMPNCMIDA(ComponentType KCEEKGALKFC, NativeList<int> JDFBPHJNCCJ, NativeList<int> EIDHOHCPCDL, NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> KKBMAODLFPI, NativeArray<byte> CHHFOFIKHKL, NativeArray<byte> IECLCEDGDAE, int LPECOOCMGPK, int NIFIKABPPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x301CCA0", Offset = "0x301B6A0", VA = "0x18301CCA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x301CAA0", Offset = "0x301B4A0", VA = "0x18301CAA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x301CBD0", Offset = "0x301B5D0", VA = "0x18301CBD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x301CAF0", Offset = "0x301B4F0", VA = "0x18301CAF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B25800", Offset = "0x2B24200", VA = "0x182B25800")]
	public LHKPICCFKEL(ComponentType KCEEKGALKFC, int LPECOOCMGPK, int NIFIKABPPCH, EntityQuery ANBHGOBNOFE, NativeArray<GKBBNJFKKEL> FNBGFGCHFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x2B257B0", Offset = "0x2B241B0", VA = "0x182B257B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x731A30", Offset = "0x730430", VA = "0x180731A30")]
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
	[Cpp2IlInjected.Address(RVA = "0x731A30", Offset = "0x730430", VA = "0x180731A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3201550", Offset = "0x31FFF50", VA = "0x183201550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public AHKPLOLMABO IKLMOKJELML
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C14C0", VA = "0x1807C2AC0")]
		get
		{
			return default(AHKPLOLMABO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x3201560", Offset = "0x31FFF60", VA = "0x183201560")]
	public HAMGOKKMMPI FHIIKIODOHE(Type OGILDIMGIOH)
	{
		return default(HAMGOKKMMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x3201650", Offset = "0x3200050", VA = "0x183201650")]
	public HAMGOKKMMPI HCDJDJNOCCF(Type OGILDIMGIOH)
	{
		return default(HAMGOKKMMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E090", Offset = "0x1F7CA90", VA = "0x181F7E090")]
	public T FHIIKIODOHE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E0B0", Offset = "0x1F7CAB0", VA = "0x181F7E0B0")]
	public T HCDJDJNOCCF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x3201740", Offset = "0x3200140", VA = "0x183201740")]
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
	[Cpp2IlInjected.Address(RVA = "0x3025420", Offset = "0x3023E20", VA = "0x183025420", Slot = "17")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x3025470", Offset = "0x3023E70", VA = "0x183025470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x30251E0", Offset = "0x3023BE0", VA = "0x1830251E0", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	protected KAADPHHJBDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2A260", Offset = "0x2B28C60", VA = "0x182B2A260")]
		get
		{
			return default(LHKPICCFKEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A750", Offset = "0x2B29150", VA = "0x182B2A750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x2B2ACE0", Offset = "0x2B296E0", VA = "0x182B2ACE0")]
	public NOBLONKDMFK(BHHDNNCMGLM GHDOFHADNOC, KLBHBMBPLOA JFFPIFJCILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A2F0", Offset = "0x2B28CF0", VA = "0x182B2A2F0")]
	public bool DJKANKJNGBD(ComponentType KCEEKGALKFC, out LHKPICCFKEL COEEJIEMCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A850", Offset = "0x2B29250", VA = "0x182B2A850")]
	public Dictionary<ComponentType, LHKPICCFKEL>.Enumerator OKFDNCHLPHK()
	{
		return default(Dictionary<ComponentType, LHKPICCFKEL>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A360", Offset = "0x2B28D60", VA = "0x182B2A360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A8E0", Offset = "0x2B292E0", VA = "0x182B2A8E0")]
	private void PPFJDIAPFKL(IEnumerable<HOOPFMCFMDE> IAPHJIOPDJO, EntityManager MABCFMECCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A7A0", Offset = "0x2B291A0", VA = "0x182B2A7A0")]
	private static int KAFNFDJEMFD(HOOPFMCFMDE BILIICLNGJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A500", Offset = "0x2B28F00", VA = "0x182B2A500")]
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
			[Cpp2IlInjected.Address(RVA = "0xCA5370", Offset = "0xCA3D70", VA = "0x180CA5370", Slot = "4")]
			get
			{
				return default(CBFIIKBAJEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A790", Offset = "0x2D79190", VA = "0x182D7A790", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A7E0", Offset = "0x2D791E0", VA = "0x182D7A7E0")]
		internal GHFLNGADFNO(NativeMultiHashMap<Entity, CBFIIKBAJEL> MCHKFDMHGLB, Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A550", Offset = "0x2D78F50", VA = "0x182D7A550", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A620", Offset = "0x2D79020", VA = "0x182D7A620")]
		public GHFLNGADFNO OKFDNCHLPHK()
		{
			return default(GHFLNGADFNO);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A650", Offset = "0x2D79050", VA = "0x182D7A650", Slot = "9")]
		private IEnumerator<CBFIIKBAJEL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A6F0", Offset = "0x2D790F0", VA = "0x182D7A6F0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3212E60", Offset = "0x3211860", VA = "0x183212E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x3212AD0", Offset = "0x32114D0", VA = "0x183212AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x2351650", Offset = "0x2350050", VA = "0x182351650")]
	public DLNMECKPKMF(IIEECLOJGND OJNFGJAPBNC, JobHandle NNDGCIEGNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x3212D20", Offset = "0x3211720", VA = "0x183212D20")]
	public bool GDNLBEAOCAH(Allocator FKHAEPDPDAI, out NativeKeyValueArrays<Entity, CBFIIKBAJEL> JGINNNKFHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x3212BB0", Offset = "0x32115B0", VA = "0x183212BB0")]
	public bool CAJPAIFJPHE(Allocator FKHAEPDPDAI, out (NativeArray<Entity> entities, int uniqueCount) JGINNNKFHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x3212F50", Offset = "0x3211950", VA = "0x183212F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x3013AC0", Offset = "0x30124C0", VA = "0x183013AC0")]
		get
		{
			return default(LHKPICCFKEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x3013CD0", Offset = "0x30126D0", VA = "0x183013CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x30140D0", Offset = "0x3012AD0", VA = "0x1830140D0")]
	public HAMGBPFOOHJ(NOBLONKDMFK AILOFIFIOME, BHHDNNCMGLM GHDOFHADNOC, KLBHBMBPLOA JFFPIFJCILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x3013D10", Offset = "0x3012710", VA = "0x183013D10")]
	public List<LHKPICCFKEL>.Enumerator OKFDNCHLPHK()
	{
		return default(List<LHKPICCFKEL>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x3013B50", Offset = "0x3012550", VA = "0x183013B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x3013D90", Offset = "0x3012790", VA = "0x183013D90")]
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
	[Cpp2IlInjected.Address(RVA = "0x301C8C0", Offset = "0x301B2C0", VA = "0x18301C8C0")]
	public IFJOIMFECNJ(ObjectInstantiationService IIPJHFKNDGJ, BHHDNNCMGLM GHDOFHADNOC, KLBHBMBPLOA JFFPIFJCILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x301B370", Offset = "0x3019D70", VA = "0x18301B370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x301C430", Offset = "0x301AE30", VA = "0x18301C430")]
	public bool LJBAPKMEOLK(GODNFBOIBNJ KLFAINNONJC, out Entity OPBBFNOFOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x301B440", Offset = "0x3019E40", VA = "0x18301B440")]
	private void GAOHHEODLEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x301BCE0", Offset = "0x301A6E0", VA = "0x18301BCE0")]
	private EntityArchetype HFDCFDHFBEL(EntityArchetype MPNBIOGEFCF)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x301C490", Offset = "0x301AE90", VA = "0x18301C490")]
	public static void PCDPNHDBPBD(EntityManager MENKGFBPIJM, EntityManager DLKHAOHFHOB, NativeArray<Entity> JILBKCFLHPF, NativeArray<EntityArchetype> NIIPLLMCLJE, [Optional] NativeArray<Entity> IIAJPNPCDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x301B050", Offset = "0x3019A50", VA = "0x18301B050")]
	[Conditional("DEBUG_BUILD")]
	private static void BCIOMPIOHHA(NativeArray<EntityArchetype> NOKEICPGEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x301BAA0", Offset = "0x301A4A0", VA = "0x18301BAA0")]
	private static string GIKBMFAGOAC(EntityArchetype NCPPLDKIKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x301C210", Offset = "0x301AC10", VA = "0x18301C210")]
	[CompilerGenerated]
	internal static void HGKFNOBMKEF(ref Span<ComponentType> OJBOAKGOJFN, ComponentType LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x301B1C0", Offset = "0x3019BC0", VA = "0x18301B1C0")]
	[CompilerGenerated]
	internal static void DEMKHLGIABF(Span<ComponentType> BGAKDGCGOMH, ref Span<ComponentType> OJBOAKGOJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x301C350", Offset = "0x301AD50", VA = "0x18301C350")]
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
		[Cpp2IlInjected.Address(RVA = "0x31FBF30", Offset = "0x31FA930", VA = "0x1831FBF30", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x31FBFF0", Offset = "0x31FA9F0", VA = "0x1831FBFF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D7CD70", Offset = "0x2D7B770", VA = "0x182D7CD70", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x2D7CEB0", Offset = "0x2D7B8B0", VA = "0x182D7CEB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D7B490", Offset = "0x2D79E90", VA = "0x182D7B490", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D79430", Offset = "0x2D77E30", VA = "0x182D79430", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D7B210", Offset = "0x2D79C10", VA = "0x182D7B210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3209500", Offset = "0x3207F00", VA = "0x183209500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private IIEECLOJGND FJJGKFADCDD
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x3208280", Offset = "0x3206C80", VA = "0x183208280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x32082A0", Offset = "0x3206CA0", VA = "0x1832082A0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "15")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x3209CA0", Offset = "0x32086A0", VA = "0x183209CA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x3209E60", Offset = "0x3208860", VA = "0x183209E60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x3209DF0", Offset = "0x32087F0", VA = "0x183209DF0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x3206E80", Offset = "0x3205880", VA = "0x183206E80")]
		private void BDDFDHBKPPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x3209320", Offset = "0x3207D20", VA = "0x183209320")]
		internal void IDIJPFOCBOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x3208B50", Offset = "0x3207550", VA = "0x183208B50")]
		private void IDIJPFOCBOK(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x32071F0", Offset = "0x3205BF0", VA = "0x1832071F0")]
		private void CEONFKHJOOK(NativeArray<Entity> JILBKCFLHPF, NativeArray<RRObjectPrefabData> EMBJJIPONBD, ref NativeArray<Entity> ODOKAALFGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x3208260", Offset = "0x3206C60", VA = "0x183208260")]
		internal void CPPGJLKJHAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x3207E60", Offset = "0x3206860", VA = "0x183207E60")]
		private void CPPGJLKJHAE(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x32083F0", Offset = "0x3206DF0", VA = "0x1832083F0")]
		internal void GNCLJJHPAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x32095C0", Offset = "0x3207FC0", VA = "0x1832095C0")]
		private void JPHHEOJGFNM(IIEECLOJGND OJNFGJAPBNC, LHKPICCFKEL OCNEBCDHANP, bool LMHNPCCHOCO, ref JobHandle ACNKHGAIBKH, ref JobHandle BKCDJAHDOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x3207E30", Offset = "0x3206830", VA = "0x183207E30")]
		internal bool CNGDPCKLLKJ(in LHKPICCFKEL AFCHMEJMNBE, out JobHandle IGELLPOEMHM, out IGNMPNCMIDA JDCHPBICAGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x3207430", Offset = "0x3205E30", VA = "0x183207430")]
		private bool CNGDPCKLLKJ(in LHKPICCFKEL AFCHMEJMNBE, bool LMHNPCCHOCO, out JobHandle IGELLPOEMHM, out IGNMPNCMIDA JDCHPBICAGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x3209340", Offset = "0x3207D40", VA = "0x183209340")]
		internal (NativeList<int>, NativeList<int>) ILABJGIGNIG(NativeList<FAEMGOHDEBA> LJLPNNBCCEF, int IPADGNLNKOB, JobHandle ELLADMEAHLJ, out JobHandle DNPFDFHMBNH, Allocator FKHAEPDPDAI = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x3207140", Offset = "0x3205B40", VA = "0x183207140")]
		internal static NativeArray<Entity> CEBHKFDCONB(EntityQuery ANBHGOBNOFE, out JobHandle CDOLDCAEBLK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x3209C20", Offset = "0x3208620", VA = "0x183209C20")]
		internal static NativeArray<byte> OICINKFKBEL(int EMIAMELGKNF, out JobHandle FDNADPEBPPO)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x32098A0", Offset = "0x32082A0", VA = "0x1832098A0")]
		internal static NativeArray<byte> KJCMNPGIMNP(EntityQuery ANBHGOBNOFE, int ODMCPPPIBBH, out JobHandle FDNADPEBPPO)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x32082F0", Offset = "0x3206CF0", VA = "0x1832082F0")]
		internal static NativeArray<Entity> GKLEPMBLOBK(EntityQuery ANBHGOBNOFE, out JobHandle IHJJIBIIDLN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x32099B0", Offset = "0x32083B0", VA = "0x1832099B0")]
		internal NativeArray<byte> LGAHHFHPDHP(NativeArray<Entity> ABBIPALBHCK, LHKPICCFKEL OCNEBCDHANP, JobHandle ELLADMEAHLJ, out JobHandle DNPFDFHMBNH, Allocator FKHAEPDPDAI = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x3206CF0", Offset = "0x32056F0", VA = "0x183206CF0")]
		internal JobHandle AHOGNABDEDL(in IGNMPNCMIDA HIDEHJGLNHO, in LHKPICCFKEL OCNEBCDHANP, NativeMultiHashMap<Entity, CBFIIKBAJEL> DIAFLBCAEMB, JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1684440", Offset = "0x1682E40", VA = "0x181684440")]
		private JobHandle DCHBNNMAEFD(JobHandle KMKICIADJJL, JobHandle IOLEGKJGFEA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1684440", Offset = "0x1682E40", VA = "0x181684440")]
		private JobHandle DCHBNNMAEFD(JobHandle KMKICIADJJL, JobHandle IOLEGKJGFEA, JobHandle BHPAAJNIHEK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B41CA0", Offset = "0x2B406A0", VA = "0x182B41CA0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType EPMEBHFHEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x2B41D00", Offset = "0x2B40700", VA = "0x182B41D00", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType HCFNJFHMEDN
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B41CD0", Offset = "0x2B406D0", VA = "0x182B41CD0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B41D30", Offset = "0x2B40730", VA = "0x182B41D30")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B41D40", Offset = "0x2B40740", VA = "0x182B41D40", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType EPMEBHFHEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x2B41DA0", Offset = "0x2B407A0", VA = "0x182B41DA0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType HCFNJFHMEDN
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x2B41D70", Offset = "0x2B40770", VA = "0x182B41D70", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B41D30", Offset = "0x2B40730", VA = "0x182B41D30")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3013170", Offset = "0x3011B70", VA = "0x183013170", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x3013200", Offset = "0x3011C00", VA = "0x183013200", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public GPLINALFPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public IEJMOIPJOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4522A10", Offset = "0x4521410", VA = "0x184522A10")]
			public void KMHCJEDMEHN(OBJCKFABAJI LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x4522A70", Offset = "0x4521470", VA = "0x184522A70")]
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
		[Cpp2IlInjected.Address(RVA = "0x45190B0", Offset = "0x4517AB0", VA = "0x1845190B0")]
		internal void JACNCLCPMJH(Entity LCLDFKAJPDK, SplinePointParentData JDJHGHDNLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x4519260", Offset = "0x4517C60", VA = "0x184519260", Slot = "5")]
		public void ReadFromDisplayClass(ref IEJMOIPJOGL LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x4519270", Offset = "0x4517C70", VA = "0x184519270", Slot = "6")]
		public void WriteToDisplayClass(ref IEJMOIPJOGL LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x4518FA0", Offset = "0x45179A0", VA = "0x184518FA0", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x45191B0", Offset = "0x4517BB0", VA = "0x1845191B0")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref PLALMAJACPD.NBANCJBMIHI MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x4519120", Offset = "0x4517B20", VA = "0x184519120")]
		public void KMHCJEDMEHN(OBJCKFABAJI LFKHFKIBGCJ, ref IEJMOIPJOGL LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x4519040", Offset = "0x4517A40", VA = "0x184519040")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B2B1E0", Offset = "0x2B29BE0", VA = "0x182B2B1E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public OBJCKFABAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x2B2AFB0", Offset = "0x2B299B0", VA = "0x182B2AFB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x2B2AE50", Offset = "0x2B29850", VA = "0x182B2AE50")]
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
	[Cpp2IlInjected.Address(RVA = "0x3010160", Offset = "0x300EB60", VA = "0x183010160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x30101F0", Offset = "0x300EBF0", VA = "0x1830101F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public FEPOMBPKHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(GPLINALFPNN))]
public class LBJDKKJAEHH : KHECDAFCLCI
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x2B25100", Offset = "0x2B23B00", VA = "0x182B25100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public LBJDKKJAEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public JMAHJJCKCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x451B970", Offset = "0x451A370", VA = "0x18451B970")]
			public void KMHCJEDMEHN(HKNNNHGIALJ LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x451B9D0", Offset = "0x451A3D0", VA = "0x18451B9D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4518670", Offset = "0x4517070", VA = "0x184518670")]
		internal void JACNCLCPMJH(Entity LCLDFKAJPDK, ObjectNetworkIdComponentData AHJABOIJHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x16805F0", Offset = "0x167EFF0", VA = "0x1816805F0", Slot = "5")]
		public void ReadFromDisplayClass(ref JMAHJJCKCEP LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x2289200", Offset = "0x2287C00", VA = "0x182289200", Slot = "6")]
		public void WriteToDisplayClass(ref JMAHJJCKCEP LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x4518560", Offset = "0x4516F60", VA = "0x184518560", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x4518780", Offset = "0x4517180", VA = "0x184518780")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref ILBBJCNDDGF.GIPFBBNJFDA MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x45186F0", Offset = "0x45170F0", VA = "0x1845186F0")]
		public void KMHCJEDMEHN(HKNNNHGIALJ LFKHFKIBGCJ, ref JMAHJJCKCEP LNLMJEFNJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x4518600", Offset = "0x4517000", VA = "0x184518600")]
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
	[Cpp2IlInjected.Address(RVA = "0x3016620", Offset = "0x3015020", VA = "0x183016620", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x30169E0", Offset = "0x30153E0", VA = "0x1830169E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public HKNNNHGIALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x30167E0", Offset = "0x30151E0", VA = "0x1830167E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x3016680", Offset = "0x3015080", VA = "0x183016680")]
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
			[Cpp2IlInjected.Address(RVA = "0x45189B0", Offset = "0x45173B0", VA = "0x1845189B0")]
			public void KMHCJEDMEHN(ANNMOPKLGEN LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x4518A10", Offset = "0x4517410", VA = "0x184518A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D79E90", Offset = "0x2D78890", VA = "0x182D79E90")]
		public void JACNCLCPMJH(Entity LCLDFKAJPDK, ParentData GMGPEPOBPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x2D79DB0", Offset = "0x2D787B0", VA = "0x182D79DB0", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x2D79EF0", Offset = "0x2D788F0", VA = "0x182D79EF0")]
		public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref CGCBGFEBNKC.LGNHGFIIFIN MCKDMOCNPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x2D79EB0", Offset = "0x2D788B0", VA = "0x182D79EB0")]
		public void KMHCJEDMEHN(ANNMOPKLGEN LFKHFKIBGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x2D79E20", Offset = "0x2D78820", VA = "0x182D79E20")]
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
	[Cpp2IlInjected.Address(RVA = "0x31FA990", Offset = "0x31F9390", VA = "0x1831FA990", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x31FAF40", Offset = "0x31F9940", VA = "0x1831FAF40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public ANNMOPKLGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x31FA9F0", Offset = "0x31F93F0", VA = "0x1831FA9F0")]
	[CompilerGenerated]
	private void LHDJPMBKDMA(Entity LCLDFKAJPDK, ParentData GMGPEPOBPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x31FAD40", Offset = "0x31F9740", VA = "0x1831FAD40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x31FABE0", Offset = "0x31F95E0", VA = "0x1831FABE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B3A880", Offset = "0x2B39280", VA = "0x182B3A880", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AC70", Offset = "0x2B39670", VA = "0x182B3AC70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AD50", Offset = "0x2B39750", VA = "0x182B3AD50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A8D0", Offset = "0x2B392D0", VA = "0x182B3A8D0")]
	private void HMMEMOBNCMI(Entity LCLDFKAJPDK, GODNFBOIBNJ KLFAINNONJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public PDIINLCNDBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3FD00", Offset = "0x2B3E700", VA = "0x182B3FD00", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FD50", Offset = "0x2B3E750", VA = "0x182B3FD50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
			public AIGBJEEFACO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x45173B0", Offset = "0x4515DB0", VA = "0x1845173B0")]
				public void KMHCJEDMEHN(PostLoadInitializeNetworkId LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x4517420", Offset = "0x4515E20", VA = "0x184517420")]
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
			[Cpp2IlInjected.Address(RVA = "0x4519E90", Offset = "0x4518890", VA = "0x184519E90")]
			internal void JACNCLCPMJH(Entity LCLDFKAJPDK, int AOIHDODPBAH, ref ObjectNetworkIdComponentData AHJABOIJHEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x16805F0", Offset = "0x167EFF0", VA = "0x1816805F0", Slot = "5")]
			public void ReadFromDisplayClass(ref AIGBJEEFACO LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x2289200", Offset = "0x2287C00", VA = "0x182289200", Slot = "6")]
			public void WriteToDisplayClass(ref AIGBJEEFACO LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x4519D30", Offset = "0x4518730", VA = "0x184519D30", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x4519FC0", Offset = "0x45189C0", VA = "0x184519FC0")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref AHAENJOOACO.OCLCOLFPIOF MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x4519F20", Offset = "0x4518920", VA = "0x184519F20")]
			public void KMHCJEDMEHN(PostLoadInitializeNetworkId LFKHFKIBGCJ, ref AIGBJEEFACO LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x4519E20", Offset = "0x4518820", VA = "0x184519E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B40710", Offset = "0x2B3F110", VA = "0x182B40710", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x2B40C80", Offset = "0x2B3F680", VA = "0x182B40C80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2B40D20", Offset = "0x2B3F720", VA = "0x182B40D20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2B40780", Offset = "0x2B3F180", VA = "0x182B40780")]
		public void MJCNCJPGIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FF60", Offset = "0x2B3E960", VA = "0x182B3FF60")]
		private void BGNEADEJGDP(NativeHashMap<KHMECMDAALD, Entity> MCHKFDMHGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2B404B0", Offset = "0x2B3EEB0", VA = "0x182B404B0")]
		private void FAGLOLIJHKB(NativeHashMap<KHMECMDAALD, Entity> MCHKFDMHGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2B409F0", Offset = "0x2B3F3F0", VA = "0x182B409F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2B40850", Offset = "0x2B3F250", VA = "0x182B40850")]
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
	[Cpp2IlInjected.Address(RVA = "0x30250B0", Offset = "0x3023AB0", VA = "0x1830250B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x3025140", Offset = "0x3023B40", VA = "0x183025140", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public JPMEMIFMBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x31FCFA0", Offset = "0x31FB9A0", VA = "0x1831FCFA0", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x31FD8A0", Offset = "0x31FC2A0", VA = "0x1831FD8A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x31FD040", Offset = "0x31FBA40", VA = "0x1831FD040")]
	private void IICPADHKKEM(NativeList<EntityArchetype> NOKEICPGEDG, NativeHashMap<int, JAPIHNFIDBB> OHDGELKDLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x31FCE60", Offset = "0x31FB860", VA = "0x1831FCE60")]
	private Span<int> DMOJKOIIBNL(EntityArchetype NCPPLDKIKPK)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x31FD1D0", Offset = "0x31FBBD0", VA = "0x1831FD1D0")]
	private bool LNPFKNKDNIM(int ODMCPPPIBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x31FD2A0", Offset = "0x31FBCA0", VA = "0x1831FD2A0")]
	private void MNPJCMKKDKA(NativeHashMap<int, JAPIHNFIDBB> OHDGELKDLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public BGEHHCGMNJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B40D80", Offset = "0x2B3F780", VA = "0x182B40D80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x2B41000", Offset = "0x2B3FA00", VA = "0x182B41000", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
			public BGMFLFHPBOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x2D7AFF0", Offset = "0x2D799F0", VA = "0x182D7AFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x451E0E0", Offset = "0x451CAE0", VA = "0x18451E0E0")]
			internal void JACNCLCPMJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x451E2C0", Offset = "0x451CCC0", VA = "0x18451E2C0", Slot = "5")]
			public void ReadFromDisplayClass(ref BGMFLFHPBOL LNLMJEFNJAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x451E0D0", Offset = "0x451CAD0", VA = "0x18451E0D0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x451E2A0", Offset = "0x451CCA0", VA = "0x18451E2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D842E0", Offset = "0x2D82CE0", VA = "0x182D842E0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2D849F0", Offset = "0x2D833F0", VA = "0x182D849F0")]
		public JobHandle PFDCJAJGMKJ(JobHandle ELLADMEAHLJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x2D84650", Offset = "0x2D83050", VA = "0x182D84650", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x2D84340", Offset = "0x2D82D40", VA = "0x182D84340")]
		private bool MBPGIKKDKCG(JobHandle ELLADMEAHLJ, int ODMCPPPIBBH, out JobHandle NEKDMAACJDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B3BD40", Offset = "0x2B3A740", VA = "0x182B3BD40", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public POAONHOIGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x31FF1B0", Offset = "0x31FDBB0", VA = "0x1831FF1B0", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public BMOFBIMGGJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B29000", Offset = "0x2B27A00", VA = "0x182B29000", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public NGPMJPMOHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B28740", Offset = "0x2B27140", VA = "0x182B28740", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public MNCHCDHIHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7374E0", Offset = "0x735EE0", VA = "0x1807374E0", Slot = "18")]
		get
		{
			return default(IECIGCFEBBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x31F91C0", Offset = "0x31F7BC0", VA = "0x1831F91C0")]
	public AKEOGAPEAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x31FA170", Offset = "0x31F8B70", VA = "0x1831FA170", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public AMNHJHGAIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class IDGLDKHPCOC : LLPKLCJBNBL
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public IDGLDKHPCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "18")]
		get
		{
			return default(IECIGCFEBBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public KLMPJIOHGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3202380", Offset = "0x3200D80", VA = "0x183202380", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public CGLJFPNEMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class JEEDCDDFIAH : LLPKLCJBNBL
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public JEEDCDDFIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class HCMDGBKLNFM : LLPKLCJBNBL
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public HCMDGBKLNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class NBDEPOOOIKG : KHECDAFCLCI
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public NBDEPOOOIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3216240", Offset = "0x3214C40", VA = "0x183216240", Slot = "14")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x3216290", Offset = "0x3214C90", VA = "0x183216290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public ELCGEJIHCPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D79580", Offset = "0x2D77F80", VA = "0x182D79580", Slot = "4")]
			public void Execute(int EGNHJGKABLC, TransformAccess CACALPHNCBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x2D797B0", Offset = "0x2D781B0", VA = "0x182D797B0")]
			private bool PKIKFJJNMEI(float3 JFNADPGFOAB, float3 DKOFAPECACL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x2D79740", Offset = "0x2D78140", VA = "0x182D79740")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D78DE0", Offset = "0x2D777E0", VA = "0x182D78DE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x320D150", Offset = "0x320BB50", VA = "0x18320D150", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x320D1C0", Offset = "0x320BBC0", VA = "0x18320D1C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x320D1F0", Offset = "0x320BBF0", VA = "0x18320D1F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x451E5A0", Offset = "0x451CFA0", VA = "0x18451E5A0")]
				public void KMHCJEDMEHN(RegisterTransforms LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x451E620", Offset = "0x451D020", VA = "0x18451E620")]
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
			[Cpp2IlInjected.Address(RVA = "0x4522820", Offset = "0x4521220", VA = "0x184522820")]
			internal void JACNCLCPMJH(Entity LCLDFKAJPDK, FCKMCCGOFNE HJEGHEJBGPH, Transform CACALPHNCBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x45226C0", Offset = "0x45210C0", VA = "0x1845226C0", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x4522930", Offset = "0x4521330", VA = "0x184522930")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, ref MMLKEAKDDLA.KFKOLCLDFGJ MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x4522920", Offset = "0x4521320", VA = "0x184522920")]
			public void KMHCJEDMEHN(RegisterTransforms LFKHFKIBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x45227B0", Offset = "0x45211B0", VA = "0x1845227B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x451BA50", Offset = "0x451A450", VA = "0x18451BA50")]
				public void KMHCJEDMEHN(RegisterTransforms LFKHFKIBGCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x451BAB0", Offset = "0x451A4B0", VA = "0x18451BAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x451D080", Offset = "0x451BA80", VA = "0x18451D080")]
			internal void JACNCLCPMJH(Entity LCLDFKAJPDK, FCKMCCGOFNE HJEGHEJBGPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x451CFF0", Offset = "0x451B9F0", VA = "0x18451CFF0", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x451D160", Offset = "0x451BB60", VA = "0x18451D160")]
			public void PCDANPFIHLF(ref ArchetypeChunk ONPLFJPHGKJ, [NoAlias] ref JDOKOGBDNNI.GHCMOJPLBKO MCKDMOCNPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x451BA50", Offset = "0x451A450", VA = "0x18451BA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D7D8A0", Offset = "0x2D7C2A0", VA = "0x182D7D8A0", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E150", Offset = "0x2D7CB50", VA = "0x182D7E150", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E360", Offset = "0x2D7CD60", VA = "0x182D7E360", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DCA0", Offset = "0x2D7C6A0", VA = "0x182D7DCA0")]
		private void NCLJCHLPHLA(EntityQuery ANBHGOBNOFE, HIEGLBAPNMB GPFPPMDAEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D4F0", Offset = "0x2D7BEF0", VA = "0x182D7D4F0")]
		private void DIHFPACHJPD(EntityQuery ANBHGOBNOFE, HIEGLBAPNMB GPFPPMDAEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E300", Offset = "0x2D7CD00", VA = "0x182D7E300", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D760", Offset = "0x2D7C160", VA = "0x182D7D760")]
		private void EKDHEIDHMJO(NativeArray<Entity> ABBIPALBHCK, HIEGLBAPNMB GPFPPMDAEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D040", Offset = "0x2D7BA40", VA = "0x182D7D040")]
		[BurstCompile]
		internal static void CLMNFPBKGPG(NativeArray<FCKMCCGOFNE> EPFCCIEGCBE, ComponentDataFromEntity<FCKMCCGOFNE> ACEEBHDOPPF, HIEGLBAPNMB GPFPPMDAEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		private static void MPMGKKFBPMB(Transform CACALPHNCBH, Entity LCLDFKAJPDK, int EGNHJGKABLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		private static void CBAHHKDKLHN(Entity LCLDFKAJPDK, int EGNHJGKABLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		private static void JIJINPIFOGF(int EGNHJGKABLC, HIEGLBAPNMB GPFPPMDAEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D8F0", Offset = "0x2D7C2F0", VA = "0x182D7D8F0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void MGGJNOKKAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DEE0", Offset = "0x2D7C8E0", VA = "0x182D7DEE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D350", Offset = "0x2D7BD50", VA = "0x182D7D350")]
		public static EntityQuery DDAGGAOCIEH(ComponentSystemBase LFKHFKIBGCJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DAD0", Offset = "0x2D7C4D0", VA = "0x182D7DAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D7BAC0", Offset = "0x2D7A4C0", VA = "0x182D7BAC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D786F0", Offset = "0x2D770F0", VA = "0x182D786F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D7CF40", Offset = "0x2D7B940", VA = "0x182D7CF40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x320D820", Offset = "0x320C220", VA = "0x18320D820", Slot = "14")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x320D870", Offset = "0x320C270", VA = "0x18320D870", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x320DA60", Offset = "0x320C460", VA = "0x18320DA60", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x320DAF0", Offset = "0x320C4F0", VA = "0x18320DAF0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x320DB20", Offset = "0x320C520", VA = "0x18320DB20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x320D6A0", Offset = "0x320C0A0", VA = "0x18320D6A0")]
		private NativeArray<Entity> FKFMDGIJMFB(NativeArray<FCKMCCGOFNE> JDFBPHJNCCJ, NativeList<Entity> JILBKCFLHPF, TransformAccessArray MAJCINIPNKO, TransformAccessArray BHHALGBFGOI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B413C0", Offset = "0x2B3FDC0", VA = "0x182B413C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x320E670", Offset = "0x320D070", VA = "0x18320E670", Slot = "14")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x320E780", Offset = "0x320D180", VA = "0x18320E780", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x320E450", Offset = "0x320CE50", VA = "0x18320E450")]
		private static void APLEKHBAIEH(EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, Entity GGEKFPEBLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x320E5D0", Offset = "0x320CFD0", VA = "0x18320E5D0")]
		private static bool KGFFBHKEPBA(EntityManager MABCFMECCKD, Entity LCLDFKAJPDK, out Transform CACALPHNCBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4520ED0", Offset = "0x451F8D0", VA = "0x184520ED0")]
			[Conditional("DEBUG_BUILD")]
			private void MANEPGOHPFN(Entity LCLDFKAJPDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x4520BE0", Offset = "0x451F5E0", VA = "0x184520BE0", Slot = "4")]
			public void Execute(ArchetypeChunk ONPLFJPHGKJ, int EGNHJGKABLC, int OLEGPGLEHEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x4520FA0", Offset = "0x451F9A0", VA = "0x184520FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B246B0", Offset = "0x2B230B0", VA = "0x182B246B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x2B247D0", Offset = "0x2B231D0", VA = "0x182B247D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x45188B0", Offset = "0x45172B0", VA = "0x1845188B0", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int EGNHJGKABLC, int OLEGPGLEHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x4518830", Offset = "0x4517230", VA = "0x184518830")]
		public bool DMLNPENFHLB(ArchetypeChunk ONPLFJPHGKJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery NONEKIBDKLA;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x2B24E90", Offset = "0x2B23890", VA = "0x182B24E90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2B24FC0", Offset = "0x2B239C0", VA = "0x182B24FC0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PEGJJCPFDDP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public LAHBGKACFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D79080", Offset = "0x2D77A80", VA = "0x182D79080", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int EGNHJGKABLC, int OLEGPGLEHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x2D79000", Offset = "0x2D77A00", VA = "0x182D79000")]
		public bool DMLNPENFHLB(ArchetypeChunk ONPLFJPHGKJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery HFKINOFBOBG;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x32012D0", Offset = "0x31FFCD0", VA = "0x1832012D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x32013E0", Offset = "0x31FFDE0", VA = "0x1832013E0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PEGJJCPFDDP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
	public CADODBIICJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D7A8E0", Offset = "0x2D792E0", VA = "0x182D7A8E0", Slot = "4")]
		public void Execute(ArchetypeChunk ONPLFJPHGKJ, int EGNHJGKABLC, int OLEGPGLEHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A800", Offset = "0x2D79200", VA = "0x182D7A800")]
		public bool DMLNPENFHLB(ArchetypeChunk ONPLFJPHGKJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery HFKINOFBOBG;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x3215D50", Offset = "0x3214750", VA = "0x183215D50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x3215E80", Offset = "0x3214880", VA = "0x183215E80", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PEGJJCPFDDP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740")]
	public EILNAOCAPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B41DD0", Offset = "0x2B407D0", VA = "0x182B41DD0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType EPMEBHFHEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x2B41E30", Offset = "0x2B40830", VA = "0x182B41E30", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType HCFNJFHMEDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x2B41E00", Offset = "0x2B40800", VA = "0x182B41E00", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2B41D30", Offset = "0x2B40730", VA = "0x182B41D30")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3214CE0", Offset = "0x32136E0", VA = "0x183214CE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] OOKOOBEKHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x3214670", Offset = "0x3213070", VA = "0x183214670", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] OOKOOBEKHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x301C9B0", Offset = "0x301B3B0", VA = "0x18301C9B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public IGJDHNEKPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class KGJNNENIMHE : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x3025D60", Offset = "0x3024760", VA = "0x183025D60", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public KGJNNENIMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] OOKOOBEKHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x3015B20", Offset = "0x3014520", VA = "0x183015B20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public HHCKMKBLANE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class FMIKHLJEPIB : BPBHIFGCFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x3010E90", Offset = "0x300F890", VA = "0x183010E90", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public FMIKHLJEPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3010CE0", Offset = "0x300F6E0", VA = "0x183010CE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] OOKOOBEKHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x3010930", Offset = "0x300F330", VA = "0x183010930", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x3213070", Offset = "0x3211A70", VA = "0x183213070", Slot = "4")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x300CA50", Offset = "0x300B450", VA = "0x18300CA50", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x300CB20", Offset = "0x300B520", VA = "0x18300CB20", Slot = "5")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x300CE00", Offset = "0x300B800", VA = "0x18300CE00")]
		public Entity NGLDHLBMECO(Entity LCLDFKAJPDK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x300CAC0", Offset = "0x300B4C0", VA = "0x18300CAC0")]
		public bool LGLAJNBPHCD(Entity LCLDFKAJPDK, Entity BJNIPOLNMLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x300C9B0", Offset = "0x300B3B0", VA = "0x18300C9B0")]
		public bool DEIBNNOCJKC(Entity LCLDFKAJPDK, Entity BJNIPOLNMLD, bool NFCHCDFCFMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x300CC20", Offset = "0x300B620", VA = "0x18300CC20")]
		private bool MJCAIGLJGIG(Entity LCLDFKAJPDK, Entity BJNIPOLNMLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x31F9F60", Offset = "0x31F8960", VA = "0x1831F9F60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x31F9C10", Offset = "0x31F8610", VA = "0x1831F9C10", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x31F9A60", Offset = "0x31F8460", VA = "0x1831F9A60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x31F9B50", Offset = "0x31F8550", VA = "0x1831F9B50")]
	public bool FFKLPDDAEHN(Entity LCLDFKAJPDK, Entity NLBEDCCLIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x31F99A0", Offset = "0x31F83A0", VA = "0x1831F99A0")]
	public IEnumerable<Entity> CMGIHGILOAF(Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x31F9D10", Offset = "0x31F8710", VA = "0x1831F9D10")]
	public bool HMKPBKJMFKD(Entity LCLDFKAJPDK, Entity ILLPMKANGKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x31F9FB0", Offset = "0x31F89B0", VA = "0x1831F9FB0")]
	public bool NBCMHKFAKCC(Entity LCLDFKAJPDK, Entity AGDKLNJDAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x31F9E80", Offset = "0x31F8880", VA = "0x1831F9E80")]
	public NativeList<Entity> JCKMNEBEMBO(Entity LCLDFKAJPDK, bool PNGNAFIFALL = false, Allocator FKHAEPDPDAI = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x31F98E0", Offset = "0x31F82E0", VA = "0x1831F98E0")]
	public IEnumerable<Entity> CEAEBLDPEEN(Entity LCLDFKAJPDK, bool PNGNAFIFALL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x31FA070", Offset = "0x31F8A70", VA = "0x1831FA070")]
	public Entity NKAKDLGIEDI(Entity LCLDFKAJPDK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x31FA120", Offset = "0x31F8B20", VA = "0x1831FA120")]
	public NativeArray<Entity> PADFFCJKHOD()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x31F9A80", Offset = "0x31F8480", VA = "0x1831F9A80")]
	public bool EDCKHKPPKHK(Entity AGDKLNJDAPF, Entity NMPDJFDFMIN, out Entity NFENBCEFMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x31F9DD0", Offset = "0x31F87D0", VA = "0x1831F9DD0")]
	private Entity IJHIFONNBOI(Entity LCLDFKAJPDK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x22DD300", Offset = "0x22DBD00", VA = "0x1822DD300")]
		public static void GJPLHHGHDFM<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(FJEOEPCCLME JGMMDACFJLC, global::OBMHIPHOPOO<Entity> IHNHAGGGBIH, out global::LHALHIEHJOK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> MJCHNIAODLH) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, JJCEHBPPLLO where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, JJCEHBPPLLO, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C1D0", Offset = "0x2B3ABD0", VA = "0x182B3C1D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x39D19D0", Offset = "0x39D03D0", VA = "0x1839D19D0")]
	public LHALHIEHJOK(FJEOEPCCLME JGMMDACFJLC, global::OBMHIPHOPOO<Entity> IHNHAGGGBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x39D0240", Offset = "0x39CEC40", VA = "0x1839D0240")]
	private bool FCAKMAPDICF(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x39D0190", Offset = "0x39CEB90", VA = "0x1839D0190")]
	private bool CNHODMGHFJP(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x39D07A0", Offset = "0x39CF1A0", VA = "0x1839D07A0")]
	public bool LGLAJNBPHCD(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x39D1010", Offset = "0x39CFA10", VA = "0x1839D1010")]
	public bool MEAILOEIHJH(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x39D0BD0", Offset = "0x39CF5D0", VA = "0x1839D0BD0")]
	private bool MEAILOEIHJH(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD, bool KDJOAFGCAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void PHFLMNLHLLF(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void GLLDFBLNOAA(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void INBEDGMAHFC(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void CCHNFLOIMCF(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void KHEEEKLEONJ(Entity LCLDFKAJPDK, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x39D0380", Offset = "0x39CED80", VA = "0x1839D0380")]
	private bool FFKLPDDAEHN(Entity LCLDFKAJPDK, Entity NLBEDCCLIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x39D0590", Offset = "0x39CEF90", VA = "0x1839D0590")]
	private void FMLGJONEGLB(Entity LCLDFKAJPDK, in Entity LOFGAAGHIJI, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x39D1040", Offset = "0x39CFA40", VA = "0x1839D1040")]
	private void PIALGDMPBFM(Entity LCLDFKAJPDK, in Entity LOFGAAGHIJI, in Entity BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x39D09D0", Offset = "0x39CF3D0", VA = "0x1839D09D0")]
	private bool MAICBACFIKK(FAPEEHIPGCB NNDGEEDPDKD, in KHMECMDAALD OJPJGALEFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x39D0460", Offset = "0x39CEE60", VA = "0x1839D0460")]
	private void FHJPDJCNJIO(Entity GGEKFPEBLKN, Entity ILLPMKANGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x39D0710", Offset = "0x39CF110", VA = "0x1839D0710")]
	private void LBIPGKKJCGE(Entity GGEKFPEBLKN, Entity ILLPMKANGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private void JIJINPIFOGF(Entity LCLDFKAJPDK, Entity LOFGAAGHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
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
		[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GELFNNAOOFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B305A0", Offset = "0x2B2EFA0", VA = "0x182B305A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int LBGJAHIFKCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x2B2FCF0", Offset = "0x2B2E6F0", VA = "0x182B2FCF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int CDJBKJOLKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x2B31AB0", Offset = "0x2B304B0", VA = "0x182B31AB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x15A4AE0", Offset = "0x15A34E0", VA = "0x1815A4AE0", Slot = "4")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FB30", Offset = "0x2B2E530", VA = "0x182B2FB30", Slot = "5")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2B31E60", Offset = "0x2B30860", VA = "0x182B31E60")]
		public void PCBJCBJMJKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2B31360", Offset = "0x2B2FD60", VA = "0x182B31360", Slot = "6")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EF70", Offset = "0x2B2D970", VA = "0x182B2EF70", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x2B31EB0", Offset = "0x2B308B0", VA = "0x182B31EB0")]
		public int PHDIMBKCLEF(SceneTag OOOMPFGDEEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x2B31CF0", Offset = "0x2B306F0", VA = "0x182B31CF0")]
		public int NHBEOEOMDAO(SceneTag OOOMPFGDEEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EB90", Offset = "0x2B2D590", VA = "0x182B2EB90")]
		public bool CEKHMFLDFGM(Entity LCLDFKAJPDK, Allocator FKHAEPDPDAI, out NativeList<Entity> PBEMBFBGMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2B30900", Offset = "0x2B2F300", VA = "0x182B30900")]
		public bool LDOPCOPODDB(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EDE0", Offset = "0x2B2D7E0", VA = "0x182B2EDE0")]
		public bool DGBCKPEIJJH(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x2B31ED0", Offset = "0x2B308D0", VA = "0x182B31ED0")]
		public bool PHONMIEGPBF(Entity LCLDFKAJPDK, out APKFPLGDLPH MPIEEKNKAMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2B31F40", Offset = "0x2B30940", VA = "0x182B31F40")]
		private bool PHONMIEGPBF(Transform CACALPHNCBH, out APKFPLGDLPH MPIEEKNKAMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FC60", Offset = "0x2B2E660", VA = "0x182B2FC60")]
		private void GBIFKHPFBNE(Entity LCLDFKAJPDK, APKFPLGDLPH MPIEEKNKAMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2B31E40", Offset = "0x2B30840", VA = "0x182B31E40")]
		private bool OPKIHFBPPFC(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F7F0", Offset = "0x2B2E1F0", VA = "0x182B2F7F0")]
		public void EHOMCGHPBHE(KHMECMDAALD HBKLDKCICEJ, APKFPLGDLPH CNEFEEJPMMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2B314B0", Offset = "0x2B2FEB0", VA = "0x182B314B0")]
		public bool MBELIAOAHEJ(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x2B30EC0", Offset = "0x2B2F8C0", VA = "0x182B30EC0")]
		public bool LFIKAPHEHNB(MBEDCJLMHEO LKHNLAILFFL, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2B31290", Offset = "0x2B2FC90", VA = "0x182B31290")]
		public bool LFIKAPHEHNB(Entity LCLDFKAJPDK, [Optional] object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x2B31270", Offset = "0x2B2FC70", VA = "0x182B31270")]
		public bool LFIKAPHEHNB(APKFPLGDLPH KANBPIJHFNA, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F100", Offset = "0x2B2DB00", VA = "0x182B2F100")]
		public bool EDFNPEPIDIC(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F0D0", Offset = "0x2B2DAD0", VA = "0x182B2F0D0")]
		public bool EDFNPEPIDIC(APKFPLGDLPH MPIEEKNKAMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2B30B50", Offset = "0x2B2F550", VA = "0x182B30B50")]
		public bool LFIKAPHEHNB(APKFPLGDLPH MPIEEKNKAMO, [Optional] object MIFCLBEAOPM, bool HKPPDHFDHMN = false, bool BHPLNOFGJEF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EE00", Offset = "0x2B2D800", VA = "0x182B2EE00")]
		public Transform DHHOPPBKOBH(Entity LCLDFKAJPDK, [Optional] object MIFCLBEAOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2B305F0", Offset = "0x2B2EFF0", VA = "0x182B305F0")]
		public bool KGFFBHKEPBA(Entity LCLDFKAJPDK, out Transform CACALPHNCBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F9F0", Offset = "0x2B2E3F0", VA = "0x182B2F9F0")]
		public APKFPLGDLPH EKICMIMOHBL(Entity LCLDFKAJPDK, [Optional] object MIFCLBEAOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F560", Offset = "0x2B2DF60", VA = "0x182B2F560")]
		public void EHGKANMEAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E340", Offset = "0x2B2CD40", VA = "0x182B2E340")]
		public void APCOFGFCCHC(SceneTag OOOMPFGDEEN, bool HONEAFDLBMH, global::GMANFPIPMBB<int> NGFDMJGEJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x2B300A0", Offset = "0x2B2EAA0", VA = "0x182B300A0")]
		private void JNBJMGNEBFI(Entity LCLDFKAJPDK, bool HONEAFDLBMH, bool KMPPFLJHBHE, global::GMANFPIPMBB<int> NGFDMJGEJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FDD0", Offset = "0x2B2E7D0", VA = "0x182B2FDD0")]
		private void HOINELOCENC(Entity LCLDFKAJPDK, APKFPLGDLPH MPIEEKNKAMO, bool HONEAFDLBMH, bool KMPPFLJHBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FAE0", Offset = "0x2B2E4E0", VA = "0x182B2FAE0")]
		public APKFPLGDLPH ELDOOGALMKM(Entity LCLDFKAJPDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E730", Offset = "0x2B2D130", VA = "0x182B2E730")]
		public bool BALOOPDBMDO(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x2B312E0", Offset = "0x2B2FCE0", VA = "0x182B312E0")]
		public bool LGIJADFEFLD(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2B31DD0", Offset = "0x2B307D0", VA = "0x182B31DD0")]
		public bool OOCDJKEDMNO(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2B31850", Offset = "0x2B30250", VA = "0x182B31850")]
		public bool MFDJBBJBCKH(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2B318C0", Offset = "0x2B302C0", VA = "0x182B318C0")]
		public bool MFDJBBJBCKH(GELFNNAOOFF IGELLPOEMHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void KLMKIDBPMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FD10", Offset = "0x2B2E710", VA = "0x182B2FD10")]
		private void GHGDPFPAJHH(bool GNCHPDAPALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F4D0", Offset = "0x2B2DED0", VA = "0x182B2F4D0")]
		private bool EGENMMIAIHO(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E2A0", Offset = "0x2B2CCA0", VA = "0x182B2E2A0")]
		private APKFPLGDLPH AFDOLMHKKDO(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E9A0", Offset = "0x2B2D3A0", VA = "0x182B2E9A0")]
		private APKFPLGDLPH CAJKIOGIOMA(Entity LCLDFKAJPDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x2B31AD0", Offset = "0x2B304D0", VA = "0x182B31AD0")]
		private (Vector3, Quaternion, Vector3) NEFGADJAFKN(Entity LCLDFKAJPDK)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E890", Offset = "0x2B2D290", VA = "0x182B2E890")]
		private void BENIODBEGGG(Entity LCLDFKAJPDK, GODNFBOIBNJ KLFAINNONJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2B31D10", Offset = "0x2B30710", VA = "0x182B31D10")]
		private void OHFDJMLMNPK(MBEDCJLMHEO LKHNLAILFFL, APKFPLGDLPH CNEFEEJPMMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2B31990", Offset = "0x2B30390", VA = "0x182B31990")]
		private void MHCOPBNAICC(APKFPLGDLPH CNEFEEJPMMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FE70", Offset = "0x2B2E870", VA = "0x182B2FE70")]
		private void JBCIDFGPJDD(APKFPLGDLPH MPIEEKNKAMO, Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2B306C0", Offset = "0x2B2F0C0", VA = "0x182B306C0")]
		private void KOAOPJPJAEC(Entity LCLDFKAJPDK, APKFPLGDLPH MPIEEKNKAMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E7B0", Offset = "0x2B2D1B0", VA = "0x182B2E7B0")]
		private void BECPHPFPPFP(Entity LCLDFKAJPDK, Transform CACALPHNCBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F0A0", Offset = "0x2B2DAA0", VA = "0x182B2F0A0")]
		private MBEDCJLMHEO EAFCGHBLJOG(Entity LCLDFKAJPDK)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x2B32110", Offset = "0x2B30B10", VA = "0x182B32110")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x2B31FF0", Offset = "0x2B309F0", VA = "0x182B31FF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3012950", Offset = "0x3011350", VA = "0x183012950")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B334A0", Offset = "0x2B31EA0", VA = "0x182B334A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, GODNFBOIBNJ> NDEJJCMOJOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x2B33400", Offset = "0x2B31E00", VA = "0x182B33400")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x2B328F0", Offset = "0x2B312F0", VA = "0x182B328F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> KHIOIHMLPND
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x2B33610", Offset = "0x2B32010", VA = "0x182B33610")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x2B32850", Offset = "0x2B31250", VA = "0x182B32850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x2B32CD0", Offset = "0x2B316D0", VA = "0x182B32CD0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x157B150", Offset = "0x1579B50", VA = "0x18157B150", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2B32C50", Offset = "0x2B31650", VA = "0x182B32C50")]
		public bool FIKLEKNKGJP(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2B32990", Offset = "0x2B31390", VA = "0x182B32990")]
		internal void CJJJNDCJKEI(Entity LCLDFKAJPDK, GODNFBOIBNJ KLFAINNONJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x2B32DB0", Offset = "0x2B317B0", VA = "0x182B32DB0")]
		public void HDLFCKJDPBO(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2B33740", Offset = "0x2B32140", VA = "0x182B33740")]
		public void PLFCEMPLJCD(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2B334F0", Offset = "0x2B31EF0", VA = "0x182B334F0")]
		private bool KMEPBCOCGKA(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2B33200", Offset = "0x2B31C00", VA = "0x182B33200")]
		public void JALMAFNAIBH(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2B32E40", Offset = "0x2B31840", VA = "0x182B32E40")]
		private bool HJJGIAGJEBI(Entity LCLDFKAJPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2B336B0", Offset = "0x2B320B0", VA = "0x182B336B0")]
		public void NAMPHNFBBEJ(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2B335B0", Offset = "0x2B31FB0", VA = "0x182B335B0")]
		private void LCAMDLJOOKD(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2B329F0", Offset = "0x2B313F0", VA = "0x182B329F0")]
		private void DPBFIMKMINF(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x2B32DF0", Offset = "0x2B317F0", VA = "0x182B32DF0")]
		public void HICCDFAGLMP(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		private void IBMPPHJLICD(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x2B33000", Offset = "0x2B31A00", VA = "0x182B33000")]
		private void HLLCKMPHGEH(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
				[Cpp2IlInjected.Address(RVA = "0x2295790", Offset = "0x2294190", VA = "0x182295790", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x451C320", Offset = "0x451AD20", VA = "0x18451C320", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x4517380", Offset = "0x4515D80", VA = "0x184517380")]
			[DebuggerHidden]
			public JFILPPKKOHN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x451C140", Offset = "0x451AB40", VA = "0x18451C140", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x451C2E0", Offset = "0x451ACE0", VA = "0x18451C2E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x451C240", Offset = "0x451AC40", VA = "0x18451C240", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(LFEIHDPDPKH, GODNFBOIBNJ)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x451C240", Offset = "0x451AC40", VA = "0x18451C240", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B37070", Offset = "0x2B35A70", VA = "0x182B37070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x2B37130", Offset = "0x2B35B30", VA = "0x182B37130")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x2B366E0", Offset = "0x2B350E0", VA = "0x182B366E0", Slot = "5")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x2B362F0", Offset = "0x2B34CF0", VA = "0x182B362F0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x2B35DD0", Offset = "0x2B347D0", VA = "0x182B35DD0")]
		internal IEnumerable<Type> AKGLONNPMJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x2B37460", Offset = "0x2B35E60", VA = "0x182B37460")]
		internal AGDNGEJKLKF ODHFBDBIEEH(Type OGILDIMGIOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x2B37340", Offset = "0x2B35D40", VA = "0x182B37340")]
		public EntityArchetype LGNAHADHJJD(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x2B37150", Offset = "0x2B35B50", VA = "0x182B37150")]
		public NativeHashMap<int, EntityArchetype> KFKJCKFILDI(Allocator FKHAEPDPDAI = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x2B372D0", Offset = "0x2B35CD0", VA = "0x182B372D0")]
		public bool KNIHHJKNKII(GODNFBOIBNJ KLFAINNONJC, out EntityArchetype NCPPLDKIKPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x2B370C0", Offset = "0x2B35AC0", VA = "0x182B370C0", Slot = "4")]
		[IteratorStateMachine(typeof(JFILPPKKOHN))]
		public IEnumerable<(LFEIHDPDPKH, GODNFBOIBNJ)> JHIPBENLCDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x2B361E0", Offset = "0x2B34BE0", VA = "0x182B361E0")]
		public Entity DBMKBBAHMAH(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x2B36680", Offset = "0x2B35080", VA = "0x182B36680")]
		public GODNFBOIBNJ FKGBCFJDCGK(ECHOKHJACKM OGILDIMGIOH)
		{
			return default(GODNFBOIBNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x2B36620", Offset = "0x2B35020", VA = "0x182B36620")]
		public GODNFBOIBNJ FKGBCFJDCGK(LFEIHDPDPKH OGILDIMGIOH)
		{
			return default(GODNFBOIBNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2B374D0", Offset = "0x2B35ED0", VA = "0x182B374D0")]
		public NativeHashMap<int, Entity> OPJOAFDHOFB(Allocator FKHAEPDPDAI = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2B37410", Offset = "0x2B35E10", VA = "0x182B37410")]
		public IEnumerable<GODNFBOIBNJ> MOCMAPEEAAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x2B36180", Offset = "0x2B34B80", VA = "0x182B36180")]
		public Entity COIHJJFIIGJ(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x2B373A0", Offset = "0x2B35DA0", VA = "0x182B373A0")]
		public bool LJBAPKMEOLK(GODNFBOIBNJ KLFAINNONJC, out Entity OPBBFNOFOIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x2B36C20", Offset = "0x2B35620", VA = "0x182B36C20")]
		private void HPDNGGNLOFA(AGDNGEJKLKF EAEDDCOHLGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x2B35E30", Offset = "0x2B34830", VA = "0x182B35E30")]
		internal void CCEIADDIBAF(GODNFBOIBNJ KLFAINNONJC, ComponentTypeList LLBOFFMHDFO, PFIJAJNBJFD PKFEKGEJIFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x2B36AC0", Offset = "0x2B354C0", VA = "0x182B36AC0")]
		private void GLBKHGKIINJ(GODNFBOIBNJ KLFAINNONJC, ComponentTypeList MCGONHKIMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x2B36060", Offset = "0x2B34A60", VA = "0x182B36060")]
		internal Entity CEPFIDMILML(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x2B37690", Offset = "0x2B36090", VA = "0x182B37690")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B291C0", Offset = "0x2B27BC0", VA = "0x182B291C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private NOBLONKDMFK IJLPOHKNBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x2B29AA0", Offset = "0x2B284A0", VA = "0x182B29AA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private HAMGBPFOOHJ IINCGJPKHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x74A900", Offset = "0x749300", VA = "0x18074A900", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, CBFIIKBAJEL> NBOLBAJBHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x7319F0", Offset = "0x7303F0", VA = "0x1807319F0", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, CBFIIKBAJEL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle KJBLPCOCDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x130D420", Offset = "0x130BE20", VA = "0x18130D420", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x1988F90", Offset = "0x1987990", VA = "0x181988F90", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool OLEOCMNDHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x2B29720", Offset = "0x2B28120", VA = "0x182B29720", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World CFJNIKBCPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x2B29950", Offset = "0x2B28350", VA = "0x182B29950", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A060", Offset = "0x2B28A60", VA = "0x182B2A060")]
	public NMMCCNJGHJL(LKOHPCAHLLK LJKPAKFPMLM, IECIGCFEBBH HJGAFKLFBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x2B296D0", Offset = "0x2B280D0", VA = "0x182B296D0", Slot = "11")]
	private void FBNLAJDICMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x2B29570", Offset = "0x2B27F70", VA = "0x182B29570", Slot = "10")]
	private bool EBJPFKHFOLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x2B29C80", Offset = "0x2B28680", VA = "0x182B29C80", Slot = "12")]
	private void PIAEICICBFC(ComponentType KCEEKGALKFC, in IGNMPNCMIDA GKOCLMPMONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x2B29C50", Offset = "0x2B28650", VA = "0x182B29C50", Slot = "13")]
	private bool NDMBIFFIPPK(GODNFBOIBNJ KLFAINNONJC, out Entity OPBBFNOFOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x2B294D0", Offset = "0x2B27ED0", VA = "0x182B294D0", Slot = "16")]
	private bool CGHJIAGCHBG(out NativeArray<int> AOMENFOEHAP, Allocator FKHAEPDPDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x2B29EA0", Offset = "0x2B288A0", VA = "0x182B29EA0", Slot = "17")]
	private bool POIIOILEHCD(ComponentType KCEEKGALKFC, out IGNMPNCMIDA IDHFJEIFJJF, out LHKPICCFKEL OCNEBCDHANP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x2B29D70", Offset = "0x2B28770", VA = "0x182B29D70", Slot = "18")]
	private bool POIIOILEHCD(ComponentType KCEEKGALKFC, out IGNMPNCMIDA IDHFJEIFJJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x2B299B0", Offset = "0x2B283B0", VA = "0x182B299B0", Slot = "19")]
	private IGNMPNCMIDA KMEPCJNMJEI(ComponentType KCEEKGALKFC)
	{
		return default(IGNMPNCMIDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x2B296E0", Offset = "0x2B280E0", VA = "0x182B296E0", Slot = "20")]
	private DLNMECKPKMF IBMDOMNMPHD()
	{
		return default(DLNMECKPKMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x2B29690", Offset = "0x2B28090", VA = "0x182B29690", Slot = "21")]
	private void EBPGHPPNJPN(JobHandle DNPFDFHMBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x2B29220", Offset = "0x2B27C20", VA = "0x182B29220")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x2B29730", Offset = "0x2B28130", VA = "0x182B29730")]
	private bool JCKAJKIMOCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x2B29AC0", Offset = "0x2B284C0", VA = "0x182B29AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B25C60", Offset = "0x2B24660", VA = "0x182B25C60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public NOBLONKDMFK FEPPIANMPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x451DC00", Offset = "0x451C600", VA = "0x18451DC00")]
			public MIMBMNPBNKL(PropertyDiffStateService LHDJJEMNOIF, IECIGCFEBBH IJPCPLACKHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x451DBE0", Offset = "0x451C5E0", VA = "0x18451DBE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public KIPPNPAOMDE EFCKPEGFCCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x2B42F60", Offset = "0x2B41960", VA = "0x182B42F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public IIEECLOJGND KBAFKHGDOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x2B42F60", Offset = "0x2B41960", VA = "0x182B42F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x8C89D0", Offset = "0x8C73D0", VA = "0x1808C89D0")]
		public KIPPNPAOMDE BJOIIHANBNN(IECIGCFEBBH HJGAFKLFBEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x8C89D0", Offset = "0x8C73D0", VA = "0x1808C89D0")]
		public IIEECLOJGND DGFFJEDALFN(IECIGCFEBBH HJGAFKLFBEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2B430E0", Offset = "0x2B41AE0", VA = "0x182B430E0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2B43180", Offset = "0x2B41B80", VA = "0x182B43180", Slot = "5")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2B42FA0", Offset = "0x2B419A0", VA = "0x182B42FA0")]
		public void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2B43000", Offset = "0x2B41A00", VA = "0x182B43000", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2B43160", Offset = "0x2B41B60", VA = "0x182B43160")]
		public MIMBMNPBNKL JIPPPMADBFC(IECIGCFEBBH HJGAFKLFBEI)
		{
			return default(MIMBMNPBNKL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x2B43590", Offset = "0x2B41F90", VA = "0x182B43590")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D7E8D0", Offset = "0x2D7D2D0", VA = "0x182D7E8D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> NAKBHKKJAKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0x1459F10", Offset = "0x1458910", VA = "0x181459F10")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0x216E0C0", Offset = "0x216CAC0", VA = "0x18216E0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity AGIHNPJFODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x2D7F930", Offset = "0x2D7E330", VA = "0x182D7F930")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag ONHAKDGHMFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x2D7F5A0", Offset = "0x2D7DFA0", VA = "0x182D7F5A0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity HOEOHPFHNCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x2D7F5A0", Offset = "0x2D7DFA0", VA = "0x182D7F5A0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x2D7F6F0", Offset = "0x2D7E0F0", VA = "0x182D7F6F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x2D7FA90", Offset = "0x2D7E490", VA = "0x182D7FA90")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F760", Offset = "0x2D7E160", VA = "0x182D7F760", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F550", Offset = "0x2D7DF50", VA = "0x182D7F550", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2D803A0", Offset = "0x2D7EDA0", VA = "0x182D803A0")]
		public void POCNDCJFBPN(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FB40", Offset = "0x2D7E540", VA = "0x182D7FB40")]
		public NativeArray<Entity> KNKAKBGPJKL(Allocator FKHAEPDPDAI = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F5F0", Offset = "0x2D7DFF0", VA = "0x182D7F5F0")]
		public void EHJKKDFOPEF(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2D80170", Offset = "0x2D7EB70", VA = "0x182D80170")]
		public Entity OEGIECJCAJK(string AMNLGEBHFHK = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FE80", Offset = "0x2D7E880", VA = "0x182D7FE80")]
		public void MMGNOIMFFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EA30", Offset = "0x2D7D430", VA = "0x182D7EA30")]
		public void CNMMEOHJGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FAE0", Offset = "0x2D7E4E0", VA = "0x182D7FAE0")]
		public void KNHMDCGAKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FA80", Offset = "0x2D7E480", VA = "0x182D7FA80")]
		public void KAGFEKFHOHE(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F880", Offset = "0x2D7E280", VA = "0x182D7F880")]
		public bool JEMFIJABFKF(Entity OOOMPFGDEEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FEA0", Offset = "0x2D7E8A0", VA = "0x182D7FEA0")]
		public void NDDAOAAFMJK(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E920", Offset = "0x2D7D320", VA = "0x182D7E920")]
		public string CLCLKGNBGGN(Entity OOOMPFGDEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public void GOOBCFDELOA(Entity OOOMPFGDEEN, string AMNLGEBHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x2D80150", Offset = "0x2D7EB50", VA = "0x182D80150")]
		public bool NMCIGPFNFPA(string AMNLGEBHFHK, out Entity OOOMPFGDEEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x2D80040", Offset = "0x2D7EA40", VA = "0x182D80040")]
		public void NHLMFBBOOAM(Entity OOOMPFGDEEN, bool NJMABCMAFIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EB70", Offset = "0x2D7D570", VA = "0x182D7EB70")]
		public void DEOPGDILMFN(Entity LCLDFKAJPDK, bool ILECBDFCKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EB00", Offset = "0x2D7D500", VA = "0x182D7EB00")]
		public void DEOPGDILMFN(NativeArray<Entity> ABBIPALBHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EBF0", Offset = "0x2D7D5F0", VA = "0x182D7EBF0")]
		public void DEOPGDILMFN(EntityQuery ANBHGOBNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EEC0", Offset = "0x2D7D8C0", VA = "0x182D7EEC0")]
		public void DMNJAEHNICL(Entity LCLDFKAJPDK, Entity OOOMPFGDEEN, bool ILECBDFCKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2D7ECE0", Offset = "0x2D7D6E0", VA = "0x182D7ECE0")]
		public void DMNJAEHNICL(NativeArray<Entity> ABBIPALBHCK, Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F0F0", Offset = "0x2D7DAF0", VA = "0x182D7F0F0")]
		public void DMNJAEHNICL(EntityQuery ANBHGOBNOFE, Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x2D801F0", Offset = "0x2D7EBF0", VA = "0x182D801F0")]
		private void PDHBPIIONMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x2D803E0", Offset = "0x2D7EDE0", VA = "0x182D803E0")]
		private void POGNBINJLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F930", Offset = "0x2D7E330", VA = "0x182D7F930")]
		private Entity MFAPILJGENM()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EA50", Offset = "0x2D7D450", VA = "0x182D7EA50")]
		private void DDADPABJJKH(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F480", Offset = "0x2D7DE80", VA = "0x182D7F480")]
		private void DODOFNHEHBD(EntityQuery IMAJPHALFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F1A0", Offset = "0x2D7DBA0", VA = "0x182D7F1A0")]
		private void DODOFNHEHBD(NativeArray<Entity> OOCMFKEPGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E820", Offset = "0x2D7D220", VA = "0x182D7E820")]
		private void CDNPFOCKEIP(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FD20", Offset = "0x2D7E720", VA = "0x182D7FD20")]
		private void LMCBJECPLNJ(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FB70", Offset = "0x2D7E570", VA = "0x182D7FB70")]
		private void KOBBOOCEIHM(SceneTag MNLIIBDIJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FCE0", Offset = "0x2D7E6E0", VA = "0x182D7FCE0")]
		private void LGBPMHFGAAN(SceneTag MNLIIBDIJCN, global::GMANFPIPMBB<int> NGFDMJGEJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FEB0", Offset = "0x2D7E8B0", VA = "0x182D7FEB0")]
		private void NGGLPDNGPIO(SceneTag MNLIIBDIJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E720", Offset = "0x2D7D120", VA = "0x182D7E720")]
		private void ACJHLDBJDEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x4ADCA70", Offset = "0x4ADB470", VA = "0x184ADCA70")]
		private void AAKLEGAPBEL<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void LBBICLCDLNJ(SceneTag MNLIIBDIJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E7C0", Offset = "0x2D7D1C0", VA = "0x182D7E7C0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void BGALIFGCGAB(EntityQuery ANBHGOBNOFE, string AMNLGEBHFHK, SceneTag MNLIIBDIJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FE50", Offset = "0x2D7E850", VA = "0x182D7FE50")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void MKCEICNBBHB(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void LIBFDHIKFAP(Entity OOOMPFGDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D8E090", Offset = "0x2D8CA90", VA = "0x182D8E090")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E000", Offset = "0x2D8CA00", VA = "0x182D8E000", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E150", Offset = "0x2D8CB50", VA = "0x182D8E150", Slot = "5")]
		public void POCNDCJFBPN(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x2D8DE10", Offset = "0x2D8C810", VA = "0x182D8DE10", Slot = "6")]
		public bool DHOMPHFDFBB(MBEDCJLMHEO LKHNLAILFFL, Transform CACALPHNCBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E0E0", Offset = "0x2D8CAE0", VA = "0x182D8E0E0")]
		private bool KIJELLAOMOI(Scene OOOMPFGDEEN, out Entity MFBJOFKPAKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E2C0", Offset = "0x2D8CCC0", VA = "0x182D8E2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D84DC0", Offset = "0x2D837C0", VA = "0x182D84DC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity PBIJGMNGOLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager BFILENFCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x2D850D0", Offset = "0x2D83AD0", VA = "0x182D850D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE2D0", Offset = "0x4ADCCD0", VA = "0x184ADE2D0")]
		public T MKLBNKEKMJE<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE200", Offset = "0x4ADCC00", VA = "0x184ADE200")]
		public void EFMALMFMJGL<T>(T LPJDDLMPNCG) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x2D84D50", Offset = "0x2D83750", VA = "0x182D84D50", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x2D85120", Offset = "0x2D83B20", VA = "0x182D85120", Slot = "5")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x2D85120", Offset = "0x2D83B20", VA = "0x182D85120")]
		private void MNCBKDJCMEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x2D84A80", Offset = "0x2D83480", VA = "0x182D84A80", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x2D84DD0", Offset = "0x2D837D0", VA = "0x182D84DD0")]
		private ComponentTypeList JBHAHIPKGHA()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		private static void HKCPHNLCJJH(int EJMNNLNLAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		private static void FNLAKDINAOD(Type OGILDIMGIOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x2D852C0", Offset = "0x2D83CC0", VA = "0x182D852C0")]
		private static void PJEGMHHBLLI(Type OGILDIMGIOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public AJNLODPELOG LBFLJDPNOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public AJNLODPELOG IBMIOPPDFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public AJNLODPELOG PNLGEEBOKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public AJNLODPELOG MLCKCLKBELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public AJNLODPELOG OCDIGFPMION
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76F9F0", VA = "0x180770FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager BFILENFCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2B28AD0", Offset = "0x2B274D0", VA = "0x182B28AD0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x2B289C0", Offset = "0x2B273C0", VA = "0x182B289C0", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x2B288D0", Offset = "0x2B272D0", VA = "0x182B288D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7D70", Offset = "0x2CD6770", VA = "0x182CD7D70")]
	private void GJPLHHGHDFM<T>(ref global::NFKGLAFFMGG<T> EFOCNJAEIPA) where T : struct, NIJKBPKBPOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7D70", Offset = "0x2CD6770", VA = "0x182CD7D70")]
	private void GJPLHHGHDFM<TC, TV>(ref global::MIOAAOMMLGI<TC, TV> EFOCNJAEIPA) where TC : struct, NIJKBPKBPOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x23522D0", Offset = "0x2350CD0", VA = "0x1823522D0")]
		get
		{
			return default(HIEGLBAPNMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x2B2ADF0", Offset = "0x2B297F0", VA = "0x182B2ADF0", Slot = "4")]
	public void DHCINKEHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x2B2AE40", Offset = "0x2B29840", VA = "0x182B2AE40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x4522B10", Offset = "0x4521510", VA = "0x184522B10")]
			public PNPFBPANAGP(TransformOwnershipPhase GGEKFPEBLKN, MIAKCDFPOCC HJGAFKLFBEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x4522AF0", Offset = "0x45214F0", VA = "0x184522AF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020")]
			get
			{
				return default(MIAKCDFPOCC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x7318F0", Offset = "0x7302F0", VA = "0x1807318F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool HMKNALALOKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0xB7D6D0", Offset = "0xB7C0D0", VA = "0x180B7D6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool CLLNCFKENJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0xFA5200", Offset = "0xFA3C00", VA = "0x180FA5200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x2D88620", Offset = "0x2D87020", VA = "0x182D88620")]
		public PNPFBPANAGP FPNGJFPEMBK()
		{
			return default(PNPFBPANAGP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x2D88650", Offset = "0x2D87050", VA = "0x182D88650")]
		public PNPFBPANAGP MMCEOGPMJIG()
		{
			return default(PNPFBPANAGP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x32057D0", Offset = "0x32041D0", VA = "0x1832057D0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x3205390", Offset = "0x3203D90", VA = "0x183205390", Slot = "5")]
		public bool ANGDAPPADEE(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x32056E0", Offset = "0x32040E0", VA = "0x1832056E0", Slot = "7")]
		public bool FIIHLFKEHCN(MBEDCJLMHEO LKHNLAILFFL, out Guid HDIHCPHNJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x3206460", Offset = "0x3204E60", VA = "0x183206460", Slot = "8")]
		public Guid KJPMLGCGPFO(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x3205B30", Offset = "0x3204530", VA = "0x183205B30", Slot = "9")]
		public void IGNAMIFGHND(MBEDCJLMHEO LKHNLAILFFL, Guid HDIHCPHNJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x3205A40", Offset = "0x3204440", VA = "0x183205A40", Slot = "10")]
		public bool IDDOCBKNLHA(MBEDCJLMHEO LKHNLAILFFL, out Guid FKJKGACLIOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x3206570", Offset = "0x3204F70", VA = "0x183206570", Slot = "11")]
		public Guid MOCNOFCDGIC(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x3206150", Offset = "0x3204B50", VA = "0x183206150", Slot = "12")]
		public void KAOLONFHDKA(MBEDCJLMHEO LKHNLAILFFL, Guid FKJKGACLIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x3205490", Offset = "0x3203E90", VA = "0x183205490", Slot = "13")]
		public bool DCNFJIIMMDM(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x3205670", Offset = "0x3204070", VA = "0x183205670", Slot = "14")]
		public void FCKHLPCCGFF(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x3205D90", Offset = "0x3204790", VA = "0x183205D90", Slot = "15")]
		public void JGMELKLBMOL(MBEDCJLMHEO ELODBNLDLIK, MBEDCJLMHEO GGEKFPEBLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x3205870", Offset = "0x3204270", VA = "0x183205870")]
		private void HDBKIANEFJD(EAGNNFCOCKO GGHIDBJGFCN, MBEDCJLMHEO GGEKFPEBLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x32054E0", Offset = "0x3203EE0", VA = "0x1832054E0")]
		private void DGNBIJBOMLF(EAGNNFCOCKO GGHIDBJGFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x3205240", Offset = "0x3203C40", VA = "0x183205240")]
		private bool AFCJDOHOMMF(EMFDOJECCDF NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x32063B0", Offset = "0x3204DB0", VA = "0x1832063B0")]
		private bool KHDLAAJPNII(EMFDOJECCDF NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x32059E0", Offset = "0x32043E0", VA = "0x1832059E0", Slot = "6")]
		public bool HKEACDLHMCP(MBEDCJLMHEO LMLBLIDPKCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
				[Cpp2IlInjected.Address(RVA = "0x731A00", Offset = "0x730400", VA = "0x180731A00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2D7A390", Offset = "0x2D78D90", VA = "0x182D7A390", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x9892A0", Offset = "0x987CA0", VA = "0x1809892A0")]
			[DebuggerHidden]
			public FKOJFDJCIAF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A3E0", Offset = "0x2D78DE0", VA = "0x182D7A3E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x2D79FA0", Offset = "0x2D789A0", VA = "0x182D79FA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A4B0", Offset = "0x2D78EB0", VA = "0x182D7A4B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A500", Offset = "0x2D78F00", VA = "0x182D7A500")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A350", Offset = "0x2D78D50", VA = "0x182D7A350", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A2A0", Offset = "0x2D78CA0", VA = "0x182D7A2A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MBEDCJLMHEO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A2A0", Offset = "0x2D78CA0", VA = "0x182D7A2A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x727090", Offset = "0x725A90", VA = "0x180727090", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x82DBF0", Offset = "0x82C5F0", VA = "0x18082DBF0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<MBEDCJLMHEO, MBEDCJLMHEO> EDGGDJFKPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x320B390", Offset = "0x3209D90", VA = "0x18320B390", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x320B070", Offset = "0x3209A70", VA = "0x18320B070", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<MBEDCJLMHEO, MBEDCJLMHEO> PCBBNEAHOBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x320C090", Offset = "0x320AA90", VA = "0x18320C090", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x320A860", Offset = "0x3209260", VA = "0x18320A860", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<MBEDCJLMHEO, MBEDCJLMHEO, MBEDCJLMHEO> INKODGPCFLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x320AE50", Offset = "0x3209850", VA = "0x18320AE50", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x320A7C0", Offset = "0x32091C0", VA = "0x18320A7C0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<MBEDCJLMHEO> HMJMHIGBAHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x320BDB0", Offset = "0x320A7B0", VA = "0x18320BDB0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x320A5D0", Offset = "0x3208FD0", VA = "0x18320A5D0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x320AEF0", Offset = "0x32098F0", VA = "0x18320AEF0", Slot = "25")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x320B910", Offset = "0x320A310", VA = "0x18320B910", Slot = "26")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x320AAC0", Offset = "0x32094C0", VA = "0x18320AAC0", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x320AC70", Offset = "0x3209670", VA = "0x18320AC70")]
		private void EKGDECLKKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x320B430", Offset = "0x3209E30", VA = "0x18320B430")]
		private void IGAIOIBGIII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x320A900", Offset = "0x3209300", VA = "0x18320A900")]
		private void DHKFMFLKANM(Entity LCLDFKAJPDK, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI DKOFAPECACL, HAMGOKKMMPI JFNADPGFOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x320C030", Offset = "0x320AA30", VA = "0x18320C030")]
		private void OHDIHGKABAA(Entity LCLDFKAJPDK, AHKPLOLMABO CBPECCEKJOB, HAMGOKKMMPI DKOFAPECACL, HAMGOKKMMPI JFNADPGFOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x1684440", Offset = "0x1682E40", VA = "0x181684440", Slot = "14")]
		public MBEDCJLMHEO DBMFKACBPJP(MBEDCJLMHEO LKHNLAILFFL, int CHIMMHOJJPG)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x13A4CF0", Offset = "0x13A36F0", VA = "0x1813A4CF0", Slot = "15")]
		public Color HGPGACLBBON(MBEDCJLMHEO LKHNLAILFFL, int CHIMMHOJJPG)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x320B730", Offset = "0x320A130", VA = "0x18320B730", Slot = "16")]
		public float3 KACCOCEONIB(MBEDCJLMHEO LKHNLAILFFL, int CHIMMHOJJPG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x320BE50", Offset = "0x320A850", VA = "0x18320BE50", Slot = "17")]
		public bool NKKFLAJKMBF(MBEDCJLMHEO LKHNLAILFFL, MBEDCJLMHEO MCIFJHLGFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x320B2E0", Offset = "0x3209CE0", VA = "0x18320B2E0", Slot = "18")]
		public MBEDCJLMHEO HPNJPLPKLJD(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x320A670", Offset = "0x3209070", VA = "0x18320A670", Slot = "21")]
		public void CAABHGHOFIH(MBEDCJLMHEO LKHNLAILFFL, Vector3 GPANIELDIGF, Quaternion DBPJHIKNNJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x320BF90", Offset = "0x320A990", VA = "0x18320BF90", Slot = "23")]
		public float3 OGBFLDPHPPC(MNPGLJDFPEI HFAEPNPFGOA)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x320B5A0", Offset = "0x3209FA0", VA = "0x18320B5A0", Slot = "24")]
		public quaternion JBJGILFHGEH(MNPGLJDFPEI HFAEPNPFGOA)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x320B630", Offset = "0x320A030", VA = "0x18320B630", Slot = "28")]
		public RigidTransform JIFNPFBGKDL(MNPGLJDFPEI HFAEPNPFGOA)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x320ACD0", Offset = "0x32096D0", VA = "0x18320ACD0", Slot = "22")]
		public bool EMMOCFOCGKM(MBEDCJLMHEO LKHNLAILFFL, out RigidTransform EFCKMMEMLMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x320BF00", Offset = "0x320A900", VA = "0x18320BF00", Slot = "19")]
		[IteratorStateMachine(typeof(FKOJFDJCIAF))]
		public IEnumerable<MBEDCJLMHEO> OEODJGDOMJE(MBEDCJLMHEO LKHNLAILFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x320A470", Offset = "0x3208E70", VA = "0x18320A470", Slot = "20")]
		public MBEDCJLMHEO BACFLHOIANK(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x320B110", Offset = "0x3209B10", VA = "0x18320B110", Slot = "29")]
		public void GLOLKBCIMFI(ref List<MBEDCJLMHEO> NNDAPMCFFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x320A350", Offset = "0x3208D50", VA = "0x18320A350")]
		private Entity BACFLHOIANK(Entity LCLDFKAJPDK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x320C1C0", Offset = "0x320ABC0", VA = "0x18320C1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B32220", Offset = "0x2B30C20", VA = "0x182B32220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x2B324D0", Offset = "0x2B30ED0", VA = "0x182B324D0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x2B32780", Offset = "0x2B31180", VA = "0x182B32780")]
		public Entity PFNKHCBELDA(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x2B327A0", Offset = "0x2B311A0", VA = "0x182B327A0")]
		public Entity PLLGILFFNLD(KHMECMDAALD HBKLDKCICEJ, GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x2B323D0", Offset = "0x2B30DD0", VA = "0x182B323D0")]
		public Entity FMBHGNBEDKM(GODNFBOIBNJ KLFAINNONJC, bool GKHKAHGPIJJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2B32270", Offset = "0x2B30C70", VA = "0x182B32270")]
		public Entity FMBHGNBEDKM(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2B32600", Offset = "0x2B31000", VA = "0x182B32600")]
		public Entity HNGEDIPEFKF()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2B32640", Offset = "0x2B31040", VA = "0x182B32640")]
		public Entity JHOHELNIPGN(LFEIHDPDPKH OGILDIMGIOH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x2B32190", Offset = "0x2B30B90", VA = "0x182B32190")]
		public Entity BHGFCNAGJLA(ECHOKHJACKM OGILDIMGIOH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2B32480", Offset = "0x2B30E80", VA = "0x182B32480")]
		public NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)> DBMKBBAHMAH(NativeArray<MBEDCJLMHEO> HNAFJFFPIOE, Allocator FKHAEPDPDAI)
		{
			return default(NativeArray<(MBEDCJLMHEO, MBEDCJLMHEO)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2B32730", Offset = "0x2B31130", VA = "0x182B32730")]
		public IEnumerable<GODNFBOIBNJ> MOCMAPEEAAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2B326D0", Offset = "0x2B310D0", VA = "0x182B326D0")]
		public EntityArchetype LGNAHADHJJD(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2B32420", Offset = "0x2B30E20", VA = "0x182B32420")]
		public Entity COIHJJFIIGJ(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x2B32270", Offset = "0x2B30C70", VA = "0x182B32270")]
		private Entity CJCECJGAKAI(GODNFBOIBNJ KLFAINNONJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x2B323D0", Offset = "0x2B30DD0", VA = "0x182B323D0")]
		private Entity CJCECJGAKAI(GODNFBOIBNJ KLFAINNONJC, bool GKHKAHGPIJJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2B322B0", Offset = "0x2B30CB0", VA = "0x182B322B0")]
		private Entity CJCECJGAKAI(GODNFBOIBNJ KLFAINNONJC, KHMECMDAALD HBKLDKCICEJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B3C790", Offset = "0x2B3B190", VA = "0x182B3C790", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C8F0", Offset = "0x2B3B2F0", VA = "0x182B3C8F0", Slot = "9")]
		public void DHCINKEHHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CFA0", Offset = "0x2B3B9A0", VA = "0x182B3CFA0", Slot = "10")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CAB0", Offset = "0x2B3B4B0", VA = "0x182B3CAB0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D060", Offset = "0x2B3BA60", VA = "0x182B3D060", Slot = "4")]
		public CMKEFKIFPMD GLJAHNPFFDG(Entity LCLDFKAJPDK)
		{
			return default(CMKEFKIFPMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D540", Offset = "0x2B3BF40", VA = "0x182B3D540", Slot = "5")]
		public void ODFMHOGGBHC(NativeArray<CMKEFKIFPMD> FENIMIGFDHN, NativeArray<CNEHLCBOJKB> ABPIDODICDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D9B0", Offset = "0x2B3C3B0", VA = "0x182B3D9B0", Slot = "6")]
		public void PJFNONPCDML(CMKEFKIFPMD IGELLPOEMHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CEC0", Offset = "0x2B3B8C0", VA = "0x182B3CEC0", Slot = "7")]
		public bool EGFFMNOOCCE(CMKEFKIFPMD IGELLPOEMHM, out Collider CMHAOFFOOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CBB0", Offset = "0x2B3B5B0", VA = "0x182B3CBB0")]
		public bool EEMPOIEDICE(in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, float CBFODBDKBEK, Allocator FKHAEPDPDAI, out NativeArray<Entity> ABBIPALBHCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CA60", Offset = "0x2B3B460", VA = "0x182B3CA60")]
		private void DIJJGKONOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xC04C50", Offset = "0xC03650", VA = "0x180C04C50")]
		private void NMCDHGHPHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D960", Offset = "0x2B3C360", VA = "0x182B3D960")]
		private void PDNIILOBMLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x9854A0", Offset = "0x983EA0", VA = "0x1809854A0")]
		private void BGEGPBINELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C7D0", Offset = "0x2B3B1D0", VA = "0x182B3C7D0")]
		private BoxCollider CPIODAMHIIO(Entity LCLDFKAJPDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C710", Offset = "0x2B3B110", VA = "0x182B3C710")]
		private void BGFDIAKHCDD(BoxCollider GOMLNOAKNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D500", Offset = "0x2B3BF00", VA = "0x182B3D500")]
		[Conditional("UNITY_EDITOR")]
		private void MAHAKEKIGBL(GameObject DLNMCGFEPOP, Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D200", Offset = "0x2B3BC00", VA = "0x182B3D200")]
		private void KAEFPFLEOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D3F0", Offset = "0x2B3BDF0", VA = "0x182B3D3F0")]
		private void LAGOCFGBNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D750", Offset = "0x2B3C150", VA = "0x182B3D750")]
		private void OPEBIDDPPBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D1D0", Offset = "0x2B3BBD0", VA = "0x182B3D1D0")]
		private void JOEKHNLAHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D1B0", Offset = "0x2B3BBB0", VA = "0x182B3D1B0")]
		private void HBNKDMOCPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CF60", Offset = "0x2B3B960", VA = "0x182B3CF60")]
		private void EHLBGAEDHAO(Scene OCJBFGAPLBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D1C0", Offset = "0x2B3BBC0", VA = "0x182B3D1C0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3016480", Offset = "0x3014E80", VA = "0x183016480", Slot = "5")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x3016000", Offset = "0x3014A00", VA = "0x183016000")]
	public bool EEMPOIEDICE(in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, float CBFODBDKBEK, out OBMPBPFAGAM AHNPMILMEKC, out Entity BADFIEDMMBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x30164F0", Offset = "0x3014EF0", VA = "0x1830164F0")]
	public static bool KHHHCLIODGK(in Span<OBMPBPFAGAM> DDPJAPAMPDO, float CBFODBDKBEK, out int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x30165F0", Offset = "0x3014FF0", VA = "0x1830165F0")]
	public static float NEIPKBHICDN(float DBJKICMPHJB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public HILIPBHIKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x3015FF0", Offset = "0x30149F0", VA = "0x183015FF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4521470", Offset = "0x451FE70", VA = "0x184521470", Slot = "4")]
		public void Execute(int EGNHJGKABLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x45213A0", Offset = "0x451FDA0", VA = "0x1845213A0")]
		private static float3 BBLDIDGICNH(in float4x4 HFKDJOHFPJL, in float3 JOFEJELEMJH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x4522390", Offset = "0x4520D90", VA = "0x184522390")]
		private static float3 LGMNACJJFIP(in float4x4 HFKDJOHFPJL, in float3 FHOLHGOPLFN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x4522550", Offset = "0x4520F50", VA = "0x184522550")]
		private static float3 NHNCCCCIGNG(in float4x4 HFKDJOHFPJL, in float3 JOFEJELEMJH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x4522170", Offset = "0x4520B70", VA = "0x184522170")]
		private static float3 LECBAPPFJAK(in float4x4 HFKDJOHFPJL, in float3 FHOLHGOPLFN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x4521750", Offset = "0x4520150", VA = "0x184521750")]
		private bool JOAOEHNPEHF(in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, in NativeArray<Entity> EPFCJOBDAJD, out float3 AHNPMILMEKC, out float3 GCGCIPKJGGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x4521AA0", Offset = "0x45204A0", VA = "0x184521AA0")]
		public static bool KALAOFOOINH(in float3 IDIJOBCGPIE, in float3 NAOJLHNCLOF, in float3 FCMLNJLDLJA, in float3 PBMNJAMCBKN, float POPHLCJMFFD, float EGFCGGBAJBP, out float FOHPMIEDDCH, out float3 CLCAFOLJPCA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager MABCFMECCKD;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x30130E0", Offset = "0x3011AE0", VA = "0x1830130E0", Slot = "5")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x3012C00", Offset = "0x3011600", VA = "0x183012C00")]
	public void EEMPOIEDICE(in NativeArray<Entity> ABBIPALBHCK, in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, in NativeArray<OBMPBPFAGAM> GOJDMOLEOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public GPEBHGLNPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x3013160", Offset = "0x3011B60", VA = "0x183013160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x11ECA90", Offset = "0x11EB490", VA = "0x1811ECA90")]
			get
			{
				return default(NativeHashMap<KHMECMDAALD, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint NNGCNJHNEJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x2B35710", Offset = "0x2B34110", VA = "0x182B35710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool AMOPNJPCIDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x8FBA40", Offset = "0x8FA440", VA = "0x1808FBA40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0x1125E60", Offset = "0x1124860", VA = "0x181125E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x2B35A30", Offset = "0x2B34430", VA = "0x182B35A30", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x2B35740", Offset = "0x2B34140", VA = "0x182B35740", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x2B35690", Offset = "0x2B34090", VA = "0x182B35690")]
		public void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x2B357E0", Offset = "0x2B341E0", VA = "0x182B357E0")]
		public void EHEINJKPBJH(KHMECMDAALD HBKLDKCICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x2B357B0", Offset = "0x2B341B0", VA = "0x182B357B0")]
		private MBEDCJLMHEO EAFCGHBLJOG(Entity LCLDFKAJPDK)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x2B35C40", Offset = "0x2B34640", VA = "0x182B35C40")]
		public MBEDCJLMHEO HKKALCMCNLF(KHMECMDAALD HBKLDKCICEJ)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2B35B50", Offset = "0x2B34550", VA = "0x182B35B50")]
		public KHMECMDAALD FLJOHMEAAKD(MBEDCJLMHEO LKHNLAILFFL)
		{
			return default(KHMECMDAALD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x2B359A0", Offset = "0x2B343A0", VA = "0x182B359A0")]
		public void FFMJGCAAAJB(Entity LCLDFKAJPDK, KHMECMDAALD HBKLDKCICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x2B35BE0", Offset = "0x2B345E0", VA = "0x182B35BE0")]
		public void HKALEDFALIG(Entity LCLDFKAJPDK, KHMECMDAALD HBKLDKCICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x2B35D20", Offset = "0x2B34720", VA = "0x182B35D20")]
		public void KIAFNFEMHGD(Entity LCLDFKAJPDK, KHMECMDAALD HBKLDKCICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x2B355C0", Offset = "0x2B33FC0", VA = "0x182B355C0")]
		public void BHEACGKKHHJ(Entity LCLDFKAJPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B43E60", Offset = "0x2B42860", VA = "0x182B43E60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x2B43DC0", Offset = "0x2B427C0", VA = "0x182B43DC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action PIEIPDDJIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x2B43D20", Offset = "0x2B42720", VA = "0x182B43D20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x2B43C80", Offset = "0x2B42680", VA = "0x182B43C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x2B439B0", Offset = "0x2B423B0", VA = "0x182B439B0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x2B437B0", Offset = "0x2B421B0", VA = "0x182B437B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x2B43840", Offset = "0x2B42240", VA = "0x182B43840")]
		public void EHOMCGHPBHE(AHKPLOLMABO CBPECCEKJOB, JFEKOCHNFPJ MIKGEIBIMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x2B44530", Offset = "0x2B42F30", VA = "0x182B44530")]
		public void LPEOMHLIOKB(AHKPLOLMABO CBPECCEKJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x2B44620", Offset = "0x2B43020", VA = "0x182B44620")]
		internal void MNCEJMAAFEG(KIPPNPAOMDE OJNFGJAPBNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x2B43FF0", Offset = "0x2B429F0", VA = "0x182B43FF0")]
		private void KNENKCHDKIJ(KIPPNPAOMDE OJNFGJAPBNC, int ODMCPPPIBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x2B43A00", Offset = "0x2B42400", VA = "0x182B43A00")]
		private void GPDKHHBAODH(ANIKAMAEHJJ HDLEMAAGOPN, HPEJEEPDKIC JDLEDOMGLLJ, JHBOIBABLAL JCKODLGNJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x2B43630", Offset = "0x2B42030", VA = "0x182B43630")]
		private KFNMGDMNBOO DIMAMDOBADA(ANIKAMAEHJJ HDLEMAAGOPN, HPEJEEPDKIC JDLEDOMGLLJ)
		{
			return default(KFNMGDMNBOO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x2B43F00", Offset = "0x2B42900", VA = "0x182B43F00")]
		private JHBOIBABLAL KBMGPBGGPOI(KFNMGDMNBOO OCNEBCDHANP, ANIKAMAEHJJ HDLEMAAGOPN, HPEJEEPDKIC JDLEDOMGLLJ)
		{
			return default(JHBOIBABLAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x2B44900", Offset = "0x2B43300", VA = "0x182B44900")]
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
			[Cpp2IlInjected.Address(RVA = "0x731A00", Offset = "0x730400", VA = "0x180731A00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D78D90", Offset = "0x2D77790", VA = "0x182D78D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x9892A0", Offset = "0x987CA0", VA = "0x1809892A0")]
		[DebuggerHidden]
		public CJLBHMODDMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x2D78BE0", Offset = "0x2D775E0", VA = "0x182D78BE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x2D78D50", Offset = "0x2D77750", VA = "0x182D78D50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x2D78CA0", Offset = "0x2D776A0", VA = "0x182D78CA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MBEDCJLMHEO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x2D78CA0", Offset = "0x2D776A0", VA = "0x182D78CA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3210DF0", Offset = "0x320F7F0", VA = "0x183210DF0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private PHIPKIFAENI PDFOFNPFHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x3210ED0", Offset = "0x320F8D0", VA = "0x183210ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x3210940", Offset = "0x320F340", VA = "0x183210940", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x3210F90", Offset = "0x320F990", VA = "0x183210F90", Slot = "5")]
	public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x32107D0", Offset = "0x320F1D0", VA = "0x1832107D0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x3211180", Offset = "0x320FB80", VA = "0x183211180")]
	private void MMAOFIFDHGH(Entity LFMBJFHAJEM, in HAMGOKKMMPI MHPPGEEJAEH, in HAMGOKKMMPI CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x32109D0", Offset = "0x320F3D0", VA = "0x1832109D0", Slot = "14")]
	public MBEDCJLMHEO HNGEDIPEFKF()
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x3211660", Offset = "0x3210060", VA = "0x183211660", Slot = "10")]
	public void ONMPADPNFGL(MBEDCJLMHEO LKHNLAILFFL, FOIGNAKKMCJ BHGFJLDJJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x3210880", Offset = "0x320F280", VA = "0x183210880", Slot = "9")]
	public FOIGNAKKMCJ EIMBJPIMGJD(MBEDCJLMHEO LKHNLAILFFL)
	{
		return default(FOIGNAKKMCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x3210AF0", Offset = "0x320F4F0", VA = "0x183210AF0", Slot = "11")]
	public MBEDCJLMHEO JELNCJOHJPG(MBEDCJLMHEO MDGOLEBJDDG, [Optional] Vector3? PICDPPHNNLH, [Optional] Quaternion? IHCJBCJFELL, [Optional] Vector3? AFPPFOOOELL)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x3210550", Offset = "0x320EF50", VA = "0x183210550", Slot = "15")]
	public MBEDCJLMHEO AEBDBMHDFKJ(MBEDCJLMHEO PIPOCKGHLKK, int EGNHJGKABLC, [Optional] Vector3? PICDPPHNNLH, [Optional] Quaternion? IHCJBCJFELL, [Optional] Vector3? AFPPFOOOELL)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x3211090", Offset = "0x320FA90", VA = "0x183211090", Slot = "7")]
	public MBEDCJLMHEO MBJMINBJNOB(MBEDCJLMHEO PIPOCKGHLKK, int EGNHJGKABLC)
	{
		return default(MBEDCJLMHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x32115A0", Offset = "0x320FFA0", VA = "0x1832115A0", Slot = "16")]
	public void OKKIBFDCACD(MBEDCJLMHEO PIPOCKGHLKK, MBEDCJLMHEO HIBFCDNCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x3211400", Offset = "0x320FE00", VA = "0x183211400", Slot = "12")]
	public void MPFKOEEEACC(MBEDCJLMHEO PIPOCKGHLKK, int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x3210630", Offset = "0x320F030", VA = "0x183210630", Slot = "17")]
	public void CGIOCEHLJPO(MBEDCJLMHEO PIPOCKGHLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x3210590", Offset = "0x320EF90", VA = "0x183210590", Slot = "8")]
	public int AJEIBGLJBFG(MBEDCJLMHEO PIPOCKGHLKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x3211720", Offset = "0x3210120", VA = "0x183211720", Slot = "6")]
	[IteratorStateMachine(typeof(CJLBHMODDMJ))]
	public IEnumerable<MBEDCJLMHEO> OPIFHIDCKKK(MBEDCJLMHEO PIPOCKGHLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x3210E40", Offset = "0x320F840", VA = "0x183210E40")]
	private bool KGJONKDKNJI(MBEDCJLMHEO PIPOCKGHLKK, out NativeArray<Entity> BOGHIFKGACA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x3210A30", Offset = "0x320F430", VA = "0x183210A30")]
	private NativeArray<Entity> HNMNGKDAFBE(MBEDCJLMHEO PIPOCKGHLKK)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x3024C20", Offset = "0x3023620", VA = "0x183024C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x3024C70", Offset = "0x3023670", VA = "0x183024C70", Slot = "4")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x3024FC0", Offset = "0x30239C0", VA = "0x183024FC0")]
	public void PLANKGEDEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x3024CF0", Offset = "0x30236F0", VA = "0x183024CF0")]
	public void HHDDIHAOJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x30148F0", Offset = "0x30132F0", VA = "0x1830148F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x3014AD0", Offset = "0x30134D0", VA = "0x183014AD0")]
	public HCBCHLAIJFO(Type OGILDIMGIOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x3014A70", Offset = "0x3013470", VA = "0x183014A70")]
	public static HCBCHLAIJFO HPHCHABBDNG(Type OGILDIMGIOH)
	{
		return default(HCBCHLAIJFO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x3014A50", Offset = "0x3013450", VA = "0x183014A50")]
	public static Type HPHCHABBDNG(HCBCHLAIJFO IGELLPOEMHM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x10CF340", Offset = "0x10CDD40", VA = "0x1810CF340")]
	public static bool BOBJELOEACN(HCBCHLAIJFO HFOFADIOHHP, HCBCHLAIJFO GFCGIJPPCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x10CF340", Offset = "0x10CDD40", VA = "0x1810CF340")]
	public static bool GPCPOEGFAHL(HCBCHLAIJFO HFOFADIOHHP, HCBCHLAIJFO GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x8A2060", Offset = "0x8A0A60", VA = "0x1808A2060", Slot = "4")]
	public bool Equals(HCBCHLAIJFO MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x30149D0", Offset = "0x30133D0", VA = "0x1830149D0", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C14C0", VA = "0x1807C2AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x3014AA0", Offset = "0x30134A0", VA = "0x183014AA0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3010760", Offset = "0x300F160", VA = "0x183010760")]
	static FFNIKEEFGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x2F7AC30", Offset = "0x2F79630", VA = "0x182F7AC30")]
	public static bool AGMLDLCGDGN<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x30102B0", Offset = "0x300ECB0", VA = "0x1830102B0")]
	public static bool AGMLDLCGDGN(Type OGILDIMGIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x3010320", Offset = "0x300ED20", VA = "0x183010320")]
	private static bool AGMLDLCGDGN(Type OGILDIMGIOH, out int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x2F7ACC0", Offset = "0x2F796C0", VA = "0x182F7ACC0")]
	public static int DFDIJCKOMFL<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x3010490", Offset = "0x300EE90", VA = "0x183010490")]
	public static int DFDIJCKOMFL(Type OGILDIMGIOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x2F7AD50", Offset = "0x2F79750", VA = "0x182F7AD50")]
	public static bool OBCGBBDEENH<T>(out int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x30105A0", Offset = "0x300EFA0", VA = "0x1830105A0")]
	public static bool OBCGBBDEENH(Type OGILDIMGIOH, out int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x3010500", Offset = "0x300EF00", VA = "0x183010500")]
	public static Type MKLBNKEKMJE(int EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x3010640", Offset = "0x300F040", VA = "0x183010640")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C4090", Offset = "0x8C2A90", VA = "0x1808C4090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x24BF800", Offset = "0x24BE200", VA = "0x1824BF800")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> DNIFLPOBKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6A30", Offset = "0x2CF5430", VA = "0x182CF6A30")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0x920250", Offset = "0x91EC50", VA = "0x180920250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6AD0", Offset = "0x2CF54D0", VA = "0x182CF6AD0")]
	public DGECPDIGKGH(int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6980", Offset = "0x2CF5380", VA = "0x182CF6980")]
	public int JPAOIDBBCIF(T LPJDDLMPNCG, int LOEMONDJCMM, int EJMNNLNLAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x2CF68C0", Offset = "0x2CF52C0", VA = "0x182CF68C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x357F9D0", Offset = "0x357E3D0", VA = "0x18357F9D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int JJINKJIBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x35807E0", Offset = "0x357F1E0", VA = "0x1835807E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int CMKLLLCOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x27BEE30", Offset = "0x27BD830", VA = "0x1827BEE30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x3580830", Offset = "0x357F230", VA = "0x183580830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x357F4C0", Offset = "0x357DEC0", VA = "0x18357F4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> DNIFLPOBKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x3580690", Offset = "0x357F090", VA = "0x183580690")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x35808F0", Offset = "0x357F2F0", VA = "0x1835808F0")]
	public HEFEHBFLBJH(int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x357F980", Offset = "0x357E380", VA = "0x18357F980")]
	public T DAGKHIGBMKO(int EGNHJGKABLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x357F500", Offset = "0x357DF00", VA = "0x18357F500")]
	public void BPKBEGFGHID(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x357F810", Offset = "0x357E210", VA = "0x18357F810")]
	public void CNLOOLKEGEC(Span<T> BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x357F190", Offset = "0x357DB90", VA = "0x18357F190")]
	public void AGMLDLCGDGN(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x357FC50", Offset = "0x357E650", VA = "0x18357FC50")]
	private void HKOAAAHAEOP(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x35800A0", Offset = "0x357EAA0", VA = "0x1835800A0")]
	public void JHAKILBFFKF(Span<T> BNJGAHEFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x357FE40", Offset = "0x357E840", VA = "0x18357FE40")]
	public void IFBMNDOAGOK(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x357F2A0", Offset = "0x357DCA0", VA = "0x18357F2A0")]
	public void AGPAMOFMIOH(int HOOEGCCNGHE, int FHNIHLGHOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x3580630", Offset = "0x357F030", VA = "0x183580630")]
	public void MDGCJLLGPHG(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x357EF80", Offset = "0x357D980", VA = "0x18357EF80")]
	public void AALDKJEFAAP(int HOOEGCCNGHE, int FHNIHLGHOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x357FEA0", Offset = "0x357E8A0", VA = "0x18357FEA0")]
	public void IMFLLMIHACN(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x3580370", Offset = "0x357ED70", VA = "0x183580370")]
	public void LAAFGIGGPPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x35802E0", Offset = "0x357ECE0", VA = "0x1835802E0")]
	public int JPAOIDBBCIF(T LPJDDLMPNCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x357FBF0", Offset = "0x357E5F0", VA = "0x18357FBF0")]
	public bool GMBMHDKFMPB(T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x357FBA0", Offset = "0x357E5A0", VA = "0x18357FBA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x3580880", Offset = "0x357F280", VA = "0x183580880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x357FDD0", Offset = "0x357E7D0", VA = "0x18357FDD0")]
	public static Span<T> HPHCHABBDNG(global::HEFEHBFLBJH<T> BDHPAGCMKHB)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x357F570", Offset = "0x357DF70", VA = "0x18357F570")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CJJPFPPEHHF(int LPJDDLMPNCG, int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void CLAEGEOCGIN(int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x357F6B0", Offset = "0x357E0B0", VA = "0x18357F6B0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CLAEGEOCGIN(int OEMPOIHBNFL, int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x357FF60", Offset = "0x357E960", VA = "0x18357FF60")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void IODMPIPCPDC(int LPJDDLMPNCG, int OEMPOIHBNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x3580430", Offset = "0x357EE30", VA = "0x183580430")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void LOKLOLOCMAH(int HOOEGCCNGHE, int FHNIHLGHOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x357FA60", Offset = "0x357E460", VA = "0x18357FA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3015EC0", Offset = "0x30148C0", VA = "0x183015EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> LAAACCFEMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0xC32FD0", Offset = "0xC319D0", VA = "0x180C32FD0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray MIBOBNDGGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool AMOPNJPCIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x3015E10", Offset = "0x3014810", VA = "0x183015E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x3015F70", Offset = "0x3014970", VA = "0x183015F70")]
	public HIEGLBAPNMB(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x3015ED0", Offset = "0x30148D0", VA = "0x183015ED0")]
	public Entity JMIOABGPGOA(int EGNHJGKABLC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x3015E30", Offset = "0x3014830", VA = "0x183015E30")]
	public Transform GEBNBHFHKBB(int EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x3015F20", Offset = "0x3014920", VA = "0x183015F20")]
	public void NMGICPLAADH(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x3015C80", Offset = "0x3014680", VA = "0x183015C80")]
	public int AGMLDLCGDGN(Transform CACALPHNCBH, Entity LCLDFKAJPDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x3015E40", Offset = "0x3014840", VA = "0x183015E40")]
	public int IFBMNDOAGOK(int EGNHJGKABLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x3015D90", Offset = "0x3014790", VA = "0x183015D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x3015D50", Offset = "0x3014750", VA = "0x183015D50")]
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
	[Cpp2IlInjected.Address(RVA = "0x3023D10", Offset = "0x3022710", VA = "0x183023D10")]
	public JIDPFHKCIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x30234E0", Offset = "0x3021EE0", VA = "0x1830234E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x30235E0", Offset = "0x3021FE0", VA = "0x1830235E0")]
	public void EFMALMFMJGL(Type OGILDIMGIOH, HAMGOKKMMPI LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x30239E0", Offset = "0x30223E0", VA = "0x1830239E0")]
	public HAMGOKKMMPI MKLBNKEKMJE(Type OGILDIMGIOH)
	{
		return default(HAMGOKKMMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x3023940", Offset = "0x3022340", VA = "0x183023940")]
	private NativeArray<byte> KEAPDLLIILM(int2 OBGFBPBPFBM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x3023540", Offset = "0x3021F40", VA = "0x183023540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x3023820", Offset = "0x3022220", VA = "0x183023820", Slot = "1")]
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
	[Cpp2IlInjected.Address(RVA = "0x31FDBA0", Offset = "0x31FC5A0", VA = "0x1831FDBA0")]
	internal static void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void EFMALMFMJGL<T>(T LPJDDLMPNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x31FDC10", Offset = "0x31FC610", VA = "0x1831FDC10")]
	public static void EFMALMFMJGL(Type OGILDIMGIOH, HAMGOKKMMPI LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T MKLBNKEKMJE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x31FDCB0", Offset = "0x31FC6B0", VA = "0x1831FDCB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x31FF300", Offset = "0x31FDD00", VA = "0x1831FF300", Slot = "4")]
	public bool Equals(LinkedEntityGroup GKBCEINHOJB, LinkedEntityGroup LAMHEDHCIJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x31FF320", Offset = "0x31FDD20", VA = "0x1831FF320", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup NBNOMDAKOCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public BNOMAFMOKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class LEKCMOIFDJC
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("DEBUG_BUILD")]
	public static void DEKJNLGBJMC(in Vector3 PICDPPHNNLH, in Quaternion IHCJBCJFELL, in Vector3 AFPPFOOOELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("DEBUG_BUILD")]
	public static void MLNIKCAHIMN(in Vector3 PEMADDOMMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("DEBUG_BUILD")]
	public static void MIHCFEKNPJO(in Quaternion IHCJBCJFELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("DEBUG_BUILD")]
	public static void FKHACOJEBOB(in Vector3 JJGPMNKMNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("DEBUG_BUILD")]
	public static void KDENKEMFDDK(in Vector3 JJGPMNKMNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("DEBUG_BUILD")]
	public static void CAHEOEILNAF(in float NKEPFBEFOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x2B25310", Offset = "0x2B23D10", VA = "0x182B25310")]
	[Conditional("DEBUG_BUILD")]
	public static void LBDEMIFKHGH(in float3 LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("DEBUG_BUILD")]
	public static void DINAOCNANKJ(in float LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x2B25210", Offset = "0x2B23C10", VA = "0x182B25210")]
	[Conditional("DEBUG_BUILD")]
	public static void DINAOCNANKJ(in Vector3 LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x2B25260", Offset = "0x2B23C60", VA = "0x182B25260")]
	[Conditional("DEBUG_BUILD")]
	public static void DINAOCNANKJ(in Quaternion LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x2B25300", Offset = "0x2B23D00", VA = "0x182B25300")]
	[Conditional("DEBUG_BUILD")]
	public static void KJOKPEHPPDA(in float LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x2B252C0", Offset = "0x2B23CC0", VA = "0x182B252C0")]
	[Conditional("DEBUG_BUILD")]
	public static void KJOKPEHPPDA(in Vector3 LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x2B25290", Offset = "0x2B23C90", VA = "0x182B25290")]
	[Conditional("DEBUG_BUILD")]
	public static void KJOKPEHPPDA(in Quaternion LPJDDLMPNCG, string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x3214DB0", Offset = "0x32137B0", VA = "0x183214DB0")]
	public EBCGMCIBBDB(Entity LCLDFKAJPDK, Entity LOFGAAGHIJI, Entity BJNIPOLNMLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x3214D50", Offset = "0x3213750", VA = "0x183214D50")]
	public static EBCGMCIBBDB HPHCHABBDNG((Entity entity, Entity oldParent, Entity newParent) HFOFEEILCNC)
	{
		return default(EBCGMCIBBDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x3214D90", Offset = "0x3213790", VA = "0x183214D90")]
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
	[Cpp2IlInjected.Address(RVA = "0xE38640", Offset = "0xE37040", VA = "0x180E38640")]
	public LBCACEFDDPD(Entity LCLDFKAJPDK, Entity GGEKFPEBLKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x2B250C0", Offset = "0x2B23AC0", VA = "0x182B250C0")]
	public static LBCACEFDDPD HPHCHABBDNG((Entity entity, Entity parent) HFOFEEILCNC)
	{
		return default(LBCACEFDDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x2B250F0", Offset = "0x2B23AF0", VA = "0x182B250F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3020810", Offset = "0x301F210", VA = "0x183020810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x39D8120", Offset = "0x39D6B20", VA = "0x1839D8120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x39D81C0", Offset = "0x39D6BC0", VA = "0x1839D81C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x39D8280", Offset = "0x39D6C80", VA = "0x1839D8280")]
	public LJANFEDEEMJ(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x39D80F0", Offset = "0x39D6AF0", VA = "0x1839D80F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x731A30", Offset = "0x730430", VA = "0x180731A30")]
	public BCAIIOMBBGG(PIJDLNNHGJO EAAMFEFLALL, int KLIKLNGCPEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x2B26A60", Offset = "0x2B25460", VA = "0x182B26A60")]
	public static BCAIIOMBBGG HPHCHABBDNG((PIJDLNNHGJO eventType, int eventIndex) GKBCEINHOJB)
	{
		return default(BCAIIOMBBGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x31FCAE0", Offset = "0x31FB4E0", VA = "0x1831FCAE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3016BC0", Offset = "0x30155C0", VA = "0x183016BC0", Slot = "5")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x3016B20", Offset = "0x3015520", VA = "0x183016B20")]
	public bool EEMPOIEDICE(in float3 BCJDHFBOOBH, in float3 MFKKMPGAJFI, float CBFODBDKBEK, Allocator FKHAEPDPDAI, out NativeArray<Entity> ABBIPALBHCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public HNAKDCLIHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x3016B20", Offset = "0x3015520", VA = "0x183016B20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x32117B0", Offset = "0x32101B0", VA = "0x1832117B0", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public DEGDBCALKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x301DD80", Offset = "0x301C780", VA = "0x18301DD80", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public IJPNANPPBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3016C10", Offset = "0x3015610", VA = "0x183016C10", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public HPCKAFJHAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class FGPJLPEHPGE : LLPKLCJBNBL
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public FGPJLPEHPGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3010D50", Offset = "0x300F750", VA = "0x183010D50", Slot = "16")]
	protected override ComponentSystemBase BDEPGHFEAKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x2B288C0", Offset = "0x2B272C0", VA = "0x182B288C0")]
	public FJLFIPEFALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[KLLNJHKGGCN(typeof(AuthoredLocalPoseData))]
public sealed class NNDEKBJMBBA : HHKFFCCLOEM
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A1D0", Offset = "0x2B28BD0", VA = "0x182B2A1D0", Slot = "8")]
	protected override bool JAPPKCEDIFG(ReadOnlySpan<AuthoredLocalPoseData> BNJGAHEFJPB, NKBHFLFMPJO JCDMDNEMCAL, out ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A110", Offset = "0x2B28B10", VA = "0x182B2A110", Slot = "9")]
	protected override bool BCGHMNNLDCA(int NHBDMCDLELK, Span<AuthoredLocalPoseData> BNJGAHEFJPB, in ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A250", Offset = "0x2B28C50", VA = "0x182B2A250")]
	public NNDEKBJMBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[KLLNJHKGGCN(typeof(LocalPoseData))]
public sealed class OFJFEJBNOBP : KCNKLMKHKBD
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x2B2BD10", Offset = "0x2B2A710", VA = "0x182B2BD10", Slot = "8")]
	protected override bool JAPPKCEDIFG(ReadOnlySpan<LocalPoseData> BNJGAHEFJPB, NKBHFLFMPJO JCDMDNEMCAL, out ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x2B2BC50", Offset = "0x2B2A650", VA = "0x182B2BC50", Slot = "9")]
	protected override bool BCGHMNNLDCA(int NHBDMCDLELK, Span<LocalPoseData> BNJGAHEFJPB, in ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x2B2BD90", Offset = "0x2B2A790", VA = "0x182B2BD90")]
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
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x2D96810", Offset = "0x2D95210", VA = "0x182D96810", Slot = "6")]
		public sealed override void MNNDBLCHNEL(CKMMIMLGKKB MIKGEIBIMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x2D95D40", Offset = "0x2D94740", VA = "0x182D95D40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x3027060", Offset = "0x3025A60", VA = "0x183027060")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x3026D10", Offset = "0x3025710", VA = "0x183026D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
